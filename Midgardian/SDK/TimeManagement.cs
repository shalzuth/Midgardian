using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TimeManagementSDK
{
    public class FixedFrameRateCustomTimeStep : EngineCustomTimeStep
    {
        public FixedFrameRateCustomTimeStep(ulong addr) : base(addr) { }
        public FrameRate FixedFrameRate { get { return this[nameof(FixedFrameRate)].As<FrameRate>(); } set { this["FixedFrameRate"] = value; } }
    }
    public class GenlockedCustomTimeStep : FixedFrameRateCustomTimeStep
    {
        public GenlockedCustomTimeStep(ulong addr) : base(addr) { }
    }
    public class GenlockedTimecodeProvider : TimecodeProvider
    {
        public GenlockedTimecodeProvider(ulong addr) : base(addr) { }
        public bool bUseGenlockToCount { get { return this[nameof(bUseGenlockToCount)].Flag; } set { this[nameof(bUseGenlockToCount)].Flag = value; } }
    }
    public class TimeManagementBlueprintLibrary : BlueprintFunctionLibrary
    {
        public TimeManagementBlueprintLibrary(ulong addr) : base(addr) { }
        public FrameTime TransformTime(FrameTime SourceTime, FrameRate SourceRate, FrameRate DestinationRate) { return Invoke<FrameTime>(nameof(TransformTime), SourceTime, SourceRate, DestinationRate); }
        public FrameNumber Subtract_FrameNumberInteger(FrameNumber A, int B) { return Invoke<FrameNumber>(nameof(Subtract_FrameNumberInteger), A, B); }
        public FrameNumber Subtract_FrameNumberFrameNumber(FrameNumber A, FrameNumber B) { return Invoke<FrameNumber>(nameof(Subtract_FrameNumberFrameNumber), A, B); }
        public FrameTime SnapFrameTimeToRate(FrameTime SourceTime, FrameRate SourceRate, FrameRate SnapToRate) { return Invoke<FrameTime>(nameof(SnapFrameTimeToRate), SourceTime, SourceRate, SnapToRate); }
        public FrameTime Multiply_SecondsFrameRate(float TimeInSeconds, FrameRate FrameRate) { return Invoke<FrameTime>(nameof(Multiply_SecondsFrameRate), TimeInSeconds, FrameRate); }
        public FrameNumber Multiply_FrameNumberInteger(FrameNumber A, int B) { return Invoke<FrameNumber>(nameof(Multiply_FrameNumberInteger), A, B); }
        public bool IsValid_MultipleOf(FrameRate InFrameRate, FrameRate OtherFramerate) { return Invoke<bool>(nameof(IsValid_MultipleOf), InFrameRate, OtherFramerate); }
        public bool IsValid_Framerate(FrameRate InFrameRate) { return Invoke<bool>(nameof(IsValid_Framerate), InFrameRate); }
        public FrameRate GetTimecodeFrameRate() { return Invoke<FrameRate>(nameof(GetTimecodeFrameRate)); }
        public Timecode GetTimecode() { return Invoke<Timecode>(nameof(GetTimecode)); }
        public FrameNumber Divide_FrameNumberInteger(FrameNumber A, int B) { return Invoke<FrameNumber>(nameof(Divide_FrameNumberInteger), A, B); }
        public Object Conv_TimecodeToString(Timecode InTimecode, bool bForceSignDisplay) { return Invoke<Object>(nameof(Conv_TimecodeToString), InTimecode, bForceSignDisplay); }
        public float Conv_QualifiedFrameTimeToSeconds(QualifiedFrameTime InFrameTime) { return Invoke<float>(nameof(Conv_QualifiedFrameTimeToSeconds), InFrameTime); }
        public float Conv_FrameRateToSeconds(FrameRate InFrameRate) { return Invoke<float>(nameof(Conv_FrameRateToSeconds), InFrameRate); }
        public int Conv_FrameNumberToInteger(FrameNumber InFrameNumber) { return Invoke<int>(nameof(Conv_FrameNumberToInteger), InFrameNumber); }
        public FrameNumber Add_FrameNumberInteger(FrameNumber A, int B) { return Invoke<FrameNumber>(nameof(Add_FrameNumberInteger), A, B); }
        public FrameNumber Add_FrameNumberFrameNumber(FrameNumber A, FrameNumber B) { return Invoke<FrameNumber>(nameof(Add_FrameNumberFrameNumber), A, B); }
    }
    public class TimeSynchronizationSource : Object
    {
        public TimeSynchronizationSource(ulong addr) : base(addr) { }
        public bool bUseForSynchronization { get { return this[nameof(bUseForSynchronization)].Flag; } set { this[nameof(bUseForSynchronization)].Flag = value; } }
        public int FrameOffset { get { return this[nameof(FrameOffset)].GetValue<int>(); } set { this[nameof(FrameOffset)].SetValue<int>(value); } }
    }
    public enum EFrameNumberDisplayFormats : int
    {
        NonDropFrameTimecode = 0,
        DropFrameTimecode = 1,
        Seconds = 2,
        Frames = 3,
        MAX_Count = 4,
        EFrameNumberDisplayFormats_MAX = 5,
    }
    public enum ETimedDataInputState : int
    {
        Connected = 0,
        Unresponsive = 1,
        Disconnected = 2,
        ETimedDataInputState_MAX = 3,
    }
    public enum ETimedDataInputEvaluationType : int
    {
        None = 0,
        Timecode = 1,
        PlatformTime = 2,
        ETimedDataInputEvaluationType_MAX = 3,
    }
    public class TimedDataInputEvaluationData : Object
    {
        public TimedDataInputEvaluationData(ulong addr) : base(addr) { }
        public float DistanceToNewestSampleSeconds { get { return this[nameof(DistanceToNewestSampleSeconds)].GetValue<float>(); } set { this[nameof(DistanceToNewestSampleSeconds)].SetValue<float>(value); } }
        public float DistanceToOldestSampleSeconds { get { return this[nameof(DistanceToOldestSampleSeconds)].GetValue<float>(); } set { this[nameof(DistanceToOldestSampleSeconds)].SetValue<float>(value); } }
    }
    public class TimedDataChannelSampleTime : Object
    {
        public TimedDataChannelSampleTime(ulong addr) : base(addr) { }
    }
}
