using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface ITeamApi
    {
        TeamAccessLogs AccessLogs(int? messageCount = null, int? pageNumber = null);
        TeamResponse Info();
    }
}
