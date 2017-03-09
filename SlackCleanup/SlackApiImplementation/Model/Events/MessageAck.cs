namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class MessageAck : EventMessageBase
    {
        public bool Ok { get; set; }
        public long ReplyTo { get; set; }
        public string Ts { get; set; }
        public string Text { get; set; }
    }
}

