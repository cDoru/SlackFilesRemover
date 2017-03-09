﻿namespace SlackCleanup.SlackApiImplementation.Model.Events
{
    public enum EventType
    {
        Hello,
        Message,
        Error,
        UserTyping,
        ChannelMarked,
        ChannelCreated,
        ChannelJoined,
        ChannelLeft,
        ChannelDeleted,
        ChannelRename,
        ChannelArchive,
        ChannelUnarchive,
        ChannelHistoryChanged,
        ImCreated,
        ImOpen,
        ImClose,
        ImMarked,
        ImHistoryChanged,
        GroupJoined,
        GroupLeft,
        GroupOpen,
        GroupClose,
        GroupArchive,
        GroupUnarchive,
        GroupRename,
        GroupMarked,
        GroupHistoryChanged,
        FileCreated,
        FileShared,
        FileUnshared,
        FilePublic,
        FilePrivate,
        FileChange,
        FileDeleted,
        FileCommentAdded,
        FileCommentEdited,
        FileCommentDeleted,
        PinAdded,
        PinRemoved,
        PresenceChange,
        ManualPresenceChange,
        PrefChange,
        UserChange,
        TeamJoin,
        StarAdded,
        StarRemoved,
        ReactionAdded,
        ReactionRemoved,
        MessageAck,
        MessageError,
        EmojiChanged,
        CommandsChanged,
        TeamPlanChange,
        TeamPrefChange,
        TeamRename,
        TeamDomainChange,
        EmailDomainChanged,
        BotAdded,
        BotChanged,
        AccountsChanged,
        TeamMigrationStarted,
        RtmStart,
        Pong
    }
}
