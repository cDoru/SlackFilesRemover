﻿using System.Collections.Generic;
using SlackCleanup.SlackApiImplementation.Model.Events;

namespace SlackCleanup.SlackApiImplementation.Model
{
    public class RtmStartResponse : EventMessageBase
    {
        public bool Ok { get; set; }

        public string LatestEventTs { get; set; }
        public string CacheVersion { get; set; }

        public ErrorType Error { get; set; }

        /// <summary>
        /// The WebSocket Message Server URL; connecting to this URL will initiate a Real Time Messaging session. These URLs are only valid for 30 seconds.
        /// </summary>
        public string Url { get; set; }
        
        public SelfBotData Self { get; set; }
        
        public TeamData Team { get; set; }

        public List<BotModel> Bots { get; set; }
        public List<User> Users { get; set; }
        public List<Channel> Channels { get; set; }
        public List<Group> Groups { get; set; }
        public List<DirectMessageChannel> Ims { get; set; }
    }
}
