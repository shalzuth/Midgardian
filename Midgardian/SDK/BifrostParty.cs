using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.LobbySDK;
using SDK.Script.EngineSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.BifrostPartySDK
{
    public class BifrostPartyBeaconClient : LobbyBeaconClient
    {
        public BifrostPartyBeaconClient(ulong addr) : base(addr) { }
        public bool bHasHandShakeCompleted { get { return this[nameof(bHasHandShakeCompleted)].Flag; } set { this[nameof(bHasHandShakeCompleted)].Flag = value; } }
        public BifrostPartyBeaconState BeaconLobbyState { get { return this[nameof(BeaconLobbyState)].As<BifrostPartyBeaconState>(); } set { this["BeaconLobbyState"] = value; } }
        public BifrostPartyPlayerState BeaconPlayerState { get { return this[nameof(BeaconPlayerState)].As<BifrostPartyPlayerState>(); } set { this["BeaconPlayerState"] = value; } }
        public bool bHasRegisterComponentsCompleted { get { return this[nameof(bHasRegisterComponentsCompleted)].Flag; } set { this[nameof(bHasRegisterComponentsCompleted)].Flag = value; } }
        public void ServerSetHandshakeComplete() { Invoke(nameof(ServerSetHandshakeComplete)); }
        public void OnRep_PlayerState() { Invoke(nameof(OnRep_PlayerState)); }
        public void OnRep_LobbyState() { Invoke(nameof(OnRep_LobbyState)); }
        public void OnPartyDisbanded() { Invoke(nameof(OnPartyDisbanded)); }
        public void LeaveParty() { Invoke(nameof(LeaveParty)); }
        public void KickFromParty(UniqueNetIdRepl PlayerToKick, Object Reason) { Invoke(nameof(KickFromParty), PlayerToKick, Reason); }
        public BifrostPartyPlayerState GetPlayerState() { return Invoke<BifrostPartyPlayerState>(nameof(GetPlayerState)); }
        public BifrostPartyBeaconState GetPartyState() { return Invoke<BifrostPartyBeaconState>(nameof(GetPartyState)); }
    }
    public class BifrostPartyBeaconHost : LobbyBeaconHost
    {
        public BifrostPartyBeaconHost(ulong addr) : base(addr) { }
        public bool bIsDisbandingParty { get { return this[nameof(bIsDisbandingParty)].Flag; } set { this[nameof(bIsDisbandingParty)].Flag = value; } }
        public bool bIsJoiningGame { get { return this[nameof(bIsJoiningGame)].Flag; } set { this[nameof(bIsJoiningGame)].Flag = value; } }
        public bool bIsLevelChanging { get { return this[nameof(bIsLevelChanging)].Flag; } set { this[nameof(bIsLevelChanging)].Flag = value; } }
        public BifrostPartyBeaconState GetPartyState() { return Invoke<BifrostPartyBeaconState>(nameof(GetPartyState)); }
        public void DisbandParty() { Invoke(nameof(DisbandParty)); }
    }
    public class BifrostPartyBeaconListener : OnlineBeaconHost
    {
        public BifrostPartyBeaconListener(ulong addr) : base(addr) { }
    }
    public class BifrostPartyBeaconState : LobbyBeaconState
    {
        public BifrostPartyBeaconState(ulong addr) : base(addr) { }
        public UniqueNetIdRepl PartyOwnerUniqueId { get { return this[nameof(PartyOwnerUniqueId)].As<UniqueNetIdRepl>(); } set { this["PartyOwnerUniqueId"] = value; } }
        public void RemoveAllPlayers() { Invoke(nameof(RemoveAllPlayers)); }
        public void OnRep_PartyOwnerUniqueId() { Invoke(nameof(OnRep_PartyOwnerUniqueId)); }
        public void OnLobbyStateInfoUpdated_NetRefresh() { Invoke(nameof(OnLobbyStateInfoUpdated_NetRefresh)); }
        public void OnLobbyStateInfoUpdated() { Invoke(nameof(OnLobbyStateInfoUpdated)); }
        public BifrostPartyPlayerState GetPartyPlayer(UniqueNetIdRepl UniqueId) { return Invoke<BifrostPartyPlayerState>(nameof(GetPartyPlayer), UniqueId); }
        public BifrostPartyPlayerState GetPartyLeader() { return Invoke<BifrostPartyPlayerState>(nameof(GetPartyLeader)); }
        public void GetAllPartyMembers(Array<BifrostPartyPlayerState> InPlayerArray) { Invoke(nameof(GetAllPartyMembers), InPlayerArray); }
    }
    public class BifrostPartyComponent : ActorComponent
    {
        public BifrostPartyComponent(ulong addr) : base(addr) { }
        public BifrostPartyBeaconState PartyBeaconState { get { return this[nameof(PartyBeaconState)].As<BifrostPartyBeaconState>(); } set { this["PartyBeaconState"] = value; } }
        public Object OnPlayerJoinedBifrostParty { get { return this[nameof(OnPlayerJoinedBifrostParty)]; } set { this[nameof(OnPlayerJoinedBifrostParty)] = value; } }
        public Object OnPlayerLeftBifrostParty { get { return this[nameof(OnPlayerLeftBifrostParty)]; } set { this[nameof(OnPlayerLeftBifrostParty)] = value; } }
        public Object OnPlayerChangedBifrostParty { get { return this[nameof(OnPlayerChangedBifrostParty)]; } set { this[nameof(OnPlayerChangedBifrostParty)] = value; } }
        public Object OnPartyStateChangedBifrostParty { get { return this[nameof(OnPartyStateChangedBifrostParty)]; } set { this[nameof(OnPartyStateChangedBifrostParty)] = value; } }
        public Object OnPartyOwnerChangedBifrostParty { get { return this[nameof(OnPartyOwnerChangedBifrostParty)]; } set { this[nameof(OnPartyOwnerChangedBifrostParty)] = value; } }
        public Object OnPartyJoiningGameBifrostParty { get { return this[nameof(OnPartyJoiningGameBifrostParty)]; } set { this[nameof(OnPartyJoiningGameBifrostParty)] = value; } }
        public Object OnPartyHostConnectionFailureBifrostParty { get { return this[nameof(OnPartyHostConnectionFailureBifrostParty)]; } set { this[nameof(OnPartyHostConnectionFailureBifrostParty)] = value; } }
        public Object OnPartyHostReconnectingBifrostParty { get { return this[nameof(OnPartyHostReconnectingBifrostParty)]; } set { this[nameof(OnPartyHostReconnectingBifrostParty)] = value; } }
        public Object OnPartyInviteReceivedBifrostParty { get { return this[nameof(OnPartyInviteReceivedBifrostParty)]; } set { this[nameof(OnPartyInviteReceivedBifrostParty)] = value; } }
        public bool IsPlayerControllerUniqueIdMatch(UniqueNetIdRepl PlayerId) { return Invoke<bool>(nameof(IsPlayerControllerUniqueIdMatch), PlayerId); }
        public BifrostPartyPlayerState GetPartyPlayer(UniqueNetIdRepl PlayerId) { return Invoke<BifrostPartyPlayerState>(nameof(GetPartyPlayer), PlayerId); }
        public BifrostPartyPlayerState GetPartyLeader() { return Invoke<BifrostPartyPlayerState>(nameof(GetPartyLeader)); }
        public void GetAllPartyMembers(Array<BifrostPartyPlayerState> InPlayerArray) { Invoke(nameof(GetAllPartyMembers), InPlayerArray); }
    }
    public class BifrostPartyGameSession : GameSession
    {
        public BifrostPartyGameSession(ulong addr) : base(addr) { }
    }
    public class BifrostPartyGISubsystem : GameInstanceSubsystem
    {
        public BifrostPartyGISubsystem(ulong addr) : base(addr) { }
        public Object OnPreLoadMapBifrostParty { get { return this[nameof(OnPreLoadMapBifrostParty)]; } set { this[nameof(OnPreLoadMapBifrostParty)] = value; } }
        public Object OnNetworkFailed { get { return this[nameof(OnNetworkFailed)]; } set { this[nameof(OnNetworkFailed)] = value; } }
        public Object OnJoiningPartyStarted { get { return this[nameof(OnJoiningPartyStarted)]; } set { this[nameof(OnJoiningPartyStarted)] = value; } }
        public Object OnPartyStatusChanged { get { return this[nameof(OnPartyStatusChanged)]; } set { this[nameof(OnPartyStatusChanged)] = value; } }
        public int MaxPartyCount { get { return this[nameof(MaxPartyCount)].GetValue<int>(); } set { this[nameof(MaxPartyCount)].SetValue<int>(value); } }
        public Object LobbyBeaconPlayerStateClass { get { return this[nameof(LobbyBeaconPlayerStateClass)]; } set { this[nameof(LobbyBeaconPlayerStateClass)] = value; } }
        public bool IsPartyHostCreatingServer { get { return this[nameof(IsPartyHostCreatingServer)].Flag; } set { this[nameof(IsPartyHostCreatingServer)].Flag = value; } }
        public int CurrentTravelRetries { get { return this[nameof(CurrentTravelRetries)].GetValue<int>(); } set { this[nameof(CurrentTravelRetries)].SetValue<int>(value); } }
        public EPartyStatus PartyStatus { get { return (EPartyStatus)this[nameof(PartyStatus)].GetValue<int>(); } set { this[nameof(PartyStatus)].SetValue<int>((int)value); } }
        public BifrostPartyBeaconHost BeaconHostObject { get { return this[nameof(BeaconHostObject)].As<BifrostPartyBeaconHost>(); } set { this["BeaconHostObject"] = value; } }
        public BifrostPartyBeaconListener BeaconHostListener { get { return this[nameof(BeaconHostListener)].As<BifrostPartyBeaconListener>(); } set { this["BeaconHostListener"] = value; } }
        public BifrostPartyBeaconClient BeaconClient { get { return this[nameof(BeaconClient)].As<BifrostPartyBeaconClient>(); } set { this["BeaconClient"] = value; } }
        public ELocalPlayerStatus LocalPlayerStatus { get { return (ELocalPlayerStatus)this[nameof(LocalPlayerStatus)].GetValue<int>(); } set { this[nameof(LocalPlayerStatus)].SetValue<int>((int)value); } }
        public bool Tick(float DeltaSeconds) { return Invoke<bool>(nameof(Tick), DeltaSeconds); }
        public void ShowInviteUI() { Invoke(nameof(ShowInviteUI)); }
        public void ShowFriendsUI() { Invoke(nameof(ShowFriendsUI)); }
        public void SetPartyStatus(EPartyStatus InPartyStatus) { Invoke(nameof(SetPartyStatus), InPartyStatus); }
        public void SetLocalPlayerStatus(ELocalPlayerStatus Status) { Invoke(nameof(SetLocalPlayerStatus), Status); }
        public bool SendPartySessionInviteToFriend(PlayerController PlayerController, UniqueNetIdRepl FriendUniqueNetId) { return Invoke<bool>(nameof(SendPartySessionInviteToFriend), PlayerController, FriendUniqueNetId); }
        public void SavePartyInfo() { Invoke(nameof(SavePartyInfo)); }
        public void RestorePartyInfo() { Invoke(nameof(RestorePartyInfo)); }
        public bool RestoreLobbyIfNeeded() { return Invoke<bool>(nameof(RestoreLobbyIfNeeded)); }
        public void RemovePlatformPlayerSession(PlayerState InPlayerState) { Invoke(nameof(RemovePlatformPlayerSession), InPlayerState); }
        public void PrepareForInvitation(Object Callback) { Invoke(nameof(PrepareForInvitation), Callback); }
        public void JoinFriendPartySession(UniqueNetIdRepl FriendUniqueNetId) { Invoke(nameof(JoinFriendPartySession), FriendUniqueNetId); }
        public bool IsUserLoggedIn() { return Invoke<bool>(nameof(IsUserLoggedIn)); }
        public bool IsPartyLeader() { return Invoke<bool>(nameof(IsPartyLeader)); }
        public bool IsPartyFull() { return Invoke<bool>(nameof(IsPartyFull)); }
        public bool IsInParty() { return Invoke<bool>(nameof(IsInParty)); }
        public bool IsAloneInParty() { return Invoke<bool>(nameof(IsAloneInParty)); }
        public void InitBeaconClientBP(BlueprintSessionResult DesiredHost) { Invoke(nameof(InitBeaconClientBP), DesiredHost); }
        public bool HostParty(int MaxPlayers, int InType) { return Invoke<bool>(nameof(HostParty), MaxPlayers, InType); }
        public void HandleNetworkFailure(World World, NetDriver InNetDriver, byte FailureType, Object ErrorString) { Invoke(nameof(HandleNetworkFailure), World, InNetDriver, FailureType, ErrorString); }
        public Object GetPlayerIdString(UniqueNetIdRepl UniqueNetId) { return Invoke<Object>(nameof(GetPlayerIdString), UniqueNetId); }
        public EPartyStatus GetPartyStatus() { return Invoke<EPartyStatus>(nameof(GetPartyStatus)); }
        public int GetPartyCount() { return Invoke<int>(nameof(GetPartyCount)); }
        public int GetMaxPartyCount() { return Invoke<int>(nameof(GetMaxPartyCount)); }
        public ELocalPlayerStatus GetLocalPlayerStatus() { return Invoke<ELocalPlayerStatus>(nameof(GetLocalPlayerStatus)); }
        public void DumpDebugParty() { Invoke(nameof(DumpDebugParty)); }
        public void DisbandParty() { Invoke(nameof(DisbandParty)); }
        public void ClearPartyBeacons() { Invoke(nameof(ClearPartyBeacons)); }
        public void AcceptPartyInvite() { Invoke(nameof(AcceptPartyInvite)); }
    }
    public class BifrostPartyPlayerState : LobbyBeaconPlayerState
    {
        public BifrostPartyPlayerState(ulong addr) : base(addr) { }
        public int PlayerProfileLevel { get { return this[nameof(PlayerProfileLevel)].GetValue<int>(); } set { this[nameof(PlayerProfileLevel)].SetValue<int>(value); } }
        public PlayerState SpawnConvertedPlayerState() { return Invoke<PlayerState>(nameof(SpawnConvertedPlayerState)); }
        public void ServerSetPlayerProfileLevel(int InPlayerProfileLevel) { Invoke(nameof(ServerSetPlayerProfileLevel), InPlayerProfileLevel); }
        public bool IsPlayerPartyLeader(BifrostPartyPlayerState InPlayerState) { return Invoke<bool>(nameof(IsPlayerPartyLeader), InPlayerState); }
        public bool IsPlayer(BifrostPartyPlayerState InPlayerState) { return Invoke<bool>(nameof(IsPlayer), InPlayerState); }
        public bool IsPartyLeader() { return Invoke<bool>(nameof(IsPartyLeader)); }
        public void InitializePlayerStateDataBlueprint() { Invoke(nameof(InitializePlayerStateDataBlueprint)); }
        public void InitializePlayerStateData() { Invoke(nameof(InitializePlayerStateData)); }
        public UniqueNetIdRepl GetPlayerUniqueId() { return Invoke<UniqueNetIdRepl>(nameof(GetPlayerUniqueId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
    }
    public class DummyPlayerController : PlayerController
    {
        public DummyPlayerController(ulong addr) : base(addr) { }
    }
    public enum ENetworkErrorType : int
    {
        UnknownError = 0,
        HostConnectionFailed = 1,
        RestoreLobbyFailed = 2,
        PlayerNotReady = 3,
        ENetworkErrorType_MAX = 4,
    }
    public enum EPartyChatType : int
    {
        Global = 0,
        Whisper = 1,
        EPartyChatType_MAX = 2,
    }
    public enum EPartyStatus : int
    {
        PartyNone = 0,
        PartyProcessing = 1,
        PartyLeader = 2,
        PartyMember = 3,
        EPartyStatus_MAX = 4,
    }
    public enum ELocalPlayerStatus : int
    {
        Uninitialized = 0,
        ReadyForParty = 1,
        InGame = 2,
        NotAvailable = 3,
        ELocalPlayerStatus_MAX = 4,
    }
    public enum EPlatformAvatarSize : int
    {
        AvatarNone = 0,
        AvatarSmall = 1,
        AvatarMedium = 2,
        AvatarLarge = 3,
        EPlatformAvatarSize_MAX = 4,
    }
    public enum EPlatformPresenceState : int
    {
        Online = 0,
        Offline = 1,
        Away = 2,
        ExtendedAway = 3,
        DoNotDisturb = 4,
        Chat = 5,
        EPlatformPresenceState_MAX = 6,
    }
    public class PlatformFriendInfo : Object
    {
        public PlatformFriendInfo(ulong addr) : base(addr) { }
        public UniqueNetIdRepl UniqueNetId { get { return this[nameof(UniqueNetId)].As<UniqueNetIdRepl>(); } set { this["UniqueNetId"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object RealName { get { return this[nameof(RealName)]; } set { this[nameof(RealName)] = value; } }
        public EPlatformPresenceState OnlineState { get { return (EPlatformPresenceState)this[nameof(OnlineState)].GetValue<int>(); } set { this[nameof(OnlineState)].SetValue<int>((int)value); } }
        public bool bIsOnline { get { return this[nameof(bIsOnline)].Flag; } set { this[nameof(bIsOnline)].Flag = value; } }
        public bool bIsPlaying { get { return this[nameof(bIsPlaying)].Flag; } set { this[nameof(bIsPlaying)].Flag = value; } }
        public bool bIsPlayingThisGame { get { return this[nameof(bIsPlayingThisGame)].Flag; } set { this[nameof(bIsPlayingThisGame)].Flag = value; } }
        public bool bIsJoinable { get { return this[nameof(bIsJoinable)].Flag; } set { this[nameof(bIsJoinable)].Flag = value; } }
        public bool bHasVoiceSupport { get { return this[nameof(bHasVoiceSupport)].Flag; } set { this[nameof(bHasVoiceSupport)].Flag = value; } }
    }
    public class PartySaveInfo : Object
    {
        public PartySaveInfo(ulong addr) : base(addr) { }
        public bool IsInParty { get { return this[nameof(IsInParty)].Flag; } set { this[nameof(IsInParty)].Flag = value; } }
        public bool IsPartyLeader { get { return this[nameof(IsPartyLeader)].Flag; } set { this[nameof(IsPartyLeader)].Flag = value; } }
    }
    public class BifrostPartySessionResult : Object
    {
        public BifrostPartySessionResult(ulong addr) : base(addr) { }
        public Object SessionType { get { return this[nameof(SessionType)]; } set { this[nameof(SessionType)] = value; } }
        public Object HostAddr { get { return this[nameof(HostAddr)]; } set { this[nameof(HostAddr)] = value; } }
        public Object SteamP2PAddr { get { return this[nameof(SteamP2PAddr)]; } set { this[nameof(SteamP2PAddr)] = value; } }
        public Object SessionId { get { return this[nameof(SessionId)]; } set { this[nameof(SessionId)] = value; } }
        public bool bIsPresence { get { return this[nameof(bIsPresence)].Flag; } set { this[nameof(bIsPresence)].Flag = value; } }
        public bool bIsLan { get { return this[nameof(bIsLan)].Flag; } set { this[nameof(bIsLan)].Flag = value; } }
    }
}
