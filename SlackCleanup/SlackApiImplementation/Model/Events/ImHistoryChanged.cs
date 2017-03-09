namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ImHistoryChanged : EventMessageBase
    {
        public string Latest { get; set; }
        public string Ts { get; set; }
        public string EventTs { get; set; }
    }
}

