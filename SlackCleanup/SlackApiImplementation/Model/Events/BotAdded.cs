namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class BotAdded : EventMessageBase
    {
        public BotModel Bot { get; set; }
        public string CacheTs { get; set; }
    }
}

