using SlackCleanup.SlackApiImplementation.Model;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IReactionsApi
    {
        ResponseBase Add(string reaction, string fileId = null, string commentId = null, string channelId = null, string ts = null);
        ReactionItem Get(string fileId = null, string commentId = null, string channelId = null, string ts = null, bool? fullResults = null);
        ReactionListResponse List(string userId = null, bool? fullResults = null, int? reactionCount = null, int? pageNumber = null);
        ResponseBase Remove(string reaction, string fileId = null, string commentId = null, string channelId = null, string ts = null);
    }
}
