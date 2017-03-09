using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public class Item : FlexibleJsonModel
    {
        public ItemType Type { get; set; }
        public string Channel { get; set; }
        public File File { get; set; }
        public MessageBase Message { get; set; }
        public ItemComment Comment { get; set; }
    }
}
