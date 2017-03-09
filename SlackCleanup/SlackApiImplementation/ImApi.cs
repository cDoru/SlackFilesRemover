using System;
using System.Linq;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class ImApi : IImApi
    {
        private readonly IRequestHandler _request;

        public ImApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public CloseResponse Close(string imId)
        {
            var apiPath = _request.BuildApiPath("/im.close", channel => imId);
            var response = _request.ExecuteAndDeserializeRequest<CloseResponse>(apiPath);

            return response;
        }

        public MessagesResponse History(string imId, string latestTs = null,
            string oldestTs = null, bool isInclusive = false, int messageCount = 100)
        {
            var apiPath = _request.BuildApiPath("/im.history",
                                        channel => imId,
                                        latest => latestTs,
                                        oldest => oldestTs,
                                        inclusive => isInclusive ? "1" : "0",
                                        count => messageCount.ToString());

            var response = _request.ExecuteAndDeserializeRequest<MessagesResponse>(apiPath);

            if (response.Messages != null)
            {
                response.Messages = _request.ResponseParser.RemapMessagesToConcreteTypes(response.Messages)
                                                       .ToList();
            }

            return response;
        }

        public ImsResponse List(bool excludeArchived = false)
        {
            var apiPath = _request.BuildApiPath("/im.list", exclude_archived => excludeArchived ? "1" : "0");
            var response = _request.ExecuteAndDeserializeRequest<ImsResponse>(apiPath);

            return response;
        }

        public ResponseBase Mark(string imId, string timestamp)
        {
            var apiPath = _request.BuildApiPath("/im.mark", channel => imId, ts => timestamp);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public ImOpenResponse Open(string userId)
        {
            var apiPath = _request.BuildApiPath("/im.open", user => userId);
            var response = _request.ExecuteAndDeserializeRequest<ImOpenResponse>(apiPath);

            return response;
        }
    }
}
