namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class MessageDeleted : MessageBase
    {
        public bool Hidden { get; set; }
        public string DeletedTs { get; set; }
    }
}

