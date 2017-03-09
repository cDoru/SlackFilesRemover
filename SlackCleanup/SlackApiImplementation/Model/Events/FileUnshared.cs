namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileUnshared : EventMessageBase
    {
        public File File { get; set; }
    }
}

