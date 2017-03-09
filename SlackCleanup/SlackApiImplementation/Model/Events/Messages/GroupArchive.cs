using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Events.Messages
{
    public class GroupArchive : MessageBase
    {
        public List<string> Members { get; set; }
    }
}

