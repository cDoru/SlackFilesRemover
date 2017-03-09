namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ReactionRemoved : EventMessageBase
    {
        public string User { get; set; }
        public string Reaction { get; set; }
        public string EventTs { get; set; }
        public ReactionItem Item { get; set; }
    }
}

