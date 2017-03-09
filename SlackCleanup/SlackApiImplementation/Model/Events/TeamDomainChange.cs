namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class TeamDomainChange : EventMessageBase
    {
        public string Url { get; set; }
        public string Domain { get; set; }
    }
}

