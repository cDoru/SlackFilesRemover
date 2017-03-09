using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SlackCleanup.SlackApiImplementation.Json;
using SlackCleanup.SlackApiImplementation.Model.Requests;

namespace SlackCleanup.SlackApiImplementation
{
    public interface IRequestHandler
    {
        IResponseParser ResponseParser { get; set; }

        Dictionary<string, string> BuildRequestParams<T>(T requestParamsObject);
        string BuildApiPath(string apiPath, params Expression<Func<string, object>>[] queryParamParts);
        T ExecuteAndDeserializeRequest<T>(string apiPath, Dictionary<string, string> parameters = null, HttpMethod method = HttpMethod.POST, FileUploadRequest file = null);
    }
}
