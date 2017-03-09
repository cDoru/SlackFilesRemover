namespace SlackCleanup.SlackApiImplementation.Model
{
    public class ItemComment : FlexibleJsonModel
    {
        public string Id { get; set; }
        public string Timestamp { get; set; }
        public string Created { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
    }
}
