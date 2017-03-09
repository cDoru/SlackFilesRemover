namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ImOpenResponse : ResponseBase
    {
        public DirectMessageChannel Channel { get; set; }
        public bool NoOp { get; set; }
        public bool AlreadyOpen { get; set; }
    }
}
