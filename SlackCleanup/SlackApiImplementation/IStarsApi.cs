using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IStarsApi
    {
        StarsResponse List(string userId = null, int? messageCount = null, int? pageNumber = null);
    }
}
