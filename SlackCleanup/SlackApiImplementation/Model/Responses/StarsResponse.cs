using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class StarsResponse : ResponseBase
    {
        public List<StarItemResponse> Items { get; set; }
        public PagingSettings Paging { get; set; }
    }
}
