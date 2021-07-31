using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ChaosSDK;
namespace SDK.Script.ChaosSolverEngineSDK
{
    public class ChaosDebugDrawComponent : ActorComponent
    {
        public ChaosDebugDrawComponent(ulong addr) : base(addr) { }
    }
    public class ChaosEventListenerComponent : ActorComponent
    {
        public ChaosEventListenerComponent(ulong addr) : base(addr) { }
    }
    public class ChaosGameplayEventDispatcher : ChaosEventListenerComponent
    {
        public ChaosGameplayEventDispatcher(ulong addr) : base(addr) { }
        public Object CollisionEventRegistrations { get { return this[nameof(CollisionEventRegistrations)]; } set { this[nameof(CollisionEventRegistrations)] = value; } }
        public Object BreakEventRegistrations { get { return this[nameof(BreakEventRegistrations)]; } set { this[nameof(BreakEventRegistrations)] = value; } }
    }
    public class ChaosNotifyHandlerInterface : Interface
    {
        public ChaosNotifyHandlerInterface(ulong addr) : base(addr) { }
    }
    public class ChaosSolverEngineBlueprintLibrary : BlueprintFunctionLibrary
    {
        public ChaosSolverEngineBlueprintLibrary(ulong addr) : base(addr) { }
        public HitResult ConvertPhysicsCollisionToHitResult(ChaosPhysicsCollisionInfo PhysicsCollision) { return Invoke<HitResult>(nameof(ConvertPhysicsCollisionToHitResult), PhysicsCollision); }
    }
    public class ChaosSolver : Object
    {
        public ChaosSolver(ulong addr) : base(addr) { }
    }
    public class ChaosSolverActor : Actor
    {
        public ChaosSolverActor(ulong addr) : base(addr) { }
        public ChaosSolverConfiguration Properties { get { return this[nameof(Properties)].As<ChaosSolverConfiguration>(); } set { this["Properties"] = value; } }
        public float TimeStepMultiplier { get { return this[nameof(TimeStepMultiplier)].GetValue<float>(); } set { this[nameof(TimeStepMultiplier)].SetValue<float>(value); } }
        public int CollisionIterations { get { return this[nameof(CollisionIterations)].GetValue<int>(); } set { this[nameof(CollisionIterations)].SetValue<int>(value); } }
        public int PushOutIterations { get { return this[nameof(PushOutIterations)].GetValue<int>(); } set { this[nameof(PushOutIterations)].SetValue<int>(value); } }
        public int PushOutPairIterations { get { return this[nameof(PushOutPairIterations)].GetValue<int>(); } set { this[nameof(PushOutPairIterations)].SetValue<int>(value); } }
        public float ClusterConnectionFactor { get { return this[nameof(ClusterConnectionFactor)].GetValue<float>(); } set { this[nameof(ClusterConnectionFactor)].SetValue<float>(value); } }
        public EClusterConnectionTypeEnum ClusterUnionConnectionType { get { return (EClusterConnectionTypeEnum)this[nameof(ClusterUnionConnectionType)].GetValue<int>(); } set { this[nameof(ClusterUnionConnectionType)].SetValue<int>((int)value); } }
        public bool DoGenerateCollisionData { get { return this[nameof(DoGenerateCollisionData)].Flag; } set { this[nameof(DoGenerateCollisionData)].Flag = value; } }
        public SolverCollisionFilterSettings CollisionFilterSettings { get { return this[nameof(CollisionFilterSettings)].As<SolverCollisionFilterSettings>(); } set { this["CollisionFilterSettings"] = value; } }
        public bool DoGenerateBreakingData { get { return this[nameof(DoGenerateBreakingData)].Flag; } set { this[nameof(DoGenerateBreakingData)].Flag = value; } }
        public SolverBreakingFilterSettings BreakingFilterSettings { get { return this[nameof(BreakingFilterSettings)].As<SolverBreakingFilterSettings>(); } set { this["BreakingFilterSettings"] = value; } }
        public bool DoGenerateTrailingData { get { return this[nameof(DoGenerateTrailingData)].Flag; } set { this[nameof(DoGenerateTrailingData)].Flag = value; } }
        public SolverTrailingFilterSettings TrailingFilterSettings { get { return this[nameof(TrailingFilterSettings)].As<SolverTrailingFilterSettings>(); } set { this["TrailingFilterSettings"] = value; } }
        public float MassScale { get { return this[nameof(MassScale)].GetValue<float>(); } set { this[nameof(MassScale)].SetValue<float>(value); } }
        public bool bGenerateContactGraph { get { return this[nameof(bGenerateContactGraph)].Flag; } set { this[nameof(bGenerateContactGraph)].Flag = value; } }
        public bool bHasFloor { get { return this[nameof(bHasFloor)].Flag; } set { this[nameof(bHasFloor)].Flag = value; } }
        public float FloorHeight { get { return this[nameof(FloorHeight)].GetValue<float>(); } set { this[nameof(FloorHeight)].SetValue<float>(value); } }
        public ChaosDebugSubstepControl ChaosDebugSubstepControl { get { return this[nameof(ChaosDebugSubstepControl)].As<ChaosDebugSubstepControl>(); } set { this["ChaosDebugSubstepControl"] = value; } }
        public BillboardComponent SpriteComponent { get { return this[nameof(SpriteComponent)].As<BillboardComponent>(); } set { this["SpriteComponent"] = value; } }
        public ChaosGameplayEventDispatcher GameplayEventDispatcherComponent { get { return this[nameof(GameplayEventDispatcherComponent)].As<ChaosGameplayEventDispatcher>(); } set { this["GameplayEventDispatcherComponent"] = value; } }
        public void SetSolverActive(bool bActive) { Invoke(nameof(SetSolverActive), bActive); }
        public void SetAsCurrentWorldSolver() { Invoke(nameof(SetAsCurrentWorldSolver)); }
    }
    public class ChaosPhysicsCollisionInfo : Object
    {
        public ChaosPhysicsCollisionInfo(ulong addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public PrimitiveComponent OtherComponent { get { return this[nameof(OtherComponent)].As<PrimitiveComponent>(); } set { this["OtherComponent"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector AccumulatedImpulse { get { return this[nameof(AccumulatedImpulse)].As<Vector>(); } set { this["AccumulatedImpulse"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector OtherVelocity { get { return this[nameof(OtherVelocity)].As<Vector>(); } set { this["OtherVelocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public Vector OtherAngularVelocity { get { return this[nameof(OtherAngularVelocity)].As<Vector>(); } set { this["OtherAngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public float OtherMass { get { return this[nameof(OtherMass)].GetValue<float>(); } set { this[nameof(OtherMass)].SetValue<float>(value); } }
    }
    public enum EClusterConnectionTypeEnum : int
    {
        Chaos_PointImplicit = 0,
        Chaos_DelaunayTriangulation = 1,
        Chaos_MinimalSpanningSubsetDelaunayTriangulation = 2,
        Chaos_PointImplicitAugmentedWithMinimalDelaunay = 3,
        Chaos_None = 4,
        Chaos_EClsuterCreationParameters_Max = 5,
        Chaos_MAX = 6,
    }
    public class ChaosBreakEvent : Object
    {
        public ChaosBreakEvent(ulong addr) : base(addr) { }
        public PrimitiveComponent Component { get { return this[nameof(Component)].As<PrimitiveComponent>(); } set { this["Component"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
    }
    public class ChaosHandlerSet : Object
    {
        public ChaosHandlerSet(ulong addr) : base(addr) { }
        public Object ChaosHandlers { get { return this[nameof(ChaosHandlers)]; } set { this[nameof(ChaosHandlers)] = value; } }
    }
    public class BreakEventCallbackWrapper : Object
    {
        public BreakEventCallbackWrapper(ulong addr) : base(addr) { }
    }
    public class ChaosDebugSubstepControl : Object
    {
        public ChaosDebugSubstepControl(ulong addr) : base(addr) { }
        public bool bPause { get { return this[nameof(bPause)].Flag; } set { this[nameof(bPause)].Flag = value; } }
        public bool bSubstep { get { return this[nameof(bSubstep)].Flag; } set { this[nameof(bSubstep)].Flag = value; } }
        public bool bStep { get { return this[nameof(bStep)].Flag; } set { this[nameof(bStep)].Flag = value; } }
    }
}
