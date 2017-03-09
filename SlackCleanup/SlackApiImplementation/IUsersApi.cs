using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IUsersApi
    {
        PresenceResponse GetPresence(string userId);
        UserResponse Info(string userId);
        UsersResponse List();
        ResponseBase SetActive();
        ResponseBase SetPresence(string presenceValue = "auto");
    }
}
