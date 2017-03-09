namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class Pong : EventMessageBase
    {
        public string ReplyTo { get; set; }
        public string Time { get; set; }
        public string Channel { get; set; }
        public string Text { get; set; }
    }
}
