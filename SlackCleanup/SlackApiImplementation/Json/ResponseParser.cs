using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SlackCleanup.SlackApiImplementation.Model.Events;
using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Json
{
    public class ResponseParser : IResponseParser
    {
        private readonly JsonSerializer _jsonSerializer;
        private readonly JsonSerializerSettings _serializerSettings;

        public ResponseParser()
        {
            _serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new LowerCaseDelimitedPropertyNamesContractResolver('_'),
                Converters = new List<JsonConverter> { new UnderscoreEnumTypeConverter() }
            };

            _jsonSerializer = JsonSerializer.Create(_serializerSettings);
        }

        public string SerializeMessage(object message)
        {
            return JsonConvert.SerializeObject(message, Formatting.None, _serializerSettings);
        }

        public IEnumerable<MessageBase> RemapMessagesToConcreteTypes(IEnumerable<MessageBase> messages)
        {
            if (messages == null)
                throw new ArgumentNullException("messages");

            foreach (var baseMessage in messages)
            {
                yield return RemapMessageToConcreteType(baseMessage);
            }
        }

        public MessageBase RemapMessageToConcreteType(MessageBase baseMessage)
        {
            if (baseMessage == null)
                throw new ArgumentNullException("baseMessage");

            var concreteMessage = ParseEvent<MessageSubType>(
                                        baseMessage.UnmatchedAdditionalJsonData,
                                        baseMessage.Subtype.ToString().ToDelimitedString('_')
                                      ) as MessageBase;

            concreteMessage.Channel = baseMessage.Channel;
            concreteMessage.Subtype = baseMessage.Subtype;
            concreteMessage.Team = baseMessage.Team;
            concreteMessage.Ts = baseMessage.Ts;
            concreteMessage.Type = baseMessage.Type;
            concreteMessage.Text = baseMessage.Text;
            concreteMessage.User = baseMessage.User;

            return concreteMessage;
        }

        public T Deserialize<T>(string content)
        {
            if (content == null)
                throw new ArgumentNullException("content");
            
            return JsonConvert.DeserializeObject<T>(content, _serializerSettings);
        }

        public EventMessageBase DeserializeEvent(string content)
        {
            var jsonObject = JsonConvert.DeserializeObject(content) as JObject;
            EventMessageBase eventMessage;

            if (jsonObject != null && (string)jsonObject["type"] == "message")
            {
                eventMessage = ParseEvent<MessageSubType>(jsonObject, (string)jsonObject["subtype"] ?? "plain_message");
            }
            else if (jsonObject != null && !string.IsNullOrWhiteSpace((string)jsonObject["type"]))
            {
                eventMessage = ParseEvent<EventType>(jsonObject, (string)jsonObject["type"]);
            }
            else
            {
                eventMessage = ParseMessageResponse(jsonObject);
            }

            return eventMessage;
        }

        private EventMessageBase ParseMessageResponse(JObject jsonObject)
        {
            EventMessageBase eventMessage = null;
            var properties = jsonObject.Properties().ToList();

            if (properties.Any(p => p.Name == "ok") && properties.Any(p => p.Name == "reply_to"))
            {
                if ((bool)jsonObject["ok"])
                    eventMessage = jsonObject.ToObject<MessageAck>(_jsonSerializer);
                else
                    eventMessage = jsonObject.ToObject<MessageError>(_jsonSerializer);
            }

            return eventMessage;
        }

        private EventMessageBase ParseEvent<T>(JObject jsonObject, string typeKey)
        {
            var enumValue = UnderscoreEnumTypeConverter.FindMatchingName<T>(typeKey);
            var assemblyQualifiedName = typeof(T).AssemblyQualifiedName;
            if (assemblyQualifiedName != null)
            {
                var typeName = assemblyQualifiedName.Replace(typeof(T).Name, enumValue);

                return (jsonObject ?? new JObject()).ToObject(Type.GetType(typeName), _jsonSerializer) as EventMessageBase;
            }

            throw new Exception("AssemblyQualifiedName null");
        }
    }
}
