namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class PrefChange : EventMessageBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}

