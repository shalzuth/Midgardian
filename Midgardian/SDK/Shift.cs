using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.ShiftSDK
{
    public class AuthTicketTicker : Object
    {
        public AuthTicketTicker(ulong addr) : base(addr) { }
        public ShiftSession Session { get { return this[nameof(Session)].As<ShiftSession>(); } set { this["Session"] = value; } }
    }
    public class ShiftService : Object
    {
        public ShiftService(ulong addr) : base(addr) { }
        public ShiftSessionManager SessionManager { get { return this[nameof(SessionManager)].As<ShiftSessionManager>(); } set { this["SessionManager"] = value; } }
    }
    public class ShiftSession : Object
    {
        public ShiftSession(ulong addr) : base(addr) { }
        public ClientTelemetry ClientTelemetry { get { return this[nameof(ClientTelemetry)].As<ClientTelemetry>(); } set { this["ClientTelemetry"] = value; } }
        public ServerTelemetry ServerTelemetry { get { return this[nameof(ServerTelemetry)].As<ServerTelemetry>(); } set { this["ServerTelemetry"] = value; } }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object ShiftId { get { return this[nameof(ShiftId)]; } set { this[nameof(ShiftId)] = value; } }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public uint BifrostId { get { return this[nameof(BifrostId)].GetValue<uint>(); } set { this[nameof(BifrostId)].SetValue<uint>(value); } }
        public Object ArchwayToken { get { return this[nameof(ArchwayToken)]; } set { this[nameof(ArchwayToken)] = value; } }
        public Array<Object> DisplayNameConflictChoices { get { return new Array<Object>(this[nameof(DisplayNameConflictChoices)].Address); } }
    }
    public class ShiftSessionManager : Object
    {
        public ShiftSessionManager(ulong addr) : base(addr) { }
        public Array<ShiftSession> UserList { get { return new Array<ShiftSession>(this[nameof(UserList)].Address); } }
        public Object ShiftSessionClass { get { return this[nameof(ShiftSessionClass)]; } set { this[nameof(ShiftSessionClass)] = value; } }
    }
    public enum EShiftMatchmakingService : int
    {
        Matchmaking = 0,
        None = 1,
        EShiftMatchmakingService_MAX = 2,
    }
    public enum EShiftPresenceShowAs : int
    {
        Available = 0,
        Away = 1,
        DoNotDisturb = 2,
        Unavailable = 3,
        EShiftPresenceShowAs_MAX = 4,
    }
    public enum EShiftFriendRelationship : int
    {
        RequestSent = 0,
        RequestReceived = 1,
        Active = 2,
        Blocking = 3,
        Any = 4,
        EShiftFriendRelationship_MAX = 5,
    }
    public enum EShiftUserState : int
    {
        None = 0,
        Provisional = 1,
        Unconfirmed = 2,
        Confirmed = 3,
        EShiftUserState_MAX = 4,
    }
    public class ClientTelemetry : Object
    {
        public ClientTelemetry(ulong addr) : base(addr) { }
        public PlayerController PlayerController { get { return this[nameof(PlayerController)].As<PlayerController>(); } set { this["PlayerController"] = value; } }
    }
    public class ServerTelemetry : Object
    {
        public ServerTelemetry(ulong addr) : base(addr) { }
        public GameInstance Game { get { return this[nameof(Game)].As<GameInstance>(); } set { this["Game"] = value; } }
    }
    public class ShiftUserAchievement : Object
    {
        public ShiftUserAchievement(ulong addr) : base(addr) { }
        public Object AchievedAt { get { return this[nameof(AchievedAt)]; } set { this[nameof(AchievedAt)] = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public long Progression { get { return this[nameof(Progression)].GetValue<long>(); } set { this[nameof(Progression)].SetValue<long>(value); } }
    }
    public class ShiftAchievement : Object
    {
        public ShiftAchievement(ulong addr) : base(addr) { }
        public Object Category { get { return this[nameof(Category)]; } set { this[nameof(Category)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public bool bHidden { get { return this[nameof(bHidden)].Flag; } set { this[nameof(bHidden)].Flag = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public long Target { get { return this[nameof(Target)].GetValue<long>(); } set { this[nameof(Target)].SetValue<long>(value); } }
        public Object Tier { get { return this[nameof(Tier)]; } set { this[nameof(Tier)] = value; } }
    }
    public class ShiftEntitlement : Object
    {
        public ShiftEntitlement(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public bool bConsumable { get { return this[nameof(bConsumable)].Flag; } set { this[nameof(bConsumable)].Flag = value; } }
        public long ConsumableAmount { get { return this[nameof(ConsumableAmount)].GetValue<long>(); } set { this[nameof(ConsumableAmount)].SetValue<long>(value); } }
        public long EntitlementID { get { return this[nameof(EntitlementID)].GetValue<long>(); } set { this[nameof(EntitlementID)].SetValue<long>(value); } }
    }
    public class ShiftOffer : Object
    {
        public ShiftOffer(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object DateUnlocked { get { return this[nameof(DateUnlocked)]; } set { this[nameof(DateUnlocked)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
    }
    public class ShiftEULA : Object
    {
        public ShiftEULA(ulong addr) : base(addr) { }
        public long ID { get { return this[nameof(ID)].GetValue<long>(); } set { this[nameof(ID)].SetValue<long>(value); } }
        public Object Version { get { return this[nameof(Version)]; } set { this[nameof(Version)] = value; } }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
    }
    public class ShiftExperience : Object
    {
        public ShiftExperience(ulong addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Version { get { return this[nameof(Version)]; } set { this[nameof(Version)] = value; } }
        public long Priority { get { return this[nameof(Priority)].GetValue<long>(); } set { this[nameof(Priority)].SetValue<long>(value); } }
        public ShiftPortrait Portrait { get { return this[nameof(Portrait)].As<ShiftPortrait>(); } set { this["Portrait"] = value; } }
        public ShiftMatchmaking Matchmaking { get { return this[nameof(Matchmaking)].As<ShiftMatchmaking>(); } set { this["Matchmaking"] = value; } }
        public long TeamCount { get { return this[nameof(TeamCount)].GetValue<long>(); } set { this[nameof(TeamCount)].SetValue<long>(value); } }
        public long MinTeamSize { get { return this[nameof(MinTeamSize)].GetValue<long>(); } set { this[nameof(MinTeamSize)].SetValue<long>(value); } }
        public long MaxTeamSize { get { return this[nameof(MaxTeamSize)].GetValue<long>(); } set { this[nameof(MaxTeamSize)].SetValue<long>(value); } }
        public Object ServerAllocator { get { return this[nameof(ServerAllocator)]; } set { this[nameof(ServerAllocator)] = value; } }
        public Object ServerOptions { get { return this[nameof(ServerOptions)]; } set { this[nameof(ServerOptions)] = value; } }
        public Object ModSets { get { return this[nameof(ModSets)]; } set { this[nameof(ModSets)] = value; } }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
        public Array<ShiftGameMode> GameModes { get { return new Array<ShiftGameMode>(this[nameof(GameModes)].Address); } }
        public Object RewardOptions { get { return this[nameof(RewardOptions)]; } set { this[nameof(RewardOptions)] = value; } }
    }
    public class ShiftGameMode : Object
    {
        public ShiftGameMode(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object GameData { get { return this[nameof(GameData)]; } set { this[nameof(GameData)] = value; } }
        public Array<ShiftGameMap> Maps { get { return new Array<ShiftGameMap>(this[nameof(Maps)].Address); } }
    }
    public class ShiftGameMap : Object
    {
        public ShiftGameMap(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object GameData { get { return this[nameof(GameData)]; } set { this[nameof(GameData)] = value; } }
        public long Priority { get { return this[nameof(Priority)].GetValue<long>(); } set { this[nameof(Priority)].SetValue<long>(value); } }
        public long Chance { get { return this[nameof(Chance)].GetValue<long>(); } set { this[nameof(Chance)].SetValue<long>(value); } }
    }
    public class ShiftMatchmaking : Object
    {
        public ShiftMatchmaking(ulong addr) : base(addr) { }
        public EShiftMatchmakingService Service { get { return (EShiftMatchmakingService)this[nameof(Service)].GetValue<int>(); } set { this[nameof(Service)].SetValue<int>((int)value); } }
        public ShiftMatchmakingPool Pool { get { return this[nameof(Pool)].As<ShiftMatchmakingPool>(); } set { this["Pool"] = value; } }
        public Object Rules { get { return this[nameof(Rules)]; } set { this[nameof(Rules)] = value; } }
        public Object Options { get { return this[nameof(Options)]; } set { this[nameof(Options)] = value; } }
    }
    public class ShiftMatchmakingPool : Object
    {
        public ShiftMatchmakingPool(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Options { get { return this[nameof(Options)]; } set { this[nameof(Options)] = value; } }
    }
    public class ShiftPortrait : Object
    {
        public ShiftPortrait(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Rules { get { return this[nameof(Rules)]; } set { this[nameof(Rules)] = value; } }
        public Object Requirements { get { return this[nameof(Requirements)]; } set { this[nameof(Requirements)] = value; } }
        public Object ImageName { get { return this[nameof(ImageName)]; } set { this[nameof(ImageName)] = value; } }
        public Object ImageURL { get { return this[nameof(ImageURL)]; } set { this[nameof(ImageURL)] = value; } }
    }
    public class ShiftFriendInfo : Object
    {
        public ShiftFriendInfo(ulong addr) : base(addr) { }
        public uint UniqueId { get { return this[nameof(UniqueId)].GetValue<uint>(); } set { this[nameof(UniqueId)].SetValue<uint>(value); } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object RichPresence { get { return this[nameof(RichPresence)]; } set { this[nameof(RichPresence)] = value; } }
        public EShiftFriendRelationship Status { get { return (EShiftFriendRelationship)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public EShiftPresenceShowAs Presence { get { return (EShiftPresenceShowAs)this[nameof(Presence)].GetValue<int>(); } set { this[nameof(Presence)].SetValue<int>((int)value); } }
    }
    public class ShiftLeaderboardEntry : Object
    {
        public ShiftLeaderboardEntry(ulong addr) : base(addr) { }
        public long UserUniqueId { get { return this[nameof(UserUniqueId)].GetValue<long>(); } set { this[nameof(UserUniqueId)].SetValue<long>(value); } }
        public long Rank { get { return this[nameof(Rank)].GetValue<long>(); } set { this[nameof(Rank)].SetValue<long>(value); } }
        public long MMR { get { return this[nameof(MMR)].GetValue<long>(); } set { this[nameof(MMR)].SetValue<long>(value); } }
    }
    public class ShiftArticle : Object
    {
        public ShiftArticle(ulong addr) : base(addr) { }
        public Object Header { get { return this[nameof(Header)]; } set { this[nameof(Header)] = value; } }
        public Object Body { get { return this[nameof(Body)]; } set { this[nameof(Body)] = value; } }
        public Object Summary { get { return this[nameof(Summary)]; } set { this[nameof(Summary)] = value; } }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
    }
    public class ShiftPersonalDetails : Object
    {
        public ShiftPersonalDetails(ulong addr) : base(addr) { }
        public Object FirstName { get { return this[nameof(FirstName)]; } set { this[nameof(FirstName)] = value; } }
        public Object LastName { get { return this[nameof(LastName)]; } set { this[nameof(LastName)] = value; } }
        public Object Country { get { return this[nameof(Country)]; } set { this[nameof(Country)] = value; } }
        public Object Email { get { return this[nameof(Email)]; } set { this[nameof(Email)] = value; } }
        public Array<ShiftPlatformLink> PlatformLinks { get { return new Array<ShiftPlatformLink>(this[nameof(PlatformLinks)].Address); } }
    }
    public class ShiftPlatformLink : Object
    {
        public ShiftPlatformLink(ulong addr) : base(addr) { }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public Object ServiceID { get { return this[nameof(ServiceID)]; } set { this[nameof(ServiceID)] = value; } }
    }
    public class ShiftUserDetails : Object
    {
        public ShiftUserDetails(ulong addr) : base(addr) { }
        public EShiftUserState State { get { return (EShiftUserState)this[nameof(State)].GetValue<int>(); } set { this[nameof(State)].SetValue<int>((int)value); } }
        public uint UserId { get { return this[nameof(UserId)].GetValue<uint>(); } set { this[nameof(UserId)].SetValue<uint>(value); } }
        public uint SessionId { get { return this[nameof(SessionId)].GetValue<uint>(); } set { this[nameof(SessionId)].SetValue<uint>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
        public Object ServiceID { get { return this[nameof(ServiceID)]; } set { this[nameof(ServiceID)] = value; } }
        public Object TitleSlug { get { return this[nameof(TitleSlug)]; } set { this[nameof(TitleSlug)] = value; } }
        public Object CustomerSupportID { get { return this[nameof(CustomerSupportID)]; } set { this[nameof(CustomerSupportID)] = value; } }
    }
}
