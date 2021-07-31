using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioAnalyzerSDK
{
    public class AudioAnalyzerAsset : Object
    {
        public AudioAnalyzerAsset(ulong addr) : base(addr) { }
    }
    public class AudioAnalyzerNRTSettings : AudioAnalyzerAsset
    {
        public AudioAnalyzerNRTSettings(ulong addr) : base(addr) { }
    }
    public class AudioAnalyzerNRT : AudioAnalyzerAsset
    {
        public AudioAnalyzerNRT(ulong addr) : base(addr) { }
        public SoundWave Sound { get { return this[nameof(Sound)].As<SoundWave>(); } set { this["Sound"] = value; } }
        public float DurationInSeconds { get { return this[nameof(DurationInSeconds)].GetValue<float>(); } set { this[nameof(DurationInSeconds)].SetValue<float>(value); } }
    }
}
