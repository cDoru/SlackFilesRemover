namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class UserChange : EventMessageBase
    {
        public User User { get; set; }
        public string CacheTs { get; set; }
    }
}

