namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class SearchResponse : ResponseBase
    {
        public string Query { get; set; }
        public SearchMessagesResponse Messages { get; set; }
        public SearchFilesResponse Files { get; set; }
    }
}
