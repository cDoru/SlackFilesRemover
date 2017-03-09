namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelJoined : EventMessageBase
    {
        public Channel Channel { get; set; }
    }
}
