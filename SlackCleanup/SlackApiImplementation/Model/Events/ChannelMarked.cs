namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ChannelMarked : EventMessageBase
    {
        public string Channel { get; set; }
        public string Ts { get; set; }
    }
}
