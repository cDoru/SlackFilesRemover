namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class MessageChanged : MessageBase
    {
        public bool Hidden { get; set; }
        public string EventTs { get; set; }
        public EditedMessage Message { get; set; }   
    }
}

