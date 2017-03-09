namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public abstract class EventMessageBase :  FlexibleJsonModel
    {
        public EventType Type { get; set; }
    }
}
