using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MovieSceneSDK;
using SDK.Script.UMGSDK;
using SDK.Script.MediaAssetsSDK;
namespace SDK.Script.LevelSequenceSDK
{
    public class AnimSequenceLevelSequenceLink : AssetUserData
    {
        public AnimSequenceLevelSequenceLink(ulong addr) : base(addr) { }
        public Guid SkelTrackGuid { get { return this[nameof(SkelTrackGuid)].As<Guid>(); } set { this["SkelTrackGuid"] = value; } }
        public SoftObjectPath PathToLevelSequence { get { return this[nameof(PathToLevelSequence)].As<SoftObjectPath>(); } set { this["PathToLevelSequence"] = value; } }
    }
    public class DefaultLevelSequenceInstanceData : Object
    {
        public DefaultLevelSequenceInstanceData(ulong addr) : base(addr) { }
        public Actor TransformOriginActor { get { return this[nameof(TransformOriginActor)].As<Actor>(); } set { this["TransformOriginActor"] = value; } }
        public Transform TransformOrigin { get { return this[nameof(TransformOrigin)].As<Transform>(); } set { this["TransformOrigin"] = value; } }
    }
    public class LevelSequenceMetaData : Interface
    {
        public LevelSequenceMetaData(ulong addr) : base(addr) { }
    }
    public class LevelSequence : MovieSceneSequence
    {
        public LevelSequence(ulong addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public LevelSequenceObjectReferenceMap ObjectReferences { get { return this[nameof(ObjectReferences)].As<LevelSequenceObjectReferenceMap>(); } set { this["ObjectReferences"] = value; } }
        public LevelSequenceBindingReferences BindingReferences { get { return this[nameof(BindingReferences)].As<LevelSequenceBindingReferences>(); } set { this["BindingReferences"] = value; } }
        public Object PossessedObjects { get { return this[nameof(PossessedObjects)]; } set { this[nameof(PossessedObjects)] = value; } }
        public Object DirectorClass { get { return this[nameof(DirectorClass)]; } set { this[nameof(DirectorClass)] = value; } }
        public Array<AssetUserData> AssetUserData { get { return new Array<AssetUserData>(this[nameof(AssetUserData)].Address); } }
        public void RemoveMetaDataByClass(Object InClass) { Invoke(nameof(RemoveMetaDataByClass), InClass); }
        public Object FindOrAddMetaDataByClass(Object InClass) { return Invoke<Object>(nameof(FindOrAddMetaDataByClass), InClass); }
        public Object FindMetaDataByClass(Object InClass) { return Invoke<Object>(nameof(FindMetaDataByClass), InClass); }
        public Object CopyMetaData(Object InMetaData) { return Invoke<Object>(nameof(CopyMetaData), InMetaData); }
    }
    public class LevelSequenceBurnInInitSettings : Object
    {
        public LevelSequenceBurnInInitSettings(ulong addr) : base(addr) { }
    }
    public class LevelSequenceBurnInOptions : Object
    {
        public LevelSequenceBurnInOptions(ulong addr) : base(addr) { }
        public bool bUseBurnIn { get { return this[nameof(bUseBurnIn)].Flag; } set { this[nameof(bUseBurnIn)].Flag = value; } }
        public SoftClassPath BurnInClass { get { return this[nameof(BurnInClass)].As<SoftClassPath>(); } set { this["BurnInClass"] = value; } }
        public LevelSequenceBurnInInitSettings Settings { get { return this[nameof(Settings)].As<LevelSequenceBurnInInitSettings>(); } set { this["Settings"] = value; } }
        public void SetBurnIn(SoftClassPath InBurnInClass) { Invoke(nameof(SetBurnIn), InBurnInClass); }
    }
    public class LevelSequenceActor : Actor
    {
        public LevelSequenceActor(ulong addr) : base(addr) { }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public LevelSequencePlayer SequencePlayer { get { return this[nameof(SequencePlayer)].As<LevelSequencePlayer>(); } set { this["SequencePlayer"] = value; } }
        public SoftObjectPath LevelSequence { get { return this[nameof(LevelSequence)].As<SoftObjectPath>(); } set { this["LevelSequence"] = value; } }
        public LevelSequenceCameraSettings CameraSettings { get { return this[nameof(CameraSettings)].As<LevelSequenceCameraSettings>(); } set { this["CameraSettings"] = value; } }
        public LevelSequenceBurnInOptions BurnInOptions { get { return this[nameof(BurnInOptions)].As<LevelSequenceBurnInOptions>(); } set { this["BurnInOptions"] = value; } }
        public MovieSceneBindingOverrides BindingOverrides { get { return this[nameof(BindingOverrides)].As<MovieSceneBindingOverrides>(); } set { this["BindingOverrides"] = value; } }
        public bool bAutoPlay { get { return this[nameof(bAutoPlay)].Flag; } set { this[nameof(bAutoPlay)].Flag = value; } }
        public bool bOverrideInstanceData { get { return this[nameof(bOverrideInstanceData)].Flag; } set { this[nameof(bOverrideInstanceData)].Flag = value; } }
        public bool bReplicatePlayback { get { return this[nameof(bReplicatePlayback)].Flag; } set { this[nameof(bReplicatePlayback)].Flag = value; } }
        public Object DefaultInstanceData { get { return this[nameof(DefaultInstanceData)].As<Object>(); } set { this["DefaultInstanceData"] = value; } }
        public LevelSequenceBurnIn BurnInInstance { get { return this[nameof(BurnInInstance)].As<LevelSequenceBurnIn>(); } set { this["BurnInInstance"] = value; } }
        public bool bShowBurnin { get { return this[nameof(bShowBurnin)].Flag; } set { this[nameof(bShowBurnin)].Flag = value; } }
        public void ShowBurnin() { Invoke(nameof(ShowBurnin)); }
        public void SetSequence(LevelSequence InSequence) { Invoke(nameof(SetSequence), InSequence); }
        public void SetReplicatePlayback(bool ReplicatePlayback) { Invoke(nameof(SetReplicatePlayback), ReplicatePlayback); }
        public void SetBindingByTag(Object BindingTag, Array<Actor> Actors, bool bAllowBindingsFromAsset) { Invoke(nameof(SetBindingByTag), BindingTag, Actors, bAllowBindingsFromAsset); }
        public void SetBinding(MovieSceneObjectBindingID Binding, Array<Actor> Actors, bool bAllowBindingsFromAsset) { Invoke(nameof(SetBinding), Binding, Actors, bAllowBindingsFromAsset); }
        public void ResetBindings() { Invoke(nameof(ResetBindings)); }
        public void ResetBinding(MovieSceneObjectBindingID Binding) { Invoke(nameof(ResetBinding), Binding); }
        public void RemoveBindingByTag(Object Tag, Actor Actor) { Invoke(nameof(RemoveBindingByTag), Tag, Actor); }
        public void RemoveBinding(MovieSceneObjectBindingID Binding, Actor Actor) { Invoke(nameof(RemoveBinding), Binding, Actor); }
        public void OnLevelSequenceLoaded__DelegateSignature() { Invoke(nameof(OnLevelSequenceLoaded__DelegateSignature)); }
        public LevelSequence LoadSequence() { return Invoke<LevelSequence>(nameof(LoadSequence)); }
        public void HideBurnin() { Invoke(nameof(HideBurnin)); }
        public LevelSequencePlayer GetSequencePlayer() { return Invoke<LevelSequencePlayer>(nameof(GetSequencePlayer)); }
        public LevelSequence GetSequence() { return Invoke<LevelSequence>(nameof(GetSequence)); }
        public Array<MovieSceneObjectBindingID> FindNamedBindings(Object Tag) { return Invoke<Array<MovieSceneObjectBindingID>>(nameof(FindNamedBindings), Tag); }
        public MovieSceneObjectBindingID FindNamedBinding(Object Tag) { return Invoke<MovieSceneObjectBindingID>(nameof(FindNamedBinding), Tag); }
        public void AddBindingByTag(Object BindingTag, Actor Actor, bool bAllowBindingsFromAsset) { Invoke(nameof(AddBindingByTag), BindingTag, Actor, bAllowBindingsFromAsset); }
        public void AddBinding(MovieSceneObjectBindingID Binding, Actor Actor, bool bAllowBindingsFromAsset) { Invoke(nameof(AddBinding), Binding, Actor, bAllowBindingsFromAsset); }
    }
    public class LevelSequenceAnimSequenceLink : AssetUserData
    {
        public LevelSequenceAnimSequenceLink(ulong addr) : base(addr) { }
        public Array<LevelSequenceAnimSequenceLinkItem> AnimSequenceLinks { get { return new Array<LevelSequenceAnimSequenceLinkItem>(this[nameof(AnimSequenceLinks)].Address); } }
    }
    public class LevelSequenceBurnIn : UserWidget
    {
        public LevelSequenceBurnIn(ulong addr) : base(addr) { }
        public LevelSequencePlayerSnapshot FrameInformation { get { return this[nameof(FrameInformation)].As<LevelSequencePlayerSnapshot>(); } set { this["FrameInformation"] = value; } }
        public LevelSequenceActor LevelSequenceActor { get { return this[nameof(LevelSequenceActor)].As<LevelSequenceActor>(); } set { this["LevelSequenceActor"] = value; } }
        public void SetSettings(Object InSettings) { Invoke(nameof(SetSettings), InSettings); }
        public Object GetSettingsClass() { return Invoke<Object>(nameof(GetSettingsClass)); }
    }
    public class LevelSequenceDirector : Object
    {
        public LevelSequenceDirector(ulong addr) : base(addr) { }
        public LevelSequencePlayer Player { get { return this[nameof(Player)].As<LevelSequencePlayer>(); } set { this["Player"] = value; } }
        public void OnCreated() { Invoke(nameof(OnCreated)); }
    }
    public class LegacyLevelSequenceDirectorBlueprint : Blueprint
    {
        public LegacyLevelSequenceDirectorBlueprint(ulong addr) : base(addr) { }
    }
    public class LevelSequencePlayer : MovieSceneSequencePlayer
    {
        public LevelSequencePlayer(ulong addr) : base(addr) { }
        public Object OnCameraCut { get { return this[nameof(OnCameraCut)]; } set { this[nameof(OnCameraCut)] = value; } }
        public CameraComponent GetActiveCameraComponent() { return Invoke<CameraComponent>(nameof(GetActiveCameraComponent)); }
        public LevelSequencePlayer CreateLevelSequencePlayer(Object WorldContextObject, LevelSequence LevelSequence, MovieSceneSequencePlaybackSettings Settings, LevelSequenceActor OutActor) { return Invoke<LevelSequencePlayer>(nameof(CreateLevelSequencePlayer), WorldContextObject, LevelSequence, Settings, OutActor); }
    }
    public class LevelSequenceMediaController : Actor
    {
        public LevelSequenceMediaController(ulong addr) : base(addr) { }
        public LevelSequenceActor Sequence { get { return this[nameof(Sequence)].As<LevelSequenceActor>(); } set { this["Sequence"] = value; } }
        public MediaComponent MediaComponent { get { return this[nameof(MediaComponent)].As<MediaComponent>(); } set { this["MediaComponent"] = value; } }
        public float ServerStartTimeSeconds { get { return this[nameof(ServerStartTimeSeconds)].GetValue<float>(); } set { this[nameof(ServerStartTimeSeconds)].SetValue<float>(value); } }
        public void SynchronizeToServer(float DesyncThresholdSeconds) { Invoke(nameof(SynchronizeToServer), DesyncThresholdSeconds); }
        public void Play() { Invoke(nameof(Play)); }
        public void OnRep_ServerStartTimeSeconds() { Invoke(nameof(OnRep_ServerStartTimeSeconds)); }
        public LevelSequenceActor GetSequence() { return Invoke<LevelSequenceActor>(nameof(GetSequence)); }
        public MediaComponent GetMediaComponent() { return Invoke<MediaComponent>(nameof(GetMediaComponent)); }
    }
    public class LevelSequenceCameraSettings : Object
    {
        public LevelSequenceCameraSettings(ulong addr) : base(addr) { }
        public bool bOverrideAspectRatioAxisConstraint { get { return this[nameof(bOverrideAspectRatioAxisConstraint)].Flag; } set { this[nameof(bOverrideAspectRatioAxisConstraint)].Flag = value; } }
        public byte AspectRatioAxisConstraint { get { return this[nameof(AspectRatioAxisConstraint)].GetValue<byte>(); } set { this[nameof(AspectRatioAxisConstraint)].SetValue<byte>(value); } }
    }
    public class BoundActorProxy : Object
    {
        public BoundActorProxy(ulong addr) : base(addr) { }
    }
    public class LevelSequenceAnimSequenceLinkItem : Object
    {
        public LevelSequenceAnimSequenceLinkItem(ulong addr) : base(addr) { }
        public Guid SkelTrackGuid { get { return this[nameof(SkelTrackGuid)].As<Guid>(); } set { this["SkelTrackGuid"] = value; } }
        public SoftObjectPath PathToAnimSequence { get { return this[nameof(PathToAnimSequence)].As<SoftObjectPath>(); } set { this["PathToAnimSequence"] = value; } }
        public bool bExportTransforms { get { return this[nameof(bExportTransforms)].Flag; } set { this[nameof(bExportTransforms)].Flag = value; } }
        public bool bExportCurves { get { return this[nameof(bExportCurves)].Flag; } set { this[nameof(bExportCurves)].Flag = value; } }
        public bool bRecordInWorldSpace { get { return this[nameof(bRecordInWorldSpace)].Flag; } set { this[nameof(bRecordInWorldSpace)].Flag = value; } }
    }
    public class LevelSequenceBindingReferences : Object
    {
        public LevelSequenceBindingReferences(ulong addr) : base(addr) { }
        public Object BindingIdToReferences { get { return this[nameof(BindingIdToReferences)]; } set { this[nameof(BindingIdToReferences)] = value; } }
        public Object AnimSequenceInstances { get { return this[nameof(AnimSequenceInstances)]; } set { this[nameof(AnimSequenceInstances)] = value; } }
    }
    public class LevelSequenceBindingReferenceArray : Object
    {
        public LevelSequenceBindingReferenceArray(ulong addr) : base(addr) { }
        public Array<LevelSequenceBindingReference> References { get { return new Array<LevelSequenceBindingReference>(this[nameof(References)].Address); } }
    }
    public class LevelSequenceBindingReference : Object
    {
        public LevelSequenceBindingReference(ulong addr) : base(addr) { }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public SoftObjectPath ExternalObjectPath { get { return this[nameof(ExternalObjectPath)].As<SoftObjectPath>(); } set { this["ExternalObjectPath"] = value; } }
        public Object ObjectPath { get { return this[nameof(ObjectPath)]; } set { this[nameof(ObjectPath)] = value; } }
    }
    public class LevelSequenceObjectReferenceMap : Object
    {
        public LevelSequenceObjectReferenceMap(ulong addr) : base(addr) { }
    }
    public class LevelSequenceLegacyObjectReference : Object
    {
        public LevelSequenceLegacyObjectReference(ulong addr) : base(addr) { }
    }
    public class LevelSequenceObject : Object
    {
        public LevelSequenceObject(ulong addr) : base(addr) { }
        public Object ObjectOrOwner { get { return this[nameof(ObjectOrOwner)]; } set { this[nameof(ObjectOrOwner)] = value; } }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public Object CachedComponent { get { return this[nameof(CachedComponent)]; } set { this[nameof(CachedComponent)] = value; } }
    }
    public class LevelSequencePlayerSnapshot : Object
    {
        public LevelSequencePlayerSnapshot(ulong addr) : base(addr) { }
        public Object MasterName { get { return this[nameof(MasterName)]; } set { this[nameof(MasterName)] = value; } }
        public QualifiedFrameTime MasterTime { get { return this[nameof(MasterTime)].As<QualifiedFrameTime>(); } set { this["MasterTime"] = value; } }
        public QualifiedFrameTime SourceTime { get { return this[nameof(SourceTime)].As<QualifiedFrameTime>(); } set { this["SourceTime"] = value; } }
        public Object CurrentShotName { get { return this[nameof(CurrentShotName)]; } set { this[nameof(CurrentShotName)] = value; } }
        public QualifiedFrameTime CurrentShotLocalTime { get { return this[nameof(CurrentShotLocalTime)].As<QualifiedFrameTime>(); } set { this["CurrentShotLocalTime"] = value; } }
        public QualifiedFrameTime CurrentShotSourceTime { get { return this[nameof(CurrentShotSourceTime)].As<QualifiedFrameTime>(); } set { this["CurrentShotSourceTime"] = value; } }
        public Object SourceTimecode { get { return this[nameof(SourceTimecode)]; } set { this[nameof(SourceTimecode)] = value; } }
        public Object CameraComponent { get { return this[nameof(CameraComponent)]; } set { this[nameof(CameraComponent)] = value; } }
        public LevelSequenceSnapshotSettings Settings { get { return this[nameof(Settings)].As<LevelSequenceSnapshotSettings>(); } set { this["Settings"] = value; } }
        public LevelSequence ActiveShot { get { return this[nameof(ActiveShot)].As<LevelSequence>(); } set { this["ActiveShot"] = value; } }
        public MovieSceneSequenceID ShotID { get { return this[nameof(ShotID)].As<MovieSceneSequenceID>(); } set { this["ShotID"] = value; } }
    }
    public class LevelSequenceSnapshotSettings : Object
    {
        public LevelSequenceSnapshotSettings(ulong addr) : base(addr) { }
        public byte ZeroPadAmount { get { return this[nameof(ZeroPadAmount)].GetValue<byte>(); } set { this[nameof(ZeroPadAmount)].SetValue<byte>(value); } }
        public FrameRate FrameRate { get { return this[nameof(FrameRate)].As<FrameRate>(); } set { this["FrameRate"] = value; } }
    }
}
