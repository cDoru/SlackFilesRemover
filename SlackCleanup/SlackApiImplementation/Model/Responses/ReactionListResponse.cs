using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ReactionListResponse : ResponseBase
    {
        public List<ReactionItem> Items { get; set; }
        public PagingSettings Paging { get; set; }
    }
}
