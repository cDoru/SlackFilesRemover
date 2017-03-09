namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileCommentAdded : EventMessageBase
    {
        public File File { get; set; }
        public ItemComment Comment { get; set; }
    }
}

