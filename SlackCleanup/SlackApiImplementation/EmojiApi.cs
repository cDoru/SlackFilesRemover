using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class EmojiApi : IEmojiApi
    {
        private readonly IRequestHandler _request;

        public EmojiApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public EmojiResponse List()
        {
            var response = _request.ExecuteAndDeserializeRequest<EmojiResponse>("/emoji.list");

            return response;
        }
    }
}
