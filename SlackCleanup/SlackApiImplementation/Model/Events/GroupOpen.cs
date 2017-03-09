namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupOpen : EventMessageBase
    {
        public string User { get; set; }
        public string Channel { get; set; }
    }
}

