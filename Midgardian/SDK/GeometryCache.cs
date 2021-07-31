using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.GeometryCacheSDK
{
    public class GeometryCache : Object
    {
        public GeometryCache(ulong addr) : base(addr) { }
        public Array<MaterialInterface> Materials { get { return new Array<MaterialInterface>(this[nameof(Materials)].Address); } }
        public Array<GeometryCacheTrack> Tracks { get { return new Array<GeometryCacheTrack>(this[nameof(Tracks)].Address); } }
        public int StartFrame { get { return this[nameof(StartFrame)].GetValue<int>(); } set { this[nameof(StartFrame)].SetValue<int>(value); } }
        public int EndFrame { get { return this[nameof(EndFrame)].GetValue<int>(); } set { this[nameof(EndFrame)].SetValue<int>(value); } }
    }
    public class GeometryCacheActor : Actor
    {
        public GeometryCacheActor(ulong addr) : base(addr) { }
        public GeometryCacheComponent GeometryCacheComponent { get { return this[nameof(GeometryCacheComponent)].As<GeometryCacheComponent>(); } set { this["GeometryCacheComponent"] = value; } }
        public GeometryCacheComponent GetGeometryCacheComponent() { return Invoke<GeometryCacheComponent>(nameof(GetGeometryCacheComponent)); }
    }
    public class GeometryCacheCodecBase : Object
    {
        public GeometryCacheCodecBase(ulong addr) : base(addr) { }
        public Array<int> TopologyRanges { get { return new Array<int>(this[nameof(TopologyRanges)].Address); } }
    }
    public class GeometryCacheCodecRaw : GeometryCacheCodecBase
    {
        public GeometryCacheCodecRaw(ulong addr) : base(addr) { }
        public int DummyProperty { get { return this[nameof(DummyProperty)].GetValue<int>(); } set { this[nameof(DummyProperty)].SetValue<int>(value); } }
    }
    public class GeometryCacheCodecV1 : GeometryCacheCodecBase
    {
        public GeometryCacheCodecV1(ulong addr) : base(addr) { }
    }
    public class GeometryCacheComponent : MeshComponent
    {
        public GeometryCacheComponent(ulong addr) : base(addr) { }
        public GeometryCache GeometryCache { get { return this[nameof(GeometryCache)].As<GeometryCache>(); } set { this["GeometryCache"] = value; } }
        public bool bRunning { get { return this[nameof(bRunning)].Flag; } set { this[nameof(bRunning)].Flag = value; } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public float StartTimeOffset { get { return this[nameof(StartTimeOffset)].GetValue<float>(); } set { this[nameof(StartTimeOffset)].SetValue<float>(value); } }
        public float PlaybackSpeed { get { return this[nameof(PlaybackSpeed)].GetValue<float>(); } set { this[nameof(PlaybackSpeed)].SetValue<float>(value); } }
        public int NumTracks { get { return this[nameof(NumTracks)].GetValue<int>(); } set { this[nameof(NumTracks)].SetValue<int>(value); } }
        public float ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<float>(); } set { this[nameof(ElapsedTime)].SetValue<float>(value); } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public bool bManualTick { get { return this[nameof(bManualTick)].Flag; } set { this[nameof(bManualTick)].Flag = value; } }
        public void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping) { Invoke(nameof(TickAtThisTime), Time, bInIsRunning, bInBackwards, bInIsLooping); }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetStartTimeOffset(float NewStartTimeOffset) { Invoke(nameof(SetStartTimeOffset), NewStartTimeOffset); }
        public void SetPlaybackSpeed(float NewPlaybackSpeed) { Invoke(nameof(SetPlaybackSpeed), NewPlaybackSpeed); }
        public void SetLooping(bool bNewLooping) { Invoke(nameof(SetLooping), bNewLooping); }
        public bool SetGeometryCache(GeometryCache NewGeomCache) { return Invoke<bool>(nameof(SetGeometryCache), NewGeomCache); }
        public void PlayReversedFromEnd() { Invoke(nameof(PlayReversedFromEnd)); }
        public void PlayReversed() { Invoke(nameof(PlayReversed)); }
        public void PlayFromStart() { Invoke(nameof(PlayFromStart)); }
        public void Play() { Invoke(nameof(Play)); }
        public void Pause() { Invoke(nameof(Pause)); }
        public bool IsPlayingReversed() { return Invoke<bool>(nameof(IsPlayingReversed)); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
        public bool IsLooping() { return Invoke<bool>(nameof(IsLooping)); }
        public float GetStartTimeOffset() { return Invoke<float>(nameof(GetStartTimeOffset)); }
        public float GetPlaybackSpeed() { return Invoke<float>(nameof(GetPlaybackSpeed)); }
        public float GetPlaybackDirection() { return Invoke<float>(nameof(GetPlaybackDirection)); }
        public int GetNumberOfFrames() { return Invoke<int>(nameof(GetNumberOfFrames)); }
        public float GetDuration() { return Invoke<float>(nameof(GetDuration)); }
        public float GetAnimationTime() { return Invoke<float>(nameof(GetAnimationTime)); }
    }
    public class GeometryCacheTrack : Object
    {
        public GeometryCacheTrack(ulong addr) : base(addr) { }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
    }
    public class GeometryCacheTrack_FlipbookAnimation : GeometryCacheTrack
    {
        public GeometryCacheTrack_FlipbookAnimation(ulong addr) : base(addr) { }
        public uint NumMeshSamples { get { return this[nameof(NumMeshSamples)].GetValue<uint>(); } set { this[nameof(NumMeshSamples)].SetValue<uint>(value); } }
        public void AddMeshSample(GeometryCacheMeshData MeshData, float SampleTime) { Invoke(nameof(AddMeshSample), MeshData, SampleTime); }
    }
    public class GeometryCacheTrackStreamable : GeometryCacheTrack
    {
        public GeometryCacheTrackStreamable(ulong addr) : base(addr) { }
        public GeometryCacheCodecBase Codec { get { return this[nameof(Codec)].As<GeometryCacheCodecBase>(); } set { this["Codec"] = value; } }
        public float StartSampleTime { get { return this[nameof(StartSampleTime)].GetValue<float>(); } set { this[nameof(StartSampleTime)].SetValue<float>(value); } }
    }
    public class GeometryCacheTrack_TransformAnimation : GeometryCacheTrack
    {
        public GeometryCacheTrack_TransformAnimation(ulong addr) : base(addr) { }
        public void SetMesh(GeometryCacheMeshData NewMeshData) { Invoke(nameof(SetMesh), NewMeshData); }
    }
    public class GeometryCacheTrack_TransformGroupAnimation : GeometryCacheTrack
    {
        public GeometryCacheTrack_TransformGroupAnimation(ulong addr) : base(addr) { }
        public void SetMesh(GeometryCacheMeshData NewMeshData) { Invoke(nameof(SetMesh), NewMeshData); }
    }
    public class TrackRenderData : Object
    {
        public TrackRenderData(ulong addr) : base(addr) { }
    }
    public class GeometryCacheMeshData : Object
    {
        public GeometryCacheMeshData(ulong addr) : base(addr) { }
    }
    public class GeometryCacheVertexInfo : Object
    {
        public GeometryCacheVertexInfo(ulong addr) : base(addr) { }
    }
    public class GeometryCacheMeshBatchInfo : Object
    {
        public GeometryCacheMeshBatchInfo(ulong addr) : base(addr) { }
    }
}
