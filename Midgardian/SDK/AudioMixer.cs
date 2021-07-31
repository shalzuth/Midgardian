using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioMixerSDK
{
    public class SynthComponent : SceneComponent
    {
        public SynthComponent(ulong addr) : base(addr) { }
        public bool bAutoDestroy { get { return this[nameof(bAutoDestroy)].Flag; } set { this[nameof(bAutoDestroy)].Flag = value; } }
        public bool bStopWhenOwnerDestroyed { get { return this[nameof(bStopWhenOwnerDestroyed)].Flag; } set { this[nameof(bStopWhenOwnerDestroyed)].Flag = value; } }
        public bool bAllowSpatialization { get { return this[nameof(bAllowSpatialization)].Flag; } set { this[nameof(bAllowSpatialization)].Flag = value; } }
        public bool bOverrideAttenuation { get { return this[nameof(bOverrideAttenuation)].Flag; } set { this[nameof(bOverrideAttenuation)].Flag = value; } }
        public bool bOutputToBusOnly { get { return this[nameof(bOutputToBusOnly)].Flag; } set { this[nameof(bOutputToBusOnly)].Flag = value; } }
        public SoundAttenuation AttenuationSettings { get { return this[nameof(AttenuationSettings)].As<SoundAttenuation>(); } set { this["AttenuationSettings"] = value; } }
        public SoundAttenuationSettings AttenuationOverrides { get { return this[nameof(AttenuationOverrides)].As<SoundAttenuationSettings>(); } set { this["AttenuationOverrides"] = value; } }
        public SoundConcurrency ConcurrencySettings { get { return this[nameof(ConcurrencySettings)].As<SoundConcurrency>(); } set { this["ConcurrencySettings"] = value; } }
        public Object ConcurrencySet { get { return this[nameof(ConcurrencySet)]; } set { this[nameof(ConcurrencySet)] = value; } }
        public SoundClass SoundClass { get { return this[nameof(SoundClass)].As<SoundClass>(); } set { this["SoundClass"] = value; } }
        public SoundEffectSourcePresetChain SourceEffectChain { get { return this[nameof(SourceEffectChain)].As<SoundEffectSourcePresetChain>(); } set { this["SourceEffectChain"] = value; } }
        public SoundSubmixBase SoundSubmix { get { return this[nameof(SoundSubmix)].As<SoundSubmixBase>(); } set { this["SoundSubmix"] = value; } }
        public Array<SoundSubmixSendInfo> SoundSubmixSends { get { return new Array<SoundSubmixSendInfo>(this[nameof(SoundSubmixSends)].Address); } }
        public Array<SoundSourceBusSendInfo> BusSends { get { return new Array<SoundSourceBusSendInfo>(this[nameof(BusSends)].Address); } }
        public Array<SoundSourceBusSendInfo> PreEffectBusSends { get { return new Array<SoundSourceBusSendInfo>(this[nameof(PreEffectBusSends)].Address); } }
        public bool bIsUISound { get { return this[nameof(bIsUISound)].Flag; } set { this[nameof(bIsUISound)].Flag = value; } }
        public bool bIsPreviewSound { get { return this[nameof(bIsPreviewSound)].Flag; } set { this[nameof(bIsPreviewSound)].Flag = value; } }
        public int EnvelopeFollowerAttackTime { get { return this[nameof(EnvelopeFollowerAttackTime)].GetValue<int>(); } set { this[nameof(EnvelopeFollowerAttackTime)].SetValue<int>(value); } }
        public int EnvelopeFollowerReleaseTime { get { return this[nameof(EnvelopeFollowerReleaseTime)].GetValue<int>(); } set { this[nameof(EnvelopeFollowerReleaseTime)].SetValue<int>(value); } }
        public Object OnAudioEnvelopeValue { get { return this[nameof(OnAudioEnvelopeValue)]; } set { this[nameof(OnAudioEnvelopeValue)] = value; } }
        public SynthSound Synth { get { return this[nameof(Synth)].As<SynthSound>(); } set { this["Synth"] = value; } }
        public AudioComponent AudioComponent { get { return this[nameof(AudioComponent)].As<AudioComponent>(); } set { this["AudioComponent"] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
        public void Start() { Invoke(nameof(Start)); }
        public void SetVolumeMultiplier(float VolumeMultiplier) { Invoke(nameof(SetVolumeMultiplier), VolumeMultiplier); }
        public void SetSubmixSend(SoundSubmixBase Submix, float SendLevel) { Invoke(nameof(SetSubmixSend), Submix, SendLevel); }
        public void SetLowPassFilterFrequency(float InLowPassFilterFrequency) { Invoke(nameof(SetLowPassFilterFrequency), InLowPassFilterFrequency); }
        public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled) { Invoke(nameof(SetLowPassFilterEnabled), InLowPassFilterEnabled); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
    }
    public class AudioGenerator : Object
    {
        public AudioGenerator(ulong addr) : base(addr) { }
    }
    public class AudioMixerBlueprintLibrary : BlueprintFunctionLibrary
    {
        public AudioMixerBlueprintLibrary(ulong addr) : base(addr) { }
        public float TrimAudioCache(float InMegabytesToFree) { return Invoke<float>(nameof(TrimAudioCache), InMegabytesToFree); }
        public SoundWave StopRecordingOutput(Object WorldContextObject, EAudioRecordingExportType ExportType, Object Name, Object Path, SoundSubmix SubmixToRecord, SoundWave ExistingSoundWaveToOverwrite) { return Invoke<SoundWave>(nameof(StopRecordingOutput), WorldContextObject, ExportType, Name, Path, SubmixToRecord, ExistingSoundWaveToOverwrite); }
        public void StopAudioBus(Object WorldContextObject, AudioBus AudioBus) { Invoke(nameof(StopAudioBus), WorldContextObject, AudioBus); }
        public void StopAnalyzingOutput(Object WorldContextObject, SoundSubmix SubmixToStopAnalyzing) { Invoke(nameof(StopAnalyzingOutput), WorldContextObject, SubmixToStopAnalyzing); }
        public void StartRecordingOutput(Object WorldContextObject, float ExpectedDuration, SoundSubmix SubmixToRecord) { Invoke(nameof(StartRecordingOutput), WorldContextObject, ExpectedDuration, SubmixToRecord); }
        public void StartAudioBus(Object WorldContextObject, AudioBus AudioBus) { Invoke(nameof(StartAudioBus), WorldContextObject, AudioBus); }
        public void StartAnalyzingOutput(Object WorldContextObject, SoundSubmix SubmixToAnalyze, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType) { Invoke(nameof(StartAnalyzingOutput), WorldContextObject, SubmixToAnalyze, FFTSize, InterpolationMethod, WindowType, HopSize, SpectrumType); }
        public void SetSubmixEffectChainOverride(Object WorldContextObject, SoundSubmix SoundSubmix, Array<SoundEffectSubmixPreset> SubmixEffectPresetChain, float FadeTimeSec) { Invoke(nameof(SetSubmixEffectChainOverride), WorldContextObject, SoundSubmix, SubmixEffectPresetChain, FadeTimeSec); }
        public void SetBypassSourceEffectChainEntry(Object WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed) { Invoke(nameof(SetBypassSourceEffectChainEntry), WorldContextObject, PresetChain, EntryIndex, bBypassed); }
        public void ResumeRecordingOutput(Object WorldContextObject, SoundSubmix SubmixToPause) { Invoke(nameof(ResumeRecordingOutput), WorldContextObject, SubmixToPause); }
        public void ReplaceSoundEffectSubmix(Object WorldContextObject, SoundSubmix InSoundSubmix, int SubmixChainIndex, SoundEffectSubmixPreset SubmixEffectPreset) { Invoke(nameof(ReplaceSoundEffectSubmix), WorldContextObject, InSoundSubmix, SubmixChainIndex, SubmixEffectPreset); }
        public void RemoveSubmixEffectPresetAtIndex(Object WorldContextObject, SoundSubmix SoundSubmix, int SubmixChainIndex) { Invoke(nameof(RemoveSubmixEffectPresetAtIndex), WorldContextObject, SoundSubmix, SubmixChainIndex); }
        public void RemoveSubmixEffectPreset(Object WorldContextObject, SoundSubmix SoundSubmix, SoundEffectSubmixPreset SubmixEffectPreset) { Invoke(nameof(RemoveSubmixEffectPreset), WorldContextObject, SoundSubmix, SubmixEffectPreset); }
        public void RemoveSourceEffectFromPresetChain(Object WorldContextObject, SoundEffectSourcePresetChain PresetChain, int EntryIndex) { Invoke(nameof(RemoveSourceEffectFromPresetChain), WorldContextObject, PresetChain, EntryIndex); }
        public void RemoveMasterSubmixEffect(Object WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset) { Invoke(nameof(RemoveMasterSubmixEffect), WorldContextObject, SubmixEffectPreset); }
        public void PrimeSoundForPlayback(SoundWave SoundWave, Object OnLoadCompletion) { Invoke(nameof(PrimeSoundForPlayback), SoundWave, OnLoadCompletion); }
        public void PrimeSoundCueForPlayback(SoundCue SoundCue) { Invoke(nameof(PrimeSoundCueForPlayback), SoundCue); }
        public void PauseRecordingOutput(Object WorldContextObject, SoundSubmix SubmixToPause) { Invoke(nameof(PauseRecordingOutput), WorldContextObject, SubmixToPause); }
        public Array<SoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands, int InAttackTimeMsec, int InReleaseTimeMsec) { return Invoke<Array<SoundSubmixSpectralAnalysisBandSettings>>(nameof(MakePresetSpectralAnalysisBandSettings), InBandPresetType, InNumBands, InAttackTimeMsec, InReleaseTimeMsec); }
        public Array<SoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones, EMusicalNoteName InStartingMusicalNote, int InStartingOctave, int InAttackTimeMsec, int InReleaseTimeMsec) { return Invoke<Array<SoundSubmixSpectralAnalysisBandSettings>>(nameof(MakeMusicalSpectralAnalysisBandSettings), InNumSemitones, InStartingMusicalNote, InStartingOctave, InAttackTimeMsec, InReleaseTimeMsec); }
        public Array<SoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands, float InMinimumFrequency, float InMaximumFrequency, int InAttackTimeMsec, int InReleaseTimeMsec) { return Invoke<Array<SoundSubmixSpectralAnalysisBandSettings>>(nameof(MakeFullSpectrumSpectralAnalysisBandSettings), InNumBands, InMinimumFrequency, InMaximumFrequency, InAttackTimeMsec, InReleaseTimeMsec); }
        public bool IsAudioBusActive(Object WorldContextObject, AudioBus AudioBus) { return Invoke<bool>(nameof(IsAudioBusActive), WorldContextObject, AudioBus); }
        public void GetPhaseForFrequencies(Object WorldContextObject, Array<float> Frequencies, Array<float> Phases, SoundSubmix SubmixToAnalyze) { Invoke(nameof(GetPhaseForFrequencies), WorldContextObject, Frequencies, Phases, SubmixToAnalyze); }
        public int GetNumberOfEntriesInSourceEffectChain(Object WorldContextObject, SoundEffectSourcePresetChain PresetChain) { return Invoke<int>(nameof(GetNumberOfEntriesInSourceEffectChain), WorldContextObject, PresetChain); }
        public void GetMagnitudeForFrequencies(Object WorldContextObject, Array<float> Frequencies, Array<float> Magnitudes, SoundSubmix SubmixToAnalyze) { Invoke(nameof(GetMagnitudeForFrequencies), WorldContextObject, Frequencies, Magnitudes, SubmixToAnalyze); }
        public void ClearSubmixEffects(Object WorldContextObject, SoundSubmix SoundSubmix) { Invoke(nameof(ClearSubmixEffects), WorldContextObject, SoundSubmix); }
        public void ClearSubmixEffectChainOverride(Object WorldContextObject, SoundSubmix SoundSubmix, float FadeTimeSec) { Invoke(nameof(ClearSubmixEffectChainOverride), WorldContextObject, SoundSubmix, FadeTimeSec); }
        public void ClearMasterSubmixEffects(Object WorldContextObject) { Invoke(nameof(ClearMasterSubmixEffects), WorldContextObject); }
        public int AddSubmixEffect(Object WorldContextObject, SoundSubmix SoundSubmix, SoundEffectSubmixPreset SubmixEffectPreset) { return Invoke<int>(nameof(AddSubmixEffect), WorldContextObject, SoundSubmix, SubmixEffectPreset); }
        public void AddSourceEffectToPresetChain(Object WorldContextObject, SoundEffectSourcePresetChain PresetChain, SourceEffectChainEntry Entry) { Invoke(nameof(AddSourceEffectToPresetChain), WorldContextObject, PresetChain, Entry); }
        public void AddMasterSubmixEffect(Object WorldContextObject, SoundEffectSubmixPreset SubmixEffectPreset) { Invoke(nameof(AddMasterSubmixEffect), WorldContextObject, SubmixEffectPreset); }
    }
    public class QuartzClockHandle : Object
    {
        public QuartzClockHandle(ulong addr) : base(addr) { }
        public void UnsubscribeFromTimeDivision(Object WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary) { Invoke(nameof(UnsubscribeFromTimeDivision), WorldContextObject, InQuantizationBoundary); }
        public void UnsubscribeFromAllTimeDivisions(Object WorldContextObject) { Invoke(nameof(UnsubscribeFromAllTimeDivisions), WorldContextObject); }
        public void SubscribeToQuantizationEvent(Object WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, Object OnQuantizationEvent) { Invoke(nameof(SubscribeToQuantizationEvent), WorldContextObject, InQuantizationBoundary, OnQuantizationEvent); }
        public void SubscribeToAllQuantizationEvents(Object WorldContextObject, Object OnQuantizationEvent) { Invoke(nameof(SubscribeToAllQuantizationEvents), WorldContextObject, OnQuantizationEvent); }
        public void SetTicksPerSecond(Object WorldContextObject, QuartzQuantizationBoundary QuantizationBoundary, Object Delegate, float TicksPerSecond) { Invoke(nameof(SetTicksPerSecond), WorldContextObject, QuantizationBoundary, Delegate, TicksPerSecond); }
        public void SetThirtySecondNotesPerMinute(Object WorldContextObject, QuartzQuantizationBoundary QuantizationBoundary, Object Delegate, float ThirtySecondsNotesPerMinute) { Invoke(nameof(SetThirtySecondNotesPerMinute), WorldContextObject, QuantizationBoundary, Delegate, ThirtySecondsNotesPerMinute); }
        public void SetSecondsPerTick(Object WorldContextObject, QuartzQuantizationBoundary QuantizationBoundary, Object Delegate, float SecondsPerTick) { Invoke(nameof(SetSecondsPerTick), WorldContextObject, QuantizationBoundary, Delegate, SecondsPerTick); }
        public void SetMillisecondsPerTick(Object WorldContextObject, QuartzQuantizationBoundary QuantizationBoundary, Object Delegate, float MillisecondsPerTick) { Invoke(nameof(SetMillisecondsPerTick), WorldContextObject, QuantizationBoundary, Delegate, MillisecondsPerTick); }
        public void SetBeatsPerMinute(Object WorldContextObject, QuartzQuantizationBoundary QuantizationBoundary, Object Delegate, float BeatsPerMinute) { Invoke(nameof(SetBeatsPerMinute), WorldContextObject, QuantizationBoundary, Delegate, BeatsPerMinute); }
        public void ResumeClock(Object WorldContextObject) { Invoke(nameof(ResumeClock), WorldContextObject); }
        public void ResetTransport(Object WorldContextObject, Object InDelegate) { Invoke(nameof(ResetTransport), WorldContextObject, InDelegate); }
        public void PauseClock(Object WorldContextObject) { Invoke(nameof(PauseClock), WorldContextObject); }
        public float GetTicksPerSecond(Object WorldContextObject) { return Invoke<float>(nameof(GetTicksPerSecond), WorldContextObject); }
        public float GetThirtySecondNotesPerMinute(Object WorldContextObject) { return Invoke<float>(nameof(GetThirtySecondNotesPerMinute), WorldContextObject); }
        public float GetSecondsPerTick(Object WorldContextObject) { return Invoke<float>(nameof(GetSecondsPerTick), WorldContextObject); }
        public float GetMillisecondsPerTick(Object WorldContextObject) { return Invoke<float>(nameof(GetMillisecondsPerTick), WorldContextObject); }
        public float GetBeatsPerMinute(Object WorldContextObject) { return Invoke<float>(nameof(GetBeatsPerMinute), WorldContextObject); }
    }
    public class SubmixEffectDynamicsProcessorPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectDynamicsProcessorPreset(ulong addr) : base(addr) { }
        public SubmixEffectDynamicsProcessorSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectDynamicsProcessorSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectDynamicsProcessorSettings Settings) { Invoke(nameof(SetSettings), Settings); }
        public void SetExternalSubmix(SoundSubmix Submix) { Invoke(nameof(SetExternalSubmix), Submix); }
    }
    public class SubmixEffectSubmixEQPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectSubmixEQPreset(ulong addr) : base(addr) { }
        public SubmixEffectSubmixEQSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectSubmixEQSettings>(); } set { this["Settings"] = value; } }
        public void SetSettings(SubmixEffectSubmixEQSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class SubmixEffectReverbPreset : SoundEffectSubmixPreset
    {
        public SubmixEffectReverbPreset(ulong addr) : base(addr) { }
        public SubmixEffectReverbSettings Settings { get { return this[nameof(Settings)].As<SubmixEffectReverbSettings>(); } set { this["Settings"] = value; } }
        public void SetSettingsWithReverbEffect(ReverbEffect InReverbEffect, float WetLevel, float DryLevel) { Invoke(nameof(SetSettingsWithReverbEffect), InReverbEffect, WetLevel, DryLevel); }
        public void SetSettings(SubmixEffectReverbSettings InSettings) { Invoke(nameof(SetSettings), InSettings); }
    }
    public class QuartzSubsystem : WorldSubsystem
    {
        public QuartzSubsystem(ulong addr) : base(addr) { }
        public float GetRoundTripMinLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetRoundTripMinLatency), WorldContextObject); }
        public float GetRoundTripMaxLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetRoundTripMaxLatency), WorldContextObject); }
        public float GetRoundTripAverageLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetRoundTripAverageLatency), WorldContextObject); }
        public QuartzClockHandle GetHandleForClock(Object WorldContextObject, Object ClockName) { return Invoke<QuartzClockHandle>(nameof(GetHandleForClock), WorldContextObject, ClockName); }
        public float GetGameThreadToAudioRenderThreadMinLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetGameThreadToAudioRenderThreadMinLatency), WorldContextObject); }
        public float GetGameThreadToAudioRenderThreadMaxLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetGameThreadToAudioRenderThreadMaxLatency), WorldContextObject); }
        public float GetGameThreadToAudioRenderThreadAverageLatency(Object WorldContextObject) { return Invoke<float>(nameof(GetGameThreadToAudioRenderThreadAverageLatency), WorldContextObject); }
        public float GetAudioRenderThreadToGameThreadMinLatency() { return Invoke<float>(nameof(GetAudioRenderThreadToGameThreadMinLatency)); }
        public float GetAudioRenderThreadToGameThreadMaxLatency() { return Invoke<float>(nameof(GetAudioRenderThreadToGameThreadMaxLatency)); }
        public float GetAudioRenderThreadToGameThreadAverageLatency() { return Invoke<float>(nameof(GetAudioRenderThreadToGameThreadAverageLatency)); }
        public bool DoesClockExist(Object WorldContextObject, Object ClockName) { return Invoke<bool>(nameof(DoesClockExist), WorldContextObject, ClockName); }
        public QuartzClockHandle CreateNewClock(Object WorldContextObject, Object ClockName, QuartzClockSettings InSettings, bool bOverrideSettingsIfClockExists) { return Invoke<QuartzClockHandle>(nameof(CreateNewClock), WorldContextObject, ClockName, InSettings, bOverrideSettingsIfClockExists); }
    }
    public class SynthSound : SoundWaveProcedural
    {
        public SynthSound(ulong addr) : base(addr) { }
        public SynthComponent OwningSynthComponent { get { return this[nameof(OwningSynthComponent)].As<SynthComponent>(); } set { this["OwningSynthComponent"] = value; } }
    }
    public enum EMusicalNoteName : int
    {
        C = 0,
        Db = 1,
        D = 2,
        Eb = 3,
        E = 4,
        F = 5,
        Gb = 6,
        G = 7,
        Ab = 8,
        A = 9,
        Bb = 10,
        B = 11,
        EMusicalNoteName_MAX = 12,
    }
    public enum ESubmixEffectDynamicsChannelLinkMode : int
    {
        Disabled = 0,
        Average = 1,
        Peak = 2,
        Count = 3,
        ESubmixEffectDynamicsChannelLinkMode_MAX = 4,
    }
    public enum ESubmixEffectDynamicsPeakMode : int
    {
        MeanSquared = 0,
        RootMeanSquared = 1,
        Peak = 2,
        Count = 3,
        ESubmixEffectDynamicsPeakMode_MAX = 4,
    }
    public enum ESubmixEffectDynamicsProcessorType : int
    {
        Compressor = 0,
        Limiter = 1,
        Expander = 2,
        Gate = 3,
        Count = 4,
        ESubmixEffectDynamicsProcessorType_MAX = 5,
    }
    public class SubmixEffectDynamicsProcessorSettings : Object
    {
        public SubmixEffectDynamicsProcessorSettings(ulong addr) : base(addr) { }
        public ESubmixEffectDynamicsProcessorType DynamicsProcessorType { get { return (ESubmixEffectDynamicsProcessorType)this[nameof(DynamicsProcessorType)].GetValue<int>(); } set { this[nameof(DynamicsProcessorType)].SetValue<int>((int)value); } }
        public ESubmixEffectDynamicsPeakMode PeakMode { get { return (ESubmixEffectDynamicsPeakMode)this[nameof(PeakMode)].GetValue<int>(); } set { this[nameof(PeakMode)].SetValue<int>((int)value); } }
        public ESubmixEffectDynamicsChannelLinkMode LinkMode { get { return (ESubmixEffectDynamicsChannelLinkMode)this[nameof(LinkMode)].GetValue<int>(); } set { this[nameof(LinkMode)].SetValue<int>((int)value); } }
        public float InputGainDb { get { return this[nameof(InputGainDb)].GetValue<float>(); } set { this[nameof(InputGainDb)].SetValue<float>(value); } }
        public float ThresholdDb { get { return this[nameof(ThresholdDb)].GetValue<float>(); } set { this[nameof(ThresholdDb)].SetValue<float>(value); } }
        public float Ratio { get { return this[nameof(Ratio)].GetValue<float>(); } set { this[nameof(Ratio)].SetValue<float>(value); } }
        public float KneeBandwidthDb { get { return this[nameof(KneeBandwidthDb)].GetValue<float>(); } set { this[nameof(KneeBandwidthDb)].SetValue<float>(value); } }
        public float LookAheadMsec { get { return this[nameof(LookAheadMsec)].GetValue<float>(); } set { this[nameof(LookAheadMsec)].SetValue<float>(value); } }
        public float AttackTimeMsec { get { return this[nameof(AttackTimeMsec)].GetValue<float>(); } set { this[nameof(AttackTimeMsec)].SetValue<float>(value); } }
        public float ReleaseTimeMsec { get { return this[nameof(ReleaseTimeMsec)].GetValue<float>(); } set { this[nameof(ReleaseTimeMsec)].SetValue<float>(value); } }
        public SoundSubmix ExternalSubmix { get { return this[nameof(ExternalSubmix)].As<SoundSubmix>(); } set { this["ExternalSubmix"] = value; } }
        public bool bChannelLinked { get { return this[nameof(bChannelLinked)].Flag; } set { this[nameof(bChannelLinked)].Flag = value; } }
        public bool bAnalogMode { get { return this[nameof(bAnalogMode)].Flag; } set { this[nameof(bAnalogMode)].Flag = value; } }
        public bool bKeyAudition { get { return this[nameof(bKeyAudition)].Flag; } set { this[nameof(bKeyAudition)].Flag = value; } }
        public float KeyGainDb { get { return this[nameof(KeyGainDb)].GetValue<float>(); } set { this[nameof(KeyGainDb)].SetValue<float>(value); } }
        public float OutputGainDb { get { return this[nameof(OutputGainDb)].GetValue<float>(); } set { this[nameof(OutputGainDb)].SetValue<float>(value); } }
        public SubmixEffectDynamicProcessorFilterSettings KeyHighshelf { get { return this[nameof(KeyHighshelf)].As<SubmixEffectDynamicProcessorFilterSettings>(); } set { this["KeyHighshelf"] = value; } }
        public SubmixEffectDynamicProcessorFilterSettings KeyLowshelf { get { return this[nameof(KeyLowshelf)].As<SubmixEffectDynamicProcessorFilterSettings>(); } set { this["KeyLowshelf"] = value; } }
    }
    public class SubmixEffectDynamicProcessorFilterSettings : Object
    {
        public SubmixEffectDynamicProcessorFilterSettings(ulong addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public float Cutoff { get { return this[nameof(Cutoff)].GetValue<float>(); } set { this[nameof(Cutoff)].SetValue<float>(value); } }
        public float GainDb { get { return this[nameof(GainDb)].GetValue<float>(); } set { this[nameof(GainDb)].SetValue<float>(value); } }
    }
    public class SubmixEffectSubmixEQSettings : Object
    {
        public SubmixEffectSubmixEQSettings(ulong addr) : base(addr) { }
        public Array<SubmixEffectEQBand> EQBands { get { return new Array<SubmixEffectEQBand>(this[nameof(EQBands)].Address); } }
    }
    public class SubmixEffectEQBand : Object
    {
        public SubmixEffectEQBand(ulong addr) : base(addr) { }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Bandwidth { get { return this[nameof(Bandwidth)].GetValue<float>(); } set { this[nameof(Bandwidth)].SetValue<float>(value); } }
        public float GainDb { get { return this[nameof(GainDb)].GetValue<float>(); } set { this[nameof(GainDb)].SetValue<float>(value); } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class SubmixEffectReverbSettings : Object
    {
        public SubmixEffectReverbSettings(ulong addr) : base(addr) { }
        public bool bBypassEarlyReflections { get { return this[nameof(bBypassEarlyReflections)].Flag; } set { this[nameof(bBypassEarlyReflections)].Flag = value; } }
        public float ReflectionsDelay { get { return this[nameof(ReflectionsDelay)].GetValue<float>(); } set { this[nameof(ReflectionsDelay)].SetValue<float>(value); } }
        public float GainHF { get { return this[nameof(GainHF)].GetValue<float>(); } set { this[nameof(GainHF)].SetValue<float>(value); } }
        public float ReflectionsGain { get { return this[nameof(ReflectionsGain)].GetValue<float>(); } set { this[nameof(ReflectionsGain)].SetValue<float>(value); } }
        public bool bBypassLateReflections { get { return this[nameof(bBypassLateReflections)].Flag; } set { this[nameof(bBypassLateReflections)].Flag = value; } }
        public float LateDelay { get { return this[nameof(LateDelay)].GetValue<float>(); } set { this[nameof(LateDelay)].SetValue<float>(value); } }
        public float DecayTime { get { return this[nameof(DecayTime)].GetValue<float>(); } set { this[nameof(DecayTime)].SetValue<float>(value); } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float Diffusion { get { return this[nameof(Diffusion)].GetValue<float>(); } set { this[nameof(Diffusion)].SetValue<float>(value); } }
        public float AirAbsorptionGainHF { get { return this[nameof(AirAbsorptionGainHF)].GetValue<float>(); } set { this[nameof(AirAbsorptionGainHF)].SetValue<float>(value); } }
        public float DecayHFRatio { get { return this[nameof(DecayHFRatio)].GetValue<float>(); } set { this[nameof(DecayHFRatio)].SetValue<float>(value); } }
        public float LateGain { get { return this[nameof(LateGain)].GetValue<float>(); } set { this[nameof(LateGain)].SetValue<float>(value); } }
        public float Gain { get { return this[nameof(Gain)].GetValue<float>(); } set { this[nameof(Gain)].SetValue<float>(value); } }
        public float WetLevel { get { return this[nameof(WetLevel)].GetValue<float>(); } set { this[nameof(WetLevel)].SetValue<float>(value); } }
        public float DryLevel { get { return this[nameof(DryLevel)].GetValue<float>(); } set { this[nameof(DryLevel)].SetValue<float>(value); } }
        public bool bBypass { get { return this[nameof(bBypass)].Flag; } set { this[nameof(bBypass)].Flag = value; } }
    }
}
