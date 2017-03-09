using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class EmojiResponse : ResponseBase
    {
        public Dictionary<string, string> Emoji { get; set; }
    }
}
