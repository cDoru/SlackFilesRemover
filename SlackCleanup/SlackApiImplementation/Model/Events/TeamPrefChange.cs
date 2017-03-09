namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class TeamPrefChange : EventMessageBase
    {
        public string Name { get; set; }
        public bool Value { get; set; }
    }
}

