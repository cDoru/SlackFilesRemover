using System;
using SlackCleanup.SlackApiImplementation.Model;
using SlackCleanup.SlackApiImplementation.Model.Events;

namespace SlackCleanup.SlackApiImplementation
{
    public class RtmApi : IRtmApi
    {
        private readonly IRequestHandler _request;

        public RtmApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public RtmStartResponse Start()
        {
            var response = _request.ExecuteAndDeserializeRequest<RtmStartResponse>("/rtm.start");

            if (response != null)
                response.Type = EventType.RtmStart;

            return response;
        }
    }
}
