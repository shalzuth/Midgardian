using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.PartySDK
{
    public class Chatroom : Object
    {
        public Chatroom(ulong addr) : base(addr) { }
        public Object CurrentChatRoomId { get { return this[nameof(CurrentChatRoomId)]; } set { this[nameof(CurrentChatRoomId)] = value; } }
        public int MaxChatRoomRetries { get { return this[nameof(MaxChatRoomRetries)].GetValue<int>(); } set { this[nameof(MaxChatRoomRetries)].SetValue<int>(value); } }
        public int NumChatRoomRetries { get { return this[nameof(NumChatRoomRetries)].GetValue<int>(); } set { this[nameof(NumChatRoomRetries)].SetValue<int>(value); } }
    }
    public class SocialManager : Object
    {
        public SocialManager(ulong addr) : base(addr) { }
        public Array<SocialToolkit> SocialToolkits { get { return new Array<SocialToolkit>(this[nameof(SocialToolkits)].Address); } }
        public SocialDebugTools SocialDebugTools { get { return this[nameof(SocialDebugTools)].As<SocialDebugTools>(); } set { this["SocialDebugTools"] = value; } }
    }
    public class SocialParty : Object
    {
        public SocialParty(ulong addr) : base(addr) { }
        public Object ReservationBeaconClientClass { get { return this[nameof(ReservationBeaconClientClass)]; } set { this[nameof(ReservationBeaconClientClass)] = value; } }
        public Object SpectatorBeaconClientClass { get { return this[nameof(SpectatorBeaconClientClass)]; } set { this[nameof(SpectatorBeaconClientClass)] = value; } }
        public UniqueNetIdRepl OwningLocalUserId { get { return this[nameof(OwningLocalUserId)].As<UniqueNetIdRepl>(); } set { this["OwningLocalUserId"] = value; } }
        public UniqueNetIdRepl CurrentLeaderId { get { return this[nameof(CurrentLeaderId)].As<UniqueNetIdRepl>(); } set { this["CurrentLeaderId"] = value; } }
        public Object PartyMembersById { get { return this[nameof(PartyMembersById)]; } set { this[nameof(PartyMembersById)] = value; } }
        public bool bEnableAutomaticPartyRejoin { get { return this[nameof(bEnableAutomaticPartyRejoin)].Flag; } set { this[nameof(bEnableAutomaticPartyRejoin)].Flag = value; } }
        public PartyBeaconClient ReservationBeaconClient { get { return this[nameof(ReservationBeaconClient)].As<PartyBeaconClient>(); } set { this["ReservationBeaconClient"] = value; } }
        public SpectatorBeaconClient SpectatorBeaconClient { get { return this[nameof(SpectatorBeaconClient)].As<SpectatorBeaconClient>(); } set { this["SpectatorBeaconClient"] = value; } }
    }
    public class PartyMember : Object
    {
        public PartyMember(ulong addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
    }
    public class SocialToolkit : Object
    {
        public SocialToolkit(ulong addr) : base(addr) { }
        public SocialUser LocalUser { get { return this[nameof(LocalUser)].As<SocialUser>(); } set { this["LocalUser"] = value; } }
        public Array<SocialUser> AllUsers { get { return new Array<SocialUser>(this[nameof(AllUsers)].Address); } }
        public LocalPlayer LocalPlayerOwner { get { return this[nameof(LocalPlayerOwner)].As<LocalPlayer>(); } set { this["LocalPlayerOwner"] = value; } }
        public SocialChatManager SocialChatManager { get { return this[nameof(SocialChatManager)].As<SocialChatManager>(); } set { this["SocialChatManager"] = value; } }
    }
    public class SocialChatManager : Object
    {
        public SocialChatManager(ulong addr) : base(addr) { }
        public Object DirectChannelsByTargetUser { get { return this[nameof(DirectChannelsByTargetUser)]; } set { this[nameof(DirectChannelsByTargetUser)] = value; } }
        public Object ChatRoomsById { get { return this[nameof(ChatRoomsById)]; } set { this[nameof(ChatRoomsById)] = value; } }
        public Object ReadOnlyChannelsByDisplayName { get { return this[nameof(ReadOnlyChannelsByDisplayName)]; } set { this[nameof(ReadOnlyChannelsByDisplayName)] = value; } }
        public bool bEnableChatSlashCommands { get { return this[nameof(bEnableChatSlashCommands)].Flag; } set { this[nameof(bEnableChatSlashCommands)].Flag = value; } }
        public Object GroupChannels { get { return this[nameof(GroupChannels)]; } set { this[nameof(GroupChannels)] = value; } }
    }
    public class SocialChatChannel : Object
    {
        public SocialChatChannel(ulong addr) : base(addr) { }
    }
    public class SocialChatRoom : SocialChatChannel
    {
        public SocialChatRoom(ulong addr) : base(addr) { }
    }
    public class SocialDebugTools : Object
    {
        public SocialDebugTools(ulong addr) : base(addr) { }
    }
    public class SocialGroupChannel : Object
    {
        public SocialGroupChannel(ulong addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
        public UniqueNetIdRepl GroupID { get { return this[nameof(GroupID)].As<UniqueNetIdRepl>(); } set { this["GroupID"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Array<SocialUser> Members { get { return new Array<SocialUser>(this[nameof(Members)].Address); } }
    }
    public class SocialPartyChatRoom : SocialChatRoom
    {
        public SocialPartyChatRoom(ulong addr) : base(addr) { }
    }
    public class SocialPrivateMessageChannel : SocialChatChannel
    {
        public SocialPrivateMessageChannel(ulong addr) : base(addr) { }
        public SocialUser TargetUser { get { return this[nameof(TargetUser)].As<SocialUser>(); } set { this["TargetUser"] = value; } }
    }
    public class SocialReadOnlyChatChannel : SocialChatChannel
    {
        public SocialReadOnlyChatChannel(ulong addr) : base(addr) { }
    }
    public class SocialSettings : Object
    {
        public SocialSettings(ulong addr) : base(addr) { }
        public Array<Object> OssNamesWithEnvironmentIdPrefix { get { return new Array<Object>(this[nameof(OssNamesWithEnvironmentIdPrefix)].Address); } }
        public int DefaultMaxPartySize { get { return this[nameof(DefaultMaxPartySize)].GetValue<int>(); } set { this[nameof(DefaultMaxPartySize)].SetValue<int>(value); } }
        public bool bPreferPlatformInvites { get { return this[nameof(bPreferPlatformInvites)].Flag; } set { this[nameof(bPreferPlatformInvites)].Flag = value; } }
        public bool bMustSendPrimaryInvites { get { return this[nameof(bMustSendPrimaryInvites)].Flag; } set { this[nameof(bMustSendPrimaryInvites)].Flag = value; } }
        public bool bLeavePartyOnDisconnect { get { return this[nameof(bLeavePartyOnDisconnect)].Flag; } set { this[nameof(bLeavePartyOnDisconnect)].Flag = value; } }
        public bool bSetDesiredPrivacyOnLocalPlayerBecomesLeader { get { return this[nameof(bSetDesiredPrivacyOnLocalPlayerBecomesLeader)].Flag; } set { this[nameof(bSetDesiredPrivacyOnLocalPlayerBecomesLeader)].Flag = value; } }
        public float UserListAutoUpdateRate { get { return this[nameof(UserListAutoUpdateRate)].GetValue<float>(); } set { this[nameof(UserListAutoUpdateRate)].SetValue<float>(value); } }
        public int MinNicknameLength { get { return this[nameof(MinNicknameLength)].GetValue<int>(); } set { this[nameof(MinNicknameLength)].SetValue<int>(value); } }
        public int MaxNicknameLength { get { return this[nameof(MaxNicknameLength)].GetValue<int>(); } set { this[nameof(MaxNicknameLength)].SetValue<int>(value); } }
        public Array<SocialPlatformDescription> SocialPlatformDescriptions { get { return new Array<SocialPlatformDescription>(this[nameof(SocialPlatformDescriptions)].Address); } }
    }
    public class SocialUser : Object
    {
        public SocialUser(ulong addr) : base(addr) { }
    }
    public enum EApprovalAction : int
    {
        Approve = 0,
        Enqueue = 1,
        EnqueueAndStartBeacon = 2,
        Deny = 3,
        EApprovalAction_MAX = 4,
    }
    public enum EPartyJoinDenialReason : int
    {
        NoReason = 0,
        JoinAttemptAborted = 1,
        Busy = 2,
        OssUnavailable = 3,
        PartyFull = 4,
        GameFull = 5,
        NotPartyLeader = 6,
        PartyPrivate = 7,
        JoinerCrossplayRestricted = 8,
        MemberCrossplayRestricted = 9,
        GameModeRestricted = 10,
        Banned = 11,
        NotLoggedIn = 12,
        CheckingForRejoin = 13,
        TargetUserMissingPresence = 14,
        TargetUserUnjoinable = 15,
        TargetUserAway = 16,
        AlreadyLeaderInPlatformSession = 17,
        TargetUserPlayingDifferentGame = 18,
        TargetUserMissingPlatformSession = 19,
        PlatformSessionMissingJoinInfo = 20,
        FailedToStartFindConsoleSession = 21,
        MissingPartyClassForTypeId = 22,
        TargetUserBlocked = 23,
        CustomReason0 = 24,
        CustomReason1 = 25,
        CustomReason2 = 26,
        CustomReason3 = 27,
        CustomReason4 = 28,
        CustomReason5 = 29,
        CustomReason6 = 30,
        CustomReason7 = 31,
        CustomReason8 = 32,
        CustomReason9 = 33,
        CustomReason10 = 34,
        CustomReason11 = 35,
        CustomReason12 = 36,
        CustomReason13 = 37,
        CustomReason14 = 38,
        CustomReason15 = 39,
        CustomReason16 = 40,
        CustomReason17 = 41,
        CustomReason18 = 42,
        CustomReason19 = 43,
        CustomReason20 = 44,
        CustomReason21 = 45,
        CustomReason22 = 46,
        CustomReason23 = 47,
        CustomReason24 = 48,
        CustomReason25 = 49,
        CustomReason26 = 50,
        CustomReason27 = 51,
        CustomReason28 = 52,
        CustomReason29 = 53,
        CustomReason30 = 54,
        CustomReason31 = 55,
        CustomReason32 = 56,
        CustomReason33 = 57,
        CustomReason34 = 58,
        CustomReason35 = 59,
        CustomReason36 = 60,
        CustomReason37 = 61,
        CustomReason38 = 62,
        CustomReason39 = 63,
        MAX = 64,
    }
    public enum EPartyInviteRestriction : int
    {
        AnyMember = 0,
        LeaderOnly = 1,
        NoInvites = 2,
        EPartyInviteRestriction_MAX = 3,
    }
    public enum EPartyType : int
    {
        Public = 0,
        FriendsOnly = 1,
        Private = 2,
        EPartyType_MAX = 3,
    }
    public enum ESocialChannelType : int
    {
        General = 0,
        Founder = 1,
        Party = 2,
        Team = 3,
        System = 4,
        Private = 5,
        ESocialChannelType_MAX = 6,
    }
    public enum EPlatformIconDisplayRule : int
    {
        Always = 0,
        AlwaysIfDifferent = 1,
        AlwaysWhenInCrossplayParty = 2,
        AlwaysIfDifferentWhenInCrossplayParty = 3,
        Never = 4,
        EPlatformIconDisplayRule_MAX = 5,
    }
    public enum ECrossplayPreference : int
    {
        NoSelection = 0,
        OptedIn = 1,
        OptedOut = 2,
        OptedOutRestricted = 3,
        ECrossplayPreference_MAX = 4,
    }
    public enum ESocialRelationship : int
    {
        Any = 0,
        FriendInviteReceived = 1,
        FriendInviteSent = 2,
        PartyInvite = 3,
        Friend = 4,
        BlockedPlayer = 5,
        SuggestedFriend = 6,
        RecentPlayer = 7,
        ESocialRelationship_MAX = 8,
    }
    public enum ESocialSubsystem : int
    {
        Primary = 0,
        Platform = 1,
        MAX = 2,
    }
    public class OnlinePartyRepDataBase : Object
    {
        public OnlinePartyRepDataBase(ulong addr) : base(addr) { }
    }
    public class PartyMemberRepData : OnlinePartyRepDataBase
    {
        public PartyMemberRepData(ulong addr) : base(addr) { }
        public UserPlatform Platform { get { return this[nameof(Platform)].As<UserPlatform>(); } set { this["Platform"] = value; } }
        public UniqueNetIdRepl PlatformUniqueId { get { return this[nameof(PlatformUniqueId)].As<UniqueNetIdRepl>(); } set { this["PlatformUniqueId"] = value; } }
        public Object PlatformSessionId { get { return this[nameof(PlatformSessionId)]; } set { this[nameof(PlatformSessionId)] = value; } }
        public ECrossplayPreference CrossplayPreference { get { return (ECrossplayPreference)this[nameof(CrossplayPreference)].GetValue<int>(); } set { this[nameof(CrossplayPreference)].SetValue<int>((int)value); } }
    }
    public class UserPlatform : Object
    {
        public UserPlatform(ulong addr) : base(addr) { }
        public SocialPlatformDescription PlatformDescription { get { return this[nameof(PlatformDescription)].As<SocialPlatformDescription>(); } set { this["PlatformDescription"] = value; } }
    }
    public class SocialPlatformDescription : Object
    {
        public SocialPlatformDescription(ulong addr) : base(addr) { }
        public Object SocialPlatformTypeName { get { return this[nameof(SocialPlatformTypeName)]; } set { this[nameof(SocialPlatformTypeName)] = value; } }
        public Object SocialPlatformName { get { return this[nameof(SocialPlatformName)]; } set { this[nameof(SocialPlatformName)] = value; } }
    }
    public class PartyPrivacySettings : Object
    {
        public PartyPrivacySettings(ulong addr) : base(addr) { }
        public EPartyType PartyType { get { return (EPartyType)this[nameof(PartyType)].GetValue<int>(); } set { this[nameof(PartyType)].SetValue<int>((int)value); } }
        public EPartyInviteRestriction PartyInviteRestriction { get { return (EPartyInviteRestriction)this[nameof(PartyInviteRestriction)].GetValue<int>(); } set { this[nameof(PartyInviteRestriction)].SetValue<int>((int)value); } }
        public bool bOnlyLeaderFriendsCanJoin { get { return this[nameof(bOnlyLeaderFriendsCanJoin)].Flag; } set { this[nameof(bOnlyLeaderFriendsCanJoin)].Flag = value; } }
    }
    public class PartyPlatformSessionInfo : Object
    {
        public PartyPlatformSessionInfo(ulong addr) : base(addr) { }
        public Object OssName { get { return this[nameof(OssName)]; } set { this[nameof(OssName)] = value; } }
        public Object SessionId { get { return this[nameof(SessionId)]; } set { this[nameof(SessionId)] = value; } }
        public UniqueNetIdRepl OwnerPrimaryId { get { return this[nameof(OwnerPrimaryId)].As<UniqueNetIdRepl>(); } set { this["OwnerPrimaryId"] = value; } }
    }
    public class SocialChatChannelConfig : Object
    {
        public SocialChatChannelConfig(ulong addr) : base(addr) { }
        public SocialUser SocialUser { get { return this[nameof(SocialUser)].As<SocialUser>(); } set { this["SocialUser"] = value; } }
        public Array<SocialChatChannel> ListenChannels { get { return new Array<SocialChatChannel>(this[nameof(ListenChannels)].Address); } }
    }
    public class PartyRepData : OnlinePartyRepDataBase
    {
        public PartyRepData(ulong addr) : base(addr) { }
        public PartyPrivacySettings PrivacySettings { get { return this[nameof(PrivacySettings)].As<PartyPrivacySettings>(); } set { this["PrivacySettings"] = value; } }
        public Array<PartyPlatformSessionInfo> PlatformSessions { get { return new Array<PartyPlatformSessionInfo>(this[nameof(PlatformSessions)].Address); } }
    }
}
