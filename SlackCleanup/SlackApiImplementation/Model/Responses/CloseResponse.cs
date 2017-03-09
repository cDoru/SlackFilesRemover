namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class CloseResponse : ResponseBase
    {
        public bool NoOp { get; set; }
        public bool AlreadyClosed { get; set; }
    }
}
