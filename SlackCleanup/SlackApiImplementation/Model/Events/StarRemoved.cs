namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class StarRemoved : EventMessageBase
    {
        public string User { get; set; }
        public Item Item { get; set; }
        public string EventTs { get; set; }
    }
}

