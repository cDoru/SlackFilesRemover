namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class Error : EventMessageBase
    {
        public string Msg { get; set; }
        public string Code { get; set; }
    }
}
