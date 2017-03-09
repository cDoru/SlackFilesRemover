namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class ImMarked : EventMessageBase
    {
        public string Channel { get; set; }
        public string Ts { get; set; }
    }
}

