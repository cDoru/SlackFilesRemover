namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class FileComment : MessageBase
    {
        public File File { get; set; }
        public ItemComment Comment { get; set; }
    }
}

