namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelUnarchive : EventMessageBase
    {
        public string Channel { get; set; }
        public string User { get; set; }
    }
}
