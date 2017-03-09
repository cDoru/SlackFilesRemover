using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class FileResponse : ResponseBase
    {
        public File File { get; set; }
        public List<ItemComment> Comments { get; set; }
        public PagingSettings Paging { get; set; }
    }
}
