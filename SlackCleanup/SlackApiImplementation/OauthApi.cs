using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class OauthApi : IOauthApi
    {
        private readonly IRequestHandler _request;

        public OauthApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public OauthAccessResponse Access(string clientId, string clientSecret, string callbackCode, string redirectUri = null)
        {
            var apiPath = _request.BuildApiPath("/oauth.access", client_id => clientId, client_secret => clientSecret, code => callbackCode, redirect_uri => redirectUri);
            var response = _request.ExecuteAndDeserializeRequest<OauthAccessResponse>(apiPath);

            return response;
        }
    }
}
