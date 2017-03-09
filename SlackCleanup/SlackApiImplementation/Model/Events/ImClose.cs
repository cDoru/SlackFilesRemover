namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ImClose : EventMessageBase
    {
        public string User { get; set; }
        public string Channel { get; set; }
    }
}

