namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class AuthTestResponse : ResponseBase
    {
        public string Url { get; set; }
        public string Team { get; set; }
        public string User { get; set; }
        public string TeamId { get; set; }
        public string UserId { get; set; }
    }
}
