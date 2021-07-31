using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.AndroidPermissionSDK
{
    public class AndroidPermissionCallbackProxy : Object
    {
        public AndroidPermissionCallbackProxy(ulong addr) : base(addr) { }
        public Object OnPermissionsGrantedDynamicDelegate { get { return this[nameof(OnPermissionsGrantedDynamicDelegate)]; } set { this[nameof(OnPermissionsGrantedDynamicDelegate)] = value; } }
    }
    public class AndroidPermissionFunctionLibrary : BlueprintFunctionLibrary
    {
        public AndroidPermissionFunctionLibrary(ulong addr) : base(addr) { }
        public bool CheckPermission(Object permission) { return Invoke<bool>(nameof(CheckPermission), permission); }
        public AndroidPermissionCallbackProxy AcquirePermissions(Array<Object> Permissions) { return Invoke<AndroidPermissionCallbackProxy>(nameof(AcquirePermissions), Permissions); }
    }
}
