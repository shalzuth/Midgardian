using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AdvancedSessionsSDK
{
    public class AdvancedExternalUILibrary : BlueprintFunctionLibrary
    {
        public AdvancedExternalUILibrary(ulong addr) : base(addr) { }
        public void ShowWebURLUI(Object URLToShow, EBlueprintResultSwitch Result, Array<Object> AllowedDomains, bool bEmbedded, bool bShowBackground, bool bShowCloseButton, int OffsetX, int OffsetY, int SizeX, int SizeY) { Invoke(nameof(ShowWebURLUI), URLToShow, Result, AllowedDomains, bEmbedded, bShowBackground, bShowCloseButton, OffsetX, OffsetY, SizeX, SizeY); }
        public void ShowProfileUI(BPUniqueNetId PlayerViewingProfile, BPUniqueNetId PlayerToViewProfileOf, EBlueprintResultSwitch Result) { Invoke(nameof(ShowProfileUI), PlayerViewingProfile, PlayerToViewProfileOf, Result); }
        public void ShowLeaderBoardUI(Object LeaderboardName, EBlueprintResultSwitch Result) { Invoke(nameof(ShowLeaderBoardUI), LeaderboardName, Result); }
        public void ShowInviteUI(PlayerController PlayerController, EBlueprintResultSwitch Result) { Invoke(nameof(ShowInviteUI), PlayerController, Result); }
        public void ShowFriendsUI(PlayerController PlayerController, EBlueprintResultSwitch Result) { Invoke(nameof(ShowFriendsUI), PlayerController, Result); }
        public void ShowAccountUpgradeUI(BPUniqueNetId PlayerRequestingAccountUpgradeUI, EBlueprintResultSwitch Result) { Invoke(nameof(ShowAccountUpgradeUI), PlayerRequestingAccountUpgradeUI, Result); }
        public void CloseWebURLUI() { Invoke(nameof(CloseWebURLUI)); }
    }
    public class AdvancedFriendsGameInstance : GameInstance
    {
        public AdvancedFriendsGameInstance(ulong addr) : base(addr) { }
        public bool bCallFriendInterfaceEventsOnPlayerControllers { get { return this[nameof(bCallFriendInterfaceEventsOnPlayerControllers)].Flag; } set { this[nameof(bCallFriendInterfaceEventsOnPlayerControllers)].Flag = value; } }
        public bool bCallIdentityInterfaceEventsOnPlayerControllers { get { return this[nameof(bCallIdentityInterfaceEventsOnPlayerControllers)].Flag; } set { this[nameof(bCallIdentityInterfaceEventsOnPlayerControllers)].Flag = value; } }
        public bool bCallVoiceInterfaceEventsOnPlayerControllers { get { return this[nameof(bCallVoiceInterfaceEventsOnPlayerControllers)].Flag; } set { this[nameof(bCallVoiceInterfaceEventsOnPlayerControllers)].Flag = value; } }
        public bool bEnableTalkingStatusDelegate { get { return this[nameof(bEnableTalkingStatusDelegate)].Flag; } set { this[nameof(bEnableTalkingStatusDelegate)].Flag = value; } }
        public void OnSessionInviteReceived(int LocalPlayerNum, BPUniqueNetId PersonInviting, Object AppId, BlueprintSessionResult SessionToJoin) { Invoke(nameof(OnSessionInviteReceived), LocalPlayerNum, PersonInviting, AppId, SessionToJoin); }
        public void OnSessionInviteAccepted(int LocalPlayerNum, BPUniqueNetId PersonInvited, BlueprintSessionResult SessionToJoin) { Invoke(nameof(OnSessionInviteAccepted), LocalPlayerNum, PersonInvited, SessionToJoin); }
        public void OnPlayerTalkingStateChanged(BPUniqueNetId PlayerId, bool bIsTalking) { Invoke(nameof(OnPlayerTalkingStateChanged), PlayerId, bIsTalking); }
        public void OnPlayerLoginStatusChanged(int PlayerNum, EBPLoginStatus PreviousStatus, EBPLoginStatus NewStatus, BPUniqueNetId NewPlayerUniqueNetID) { Invoke(nameof(OnPlayerLoginStatusChanged), PlayerNum, PreviousStatus, NewStatus, NewPlayerUniqueNetID); }
        public void OnPlayerLoginChanged(int PlayerNum) { Invoke(nameof(OnPlayerLoginChanged), PlayerNum); }
    }
    public class AdvancedFriendsInterface : Interface
    {
        public AdvancedFriendsInterface(ulong addr) : base(addr) { }
        public void OnSessionInviteReceived(BPUniqueNetId PersonInviting, BlueprintSessionResult SearchResult) { Invoke(nameof(OnSessionInviteReceived), PersonInviting, SearchResult); }
        public void OnSessionInviteAccepted(BPUniqueNetId PersonInvited, BlueprintSessionResult SearchResult) { Invoke(nameof(OnSessionInviteAccepted), PersonInvited, SearchResult); }
        public void OnPlayerVoiceStateChanged(BPUniqueNetId PlayerId, bool bIsTalking) { Invoke(nameof(OnPlayerVoiceStateChanged), PlayerId, bIsTalking); }
        public void OnPlayerLoginStatusChanged(EBPLoginStatus PreviousStatus, EBPLoginStatus NewStatus, BPUniqueNetId PlayerUniqueNetID) { Invoke(nameof(OnPlayerLoginStatusChanged), PreviousStatus, NewStatus, PlayerUniqueNetID); }
        public void OnPlayerLoginChanged(int PlayerNum) { Invoke(nameof(OnPlayerLoginChanged), PlayerNum); }
    }
    public class AdvancedFriendsLibrary : BlueprintFunctionLibrary
    {
        public AdvancedFriendsLibrary(ulong addr) : base(addr) { }
        public void SendSessionInviteToFriends(PlayerController PlayerController, Array<BPUniqueNetId> Friends, EBlueprintResultSwitch Result) { Invoke(nameof(SendSessionInviteToFriends), PlayerController, Friends, Result); }
        public void SendSessionInviteToFriend(PlayerController PlayerController, BPUniqueNetId FriendUniqueNetId, EBlueprintResultSwitch Result) { Invoke(nameof(SendSessionInviteToFriend), PlayerController, FriendUniqueNetId, Result); }
        public void IsAFriend(PlayerController PlayerController, BPUniqueNetId UniqueNetId, bool IsFriend) { Invoke(nameof(IsAFriend), PlayerController, UniqueNetId, IsFriend); }
        public void GetStoredRecentPlayersList(BPUniqueNetId UniqueNetId, Array<BPOnlineRecentPlayer> PlayersList) { Invoke(nameof(GetStoredRecentPlayersList), UniqueNetId, PlayersList); }
        public void GetStoredFriendsList(PlayerController PlayerController, Array<BPFriendInfo> FriendsList) { Invoke(nameof(GetStoredFriendsList), PlayerController, FriendsList); }
        public void GetFriend(PlayerController PlayerController, BPUniqueNetId FriendUniqueNetId, BPFriendInfo Friend) { Invoke(nameof(GetFriend), PlayerController, FriendUniqueNetId, Friend); }
    }
    public class AdvancedGameSession : GameSession
    {
        public AdvancedGameSession(ulong addr) : base(addr) { }
        public Object BanList { get { return this[nameof(BanList)]; } set { this[nameof(BanList)] = value; } }
    }
    public class AdvancedIdentityLibrary : BlueprintFunctionLibrary
    {
        public AdvancedIdentityLibrary(ulong addr) : base(addr) { }
        public void SetUserAccountAttribute(BPUserOnlineAccount AccountInfo, Object AttributeName, Object NewAttributeValue, EBlueprintResultSwitch Result) { Invoke(nameof(SetUserAccountAttribute), AccountInfo, AttributeName, NewAttributeValue, Result); }
        public void GetUserID(BPUserOnlineAccount AccountInfo, BPUniqueNetId UniqueNetId) { Invoke(nameof(GetUserID), AccountInfo, UniqueNetId); }
        public void GetUserAccountRealName(BPUserOnlineAccount AccountInfo, Object UserName) { Invoke(nameof(GetUserAccountRealName), AccountInfo, UserName); }
        public void GetUserAccountDisplayName(BPUserOnlineAccount AccountInfo, Object DisplayName) { Invoke(nameof(GetUserAccountDisplayName), AccountInfo, DisplayName); }
        public void GetUserAccountAuthAttribute(BPUserOnlineAccount AccountInfo, Object AttributeName, Object AuthAttribute, EBlueprintResultSwitch Result) { Invoke(nameof(GetUserAccountAuthAttribute), AccountInfo, AttributeName, AuthAttribute, Result); }
        public void GetUserAccountAttribute(BPUserOnlineAccount AccountInfo, Object AttributeName, Object AttributeValue, EBlueprintResultSwitch Result) { Invoke(nameof(GetUserAccountAttribute), AccountInfo, AttributeName, AttributeValue, Result); }
        public void GetUserAccountAccessToken(BPUserOnlineAccount AccountInfo, Object AccessToken) { Invoke(nameof(GetUserAccountAccessToken), AccountInfo, AccessToken); }
        public void GetUserAccount(BPUniqueNetId UniqueNetId, BPUserOnlineAccount AccountInfo, EBlueprintResultSwitch Result) { Invoke(nameof(GetUserAccount), UniqueNetId, AccountInfo, Result); }
        public void GetPlayerNickname(BPUniqueNetId UniqueNetId, Object PlayerNickname) { Invoke(nameof(GetPlayerNickname), UniqueNetId, PlayerNickname); }
        public void GetPlayerAuthToken(PlayerController PlayerController, Object AuthToken, EBlueprintResultSwitch Result) { Invoke(nameof(GetPlayerAuthToken), PlayerController, AuthToken, Result); }
        public void GetLoginStatus(BPUniqueNetId UniqueNetId, EBPLoginStatus LoginStatus, EBlueprintResultSwitch Result) { Invoke(nameof(GetLoginStatus), UniqueNetId, LoginStatus, Result); }
        public void GetAllUserAccounts(Array<BPUserOnlineAccount> AccountInfos, EBlueprintResultSwitch Result) { Invoke(nameof(GetAllUserAccounts), AccountInfos, Result); }
    }
    public class AdvancedSessionsLibrary : BlueprintFunctionLibrary
    {
        public AdvancedSessionsLibrary(ulong addr) : base(addr) { }
        public void UniqueNetIdToString(BPUniqueNetId UniqueNetId, Object String) { Invoke(nameof(UniqueNetIdToString), UniqueNetId, String); }
        public void SetPlayerName(PlayerController PlayerController, Object PlayerName) { Invoke(nameof(SetPlayerName), PlayerController, PlayerName); }
        public SessionsSearchSetting MakeLiteralSessionSearchProperty(SessionPropertyKeyPair SessionSearchProperty, EOnlineComparisonOpRedux ComparisonOp) { return Invoke<SessionsSearchSetting>(nameof(MakeLiteralSessionSearchProperty), SessionSearchProperty, ComparisonOp); }
        public SessionPropertyKeyPair MakeLiteralSessionPropertyString(Object Key, Object Value) { return Invoke<SessionPropertyKeyPair>(nameof(MakeLiteralSessionPropertyString), Key, Value); }
        public SessionPropertyKeyPair MakeLiteralSessionPropertyInt(Object Key, int Value) { return Invoke<SessionPropertyKeyPair>(nameof(MakeLiteralSessionPropertyInt), Key, Value); }
        public SessionPropertyKeyPair MakeLiteralSessionPropertyFloat(Object Key, float Value) { return Invoke<SessionPropertyKeyPair>(nameof(MakeLiteralSessionPropertyFloat), Key, Value); }
        public SessionPropertyKeyPair MakeLiteralSessionPropertyByte(Object Key, byte Value) { return Invoke<SessionPropertyKeyPair>(nameof(MakeLiteralSessionPropertyByte), Key, Value); }
        public SessionPropertyKeyPair MakeLiteralSessionPropertyBool(Object Key, bool Value) { return Invoke<SessionPropertyKeyPair>(nameof(MakeLiteralSessionPropertyBool), Key, Value); }
        public bool KickPlayer(Object WorldContextObject, PlayerController PlayerToKick, Object KickReason) { return Invoke<bool>(nameof(KickPlayer), WorldContextObject, PlayerToKick, KickReason); }
        public bool IsValidUniqueNetID(BPUniqueNetId UniqueNetId) { return Invoke<bool>(nameof(IsValidUniqueNetID), UniqueNetId); }
        public bool IsValidSession(BlueprintSessionResult SessionResult) { return Invoke<bool>(nameof(IsValidSession), SessionResult); }
        public void IsPlayerInSession(Object WorldContextObject, BPUniqueNetId PlayerToCheck, bool bIsInSession) { Invoke(nameof(IsPlayerInSession), WorldContextObject, PlayerToCheck, bIsInSession); }
        public bool HasOnlineSubsystem(Object SubSystemName) { return Invoke<bool>(nameof(HasOnlineSubsystem), SubSystemName); }
        public void GetUniqueNetIDFromPlayerState(PlayerState PlayerState, BPUniqueNetId UniqueNetId) { Invoke(nameof(GetUniqueNetIDFromPlayerState), PlayerState, UniqueNetId); }
        public void GetUniqueNetID(PlayerController PlayerController, BPUniqueNetId UniqueNetId) { Invoke(nameof(GetUniqueNetID), PlayerController, UniqueNetId); }
        public void GetUniqueBuildID(BlueprintSessionResult SessionResult, int UniqueBuildId) { Invoke(nameof(GetUniqueBuildID), SessionResult, UniqueBuildId); }
        public void GetSessionState(Object WorldContextObject, EBPOnlineSessionState SessionState) { Invoke(nameof(GetSessionState), WorldContextObject, SessionState); }
        public void GetSessionSettings(Object WorldContextObject, int NumConnections, int NumPrivateConnections, bool bIsLan, bool bIsDedicated, bool bAllowInvites, bool bAllowJoinInProgress, bool bIsAnticheatEnabled, int BuildUniqueID, Array<SessionPropertyKeyPair> ExtraSettings, EBlueprintResultSwitch Result) { Invoke(nameof(GetSessionSettings), WorldContextObject, NumConnections, NumPrivateConnections, bIsLan, bIsDedicated, bAllowInvites, bAllowJoinInProgress, bIsAnticheatEnabled, BuildUniqueID, ExtraSettings, Result); }
        public void GetSessionPropertyString(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, ESessionSettingSearchResult SearchResult, Object SettingValue) { Invoke(nameof(GetSessionPropertyString), ExtraSettings, SettingName, SearchResult, SettingValue); }
        public Object GetSessionPropertyKey(SessionPropertyKeyPair SessionProperty) { return Invoke<Object>(nameof(GetSessionPropertyKey), SessionProperty); }
        public void GetSessionPropertyInt(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, ESessionSettingSearchResult SearchResult, int SettingValue) { Invoke(nameof(GetSessionPropertyInt), ExtraSettings, SettingName, SearchResult, SettingValue); }
        public void GetSessionPropertyFloat(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, ESessionSettingSearchResult SearchResult, float SettingValue) { Invoke(nameof(GetSessionPropertyFloat), ExtraSettings, SettingName, SearchResult, SettingValue); }
        public void GetSessionPropertyByte(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, ESessionSettingSearchResult SearchResult, byte SettingValue) { Invoke(nameof(GetSessionPropertyByte), ExtraSettings, SettingName, SearchResult, SettingValue); }
        public void GetSessionPropertyBool(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, ESessionSettingSearchResult SearchResult, bool SettingValue) { Invoke(nameof(GetSessionPropertyBool), ExtraSettings, SettingName, SearchResult, SettingValue); }
        public void GetSessionID_AsString(BlueprintSessionResult SessionResult, Object SessionId) { Invoke(nameof(GetSessionID_AsString), SessionResult, SessionId); }
        public void GetPlayerName(PlayerController PlayerController, Object PlayerName) { Invoke(nameof(GetPlayerName), PlayerController, PlayerName); }
        public void GetNumberOfNetworkPlayers(Object WorldContextObject, int NumNetPlayers) { Invoke(nameof(GetNumberOfNetworkPlayers), WorldContextObject, NumNetPlayers); }
        public void GetNetPlayerIndex(PlayerController PlayerController, int NetPlayerIndex) { Invoke(nameof(GetNetPlayerIndex), PlayerController, NetPlayerIndex); }
        public void GetExtraSettings(BlueprintSessionResult SessionResult, Array<SessionPropertyKeyPair> ExtraSettings) { Invoke(nameof(GetExtraSettings), SessionResult, ExtraSettings); }
        public void GetCurrentUniqueBuildID(int UniqueBuildId) { Invoke(nameof(GetCurrentUniqueBuildID), UniqueBuildId); }
        public void GetCurrentSessionID_AsString(Object WorldContextObject, Object SessionId) { Invoke(nameof(GetCurrentSessionID_AsString), WorldContextObject, SessionId); }
        public void FindSessionPropertyIndexByName(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingName, EBlueprintResultSwitch Result, int OutIndex) { Invoke(nameof(FindSessionPropertyIndexByName), ExtraSettings, SettingName, Result, OutIndex); }
        public void FindSessionPropertyByName(Array<SessionPropertyKeyPair> ExtraSettings, Object SettingsName, EBlueprintResultSwitch Result, SessionPropertyKeyPair OutProperty) { Invoke(nameof(FindSessionPropertyByName), ExtraSettings, SettingsName, Result, OutProperty); }
        public bool EqualEqual_UNetIDUnetID(BPUniqueNetId A, BPUniqueNetId B) { return Invoke<bool>(nameof(EqualEqual_UNetIDUnetID), A, B); }
        public bool BanPlayer(Object WorldContextObject, PlayerController PlayerToBan, Object BanReason) { return Invoke<bool>(nameof(BanPlayer), WorldContextObject, PlayerToBan, BanReason); }
        public void AddOrModifyExtraSettings(Array<SessionPropertyKeyPair> SettingsArray, Array<SessionPropertyKeyPair> NewOrChangedSettings, Array<SessionPropertyKeyPair> ModifiedSettingsArray) { Invoke(nameof(AddOrModifyExtraSettings), SettingsArray, NewOrChangedSettings, ModifiedSettingsArray); }
    }
    public class AdvancedVoiceLibrary : BlueprintFunctionLibrary
    {
        public AdvancedVoiceLibrary(ulong addr) : base(addr) { }
        public bool UnRegisterRemoteTalker(BPUniqueNetId UniqueNetId) { return Invoke<bool>(nameof(UnRegisterRemoteTalker), UniqueNetId); }
        public void UnRegisterLocalTalker(byte LocalPlayerNum) { Invoke(nameof(UnRegisterLocalTalker), LocalPlayerNum); }
        public void UnRegisterAllLocalTalkers() { Invoke(nameof(UnRegisterAllLocalTalkers)); }
        public bool UnMuteRemoteTalker(byte LocalUserNum, BPUniqueNetId UniqueNetId, bool bIsSystemWide) { return Invoke<bool>(nameof(UnMuteRemoteTalker), LocalUserNum, UniqueNetId, bIsSystemWide); }
        public void StopNetworkedVoice(byte LocalPlayerNum) { Invoke(nameof(StopNetworkedVoice), LocalPlayerNum); }
        public void StartNetworkedVoice(byte LocalPlayerNum) { Invoke(nameof(StartNetworkedVoice), LocalPlayerNum); }
        public void RemoveAllRemoteTalkers() { Invoke(nameof(RemoveAllRemoteTalkers)); }
        public bool RegisterRemoteTalker(BPUniqueNetId UniqueNetId) { return Invoke<bool>(nameof(RegisterRemoteTalker), UniqueNetId); }
        public bool RegisterLocalTalker(byte LocalPlayerNum) { return Invoke<bool>(nameof(RegisterLocalTalker), LocalPlayerNum); }
        public void RegisterAllLocalTalkers() { Invoke(nameof(RegisterAllLocalTalkers)); }
        public bool MuteRemoteTalker(byte LocalUserNum, BPUniqueNetId UniqueNetId, bool bIsSystemWide) { return Invoke<bool>(nameof(MuteRemoteTalker), LocalUserNum, UniqueNetId, bIsSystemWide); }
        public bool IsRemotePlayerTalking(BPUniqueNetId UniqueNetId) { return Invoke<bool>(nameof(IsRemotePlayerTalking), UniqueNetId); }
        public bool IsPlayerMuted(byte LocalUserNumChecking, BPUniqueNetId UniqueNetId) { return Invoke<bool>(nameof(IsPlayerMuted), LocalUserNumChecking, UniqueNetId); }
        public bool IsLocalPlayerTalking(byte LocalPlayerNum) { return Invoke<bool>(nameof(IsLocalPlayerTalking), LocalPlayerNum); }
        public void IsHeadsetPresent(bool bHasHeadset, byte LocalPlayerNum) { Invoke(nameof(IsHeadsetPresent), bHasHeadset, LocalPlayerNum); }
        public void GetNumLocalTalkers(int NumLocalTalkers) { Invoke(nameof(GetNumLocalTalkers), NumLocalTalkers); }
    }
    public class CancelFindSessionsCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public CancelFindSessionsCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CancelFindSessionsCallbackProxy CancelFindSessions(Object WorldContextObject, PlayerController PlayerController) { return Invoke<CancelFindSessionsCallbackProxy>(nameof(CancelFindSessions), WorldContextObject, PlayerController); }
    }
    public class CreateSessionCallbackProxyAdvanced : OnlineBlueprintCallProxyBase
    {
        public CreateSessionCallbackProxyAdvanced(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CreateSessionCallbackProxyAdvanced CreateAdvancedSession(Object WorldContextObject, Array<SessionPropertyKeyPair> ExtraSettings, PlayerController PlayerController, int PublicConnections, int PrivateConnections, bool bUseLAN, bool bAllowInvites, bool bIsDedicatedServer, bool bUsePresence, bool bAllowJoinViaPresence, bool bAllowJoinViaPresenceFriendsOnly, bool bAntiCheatProtected, bool bUsesStats, bool bShouldAdvertise) { return Invoke<CreateSessionCallbackProxyAdvanced>(nameof(CreateAdvancedSession), WorldContextObject, ExtraSettings, PlayerController, PublicConnections, PrivateConnections, bUseLAN, bAllowInvites, bIsDedicatedServer, bUsePresence, bAllowJoinViaPresence, bAllowJoinViaPresenceFriendsOnly, bAntiCheatProtected, bUsesStats, bShouldAdvertise); }
    }
    public class EndSessionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public EndSessionCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public EndSessionCallbackProxy EndSession(Object WorldContextObject, PlayerController PlayerController) { return Invoke<EndSessionCallbackProxy>(nameof(EndSession), WorldContextObject, PlayerController); }
    }
    public class FindFriendSessionCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public FindFriendSessionCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public FindFriendSessionCallbackProxy FindFriendSession(Object WorldContextObject, PlayerController PlayerController, BPUniqueNetId FriendUniqueNetId) { return Invoke<FindFriendSessionCallbackProxy>(nameof(FindFriendSession), WorldContextObject, PlayerController, FriendUniqueNetId); }
    }
    public class FindSessionsCallbackProxyAdvanced : OnlineBlueprintCallProxyBase
    {
        public FindSessionsCallbackProxyAdvanced(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public FindSessionsCallbackProxyAdvanced FindSessionsAdvanced(Object WorldContextObject, PlayerController PlayerController, int MaxResults, bool bUseLAN, EBPServerPresenceSearchType ServerTypeToSearch, Array<SessionsSearchSetting> Filters, bool bEmptyServersOnly, bool bNonEmptyServersOnly, bool bSecureServersOnly, int MinSlotsAvailable) { return Invoke<FindSessionsCallbackProxyAdvanced>(nameof(FindSessionsAdvanced), WorldContextObject, PlayerController, MaxResults, bUseLAN, ServerTypeToSearch, Filters, bEmptyServersOnly, bNonEmptyServersOnly, bSecureServersOnly, MinSlotsAvailable); }
        public void FilterSessionResults(Array<BlueprintSessionResult> SessionResults, Array<SessionsSearchSetting> Filters, Array<BlueprintSessionResult> FilteredResults) { Invoke(nameof(FilterSessionResults), SessionResults, Filters, FilteredResults); }
    }
    public class GetFriendsCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public GetFriendsCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public GetFriendsCallbackProxy GetAndStoreFriendsList(Object WorldContextObject, PlayerController PlayerController) { return Invoke<GetFriendsCallbackProxy>(nameof(GetAndStoreFriendsList), WorldContextObject, PlayerController); }
    }
    public class GetRecentPlayersCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public GetRecentPlayersCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public GetRecentPlayersCallbackProxy GetAndStoreRecentPlayersList(Object WorldContextObject, BPUniqueNetId UniqueNetId) { return Invoke<GetRecentPlayersCallbackProxy>(nameof(GetAndStoreRecentPlayersList), WorldContextObject, UniqueNetId); }
    }
    public class GetUserPrivilegeCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public GetUserPrivilegeCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public GetUserPrivilegeCallbackProxy GetUserPrivilege(Object WorldContextObject, EBPUserPrivileges PrivilegeToCheck, BPUniqueNetId PlayerUniqueNetID) { return Invoke<GetUserPrivilegeCallbackProxy>(nameof(GetUserPrivilege), WorldContextObject, PrivilegeToCheck, PlayerUniqueNetID); }
    }
    public class LoginUserCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public LoginUserCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LoginUserCallbackProxy LoginUser(Object WorldContextObject, PlayerController PlayerController, Object UserId, Object UserToken) { return Invoke<LoginUserCallbackProxy>(nameof(LoginUser), WorldContextObject, PlayerController, UserId, UserToken); }
    }
    public class LogoutUserCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public LogoutUserCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LogoutUserCallbackProxy LogoutUser(Object WorldContextObject, PlayerController PlayerController) { return Invoke<LogoutUserCallbackProxy>(nameof(LogoutUser), WorldContextObject, PlayerController); }
    }
    public class SendFriendInviteCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public SendFriendInviteCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public SendFriendInviteCallbackProxy SendFriendInvite(Object WorldContextObject, PlayerController PlayerController, BPUniqueNetId UniqueNetIDInvited) { return Invoke<SendFriendInviteCallbackProxy>(nameof(SendFriendInvite), WorldContextObject, PlayerController, UniqueNetIDInvited); }
    }
    public class UpdateSessionCallbackProxyAdvanced : OnlineBlueprintCallProxyBase
    {
        public UpdateSessionCallbackProxyAdvanced(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public UpdateSessionCallbackProxyAdvanced UpdateSession(Object WorldContextObject, Array<SessionPropertyKeyPair> ExtraSettings, int PublicConnections, int PrivateConnections, bool bUseLAN, bool bAllowInvites, bool bAllowJoinInProgress, bool bRefreshOnlineData, bool bIsDedicatedServer) { return Invoke<UpdateSessionCallbackProxyAdvanced>(nameof(UpdateSession), WorldContextObject, ExtraSettings, PublicConnections, PrivateConnections, bUseLAN, bAllowInvites, bAllowJoinInProgress, bRefreshOnlineData, bIsDedicatedServer); }
    }
    public class BPFriendInfo : Object
    {
        public BPFriendInfo(ulong addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object RealName { get { return this[nameof(RealName)]; } set { this[nameof(RealName)] = value; } }
        public EBPOnlinePresenceState OnlineState { get { return (EBPOnlinePresenceState)this[nameof(OnlineState)].GetValue<int>(); } set { this[nameof(OnlineState)].SetValue<int>((int)value); } }
        public BPUniqueNetId UniqueNetId { get { return this[nameof(UniqueNetId)].As<BPUniqueNetId>(); } set { this["UniqueNetId"] = value; } }
        public bool bIsPlayingSameGame { get { return this[nameof(bIsPlayingSameGame)].Flag; } set { this[nameof(bIsPlayingSameGame)].Flag = value; } }
        public BPFriendPresenceInfo PresenceInfo { get { return this[nameof(PresenceInfo)].As<BPFriendPresenceInfo>(); } set { this["PresenceInfo"] = value; } }
    }
    public class BPFriendPresenceInfo : Object
    {
        public BPFriendPresenceInfo(ulong addr) : base(addr) { }
        public bool bIsOnline { get { return this[nameof(bIsOnline)].Flag; } set { this[nameof(bIsOnline)].Flag = value; } }
        public bool bIsPlaying { get { return this[nameof(bIsPlaying)].Flag; } set { this[nameof(bIsPlaying)].Flag = value; } }
        public bool bIsPlayingThisGame { get { return this[nameof(bIsPlayingThisGame)].Flag; } set { this[nameof(bIsPlayingThisGame)].Flag = value; } }
        public bool bIsJoinable { get { return this[nameof(bIsJoinable)].Flag; } set { this[nameof(bIsJoinable)].Flag = value; } }
        public bool bHasVoiceSupport { get { return this[nameof(bHasVoiceSupport)].Flag; } set { this[nameof(bHasVoiceSupport)].Flag = value; } }
        public EBPOnlinePresenceState PresenceState { get { return (EBPOnlinePresenceState)this[nameof(PresenceState)].GetValue<int>(); } set { this[nameof(PresenceState)].SetValue<int>((int)value); } }
        public Object StatusString { get { return this[nameof(StatusString)]; } set { this[nameof(StatusString)] = value; } }
    }
    public enum EBPOnlinePresenceState : int
    {
        Online = 0,
        Offline = 1,
        Away = 2,
        ExtendedAway = 3,
        DoNotDisturb = 4,
        Chat = 5,
        EBPOnlinePresenceState_MAX = 6,
    }
    public class BPUniqueNetId : Object
    {
        public BPUniqueNetId(ulong addr) : base(addr) { }
    }
    public class BPOnlineUser : Object
    {
        public BPOnlineUser(ulong addr) : base(addr) { }
        public BPUniqueNetId UniqueNetId { get { return this[nameof(UniqueNetId)].As<BPUniqueNetId>(); } set { this["UniqueNetId"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object RealName { get { return this[nameof(RealName)]; } set { this[nameof(RealName)] = value; } }
    }
    public class BPOnlineRecentPlayer : BPOnlineUser
    {
        public BPOnlineRecentPlayer(ulong addr) : base(addr) { }
        public Object LastSeen { get { return this[nameof(LastSeen)]; } set { this[nameof(LastSeen)] = value; } }
    }
    public enum EBPUserPrivileges : int
    {
        CanPlay = 0,
        CanPlayOnline = 1,
        CanCommunicateOnline = 2,
        CanUseUserGeneratedContent = 3,
        EBPUserPrivileges_MAX = 4,
    }
    public enum EOnlineComparisonOpRedux : int
    {
        Equals = 0,
        NotEquals = 1,
        GreaterThan = 2,
        GreaterThanEquals = 3,
        LessThan = 4,
        LessThanEquals = 5,
        EOnlineComparisonOpRedux_MAX = 6,
    }
    public enum EBPOnlineSessionState : int
    {
        NoSession = 0,
        Creating = 1,
        Pending = 2,
        Starting = 3,
        InProgress = 4,
        Ending = 5,
        Ended = 6,
        Destroying = 7,
        EBPOnlineSessionState_MAX = 8,
    }
    public enum EBPServerPresenceSearchType : int
    {
        AllServers = 0,
        ClientServersOnly = 1,
        DedicatedServersOnly = 2,
        EBPServerPresenceSearchType_MAX = 3,
    }
    public enum EBlueprintAsyncResultSwitch : int
    {
        OnSuccess = 0,
        AsyncLoading = 1,
        OnFailure = 2,
        EBlueprintAsyncResultSwitch_MAX = 3,
    }
    public enum EBlueprintResultSwitch : int
    {
        OnSuccess = 0,
        OnFailure = 1,
        EBlueprintResultSwitch_MAX = 2,
    }
    public enum ESessionSettingSearchResult : int
    {
        Found = 0,
        NotFound = 1,
        WrongType = 2,
        ESessionSettingSearchResult_MAX = 3,
    }
    public enum EBPLoginStatus : int
    {
        NotLoggedIn = 0,
        UsingLocalProfile = 1,
        LoggedIn = 2,
        EBPLoginStatus_MAX = 3,
    }
    public class SessionsSearchSetting : Object
    {
        public SessionsSearchSetting(ulong addr) : base(addr) { }
    }
    public class SessionPropertyKeyPair : Object
    {
        public SessionPropertyKeyPair(ulong addr) : base(addr) { }
    }
    public class BPUserOnlineAccount : Object
    {
        public BPUserOnlineAccount(ulong addr) : base(addr) { }
    }
}
