using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.NiagaraCoreSDK;
using SDK.Script.NiagaraShaderSDK;
namespace SDK.Script.NiagaraSDK
{
    public class MovieSceneNiagaraTrack : MovieSceneNameableTrack
    {
        public MovieSceneNiagaraTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> Sections { get { return new Array<MovieSceneSection>(this[nameof(Sections)].Address); } }
    }
    public class MovieSceneNiagaraParameterTrack : MovieSceneNiagaraTrack
    {
        public MovieSceneNiagaraParameterTrack(ulong addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class MovieSceneNiagaraBoolParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraBoolParameterTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraColorParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraColorParameterTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraFloatParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraFloatParameterTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraIntegerParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraIntegerParameterTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraSystemSpawnSection : MovieSceneSection
    {
        public MovieSceneNiagaraSystemSpawnSection(ulong addr) : base(addr) { }
        public ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior { get { return (ENiagaraSystemSpawnSectionStartBehavior)this[nameof(SectionStartBehavior)].GetValue<int>(); } set { this[nameof(SectionStartBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior { get { return (ENiagaraSystemSpawnSectionEvaluateBehavior)this[nameof(SectionEvaluateBehavior)].GetValue<int>(); } set { this[nameof(SectionEvaluateBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior { get { return (ENiagaraSystemSpawnSectionEndBehavior)this[nameof(SectionEndBehavior)].GetValue<int>(); } set { this[nameof(SectionEndBehavior)].SetValue<int>((int)value); } }
        public ENiagaraAgeUpdateMode AgeUpdateMode { get { return (ENiagaraAgeUpdateMode)this[nameof(AgeUpdateMode)].GetValue<int>(); } set { this[nameof(AgeUpdateMode)].SetValue<int>((int)value); } }
    }
    public class MovieSceneNiagaraSystemTrack : MovieSceneNiagaraTrack
    {
        public MovieSceneNiagaraSystemTrack(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraVectorParameterTrack : MovieSceneNiagaraParameterTrack
    {
        public MovieSceneNiagaraVectorParameterTrack(ulong addr) : base(addr) { }
        public int ChannelsUsed { get { return this[nameof(ChannelsUsed)].GetValue<int>(); } set { this[nameof(ChannelsUsed)].SetValue<int>(value); } }
    }
    public class NiagaraActor : Actor
    {
        public NiagaraActor(ulong addr) : base(addr) { }
        public NiagaraComponent NiagaraComponent { get { return this[nameof(NiagaraComponent)].As<NiagaraComponent>(); } set { this["NiagaraComponent"] = value; } }
        public bool bDestroyOnSystemFinish { get { return this[nameof(bDestroyOnSystemFinish)].Flag; } set { this[nameof(bDestroyOnSystemFinish)].Flag = value; } }
        public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish) { Invoke(nameof(SetDestroyOnSystemFinish), bShouldDestroyOnSystemFinish); }
        public void OnNiagaraSystemFinished(NiagaraComponent FinishedComponent) { Invoke(nameof(OnNiagaraSystemFinished), FinishedComponent); }
    }
    public class NiagaraComponent : FXSystemComponent
    {
        public NiagaraComponent(ulong addr) : base(addr) { }
        public NiagaraSystem Asset { get { return this[nameof(Asset)].As<NiagaraSystem>(); } set { this["Asset"] = value; } }
        public ENiagaraTickBehavior TickBehavior { get { return (ENiagaraTickBehavior)this[nameof(TickBehavior)].GetValue<int>(); } set { this[nameof(TickBehavior)].SetValue<int>((int)value); } }
        public NiagaraUserRedirectionParameterStore OverrideParameters { get { return this[nameof(OverrideParameters)].As<NiagaraUserRedirectionParameterStore>(); } set { this["OverrideParameters"] = value; } }
        public bool bForceSolo { get { return this[nameof(bForceSolo)].Flag; } set { this[nameof(bForceSolo)].Flag = value; } }
        public bool bEnableGpuComputeDebug { get { return this[nameof(bEnableGpuComputeDebug)].Flag; } set { this[nameof(bEnableGpuComputeDebug)].Flag = value; } }
        public bool bAutoDestroy { get { return this[nameof(bAutoDestroy)].Flag; } set { this[nameof(bAutoDestroy)].Flag = value; } }
        public bool bRenderingEnabled { get { return this[nameof(bRenderingEnabled)].Flag; } set { this[nameof(bRenderingEnabled)].Flag = value; } }
        public bool bAutoManageAttachment { get { return this[nameof(bAutoManageAttachment)].Flag; } set { this[nameof(bAutoManageAttachment)].Flag = value; } }
        public bool bAutoAttachWeldSimulatedBodies { get { return this[nameof(bAutoAttachWeldSimulatedBodies)].Flag; } set { this[nameof(bAutoAttachWeldSimulatedBodies)].Flag = value; } }
        public float MaxTimeBeforeForceUpdateTransform { get { return this[nameof(MaxTimeBeforeForceUpdateTransform)].GetValue<float>(); } set { this[nameof(MaxTimeBeforeForceUpdateTransform)].SetValue<float>(value); } }
        public Array<NiagaraMaterialOverride> EmitterMaterials { get { return new Array<NiagaraMaterialOverride>(this[nameof(EmitterMaterials)].Address); } }
        public Object OnSystemFinished { get { return this[nameof(OnSystemFinished)]; } set { this[nameof(OnSystemFinished)] = value; } }
        public Object AutoAttachParent { get { return this[nameof(AutoAttachParent)]; } set { this[nameof(AutoAttachParent)] = value; } }
        public Object AutoAttachSocketName { get { return this[nameof(AutoAttachSocketName)]; } set { this[nameof(AutoAttachSocketName)] = value; } }
        public EAttachmentRule AutoAttachLocationRule { get { return (EAttachmentRule)this[nameof(AutoAttachLocationRule)].GetValue<int>(); } set { this[nameof(AutoAttachLocationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AutoAttachRotationRule { get { return (EAttachmentRule)this[nameof(AutoAttachRotationRule)].GetValue<int>(); } set { this[nameof(AutoAttachRotationRule)].SetValue<int>((int)value); } }
        public EAttachmentRule AutoAttachScaleRule { get { return (EAttachmentRule)this[nameof(AutoAttachScaleRule)].GetValue<int>(); } set { this[nameof(AutoAttachScaleRule)].SetValue<int>((int)value); } }
        public void SetVariableVec4(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetVariableVec4), InVariableName, InValue); }
        public void SetVariableVec3(Object InVariableName, Vector InValue) { Invoke(nameof(SetVariableVec3), InVariableName, InValue); }
        public void SetVariableVec2(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetVariableVec2), InVariableName, InValue); }
        public void SetVariableTextureRenderTarget(Object InVariableName, TextureRenderTarget TextureRenderTarget) { Invoke(nameof(SetVariableTextureRenderTarget), InVariableName, TextureRenderTarget); }
        public void SetVariableQuat(Object InVariableName, Quat InValue) { Invoke(nameof(SetVariableQuat), InVariableName, InValue); }
        public void SetVariableObject(Object InVariableName, Object Object) { Invoke(nameof(SetVariableObject), InVariableName, Object); }
        public void SetVariableMaterial(Object InVariableName, MaterialInterface Object) { Invoke(nameof(SetVariableMaterial), InVariableName, Object); }
        public void SetVariableLinearColor(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetVariableLinearColor), InVariableName, InValue); }
        public void SetVariableInt(Object InVariableName, int InValue) { Invoke(nameof(SetVariableInt), InVariableName, InValue); }
        public void SetVariableFloat(Object InVariableName, float InValue) { Invoke(nameof(SetVariableFloat), InVariableName, InValue); }
        public void SetVariableBool(Object InVariableName, bool InValue) { Invoke(nameof(SetVariableBool), InVariableName, InValue); }
        public void SetVariableActor(Object InVariableName, Actor Actor) { Invoke(nameof(SetVariableActor), InVariableName, Actor); }
        public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior) { Invoke(nameof(SetTickBehavior), NewTickBehavior); }
        public void SetSeekDelta(float InSeekDelta) { Invoke(nameof(SetSeekDelta), InSeekDelta); }
        public void SetRenderingEnabled(bool bInRenderingEnabled) { Invoke(nameof(SetRenderingEnabled), bInRenderingEnabled); }
        public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance) { Invoke(nameof(SetPreviewLODDistance), bEnablePreviewLODDistance, PreviewLODDistance); }
        public void SetPaused(bool bInPaused) { Invoke(nameof(SetPaused), bInPaused); }
        public void SetNiagaraVariableVec4(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetNiagaraVariableVec4), InVariableName, InValue); }
        public void SetNiagaraVariableVec3(Object InVariableName, Vector InValue) { Invoke(nameof(SetNiagaraVariableVec3), InVariableName, InValue); }
        public void SetNiagaraVariableVec2(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetNiagaraVariableVec2), InVariableName, InValue); }
        public void SetNiagaraVariableQuat(Object InVariableName, Quat InValue) { Invoke(nameof(SetNiagaraVariableQuat), InVariableName, InValue); }
        public void SetNiagaraVariableObject(Object InVariableName, Object Object) { Invoke(nameof(SetNiagaraVariableObject), InVariableName, Object); }
        public void SetNiagaraVariableLinearColor(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetNiagaraVariableLinearColor), InVariableName, InValue); }
        public void SetNiagaraVariableInt(Object InVariableName, int InValue) { Invoke(nameof(SetNiagaraVariableInt), InVariableName, InValue); }
        public void SetNiagaraVariableFloat(Object InVariableName, float InValue) { Invoke(nameof(SetNiagaraVariableFloat), InVariableName, InValue); }
        public void SetNiagaraVariableBool(Object InVariableName, bool InValue) { Invoke(nameof(SetNiagaraVariableBool), InVariableName, InValue); }
        public void SetNiagaraVariableActor(Object InVariableName, Actor Actor) { Invoke(nameof(SetNiagaraVariableActor), InVariableName, Actor); }
        public void SetMaxSimTime(float InMaxTime) { Invoke(nameof(SetMaxSimTime), InMaxTime); }
        public void SetGpuComputeDebug(bool bEnableDebug) { Invoke(nameof(SetGpuComputeDebug), bEnableDebug); }
        public void SetForceSolo(bool bInForceSolo) { Invoke(nameof(SetForceSolo), bInForceSolo); }
        public void SetDesiredAge(float InDesiredAge) { Invoke(nameof(SetDesiredAge), InDesiredAge); }
        public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking) { Invoke(nameof(SetCanRenderWhileSeeking), bInCanRenderWhileSeeking); }
        public void SetAutoDestroy(bool bInAutoDestroy) { Invoke(nameof(SetAutoDestroy), bInAutoDestroy); }
        public void SetAsset(NiagaraSystem InAsset) { Invoke(nameof(SetAsset), InAsset); }
        public void SetAllowScalability(bool bAllow) { Invoke(nameof(SetAllowScalability), bAllow); }
        public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode) { Invoke(nameof(SetAgeUpdateMode), InAgeUpdateMode); }
        public void SeekToDesiredAge(float InDesiredAge) { Invoke(nameof(SeekToDesiredAge), InDesiredAge); }
        public void ResetSystem() { Invoke(nameof(ResetSystem)); }
        public void ReinitializeSystem() { Invoke(nameof(ReinitializeSystem)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
        public ENiagaraTickBehavior GetTickBehavior() { return Invoke<ENiagaraTickBehavior>(nameof(GetTickBehavior)); }
        public float GetSeekDelta() { return Invoke<float>(nameof(GetSeekDelta)); }
        public bool GetPreviewLODDistanceEnabled() { return Invoke<bool>(nameof(GetPreviewLODDistanceEnabled)); }
        public int GetPreviewLODDistance() { return Invoke<int>(nameof(GetPreviewLODDistance)); }
        public Array<Vector> GetNiagaraParticleValueVec3_DebugOnly(Object InEmitterName, Object InValueName) { return Invoke<Array<Vector>>(nameof(GetNiagaraParticleValueVec3_DebugOnly), InEmitterName, InValueName); }
        public Array<float> GetNiagaraParticleValues_DebugOnly(Object InEmitterName, Object InValueName) { return Invoke<Array<float>>(nameof(GetNiagaraParticleValues_DebugOnly), InEmitterName, InValueName); }
        public Array<Vector> GetNiagaraParticlePositions_DebugOnly(Object InEmitterName) { return Invoke<Array<Vector>>(nameof(GetNiagaraParticlePositions_DebugOnly), InEmitterName); }
        public float GetMaxSimTime() { return Invoke<float>(nameof(GetMaxSimTime)); }
        public bool GetForceSolo() { return Invoke<bool>(nameof(GetForceSolo)); }
        public float GetDesiredAge() { return Invoke<float>(nameof(GetDesiredAge)); }
        public NiagaraDataInterface GetDataInterface(Object Name) { return Invoke<NiagaraDataInterface>(nameof(GetDataInterface), Name); }
        public NiagaraSystem GetAsset() { return Invoke<NiagaraSystem>(nameof(GetAsset)); }
        public ENiagaraAgeUpdateMode GetAgeUpdateMode() { return Invoke<ENiagaraAgeUpdateMode>(nameof(GetAgeUpdateMode)); }
        public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds) { Invoke(nameof(AdvanceSimulationByTime), SimulateTime, TickDeltaSeconds); }
        public void AdvanceSimulation(int TickCount, float TickDeltaSeconds) { Invoke(nameof(AdvanceSimulation), TickCount, TickDeltaSeconds); }
    }
    public class NiagaraComponentPool : Object
    {
        public NiagaraComponentPool(ulong addr) : base(addr) { }
        public Object WorldParticleSystemPools { get { return this[nameof(WorldParticleSystemPools)]; } set { this[nameof(WorldParticleSystemPools)] = value; } }
    }
    public class NiagaraRendererProperties : NiagaraMergeable
    {
        public NiagaraRendererProperties(ulong addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public int SortOrderHint { get { return this[nameof(SortOrderHint)].GetValue<int>(); } set { this[nameof(SortOrderHint)].SetValue<int>(value); } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public bool bMotionBlurEnabled { get { return this[nameof(bMotionBlurEnabled)].Flag; } set { this[nameof(bMotionBlurEnabled)].Flag = value; } }
    }
    public class NiagaraComponentRendererProperties : NiagaraRendererProperties
    {
        public NiagaraComponentRendererProperties(ulong addr) : base(addr) { }
        public Object ComponentType { get { return this[nameof(ComponentType)]; } set { this[nameof(ComponentType)] = value; } }
        public uint ComponentCountLimit { get { return this[nameof(ComponentCountLimit)].GetValue<uint>(); } set { this[nameof(ComponentCountLimit)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding EnabledBinding { get { return this[nameof(EnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["EnabledBinding"] = value; } }
        public bool bAssignComponentsOnParticleID { get { return this[nameof(bAssignComponentsOnParticleID)].Flag; } set { this[nameof(bAssignComponentsOnParticleID)].Flag = value; } }
        public bool bOnlyCreateComponentsOnParticleSpawn { get { return this[nameof(bOnlyCreateComponentsOnParticleSpawn)].Flag; } set { this[nameof(bOnlyCreateComponentsOnParticleSpawn)].Flag = value; } }
        public SceneComponent TemplateComponent { get { return this[nameof(TemplateComponent)].As<SceneComponent>(); } set { this["TemplateComponent"] = value; } }
        public Array<NiagaraComponentPropertyBinding> PropertyBindings { get { return new Array<NiagaraComponentPropertyBinding>(this[nameof(PropertyBindings)].Address); } }
    }
    public class NiagaraComponentSettings : Object
    {
        public NiagaraComponentSettings(ulong addr) : base(addr) { }
        public Object SuppressActivationList { get { return this[nameof(SuppressActivationList)]; } set { this[nameof(SuppressActivationList)] = value; } }
        public Object ForceAutoPooolingList { get { return this[nameof(ForceAutoPooolingList)]; } set { this[nameof(ForceAutoPooolingList)] = value; } }
        public Object SuppressEmitterList { get { return this[nameof(SuppressEmitterList)]; } set { this[nameof(SuppressEmitterList)] = value; } }
    }
    public class NiagaraConvertInPlaceUtilityBase : Object
    {
        public NiagaraConvertInPlaceUtilityBase(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterface : NiagaraDataInterfaceBase
    {
        public NiagaraDataInterface(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterface2DArrayTexture : NiagaraDataInterface
    {
        public NiagaraDataInterface2DArrayTexture(ulong addr) : base(addr) { }
        public Texture2DArray Texture { get { return this[nameof(Texture)].As<Texture2DArray>(); } set { this["Texture"] = value; } }
    }
    public class NiagaraDataInterfaceArray : NiagaraDataInterface
    {
        public NiagaraDataInterfaceArray(ulong addr) : base(addr) { }
        public int MaxElements { get { return this[nameof(MaxElements)].GetValue<int>(); } set { this[nameof(MaxElements)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceArrayFloat : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat(ulong addr) : base(addr) { }
        public Array<float> FloatData { get { return new Array<float>(this[nameof(FloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat2 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat2(ulong addr) : base(addr) { }
        public Array<Vector2D> FloatData { get { return new Array<Vector2D>(this[nameof(FloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat3 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat3(ulong addr) : base(addr) { }
        public Array<Vector> FloatData { get { return new Array<Vector>(this[nameof(FloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFloat4 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayFloat4(ulong addr) : base(addr) { }
        public Array<Vector4> FloatData { get { return new Array<Vector4>(this[nameof(FloatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayColor : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayColor(ulong addr) : base(addr) { }
        public Array<LinearColor> ColorData { get { return new Array<LinearColor>(this[nameof(ColorData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayQuat : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayQuat(ulong addr) : base(addr) { }
        public Array<Quat> QuatData { get { return new Array<Quat>(this[nameof(QuatData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraDataInterfaceArrayFunctionLibrary(ulong addr) : base(addr) { }
        public void SetNiagaraArrayVector4(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector4> ArrayData) { Invoke(nameof(SetNiagaraArrayVector4), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayVector2D(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector2D> ArrayData) { Invoke(nameof(SetNiagaraArrayVector2D), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayVector(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Vector> ArrayData) { Invoke(nameof(SetNiagaraArrayVector), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayQuat(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Quat> ArrayData) { Invoke(nameof(SetNiagaraArrayQuat), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayInt32(NiagaraComponent NiagaraSystem, Object OverrideName, Array<int> ArrayData) { Invoke(nameof(SetNiagaraArrayInt32), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayFloat(NiagaraComponent NiagaraSystem, Object OverrideName, Array<float> ArrayData) { Invoke(nameof(SetNiagaraArrayFloat), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayColor(NiagaraComponent NiagaraSystem, Object OverrideName, Array<LinearColor> ArrayData) { Invoke(nameof(SetNiagaraArrayColor), NiagaraSystem, OverrideName, ArrayData); }
        public void SetNiagaraArrayBool(NiagaraComponent NiagaraSystem, Object OverrideName, Array<bool> ArrayData) { Invoke(nameof(SetNiagaraArrayBool), NiagaraSystem, OverrideName, ArrayData); }
        public Array<Vector4> GetNiagaraArrayVector4(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector4>>(nameof(GetNiagaraArrayVector4), NiagaraSystem, OverrideName); }
        public Array<Vector2D> GetNiagaraArrayVector2D(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector2D>>(nameof(GetNiagaraArrayVector2D), NiagaraSystem, OverrideName); }
        public Array<Vector> GetNiagaraArrayVector(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Vector>>(nameof(GetNiagaraArrayVector), NiagaraSystem, OverrideName); }
        public Array<Quat> GetNiagaraArrayQuat(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<Quat>>(nameof(GetNiagaraArrayQuat), NiagaraSystem, OverrideName); }
        public Array<int> GetNiagaraArrayInt32(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<int>>(nameof(GetNiagaraArrayInt32), NiagaraSystem, OverrideName); }
        public Array<float> GetNiagaraArrayFloat(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<float>>(nameof(GetNiagaraArrayFloat), NiagaraSystem, OverrideName); }
        public Array<LinearColor> GetNiagaraArrayColor(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<LinearColor>>(nameof(GetNiagaraArrayColor), NiagaraSystem, OverrideName); }
        public Array<bool> GetNiagaraArrayBool(NiagaraComponent NiagaraSystem, Object OverrideName) { return Invoke<Array<bool>>(nameof(GetNiagaraArrayBool), NiagaraSystem, OverrideName); }
    }
    public class NiagaraDataInterfaceArrayInt32 : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayInt32(ulong addr) : base(addr) { }
        public Array<int> IntData { get { return new Array<int>(this[nameof(IntData)].Address); } }
    }
    public class NiagaraDataInterfaceArrayBool : NiagaraDataInterfaceArray
    {
        public NiagaraDataInterfaceArrayBool(ulong addr) : base(addr) { }
        public Array<bool> BoolData { get { return new Array<bool>(this[nameof(BoolData)].Address); } }
    }
    public class NiagaraDataInterfaceAudioSubmix : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioSubmix(ulong addr) : base(addr) { }
        public SoundSubmix Submix { get { return this[nameof(Submix)].As<SoundSubmix>(); } set { this["Submix"] = value; } }
    }
    public class NiagaraDataInterfaceAudioOscilloscope : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioOscilloscope(ulong addr) : base(addr) { }
        public SoundSubmix Submix { get { return this[nameof(Submix)].As<SoundSubmix>(); } set { this["Submix"] = value; } }
        public int Resolution { get { return this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>(value); } }
        public float ScopeInMilliseconds { get { return this[nameof(ScopeInMilliseconds)].GetValue<float>(); } set { this[nameof(ScopeInMilliseconds)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceAudioPlayer : NiagaraDataInterface
    {
        public NiagaraDataInterfaceAudioPlayer(ulong addr) : base(addr) { }
        public SoundBase SoundToPlay { get { return this[nameof(SoundToPlay)].As<SoundBase>(); } set { this["SoundToPlay"] = value; } }
        public SoundAttenuation Attenuation { get { return this[nameof(Attenuation)].As<SoundAttenuation>(); } set { this["Attenuation"] = value; } }
        public SoundConcurrency Concurrency { get { return this[nameof(Concurrency)].As<SoundConcurrency>(); } set { this["Concurrency"] = value; } }
        public Array<Object> ParameterNames { get { return new Array<Object>(this[nameof(ParameterNames)].Address); } }
        public bool bLimitPlaysPerTick { get { return this[nameof(bLimitPlaysPerTick)].Flag; } set { this[nameof(bLimitPlaysPerTick)].Flag = value; } }
        public int MaxPlaysPerTick { get { return this[nameof(MaxPlaysPerTick)].GetValue<int>(); } set { this[nameof(MaxPlaysPerTick)].SetValue<int>(value); } }
        public bool bStopWhenComponentIsDestroyed { get { return this[nameof(bStopWhenComponentIsDestroyed)].Flag; } set { this[nameof(bStopWhenComponentIsDestroyed)].Flag = value; } }
    }
    public class NiagaraDataInterfaceAudioSpectrum : NiagaraDataInterfaceAudioSubmix
    {
        public NiagaraDataInterfaceAudioSpectrum(ulong addr) : base(addr) { }
        public int Resolution { get { return this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>(value); } }
        public float MinimumFrequency { get { return this[nameof(MinimumFrequency)].GetValue<float>(); } set { this[nameof(MinimumFrequency)].SetValue<float>(value); } }
        public float MaximumFrequency { get { return this[nameof(MaximumFrequency)].GetValue<float>(); } set { this[nameof(MaximumFrequency)].SetValue<float>(value); } }
        public float NoiseFloorDb { get { return this[nameof(NoiseFloorDb)].GetValue<float>(); } set { this[nameof(NoiseFloorDb)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceCamera : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCamera(ulong addr) : base(addr) { }
        public int PlayerControllerIndex { get { return this[nameof(PlayerControllerIndex)].GetValue<int>(); } set { this[nameof(PlayerControllerIndex)].SetValue<int>(value); } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
    }
    public class NiagaraDataInterfaceCollisionQuery : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCollisionQuery(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceCurveBase : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCurveBase(ulong addr) : base(addr) { }
        public Array<float> ShaderLUT { get { return new Array<float>(this[nameof(ShaderLUT)].Address); } }
        public float LUTMinTime { get { return this[nameof(LUTMinTime)].GetValue<float>(); } set { this[nameof(LUTMinTime)].SetValue<float>(value); } }
        public float LUTMaxTime { get { return this[nameof(LUTMaxTime)].GetValue<float>(); } set { this[nameof(LUTMaxTime)].SetValue<float>(value); } }
        public float LUTInvTimeRange { get { return this[nameof(LUTInvTimeRange)].GetValue<float>(); } set { this[nameof(LUTInvTimeRange)].SetValue<float>(value); } }
        public float LUTNumSamplesMinusOne { get { return this[nameof(LUTNumSamplesMinusOne)].GetValue<float>(); } set { this[nameof(LUTNumSamplesMinusOne)].SetValue<float>(value); } }
        public bool bUseLUT { get { return this[nameof(bUseLUT)].Flag; } set { this[nameof(bUseLUT)].Flag = value; } }
        public bool bExposeCurve { get { return this[nameof(bExposeCurve)].Flag; } set { this[nameof(bExposeCurve)].Flag = value; } }
        public Object ExposedName { get { return this[nameof(ExposedName)]; } set { this[nameof(ExposedName)] = value; } }
        public Texture2D ExposedTexture { get { return this[nameof(ExposedTexture)].As<Texture2D>(); } set { this["ExposedTexture"] = value; } }
    }
    public class NiagaraDataInterfaceColorCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceColorCurve(ulong addr) : base(addr) { }
        public RichCurve RedCurve { get { return this[nameof(RedCurve)].As<RichCurve>(); } set { this["RedCurve"] = value; } }
        public RichCurve GreenCurve { get { return this[nameof(GreenCurve)].As<RichCurve>(); } set { this["GreenCurve"] = value; } }
        public RichCurve BlueCurve { get { return this[nameof(BlueCurve)].As<RichCurve>(); } set { this["BlueCurve"] = value; } }
        public RichCurve AlphaCurve { get { return this[nameof(AlphaCurve)].As<RichCurve>(); } set { this["AlphaCurve"] = value; } }
    }
    public class NiagaraDataInterfaceCurlNoise : NiagaraDataInterface
    {
        public NiagaraDataInterfaceCurlNoise(ulong addr) : base(addr) { }
        public uint Seed { get { return this[nameof(Seed)].GetValue<uint>(); } set { this[nameof(Seed)].SetValue<uint>(value); } }
    }
    public class NiagaraDataInterfaceCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceCurve(ulong addr) : base(addr) { }
        public RichCurve Curve { get { return this[nameof(Curve)].As<RichCurve>(); } set { this["Curve"] = value; } }
    }
    public class NiagaraParticleCallbackHandler : Interface
    {
        public NiagaraParticleCallbackHandler(ulong addr) : base(addr) { }
        public void ReceiveParticleData(Array<BasicParticleData> Data, NiagaraSystem NiagaraSystem) { Invoke(nameof(ReceiveParticleData), Data, NiagaraSystem); }
    }
    public class NiagaraDataInterfaceExport : NiagaraDataInterface
    {
        public NiagaraDataInterfaceExport(ulong addr) : base(addr) { }
        public NiagaraUserParameterBinding CallbackHandlerParameter { get { return this[nameof(CallbackHandlerParameter)].As<NiagaraUserParameterBinding>(); } set { this["CallbackHandlerParameter"] = value; } }
        public ENDIExport_GPUAllocationMode GPUAllocationMode { get { return (ENDIExport_GPUAllocationMode)this[nameof(GPUAllocationMode)].GetValue<int>(); } set { this[nameof(GPUAllocationMode)].SetValue<int>((int)value); } }
        public int GPUAllocationFixedSize { get { return this[nameof(GPUAllocationFixedSize)].GetValue<int>(); } set { this[nameof(GPUAllocationFixedSize)].SetValue<int>(value); } }
        public float GPUAllocationPerParticleSize { get { return this[nameof(GPUAllocationPerParticleSize)].GetValue<float>(); } set { this[nameof(GPUAllocationPerParticleSize)].SetValue<float>(value); } }
    }
    public class NiagaraDataInterfaceGBuffer : NiagaraDataInterface
    {
        public NiagaraDataInterfaceGBuffer(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceRWBase : NiagaraDataInterface
    {
        public NiagaraDataInterfaceRWBase(ulong addr) : base(addr) { }
        public Object OutputShaderStages { get { return this[nameof(OutputShaderStages)]; } set { this[nameof(OutputShaderStages)] = value; } }
        public Object IterationShaderStages { get { return this[nameof(IterationShaderStages)]; } set { this[nameof(IterationShaderStages)] = value; } }
    }
    public class NiagaraDataInterfaceGrid2D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceGrid2D(ulong addr) : base(addr) { }
        public int NumCellsX { get { return this[nameof(NumCellsX)].GetValue<int>(); } set { this[nameof(NumCellsX)].SetValue<int>(value); } }
        public int NumCellsY { get { return this[nameof(NumCellsY)].GetValue<int>(); } set { this[nameof(NumCellsY)].SetValue<int>(value); } }
        public int NumCellsMaxAxis { get { return this[nameof(NumCellsMaxAxis)].GetValue<int>(); } set { this[nameof(NumCellsMaxAxis)].SetValue<int>(value); } }
        public int NumAttributes { get { return this[nameof(NumAttributes)].GetValue<int>(); } set { this[nameof(NumAttributes)].SetValue<int>(value); } }
        public bool SetGridFromMaxAxis { get { return this[nameof(SetGridFromMaxAxis)].Flag; } set { this[nameof(SetGridFromMaxAxis)].Flag = value; } }
        public Vector2D WorldBBoxSize { get { return this[nameof(WorldBBoxSize)].As<Vector2D>(); } set { this["WorldBBoxSize"] = value; } }
    }
    public class NiagaraDataInterfaceGrid2DCollection : NiagaraDataInterfaceGrid2D
    {
        public NiagaraDataInterfaceGrid2DCollection(ulong addr) : base(addr) { }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public ENiagaraGpuBufferFormat OverrideBufferFormat { get { return (ENiagaraGpuBufferFormat)this[nameof(OverrideBufferFormat)].GetValue<int>(); } set { this[nameof(OverrideBufferFormat)].SetValue<int>((int)value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
        public void GetTextureSize(NiagaraComponent Component, int SizeX, int SizeY) { Invoke(nameof(GetTextureSize), Component, SizeX, SizeY); }
        public void GetRawTextureSize(NiagaraComponent Component, int SizeX, int SizeY) { Invoke(nameof(GetRawTextureSize), Component, SizeX, SizeY); }
        public bool FillTexture2D(NiagaraComponent Component, TextureRenderTarget2D Dest, int AttributeIndex) { return Invoke<bool>(nameof(FillTexture2D), Component, Dest, AttributeIndex); }
        public bool FillRawTexture2D(NiagaraComponent Component, TextureRenderTarget2D Dest, int TilesX, int TilesY) { return Invoke<bool>(nameof(FillRawTexture2D), Component, Dest, TilesX, TilesY); }
    }
    public class NiagaraDataInterfaceGrid2DCollectionReader : NiagaraDataInterfaceGrid2D
    {
        public NiagaraDataInterfaceGrid2DCollectionReader(ulong addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
        public Object DIName { get { return this[nameof(DIName)]; } set { this[nameof(DIName)] = value; } }
    }
    public class NiagaraDataInterfaceGrid3D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceGrid3D(ulong addr) : base(addr) { }
        public IntVector NumCells { get { return this[nameof(NumCells)].As<IntVector>(); } set { this["NumCells"] = value; } }
        public float CellSize { get { return this[nameof(CellSize)].GetValue<float>(); } set { this[nameof(CellSize)].SetValue<float>(value); } }
        public int NumCellsMaxAxis { get { return this[nameof(NumCellsMaxAxis)].GetValue<int>(); } set { this[nameof(NumCellsMaxAxis)].SetValue<int>(value); } }
        public ESetResolutionMethod SetResolutionMethod { get { return (ESetResolutionMethod)this[nameof(SetResolutionMethod)].GetValue<int>(); } set { this[nameof(SetResolutionMethod)].SetValue<int>((int)value); } }
        public Vector WorldBBoxSize { get { return this[nameof(WorldBBoxSize)].As<Vector>(); } set { this["WorldBBoxSize"] = value; } }
    }
    public class NiagaraDataInterfaceGrid3DCollection : NiagaraDataInterfaceGrid3D
    {
        public NiagaraDataInterfaceGrid3DCollection(ulong addr) : base(addr) { }
        public int NumAttributes { get { return this[nameof(NumAttributes)].GetValue<int>(); } set { this[nameof(NumAttributes)].SetValue<int>(value); } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public ENiagaraGpuBufferFormat BufferFormat { get { return (ENiagaraGpuBufferFormat)this[nameof(BufferFormat)].GetValue<int>(); } set { this[nameof(BufferFormat)].SetValue<int>((int)value); } }
        public void GetTextureSize(NiagaraComponent Component, int SizeX, int SizeY, int SizeZ) { Invoke(nameof(GetTextureSize), Component, SizeX, SizeY, SizeZ); }
        public void GetRawTextureSize(NiagaraComponent Component, int SizeX, int SizeY, int SizeZ) { Invoke(nameof(GetRawTextureSize), Component, SizeX, SizeY, SizeZ); }
        public bool FillVolumeTexture(NiagaraComponent Component, VolumeTexture Dest, int AttributeIndex) { return Invoke<bool>(nameof(FillVolumeTexture), Component, Dest, AttributeIndex); }
        public bool FillRawVolumeTexture(NiagaraComponent Component, VolumeTexture Dest, int TilesX, int TilesY, int TileZ) { return Invoke<bool>(nameof(FillRawVolumeTexture), Component, Dest, TilesX, TilesY, TileZ); }
    }
    public class NiagaraDataInterfaceLandscape : NiagaraDataInterface
    {
        public NiagaraDataInterfaceLandscape(ulong addr) : base(addr) { }
        public Actor SourceLandscape { get { return this[nameof(SourceLandscape)].As<Actor>(); } set { this["SourceLandscape"] = value; } }
    }
    public class NiagaraDataInterfaceNeighborGrid3D : NiagaraDataInterfaceGrid3D
    {
        public NiagaraDataInterfaceNeighborGrid3D(ulong addr) : base(addr) { }
        public uint MaxNeighborsPerCell { get { return this[nameof(MaxNeighborsPerCell)].GetValue<uint>(); } set { this[nameof(MaxNeighborsPerCell)].SetValue<uint>(value); } }
    }
    public class NiagaraDataInterfaceOcclusion : NiagaraDataInterface
    {
        public NiagaraDataInterfaceOcclusion(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceParticleRead : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceParticleRead(ulong addr) : base(addr) { }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
    }
    public class NiagaraDataInterfacePlatformSet : NiagaraDataInterface
    {
        public NiagaraDataInterfacePlatformSet(ulong addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
    }
    public class NiagaraDataInterfaceRenderTarget2D : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTarget2D(ulong addr) : base(addr) { }
        public IntPoint Size { get { return this[nameof(Size)].As<IntPoint>(); } set { this["Size"] = value; } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRenderTarget2DArray : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTarget2DArray(ulong addr) : base(addr) { }
        public IntVector Size { get { return this[nameof(Size)].As<IntVector>(); } set { this["Size"] = value; } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceRenderTargetVolume : NiagaraDataInterfaceRWBase
    {
        public NiagaraDataInterfaceRenderTargetVolume(ulong addr) : base(addr) { }
        public IntVector Size { get { return this[nameof(Size)].As<IntVector>(); } set { this["Size"] = value; } }
        public byte OverrideRenderTargetFormat { get { return this[nameof(OverrideRenderTargetFormat)].GetValue<byte>(); } set { this[nameof(OverrideRenderTargetFormat)].SetValue<byte>(value); } }
        public bool bOverrideFormat { get { return this[nameof(bOverrideFormat)].Flag; } set { this[nameof(bOverrideFormat)].Flag = value; } }
        public NiagaraUserParameterBinding RenderTargetUserParameter { get { return this[nameof(RenderTargetUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["RenderTargetUserParameter"] = value; } }
        public Object ManagedRenderTargets { get { return this[nameof(ManagedRenderTargets)]; } set { this[nameof(ManagedRenderTargets)] = value; } }
    }
    public class NiagaraDataInterfaceSimpleCounter : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSimpleCounter(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceSkeletalMesh : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSkeletalMesh(ulong addr) : base(addr) { }
        public ENDISkeletalMesh_SourceMode SourceMode { get { return (ENDISkeletalMesh_SourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public Actor Source { get { return this[nameof(Source)].As<Actor>(); } set { this["Source"] = value; } }
        public NiagaraUserParameterBinding MeshUserParameter { get { return this[nameof(MeshUserParameter)].As<NiagaraUserParameterBinding>(); } set { this["MeshUserParameter"] = value; } }
        public SkeletalMeshComponent SourceComponent { get { return this[nameof(SourceComponent)].As<SkeletalMeshComponent>(); } set { this["SourceComponent"] = value; } }
        public ENDISkeletalMesh_SkinningMode SkinningMode { get { return (ENDISkeletalMesh_SkinningMode)this[nameof(SkinningMode)].GetValue<int>(); } set { this[nameof(SkinningMode)].SetValue<int>((int)value); } }
        public Array<Object> SamplingRegions { get { return new Array<Object>(this[nameof(SamplingRegions)].Address); } }
        public int WholeMeshLOD { get { return this[nameof(WholeMeshLOD)].GetValue<int>(); } set { this[nameof(WholeMeshLOD)].SetValue<int>(value); } }
        public Array<Object> FilteredBones { get { return new Array<Object>(this[nameof(FilteredBones)].Address); } }
        public Array<Object> FilteredSockets { get { return new Array<Object>(this[nameof(FilteredSockets)].Address); } }
        public Object ExcludeBoneName { get { return this[nameof(ExcludeBoneName)]; } set { this[nameof(ExcludeBoneName)] = value; } }
        public bool bExcludeBone { get { return this[nameof(bExcludeBone)].Flag; } set { this[nameof(bExcludeBone)].Flag = value; } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
    }
    public class NiagaraDataInterfaceSpline : NiagaraDataInterface
    {
        public NiagaraDataInterfaceSpline(ulong addr) : base(addr) { }
        public Actor Source { get { return this[nameof(Source)].As<Actor>(); } set { this["Source"] = value; } }
    }
    public class NiagaraDataInterfaceStaticMesh : NiagaraDataInterface
    {
        public NiagaraDataInterfaceStaticMesh(ulong addr) : base(addr) { }
        public ENDIStaticMesh_SourceMode SourceMode { get { return (ENDIStaticMesh_SourceMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public StaticMesh DefaultMesh { get { return this[nameof(DefaultMesh)].As<StaticMesh>(); } set { this["DefaultMesh"] = value; } }
        public Actor Source { get { return this[nameof(Source)].As<Actor>(); } set { this["Source"] = value; } }
        public StaticMeshComponent SourceComponent { get { return this[nameof(SourceComponent)].As<StaticMeshComponent>(); } set { this["SourceComponent"] = value; } }
        public NDIStaticMeshSectionFilter SectionFilter { get { return this[nameof(SectionFilter)].As<NDIStaticMeshSectionFilter>(); } set { this["SectionFilter"] = value; } }
        public bool bUsePhysicsBodyVelocity { get { return this[nameof(bUsePhysicsBodyVelocity)].Flag; } set { this[nameof(bUsePhysicsBodyVelocity)].Flag = value; } }
        public Array<Object> FilteredSockets { get { return new Array<Object>(this[nameof(FilteredSockets)].Address); } }
    }
    public class NiagaraDataInterfaceTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceTexture(ulong addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
    }
    public class NiagaraDataInterfaceVector2DCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVector2DCurve(ulong addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVector4Curve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVector4Curve(ulong addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
        public RichCurve ZCurve { get { return this[nameof(ZCurve)].As<RichCurve>(); } set { this["ZCurve"] = value; } }
        public RichCurve WCurve { get { return this[nameof(WCurve)].As<RichCurve>(); } set { this["WCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVectorCurve : NiagaraDataInterfaceCurveBase
    {
        public NiagaraDataInterfaceVectorCurve(ulong addr) : base(addr) { }
        public RichCurve XCurve { get { return this[nameof(XCurve)].As<RichCurve>(); } set { this["XCurve"] = value; } }
        public RichCurve YCurve { get { return this[nameof(YCurve)].As<RichCurve>(); } set { this["YCurve"] = value; } }
        public RichCurve ZCurve { get { return this[nameof(ZCurve)].As<RichCurve>(); } set { this["ZCurve"] = value; } }
    }
    public class NiagaraDataInterfaceVectorField : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVectorField(ulong addr) : base(addr) { }
        public VectorField Field { get { return this[nameof(Field)].As<VectorField>(); } set { this["Field"] = value; } }
        public bool bTileX { get { return this[nameof(bTileX)].Flag; } set { this[nameof(bTileX)].Flag = value; } }
        public bool bTileY { get { return this[nameof(bTileY)].Flag; } set { this[nameof(bTileY)].Flag = value; } }
        public bool bTileZ { get { return this[nameof(bTileZ)].Flag; } set { this[nameof(bTileZ)].Flag = value; } }
    }
    public class NiagaraDataInterfaceVolumeTexture : NiagaraDataInterface
    {
        public NiagaraDataInterfaceVolumeTexture(ulong addr) : base(addr) { }
        public VolumeTexture Texture { get { return this[nameof(Texture)].As<VolumeTexture>(); } set { this["Texture"] = value; } }
    }
    public class NiagaraEditorDataBase : Object
    {
        public NiagaraEditorDataBase(ulong addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandler : Object
    {
        public NiagaraSignificanceHandler(ulong addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandlerDistance : NiagaraSignificanceHandler
    {
        public NiagaraSignificanceHandlerDistance(ulong addr) : base(addr) { }
    }
    public class NiagaraSignificanceHandlerAge : NiagaraSignificanceHandler
    {
        public NiagaraSignificanceHandlerAge(ulong addr) : base(addr) { }
    }
    public class NiagaraEffectType : Object
    {
        public NiagaraEffectType(ulong addr) : base(addr) { }
        public ENiagaraScalabilityUpdateFrequency UpdateFrequency { get { return (ENiagaraScalabilityUpdateFrequency)this[nameof(UpdateFrequency)].GetValue<int>(); } set { this[nameof(UpdateFrequency)].SetValue<int>((int)value); } }
        public ENiagaraCullReaction CullReaction { get { return (ENiagaraCullReaction)this[nameof(CullReaction)].GetValue<int>(); } set { this[nameof(CullReaction)].SetValue<int>((int)value); } }
        public NiagaraSignificanceHandler SignificanceHandler { get { return this[nameof(SignificanceHandler)].As<NiagaraSignificanceHandler>(); } set { this["SignificanceHandler"] = value; } }
        public Array<NiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings { get { return new Array<NiagaraSystemScalabilitySettings>(this[nameof(DetailLevelScalabilitySettings)].Address); } }
        public NiagaraSystemScalabilitySettingsArray SystemScalabilitySettings { get { return this[nameof(SystemScalabilitySettings)].As<NiagaraSystemScalabilitySettingsArray>(); } set { this["SystemScalabilitySettings"] = value; } }
        public NiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings { get { return this[nameof(EmitterScalabilitySettings)].As<NiagaraEmitterScalabilitySettingsArray>(); } set { this["EmitterScalabilitySettings"] = value; } }
    }
    public class NiagaraEmitter : Object
    {
        public NiagaraEmitter(ulong addr) : base(addr) { }
        public bool bLocalSpace { get { return this[nameof(bLocalSpace)].Flag; } set { this[nameof(bLocalSpace)].Flag = value; } }
        public bool bDeterminism { get { return this[nameof(bDeterminism)].Flag; } set { this[nameof(bDeterminism)].Flag = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public EParticleAllocationMode AllocationMode { get { return (EParticleAllocationMode)this[nameof(AllocationMode)].GetValue<int>(); } set { this[nameof(AllocationMode)].SetValue<int>((int)value); } }
        public int PreAllocationCount { get { return this[nameof(PreAllocationCount)].GetValue<int>(); } set { this[nameof(PreAllocationCount)].SetValue<int>(value); } }
        public NiagaraEmitterScriptProperties UpdateScriptProps { get { return this[nameof(UpdateScriptProps)].As<NiagaraEmitterScriptProperties>(); } set { this["UpdateScriptProps"] = value; } }
        public NiagaraEmitterScriptProperties SpawnScriptProps { get { return this[nameof(SpawnScriptProps)].As<NiagaraEmitterScriptProperties>(); } set { this["SpawnScriptProps"] = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
        public Box FixedBounds { get { return this[nameof(FixedBounds)].As<Box>(); } set { this["FixedBounds"] = value; } }
        public int MinDetailLevel { get { return this[nameof(MinDetailLevel)].GetValue<int>(); } set { this[nameof(MinDetailLevel)].SetValue<int>(value); } }
        public int MaxDetailLevel { get { return this[nameof(MaxDetailLevel)].GetValue<int>(); } set { this[nameof(MaxDetailLevel)].SetValue<int>(value); } }
        public NiagaraDetailsLevelScaleOverrides GlobalSpawnCountScaleOverrides { get { return this[nameof(GlobalSpawnCountScaleOverrides)].As<NiagaraDetailsLevelScaleOverrides>(); } set { this["GlobalSpawnCountScaleOverrides"] = value; } }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public NiagaraEmitterScalabilityOverrides ScalabilityOverrides { get { return this[nameof(ScalabilityOverrides)].As<NiagaraEmitterScalabilityOverrides>(); } set { this["ScalabilityOverrides"] = value; } }
        public bool bInterpolatedSpawning { get { return this[nameof(bInterpolatedSpawning)].Flag; } set { this[nameof(bInterpolatedSpawning)].Flag = value; } }
        public bool bFixedBounds { get { return this[nameof(bFixedBounds)].Flag; } set { this[nameof(bFixedBounds)].Flag = value; } }
        public bool bUseMinDetailLevel { get { return this[nameof(bUseMinDetailLevel)].Flag; } set { this[nameof(bUseMinDetailLevel)].Flag = value; } }
        public bool bUseMaxDetailLevel { get { return this[nameof(bUseMaxDetailLevel)].Flag; } set { this[nameof(bUseMaxDetailLevel)].Flag = value; } }
        public bool bOverrideGlobalSpawnCountScale { get { return this[nameof(bOverrideGlobalSpawnCountScale)].Flag; } set { this[nameof(bOverrideGlobalSpawnCountScale)].Flag = value; } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public bool bCombineEventSpawn { get { return this[nameof(bCombineEventSpawn)].Flag; } set { this[nameof(bCombineEventSpawn)].Flag = value; } }
        public float MaxDeltaTimePerTick { get { return this[nameof(MaxDeltaTimePerTick)].GetValue<float>(); } set { this[nameof(MaxDeltaTimePerTick)].SetValue<float>(value); } }
        public uint DefaultShaderStageIndex { get { return this[nameof(DefaultShaderStageIndex)].GetValue<uint>(); } set { this[nameof(DefaultShaderStageIndex)].SetValue<uint>(value); } }
        public uint MaxUpdateIterations { get { return this[nameof(MaxUpdateIterations)].GetValue<uint>(); } set { this[nameof(MaxUpdateIterations)].SetValue<uint>(value); } }
        public Object SpawnStages { get { return this[nameof(SpawnStages)]; } set { this[nameof(SpawnStages)] = value; } }
        public bool bSimulationStagesEnabled { get { return this[nameof(bSimulationStagesEnabled)].Flag; } set { this[nameof(bSimulationStagesEnabled)].Flag = value; } }
        public bool bDeprecatedShaderStagesEnabled { get { return this[nameof(bDeprecatedShaderStagesEnabled)].Flag; } set { this[nameof(bDeprecatedShaderStagesEnabled)].Flag = value; } }
        public bool bLimitDeltaTime { get { return this[nameof(bLimitDeltaTime)].Flag; } set { this[nameof(bLimitDeltaTime)].Flag = value; } }
        public Object UniqueEmitterName { get { return this[nameof(UniqueEmitterName)]; } set { this[nameof(UniqueEmitterName)] = value; } }
        public Array<NiagaraRendererProperties> RendererProperties { get { return new Array<NiagaraRendererProperties>(this[nameof(RendererProperties)].Address); } }
        public Array<NiagaraEventScriptProperties> EventHandlerScriptProps { get { return new Array<NiagaraEventScriptProperties>(this[nameof(EventHandlerScriptProps)].Address); } }
        public Array<NiagaraSimulationStageBase> SimulationStages { get { return new Array<NiagaraSimulationStageBase>(this[nameof(SimulationStages)].Address); } }
        public NiagaraScript GPUComputeScript { get { return this[nameof(GPUComputeScript)].As<NiagaraScript>(); } set { this["GPUComputeScript"] = value; } }
        public Array<Object> SharedEventGeneratorIds { get { return new Array<Object>(this[nameof(SharedEventGeneratorIds)].Address); } }
    }
    public class NiagaraEventReceiverEmitterAction : Object
    {
        public NiagaraEventReceiverEmitterAction(ulong addr) : base(addr) { }
    }
    public class NiagaraEventReceiverEmitterAction_SpawnParticles : NiagaraEventReceiverEmitterAction
    {
        public NiagaraEventReceiverEmitterAction_SpawnParticles(ulong addr) : base(addr) { }
        public uint NumParticles { get { return this[nameof(NumParticles)].GetValue<uint>(); } set { this[nameof(NumParticles)].SetValue<uint>(value); } }
    }
    public class NiagaraFunctionLibrary : BlueprintFunctionLibrary
    {
        public NiagaraFunctionLibrary(ulong addr) : base(addr) { }
        public NiagaraComponent SpawnSystemAttached(NiagaraSystem SystemTemplate, SceneComponent AttachToComponent, Object AttachPointName, Vector Location, Rotator Rotation, byte LocationType, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAttached), SystemTemplate, AttachToComponent, AttachPointName, Location, Rotation, LocationType, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck); }
        public NiagaraComponent SpawnSystemAtLocation(Object WorldContextObject, NiagaraSystem SystemTemplate, Vector Location, Rotator Rotation, Vector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck) { return Invoke<NiagaraComponent>(nameof(SpawnSystemAtLocation), WorldContextObject, SystemTemplate, Location, Rotation, Scale, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck); }
        public void SetVolumeTextureObject(NiagaraComponent NiagaraSystem, Object OverrideName, VolumeTexture Texture) { Invoke(nameof(SetVolumeTextureObject), NiagaraSystem, OverrideName, Texture); }
        public void SetTextureObject(NiagaraComponent NiagaraSystem, Object OverrideName, Texture Texture) { Invoke(nameof(SetTextureObject), NiagaraSystem, OverrideName, Texture); }
        public void SetSkeletalMeshDataInterfaceSamplingRegions(NiagaraComponent NiagaraSystem, Object OverrideName, Array<Object> SamplingRegions) { Invoke(nameof(SetSkeletalMeshDataInterfaceSamplingRegions), NiagaraSystem, OverrideName, SamplingRegions); }
        public void OverrideSystemUserVariableStaticMeshComponent(NiagaraComponent NiagaraSystem, Object OverrideName, StaticMeshComponent StaticMeshComponent) { Invoke(nameof(OverrideSystemUserVariableStaticMeshComponent), NiagaraSystem, OverrideName, StaticMeshComponent); }
        public void OverrideSystemUserVariableStaticMesh(NiagaraComponent NiagaraSystem, Object OverrideName, StaticMesh StaticMesh) { Invoke(nameof(OverrideSystemUserVariableStaticMesh), NiagaraSystem, OverrideName, StaticMesh); }
        public void OverrideSystemUserVariableSkeletalMeshComponent(NiagaraComponent NiagaraSystem, Object OverrideName, SkeletalMeshComponent SkeletalMeshComponent) { Invoke(nameof(OverrideSystemUserVariableSkeletalMeshComponent), NiagaraSystem, OverrideName, SkeletalMeshComponent); }
        public NiagaraParameterCollectionInstance GetNiagaraParameterCollection(Object WorldContextObject, NiagaraParameterCollection Collection) { return Invoke<NiagaraParameterCollectionInstance>(nameof(GetNiagaraParameterCollection), WorldContextObject, Collection); }
    }
    public class NiagaraLightRendererProperties : NiagaraRendererProperties
    {
        public NiagaraLightRendererProperties(ulong addr) : base(addr) { }
        public bool bUseInverseSquaredFalloff { get { return this[nameof(bUseInverseSquaredFalloff)].Flag; } set { this[nameof(bUseInverseSquaredFalloff)].Flag = value; } }
        public bool bAffectsTranslucency { get { return this[nameof(bAffectsTranslucency)].Flag; } set { this[nameof(bAffectsTranslucency)].Flag = value; } }
        public float RadiusScale { get { return this[nameof(RadiusScale)].GetValue<float>(); } set { this[nameof(RadiusScale)].SetValue<float>(value); } }
        public Vector ColorAdd { get { return this[nameof(ColorAdd)].As<Vector>(); } set { this["ColorAdd"] = value; } }
        public NiagaraVariableAttributeBinding LightRenderingEnabledBinding { get { return this[nameof(LightRenderingEnabledBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["LightRenderingEnabledBinding"] = value; } }
        public NiagaraVariableAttributeBinding LightExponentBinding { get { return this[nameof(LightExponentBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["LightExponentBinding"] = value; } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding RadiusBinding { get { return this[nameof(RadiusBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RadiusBinding"] = value; } }
        public NiagaraVariableAttributeBinding VolumetricScatteringBinding { get { return this[nameof(VolumetricScatteringBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VolumetricScatteringBinding"] = value; } }
    }
    public class NiagaraMeshRendererProperties : NiagaraRendererProperties
    {
        public NiagaraMeshRendererProperties(ulong addr) : base(addr) { }
        public StaticMesh ParticleMesh { get { return this[nameof(ParticleMesh)].As<StaticMesh>(); } set { this["ParticleMesh"] = value; } }
        public ENiagaraSortMode SortMode { get { return (ENiagaraSortMode)this[nameof(SortMode)].GetValue<int>(); } set { this[nameof(SortMode)].SetValue<int>((int)value); } }
        public bool bOverrideMaterials { get { return this[nameof(bOverrideMaterials)].Flag; } set { this[nameof(bOverrideMaterials)].Flag = value; } }
        public bool bSortOnlyWhenTranslucent { get { return this[nameof(bSortOnlyWhenTranslucent)].Flag; } set { this[nameof(bSortOnlyWhenTranslucent)].Flag = value; } }
        public Array<NiagaraMeshMaterialOverride> OverrideMaterials { get { return new Array<NiagaraMeshMaterialOverride>(this[nameof(OverrideMaterials)].Address); } }
        public Vector2D SubImageSize { get { return this[nameof(SubImageSize)].As<Vector2D>(); } set { this["SubImageSize"] = value; } }
        public bool bSubImageBlend { get { return this[nameof(bSubImageBlend)].Flag; } set { this[nameof(bSubImageBlend)].Flag = value; } }
        public ENiagaraMeshFacingMode FacingMode { get { return (ENiagaraMeshFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public bool bLockedAxisEnable { get { return this[nameof(bLockedAxisEnable)].Flag; } set { this[nameof(bLockedAxisEnable)].Flag = value; } }
        public Vector LockedAxis { get { return this[nameof(LockedAxis)].As<Vector>(); } set { this["LockedAxis"] = value; } }
        public ENiagaraMeshLockedAxisSpace LockedAxisSpace { get { return (ENiagaraMeshLockedAxisSpace)this[nameof(LockedAxisSpace)].GetValue<int>(); } set { this[nameof(LockedAxisSpace)].SetValue<int>((int)value); } }
        public Vector PivotOffset { get { return this[nameof(PivotOffset)].As<Vector>(); } set { this["PivotOffset"] = value; } }
        public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace { get { return (ENiagaraMeshPivotOffsetSpace)this[nameof(PivotOffsetSpace)].GetValue<int>(); } set { this[nameof(PivotOffsetSpace)].SetValue<int>((int)value); } }
        public bool bEnableFrustumCulling { get { return this[nameof(bEnableFrustumCulling)].Flag; } set { this[nameof(bEnableFrustumCulling)].Flag = value; } }
        public bool bEnableCameraDistanceCulling { get { return this[nameof(bEnableCameraDistanceCulling)].Flag; } set { this[nameof(bEnableCameraDistanceCulling)].Flag = value; } }
        public float MinCameraDistance { get { return this[nameof(MinCameraDistance)].GetValue<float>(); } set { this[nameof(MinCameraDistance)].SetValue<float>(value); } }
        public float MaxCameraDistance { get { return this[nameof(MaxCameraDistance)].GetValue<float>(); } set { this[nameof(MaxCameraDistance)].SetValue<float>(value); } }
        public uint RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<uint>(); } set { this[nameof(RendererVisibility)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding MeshOrientationBinding { get { return this[nameof(MeshOrientationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MeshOrientationBinding"] = value; } }
        public NiagaraVariableAttributeBinding ScaleBinding { get { return this[nameof(ScaleBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ScaleBinding"] = value; } }
        public NiagaraVariableAttributeBinding SubImageIndexBinding { get { return this[nameof(SubImageIndexBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SubImageIndexBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding CustomSortingBinding { get { return this[nameof(CustomSortingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CustomSortingBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding CameraOffsetBinding { get { return this[nameof(CameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
    }
    public class NiagaraMessageDataBase : Object
    {
        public NiagaraMessageDataBase(ulong addr) : base(addr) { }
    }
    public class NiagaraParameterCollectionInstance : Object
    {
        public NiagaraParameterCollectionInstance(ulong addr) : base(addr) { }
        public NiagaraParameterCollection Collection { get { return this[nameof(Collection)].As<NiagaraParameterCollection>(); } set { this["Collection"] = value; } }
        public Array<NiagaraVariable> OverridenParameters { get { return new Array<NiagaraVariable>(this[nameof(OverridenParameters)].Address); } }
        public NiagaraParameterStore ParameterStorage { get { return this[nameof(ParameterStorage)].As<NiagaraParameterStore>(); } set { this["ParameterStorage"] = value; } }
        public void SetVectorParameter(Object InVariableName, Vector InValue) { Invoke(nameof(SetVectorParameter), InVariableName, InValue); }
        public void SetVector4Parameter(Object InVariableName, Vector4 InValue) { Invoke(nameof(SetVector4Parameter), InVariableName, InValue); }
        public void SetVector2DParameter(Object InVariableName, Vector2D InValue) { Invoke(nameof(SetVector2DParameter), InVariableName, InValue); }
        public void SetQuatParameter(Object InVariableName, Quat InValue) { Invoke(nameof(SetQuatParameter), InVariableName, InValue); }
        public void SetIntParameter(Object InVariableName, int InValue) { Invoke(nameof(SetIntParameter), InVariableName, InValue); }
        public void SetFloatParameter(Object InVariableName, float InValue) { Invoke(nameof(SetFloatParameter), InVariableName, InValue); }
        public void SetColorParameter(Object InVariableName, LinearColor InValue) { Invoke(nameof(SetColorParameter), InVariableName, InValue); }
        public void SetBoolParameter(Object InVariableName, bool InValue) { Invoke(nameof(SetBoolParameter), InVariableName, InValue); }
        public Vector GetVectorParameter(Object InVariableName) { return Invoke<Vector>(nameof(GetVectorParameter), InVariableName); }
        public Vector4 GetVector4Parameter(Object InVariableName) { return Invoke<Vector4>(nameof(GetVector4Parameter), InVariableName); }
        public Vector2D GetVector2DParameter(Object InVariableName) { return Invoke<Vector2D>(nameof(GetVector2DParameter), InVariableName); }
        public Quat GetQuatParameter(Object InVariableName) { return Invoke<Quat>(nameof(GetQuatParameter), InVariableName); }
        public int GetIntParameter(Object InVariableName) { return Invoke<int>(nameof(GetIntParameter), InVariableName); }
        public float GetFloatParameter(Object InVariableName) { return Invoke<float>(nameof(GetFloatParameter), InVariableName); }
        public LinearColor GetColorParameter(Object InVariableName) { return Invoke<LinearColor>(nameof(GetColorParameter), InVariableName); }
        public bool GetBoolParameter(Object InVariableName) { return Invoke<bool>(nameof(GetBoolParameter), InVariableName); }
    }
    public class NiagaraParameterCollection : Object
    {
        public NiagaraParameterCollection(ulong addr) : base(addr) { }
        public Object Namespace { get { return this[nameof(Namespace)]; } set { this[nameof(Namespace)] = value; } }
        public Array<NiagaraVariable> Parameters { get { return new Array<NiagaraVariable>(this[nameof(Parameters)].Address); } }
        public MaterialParameterCollection SourceMaterialCollection { get { return this[nameof(SourceMaterialCollection)].As<MaterialParameterCollection>(); } set { this["SourceMaterialCollection"] = value; } }
        public NiagaraParameterCollectionInstance DefaultInstance { get { return this[nameof(DefaultInstance)].As<NiagaraParameterCollectionInstance>(); } set { this["DefaultInstance"] = value; } }
        public Guid CompileId { get { return this[nameof(CompileId)].As<Guid>(); } set { this["CompileId"] = value; } }
    }
    public class NiagaraPrecompileContainer : Object
    {
        public NiagaraPrecompileContainer(ulong addr) : base(addr) { }
        public Array<NiagaraScript> Scripts { get { return new Array<NiagaraScript>(this[nameof(Scripts)].Address); } }
        public NiagaraSystem System { get { return this[nameof(System)].As<NiagaraSystem>(); } set { this["System"] = value; } }
    }
    public class NiagaraPreviewBase : Actor
    {
        public NiagaraPreviewBase(ulong addr) : base(addr) { }
        public void SetSystem(NiagaraSystem InSystem) { Invoke(nameof(SetSystem), InSystem); }
        public void SetLabelText(Object InXAxisText, Object InYAxisText) { Invoke(nameof(SetLabelText), InXAxisText, InYAxisText); }
    }
    public class NiagaraPreviewAxis : Object
    {
        public NiagaraPreviewAxis(ulong addr) : base(addr) { }
        public int Num() { return Invoke<int>(nameof(Num)); }
        public void ApplyToPreview(NiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, Object OutLabelText) { Invoke(nameof(ApplyToPreview), PreviewComponent, PreviewIndex, bIsXAxis, OutLabelText); }
    }
    public class NiagaraPreviewAxis_InterpParamBase : NiagaraPreviewAxis
    {
        public NiagaraPreviewAxis_InterpParamBase(ulong addr) : base(addr) { }
        public Object Param { get { return this[nameof(Param)]; } set { this[nameof(Param)] = value; } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamInt32 : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamInt32(ulong addr) : base(addr) { }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamFloat : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamFloat(ulong addr) : base(addr) { }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
    }
    public class NiagaraPreviewAxis_InterpParamVector2D : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector2D(ulong addr) : base(addr) { }
        public Vector2D Min { get { return this[nameof(Min)].As<Vector2D>(); } set { this["Min"] = value; } }
        public Vector2D Max { get { return this[nameof(Max)].As<Vector2D>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamVector : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector(ulong addr) : base(addr) { }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamVector4 : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamVector4(ulong addr) : base(addr) { }
        public Vector4 Min { get { return this[nameof(Min)].As<Vector4>(); } set { this["Min"] = value; } }
        public Vector4 Max { get { return this[nameof(Max)].As<Vector4>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewAxis_InterpParamLinearColor : NiagaraPreviewAxis_InterpParamBase
    {
        public NiagaraPreviewAxis_InterpParamLinearColor(ulong addr) : base(addr) { }
        public LinearColor Min { get { return this[nameof(Min)].As<LinearColor>(); } set { this["Min"] = value; } }
        public LinearColor Max { get { return this[nameof(Max)].As<LinearColor>(); } set { this["Max"] = value; } }
    }
    public class NiagaraPreviewGrid : Actor
    {
        public NiagaraPreviewGrid(ulong addr) : base(addr) { }
        public NiagaraSystem System { get { return this[nameof(System)].As<NiagaraSystem>(); } set { this["System"] = value; } }
        public ENiagaraPreviewGridResetMode ResetMode { get { return (ENiagaraPreviewGridResetMode)this[nameof(ResetMode)].GetValue<int>(); } set { this[nameof(ResetMode)].SetValue<int>((int)value); } }
        public NiagaraPreviewAxis PreviewAxisX { get { return this[nameof(PreviewAxisX)].As<NiagaraPreviewAxis>(); } set { this["PreviewAxisX"] = value; } }
        public NiagaraPreviewAxis PreviewAxisY { get { return this[nameof(PreviewAxisY)].As<NiagaraPreviewAxis>(); } set { this["PreviewAxisY"] = value; } }
        public Object PreviewClass { get { return this[nameof(PreviewClass)]; } set { this[nameof(PreviewClass)] = value; } }
        public float SpacingX { get { return this[nameof(SpacingX)].GetValue<float>(); } set { this[nameof(SpacingX)].SetValue<float>(value); } }
        public float SpacingY { get { return this[nameof(SpacingY)].GetValue<float>(); } set { this[nameof(SpacingY)].SetValue<float>(value); } }
        public int NumX { get { return this[nameof(NumX)].GetValue<int>(); } set { this[nameof(NumX)].SetValue<int>(value); } }
        public int NumY { get { return this[nameof(NumY)].GetValue<int>(); } set { this[nameof(NumY)].SetValue<int>(value); } }
        public Array<ChildActorComponent> PreviewComponents { get { return new Array<ChildActorComponent>(this[nameof(PreviewComponents)].Address); } }
        public void SetPaused(bool bPaused) { Invoke(nameof(SetPaused), bPaused); }
        public void GetPreviews(Array<NiagaraComponent> OutPreviews) { Invoke(nameof(GetPreviews), OutPreviews); }
        public void DeactivatePreviews() { Invoke(nameof(DeactivatePreviews)); }
        public void ActivatePreviews(bool bReset) { Invoke(nameof(ActivatePreviews), bReset); }
    }
    public class NiagaraRibbonRendererProperties : NiagaraRendererProperties
    {
        public NiagaraRibbonRendererProperties(ulong addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public NiagaraUserParameterBinding MaterialUserParamBinding { get { return this[nameof(MaterialUserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["MaterialUserParamBinding"] = value; } }
        public ENiagaraRibbonFacingMode FacingMode { get { return (ENiagaraRibbonFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public NiagaraRibbonUVSettings UV0Settings { get { return this[nameof(UV0Settings)].As<NiagaraRibbonUVSettings>(); } set { this["UV0Settings"] = value; } }
        public NiagaraRibbonUVSettings UV1Settings { get { return this[nameof(UV1Settings)].As<NiagaraRibbonUVSettings>(); } set { this["UV1Settings"] = value; } }
        public ENiagaraRibbonDrawDirection DrawDirection { get { return (ENiagaraRibbonDrawDirection)this[nameof(DrawDirection)].GetValue<int>(); } set { this[nameof(DrawDirection)].SetValue<int>((int)value); } }
        public float CurveTension { get { return this[nameof(CurveTension)].GetValue<float>(); } set { this[nameof(CurveTension)].SetValue<float>(value); } }
        public ENiagaraRibbonTessellationMode TessellationMode { get { return (ENiagaraRibbonTessellationMode)this[nameof(TessellationMode)].GetValue<int>(); } set { this[nameof(TessellationMode)].SetValue<int>((int)value); } }
        public int TessellationFactor { get { return this[nameof(TessellationFactor)].GetValue<int>(); } set { this[nameof(TessellationFactor)].SetValue<int>(value); } }
        public bool bUseConstantFactor { get { return this[nameof(bUseConstantFactor)].Flag; } set { this[nameof(bUseConstantFactor)].Flag = value; } }
        public float TessellationAngle { get { return this[nameof(TessellationAngle)].GetValue<float>(); } set { this[nameof(TessellationAngle)].SetValue<float>(value); } }
        public bool bScreenSpaceTessellation { get { return this[nameof(bScreenSpaceTessellation)].Flag; } set { this[nameof(bScreenSpaceTessellation)].Flag = value; } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonTwistBinding { get { return this[nameof(RibbonTwistBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonTwistBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonWidthBinding { get { return this[nameof(RibbonWidthBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonWidthBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonFacingBinding { get { return this[nameof(RibbonFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonIdBinding { get { return this[nameof(RibbonIdBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonIdBinding"] = value; } }
        public NiagaraVariableAttributeBinding RibbonLinkOrderBinding { get { return this[nameof(RibbonLinkOrderBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RibbonLinkOrderBinding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding U0OverrideBinding { get { return this[nameof(U0OverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["U0OverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding V0RangeOverrideBinding { get { return this[nameof(V0RangeOverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["V0RangeOverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding U1OverrideBinding { get { return this[nameof(U1OverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["U1OverrideBinding"] = value; } }
        public NiagaraVariableAttributeBinding V1RangeOverrideBinding { get { return this[nameof(V1RangeOverrideBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["V1RangeOverrideBinding"] = value; } }
    }
    public class NiagaraScript : NiagaraScriptBase
    {
        public NiagaraScript(ulong addr) : base(addr) { }
        public ENiagaraScriptUsage Usage { get { return (ENiagaraScriptUsage)this[nameof(Usage)].GetValue<int>(); } set { this[nameof(Usage)].SetValue<int>((int)value); } }
        public int UsageIndex { get { return this[nameof(UsageIndex)].GetValue<int>(); } set { this[nameof(UsageIndex)].SetValue<int>(value); } }
        public Guid UsageId { get { return this[nameof(UsageId)].As<Guid>(); } set { this["UsageId"] = value; } }
        public NiagaraParameterStore RapidIterationParameters { get { return this[nameof(RapidIterationParameters)].As<NiagaraParameterStore>(); } set { this["RapidIterationParameters"] = value; } }
        public NiagaraScriptExecutionParameterStore ScriptExecutionParamStore { get { return this[nameof(ScriptExecutionParamStore)].As<NiagaraScriptExecutionParameterStore>(); } set { this["ScriptExecutionParamStore"] = value; } }
        public Array<NiagaraBoundParameter> ScriptExecutionBoundParameters { get { return new Array<NiagaraBoundParameter>(this[nameof(ScriptExecutionBoundParameters)].Address); } }
        public NiagaraVMExecutableDataId CachedScriptVMId { get { return this[nameof(CachedScriptVMId)].As<NiagaraVMExecutableDataId>(); } set { this["CachedScriptVMId"] = value; } }
        public NiagaraVMExecutableData CachedScriptVM { get { return this[nameof(CachedScriptVM)].As<NiagaraVMExecutableData>(); } set { this["CachedScriptVM"] = value; } }
        public Array<NiagaraParameterCollection> CachedParameterCollectionReferences { get { return new Array<NiagaraParameterCollection>(this[nameof(CachedParameterCollectionReferences)].Address); } }
        public Array<NiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces { get { return new Array<NiagaraScriptDataInterfaceInfo>(this[nameof(CachedDefaultDataInterfaces)].Address); } }
        public void RaiseOnGPUCompilationComplete() { Invoke(nameof(RaiseOnGPUCompilationComplete)); }
    }
    public class NiagaraScriptSourceBase : Object
    {
        public NiagaraScriptSourceBase(ulong addr) : base(addr) { }
    }
    public class NiagaraSimulationStageBase : NiagaraMergeable
    {
        public NiagaraSimulationStageBase(ulong addr) : base(addr) { }
        public NiagaraScript Script { get { return this[nameof(Script)].As<NiagaraScript>(); } set { this["Script"] = value; } }
        public Object SimulationStageName { get { return this[nameof(SimulationStageName)]; } set { this[nameof(SimulationStageName)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
    public class NiagaraSimulationStageGeneric : NiagaraSimulationStageBase
    {
        public NiagaraSimulationStageGeneric(ulong addr) : base(addr) { }
        public ENiagaraIterationSource IterationSource { get { return (ENiagaraIterationSource)this[nameof(IterationSource)].GetValue<int>(); } set { this[nameof(IterationSource)].SetValue<int>((int)value); } }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public bool bSpawnOnly { get { return this[nameof(bSpawnOnly)].Flag; } set { this[nameof(bSpawnOnly)].Flag = value; } }
        public bool bDisablePartialParticleUpdate { get { return this[nameof(bDisablePartialParticleUpdate)].Flag; } set { this[nameof(bDisablePartialParticleUpdate)].Flag = value; } }
        public NiagaraVariableDataInterfaceBinding DataInterface { get { return this[nameof(DataInterface)].As<NiagaraVariableDataInterfaceBinding>(); } set { this["DataInterface"] = value; } }
    }
    public class NiagaraSpriteRendererProperties : NiagaraRendererProperties
    {
        public NiagaraSpriteRendererProperties(ulong addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public ENiagaraRendererSourceDataMode SourceMode { get { return (ENiagaraRendererSourceDataMode)this[nameof(SourceMode)].GetValue<int>(); } set { this[nameof(SourceMode)].SetValue<int>((int)value); } }
        public NiagaraUserParameterBinding MaterialUserParamBinding { get { return this[nameof(MaterialUserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["MaterialUserParamBinding"] = value; } }
        public ENiagaraSpriteAlignment Alignment { get { return (ENiagaraSpriteAlignment)this[nameof(Alignment)].GetValue<int>(); } set { this[nameof(Alignment)].SetValue<int>((int)value); } }
        public ENiagaraSpriteFacingMode FacingMode { get { return (ENiagaraSpriteFacingMode)this[nameof(FacingMode)].GetValue<int>(); } set { this[nameof(FacingMode)].SetValue<int>((int)value); } }
        public Vector2D PivotInUVSpace { get { return this[nameof(PivotInUVSpace)].As<Vector2D>(); } set { this["PivotInUVSpace"] = value; } }
        public ENiagaraSortMode SortMode { get { return (ENiagaraSortMode)this[nameof(SortMode)].GetValue<int>(); } set { this[nameof(SortMode)].SetValue<int>((int)value); } }
        public Vector2D SubImageSize { get { return this[nameof(SubImageSize)].As<Vector2D>(); } set { this["SubImageSize"] = value; } }
        public bool bSubImageBlend { get { return this[nameof(bSubImageBlend)].Flag; } set { this[nameof(bSubImageBlend)].Flag = value; } }
        public bool bRemoveHMDRollInVR { get { return this[nameof(bRemoveHMDRollInVR)].Flag; } set { this[nameof(bRemoveHMDRollInVR)].Flag = value; } }
        public bool bSortOnlyWhenTranslucent { get { return this[nameof(bSortOnlyWhenTranslucent)].Flag; } set { this[nameof(bSortOnlyWhenTranslucent)].Flag = value; } }
        public bool bGpuLowLatencyTranslucency { get { return this[nameof(bGpuLowLatencyTranslucency)].Flag; } set { this[nameof(bGpuLowLatencyTranslucency)].Flag = value; } }
        public float MinFacingCameraBlendDistance { get { return this[nameof(MinFacingCameraBlendDistance)].GetValue<float>(); } set { this[nameof(MinFacingCameraBlendDistance)].SetValue<float>(value); } }
        public float MaxFacingCameraBlendDistance { get { return this[nameof(MaxFacingCameraBlendDistance)].GetValue<float>(); } set { this[nameof(MaxFacingCameraBlendDistance)].SetValue<float>(value); } }
        public bool bEnableCameraDistanceCulling { get { return this[nameof(bEnableCameraDistanceCulling)].Flag; } set { this[nameof(bEnableCameraDistanceCulling)].Flag = value; } }
        public float MinCameraDistance { get { return this[nameof(MinCameraDistance)].GetValue<float>(); } set { this[nameof(MinCameraDistance)].SetValue<float>(value); } }
        public float MaxCameraDistance { get { return this[nameof(MaxCameraDistance)].GetValue<float>(); } set { this[nameof(MaxCameraDistance)].SetValue<float>(value); } }
        public uint RendererVisibility { get { return this[nameof(RendererVisibility)].GetValue<uint>(); } set { this[nameof(RendererVisibility)].SetValue<uint>(value); } }
        public NiagaraVariableAttributeBinding PositionBinding { get { return this[nameof(PositionBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["PositionBinding"] = value; } }
        public NiagaraVariableAttributeBinding ColorBinding { get { return this[nameof(ColorBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["ColorBinding"] = value; } }
        public NiagaraVariableAttributeBinding VelocityBinding { get { return this[nameof(VelocityBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["VelocityBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteRotationBinding { get { return this[nameof(SpriteRotationBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteRotationBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteSizeBinding { get { return this[nameof(SpriteSizeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteSizeBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteFacingBinding { get { return this[nameof(SpriteFacingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteFacingBinding"] = value; } }
        public NiagaraVariableAttributeBinding SpriteAlignmentBinding { get { return this[nameof(SpriteAlignmentBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SpriteAlignmentBinding"] = value; } }
        public NiagaraVariableAttributeBinding SubImageIndexBinding { get { return this[nameof(SubImageIndexBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["SubImageIndexBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterialBinding { get { return this[nameof(DynamicMaterialBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterialBinding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial1Binding { get { return this[nameof(DynamicMaterial1Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial1Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial2Binding { get { return this[nameof(DynamicMaterial2Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial2Binding"] = value; } }
        public NiagaraVariableAttributeBinding DynamicMaterial3Binding { get { return this[nameof(DynamicMaterial3Binding)].As<NiagaraVariableAttributeBinding>(); } set { this["DynamicMaterial3Binding"] = value; } }
        public NiagaraVariableAttributeBinding CameraOffsetBinding { get { return this[nameof(CameraOffsetBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CameraOffsetBinding"] = value; } }
        public NiagaraVariableAttributeBinding UVScaleBinding { get { return this[nameof(UVScaleBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["UVScaleBinding"] = value; } }
        public NiagaraVariableAttributeBinding MaterialRandomBinding { get { return this[nameof(MaterialRandomBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["MaterialRandomBinding"] = value; } }
        public NiagaraVariableAttributeBinding CustomSortingBinding { get { return this[nameof(CustomSortingBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["CustomSortingBinding"] = value; } }
        public NiagaraVariableAttributeBinding NormalizedAgeBinding { get { return this[nameof(NormalizedAgeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["NormalizedAgeBinding"] = value; } }
        public NiagaraVariableAttributeBinding RendererVisibilityTagBinding { get { return this[nameof(RendererVisibilityTagBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["RendererVisibilityTagBinding"] = value; } }
        public Array<NiagaraMaterialAttributeBinding> MaterialParameterBindings { get { return new Array<NiagaraMaterialAttributeBinding>(this[nameof(MaterialParameterBindings)].Address); } }
    }
    public class NiagaraSystem : FXSystemAsset
    {
        public NiagaraSystem(ulong addr) : base(addr) { }
        public bool bDumpDebugSystemInfo { get { return this[nameof(bDumpDebugSystemInfo)].Flag; } set { this[nameof(bDumpDebugSystemInfo)].Flag = value; } }
        public bool bDumpDebugEmitterInfo { get { return this[nameof(bDumpDebugEmitterInfo)].Flag; } set { this[nameof(bDumpDebugEmitterInfo)].Flag = value; } }
        public bool bRequireCurrentFrameData { get { return this[nameof(bRequireCurrentFrameData)].Flag; } set { this[nameof(bRequireCurrentFrameData)].Flag = value; } }
        public bool bFixedBounds { get { return this[nameof(bFixedBounds)].Flag; } set { this[nameof(bFixedBounds)].Flag = value; } }
        public NiagaraEffectType EffectType { get { return this[nameof(EffectType)].As<NiagaraEffectType>(); } set { this["EffectType"] = value; } }
        public bool bOverrideScalabilitySettings { get { return this[nameof(bOverrideScalabilitySettings)].Flag; } set { this[nameof(bOverrideScalabilitySettings)].Flag = value; } }
        public Array<NiagaraSystemScalabilityOverride> ScalabilityOverrides { get { return new Array<NiagaraSystemScalabilityOverride>(this[nameof(ScalabilityOverrides)].Address); } }
        public NiagaraSystemScalabilityOverrides SystemScalabilityOverrides { get { return this[nameof(SystemScalabilityOverrides)].As<NiagaraSystemScalabilityOverrides>(); } set { this["SystemScalabilityOverrides"] = value; } }
        public Array<NiagaraEmitterHandle> EmitterHandles { get { return new Array<NiagaraEmitterHandle>(this[nameof(EmitterHandles)].Address); } }
        public Array<NiagaraParameterCollectionInstance> ParameterCollectionOverrides { get { return new Array<NiagaraParameterCollectionInstance>(this[nameof(ParameterCollectionOverrides)].Address); } }
        public NiagaraScript SystemSpawnScript { get { return this[nameof(SystemSpawnScript)].As<NiagaraScript>(); } set { this["SystemSpawnScript"] = value; } }
        public NiagaraScript SystemUpdateScript { get { return this[nameof(SystemUpdateScript)].As<NiagaraScript>(); } set { this["SystemUpdateScript"] = value; } }
        public NiagaraSystemCompiledData SystemCompiledData { get { return this[nameof(SystemCompiledData)].As<NiagaraSystemCompiledData>(); } set { this["SystemCompiledData"] = value; } }
        public NiagaraUserRedirectionParameterStore ExposedParameters { get { return this[nameof(ExposedParameters)].As<NiagaraUserRedirectionParameterStore>(); } set { this["ExposedParameters"] = value; } }
        public Box FixedBounds { get { return this[nameof(FixedBounds)].As<Box>(); } set { this["FixedBounds"] = value; } }
        public bool bAutoDeactivate { get { return this[nameof(bAutoDeactivate)].Flag; } set { this[nameof(bAutoDeactivate)].Flag = value; } }
        public float WarmupTime { get { return this[nameof(WarmupTime)].GetValue<float>(); } set { this[nameof(WarmupTime)].SetValue<float>(value); } }
        public int WarmupTickCount { get { return this[nameof(WarmupTickCount)].GetValue<int>(); } set { this[nameof(WarmupTickCount)].SetValue<int>(value); } }
        public float WarmupTickDelta { get { return this[nameof(WarmupTickDelta)].GetValue<float>(); } set { this[nameof(WarmupTickDelta)].SetValue<float>(value); } }
        public bool bHasSystemScriptDIsWithPerInstanceData { get { return this[nameof(bHasSystemScriptDIsWithPerInstanceData)].Flag; } set { this[nameof(bHasSystemScriptDIsWithPerInstanceData)].Flag = value; } }
        public Array<Object> UserDINamesReadInSystemScripts { get { return new Array<Object>(this[nameof(UserDINamesReadInSystemScripts)].Address); } }
    }
    public enum ENiagaraSystemSpawnSectionEndBehavior : int
    {
        SetSystemInactive = 0,
        Deactivate = 1,
        None = 2,
        ENiagaraSystemSpawnSectionEndBehavior_MAX = 3,
    }
    public enum ENiagaraSystemSpawnSectionEvaluateBehavior : int
    {
        ActivateIfInactive = 0,
        None = 1,
        ENiagaraSystemSpawnSectionEvaluateBehavior_MAX = 2,
    }
    public enum ENiagaraSystemSpawnSectionStartBehavior : int
    {
        Activate = 0,
        ENiagaraSystemSpawnSectionStartBehavior_MAX = 1,
    }
    public enum ENiagaraCollisionMode : int
    {
        None = 0,
        SceneGeometry = 1,
        DepthBuffer = 2,
        DistanceField = 3,
        ENiagaraCollisionMode_MAX = 4,
    }
    public enum ENiagaraLegacyTrailWidthMode : int
    {
        FromCentre = 0,
        FromFirst = 1,
        FromSecond = 2,
        ENiagaraLegacyTrailWidthMode_MAX = 3,
    }
    public enum ENiagaraRendererSourceDataMode : int
    {
        Particles = 0,
        Emitter = 1,
        ENiagaraRendererSourceDataMode_MAX = 2,
    }
    public enum ENiagaraBindingSource : int
    {
        ImplicitFromSource = 0,
        ExplicitParticles = 1,
        ExplicitEmitter = 2,
        ExplicitSystem = 3,
        ExplicitUser = 4,
        MaxBindingSource = 5,
        ENiagaraBindingSource_MAX = 6,
    }
    public enum ENiagaraIterationSource : int
    {
        Particles = 0,
        DataInterface = 1,
        ENiagaraIterationSource_MAX = 2,
    }
    public enum ENiagaraScriptGroup : int
    {
        Particle = 0,
        Emitter = 1,
        System = 2,
        Max = 3,
    }
    public enum ENiagaraScriptContextStaticSwitch : int
    {
        System = 0,
        Emitter = 1,
        Particle = 2,
        ENiagaraScriptContextStaticSwitch_MAX = 3,
    }
    public enum ENiagaraCompileUsageStaticSwitch : int
    {
        Spawn = 0,
        Update = 1,
        Event = 2,
        SimulationStage = 3,
        Default = 4,
        ENiagaraCompileUsageStaticSwitch_MAX = 5,
    }
    public enum ENiagaraScriptUsage : int
    {
        Function = 0,
        Module = 1,
        DynamicInput = 2,
        ParticleSpawnScript = 3,
        ParticleSpawnScriptInterpolated = 4,
        ParticleUpdateScript = 5,
        ParticleEventScript = 6,
        ParticleSimulationStageScript = 7,
        ParticleGPUComputeScript = 8,
        EmitterSpawnScript = 9,
        EmitterUpdateScript = 10,
        SystemSpawnScript = 11,
        SystemUpdateScript = 12,
        ENiagaraScriptUsage_MAX = 13,
    }
    public enum ENiagaraScriptCompileStatus : int
    {
        NCS_Unknown = 0,
        NCS_Dirty = 1,
        NCS_Error = 2,
        NCS_UpToDate = 3,
        NCS_BeingCreated = 4,
        NCS_UpToDateWithWarnings = 5,
        NCS_ComputeUpToDateWithWarnings = 6,
        NCS_MAX = 7,
    }
    public enum ENiagaraInputNodeUsage : int
    {
        Undefined = 0,
        Parameter = 1,
        Attribute = 2,
        SystemConstant = 3,
        TranslatorConstant = 4,
        RapidIterationParameter = 5,
        ENiagaraInputNodeUsage_MAX = 6,
    }
    public enum ENiagaraDataSetType : int
    {
        ParticleData = 0,
        Shared = 1,
        Event = 2,
        ENiagaraDataSetType_MAX = 3,
    }
    public enum ENiagaraStatDisplayMode : int
    {
        Percent = 0,
        Absolute = 1,
        ENiagaraStatDisplayMode_MAX = 2,
    }
    public enum ENiagaraStatEvaluationType : int
    {
        Average = 0,
        Maximum = 1,
        ENiagaraStatEvaluationType_MAX = 2,
    }
    public enum ENiagaraAgeUpdateMode : int
    {
        TickDeltaTime = 0,
        DesiredAge = 1,
        DesiredAgeNoSeek = 2,
        ENiagaraAgeUpdateMode_MAX = 3,
    }
    public enum ENiagaraSimTarget : int
    {
        CPUSim = 0,
        GPUComputeSim = 1,
        ENiagaraSimTarget_MAX = 2,
    }
    public enum ENiagaraDefaultMode : int
    {
        Value = 0,
        Binding = 1,
        Custom = 2,
        ENiagaraDefaultMode_MAX = 3,
    }
    public enum ENiagaraGpuBufferFormat : int
    {
        Float = 0,
        HalfFloat = 1,
        UnsignedNormalizedByte = 2,
        Max = 3,
    }
    public enum ENiagaraTickBehavior : int
    {
        UsePrereqs = 0,
        UseComponentTickGroup = 1,
        ForceTickFirst = 2,
        ForceTickLast = 3,
        ENiagaraTickBehavior_MAX = 4,
    }
    public enum ENCPoolMethod : int
    {
        None = 0,
        AutoRelease = 1,
        ManualRelease = 2,
        ManualRelease_OnComplete = 3,
        FreeInPool = 4,
        ENCPoolMethod_MAX = 5,
    }
    public enum ENDIExport_GPUAllocationMode : int
    {
        FixedSize = 0,
        PerParticle = 1,
        ENDIExport_MAX = 2,
    }
    public enum ESetResolutionMethod : int
    {
        Independent = 0,
        MaxAxis = 1,
        CellSize = 2,
        ESetResolutionMethod_MAX = 3,
    }
    public enum ENDISkeletalMesh_SkinningMode : int
    {
        Invalid = 255,
        None = 0,
        SkinOnTheFly = 1,
        PreSkin = 2,
        ENDISkeletalMesh_MAX = 256,
    }
    public enum ENDISkeletalMesh_SourceMode : int
    {
        Default = 0,
        Source = 1,
        AttachParent = 2,
        ENDISkeletalMesh_MAX = 3,
    }
    public enum ENDIStaticMesh_SourceMode : int
    {
        Default = 0,
        Source = 1,
        AttachParent = 2,
        DefaultMeshOnly = 3,
        ENDIStaticMesh_MAX = 4,
    }
    public enum ENiagaraScalabilityUpdateFrequency : int
    {
        SpawnOnly = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Continuous = 4,
        ENiagaraScalabilityUpdateFrequency_MAX = 5,
    }
    public enum ENiagaraCullReaction : int
    {
        Deactivate = 0,
        DeactivateImmediate = 1,
        DeactivateResume = 2,
        DeactivateImmediateResume = 3,
        ENiagaraCullReaction_MAX = 4,
    }
    public enum EParticleAllocationMode : int
    {
        AutomaticEstimate = 0,
        ManualEstimate = 1,
        EParticleAllocationMode_MAX = 2,
    }
    public enum EScriptExecutionMode : int
    {
        EveryParticle = 0,
        SpawnedParticles = 1,
        SingleParticle = 2,
        EScriptExecutionMode_MAX = 3,
    }
    public enum ENiagaraSortMode : int
    {
        None = 0,
        ViewDepth = 1,
        ViewDistance = 2,
        CustomAscending = 3,
        CustomDecending = 4,
        ENiagaraSortMode_MAX = 5,
    }
    public enum ENiagaraMeshLockedAxisSpace : int
    {
        Simulation = 0,
        World = 1,
        Local = 2,
        ENiagaraMeshLockedAxisSpace_MAX = 3,
    }
    public enum ENiagaraMeshPivotOffsetSpace : int
    {
        Mesh = 0,
        Simulation = 1,
        World = 2,
        Local = 3,
        ENiagaraMeshPivotOffsetSpace_MAX = 4,
    }
    public enum ENiagaraMeshFacingMode : int
    {
        Default = 0,
        Velocity = 1,
        CameraPosition = 2,
        CameraPlane = 3,
        ENiagaraMeshFacingMode_MAX = 4,
    }
    public enum ENiagaraPlatformSetState : int
    {
        Disabled = 0,
        Enabled = 1,
        Active = 2,
        Unknown = 3,
        ENiagaraPlatformSetState_MAX = 4,
    }
    public enum ENiagaraPlatformSelectionState : int
    {
        Default = 0,
        Enabled = 1,
        Disabled = 2,
        ENiagaraPlatformSelectionState_MAX = 3,
    }
    public enum ENiagaraPreviewGridResetMode : int
    {
        Never = 0,
        Individual = 1,
        All = 2,
        ENiagaraPreviewGridResetMode_MAX = 3,
    }
    public enum ENiagaraRibbonUVDistributionMode : int
    {
        ScaledUniformly = 0,
        ScaledUsingRibbonSegmentLength = 1,
        TiledOverRibbonLength = 2,
        ENiagaraRibbonUVDistributionMode_MAX = 3,
    }
    public enum ENiagaraRibbonUVEdgeMode : int
    {
        SmoothTransition = 0,
        Locked = 1,
        ENiagaraRibbonUVEdgeMode_MAX = 2,
    }
    public enum ENiagaraRibbonTessellationMode : int
    {
        Automatic = 0,
        Custom = 1,
        Disabled = 2,
        ENiagaraRibbonTessellationMode_MAX = 3,
    }
    public enum ENiagaraRibbonDrawDirection : int
    {
        FrontToBack = 0,
        BackToFront = 1,
        ENiagaraRibbonDrawDirection_MAX = 2,
    }
    public enum ENiagaraRibbonAgeOffsetMode : int
    {
        Scale = 0,
        Clip = 1,
        ENiagaraRibbonAgeOffsetMode_MAX = 2,
    }
    public enum ENiagaraRibbonFacingMode : int
    {
        Screen = 0,
        Custom = 1,
        CustomSideVector = 2,
        ENiagaraRibbonFacingMode_MAX = 3,
    }
    public enum ENiagaraScriptLibraryVisibility : int
    {
        Invalid = 0,
        Unexposed = 1,
        Library = 2,
        Hidden = 3,
        ENiagaraScriptLibraryVisibility_MAX = 4,
    }
    public enum ENiagaraModuleDependencyScriptConstraint : int
    {
        SameScript = 0,
        AllScripts = 1,
        ENiagaraModuleDependencyScriptConstraint_MAX = 2,
    }
    public enum ENiagaraModuleDependencyType : int
    {
        PreDependency = 0,
        PostDependency = 1,
        ENiagaraModuleDependencyType_MAX = 2,
    }
    public enum EUnusedAttributeBehaviour : int
    {
        Copy = 0,
        Zero = 1,
        None = 2,
        MarkInvalid = 3,
        PassThrough = 4,
        EUnusedAttributeBehaviour_MAX = 5,
    }
    public enum ENiagaraSpriteFacingMode : int
    {
        FaceCamera = 0,
        FaceCameraPlane = 1,
        CustomFacingVector = 2,
        FaceCameraPosition = 3,
        FaceCameraDistanceBlend = 4,
        ENiagaraSpriteFacingMode_MAX = 5,
    }
    public enum ENiagaraSpriteAlignment : int
    {
        Unaligned = 0,
        VelocityAligned = 1,
        CustomAlignment = 2,
        ENiagaraSpriteAlignment_MAX = 3,
    }
    public enum ENiagaraParameterPanelCategory : int
    {
        Input = 0,
        Attributes = 1,
        Output = 2,
        Local = 3,
        User = 4,
        Engine = 5,
        Owner = 6,
        System = 7,
        Emitter = 8,
        Particles = 9,
        ScriptTransient = 10,
        StaticSwitch = 11,
        None = 12,
        Num = 13,
        ENiagaraParameterPanelCategory_MAX = 14,
    }
    public enum ENiagaraScriptParameterUsage : int
    {
        Input = 0,
        Output = 1,
        Local = 2,
        InputOutput = 3,
        InitialValueInput = 4,
        None = 5,
        Num = 6,
        ENiagaraScriptParameterUsage_MAX = 7,
    }
    public enum ENiagaraParameterScope : int
    {
        Input = 0,
        User = 1,
        Engine = 2,
        Owner = 3,
        System = 4,
        Emitter = 5,
        Particles = 6,
        ScriptPersistent = 7,
        ScriptTransient = 8,
        Local = 9,
        Custom = 10,
        DISPLAY_ONLY_StaticSwitch = 11,
        Output = 12,
        None = 13,
        Num = 14,
        ENiagaraParameterScope_MAX = 15,
    }
    public enum ENiagaraExecutionState : int
    {
        Active = 0,
        Inactive = 1,
        InactiveClear = 2,
        Complete = 3,
        Disabled = 4,
        Num = 5,
        ENiagaraExecutionState_MAX = 6,
    }
    public enum ENiagaraExecutionStateSource : int
    {
        Scalability = 0,
        Internal = 1,
        Owner = 2,
        InternalCompletion = 3,
        ENiagaraExecutionStateSource_MAX = 4,
    }
    public enum ENiagaraNumericOutputTypeSelectionMode : int
    {
        None = 0,
        Largest = 1,
        Smallest = 2,
        Scalar = 3,
        ENiagaraNumericOutputTypeSelectionMode_MAX = 4,
    }
    public enum ENiagaraVariantMode : int
    {
        None = 0,
        Object = 1,
        DataInterface = 2,
        Bytes = 3,
        ENiagaraVariantMode_MAX = 4,
    }
    public class MovieSceneNiagaraParameterSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneNiagaraParameterSectionTemplate(ulong addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class NiagaraVariableBase : Object
    {
        public NiagaraVariableBase(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public NiagaraTypeDefinitionHandle TypeDefHandle { get { return this[nameof(TypeDefHandle)].As<NiagaraTypeDefinitionHandle>(); } set { this["TypeDefHandle"] = value; } }
    }
    public class NiagaraTypeDefinitionHandle : Object
    {
        public NiagaraTypeDefinitionHandle(ulong addr) : base(addr) { }
        public int RegisteredTypeIndex { get { return this[nameof(RegisteredTypeIndex)].GetValue<int>(); } set { this[nameof(RegisteredTypeIndex)].SetValue<int>(value); } }
    }
    public class NiagaraVariable : NiagaraVariableBase
    {
        public NiagaraVariable(ulong addr) : base(addr) { }
        public Array<byte> VarData { get { return new Array<byte>(this[nameof(VarData)].Address); } }
    }
    public class MovieSceneNiagaraBoolParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraBoolParameterSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneBoolChannel BoolChannel { get { return this[nameof(BoolChannel)].As<MovieSceneBoolChannel>(); } set { this["BoolChannel"] = value; } }
    }
    public class MovieSceneNiagaraColorParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraColorParameterSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel RedChannel { get { return this[nameof(RedChannel)].As<MovieSceneFloatChannel>(); } set { this["RedChannel"] = value; } }
        public MovieSceneFloatChannel GreenChannel { get { return this[nameof(GreenChannel)].As<MovieSceneFloatChannel>(); } set { this["GreenChannel"] = value; } }
        public MovieSceneFloatChannel BlueChannel { get { return this[nameof(BlueChannel)].As<MovieSceneFloatChannel>(); } set { this["BlueChannel"] = value; } }
        public MovieSceneFloatChannel AlphaChannel { get { return this[nameof(AlphaChannel)].As<MovieSceneFloatChannel>(); } set { this["AlphaChannel"] = value; } }
    }
    public class MovieSceneNiagaraFloatParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraFloatParameterSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel FloatChannel { get { return this[nameof(FloatChannel)].As<MovieSceneFloatChannel>(); } set { this["FloatChannel"] = value; } }
    }
    public class MovieSceneNiagaraIntegerParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraIntegerParameterSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneIntegerChannel IntegerChannel { get { return this[nameof(IntegerChannel)].As<MovieSceneIntegerChannel>(); } set { this["IntegerChannel"] = value; } }
    }
    public class MovieSceneNiagaraSystemTrackImplementation : MovieSceneTrackImplementation
    {
        public MovieSceneNiagaraSystemTrackImplementation(ulong addr) : base(addr) { }
        public FrameNumber SpawnSectionStartFrame { get { return this[nameof(SpawnSectionStartFrame)].As<FrameNumber>(); } set { this["SpawnSectionStartFrame"] = value; } }
        public FrameNumber SpawnSectionEndFrame { get { return this[nameof(SpawnSectionEndFrame)].As<FrameNumber>(); } set { this["SpawnSectionEndFrame"] = value; } }
        public ENiagaraSystemSpawnSectionStartBehavior SpawnSectionStartBehavior { get { return (ENiagaraSystemSpawnSectionStartBehavior)this[nameof(SpawnSectionStartBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionStartBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEvaluateBehavior SpawnSectionEvaluateBehavior { get { return (ENiagaraSystemSpawnSectionEvaluateBehavior)this[nameof(SpawnSectionEvaluateBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionEvaluateBehavior)].SetValue<int>((int)value); } }
        public ENiagaraSystemSpawnSectionEndBehavior SpawnSectionEndBehavior { get { return (ENiagaraSystemSpawnSectionEndBehavior)this[nameof(SpawnSectionEndBehavior)].GetValue<int>(); } set { this[nameof(SpawnSectionEndBehavior)].SetValue<int>((int)value); } }
        public ENiagaraAgeUpdateMode AgeUpdateMode { get { return (ENiagaraAgeUpdateMode)this[nameof(AgeUpdateMode)].GetValue<int>(); } set { this[nameof(AgeUpdateMode)].SetValue<int>((int)value); } }
    }
    public class MovieSceneNiagaraSystemTrackTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneNiagaraSystemTrackTemplate(ulong addr) : base(addr) { }
    }
    public class MovieSceneNiagaraVectorParameterSectionTemplate : MovieSceneNiagaraParameterSectionTemplate
    {
        public MovieSceneNiagaraVectorParameterSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneFloatChannel VectorChannels { get { return this[nameof(VectorChannels)].As<MovieSceneFloatChannel>(); } set { this["VectorChannels"] = value; } }
        public int ChannelsUsed { get { return this[nameof(ChannelsUsed)].GetValue<int>(); } set { this[nameof(ChannelsUsed)].SetValue<int>(value); } }
    }
    public class NiagaraRandInfo : Object
    {
        public NiagaraRandInfo(ulong addr) : base(addr) { }
        public int Seed1 { get { return this[nameof(Seed1)].GetValue<int>(); } set { this[nameof(Seed1)].SetValue<int>(value); } }
        public int Seed2 { get { return this[nameof(Seed2)].GetValue<int>(); } set { this[nameof(Seed2)].SetValue<int>(value); } }
        public int Seed3 { get { return this[nameof(Seed3)].GetValue<int>(); } set { this[nameof(Seed3)].SetValue<int>(value); } }
    }
    public class NiagaraUserParameterBinding : Object
    {
        public NiagaraUserParameterBinding(ulong addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
    }
    public class NiagaraScriptVariableBinding : Object
    {
        public NiagaraScriptVariableBinding(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class NiagaraVariableDataInterfaceBinding : Object
    {
        public NiagaraVariableDataInterfaceBinding(ulong addr) : base(addr) { }
        public NiagaraVariable BoundVariable { get { return this[nameof(BoundVariable)].As<NiagaraVariable>(); } set { this["BoundVariable"] = value; } }
    }
    public class NiagaraMaterialAttributeBinding : Object
    {
        public NiagaraMaterialAttributeBinding(ulong addr) : base(addr) { }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public NiagaraVariableBase NiagaraVariable { get { return this[nameof(NiagaraVariable)].As<NiagaraVariableBase>(); } set { this["NiagaraVariable"] = value; } }
        public NiagaraVariableBase ResolvedNiagaraVariable { get { return this[nameof(ResolvedNiagaraVariable)].As<NiagaraVariableBase>(); } set { this["ResolvedNiagaraVariable"] = value; } }
        public NiagaraVariableBase NiagaraChildVariable { get { return this[nameof(NiagaraChildVariable)].As<NiagaraVariableBase>(); } set { this["NiagaraChildVariable"] = value; } }
    }
    public class NiagaraVariableAttributeBinding : Object
    {
        public NiagaraVariableAttributeBinding(ulong addr) : base(addr) { }
        public NiagaraVariableBase ParamMapVariable { get { return this[nameof(ParamMapVariable)].As<NiagaraVariableBase>(); } set { this["ParamMapVariable"] = value; } }
        public NiagaraVariable DataSetVariable { get { return this[nameof(DataSetVariable)].As<NiagaraVariable>(); } set { this["DataSetVariable"] = value; } }
        public NiagaraVariable RootVariable { get { return this[nameof(RootVariable)].As<NiagaraVariable>(); } set { this["RootVariable"] = value; } }
        public byte BindingSourceMode { get { return this[nameof(BindingSourceMode)].GetValue<byte>(); } set { this[nameof(BindingSourceMode)].SetValue<byte>(value); } }
        public bool bBindingExistsOnSource { get { return this[nameof(bBindingExistsOnSource)].Flag; } set { this[nameof(bBindingExistsOnSource)].Flag = value; } }
        public bool bIsCachedParticleValue { get { return this[nameof(bIsCachedParticleValue)].Flag; } set { this[nameof(bIsCachedParticleValue)].Flag = value; } }
    }
    public class NiagaraVariableInfo : Object
    {
        public NiagaraVariableInfo(ulong addr) : base(addr) { }
        public NiagaraVariable Variable { get { return this[nameof(Variable)].As<NiagaraVariable>(); } set { this["Variable"] = value; } }
        public Object Definition { get { return this[nameof(Definition)]; } set { this[nameof(Definition)] = value; } }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
    }
    public class NiagaraSystemUpdateContext : Object
    {
        public NiagaraSystemUpdateContext(ulong addr) : base(addr) { }
        public Array<NiagaraComponent> ComponentsToReset { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToReset)].Address); } }
        public Array<NiagaraComponent> ComponentsToReInit { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToReInit)].Address); } }
        public Array<NiagaraComponent> ComponentsToNotifySimDestroy { get { return new Array<NiagaraComponent>(this[nameof(ComponentsToNotifySimDestroy)].Address); } }
        public Array<NiagaraSystem> SystemSimsToDestroy { get { return new Array<NiagaraSystem>(this[nameof(SystemSimsToDestroy)].Address); } }
    }
    public class VMExternalFunctionBindingInfo : Object
    {
        public VMExternalFunctionBindingInfo(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object OwnerName { get { return this[nameof(OwnerName)]; } set { this[nameof(OwnerName)] = value; } }
        public Array<bool> InputParamLocations { get { return new Array<bool>(this[nameof(InputParamLocations)].Address); } }
        public int NumOutputs { get { return this[nameof(NumOutputs)].GetValue<int>(); } set { this[nameof(NumOutputs)].SetValue<int>(value); } }
        public Array<VMFunctionSpecifier> FunctionSpecifiers { get { return new Array<VMFunctionSpecifier>(this[nameof(FunctionSpecifiers)].Address); } }
    }
    public class VMFunctionSpecifier : Object
    {
        public VMFunctionSpecifier(ulong addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class NiagaraStatScope : Object
    {
        public NiagaraStatScope(ulong addr) : base(addr) { }
        public Object FullName { get { return this[nameof(FullName)]; } set { this[nameof(FullName)] = value; } }
        public Object FriendlyName { get { return this[nameof(FriendlyName)]; } set { this[nameof(FriendlyName)] = value; } }
    }
    public class NiagaraScriptDataInterfaceCompileInfo : Object
    {
        public NiagaraScriptDataInterfaceCompileInfo(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int UserPtrIdx { get { return this[nameof(UserPtrIdx)].GetValue<int>(); } set { this[nameof(UserPtrIdx)].SetValue<int>(value); } }
        public NiagaraTypeDefinition Type { get { return this[nameof(Type)].As<NiagaraTypeDefinition>(); } set { this["Type"] = value; } }
        public Object RegisteredParameterMapRead { get { return this[nameof(RegisteredParameterMapRead)]; } set { this[nameof(RegisteredParameterMapRead)] = value; } }
        public Object RegisteredParameterMapWrite { get { return this[nameof(RegisteredParameterMapWrite)]; } set { this[nameof(RegisteredParameterMapWrite)] = value; } }
        public bool bIsPlaceholder { get { return this[nameof(bIsPlaceholder)].Flag; } set { this[nameof(bIsPlaceholder)].Flag = value; } }
    }
    public class NiagaraTypeDefinition : Object
    {
        public NiagaraTypeDefinition(ulong addr) : base(addr) { }
        public Object ClassStructOrEnum { get { return this[nameof(ClassStructOrEnum)].As<Object>(); } set { this["ClassStructOrEnum"] = value; } }
        public ushort UnderlyingType { get { return this[nameof(UnderlyingType)].GetValue<ushort>(); } set { this[nameof(UnderlyingType)].SetValue<ushort>(value); } }
    }
    public class NiagaraScriptDataInterfaceInfo : Object
    {
        public NiagaraScriptDataInterfaceInfo(ulong addr) : base(addr) { }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int UserPtrIdx { get { return this[nameof(UserPtrIdx)].GetValue<int>(); } set { this[nameof(UserPtrIdx)].SetValue<int>(value); } }
        public NiagaraTypeDefinition Type { get { return this[nameof(Type)].As<NiagaraTypeDefinition>(); } set { this["Type"] = value; } }
        public Object RegisteredParameterMapRead { get { return this[nameof(RegisteredParameterMapRead)]; } set { this[nameof(RegisteredParameterMapRead)] = value; } }
        public Object RegisteredParameterMapWrite { get { return this[nameof(RegisteredParameterMapWrite)]; } set { this[nameof(RegisteredParameterMapWrite)] = value; } }
    }
    public class NiagaraFunctionSignature : Object
    {
        public NiagaraFunctionSignature(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Array<NiagaraVariable> Inputs { get { return new Array<NiagaraVariable>(this[nameof(Inputs)].Address); } }
        public Array<NiagaraVariable> Outputs { get { return new Array<NiagaraVariable>(this[nameof(Outputs)].Address); } }
        public Object OwnerName { get { return this[nameof(OwnerName)]; } set { this[nameof(OwnerName)] = value; } }
        public bool bRequiresContext { get { return this[nameof(bRequiresContext)].Flag; } set { this[nameof(bRequiresContext)].Flag = value; } }
        public bool bRequiresExecPin { get { return this[nameof(bRequiresExecPin)].Flag; } set { this[nameof(bRequiresExecPin)].Flag = value; } }
        public bool bMemberFunction { get { return this[nameof(bMemberFunction)].Flag; } set { this[nameof(bMemberFunction)].Flag = value; } }
        public bool bExperimental { get { return this[nameof(bExperimental)].Flag; } set { this[nameof(bExperimental)].Flag = value; } }
        public bool bSupportsCPU { get { return this[nameof(bSupportsCPU)].Flag; } set { this[nameof(bSupportsCPU)].Flag = value; } }
        public bool bSupportsGPU { get { return this[nameof(bSupportsGPU)].Flag; } set { this[nameof(bSupportsGPU)].Flag = value; } }
        public bool bWriteFunction { get { return this[nameof(bWriteFunction)].Flag; } set { this[nameof(bWriteFunction)].Flag = value; } }
        public bool bSoftDeprecatedFunction { get { return this[nameof(bSoftDeprecatedFunction)].Flag; } set { this[nameof(bSoftDeprecatedFunction)].Flag = value; } }
        public int ModuleUsageBitmask { get { return this[nameof(ModuleUsageBitmask)].GetValue<int>(); } set { this[nameof(ModuleUsageBitmask)].SetValue<int>(value); } }
        public int ContextStageMinIndex { get { return this[nameof(ContextStageMinIndex)].GetValue<int>(); } set { this[nameof(ContextStageMinIndex)].SetValue<int>(value); } }
        public int ContextStageMaxIndex { get { return this[nameof(ContextStageMaxIndex)].GetValue<int>(); } set { this[nameof(ContextStageMaxIndex)].SetValue<int>(value); } }
        public Object FunctionSpecifiers { get { return this[nameof(FunctionSpecifiers)]; } set { this[nameof(FunctionSpecifiers)] = value; } }
    }
    public class NiagaraScriptDataUsageInfo : Object
    {
        public NiagaraScriptDataUsageInfo(ulong addr) : base(addr) { }
        public bool bReadsAttributeData { get { return this[nameof(bReadsAttributeData)].Flag; } set { this[nameof(bReadsAttributeData)].Flag = value; } }
    }
    public class NiagaraDataSetProperties : Object
    {
        public NiagaraDataSetProperties(ulong addr) : base(addr) { }
        public NiagaraDataSetID ID { get { return this[nameof(ID)].As<NiagaraDataSetID>(); } set { this["ID"] = value; } }
        public Array<NiagaraVariable> Variables { get { return new Array<NiagaraVariable>(this[nameof(Variables)].Address); } }
    }
    public class NiagaraDataSetID : Object
    {
        public NiagaraDataSetID(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public ENiagaraDataSetType Type { get { return (ENiagaraDataSetType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class NiagaraMaterialOverride : Object
    {
        public NiagaraMaterialOverride(ulong addr) : base(addr) { }
        public MaterialInterface Material { get { return this[nameof(Material)].As<MaterialInterface>(); } set { this["Material"] = value; } }
        public uint MaterialSubIndex { get { return this[nameof(MaterialSubIndex)].GetValue<uint>(); } set { this[nameof(MaterialSubIndex)].SetValue<uint>(value); } }
        public NiagaraRendererProperties EmitterRendererProperty { get { return this[nameof(EmitterRendererProperty)].As<NiagaraRendererProperties>(); } set { this["EmitterRendererProperty"] = value; } }
    }
    public class NCPool : Object
    {
        public NCPool(ulong addr) : base(addr) { }
        public Array<NCPoolElement> FreeElements { get { return new Array<NCPoolElement>(this[nameof(FreeElements)].Address); } }
        public Array<NiagaraComponent> InUseComponents_Auto { get { return new Array<NiagaraComponent>(this[nameof(InUseComponents_Auto)].Address); } }
        public Array<NiagaraComponent> InUseComponents_Manual { get { return new Array<NiagaraComponent>(this[nameof(InUseComponents_Manual)].Address); } }
    }
    public class NCPoolElement : Object
    {
        public NCPoolElement(ulong addr) : base(addr) { }
        public NiagaraComponent Component { get { return this[nameof(Component)].As<NiagaraComponent>(); } set { this["Component"] = value; } }
    }
    public class NiagaraComponentPropertyBinding : Object
    {
        public NiagaraComponentPropertyBinding(ulong addr) : base(addr) { }
        public NiagaraVariableAttributeBinding AttributeBinding { get { return this[nameof(AttributeBinding)].As<NiagaraVariableAttributeBinding>(); } set { this["AttributeBinding"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public NiagaraTypeDefinition PropertyType { get { return this[nameof(PropertyType)].As<NiagaraTypeDefinition>(); } set { this["PropertyType"] = value; } }
        public Object MetadataSetterName { get { return this[nameof(MetadataSetterName)]; } set { this[nameof(MetadataSetterName)] = value; } }
        public NiagaraVariable WritableValue { get { return this[nameof(WritableValue)].As<NiagaraVariable>(); } set { this["WritableValue"] = value; } }
    }
    public class NiagaraEmitterNameSettingsRef : Object
    {
        public NiagaraEmitterNameSettingsRef(ulong addr) : base(addr) { }
        public Object SystemName { get { return this[nameof(SystemName)]; } set { this[nameof(SystemName)] = value; } }
        public Object EmitterName { get { return this[nameof(EmitterName)]; } set { this[nameof(EmitterName)] = value; } }
    }
    public class BasicParticleData : Object
    {
        public BasicParticleData(ulong addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public float Size { get { return this[nameof(Size)].GetValue<float>(); } set { this[nameof(Size)].SetValue<float>(value); } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
    }
    public class MeshTriCoordinate : Object
    {
        public MeshTriCoordinate(ulong addr) : base(addr) { }
        public int Tri { get { return this[nameof(Tri)].GetValue<int>(); } set { this[nameof(Tri)].SetValue<int>(value); } }
        public Vector BaryCoord { get { return this[nameof(BaryCoord)].As<Vector>(); } set { this["BaryCoord"] = value; } }
    }
    public class NDIStaticMeshSectionFilter : Object
    {
        public NDIStaticMeshSectionFilter(ulong addr) : base(addr) { }
        public Array<int> AllowedMaterialSlots { get { return new Array<int>(this[nameof(AllowedMaterialSlots)].Address); } }
    }
    public class NiagaraDataSetCompiledData : Object
    {
        public NiagaraDataSetCompiledData(ulong addr) : base(addr) { }
        public Array<NiagaraVariable> Variables { get { return new Array<NiagaraVariable>(this[nameof(Variables)].Address); } }
        public Array<NiagaraVariableLayoutInfo> VariableLayouts { get { return new Array<NiagaraVariableLayoutInfo>(this[nameof(VariableLayouts)].Address); } }
        public NiagaraDataSetID ID { get { return this[nameof(ID)].As<NiagaraDataSetID>(); } set { this["ID"] = value; } }
        public uint TotalFloatComponents { get { return this[nameof(TotalFloatComponents)].GetValue<uint>(); } set { this[nameof(TotalFloatComponents)].SetValue<uint>(value); } }
        public uint TotalInt32Components { get { return this[nameof(TotalInt32Components)].GetValue<uint>(); } set { this[nameof(TotalInt32Components)].SetValue<uint>(value); } }
        public uint TotalHalfComponents { get { return this[nameof(TotalHalfComponents)].GetValue<uint>(); } set { this[nameof(TotalHalfComponents)].SetValue<uint>(value); } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public ENiagaraSimTarget SimTarget { get { return (ENiagaraSimTarget)this[nameof(SimTarget)].GetValue<int>(); } set { this[nameof(SimTarget)].SetValue<int>((int)value); } }
    }
    public class NiagaraVariableLayoutInfo : Object
    {
        public NiagaraVariableLayoutInfo(ulong addr) : base(addr) { }
        public uint FloatComponentStart { get { return this[nameof(FloatComponentStart)].GetValue<uint>(); } set { this[nameof(FloatComponentStart)].SetValue<uint>(value); } }
        public uint Int32ComponentStart { get { return this[nameof(Int32ComponentStart)].GetValue<uint>(); } set { this[nameof(Int32ComponentStart)].SetValue<uint>(value); } }
        public uint HalfComponentStart { get { return this[nameof(HalfComponentStart)].GetValue<uint>(); } set { this[nameof(HalfComponentStart)].SetValue<uint>(value); } }
        public NiagaraTypeLayoutInfo LayoutInfo { get { return this[nameof(LayoutInfo)].As<NiagaraTypeLayoutInfo>(); } set { this["LayoutInfo"] = value; } }
    }
    public class NiagaraTypeLayoutInfo : Object
    {
        public NiagaraTypeLayoutInfo(ulong addr) : base(addr) { }
        public Array<uint> FloatComponentByteOffsets { get { return new Array<uint>(this[nameof(FloatComponentByteOffsets)].Address); } }
        public Array<uint> FloatComponentRegisterOffsets { get { return new Array<uint>(this[nameof(FloatComponentRegisterOffsets)].Address); } }
        public Array<uint> Int32ComponentByteOffsets { get { return new Array<uint>(this[nameof(Int32ComponentByteOffsets)].Address); } }
        public Array<uint> Int32ComponentRegisterOffsets { get { return new Array<uint>(this[nameof(Int32ComponentRegisterOffsets)].Address); } }
        public Array<uint> HalfComponentByteOffsets { get { return new Array<uint>(this[nameof(HalfComponentByteOffsets)].Address); } }
        public Array<uint> HalfComponentRegisterOffsets { get { return new Array<uint>(this[nameof(HalfComponentRegisterOffsets)].Address); } }
    }
    public class NiagaraGraphViewSettings : Object
    {
        public NiagaraGraphViewSettings(ulong addr) : base(addr) { }
        public Vector2D Location { get { return this[nameof(Location)].As<Vector2D>(); } set { this["Location"] = value; } }
        public float Zoom { get { return this[nameof(Zoom)].GetValue<float>(); } set { this[nameof(Zoom)].SetValue<float>(value); } }
        public bool bIsValid { get { return this[nameof(bIsValid)].Flag; } set { this[nameof(bIsValid)].Flag = value; } }
    }
    public class NiagaraEmitterScalabilityOverrides : Object
    {
        public NiagaraEmitterScalabilityOverrides(ulong addr) : base(addr) { }
        public Array<NiagaraEmitterScalabilityOverride> Overrides { get { return new Array<NiagaraEmitterScalabilityOverride>(this[nameof(Overrides)].Address); } }
    }
    public class NiagaraEmitterScalabilitySettings : Object
    {
        public NiagaraEmitterScalabilitySettings(ulong addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public bool bScaleSpawnCount { get { return this[nameof(bScaleSpawnCount)].Flag; } set { this[nameof(bScaleSpawnCount)].Flag = value; } }
        public float SpawnCountScale { get { return this[nameof(SpawnCountScale)].GetValue<float>(); } set { this[nameof(SpawnCountScale)].SetValue<float>(value); } }
    }
    public class NiagaraPlatformSet : Object
    {
        public NiagaraPlatformSet(ulong addr) : base(addr) { }
        public int QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<int>(); } set { this[nameof(QualityLevelMask)].SetValue<int>(value); } }
        public Array<NiagaraDeviceProfileStateEntry> DeviceProfileStates { get { return new Array<NiagaraDeviceProfileStateEntry>(this[nameof(DeviceProfileStates)].Address); } }
        public Array<NiagaraPlatformSetCVarCondition> CVarConditions { get { return new Array<NiagaraPlatformSetCVarCondition>(this[nameof(CVarConditions)].Address); } }
    }
    public class NiagaraPlatformSetCVarCondition : Object
    {
        public NiagaraPlatformSetCVarCondition(ulong addr) : base(addr) { }
        public Object CVarName { get { return this[nameof(CVarName)]; } set { this[nameof(CVarName)] = value; } }
        public bool Value { get { return this[nameof(Value)].Flag; } set { this[nameof(Value)].Flag = value; } }
        public int MinInt { get { return this[nameof(MinInt)].GetValue<int>(); } set { this[nameof(MinInt)].SetValue<int>(value); } }
        public int MaxInt { get { return this[nameof(MaxInt)].GetValue<int>(); } set { this[nameof(MaxInt)].SetValue<int>(value); } }
        public float MinFloat { get { return this[nameof(MinFloat)].GetValue<float>(); } set { this[nameof(MinFloat)].SetValue<float>(value); } }
        public float MaxFloat { get { return this[nameof(MaxFloat)].GetValue<float>(); } set { this[nameof(MaxFloat)].SetValue<float>(value); } }
        public bool bUseMinInt { get { return this[nameof(bUseMinInt)].Flag; } set { this[nameof(bUseMinInt)].Flag = value; } }
        public bool bUseMaxInt { get { return this[nameof(bUseMaxInt)].Flag; } set { this[nameof(bUseMaxInt)].Flag = value; } }
        public bool bUseMinFloat { get { return this[nameof(bUseMinFloat)].Flag; } set { this[nameof(bUseMinFloat)].Flag = value; } }
        public bool bUseMaxFloat { get { return this[nameof(bUseMaxFloat)].Flag; } set { this[nameof(bUseMaxFloat)].Flag = value; } }
    }
    public class NiagaraDeviceProfileStateEntry : Object
    {
        public NiagaraDeviceProfileStateEntry(ulong addr) : base(addr) { }
        public Object ProfileName { get { return this[nameof(ProfileName)]; } set { this[nameof(ProfileName)] = value; } }
        public uint QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<uint>(); } set { this[nameof(QualityLevelMask)].SetValue<uint>(value); } }
        public uint SetQualityLevelMask { get { return this[nameof(SetQualityLevelMask)].GetValue<uint>(); } set { this[nameof(SetQualityLevelMask)].SetValue<uint>(value); } }
    }
    public class NiagaraEmitterScalabilityOverride : NiagaraEmitterScalabilitySettings
    {
        public NiagaraEmitterScalabilityOverride(ulong addr) : base(addr) { }
        public bool bOverrideSpawnCountScale { get { return this[nameof(bOverrideSpawnCountScale)].Flag; } set { this[nameof(bOverrideSpawnCountScale)].Flag = value; } }
    }
    public class NiagaraEmitterScalabilitySettingsArray : Object
    {
        public NiagaraEmitterScalabilitySettingsArray(ulong addr) : base(addr) { }
        public Array<NiagaraEmitterScalabilitySettings> Settings { get { return new Array<NiagaraEmitterScalabilitySettings>(this[nameof(Settings)].Address); } }
    }
    public class NiagaraSystemScalabilityOverrides : Object
    {
        public NiagaraSystemScalabilityOverrides(ulong addr) : base(addr) { }
        public Array<NiagaraSystemScalabilityOverride> Overrides { get { return new Array<NiagaraSystemScalabilityOverride>(this[nameof(Overrides)].Address); } }
    }
    public class NiagaraSystemScalabilitySettings : Object
    {
        public NiagaraSystemScalabilitySettings(ulong addr) : base(addr) { }
        public NiagaraPlatformSet Platforms { get { return this[nameof(Platforms)].As<NiagaraPlatformSet>(); } set { this["Platforms"] = value; } }
        public bool bCullByDistance { get { return this[nameof(bCullByDistance)].Flag; } set { this[nameof(bCullByDistance)].Flag = value; } }
        public bool bCullMaxInstanceCount { get { return this[nameof(bCullMaxInstanceCount)].Flag; } set { this[nameof(bCullMaxInstanceCount)].Flag = value; } }
        public bool bCullPerSystemMaxInstanceCount { get { return this[nameof(bCullPerSystemMaxInstanceCount)].Flag; } set { this[nameof(bCullPerSystemMaxInstanceCount)].Flag = value; } }
        public bool bCullByMaxTimeWithoutRender { get { return this[nameof(bCullByMaxTimeWithoutRender)].Flag; } set { this[nameof(bCullByMaxTimeWithoutRender)].Flag = value; } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public int MaxInstances { get { return this[nameof(MaxInstances)].GetValue<int>(); } set { this[nameof(MaxInstances)].SetValue<int>(value); } }
        public int MaxSystemInstances { get { return this[nameof(MaxSystemInstances)].GetValue<int>(); } set { this[nameof(MaxSystemInstances)].SetValue<int>(value); } }
        public float MaxTimeWithoutRender { get { return this[nameof(MaxTimeWithoutRender)].GetValue<float>(); } set { this[nameof(MaxTimeWithoutRender)].SetValue<float>(value); } }
    }
    public class NiagaraSystemScalabilityOverride : NiagaraSystemScalabilitySettings
    {
        public NiagaraSystemScalabilityOverride(ulong addr) : base(addr) { }
        public bool bOverrideDistanceSettings { get { return this[nameof(bOverrideDistanceSettings)].Flag; } set { this[nameof(bOverrideDistanceSettings)].Flag = value; } }
        public bool bOverrideInstanceCountSettings { get { return this[nameof(bOverrideInstanceCountSettings)].Flag; } set { this[nameof(bOverrideInstanceCountSettings)].Flag = value; } }
        public bool bOverridePerSystemInstanceCountSettings { get { return this[nameof(bOverridePerSystemInstanceCountSettings)].Flag; } set { this[nameof(bOverridePerSystemInstanceCountSettings)].Flag = value; } }
        public bool bOverrideTimeSinceRendererSettings { get { return this[nameof(bOverrideTimeSinceRendererSettings)].Flag; } set { this[nameof(bOverrideTimeSinceRendererSettings)].Flag = value; } }
    }
    public class NiagaraSystemScalabilitySettingsArray : Object
    {
        public NiagaraSystemScalabilitySettingsArray(ulong addr) : base(addr) { }
        public Array<NiagaraSystemScalabilitySettings> Settings { get { return new Array<NiagaraSystemScalabilitySettings>(this[nameof(Settings)].Address); } }
    }
    public class NiagaraDetailsLevelScaleOverrides : Object
    {
        public NiagaraDetailsLevelScaleOverrides(ulong addr) : base(addr) { }
        public float Low { get { return this[nameof(Low)].GetValue<float>(); } set { this[nameof(Low)].SetValue<float>(value); } }
        public float Medium { get { return this[nameof(Medium)].GetValue<float>(); } set { this[nameof(Medium)].SetValue<float>(value); } }
        public float High { get { return this[nameof(High)].GetValue<float>(); } set { this[nameof(High)].SetValue<float>(value); } }
        public float Epic { get { return this[nameof(Epic)].GetValue<float>(); } set { this[nameof(Epic)].SetValue<float>(value); } }
        public float Cine { get { return this[nameof(Cine)].GetValue<float>(); } set { this[nameof(Cine)].SetValue<float>(value); } }
    }
    public class NiagaraEmitterScriptProperties : Object
    {
        public NiagaraEmitterScriptProperties(ulong addr) : base(addr) { }
        public NiagaraScript Script { get { return this[nameof(Script)].As<NiagaraScript>(); } set { this["Script"] = value; } }
        public Array<NiagaraEventReceiverProperties> EventReceivers { get { return new Array<NiagaraEventReceiverProperties>(this[nameof(EventReceivers)].Address); } }
        public Array<NiagaraEventGeneratorProperties> EventGenerators { get { return new Array<NiagaraEventGeneratorProperties>(this[nameof(EventGenerators)].Address); } }
    }
    public class NiagaraEventGeneratorProperties : Object
    {
        public NiagaraEventGeneratorProperties(ulong addr) : base(addr) { }
        public int MaxEventsPerFrame { get { return this[nameof(MaxEventsPerFrame)].GetValue<int>(); } set { this[nameof(MaxEventsPerFrame)].SetValue<int>(value); } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
    }
    public class NiagaraEventReceiverProperties : Object
    {
        public NiagaraEventReceiverProperties(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object SourceEventGenerator { get { return this[nameof(SourceEventGenerator)]; } set { this[nameof(SourceEventGenerator)] = value; } }
        public Object SourceEmitter { get { return this[nameof(SourceEmitter)]; } set { this[nameof(SourceEmitter)] = value; } }
    }
    public class NiagaraEventScriptProperties : NiagaraEmitterScriptProperties
    {
        public NiagaraEventScriptProperties(ulong addr) : base(addr) { }
        public EScriptExecutionMode ExecutionMode { get { return (EScriptExecutionMode)this[nameof(ExecutionMode)].GetValue<int>(); } set { this[nameof(ExecutionMode)].SetValue<int>((int)value); } }
        public uint SpawnNumber { get { return this[nameof(SpawnNumber)].GetValue<uint>(); } set { this[nameof(SpawnNumber)].SetValue<uint>(value); } }
        public uint MaxEventsPerFrame { get { return this[nameof(MaxEventsPerFrame)].GetValue<uint>(); } set { this[nameof(MaxEventsPerFrame)].SetValue<uint>(value); } }
        public Guid SourceEmitterID { get { return this[nameof(SourceEmitterID)].As<Guid>(); } set { this["SourceEmitterID"] = value; } }
        public Object SourceEventName { get { return this[nameof(SourceEventName)]; } set { this[nameof(SourceEventName)] = value; } }
        public bool bRandomSpawnNumber { get { return this[nameof(bRandomSpawnNumber)].Flag; } set { this[nameof(bRandomSpawnNumber)].Flag = value; } }
        public uint MinSpawnNumber { get { return this[nameof(MinSpawnNumber)].GetValue<uint>(); } set { this[nameof(MinSpawnNumber)].SetValue<uint>(value); } }
    }
    public class NiagaraEmitterHandle : Object
    {
        public NiagaraEmitterHandle(ulong addr) : base(addr) { }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Object IdName { get { return this[nameof(IdName)]; } set { this[nameof(IdName)] = value; } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public NiagaraEmitter Instance { get { return this[nameof(Instance)].As<NiagaraEmitter>(); } set { this["Instance"] = value; } }
    }
    public class NiagaraCollisionEventPayload : Object
    {
        public NiagaraCollisionEventPayload(ulong addr) : base(addr) { }
        public Vector CollisionPos { get { return this[nameof(CollisionPos)].As<Vector>(); } set { this["CollisionPos"] = value; } }
        public Vector CollisionNormal { get { return this[nameof(CollisionNormal)].As<Vector>(); } set { this["CollisionNormal"] = value; } }
        public Vector CollisionVelocity { get { return this[nameof(CollisionVelocity)].As<Vector>(); } set { this["CollisionVelocity"] = value; } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int PhysicalMaterialIndex { get { return this[nameof(PhysicalMaterialIndex)].GetValue<int>(); } set { this[nameof(PhysicalMaterialIndex)].SetValue<int>(value); } }
    }
    public class NiagaraMeshMaterialOverride : Object
    {
        public NiagaraMeshMaterialOverride(ulong addr) : base(addr) { }
        public MaterialInterface ExplicitMat { get { return this[nameof(ExplicitMat)].As<MaterialInterface>(); } set { this["ExplicitMat"] = value; } }
        public NiagaraUserParameterBinding UserParamBinding { get { return this[nameof(UserParamBinding)].As<NiagaraUserParameterBinding>(); } set { this["UserParamBinding"] = value; } }
    }
    public class NiagaraParameters : Object
    {
        public NiagaraParameters(ulong addr) : base(addr) { }
        public Array<NiagaraVariable> Parameters { get { return new Array<NiagaraVariable>(this[nameof(Parameters)].Address); } }
    }
    public class NiagaraParameterStore : Object
    {
        public NiagaraParameterStore(ulong addr) : base(addr) { }
        public Object Owner { get { return this[nameof(Owner)].As<Object>(); } set { this["Owner"] = value; } }
        public Array<NiagaraVariableWithOffset> SortedParameterOffsets { get { return new Array<NiagaraVariableWithOffset>(this[nameof(SortedParameterOffsets)].Address); } }
        public Array<byte> ParameterData { get { return new Array<byte>(this[nameof(ParameterData)].Address); } }
        public Array<NiagaraDataInterface> DataInterfaces { get { return new Array<NiagaraDataInterface>(this[nameof(DataInterfaces)].Address); } }
        public Array<Object> UObjects { get { return new Array<Object>(this[nameof(UObjects)].Address); } }
    }
    public class NiagaraVariableWithOffset : NiagaraVariableBase
    {
        public NiagaraVariableWithOffset(ulong addr) : base(addr) { }
        public int Offset { get { return this[nameof(Offset)].GetValue<int>(); } set { this[nameof(Offset)].SetValue<int>(value); } }
    }
    public class NiagaraBoundParameter : Object
    {
        public NiagaraBoundParameter(ulong addr) : base(addr) { }
        public NiagaraVariable Parameter { get { return this[nameof(Parameter)].As<NiagaraVariable>(); } set { this["Parameter"] = value; } }
        public int SrcOffset { get { return this[nameof(SrcOffset)].GetValue<int>(); } set { this[nameof(SrcOffset)].SetValue<int>(value); } }
        public int DestOffset { get { return this[nameof(DestOffset)].GetValue<int>(); } set { this[nameof(DestOffset)].SetValue<int>(value); } }
    }
    public class NiagaraPlatformSetConflictInfo : Object
    {
        public NiagaraPlatformSetConflictInfo(ulong addr) : base(addr) { }
        public int SetAIndex { get { return this[nameof(SetAIndex)].GetValue<int>(); } set { this[nameof(SetAIndex)].SetValue<int>(value); } }
        public int SetBIndex { get { return this[nameof(SetBIndex)].GetValue<int>(); } set { this[nameof(SetBIndex)].SetValue<int>(value); } }
        public Array<NiagaraPlatformSetConflictEntry> Conflicts { get { return new Array<NiagaraPlatformSetConflictEntry>(this[nameof(Conflicts)].Address); } }
    }
    public class NiagaraPlatformSetConflictEntry : Object
    {
        public NiagaraPlatformSetConflictEntry(ulong addr) : base(addr) { }
        public Object ProfileName { get { return this[nameof(ProfileName)]; } set { this[nameof(ProfileName)] = value; } }
        public int QualityLevelMask { get { return this[nameof(QualityLevelMask)].GetValue<int>(); } set { this[nameof(QualityLevelMask)].SetValue<int>(value); } }
    }
    public class NiagaraRibbonUVSettings : Object
    {
        public NiagaraRibbonUVSettings(ulong addr) : base(addr) { }
        public ENiagaraRibbonUVEdgeMode LeadingEdgeMode { get { return (ENiagaraRibbonUVEdgeMode)this[nameof(LeadingEdgeMode)].GetValue<int>(); } set { this[nameof(LeadingEdgeMode)].SetValue<int>((int)value); } }
        public ENiagaraRibbonUVEdgeMode TrailingEdgeMode { get { return (ENiagaraRibbonUVEdgeMode)this[nameof(TrailingEdgeMode)].GetValue<int>(); } set { this[nameof(TrailingEdgeMode)].SetValue<int>((int)value); } }
        public ENiagaraRibbonUVDistributionMode DistributionMode { get { return (ENiagaraRibbonUVDistributionMode)this[nameof(DistributionMode)].GetValue<int>(); } set { this[nameof(DistributionMode)].SetValue<int>((int)value); } }
        public float TilingLength { get { return this[nameof(TilingLength)].GetValue<float>(); } set { this[nameof(TilingLength)].SetValue<float>(value); } }
        public Vector2D Offset { get { return this[nameof(Offset)].As<Vector2D>(); } set { this["Offset"] = value; } }
        public Vector2D Scale { get { return this[nameof(Scale)].As<Vector2D>(); } set { this["Scale"] = value; } }
        public bool bEnablePerParticleUOverride { get { return this[nameof(bEnablePerParticleUOverride)].Flag; } set { this[nameof(bEnablePerParticleUOverride)].Flag = value; } }
        public bool bEnablePerParticleVRangeOverride { get { return this[nameof(bEnablePerParticleVRangeOverride)].Flag; } set { this[nameof(bEnablePerParticleVRangeOverride)].Flag = value; } }
    }
    public class NiagaraScalabilityManager : Object
    {
        public NiagaraScalabilityManager(ulong addr) : base(addr) { }
        public NiagaraEffectType EffectType { get { return this[nameof(EffectType)].As<NiagaraEffectType>(); } set { this["EffectType"] = value; } }
        public Array<NiagaraComponent> ManagedComponents { get { return new Array<NiagaraComponent>(this[nameof(ManagedComponents)].Address); } }
    }
    public class NiagaraVMExecutableData : Object
    {
        public NiagaraVMExecutableData(ulong addr) : base(addr) { }
        public Array<byte> ByteCode { get { return new Array<byte>(this[nameof(ByteCode)].Address); } }
        public Array<byte> OptimizedByteCode { get { return new Array<byte>(this[nameof(OptimizedByteCode)].Address); } }
        public int NumTempRegisters { get { return this[nameof(NumTempRegisters)].GetValue<int>(); } set { this[nameof(NumTempRegisters)].SetValue<int>(value); } }
        public int NumUserPtrs { get { return this[nameof(NumUserPtrs)].GetValue<int>(); } set { this[nameof(NumUserPtrs)].SetValue<int>(value); } }
        public Array<byte> ScriptLiterals { get { return new Array<byte>(this[nameof(ScriptLiterals)].Address); } }
        public Array<NiagaraVariable> Attributes { get { return new Array<NiagaraVariable>(this[nameof(Attributes)].Address); } }
        public NiagaraScriptDataUsageInfo DataUsage { get { return this[nameof(DataUsage)].As<NiagaraScriptDataUsageInfo>(); } set { this["DataUsage"] = value; } }
        public Array<NiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo { get { return new Array<NiagaraScriptDataInterfaceCompileInfo>(this[nameof(DataInterfaceInfo)].Address); } }
        public Array<VMExternalFunctionBindingInfo> CalledVMExternalFunctions { get { return new Array<VMExternalFunctionBindingInfo>(this[nameof(CalledVMExternalFunctions)].Address); } }
        public Array<NiagaraDataSetID> ReadDataSets { get { return new Array<NiagaraDataSetID>(this[nameof(ReadDataSets)].Address); } }
        public Array<NiagaraDataSetProperties> WriteDataSets { get { return new Array<NiagaraDataSetProperties>(this[nameof(WriteDataSets)].Address); } }
        public Array<NiagaraStatScope> StatScopes { get { return new Array<NiagaraStatScope>(this[nameof(StatScopes)].Address); } }
        public Array<NiagaraDataInterfaceGPUParamInfo> DIParamInfo { get { return new Array<NiagaraDataInterfaceGPUParamInfo>(this[nameof(DIParamInfo)].Address); } }
        public ENiagaraScriptCompileStatus LastCompileStatus { get { return (ENiagaraScriptCompileStatus)this[nameof(LastCompileStatus)].GetValue<int>(); } set { this[nameof(LastCompileStatus)].SetValue<int>((int)value); } }
        public Array<SimulationStageMetaData> SimulationStageMetaData { get { return new Array<SimulationStageMetaData>(this[nameof(SimulationStageMetaData)].Address); } }
        public bool bReadsSignificanceIndex { get { return this[nameof(bReadsSignificanceIndex)].Flag; } set { this[nameof(bReadsSignificanceIndex)].Flag = value; } }
    }
    public class NiagaraVMExecutableDataId : Object
    {
        public NiagaraVMExecutableDataId(ulong addr) : base(addr) { }
        public Guid CompilerVersionID { get { return this[nameof(CompilerVersionID)].As<Guid>(); } set { this["CompilerVersionID"] = value; } }
        public ENiagaraScriptUsage ScriptUsageType { get { return (ENiagaraScriptUsage)this[nameof(ScriptUsageType)].GetValue<int>(); } set { this[nameof(ScriptUsageType)].SetValue<int>((int)value); } }
        public Guid ScriptUsageTypeID { get { return this[nameof(ScriptUsageTypeID)].As<Guid>(); } set { this["ScriptUsageTypeID"] = value; } }
        public bool bUsesRapidIterationParams { get { return this[nameof(bUsesRapidIterationParams)].Flag; } set { this[nameof(bUsesRapidIterationParams)].Flag = value; } }
        public bool bInterpolatedSpawn { get { return this[nameof(bInterpolatedSpawn)].Flag; } set { this[nameof(bInterpolatedSpawn)].Flag = value; } }
        public bool bRequiresPersistentIDs { get { return this[nameof(bRequiresPersistentIDs)].Flag; } set { this[nameof(bRequiresPersistentIDs)].Flag = value; } }
        public Guid BaseScriptID { get { return this[nameof(BaseScriptID)].As<Guid>(); } set { this["BaseScriptID"] = value; } }
        public NiagaraCompileHash BaseScriptCompileHash { get { return this[nameof(BaseScriptCompileHash)].As<NiagaraCompileHash>(); } set { this["BaseScriptCompileHash"] = value; } }
    }
    public class NiagaraModuleDependency : Object
    {
        public NiagaraModuleDependency(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public ENiagaraModuleDependencyType Type { get { return (ENiagaraModuleDependencyType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ENiagaraModuleDependencyScriptConstraint ScriptConstraint { get { return (ENiagaraModuleDependencyScriptConstraint)this[nameof(ScriptConstraint)].GetValue<int>(); } set { this[nameof(ScriptConstraint)].SetValue<int>((int)value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
    }
    public class NiagaraScriptInstanceParameterStore : NiagaraParameterStore
    {
        public NiagaraScriptInstanceParameterStore(ulong addr) : base(addr) { }
    }
    public class NiagaraScriptExecutionParameterStore : NiagaraParameterStore
    {
        public NiagaraScriptExecutionParameterStore(ulong addr) : base(addr) { }
        public int ParameterSize { get { return this[nameof(ParameterSize)].GetValue<int>(); } set { this[nameof(ParameterSize)].SetValue<int>(value); } }
        public uint PaddedParameterSize { get { return this[nameof(PaddedParameterSize)].GetValue<uint>(); } set { this[nameof(PaddedParameterSize)].SetValue<uint>(value); } }
        public Array<NiagaraScriptExecutionPaddingInfo> PaddingInfo { get { return new Array<NiagaraScriptExecutionPaddingInfo>(this[nameof(PaddingInfo)].Address); } }
        public bool bInitialized { get { return this[nameof(bInitialized)].Flag; } set { this[nameof(bInitialized)].Flag = value; } }
    }
    public class NiagaraScriptExecutionPaddingInfo : Object
    {
        public NiagaraScriptExecutionPaddingInfo(ulong addr) : base(addr) { }
        public ushort SrcOffset { get { return this[nameof(SrcOffset)].GetValue<ushort>(); } set { this[nameof(SrcOffset)].SetValue<ushort>(value); } }
        public ushort DestOffset { get { return this[nameof(DestOffset)].GetValue<ushort>(); } set { this[nameof(DestOffset)].SetValue<ushort>(value); } }
        public ushort SrcSize { get { return this[nameof(SrcSize)].GetValue<ushort>(); } set { this[nameof(SrcSize)].SetValue<ushort>(value); } }
        public ushort DestSize { get { return this[nameof(DestSize)].GetValue<ushort>(); } set { this[nameof(DestSize)].SetValue<ushort>(value); } }
    }
    public class NiagaraScriptHighlight : Object
    {
        public NiagaraScriptHighlight(ulong addr) : base(addr) { }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
    }
    public class NiagaraSystemCompileRequest : Object
    {
        public NiagaraSystemCompileRequest(ulong addr) : base(addr) { }
        public Array<Object> RootObjects { get { return new Array<Object>(this[nameof(RootObjects)].Address); } }
    }
    public class EmitterCompiledScriptPair : Object
    {
        public EmitterCompiledScriptPair(ulong addr) : base(addr) { }
    }
    public class NiagaraSystemCompiledData : Object
    {
        public NiagaraSystemCompiledData(ulong addr) : base(addr) { }
        public NiagaraParameterStore InstanceParamStore { get { return this[nameof(InstanceParamStore)].As<NiagaraParameterStore>(); } set { this["InstanceParamStore"] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
        public NiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData { get { return this[nameof(SpawnInstanceParamsDataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["SpawnInstanceParamsDataSetCompiledData"] = value; } }
        public NiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData { get { return this[nameof(UpdateInstanceParamsDataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["UpdateInstanceParamsDataSetCompiledData"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding { get { return this[nameof(SpawnInstanceGlobalBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceGlobalBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding { get { return this[nameof(SpawnInstanceSystemBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceSystemBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding { get { return this[nameof(SpawnInstanceOwnerBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["SpawnInstanceOwnerBinding"] = value; } }
        public Array<NiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings { get { return new Array<NiagaraParameterDataSetBindingCollection>(this[nameof(SpawnInstanceEmitterBindings)].Address); } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding { get { return this[nameof(UpdateInstanceGlobalBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceGlobalBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding { get { return this[nameof(UpdateInstanceSystemBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceSystemBinding"] = value; } }
        public NiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding { get { return this[nameof(UpdateInstanceOwnerBinding)].As<NiagaraParameterDataSetBindingCollection>(); } set { this["UpdateInstanceOwnerBinding"] = value; } }
        public Array<NiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings { get { return new Array<NiagaraParameterDataSetBindingCollection>(this[nameof(UpdateInstanceEmitterBindings)].Address); } }
    }
    public class NiagaraParameterDataSetBindingCollection : Object
    {
        public NiagaraParameterDataSetBindingCollection(ulong addr) : base(addr) { }
        public Array<NiagaraParameterDataSetBinding> FloatOffsets { get { return new Array<NiagaraParameterDataSetBinding>(this[nameof(FloatOffsets)].Address); } }
        public Array<NiagaraParameterDataSetBinding> Int32Offsets { get { return new Array<NiagaraParameterDataSetBinding>(this[nameof(Int32Offsets)].Address); } }
    }
    public class NiagaraParameterDataSetBinding : Object
    {
        public NiagaraParameterDataSetBinding(ulong addr) : base(addr) { }
        public int ParameterOffset { get { return this[nameof(ParameterOffset)].GetValue<int>(); } set { this[nameof(ParameterOffset)].SetValue<int>(value); } }
        public int DataSetComponentOffset { get { return this[nameof(DataSetComponentOffset)].GetValue<int>(); } set { this[nameof(DataSetComponentOffset)].SetValue<int>(value); } }
    }
    public class NiagaraEmitterCompiledData : Object
    {
        public NiagaraEmitterCompiledData(ulong addr) : base(addr) { }
        public Array<Object> SpawnAttributes { get { return new Array<Object>(this[nameof(SpawnAttributes)].Address); } }
        public NiagaraVariable EmitterSpawnIntervalVar { get { return this[nameof(EmitterSpawnIntervalVar)].As<NiagaraVariable>(); } set { this["EmitterSpawnIntervalVar"] = value; } }
        public NiagaraVariable EmitterInterpSpawnStartDTVar { get { return this[nameof(EmitterInterpSpawnStartDTVar)].As<NiagaraVariable>(); } set { this["EmitterInterpSpawnStartDTVar"] = value; } }
        public NiagaraVariable EmitterSpawnGroupVar { get { return this[nameof(EmitterSpawnGroupVar)].As<NiagaraVariable>(); } set { this["EmitterSpawnGroupVar"] = value; } }
        public NiagaraVariable EmitterAgeVar { get { return this[nameof(EmitterAgeVar)].As<NiagaraVariable>(); } set { this["EmitterAgeVar"] = value; } }
        public NiagaraVariable EmitterRandomSeedVar { get { return this[nameof(EmitterRandomSeedVar)].As<NiagaraVariable>(); } set { this["EmitterRandomSeedVar"] = value; } }
        public NiagaraVariable EmitterInstanceSeedVar { get { return this[nameof(EmitterInstanceSeedVar)].As<NiagaraVariable>(); } set { this["EmitterInstanceSeedVar"] = value; } }
        public NiagaraVariable EmitterTotalSpawnedParticlesVar { get { return this[nameof(EmitterTotalSpawnedParticlesVar)].As<NiagaraVariable>(); } set { this["EmitterTotalSpawnedParticlesVar"] = value; } }
        public NiagaraDataSetCompiledData DataSetCompiledData { get { return this[nameof(DataSetCompiledData)].As<NiagaraDataSetCompiledData>(); } set { this["DataSetCompiledData"] = value; } }
    }
    public class NiagaraVariableMetaData : Object
    {
        public NiagaraVariableMetaData(ulong addr) : base(addr) { }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object CategoryName { get { return this[nameof(CategoryName)]; } set { this[nameof(CategoryName)] = value; } }
        public bool bAdvancedDisplay { get { return this[nameof(bAdvancedDisplay)].Flag; } set { this[nameof(bAdvancedDisplay)].Flag = value; } }
        public int EditorSortPriority { get { return this[nameof(EditorSortPriority)].GetValue<int>(); } set { this[nameof(EditorSortPriority)].SetValue<int>(value); } }
        public bool bInlineEditConditionToggle { get { return this[nameof(bInlineEditConditionToggle)].Flag; } set { this[nameof(bInlineEditConditionToggle)].Flag = value; } }
        public NiagaraInputConditionMetadata EditCondition { get { return this[nameof(EditCondition)].As<NiagaraInputConditionMetadata>(); } set { this["EditCondition"] = value; } }
        public NiagaraInputConditionMetadata VisibleCondition { get { return this[nameof(VisibleCondition)].As<NiagaraInputConditionMetadata>(); } set { this["VisibleCondition"] = value; } }
        public Object PropertyMetaData { get { return this[nameof(PropertyMetaData)]; } set { this[nameof(PropertyMetaData)] = value; } }
        public Object ParentAttribute { get { return this[nameof(ParentAttribute)]; } set { this[nameof(ParentAttribute)] = value; } }
        public Object ScopeName { get { return this[nameof(ScopeName)]; } set { this[nameof(ScopeName)] = value; } }
        public ENiagaraScriptParameterUsage Usage { get { return (ENiagaraScriptParameterUsage)this[nameof(Usage)].GetValue<int>(); } set { this[nameof(Usage)].SetValue<int>((int)value); } }
        public bool bIsStaticSwitch { get { return this[nameof(bIsStaticSwitch)].Flag; } set { this[nameof(bIsStaticSwitch)].Flag = value; } }
        public int StaticSwitchDefaultValue { get { return this[nameof(StaticSwitchDefaultValue)].GetValue<int>(); } set { this[nameof(StaticSwitchDefaultValue)].SetValue<int>(value); } }
        public bool bAddedToNodeGraphDeepCopy { get { return this[nameof(bAddedToNodeGraphDeepCopy)].Flag; } set { this[nameof(bAddedToNodeGraphDeepCopy)].Flag = value; } }
        public bool bOutputIsPersistent { get { return this[nameof(bOutputIsPersistent)].Flag; } set { this[nameof(bOutputIsPersistent)].Flag = value; } }
        public Object CachedNamespacelessVariableName { get { return this[nameof(CachedNamespacelessVariableName)]; } set { this[nameof(CachedNamespacelessVariableName)] = value; } }
        public bool bCreatedInSystemEditor { get { return this[nameof(bCreatedInSystemEditor)].Flag; } set { this[nameof(bCreatedInSystemEditor)].Flag = value; } }
        public bool bUseLegacyNameString { get { return this[nameof(bUseLegacyNameString)].Flag; } set { this[nameof(bUseLegacyNameString)].Flag = value; } }
    }
    public class NiagaraInputConditionMetadata : Object
    {
        public NiagaraInputConditionMetadata(ulong addr) : base(addr) { }
        public Object InputName { get { return this[nameof(InputName)]; } set { this[nameof(InputName)] = value; } }
        public Array<Object> TargetValues { get { return new Array<Object>(this[nameof(TargetValues)].Address); } }
    }
    public class NiagaraParameterScopeInfo : Object
    {
        public NiagaraParameterScopeInfo(ulong addr) : base(addr) { }
        public ENiagaraParameterScope Scope { get { return (ENiagaraParameterScope)this[nameof(Scope)].GetValue<int>(); } set { this[nameof(Scope)].SetValue<int>((int)value); } }
        public Object NamespaceString { get { return this[nameof(NamespaceString)]; } set { this[nameof(NamespaceString)] = value; } }
    }
    public class NiagaraCompileHashVisitorDebugInfo : Object
    {
        public NiagaraCompileHashVisitorDebugInfo(ulong addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public Array<Object> PropertyKeys { get { return new Array<Object>(this[nameof(PropertyKeys)].Address); } }
        public Array<Object> PropertyValues { get { return new Array<Object>(this[nameof(PropertyValues)].Address); } }
    }
    public class NiagaraID : Object
    {
        public NiagaraID(ulong addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public int AcquireTag { get { return this[nameof(AcquireTag)].GetValue<int>(); } set { this[nameof(AcquireTag)].SetValue<int>(value); } }
    }
    public class NiagaraSpawnInfo : Object
    {
        public NiagaraSpawnInfo(ulong addr) : base(addr) { }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public float InterpStartDt { get { return this[nameof(InterpStartDt)].GetValue<float>(); } set { this[nameof(InterpStartDt)].SetValue<float>(value); } }
        public float IntervalDt { get { return this[nameof(IntervalDt)].GetValue<float>(); } set { this[nameof(IntervalDt)].SetValue<float>(value); } }
        public int SpawnGroup { get { return this[nameof(SpawnGroup)].GetValue<int>(); } set { this[nameof(SpawnGroup)].SetValue<int>(value); } }
    }
    public class NiagaraMatrix : Object
    {
        public NiagaraMatrix(ulong addr) : base(addr) { }
        public Vector4 Row0 { get { return this[nameof(Row0)].As<Vector4>(); } set { this["Row0"] = value; } }
        public Vector4 Row1 { get { return this[nameof(Row1)].As<Vector4>(); } set { this["Row1"] = value; } }
        public Vector4 Row2 { get { return this[nameof(Row2)].As<Vector4>(); } set { this["Row2"] = value; } }
        public Vector4 Row3 { get { return this[nameof(Row3)].As<Vector4>(); } set { this["Row3"] = value; } }
    }
    public class NiagaraParameterMap : Object
    {
        public NiagaraParameterMap(ulong addr) : base(addr) { }
    }
    public class NiagaraNumeric : Object
    {
        public NiagaraNumeric(ulong addr) : base(addr) { }
    }
    public class NiagaraHalfVector4 : Object
    {
        public NiagaraHalfVector4(ulong addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
        public ushort Z { get { return this[nameof(Z)].GetValue<ushort>(); } set { this[nameof(Z)].SetValue<ushort>(value); } }
        public ushort W { get { return this[nameof(W)].GetValue<ushort>(); } set { this[nameof(W)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalfVector3 : Object
    {
        public NiagaraHalfVector3(ulong addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
        public ushort Z { get { return this[nameof(Z)].GetValue<ushort>(); } set { this[nameof(Z)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalfVector2 : Object
    {
        public NiagaraHalfVector2(ulong addr) : base(addr) { }
        public ushort X { get { return this[nameof(X)].GetValue<ushort>(); } set { this[nameof(X)].SetValue<ushort>(value); } }
        public ushort Y { get { return this[nameof(Y)].GetValue<ushort>(); } set { this[nameof(Y)].SetValue<ushort>(value); } }
    }
    public class NiagaraHalf : Object
    {
        public NiagaraHalf(ulong addr) : base(addr) { }
        public ushort Value { get { return this[nameof(Value)].GetValue<ushort>(); } set { this[nameof(Value)].SetValue<ushort>(value); } }
    }
    public class NiagaraBool : Object
    {
        public NiagaraBool(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class NiagaraInt32 : Object
    {
        public NiagaraInt32(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class NiagaraFloat : Object
    {
        public NiagaraFloat(ulong addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class NiagaraUserRedirectionParameterStore : NiagaraParameterStore
    {
        public NiagaraUserRedirectionParameterStore(ulong addr) : base(addr) { }
        public Object UserParameterRedirects { get { return this[nameof(UserParameterRedirects)]; } set { this[nameof(UserParameterRedirects)] = value; } }
    }
    public class NiagaraVariant : Object
    {
        public NiagaraVariant(ulong addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)].As<Object>(); } set { this["Object"] = value; } }
        public NiagaraDataInterface DataInterface { get { return this[nameof(DataInterface)].As<NiagaraDataInterface>(); } set { this["DataInterface"] = value; } }
        public Array<byte> Bytes { get { return new Array<byte>(this[nameof(Bytes)].Address); } }
        public ENiagaraVariantMode CurrentMode { get { return (ENiagaraVariantMode)this[nameof(CurrentMode)].GetValue<int>(); } set { this[nameof(CurrentMode)].SetValue<int>((int)value); } }
    }
    public class NiagaraWorldManagerTickFunction : TickFunction
    {
        public NiagaraWorldManagerTickFunction(ulong addr) : base(addr) { }
    }
}
