namespace SlackCleanup.SlackApiImplementation.Model.Requests
{
    public class FileUploadRequest
    {
        public byte[] FileData { get; set; }
        public string Filetype { get; set; }
        public string Filename { get; set; }
        public string Title { get; set; }
        public string InitialComment { get; set; }
        public string Channels { get; set; }
    }
}
