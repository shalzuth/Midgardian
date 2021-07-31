using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.AudioAnalyzerSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.AudioSynesthesiaSDK
{
    public class AudioSynesthesiaNRTSettings : AudioAnalyzerNRTSettings
    {
        public AudioSynesthesiaNRTSettings(ulong addr) : base(addr) { }
    }
    public class AudioSynesthesiaNRT : AudioAnalyzerNRT
    {
        public AudioSynesthesiaNRT(ulong addr) : base(addr) { }
    }
    public class ConstantQNRTSettings : AudioSynesthesiaNRTSettings
    {
        public ConstantQNRTSettings(ulong addr) : base(addr) { }
        public float StartingFrequency { get { return this[nameof(StartingFrequency)].GetValue<float>(); } set { this[nameof(StartingFrequency)].SetValue<float>(value); } }
        public int NumBands { get { return this[nameof(NumBands)].GetValue<int>(); } set { this[nameof(NumBands)].SetValue<int>(value); } }
        public float NumBandsPerOctave { get { return this[nameof(NumBandsPerOctave)].GetValue<float>(); } set { this[nameof(NumBandsPerOctave)].SetValue<float>(value); } }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public bool bDownmixToMono { get { return this[nameof(bDownmixToMono)].Flag; } set { this[nameof(bDownmixToMono)].Flag = value; } }
        public EConstantQFFTSizeEnum FFTSize { get { return (EConstantQFFTSizeEnum)this[nameof(FFTSize)].GetValue<int>(); } set { this[nameof(FFTSize)].SetValue<int>((int)value); } }
        public EFFTWindowType WindowType { get { return (EFFTWindowType)this[nameof(WindowType)].GetValue<int>(); } set { this[nameof(WindowType)].SetValue<int>((int)value); } }
        public EAudioSpectrumType SpectrumType { get { return (EAudioSpectrumType)this[nameof(SpectrumType)].GetValue<int>(); } set { this[nameof(SpectrumType)].SetValue<int>((int)value); } }
        public float BandWidthStretch { get { return this[nameof(BandWidthStretch)].GetValue<float>(); } set { this[nameof(BandWidthStretch)].SetValue<float>(value); } }
        public EConstantQNormalizationEnum CQTNormalization { get { return (EConstantQNormalizationEnum)this[nameof(CQTNormalization)].GetValue<int>(); } set { this[nameof(CQTNormalization)].SetValue<int>((int)value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class ConstantQNRT : AudioSynesthesiaNRT
    {
        public ConstantQNRT(ulong addr) : base(addr) { }
        public ConstantQNRTSettings Settings { get { return this[nameof(Settings)].As<ConstantQNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, Array<float> OutConstantQ) { Invoke(nameof(GetNormalizedChannelConstantQAtTime), InSeconds, InChannel, OutConstantQ); }
        public void GetChannelConstantQAtTime(float InSeconds, int InChannel, Array<float> OutConstantQ) { Invoke(nameof(GetChannelConstantQAtTime), InSeconds, InChannel, OutConstantQ); }
    }
    public class LoudnessNRTSettings : AudioSynesthesiaNRTSettings
    {
        public LoudnessNRTSettings(ulong addr) : base(addr) { }
        public float AnalysisPeriod { get { return this[nameof(AnalysisPeriod)].GetValue<float>(); } set { this[nameof(AnalysisPeriod)].SetValue<float>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
        public ELoudnessNRTCurveTypeEnum CurveType { get { return (ELoudnessNRTCurveTypeEnum)this[nameof(CurveType)].GetValue<int>(); } set { this[nameof(CurveType)].SetValue<int>((int)value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class LoudnessNRT : AudioSynesthesiaNRT
    {
        public LoudnessNRT(ulong addr) : base(addr) { }
        public LoudnessNRTSettings Settings { get { return this[nameof(Settings)].As<LoudnessNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedLoudnessAtTime(float InSeconds, float OutLoudness) { Invoke(nameof(GetNormalizedLoudnessAtTime), InSeconds, OutLoudness); }
        public void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, float OutLoudness) { Invoke(nameof(GetNormalizedChannelLoudnessAtTime), InSeconds, InChannel, OutLoudness); }
        public void GetLoudnessAtTime(float InSeconds, float OutLoudness) { Invoke(nameof(GetLoudnessAtTime), InSeconds, OutLoudness); }
        public void GetChannelLoudnessAtTime(float InSeconds, int InChannel, float OutLoudness) { Invoke(nameof(GetChannelLoudnessAtTime), InSeconds, InChannel, OutLoudness); }
    }
    public class OnsetNRTSettings : AudioSynesthesiaNRTSettings
    {
        public OnsetNRTSettings(ulong addr) : base(addr) { }
        public bool bDownmixToMono { get { return this[nameof(bDownmixToMono)].Flag; } set { this[nameof(bDownmixToMono)].Flag = value; } }
        public float GranularityInSeconds { get { return this[nameof(GranularityInSeconds)].GetValue<float>(); } set { this[nameof(GranularityInSeconds)].SetValue<float>(value); } }
        public float Sensitivity { get { return this[nameof(Sensitivity)].GetValue<float>(); } set { this[nameof(Sensitivity)].SetValue<float>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
    }
    public class OnsetNRT : AudioSynesthesiaNRT
    {
        public OnsetNRT(ulong addr) : base(addr) { }
        public OnsetNRTSettings Settings { get { return this[nameof(Settings)].As<OnsetNRTSettings>(); } set { this["Settings"] = value; } }
        public void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, Array<float> OutOnsetTimestamps, Array<float> OutOnsetStrengths) { Invoke(nameof(GetNormalizedChannelOnsetsBetweenTimes), InStartSeconds, InEndSeconds, InChannel, OutOnsetTimestamps, OutOnsetStrengths); }
        public void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, Array<float> OutOnsetTimestamps, Array<float> OutOnsetStrengths) { Invoke(nameof(GetChannelOnsetsBetweenTimes), InStartSeconds, InEndSeconds, InChannel, OutOnsetTimestamps, OutOnsetStrengths); }
    }
    public enum EConstantQFFTSizeEnum : int
    {
        Min = 0,
        XXSmall = 1,
        XSmall = 2,
        Small = 3,
        Medium = 4,
        Large = 5,
        XLarge = 6,
        XXLarge = 7,
        Max = 8,
    }
    public enum EConstantQNormalizationEnum : int
    {
        EqualEuclideanNorm = 0,
        EqualEnergy = 1,
        EqualAmplitude = 2,
        EConstantQNormalizationEnum_MAX = 3,
    }
    public enum ELoudnessNRTCurveTypeEnum : int
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        None = 4,
        ELoudnessNRTCurveTypeEnum_MAX = 5,
    }
}
