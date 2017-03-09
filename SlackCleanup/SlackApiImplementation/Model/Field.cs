namespace SlackCleanup.SlackApiImplementation.Model
{
    public class Field : FlexibleJsonModel
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public bool Short { get; set; }
    }
}
