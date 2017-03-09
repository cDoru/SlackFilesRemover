using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class StarsApi : IStarsApi
    {
        private readonly IRequestHandler _request;

        public StarsApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public StarsResponse List(string userId = null, int? messageCount = null, int? pageNumber = null)
        {
            var apiPath = _request.BuildApiPath("/stars.list",
                                        user => userId,
                                        count => messageCount,
                                        page => pageNumber);

            var response = _request.ExecuteAndDeserializeRequest<StarsResponse>(apiPath);

            return response;
        }
    }
}
