using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class GroupsResponse : ResponseBase
    {
        public List<Group> Groups { get; set; }
    }
}
