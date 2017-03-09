using System.Collections.Generic;
using SlackCleanup.SlackApiImplementation.Model.Events;
using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Json
{
    public interface IResponseParser
    {
        EventMessageBase DeserializeEvent(string content);
        T Deserialize<T>(string content);
        string SerializeMessage(object message);
        IEnumerable<MessageBase> RemapMessagesToConcreteTypes(IEnumerable<MessageBase> messages);
        MessageBase RemapMessageToConcreteType(MessageBase baseMessage);
    }
}