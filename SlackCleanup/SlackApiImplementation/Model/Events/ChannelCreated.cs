namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelCreated : EventMessageBase
    {
        public Channel Channel { get; set; }
    }
}
