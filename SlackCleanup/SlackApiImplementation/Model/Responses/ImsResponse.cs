using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ImsResponse : ResponseBase
    {
        public List<DirectMessageChannel> Ims { get; set; }
    }
}
