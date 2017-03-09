using System.Collections.Generic;
using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class MessagesResponse : ResponseBase
    {
        public string Latest { get; set; }
        public List<MessageBase> Messages { get; set; }
        public bool HasMore { get; set; }
    }
}
