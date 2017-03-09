using System.Collections.Generic;
using SlackCleanup.SlackApiImplementation.Model.Events.Messages;

namespace SlackCleanup.SlackApiImplementation.Model
{
    // todo: this class is a hack (I blame Slack's inconsistent schema) - needs rethinking 
    public class ReactionMessage : MessageBase
    {
        public List<Reaction> Reactions { get; set; }
    }
}