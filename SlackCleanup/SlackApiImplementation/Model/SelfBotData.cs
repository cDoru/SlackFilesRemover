﻿using Newtonsoft.Json.Linq;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public class SelfBotData : FlexibleJsonModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// User-specific preferences.
        /// </summary>
        public JObject Prefs { get; set; }

        /// <summary>
        /// The date the user was created (Unix timestamp).
        /// </summary>
        public long Created { get; set; }

        public string ManualPresence { get; set; }
    }
}