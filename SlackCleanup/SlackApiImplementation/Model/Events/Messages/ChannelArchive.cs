using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class ChannelArchive : MessageBase
    {
        public List<string> Members { get; set; }
    }
}

