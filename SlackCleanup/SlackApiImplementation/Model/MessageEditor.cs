namespace SlackCleanup.SlackApiImplementation.Model
{
    public class MessageEditor : FlexibleJsonModel
    {
        public string User { get; set; }
        public string Ts { get; set; }
    }
}