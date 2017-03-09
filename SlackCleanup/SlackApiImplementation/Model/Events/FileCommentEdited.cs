namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileCommentEdited : EventMessageBase
    {
        public File File { get; set; }
        public ItemComment Comment { get; set; }
        public string EventTs { get; set; }
    }
}

