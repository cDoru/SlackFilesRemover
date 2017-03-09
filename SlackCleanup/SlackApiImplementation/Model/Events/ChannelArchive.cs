namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelArchive : EventMessageBase
    {
        public string Channel { get; set; }
        public string User { get; set; }
    }
}
