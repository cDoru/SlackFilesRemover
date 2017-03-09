namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class UserTyping : EventMessageBase
    {
        public string Channel { get; set; }
        public string User { get; set; }
    }
}
