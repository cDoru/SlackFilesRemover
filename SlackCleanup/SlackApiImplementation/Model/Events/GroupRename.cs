namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupRename : EventMessageBase
    {
        public Group Channel { get; set; }
    }
}

