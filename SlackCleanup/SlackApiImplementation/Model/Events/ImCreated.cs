namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ImCreated : EventMessageBase
    {
        public string User { get; set; }
        public DirectMessageChannel Channel { get; set; }
    }
}

