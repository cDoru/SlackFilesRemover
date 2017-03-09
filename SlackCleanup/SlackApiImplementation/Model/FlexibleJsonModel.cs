using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public abstract class FlexibleJsonModel
    {
        [JsonExtensionData]
        public JObject UnmatchedAdditionalJsonData { get; set; }

        public IEnumerable<string> WalkUnmatchedData(string path = null)
        {
            if (path == null)
                path = GetType().Name;

            var unmatchedDataEntries = new List<string>();

            if (UnmatchedAdditionalJsonData != null && UnmatchedAdditionalJsonData.HasValues)
                unmatchedDataEntries.Add(string.Format("Unmatched Model Data <{0}>: {1}", path, UnmatchedAdditionalJsonData));

            foreach (var prop in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                if (prop.PropertyType.IsGenericType &&
                    typeof(FlexibleJsonModel).IsAssignableFrom(prop.PropertyType.GetGenericArguments()[0]) &&
                    typeof(IEnumerable).IsAssignableFrom(prop.PropertyType)
                    )
                {
                    var values = prop.GetValue(this) as IEnumerable;

                    if (values != null)
                    {
                        foreach (var item in values)
                        {
                            var unmatchedElementEntries = (item as FlexibleJsonModel).WalkUnmatchedData(string.Format("{0}.{1}[]", path, prop.Name));

                            if (unmatchedElementEntries.Any())
                                unmatchedDataEntries.AddRange(unmatchedElementEntries);
                        }
                    }
                }
                else if (typeof(FlexibleJsonModel).IsAssignableFrom(prop.PropertyType))
                {
                    var value = prop.GetValue(this);
                    var unmatchedPropertyEntries = (value as FlexibleJsonModel).WalkUnmatchedData(string.Format("{0}.{1}", path, prop.Name));

                    if (unmatchedPropertyEntries.Any())
                        unmatchedDataEntries.AddRange(unmatchedPropertyEntries);
                }
            }

            return unmatchedDataEntries;
        }
    }
}
