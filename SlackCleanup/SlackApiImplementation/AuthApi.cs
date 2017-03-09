using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class AuthApi : IAuthApi
    {
        private readonly IRequestHandler _request;

        public AuthApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public AuthTestResponse Test()
        {
            var response = _request.ExecuteAndDeserializeRequest<AuthTestResponse>("/auth.test");

            return response;
        }
    }
}
