using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.WmfMediaFactorySDK
{
    public class WmfMediaSettings : Object
    {
        public WmfMediaSettings(ulong addr) : base(addr) { }
        public bool AllowNonStandardCodecs { get { return this[nameof(AllowNonStandardCodecs)].Flag; } set { this[nameof(AllowNonStandardCodecs)].Flag = value; } }
        public bool LowLatency { get { return this[nameof(LowLatency)].Flag; } set { this[nameof(LowLatency)].Flag = value; } }
        public bool NativeAudioOut { get { return this[nameof(NativeAudioOut)].Flag; } set { this[nameof(NativeAudioOut)].Flag = value; } }
        public bool HardwareAcceleratedVideoDecoding { get { return this[nameof(HardwareAcceleratedVideoDecoding)].Flag; } set { this[nameof(HardwareAcceleratedVideoDecoding)].Flag = value; } }
    }
}
