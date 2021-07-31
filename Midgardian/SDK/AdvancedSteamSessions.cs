using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.AdvancedSessionsSDK;
namespace SDK.Script.AdvancedSteamSessionsSDK
{
    public class AdvancedSteamFriendsLibrary : BlueprintFunctionLibrary
    {
        public AdvancedSteamFriendsLibrary(ulong addr) : base(addr) { }
        public bool RequestSteamFriendInfo(BPUniqueNetId UniqueNetId, bool bRequireNameOnly) { return Invoke<bool>(nameof(RequestSteamFriendInfo), UniqueNetId, bRequireNameOnly); }
        public bool OpenSteamUserOverlay(BPUniqueNetId UniqueNetId, ESteamUserOverlayType DialogType) { return Invoke<bool>(nameof(OpenSteamUserOverlay), UniqueNetId, DialogType); }
        public Object GetSteamPersonaName(BPUniqueNetId UniqueNetId) { return Invoke<Object>(nameof(GetSteamPersonaName), UniqueNetId); }
        public void GetSteamGroups(Array<BPSteamGroupInfo> SteamGroups) { Invoke(nameof(GetSteamGroups), SteamGroups); }
        public void GetSteamFriendGamePlayed(BPUniqueNetId UniqueNetId, EBlueprintResultSwitch Result, int AppId) { Invoke(nameof(GetSteamFriendGamePlayed), UniqueNetId, Result, AppId); }
        public Texture2D GetSteamFriendAvatar(BPUniqueNetId UniqueNetId, EBlueprintAsyncResultSwitch Result, SteamAvatarSize AvatarSize) { return Invoke<Texture2D>(nameof(GetSteamFriendAvatar), UniqueNetId, Result, AvatarSize); }
        public BPUniqueNetId GetLocalSteamIDFromSteam() { return Invoke<BPUniqueNetId>(nameof(GetLocalSteamIDFromSteam)); }
        public int GetFriendSteamLevel(BPUniqueNetId UniqueNetId) { return Invoke<int>(nameof(GetFriendSteamLevel), UniqueNetId); }
        public BPUniqueNetId CreateSteamIDFromString(Object SteamID64) { return Invoke<BPUniqueNetId>(nameof(CreateSteamIDFromString), SteamID64); }
    }
    public class AdvancedSteamWorkshopLibrary : BlueprintFunctionLibrary
    {
        public AdvancedSteamWorkshopLibrary(ulong addr) : base(addr) { }
        public Array<BPSteamWorkshopID> GetSubscribedWorkshopItems(int NumberOfItems) { return Invoke<Array<BPSteamWorkshopID>>(nameof(GetSubscribedWorkshopItems), NumberOfItems); }
        public void GetNumSubscribedWorkshopItems(int NumberOfItems) { Invoke(nameof(GetNumSubscribedWorkshopItems), NumberOfItems); }
    }
    public class SteamRequestGroupOfficersCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public SteamRequestGroupOfficersCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public SteamRequestGroupOfficersCallbackProxy GetSteamGroupOfficerList(Object WorldContextObject, BPUniqueNetId GroupUniqueNetID) { return Invoke<SteamRequestGroupOfficersCallbackProxy>(nameof(GetSteamGroupOfficerList), WorldContextObject, GroupUniqueNetID); }
    }
    public class SteamWSRequestUGCDetailsCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public SteamWSRequestUGCDetailsCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public SteamWSRequestUGCDetailsCallbackProxy GetWorkshopItemDetails(Object WorldContextObject, BPSteamWorkshopID WorkShopID) { return Invoke<SteamWSRequestUGCDetailsCallbackProxy>(nameof(GetWorkshopItemDetails), WorldContextObject, WorkShopID); }
    }
    public class BPSteamGroupOfficer : Object
    {
        public BPSteamGroupOfficer(ulong addr) : base(addr) { }
        public BPUniqueNetId OfficerUniqueNetID { get { return this[nameof(OfficerUniqueNetID)].As<BPUniqueNetId>(); } set { this["OfficerUniqueNetID"] = value; } }
        public bool bIsOwner { get { return this[nameof(bIsOwner)].Flag; } set { this[nameof(bIsOwner)].Flag = value; } }
    }
    public class BPSteamWorkshopItemDetails : Object
    {
        public BPSteamWorkshopItemDetails(ulong addr) : base(addr) { }
        public FBPSteamResult ResultOfRequest { get { return (FBPSteamResult)this[nameof(ResultOfRequest)].GetValue<int>(); } set { this[nameof(ResultOfRequest)].SetValue<int>((int)value); } }
        public FBPWorkshopFileType FileType { get { return (FBPWorkshopFileType)this[nameof(FileType)].GetValue<int>(); } set { this[nameof(FileType)].SetValue<int>((int)value); } }
        public int CreatorAppID { get { return this[nameof(CreatorAppID)].GetValue<int>(); } set { this[nameof(CreatorAppID)].SetValue<int>(value); } }
        public int ConsumerAppID { get { return this[nameof(ConsumerAppID)].GetValue<int>(); } set { this[nameof(ConsumerAppID)].SetValue<int>(value); } }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object ItemUrl { get { return this[nameof(ItemUrl)]; } set { this[nameof(ItemUrl)] = value; } }
        public int VotesUp { get { return this[nameof(VotesUp)].GetValue<int>(); } set { this[nameof(VotesUp)].SetValue<int>(value); } }
        public int VotesDown { get { return this[nameof(VotesDown)].GetValue<int>(); } set { this[nameof(VotesDown)].SetValue<int>(value); } }
        public float CalculatedScore { get { return this[nameof(CalculatedScore)].GetValue<float>(); } set { this[nameof(CalculatedScore)].SetValue<float>(value); } }
        public bool bBanned { get { return this[nameof(bBanned)].Flag; } set { this[nameof(bBanned)].Flag = value; } }
        public bool bAcceptedForUse { get { return this[nameof(bAcceptedForUse)].Flag; } set { this[nameof(bAcceptedForUse)].Flag = value; } }
        public bool bTagsTruncated { get { return this[nameof(bTagsTruncated)].Flag; } set { this[nameof(bTagsTruncated)].Flag = value; } }
        public Object CreatorSteamID { get { return this[nameof(CreatorSteamID)]; } set { this[nameof(CreatorSteamID)] = value; } }
    }
    public enum FBPWorkshopFileType : int
    {
        k_EWorkshopFileTypeCommunity = 0,
        k_EWorkshopFileTypeMicrotransaction = 1,
        k_EWorkshopFileTypeCollection = 2,
        k_EWorkshopFileTypeArt = 3,
        k_EWorkshopFileTypeVideo = 4,
        k_EWorkshopFileTypeScreenshot = 5,
        k_EWorkshopFileTypeGame = 6,
        k_EWorkshopFileTypeSoftware = 7,
        k_EWorkshopFileTypeConcept = 8,
        k_EWorkshopFileTypeWebGuide = 9,
        k_EWorkshopFileTypeIntegratedGuide = 10,
        k_EWorkshopFileTypeMerch = 11,
        k_EWorkshopFileTypeControllerBinding = 12,
        k_EWorkshopFileTypeSteamworksAccessInvite = 13,
        k_EWorkshopFileTypeSteamVideo = 14,
        k_EWorkshopFileTypeMax = 15,
        k_MAX = 16,
    }
    public enum FBPSteamResult : int
    {
        K_EResultInvalid = 0,
        k_EResultOK = 1,
        k_EResultFail = 2,
        k_EResultNoConnection = 3,
        k_EResultInvalidPassword = 5,
        k_EResultLoggedInElsewhere = 6,
        k_EResultInvalidProtocolVer = 7,
        k_EResultInvalidParam = 8,
        k_EResultFileNotFound = 9,
        k_EResultBusy = 10,
        k_EResultInvalidState = 11,
        k_EResultInvalidName = 12,
        k_EResultInvalidEmail = 13,
        k_EResultDuplicateName = 14,
        k_EResultAccessDenied = 15,
        k_EResultTimeout = 16,
        k_EResultBanned = 17,
        k_EResultAccountNotFound = 18,
        k_EResultInvalidSteamID = 19,
        k_EResultServiceUnavailable = 20,
        k_EResultNotLoggedOn = 21,
        k_EResultPending = 22,
        k_EResultEncryptionFailure = 23,
        k_EResultInsufficientPrivilege = 24,
        k_EResultLimitExceeded = 25,
        k_EResultRevoked = 26,
        k_EResultExpired = 27,
        k_EResultAlreadyRedeemed = 28,
        k_EResultDuplicateRequest = 29,
        k_EResultAlreadyOwned = 30,
        k_EResultIPNotFound = 31,
        k_EResultPersistFailed = 32,
        k_EResultLockingFailed = 33,
        k_EResultLogonSessionReplaced = 34,
        k_EResultConnectFailed = 35,
        k_EResultHandshakeFailed = 36,
        k_EResultIOFailure = 37,
        k_EResultRemoteDisconnect = 38,
        k_EResultShoppingCartNotFound = 39,
        k_EResultBlocked = 40,
        k_EResultIgnored = 41,
        k_EResultNoMatch = 42,
        k_EResultAccountDisabled = 43,
        k_EResultServiceReadOnly = 44,
        k_EResultAccountNotFeatured = 45,
        k_EResultAdministratorOK = 46,
        k_EResultContentVersion = 47,
        k_EResultTryAnotherCM = 48,
        k_EResultPasswordRequiredToKickSession = 49,
        k_EResultAlreadyLoggedInElsewhere = 50,
        k_EResultSuspended = 51,
        k_EResultCancelled = 52,
        k_EResultDataCorruption = 53,
        k_EResultDiskFull = 54,
        k_EResultRemoteCallFailed = 55,
        k_EResultPasswordUnset = 56,
        k_EResultExternalAccountUnlinked = 57,
        k_EResultPSNTicketInvalid = 58,
        k_EResultExternalAccountAlreadyLinked = 59,
        k_EResultRemoteFileConflict = 60,
        k_EResultIllegalPassword = 61,
        k_EResultSameAsPreviousValue = 62,
        k_EResultAccountLogonDenied = 63,
        k_EResultCannotUseOldPassword = 64,
        k_EResultInvalidLoginAuthCode = 65,
        k_EResultAccountLogonDeniedNoMail = 66,
        k_EResultHardwareNotCapableOfIPT = 67,
        k_EResultIPTInitError = 68,
        k_EResultParentalControlRestricted = 69,
        k_EResultFacebookQueryError = 70,
        k_EResultExpiredLoginAuthCode = 71,
        k_EResultIPLoginRestrictionFailed = 72,
        k_EResultAccountLockedDown = 73,
        k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
        k_EResultNoMatchingURL = 75,
        k_EResultBadResponse = 76,
        k_EResultRequirePasswordReEntry = 77,
        k_EResultValueOutOfRange = 78,
        k_EResultUnexpectedError = 79,
        k_EResultDisabled = 80,
        k_EResultInvalidCEGSubmission = 81,
        k_EResultRestrictedDevice = 82,
        k_EResultRegionLocked = 83,
        k_EResultRateLimitExceeded = 84,
        k_EResultAccountLoginDeniedNeedTwoFactor = 85,
        k_EResultItemDeleted = 86,
        k_EResultAccountLoginDeniedThrottle = 87,
        k_EResultTwoFactorCodeMismatch = 88,
        k_EResultTwoFactorActivationCodeMismatch = 89,
        k_EResultAccountAssociatedToMultiplePartners = 90,
        k_EResultNotModified = 91,
        FBPSteamResult_MAX = 92,
    }
    public enum ESteamUserOverlayType : int
    {
        steamid = 0,
        chat = 1,
        jointrade = 2,
        stats = 3,
        achievements = 4,
        friendadd = 5,
        friendremove = 6,
        friendrequestaccept = 7,
        friendrequestignore = 8,
        ESteamUserOverlayType_MAX = 9,
    }
    public enum SteamAvatarSize : int
    {
        SteamAvatar_INVALID = 0,
        SteamAvatar_Small = 1,
        SteamAvatar_Medium = 2,
        SteamAvatar_Large = 3,
        SteamAvatar_MAX = 4,
    }
    public class BPSteamGroupInfo : Object
    {
        public BPSteamGroupInfo(ulong addr) : base(addr) { }
        public BPUniqueNetId GroupID { get { return this[nameof(GroupID)].As<BPUniqueNetId>(); } set { this["GroupID"] = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public Object GroupTag { get { return this[nameof(GroupTag)]; } set { this[nameof(GroupTag)] = value; } }
        public int numOnline { get { return this[nameof(numOnline)].GetValue<int>(); } set { this[nameof(numOnline)].SetValue<int>(value); } }
        public int numInGame { get { return this[nameof(numInGame)].GetValue<int>(); } set { this[nameof(numInGame)].SetValue<int>(value); } }
        public int numChatting { get { return this[nameof(numChatting)].GetValue<int>(); } set { this[nameof(numChatting)].SetValue<int>(value); } }
    }
    public class BPSteamWorkshopID : Object
    {
        public BPSteamWorkshopID(ulong addr) : base(addr) { }
    }
}
