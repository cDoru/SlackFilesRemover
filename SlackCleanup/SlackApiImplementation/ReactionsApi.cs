using System;
using SlackCleanup.SlackApiImplementation.Model;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class ReactionsApi : IReactionsApi
    {
        private readonly IRequestHandler _request;

        public ReactionsApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public ResponseBase Add(string reaction, string fileId = null, string commentId = null, string channelId = null, string ts = null)
        {
            var apiPath = _request.BuildApiPath("/reactions.add",
                                        name => reaction,
                                        file => fileId,
                                        fileComment => commentId,
                                        channel => channelId,
                                        timestamp => ts);

            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public ReactionItem Get(string fileId = null, string commentId = null, string channelId = null, string ts = null, bool? fullResults = null)
        {
            var apiPath = _request.BuildApiPath("/reactions.get",
                                        file => fileId,
                                        fileComment => commentId,
                                        channel => channelId,
                                        timestamp => ts,
                                        full => fullResults);

            var response = _request.ExecuteAndDeserializeRequest<ReactionItem>(apiPath);

            return response;
        }

        public ReactionListResponse List(string userId = null, bool? fullResults = null, int? reactionCount = null, int? pageNumber = null)
        {
            var apiPath = _request.BuildApiPath("/reactions.list",
                                        user => userId,
                                        full => fullResults,
                                        page => pageNumber,
                                        count => reactionCount);

            var response = _request.ExecuteAndDeserializeRequest<ReactionListResponse>(apiPath);

            return response;
        }

        public ResponseBase Remove(string reaction, string fileId = null, string commentId = null, string channelId = null, string ts = null)
        {
            var apiPath = _request.BuildApiPath("/reactions.remove",
                                        name => reaction,
                                        file => fileId,
                                        fileComment => commentId,
                                        channel => channelId,
                                        timestamp => ts);

            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }
    }
}
