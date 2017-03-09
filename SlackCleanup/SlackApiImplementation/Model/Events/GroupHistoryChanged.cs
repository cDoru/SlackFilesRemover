namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupHistoryChanged : EventMessageBase
    {
        public string Latest { get; set; }
        public string Ts { get; set; }
        public string EventTs { get; set; }
    }
}

