using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.ClothingSystemRuntimeCommonSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ClothingSystemRuntimeInterfaceSDK;
namespace SDK.Script.ChaosClothSDK
{
    public class ChaosClothConfig : ClothConfigCommon
    {
        public ChaosClothConfig(ulong addr) : base(addr) { }
        public EClothMassMode MassMode { get { return (EClothMassMode)this[nameof(MassMode)].GetValue<int>(); } set { this[nameof(MassMode)].SetValue<int>((int)value); } }
        public float UniformMass { get { return this[nameof(UniformMass)].GetValue<float>(); } set { this[nameof(UniformMass)].SetValue<float>(value); } }
        public float TotalMass { get { return this[nameof(TotalMass)].GetValue<float>(); } set { this[nameof(TotalMass)].SetValue<float>(value); } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float MinPerParticleMass { get { return this[nameof(MinPerParticleMass)].GetValue<float>(); } set { this[nameof(MinPerParticleMass)].SetValue<float>(value); } }
        public float EdgeStiffness { get { return this[nameof(EdgeStiffness)].GetValue<float>(); } set { this[nameof(EdgeStiffness)].SetValue<float>(value); } }
        public float BendingStiffness { get { return this[nameof(BendingStiffness)].GetValue<float>(); } set { this[nameof(BendingStiffness)].SetValue<float>(value); } }
        public bool bUseBendingElements { get { return this[nameof(bUseBendingElements)].Flag; } set { this[nameof(bUseBendingElements)].Flag = value; } }
        public float AreaStiffness { get { return this[nameof(AreaStiffness)].GetValue<float>(); } set { this[nameof(AreaStiffness)].SetValue<float>(value); } }
        public float VolumeStiffness { get { return this[nameof(VolumeStiffness)].GetValue<float>(); } set { this[nameof(VolumeStiffness)].SetValue<float>(value); } }
        public float StrainLimitingStiffness { get { return this[nameof(StrainLimitingStiffness)].GetValue<float>(); } set { this[nameof(StrainLimitingStiffness)].SetValue<float>(value); } }
        public float LimitScale { get { return this[nameof(LimitScale)].GetValue<float>(); } set { this[nameof(LimitScale)].SetValue<float>(value); } }
        public EChaosClothTetherMode TetherMode { get { return (EChaosClothTetherMode)this[nameof(TetherMode)].GetValue<int>(); } set { this[nameof(TetherMode)].SetValue<int>((int)value); } }
        public bool bUseGeodesicDistance { get { return this[nameof(bUseGeodesicDistance)].Flag; } set { this[nameof(bUseGeodesicDistance)].Flag = value; } }
        public float ShapeTargetStiffness { get { return this[nameof(ShapeTargetStiffness)].GetValue<float>(); } set { this[nameof(ShapeTargetStiffness)].SetValue<float>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public float FrictionCoefficient { get { return this[nameof(FrictionCoefficient)].GetValue<float>(); } set { this[nameof(FrictionCoefficient)].SetValue<float>(value); } }
        public bool bUseSelfCollisions { get { return this[nameof(bUseSelfCollisions)].Flag; } set { this[nameof(bUseSelfCollisions)].Flag = value; } }
        public float SelfCollisionThickness { get { return this[nameof(SelfCollisionThickness)].GetValue<float>(); } set { this[nameof(SelfCollisionThickness)].SetValue<float>(value); } }
        public bool bUseLegacyBackstop { get { return this[nameof(bUseLegacyBackstop)].Flag; } set { this[nameof(bUseLegacyBackstop)].Flag = value; } }
        public float DampingCoefficient { get { return this[nameof(DampingCoefficient)].GetValue<float>(); } set { this[nameof(DampingCoefficient)].SetValue<float>(value); } }
        public bool bUsePointBasedWindModel { get { return this[nameof(bUsePointBasedWindModel)].Flag; } set { this[nameof(bUsePointBasedWindModel)].Flag = value; } }
        public float DragCoefficient { get { return this[nameof(DragCoefficient)].GetValue<float>(); } set { this[nameof(DragCoefficient)].SetValue<float>(value); } }
        public float LiftCoefficient { get { return this[nameof(LiftCoefficient)].GetValue<float>(); } set { this[nameof(LiftCoefficient)].SetValue<float>(value); } }
        public bool bUseGravityOverride { get { return this[nameof(bUseGravityOverride)].Flag; } set { this[nameof(bUseGravityOverride)].Flag = value; } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public Vector Gravity { get { return this[nameof(Gravity)].As<Vector>(); } set { this["Gravity"] = value; } }
        public float AnimDriveSpringStiffness { get { return this[nameof(AnimDriveSpringStiffness)].GetValue<float>(); } set { this[nameof(AnimDriveSpringStiffness)].SetValue<float>(value); } }
        public Vector LinearVelocityScale { get { return this[nameof(LinearVelocityScale)].As<Vector>(); } set { this["LinearVelocityScale"] = value; } }
        public float AngularVelocityScale { get { return this[nameof(AngularVelocityScale)].GetValue<float>(); } set { this[nameof(AngularVelocityScale)].SetValue<float>(value); } }
        public bool bUseTetrahedralConstraints { get { return this[nameof(bUseTetrahedralConstraints)].Flag; } set { this[nameof(bUseTetrahedralConstraints)].Flag = value; } }
        public bool bUseThinShellVolumeConstraints { get { return this[nameof(bUseThinShellVolumeConstraints)].Flag; } set { this[nameof(bUseThinShellVolumeConstraints)].Flag = value; } }
        public bool bUseContinuousCollisionDetection { get { return this[nameof(bUseContinuousCollisionDetection)].Flag; } set { this[nameof(bUseContinuousCollisionDetection)].Flag = value; } }
    }
    public class ChaosClothSharedSimConfig : ClothSharedConfigCommon
    {
        public ChaosClothSharedSimConfig(ulong addr) : base(addr) { }
        public int IterationCount { get { return this[nameof(IterationCount)].GetValue<int>(); } set { this[nameof(IterationCount)].SetValue<int>(value); } }
        public int SubdivisionCount { get { return this[nameof(SubdivisionCount)].GetValue<int>(); } set { this[nameof(SubdivisionCount)].SetValue<int>(value); } }
        public float SelfCollisionThickness { get { return this[nameof(SelfCollisionThickness)].GetValue<float>(); } set { this[nameof(SelfCollisionThickness)].SetValue<float>(value); } }
        public float CollisionThickness { get { return this[nameof(CollisionThickness)].GetValue<float>(); } set { this[nameof(CollisionThickness)].SetValue<float>(value); } }
        public bool bUseDampingOverride { get { return this[nameof(bUseDampingOverride)].Flag; } set { this[nameof(bUseDampingOverride)].Flag = value; } }
        public float Damping { get { return this[nameof(Damping)].GetValue<float>(); } set { this[nameof(Damping)].SetValue<float>(value); } }
        public bool bUseGravityOverride { get { return this[nameof(bUseGravityOverride)].Flag; } set { this[nameof(bUseGravityOverride)].Flag = value; } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public Vector Gravity { get { return this[nameof(Gravity)].As<Vector>(); } set { this["Gravity"] = value; } }
        public bool bUseLocalSpaceSimulation { get { return this[nameof(bUseLocalSpaceSimulation)].Flag; } set { this[nameof(bUseLocalSpaceSimulation)].Flag = value; } }
        public bool bUseXPBDConstraints { get { return this[nameof(bUseXPBDConstraints)].Flag; } set { this[nameof(bUseXPBDConstraints)].Flag = value; } }
    }
    public class ChaosClothingSimulationFactory : ClothingSimulationFactory
    {
        public ChaosClothingSimulationFactory(ulong addr) : base(addr) { }
    }
    public class ChaosClothingSimulationInteractor : ClothingSimulationInteractor
    {
        public ChaosClothingSimulationInteractor(ulong addr) : base(addr) { }
    }
    public enum EChaosClothTetherMode : int
    {
        FastTetherFastLength = 0,
        AccurateTetherFastLength = 1,
        AccurateTetherAccurateLength = 2,
        MaxChaosClothTetherMode = 3,
        EChaosClothTetherMode_MAX = 4,
    }
    public enum EChaosWeightMapTarget : int
    {
        None = 0,
        MaxDistance = 1,
        BackstopDistance = 2,
        BackstopRadius = 3,
        AnimDriveMultiplier = 4,
        EChaosWeightMapTarget_MAX = 5,
    }
}
