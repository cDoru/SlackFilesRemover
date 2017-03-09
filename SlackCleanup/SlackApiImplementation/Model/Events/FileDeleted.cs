namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileDeleted : EventMessageBase
    {
        public string FileId { get; set; }
        public string EventTs { get; set; }
    }
}

