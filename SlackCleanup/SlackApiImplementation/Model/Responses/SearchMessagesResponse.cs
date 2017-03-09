using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class SearchMessagesResponse : FlexibleJsonModel
    {
        public List<SearchMessageMatch> Matches { get; set; }
        public PagingSettings Paging { get; set; }
    }
}