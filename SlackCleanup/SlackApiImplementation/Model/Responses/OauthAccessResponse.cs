namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class OauthAccessResponse : ResponseBase
    {
        public string AccessToken { get; set; }
        public string Scope { get; set; }
    }
}
