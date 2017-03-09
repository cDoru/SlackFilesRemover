namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class MessageError : EventMessageBase
    {
        public bool Ok { get; set; }
        public long ReplyTo { get; set; }
        public Error Error { get; set; }
    }
}

