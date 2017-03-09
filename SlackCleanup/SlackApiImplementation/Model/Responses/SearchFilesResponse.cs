using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class SearchFilesResponse : FlexibleJsonModel
    {
        public List<File> Matches { get; set; }
        public PagingSettings Paging { get; set; }
    }
}