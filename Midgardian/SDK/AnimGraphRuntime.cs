using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AnimationCoreSDK;
namespace SDK.Script.AnimGraphRuntimeSDK
{
    public class AnimNotify_PlayMontageNotify : AnimNotify
    {
        public AnimNotify_PlayMontageNotify(ulong addr) : base(addr) { }
        public Object NotifyName { get { return this[nameof(NotifyName)]; } set { this[nameof(NotifyName)] = value; } }
    }
    public class AnimNotify_PlayMontageNotifyWindow : AnimNotifyState
    {
        public AnimNotify_PlayMontageNotifyWindow(ulong addr) : base(addr) { }
        public Object NotifyName { get { return this[nameof(NotifyName)]; } set { this[nameof(NotifyName)] = value; } }
    }
    public class AnimSequencerInstance : AnimInstance
    {
        public AnimSequencerInstance(ulong addr) : base(addr) { }
    }
    public class KismetAnimationLibrary : BlueprintFunctionLibrary
    {
        public KismetAnimationLibrary(ulong addr) : base(addr) { }
        public void K2_TwoBoneIK(Vector RootPos, Vector JointPos, Vector EndPos, Vector JointTarget, Vector Effector, Vector OutJointPos, Vector OutEndPos, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale) { Invoke(nameof(K2_TwoBoneIK), RootPos, JointPos, EndPos, JointTarget, Effector, OutJointPos, OutEndPos, bAllowStretching, StartStretchRatio, MaxStretchScale); }
        public void K2_StartProfilingTimer() { Invoke(nameof(K2_StartProfilingTimer)); }
        public Vector K2_MakePerlinNoiseVectorAndRemap(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ) { return Invoke<Vector>(nameof(K2_MakePerlinNoiseVectorAndRemap), X, Y, Z, RangeOutMinX, RangeOutMaxX, RangeOutMinY, RangeOutMaxY, RangeOutMinZ, RangeOutMaxZ); }
        public float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax) { return Invoke<float>(nameof(K2_MakePerlinNoiseAndRemap), Value, RangeOutMin, RangeOutMax); }
        public Transform K2_LookAt(Transform CurrentTransform, Vector TargetPosition, Vector LookAtVector, bool bUseUpVector, Vector UpVector, float ClampConeInDegree) { return Invoke<Transform>(nameof(K2_LookAt), CurrentTransform, TargetPosition, LookAtVector, bUseUpVector, UpVector, ClampConeInDegree); }
        public float K2_EndProfilingTimer(bool bLog, Object LogPrefix) { return Invoke<float>(nameof(K2_EndProfilingTimer), bLog, LogPrefix); }
        public float K2_DistanceBetweenTwoSocketsAndMapRange(SkeletalMeshComponent Component, Object SocketOrBoneNameA, byte SocketSpaceA, Object SocketOrBoneNameB, byte SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax) { return Invoke<float>(nameof(K2_DistanceBetweenTwoSocketsAndMapRange), Component, SocketOrBoneNameA, SocketSpaceA, SocketOrBoneNameB, SocketSpaceB, bRemapRange, InRangeMin, InRangeMax, OutRangeMin, OutRangeMax); }
        public Vector K2_DirectionBetweenSockets(SkeletalMeshComponent Component, Object SocketOrBoneNameFrom, Object SocketOrBoneNameTo) { return Invoke<Vector>(nameof(K2_DirectionBetweenSockets), Component, SocketOrBoneNameFrom, SocketOrBoneNameTo); }
        public float K2_CalculateVelocityFromSockets(float DeltaSeconds, SkeletalMeshComponent Component, Object SocketOrBoneName, Object ReferenceSocketOrBone, byte SocketSpace, Vector OffsetInBoneSpace, PositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, RuntimeFloatCurve CustomCurve) { return Invoke<float>(nameof(K2_CalculateVelocityFromSockets), DeltaSeconds, Component, SocketOrBoneName, ReferenceSocketOrBone, SocketSpace, OffsetInBoneSpace, History, NumberOfSamples, VelocityMin, VelocityMax, EasingType, CustomCurve); }
        public float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds, Vector Position, PositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax) { return Invoke<float>(nameof(K2_CalculateVelocityFromPositionHistory), DeltaSeconds, Position, History, NumberOfSamples, VelocityMin, VelocityMax); }
    }
    public class PlayMontageCallbackProxy : Object
    {
        public PlayMontageCallbackProxy(ulong addr) : base(addr) { }
        public Object OnCompleted { get { return this[nameof(OnCompleted)]; } set { this[nameof(OnCompleted)] = value; } }
        public Object OnBlendOut { get { return this[nameof(OnBlendOut)]; } set { this[nameof(OnBlendOut)] = value; } }
        public Object OnInterrupted { get { return this[nameof(OnInterrupted)]; } set { this[nameof(OnInterrupted)] = value; } }
        public Object OnNotifyBegin { get { return this[nameof(OnNotifyBegin)]; } set { this[nameof(OnNotifyBegin)] = value; } }
        public Object OnNotifyEnd { get { return this[nameof(OnNotifyEnd)]; } set { this[nameof(OnNotifyEnd)] = value; } }
        public void OnNotifyEndReceived(Object NotifyName, BranchingPointNotifyPayload BranchingPointNotifyPayload) { Invoke(nameof(OnNotifyEndReceived), NotifyName, BranchingPointNotifyPayload); }
        public void OnNotifyBeginReceived(Object NotifyName, BranchingPointNotifyPayload BranchingPointNotifyPayload) { Invoke(nameof(OnNotifyBeginReceived), NotifyName, BranchingPointNotifyPayload); }
        public void OnMontageEnded(AnimMontage Montage, bool bInterrupted) { Invoke(nameof(OnMontageEnded), Montage, bInterrupted); }
        public void OnMontageBlendingOut(AnimMontage Montage, bool bInterrupted) { Invoke(nameof(OnMontageBlendingOut), Montage, bInterrupted); }
        public PlayMontageCallbackProxy CreateProxyObjectForPlayMontage(SkeletalMeshComponent InSkeletalMeshComponent, AnimMontage MontageToPlay, float PlayRate, float StartingPosition, Object StartingSection) { return Invoke<PlayMontageCallbackProxy>(nameof(CreateProxyObjectForPlayMontage), InSkeletalMeshComponent, MontageToPlay, PlayRate, StartingPosition, StartingSection); }
    }
    public class SequencerAnimationSupport : Interface
    {
        public SequencerAnimationSupport(ulong addr) : base(addr) { }
    }
    public enum ESphericalLimitType : int
    {
        Inner = 0,
        Outer = 1,
        ESphericalLimitType_MAX = 2,
    }
    public enum AnimPhysSimSpaceType : int
    {
        Component = 0,
        Actor = 1,
        World = 2,
        RootRelative = 3,
        BoneRelative = 4,
        AnimPhysSimSpaceType_MAX = 5,
    }
    public enum AnimPhysLinearConstraintType : int
    {
        Free = 0,
        Limited = 1,
        AnimPhysLinearConstraintType_MAX = 2,
    }
    public enum AnimPhysAngularConstraintType : int
    {
        Angular = 0,
        Cone = 1,
        AnimPhysAngularConstraintType_MAX = 2,
    }
    public enum EBlendListTransitionType : int
    {
        StandardBlend = 0,
        Inertialization = 1,
        EBlendListTransitionType_MAX = 2,
    }
    public enum EDrivenDestinationMode : int
    {
        Bone = 0,
        MorphTarget = 1,
        MaterialParameter = 2,
        EDrivenDestinationMode_MAX = 3,
    }
    public enum EDrivenBoneModificationMode : int
    {
        AddToInput = 0,
        ReplaceComponent = 1,
        AddToRefPose = 2,
        EDrivenBoneModificationMode_MAX = 3,
    }
    public enum EConstraintOffsetOption : int
    {
        None = 0,
        Offset_RefPose = 1,
        EConstraintOffsetOption_MAX = 2,
    }
    public enum CopyBoneDeltaMode : int
    {
        Accumulate = 0,
        Copy = 1,
        CopyBoneDeltaMode_MAX = 2,
    }
    public enum EInterpolationBlend : int
    {
        Linear = 0,
        Cubic = 1,
        Sinusoidal = 2,
        EaseInOutExponent2 = 3,
        EaseInOutExponent3 = 4,
        EaseInOutExponent4 = 5,
        EaseInOutExponent5 = 6,
        MAX = 7,
    }
    public enum EBoneModificationMode : int
    {
        BMM_Ignore = 0,
        BMM_Replace = 1,
        BMM_Additive = 2,
        BMM_MAX = 3,
    }
    public enum EModifyCurveApplyMode : int
    {
        Add = 0,
        Scale = 1,
        Blend = 2,
        WeightedMovingAverage = 3,
        RemapCurve = 4,
        EModifyCurveApplyMode_MAX = 5,
    }
    public enum EPoseDriverOutput : int
    {
        DrivePoses = 0,
        DriveCurves = 1,
        EPoseDriverOutput_MAX = 2,
    }
    public enum EPoseDriverSource : int
    {
        Rotation = 0,
        Translation = 1,
        EPoseDriverSource_MAX = 2,
    }
    public enum EPoseDriverType : int
    {
        SwingAndTwist = 0,
        SwingOnly = 1,
        Translation = 2,
        EPoseDriverType_MAX = 3,
    }
    public enum ESnapshotSourceMode : int
    {
        NamedSnapshot = 0,
        SnapshotPin = 1,
        ESnapshotSourceMode_MAX = 2,
    }
    public enum ERefPoseType : int
    {
        EIT_LocalSpace = 0,
        EIT_Additive = 1,
        EIT_MAX = 2,
    }
    public enum ESimulationSpace : int
    {
        ComponentSpace = 0,
        WorldSpace = 1,
        BaseBoneSpace = 2,
        ESimulationSpace_MAX = 3,
    }
    public enum EScaleChainInitialLength : int
    {
        FixedDefaultLengthValue = 0,
        Distance = 1,
        ChainLength = 2,
        EScaleChainInitialLength_MAX = 3,
    }
    public enum ESequenceEvalReinit : int
    {
        NoReset = 0,
        StartPosition = 1,
        ExplicitTime = 2,
        ESequenceEvalReinit_MAX = 3,
    }
    public enum ESplineBoneAxis : int
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
        ESplineBoneAxis_MAX = 4,
    }
    public enum ERotationComponent : int
    {
        EulerX = 0,
        EulerY = 1,
        EulerZ = 2,
        QuaternionAngle = 3,
        SwingAngle = 4,
        TwistAngle = 5,
        ERotationComponent_MAX = 6,
    }
    public enum EEasingFuncType : int
    {
        Linear = 0,
        Sinusoidal = 1,
        Cubic = 2,
        QuadraticInOut = 3,
        CubicInOut = 4,
        HermiteCubic = 5,
        QuarticInOut = 6,
        QuinticInOut = 7,
        CircularIn = 8,
        CircularOut = 9,
        CircularInOut = 10,
        ExpIn = 11,
        ExpOut = 12,
        ExpInOut = 13,
        CustomCurve = 14,
        EEasingFuncType_MAX = 15,
    }
    public enum ERBFNormalizeMethod : int
    {
        OnlyNormalizeAboveOne = 0,
        AlwaysNormalize = 1,
        NormalizeWithinMedian = 2,
        NoNormalization = 3,
        ERBFNormalizeMethod_MAX = 4,
    }
    public enum ERBFDistanceMethod : int
    {
        Euclidean = 0,
        Quaternion = 1,
        SwingAngle = 2,
        TwistAngle = 3,
        DefaultMethod = 4,
        ERBFDistanceMethod_MAX = 5,
    }
    public enum ERBFFunctionType : int
    {
        Gaussian = 0,
        Exponential = 1,
        Linear = 2,
        Cubic = 3,
        Quintic = 4,
        DefaultFunction = 5,
        ERBFFunctionType_MAX = 6,
    }
    public enum ERBFSolverType : int
    {
        Additive = 0,
        Interpolative = 1,
        ERBFSolverType_MAX = 2,
    }
    public class AnimNode_SkeletalControlBase : AnimNode_Base
    {
        public AnimNode_SkeletalControlBase(ulong addr) : base(addr) { }
        public ComponentSpacePoseLink ComponentPose { get { return this[nameof(ComponentPose)].As<ComponentSpacePoseLink>(); } set { this["ComponentPose"] = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
        public float ActualAlpha { get { return this[nameof(ActualAlpha)].GetValue<float>(); } set { this[nameof(ActualAlpha)].SetValue<float>(value); } }
        public EAnimAlphaInputType AlphaInputType { get { return (EAnimAlphaInputType)this[nameof(AlphaInputType)].GetValue<int>(); } set { this[nameof(AlphaInputType)].SetValue<int>((int)value); } }
        public bool bAlphaBoolEnabled { get { return this[nameof(bAlphaBoolEnabled)].Flag; } set { this[nameof(bAlphaBoolEnabled)].Flag = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public InputAlphaBoolBlend AlphaBoolBlend { get { return this[nameof(AlphaBoolBlend)].As<InputAlphaBoolBlend>(); } set { this["AlphaBoolBlend"] = value; } }
        public Object AlphaCurveName { get { return this[nameof(AlphaCurveName)]; } set { this[nameof(AlphaCurveName)] = value; } }
        public InputScaleBiasClamp AlphaScaleBiasClamp { get { return this[nameof(AlphaScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["AlphaScaleBiasClamp"] = value; } }
    }
    public class AnimNode_BlendSpacePlayer : AnimNode_AssetPlayerBase
    {
        public AnimNode_BlendSpacePlayer(ulong addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public bool bLoop { get { return this[nameof(bLoop)].Flag; } set { this[nameof(bLoop)].Flag = value; } }
        public bool bResetPlayTimeWhenBlendSpaceChanges { get { return this[nameof(bResetPlayTimeWhenBlendSpaceChanges)].Flag; } set { this[nameof(bResetPlayTimeWhenBlendSpaceChanges)].Flag = value; } }
        public float StartPosition { get { return this[nameof(StartPosition)].GetValue<float>(); } set { this[nameof(StartPosition)].SetValue<float>(value); } }
        public BlendSpaceBase BlendSpace { get { return this[nameof(BlendSpace)].As<BlendSpaceBase>(); } set { this["BlendSpace"] = value; } }
        public BlendSpaceBase PreviousBlendSpace { get { return this[nameof(PreviousBlendSpace)].As<BlendSpaceBase>(); } set { this["PreviousBlendSpace"] = value; } }
    }
    public class AnimNode_AimOffsetLookAt : AnimNode_BlendSpacePlayer
    {
        public AnimNode_AimOffsetLookAt(ulong addr) : base(addr) { }
        public PoseLink BasePose { get { return this[nameof(BasePose)].As<PoseLink>(); } set { this["BasePose"] = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
        public Object SourceSocketName { get { return this[nameof(SourceSocketName)]; } set { this[nameof(SourceSocketName)] = value; } }
        public Object PivotSocketName { get { return this[nameof(PivotSocketName)]; } set { this[nameof(PivotSocketName)] = value; } }
        public Vector LookAtLocation { get { return this[nameof(LookAtLocation)].As<Vector>(); } set { this["LookAtLocation"] = value; } }
        public Vector SocketAxis { get { return this[nameof(SocketAxis)].As<Vector>(); } set { this["SocketAxis"] = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
    }
    public class AnimNode_AnimDynamics : AnimNode_SkeletalControlBase
    {
        public AnimNode_AnimDynamics(ulong addr) : base(addr) { }
        public float LinearDampingOverride { get { return this[nameof(LinearDampingOverride)].GetValue<float>(); } set { this[nameof(LinearDampingOverride)].SetValue<float>(value); } }
        public float AngularDampingOverride { get { return this[nameof(AngularDampingOverride)].GetValue<float>(); } set { this[nameof(AngularDampingOverride)].SetValue<float>(value); } }
        public BoneReference RelativeSpaceBone { get { return this[nameof(RelativeSpaceBone)].As<BoneReference>(); } set { this["RelativeSpaceBone"] = value; } }
        public BoneReference BoundBone { get { return this[nameof(BoundBone)].As<BoneReference>(); } set { this["BoundBone"] = value; } }
        public BoneReference ChainEnd { get { return this[nameof(ChainEnd)].As<BoneReference>(); } set { this["ChainEnd"] = value; } }
        public Vector BoxExtents { get { return this[nameof(BoxExtents)].As<Vector>(); } set { this["BoxExtents"] = value; } }
        public Vector LocalJointOffset { get { return this[nameof(LocalJointOffset)].As<Vector>(); } set { this["LocalJointOffset"] = value; } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public Vector GravityOverride { get { return this[nameof(GravityOverride)].As<Vector>(); } set { this["GravityOverride"] = value; } }
        public float LinearSpringConstant { get { return this[nameof(LinearSpringConstant)].GetValue<float>(); } set { this[nameof(LinearSpringConstant)].SetValue<float>(value); } }
        public float AngularSpringConstant { get { return this[nameof(AngularSpringConstant)].GetValue<float>(); } set { this[nameof(AngularSpringConstant)].SetValue<float>(value); } }
        public float WindScale { get { return this[nameof(WindScale)].GetValue<float>(); } set { this[nameof(WindScale)].SetValue<float>(value); } }
        public Vector ComponentLinearAccScale { get { return this[nameof(ComponentLinearAccScale)].As<Vector>(); } set { this["ComponentLinearAccScale"] = value; } }
        public Vector ComponentLinearVelScale { get { return this[nameof(ComponentLinearVelScale)].As<Vector>(); } set { this["ComponentLinearVelScale"] = value; } }
        public Vector ComponentAppliedLinearAccClamp { get { return this[nameof(ComponentAppliedLinearAccClamp)].As<Vector>(); } set { this["ComponentAppliedLinearAccClamp"] = value; } }
        public float AngularBiasOverride { get { return this[nameof(AngularBiasOverride)].GetValue<float>(); } set { this[nameof(AngularBiasOverride)].SetValue<float>(value); } }
        public int NumSolverIterationsPreUpdate { get { return this[nameof(NumSolverIterationsPreUpdate)].GetValue<int>(); } set { this[nameof(NumSolverIterationsPreUpdate)].SetValue<int>(value); } }
        public int NumSolverIterationsPostUpdate { get { return this[nameof(NumSolverIterationsPostUpdate)].GetValue<int>(); } set { this[nameof(NumSolverIterationsPostUpdate)].SetValue<int>(value); } }
        public AnimPhysConstraintSetup ConstraintSetup { get { return this[nameof(ConstraintSetup)].As<AnimPhysConstraintSetup>(); } set { this["ConstraintSetup"] = value; } }
        public Array<AnimPhysSphericalLimit> SphericalLimits { get { return new Array<AnimPhysSphericalLimit>(this[nameof(SphericalLimits)].Address); } }
        public float SphereCollisionRadius { get { return this[nameof(SphereCollisionRadius)].GetValue<float>(); } set { this[nameof(SphereCollisionRadius)].SetValue<float>(value); } }
        public Vector ExternalForce { get { return this[nameof(ExternalForce)].As<Vector>(); } set { this["ExternalForce"] = value; } }
        public Array<AnimPhysPlanarLimit> PlanarLimits { get { return new Array<AnimPhysPlanarLimit>(this[nameof(PlanarLimits)].Address); } }
        public AnimPhysCollisionType CollisionType { get { return (AnimPhysCollisionType)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public AnimPhysSimSpaceType SimulationSpace { get { return (AnimPhysSimSpaceType)this[nameof(SimulationSpace)].GetValue<int>(); } set { this[nameof(SimulationSpace)].SetValue<int>((int)value); } }
        public bool bUseSphericalLimits { get { return this[nameof(bUseSphericalLimits)].Flag; } set { this[nameof(bUseSphericalLimits)].Flag = value; } }
        public bool bUsePlanarLimit { get { return this[nameof(bUsePlanarLimit)].Flag; } set { this[nameof(bUsePlanarLimit)].Flag = value; } }
        public bool bDoUpdate { get { return this[nameof(bDoUpdate)].Flag; } set { this[nameof(bDoUpdate)].Flag = value; } }
        public bool bDoEval { get { return this[nameof(bDoEval)].Flag; } set { this[nameof(bDoEval)].Flag = value; } }
        public bool bOverrideLinearDamping { get { return this[nameof(bOverrideLinearDamping)].Flag; } set { this[nameof(bOverrideLinearDamping)].Flag = value; } }
        public bool bOverrideAngularBias { get { return this[nameof(bOverrideAngularBias)].Flag; } set { this[nameof(bOverrideAngularBias)].Flag = value; } }
        public bool bOverrideAngularDamping { get { return this[nameof(bOverrideAngularDamping)].Flag; } set { this[nameof(bOverrideAngularDamping)].Flag = value; } }
        public bool bEnableWind { get { return this[nameof(bEnableWind)].Flag; } set { this[nameof(bEnableWind)].Flag = value; } }
        public bool bUseGravityOverride { get { return this[nameof(bUseGravityOverride)].Flag; } set { this[nameof(bUseGravityOverride)].Flag = value; } }
        public bool bLinearSpring { get { return this[nameof(bLinearSpring)].Flag; } set { this[nameof(bLinearSpring)].Flag = value; } }
        public bool bAngularSpring { get { return this[nameof(bAngularSpring)].Flag; } set { this[nameof(bAngularSpring)].Flag = value; } }
        public bool bChain { get { return this[nameof(bChain)].Flag; } set { this[nameof(bChain)].Flag = value; } }
        public RotationRetargetingInfo RetargetingSettings { get { return this[nameof(RetargetingSettings)].As<RotationRetargetingInfo>(); } set { this["RetargetingSettings"] = value; } }
    }
    public class RotationRetargetingInfo : Object
    {
        public RotationRetargetingInfo(ulong addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public Transform Source { get { return this[nameof(Source)].As<Transform>(); } set { this["Source"] = value; } }
        public Transform Target { get { return this[nameof(Target)].As<Transform>(); } set { this["Target"] = value; } }
        public ERotationComponent RotationComponent { get { return (ERotationComponent)this[nameof(RotationComponent)].GetValue<int>(); } set { this[nameof(RotationComponent)].SetValue<int>((int)value); } }
        public Vector TwistAxis { get { return this[nameof(TwistAxis)].As<Vector>(); } set { this["TwistAxis"] = value; } }
        public bool bUseAbsoluteAngle { get { return this[nameof(bUseAbsoluteAngle)].Flag; } set { this[nameof(bUseAbsoluteAngle)].Flag = value; } }
        public float SourceMinimum { get { return this[nameof(SourceMinimum)].GetValue<float>(); } set { this[nameof(SourceMinimum)].SetValue<float>(value); } }
        public float SourceMaximum { get { return this[nameof(SourceMaximum)].GetValue<float>(); } set { this[nameof(SourceMaximum)].SetValue<float>(value); } }
        public float TargetMinimum { get { return this[nameof(TargetMinimum)].GetValue<float>(); } set { this[nameof(TargetMinimum)].SetValue<float>(value); } }
        public float TargetMaximum { get { return this[nameof(TargetMaximum)].GetValue<float>(); } set { this[nameof(TargetMaximum)].SetValue<float>(value); } }
        public EEasingFuncType EasingType { get { return (EEasingFuncType)this[nameof(EasingType)].GetValue<int>(); } set { this[nameof(EasingType)].SetValue<int>((int)value); } }
        public RuntimeFloatCurve CustomCurve { get { return this[nameof(CustomCurve)].As<RuntimeFloatCurve>(); } set { this["CustomCurve"] = value; } }
        public bool bFlipEasing { get { return this[nameof(bFlipEasing)].Flag; } set { this[nameof(bFlipEasing)].Flag = value; } }
        public float EasingWeight { get { return this[nameof(EasingWeight)].GetValue<float>(); } set { this[nameof(EasingWeight)].SetValue<float>(value); } }
        public bool bClamp { get { return this[nameof(bClamp)].Flag; } set { this[nameof(bClamp)].Flag = value; } }
    }
    public class AnimPhysPlanarLimit : Object
    {
        public AnimPhysPlanarLimit(ulong addr) : base(addr) { }
        public BoneReference DrivingBone { get { return this[nameof(DrivingBone)].As<BoneReference>(); } set { this["DrivingBone"] = value; } }
        public Transform PlaneTransform { get { return this[nameof(PlaneTransform)].As<Transform>(); } set { this["PlaneTransform"] = value; } }
    }
    public class AnimPhysSphericalLimit : Object
    {
        public AnimPhysSphericalLimit(ulong addr) : base(addr) { }
        public BoneReference DrivingBone { get { return this[nameof(DrivingBone)].As<BoneReference>(); } set { this["DrivingBone"] = value; } }
        public Vector SphereLocalOffset { get { return this[nameof(SphereLocalOffset)].As<Vector>(); } set { this["SphereLocalOffset"] = value; } }
        public float LimitRadius { get { return this[nameof(LimitRadius)].GetValue<float>(); } set { this[nameof(LimitRadius)].SetValue<float>(value); } }
        public ESphericalLimitType LimitType { get { return (ESphericalLimitType)this[nameof(LimitType)].GetValue<int>(); } set { this[nameof(LimitType)].SetValue<int>((int)value); } }
    }
    public class AnimPhysConstraintSetup : Object
    {
        public AnimPhysConstraintSetup(ulong addr) : base(addr) { }
        public AnimPhysLinearConstraintType LinearXLimitType { get { return (AnimPhysLinearConstraintType)this[nameof(LinearXLimitType)].GetValue<int>(); } set { this[nameof(LinearXLimitType)].SetValue<int>((int)value); } }
        public AnimPhysLinearConstraintType LinearYLimitType { get { return (AnimPhysLinearConstraintType)this[nameof(LinearYLimitType)].GetValue<int>(); } set { this[nameof(LinearYLimitType)].SetValue<int>((int)value); } }
        public AnimPhysLinearConstraintType LinearZLimitType { get { return (AnimPhysLinearConstraintType)this[nameof(LinearZLimitType)].GetValue<int>(); } set { this[nameof(LinearZLimitType)].SetValue<int>((int)value); } }
        public Vector LinearAxesMin { get { return this[nameof(LinearAxesMin)].As<Vector>(); } set { this["LinearAxesMin"] = value; } }
        public Vector LinearAxesMax { get { return this[nameof(LinearAxesMax)].As<Vector>(); } set { this["LinearAxesMax"] = value; } }
        public AnimPhysAngularConstraintType AngularConstraintType { get { return (AnimPhysAngularConstraintType)this[nameof(AngularConstraintType)].GetValue<int>(); } set { this[nameof(AngularConstraintType)].SetValue<int>((int)value); } }
        public AnimPhysTwistAxis TwistAxis { get { return (AnimPhysTwistAxis)this[nameof(TwistAxis)].GetValue<int>(); } set { this[nameof(TwistAxis)].SetValue<int>((int)value); } }
        public AnimPhysTwistAxis AngularTargetAxis { get { return (AnimPhysTwistAxis)this[nameof(AngularTargetAxis)].GetValue<int>(); } set { this[nameof(AngularTargetAxis)].SetValue<int>((int)value); } }
        public float ConeAngle { get { return this[nameof(ConeAngle)].GetValue<float>(); } set { this[nameof(ConeAngle)].SetValue<float>(value); } }
        public Vector AngularLimitsMin { get { return this[nameof(AngularLimitsMin)].As<Vector>(); } set { this["AngularLimitsMin"] = value; } }
        public Vector AngularLimitsMax { get { return this[nameof(AngularLimitsMax)].As<Vector>(); } set { this["AngularLimitsMax"] = value; } }
        public Vector AngularTarget { get { return this[nameof(AngularTarget)].As<Vector>(); } set { this["AngularTarget"] = value; } }
    }
    public class AnimNode_ApplyAdditive : AnimNode_Base
    {
        public AnimNode_ApplyAdditive(ulong addr) : base(addr) { }
        public PoseLink Base { get { return this[nameof(Base)].As<PoseLink>(); } set { this["Base"] = value; } }
        public PoseLink Additive { get { return this[nameof(Additive)].As<PoseLink>(); } set { this["Additive"] = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
        public InputAlphaBoolBlend AlphaBoolBlend { get { return this[nameof(AlphaBoolBlend)].As<InputAlphaBoolBlend>(); } set { this["AlphaBoolBlend"] = value; } }
        public Object AlphaCurveName { get { return this[nameof(AlphaCurveName)]; } set { this[nameof(AlphaCurveName)] = value; } }
        public InputScaleBiasClamp AlphaScaleBiasClamp { get { return this[nameof(AlphaScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["AlphaScaleBiasClamp"] = value; } }
        public EAnimAlphaInputType AlphaInputType { get { return (EAnimAlphaInputType)this[nameof(AlphaInputType)].GetValue<int>(); } set { this[nameof(AlphaInputType)].SetValue<int>((int)value); } }
        public bool bAlphaBoolEnabled { get { return this[nameof(bAlphaBoolEnabled)].Flag; } set { this[nameof(bAlphaBoolEnabled)].Flag = value; } }
    }
    public class AnimNode_ApplyLimits : AnimNode_SkeletalControlBase
    {
        public AnimNode_ApplyLimits(ulong addr) : base(addr) { }
        public Array<AngularRangeLimit> AngularRangeLimits { get { return new Array<AngularRangeLimit>(this[nameof(AngularRangeLimits)].Address); } }
        public Array<Vector> AngularOffsets { get { return new Array<Vector>(this[nameof(AngularOffsets)].Address); } }
    }
    public class AngularRangeLimit : Object
    {
        public AngularRangeLimit(ulong addr) : base(addr) { }
        public Vector LimitMin { get { return this[nameof(LimitMin)].As<Vector>(); } set { this["LimitMin"] = value; } }
        public Vector LimitMax { get { return this[nameof(LimitMax)].As<Vector>(); } set { this["LimitMax"] = value; } }
        public BoneReference Bone { get { return this[nameof(Bone)].As<BoneReference>(); } set { this["Bone"] = value; } }
    }
    public class AnimNode_BlendBoneByChannel : AnimNode_Base
    {
        public AnimNode_BlendBoneByChannel(ulong addr) : base(addr) { }
        public PoseLink A { get { return this[nameof(A)].As<PoseLink>(); } set { this["A"] = value; } }
        public PoseLink B { get { return this[nameof(B)].As<PoseLink>(); } set { this["B"] = value; } }
        public Array<BlendBoneByChannelEntry> BoneDefinitions { get { return new Array<BlendBoneByChannelEntry>(this[nameof(BoneDefinitions)].Address); } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public byte TransformsSpace { get { return this[nameof(TransformsSpace)].GetValue<byte>(); } set { this[nameof(TransformsSpace)].SetValue<byte>(value); } }
    }
    public class BlendBoneByChannelEntry : Object
    {
        public BlendBoneByChannelEntry(ulong addr) : base(addr) { }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public bool bBlendTranslation { get { return this[nameof(bBlendTranslation)].Flag; } set { this[nameof(bBlendTranslation)].Flag = value; } }
        public bool bBlendRotation { get { return this[nameof(bBlendRotation)].Flag; } set { this[nameof(bBlendRotation)].Flag = value; } }
        public bool bBlendScale { get { return this[nameof(bBlendScale)].Flag; } set { this[nameof(bBlendScale)].Flag = value; } }
    }
    public class AnimNode_BlendListBase : AnimNode_Base
    {
        public AnimNode_BlendListBase(ulong addr) : base(addr) { }
        public Array<PoseLink> BlendPose { get { return new Array<PoseLink>(this[nameof(BlendPose)].Address); } }
        public Array<float> BlendTime { get { return new Array<float>(this[nameof(BlendTime)].Address); } }
        public EBlendListTransitionType TransitionType { get { return (EBlendListTransitionType)this[nameof(TransitionType)].GetValue<int>(); } set { this[nameof(TransitionType)].SetValue<int>((int)value); } }
        public EAlphaBlendOption BlendType { get { return (EAlphaBlendOption)this[nameof(BlendType)].GetValue<int>(); } set { this[nameof(BlendType)].SetValue<int>((int)value); } }
        public bool bResetChildOnActivation { get { return this[nameof(bResetChildOnActivation)].Flag; } set { this[nameof(bResetChildOnActivation)].Flag = value; } }
        public CurveFloat CustomBlendCurve { get { return this[nameof(CustomBlendCurve)].As<CurveFloat>(); } set { this["CustomBlendCurve"] = value; } }
        public BlendProfile BlendProfile { get { return this[nameof(BlendProfile)].As<BlendProfile>(); } set { this["BlendProfile"] = value; } }
    }
    public class AnimNode_BlendListByBool : AnimNode_BlendListBase
    {
        public AnimNode_BlendListByBool(ulong addr) : base(addr) { }
        public bool bActiveValue { get { return this[nameof(bActiveValue)].Flag; } set { this[nameof(bActiveValue)].Flag = value; } }
    }
    public class AnimNode_BlendListByEnum : AnimNode_BlendListBase
    {
        public AnimNode_BlendListByEnum(ulong addr) : base(addr) { }
        public Array<int> EnumToPoseIndex { get { return new Array<int>(this[nameof(EnumToPoseIndex)].Address); } }
        public byte ActiveEnumValue { get { return this[nameof(ActiveEnumValue)].GetValue<byte>(); } set { this[nameof(ActiveEnumValue)].SetValue<byte>(value); } }
    }
    public class AnimNode_BlendListByInt : AnimNode_BlendListBase
    {
        public AnimNode_BlendListByInt(ulong addr) : base(addr) { }
        public int ActiveChildIndex { get { return this[nameof(ActiveChildIndex)].GetValue<int>(); } set { this[nameof(ActiveChildIndex)].SetValue<int>(value); } }
    }
    public class AnimNode_BlendSpaceEvaluator : AnimNode_BlendSpacePlayer
    {
        public AnimNode_BlendSpaceEvaluator(ulong addr) : base(addr) { }
        public float NormalizedTime { get { return this[nameof(NormalizedTime)].GetValue<float>(); } set { this[nameof(NormalizedTime)].SetValue<float>(value); } }
    }
    public class AnimNode_BoneDrivenController : AnimNode_SkeletalControlBase
    {
        public AnimNode_BoneDrivenController(ulong addr) : base(addr) { }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public CurveFloat DrivingCurve { get { return this[nameof(DrivingCurve)].As<CurveFloat>(); } set { this["DrivingCurve"] = value; } }
        public float Multiplier { get { return this[nameof(Multiplier)].GetValue<float>(); } set { this[nameof(Multiplier)].SetValue<float>(value); } }
        public float RangeMin { get { return this[nameof(RangeMin)].GetValue<float>(); } set { this[nameof(RangeMin)].SetValue<float>(value); } }
        public float RangeMax { get { return this[nameof(RangeMax)].GetValue<float>(); } set { this[nameof(RangeMax)].SetValue<float>(value); } }
        public float RemappedMin { get { return this[nameof(RemappedMin)].GetValue<float>(); } set { this[nameof(RemappedMin)].SetValue<float>(value); } }
        public float RemappedMax { get { return this[nameof(RemappedMax)].GetValue<float>(); } set { this[nameof(RemappedMax)].SetValue<float>(value); } }
        public Object ParameterName { get { return this[nameof(ParameterName)]; } set { this[nameof(ParameterName)] = value; } }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public EDrivenDestinationMode DestinationMode { get { return (EDrivenDestinationMode)this[nameof(DestinationMode)].GetValue<int>(); } set { this[nameof(DestinationMode)].SetValue<int>((int)value); } }
        public EDrivenBoneModificationMode ModificationMode { get { return (EDrivenBoneModificationMode)this[nameof(ModificationMode)].GetValue<int>(); } set { this[nameof(ModificationMode)].SetValue<int>((int)value); } }
        public byte SourceComponent { get { return this[nameof(SourceComponent)].GetValue<byte>(); } set { this[nameof(SourceComponent)].SetValue<byte>(value); } }
        public bool bUseRange { get { return this[nameof(bUseRange)].Flag; } set { this[nameof(bUseRange)].Flag = value; } }
        public bool bAffectTargetTranslationX { get { return this[nameof(bAffectTargetTranslationX)].Flag; } set { this[nameof(bAffectTargetTranslationX)].Flag = value; } }
        public bool bAffectTargetTranslationY { get { return this[nameof(bAffectTargetTranslationY)].Flag; } set { this[nameof(bAffectTargetTranslationY)].Flag = value; } }
        public bool bAffectTargetTranslationZ { get { return this[nameof(bAffectTargetTranslationZ)].Flag; } set { this[nameof(bAffectTargetTranslationZ)].Flag = value; } }
        public bool bAffectTargetRotationX { get { return this[nameof(bAffectTargetRotationX)].Flag; } set { this[nameof(bAffectTargetRotationX)].Flag = value; } }
        public bool bAffectTargetRotationY { get { return this[nameof(bAffectTargetRotationY)].Flag; } set { this[nameof(bAffectTargetRotationY)].Flag = value; } }
        public bool bAffectTargetRotationZ { get { return this[nameof(bAffectTargetRotationZ)].Flag; } set { this[nameof(bAffectTargetRotationZ)].Flag = value; } }
        public bool bAffectTargetScaleX { get { return this[nameof(bAffectTargetScaleX)].Flag; } set { this[nameof(bAffectTargetScaleX)].Flag = value; } }
        public bool bAffectTargetScaleY { get { return this[nameof(bAffectTargetScaleY)].Flag; } set { this[nameof(bAffectTargetScaleY)].Flag = value; } }
        public bool bAffectTargetScaleZ { get { return this[nameof(bAffectTargetScaleZ)].Flag; } set { this[nameof(bAffectTargetScaleZ)].Flag = value; } }
    }
    public class AnimNode_CCDIK : AnimNode_SkeletalControlBase
    {
        public AnimNode_CCDIK(ulong addr) : base(addr) { }
        public Vector EffectorLocation { get { return this[nameof(EffectorLocation)].As<Vector>(); } set { this["EffectorLocation"] = value; } }
        public byte EffectorLocationSpace { get { return this[nameof(EffectorLocationSpace)].GetValue<byte>(); } set { this[nameof(EffectorLocationSpace)].SetValue<byte>(value); } }
        public BoneSocketTarget EffectorTarget { get { return this[nameof(EffectorTarget)].As<BoneSocketTarget>(); } set { this["EffectorTarget"] = value; } }
        public BoneReference TipBone { get { return this[nameof(TipBone)].As<BoneReference>(); } set { this["TipBone"] = value; } }
        public BoneReference RootBone { get { return this[nameof(RootBone)].As<BoneReference>(); } set { this["RootBone"] = value; } }
        public float Precision { get { return this[nameof(Precision)].GetValue<float>(); } set { this[nameof(Precision)].SetValue<float>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public bool bStartFromTail { get { return this[nameof(bStartFromTail)].Flag; } set { this[nameof(bStartFromTail)].Flag = value; } }
        public bool bEnableRotationLimit { get { return this[nameof(bEnableRotationLimit)].Flag; } set { this[nameof(bEnableRotationLimit)].Flag = value; } }
        public Array<float> RotationLimitPerJoints { get { return new Array<float>(this[nameof(RotationLimitPerJoints)].Address); } }
    }
    public class BoneSocketTarget : Object
    {
        public BoneSocketTarget(ulong addr) : base(addr) { }
        public bool bUseSocket { get { return this[nameof(bUseSocket)].Flag; } set { this[nameof(bUseSocket)].Flag = value; } }
        public BoneReference BoneReference { get { return this[nameof(BoneReference)].As<BoneReference>(); } set { this["BoneReference"] = value; } }
        public SocketReference SocketReference { get { return this[nameof(SocketReference)].As<SocketReference>(); } set { this["SocketReference"] = value; } }
    }
    public class SocketReference : Object
    {
        public SocketReference(ulong addr) : base(addr) { }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
    }
    public class AnimNode_Constraint : AnimNode_SkeletalControlBase
    {
        public AnimNode_Constraint(ulong addr) : base(addr) { }
        public BoneReference BoneToModify { get { return this[nameof(BoneToModify)].As<BoneReference>(); } set { this["BoneToModify"] = value; } }
        public Array<Constraint> ConstraintSetup { get { return new Array<Constraint>(this[nameof(ConstraintSetup)].Address); } }
        public Array<float> ConstraintWeights { get { return new Array<float>(this[nameof(ConstraintWeights)].Address); } }
    }
    public class Constraint : Object
    {
        public Constraint(ulong addr) : base(addr) { }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public EConstraintOffsetOption OffsetOption { get { return (EConstraintOffsetOption)this[nameof(OffsetOption)].GetValue<int>(); } set { this[nameof(OffsetOption)].SetValue<int>((int)value); } }
        public ETransformConstraintType TransformType { get { return (ETransformConstraintType)this[nameof(TransformType)].GetValue<int>(); } set { this[nameof(TransformType)].SetValue<int>((int)value); } }
        public FilterOptionPerAxis PerAxis { get { return this[nameof(PerAxis)].As<FilterOptionPerAxis>(); } set { this["PerAxis"] = value; } }
    }
    public class AnimNode_CopyBone : AnimNode_SkeletalControlBase
    {
        public AnimNode_CopyBone(ulong addr) : base(addr) { }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public bool bCopyTranslation { get { return this[nameof(bCopyTranslation)].Flag; } set { this[nameof(bCopyTranslation)].Flag = value; } }
        public bool bCopyRotation { get { return this[nameof(bCopyRotation)].Flag; } set { this[nameof(bCopyRotation)].Flag = value; } }
        public bool bCopyScale { get { return this[nameof(bCopyScale)].Flag; } set { this[nameof(bCopyScale)].Flag = value; } }
        public byte ControlSpace { get { return this[nameof(ControlSpace)].GetValue<byte>(); } set { this[nameof(ControlSpace)].SetValue<byte>(value); } }
    }
    public class AnimNode_CopyBoneDelta : AnimNode_SkeletalControlBase
    {
        public AnimNode_CopyBoneDelta(ulong addr) : base(addr) { }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public bool bCopyTranslation { get { return this[nameof(bCopyTranslation)].Flag; } set { this[nameof(bCopyTranslation)].Flag = value; } }
        public bool bCopyRotation { get { return this[nameof(bCopyRotation)].Flag; } set { this[nameof(bCopyRotation)].Flag = value; } }
        public bool bCopyScale { get { return this[nameof(bCopyScale)].Flag; } set { this[nameof(bCopyScale)].Flag = value; } }
        public CopyBoneDeltaMode CopyMode { get { return (CopyBoneDeltaMode)this[nameof(CopyMode)].GetValue<int>(); } set { this[nameof(CopyMode)].SetValue<int>((int)value); } }
        public float TranslationMultiplier { get { return this[nameof(TranslationMultiplier)].GetValue<float>(); } set { this[nameof(TranslationMultiplier)].SetValue<float>(value); } }
        public float RotationMultiplier { get { return this[nameof(RotationMultiplier)].GetValue<float>(); } set { this[nameof(RotationMultiplier)].SetValue<float>(value); } }
        public float ScaleMultiplier { get { return this[nameof(ScaleMultiplier)].GetValue<float>(); } set { this[nameof(ScaleMultiplier)].SetValue<float>(value); } }
    }
    public class AnimNode_CopyPoseFromMesh : AnimNode_Base
    {
        public AnimNode_CopyPoseFromMesh(ulong addr) : base(addr) { }
        public Object SourceMeshComponent { get { return this[nameof(SourceMeshComponent)]; } set { this[nameof(SourceMeshComponent)] = value; } }
        public bool bUseAttachedParent { get { return this[nameof(bUseAttachedParent)].Flag; } set { this[nameof(bUseAttachedParent)].Flag = value; } }
        public bool bCopyCurves { get { return this[nameof(bCopyCurves)].Flag; } set { this[nameof(bCopyCurves)].Flag = value; } }
        public bool bCopyCustomAttributes { get { return this[nameof(bCopyCustomAttributes)].Flag; } set { this[nameof(bCopyCustomAttributes)].Flag = value; } }
        public bool bUseMeshPose { get { return this[nameof(bUseMeshPose)].Flag; } set { this[nameof(bUseMeshPose)].Flag = value; } }
        public Object RootBoneToCopy { get { return this[nameof(RootBoneToCopy)]; } set { this[nameof(RootBoneToCopy)] = value; } }
    }
    public class AnimNode_CurveSource : AnimNode_Base
    {
        public AnimNode_CurveSource(ulong addr) : base(addr) { }
        public PoseLink SourcePose { get { return this[nameof(SourcePose)].As<PoseLink>(); } set { this["SourcePose"] = value; } }
        public Object SourceBinding { get { return this[nameof(SourceBinding)]; } set { this[nameof(SourceBinding)] = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public Object CurveSource { get { return this[nameof(CurveSource)]; } set { this[nameof(CurveSource)] = value; } }
    }
    public class AnimNode_Fabrik : AnimNode_SkeletalControlBase
    {
        public AnimNode_Fabrik(ulong addr) : base(addr) { }
        public Transform EffectorTransform { get { return this[nameof(EffectorTransform)].As<Transform>(); } set { this["EffectorTransform"] = value; } }
        public BoneSocketTarget EffectorTarget { get { return this[nameof(EffectorTarget)].As<BoneSocketTarget>(); } set { this["EffectorTarget"] = value; } }
        public BoneReference TipBone { get { return this[nameof(TipBone)].As<BoneReference>(); } set { this["TipBone"] = value; } }
        public BoneReference RootBone { get { return this[nameof(RootBone)].As<BoneReference>(); } set { this["RootBone"] = value; } }
        public float Precision { get { return this[nameof(Precision)].GetValue<float>(); } set { this[nameof(Precision)].SetValue<float>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public byte EffectorTransformSpace { get { return this[nameof(EffectorTransformSpace)].GetValue<byte>(); } set { this[nameof(EffectorTransformSpace)].SetValue<byte>(value); } }
        public byte EffectorRotationSource { get { return this[nameof(EffectorRotationSource)].GetValue<byte>(); } set { this[nameof(EffectorRotationSource)].SetValue<byte>(value); } }
    }
    public class AnimNode_HandIKRetargeting : AnimNode_SkeletalControlBase
    {
        public AnimNode_HandIKRetargeting(ulong addr) : base(addr) { }
        public BoneReference RightHandFK { get { return this[nameof(RightHandFK)].As<BoneReference>(); } set { this["RightHandFK"] = value; } }
        public BoneReference LeftHandFK { get { return this[nameof(LeftHandFK)].As<BoneReference>(); } set { this["LeftHandFK"] = value; } }
        public BoneReference RightHandIK { get { return this[nameof(RightHandIK)].As<BoneReference>(); } set { this["RightHandIK"] = value; } }
        public BoneReference LeftHandIK { get { return this[nameof(LeftHandIK)].As<BoneReference>(); } set { this["LeftHandIK"] = value; } }
        public Array<BoneReference> IKBonesToMove { get { return new Array<BoneReference>(this[nameof(IKBonesToMove)].Address); } }
        public float HandFKWeight { get { return this[nameof(HandFKWeight)].GetValue<float>(); } set { this[nameof(HandFKWeight)].SetValue<float>(value); } }
    }
    public class AnimNode_LayeredBoneBlend : AnimNode_Base
    {
        public AnimNode_LayeredBoneBlend(ulong addr) : base(addr) { }
        public PoseLink BasePose { get { return this[nameof(BasePose)].As<PoseLink>(); } set { this["BasePose"] = value; } }
        public Array<PoseLink> BlendPoses { get { return new Array<PoseLink>(this[nameof(BlendPoses)].Address); } }
        public Array<InputBlendPose> LayerSetup { get { return new Array<InputBlendPose>(this[nameof(LayerSetup)].Address); } }
        public Array<float> BlendWeights { get { return new Array<float>(this[nameof(BlendWeights)].Address); } }
        public bool bMeshSpaceRotationBlend { get { return this[nameof(bMeshSpaceRotationBlend)].Flag; } set { this[nameof(bMeshSpaceRotationBlend)].Flag = value; } }
        public bool bMeshSpaceScaleBlend { get { return this[nameof(bMeshSpaceScaleBlend)].Flag; } set { this[nameof(bMeshSpaceScaleBlend)].Flag = value; } }
        public byte CurveBlendOption { get { return this[nameof(CurveBlendOption)].GetValue<byte>(); } set { this[nameof(CurveBlendOption)].SetValue<byte>(value); } }
        public bool bBlendRootMotionBasedOnRootBone { get { return this[nameof(bBlendRootMotionBasedOnRootBone)].Flag; } set { this[nameof(bBlendRootMotionBasedOnRootBone)].Flag = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
        public Array<PerBoneBlendWeight> PerBoneBlendWeights { get { return new Array<PerBoneBlendWeight>(this[nameof(PerBoneBlendWeights)].Address); } }
        public Guid SkeletonGuid { get { return this[nameof(SkeletonGuid)].As<Guid>(); } set { this["SkeletonGuid"] = value; } }
        public Guid VirtualBoneGuid { get { return this[nameof(VirtualBoneGuid)].As<Guid>(); } set { this["VirtualBoneGuid"] = value; } }
    }
    public class AnimNode_LegIK : AnimNode_SkeletalControlBase
    {
        public AnimNode_LegIK(ulong addr) : base(addr) { }
        public float ReachPrecision { get { return this[nameof(ReachPrecision)].GetValue<float>(); } set { this[nameof(ReachPrecision)].SetValue<float>(value); } }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
        public Array<AnimLegIKDefinition> LegsDefinition { get { return new Array<AnimLegIKDefinition>(this[nameof(LegsDefinition)].Address); } }
    }
    public class AnimLegIKDefinition : Object
    {
        public AnimLegIKDefinition(ulong addr) : base(addr) { }
        public BoneReference IKFootBone { get { return this[nameof(IKFootBone)].As<BoneReference>(); } set { this["IKFootBone"] = value; } }
        public BoneReference FKFootBone { get { return this[nameof(FKFootBone)].As<BoneReference>(); } set { this["FKFootBone"] = value; } }
        public int NumBonesInLimb { get { return this[nameof(NumBonesInLimb)].GetValue<int>(); } set { this[nameof(NumBonesInLimb)].SetValue<int>(value); } }
        public float MinRotationAngle { get { return this[nameof(MinRotationAngle)].GetValue<float>(); } set { this[nameof(MinRotationAngle)].SetValue<float>(value); } }
        public byte FootBoneForwardAxis { get { return this[nameof(FootBoneForwardAxis)].GetValue<byte>(); } set { this[nameof(FootBoneForwardAxis)].SetValue<byte>(value); } }
        public byte HingeRotationAxis { get { return this[nameof(HingeRotationAxis)].GetValue<byte>(); } set { this[nameof(HingeRotationAxis)].SetValue<byte>(value); } }
        public bool bEnableRotationLimit { get { return this[nameof(bEnableRotationLimit)].Flag; } set { this[nameof(bEnableRotationLimit)].Flag = value; } }
        public bool bEnableKneeTwistCorrection { get { return this[nameof(bEnableKneeTwistCorrection)].Flag; } set { this[nameof(bEnableKneeTwistCorrection)].Flag = value; } }
    }
    public class AnimLegIKData : Object
    {
        public AnimLegIKData(ulong addr) : base(addr) { }
    }
    public class IKChain : Object
    {
        public IKChain(ulong addr) : base(addr) { }
    }
    public class IKChainLink : Object
    {
        public IKChainLink(ulong addr) : base(addr) { }
    }
    public class AnimNode_LookAt : AnimNode_SkeletalControlBase
    {
        public AnimNode_LookAt(ulong addr) : base(addr) { }
        public BoneReference BoneToModify { get { return this[nameof(BoneToModify)].As<BoneReference>(); } set { this["BoneToModify"] = value; } }
        public BoneSocketTarget LookAtTarget { get { return this[nameof(LookAtTarget)].As<BoneSocketTarget>(); } set { this["LookAtTarget"] = value; } }
        public Vector LookAtLocation { get { return this[nameof(LookAtLocation)].As<Vector>(); } set { this["LookAtLocation"] = value; } }
        public Axis LookAt_Axis { get { return this[nameof(LookAt_Axis)].As<Axis>(); } set { this["LookAt_Axis"] = value; } }
        public bool bUseLookUpAxis { get { return this[nameof(bUseLookUpAxis)].Flag; } set { this[nameof(bUseLookUpAxis)].Flag = value; } }
        public byte InterpolationType { get { return this[nameof(InterpolationType)].GetValue<byte>(); } set { this[nameof(InterpolationType)].SetValue<byte>(value); } }
        public Axis LookUp_Axis { get { return this[nameof(LookUp_Axis)].As<Axis>(); } set { this["LookUp_Axis"] = value; } }
        public float LookAtClamp { get { return this[nameof(LookAtClamp)].GetValue<float>(); } set { this[nameof(LookAtClamp)].SetValue<float>(value); } }
        public float InterpolationTime { get { return this[nameof(InterpolationTime)].GetValue<float>(); } set { this[nameof(InterpolationTime)].SetValue<float>(value); } }
        public float InterpolationTriggerThreashold { get { return this[nameof(InterpolationTriggerThreashold)].GetValue<float>(); } set { this[nameof(InterpolationTriggerThreashold)].SetValue<float>(value); } }
    }
    public class AnimNode_MakeDynamicAdditive : AnimNode_Base
    {
        public AnimNode_MakeDynamicAdditive(ulong addr) : base(addr) { }
        public PoseLink Base { get { return this[nameof(Base)].As<PoseLink>(); } set { this["Base"] = value; } }
        public PoseLink Additive { get { return this[nameof(Additive)].As<PoseLink>(); } set { this["Additive"] = value; } }
        public bool bMeshSpaceAdditive { get { return this[nameof(bMeshSpaceAdditive)].Flag; } set { this[nameof(bMeshSpaceAdditive)].Flag = value; } }
    }
    public class AnimNode_ModifyBone : AnimNode_SkeletalControlBase
    {
        public AnimNode_ModifyBone(ulong addr) : base(addr) { }
        public BoneReference BoneToModify { get { return this[nameof(BoneToModify)].As<BoneReference>(); } set { this["BoneToModify"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public byte TranslationMode { get { return this[nameof(TranslationMode)].GetValue<byte>(); } set { this[nameof(TranslationMode)].SetValue<byte>(value); } }
        public byte RotationMode { get { return this[nameof(RotationMode)].GetValue<byte>(); } set { this[nameof(RotationMode)].SetValue<byte>(value); } }
        public byte ScaleMode { get { return this[nameof(ScaleMode)].GetValue<byte>(); } set { this[nameof(ScaleMode)].SetValue<byte>(value); } }
        public byte TranslationSpace { get { return this[nameof(TranslationSpace)].GetValue<byte>(); } set { this[nameof(TranslationSpace)].SetValue<byte>(value); } }
        public byte RotationSpace { get { return this[nameof(RotationSpace)].GetValue<byte>(); } set { this[nameof(RotationSpace)].SetValue<byte>(value); } }
        public byte ScaleSpace { get { return this[nameof(ScaleSpace)].GetValue<byte>(); } set { this[nameof(ScaleSpace)].SetValue<byte>(value); } }
    }
    public class AnimNode_ModifyCurve : AnimNode_Base
    {
        public AnimNode_ModifyCurve(ulong addr) : base(addr) { }
        public PoseLink SourcePose { get { return this[nameof(SourcePose)].As<PoseLink>(); } set { this["SourcePose"] = value; } }
        public Array<float> CurveValues { get { return new Array<float>(this[nameof(CurveValues)].Address); } }
        public Array<Object> CurveNames { get { return new Array<Object>(this[nameof(CurveNames)].Address); } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public EModifyCurveApplyMode ApplyMode { get { return (EModifyCurveApplyMode)this[nameof(ApplyMode)].GetValue<int>(); } set { this[nameof(ApplyMode)].SetValue<int>((int)value); } }
    }
    public class AnimNode_MultiWayBlend : AnimNode_Base
    {
        public AnimNode_MultiWayBlend(ulong addr) : base(addr) { }
        public Array<PoseLink> Poses { get { return new Array<PoseLink>(this[nameof(Poses)].Address); } }
        public Array<float> DesiredAlphas { get { return new Array<float>(this[nameof(DesiredAlphas)].Address); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public bool bAdditiveNode { get { return this[nameof(bAdditiveNode)].Flag; } set { this[nameof(bAdditiveNode)].Flag = value; } }
        public bool bNormalizeAlpha { get { return this[nameof(bNormalizeAlpha)].Flag; } set { this[nameof(bNormalizeAlpha)].Flag = value; } }
    }
    public class AnimNode_ObserveBone : AnimNode_SkeletalControlBase
    {
        public AnimNode_ObserveBone(ulong addr) : base(addr) { }
        public BoneReference BoneToObserve { get { return this[nameof(BoneToObserve)].As<BoneReference>(); } set { this["BoneToObserve"] = value; } }
        public byte DisplaySpace { get { return this[nameof(DisplaySpace)].GetValue<byte>(); } set { this[nameof(DisplaySpace)].SetValue<byte>(value); } }
        public bool bRelativeToRefPose { get { return this[nameof(bRelativeToRefPose)].Flag; } set { this[nameof(bRelativeToRefPose)].Flag = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
    }
    public class AnimNode_PoseHandler : AnimNode_AssetPlayerBase
    {
        public AnimNode_PoseHandler(ulong addr) : base(addr) { }
        public PoseAsset PoseAsset { get { return this[nameof(PoseAsset)].As<PoseAsset>(); } set { this["PoseAsset"] = value; } }
    }
    public class AnimNode_PoseBlendNode : AnimNode_PoseHandler
    {
        public AnimNode_PoseBlendNode(ulong addr) : base(addr) { }
        public PoseLink SourcePose { get { return this[nameof(SourcePose)].As<PoseLink>(); } set { this["SourcePose"] = value; } }
        public EAlphaBlendOption BlendOption { get { return (EAlphaBlendOption)this[nameof(BlendOption)].GetValue<int>(); } set { this[nameof(BlendOption)].SetValue<int>((int)value); } }
        public CurveFloat CustomCurve { get { return this[nameof(CustomCurve)].As<CurveFloat>(); } set { this["CustomCurve"] = value; } }
    }
    public class AnimNode_PoseByName : AnimNode_PoseHandler
    {
        public AnimNode_PoseByName(ulong addr) : base(addr) { }
        public Object PoseName { get { return this[nameof(PoseName)]; } set { this[nameof(PoseName)] = value; } }
        public float PoseWeight { get { return this[nameof(PoseWeight)].GetValue<float>(); } set { this[nameof(PoseWeight)].SetValue<float>(value); } }
    }
    public class AnimNode_PoseDriver : AnimNode_PoseHandler
    {
        public AnimNode_PoseDriver(ulong addr) : base(addr) { }
        public PoseLink SourcePose { get { return this[nameof(SourcePose)].As<PoseLink>(); } set { this["SourcePose"] = value; } }
        public Array<BoneReference> SourceBones { get { return new Array<BoneReference>(this[nameof(SourceBones)].Address); } }
        public Array<BoneReference> OnlyDriveBones { get { return new Array<BoneReference>(this[nameof(OnlyDriveBones)].Address); } }
        public Array<PoseDriverTarget> PoseTargets { get { return new Array<PoseDriverTarget>(this[nameof(PoseTargets)].Address); } }
        public BoneReference EvalSpaceBone { get { return this[nameof(EvalSpaceBone)].As<BoneReference>(); } set { this["EvalSpaceBone"] = value; } }
        public RBFParams RBFParams { get { return this[nameof(RBFParams)].As<RBFParams>(); } set { this["RBFParams"] = value; } }
        public EPoseDriverSource DriveSource { get { return (EPoseDriverSource)this[nameof(DriveSource)].GetValue<int>(); } set { this[nameof(DriveSource)].SetValue<int>((int)value); } }
        public EPoseDriverOutput DriveOutput { get { return (EPoseDriverOutput)this[nameof(DriveOutput)].GetValue<int>(); } set { this[nameof(DriveOutput)].SetValue<int>((int)value); } }
        public bool bOnlyDriveSelectedBones { get { return this[nameof(bOnlyDriveSelectedBones)].Flag; } set { this[nameof(bOnlyDriveSelectedBones)].Flag = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
    }
    public class RBFParams : Object
    {
        public RBFParams(ulong addr) : base(addr) { }
        public int TargetDimensions { get { return this[nameof(TargetDimensions)].GetValue<int>(); } set { this[nameof(TargetDimensions)].SetValue<int>(value); } }
        public ERBFSolverType SolverType { get { return (ERBFSolverType)this[nameof(SolverType)].GetValue<int>(); } set { this[nameof(SolverType)].SetValue<int>((int)value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public bool bAutomaticRadius { get { return this[nameof(bAutomaticRadius)].Flag; } set { this[nameof(bAutomaticRadius)].Flag = value; } }
        public ERBFFunctionType Function { get { return (ERBFFunctionType)this[nameof(Function)].GetValue<int>(); } set { this[nameof(Function)].SetValue<int>((int)value); } }
        public ERBFDistanceMethod DistanceMethod { get { return (ERBFDistanceMethod)this[nameof(DistanceMethod)].GetValue<int>(); } set { this[nameof(DistanceMethod)].SetValue<int>((int)value); } }
        public byte TwistAxis { get { return this[nameof(TwistAxis)].GetValue<byte>(); } set { this[nameof(TwistAxis)].SetValue<byte>(value); } }
        public float WeightThreshold { get { return this[nameof(WeightThreshold)].GetValue<float>(); } set { this[nameof(WeightThreshold)].SetValue<float>(value); } }
        public ERBFNormalizeMethod NormalizeMethod { get { return (ERBFNormalizeMethod)this[nameof(NormalizeMethod)].GetValue<int>(); } set { this[nameof(NormalizeMethod)].SetValue<int>((int)value); } }
        public Vector MedianReference { get { return this[nameof(MedianReference)].As<Vector>(); } set { this["MedianReference"] = value; } }
        public float MedianMin { get { return this[nameof(MedianMin)].GetValue<float>(); } set { this[nameof(MedianMin)].SetValue<float>(value); } }
        public float MedianMax { get { return this[nameof(MedianMax)].GetValue<float>(); } set { this[nameof(MedianMax)].SetValue<float>(value); } }
    }
    public class PoseDriverTarget : Object
    {
        public PoseDriverTarget(ulong addr) : base(addr) { }
        public Array<PoseDriverTransform> BoneTransforms { get { return new Array<PoseDriverTransform>(this[nameof(BoneTransforms)].Address); } }
        public Rotator TargetRotation { get { return this[nameof(TargetRotation)].As<Rotator>(); } set { this["TargetRotation"] = value; } }
        public float TargetScale { get { return this[nameof(TargetScale)].GetValue<float>(); } set { this[nameof(TargetScale)].SetValue<float>(value); } }
        public ERBFDistanceMethod DistanceMethod { get { return (ERBFDistanceMethod)this[nameof(DistanceMethod)].GetValue<int>(); } set { this[nameof(DistanceMethod)].SetValue<int>((int)value); } }
        public ERBFFunctionType FunctionType { get { return (ERBFFunctionType)this[nameof(FunctionType)].GetValue<int>(); } set { this[nameof(FunctionType)].SetValue<int>((int)value); } }
        public bool bApplyCustomCurve { get { return this[nameof(bApplyCustomCurve)].Flag; } set { this[nameof(bApplyCustomCurve)].Flag = value; } }
        public RichCurve CustomCurve { get { return this[nameof(CustomCurve)].As<RichCurve>(); } set { this["CustomCurve"] = value; } }
        public Object DrivenName { get { return this[nameof(DrivenName)]; } set { this[nameof(DrivenName)] = value; } }
        public bool bIsHidden { get { return this[nameof(bIsHidden)].Flag; } set { this[nameof(bIsHidden)].Flag = value; } }
    }
    public class PoseDriverTransform : Object
    {
        public PoseDriverTransform(ulong addr) : base(addr) { }
        public Vector TargetTranslation { get { return this[nameof(TargetTranslation)].As<Vector>(); } set { this["TargetTranslation"] = value; } }
        public Rotator TargetRotation { get { return this[nameof(TargetRotation)].As<Rotator>(); } set { this["TargetRotation"] = value; } }
    }
    public class AnimNode_PoseSnapshot : AnimNode_Base
    {
        public AnimNode_PoseSnapshot(ulong addr) : base(addr) { }
        public Object SnapshotName { get { return this[nameof(SnapshotName)]; } set { this[nameof(SnapshotName)] = value; } }
        public PoseSnapshot Snapshot { get { return this[nameof(Snapshot)].As<PoseSnapshot>(); } set { this["Snapshot"] = value; } }
        public ESnapshotSourceMode Mode { get { return (ESnapshotSourceMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
    }
    public class AnimNode_RandomPlayer : AnimNode_Base
    {
        public AnimNode_RandomPlayer(ulong addr) : base(addr) { }
        public Array<RandomPlayerSequenceEntry> Entries { get { return new Array<RandomPlayerSequenceEntry>(this[nameof(Entries)].Address); } }
        public bool bShuffleMode { get { return this[nameof(bShuffleMode)].Flag; } set { this[nameof(bShuffleMode)].Flag = value; } }
    }
    public class RandomPlayerSequenceEntry : Object
    {
        public RandomPlayerSequenceEntry(ulong addr) : base(addr) { }
        public AnimSequence Sequence { get { return this[nameof(Sequence)].As<AnimSequence>(); } set { this["Sequence"] = value; } }
        public float ChanceToPlay { get { return this[nameof(ChanceToPlay)].GetValue<float>(); } set { this[nameof(ChanceToPlay)].SetValue<float>(value); } }
        public int MinLoopCount { get { return this[nameof(MinLoopCount)].GetValue<int>(); } set { this[nameof(MinLoopCount)].SetValue<int>(value); } }
        public int MaxLoopCount { get { return this[nameof(MaxLoopCount)].GetValue<int>(); } set { this[nameof(MaxLoopCount)].SetValue<int>(value); } }
        public float MinPlayRate { get { return this[nameof(MinPlayRate)].GetValue<float>(); } set { this[nameof(MinPlayRate)].SetValue<float>(value); } }
        public float MaxPlayRate { get { return this[nameof(MaxPlayRate)].GetValue<float>(); } set { this[nameof(MaxPlayRate)].SetValue<float>(value); } }
        public AlphaBlend BlendIn { get { return this[nameof(BlendIn)].As<AlphaBlend>(); } set { this["BlendIn"] = value; } }
    }
    public class AnimNode_MeshSpaceRefPose : AnimNode_Base
    {
        public AnimNode_MeshSpaceRefPose(ulong addr) : base(addr) { }
    }
    public class AnimNode_RefPose : AnimNode_Base
    {
        public AnimNode_RefPose(ulong addr) : base(addr) { }
        public byte RefPoseType { get { return this[nameof(RefPoseType)].GetValue<byte>(); } set { this[nameof(RefPoseType)].SetValue<byte>(value); } }
    }
    public class AnimNode_ResetRoot : AnimNode_SkeletalControlBase
    {
        public AnimNode_ResetRoot(ulong addr) : base(addr) { }
    }
    public class AnimNode_RigidBody : AnimNode_SkeletalControlBase
    {
        public AnimNode_RigidBody(ulong addr) : base(addr) { }
        public PhysicsAsset OverridePhysicsAsset { get { return this[nameof(OverridePhysicsAsset)].As<PhysicsAsset>(); } set { this["OverridePhysicsAsset"] = value; } }
        public Vector OverrideWorldGravity { get { return this[nameof(OverrideWorldGravity)].As<Vector>(); } set { this["OverrideWorldGravity"] = value; } }
        public Vector ExternalForce { get { return this[nameof(ExternalForce)].As<Vector>(); } set { this["ExternalForce"] = value; } }
        public Vector ComponentLinearAccScale { get { return this[nameof(ComponentLinearAccScale)].As<Vector>(); } set { this["ComponentLinearAccScale"] = value; } }
        public Vector ComponentLinearVelScale { get { return this[nameof(ComponentLinearVelScale)].As<Vector>(); } set { this["ComponentLinearVelScale"] = value; } }
        public Vector ComponentAppliedLinearAccClamp { get { return this[nameof(ComponentAppliedLinearAccClamp)].As<Vector>(); } set { this["ComponentAppliedLinearAccClamp"] = value; } }
        public SimSpaceSettings SimSpaceSettings { get { return this[nameof(SimSpaceSettings)].As<SimSpaceSettings>(); } set { this["SimSpaceSettings"] = value; } }
        public float CachedBoundsScale { get { return this[nameof(CachedBoundsScale)].GetValue<float>(); } set { this[nameof(CachedBoundsScale)].SetValue<float>(value); } }
        public BoneReference BaseBoneRef { get { return this[nameof(BaseBoneRef)].As<BoneReference>(); } set { this["BaseBoneRef"] = value; } }
        public byte OverlapChannel { get { return this[nameof(OverlapChannel)].GetValue<byte>(); } set { this[nameof(OverlapChannel)].SetValue<byte>(value); } }
        public ESimulationSpace SimulationSpace { get { return (ESimulationSpace)this[nameof(SimulationSpace)].GetValue<int>(); } set { this[nameof(SimulationSpace)].SetValue<int>((int)value); } }
        public bool bForceDisableCollisionBetweenConstraintBodies { get { return this[nameof(bForceDisableCollisionBetweenConstraintBodies)].Flag; } set { this[nameof(bForceDisableCollisionBetweenConstraintBodies)].Flag = value; } }
        public bool bEnableWorldGeometry { get { return this[nameof(bEnableWorldGeometry)].Flag; } set { this[nameof(bEnableWorldGeometry)].Flag = value; } }
        public bool bOverrideWorldGravity { get { return this[nameof(bOverrideWorldGravity)].Flag; } set { this[nameof(bOverrideWorldGravity)].Flag = value; } }
        public bool bTransferBoneVelocities { get { return this[nameof(bTransferBoneVelocities)].Flag; } set { this[nameof(bTransferBoneVelocities)].Flag = value; } }
        public bool bFreezeIncomingPoseOnStart { get { return this[nameof(bFreezeIncomingPoseOnStart)].Flag; } set { this[nameof(bFreezeIncomingPoseOnStart)].Flag = value; } }
        public bool bClampLinearTranslationLimitToRefPose { get { return this[nameof(bClampLinearTranslationLimitToRefPose)].Flag; } set { this[nameof(bClampLinearTranslationLimitToRefPose)].Flag = value; } }
        public float WorldSpaceMinimumScale { get { return this[nameof(WorldSpaceMinimumScale)].GetValue<float>(); } set { this[nameof(WorldSpaceMinimumScale)].SetValue<float>(value); } }
        public float EvaluationResetTime { get { return this[nameof(EvaluationResetTime)].GetValue<float>(); } set { this[nameof(EvaluationResetTime)].SetValue<float>(value); } }
    }
    public class SimSpaceSettings : Object
    {
        public SimSpaceSettings(ulong addr) : base(addr) { }
        public float MasterAlpha { get { return this[nameof(MasterAlpha)].GetValue<float>(); } set { this[nameof(MasterAlpha)].SetValue<float>(value); } }
        public float VelocityScaleZ { get { return this[nameof(VelocityScaleZ)].GetValue<float>(); } set { this[nameof(VelocityScaleZ)].SetValue<float>(value); } }
        public float MaxLinearVelocity { get { return this[nameof(MaxLinearVelocity)].GetValue<float>(); } set { this[nameof(MaxLinearVelocity)].SetValue<float>(value); } }
        public float MaxAngularVelocity { get { return this[nameof(MaxAngularVelocity)].GetValue<float>(); } set { this[nameof(MaxAngularVelocity)].SetValue<float>(value); } }
        public float MaxLinearAcceleration { get { return this[nameof(MaxLinearAcceleration)].GetValue<float>(); } set { this[nameof(MaxLinearAcceleration)].SetValue<float>(value); } }
        public float MaxAngularAcceleration { get { return this[nameof(MaxAngularAcceleration)].GetValue<float>(); } set { this[nameof(MaxAngularAcceleration)].SetValue<float>(value); } }
        public float ExternalLinearDrag { get { return this[nameof(ExternalLinearDrag)].GetValue<float>(); } set { this[nameof(ExternalLinearDrag)].SetValue<float>(value); } }
        public Vector ExternalLinearDragV { get { return this[nameof(ExternalLinearDragV)].As<Vector>(); } set { this["ExternalLinearDragV"] = value; } }
        public Vector ExternalLinearVelocity { get { return this[nameof(ExternalLinearVelocity)].As<Vector>(); } set { this["ExternalLinearVelocity"] = value; } }
        public Vector ExternalAngularVelocity { get { return this[nameof(ExternalAngularVelocity)].As<Vector>(); } set { this["ExternalAngularVelocity"] = value; } }
    }
    public class AnimNode_RotateRootBone : AnimNode_Base
    {
        public AnimNode_RotateRootBone(ulong addr) : base(addr) { }
        public PoseLink BasePose { get { return this[nameof(BasePose)].As<PoseLink>(); } set { this["BasePose"] = value; } }
        public float Pitch { get { return this[nameof(Pitch)].GetValue<float>(); } set { this[nameof(Pitch)].SetValue<float>(value); } }
        public float Yaw { get { return this[nameof(Yaw)].GetValue<float>(); } set { this[nameof(Yaw)].SetValue<float>(value); } }
        public InputScaleBiasClamp PitchScaleBiasClamp { get { return this[nameof(PitchScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["PitchScaleBiasClamp"] = value; } }
        public InputScaleBiasClamp YawScaleBiasClamp { get { return this[nameof(YawScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["YawScaleBiasClamp"] = value; } }
        public Rotator MeshToComponent { get { return this[nameof(MeshToComponent)].As<Rotator>(); } set { this["MeshToComponent"] = value; } }
    }
    public class AnimNode_RotationMultiplier : AnimNode_SkeletalControlBase
    {
        public AnimNode_RotationMultiplier(ulong addr) : base(addr) { }
        public BoneReference TargetBone { get { return this[nameof(TargetBone)].As<BoneReference>(); } set { this["TargetBone"] = value; } }
        public BoneReference SourceBone { get { return this[nameof(SourceBone)].As<BoneReference>(); } set { this["SourceBone"] = value; } }
        public float Multiplier { get { return this[nameof(Multiplier)].GetValue<float>(); } set { this[nameof(Multiplier)].SetValue<float>(value); } }
        public byte RotationAxisToRefer { get { return this[nameof(RotationAxisToRefer)].GetValue<byte>(); } set { this[nameof(RotationAxisToRefer)].SetValue<byte>(value); } }
        public bool bIsAdditive { get { return this[nameof(bIsAdditive)].Flag; } set { this[nameof(bIsAdditive)].Flag = value; } }
    }
    public class AnimNode_RotationOffsetBlendSpace : AnimNode_BlendSpacePlayer
    {
        public AnimNode_RotationOffsetBlendSpace(ulong addr) : base(addr) { }
        public PoseLink BasePose { get { return this[nameof(BasePose)].As<PoseLink>(); } set { this["BasePose"] = value; } }
        public int LODThreshold { get { return this[nameof(LODThreshold)].GetValue<int>(); } set { this[nameof(LODThreshold)].SetValue<int>(value); } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public InputAlphaBoolBlend AlphaBoolBlend { get { return this[nameof(AlphaBoolBlend)].As<InputAlphaBoolBlend>(); } set { this["AlphaBoolBlend"] = value; } }
        public Object AlphaCurveName { get { return this[nameof(AlphaCurveName)]; } set { this[nameof(AlphaCurveName)] = value; } }
        public InputScaleBiasClamp AlphaScaleBiasClamp { get { return this[nameof(AlphaScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["AlphaScaleBiasClamp"] = value; } }
        public EAnimAlphaInputType AlphaInputType { get { return (EAnimAlphaInputType)this[nameof(AlphaInputType)].GetValue<int>(); } set { this[nameof(AlphaInputType)].SetValue<int>((int)value); } }
        public bool bAlphaBoolEnabled { get { return this[nameof(bAlphaBoolEnabled)].Flag; } set { this[nameof(bAlphaBoolEnabled)].Flag = value; } }
    }
    public class AnimNode_ScaleChainLength : AnimNode_Base
    {
        public AnimNode_ScaleChainLength(ulong addr) : base(addr) { }
        public PoseLink InputPose { get { return this[nameof(InputPose)].As<PoseLink>(); } set { this["InputPose"] = value; } }
        public float DefaultChainLength { get { return this[nameof(DefaultChainLength)].GetValue<float>(); } set { this[nameof(DefaultChainLength)].SetValue<float>(value); } }
        public BoneReference ChainStartBone { get { return this[nameof(ChainStartBone)].As<BoneReference>(); } set { this["ChainStartBone"] = value; } }
        public BoneReference ChainEndBone { get { return this[nameof(ChainEndBone)].As<BoneReference>(); } set { this["ChainEndBone"] = value; } }
        public Vector TargetLocation { get { return this[nameof(TargetLocation)].As<Vector>(); } set { this["TargetLocation"] = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public EScaleChainInitialLength ChainInitialLength { get { return (EScaleChainInitialLength)this[nameof(ChainInitialLength)].GetValue<int>(); } set { this[nameof(ChainInitialLength)].SetValue<int>((int)value); } }
    }
    public class AnimNode_SequenceEvaluator : AnimNode_AssetPlayerBase
    {
        public AnimNode_SequenceEvaluator(ulong addr) : base(addr) { }
        public AnimSequenceBase Sequence { get { return this[nameof(Sequence)].As<AnimSequenceBase>(); } set { this["Sequence"] = value; } }
        public float ExplicitTime { get { return this[nameof(ExplicitTime)].GetValue<float>(); } set { this[nameof(ExplicitTime)].SetValue<float>(value); } }
        public bool bShouldLoop { get { return this[nameof(bShouldLoop)].Flag; } set { this[nameof(bShouldLoop)].Flag = value; } }
        public bool bTeleportToExplicitTime { get { return this[nameof(bTeleportToExplicitTime)].Flag; } set { this[nameof(bTeleportToExplicitTime)].Flag = value; } }
        public byte ReinitializationBehavior { get { return this[nameof(ReinitializationBehavior)].GetValue<byte>(); } set { this[nameof(ReinitializationBehavior)].SetValue<byte>(value); } }
        public float StartPosition { get { return this[nameof(StartPosition)].GetValue<float>(); } set { this[nameof(StartPosition)].SetValue<float>(value); } }
    }
    public class AnimNode_Slot : AnimNode_Base
    {
        public AnimNode_Slot(ulong addr) : base(addr) { }
        public PoseLink Source { get { return this[nameof(Source)].As<PoseLink>(); } set { this["Source"] = value; } }
        public Object SlotName { get { return this[nameof(SlotName)]; } set { this[nameof(SlotName)] = value; } }
        public bool bAlwaysUpdateSourcePose { get { return this[nameof(bAlwaysUpdateSourcePose)].Flag; } set { this[nameof(bAlwaysUpdateSourcePose)].Flag = value; } }
    }
    public class AnimNode_SplineIK : AnimNode_SkeletalControlBase
    {
        public AnimNode_SplineIK(ulong addr) : base(addr) { }
        public BoneReference StartBone { get { return this[nameof(StartBone)].As<BoneReference>(); } set { this["StartBone"] = value; } }
        public BoneReference EndBone { get { return this[nameof(EndBone)].As<BoneReference>(); } set { this["EndBone"] = value; } }
        public ESplineBoneAxis BoneAxis { get { return (ESplineBoneAxis)this[nameof(BoneAxis)].GetValue<int>(); } set { this[nameof(BoneAxis)].SetValue<int>((int)value); } }
        public bool bAutoCalculateSpline { get { return this[nameof(bAutoCalculateSpline)].Flag; } set { this[nameof(bAutoCalculateSpline)].Flag = value; } }
        public int PointCount { get { return this[nameof(PointCount)].GetValue<int>(); } set { this[nameof(PointCount)].SetValue<int>(value); } }
        public Array<Transform> ControlPoints { get { return new Array<Transform>(this[nameof(ControlPoints)].Address); } }
        public float Roll { get { return this[nameof(Roll)].GetValue<float>(); } set { this[nameof(Roll)].SetValue<float>(value); } }
        public float TwistStart { get { return this[nameof(TwistStart)].GetValue<float>(); } set { this[nameof(TwistStart)].SetValue<float>(value); } }
        public float TwistEnd { get { return this[nameof(TwistEnd)].GetValue<float>(); } set { this[nameof(TwistEnd)].SetValue<float>(value); } }
        public AlphaBlend TwistBlend { get { return this[nameof(TwistBlend)].As<AlphaBlend>(); } set { this["TwistBlend"] = value; } }
        public float Stretch { get { return this[nameof(Stretch)].GetValue<float>(); } set { this[nameof(Stretch)].SetValue<float>(value); } }
        public float Offset { get { return this[nameof(Offset)].GetValue<float>(); } set { this[nameof(Offset)].SetValue<float>(value); } }
    }
    public class SplineIKCachedBoneData : Object
    {
        public SplineIKCachedBoneData(ulong addr) : base(addr) { }
        public BoneReference Bone { get { return this[nameof(Bone)].As<BoneReference>(); } set { this["Bone"] = value; } }
        public int RefSkeletonIndex { get { return this[nameof(RefSkeletonIndex)].GetValue<int>(); } set { this[nameof(RefSkeletonIndex)].SetValue<int>(value); } }
    }
    public class AnimNode_SpringBone : AnimNode_SkeletalControlBase
    {
        public AnimNode_SpringBone(ulong addr) : base(addr) { }
        public BoneReference SpringBone { get { return this[nameof(SpringBone)].As<BoneReference>(); } set { this["SpringBone"] = value; } }
        public float MaxDisplacement { get { return this[nameof(MaxDisplacement)].GetValue<float>(); } set { this[nameof(MaxDisplacement)].SetValue<float>(value); } }
        public float SpringStiffness { get { return this[nameof(SpringStiffness)].GetValue<float>(); } set { this[nameof(SpringStiffness)].SetValue<float>(value); } }
        public float SpringDamping { get { return this[nameof(SpringDamping)].GetValue<float>(); } set { this[nameof(SpringDamping)].SetValue<float>(value); } }
        public float ErrorResetThresh { get { return this[nameof(ErrorResetThresh)].GetValue<float>(); } set { this[nameof(ErrorResetThresh)].SetValue<float>(value); } }
        public bool bLimitDisplacement { get { return this[nameof(bLimitDisplacement)].Flag; } set { this[nameof(bLimitDisplacement)].Flag = value; } }
        public bool bTranslateX { get { return this[nameof(bTranslateX)].Flag; } set { this[nameof(bTranslateX)].Flag = value; } }
        public bool bTranslateY { get { return this[nameof(bTranslateY)].Flag; } set { this[nameof(bTranslateY)].Flag = value; } }
        public bool bTranslateZ { get { return this[nameof(bTranslateZ)].Flag; } set { this[nameof(bTranslateZ)].Flag = value; } }
        public bool bRotateX { get { return this[nameof(bRotateX)].Flag; } set { this[nameof(bRotateX)].Flag = value; } }
        public bool bRotateY { get { return this[nameof(bRotateY)].Flag; } set { this[nameof(bRotateY)].Flag = value; } }
        public bool bRotateZ { get { return this[nameof(bRotateZ)].Flag; } set { this[nameof(bRotateZ)].Flag = value; } }
    }
    public class AnimNode_StateResult : AnimNode_Root
    {
        public AnimNode_StateResult(ulong addr) : base(addr) { }
    }
    public class AnimNode_Trail : AnimNode_SkeletalControlBase
    {
        public AnimNode_Trail(ulong addr) : base(addr) { }
        public BoneReference TrailBone { get { return this[nameof(TrailBone)].As<BoneReference>(); } set { this["TrailBone"] = value; } }
        public int ChainLength { get { return this[nameof(ChainLength)].GetValue<int>(); } set { this[nameof(ChainLength)].SetValue<int>(value); } }
        public byte ChainBoneAxis { get { return this[nameof(ChainBoneAxis)].GetValue<byte>(); } set { this[nameof(ChainBoneAxis)].SetValue<byte>(value); } }
        public bool bInvertChainBoneAxis { get { return this[nameof(bInvertChainBoneAxis)].Flag; } set { this[nameof(bInvertChainBoneAxis)].Flag = value; } }
        public bool bLimitStretch { get { return this[nameof(bLimitStretch)].Flag; } set { this[nameof(bLimitStretch)].Flag = value; } }
        public bool bLimitRotation { get { return this[nameof(bLimitRotation)].Flag; } set { this[nameof(bLimitRotation)].Flag = value; } }
        public bool bUsePlanarLimit { get { return this[nameof(bUsePlanarLimit)].Flag; } set { this[nameof(bUsePlanarLimit)].Flag = value; } }
        public bool bActorSpaceFakeVel { get { return this[nameof(bActorSpaceFakeVel)].Flag; } set { this[nameof(bActorSpaceFakeVel)].Flag = value; } }
        public bool bReorientParentToChild { get { return this[nameof(bReorientParentToChild)].Flag; } set { this[nameof(bReorientParentToChild)].Flag = value; } }
        public float MaxDeltaTime { get { return this[nameof(MaxDeltaTime)].GetValue<float>(); } set { this[nameof(MaxDeltaTime)].SetValue<float>(value); } }
        public float RelaxationSpeedScale { get { return this[nameof(RelaxationSpeedScale)].GetValue<float>(); } set { this[nameof(RelaxationSpeedScale)].SetValue<float>(value); } }
        public RuntimeFloatCurve TrailRelaxationSpeed { get { return this[nameof(TrailRelaxationSpeed)].As<RuntimeFloatCurve>(); } set { this["TrailRelaxationSpeed"] = value; } }
        public InputScaleBiasClamp RelaxationSpeedScaleInputProcessor { get { return this[nameof(RelaxationSpeedScaleInputProcessor)].As<InputScaleBiasClamp>(); } set { this["RelaxationSpeedScaleInputProcessor"] = value; } }
        public Array<RotationLimit> RotationLimits { get { return new Array<RotationLimit>(this[nameof(RotationLimits)].Address); } }
        public Array<Vector> RotationOffsets { get { return new Array<Vector>(this[nameof(RotationOffsets)].Address); } }
        public Array<AnimPhysPlanarLimit> PlanarLimits { get { return new Array<AnimPhysPlanarLimit>(this[nameof(PlanarLimits)].Address); } }
        public float StretchLimit { get { return this[nameof(StretchLimit)].GetValue<float>(); } set { this[nameof(StretchLimit)].SetValue<float>(value); } }
        public Vector FakeVelocity { get { return this[nameof(FakeVelocity)].As<Vector>(); } set { this["FakeVelocity"] = value; } }
        public BoneReference BaseJoint { get { return this[nameof(BaseJoint)].As<BoneReference>(); } set { this["BaseJoint"] = value; } }
        public float LastBoneRotationAnimAlphaBlend { get { return this[nameof(LastBoneRotationAnimAlphaBlend)].GetValue<float>(); } set { this[nameof(LastBoneRotationAnimAlphaBlend)].SetValue<float>(value); } }
    }
    public class RotationLimit : Object
    {
        public RotationLimit(ulong addr) : base(addr) { }
        public Vector LimitMin { get { return this[nameof(LimitMin)].As<Vector>(); } set { this["LimitMin"] = value; } }
        public Vector LimitMax { get { return this[nameof(LimitMax)].As<Vector>(); } set { this["LimitMax"] = value; } }
    }
    public class AnimNode_TwistCorrectiveNode : AnimNode_SkeletalControlBase
    {
        public AnimNode_TwistCorrectiveNode(ulong addr) : base(addr) { }
        public ReferenceBoneFrame BaseFrame { get { return this[nameof(BaseFrame)].As<ReferenceBoneFrame>(); } set { this["BaseFrame"] = value; } }
        public ReferenceBoneFrame TwistFrame { get { return this[nameof(TwistFrame)].As<ReferenceBoneFrame>(); } set { this["TwistFrame"] = value; } }
        public Axis TwistPlaneNormalAxis { get { return this[nameof(TwistPlaneNormalAxis)].As<Axis>(); } set { this["TwistPlaneNormalAxis"] = value; } }
        public float RangeMax { get { return this[nameof(RangeMax)].GetValue<float>(); } set { this[nameof(RangeMax)].SetValue<float>(value); } }
        public float RemappedMin { get { return this[nameof(RemappedMin)].GetValue<float>(); } set { this[nameof(RemappedMin)].SetValue<float>(value); } }
        public float RemappedMax { get { return this[nameof(RemappedMax)].GetValue<float>(); } set { this[nameof(RemappedMax)].SetValue<float>(value); } }
        public AnimCurveParam Curve { get { return this[nameof(Curve)].As<AnimCurveParam>(); } set { this["Curve"] = value; } }
    }
    public class ReferenceBoneFrame : Object
    {
        public ReferenceBoneFrame(ulong addr) : base(addr) { }
        public BoneReference Bone { get { return this[nameof(Bone)].As<BoneReference>(); } set { this["Bone"] = value; } }
        public Axis Axis { get { return this[nameof(Axis)].As<Axis>(); } set { this["Axis"] = value; } }
    }
    public class AnimNode_TwoBoneIK : AnimNode_SkeletalControlBase
    {
        public AnimNode_TwoBoneIK(ulong addr) : base(addr) { }
        public BoneReference IKBone { get { return this[nameof(IKBone)].As<BoneReference>(); } set { this["IKBone"] = value; } }
        public float StartStretchRatio { get { return this[nameof(StartStretchRatio)].GetValue<float>(); } set { this[nameof(StartStretchRatio)].SetValue<float>(value); } }
        public float MaxStretchScale { get { return this[nameof(MaxStretchScale)].GetValue<float>(); } set { this[nameof(MaxStretchScale)].SetValue<float>(value); } }
        public Vector EffectorLocation { get { return this[nameof(EffectorLocation)].As<Vector>(); } set { this["EffectorLocation"] = value; } }
        public BoneSocketTarget EffectorTarget { get { return this[nameof(EffectorTarget)].As<BoneSocketTarget>(); } set { this["EffectorTarget"] = value; } }
        public Vector JointTargetLocation { get { return this[nameof(JointTargetLocation)].As<Vector>(); } set { this["JointTargetLocation"] = value; } }
        public BoneSocketTarget JointTarget { get { return this[nameof(JointTarget)].As<BoneSocketTarget>(); } set { this["JointTarget"] = value; } }
        public Axis TwistAxis { get { return this[nameof(TwistAxis)].As<Axis>(); } set { this["TwistAxis"] = value; } }
        public byte EffectorLocationSpace { get { return this[nameof(EffectorLocationSpace)].GetValue<byte>(); } set { this[nameof(EffectorLocationSpace)].SetValue<byte>(value); } }
        public byte JointTargetLocationSpace { get { return this[nameof(JointTargetLocationSpace)].GetValue<byte>(); } set { this[nameof(JointTargetLocationSpace)].SetValue<byte>(value); } }
        public bool bAllowStretching { get { return this[nameof(bAllowStretching)].Flag; } set { this[nameof(bAllowStretching)].Flag = value; } }
        public bool bTakeRotationFromEffectorSpace { get { return this[nameof(bTakeRotationFromEffectorSpace)].Flag; } set { this[nameof(bTakeRotationFromEffectorSpace)].Flag = value; } }
        public bool bMaintainEffectorRelRot { get { return this[nameof(bMaintainEffectorRelRot)].Flag; } set { this[nameof(bMaintainEffectorRelRot)].Flag = value; } }
        public bool bAllowTwist { get { return this[nameof(bAllowTwist)].Flag; } set { this[nameof(bAllowTwist)].Flag = value; } }
    }
    public class AnimNode_TwoWayBlend : AnimNode_Base
    {
        public AnimNode_TwoWayBlend(ulong addr) : base(addr) { }
        public PoseLink A { get { return this[nameof(A)].As<PoseLink>(); } set { this["A"] = value; } }
        public PoseLink B { get { return this[nameof(B)].As<PoseLink>(); } set { this["B"] = value; } }
        public EAnimAlphaInputType AlphaInputType { get { return (EAnimAlphaInputType)this[nameof(AlphaInputType)].GetValue<int>(); } set { this[nameof(AlphaInputType)].SetValue<int>((int)value); } }
        public bool bAlphaBoolEnabled { get { return this[nameof(bAlphaBoolEnabled)].Flag; } set { this[nameof(bAlphaBoolEnabled)].Flag = value; } }
        public bool bResetChildOnActivation { get { return this[nameof(bResetChildOnActivation)].Flag; } set { this[nameof(bResetChildOnActivation)].Flag = value; } }
        public float ALPHA { get { return this[nameof(ALPHA)].GetValue<float>(); } set { this[nameof(ALPHA)].SetValue<float>(value); } }
        public InputScaleBias AlphaScaleBias { get { return this[nameof(AlphaScaleBias)].As<InputScaleBias>(); } set { this["AlphaScaleBias"] = value; } }
        public InputAlphaBoolBlend AlphaBoolBlend { get { return this[nameof(AlphaBoolBlend)].As<InputAlphaBoolBlend>(); } set { this["AlphaBoolBlend"] = value; } }
        public Object AlphaCurveName { get { return this[nameof(AlphaCurveName)]; } set { this[nameof(AlphaCurveName)] = value; } }
        public InputScaleBiasClamp AlphaScaleBiasClamp { get { return this[nameof(AlphaScaleBiasClamp)].As<InputScaleBiasClamp>(); } set { this["AlphaScaleBiasClamp"] = value; } }
    }
    public class AnimSequencerInstanceProxy : AnimInstanceProxy
    {
        public AnimSequencerInstanceProxy(ulong addr) : base(addr) { }
    }
    public class PositionHistory : Object
    {
        public PositionHistory(ulong addr) : base(addr) { }
        public Array<Vector> Positions { get { return new Array<Vector>(this[nameof(Positions)].Address); } }
        public float Range { get { return this[nameof(Range)].GetValue<float>(); } set { this[nameof(Range)].SetValue<float>(value); } }
    }
    public class RBFEntry : Object
    {
        public RBFEntry(ulong addr) : base(addr) { }
        public Array<float> Values { get { return new Array<float>(this[nameof(Values)].Address); } }
    }
    public class RBFTarget : RBFEntry
    {
        public RBFTarget(ulong addr) : base(addr) { }
        public float ScaleFactor { get { return this[nameof(ScaleFactor)].GetValue<float>(); } set { this[nameof(ScaleFactor)].SetValue<float>(value); } }
        public bool bApplyCustomCurve { get { return this[nameof(bApplyCustomCurve)].Flag; } set { this[nameof(bApplyCustomCurve)].Flag = value; } }
        public RichCurve CustomCurve { get { return this[nameof(CustomCurve)].As<RichCurve>(); } set { this["CustomCurve"] = value; } }
        public ERBFDistanceMethod DistanceMethod { get { return (ERBFDistanceMethod)this[nameof(DistanceMethod)].GetValue<int>(); } set { this[nameof(DistanceMethod)].SetValue<int>((int)value); } }
        public ERBFFunctionType FunctionType { get { return (ERBFFunctionType)this[nameof(FunctionType)].GetValue<int>(); } set { this[nameof(FunctionType)].SetValue<int>((int)value); } }
    }
}
