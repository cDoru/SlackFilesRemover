using System;
using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class ChatApi : IChatApi
    {
        private readonly IRequestHandler _request;

        public ChatApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public ChatDeleteResponse Delete(string channelId, string timestamp)
        {
            var apiPath = _request.BuildApiPath("/chat.delete", channel => channelId, ts => timestamp);
            var response = _request.ExecuteAndDeserializeRequest<ChatDeleteResponse>(apiPath);

            return response;
        }

        public MessageResponse PostMessage(PostMessageRequest request)
        {
            var requestParams = _request.BuildRequestParams(request);
            var response = _request.ExecuteAndDeserializeRequest<MessageResponse>("/chat.postMessage", requestParams);

            if (response.Ok)
                response.Message = _request.ResponseParser.RemapMessageToConcreteType(response.Message);

            return response;
        }

        public ChatUpdateResponse Update(string channelId, string timestamp, string updatedText)
        {
            var apiPath = _request.BuildApiPath("/chat.update", channel => channelId, ts => timestamp, text => updatedText);
            var response = _request.ExecuteAndDeserializeRequest<ChatUpdateResponse>(apiPath);

            return response;
        }
    }
}
