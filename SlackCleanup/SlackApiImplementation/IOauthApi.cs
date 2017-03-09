using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IOauthApi
    {
        OauthAccessResponse Access(string clientId, string clientSecret, string callbackCode, string redirectUri = null);
    }
}
