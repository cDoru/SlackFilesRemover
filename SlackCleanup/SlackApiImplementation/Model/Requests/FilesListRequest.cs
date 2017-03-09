namespace SlackCleanup.SlackApiImplementation.Model.Requests
{
    public class FilesListRequest
    {
        public string User { get; set; }
        public string TsFrom { get; set; }
        public string TsTo { get; set; }
        public string Types { get; set; }
        public int? Count { get; set; }
        public int? Page { get; set; }
    }
}
