namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ResponseBase : FlexibleJsonModel
    {
        public bool Ok { get; set; }
        public string Error { get; set; }
    }
}
