namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class TeamJoin : EventMessageBase
    {
        public User User { get; set; }
        public string CacheTs { get; set; }
    }
}

