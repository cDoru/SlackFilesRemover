using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using RestSharp;
using SlackCleanup.SlackApiImplementation.Json;
using SlackCleanup.SlackApiImplementation.Model.Requests;

namespace SlackCleanup.SlackApiImplementation
{
    public class RestSharpRequestHandler : IRequestHandler
    {
        private readonly string _apiKey;

        private IRestClient RestClient { get; set; }
        public IResponseParser ResponseParser { get; set; } 

        public RestSharpRequestHandler(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException("apiKey");
            RestClient = new RestClient("https://slack.com/api");
            ResponseParser = new ResponseParser();
            _apiKey = apiKey;
        }

        public Dictionary<string, string> BuildRequestParams<T>(T requestParamsObject)
        {
            if (requestParamsObject == null)
                return new Dictionary<string, string>();

            var requestParams = new Dictionary<string, string>();
            var publicProps = typeof(T).GetProperties();

            foreach (var paramProp in publicProps)
            {
                // TODO: maybe easier to whitelist types instead of blacklist
                if (paramProp.PropertyType.IsAssignableFrom(typeof(byte[])))
                    continue;

                var key = paramProp.Name.ToDelimitedString('_');
                object value = paramProp.GetMethod.Invoke(requestParamsObject, null);

                if (value == null)
                    continue;

                var stringValue = value.ToString();

                if (value is bool)
                    stringValue = stringValue.ToLower();
                else if (value.GetType().IsEnum)
                    stringValue = stringValue.ToDelimitedString('_');
                else if (!value.GetType().IsPrimitive && !(value is string))
                    stringValue = ResponseParser.SerializeMessage(value);

                requestParams.Add(key, stringValue);
            }

            return requestParams;
        }

        public string BuildApiPath(string apiPath, params Expression<Func<string, object>>[] queryParamParts)
        {
            if (queryParamParts == null)
                return apiPath;

            var queryParams = new List<string>();

            foreach (var paramPart in queryParamParts)
            {
                var key = paramPart.Parameters[0].Name;
                var value = paramPart.Compile().Invoke("");

                if (value == null)
                    continue;

                if (value is bool || value is bool?)
                    value = value.ToString().ToLower();

                queryParams.Add(string.Format("{0}={1}", key, Uri.EscapeDataString(value.ToString())));
            }

            if (queryParams.Count < 1)
                return apiPath;

            return string.Format("{0}?", apiPath) + string.Join("&", queryParams);
        }

        public T ExecuteAndDeserializeRequest<T>(string apiPath, Dictionary<string, string> parameters = null, HttpMethod method = HttpMethod.POST, FileUploadRequest file = null)
        {
            var response = ExecuteRequest(apiPath, parameters, method, file);

            // TODO: handle error response

            var result = ResponseParser.Deserialize<T>(response.Content);

            return result;
        }

        private IRestResponse ExecuteRequest(string apiPath, Dictionary<string, string> parameters = null, HttpMethod method = HttpMethod.POST, FileUploadRequest file = null)
        {
            var request = new RestRequest(apiPath, (Method)Enum.Parse(typeof(Method), method.ToString()));
            request.AddParameter("token", _apiKey);

            if (file != null)
                request.AddFile("file", file.FileData, file.Filename);

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    if (parameter.Value == null)
                        continue;

                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }

            return RestClient.Execute(request);
        }
    }
}
