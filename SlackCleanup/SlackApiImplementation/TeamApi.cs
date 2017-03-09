using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class TeamApi : ITeamApi
    {
        private readonly IRequestHandler _request;

        public TeamApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public TeamAccessLogs AccessLogs(int? messageCount = null, int? pageNumber = null)
        {
            var apiPath = _request.BuildApiPath("/team.accessLogs", count => messageCount, page => pageNumber);
            var response = _request.ExecuteAndDeserializeRequest<TeamAccessLogs>(apiPath);

            return response;
        }

        public TeamResponse Info()
        {
            var response = _request.ExecuteAndDeserializeRequest<TeamResponse>("/team.info");

            return response;
        }
    }
}
