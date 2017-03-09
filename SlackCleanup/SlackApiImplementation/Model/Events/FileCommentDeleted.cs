namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileCommentDeleted : EventMessageBase
    {
        public File File { get; set; }
        public ItemComment Comment { get; set; }
    }
}

