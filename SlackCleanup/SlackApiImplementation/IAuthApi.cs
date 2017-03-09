using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IAuthApi
    {
        AuthTestResponse Test();
    }
}
