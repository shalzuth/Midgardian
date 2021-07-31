using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TemplateSequenceSDK
{
    public class TemplateSequence : MovieSceneSequence
    {
        public TemplateSequence(ulong addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public Object BoundActorClass { get { return this[nameof(BoundActorClass)]; } set { this[nameof(BoundActorClass)] = value; } }
        public Object BoundPreviewActor { get { return this[nameof(BoundPreviewActor)]; } set { this[nameof(BoundPreviewActor)] = value; } }
        public Object BoundActorComponents { get { return this[nameof(BoundActorComponents)]; } set { this[nameof(BoundActorComponents)] = value; } }
    }
    public class CameraAnimationSequence : TemplateSequence
    {
        public CameraAnimationSequence(ulong addr) : base(addr) { }
    }
    public class SequenceCameraShakeCameraStandIn : Object
    {
        public SequenceCameraShakeCameraStandIn(ulong addr) : base(addr) { }
        public float FieldOfView { get { return this[nameof(FieldOfView)].GetValue<float>(); } set { this[nameof(FieldOfView)].SetValue<float>(value); } }
    }
    public class SequenceCameraShake : CameraShakeBase
    {
        public SequenceCameraShake(ulong addr) : base(addr) { }
        public CameraAnimationSequence Sequence { get { return this[nameof(Sequence)].As<CameraAnimationSequence>(); } set { this["Sequence"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
        public float RandomSegmentDuration { get { return this[nameof(RandomSegmentDuration)].GetValue<float>(); } set { this[nameof(RandomSegmentDuration)].SetValue<float>(value); } }
        public bool bRandomSegment { get { return this[nameof(bRandomSegment)].Flag; } set { this[nameof(bRandomSegment)].Flag = value; } }
        public SequenceCameraShakeSequencePlayer Player { get { return this[nameof(Player)].As<SequenceCameraShakeSequencePlayer>(); } set { this["Player"] = value; } }
        public SequenceCameraShakeCameraStandIn CameraStandIn { get { return this[nameof(CameraStandIn)].As<SequenceCameraShakeCameraStandIn>(); } set { this["CameraStandIn"] = value; } }
    }
    public class SequenceCameraShakeSequencePlayer : Object
    {
        public SequenceCameraShakeSequencePlayer(ulong addr) : base(addr) { }
        public Object BoundObjectOverride { get { return this[nameof(BoundObjectOverride)].As<Object>(); } set { this["BoundObjectOverride"] = value; } }
        public MovieSceneSequence Sequence { get { return this[nameof(Sequence)].As<MovieSceneSequence>(); } set { this["Sequence"] = value; } }
        public MovieSceneRootEvaluationTemplateInstance RootTemplateInstance { get { return this[nameof(RootTemplateInstance)].As<MovieSceneRootEvaluationTemplateInstance>(); } set { this["RootTemplateInstance"] = value; } }
    }
    public class TemplateSequenceActor : Actor
    {
        public TemplateSequenceActor(ulong addr) : base(addr) { }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public TemplateSequencePlayer SequencePlayer { get { return this[nameof(SequencePlayer)].As<TemplateSequencePlayer>(); } set { this["SequencePlayer"] = value; } }
        public SoftObjectPath TemplateSequence { get { return this[nameof(TemplateSequence)].As<SoftObjectPath>(); } set { this["TemplateSequence"] = value; } }
        public TemplateSequenceBindingOverrideData BindingOverride { get { return this[nameof(BindingOverride)].As<TemplateSequenceBindingOverrideData>(); } set { this["BindingOverride"] = value; } }
        public void SetSequence(TemplateSequence InSequence) { Invoke(nameof(SetSequence), InSequence); }
        public void SetBinding(Actor Actor) { Invoke(nameof(SetBinding), Actor); }
        public TemplateSequence LoadSequence() { return Invoke<TemplateSequence>(nameof(LoadSequence)); }
        public TemplateSequencePlayer GetSequencePlayer() { return Invoke<TemplateSequencePlayer>(nameof(GetSequencePlayer)); }
        public TemplateSequence GetSequence() { return Invoke<TemplateSequence>(nameof(GetSequence)); }
    }
    public class TemplateSequencePlayer : MovieSceneSequencePlayer
    {
        public TemplateSequencePlayer(ulong addr) : base(addr) { }
        public TemplateSequencePlayer CreateTemplateSequencePlayer(Object WorldContextObject, TemplateSequence TemplateSequence, MovieSceneSequencePlaybackSettings Settings, TemplateSequenceActor OutActor) { return Invoke<TemplateSequencePlayer>(nameof(CreateTemplateSequencePlayer), WorldContextObject, TemplateSequence, Settings, OutActor); }
    }
    public class TemplateSequenceSection : MovieSceneSubSection
    {
        public TemplateSequenceSection(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceSystem : MovieSceneEntitySystem
    {
        public TemplateSequenceSystem(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceTrack : MovieSceneSubTrack
    {
        public TemplateSequenceTrack(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceBindingOverrideData : Object
    {
        public TemplateSequenceBindingOverrideData(ulong addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public bool bOverridesDefault { get { return this[nameof(bOverridesDefault)].Flag; } set { this[nameof(bOverridesDefault)].Flag = value; } }
    }
}
