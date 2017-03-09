namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class TeamRename : EventMessageBase
    {
        public string Name { get; set; }
    }
}

