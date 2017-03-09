using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class MessageResponse : ResponseBase
    {
        public string Ts { get; set; }
        public string Channel { get; set; }
        public MessageBase Message { get; set; }
    }
}
