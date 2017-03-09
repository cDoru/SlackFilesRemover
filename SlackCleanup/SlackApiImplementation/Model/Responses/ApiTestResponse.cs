using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model.Responses
{
    public class ApiTestResponse : ResponseBase
    {
        public IDictionary<string, string> Args { get; set; }
    }
}
