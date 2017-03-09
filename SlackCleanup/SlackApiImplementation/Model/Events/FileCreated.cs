namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class FileCreated : EventMessageBase
    {
        public File File { get; set; }
    }
}

