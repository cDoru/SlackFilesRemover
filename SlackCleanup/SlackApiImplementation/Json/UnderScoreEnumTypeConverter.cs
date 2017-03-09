using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SlackCleanup.SlackApiImplementation.Json
{
    public class UnderscoreEnumTypeConverter : StringEnumConverter
    {
        public static string FindMatchingName<T>(string name)
        {
            return FindMatchingName(name, typeof(T));
        }

        private static string FindMatchingName(string name, Type enumType)
        {
            var searchName = (name ?? "").Replace("_", "");

            var enumValues = Enum.GetNames(enumType);
            return enumValues.FirstOrDefault(value => value.Equals(searchName, StringComparison.CurrentCultureIgnoreCase));
        }

        public override object ReadJson(JsonReader reader, Type enumType, object existingValue, JsonSerializer serializer)
        {
            var jsonValue = ((string)reader.Value);
            var enumValue = FindMatchingName(jsonValue, enumType);

            if (enumValue == null)
                return null;

            return Enum.Parse(enumType, enumValue, false);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }
    }
}
