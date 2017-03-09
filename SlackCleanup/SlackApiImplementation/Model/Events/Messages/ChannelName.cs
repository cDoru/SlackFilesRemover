namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class ChannelName : MessageBase
    {
        public string OldName { get; set; }
        public string Name { get; set; }
    }
}

