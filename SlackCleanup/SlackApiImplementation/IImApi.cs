using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IImApi
    {
        CloseResponse Close(string imId);
        MessagesResponse History(string imId, string latestTs = null,
            string oldestTs = null, bool isInclusive = false, int messageCount = 100);
        ImsResponse List(bool excludeArchived = false);
        ResponseBase Mark(string imId, string timestamp);
        ImOpenResponse Open(string userId);
    }
}
