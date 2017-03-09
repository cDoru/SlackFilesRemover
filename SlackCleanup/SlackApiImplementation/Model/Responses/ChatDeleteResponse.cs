namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ChatDeleteResponse : ResponseBase
    {
        public string Channel { get; set; }
        public string Ts { get; set; }
    }
}
