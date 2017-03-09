using SlackCleanup.SlackApiImplementation.Model.Events;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public class EditedMessage : FlexibleJsonModel
    {
        public EventType Type { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public string Ts { get; set; }
        public MessageEditor Edited { get; set; }
    }
}
