using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.ChaosSolverEngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.ChaosSDK;
using SDK.Script.FieldSystemEngineSDK;
using SDK.Script.PhysicsCoreSDK;
namespace SDK.Script.GeometryCollectionEngineSDK
{
    public class ChaosDestructionListener : SceneComponent
    {
        public ChaosDestructionListener(ulong addr) : base(addr) { }
        public bool bIsCollisionEventListeningEnabled { get { return this[nameof(bIsCollisionEventListeningEnabled)].Flag; } set { this[nameof(bIsCollisionEventListeningEnabled)].Flag = value; } }
        public bool bIsBreakingEventListeningEnabled { get { return this[nameof(bIsBreakingEventListeningEnabled)].Flag; } set { this[nameof(bIsBreakingEventListeningEnabled)].Flag = value; } }
        public bool bIsTrailingEventListeningEnabled { get { return this[nameof(bIsTrailingEventListeningEnabled)].Flag; } set { this[nameof(bIsTrailingEventListeningEnabled)].Flag = value; } }
        public ChaosCollisionEventRequestSettings CollisionEventRequestSettings { get { return this[nameof(CollisionEventRequestSettings)].As<ChaosCollisionEventRequestSettings>(); } set { this["CollisionEventRequestSettings"] = value; } }
        public ChaosBreakingEventRequestSettings BreakingEventRequestSettings { get { return this[nameof(BreakingEventRequestSettings)].As<ChaosBreakingEventRequestSettings>(); } set { this["BreakingEventRequestSettings"] = value; } }
        public ChaosTrailingEventRequestSettings TrailingEventRequestSettings { get { return this[nameof(TrailingEventRequestSettings)].As<ChaosTrailingEventRequestSettings>(); } set { this["TrailingEventRequestSettings"] = value; } }
        public Object ChaosSolverActors { get { return this[nameof(ChaosSolverActors)]; } set { this[nameof(ChaosSolverActors)] = value; } }
        public Object GeometryCollectionActors { get { return this[nameof(GeometryCollectionActors)]; } set { this[nameof(GeometryCollectionActors)] = value; } }
        public Object OnCollisionEvents { get { return this[nameof(OnCollisionEvents)]; } set { this[nameof(OnCollisionEvents)] = value; } }
        public Object OnBreakingEvents { get { return this[nameof(OnBreakingEvents)]; } set { this[nameof(OnBreakingEvents)] = value; } }
        public Object OnTrailingEvents { get { return this[nameof(OnTrailingEvents)]; } set { this[nameof(OnTrailingEvents)] = value; } }
        public void SortTrailingEvents(Array<ChaosTrailingEventData> TrailingEvents, EChaosTrailingSortMethod SortMethod) { Invoke(nameof(SortTrailingEvents), TrailingEvents, SortMethod); }
        public void SortCollisionEvents(Array<ChaosCollisionEventData> CollisionEvents, EChaosCollisionSortMethod SortMethod) { Invoke(nameof(SortCollisionEvents), CollisionEvents, SortMethod); }
        public void SortBreakingEvents(Array<ChaosBreakingEventData> BreakingEvents, EChaosBreakingSortMethod SortMethod) { Invoke(nameof(SortBreakingEvents), BreakingEvents, SortMethod); }
        public void SetTrailingEventRequestSettings(ChaosTrailingEventRequestSettings InSettings) { Invoke(nameof(SetTrailingEventRequestSettings), InSettings); }
        public void SetTrailingEventEnabled(bool bIsEnabled) { Invoke(nameof(SetTrailingEventEnabled), bIsEnabled); }
        public void SetCollisionEventRequestSettings(ChaosCollisionEventRequestSettings InSettings) { Invoke(nameof(SetCollisionEventRequestSettings), InSettings); }
        public void SetCollisionEventEnabled(bool bIsEnabled) { Invoke(nameof(SetCollisionEventEnabled), bIsEnabled); }
        public void SetBreakingEventRequestSettings(ChaosBreakingEventRequestSettings InSettings) { Invoke(nameof(SetBreakingEventRequestSettings), InSettings); }
        public void SetBreakingEventEnabled(bool bIsEnabled) { Invoke(nameof(SetBreakingEventEnabled), bIsEnabled); }
        public void RemoveGeometryCollectionActor(GeometryCollectionActor GeometryCollectionActor) { Invoke(nameof(RemoveGeometryCollectionActor), GeometryCollectionActor); }
        public void RemoveChaosSolverActor(ChaosSolverActor ChaosSolverActor) { Invoke(nameof(RemoveChaosSolverActor), ChaosSolverActor); }
        public bool IsEventListening() { return Invoke<bool>(nameof(IsEventListening)); }
        public void AddGeometryCollectionActor(GeometryCollectionActor GeometryCollectionActor) { Invoke(nameof(AddGeometryCollectionActor), GeometryCollectionActor); }
        public void AddChaosSolverActor(ChaosSolverActor ChaosSolverActor) { Invoke(nameof(AddChaosSolverActor), ChaosSolverActor); }
    }
    public class GeometryCollectionActor : Actor
    {
        public GeometryCollectionActor(ulong addr) : base(addr) { }
        public GeometryCollectionComponent GeometryCollectionComponent { get { return this[nameof(GeometryCollectionComponent)].As<GeometryCollectionComponent>(); } set { this["GeometryCollectionComponent"] = value; } }
        public GeometryCollectionDebugDrawComponent GeometryCollectionDebugDrawComponent { get { return this[nameof(GeometryCollectionDebugDrawComponent)].As<GeometryCollectionDebugDrawComponent>(); } set { this["GeometryCollectionDebugDrawComponent"] = value; } }
        public bool RaycastSingle(Vector Start, Vector End, HitResult OutHit) { return Invoke<bool>(nameof(RaycastSingle), Start, End, OutHit); }
    }
    public class GeometryCollectionCache : Object
    {
        public GeometryCollectionCache(ulong addr) : base(addr) { }
        public RecordedTransformTrack RecordedData { get { return this[nameof(RecordedData)].As<RecordedTransformTrack>(); } set { this["RecordedData"] = value; } }
        public GeometryCollection SupportedCollection { get { return this[nameof(SupportedCollection)].As<GeometryCollection>(); } set { this["SupportedCollection"] = value; } }
        public Guid CompatibleCollectionState { get { return this[nameof(CompatibleCollectionState)].As<Guid>(); } set { this["CompatibleCollectionState"] = value; } }
    }
    public class GeometryCollectionComponent : MeshComponent
    {
        public GeometryCollectionComponent(ulong addr) : base(addr) { }
        public ChaosSolverActor ChaosSolverActor { get { return this[nameof(ChaosSolverActor)].As<ChaosSolverActor>(); } set { this["ChaosSolverActor"] = value; } }
        public GeometryCollection RestCollection { get { return this[nameof(RestCollection)].As<GeometryCollection>(); } set { this["RestCollection"] = value; } }
        public Array<FieldSystemActor> InitializationFields { get { return new Array<FieldSystemActor>(this[nameof(InitializationFields)].Address); } }
        public bool Simulating { get { return this[nameof(Simulating)].Flag; } set { this[nameof(Simulating)].Flag = value; } }
        public EObjectStateTypeEnum ObjectType { get { return (EObjectStateTypeEnum)this[nameof(ObjectType)].GetValue<int>(); } set { this[nameof(ObjectType)].SetValue<int>((int)value); } }
        public bool EnableClustering { get { return this[nameof(EnableClustering)].Flag; } set { this[nameof(EnableClustering)].Flag = value; } }
        public int ClusterGroupIndex { get { return this[nameof(ClusterGroupIndex)].GetValue<int>(); } set { this[nameof(ClusterGroupIndex)].SetValue<int>(value); } }
        public int MaxClusterLevel { get { return this[nameof(MaxClusterLevel)].GetValue<int>(); } set { this[nameof(MaxClusterLevel)].SetValue<int>(value); } }
        public Array<float> DamageThreshold { get { return new Array<float>(this[nameof(DamageThreshold)].Address); } }
        public EClusterConnectionTypeEnum ClusterConnectionType { get { return (EClusterConnectionTypeEnum)this[nameof(ClusterConnectionType)].GetValue<int>(); } set { this[nameof(ClusterConnectionType)].SetValue<int>((int)value); } }
        public int CollisionGroup { get { return this[nameof(CollisionGroup)].GetValue<int>(); } set { this[nameof(CollisionGroup)].SetValue<int>(value); } }
        public float CollisionSampleFraction { get { return this[nameof(CollisionSampleFraction)].GetValue<float>(); } set { this[nameof(CollisionSampleFraction)].SetValue<float>(value); } }
        public float LinearEtherDrag { get { return this[nameof(LinearEtherDrag)].GetValue<float>(); } set { this[nameof(LinearEtherDrag)].SetValue<float>(value); } }
        public float AngularEtherDrag { get { return this[nameof(AngularEtherDrag)].GetValue<float>(); } set { this[nameof(AngularEtherDrag)].SetValue<float>(value); } }
        public ChaosPhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<ChaosPhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public EInitialVelocityTypeEnum InitialVelocityType { get { return (EInitialVelocityTypeEnum)this[nameof(InitialVelocityType)].GetValue<int>(); } set { this[nameof(InitialVelocityType)].SetValue<int>((int)value); } }
        public Vector InitialLinearVelocity { get { return this[nameof(InitialLinearVelocity)].As<Vector>(); } set { this["InitialLinearVelocity"] = value; } }
        public Vector InitialAngularVelocity { get { return this[nameof(InitialAngularVelocity)].As<Vector>(); } set { this["InitialAngularVelocity"] = value; } }
        public PhysicalMaterial PhysicalMaterialOverride { get { return this[nameof(PhysicalMaterialOverride)].As<PhysicalMaterial>(); } set { this["PhysicalMaterialOverride"] = value; } }
        public GeomComponentCacheParameters CacheParameters { get { return this[nameof(CacheParameters)].As<GeomComponentCacheParameters>(); } set { this["CacheParameters"] = value; } }
        public Object NotifyGeometryCollectionPhysicsStateChange { get { return this[nameof(NotifyGeometryCollectionPhysicsStateChange)]; } set { this[nameof(NotifyGeometryCollectionPhysicsStateChange)] = value; } }
        public Object NotifyGeometryCollectionPhysicsLoadingStateChange { get { return this[nameof(NotifyGeometryCollectionPhysicsLoadingStateChange)]; } set { this[nameof(NotifyGeometryCollectionPhysicsLoadingStateChange)] = value; } }
        public Object OnChaosBreakEvent { get { return this[nameof(OnChaosBreakEvent)]; } set { this[nameof(OnChaosBreakEvent)] = value; } }
        public float DesiredCacheTime { get { return this[nameof(DesiredCacheTime)].GetValue<float>(); } set { this[nameof(DesiredCacheTime)].SetValue<float>(value); } }
        public bool CachePlayback { get { return this[nameof(CachePlayback)].Flag; } set { this[nameof(CachePlayback)].Flag = value; } }
        public Object OnChaosPhysicsCollision { get { return this[nameof(OnChaosPhysicsCollision)]; } set { this[nameof(OnChaosPhysicsCollision)] = value; } }
        public bool bNotifyBreaks { get { return this[nameof(bNotifyBreaks)].Flag; } set { this[nameof(bNotifyBreaks)].Flag = value; } }
        public bool bNotifyCollisions { get { return this[nameof(bNotifyCollisions)].Flag; } set { this[nameof(bNotifyCollisions)].Flag = value; } }
        public bool bEnableReplication { get { return this[nameof(bEnableReplication)].Flag; } set { this[nameof(bEnableReplication)].Flag = value; } }
        public bool bEnableAbandonAfterLevel { get { return this[nameof(bEnableAbandonAfterLevel)].Flag; } set { this[nameof(bEnableAbandonAfterLevel)].Flag = value; } }
        public int ReplicationAbandonClusterLevel { get { return this[nameof(ReplicationAbandonClusterLevel)].GetValue<int>(); } set { this[nameof(ReplicationAbandonClusterLevel)].SetValue<int>(value); } }
        public GeometryCollectionRepData RepData { get { return this[nameof(RepData)].As<GeometryCollectionRepData>(); } set { this["RepData"] = value; } }
        public BodySetup DummyBodySetup { get { return this[nameof(DummyBodySetup)].As<BodySetup>(); } set { this["DummyBodySetup"] = value; } }
        public void SetNotifyBreaks(bool bNewNotifyBreaks) { Invoke(nameof(SetNotifyBreaks), bNewNotifyBreaks); }
        public void ReceivePhysicsCollision(ChaosPhysicsCollisionInfo CollisionInfo) { Invoke(nameof(ReceivePhysicsCollision), CollisionInfo); }
        public void OnRep_RepData(GeometryCollectionRepData OldData) { Invoke(nameof(OnRep_RepData), OldData); }
        public void NotifyGeometryCollectionPhysicsStateChange__DelegateSignature(GeometryCollectionComponent FracturedComponent) { Invoke(nameof(NotifyGeometryCollectionPhysicsStateChange__DelegateSignature), FracturedComponent); }
        public void NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature(GeometryCollectionComponent FracturedComponent) { Invoke(nameof(NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature), FracturedComponent); }
        public void NetAbandonCluster(int TransformIndex) { Invoke(nameof(NetAbandonCluster), TransformIndex); }
        public void ApplyPhysicsField(bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(ApplyPhysicsField), Enabled, Target, MetaData, Field); }
        public void ApplyKinematicField(float Radius, Vector Position) { Invoke(nameof(ApplyKinematicField), Radius, Position); }
    }
    public class GeometryCollectionDebugDrawActor : Actor
    {
        public GeometryCollectionDebugDrawActor(ulong addr) : base(addr) { }
        public GeometryCollectionDebugDrawWarningMessage WarningMessage { get { return this[nameof(WarningMessage)].As<GeometryCollectionDebugDrawWarningMessage>(); } set { this["WarningMessage"] = value; } }
        public GeometryCollectionDebugDrawActorSelectedRigidBody SelectedRigidBody { get { return this[nameof(SelectedRigidBody)].As<GeometryCollectionDebugDrawActorSelectedRigidBody>(); } set { this["SelectedRigidBody"] = value; } }
        public bool bDebugDrawWholeCollection { get { return this[nameof(bDebugDrawWholeCollection)].Flag; } set { this[nameof(bDebugDrawWholeCollection)].Flag = value; } }
        public bool bDebugDrawHierarchy { get { return this[nameof(bDebugDrawHierarchy)].Flag; } set { this[nameof(bDebugDrawHierarchy)].Flag = value; } }
        public bool bDebugDrawClustering { get { return this[nameof(bDebugDrawClustering)].Flag; } set { this[nameof(bDebugDrawClustering)].Flag = value; } }
        public EGeometryCollectionDebugDrawActorHideGeometry HideGeometry { get { return (EGeometryCollectionDebugDrawActorHideGeometry)this[nameof(HideGeometry)].GetValue<int>(); } set { this[nameof(HideGeometry)].SetValue<int>((int)value); } }
        public bool bShowRigidBodyId { get { return this[nameof(bShowRigidBodyId)].Flag; } set { this[nameof(bShowRigidBodyId)].Flag = value; } }
        public bool bShowRigidBodyCollision { get { return this[nameof(bShowRigidBodyCollision)].Flag; } set { this[nameof(bShowRigidBodyCollision)].Flag = value; } }
        public bool bCollisionAtOrigin { get { return this[nameof(bCollisionAtOrigin)].Flag; } set { this[nameof(bCollisionAtOrigin)].Flag = value; } }
        public bool bShowRigidBodyTransform { get { return this[nameof(bShowRigidBodyTransform)].Flag; } set { this[nameof(bShowRigidBodyTransform)].Flag = value; } }
        public bool bShowRigidBodyInertia { get { return this[nameof(bShowRigidBodyInertia)].Flag; } set { this[nameof(bShowRigidBodyInertia)].Flag = value; } }
        public bool bShowRigidBodyVelocity { get { return this[nameof(bShowRigidBodyVelocity)].Flag; } set { this[nameof(bShowRigidBodyVelocity)].Flag = value; } }
        public bool bShowRigidBodyForce { get { return this[nameof(bShowRigidBodyForce)].Flag; } set { this[nameof(bShowRigidBodyForce)].Flag = value; } }
        public bool bShowRigidBodyInfos { get { return this[nameof(bShowRigidBodyInfos)].Flag; } set { this[nameof(bShowRigidBodyInfos)].Flag = value; } }
        public bool bShowTransformIndex { get { return this[nameof(bShowTransformIndex)].Flag; } set { this[nameof(bShowTransformIndex)].Flag = value; } }
        public bool bShowTransform { get { return this[nameof(bShowTransform)].Flag; } set { this[nameof(bShowTransform)].Flag = value; } }
        public bool bShowParent { get { return this[nameof(bShowParent)].Flag; } set { this[nameof(bShowParent)].Flag = value; } }
        public bool bShowLevel { get { return this[nameof(bShowLevel)].Flag; } set { this[nameof(bShowLevel)].Flag = value; } }
        public bool bShowConnectivityEdges { get { return this[nameof(bShowConnectivityEdges)].Flag; } set { this[nameof(bShowConnectivityEdges)].Flag = value; } }
        public bool bShowGeometryIndex { get { return this[nameof(bShowGeometryIndex)].Flag; } set { this[nameof(bShowGeometryIndex)].Flag = value; } }
        public bool bShowGeometryTransform { get { return this[nameof(bShowGeometryTransform)].Flag; } set { this[nameof(bShowGeometryTransform)].Flag = value; } }
        public bool bShowBoundingBox { get { return this[nameof(bShowBoundingBox)].Flag; } set { this[nameof(bShowBoundingBox)].Flag = value; } }
        public bool bShowFaces { get { return this[nameof(bShowFaces)].Flag; } set { this[nameof(bShowFaces)].Flag = value; } }
        public bool bShowFaceIndices { get { return this[nameof(bShowFaceIndices)].Flag; } set { this[nameof(bShowFaceIndices)].Flag = value; } }
        public bool bShowFaceNormals { get { return this[nameof(bShowFaceNormals)].Flag; } set { this[nameof(bShowFaceNormals)].Flag = value; } }
        public bool bShowSingleFace { get { return this[nameof(bShowSingleFace)].Flag; } set { this[nameof(bShowSingleFace)].Flag = value; } }
        public int SingleFaceIndex { get { return this[nameof(SingleFaceIndex)].GetValue<int>(); } set { this[nameof(SingleFaceIndex)].SetValue<int>(value); } }
        public bool bShowVertices { get { return this[nameof(bShowVertices)].Flag; } set { this[nameof(bShowVertices)].Flag = value; } }
        public bool bShowVertexIndices { get { return this[nameof(bShowVertexIndices)].Flag; } set { this[nameof(bShowVertexIndices)].Flag = value; } }
        public bool bShowVertexNormals { get { return this[nameof(bShowVertexNormals)].Flag; } set { this[nameof(bShowVertexNormals)].Flag = value; } }
        public bool bUseActiveVisualization { get { return this[nameof(bUseActiveVisualization)].Flag; } set { this[nameof(bUseActiveVisualization)].Flag = value; } }
        public float PointThickness { get { return this[nameof(PointThickness)].GetValue<float>(); } set { this[nameof(PointThickness)].SetValue<float>(value); } }
        public float LineThickness { get { return this[nameof(LineThickness)].GetValue<float>(); } set { this[nameof(LineThickness)].SetValue<float>(value); } }
        public bool bTextShadow { get { return this[nameof(bTextShadow)].Flag; } set { this[nameof(bTextShadow)].Flag = value; } }
        public float TextScale { get { return this[nameof(TextScale)].GetValue<float>(); } set { this[nameof(TextScale)].SetValue<float>(value); } }
        public float NormalScale { get { return this[nameof(NormalScale)].GetValue<float>(); } set { this[nameof(NormalScale)].SetValue<float>(value); } }
        public float AxisScale { get { return this[nameof(AxisScale)].GetValue<float>(); } set { this[nameof(AxisScale)].SetValue<float>(value); } }
        public float ArrowScale { get { return this[nameof(ArrowScale)].GetValue<float>(); } set { this[nameof(ArrowScale)].SetValue<float>(value); } }
        public Color RigidBodyIdColor { get { return this[nameof(RigidBodyIdColor)].As<Color>(); } set { this["RigidBodyIdColor"] = value; } }
        public float RigidBodyTransformScale { get { return this[nameof(RigidBodyTransformScale)].GetValue<float>(); } set { this[nameof(RigidBodyTransformScale)].SetValue<float>(value); } }
        public Color RigidBodyCollisionColor { get { return this[nameof(RigidBodyCollisionColor)].As<Color>(); } set { this["RigidBodyCollisionColor"] = value; } }
        public Color RigidBodyInertiaColor { get { return this[nameof(RigidBodyInertiaColor)].As<Color>(); } set { this["RigidBodyInertiaColor"] = value; } }
        public Color RigidBodyVelocityColor { get { return this[nameof(RigidBodyVelocityColor)].As<Color>(); } set { this["RigidBodyVelocityColor"] = value; } }
        public Color RigidBodyForceColor { get { return this[nameof(RigidBodyForceColor)].As<Color>(); } set { this["RigidBodyForceColor"] = value; } }
        public Color RigidBodyInfoColor { get { return this[nameof(RigidBodyInfoColor)].As<Color>(); } set { this["RigidBodyInfoColor"] = value; } }
        public Color TransformIndexColor { get { return this[nameof(TransformIndexColor)].As<Color>(); } set { this["TransformIndexColor"] = value; } }
        public float TransformScale { get { return this[nameof(TransformScale)].GetValue<float>(); } set { this[nameof(TransformScale)].SetValue<float>(value); } }
        public Color LevelColor { get { return this[nameof(LevelColor)].As<Color>(); } set { this["LevelColor"] = value; } }
        public Color ParentColor { get { return this[nameof(ParentColor)].As<Color>(); } set { this["ParentColor"] = value; } }
        public float ConnectivityEdgeThickness { get { return this[nameof(ConnectivityEdgeThickness)].GetValue<float>(); } set { this[nameof(ConnectivityEdgeThickness)].SetValue<float>(value); } }
        public Color GeometryIndexColor { get { return this[nameof(GeometryIndexColor)].As<Color>(); } set { this["GeometryIndexColor"] = value; } }
        public float GeometryTransformScale { get { return this[nameof(GeometryTransformScale)].GetValue<float>(); } set { this[nameof(GeometryTransformScale)].SetValue<float>(value); } }
        public Color BoundingBoxColor { get { return this[nameof(BoundingBoxColor)].As<Color>(); } set { this["BoundingBoxColor"] = value; } }
        public Color FaceColor { get { return this[nameof(FaceColor)].As<Color>(); } set { this["FaceColor"] = value; } }
        public Color FaceIndexColor { get { return this[nameof(FaceIndexColor)].As<Color>(); } set { this["FaceIndexColor"] = value; } }
        public Color FaceNormalColor { get { return this[nameof(FaceNormalColor)].As<Color>(); } set { this["FaceNormalColor"] = value; } }
        public Color SingleFaceColor { get { return this[nameof(SingleFaceColor)].As<Color>(); } set { this["SingleFaceColor"] = value; } }
        public Color VertexColor { get { return this[nameof(VertexColor)].As<Color>(); } set { this["VertexColor"] = value; } }
        public Color VertexIndexColor { get { return this[nameof(VertexIndexColor)].As<Color>(); } set { this["VertexIndexColor"] = value; } }
        public Color VertexNormalColor { get { return this[nameof(VertexNormalColor)].As<Color>(); } set { this["VertexNormalColor"] = value; } }
        public BillboardComponent SpriteComponent { get { return this[nameof(SpriteComponent)].As<BillboardComponent>(); } set { this["SpriteComponent"] = value; } }
    }
    public class GeometryCollectionDebugDrawComponent : ActorComponent
    {
        public GeometryCollectionDebugDrawComponent(ulong addr) : base(addr) { }
        public GeometryCollectionDebugDrawActor GeometryCollectionDebugDrawActor { get { return this[nameof(GeometryCollectionDebugDrawActor)].As<GeometryCollectionDebugDrawActor>(); } set { this["GeometryCollectionDebugDrawActor"] = value; } }
        public GeometryCollectionRenderLevelSetActor GeometryCollectionRenderLevelSetActor { get { return this[nameof(GeometryCollectionRenderLevelSetActor)].As<GeometryCollectionRenderLevelSetActor>(); } set { this["GeometryCollectionRenderLevelSetActor"] = value; } }
    }
    public class GeometryCollection : Object
    {
        public GeometryCollection(ulong addr) : base(addr) { }
        public Array<GeometryCollectionSource> GeometrySource { get { return new Array<GeometryCollectionSource>(this[nameof(GeometrySource)].Address); } }
        public Array<MaterialInterface> Materials { get { return new Array<MaterialInterface>(this[nameof(Materials)].Address); } }
        public ECollisionTypeEnum CollisionType { get { return (ECollisionTypeEnum)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public EImplicitTypeEnum ImplicitType { get { return (EImplicitTypeEnum)this[nameof(ImplicitType)].GetValue<int>(); } set { this[nameof(ImplicitType)].SetValue<int>((int)value); } }
        public int MinLevelSetResolution { get { return this[nameof(MinLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinLevelSetResolution)].SetValue<int>(value); } }
        public int MaxLevelSetResolution { get { return this[nameof(MaxLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxLevelSetResolution)].SetValue<int>(value); } }
        public int MinClusterLevelSetResolution { get { return this[nameof(MinClusterLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinClusterLevelSetResolution)].SetValue<int>(value); } }
        public int MaxClusterLevelSetResolution { get { return this[nameof(MaxClusterLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxClusterLevelSetResolution)].SetValue<int>(value); } }
        public float CollisionObjectReductionPercentage { get { return this[nameof(CollisionObjectReductionPercentage)].GetValue<float>(); } set { this[nameof(CollisionObjectReductionPercentage)].SetValue<float>(value); } }
        public bool bMassAsDensity { get { return this[nameof(bMassAsDensity)].Flag; } set { this[nameof(bMassAsDensity)].Flag = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public float MinimumMassClamp { get { return this[nameof(MinimumMassClamp)].GetValue<float>(); } set { this[nameof(MinimumMassClamp)].SetValue<float>(value); } }
        public float CollisionParticlesFraction { get { return this[nameof(CollisionParticlesFraction)].GetValue<float>(); } set { this[nameof(CollisionParticlesFraction)].SetValue<float>(value); } }
        public int MaximumCollisionParticles { get { return this[nameof(MaximumCollisionParticles)].GetValue<int>(); } set { this[nameof(MaximumCollisionParticles)].SetValue<int>(value); } }
        public Array<GeometryCollectionSizeSpecificData> SizeSpecificData { get { return new Array<GeometryCollectionSizeSpecificData>(this[nameof(SizeSpecificData)].Address); } }
        public bool EnableRemovePiecesOnFracture { get { return this[nameof(EnableRemovePiecesOnFracture)].Flag; } set { this[nameof(EnableRemovePiecesOnFracture)].Flag = value; } }
        public Array<MaterialInterface> RemoveOnFractureMaterials { get { return new Array<MaterialInterface>(this[nameof(RemoveOnFractureMaterials)].Address); } }
        public Guid PersistentGuid { get { return this[nameof(PersistentGuid)].As<Guid>(); } set { this["PersistentGuid"] = value; } }
        public Guid StateGuid { get { return this[nameof(StateGuid)].As<Guid>(); } set { this["StateGuid"] = value; } }
        public int BoneSelectedMaterialIndex { get { return this[nameof(BoneSelectedMaterialIndex)].GetValue<int>(); } set { this[nameof(BoneSelectedMaterialIndex)].SetValue<int>(value); } }
    }
    public class GeometryCollectionRenderLevelSetActor : Actor
    {
        public GeometryCollectionRenderLevelSetActor(ulong addr) : base(addr) { }
        public VolumeTexture TargetVolumeTexture { get { return this[nameof(TargetVolumeTexture)].As<VolumeTexture>(); } set { this["TargetVolumeTexture"] = value; } }
        public Material RayMarchMaterial { get { return this[nameof(RayMarchMaterial)].As<Material>(); } set { this["RayMarchMaterial"] = value; } }
        public float SurfaceTolerance { get { return this[nameof(SurfaceTolerance)].GetValue<float>(); } set { this[nameof(SurfaceTolerance)].SetValue<float>(value); } }
        public float Isovalue { get { return this[nameof(Isovalue)].GetValue<float>(); } set { this[nameof(Isovalue)].SetValue<float>(value); } }
        public bool Enabled { get { return this[nameof(Enabled)].Flag; } set { this[nameof(Enabled)].Flag = value; } }
        public bool RenderVolumeBoundingBox { get { return this[nameof(RenderVolumeBoundingBox)].Flag; } set { this[nameof(RenderVolumeBoundingBox)].Flag = value; } }
    }
    public class SkeletalMeshSimulationComponent : ActorComponent
    {
        public SkeletalMeshSimulationComponent(ulong addr) : base(addr) { }
        public ChaosPhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<ChaosPhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public ChaosSolverActor ChaosSolverActor { get { return this[nameof(ChaosSolverActor)].As<ChaosSolverActor>(); } set { this["ChaosSolverActor"] = value; } }
        public PhysicsAsset OverridePhysicsAsset { get { return this[nameof(OverridePhysicsAsset)].As<PhysicsAsset>(); } set { this["OverridePhysicsAsset"] = value; } }
        public bool bSimulating { get { return this[nameof(bSimulating)].Flag; } set { this[nameof(bSimulating)].Flag = value; } }
        public bool bNotifyCollisions { get { return this[nameof(bNotifyCollisions)].Flag; } set { this[nameof(bNotifyCollisions)].Flag = value; } }
        public EObjectStateTypeEnum ObjectType { get { return (EObjectStateTypeEnum)this[nameof(ObjectType)].GetValue<int>(); } set { this[nameof(ObjectType)].SetValue<int>((int)value); } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MaxMass { get { return this[nameof(MaxMass)].GetValue<float>(); } set { this[nameof(MaxMass)].SetValue<float>(value); } }
        public ECollisionTypeEnum CollisionType { get { return (ECollisionTypeEnum)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public float ImplicitShapeParticlesPerUnitArea { get { return this[nameof(ImplicitShapeParticlesPerUnitArea)].GetValue<float>(); } set { this[nameof(ImplicitShapeParticlesPerUnitArea)].SetValue<float>(value); } }
        public int ImplicitShapeMinNumParticles { get { return this[nameof(ImplicitShapeMinNumParticles)].GetValue<int>(); } set { this[nameof(ImplicitShapeMinNumParticles)].SetValue<int>(value); } }
        public int ImplicitShapeMaxNumParticles { get { return this[nameof(ImplicitShapeMaxNumParticles)].GetValue<int>(); } set { this[nameof(ImplicitShapeMaxNumParticles)].SetValue<int>(value); } }
        public int MinLevelSetResolution { get { return this[nameof(MinLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinLevelSetResolution)].SetValue<int>(value); } }
        public int MaxLevelSetResolution { get { return this[nameof(MaxLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxLevelSetResolution)].SetValue<int>(value); } }
        public int CollisionGroup { get { return this[nameof(CollisionGroup)].GetValue<int>(); } set { this[nameof(CollisionGroup)].SetValue<int>(value); } }
        public EInitialVelocityTypeEnum InitialVelocityType { get { return (EInitialVelocityTypeEnum)this[nameof(InitialVelocityType)].GetValue<int>(); } set { this[nameof(InitialVelocityType)].SetValue<int>((int)value); } }
        public Vector InitialLinearVelocity { get { return this[nameof(InitialLinearVelocity)].As<Vector>(); } set { this["InitialLinearVelocity"] = value; } }
        public Vector InitialAngularVelocity { get { return this[nameof(InitialAngularVelocity)].As<Vector>(); } set { this["InitialAngularVelocity"] = value; } }
        public Object OnChaosPhysicsCollision { get { return this[nameof(OnChaosPhysicsCollision)]; } set { this[nameof(OnChaosPhysicsCollision)] = value; } }
        public void ReceivePhysicsCollision(ChaosPhysicsCollisionInfo CollisionInfo) { Invoke(nameof(ReceivePhysicsCollision), CollisionInfo); }
    }
    public class StaticMeshSimulationComponent : ActorComponent
    {
        public StaticMeshSimulationComponent(ulong addr) : base(addr) { }
        public bool Simulating { get { return this[nameof(Simulating)].Flag; } set { this[nameof(Simulating)].Flag = value; } }
        public bool bNotifyCollisions { get { return this[nameof(bNotifyCollisions)].Flag; } set { this[nameof(bNotifyCollisions)].Flag = value; } }
        public EObjectStateTypeEnum ObjectType { get { return (EObjectStateTypeEnum)this[nameof(ObjectType)].GetValue<int>(); } set { this[nameof(ObjectType)].SetValue<int>((int)value); } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public ECollisionTypeEnum CollisionType { get { return (ECollisionTypeEnum)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public EImplicitTypeEnum ImplicitType { get { return (EImplicitTypeEnum)this[nameof(ImplicitType)].GetValue<int>(); } set { this[nameof(ImplicitType)].SetValue<int>((int)value); } }
        public int MinLevelSetResolution { get { return this[nameof(MinLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinLevelSetResolution)].SetValue<int>(value); } }
        public int MaxLevelSetResolution { get { return this[nameof(MaxLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxLevelSetResolution)].SetValue<int>(value); } }
        public EInitialVelocityTypeEnum InitialVelocityType { get { return (EInitialVelocityTypeEnum)this[nameof(InitialVelocityType)].GetValue<int>(); } set { this[nameof(InitialVelocityType)].SetValue<int>((int)value); } }
        public Vector InitialLinearVelocity { get { return this[nameof(InitialLinearVelocity)].As<Vector>(); } set { this["InitialLinearVelocity"] = value; } }
        public Vector InitialAngularVelocity { get { return this[nameof(InitialAngularVelocity)].As<Vector>(); } set { this["InitialAngularVelocity"] = value; } }
        public float DamageThreshold { get { return this[nameof(DamageThreshold)].GetValue<float>(); } set { this[nameof(DamageThreshold)].SetValue<float>(value); } }
        public ChaosPhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<ChaosPhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public ChaosSolverActor ChaosSolverActor { get { return this[nameof(ChaosSolverActor)].As<ChaosSolverActor>(); } set { this["ChaosSolverActor"] = value; } }
        public Object OnChaosPhysicsCollision { get { return this[nameof(OnChaosPhysicsCollision)]; } set { this[nameof(OnChaosPhysicsCollision)] = value; } }
        public Array<PrimitiveComponent> SimulatedComponents { get { return new Array<PrimitiveComponent>(this[nameof(SimulatedComponents)].Address); } }
        public void ReceivePhysicsCollision(ChaosPhysicsCollisionInfo CollisionInfo) { Invoke(nameof(ReceivePhysicsCollision), CollisionInfo); }
        public void ForceRecreatePhysicsState() { Invoke(nameof(ForceRecreatePhysicsState)); }
    }
    public class ChaosCollisionEventData : Object
    {
        public ChaosCollisionEventData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector Velocity1 { get { return this[nameof(Velocity1)].As<Vector>(); } set { this["Velocity1"] = value; } }
        public Vector Velocity2 { get { return this[nameof(Velocity2)].As<Vector>(); } set { this["Velocity2"] = value; } }
        public float Mass1 { get { return this[nameof(Mass1)].GetValue<float>(); } set { this[nameof(Mass1)].SetValue<float>(value); } }
        public float Mass2 { get { return this[nameof(Mass2)].GetValue<float>(); } set { this[nameof(Mass2)].SetValue<float>(value); } }
        public Vector Impulse { get { return this[nameof(Impulse)].As<Vector>(); } set { this["Impulse"] = value; } }
    }
    public class ChaosBreakingEventData : Object
    {
        public ChaosBreakingEventData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
    }
    public class ChaosTrailingEventData : Object
    {
        public ChaosTrailingEventData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
    }
    public class GeometryCollectionRepData : Object
    {
        public GeometryCollectionRepData(ulong addr) : base(addr) { }
    }
    public class GeomComponentCacheParameters : Object
    {
        public GeomComponentCacheParameters(ulong addr) : base(addr) { }
        public EGeometryCollectionCacheType CacheMode { get { return (EGeometryCollectionCacheType)this[nameof(CacheMode)].GetValue<int>(); } set { this[nameof(CacheMode)].SetValue<int>((int)value); } }
        public GeometryCollectionCache TargetCache { get { return this[nameof(TargetCache)].As<GeometryCollectionCache>(); } set { this["TargetCache"] = value; } }
        public float ReverseCacheBeginTime { get { return this[nameof(ReverseCacheBeginTime)].GetValue<float>(); } set { this[nameof(ReverseCacheBeginTime)].SetValue<float>(value); } }
        public bool SaveCollisionData { get { return this[nameof(SaveCollisionData)].Flag; } set { this[nameof(SaveCollisionData)].Flag = value; } }
        public bool DoGenerateCollisionData { get { return this[nameof(DoGenerateCollisionData)].Flag; } set { this[nameof(DoGenerateCollisionData)].Flag = value; } }
        public int CollisionDataSizeMax { get { return this[nameof(CollisionDataSizeMax)].GetValue<int>(); } set { this[nameof(CollisionDataSizeMax)].SetValue<int>(value); } }
        public bool DoCollisionDataSpatialHash { get { return this[nameof(DoCollisionDataSpatialHash)].Flag; } set { this[nameof(DoCollisionDataSpatialHash)].Flag = value; } }
        public float CollisionDataSpatialHashRadius { get { return this[nameof(CollisionDataSpatialHashRadius)].GetValue<float>(); } set { this[nameof(CollisionDataSpatialHashRadius)].SetValue<float>(value); } }
        public int MaxCollisionPerCell { get { return this[nameof(MaxCollisionPerCell)].GetValue<int>(); } set { this[nameof(MaxCollisionPerCell)].SetValue<int>(value); } }
        public bool SaveBreakingData { get { return this[nameof(SaveBreakingData)].Flag; } set { this[nameof(SaveBreakingData)].Flag = value; } }
        public bool DoGenerateBreakingData { get { return this[nameof(DoGenerateBreakingData)].Flag; } set { this[nameof(DoGenerateBreakingData)].Flag = value; } }
        public int BreakingDataSizeMax { get { return this[nameof(BreakingDataSizeMax)].GetValue<int>(); } set { this[nameof(BreakingDataSizeMax)].SetValue<int>(value); } }
        public bool DoBreakingDataSpatialHash { get { return this[nameof(DoBreakingDataSpatialHash)].Flag; } set { this[nameof(DoBreakingDataSpatialHash)].Flag = value; } }
        public float BreakingDataSpatialHashRadius { get { return this[nameof(BreakingDataSpatialHashRadius)].GetValue<float>(); } set { this[nameof(BreakingDataSpatialHashRadius)].SetValue<float>(value); } }
        public int MaxBreakingPerCell { get { return this[nameof(MaxBreakingPerCell)].GetValue<int>(); } set { this[nameof(MaxBreakingPerCell)].SetValue<int>(value); } }
        public bool SaveTrailingData { get { return this[nameof(SaveTrailingData)].Flag; } set { this[nameof(SaveTrailingData)].Flag = value; } }
        public bool DoGenerateTrailingData { get { return this[nameof(DoGenerateTrailingData)].Flag; } set { this[nameof(DoGenerateTrailingData)].Flag = value; } }
        public int TrailingDataSizeMax { get { return this[nameof(TrailingDataSizeMax)].GetValue<int>(); } set { this[nameof(TrailingDataSizeMax)].SetValue<int>(value); } }
        public float TrailingMinSpeedThreshold { get { return this[nameof(TrailingMinSpeedThreshold)].GetValue<float>(); } set { this[nameof(TrailingMinSpeedThreshold)].SetValue<float>(value); } }
        public float TrailingMinVolumeThreshold { get { return this[nameof(TrailingMinVolumeThreshold)].GetValue<float>(); } set { this[nameof(TrailingMinVolumeThreshold)].SetValue<float>(value); } }
    }
    public enum EChaosBreakingSortMethod : int
    {
        SortNone = 0,
        SortByHighestMass = 1,
        SortByHighestSpeed = 2,
        SortByNearestFirst = 3,
        Count = 4,
        EChaosBreakingSortMethod_MAX = 5,
    }
    public enum EChaosCollisionSortMethod : int
    {
        SortNone = 0,
        SortByHighestMass = 1,
        SortByHighestSpeed = 2,
        SortByHighestImpulse = 3,
        SortByNearestFirst = 4,
        Count = 5,
        EChaosCollisionSortMethod_MAX = 6,
    }
    public enum EChaosTrailingSortMethod : int
    {
        SortNone = 0,
        SortByHighestMass = 1,
        SortByHighestSpeed = 2,
        SortByNearestFirst = 3,
        Count = 4,
        EChaosTrailingSortMethod_MAX = 5,
    }
    public enum EGeometryCollectionDebugDrawActorHideGeometry : int
    {
        HideNone = 0,
        HideWithCollision = 1,
        HideSelected = 2,
        HideWholeCollection = 3,
        HideAll = 4,
        EGeometryCollectionDebugDrawActorHideGeometry_MAX = 5,
    }
    public enum ECollectionGroupEnum : int
    {
        Chaos_Traansform = 0,
        Chaos_Max = 1,
    }
    public enum ECollectionAttributeEnum : int
    {
        Chaos_Active = 0,
        Chaos_DynamicState = 1,
        Chaos_CollisionGroup = 2,
        Chaos_Max = 3,
    }
    public class ChaosBreakingEventRequestSettings : Object
    {
        public ChaosBreakingEventRequestSettings(ulong addr) : base(addr) { }
        public int MaxNumberOfResults { get { return this[nameof(MaxNumberOfResults)].GetValue<int>(); } set { this[nameof(MaxNumberOfResults)].SetValue<int>(value); } }
        public float MinRadius { get { return this[nameof(MinRadius)].GetValue<float>(); } set { this[nameof(MinRadius)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public EChaosBreakingSortMethod SortMethod { get { return (EChaosBreakingSortMethod)this[nameof(SortMethod)].GetValue<int>(); } set { this[nameof(SortMethod)].SetValue<int>((int)value); } }
    }
    public class ChaosCollisionEventRequestSettings : Object
    {
        public ChaosCollisionEventRequestSettings(ulong addr) : base(addr) { }
        public int MaxNumberResults { get { return this[nameof(MaxNumberResults)].GetValue<int>(); } set { this[nameof(MaxNumberResults)].SetValue<int>(value); } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinImpulse { get { return this[nameof(MinImpulse)].GetValue<float>(); } set { this[nameof(MinImpulse)].SetValue<float>(value); } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public EChaosCollisionSortMethod SortMethod { get { return (EChaosCollisionSortMethod)this[nameof(SortMethod)].GetValue<int>(); } set { this[nameof(SortMethod)].SetValue<int>((int)value); } }
    }
    public class ChaosTrailingEventRequestSettings : Object
    {
        public ChaosTrailingEventRequestSettings(ulong addr) : base(addr) { }
        public int MaxNumberOfResults { get { return this[nameof(MaxNumberOfResults)].GetValue<int>(); } set { this[nameof(MaxNumberOfResults)].SetValue<int>(value); } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinAngularSpeed { get { return this[nameof(MinAngularSpeed)].GetValue<float>(); } set { this[nameof(MinAngularSpeed)].SetValue<float>(value); } }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public EChaosTrailingSortMethod SortMethod { get { return (EChaosTrailingSortMethod)this[nameof(SortMethod)].GetValue<int>(); } set { this[nameof(SortMethod)].SetValue<int>((int)value); } }
    }
    public class GeometryCollectionDebugDrawActorSelectedRigidBody : Object
    {
        public GeometryCollectionDebugDrawActorSelectedRigidBody(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public ChaosSolverActor Solver { get { return this[nameof(Solver)].As<ChaosSolverActor>(); } set { this["Solver"] = value; } }
        public GeometryCollectionActor GeometryCollection { get { return this[nameof(GeometryCollection)].As<GeometryCollectionActor>(); } set { this["GeometryCollection"] = value; } }
    }
    public class GeometryCollectionDebugDrawWarningMessage : Object
    {
        public GeometryCollectionDebugDrawWarningMessage(ulong addr) : base(addr) { }
    }
    public class GeometryCollectionSizeSpecificData : Object
    {
        public GeometryCollectionSizeSpecificData(ulong addr) : base(addr) { }
        public float MaxSize { get { return this[nameof(MaxSize)].GetValue<float>(); } set { this[nameof(MaxSize)].SetValue<float>(value); } }
        public ECollisionTypeEnum CollisionType { get { return (ECollisionTypeEnum)this[nameof(CollisionType)].GetValue<int>(); } set { this[nameof(CollisionType)].SetValue<int>((int)value); } }
        public EImplicitTypeEnum ImplicitType { get { return (EImplicitTypeEnum)this[nameof(ImplicitType)].GetValue<int>(); } set { this[nameof(ImplicitType)].SetValue<int>((int)value); } }
        public int MinLevelSetResolution { get { return this[nameof(MinLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinLevelSetResolution)].SetValue<int>(value); } }
        public int MaxLevelSetResolution { get { return this[nameof(MaxLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxLevelSetResolution)].SetValue<int>(value); } }
        public int MinClusterLevelSetResolution { get { return this[nameof(MinClusterLevelSetResolution)].GetValue<int>(); } set { this[nameof(MinClusterLevelSetResolution)].SetValue<int>(value); } }
        public int MaxClusterLevelSetResolution { get { return this[nameof(MaxClusterLevelSetResolution)].GetValue<int>(); } set { this[nameof(MaxClusterLevelSetResolution)].SetValue<int>(value); } }
        public int CollisionObjectReductionPercentage { get { return this[nameof(CollisionObjectReductionPercentage)].GetValue<int>(); } set { this[nameof(CollisionObjectReductionPercentage)].SetValue<int>(value); } }
        public float CollisionParticlesFraction { get { return this[nameof(CollisionParticlesFraction)].GetValue<float>(); } set { this[nameof(CollisionParticlesFraction)].SetValue<float>(value); } }
        public int MaximumCollisionParticles { get { return this[nameof(MaximumCollisionParticles)].GetValue<int>(); } set { this[nameof(MaximumCollisionParticles)].SetValue<int>(value); } }
    }
    public class GeometryCollectionSource : Object
    {
        public GeometryCollectionSource(ulong addr) : base(addr) { }
        public SoftObjectPath SourceGeometryObject { get { return this[nameof(SourceGeometryObject)].As<SoftObjectPath>(); } set { this["SourceGeometryObject"] = value; } }
        public Transform LocalTransform { get { return this[nameof(LocalTransform)].As<Transform>(); } set { this["LocalTransform"] = value; } }
        public Array<MaterialInterface> SourceMaterial { get { return new Array<MaterialInterface>(this[nameof(SourceMaterial)].Address); } }
    }
}
