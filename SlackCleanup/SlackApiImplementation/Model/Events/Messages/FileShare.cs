namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class FileShare : MessageBase
    {
        public File File { get; set; }
        public bool Upload { get; set; }
    }
}

