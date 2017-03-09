using System;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class UsersApi : IUsersApi
    {
        private readonly IRequestHandler _request;

        public UsersApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public PresenceResponse GetPresence(string userId)
        {
            var apiPath = _request.BuildApiPath("/users.getPresence", user => userId);
            var response = _request.ExecuteAndDeserializeRequest<PresenceResponse>(apiPath);

            return response;
        }

        public UserResponse Info(string userId)
        {
            var apiPath = _request.BuildApiPath("/users.info", user => userId);
            var response = _request.ExecuteAndDeserializeRequest<UserResponse>(apiPath);

            return response;
        }

        public UsersResponse List()
        {
            var response = _request.ExecuteAndDeserializeRequest<UsersResponse>("/users.list");

            return response;
        }

        public ResponseBase SetActive()
        {
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>("/users.setActive");

            return response;
        }

        public ResponseBase SetPresence(string presenceValue = "auto")
        {
            var apiPath = _request.BuildApiPath("/users.setPresence", presence => presenceValue);
            var response = _request.ExecuteAndDeserializeRequest<ResponseBase>(apiPath);

            return response;
        }
    }
}
