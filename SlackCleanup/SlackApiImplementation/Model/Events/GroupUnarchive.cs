namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupUnarchive : EventMessageBase
    {
        public string Channel { get; set; }
    }
}

