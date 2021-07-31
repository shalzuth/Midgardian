using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.OnlineSubsystemUtilsBifrostSDK
{
    public class CheckUserOnlinePrivilegeProxy : BlueprintAsyncActionBase
    {
        public CheckUserOnlinePrivilegeProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CheckUserOnlinePrivilegeProxy CheckOnlinePrivilege(Object WorldContextObject, PlayerController InPlayerController) { return Invoke<CheckUserOnlinePrivilegeProxy>(nameof(CheckOnlinePrivilege), WorldContextObject, InPlayerController); }
    }
    public class CheckUserPrivilegeProxy : BlueprintAsyncActionBase
    {
        public CheckUserPrivilegeProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CheckUserPrivilegeProxy CheckPrivilege(Object WorldContextObject, EBPBifrostUserPrivileges PrivilegeToCheck, PlayerController InPlayerController) { return Invoke<CheckUserPrivilegeProxy>(nameof(CheckPrivilege), WorldContextObject, PrivilegeToCheck, InPlayerController); }
    }
    public class JoinSessionWithParamsCallbackProxy : OnlineBlueprintCallProxyBase
    {
        public JoinSessionWithParamsCallbackProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public JoinSessionWithParamsCallbackProxy JoinSessionWithParams(Object WorldContextObject, PlayerController PlayerController, BlueprintSessionResult SearchResult, Object Params) { return Invoke<JoinSessionWithParamsCallbackProxy>(nameof(JoinSessionWithParams), WorldContextObject, PlayerController, SearchResult, Params); }
    }
    public enum EBPBifrostUserPrivileges : int
    {
        CanPlay = 0,
        CanPlayOnline = 1,
        CanCommunicateOnline = 2,
        CanUseUserGeneratedContent = 3,
        CanUserCrossPlay = 4,
        EBPBifrostUserPrivileges_MAX = 5,
    }
}
