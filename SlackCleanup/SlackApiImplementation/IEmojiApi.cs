using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IEmojiApi
    {
        EmojiResponse List();
    }
}
