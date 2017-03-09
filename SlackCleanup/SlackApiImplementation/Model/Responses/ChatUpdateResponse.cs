namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ChatUpdateResponse : ResponseBase
    {
        public string Ts { get; set; }
        public string Channel { get; set; }
        public string Text { get; set; }
    }
}
