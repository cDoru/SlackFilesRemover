namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileChange : EventMessageBase
    {
        public File File { get; set; }
    }
}

