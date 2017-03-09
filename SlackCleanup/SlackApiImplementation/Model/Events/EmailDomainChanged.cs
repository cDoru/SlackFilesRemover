namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class EmailDomainChanged : EventMessageBase
    {
        public string EmailDomain { get; set; }
        public string EventTs { get; set; }
    }
}

