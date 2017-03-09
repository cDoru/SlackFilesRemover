namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FilePublic : EventMessageBase
    {
        public File File { get; set; }
        public string EventTs { get; set; }
    }
}

