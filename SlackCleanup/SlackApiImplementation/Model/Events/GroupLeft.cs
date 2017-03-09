namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupLeft : EventMessageBase
    {
        public Group Channel { get; set; }
    }
}

