namespace SlackCleanup.SlackApiImplementation.Model
{
    public class PagingSettings : FlexibleJsonModel
    {
        public int Count { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
    }
}
