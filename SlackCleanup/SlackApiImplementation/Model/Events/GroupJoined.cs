namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupJoined : EventMessageBase
    {
        public Group Channel { get; set; }
    }
}

