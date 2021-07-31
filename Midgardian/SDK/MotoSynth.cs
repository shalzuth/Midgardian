using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.AudioMixerSDK;
namespace SDK.Script.MotoSynthSDK
{
    public class MotoSynthPreset : Object
    {
        public MotoSynthPreset(ulong addr) : base(addr) { }
        public MotoSynthRuntimeSettings Settings { get { return this[nameof(Settings)].As<MotoSynthRuntimeSettings>(); } set { this["Settings"] = value; } }
    }
    public class MotoSynthSource : Object
    {
        public MotoSynthSource(ulong addr) : base(addr) { }
        public bool bConvertTo8Bit { get { return this[nameof(bConvertTo8Bit)].Flag; } set { this[nameof(bConvertTo8Bit)].Flag = value; } }
        public float DownSampleFactor { get { return this[nameof(DownSampleFactor)].GetValue<float>(); } set { this[nameof(DownSampleFactor)].SetValue<float>(value); } }
        public RuntimeFloatCurve RPMCurve { get { return this[nameof(RPMCurve)].As<RuntimeFloatCurve>(); } set { this["RPMCurve"] = value; } }
        public Array<float> SourceData { get { return new Array<float>(this[nameof(SourceData)].Address); } }
        public Array<short> SourceDataPCM { get { return new Array<short>(this[nameof(SourceDataPCM)].Address); } }
        public int SourceSampleRate { get { return this[nameof(SourceSampleRate)].GetValue<int>(); } set { this[nameof(SourceSampleRate)].SetValue<int>(value); } }
        public Array<GrainTableEntry> GrainTable { get { return new Array<GrainTableEntry>(this[nameof(GrainTable)].Address); } }
    }
    public class SynthComponentMoto : SynthComponent
    {
        public SynthComponentMoto(ulong addr) : base(addr) { }
        public MotoSynthPreset MotoSynthPreset { get { return this[nameof(MotoSynthPreset)].As<MotoSynthPreset>(); } set { this["MotoSynthPreset"] = value; } }
        public float RPM { get { return this[nameof(RPM)].GetValue<float>(); } set { this[nameof(RPM)].SetValue<float>(value); } }
        public void SetSettings(MotoSynthRuntimeSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public void SetRPM(float InRPM, float InTimeSec) { Invoke(nameof(SetRPM), InRPM, InTimeSec); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public void GetRPMRange(float OutMinRPM, float OutMaxRPM) { Invoke(nameof(GetRPMRange), OutMinRPM, OutMaxRPM); }
    }
    public class MotoSynthRuntimeSettings : Object
    {
        public MotoSynthRuntimeSettings(ulong addr) : base(addr) { }
        public bool bSynthToneEnabled { get { return this[nameof(bSynthToneEnabled)].Flag; } set { this[nameof(bSynthToneEnabled)].Flag = value; } }
        public float SynthToneVolume { get { return this[nameof(SynthToneVolume)].GetValue<float>(); } set { this[nameof(SynthToneVolume)].SetValue<float>(value); } }
        public float SynthToneFilterFrequency { get { return this[nameof(SynthToneFilterFrequency)].GetValue<float>(); } set { this[nameof(SynthToneFilterFrequency)].SetValue<float>(value); } }
        public int SynthOctaveShift { get { return this[nameof(SynthOctaveShift)].GetValue<int>(); } set { this[nameof(SynthOctaveShift)].SetValue<int>(value); } }
        public bool bGranularEngineEnabled { get { return this[nameof(bGranularEngineEnabled)].Flag; } set { this[nameof(bGranularEngineEnabled)].Flag = value; } }
        public float GranularEngineVolume { get { return this[nameof(GranularEngineVolume)].GetValue<float>(); } set { this[nameof(GranularEngineVolume)].SetValue<float>(value); } }
        public float GranularEnginePitchScale { get { return this[nameof(GranularEnginePitchScale)].GetValue<float>(); } set { this[nameof(GranularEnginePitchScale)].SetValue<float>(value); } }
        public int NumSamplesToCrossfadeBetweenGrains { get { return this[nameof(NumSamplesToCrossfadeBetweenGrains)].GetValue<int>(); } set { this[nameof(NumSamplesToCrossfadeBetweenGrains)].SetValue<int>(value); } }
        public int NumGrainTableEntriesPerGrain { get { return this[nameof(NumGrainTableEntriesPerGrain)].GetValue<int>(); } set { this[nameof(NumGrainTableEntriesPerGrain)].SetValue<int>(value); } }
        public int GrainTableRandomOffsetForConstantRPMs { get { return this[nameof(GrainTableRandomOffsetForConstantRPMs)].GetValue<int>(); } set { this[nameof(GrainTableRandomOffsetForConstantRPMs)].SetValue<int>(value); } }
        public int GrainCrossfadeSamplesForConstantRPMs { get { return this[nameof(GrainCrossfadeSamplesForConstantRPMs)].GetValue<int>(); } set { this[nameof(GrainCrossfadeSamplesForConstantRPMs)].SetValue<int>(value); } }
        public MotoSynthSource AccelerationSource { get { return this[nameof(AccelerationSource)].As<MotoSynthSource>(); } set { this["AccelerationSource"] = value; } }
        public MotoSynthSource DecelerationSource { get { return this[nameof(DecelerationSource)].As<MotoSynthSource>(); } set { this["DecelerationSource"] = value; } }
        public bool bStereoWidenerEnabled { get { return this[nameof(bStereoWidenerEnabled)].Flag; } set { this[nameof(bStereoWidenerEnabled)].Flag = value; } }
        public float StereoDelayMsec { get { return this[nameof(StereoDelayMsec)].GetValue<float>(); } set { this[nameof(StereoDelayMsec)].SetValue<float>(value); } }
        public float StereoFeedback { get { return this[nameof(StereoFeedback)].GetValue<float>(); } set { this[nameof(StereoFeedback)].SetValue<float>(value); } }
        public float StereoWidenerWetlevel { get { return this[nameof(StereoWidenerWetlevel)].GetValue<float>(); } set { this[nameof(StereoWidenerWetlevel)].SetValue<float>(value); } }
        public float StereoWidenerDryLevel { get { return this[nameof(StereoWidenerDryLevel)].GetValue<float>(); } set { this[nameof(StereoWidenerDryLevel)].SetValue<float>(value); } }
        public float StereoWidenerDelayRatio { get { return this[nameof(StereoWidenerDelayRatio)].GetValue<float>(); } set { this[nameof(StereoWidenerDelayRatio)].SetValue<float>(value); } }
        public bool bStereoWidenerFilterEnabled { get { return this[nameof(bStereoWidenerFilterEnabled)].Flag; } set { this[nameof(bStereoWidenerFilterEnabled)].Flag = value; } }
        public float StereoWidenerFilterFrequency { get { return this[nameof(StereoWidenerFilterFrequency)].GetValue<float>(); } set { this[nameof(StereoWidenerFilterFrequency)].SetValue<float>(value); } }
        public float StereoWidenerFilterQ { get { return this[nameof(StereoWidenerFilterQ)].GetValue<float>(); } set { this[nameof(StereoWidenerFilterQ)].SetValue<float>(value); } }
    }
    public class GrainTableEntry : Object
    {
        public GrainTableEntry(ulong addr) : base(addr) { }
        public int SampleIndex { get { return this[nameof(SampleIndex)].GetValue<int>(); } set { this[nameof(SampleIndex)].SetValue<int>(value); } }
        public float RPM { get { return this[nameof(RPM)].GetValue<float>(); } set { this[nameof(RPM)].SetValue<float>(value); } }
    }
}
