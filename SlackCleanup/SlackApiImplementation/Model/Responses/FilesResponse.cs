using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class FilesResponse : ResponseBase
    {
        public List<File> Files { get; set; }
        public PagingSettings Paging { get; set; }
    }
}
