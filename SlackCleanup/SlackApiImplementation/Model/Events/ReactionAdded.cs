namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ReactionAdded : EventMessageBase
    {
        public string User { get; set; }
        public string Reaction { get; set; }
        public string EventTs { get; set; }
        public ReactionItem Item { get; set; }
    }
}

