namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelRename : EventMessageBase
    {
        public Channel Channel { get; set; }
    }
}
