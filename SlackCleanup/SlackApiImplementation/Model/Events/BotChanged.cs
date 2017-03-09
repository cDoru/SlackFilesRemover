namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class BotChanged : EventMessageBase
    {
        public BotModel Bot { get; set; }
    }
}

