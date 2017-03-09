using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class UsersResponse : ResponseBase
    {
        public List<User> Members { get; set; }
    }
}
