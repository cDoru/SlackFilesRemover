using System.Collections.Generic;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public class Reaction : FlexibleJsonModel
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<string> Users { get; set; }
    }
}
