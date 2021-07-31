using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SignificanceManagerSDK
{
    public class SignificanceManager : Object
    {
        public SignificanceManager(ulong addr) : base(addr) { }
        public SoftClassPath SignificanceManagerClassName { get { return this[nameof(SignificanceManagerClassName)].As<SoftClassPath>(); } set { this["SignificanceManagerClassName"] = value; } }
    }
}
