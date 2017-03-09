namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileShared : EventMessageBase
    {
        public File File { get; set; }
        public string EventTs { get; set; }
    }
}

