using SlackCleanup.SlackApiImplementation.Model.Requests;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IChatApi
    {
        ChatDeleteResponse Delete(string channelId, string timestamp);
        MessageResponse PostMessage(PostMessageRequest request);
        ChatUpdateResponse Update(string channelId, string timestamp, string updatedText);
    }
}
