using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.AudioMixerSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioCaptureSDK
{
    public class AudioCapture : AudioGenerator
    {
        public AudioCapture(ulong addr) : base(addr) { }
        public void StopCapturingAudio() { Invoke(nameof(StopCapturingAudio)); }
        public void StartCapturingAudio() { Invoke(nameof(StartCapturingAudio)); }
        public bool IsCapturingAudio() { return Invoke<bool>(nameof(IsCapturingAudio)); }
        public bool GetAudioCaptureDeviceInfo(AudioCaptureDeviceInfo OutInfo) { return Invoke<bool>(nameof(GetAudioCaptureDeviceInfo), OutInfo); }
    }
    public class AudioCaptureFunctionLibrary : BlueprintFunctionLibrary
    {
        public AudioCaptureFunctionLibrary(ulong addr) : base(addr) { }
        public AudioCapture CreateAudioCapture() { return Invoke<AudioCapture>(nameof(CreateAudioCapture)); }
    }
    public class AudioCaptureComponent : SynthComponent
    {
        public AudioCaptureComponent(ulong addr) : base(addr) { }
        public int JitterLatencyFrames { get { return this[nameof(JitterLatencyFrames)].GetValue<int>(); } set { this[nameof(JitterLatencyFrames)].SetValue<int>(value); } }
    }
    public class AudioCaptureDeviceInfo : Object
    {
        public AudioCaptureDeviceInfo(ulong addr) : base(addr) { }
        public Object DeviceName { get { return this[nameof(DeviceName)]; } set { this[nameof(DeviceName)] = value; } }
        public int NumInputChannels { get { return this[nameof(NumInputChannels)].GetValue<int>(); } set { this[nameof(NumInputChannels)].SetValue<int>(value); } }
        public int SampleRate { get { return this[nameof(SampleRate)].GetValue<int>(); } set { this[nameof(SampleRate)].SetValue<int>(value); } }
    }
}
