namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelLeft : EventMessageBase
    {
        public string Channel { get; set; }
    }
}
