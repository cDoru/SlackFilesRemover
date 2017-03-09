namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class PresenceResponse : ResponseBase
    {
        public string Presence { get; set; }
        public bool Online { get; set; }
        public bool AutoAway { get; set; }
        public bool ManualAway { get; set; }
        public int ConnectionCount { get; set; }
        public int LastActivity { get; set; }
    }
}
