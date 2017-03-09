namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupClose : EventMessageBase
    {
        public string User { get; set; }
        public string Channel { get; set; }
    }
}

