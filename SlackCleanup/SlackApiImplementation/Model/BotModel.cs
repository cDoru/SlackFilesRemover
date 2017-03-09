namespace SlackCleanup.SlackApiImplementation.Model
{
    public class BotModel : FlexibleJsonModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public BotIcons Icons { get; set; }
        public bool Deleted { get; set; }
    }
}
