using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class StarItemResponse : FlexibleJsonModel
    {
        public StarItemType Type { get; set; }
        public string Channel { get; set; }
        public MessageBase Message { get; set; }
        public File File { get; set; }
        public FileComment Comment { get; set; }
        public string Group { get; set; }
    }
}