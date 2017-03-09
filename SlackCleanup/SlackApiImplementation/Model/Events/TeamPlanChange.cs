namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public class TeamPlanChange : EventMessageBase
    {
        public string Plan { get; set; }
    }
}

