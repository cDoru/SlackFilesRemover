using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class TeamAccessLogs : ResponseBase
    {
        public List<TeamAccessLog> Logins { get; set; }
        public PagingSettings Paging { get; set; }
    }
}
