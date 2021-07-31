using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.MovieSceneTracksSDK
{
    public class MovieScenePropertyTrack : MovieSceneNameableTrack
    {
        public MovieScenePropertyTrack(ulong addr) : base(addr) { }
        public MovieSceneSection SectionToKey { get { return this[nameof(SectionToKey)].As<MovieSceneSection>(); } set { this["SectionToKey"] = value; } }
        public MovieScenePropertyBinding PropertyBinding { get { return this[nameof(PropertyBinding)].As<MovieScenePropertyBinding>(); } set { this["PropertyBinding"] = value; } }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class FloatChannelEvaluatorSystem : MovieSceneEntitySystem
    {
        public FloatChannelEvaluatorSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneTransformOrigin : Interface
    {
        public MovieSceneTransformOrigin(ulong addr) : base(addr) { }
        public Transform BP_GetTransformOrigin() { return Invoke<Transform>(nameof(BP_GetTransformOrigin)); }
    }
    public class MovieScene3DConstraintSection : MovieSceneSection
    {
        public MovieScene3DConstraintSection(ulong addr) : base(addr) { }
        public Guid ConstraintId { get { return this[nameof(ConstraintId)].As<Guid>(); } set { this["ConstraintId"] = value; } }
        public MovieSceneObjectBindingID ConstraintBindingID { get { return this[nameof(ConstraintBindingID)].As<MovieSceneObjectBindingID>(); } set { this["ConstraintBindingID"] = value; } }
        public void SetConstraintBindingID(MovieSceneObjectBindingID InConstraintBindingID) { Invoke(nameof(SetConstraintBindingID), InConstraintBindingID); }
        public MovieSceneObjectBindingID GetConstraintBindingID() { return Invoke<MovieSceneObjectBindingID>(nameof(GetConstraintBindingID)); }
    }
    public class MovieScene3DAttachSection : MovieScene3DConstraintSection
    {
        public MovieScene3DAttachSection(ulong addr) : base(addr) { }
        public Object AttachSocketName { get { return this[nameof(AttachSocketName)]; } set { this[nameof(AttachSocketName)] = value; } }
        public Object AttachComponentName { get { return this[nameof(AttachComponentName)]; } set { this[nameof(AttachComponentName)] = value; } }
        public EAttachmentRule AttachmentLocationRule { get { return (EAttachmentRule)this[nameof(AttachmentLocationRule)].GetValue<int>(); } set { this[nameof(AttachmentLocationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AttachmentRotationRule { get { return (EAttachmentRule)this[nameof(AttachmentRotationRule)].GetValue<int>(); } set { this[nameof(AttachmentRotationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AttachmentScaleRule { get { return (EAttachmentRule)this[nameof(AttachmentScaleRule)].GetValue<int>(); } set { this[nameof(AttachmentScaleRule)].SetValue<int>((int)value); } }
        public EDetachmentRule DetachmentLocationRule { get { return (EDetachmentRule)this[nameof(DetachmentLocationRule)].GetValue<int>(); } set { this[nameof(DetachmentLocationRule)].SetValue<int>((int)value); } }
        public EDetachmentRule DetachmentRotationRule { get { return (EDetachmentRule)this[nameof(DetachmentRotationRule)].GetValue<int>(); } set { this[nameof(DetachmentRotationRule)].SetValue<int>((int)value); } }
        public EDetachmentRule DetachmentScaleRule { get { return (EDetachmentRule)this[nameof(DetachmentScaleRule)].GetValue<int>(); } set { this[nameof(DetachmentScaleRule)].SetValue<int>((int)value); } }
    }
    public class MovieScene3DConstraintTrack : MovieSceneTrack
    {
        public MovieScene3DConstraintTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> ConstraintSections { get { return new Array<MovieSceneSection>(this[nameof(ConstraintSections)].Address); } }
    }
    public class MovieScene3DAttachTrack : MovieScene3DConstraintTrack
    {
        public MovieScene3DAttachTrack(ulong addr) : base(addr) { }
    }
    public class MovieScene3DPathSection : MovieScene3DConstraintSection
    {
        public MovieScene3DPathSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel TimingCurve { get { return this[nameof(TimingCurve)].As<MovieSceneFloatChannel>(); } set { this["TimingCurve"] = value; } }
        public MovieScene3DPathSection_Axis FrontAxisEnum { get { return (MovieScene3DPathSection_Axis)this[nameof(FrontAxisEnum)].GetValue<int>(); } set { this[nameof(FrontAxisEnum)].SetValue<int>((int)value); } }
        public MovieScene3DPathSection_Axis UpAxisEnum { get { return (MovieScene3DPathSection_Axis)this[nameof(UpAxisEnum)].GetValue<int>(); } set { this[nameof(UpAxisEnum)].SetValue<int>((int)value); } }
        public bool bFollow { get { return this[nameof(bFollow)].Flag; } set { this[nameof(bFollow)].Flag = value; } }
        public bool bReverse { get { return this[nameof(bReverse)].Flag; } set { this[nameof(bReverse)].Flag = value; } }
        public bool bForceUpright { get { return this[nameof(bForceUpright)].Flag; } set { this[nameof(bForceUpright)].Flag = value; } }
    }
    public class MovieScene3DPathTrack : MovieScene3DConstraintTrack
    {
        public MovieScene3DPathTrack(ulong addr) : base(addr) { }
    }
    public class MovieScenePropertySystem : MovieSceneEntitySystem
    {
        public MovieScenePropertySystem(ulong addr) : base(addr) { }
        public MovieScenePropertyInstantiatorSystem InstantiatorSystem { get { return this[nameof(InstantiatorSystem)].As<MovieScenePropertyInstantiatorSystem>(); } set { this["InstantiatorSystem"] = value; } }
    }
    public class MovieScene3DTransformPropertySystem : MovieScenePropertySystem
    {
        public MovieScene3DTransformPropertySystem(ulong addr) : base(addr) { }
    }
    public class MovieScene3DTransformSection : MovieSceneSection
    {
        public MovieScene3DTransformSection(ulong addr) : base(addr) { }
        public MovieSceneTransformMask TransformMask { get { return this[nameof(TransformMask)].As<MovieSceneTransformMask>(); } set { this["TransformMask"] = value; } }
        public MovieSceneFloatChannel Translation { get { return this[nameof(Translation)].As<MovieSceneFloatChannel>(); } set { this["Translation"] = value; } }
        public MovieSceneFloatChannel Rotation { get { return this[nameof(Rotation)].As<MovieSceneFloatChannel>(); } set { this["Rotation"] = value; } }
        public MovieSceneFloatChannel Scale { get { return this[nameof(Scale)].As<MovieSceneFloatChannel>(); } set { this["Scale"] = value; } }
        public MovieSceneFloatChannel ManualWeight { get { return this[nameof(ManualWeight)].As<MovieSceneFloatChannel>(); } set { this["ManualWeight"] = value; } }
        public bool bUseQuaternionInterpolation { get { return this[nameof(bUseQuaternionInterpolation)].Flag; } set { this[nameof(bUseQuaternionInterpolation)].Flag = value; } }
    }
    public class MovieScene3DTransformTrack : MovieScenePropertyTrack
    {
        public MovieScene3DTransformTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneActorReferenceSection : MovieSceneSection
    {
        public MovieSceneActorReferenceSection(ulong addr) : base(addr) { }
        public MovieSceneActorReferenceData ActorReferenceData { get { return this[nameof(ActorReferenceData)].As<MovieSceneActorReferenceData>(); } set { this["ActorReferenceData"] = value; } }
        public IntegralCurve ActorGuidIndexCurve { get { return this[nameof(ActorGuidIndexCurve)].As<IntegralCurve>(); } set { this["ActorGuidIndexCurve"] = value; } }
        public Array<Object> ActorGuidStrings { get { return new Array<Object>(this[nameof(ActorGuidStrings)].Address); } }
    }
    public class MovieSceneActorReferenceTrack : MovieScenePropertyTrack
    {
        public MovieSceneActorReferenceTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneAudioSection : MovieSceneSection
    {
        public MovieSceneAudioSection(ulong addr) : base(addr) { }
        public SoundBase Sound { get { return this[nameof(Sound)].As<SoundBase>(); } set { this["Sound"] = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float AudioStartTime { get { return this[nameof(AudioStartTime)].GetValue<float>(); } set { this[nameof(AudioStartTime)].SetValue<float>(value); } }
        public float AudioDilationFactor { get { return this[nameof(AudioDilationFactor)].GetValue<float>(); } set { this[nameof(AudioDilationFactor)].SetValue<float>(value); } }
        public float AudioVolume { get { return this[nameof(AudioVolume)].GetValue<float>(); } set { this[nameof(AudioVolume)].SetValue<float>(value); } }
        public MovieSceneFloatChannel SoundVolume { get { return this[nameof(SoundVolume)].As<MovieSceneFloatChannel>(); } set { this["SoundVolume"] = value; } }
        public MovieSceneFloatChannel PitchMultiplier { get { return this[nameof(PitchMultiplier)].As<MovieSceneFloatChannel>(); } set { this["PitchMultiplier"] = value; } }
        public MovieSceneActorReferenceData AttachActorData { get { return this[nameof(AttachActorData)].As<MovieSceneActorReferenceData>(); } set { this["AttachActorData"] = value; } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
        public bool bSuppressSubtitles { get { return this[nameof(bSuppressSubtitles)].Flag; } set { this[nameof(bSuppressSubtitles)].Flag = value; } }
        public bool bOverrideAttenuation { get { return this[nameof(bOverrideAttenuation)].Flag; } set { this[nameof(bOverrideAttenuation)].Flag = value; } }
        public SoundAttenuation AttenuationSettings { get { return this[nameof(AttenuationSettings)].As<SoundAttenuation>(); } set { this["AttenuationSettings"] = value; } }
        public Object OnQueueSubtitles { get { return this[nameof(OnQueueSubtitles)]; } set { this[nameof(OnQueueSubtitles)] = value; } }
        public Object OnAudioFinished { get { return this[nameof(OnAudioFinished)]; } set { this[nameof(OnAudioFinished)] = value; } }
        public Object OnAudioPlaybackPercent { get { return this[nameof(OnAudioPlaybackPercent)]; } set { this[nameof(OnAudioPlaybackPercent)] = value; } }
        public void SetStartOffset(FrameNumber InStartOffset) { Invoke(nameof(SetStartOffset), InStartOffset); }
        public void SetSound(SoundBase InSound) { Invoke(nameof(SetSound), InSound); }
        public FrameNumber GetStartOffset() { return Invoke<FrameNumber>(nameof(GetStartOffset)); }
        public SoundBase GetSound() { return Invoke<SoundBase>(nameof(GetSound)); }
    }
    public class MovieSceneAudioTrack : MovieSceneNameableTrack
    {
        public MovieSceneAudioTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> AudioSections { get { return new Array<MovieSceneSection>(this[nameof(AudioSections)].Address); } }
    }
    public class MovieSceneBaseValueEvaluatorSystem : MovieSceneEntitySystem
    {
        public MovieSceneBaseValueEvaluatorSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneBoolTrack : MovieScenePropertyTrack
    {
        public MovieSceneBoolTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneByteSection : MovieSceneSection
    {
        public MovieSceneByteSection(ulong addr) : base(addr) { }
        public MovieSceneByteChannel ByteCurve { get { return this[nameof(ByteCurve)].As<MovieSceneByteChannel>(); } set { this["ByteCurve"] = value; } }
    }
    public class MovieSceneByteTrack : MovieScenePropertyTrack
    {
        public MovieSceneByteTrack(ulong addr) : base(addr) { }
        public Enum Enum { get { return this[nameof(Enum)].As<Enum>(); } set { this["Enum"] = value; } }
    }
    public class MovieSceneCameraAnimSection : MovieSceneSection
    {
        public MovieSceneCameraAnimSection(ulong addr) : base(addr) { }
        public MovieSceneCameraAnimSectionData AnimData { get { return this[nameof(AnimData)].As<MovieSceneCameraAnimSectionData>(); } set { this["AnimData"] = value; } }
        public CameraAnim CameraAnim { get { return this[nameof(CameraAnim)].As<CameraAnim>(); } set { this["CameraAnim"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float PlayScale { get { return this[nameof(PlayScale)].GetValue<float>(); } set { this[nameof(PlayScale)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
    }
    public class MovieSceneCameraAnimTrack : MovieSceneNameableTrack
    {
        public MovieSceneCameraAnimTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> CameraAnimSections { get { return new Array<MovieSceneSection>(this[nameof(CameraAnimSections)].Address); } }
    }
    public class MovieSceneCameraCutSection : MovieSceneSection
    {
        public MovieSceneCameraCutSection(ulong addr) : base(addr) { }
        public bool bLockPreviousCamera { get { return this[nameof(bLockPreviousCamera)].Flag; } set { this[nameof(bLockPreviousCamera)].Flag = value; } }
        public Guid CameraGuid { get { return this[nameof(CameraGuid)].As<Guid>(); } set { this["CameraGuid"] = value; } }
        public MovieSceneObjectBindingID CameraBindingID { get { return this[nameof(CameraBindingID)].As<MovieSceneObjectBindingID>(); } set { this["CameraBindingID"] = value; } }
        public Transform InitialCameraCutTransform { get { return this[nameof(InitialCameraCutTransform)].As<Transform>(); } set { this["InitialCameraCutTransform"] = value; } }
        public bool bHasInitialCameraCutTransform { get { return this[nameof(bHasInitialCameraCutTransform)].Flag; } set { this[nameof(bHasInitialCameraCutTransform)].Flag = value; } }
        public void SetCameraBindingID(MovieSceneObjectBindingID InCameraBindingID) { Invoke(nameof(SetCameraBindingID), InCameraBindingID); }
        public MovieSceneObjectBindingID GetCameraBindingID() { return Invoke<MovieSceneObjectBindingID>(nameof(GetCameraBindingID)); }
    }
    public class MovieSceneCameraCutTrack : MovieSceneNameableTrack
    {
        public MovieSceneCameraCutTrack(ulong addr) : base(addr) { }
        public bool bCanBlend { get { return this[nameof(bCanBlend)].Flag; } set { this[nameof(bCanBlend)].Flag = value; } }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneCameraCutTrackInstance : MovieSceneTrackInstance
    {
        public MovieSceneCameraCutTrackInstance(ulong addr) : base(addr) { }
    }
    public class MovieSceneCameraShakeSection : MovieSceneSection
    {
        public MovieSceneCameraShakeSection(ulong addr) : base(addr) { }
        public MovieSceneCameraShakeSectionData ShakeData { get { return this[nameof(ShakeData)].As<MovieSceneCameraShakeSectionData>(); } set { this["ShakeData"] = value; } }
        public Object ShakeClass { get { return this[nameof(ShakeClass)]; } set { this[nameof(ShakeClass)] = value; } }
        public float PlayScale { get { return this[nameof(PlayScale)].GetValue<float>(); } set { this[nameof(PlayScale)].SetValue<float>(value); } }
        public ECameraShakePlaySpace PlaySpace { get { return (ECameraShakePlaySpace)this[nameof(PlaySpace)].GetValue<int>(); } set { this[nameof(PlaySpace)].SetValue<int>((int)value); } }
        public Rotator UserDefinedPlaySpace { get { return this[nameof(UserDefinedPlaySpace)].As<Rotator>(); } set { this["UserDefinedPlaySpace"] = value; } }
    }
    public class MovieSceneCameraShakeSourceShakeSection : MovieSceneSection
    {
        public MovieSceneCameraShakeSourceShakeSection(ulong addr) : base(addr) { }
        public MovieSceneCameraShakeSectionData ShakeData { get { return this[nameof(ShakeData)].As<MovieSceneCameraShakeSectionData>(); } set { this["ShakeData"] = value; } }
    }
    public class MovieSceneCameraShakeSourceShakeTrack : MovieSceneNameableTrack
    {
        public MovieSceneCameraShakeSourceShakeTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> CameraShakeSections { get { return new Array<MovieSceneSection>(this[nameof(CameraShakeSections)].Address); } }
    }
    public class MovieSceneCameraShakeSourceTriggerSection : MovieSceneSection
    {
        public MovieSceneCameraShakeSourceTriggerSection(ulong addr) : base(addr) { }
        public MovieSceneCameraShakeSourceTriggerChannel Channel { get { return this[nameof(Channel)].As<MovieSceneCameraShakeSourceTriggerChannel>(); } set { this["Channel"] = value; } }
    }
    public class MovieSceneCameraShakeSourceTriggerTrack : MovieSceneTrack
    {
        public MovieSceneCameraShakeSourceTriggerTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneCameraShakeTrack : MovieSceneNameableTrack
    {
        public MovieSceneCameraShakeTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> CameraShakeSections { get { return new Array<MovieSceneSection>(this[nameof(CameraShakeSections)].Address); } }
    }
    public class MovieSceneCinematicShotSection : MovieSceneSubSection
    {
        public MovieSceneCinematicShotSection(ulong addr) : base(addr) { }
        public Object ShotDisplayName { get { return this[nameof(ShotDisplayName)]; } set { this[nameof(ShotDisplayName)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public void SetShotDisplayName(Object InShotDisplayName) { Invoke(nameof(SetShotDisplayName), InShotDisplayName); }
        public Object GetShotDisplayName() { return Invoke<Object>(nameof(GetShotDisplayName)); }
    }
    public class MovieSceneCinematicShotTrack : MovieSceneSubTrack
    {
        public MovieSceneCinematicShotTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneColorSection : MovieSceneSection
    {
        public MovieSceneColorSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel RedCurve { get { return this[nameof(RedCurve)].As<MovieSceneFloatChannel>(); } set { this["RedCurve"] = value; } }
        public MovieSceneFloatChannel GreenCurve { get { return this[nameof(GreenCurve)].As<MovieSceneFloatChannel>(); } set { this["GreenCurve"] = value; } }
        public MovieSceneFloatChannel BlueCurve { get { return this[nameof(BlueCurve)].As<MovieSceneFloatChannel>(); } set { this["BlueCurve"] = value; } }
        public MovieSceneFloatChannel AlphaCurve { get { return this[nameof(AlphaCurve)].As<MovieSceneFloatChannel>(); } set { this["AlphaCurve"] = value; } }
    }
    public class MovieSceneColorTrack : MovieScenePropertyTrack
    {
        public MovieSceneColorTrack(ulong addr) : base(addr) { }
        public bool bIsSlateColor { get { return this[nameof(bIsSlateColor)].Flag; } set { this[nameof(bIsSlateColor)].Flag = value; } }
    }
    public class MovieSceneComponentAttachmentInvalidatorSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneComponentAttachmentInvalidatorSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneComponentAttachmentSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneComponentAttachmentSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneComponentMobilitySystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneComponentMobilitySystem(ulong addr) : base(addr) { }
    }
    public class MovieScenePreAnimatedComponentTransformSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieScenePreAnimatedComponentTransformSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneComponentTransformSystem : MovieScenePropertySystem
    {
        public MovieSceneComponentTransformSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneEnumSection : MovieSceneSection
    {
        public MovieSceneEnumSection(ulong addr) : base(addr) { }
        public MovieSceneByteChannel EnumCurve { get { return this[nameof(EnumCurve)].As<MovieSceneByteChannel>(); } set { this["EnumCurve"] = value; } }
    }
    public class MovieSceneEnumTrack : MovieScenePropertyTrack
    {
        public MovieSceneEnumTrack(ulong addr) : base(addr) { }
        public Enum Enum { get { return this[nameof(Enum)].As<Enum>(); } set { this["Enum"] = value; } }
    }
    public class MovieSceneEulerTransformPropertySystem : MovieScenePropertySystem
    {
        public MovieSceneEulerTransformPropertySystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneEulerTransformTrack : MovieScenePropertyTrack
    {
        public MovieSceneEulerTransformTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneEventSectionBase : MovieSceneSection
    {
        public MovieSceneEventSectionBase(ulong addr) : base(addr) { }
    }
    public class MovieSceneEventRepeaterSection : MovieSceneEventSectionBase
    {
        public MovieSceneEventRepeaterSection(ulong addr) : base(addr) { }
        public MovieSceneEvent Event { get { return this[nameof(Event)].As<MovieSceneEvent>(); } set { this["Event"] = value; } }
    }
    public class MovieSceneEventSection : MovieSceneSection
    {
        public MovieSceneEventSection(ulong addr) : base(addr) { }
        public NameCurve Events { get { return this[nameof(Events)].As<NameCurve>(); } set { this["Events"] = value; } }
        public MovieSceneEventSectionData EventData { get { return this[nameof(EventData)].As<MovieSceneEventSectionData>(); } set { this["EventData"] = value; } }
    }
    public class MovieSceneEventSystem : MovieSceneEntitySystem
    {
        public MovieSceneEventSystem(ulong addr) : base(addr) { }
    }
    public class MovieScenePreSpawnEventSystem : MovieSceneEventSystem
    {
        public MovieScenePreSpawnEventSystem(ulong addr) : base(addr) { }
    }
    public class MovieScenePostSpawnEventSystem : MovieSceneEventSystem
    {
        public MovieScenePostSpawnEventSystem(ulong addr) : base(addr) { }
    }
    public class MovieScenePostEvalEventSystem : MovieSceneEventSystem
    {
        public MovieScenePostEvalEventSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneEventTrack : MovieSceneNameableTrack
    {
        public MovieSceneEventTrack(ulong addr) : base(addr) { }
        public bool bFireEventsWhenForwards { get { return this[nameof(bFireEventsWhenForwards)].Flag; } set { this[nameof(bFireEventsWhenForwards)].Flag = value; } }
        public bool bFireEventsWhenBackwards { get { return this[nameof(bFireEventsWhenBackwards)].Flag; } set { this[nameof(bFireEventsWhenBackwards)].Flag = value; } }
        public EFireEventsAtPosition EventPosition { get { return (EFireEventsAtPosition)this[nameof(EventPosition)].GetValue<int>(); } set { this[nameof(EventPosition)].SetValue<int>((int)value); } }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneEventTriggerSection : MovieSceneEventSectionBase
    {
        public MovieSceneEventTriggerSection(ulong addr) : base(addr) { }
        public MovieSceneEventChannel EventChannel { get { return this[nameof(EventChannel)].As<MovieSceneEventChannel>(); } set { this["EventChannel"] = value; } }
    }
    public class MovieSceneFadeSection : MovieSceneSection
    {
        public MovieSceneFadeSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel FloatCurve { get { return this[nameof(FloatCurve)].As<MovieSceneFloatChannel>(); } set { this["FloatCurve"] = value; } }
        public LinearColor FadeColor { get { return this[nameof(FadeColor)].As<LinearColor>(); } set { this["FadeColor"] = value; } }
        public bool bFadeAudio { get { return this[nameof(bFadeAudio)].Flag; } set { this[nameof(bFadeAudio)].Flag = value; } }
    }
    public class MovieSceneFloatTrack : MovieScenePropertyTrack
    {
        public MovieSceneFloatTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneFadeTrack : MovieSceneFloatTrack
    {
        public MovieSceneFadeTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneFloatPropertySystem : MovieScenePropertySystem
    {
        public MovieSceneFloatPropertySystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneFloatSection : MovieSceneSection
    {
        public MovieSceneFloatSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel FloatCurve { get { return this[nameof(FloatCurve)].As<MovieSceneFloatChannel>(); } set { this["FloatCurve"] = value; } }
    }
    public class MovieSceneHierarchicalBiasSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneHierarchicalBiasSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneIntegerSection : MovieSceneSection
    {
        public MovieSceneIntegerSection(ulong addr) : base(addr) { }
        public MovieSceneIntegerChannel IntegerCurve { get { return this[nameof(IntegerCurve)].As<MovieSceneIntegerChannel>(); } set { this["IntegerCurve"] = value; } }
    }
    public class MovieSceneIntegerTrack : MovieScenePropertyTrack
    {
        public MovieSceneIntegerTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneInterrogatedPropertyInstantiatorSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneInterrogatedPropertyInstantiatorSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneLevelVisibilitySection : MovieSceneSection
    {
        public MovieSceneLevelVisibilitySection(ulong addr) : base(addr) { }
        public ELevelVisibility Visibility { get { return (ELevelVisibility)this[nameof(Visibility)].GetValue<int>(); } set { this[nameof(Visibility)].SetValue<int>((int)value); } }
        public Array<Object> LevelNames { get { return new Array<Object>(this[nameof(LevelNames)].Address); } }
        public void SetVisibility(ELevelVisibility InVisibility) { Invoke(nameof(SetVisibility), InVisibility); }
        public void SetLevelNames(Array<Object> InLevelNames) { Invoke(nameof(SetLevelNames), InLevelNames); }
        public ELevelVisibility GetVisibility() { return Invoke<ELevelVisibility>(nameof(GetVisibility)); }
        public Array<Object> GetLevelNames() { return Invoke<Array<Object>>(nameof(GetLevelNames)); }
    }
    public class MovieSceneLevelVisibilitySystem : MovieSceneEntitySystem
    {
        public MovieSceneLevelVisibilitySystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneLevelVisibilityTrack : MovieSceneNameableTrack
    {
        public MovieSceneLevelVisibilityTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneMaterialTrack : MovieSceneNameableTrack
    {
        public MovieSceneMaterialTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneMaterialParameterCollectionTrack : MovieSceneMaterialTrack
    {
        public MovieSceneMaterialParameterCollectionTrack(ulong addr) : base(addr) { }
        public MaterialParameterCollection MPC { get { return this[nameof(MPC)].As<MaterialParameterCollection>(); } set { this["MPC"] = value; } }
    }
    public class MovieSceneComponentMaterialTrack : MovieSceneMaterialTrack
    {
        public MovieSceneComponentMaterialTrack(ulong addr) : base(addr) { }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
    }
    public class MovieSceneObjectPropertySection : MovieSceneSection
    {
        public MovieSceneObjectPropertySection(ulong addr) : base(addr) { }
        public MovieSceneObjectPathChannel ObjectChannel { get { return this[nameof(ObjectChannel)].As<MovieSceneObjectPathChannel>(); } set { this["ObjectChannel"] = value; } }
    }
    public class MovieSceneObjectPropertyTrack : MovieScenePropertyTrack
    {
        public MovieSceneObjectPropertyTrack(ulong addr) : base(addr) { }
        public Object PropertyClass { get { return this[nameof(PropertyClass)]; } set { this[nameof(PropertyClass)] = value; } }
    }
    public class MovieSceneParameterSection : MovieSceneSection
    {
        public MovieSceneParameterSection(ulong addr) : base(addr) { }
        public Array<BoolParameterNameAndCurve> BoolParameterNamesAndCurves { get { return new Array<BoolParameterNameAndCurve>(this[nameof(BoolParameterNamesAndCurves)].Address); } }
        public Array<ScalarParameterNameAndCurve> ScalarParameterNamesAndCurves { get { return new Array<ScalarParameterNameAndCurve>(this[nameof(ScalarParameterNamesAndCurves)].Address); } }
        public Array<Vector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves { get { return new Array<Vector2DParameterNameAndCurves>(this[nameof(Vector2DParameterNamesAndCurves)].Address); } }
        public Array<VectorParameterNameAndCurves> VectorParameterNamesAndCurves { get { return new Array<VectorParameterNameAndCurves>(this[nameof(VectorParameterNamesAndCurves)].Address); } }
        public Array<ColorParameterNameAndCurves> ColorParameterNamesAndCurves { get { return new Array<ColorParameterNameAndCurves>(this[nameof(ColorParameterNamesAndCurves)].Address); } }
        public Array<TransformParameterNameAndCurves> TransformParameterNamesAndCurves { get { return new Array<TransformParameterNameAndCurves>(this[nameof(TransformParameterNamesAndCurves)].Address); } }
        public bool RemoveVectorParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveVectorParameter), InParameterName); }
        public bool RemoveVector2DParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveVector2DParameter), InParameterName); }
        public bool RemoveTransformParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveTransformParameter), InParameterName); }
        public bool RemoveScalarParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveScalarParameter), InParameterName); }
        public bool RemoveColorParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveColorParameter), InParameterName); }
        public bool RemoveBoolParameter(Object InParameterName) { return Invoke<bool>(nameof(RemoveBoolParameter), InParameterName); }
        public void GetParameterNames(Object ParameterNames) { Invoke(nameof(GetParameterNames), ParameterNames); }
        public void AddVectorParameterKey(Object InParameterName, FrameNumber InTime, Vector InValue) { Invoke(nameof(AddVectorParameterKey), InParameterName, InTime, InValue); }
        public void AddVector2DParameterKey(Object InParameterName, FrameNumber InTime, Vector2D InValue) { Invoke(nameof(AddVector2DParameterKey), InParameterName, InTime, InValue); }
        public void AddTransformParameterKey(Object InParameterName, FrameNumber InTime, Transform InValue) { Invoke(nameof(AddTransformParameterKey), InParameterName, InTime, InValue); }
        public void AddScalarParameterKey(Object InParameterName, FrameNumber InTime, float InValue) { Invoke(nameof(AddScalarParameterKey), InParameterName, InTime, InValue); }
        public void AddColorParameterKey(Object InParameterName, FrameNumber InTime, LinearColor InValue) { Invoke(nameof(AddColorParameterKey), InParameterName, InTime, InValue); }
        public void AddBoolParameterKey(Object InParameterName, FrameNumber InTime, bool InValue) { Invoke(nameof(AddBoolParameterKey), InParameterName, InTime, InValue); }
    }
    public class MovieSceneParticleParameterTrack : MovieSceneNameableTrack
    {
        public MovieSceneParticleParameterTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneParticleSection : MovieSceneSection
    {
        public MovieSceneParticleSection(ulong addr) : base(addr) { }
        public MovieSceneParticleChannel ParticleKeys { get { return this[nameof(ParticleKeys)].As<MovieSceneParticleChannel>(); } set { this["ParticleKeys"] = value; } }
    }
    public class MovieSceneParticleTrack : MovieSceneNameableTrack
    {
        public MovieSceneParticleTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> ParticleSections { get { return new Array<MovieSceneSection>(this[nameof(ParticleSections)].Address); } }
    }
    public class MovieScenePiecewiseFloatBlenderSystem : MovieSceneBlenderSystem
    {
        public MovieScenePiecewiseFloatBlenderSystem(ulong addr) : base(addr) { }
    }
    public class MovieScenePrimitiveMaterialSection : MovieSceneSection
    {
        public MovieScenePrimitiveMaterialSection(ulong addr) : base(addr) { }
        public MovieSceneObjectPathChannel MaterialChannel { get { return this[nameof(MaterialChannel)].As<MovieSceneObjectPathChannel>(); } set { this["MaterialChannel"] = value; } }
    }
    public class MovieScenePrimitiveMaterialTrack : MovieScenePropertyTrack
    {
        public MovieScenePrimitiveMaterialTrack(ulong addr) : base(addr) { }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
    }
    public class MovieScenePropertyInstantiatorSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieScenePropertyInstantiatorSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneQuaternionInterpolationRotationSystem : MovieSceneEntitySystem
    {
        public MovieSceneQuaternionInterpolationRotationSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneSkeletalAnimationSection : MovieSceneSection
    {
        public MovieSceneSkeletalAnimationSection(ulong addr) : base(addr) { }
        public MovieSceneSkeletalAnimationParams Params { get { return this[nameof(Params)].As<MovieSceneSkeletalAnimationParams>(); } set { this["Params"] = value; } }
        public AnimSequence AnimSequence { get { return this[nameof(AnimSequence)].As<AnimSequence>(); } set { this["AnimSequence"] = value; } }
        public AnimSequenceBase Animation { get { return this[nameof(Animation)].As<AnimSequenceBase>(); } set { this["Animation"] = value; } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float EndOffset { get { return this[nameof(EndOffset)].GetValue<float>(); } set { this[nameof(EndOffset)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bReverse { get { return this[nameof(bReverse)].Flag; } set { this[nameof(bReverse)].Flag = value; } }
        public Object SlotName { get { return this[nameof(SlotName)]; } set { this[nameof(SlotName)] = value; } }
        public Vector StartLocationOffset { get { return this[nameof(StartLocationOffset)].As<Vector>(); } set { this["StartLocationOffset"] = value; } }
        public Rotator StartRotationOffset { get { return this[nameof(StartRotationOffset)].As<Rotator>(); } set { this["StartRotationOffset"] = value; } }
        public bool bMatchWithPrevious { get { return this[nameof(bMatchWithPrevious)].Flag; } set { this[nameof(bMatchWithPrevious)].Flag = value; } }
        public Object MatchedBoneName { get { return this[nameof(MatchedBoneName)]; } set { this[nameof(MatchedBoneName)] = value; } }
        public Vector MatchedLocationOffset { get { return this[nameof(MatchedLocationOffset)].As<Vector>(); } set { this["MatchedLocationOffset"] = value; } }
        public Rotator MatchedRotationOffset { get { return this[nameof(MatchedRotationOffset)].As<Rotator>(); } set { this["MatchedRotationOffset"] = value; } }
        public bool bMatchTranslation { get { return this[nameof(bMatchTranslation)].Flag; } set { this[nameof(bMatchTranslation)].Flag = value; } }
        public bool bMatchIncludeZHeight { get { return this[nameof(bMatchIncludeZHeight)].Flag; } set { this[nameof(bMatchIncludeZHeight)].Flag = value; } }
        public bool bMatchRotationYaw { get { return this[nameof(bMatchRotationYaw)].Flag; } set { this[nameof(bMatchRotationYaw)].Flag = value; } }
        public bool bMatchRotationPitch { get { return this[nameof(bMatchRotationPitch)].Flag; } set { this[nameof(bMatchRotationPitch)].Flag = value; } }
        public bool bMatchRotationRoll { get { return this[nameof(bMatchRotationRoll)].Flag; } set { this[nameof(bMatchRotationRoll)].Flag = value; } }
    }
    public class MovieSceneSkeletalAnimationTrack : MovieSceneNameableTrack
    {
        public MovieSceneSkeletalAnimationTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> AnimationSections { get { return new Array<MovieSceneSection>(this[nameof(AnimationSections)].Address); } }
        public bool bUseLegacySectionIndexBlend { get { return this[nameof(bUseLegacySectionIndexBlend)].Flag; } set { this[nameof(bUseLegacySectionIndexBlend)].Flag = value; } }
        public MovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams { get { return this[nameof(RootMotionParams)].As<MovieSceneSkeletalAnimRootMotionTrackParams>(); } set { this["RootMotionParams"] = value; } }
        public bool bBlendFirstChildOfRoot { get { return this[nameof(bBlendFirstChildOfRoot)].Flag; } set { this[nameof(bBlendFirstChildOfRoot)].Flag = value; } }
    }
    public class MovieSceneSlomoSection : MovieSceneSection
    {
        public MovieSceneSlomoSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel FloatCurve { get { return this[nameof(FloatCurve)].As<MovieSceneFloatChannel>(); } set { this["FloatCurve"] = value; } }
    }
    public class MovieSceneSlomoTrack : MovieSceneFloatTrack
    {
        public MovieSceneSlomoTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneStringSection : MovieSceneSection
    {
        public MovieSceneStringSection(ulong addr) : base(addr) { }
        public MovieSceneStringChannel StringCurve { get { return this[nameof(StringCurve)].As<MovieSceneStringChannel>(); } set { this["StringCurve"] = value; } }
    }
    public class MovieSceneStringTrack : MovieScenePropertyTrack
    {
        public MovieSceneStringTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneTransformOriginSystem : MovieSceneEntitySystem
    {
        public MovieSceneTransformOriginSystem(ulong addr) : base(addr) { }
    }
    public class MovieSceneTransformTrack : MovieScenePropertyTrack
    {
        public MovieSceneTransformTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneVectorSection : MovieSceneSection
    {
        public MovieSceneVectorSection(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel Curves { get { return this[nameof(Curves)].As<MovieSceneFloatChannel>(); } set { this["Curves"] = value; } }
        public int ChannelsUsed { get { return this[nameof(ChannelsUsed)].GetValue<int>(); } set { this[nameof(ChannelsUsed)].SetValue<int>(value); } }
    }
    public class MovieSceneVectorTrack : MovieScenePropertyTrack
    {
        public MovieSceneVectorTrack(ulong addr) : base(addr) { }
        public int NumChannelsUsed { get { return this[nameof(NumChannelsUsed)].GetValue<int>(); } set { this[nameof(NumChannelsUsed)].SetValue<int>(value); } }
    }
    public class MovieSceneVisibilityTrack : MovieSceneBoolTrack
    {
        public MovieSceneVisibilityTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneHierarchicalEasingInstantiatorSystem : MovieSceneEntityInstantiatorSystem
    {
        public MovieSceneHierarchicalEasingInstantiatorSystem(ulong addr) : base(addr) { }
    }
    public class WeightAndEasingEvaluatorSystem : MovieSceneEntitySystem
    {
        public WeightAndEasingEvaluatorSystem(ulong addr) : base(addr) { }
    }
    public enum MovieScene3DPathSection_Axis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        NEG_X = 3,
        NEG_Y = 4,
        NEG_Z = 5,
        MovieScene3DPathSection_MAX = 6,
    }
    public enum EFireEventsAtPosition : int
    {
        AtStartOfEvaluation = 0,
        AtEndOfEvaluation = 1,
        AfterSpawn = 2,
        EFireEventsAtPosition_MAX = 3,
    }
    public enum ELevelVisibility : int
    {
        Visible = 0,
        Hidden = 1,
        ELevelVisibility_MAX = 2,
    }
    public enum EParticleKey : int
    {
        Activate = 0,
        Deactivate = 1,
        Trigger = 2,
        EParticleKey_MAX = 3,
    }
    public class MovieScene3DPathSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieScene3DPathSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneObjectBindingID PathBindingID { get { return this[nameof(PathBindingID)].As<MovieSceneObjectBindingID>(); } set { this["PathBindingID"] = value; } }
        public MovieSceneFloatChannel TimingCurve { get { return this[nameof(TimingCurve)].As<MovieSceneFloatChannel>(); } set { this["TimingCurve"] = value; } }
        public MovieScene3DPathSection_Axis FrontAxisEnum { get { return (MovieScene3DPathSection_Axis)this[nameof(FrontAxisEnum)].GetValue<int>(); } set { this[nameof(FrontAxisEnum)].SetValue<int>((int)value); } }
        public MovieScene3DPathSection_Axis UpAxisEnum { get { return (MovieScene3DPathSection_Axis)this[nameof(UpAxisEnum)].GetValue<int>(); } set { this[nameof(UpAxisEnum)].SetValue<int>((int)value); } }
        public bool bFollow { get { return this[nameof(bFollow)].Flag; } set { this[nameof(bFollow)].Flag = value; } }
        public bool bReverse { get { return this[nameof(bReverse)].Flag; } set { this[nameof(bReverse)].Flag = value; } }
        public bool bForceUpright { get { return this[nameof(bForceUpright)].Flag; } set { this[nameof(bForceUpright)].Flag = value; } }
    }
    public class MovieSceneTransformMask : Object
    {
        public MovieSceneTransformMask(ulong addr) : base(addr) { }
        public uint Mask { get { return this[nameof(Mask)].GetValue<uint>(); } set { this[nameof(Mask)].SetValue<uint>(value); } }
    }
    public class MovieScene3DTransformKeyStruct : MovieSceneKeyStruct
    {
        public MovieScene3DTransformKeyStruct(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieScene3DScaleKeyStruct : MovieSceneKeyStruct
    {
        public MovieScene3DScaleKeyStruct(ulong addr) : base(addr) { }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieScene3DRotationKeyStruct : MovieSceneKeyStruct
    {
        public MovieScene3DRotationKeyStruct(ulong addr) : base(addr) { }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieScene3DLocationKeyStruct : MovieSceneKeyStruct
    {
        public MovieScene3DLocationKeyStruct(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieScene3DTransformTemplateData : Object
    {
        public MovieScene3DTransformTemplateData(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel TranslationCurve { get { return this[nameof(TranslationCurve)].As<MovieSceneFloatChannel>(); } set { this["TranslationCurve"] = value; } }
        public MovieSceneFloatChannel RotationCurve { get { return this[nameof(RotationCurve)].As<MovieSceneFloatChannel>(); } set { this["RotationCurve"] = value; } }
        public MovieSceneFloatChannel ScaleCurve { get { return this[nameof(ScaleCurve)].As<MovieSceneFloatChannel>(); } set { this["ScaleCurve"] = value; } }
        public MovieSceneFloatChannel ManualWeight { get { return this[nameof(ManualWeight)].As<MovieSceneFloatChannel>(); } set { this["ManualWeight"] = value; } }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
        public MovieSceneTransformMask Mask { get { return this[nameof(Mask)].As<MovieSceneTransformMask>(); } set { this["Mask"] = value; } }
        public bool bUseQuaternionInterpolation { get { return this[nameof(bUseQuaternionInterpolation)].Flag; } set { this[nameof(bUseQuaternionInterpolation)].Flag = value; } }
    }
    public class MovieSceneActorReferenceData : MovieSceneChannel
    {
        public MovieSceneActorReferenceData(ulong addr) : base(addr) { }
        public Array<FrameNumber> KeyTimes { get { return new Array<FrameNumber>(this[nameof(KeyTimes)].Address); } }
        public Array<MovieSceneActorReferenceKey> KeyValues { get { return new Array<MovieSceneActorReferenceKey>(this[nameof(KeyValues)].Address); } }
    }
    public class MovieSceneActorReferenceKey : Object
    {
        public MovieSceneActorReferenceKey(ulong addr) : base(addr) { }
        public MovieSceneObjectBindingID Object { get { return this[nameof(Object)].As<MovieSceneObjectBindingID>(); } set { this["Object"] = value; } }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class MovieSceneActorReferenceSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneActorReferenceSectionTemplate(ulong addr) : base(addr) { }
        public MovieScenePropertySectionData PropertyData { get { return this[nameof(PropertyData)].As<MovieScenePropertySectionData>(); } set { this["PropertyData"] = value; } }
        public MovieSceneActorReferenceData ActorReferenceData { get { return this[nameof(ActorReferenceData)].As<MovieSceneActorReferenceData>(); } set { this["ActorReferenceData"] = value; } }
    }
    public class MovieSceneAudioSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneAudioSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneAudioSection AudioSection { get { return this[nameof(AudioSection)].As<MovieSceneAudioSection>(); } set { this["AudioSection"] = value; } }
    }
    public class MovieSceneCameraAnimSectionData : Object
    {
        public MovieSceneCameraAnimSectionData(ulong addr) : base(addr) { }
        public CameraAnim CameraAnim { get { return this[nameof(CameraAnim)].As<CameraAnim>(); } set { this["CameraAnim"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public float PlayScale { get { return this[nameof(PlayScale)].GetValue<float>(); } set { this[nameof(PlayScale)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
        public bool bLooping { get { return this[nameof(bLooping)].Flag; } set { this[nameof(bLooping)].Flag = value; } }
    }
    public class MovieSceneAdditiveCameraAnimationTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneAdditiveCameraAnimationTemplate(ulong addr) : base(addr) { }
    }
    public class MovieSceneCameraShakeSectionTemplate : MovieSceneAdditiveCameraAnimationTemplate
    {
        public MovieSceneCameraShakeSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneCameraShakeSectionData SourceData { get { return this[nameof(SourceData)].As<MovieSceneCameraShakeSectionData>(); } set { this["SourceData"] = value; } }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
    }
    public class MovieSceneCameraShakeSectionData : Object
    {
        public MovieSceneCameraShakeSectionData(ulong addr) : base(addr) { }
        public Object ShakeClass { get { return this[nameof(ShakeClass)]; } set { this[nameof(ShakeClass)] = value; } }
        public float PlayScale { get { return this[nameof(PlayScale)].GetValue<float>(); } set { this[nameof(PlayScale)].SetValue<float>(value); } }
        public ECameraShakePlaySpace PlaySpace { get { return (ECameraShakePlaySpace)this[nameof(PlaySpace)].GetValue<int>(); } set { this[nameof(PlaySpace)].SetValue<int>((int)value); } }
        public Rotator UserDefinedPlaySpace { get { return this[nameof(UserDefinedPlaySpace)].As<Rotator>(); } set { this["UserDefinedPlaySpace"] = value; } }
    }
    public class MovieSceneCameraAnimSectionTemplate : MovieSceneAdditiveCameraAnimationTemplate
    {
        public MovieSceneCameraAnimSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneCameraAnimSectionData SourceData { get { return this[nameof(SourceData)].As<MovieSceneCameraAnimSectionData>(); } set { this["SourceData"] = value; } }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
    }
    public class MovieSceneCameraShakeSourceShakeSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneCameraShakeSourceShakeSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneCameraShakeSectionData SourceData { get { return this[nameof(SourceData)].As<MovieSceneCameraShakeSectionData>(); } set { this["SourceData"] = value; } }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
        public FrameNumber SectionEndTime { get { return this[nameof(SectionEndTime)].As<FrameNumber>(); } set { this["SectionEndTime"] = value; } }
    }
    public class MovieSceneCameraShakeSourceTriggerChannel : MovieSceneChannel
    {
        public MovieSceneCameraShakeSourceTriggerChannel(ulong addr) : base(addr) { }
        public Array<FrameNumber> KeyTimes { get { return new Array<FrameNumber>(this[nameof(KeyTimes)].Address); } }
        public Array<MovieSceneCameraShakeSourceTrigger> KeyValues { get { return new Array<MovieSceneCameraShakeSourceTrigger>(this[nameof(KeyValues)].Address); } }
    }
    public class MovieSceneCameraShakeSourceTrigger : Object
    {
        public MovieSceneCameraShakeSourceTrigger(ulong addr) : base(addr) { }
        public Object ShakeClass { get { return this[nameof(ShakeClass)]; } set { this[nameof(ShakeClass)] = value; } }
        public float PlayScale { get { return this[nameof(PlayScale)].GetValue<float>(); } set { this[nameof(PlayScale)].SetValue<float>(value); } }
        public ECameraShakePlaySpace PlaySpace { get { return (ECameraShakePlaySpace)this[nameof(PlaySpace)].GetValue<int>(); } set { this[nameof(PlaySpace)].SetValue<int>((int)value); } }
        public Rotator UserDefinedPlaySpace { get { return this[nameof(UserDefinedPlaySpace)].As<Rotator>(); } set { this["UserDefinedPlaySpace"] = value; } }
    }
    public class MovieSceneCameraShakeSourceTriggerSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneCameraShakeSourceTriggerSectionTemplate(ulong addr) : base(addr) { }
        public Array<FrameNumber> TriggerTimes { get { return new Array<FrameNumber>(this[nameof(TriggerTimes)].Address); } }
        public Array<MovieSceneCameraShakeSourceTrigger> TriggerValues { get { return new Array<MovieSceneCameraShakeSourceTrigger>(this[nameof(TriggerValues)].Address); } }
    }
    public class MovieSceneColorKeyStruct : MovieSceneKeyStruct
    {
        public MovieSceneColorKeyStruct(ulong addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieSceneColorSectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneColorSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel Curves { get { return this[nameof(Curves)].As<MovieSceneFloatChannel>(); } set { this["Curves"] = value; } }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
    }
    public class MovieSceneEvent : Object
    {
        public MovieSceneEvent(ulong addr) : base(addr) { }
        public MovieSceneEventPtrs Ptrs { get { return this[nameof(Ptrs)].As<MovieSceneEventPtrs>(); } set { this["Ptrs"] = value; } }
    }
    public class MovieSceneEventPtrs : Object
    {
        public MovieSceneEventPtrs(ulong addr) : base(addr) { }
        public Function Function { get { return this[nameof(Function)].As<Function>(); } set { this["Function"] = value; } }
        public Object BoundObjectProperty { get { return this[nameof(BoundObjectProperty)]; } set { this[nameof(BoundObjectProperty)] = value; } }
    }
    public class MovieSceneEventPayloadVariable : Object
    {
        public MovieSceneEventPayloadVariable(ulong addr) : base(addr) { }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class MovieSceneEventChannel : MovieSceneChannel
    {
        public MovieSceneEventChannel(ulong addr) : base(addr) { }
        public Array<FrameNumber> KeyTimes { get { return new Array<FrameNumber>(this[nameof(KeyTimes)].Address); } }
        public Array<MovieSceneEvent> KeyValues { get { return new Array<MovieSceneEvent>(this[nameof(KeyValues)].Address); } }
    }
    public class MovieSceneEventSectionData : MovieSceneChannel
    {
        public MovieSceneEventSectionData(ulong addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<EventPayload> KeyValues { get { return new Array<EventPayload>(this[nameof(KeyValues)].Address); } }
    }
    public class EventPayload : Object
    {
        public EventPayload(ulong addr) : base(addr) { }
        public Object EventName { get { return this[nameof(EventName)]; } set { this[nameof(EventName)] = value; } }
        public MovieSceneEventParameters Parameters { get { return this[nameof(Parameters)].As<MovieSceneEventParameters>(); } set { this["Parameters"] = value; } }
    }
    public class MovieSceneEventParameters : Object
    {
        public MovieSceneEventParameters(ulong addr) : base(addr) { }
    }
    public class MovieSceneEventTriggerData : Object
    {
        public MovieSceneEventTriggerData(ulong addr) : base(addr) { }
        public MovieSceneEventPtrs Ptrs { get { return this[nameof(Ptrs)].As<MovieSceneEventPtrs>(); } set { this["Ptrs"] = value; } }
        public Guid ObjectBindingId { get { return this[nameof(ObjectBindingId)].As<Guid>(); } set { this["ObjectBindingId"] = value; } }
    }
    public class MovieSceneEventSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneEventSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneEventSectionData EventData { get { return this[nameof(EventData)].As<MovieSceneEventSectionData>(); } set { this["EventData"] = value; } }
        public bool bFireEventsWhenForwards { get { return this[nameof(bFireEventsWhenForwards)].Flag; } set { this[nameof(bFireEventsWhenForwards)].Flag = value; } }
        public bool bFireEventsWhenBackwards { get { return this[nameof(bFireEventsWhenBackwards)].Flag; } set { this[nameof(bFireEventsWhenBackwards)].Flag = value; } }
    }
    public class MovieSceneFadeSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneFadeSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel FadeCurve { get { return this[nameof(FadeCurve)].As<MovieSceneFloatChannel>(); } set { this["FadeCurve"] = value; } }
        public LinearColor FadeColor { get { return this[nameof(FadeColor)].As<LinearColor>(); } set { this["FadeColor"] = value; } }
        public bool bFadeAudio { get { return this[nameof(bFadeAudio)].Flag; } set { this[nameof(bFadeAudio)].Flag = value; } }
    }
    public class MovieSceneParameterSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneParameterSectionTemplate(ulong addr) : base(addr) { }
        public Array<ScalarParameterNameAndCurve> Scalars { get { return new Array<ScalarParameterNameAndCurve>(this[nameof(Scalars)].Address); } }
        public Array<BoolParameterNameAndCurve> Bools { get { return new Array<BoolParameterNameAndCurve>(this[nameof(Bools)].Address); } }
        public Array<Vector2DParameterNameAndCurves> Vector2Ds { get { return new Array<Vector2DParameterNameAndCurves>(this[nameof(Vector2Ds)].Address); } }
        public Array<VectorParameterNameAndCurves> Vectors { get { return new Array<VectorParameterNameAndCurves>(this[nameof(Vectors)].Address); } }
        public Array<ColorParameterNameAndCurves> Colors { get { return new Array<ColorParameterNameAndCurves>(this[nameof(Colors)].Address); } }
        public Array<TransformParameterNameAndCurves> Transforms { get { return new Array<TransformParameterNameAndCurves>(this[nameof(Transforms)].Address); } }
    }
    public class TransformParameterNameAndCurves : Object
    {
        public TransformParameterNameAndCurves(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneFloatChannel Translation { get { return this[nameof(Translation)].As<MovieSceneFloatChannel>(); } set { this["Translation"] = value; } }
        public MovieSceneFloatChannel Rotation { get { return this[nameof(Rotation)].As<MovieSceneFloatChannel>(); } set { this["Rotation"] = value; } }
        public MovieSceneFloatChannel Scale { get { return this[nameof(Scale)].As<MovieSceneFloatChannel>(); } set { this["Scale"] = value; } }
    }
    public class ColorParameterNameAndCurves : Object
    {
        public ColorParameterNameAndCurves(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneFloatChannel RedCurve { get { return this[nameof(RedCurve)].As<MovieSceneFloatChannel>(); } set { this["RedCurve"] = value; } }
        public MovieSceneFloatChannel GreenCurve { get { return this[nameof(GreenCurve)].As<MovieSceneFloatChannel>(); } set { this["GreenCurve"] = value; } }
        public MovieSceneFloatChannel BlueCurve { get { return this[nameof(BlueCurve)].As<MovieSceneFloatChannel>(); } set { this["BlueCurve"] = value; } }
        public MovieSceneFloatChannel AlphaCurve { get { return this[nameof(AlphaCurve)].As<MovieSceneFloatChannel>(); } set { this["AlphaCurve"] = value; } }
    }
    public class VectorParameterNameAndCurves : Object
    {
        public VectorParameterNameAndCurves(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneFloatChannel XCurve { get { return this[nameof(XCurve)].As<MovieSceneFloatChannel>(); } set { this["XCurve"] = value; } }
        public MovieSceneFloatChannel YCurve { get { return this[nameof(YCurve)].As<MovieSceneFloatChannel>(); } set { this["YCurve"] = value; } }
        public MovieSceneFloatChannel ZCurve { get { return this[nameof(ZCurve)].As<MovieSceneFloatChannel>(); } set { this["ZCurve"] = value; } }
    }
    public class Vector2DParameterNameAndCurves : Object
    {
        public Vector2DParameterNameAndCurves(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneFloatChannel XCurve { get { return this[nameof(XCurve)].As<MovieSceneFloatChannel>(); } set { this["XCurve"] = value; } }
        public MovieSceneFloatChannel YCurve { get { return this[nameof(YCurve)].As<MovieSceneFloatChannel>(); } set { this["YCurve"] = value; } }
    }
    public class BoolParameterNameAndCurve : Object
    {
        public BoolParameterNameAndCurve(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneBoolChannel ParameterCurve { get { return this[nameof(ParameterCurve)].As<MovieSceneBoolChannel>(); } set { this["ParameterCurve"] = value; } }
    }
    public class ScalarParameterNameAndCurve : Object
    {
        public ScalarParameterNameAndCurve(ulong addr) : base(addr) { }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public MovieSceneFloatChannel ParameterCurve { get { return this[nameof(ParameterCurve)].As<MovieSceneFloatChannel>(); } set { this["ParameterCurve"] = value; } }
    }
    public class MovieSceneMaterialParameterCollectionTemplate : MovieSceneParameterSectionTemplate
    {
        public MovieSceneMaterialParameterCollectionTemplate(ulong addr) : base(addr) { }
        public MaterialParameterCollection MPC { get { return this[nameof(MPC)].As<MaterialParameterCollection>(); } set { this["MPC"] = value; } }
    }
    public class MovieSceneObjectPropertyTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneObjectPropertyTemplate(ulong addr) : base(addr) { }
        public MovieSceneObjectPathChannel ObjectChannel { get { return this[nameof(ObjectChannel)].As<MovieSceneObjectPathChannel>(); } set { this["ObjectChannel"] = value; } }
    }
    public class MovieSceneComponentMaterialSectionTemplate : MovieSceneParameterSectionTemplate
    {
        public MovieSceneComponentMaterialSectionTemplate(ulong addr) : base(addr) { }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
    }
    public class MovieSceneParticleParameterSectionTemplate : MovieSceneParameterSectionTemplate
    {
        public MovieSceneParticleParameterSectionTemplate(ulong addr) : base(addr) { }
    }
    public class MovieSceneParticleChannel : MovieSceneByteChannel
    {
        public MovieSceneParticleChannel(ulong addr) : base(addr) { }
    }
    public class MovieSceneParticleSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneParticleSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneParticleChannel ParticleKeys { get { return this[nameof(ParticleKeys)].As<MovieSceneParticleChannel>(); } set { this["ParticleKeys"] = value; } }
    }
    public class MovieScenePrimitiveMaterialTemplate : MovieSceneEvalTemplate
    {
        public MovieScenePrimitiveMaterialTemplate(ulong addr) : base(addr) { }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
        public MovieSceneObjectPathChannel MaterialChannel { get { return this[nameof(MaterialChannel)].As<MovieSceneObjectPathChannel>(); } set { this["MaterialChannel"] = value; } }
    }
    public class MovieSceneVectorPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneVectorPropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel ComponentCurves { get { return this[nameof(ComponentCurves)].As<MovieSceneFloatChannel>(); } set { this["ComponentCurves"] = value; } }
        public int NumChannelsUsed { get { return this[nameof(NumChannelsUsed)].GetValue<int>(); } set { this[nameof(NumChannelsUsed)].SetValue<int>(value); } }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
    }
    public class MovieSceneStringPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneStringPropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneStringChannel StringCurve { get { return this[nameof(StringCurve)].As<MovieSceneStringChannel>(); } set { this["StringCurve"] = value; } }
    }
    public class MovieSceneStringChannel : MovieSceneChannel
    {
        public MovieSceneStringChannel(ulong addr) : base(addr) { }
        public Array<FrameNumber> Times { get { return new Array<FrameNumber>(this[nameof(Times)].Address); } }
        public Array<Object> Values { get { return new Array<Object>(this[nameof(Values)].Address); } }
        public Object DefaultValue { get { return this[nameof(DefaultValue)]; } set { this[nameof(DefaultValue)] = value; } }
        public bool bHasDefaultValue { get { return this[nameof(bHasDefaultValue)].Flag; } set { this[nameof(bHasDefaultValue)].Flag = value; } }
    }
    public class MovieSceneIntegerPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneIntegerPropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneIntegerChannel IntegerCurve { get { return this[nameof(IntegerCurve)].As<MovieSceneIntegerChannel>(); } set { this["IntegerCurve"] = value; } }
        public EMovieSceneBlendType BlendType { get { return (EMovieSceneBlendType)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
    }
    public class MovieSceneEnumPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneEnumPropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneByteChannel EnumCurve { get { return this[nameof(EnumCurve)].As<MovieSceneByteChannel>(); } set { this["EnumCurve"] = value; } }
    }
    public class MovieSceneBytePropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneBytePropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneByteChannel ByteCurve { get { return this[nameof(ByteCurve)].As<MovieSceneByteChannel>(); } set { this["ByteCurve"] = value; } }
    }
    public class MovieSceneBoolPropertySectionTemplate : MovieScenePropertySectionTemplate
    {
        public MovieSceneBoolPropertySectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneBoolChannel BoolCurve { get { return this[nameof(BoolCurve)].As<MovieSceneBoolChannel>(); } set { this["BoolCurve"] = value; } }
    }
    public class MovieSceneSkeletalAnimationParams : Object
    {
        public MovieSceneSkeletalAnimationParams(ulong addr) : base(addr) { }
        public AnimSequenceBase Animation { get { return this[nameof(Animation)].As<AnimSequenceBase>(); } set { this["Animation"] = value; } }
        public FrameNumber FirstLoopStartFrameOffset { get { return this[nameof(FirstLoopStartFrameOffset)].As<FrameNumber>(); } set { this["FirstLoopStartFrameOffset"] = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public FrameNumber EndFrameOffset { get { return this[nameof(EndFrameOffset)].As<FrameNumber>(); } set { this["EndFrameOffset"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bReverse { get { return this[nameof(bReverse)].Flag; } set { this[nameof(bReverse)].Flag = value; } }
        public Object SlotName { get { return this[nameof(SlotName)]; } set { this[nameof(SlotName)] = value; } }
        public MovieSceneFloatChannel Weight { get { return this[nameof(Weight)].As<MovieSceneFloatChannel>(); } set { this["Weight"] = value; } }
        public bool bSkipAnimNotifiers { get { return this[nameof(bSkipAnimNotifiers)].Flag; } set { this[nameof(bSkipAnimNotifiers)].Flag = value; } }
        public bool bForceCustomMode { get { return this[nameof(bForceCustomMode)].Flag; } set { this[nameof(bForceCustomMode)].Flag = value; } }
        public float StartOffset { get { return this[nameof(StartOffset)].GetValue<float>(); } set { this[nameof(StartOffset)].SetValue<float>(value); } }
        public float EndOffset { get { return this[nameof(EndOffset)].GetValue<float>(); } set { this[nameof(EndOffset)].SetValue<float>(value); } }
    }
    public class MovieSceneSkeletalAnimationSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneSkeletalAnimationSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneSkeletalAnimationSectionTemplateParameters Params { get { return this[nameof(Params)].As<MovieSceneSkeletalAnimationSectionTemplateParameters>(); } set { this["Params"] = value; } }
    }
    public class MovieSceneSkeletalAnimationSectionTemplateParameters : MovieSceneSkeletalAnimationParams
    {
        public MovieSceneSkeletalAnimationSectionTemplateParameters(ulong addr) : base(addr) { }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
        public FrameNumber SectionEndTime { get { return this[nameof(SectionEndTime)].As<FrameNumber>(); } set { this["SectionEndTime"] = value; } }
    }
    public class MovieSceneSkeletalAnimRootMotionTrackParams : Object
    {
        public MovieSceneSkeletalAnimRootMotionTrackParams(ulong addr) : base(addr) { }
    }
    public class MovieSceneSlomoSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneSlomoSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel SlomoCurve { get { return this[nameof(SlomoCurve)].As<MovieSceneFloatChannel>(); } set { this["SlomoCurve"] = value; } }
    }
    public class LevelVisibilityComponentData : Object
    {
        public LevelVisibilityComponentData(ulong addr) : base(addr) { }
        public MovieSceneLevelVisibilitySection Section { get { return this[nameof(Section)].As<MovieSceneLevelVisibilitySection>(); } set { this["Section"] = value; } }
    }
    public class MovieSceneVectorKeyStructBase : MovieSceneKeyStruct
    {
        public MovieSceneVectorKeyStructBase(ulong addr) : base(addr) { }
        public FrameNumber Time { get { return this[nameof(Time)].As<FrameNumber>(); } set { this["Time"] = value; } }
    }
    public class MovieSceneVector4KeyStruct : MovieSceneVectorKeyStructBase
    {
        public MovieSceneVector4KeyStruct(ulong addr) : base(addr) { }
        public Vector4 Vector { get { return this[nameof(Vector)].As<Vector4>(); } set { this["Vector"] = value; } }
    }
    public class MovieSceneVectorKeyStruct : MovieSceneVectorKeyStructBase
    {
        public MovieSceneVectorKeyStruct(ulong addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class MovieSceneVector2DKeyStruct : MovieSceneVectorKeyStructBase
    {
        public MovieSceneVector2DKeyStruct(ulong addr) : base(addr) { }
        public Vector2D Vector { get { return this[nameof(Vector)].As<Vector2D>(); } set { this["Vector"] = value; } }
    }
    public class MovieSceneVisibilitySectionTemplate : MovieSceneBoolPropertySectionTemplate
    {
        public MovieSceneVisibilitySectionTemplate(ulong addr) : base(addr) { }
    }
}
