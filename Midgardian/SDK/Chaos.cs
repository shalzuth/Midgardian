using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ChaosSDK
{
    public enum EClusterUnionMethod : int
    {
        PointImplicit = 0,
        DelaunayTriangulation = 1,
        MinimalSpanningSubsetDelaunayTriangulation = 2,
        PointImplicitAugmentedWithMinimalDelaunay = 3,
        None = 4,
        EClusterUnionMethod_MAX = 5,
    }
    public enum EFieldPhysicsDefaultFields : int
    {
        Field_RadialIntMask = 0,
        Field_RadialFalloff = 1,
        Field_UniformVector = 2,
        Field_RadialVector = 3,
        Field_RadialVectorFalloff = 4,
        Field_EFieldPhysicsDefaultFields_Max = 5,
        Field_MAX = 6,
    }
    public enum EFieldPhysicsType : int
    {
        Field_None = 0,
        Field_DynamicState = 1,
        Field_LinearForce = 2,
        Field_ExternalClusterStrain = 3,
        Field_Kill = 4,
        Field_LinearVelocity = 5,
        Field_AngularVelociy = 6,
        Field_AngularTorque = 7,
        Field_InternalClusterStrain = 8,
        Field_DisableThreshold = 9,
        Field_SleepingThreshold = 10,
        Field_PositionStatic = 11,
        Field_PositionAnimated = 12,
        Field_PositionTarget = 13,
        Field_DynamicConstraint = 14,
        Field_CollisionGroup = 15,
        Field_ActivateDisabled = 16,
        Field_PhysicsType_Max = 17,
    }
    public enum EFieldFalloffType : int
    {
        Field_FallOff_None = 0,
        Field_Falloff_Linear = 1,
        Field_Falloff_Inverse = 2,
        Field_Falloff_Squared = 3,
        Field_Falloff_Logarithmic = 4,
        Field_Falloff_Max = 5,
    }
    public enum EFieldResolutionType : int
    {
        Field_Resolution_Minimal = 0,
        Field_Resolution_DisabledParents = 1,
        Field_Resolution_Maximum = 2,
        Field_Resolution_Max = 3,
    }
    public enum EFieldCullingOperationType : int
    {
        Field_Culling_Inside = 0,
        Field_Culling_Outside = 1,
        Field_Culling_Operation_Max = 2,
        Field_Culling_MAX = 3,
    }
    public enum EFieldOperationType : int
    {
        Field_Multiply = 0,
        Field_Divide = 1,
        Field_Add = 2,
        Field_Substract = 3,
        Field_Operation_Max = 4,
    }
    public enum ESetMaskConditionType : int
    {
        Field_Set_Always = 0,
        Field_Set_IFF_NOT_Interior = 1,
        Field_Set_IFF_NOT_Exterior = 2,
        Field_MaskCondition_Max = 3,
    }
    public enum EEmissionPatternTypeEnum : int
    {
        Chaos_Emission_Pattern_First_Frame = 0,
        Chaos_Emission_Pattern_On_Demand = 1,
        Chaos_Max = 2,
    }
    public enum EInitialVelocityTypeEnum : int
    {
        Chaos_Initial_Velocity_User_Defined = 0,
        Chaos_Initial_Velocity_None = 1,
        Chaos_Max = 2,
    }
    public enum EGeometryCollectionPhysicsTypeEnum : int
    {
        Chaos_AngularVelocity = 0,
        Chaos_DynamicState = 1,
        Chaos_LinearVelocity = 2,
        Chaos_InitialAngularVelocity = 3,
        Chaos_InitialLinearVelocity = 4,
        Chaos_CollisionGroup = 5,
        Chaos_LinearForce = 6,
        Chaos_AngularTorque = 7,
        Chaos_Max = 8,
    }
    public enum EObjectStateTypeEnum : int
    {
        Chaos_NONE = 0,
        Chaos_Object_Sleeping = 1,
        Chaos_Object_Kinematic = 2,
        Chaos_Object_Static = 3,
        Chaos_Object_Dynamic = 4,
        Chaos_Object_UserDefined = 100,
        Chaos_Max = 101,
    }
    public enum EImplicitTypeEnum : int
    {
        Chaos_Implicit_Box = 0,
        Chaos_Implicit_Sphere = 1,
        Chaos_Implicit_Capsule = 2,
        Chaos_Implicit_LevelSet = 3,
        Chaos_Implicit_None = 4,
        Chaos_Max = 5,
    }
    public enum ECollisionTypeEnum : int
    {
        Chaos_Volumetric = 0,
        Chaos_Surface_Volumetric = 1,
        Chaos_Max = 2,
    }
    public enum EChaosBufferMode : int
    {
        Double = 0,
        Triple = 1,
        Num = 2,
        Invalid = 3,
        EChaosBufferMode_MAX = 4,
    }
    public enum EChaosThreadingMode : int
    {
        DedicatedThread = 0,
        TaskGraph = 1,
        SingleThread = 2,
        Num = 3,
        Invalid = 4,
        EChaosThreadingMode_MAX = 5,
    }
    public enum EChaosSolverTickMode : int
    {
        Fixed = 0,
        Variable = 1,
        VariableCapped = 2,
        VariableCappedWithTarget = 3,
        EChaosSolverTickMode_MAX = 4,
    }
    public enum EGeometryCollectionCacheType : int
    {
        None = 0,
        Record = 1,
        Play = 2,
        RecordAndPlay = 3,
        EGeometryCollectionCacheType_MAX = 4,
    }
    public class ChaosSolverConfiguration : Object
    {
        public ChaosSolverConfiguration(ulong addr) : base(addr) { }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public int CollisionPairIterations { get { return this[nameof(CollisionPairIterations)].GetValue<int>(); } set { this[nameof(CollisionPairIterations)].SetValue<int>(value); } }
        public int PushOutIterations { get { return this[nameof(PushOutIterations)].GetValue<int>(); } set { this[nameof(PushOutIterations)].SetValue<int>(value); } }
        public int CollisionPushOutPairIterations { get { return this[nameof(CollisionPushOutPairIterations)].GetValue<int>(); } set { this[nameof(CollisionPushOutPairIterations)].SetValue<int>(value); } }
        public float CollisionMarginFraction { get { return this[nameof(CollisionMarginFraction)].GetValue<float>(); } set { this[nameof(CollisionMarginFraction)].SetValue<float>(value); } }
        public float CollisionMarginMax { get { return this[nameof(CollisionMarginMax)].GetValue<float>(); } set { this[nameof(CollisionMarginMax)].SetValue<float>(value); } }
        public float CollisionCullDistance { get { return this[nameof(CollisionCullDistance)].GetValue<float>(); } set { this[nameof(CollisionCullDistance)].SetValue<float>(value); } }
        public int JointPairIterations { get { return this[nameof(JointPairIterations)].GetValue<int>(); } set { this[nameof(JointPairIterations)].SetValue<int>(value); } }
        public int JointPushOutPairIterations { get { return this[nameof(JointPushOutPairIterations)].GetValue<int>(); } set { this[nameof(JointPushOutPairIterations)].SetValue<int>(value); } }
        public float ClusterConnectionFactor { get { return this[nameof(ClusterConnectionFactor)].GetValue<float>(); } set { this[nameof(ClusterConnectionFactor)].SetValue<float>(value); } }
        public EClusterUnionMethod ClusterUnionConnectionType { get { return (EClusterUnionMethod)this[nameof(ClusterUnionConnectionType)].GetValue<int>(); } set { this[nameof(ClusterUnionConnectionType)].SetValue<int>((int)value); } }
        public bool bGenerateCollisionData { get { return this[nameof(bGenerateCollisionData)].Flag; } set { this[nameof(bGenerateCollisionData)].Flag = value; } }
        public SolverCollisionFilterSettings CollisionFilterSettings { get { return this[nameof(CollisionFilterSettings)].As<SolverCollisionFilterSettings>(); } set { this["CollisionFilterSettings"] = value; } }
        public bool bGenerateBreakData { get { return this[nameof(bGenerateBreakData)].Flag; } set { this[nameof(bGenerateBreakData)].Flag = value; } }
        public SolverBreakingFilterSettings BreakingFilterSettings { get { return this[nameof(BreakingFilterSettings)].As<SolverBreakingFilterSettings>(); } set { this["BreakingFilterSettings"] = value; } }
        public bool bGenerateTrailingData { get { return this[nameof(bGenerateTrailingData)].Flag; } set { this[nameof(bGenerateTrailingData)].Flag = value; } }
        public SolverTrailingFilterSettings TrailingFilterSettings { get { return this[nameof(TrailingFilterSettings)].As<SolverTrailingFilterSettings>(); } set { this["TrailingFilterSettings"] = value; } }
        public bool bGenerateContactGraph { get { return this[nameof(bGenerateContactGraph)].Flag; } set { this[nameof(bGenerateContactGraph)].Flag = value; } }
    }
    public class SolverTrailingFilterSettings : Object
    {
        public SolverTrailingFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinVolume { get { return this[nameof(MinVolume)].GetValue<float>(); } set { this[nameof(MinVolume)].SetValue<float>(value); } }
    }
    public class SolverBreakingFilterSettings : Object
    {
        public SolverBreakingFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinVolume { get { return this[nameof(MinVolume)].GetValue<float>(); } set { this[nameof(MinVolume)].SetValue<float>(value); } }
    }
    public class SolverCollisionFilterSettings : Object
    {
        public SolverCollisionFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinImpulse { get { return this[nameof(MinImpulse)].GetValue<float>(); } set { this[nameof(MinImpulse)].SetValue<float>(value); } }
    }
    public class RecordedTransformTrack : Object
    {
        public RecordedTransformTrack(ulong addr) : base(addr) { }
        public Array<RecordedFrame> Records { get { return new Array<RecordedFrame>(this[nameof(Records)].Address); } }
    }
    public class RecordedFrame : Object
    {
        public RecordedFrame(ulong addr) : base(addr) { }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
        public Array<int> TransformIndices { get { return new Array<int>(this[nameof(TransformIndices)].Address); } }
        public Array<int> PreviousTransformIndices { get { return new Array<int>(this[nameof(PreviousTransformIndices)].Address); } }
        public Array<bool> DisabledFlags { get { return new Array<bool>(this[nameof(DisabledFlags)].Address); } }
        public Array<SolverCollisionData> Collisions { get { return new Array<SolverCollisionData>(this[nameof(Collisions)].Address); } }
        public Array<SolverBreakingData> Breakings { get { return new Array<SolverBreakingData>(this[nameof(Breakings)].Address); } }
        public Object Trailings { get { return this[nameof(Trailings)]; } set { this[nameof(Trailings)] = value; } }
        public float Timestamp { get { return this[nameof(Timestamp)].GetValue<float>(); } set { this[nameof(Timestamp)].SetValue<float>(value); } }
    }
    public class SolverTrailingData : Object
    {
        public SolverTrailingData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
    }
    public class SolverBreakingData : Object
    {
        public SolverBreakingData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
    }
    public class SolverCollisionData : Object
    {
        public SolverCollisionData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector AccumulatedImpulse { get { return this[nameof(AccumulatedImpulse)].As<Vector>(); } set { this["AccumulatedImpulse"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector Velocity1 { get { return this[nameof(Velocity1)].As<Vector>(); } set { this["Velocity1"] = value; } }
        public Vector Velocity2 { get { return this[nameof(Velocity2)].As<Vector>(); } set { this["Velocity2"] = value; } }
        public Vector AngularVelocity1 { get { return this[nameof(AngularVelocity1)].As<Vector>(); } set { this["AngularVelocity1"] = value; } }
        public Vector AngularVelocity2 { get { return this[nameof(AngularVelocity2)].As<Vector>(); } set { this["AngularVelocity2"] = value; } }
        public float Mass1 { get { return this[nameof(Mass1)].GetValue<float>(); } set { this[nameof(Mass1)].SetValue<float>(value); } }
        public float Mass2 { get { return this[nameof(Mass2)].GetValue<float>(); } set { this[nameof(Mass2)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int LevelsetIndex { get { return this[nameof(LevelsetIndex)].GetValue<int>(); } set { this[nameof(LevelsetIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
        public int LevelsetIndexMesh { get { return this[nameof(LevelsetIndexMesh)].GetValue<int>(); } set { this[nameof(LevelsetIndexMesh)].SetValue<int>(value); } }
    }
}
