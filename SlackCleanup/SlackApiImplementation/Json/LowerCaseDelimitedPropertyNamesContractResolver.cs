using Newtonsoft.Json.Serialization;

namespace SlackCleanup.SlackApiImplementation.Json
{
    public class LowerCaseDelimitedPropertyNamesContractResolver : DefaultContractResolver
    {
        private readonly char _delimiter;

        public LowerCaseDelimitedPropertyNamesContractResolver(char delimiter)
        {
            _delimiter = delimiter;
        }
        
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToDelimitedString(_delimiter);
        }
    }
}
