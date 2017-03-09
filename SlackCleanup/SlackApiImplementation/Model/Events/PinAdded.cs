namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class PinAdded : EventMessageBase
    {
        public string User { get; set; }
        public string ChannelId { get; set; }
        public string EventTs { get; set; }

        // TODO ...
    }
}

