using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ChannelsResponse : ResponseBase
    {
        public List<Channel> Channels { get; set; }
    }
}
