namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelHistoryChanged : EventMessageBase
    {
        public string Latest { get; set; }
        public string Ts { get; set; }
        public string EventTs { get; set; }
    }
}

