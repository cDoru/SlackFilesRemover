namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class BotMessage : MessageBase
    {
        public string BotId { get; set; }
        public string Username { get; set; }
        public BotIcons Icons { get; set; }
    }
}

