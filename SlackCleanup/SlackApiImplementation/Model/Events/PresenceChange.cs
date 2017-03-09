namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class PresenceChange : EventMessageBase
    {
        public string User { get; set; }
        public string Presence { get; set; }
    }
}

