namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class GroupMarked : EventMessageBase
    {
        public string Channel { get; set; }
        public string Ts { get; set; }
    }
}

