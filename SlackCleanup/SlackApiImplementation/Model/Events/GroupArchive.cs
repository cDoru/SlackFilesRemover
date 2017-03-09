namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupArchive : EventMessageBase
    {
        public string Channel { get; set; }
    }
}

