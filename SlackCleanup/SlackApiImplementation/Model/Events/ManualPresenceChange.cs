namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ManualPresenceChange : EventMessageBase
    {
        public string Presence { get; set; }
    }
}

