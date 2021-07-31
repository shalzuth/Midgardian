using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.AvfMediaFactorySDK
{
    public class AvfMediaSettings : Object
    {
        public AvfMediaSettings(ulong addr) : base(addr) { }
        public bool NativeAudioOut { get { return this[nameof(NativeAudioOut)].Flag; } set { this[nameof(NativeAudioOut)].Flag = value; } }
    }
}
