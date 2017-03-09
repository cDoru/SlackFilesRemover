using System;
using System.Collections.Generic;
using System.Linq;
using SlackCleanup.SlackApiImplementation.Model.Responses;

namespace SlackCleanup.SlackApiImplementation
{
    public class ApiApi : IApiApi
    {
        private readonly IRequestHandler _request;

        public ApiApi(IRequestHandler requestHandler)
        {
            if (requestHandler == null)
                throw new ArgumentNullException("requestHandler");

            _request = requestHandler;
        }

        public ApiTestResponse Test(string error = null, params string[] args)
        {
            var queryParams = new List<string>();

            if (error != null)
                queryParams.Add(string.Format("error={0}", Uri.EscapeDataString(error)));

            int argIndex = 1;

            foreach (var arg in args ?? Enumerable.Empty<string>())
            {
                queryParams.Add(string.Format("arg{0}={1}", argIndex++, Uri.EscapeDataString(arg)));
            }

            var request = "/api.test?" + string.Join("&", queryParams);

            var response = _request.ExecuteAndDeserializeRequest<ApiTestResponse>(request);

            return response;
        }
    }
}
