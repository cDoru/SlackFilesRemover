namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ImOpen : EventMessageBase
    {
        public string User { get; set; }
        public string Channel { get; set; }
    }
}

