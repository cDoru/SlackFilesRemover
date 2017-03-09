using System;
using System.Linq;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class ChannelsApi : IChannelsApi
    {
        private readonly IRequestHandler _request;

        public ChannelsApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public ResponseBase Archive(string channelId)
        {
            var apiPath = _request.BuildApiPath("/channels.archive", channel => channelId);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public ChannelResponse Create(string channelName)
        {
            var apiPath = _request.BuildApiPath("/channels.create", name => channelName);
            var response = _request.ExecuteAndDeserializeRequest<ChannelResponse>(apiPath);

            return response;
        }

        public MessagesResponse History(string channelId, string latestTs = null,
            string oldestTs = null, bool isInclusive = false, int messageCount = 100)
        {
            var apiPath = _request.BuildApiPath("/channels.history",
                                        channel => channelId,
                                        latest => latestTs,
                                        oldest => oldestTs,
                                        inclusive => isInclusive ? "1" : "0",
                                        count => messageCount.ToString());

            var response = _request.ExecuteAndDeserializeRequest<MessagesResponse>(apiPath);

            if (response.Messages != null)
            {
                response.Messages = _request.ResponseParser.RemapMessagesToConcreteTypes(response.Messages)
                                                       .ToList();
            }

            return response;
        }

        public ChannelResponse Info(string channelId)
        {
            var apiPath = _request.BuildApiPath("/channels.info", channel => channelId);
            var response = _request.ExecuteAndDeserializeRequest<ChannelResponse>(apiPath);

            return response;
        }

        public ChannelResponse Invite(string channelId, string userId)
        {
            var apiPath = _request.BuildApiPath("/channels.invite", channel => channelId, user => userId);
            var response = _request.ExecuteAndDeserializeRequest<ChannelResponse>(apiPath);

            return response;
        }

        public ChannelResponse Join(string channelName)
        {
            var apiPath = _request.BuildApiPath("/channels.join", name => channelName);
            var response = _request.ExecuteAndDeserializeRequest<ChannelResponse>(apiPath);

            return response;
        }

        public ResponseBase Kick(string channelId, string userId)
        {
            var apiPath = _request.BuildApiPath("/channels.kick", channel => channelId, user => userId);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public LeaveChannelResponse Leave(string channelId)
        {
            var apiPath = _request.BuildApiPath("/channels.leave", channel => channelId);
            var response = _request.ExecuteAndDeserializeRequest<LeaveChannelResponse>(apiPath);

            return response;
        }

        public ChannelsResponse List(bool excludeArchived = false)
        {
            var apiPath = _request.BuildApiPath("/channels.list", exclude_archived => excludeArchived ? "1" : "0");
            var response = _request.ExecuteAndDeserializeRequest<ChannelsResponse>(apiPath);

            return response;
        }

        public ResponseBase Mark(string channelId, string timestamp)
        {
            var apiPath = _request.BuildApiPath("/channels.mark", channel => channelId, ts => timestamp);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }

        public ChannelResponse Rename(string channelId, string channelName)
        {
            var apiPath = _request.BuildApiPath("/channels.rename", channel => channelId, name => channelName);
            var response = _request.ExecuteAndDeserializeRequest<ChannelResponse>(apiPath);

            return response;
        }

        public PurposeResponse SetPurpose(string channelId, string channelPurpose)
        {
            var apiPath = _request.BuildApiPath("/channels.setPurpose", channel => channelId, purpose => channelPurpose);
            var response = _request.ExecuteAndDeserializeRequest<PurposeResponse>(apiPath);

            return response;
        }

        public TopicResponse SetTopic(string channelId, string channelTopic)
        {
            var apiPath = _request.BuildApiPath("/channels.setTopic", channel => channelId, topic => channelTopic);
            var response = _request.ExecuteAndDeserializeRequest<TopicResponse>(apiPath);

            return response;
        }

        public ResponseBase Unarchive(string channelId)
        {
            var apiPath = _request.BuildApiPath("/channels.unarchive", channel => channelId);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }
    }
}
