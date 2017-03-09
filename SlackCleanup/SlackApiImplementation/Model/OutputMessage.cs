namespace SlackCleanup.SlackApiImplementation.Model
{
    public class OutputMessage
    {
        private string _type = "message";
        public long Id { get; set; }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Channel { get; set; }
        public string Text { get; set; }
    }
}
