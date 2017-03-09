namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelDeleted : EventMessageBase
    {
        public string Channel { get; set; }
    }
}
