using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.SharedSDK;
using SDK.Script.AIModuleSDK;
using SDK.Script.BifrostSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.NiagaraSDK;
using SDK.Script.UMGSDK;
using SDK.Script.ProceduralMeshComponentSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.AdvancedSessionsSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.BifrostPartySDK;
using SDK.Script.OverlaySDK;
namespace SDK.Script.TOMSDK
{
    public class AchievementsManager : Object
    {
        public AchievementsManager(ulong addr) : base(addr) { }
        public UserEntityModel UserEntityModel { get { return this[nameof(UserEntityModel)].As<UserEntityModel>(); } set { this["UserEntityModel"] = value; } }
        public Object Achievements { get { return this[nameof(Achievements)]; } set { this[nameof(Achievements)] = value; } }
        public Object MaxTargetValueByAchievementType { get { return this[nameof(MaxTargetValueByAchievementType)]; } set { this[nameof(MaxTargetValueByAchievementType)] = value; } }
        public Array<int> CompletedAchievementsCache { get { return new Array<int>(this[nameof(CompletedAchievementsCache)].Address); } }
        public void OnUserDataChanged() { Invoke(nameof(OnUserDataChanged)); }
    }
    public class AnalyticsManager : Object
    {
        public AnalyticsManager(ulong addr) : base(addr) { }
        public int CurrentStoreSequence { get { return this[nameof(CurrentStoreSequence)].GetValue<int>(); } set { this[nameof(CurrentStoreSequence)].SetValue<int>(value); } }
        public Object CurrentStoreGuid { get { return this[nameof(CurrentStoreGuid)]; } set { this[nameof(CurrentStoreGuid)] = value; } }
        public void StopServerTickers() { Invoke(nameof(StopServerTickers)); }
        public void StartServerTickers() { Invoke(nameof(StartServerTickers)); }
        public void SetStatus(Object Status) { Invoke(nameof(SetStatus), Status); }
        public void SendStoreInteractionEvent(Object Event, ShopItemDataModel Item) { Invoke(nameof(SendStoreInteractionEvent), Event, Item); }
    }
    public class AnimalAIController : AIController
    {
        public AnimalAIController(ulong addr) : base(addr) { }
        public Object OnSwitchMainTarget { get { return this[nameof(OnSwitchMainTarget)]; } set { this[nameof(OnSwitchMainTarget)] = value; } }
        public Object CurrentMoveToTargetBBKey { get { return this[nameof(CurrentMoveToTargetBBKey)]; } set { this[nameof(CurrentMoveToTargetBBKey)] = value; } }
        public Object StraightDistanceToMoveToTargetBBKey { get { return this[nameof(StraightDistanceToMoveToTargetBBKey)]; } set { this[nameof(StraightDistanceToMoveToTargetBBKey)] = value; } }
        public Object LastMoveToTargetPositionBBKey { get { return this[nameof(LastMoveToTargetPositionBBKey)]; } set { this[nameof(LastMoveToTargetPositionBBKey)] = value; } }
        public Object CurrentAttackIdBBKey { get { return this[nameof(CurrentAttackIdBBKey)]; } set { this[nameof(CurrentAttackIdBBKey)] = value; } }
        public Object CurrentAttackTargetBBKey { get { return this[nameof(CurrentAttackTargetBBKey)]; } set { this[nameof(CurrentAttackTargetBBKey)] = value; } }
        public Object DetectionProfileName { get { return this[nameof(DetectionProfileName)]; } set { this[nameof(DetectionProfileName)] = value; } }
        public bool bCanTargetOpenedGates { get { return this[nameof(bCanTargetOpenedGates)].Flag; } set { this[nameof(bCanTargetOpenedGates)].Flag = value; } }
        public float MaxDistToFollowTarget { get { return this[nameof(MaxDistToFollowTarget)].GetValue<float>(); } set { this[nameof(MaxDistToFollowTarget)].SetValue<float>(value); } }
        public float ZDiffBellowThreshold { get { return this[nameof(ZDiffBellowThreshold)].GetValue<float>(); } set { this[nameof(ZDiffBellowThreshold)].SetValue<float>(value); } }
        public float NearTargetRadius { get { return this[nameof(NearTargetRadius)].GetValue<float>(); } set { this[nameof(NearTargetRadius)].SetValue<float>(value); } }
        public float DetectionFrequency { get { return this[nameof(DetectionFrequency)].GetValue<float>(); } set { this[nameof(DetectionFrequency)].SetValue<float>(value); } }
        public WorldCreatureEntityModel WorldCreatureEntity { get { return this[nameof(WorldCreatureEntity)].As<WorldCreatureEntityModel>(); } set { this["WorldCreatureEntity"] = value; } }
        public TOMCharacter TOMControllerCharacter { get { return this[nameof(TOMControllerCharacter)].As<TOMCharacter>(); } set { this["TOMControllerCharacter"] = value; } }
        public Array<DefensiveComponent> LastPerceivedTargets { get { return new Array<DefensiveComponent>(this[nameof(LastPerceivedTargets)].Address); } }
        public AIBehaviourDataModel AIBehaviourData { get { return this[nameof(AIBehaviourData)].As<AIBehaviourDataModel>(); } set { this["AIBehaviourData"] = value; } }
        public Actor MainTarget { get { return this[nameof(MainTarget)].As<Actor>(); } set { this["MainTarget"] = value; } }
        public Actor CurrentTarget { get { return this[nameof(CurrentTarget)].As<Actor>(); } set { this["CurrentTarget"] = value; } }
        public DefensiveComponent LastAttacker { get { return this[nameof(LastAttacker)].As<DefensiveComponent>(); } set { this["LastAttacker"] = value; } }
        public void PerceptionForgetAll() { Invoke(nameof(PerceptionForgetAll)); }
        public void OnPathBlockedByActors() { Invoke(nameof(OnPathBlockedByActors)); }
        public void OnEnterDownState(HealthComponent HealthComponent) { Invoke(nameof(OnEnterDownState), HealthComponent); }
        public void OnControlledDamageReceived(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnControlledDamageReceived), Source, IssuedAmount, HitResult); }
        public bool IsInsideMinAttackRange(float Distance, Actor Target, bool OnlyAvailable) { return Invoke<bool>(nameof(IsInsideMinAttackRange), Distance, Target, OnlyAvailable); }
        public void InitController() { Invoke(nameof(InitController)); }
        public WorldCreatureEntityModel GetWorldCreatureEntity() { return Invoke<WorldCreatureEntityModel>(nameof(GetWorldCreatureEntity)); }
        public Actor GetMainTarget() { return Invoke<Actor>(nameof(GetMainTarget)); }
        public Array<DefensiveComponent> GetLastPerceivedTargets() { return Invoke<Array<DefensiveComponent>>(nameof(GetLastPerceivedTargets)); }
        public Actor GetLastAttacker() { return Invoke<Actor>(nameof(GetLastAttacker)); }
        public EAnimalState GetCurrentAnimalState() { return Invoke<EAnimalState>(nameof(GetCurrentAnimalState)); }
        public void EvaluateTargets() { Invoke(nameof(EvaluateTargets)); }
        public void EvaluateAttacks() { Invoke(nameof(EvaluateAttacks)); }
    }
    public class AnimNotify_CharacterHarvest : AnimNotify
    {
        public AnimNotify_CharacterHarvest(ulong addr) : base(addr) { }
    }
    public class AnimNotify_FireBuff : AnimNotify
    {
        public AnimNotify_FireBuff(ulong addr) : base(addr) { }
    }
    public class AnimNotify_FireProjectile : AnimNotify
    {
        public AnimNotify_FireProjectile(ulong addr) : base(addr) { }
        public Rotator RotationOffset { get { return this[nameof(RotationOffset)].As<Rotator>(); } set { this["RotationOffset"] = value; } }
        public Vector LocationOffset { get { return this[nameof(LocationOffset)].As<Vector>(); } set { this["LocationOffset"] = value; } }
    }
    public class AnimNotify_PlayCharacterSFX : AnimNotify
    {
        public AnimNotify_PlayCharacterSFX(ulong addr) : base(addr) { }
        public Object SFXSuffix { get { return this[nameof(SFXSuffix)]; } set { this[nameof(SFXSuffix)] = value; } }
    }
    public class AnimNotify_PostAudioEvent : AnimNotify
    {
        public AnimNotify_PostAudioEvent(ulong addr) : base(addr) { }
        public Object SFXName { get { return this[nameof(SFXName)]; } set { this[nameof(SFXName)] = value; } }
    }
    public class AnimNotify_SlashVFX : AnimNotify
    {
        public AnimNotify_SlashVFX(ulong addr) : base(addr) { }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
        public bool Attached { get { return this[nameof(Attached)].Flag; } set { this[nameof(Attached)].Flag = value; } }
    }
    public class AnimNotifyState_AttackQueue : AnimNotifyState
    {
        public AnimNotifyState_AttackQueue(ulong addr) : base(addr) { }
    }
    public class AnimNotifyState_ExecutionState : AnimNotifyState
    {
        public AnimNotifyState_ExecutionState(ulong addr) : base(addr) { }
        public bool bAuthorizeRotation { get { return this[nameof(bAuthorizeRotation)].Flag; } set { this[nameof(bAuthorizeRotation)].Flag = value; } }
    }
    public class AnimNotifyState_IgnoreVelocity : AnimNotifyState
    {
        public AnimNotifyState_IgnoreVelocity(ulong addr) : base(addr) { }
    }
    public class AnimNotifyState_ShowArrowPreview : AnimNotifyState
    {
        public AnimNotifyState_ShowArrowPreview(ulong addr) : base(addr) { }
    }
    public class AnticipationState : AnimNotifyState
    {
        public AnticipationState(ulong addr) : base(addr) { }
    }
    public class TOMActor : BifrostActor
    {
        public TOMActor(ulong addr) : base(addr) { }
        public bool bIsActivated { get { return this[nameof(bIsActivated)].Flag; } set { this[nameof(bIsActivated)].Flag = value; } }
        public void Spawn() { Invoke(nameof(Spawn)); }
        public void Recycle() { Invoke(nameof(Recycle)); }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void ReceiveSpawn() { Invoke(nameof(ReceiveSpawn)); }
        public void ReceiveRecycle() { Invoke(nameof(ReceiveRecycle)); }
        public void ReceivePlayerReady(TOMPlayerState PlayerState) { Invoke(nameof(ReceivePlayerReady), PlayerState); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
        public void OnRep_bIsActivated() { Invoke(nameof(OnRep_bIsActivated)); }
        public void OnPlayerReady(OnPlayerReadyEventArgs Args) { Invoke(nameof(OnPlayerReady), Args); }
    }
    public class AOEBase : TOMActor
    {
        public AOEBase(ulong addr) : base(addr) { }
        public TOMCharacter TOMCharacterSource { get { return this[nameof(TOMCharacterSource)].As<TOMCharacter>(); } set { this["TOMCharacterSource"] = value; } }
        public float AutoDestroyDelay { get { return this[nameof(AutoDestroyDelay)].GetValue<float>(); } set { this[nameof(AutoDestroyDelay)].SetValue<float>(value); } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
        public bool bUpdateLocationOnEmission { get { return this[nameof(bUpdateLocationOnEmission)].Flag; } set { this[nameof(bUpdateLocationOnEmission)].Flag = value; } }
        public bool IsLastImpact { get { return this[nameof(IsLastImpact)].Flag; } set { this[nameof(IsLastImpact)].Flag = value; } }
        public bool AttachedToSource { get { return this[nameof(AttachedToSource)].Flag; } set { this[nameof(AttachedToSource)].Flag = value; } }
        public TOMOffensiveComponent AOEOffensive { get { return this[nameof(AOEOffensive)].As<TOMOffensiveComponent>(); } set { this["AOEOffensive"] = value; } }
        public void OnInit() { Invoke(nameof(OnInit)); }
        public void OnEndDuration() { Invoke(nameof(OnEndDuration)); }
        public void OnEndDelay() { Invoke(nameof(OnEndDelay)); }
        public void OnAOEStartMulticast(float AOEDuration) { Invoke(nameof(OnAOEStartMulticast), AOEDuration); }
        public void OnAOEStart(float AOEDuration) { Invoke(nameof(OnAOEStart), AOEDuration); }
        public void Init(TOMOffensiveComponent OwnerOffensive, Vector AOEOrigin, Vector AOEEnd, int AttackStatId, StatusComponent Status) { Invoke(nameof(Init), OwnerOffensive, AOEOrigin, AOEEnd, AttackStatId, Status); }
    }
    public class TOMActorComponent : BifrostActorComponent
    {
        public TOMActorComponent(ulong addr) : base(addr) { }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
    }
    public class AppearOnWorldMapComponent : TOMActorComponent
    {
        public AppearOnWorldMapComponent(ulong addr) : base(addr) { }
        public bool bNeverShow { get { return this[nameof(bNeverShow)].Flag; } set { this[nameof(bNeverShow)].Flag = value; } }
        public EAppearOnWorldMapIconWidgetType IconWidgetType { get { return (EAppearOnWorldMapIconWidgetType)this[nameof(IconWidgetType)].GetValue<int>(); } set { this[nameof(IconWidgetType)].SetValue<int>((int)value); } }
        public Object IconPtr { get { return this[nameof(IconPtr)]; } set { this[nameof(IconPtr)] = value; } }
        public bool bIsDynamic { get { return this[nameof(bIsDynamic)].Flag; } set { this[nameof(bIsDynamic)].Flag = value; } }
        public bool bIsRotationLocked { get { return this[nameof(bIsRotationLocked)].Flag; } set { this[nameof(bIsRotationLocked)].Flag = value; } }
        public Object Tooltip { get { return this[nameof(Tooltip)]; } set { this[nameof(Tooltip)] = value; } }
        public AppearOnWorldMapSpawnCondition SpawnCondition { get { return (AppearOnWorldMapSpawnCondition)this[nameof(SpawnCondition)].GetValue<int>(); } set { this[nameof(SpawnCondition)].SetValue<int>((int)value); } }
        public EAppearOnWorldMapSpawnType SpawnType { get { return (EAppearOnWorldMapSpawnType)this[nameof(SpawnType)].GetValue<int>(); } set { this[nameof(SpawnType)].SetValue<int>((int)value); } }
        public Vector ForcedPosition { get { return this[nameof(ForcedPosition)].As<Vector>(); } set { this["ForcedPosition"] = value; } }
        public bool bUseForcedPosition { get { return this[nameof(bUseForcedPosition)].Flag; } set { this[nameof(bUseForcedPosition)].Flag = value; } }
        public bool bIsTracked { get { return this[nameof(bIsTracked)].Flag; } set { this[nameof(bIsTracked)].Flag = value; } }
        public void UpdateTracking(bool bTrack) { Invoke(nameof(UpdateTracking), bTrack); }
        public void UpdateIcon(Texture2D NewIcon, int ForcedZOrder) { Invoke(nameof(UpdateIcon), NewIcon, ForcedZOrder); }
        public void PostUpdateTracking() { Invoke(nameof(PostUpdateTracking)); }
        public void OnTargetChange(Actor NewTarget) { Invoke(nameof(OnTargetChange), NewTarget); }
        public void OnRep_bIsTracked() { Invoke(nameof(OnRep_bIsTracked)); }
        public void OnOwnerDeath(TOMCharacter TOMCharacter) { Invoke(nameof(OnOwnerDeath), TOMCharacter); }
        public void OnControllerReady() { Invoke(nameof(OnControllerReady)); }
        public void Init() { Invoke(nameof(Init)); }
    }
    public class HazardBase : TOMActor
    {
        public HazardBase(ulong addr) : base(addr) { }
        public SceneComponent FloatingUIAnchor { get { return this[nameof(FloatingUIAnchor)].As<SceneComponent>(); } set { this["FloatingUIAnchor"] = value; } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
        public HazardEntityModel EntityModel { get { return this[nameof(EntityModel)].As<HazardEntityModel>(); } set { this["EntityModel"] = value; } }
        public HealthComponent HealthComponent { get { return this[nameof(HealthComponent)].As<HealthComponent>(); } set { this["HealthComponent"] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public DefensiveShieldComponent DefensiveComponent { get { return this[nameof(DefensiveComponent)].As<DefensiveShieldComponent>(); } set { this["DefensiveComponent"] = value; } }
        public TOMOffensiveComponent OffensiveComponent { get { return this[nameof(OffensiveComponent)].As<TOMOffensiveComponent>(); } set { this["OffensiveComponent"] = value; } }
        public SphereComponent InteractableCollision { get { return this[nameof(InteractableCollision)].As<SphereComponent>(); } set { this["InteractableCollision"] = value; } }
        public BoxComponent ConstructionWallCollision { get { return this[nameof(ConstructionWallCollision)].As<BoxComponent>(); } set { this["ConstructionWallCollision"] = value; } }
        public BoxComponent QueryCollision { get { return this[nameof(QueryCollision)].As<BoxComponent>(); } set { this["QueryCollision"] = value; } }
        public AppearOnWorldMapComponent AppearOnWorldMap { get { return this[nameof(AppearOnWorldMap)].As<AppearOnWorldMapComponent>(); } set { this["AppearOnWorldMap"] = value; } }
        public bool bHideOnTrigger { get { return this[nameof(bHideOnTrigger)].Flag; } set { this[nameof(bHideOnTrigger)].Flag = value; } }
        public int DefaultHazardId { get { return this[nameof(DefaultHazardId)].GetValue<int>(); } set { this[nameof(DefaultHazardId)].SetValue<int>(value); } }
        public bool bReplicateTimer { get { return this[nameof(bReplicateTimer)].Flag; } set { this[nameof(bReplicateTimer)].Flag = value; } }
        public bool bActivateOnDeath { get { return this[nameof(bActivateOnDeath)].Flag; } set { this[nameof(bActivateOnDeath)].Flag = value; } }
        public bool bTriggerOnDeath { get { return this[nameof(bTriggerOnDeath)].Flag; } set { this[nameof(bTriggerOnDeath)].Flag = value; } }
        public bool bIsConstruction { get { return this[nameof(bIsConstruction)].Flag; } set { this[nameof(bIsConstruction)].Flag = value; } }
        public Object ConstructionMaterialColorName { get { return this[nameof(ConstructionMaterialColorName)]; } set { this[nameof(ConstructionMaterialColorName)] = value; } }
        public Object ConstructionMaterialParameterName { get { return this[nameof(ConstructionMaterialParameterName)]; } set { this[nameof(ConstructionMaterialParameterName)] = value; } }
        public ParticleSystem OnSpawnParticles { get { return this[nameof(OnSpawnParticles)].As<ParticleSystem>(); } set { this["OnSpawnParticles"] = value; } }
        public int ConstructionModeStencilValue { get { return this[nameof(ConstructionModeStencilValue)].GetValue<int>(); } set { this[nameof(ConstructionModeStencilValue)].SetValue<int>(value); } }
        public float DefaultDelayBeforeDestroy { get { return this[nameof(DefaultDelayBeforeDestroy)].GetValue<float>(); } set { this[nameof(DefaultDelayBeforeDestroy)].SetValue<float>(value); } }
        public float DissolveDuration { get { return this[nameof(DissolveDuration)].GetValue<float>(); } set { this[nameof(DissolveDuration)].SetValue<float>(value); } }
        public Object DissolveParameterName { get { return this[nameof(DissolveParameterName)]; } set { this[nameof(DissolveParameterName)] = value; } }
        public EAdjustmentMethod LayoutAdjustmentsMethod { get { return (EAdjustmentMethod)this[nameof(LayoutAdjustmentsMethod)].GetValue<int>(); } set { this[nameof(LayoutAdjustmentsMethod)].SetValue<int>((int)value); } }
        public Array<MaterialInstanceDynamic> DynamicMaterials { get { return new Array<MaterialInstanceDynamic>(this[nameof(DynamicMaterials)].Address); } }
        public Actor ProjectileActor { get { return this[nameof(ProjectileActor)].As<Actor>(); } set { this["ProjectileActor"] = value; } }
        public Object OnHazardDestruction { get { return this[nameof(OnHazardDestruction)]; } set { this[nameof(OnHazardDestruction)] = value; } }
        public Object OnHazardPathObstacleRefresh { get { return this[nameof(OnHazardPathObstacleRefresh)]; } set { this[nameof(OnHazardPathObstacleRefresh)] = value; } }
        public Object OnHazardDelayedHide { get { return this[nameof(OnHazardDelayedHide)]; } set { this[nameof(OnHazardDelayedHide)] = value; } }
        public bool bBuildOnEdge { get { return this[nameof(bBuildOnEdge)].Flag; } set { this[nameof(bBuildOnEdge)].Flag = value; } }
        public bool bIgnoreCornerRotation { get { return this[nameof(bIgnoreCornerRotation)].Flag; } set { this[nameof(bIgnoreCornerRotation)].Flag = value; } }
        public bool bCanFlip { get { return this[nameof(bCanFlip)].Flag; } set { this[nameof(bCanFlip)].Flag = value; } }
        public bool bCanChangeElevation { get { return this[nameof(bCanChangeElevation)].Flag; } set { this[nameof(bCanChangeElevation)].Flag = value; } }
        public bool bAllowBuildingConstruction { get { return this[nameof(bAllowBuildingConstruction)].Flag; } set { this[nameof(bAllowBuildingConstruction)].Flag = value; } }
        public int ElevationOffset { get { return this[nameof(ElevationOffset)].GetValue<int>(); } set { this[nameof(ElevationOffset)].SetValue<int>(value); } }
        public bool bAdjustCenter { get { return this[nameof(bAdjustCenter)].Flag; } set { this[nameof(bAdjustCenter)].Flag = value; } }
        public Object StaticGridActor { get { return this[nameof(StaticGridActor)]; } set { this[nameof(StaticGridActor)] = value; } }
        public void TriggerHazard(Vector From, TOMCharacter TriggeringCharacter, AttackStatsDataModel OverrideAttack, ReceiverComponent Target) { Invoke(nameof(TriggerHazard), From, TriggeringCharacter, OverrideAttack, Target); }
        public void StopHazard(ReceiverComponent Target) { Invoke(nameof(StopHazard), Target); }
        public void Show() { Invoke(nameof(Show)); }
        public void OnReceiveDamageBP(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnReceiveDamageBP), Source, IssuedAmount, HitResult); }
        public void OnReceiveDamage(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnReceiveDamage), Source, IssuedAmount, HitResult); }
        public void OnHazardDeath() { Invoke(nameof(OnHazardDeath)); }
        public void OnDamageTypeReceivedMulticast(int TypeId, float Amount, int Effectiveness) { Invoke(nameof(OnDamageTypeReceivedMulticast), TypeId, Amount, Effectiveness); }
        public void OnDamageTypeReceived(DefensiveShieldComponent InDefensiveComponent, int TypeId, float Amount, int Effectiveness) { Invoke(nameof(OnDamageTypeReceived), InDefensiveComponent, TypeId, Amount, Effectiveness); }
        public void OnConstructionSpawn() { Invoke(nameof(OnConstructionSpawn)); }
        public void OnChunkBuild(bool bIsBuild) { Invoke(nameof(OnChunkBuild), bIsBuild); }
        public void LoadDynamicMaterials(bool ChangeStencil) { Invoke(nameof(LoadDynamicMaterials), ChangeStencil); }
        public HazardEntityModel InitWithDefaultEntity(Object HazardEntityId) { return Invoke<HazardEntityModel>(nameof(InitWithDefaultEntity), HazardEntityId); }
        public void Init(HazardEntityModel InEntityModel) { Invoke(nameof(Init), InEntityModel); }
        public void Hide() { Invoke(nameof(Hide)); }
        public PrimitiveComponent GetPlacementCollision() { return Invoke<PrimitiveComponent>(nameof(GetPlacementCollision)); }
        public Array<TOMCharacter> GetOverlappingCharacters() { return Invoke<Array<TOMCharacter>>(nameof(GetOverlappingCharacters)); }
        public HealthComponent GetHealthComponent() { return Invoke<HealthComponent>(nameof(GetHealthComponent)); }
        public HazardEntityModel GetEntityModel() { return Invoke<HazardEntityModel>(nameof(GetEntityModel)); }
        public DefensiveShieldComponent GetDefensiveComponent() { return Invoke<DefensiveShieldComponent>(nameof(GetDefensiveComponent)); }
        public void DissolveMulticast() { Invoke(nameof(DissolveMulticast)); }
        public void Dissolve() { Invoke(nameof(Dissolve)); }
        public void Die() { Invoke(nameof(Die)); }
        public void DelayedHide() { Invoke(nameof(DelayedHide)); }
        public void Deconstruct(Actor Source) { Invoke(nameof(Deconstruct), Source); }
    }
    public class ApplyPerkHazardBase : HazardBase
    {
        public ApplyPerkHazardBase(ulong addr) : base(addr) { }
        public void SetIsInteractable(bool bIsInteractable) { Invoke(nameof(SetIsInteractable), bIsInteractable); }
        public void Interact(TOMCharacter Character) { Invoke(nameof(Interact), Character); }
    }
    public class TOMEquipmentBase : TOMActor
    {
        public TOMEquipmentBase(ulong addr) : base(addr) { }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
        public Object SocketNameFemale { get { return this[nameof(SocketNameFemale)]; } set { this[nameof(SocketNameFemale)] = value; } }
        public Object ProjectileSocketName { get { return this[nameof(ProjectileSocketName)]; } set { this[nameof(ProjectileSocketName)] = value; } }
        public Character CharacterOwner { get { return this[nameof(CharacterOwner)].As<Character>(); } set { this["CharacterOwner"] = value; } }
        public Object ItemEntityId { get { return this[nameof(ItemEntityId)]; } set { this[nameof(ItemEntityId)] = value; } }
        public bool bIsCreature { get { return this[nameof(bIsCreature)].Flag; } set { this[nameof(bIsCreature)].Flag = value; } }
        public ItemDataModel ItemDataModel { get { return this[nameof(ItemDataModel)].As<ItemDataModel>(); } set { this["ItemDataModel"] = value; } }
        public Array<SkeletalMeshComponent> SkeletalMeshes { get { return new Array<SkeletalMeshComponent>(this[nameof(SkeletalMeshes)].Address); } }
        public Array<Object> PlayersReady { get { return new Array<Object>(this[nameof(PlayersReady)].Address); } }
        public TimerHandle RetryTimer { get { return this[nameof(RetryTimer)].As<TimerHandle>(); } set { this["RetryTimer"] = value; } }
        public void SetItemDataModel(ItemDataModel InItemDataModel) { Invoke(nameof(SetItemDataModel), InItemDataModel); }
        public void OnItemBreak() { Invoke(nameof(OnItemBreak)); }
        public void BreakEquipment() { Invoke(nameof(BreakEquipment)); }
    }
    public class ArmorBase : TOMEquipmentBase
    {
        public ArmorBase(ulong addr) : base(addr) { }
    }
    public class AsyncTaskDownloadImageShift : BlueprintAsyncActionBase
    {
        public AsyncTaskDownloadImageShift(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFail { get { return this[nameof(OnFail)]; } set { this[nameof(OnFail)] = value; } }
        public AsyncTaskDownloadImageShift DownloadImage(Object URL, Object Session) { return Invoke<AsyncTaskDownloadImageShift>(nameof(DownloadImage), URL, Session); }
    }
    public class AudioSourceProperty : Object
    {
        public AudioSourceProperty(ulong addr) : base(addr) { }
        public Object AudioEventName { get { return this[nameof(AudioEventName)]; } set { this[nameof(AudioEventName)] = value; } }
        public Array<Actor> Actors { get { return new Array<Actor>(this[nameof(Actors)].Address); } }
        public ActorComponent AudioComponent { get { return this[nameof(AudioComponent)].As<ActorComponent>(); } set { this["AudioComponent"] = value; } }
        public bool IsPlaying { get { return this[nameof(IsPlaying)].Flag; } set { this[nameof(IsPlaying)].Flag = value; } }
        public bool bIsDirty { get { return this[nameof(bIsDirty)].Flag; } set { this[nameof(bIsDirty)].Flag = value; } }
    }
    public class AudioManager : TOMActor
    {
        public AudioManager(ulong addr) : base(addr) { }
        public Array<AudioSourceProperty> AudioNameToSources { get { return new Array<AudioSourceProperty>(this[nameof(AudioNameToSources)].Address); } }
        public void UnRegisterNewSource(Actor NewSource, Object AudioEventName) { Invoke(nameof(UnRegisterNewSource), NewSource, AudioEventName); }
        public void SetRTPCValue(Object RTPC, float Value, int InterpolationTimeMs, Actor Actor) { Invoke(nameof(SetRTPCValue), RTPC, Value, InterpolationTimeMs, Actor); }
        public void RegisterNewSource(Actor NewSource, Object AudioEventName) { Invoke(nameof(RegisterNewSource), NewSource, AudioEventName); }
        public int PostEventAtLocation(Object EventName, Vector Location, Rotator Orientation, Object WorldContextObject) { return Invoke<int>(nameof(PostEventAtLocation), EventName, Location, Orientation, WorldContextObject); }
        public int PostEvent(Object EventName, Actor Actor, int CallbackMask, bool bStopWhenAttachedToDestroyed) { return Invoke<int>(nameof(PostEvent), EventName, Actor, CallbackMask, bStopWhenAttachedToDestroyed); }
    }
    public class BackendErrors : BlueprintFunctionLibrary
    {
        public BackendErrors(ulong addr) : base(addr) { }
        public bool IsErrorIgnored(Object ErrorId) { return Invoke<bool>(nameof(IsErrorIgnored), ErrorId); }
        public Object GetLocalizedError(Object ErrorId) { return Invoke<Object>(nameof(GetLocalizedError), ErrorId); }
    }
    public class BackendGISubsystem : GameInstanceSubsystem
    {
        public BackendGISubsystem(ulong addr) : base(addr) { }
        public Object OnInternetStatusChanged { get { return this[nameof(OnInternetStatusChanged)]; } set { this[nameof(OnInternetStatusChanged)] = value; } }
        public Object OnTriggerMaintenance { get { return this[nameof(OnTriggerMaintenance)]; } set { this[nameof(OnTriggerMaintenance)] = value; } }
        public Object OnTriggerClientUpdateRequired { get { return this[nameof(OnTriggerClientUpdateRequired)]; } set { this[nameof(OnTriggerClientUpdateRequired)] = value; } }
        public Object OnUserNotLoggedInPlatform { get { return this[nameof(OnUserNotLoggedInPlatform)]; } set { this[nameof(OnUserNotLoggedInPlatform)] = value; } }
        public Object OnNewsFetched { get { return this[nameof(OnNewsFetched)]; } set { this[nameof(OnNewsFetched)] = value; } }
        public Object OnShopNeedsRefresh { get { return this[nameof(OnShopNeedsRefresh)]; } set { this[nameof(OnShopNeedsRefresh)] = value; } }
        public Object OnShopRefreshed { get { return this[nameof(OnShopRefreshed)]; } set { this[nameof(OnShopRefreshed)] = value; } }
        public Object OnShopRefreshing { get { return this[nameof(OnShopRefreshing)]; } set { this[nameof(OnShopRefreshing)] = value; } }
        public Object OnShiftUIClosed { get { return this[nameof(OnShiftUIClosed)]; } set { this[nameof(OnShiftUIClosed)] = value; } }
        public Object OnServerStatusUpdated { get { return this[nameof(OnServerStatusUpdated)]; } set { this[nameof(OnServerStatusUpdated)] = value; } }
        public DateTime LastServerInfoCheckTime { get { return this[nameof(LastServerInfoCheckTime)].As<DateTime>(); } set { this["LastServerInfoCheckTime"] = value; } }
        public ServerStatus ServerStatus { get { return this[nameof(ServerStatus)].As<ServerStatus>(); } set { this["ServerStatus"] = value; } }
        public TimerHandle ShopRefreshTimerHandler { get { return this[nameof(ShopRefreshTimerHandler)].As<TimerHandle>(); } set { this["ShopRefreshTimerHandler"] = value; } }
        public EventRequest Event { get { return this[nameof(Event)].As<EventRequest>(); } set { this["Event"] = value; } }
        public EventRequest PingEvent { get { return this[nameof(PingEvent)].As<EventRequest>(); } set { this["PingEvent"] = value; } }
        public EventRequest RefreshShopEvent { get { return this[nameof(RefreshShopEvent)].As<EventRequest>(); } set { this["RefreshShopEvent"] = value; } }
        public EventRequest GetContentBundlesEventRequest { get { return this[nameof(GetContentBundlesEventRequest)].As<EventRequest>(); } set { this["GetContentBundlesEventRequest"] = value; } }
        public Object OverrideShiftEnvironment { get { return this[nameof(OverrideShiftEnvironment)]; } set { this[nameof(OverrideShiftEnvironment)] = value; } }
        public Object ProjectVersion { get { return this[nameof(ProjectVersion)]; } set { this[nameof(ProjectVersion)] = value; } }
        public Object EnvironmentId { get { return this[nameof(EnvironmentId)]; } set { this[nameof(EnvironmentId)] = value; } }
        public Object DeviceID { get { return this[nameof(DeviceID)]; } set { this[nameof(DeviceID)] = value; } }
        public ShopDataModel CachedShopDataModel { get { return this[nameof(CachedShopDataModel)].As<ShopDataModel>(); } set { this["CachedShopDataModel"] = value; } }
        public int IssuerId { get { return this[nameof(IssuerId)].GetValue<int>(); } set { this[nameof(IssuerId)].SetValue<int>(value); } }
        public Object ServiceSession { get { return this[nameof(ServiceSession)].As<Object>(); } set { this["ServiceSession"] = value; } }
        public Object PlatformAuthenticationServiceClass { get { return this[nameof(PlatformAuthenticationServiceClass)]; } set { this[nameof(PlatformAuthenticationServiceClass)] = value; } }
        public PlatformAuthenticationService PlatformAuthenticationService { get { return this[nameof(PlatformAuthenticationService)].As<PlatformAuthenticationService>(); } set { this["PlatformAuthenticationService"] = value; } }
        public void ShowWebURLUI(Object URLToShow, bool bEmbedded, bool bShowBackground, bool bShowCloseButton, int OffsetX, int OffsetY, int SizeX, int SizeY) { Invoke(nameof(ShowWebURLUI), URLToShow, bEmbedded, bShowBackground, bShowCloseButton, OffsetX, OffsetY, SizeX, SizeY); }
        public void ShowShiftUI(bool bWithNews) { Invoke(nameof(ShowShiftUI), bWithNews); }
        public void ResumeStartupFlow() { Invoke(nameof(ResumeStartupFlow)); }
        public void RefreshShopTimerElapsed() { Invoke(nameof(RefreshShopTimerElapsed)); }
        public void RefreshShop(int Timestamp) { Invoke(nameof(RefreshShop), Timestamp); }
        public void PurchaseCurrencyPack(int PackId) { Invoke(nameof(PurchaseCurrencyPack), PackId); }
        public bool ParseDiscoveryResponse(DataObject Platform) { return Invoke<bool>(nameof(ParseDiscoveryResponse), Platform); }
        public void OnStartupEventResponseSuccess(ServerResponse Response) { Invoke(nameof(OnStartupEventResponseSuccess), Response); }
        public void OnStartupEventResponseError(ServerResponse Response) { Invoke(nameof(OnStartupEventResponseError), Response); }
        public void OnShiftUIClose() { Invoke(nameof(OnShiftUIClose)); }
        public void OnRefreshShopSuccess(ServerResponse Response) { Invoke(nameof(OnRefreshShopSuccess), Response); }
        public void OnRefreshShopError(ServerResponse Response) { Invoke(nameof(OnRefreshShopError), Response); }
        public void OnPurchaseCurrencyPackSuccess(ServerResponse Response) { Invoke(nameof(OnPurchaseCurrencyPackSuccess), Response); }
        public void OnGetUserContentBundlesSuccess(ServerResponse Response) { Invoke(nameof(OnGetUserContentBundlesSuccess), Response); }
        public void OnGetUserContentBundlesError(ServerResponse Response) { Invoke(nameof(OnGetUserContentBundlesError), Response); }
        public void OnCheckInternetConnectionResponseSuccess(ServerResponse Response) { Invoke(nameof(OnCheckInternetConnectionResponseSuccess), Response); }
        public void OnCheckInternetConnectionResponseFail(ServerResponse Response) { Invoke(nameof(OnCheckInternetConnectionResponseFail), Response); }
        public void OnAuthenticationCompleteResponse(ServerResponse Response) { Invoke(nameof(OnAuthenticationCompleteResponse), Response); }
        public void HideShiftUI() { Invoke(nameof(HideShiftUI)); }
        public bool GetShopNeedsRefresh() { return Invoke<bool>(nameof(GetShopNeedsRefresh)); }
        public ShopDataModel GetShop() { return Invoke<ShopDataModel>(nameof(GetShop)); }
        public Object GetSession(Object Class) { return Invoke<Object>(nameof(GetSession), Class); }
        public ServerStatus GetServerStatus() { return Invoke<ServerStatus>(nameof(GetServerStatus)); }
        public Object GetPlayerShiftId() { return Invoke<Object>(nameof(GetPlayerShiftId)); }
        public Array<TOMArticle> GetNews(Object Tag) { return Invoke<Array<TOMArticle>>(nameof(GetNews), Tag); }
        public bool GetIsNewsFetched() { return Invoke<bool>(nameof(GetIsNewsFetched)); }
        public bool GetIsConnected() { return Invoke<bool>(nameof(GetIsConnected)); }
        public void FetchNews() { Invoke(nameof(FetchNews)); }
        public void ConsumePendingEntitlements() { Invoke(nameof(ConsumePendingEntitlements)); }
        public void CheckUpdatesAndMaintenance() { Invoke(nameof(CheckUpdatesAndMaintenance)); }
        public void CheckInternetConnection() { Invoke(nameof(CheckInternetConnection)); }
    }
    public class BeamAttackComponent : TOMActorComponent
    {
        public BeamAttackComponent(ulong addr) : base(addr) { }
        public bool IsControlledByPlayer { get { return this[nameof(IsControlledByPlayer)].Flag; } set { this[nameof(IsControlledByPlayer)].Flag = value; } }
        public bool IsInBeam { get { return this[nameof(IsInBeam)].Flag; } set { this[nameof(IsInBeam)].Flag = value; } }
        public AnimMontage BeamAttackMontage { get { return this[nameof(BeamAttackMontage)].As<AnimMontage>(); } set { this["BeamAttackMontage"] = value; } }
        public TOMCharacter OwnerCharacter { get { return this[nameof(OwnerCharacter)].As<TOMCharacter>(); } set { this["OwnerCharacter"] = value; } }
        public TimerHandle TickHandle { get { return this[nameof(TickHandle)].As<TimerHandle>(); } set { this["TickHandle"] = value; } }
        public TimerHandle DurationHandle { get { return this[nameof(DurationHandle)].As<TimerHandle>(); } set { this["DurationHandle"] = value; } }
        public DefensiveComponent TargetDefensive { get { return this[nameof(TargetDefensive)].As<DefensiveComponent>(); } set { this["TargetDefensive"] = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public void TickBeam() { Invoke(nameof(TickBeam)); }
        public void StopBeam() { Invoke(nameof(StopBeam)); }
        public void StartBeam(AnimMontage Montage) { Invoke(nameof(StartBeam), Montage); }
    }
    public class BifrostManager : Actor
    {
        public BifrostManager(ulong addr) : base(addr) { }
        public Object OnBifrostConditionFulfilled { get { return this[nameof(OnBifrostConditionFulfilled)]; } set { this[nameof(OnBifrostConditionFulfilled)] = value; } }
        public bool bIsConditionFulfilled { get { return this[nameof(bIsConditionFulfilled)].Flag; } set { this[nameof(bIsConditionFulfilled)].Flag = value; } }
        public void SendPlayerToBifrost() { Invoke(nameof(SendPlayerToBifrost)); }
        public void OnSagaBossKilled() { Invoke(nameof(OnSagaBossKilled)); }
        public void OnRep_IsConditionFulfilled() { Invoke(nameof(OnRep_IsConditionFulfilled)); }
        public void OnGiantKilled() { Invoke(nameof(OnGiantKilled)); }
        public bool IsConditionFulfilled() { return Invoke<bool>(nameof(IsConditionFulfilled)); }
        public void GetBifrostInfo(int OutGiantKilledAmount, int OutSagaBossKilledAmount, int OutHornAmount, bool bIsAboveRewardCount) { Invoke(nameof(GetBifrostInfo), OutGiantKilledAmount, OutSagaBossKilledAmount, OutHornAmount, bIsAboveRewardCount); }
        public void DelayedOnSagaBossKilled() { Invoke(nameof(DelayedOnSagaBossKilled)); }
        public void DelayedOnGiantKilled() { Invoke(nameof(DelayedOnGiantKilled)); }
    }
    public class ReplicatedPropBase : TOMActor
    {
        public ReplicatedPropBase(ulong addr) : base(addr) { }
        public ReplicatedPropBase_RepProperties PropProperties { get { return this[nameof(PropProperties)].As<ReplicatedPropBase_RepProperties>(); } set { this["PropProperties"] = value; } }
        public void SetProperties(int InBiomeId, Vector InLocation, Quat InRotation) { Invoke(nameof(SetProperties), InBiomeId, InLocation, InRotation); }
        public void OnRep_Properties() { Invoke(nameof(OnRep_Properties)); }
    }
    public class BifrostReplicatedProp : ReplicatedPropBase
    {
        public BifrostReplicatedProp(ulong addr) : base(addr) { }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public void OnRep_IsActive() { Invoke(nameof(OnRep_IsActive)); }
        public void OnBifrostConditionFulfilled() { Invoke(nameof(OnBifrostConditionFulfilled)); }
        public void OnActivate() { Invoke(nameof(OnActivate)); }
    }
    public class BiomeConfig : Object
    {
        public BiomeConfig(ulong addr) : base(addr) { }
        public BiomeDataModel Model { get { return this[nameof(Model)].As<BiomeDataModel>(); } set { this["Model"] = value; } }
        public BiomeConfigRow Config { get { return this[nameof(Config)].As<BiomeConfigRow>(); } set { this["Config"] = value; } }
        public Array<FoliageConfigRow> BaseFoliage { get { return new Array<FoliageConfigRow>(this[nameof(BaseFoliage)].Address); } }
        public Array<FoliageConfigRow> SpecificFoliage { get { return new Array<FoliageConfigRow>(this[nameof(SpecificFoliage)].Address); } }
        public Array<FoliageConfigRow> RiverFoliage { get { return new Array<FoliageConfigRow>(this[nameof(RiverFoliage)].Address); } }
        public Array<FoliageConfigRow> CliffFoliage { get { return new Array<FoliageConfigRow>(this[nameof(CliffFoliage)].Address); } }
        public Array<FoliageConfigRow> RoadFoliage { get { return new Array<FoliageConfigRow>(this[nameof(RoadFoliage)].Address); } }
        public Array<FoliageConfigRow> WaterFoliage { get { return new Array<FoliageConfigRow>(this[nameof(WaterFoliage)].Address); } }
        public Array<FoliageConfigRow> WaterNearShoreFoliage { get { return new Array<FoliageConfigRow>(this[nameof(WaterNearShoreFoliage)].Address); } }
        public Array<LandmarkConfigRow> RegularLandmarks { get { return new Array<LandmarkConfigRow>(this[nameof(RegularLandmarks)].Address); } }
        public Array<LandmarkConfigRow> OnRoadLandmarks { get { return new Array<LandmarkConfigRow>(this[nameof(OnRoadLandmarks)].Address); } }
        public Array<LandmarkConfigRow> OnRampLandmarks { get { return new Array<LandmarkConfigRow>(this[nameof(OnRampLandmarks)].Address); } }
        public LandmarkConfigRow DefaultLandmark { get { return this[nameof(DefaultLandmark)].As<LandmarkConfigRow>(); } set { this["DefaultLandmark"] = value; } }
        public Object GroundDetails { get { return this[nameof(GroundDetails)]; } set { this[nameof(GroundDetails)] = value; } }
        public Object RoadGroundDetails { get { return this[nameof(RoadGroundDetails)]; } set { this[nameof(RoadGroundDetails)] = value; } }
        public GroundDetailConfigRow DefaultGroundDetail { get { return this[nameof(DefaultGroundDetail)].As<GroundDetailConfigRow>(); } set { this["DefaultGroundDetail"] = value; } }
        public Array<GeoPropConfigRow> InnerCaps { get { return new Array<GeoPropConfigRow>(this[nameof(InnerCaps)].Address); } }
        public Array<GeoPropConfigRow> OuterCaps { get { return new Array<GeoPropConfigRow>(this[nameof(OuterCaps)].Address); } }
        public Array<GeoPropConfigRow> StraightCaps { get { return new Array<GeoPropConfigRow>(this[nameof(StraightCaps)].Address); } }
        public Array<GeoPropConfigRow> InnerBottoms { get { return new Array<GeoPropConfigRow>(this[nameof(InnerBottoms)].Address); } }
        public Array<GeoPropConfigRow> OuterBottoms { get { return new Array<GeoPropConfigRow>(this[nameof(OuterBottoms)].Address); } }
        public Array<GeoPropConfigRow> StraightBottoms { get { return new Array<GeoPropConfigRow>(this[nameof(StraightBottoms)].Address); } }
        public Array<GeoPropConfigRow> InnerShores { get { return new Array<GeoPropConfigRow>(this[nameof(InnerShores)].Address); } }
        public Array<GeoPropConfigRow> OuterShores { get { return new Array<GeoPropConfigRow>(this[nameof(OuterShores)].Address); } }
        public Array<GeoPropConfigRow> StraightShores { get { return new Array<GeoPropConfigRow>(this[nameof(StraightShores)].Address); } }
        public GeoPropConfigRow WaterfallLeftShore { get { return this[nameof(WaterfallLeftShore)].As<GeoPropConfigRow>(); } set { this["WaterfallLeftShore"] = value; } }
        public GeoPropConfigRow WaterfallRightShore { get { return this[nameof(WaterfallRightShore)].As<GeoPropConfigRow>(); } set { this["WaterfallRightShore"] = value; } }
        public Array<ushort> PartHeights { get { return new Array<ushort>(this[nameof(PartHeights)].Address); } }
        public Array<int> PassageCaveIds { get { return new Array<int>(this[nameof(PassageCaveIds)].Address); } }
        public Array<int> DungeonCaveIds { get { return new Array<int>(this[nameof(DungeonCaveIds)].Address); } }
        public Array<int> MythBossCaveIds { get { return new Array<int>(this[nameof(MythBossCaveIds)].Address); } }
        public MaterialInstance GetTitleMaterial() { return Invoke<MaterialInstance>(nameof(GetTitleMaterial)); }
        public Texture2D GetTerrainTexture() { return Invoke<Texture2D>(nameof(GetTerrainTexture)); }
        public MaterialInstance GetTerrainMaterial() { return Invoke<MaterialInstance>(nameof(GetTerrainMaterial)); }
    }
    public class ProjectileBase : TOMActor
    {
        public ProjectileBase(ulong addr) : base(addr) { }
        public NiagaraSystem SpeedBoostNS { get { return this[nameof(SpeedBoostNS)].As<NiagaraSystem>(); } set { this["SpeedBoostNS"] = value; } }
        public Object SpeedBoostSFX { get { return this[nameof(SpeedBoostSFX)]; } set { this[nameof(SpeedBoostSFX)] = value; } }
        public bool bCanPierceCreature { get { return this[nameof(bCanPierceCreature)].Flag; } set { this[nameof(bCanPierceCreature)].Flag = value; } }
        public bool bLookAtDirection { get { return this[nameof(bLookAtDirection)].Flag; } set { this[nameof(bLookAtDirection)].Flag = value; } }
        public bool bStickToTarget { get { return this[nameof(bStickToTarget)].Flag; } set { this[nameof(bStickToTarget)].Flag = value; } }
        public bool bIsHoming { get { return this[nameof(bIsHoming)].Flag; } set { this[nameof(bIsHoming)].Flag = value; } }
        public CurveFloat ProjectileCurve { get { return this[nameof(ProjectileCurve)].As<CurveFloat>(); } set { this["ProjectileCurve"] = value; } }
        public float TimeBetweenExplosionAndDestroy { get { return this[nameof(TimeBetweenExplosionAndDestroy)].GetValue<float>(); } set { this[nameof(TimeBetweenExplosionAndDestroy)].SetValue<float>(value); } }
        public bool bIsAttachedToSocket { get { return this[nameof(bIsAttachedToSocket)].Flag; } set { this[nameof(bIsAttachedToSocket)].Flag = value; } }
        public bool bLinkAudioToProjectile { get { return this[nameof(bLinkAudioToProjectile)].Flag; } set { this[nameof(bLinkAudioToProjectile)].Flag = value; } }
        public bool DestroyAudioWithProjectile { get { return this[nameof(DestroyAudioWithProjectile)].Flag; } set { this[nameof(DestroyAudioWithProjectile)].Flag = value; } }
        public float TargetingOffset { get { return this[nameof(TargetingOffset)].GetValue<float>(); } set { this[nameof(TargetingOffset)].SetValue<float>(value); } }
        public Object ImpactAudioSuffix { get { return this[nameof(ImpactAudioSuffix)]; } set { this[nameof(ImpactAudioSuffix)] = value; } }
        public Object InProgressAudioSuffix { get { return this[nameof(InProgressAudioSuffix)]; } set { this[nameof(InProgressAudioSuffix)] = value; } }
        public ParticleSystem OnDestroyVFX { get { return this[nameof(OnDestroyVFX)].As<ParticleSystem>(); } set { this["OnDestroyVFX"] = value; } }
        public float DelayBeforeDirectionCalculation { get { return this[nameof(DelayBeforeDirectionCalculation)].GetValue<float>(); } set { this[nameof(DelayBeforeDirectionCalculation)].SetValue<float>(value); } }
        public ProjectileDataModel DataModel { get { return this[nameof(DataModel)].As<ProjectileDataModel>(); } set { this["DataModel"] = value; } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public TOMCharacter CharacterSource { get { return this[nameof(CharacterSource)].As<TOMCharacter>(); } set { this["CharacterSource"] = value; } }
        public Actor TargetActor { get { return this[nameof(TargetActor)].As<Actor>(); } set { this["TargetActor"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector PreviousLocation { get { return this[nameof(PreviousLocation)].As<Vector>(); } set { this["PreviousLocation"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Speed { get { return this[nameof(Speed)].GetValue<float>(); } set { this[nameof(Speed)].SetValue<float>(value); } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public float FlightTime { get { return this[nameof(FlightTime)].GetValue<float>(); } set { this[nameof(FlightTime)].SetValue<float>(value); } }
        public float MaxLifeTimer { get { return this[nameof(MaxLifeTimer)].GetValue<float>(); } set { this[nameof(MaxLifeTimer)].SetValue<float>(value); } }
        public Array<ActorComponent> Spheres { get { return new Array<ActorComponent>(this[nameof(Spheres)].Address); } }
        public TOMOffensiveComponent TOMOffensive { get { return this[nameof(TOMOffensive)].As<TOMOffensiveComponent>(); } set { this["TOMOffensive"] = value; } }
        public Array<ReceiverComponent> IgnoredReceivers { get { return new Array<ReceiverComponent>(this[nameof(IgnoredReceivers)].Address); } }
        public AttackStatsDataModel AttackDataModel { get { return this[nameof(AttackDataModel)].As<AttackStatsDataModel>(); } set { this["AttackDataModel"] = value; } }
        public NiagaraComponent SpeedBoostPSComponent { get { return this[nameof(SpeedBoostPSComponent)].As<NiagaraComponent>(); } set { this["SpeedBoostPSComponent"] = value; } }
        public void UpdateLocation(float DeltaTime) { Invoke(nameof(UpdateLocation), DeltaTime); }
        public void StartMoving() { Invoke(nameof(StartMoving)); }
        public void PrepareForHolding() { Invoke(nameof(PrepareForHolding)); }
        public void PlayInAnim() { Invoke(nameof(PlayInAnim)); }
        public void OnHomingTargetDeath(TOMCharacter Character) { Invoke(nameof(OnHomingTargetDeath), Character); }
        public void OnExplodeClient(Actor Receiver) { Invoke(nameof(OnExplodeClient), Receiver); }
        public void OnComponentBeginOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnComponentBeginOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
        public void OnCollisionClientSide() { Invoke(nameof(OnCollisionClientSide)); }
        public void MaxLifeReached() { Invoke(nameof(MaxLifeReached)); }
        public void FizzleServer() { Invoke(nameof(FizzleServer)); }
        public void FizzleMulticast() { Invoke(nameof(FizzleMulticast)); }
        public void FireProjectileAtTargetWithData(Vector InTarget, int ProjectileId) { Invoke(nameof(FireProjectileAtTargetWithData), InTarget, ProjectileId); }
        public void FireProjectileAtTargetMulticast(Vector InVelocity, Vector Position, int InDataModelId, float InFlightTime, float InSpeed, Object InAudioName, TOMCharacter InCharacterSource) { Invoke(nameof(FireProjectileAtTargetMulticast), InVelocity, Position, InDataModelId, InFlightTime, InSpeed, InAudioName, InCharacterSource); }
        public void FireProjectileAtTarget(Vector InTarget) { Invoke(nameof(FireProjectileAtTarget), InTarget); }
        public void ExplodeServer(ReceiverComponent Receiver) { Invoke(nameof(ExplodeServer), Receiver); }
        public void ExplodeClient(Actor Receiver) { Invoke(nameof(ExplodeClient), Receiver); }
        public void DestroyAfterTimer() { Invoke(nameof(DestroyAfterTimer)); }
        public void DeactivateProjectile(Actor Receiver) { Invoke(nameof(DeactivateProjectile), Receiver); }
    }
    public class BouncingProjectileBase : ProjectileBase
    {
        public BouncingProjectileBase(ulong addr) : base(addr) { }
        public Array<Actor> PreviousTargets { get { return new Array<Actor>(this[nameof(PreviousTargets)].Address); } }
    }
    public class DestructibleHazardBase : HazardBase
    {
        public DestructibleHazardBase(ulong addr) : base(addr) { }
        public float Damping { get { return this[nameof(Damping)].GetValue<float>(); } set { this[nameof(Damping)].SetValue<float>(value); } }
        public float MinForce { get { return this[nameof(MinForce)].GetValue<float>(); } set { this[nameof(MinForce)].SetValue<float>(value); } }
        public ParticleSystem OnDestructionPS { get { return this[nameof(OnDestructionPS)].As<ParticleSystem>(); } set { this["OnDestructionPS"] = value; } }
        public Object OnDestructionSFX { get { return this[nameof(OnDestructionSFX)]; } set { this[nameof(OnDestructionSFX)] = value; } }
        public float DelayBeforeDissolve { get { return this[nameof(DelayBeforeDissolve)].GetValue<float>(); } set { this[nameof(DelayBeforeDissolve)].SetValue<float>(value); } }
        public bool bUseDestructionImpulseFromCenter { get { return this[nameof(bUseDestructionImpulseFromCenter)].Flag; } set { this[nameof(bUseDestructionImpulseFromCenter)].Flag = value; } }
        public bool bSendAlertOnDestruction { get { return this[nameof(bSendAlertOnDestruction)].Flag; } set { this[nameof(bSendAlertOnDestruction)].Flag = value; } }
        public Object DestructionLocalizedMessage { get { return this[nameof(DestructionLocalizedMessage)]; } set { this[nameof(DestructionLocalizedMessage)] = value; } }
        public Array<MaterialInstanceDynamic> MaterialDestructionEffectMeshes { get { return new Array<MaterialInstanceDynamic>(this[nameof(MaterialDestructionEffectMeshes)].Address); } }
        public Object MaterialDestructionParameterName { get { return this[nameof(MaterialDestructionParameterName)]; } set { this[nameof(MaterialDestructionParameterName)] = value; } }
        public float MaterialDestructionTimer { get { return this[nameof(MaterialDestructionTimer)].GetValue<float>(); } set { this[nameof(MaterialDestructionTimer)].SetValue<float>(value); } }
        public float MaterialDestructionDuration { get { return this[nameof(MaterialDestructionDuration)].GetValue<float>(); } set { this[nameof(MaterialDestructionDuration)].SetValue<float>(value); } }
        public void Tick(float DeltaSeconds) { Invoke(nameof(Tick), DeltaSeconds); }
        public void OnHazardDestructionMulticast(Vector ImpulseDirection, float Force) { Invoke(nameof(OnHazardDestructionMulticast), ImpulseDirection, Force); }
        public void LifetimeTick() { Invoke(nameof(LifetimeTick)); }
        public void DelayedDestructibleHide() { Invoke(nameof(DelayedDestructibleHide)); }
        public void DelayedDestructibleDissolve() { Invoke(nameof(DelayedDestructibleDissolve)); }
        public void ActivatePhysicForStaticMesh(StaticMeshComponent StaticMeshComponent, Vector ImpulseDirection, float Force) { Invoke(nameof(ActivatePhysicForStaticMesh), StaticMeshComponent, ImpulseDirection, Force); }
        public void ActivatePhysicForSkeletalMesh(SkeletalMeshComponent SkeletalMeshComponent, Vector ImpulseDirection, float Force) { Invoke(nameof(ActivatePhysicForSkeletalMesh), SkeletalMeshComponent, ImpulseDirection, Force); }
        public void ActivatePhysicForActor(Actor Actor, Vector ImpulseDirection, float Force) { Invoke(nameof(ActivatePhysicForActor), Actor, ImpulseDirection, Force); }
    }
    public class BuildableHazardBase : DestructibleHazardBase
    {
        public BuildableHazardBase(ulong addr) : base(addr) { }
        public bool bIsBuilt { get { return this[nameof(bIsBuilt)].Flag; } set { this[nameof(bIsBuilt)].Flag = value; } }
        public void RefreshIsBuilt(bool IsBuilt) { Invoke(nameof(RefreshIsBuilt), IsBuilt); }
        public void OnRep_IsBuilt() { Invoke(nameof(OnRep_IsBuilt)); }
        public void OnContainerChanged(ContainerDifference ContainerDifference) { Invoke(nameof(OnContainerChanged), ContainerDifference); }
        public void OnBuildMulticast() { Invoke(nameof(OnBuildMulticast)); }
        public void OnBuildEffect() { Invoke(nameof(OnBuildEffect)); }
    }
    public class BridgePartHazardBase : BuildableHazardBase
    {
        public BridgePartHazardBase(ulong addr) : base(addr) { }
    }
    public class BTDecorator_CanEvade : BTDecorator
    {
        public BTDecorator_CanEvade(ulong addr) : base(addr) { }
    }
    public class BTDecorator_CanMove : BTDecorator
    {
        public BTDecorator_CanMove(ulong addr) : base(addr) { }
    }
    public class BTDecorator_CanShield : BTDecorator
    {
        public BTDecorator_CanShield(ulong addr) : base(addr) { }
    }
    public class BTDecorator_CheckAnimalState : BTDecorator
    {
        public BTDecorator_CheckAnimalState(ulong addr) : base(addr) { }
        public EAnimalState StateToCheck { get { return (EAnimalState)this[nameof(StateToCheck)].GetValue<int>(); } set { this[nameof(StateToCheck)].SetValue<int>((int)value); } }
    }
    public class BTDecorator_HasShield : BTDecorator
    {
        public BTDecorator_HasShield(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsAggroed : BTDecorator
    {
        public BTDecorator_IsAggroed(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsAgressive : BTDecorator
    {
        public BTDecorator_IsAgressive(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsControlledByMeta : BTDecorator
    {
        public BTDecorator_IsControlledByMeta(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsInBestAttackRange : BTDecorator
    {
        public BTDecorator_IsInBestAttackRange(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector Distance { get { return this[nameof(Distance)].As<BlackboardKeySelector>(); } set { this["Distance"] = value; } }
        public BlackboardKeySelector DoKite { get { return this[nameof(DoKite)].As<BlackboardKeySelector>(); } set { this["DoKite"] = value; } }
        public float RadiusOffset { get { return this[nameof(RadiusOffset)].GetValue<float>(); } set { this[nameof(RadiusOffset)].SetValue<float>(value); } }
    }
    public class BTDecorator_IsInFarAttackRadius : BTDecorator
    {
        public BTDecorator_IsInFarAttackRadius(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector Distance { get { return this[nameof(Distance)].As<BlackboardKeySelector>(); } set { this["Distance"] = value; } }
        public float RadiusOffset { get { return this[nameof(RadiusOffset)].GetValue<float>(); } set { this[nameof(RadiusOffset)].SetValue<float>(value); } }
    }
    public class BTDecorator_IsInNearAttackRadius : BTDecorator
    {
        public BTDecorator_IsInNearAttackRadius(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector Distance { get { return this[nameof(Distance)].As<BlackboardKeySelector>(); } set { this["Distance"] = value; } }
        public float RadiusOffset { get { return this[nameof(RadiusOffset)].GetValue<float>(); } set { this[nameof(RadiusOffset)].SetValue<float>(value); } }
    }
    public class BTDecorator_IsNearTarget : BTDecorator
    {
        public BTDecorator_IsNearTarget(ulong addr) : base(addr) { }
        public BlackboardKeySelector Distance { get { return this[nameof(Distance)].As<BlackboardKeySelector>(); } set { this["Distance"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public BlackboardKeySelector RadiusKey { get { return this[nameof(RadiusKey)].As<BlackboardKeySelector>(); } set { this["RadiusKey"] = value; } }
    }
    public class BTDecorator_IsTargetNearLocation : BTDecorator
    {
        public BTDecorator_IsTargetNearLocation(ulong addr) : base(addr) { }
        public bool bUseSelfAsOrigin { get { return this[nameof(bUseSelfAsOrigin)].Flag; } set { this[nameof(bUseSelfAsOrigin)].Flag = value; } }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector Location { get { return this[nameof(Location)].As<BlackboardKeySelector>(); } set { this["Location"] = value; } }
        public BlackboardKeySelector Radius { get { return this[nameof(Radius)].As<BlackboardKeySelector>(); } set { this["Radius"] = value; } }
    }
    public class BTDecorator_ShouldWalkNearTarget : BTDecorator
    {
        public BTDecorator_ShouldWalkNearTarget(ulong addr) : base(addr) { }
    }
    public class BTDecoratorCanMoveTowardPosition : BTDecorator
    {
        public BTDecoratorCanMoveTowardPosition(ulong addr) : base(addr) { }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public float TraceHeight { get { return this[nameof(TraceHeight)].GetValue<float>(); } set { this[nameof(TraceHeight)].SetValue<float>(value); } }
        public EMoveDirection Direction { get { return (EMoveDirection)this[nameof(Direction)].GetValue<int>(); } set { this[nameof(Direction)].SetValue<int>((int)value); } }
    }
    public class BTService_CheckTarget : BTService
    {
        public BTService_CheckTarget(ulong addr) : base(addr) { }
    }
    public class BTService_EvaluateAttack : BTService
    {
        public BTService_EvaluateAttack(ulong addr) : base(addr) { }
    }
    public class BTTask_ChangeWalkState : BTTaskNode
    {
        public BTTask_ChangeWalkState(ulong addr) : base(addr) { }
        public bool bStopWalking { get { return this[nameof(bStopWalking)].Flag; } set { this[nameof(bStopWalking)].Flag = value; } }
    }
    public class BTTaskNode_ClearKey : BTTaskNode
    {
        public BTTaskNode_ClearKey(ulong addr) : base(addr) { }
        public BlackboardKeySelector Key { get { return this[nameof(Key)].As<BlackboardKeySelector>(); } set { this["Key"] = value; } }
    }
    public class BTTaskNode_Evade : BTTaskNode
    {
        public BTTaskNode_Evade(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
    }
    public class BTTaskNode_FindFleeLocation : BTTaskNode
    {
        public BTTaskNode_FindFleeLocation(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector Result { get { return this[nameof(Result)].As<BlackboardKeySelector>(); } set { this["Result"] = value; } }
        public int MinDistanceFromTarget { get { return this[nameof(MinDistanceFromTarget)].GetValue<int>(); } set { this[nameof(MinDistanceFromTarget)].SetValue<int>(value); } }
        public int RejectAngleWithTarget { get { return this[nameof(RejectAngleWithTarget)].GetValue<int>(); } set { this[nameof(RejectAngleWithTarget)].SetValue<int>(value); } }
        public int MaxDistanceFromLocation { get { return this[nameof(MaxDistanceFromLocation)].GetValue<int>(); } set { this[nameof(MaxDistanceFromLocation)].SetValue<int>(value); } }
    }
    public class BTTaskNode_FindNextPatrolPoint : BTTaskNode
    {
        public BTTaskNode_FindNextPatrolPoint(ulong addr) : base(addr) { }
        public BlackboardKeySelector SpawnPosition { get { return this[nameof(SpawnPosition)].As<BlackboardKeySelector>(); } set { this["SpawnPosition"] = value; } }
        public BlackboardKeySelector NextPatrolPoint { get { return this[nameof(NextPatrolPoint)].As<BlackboardKeySelector>(); } set { this["NextPatrolPoint"] = value; } }
    }
    public class BTTaskNode_RotateTowardTarget : BTTaskNode
    {
        public BTTaskNode_RotateTowardTarget(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
    }
    public class BTTaskNode_StackAttack : BTTaskNode
    {
        public BTTaskNode_StackAttack(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
        public BlackboardKeySelector AttackIdKey { get { return this[nameof(AttackIdKey)].As<BlackboardKeySelector>(); } set { this["AttackIdKey"] = value; } }
    }
    public class BTTaskNode_StackTaunt : BTTaskNode
    {
        public BTTaskNode_StackTaunt(ulong addr) : base(addr) { }
    }
    public class BTTaskNode_StartFleeing : BTTaskNode
    {
        public BTTaskNode_StartFleeing(ulong addr) : base(addr) { }
    }
    public class BTTaskNode_StartShielding : BTTaskNode
    {
        public BTTaskNode_StartShielding(ulong addr) : base(addr) { }
        public BlackboardKeySelector Target { get { return this[nameof(Target)].As<BlackboardKeySelector>(); } set { this["Target"] = value; } }
    }
    public class BTTaskNode_StopFleeing : BTTaskNode
    {
        public BTTaskNode_StopFleeing(ulong addr) : base(addr) { }
    }
    public class BTTaskNode_StopShielding : BTTaskNode
    {
        public BTTaskNode_StopShielding(ulong addr) : base(addr) { }
    }
    public class QuestBehaviorBase : Object
    {
        public QuestBehaviorBase(ulong addr) : base(addr) { }
        public QuestEntityModel QuestEntity { get { return this[nameof(QuestEntity)].As<QuestEntityModel>(); } set { this["QuestEntity"] = value; } }
    }
    public class BuildHazardQuestBehavior : QuestBehaviorBase
    {
        public BuildHazardQuestBehavior(ulong addr) : base(addr) { }
        public void OnHazardBuilt(HazardDataModel HazardDataModel) { Invoke(nameof(OnHazardBuilt), HazardDataModel); }
    }
    public class BuildHazardsQuestBehavior : QuestBehaviorBase
    {
        public BuildHazardsQuestBehavior(ulong addr) : base(addr) { }
        public void OnHazardBuilt(HazardDataModel HazardDataModel) { Invoke(nameof(OnHazardBuilt), HazardDataModel); }
    }
    public class BushMovementManager : Actor
    {
        public BushMovementManager(ulong addr) : base(addr) { }
        public float OrthoSize { get { return this[nameof(OrthoSize)].GetValue<float>(); } set { this[nameof(OrthoSize)].SetValue<float>(value); } }
        public SceneCaptureComponent2D SceneCapture { get { return this[nameof(SceneCapture)].As<SceneCaptureComponent2D>(); } set { this["SceneCapture"] = value; } }
    }
    public class CaveActorInterface : Interface
    {
        public CaveActorInterface(ulong addr) : base(addr) { }
        public void InitCaveActor(CaveBase CaveBase) { Invoke(nameof(InitCaveActor), CaveBase); }
    }
    public class CaveBase : TOMActor
    {
        public CaveBase(ulong addr) : base(addr) { }
        public Object FootstepSurface { get { return this[nameof(FootstepSurface)]; } set { this[nameof(FootstepSurface)] = value; } }
        public Array<CaveExit> Exits { get { return new Array<CaveExit>(this[nameof(Exits)].Address); } }
        public Object CaveSFXEnv { get { return this[nameof(CaveSFXEnv)]; } set { this[nameof(CaveSFXEnv)] = value; } }
        public MaterialInterface CavePostProcessMaterial { get { return this[nameof(CavePostProcessMaterial)].As<MaterialInterface>(); } set { this["CavePostProcessMaterial"] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public CaveEntityModel CaveEntityModel { get { return this[nameof(CaveEntityModel)].As<CaveEntityModel>(); } set { this["CaveEntityModel"] = value; } }
        public int CaveDataId { get { return this[nameof(CaveDataId)].GetValue<int>(); } set { this[nameof(CaveDataId)].SetValue<int>(value); } }
        public Array<Actor> ClientActors { get { return new Array<Actor>(this[nameof(ClientActors)].Address); } }
        public void OnRep_CaveDataId() { Invoke(nameof(OnRep_CaveDataId)); }
        public void Init(CaveEntityModel InCaveEntityModel) { Invoke(nameof(Init), InCaveEntityModel); }
    }
    public class CaveBossDungeonFloor : CaveBase
    {
        public CaveBossDungeonFloor(ulong addr) : base(addr) { }
        public ParticleSystem OnAppearPS { get { return this[nameof(OnAppearPS)].As<ParticleSystem>(); } set { this["OnAppearPS"] = value; } }
        public Object OnClearSFX { get { return this[nameof(OnClearSFX)]; } set { this[nameof(OnClearSFX)] = value; } }
        public Object OnRefreshFloorClear { get { return this[nameof(OnRefreshFloorClear)]; } set { this[nameof(OnRefreshFloorClear)] = value; } }
        public Array<WorldCreatureEntityModel> RemainingCreatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(RemainingCreatures)].Address); } }
        public bool bIsCleared { get { return this[nameof(bIsCleared)].Flag; } set { this[nameof(bIsCleared)].Flag = value; } }
        public void RefreshDungeonFloorClear() { Invoke(nameof(RefreshDungeonFloorClear)); }
        public void OnCreatureDied(WorldCreatureEntityModel CreatureEntity) { Invoke(nameof(OnCreatureDied), CreatureEntity); }
    }
    public class EntityModelBase : BifrostObject
    {
        public EntityModelBase(ulong addr) : base(addr) { }
        public Object OnEntityChanged { get { return this[nameof(OnEntityChanged)]; } set { this[nameof(OnEntityChanged)] = value; } }
        public EntitiesManager EntitiesManager { get { return this[nameof(EntitiesManager)].As<EntitiesManager>(); } set { this["EntitiesManager"] = value; } }
        public void UnbindActionListener(Object Callback) { Invoke(nameof(UnbindActionListener), Callback); }
        public void BroadcastAction(EEntityActionType ActionType, Object InEntityId, Object Context) { Invoke(nameof(BroadcastAction), ActionType, InEntityId, Context); }
        public void BindActionListener(Object Callback) { Invoke(nameof(BindActionListener), Callback); }
    }
    public class CaveEntityModel : EntityModelBase
    {
        public CaveEntityModel(ulong addr) : base(addr) { }
        public Vector SpawnPosition { get { return this[nameof(SpawnPosition)].As<Vector>(); } set { this["SpawnPosition"] = value; } }
        public Object OnCaveLeverTriggered { get { return this[nameof(OnCaveLeverTriggered)]; } set { this[nameof(OnCaveLeverTriggered)] = value; } }
        public Object OnLastPlayerExit { get { return this[nameof(OnLastPlayerExit)]; } set { this[nameof(OnLastPlayerExit)] = value; } }
        public Object OnAllCreatureSpawned { get { return this[nameof(OnAllCreatureSpawned)]; } set { this[nameof(OnAllCreatureSpawned)] = value; } }
        public CaveBase CaveBaseActor { get { return this[nameof(CaveBaseActor)].As<CaveBase>(); } set { this["CaveBaseActor"] = value; } }
        public CaveVO VO { get { return this[nameof(VO)].As<CaveVO>(); } set { this["VO"] = value; } }
        public Array<TOMCharacter> PlayerCharacters { get { return new Array<TOMCharacter>(this[nameof(PlayerCharacters)].Address); } }
        public Array<TOMCharacter> PendingPlayerCharacters { get { return new Array<TOMCharacter>(this[nameof(PendingPlayerCharacters)].Address); } }
        public ModuleSave ModuleSave { get { return this[nameof(ModuleSave)].As<ModuleSave>(); } set { this["ModuleSave"] = value; } }
        public Array<Actor> ServerActors { get { return new Array<Actor>(this[nameof(ServerActors)].Address); } }
        public Array<HazardBase> DynamicHazards { get { return new Array<HazardBase>(this[nameof(DynamicHazards)].Address); } }
        public Array<WorldCreatureEntityModel> Creatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(Creatures)].Address); } }
        public Object CreatureRespawnCallbacks { get { return this[nameof(CreatureRespawnCallbacks)]; } set { this[nameof(CreatureRespawnCallbacks)] = value; } }
        public Object HazardRespawnCallbacks { get { return this[nameof(HazardRespawnCallbacks)]; } set { this[nameof(HazardRespawnCallbacks)] = value; } }
        public GenerationRNG RNG { get { return this[nameof(RNG)].As<GenerationRNG>(); } set { this["RNG"] = value; } }
        public Array<CaveEntrance> CaveEntrances { get { return new Array<CaveEntrance>(this[nameof(CaveEntrances)].Address); } }
        public Array<CaveEntityModel> CaveFloors { get { return new Array<CaveEntityModel>(this[nameof(CaveFloors)].Address); } }
        public CaveEntityModel ParentCave { get { return this[nameof(ParentCave)].As<CaveEntityModel>(); } set { this["ParentCave"] = value; } }
        public CaveVO ToVO() { return Invoke<CaveVO>(nameof(ToVO)); }
        public void OnLeverTriggeredCallback(bool bIsTriggered, Object LeverReceiverId) { Invoke(nameof(OnLeverTriggeredCallback), bIsTriggered, LeverReceiverId); }
        public void OnDynamicHazardDestruction(HazardBase Hazard) { Invoke(nameof(OnDynamicHazardDestruction), Hazard); }
        public void OnCreatureRespawn(bool bRespawned, Object EntityId) { Invoke(nameof(OnCreatureRespawn), bRespawned, EntityId); }
        public void OnCharacterTeleportOut(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterTeleportOut), TOMCharacter); }
        public void GoToPreviousFloor(TOMCharacter TOMCharacter) { Invoke(nameof(GoToPreviousFloor), TOMCharacter); }
        public void GoToNextFloor(TOMCharacter TOMCharacter) { Invoke(nameof(GoToNextFloor), TOMCharacter); }
        public Array<Actor> GetServerActors() { return Invoke<Array<Actor>>(nameof(GetServerActors)); }
        public DataObject GetSave() { return Invoke<DataObject>(nameof(GetSave)); }
        public Array<TOMCharacter> GetPlayerCharacters() { return Invoke<Array<TOMCharacter>>(nameof(GetPlayerCharacters)); }
        public CaveEntityModel GetParent() { return Invoke<CaveEntityModel>(nameof(GetParent)); }
        public CaveEntityModel GetOrCreateCaveEntity(Object Outer, Object EntityId, int CaveDataId, Array<CaveEntrance> Entrances, bool bIsFloor) { return Invoke<CaveEntityModel>(nameof(GetOrCreateCaveEntity), Outer, EntityId, CaveDataId, Entrances, bIsFloor); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public Array<CaveEntrance> GetEntranceWorldPositions() { return Invoke<Array<CaveEntrance>>(nameof(GetEntranceWorldPositions)); }
        public CaveDataModel GetData() { return Invoke<CaveDataModel>(nameof(GetData)); }
        public Array<WorldCreatureEntityModel> GetCreatures() { return Invoke<Array<WorldCreatureEntityModel>>(nameof(GetCreatures)); }
        public void ExitCave(TOMCharacter TOMCharacter, CaveExit Exit) { Invoke(nameof(ExitCave), TOMCharacter, Exit); }
        public void DelayedExitCave(TOMCharacter TOMCharacter, Vector Location) { Invoke(nameof(DelayedExitCave), TOMCharacter, Location); }
        public CaveEntityModel CreateFromVO(Object Outer, CaveVO InVO) { return Invoke<CaveEntityModel>(nameof(CreateFromVO), Outer, InVO); }
        public bool AreAllLeverTriggered(Object LeverReceiverId) { return Invoke<bool>(nameof(AreAllLeverTriggered), LeverReceiverId); }
    }
    public class CaveExit : Actor
    {
        public CaveExit(ulong addr) : base(addr) { }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public SceneComponent TPPoint { get { return this[nameof(TPPoint)].As<SceneComponent>(); } set { this["TPPoint"] = value; } }
        public ECaveExitType CaveExitType { get { return (ECaveExitType)this[nameof(CaveExitType)].GetValue<int>(); } set { this[nameof(CaveExitType)].SetValue<int>((int)value); } }
        public CaveEntrance CaveEntranceVO { get { return this[nameof(CaveEntranceVO)].As<CaveEntrance>(); } set { this["CaveEntranceVO"] = value; } }
        public bool IsActive { get { return this[nameof(IsActive)].Flag; } set { this[nameof(IsActive)].Flag = value; } }
        public CaveBase Cave { get { return this[nameof(Cave)].As<CaveBase>(); } set { this["Cave"] = value; } }
        public void RefreshIsActive(bool InIsActive) { Invoke(nameof(RefreshIsActive), InIsActive); }
        public void OnInteraction(TOMCharacter TOMCharacter) { Invoke(nameof(OnInteraction), TOMCharacter); }
    }
    public class CaveFenrir : CaveBase
    {
        public CaveFenrir(ulong addr) : base(addr) { }
        public AnimMontage StartJumpAnim { get { return this[nameof(StartJumpAnim)].As<AnimMontage>(); } set { this["StartJumpAnim"] = value; } }
        public float DelayAfterAnim { get { return this[nameof(DelayAfterAnim)].GetValue<float>(); } set { this[nameof(DelayAfterAnim)].SetValue<float>(value); } }
        public Vector FenrirFightStartedPosition { get { return this[nameof(FenrirFightStartedPosition)].As<Vector>(); } set { this["FenrirFightStartedPosition"] = value; } }
        public Object HideOnFightStartTag { get { return this[nameof(HideOnFightStartTag)]; } set { this[nameof(HideOnFightStartTag)] = value; } }
        public Object ShowOnFightWinTag { get { return this[nameof(ShowOnFightWinTag)]; } set { this[nameof(ShowOnFightWinTag)] = value; } }
        public Object AudioOnFightStart { get { return this[nameof(AudioOnFightStart)]; } set { this[nameof(AudioOnFightStart)] = value; } }
        public Object AudioOnEnterArena { get { return this[nameof(AudioOnEnterArena)]; } set { this[nameof(AudioOnEnterArena)] = value; } }
        public Object AudioOnExitArena { get { return this[nameof(AudioOnExitArena)]; } set { this[nameof(AudioOnExitArena)] = value; } }
        public Object AudioOnPreFight { get { return this[nameof(AudioOnPreFight)]; } set { this[nameof(AudioOnPreFight)] = value; } }
        public Object OnFightStart { get { return this[nameof(OnFightStart)]; } set { this[nameof(OnFightStart)] = value; } }
        public float DelayBeforeWinCon { get { return this[nameof(DelayBeforeWinCon)].GetValue<float>(); } set { this[nameof(DelayBeforeWinCon)].SetValue<float>(value); } }
        public Object FenrirLastAttackerName { get { return this[nameof(FenrirLastAttackerName)]; } set { this[nameof(FenrirLastAttackerName)] = value; } }
        public Object FenrirLastAttackerId { get { return this[nameof(FenrirLastAttackerId)]; } set { this[nameof(FenrirLastAttackerId)] = value; } }
        public TOMCharacter Fenrir { get { return this[nameof(Fenrir)].As<TOMCharacter>(); } set { this["Fenrir"] = value; } }
        public ParticleSystem OnRewardAppearPS { get { return this[nameof(OnRewardAppearPS)].As<ParticleSystem>(); } set { this["OnRewardAppearPS"] = value; } }
        public AnimalAIController FenrirController { get { return this[nameof(FenrirController)].As<AnimalAIController>(); } set { this["FenrirController"] = value; } }
        public Vector JumpStartPosition { get { return this[nameof(JumpStartPosition)].As<Vector>(); } set { this["JumpStartPosition"] = value; } }
        public bool bIsFightStarted { get { return this[nameof(bIsFightStarted)].Flag; } set { this[nameof(bIsFightStarted)].Flag = value; } }
        public bool bIsFightWon { get { return this[nameof(bIsFightWon)].Flag; } set { this[nameof(bIsFightWon)].Flag = value; } }
        public void StartFightMulticast(TOMCharacter InFenrir) { Invoke(nameof(StartFightMulticast), InFenrir); }
        public void StartFight() { Invoke(nameof(StartFight)); }
        public void StartAI() { Invoke(nameof(StartAI)); }
        public void OnRep_IsFightWon() { Invoke(nameof(OnRep_IsFightWon)); }
        public void OnRep_FightStart() { Invoke(nameof(OnRep_FightStart)); }
        public void OnRep_FenrirActor() { Invoke(nameof(OnRep_FenrirActor)); }
        public void OnJumpDoneTimer() { Invoke(nameof(OnJumpDoneTimer)); }
        public void OnFenrirTakeDamage(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnFenrirTakeDamage), Source, IssuedAmount, HitResult); }
        public void OnCreaturesReady() { Invoke(nameof(OnCreaturesReady)); }
        public bool IsFightWon() { return Invoke<bool>(nameof(IsFightWon)); }
        public bool IsFightStarted() { return Invoke<bool>(nameof(IsFightStarted)); }
        public void InitArena() { Invoke(nameof(InitArena)); }
        public void FightWin(TOMCharacter FenrirCharacter) { Invoke(nameof(FightWin), FenrirCharacter); }
    }
    public class CaveLeverBase : TOMActor
    {
        public CaveLeverBase(ulong addr) : base(addr) { }
        public Object OnLeverTriggered { get { return this[nameof(OnLeverTriggered)]; } set { this[nameof(OnLeverTriggered)] = value; } }
        public Object LeverId { get { return this[nameof(LeverId)]; } set { this[nameof(LeverId)] = value; } }
        public Object LeverReceiverId { get { return this[nameof(LeverReceiverId)]; } set { this[nameof(LeverReceiverId)] = value; } }
        public bool bIsTriggered { get { return this[nameof(bIsTriggered)].Flag; } set { this[nameof(bIsTriggered)].Flag = value; } }
        public CaveEntityModel CaveEntityModel { get { return this[nameof(CaveEntityModel)].As<CaveEntityModel>(); } set { this["CaveEntityModel"] = value; } }
        public void ToggleLever() { Invoke(nameof(ToggleLever)); }
        public void Refresh() { Invoke(nameof(Refresh)); }
        public void OnRep_IsTriggered() { Invoke(nameof(OnRep_IsTriggered)); }
    }
    public class CaveManager : Object
    {
        public CaveManager(ulong addr) : base(addr) { }
        public float CaveZ { get { return this[nameof(CaveZ)].GetValue<float>(); } set { this[nameof(CaveZ)].SetValue<float>(value); } }
        public float CaveSpacing { get { return this[nameof(CaveSpacing)].GetValue<float>(); } set { this[nameof(CaveSpacing)].SetValue<float>(value); } }
        public Object CaveEntities { get { return this[nameof(CaveEntities)]; } set { this[nameof(CaveEntities)] = value; } }
        public void TravelToCaveById(Object CaveId, TOMCharacter Player) { Invoke(nameof(TravelToCaveById), CaveId, Player); }
        public void TravelToCave(CaveEntityModel TargetCave, TOMCharacter Player) { Invoke(nameof(TravelToCave), TargetCave, Player); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public void OnCaveLastPlayerExit(Object CaveId) { Invoke(nameof(OnCaveLastPlayerExit), CaveId); }
        public void AddCave(CaveEntityModel CaveEntityModel) { Invoke(nameof(AddCave), CaveEntityModel); }
    }
    public class CgSDKWrapper : BlueprintFunctionLibrary
    {
        public CgSDKWrapper(ulong addr) : base(addr) { }
        public void YggdrasilDestroyed() { Invoke(nameof(YggdrasilDestroyed)); }
        public void TriggerAnnouncement(Object Annoucement) { Invoke(nameof(TriggerAnnouncement), Annoucement); }
        public bool SetState(Object StateName) { return Invoke<bool>(nameof(SetState), StateName); }
        public void SetMainMenu() { Invoke(nameof(SetMainMenu)); }
        public void SetInGame() { Invoke(nameof(SetInGame)); }
        public void SetGameOver() { Invoke(nameof(SetGameOver)); }
        public bool SetGame(Object gameName) { return Invoke<bool>(nameof(SetGame), gameName); }
        public bool SetEvent(Object EventName) { return Invoke<bool>(nameof(SetEvent), EventName); }
        public void SetDaySegment(EDayTimeSegment DayTimeSegment) { Invoke(nameof(SetDaySegment), DayTimeSegment); }
        public void SetCurrentBiome(Object MusicName) { Invoke(nameof(SetCurrentBiome), MusicName); }
        public void SendEventByType(ECgSDKEventType EventType) { Invoke(nameof(SendEventByType), EventType); }
        public void SendCraftingEvent(int Rarity) { Invoke(nameof(SendCraftingEvent), Rarity); }
        public bool RequestControl() { return Invoke<bool>(nameof(RequestControl)); }
        public bool ReleaseControl() { return Invoke<bool>(nameof(ReleaseControl)); }
        public void PlayerLevelUp() { Invoke(nameof(PlayerLevelUp)); }
        public void PlayerDeath(bool bIsDead) { Invoke(nameof(PlayerDeath), bIsDead); }
        public void PlayerDamage() { Invoke(nameof(PlayerDamage)); }
        public void PickUpDeadLoot() { Invoke(nameof(PickUpDeadLoot)); }
        public void PerformProtocolHandshake() { Invoke(nameof(PerformProtocolHandshake)); }
        public void LowHealthState(bool bIsLowHealth) { Invoke(nameof(LowHealthState), bIsLowHealth); }
        public void LootTreasureChest() { Invoke(nameof(LootTreasureChest)); }
        public void LootRunes() { Invoke(nameof(LootRunes)); }
        public void LootGoldenHorn() { Invoke(nameof(LootGoldenHorn)); }
        public bool ClearState(Object StateName) { return Invoke<bool>(nameof(ClearState), StateName); }
        public bool ClearAllStates() { return Invoke<bool>(nameof(ClearAllStates)); }
        public bool ClearAllEvents() { return Invoke<bool>(nameof(ClearAllEvents)); }
        public void AnnouncementMythBossDefeated() { Invoke(nameof(AnnouncementMythBossDefeated)); }
    }
    public class ChainProjectile : AOEBase
    {
        public ChainProjectile(ulong addr) : base(addr) { }
        public NiagaraSystem NiagaraParticleSystem { get { return this[nameof(NiagaraParticleSystem)].As<NiagaraSystem>(); } set { this["NiagaraParticleSystem"] = value; } }
        public Object OnEmissionAudioName { get { return this[nameof(OnEmissionAudioName)]; } set { this[nameof(OnEmissionAudioName)] = value; } }
        public void ShowLightningPSMulticast(Array<Vector> Points) { Invoke(nameof(ShowLightningPSMulticast), Points); }
    }
    public class ChallengeManager : Object
    {
        public ChallengeManager(ulong addr) : base(addr) { }
        public Object OnChallengeCompleted { get { return this[nameof(OnChallengeCompleted)]; } set { this[nameof(OnChallengeCompleted)] = value; } }
        public UserEntityModel UserEntityModel { get { return this[nameof(UserEntityModel)].As<UserEntityModel>(); } set { this["UserEntityModel"] = value; } }
        public void OnUserDataChanged() { Invoke(nameof(OnUserDataChanged)); }
        public bool IsChallengeCompleted(ChallengeDataModel Challenge) { return Invoke<bool>(nameof(IsChallengeCompleted), Challenge); }
        public int GetCompletedCountByCategory(EChallengeCategory Category) { return Invoke<int>(nameof(GetCompletedCountByCategory), Category); }
        public int GetChallengeCountByCategory(EChallengeCategory Category) { return Invoke<int>(nameof(GetChallengeCountByCategory), Category); }
        public ChallengeDataModel GetChallengeCompleteAllForCategory(EChallengeCategory Category) { return Invoke<ChallengeDataModel>(nameof(GetChallengeCompleteAllForCategory), Category); }
        public void ClaimChallenge(ChallengeDataModel Challenge) { Invoke(nameof(ClaimChallenge), Challenge); }
    }
    public class CharacterFloatingUIManager : TOMActor
    {
        public CharacterFloatingUIManager(ulong addr) : base(addr) { }
        public int CreatureHPPoolInitSize { get { return this[nameof(CreatureHPPoolInitSize)].GetValue<int>(); } set { this[nameof(CreatureHPPoolInitSize)].SetValue<int>(value); } }
        public int FloatingDamagePoolInitSize { get { return this[nameof(FloatingDamagePoolInitSize)].GetValue<int>(); } set { this[nameof(FloatingDamagePoolInitSize)].SetValue<int>(value); } }
        public Object CreatureHPBarClass { get { return this[nameof(CreatureHPBarClass)]; } set { this[nameof(CreatureHPBarClass)] = value; } }
        public Object HazardHPBarClass { get { return this[nameof(HazardHPBarClass)]; } set { this[nameof(HazardHPBarClass)] = value; } }
        public Object ShieldLockDisplayClass { get { return this[nameof(ShieldLockDisplayClass)]; } set { this[nameof(ShieldLockDisplayClass)] = value; } }
        public Object PingCommandClass { get { return this[nameof(PingCommandClass)]; } set { this[nameof(PingCommandClass)] = value; } }
        public Object FloatingDamageClass { get { return this[nameof(FloatingDamageClass)]; } set { this[nameof(FloatingDamageClass)] = value; } }
        public Object PerkFloatingUIClass { get { return this[nameof(PerkFloatingUIClass)]; } set { this[nameof(PerkFloatingUIClass)] = value; } }
        public Object CharacterToUI { get { return this[nameof(CharacterToUI)]; } set { this[nameof(CharacterToUI)] = value; } }
        public Object HazardToUI { get { return this[nameof(HazardToUI)]; } set { this[nameof(HazardToUI)] = value; } }
        public Array<HPBarBase> CreatureHPPool { get { return new Array<HPBarBase>(this[nameof(CreatureHPPool)].Address); } }
        public Array<HPBarBase> HazardHPPool { get { return new Array<HPBarBase>(this[nameof(HazardHPPool)].Address); } }
        public Array<FloatingDamage> DamagePool { get { return new Array<FloatingDamage>(this[nameof(DamagePool)].Address); } }
        public Object CharacterToPingUI { get { return this[nameof(CharacterToPingUI)]; } set { this[nameof(CharacterToPingUI)] = value; } }
        public PlayerController LocalPlayerController { get { return this[nameof(LocalPlayerController)].As<PlayerController>(); } set { this["LocalPlayerController"] = value; } }
        public UserWidget ShieldLockDisplayWidget { get { return this[nameof(ShieldLockDisplayWidget)].As<UserWidget>(); } set { this["ShieldLockDisplayWidget"] = value; } }
        public TOMCharacter LocalCharacter { get { return this[nameof(LocalCharacter)].As<TOMCharacter>(); } set { this["LocalCharacter"] = value; } }
        public Actor ShieldLockTarget { get { return this[nameof(ShieldLockTarget)].As<Actor>(); } set { this["ShieldLockTarget"] = value; } }
        public Object LocalPlayerPerks { get { return this[nameof(LocalPlayerPerks)]; } set { this[nameof(LocalPlayerPerks)] = value; } }
        public Object LocalPlayerPerkPool { get { return this[nameof(LocalPlayerPerkPool)]; } set { this[nameof(LocalPlayerPerkPool)] = value; } }
        public void ShowFloatingDamage(int TypeId, float Amount, int Effectivness, Vector WorldPosition) { Invoke(nameof(ShowFloatingDamage), TypeId, Amount, Effectivness, WorldPosition); }
        public void SetFloatingUIsVisibility(bool bNewValue) { Invoke(nameof(SetFloatingUIsVisibility), bNewValue); }
        public void OnLocalCharacterShieldLock(Actor LockTarget) { Invoke(nameof(OnLocalCharacterShieldLock), LockTarget); }
        public void FloatingDamageEnd(FloatingDamage FloatingDamage) { Invoke(nameof(FloatingDamageEnd), FloatingDamage); }
    }
    public class ChargeAttackComponent : SphereComponent
    {
        public ChargeAttackComponent(ulong addr) : base(addr) { }
        public void StopCharge() { Invoke(nameof(StopCharge)); }
        public void StartCharge() { Invoke(nameof(StartCharge)); }
        public void OnOverlapBegin(PrimitiveComponent OverlappedComp, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnOverlapBegin), OverlappedComp, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class ChargeAttackNotifyState : AnimNotifyState
    {
        public ChargeAttackNotifyState(ulong addr) : base(addr) { }
        public ChargeAttackComponent ChargeAttackComponent { get { return this[nameof(ChargeAttackComponent)].As<ChargeAttackComponent>(); } set { this["ChargeAttackComponent"] = value; } }
    }
    public class ChestSpawnPoint : Actor
    {
        public ChestSpawnPoint(ulong addr) : base(addr) { }
        public bool bIsBoss { get { return this[nameof(bIsBoss)].Flag; } set { this[nameof(bIsBoss)].Flag = value; } }
    }
    public class ChunkAudioStep : Object
    {
        public ChunkAudioStep(ulong addr) : base(addr) { }
    }
    public class ChunkBuilderInterface : Interface
    {
        public ChunkBuilderInterface(ulong addr) : base(addr) { }
    }
    public class ChunkContentStep : Object
    {
        public ChunkContentStep(ulong addr) : base(addr) { }
    }
    public class ChunkCornerAttributesStep : Object
    {
        public ChunkCornerAttributesStep(ulong addr) : base(addr) { }
    }
    public class ChunkData : Object
    {
        public ChunkData(ulong addr) : base(addr) { }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
        public Array<int> MainModuleInstanceIds { get { return new Array<int>(this[nameof(MainModuleInstanceIds)].Address); } }
        public Array<int> ModuleInstanceIds { get { return new Array<int>(this[nameof(ModuleInstanceIds)].Address); } }
        public Array<CaveEntranceData> CaveEntrances { get { return new Array<CaveEntranceData>(this[nameof(CaveEntrances)].Address); } }
        public IntVector ModuleWorldPos { get { return this[nameof(ModuleWorldPos)].As<IntVector>(); } set { this["ModuleWorldPos"] = value; } }
        public Array<TerrainSectionData> LandSections { get { return new Array<TerrainSectionData>(this[nameof(LandSections)].Address); } }
        public Array<TerrainSectionData> PuddleSections { get { return new Array<TerrainSectionData>(this[nameof(PuddleSections)].Address); } }
        public TerrainSectionData BorderSection { get { return this[nameof(BorderSection)].As<TerrainSectionData>(); } set { this["BorderSection"] = value; } }
        public GeometrySectionData WaterSection { get { return this[nameof(WaterSection)].As<GeometrySectionData>(); } set { this["WaterSection"] = value; } }
        public TerrainSectionData SeaSection { get { return this[nameof(SeaSection)].As<TerrainSectionData>(); } set { this["SeaSection"] = value; } }
        public GeometrySectionData WaterCollisionSection { get { return this[nameof(WaterCollisionSection)].As<GeometrySectionData>(); } set { this["WaterCollisionSection"] = value; } }
        public GeometrySectionData NoConstructionSection { get { return this[nameof(NoConstructionSection)].As<GeometrySectionData>(); } set { this["NoConstructionSection"] = value; } }
        public GeometrySectionData GlobalCollisionSection { get { return this[nameof(GlobalCollisionSection)].As<GeometrySectionData>(); } set { this["GlobalCollisionSection"] = value; } }
        public GeometrySectionData RiverCollisionSection { get { return this[nameof(RiverCollisionSection)].As<GeometrySectionData>(); } set { this["RiverCollisionSection"] = value; } }
        public GeometrySectionData RoadCollisionSection { get { return this[nameof(RoadCollisionSection)].As<GeometrySectionData>(); } set { this["RoadCollisionSection"] = value; } }
        public Array<PropData> Props { get { return new Array<PropData>(this[nameof(Props)].Address); } }
        public Array<ResourceData> Resources { get { return new Array<ResourceData>(this[nameof(Resources)].Address); } }
        public Array<HazardData> Hazards { get { return new Array<HazardData>(this[nameof(Hazards)].Address); } }
        public Array<SurfaceData> Surfaces { get { return new Array<SurfaceData>(this[nameof(Surfaces)].Address); } }
        public Array<CreatureData> ModuleCreatures { get { return new Array<CreatureData>(this[nameof(ModuleCreatures)].Address); } }
        public Object CreaturesPackMap { get { return this[nameof(CreaturesPackMap)]; } set { this[nameof(CreaturesPackMap)] = value; } }
        public Array<DecoPropData> DecoProps { get { return new Array<DecoPropData>(this[nameof(DecoProps)].Address); } }
        public Array<ParticleSystemData> ParticleSystems { get { return new Array<ParticleSystemData>(this[nameof(ParticleSystems)].Address); } }
        public Array<InstancedMeshData> InstancedMeshes { get { return new Array<InstancedMeshData>(this[nameof(InstancedMeshes)].Address); } }
        public BiomeBorderData BiomeBorderData { get { return this[nameof(BiomeBorderData)].As<BiomeBorderData>(); } set { this["BiomeBorderData"] = value; } }
        public bool bDoGenerateFog { get { return this[nameof(bDoGenerateFog)].Flag; } set { this[nameof(bDoGenerateFog)].Flag = value; } }
        public Array<CornerAttributes> CornerAttributes { get { return new Array<CornerAttributes>(this[nameof(CornerAttributes)].Address); } }
        public Actor Actor { get { return this[nameof(Actor)].As<Actor>(); } set { this["Actor"] = value; } }
    }
    public class ChunkEntityModel : EntityModelBase
    {
        public ChunkEntityModel(ulong addr) : base(addr) { }
        public Object OnCreatureStatusChanged { get { return this[nameof(OnCreatureStatusChanged)]; } set { this[nameof(OnCreatureStatusChanged)] = value; } }
        public Array<HazardEntityModel> Hazards { get { return new Array<HazardEntityModel>(this[nameof(Hazards)].Address); } }
        public Array<WorldCreatureEntityModel> Creatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(Creatures)].Address); } }
        public Object RespawnCallbacks { get { return this[nameof(RespawnCallbacks)]; } set { this[nameof(RespawnCallbacks)] = value; } }
        public ChunkVO ToVO() { return Invoke<ChunkVO>(nameof(ToVO)); }
        public void OnHazardEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnHazardEntityChanged), Entity, Context); }
        public void OnCreatureStatusChangedCallback(bool bRespawned, Object EntityId) { Invoke(nameof(OnCreatureStatusChangedCallback), bRespawned, EntityId); }
        public ChunkEntityModel GetOrCreateChunkEntityModel(Object Outer, Object EntityId) { return Invoke<ChunkEntityModel>(nameof(GetOrCreateChunkEntityModel), Outer, EntityId); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public Array<HazardEntityModel> GetHazards() { return Invoke<Array<HazardEntityModel>>(nameof(GetHazards)); }
        public HazardEntityModel GetHazardById(Object EntityId) { return Invoke<HazardEntityModel>(nameof(GetHazardById), EntityId); }
        public Array<WorldCreatureEntityModel> GetCreatures() { return Invoke<Array<WorldCreatureEntityModel>>(nameof(GetCreatures)); }
    }
    public class ChunkFoliageStep : Object
    {
        public ChunkFoliageStep(ulong addr) : base(addr) { }
    }
    public class ChunkGenData : Object
    {
        public ChunkGenData(ulong addr) : base(addr) { }
        public ChunkLayout Layout { get { return this[nameof(Layout)].As<ChunkLayout>(); } set { this["Layout"] = value; } }
        public GenerationRNG RNG { get { return this[nameof(RNG)].As<GenerationRNG>(); } set { this["RNG"] = value; } }
        public GenerationRNG ClientRNG { get { return this[nameof(ClientRNG)].As<GenerationRNG>(); } set { this["ClientRNG"] = value; } }
        public Array<ushort> BiomeIds { get { return new Array<ushort>(this[nameof(BiomeIds)].Address); } }
        public Array<ushort> EffectiveHeights { get { return new Array<ushort>(this[nameof(EffectiveHeights)].Address); } }
    }
    public class ChunkGroundDetailsStep : Object
    {
        public ChunkGroundDetailsStep(ulong addr) : base(addr) { }
    }
    public class ChunkInitStep : Object
    {
        public ChunkInitStep(ulong addr) : base(addr) { }
    }
    public class ChunkInterface : Interface
    {
        public ChunkInterface(ulong addr) : base(addr) { }
    }
    public class ChunkLayout : Object
    {
        public ChunkLayout(ulong addr) : base(addr) { }
    }
    public class ChunkManager : Actor
    {
        public ChunkManager(ulong addr) : base(addr) { }
        public Array<ChunkAction> ChunkActions { get { return new Array<ChunkAction>(this[nameof(ChunkActions)].Address); } }
        public Object GeometryChunks { get { return this[nameof(GeometryChunks)]; } set { this[nameof(GeometryChunks)] = value; } }
        public Object TerrainChunks { get { return this[nameof(TerrainChunks)]; } set { this[nameof(TerrainChunks)] = value; } }
        public Object InstancedMeshesChunks { get { return this[nameof(InstancedMeshesChunks)]; } set { this[nameof(InstancedMeshesChunks)] = value; } }
        public Object PropsChunks { get { return this[nameof(PropsChunks)]; } set { this[nameof(PropsChunks)] = value; } }
        public Object CreaturesChunks { get { return this[nameof(CreaturesChunks)]; } set { this[nameof(CreaturesChunks)] = value; } }
        public Object DecoPropsChunks { get { return this[nameof(DecoPropsChunks)]; } set { this[nameof(DecoPropsChunks)] = value; } }
        public Object ModulesChunks { get { return this[nameof(ModulesChunks)]; } set { this[nameof(ModulesChunks)] = value; } }
        public Object PostProcessVolumeChunks { get { return this[nameof(PostProcessVolumeChunks)]; } set { this[nameof(PostProcessVolumeChunks)] = value; } }
    }
    public class ChunkModulesStep : Object
    {
        public ChunkModulesStep(ulong addr) : base(addr) { }
    }
    public class ChunkProviderInterface : Interface
    {
        public ChunkProviderInterface(ulong addr) : base(addr) { }
    }
    public class ChunkStepInterface : Interface
    {
        public ChunkStepInterface(ulong addr) : base(addr) { }
    }
    public class ChunkTilesStep : Object
    {
        public ChunkTilesStep(ulong addr) : base(addr) { }
    }
    public class ChunkTrapsStep : Object
    {
        public ChunkTrapsStep(ulong addr) : base(addr) { }
    }
    public class ClientModule : Actor
    {
        public ClientModule(ulong addr) : base(addr) { }
    }
    public class CollectMaterialsQuestBehavior : QuestBehaviorBase
    {
        public CollectMaterialsQuestBehavior(ulong addr) : base(addr) { }
        public ContainerEntityModel ContainerEntityModel { get { return this[nameof(ContainerEntityModel)].As<ContainerEntityModel>(); } set { this["ContainerEntityModel"] = value; } }
        public Object ItemsRequired { get { return this[nameof(ItemsRequired)]; } set { this[nameof(ItemsRequired)] = value; } }
        public Object ItemsAcquired { get { return this[nameof(ItemsAcquired)]; } set { this[nameof(ItemsAcquired)] = value; } }
        public void OnAddItem(int ItemId, int Count) { Invoke(nameof(OnAddItem), ItemId, Count); }
    }
    public class ComponentUtility : Object
    {
        public ComponentUtility(ulong addr) : base(addr) { }
        public void ReplaceAnimState(AnimSequenceBase AnimationSequence, Object OldNotifyClass, Object NewNotifyClass) { Invoke(nameof(ReplaceAnimState), AnimationSequence, OldNotifyClass, NewNotifyClass); }
        public void RemoveAnimNotifyStates(AnimSequenceBase AnimationSequence, Object OldNotifyClass) { Invoke(nameof(RemoveAnimNotifyStates), AnimationSequence, OldNotifyClass); }
        public void K2_IsTearingDown(Object caller, bool isTearingDown) { Invoke(nameof(K2_IsTearingDown), caller, isTearingDown); }
        public ActorComponent AddComponentToActor(Object Class, Object Outer) { return Invoke<ActorComponent>(nameof(AddComponentToActor), Class, Outer); }
    }
    public class ConstructionGridCell : Actor
    {
        public ConstructionGridCell(ulong addr) : base(addr) { }
        public Object OnGridCellStatusChanged { get { return this[nameof(OnGridCellStatusChanged)]; } set { this[nameof(OnGridCellStatusChanged)] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public StaticMeshComponent Mesh { get { return this[nameof(Mesh)].As<StaticMeshComponent>(); } set { this["Mesh"] = value; } }
        public BoxComponent BoxCollider { get { return this[nameof(BoxCollider)].As<BoxComponent>(); } set { this["BoxCollider"] = value; } }
        public float ZExtentMultiplier { get { return this[nameof(ZExtentMultiplier)].GetValue<float>(); } set { this[nameof(ZExtentMultiplier)].SetValue<float>(value); } }
        public LinearColor NeutralColor { get { return this[nameof(NeutralColor)].As<LinearColor>(); } set { this["NeutralColor"] = value; } }
        public LinearColor ValidColor { get { return this[nameof(ValidColor)].As<LinearColor>(); } set { this["ValidColor"] = value; } }
        public LinearColor InvalidColor { get { return this[nameof(InvalidColor)].As<LinearColor>(); } set { this["InvalidColor"] = value; } }
        public MaterialInstanceDynamic DynamicMaterial { get { return this[nameof(DynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["DynamicMaterial"] = value; } }
        public Object ColorParameterName { get { return this[nameof(ColorParameterName)]; } set { this[nameof(ColorParameterName)] = value; } }
        public float ZCastOffset { get { return this[nameof(ZCastOffset)].GetValue<float>(); } set { this[nameof(ZCastOffset)].SetValue<float>(value); } }
        public float ZDifferenceTolerance { get { return this[nameof(ZDifferenceTolerance)].GetValue<float>(); } set { this[nameof(ZDifferenceTolerance)].SetValue<float>(value); } }
        public float AlphaOffset { get { return this[nameof(AlphaOffset)].GetValue<float>(); } set { this[nameof(AlphaOffset)].SetValue<float>(value); } }
        public Texture BuildingTexture { get { return this[nameof(BuildingTexture)].As<Texture>(); } set { this["BuildingTexture"] = value; } }
        public Texture BuildingTextureValidation { get { return this[nameof(BuildingTextureValidation)].As<Texture>(); } set { this["BuildingTextureValidation"] = value; } }
        public Texture FondationNormalTexture { get { return this[nameof(FondationNormalTexture)].As<Texture>(); } set { this["FondationNormalTexture"] = value; } }
        public Texture FondationCornerTexture { get { return this[nameof(FondationCornerTexture)].As<Texture>(); } set { this["FondationCornerTexture"] = value; } }
        public Object TextureParameterName { get { return this[nameof(TextureParameterName)]; } set { this[nameof(TextureParameterName)] = value; } }
        public float GridCellSize { get { return this[nameof(GridCellSize)].GetValue<float>(); } set { this[nameof(GridCellSize)].SetValue<float>(value); } }
        public HazardBase SupportingFondation { get { return this[nameof(SupportingFondation)].As<HazardBase>(); } set { this["SupportingFondation"] = value; } }
        public void OnHazardSpawned() { Invoke(nameof(OnHazardSpawned)); }
        public void OnComponentEndOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(OnComponentEndOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void OnComponentBeginOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnComponentBeginOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class ConstructionManager : Actor
    {
        public ConstructionManager(ulong addr) : base(addr) { }
        public Object OnShowConstructionValidation { get { return this[nameof(OnShowConstructionValidation)]; } set { this[nameof(OnShowConstructionValidation)] = value; } }
        public Object OnHideConstructionValidation { get { return this[nameof(OnHideConstructionValidation)]; } set { this[nameof(OnHideConstructionValidation)] = value; } }
        public Object OnRefreshPlacementValidation { get { return this[nameof(OnRefreshPlacementValidation)]; } set { this[nameof(OnRefreshPlacementValidation)] = value; } }
        public Object OnOpenConstructionMenu { get { return this[nameof(OnOpenConstructionMenu)]; } set { this[nameof(OnOpenConstructionMenu)] = value; } }
        public Object OnCloseConstructionMenu { get { return this[nameof(OnCloseConstructionMenu)]; } set { this[nameof(OnCloseConstructionMenu)] = value; } }
        public LinearColor ConstructionValidColor { get { return this[nameof(ConstructionValidColor)].As<LinearColor>(); } set { this["ConstructionValidColor"] = value; } }
        public LinearColor ConstructionInvalidColor { get { return this[nameof(ConstructionInvalidColor)].As<LinearColor>(); } set { this["ConstructionInvalidColor"] = value; } }
        public Object CellTemplate { get { return this[nameof(CellTemplate)]; } set { this[nameof(CellTemplate)] = value; } }
        public float GridMovementDefaultThreshold { get { return this[nameof(GridMovementDefaultThreshold)].GetValue<float>(); } set { this[nameof(GridMovementDefaultThreshold)].SetValue<float>(value); } }
        public bool bIsGridOpen { get { return this[nameof(bIsGridOpen)].Flag; } set { this[nameof(bIsGridOpen)].Flag = value; } }
        public bool bIsConstructionMenuOpen { get { return this[nameof(bIsConstructionMenuOpen)].Flag; } set { this[nameof(bIsConstructionMenuOpen)].Flag = value; } }
        public int GridSize { get { return this[nameof(GridSize)].GetValue<int>(); } set { this[nameof(GridSize)].SetValue<int>(value); } }
        public int GridCellSize { get { return this[nameof(GridCellSize)].GetValue<int>(); } set { this[nameof(GridCellSize)].SetValue<int>(value); } }
        public float ValidationTreshold { get { return this[nameof(ValidationTreshold)].GetValue<float>(); } set { this[nameof(ValidationTreshold)].SetValue<float>(value); } }
        public bool bIsCurrentPlacementValid { get { return this[nameof(bIsCurrentPlacementValid)].Flag; } set { this[nameof(bIsCurrentPlacementValid)].Flag = value; } }
        public float PendingScaleOffset { get { return this[nameof(PendingScaleOffset)].GetValue<float>(); } set { this[nameof(PendingScaleOffset)].SetValue<float>(value); } }
        public int CurrentConstructionRecipeId { get { return this[nameof(CurrentConstructionRecipeId)].GetValue<int>(); } set { this[nameof(CurrentConstructionRecipeId)].SetValue<int>(value); } }
        public ConstructionRecipeDataModel ConstructionRecipeData { get { return this[nameof(ConstructionRecipeData)].As<ConstructionRecipeDataModel>(); } set { this["ConstructionRecipeData"] = value; } }
        public HazardBase PendingHazard { get { return this[nameof(PendingHazard)].As<HazardBase>(); } set { this["PendingHazard"] = value; } }
        public Actor StaticGridActor { get { return this[nameof(StaticGridActor)].As<Actor>(); } set { this["StaticGridActor"] = value; } }
        public void ValidatePlacement() { Invoke(nameof(ValidatePlacement)); }
        public void StopDestructionMode() { Invoke(nameof(StopDestructionMode)); }
        public void StartDestructionMode() { Invoke(nameof(StartDestructionMode)); }
        public void ShowConstruction(TOMCharacter InCharacterSource) { Invoke(nameof(ShowConstruction), InCharacterSource); }
        public void RotatePendingConstruction() { Invoke(nameof(RotatePendingConstruction)); }
        public void OpenConstructionGrid(int ConstructionRecipeId) { Invoke(nameof(OpenConstructionGrid), ConstructionRecipeId); }
        public void OnPlacementCollisionBeginOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnPlacementCollisionBeginOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
        public void OnInventoryChanged(ContainerDifference ContainerDifference) { Invoke(nameof(OnInventoryChanged), ContainerDifference); }
        public void OnGridCellStatusChanged() { Invoke(nameof(OnGridCellStatusChanged)); }
        public bool IsCornerPending() { return Invoke<bool>(nameof(IsCornerPending)); }
        public void HideConstruction() { Invoke(nameof(HideConstruction)); }
        public HazardBase GetPendingHazard() { return Invoke<HazardBase>(nameof(GetPendingHazard)); }
        public float GetGridCellSize() { return Invoke<float>(nameof(GetGridCellSize)); }
        public int GetCurrentRecipeCraftableCount() { return Invoke<int>(nameof(GetCurrentRecipeCraftableCount)); }
        public void FlipPendingConstruction() { Invoke(nameof(FlipPendingConstruction)); }
        public void CloseConstructionGrid() { Invoke(nameof(CloseConstructionGrid)); }
        public void ChangeElevationPendingConstruction() { Invoke(nameof(ChangeElevationPendingConstruction)); }
    }
    public class ContainerEntityModel : EntityModelBase
    {
        public ContainerEntityModel(ulong addr) : base(addr) { }
        public Object OnContainerChanged { get { return this[nameof(OnContainerChanged)]; } set { this[nameof(OnContainerChanged)] = value; } }
        public Object OnSlotChanged { get { return this[nameof(OnSlotChanged)]; } set { this[nameof(OnSlotChanged)] = value; } }
        public Object OnAddItem { get { return this[nameof(OnAddItem)]; } set { this[nameof(OnAddItem)] = value; } }
        public Vector LootPosition { get { return this[nameof(LootPosition)].As<Vector>(); } set { this["LootPosition"] = value; } }
        public TOMPlayerController LastInteractor { get { return this[nameof(LastInteractor)].As<TOMPlayerController>(); } set { this["LastInteractor"] = value; } }
        public Array<ContainerSlotEntityModel> Slots { get { return new Array<ContainerSlotEntityModel>(this[nameof(Slots)].Address); } }
        public Object SettingsByCategoryCache { get { return this[nameof(SettingsByCategoryCache)]; } set { this[nameof(SettingsByCategoryCache)] = value; } }
        public bool TryAutoEquipItem(int ItemId, int LoadoutIndex) { return Invoke<bool>(nameof(TryAutoEquipItem), ItemId, LoadoutIndex); }
        public ContainerVO ToVO() { return Invoke<ContainerVO>(nameof(ToVO)); }
        public bool StartTransactionBP(Object InContext) { return Invoke<bool>(nameof(StartTransactionBP), InContext); }
        public void SetSelectedLoadoutIndex(int InSelectedIndex) { Invoke(nameof(SetSelectedLoadoutIndex), InSelectedIndex); }
        public void SetContainerData(ContainerDataModel NewContainerData) { Invoke(nameof(SetContainerData), NewContainerData); }
        public bool Rollback() { return Invoke<bool>(nameof(Rollback)); }
        public void OnSlotEntityChanged(EntityModelBase Entity, Object InContext) { Invoke(nameof(OnSlotEntityChanged), Entity, InContext); }
        public Array<ContainerSlotEntityModel> MergeTmpSlotsArray(Array<ContainerSlotEntityModel> SlotsToAdd) { return Invoke<Array<ContainerSlotEntityModel>>(nameof(MergeTmpSlotsArray), SlotsToAdd); }
        public bool IsSlotEquipped(Object SlotId) { return Invoke<bool>(nameof(IsSlotEquipped), SlotId); }
        public bool IsFull() { return Invoke<bool>(nameof(IsFull)); }
        public bool IsEmpty() { return Invoke<bool>(nameof(IsEmpty)); }
        public EContainerType GetType() { return Invoke<EContainerType>(nameof(GetType)); }
        public Array<ContainerSlotEntityModel> GetSlotsByCategoryAndItemTypes(EItemCategory Category, Array<int> ItemTypes, bool bAvoidHiddenItems) { return Invoke<Array<ContainerSlotEntityModel>>(nameof(GetSlotsByCategoryAndItemTypes), Category, ItemTypes, bAvoidHiddenItems); }
        public Array<ContainerSlotEntityModel> GetSlotsByCategory(EItemCategory Category, bool bAvoidHiddenItems) { return Invoke<Array<ContainerSlotEntityModel>>(nameof(GetSlotsByCategory), Category, bAvoidHiddenItems); }
        public Array<ContainerSlotEntityModel> GetSlots() { return Invoke<Array<ContainerSlotEntityModel>>(nameof(GetSlots)); }
        public ContainerSlotEntityModel GetSlotByItemId(Object ID) { return Invoke<ContainerSlotEntityModel>(nameof(GetSlotByItemId), ID); }
        public ContainerSlotEntityModel GetSlotById(Object ID) { return Invoke<ContainerSlotEntityModel>(nameof(GetSlotById), ID); }
        public ContainerSlotEntityModel GetSlotByCategoryAndLoadout(EItemCategory ItemCategory, int LoadoutIndex) { return Invoke<ContainerSlotEntityModel>(nameof(GetSlotByCategoryAndLoadout), ItemCategory, LoadoutIndex); }
        public ContainerSettingsDataVO GetSettingsByCategory(EItemCategory Category) { return Invoke<ContainerSettingsDataVO>(nameof(GetSettingsByCategory), Category); }
        public Array<ContainerSettingsDataVO> GetSettings() { return Invoke<Array<ContainerSettingsDataVO>>(nameof(GetSettings)); }
        public int GetSelectedLoadoutIndex() { return Invoke<int>(nameof(GetSelectedLoadoutIndex)); }
        public ContainerEntityModel GetOrCreateEntity(Object Outer, Object EntityId, int ContainerId) { return Invoke<ContainerEntityModel>(nameof(GetOrCreateEntity), Outer, EntityId, ContainerId); }
        public Object GetMissingItemsCount() { return Invoke<Object>(nameof(GetMissingItemsCount)); }
        public int GetMaxQty(ItemDataModel ItemData) { return Invoke<int>(nameof(GetMaxQty), ItemData); }
        public TOMPlayerController GetLastInteractor() { return Invoke<TOMPlayerController>(nameof(GetLastInteractor)); }
        public int GetItemCountByItemId(int ItemId, bool bEquippedOnly) { return Invoke<int>(nameof(GetItemCountByItemId), ItemId, bEquippedOnly); }
        public ContainerSlotItemEntityModel GetItemById(Object ItemId) { return Invoke<ContainerSlotItemEntityModel>(nameof(GetItemById), ItemId); }
        public bool GetIsInstanced() { return Invoke<bool>(nameof(GetIsInstanced)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public ContainerSlotEntityModel GetFirstSlotByType(int ItemTypeId) { return Invoke<ContainerSlotEntityModel>(nameof(GetFirstSlotByType), ItemTypeId); }
        public ContainerSlotEntityModel GetFirstSlotByItemDataId(int ItemDataId) { return Invoke<ContainerSlotEntityModel>(nameof(GetFirstSlotByItemDataId), ItemDataId); }
        public ContainerSlotEntityModel GetFirstEquippedSlotByItemDataId(int ItemDataId) { return Invoke<ContainerSlotEntityModel>(nameof(GetFirstEquippedSlotByItemDataId), ItemDataId); }
        public ContainerSlotEntityModel GetFirstEquippedSlotByCategory(EItemCategory ItemCategory) { return Invoke<ContainerSlotEntityModel>(nameof(GetFirstEquippedSlotByCategory), ItemCategory); }
        public ContainerSlotEntityModel GetFirstEquipedSlotByType(int ItemTypeId) { return Invoke<ContainerSlotEntityModel>(nameof(GetFirstEquipedSlotByType), ItemTypeId); }
        public Array<ContainerSlotEntityModel> GetEquipedSlotsByCategory(EItemCategory Category) { return Invoke<Array<ContainerSlotEntityModel>>(nameof(GetEquipedSlotsByCategory), Category); }
        public Array<ContainerSlotEntityModel> GetEquipedSlots() { return Invoke<Array<ContainerSlotEntityModel>>(nameof(GetEquipedSlots)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public int GetContainerId() { return Invoke<int>(nameof(GetContainerId)); }
        public int GetAvailableQty(ItemDataModel ItemData) { return Invoke<int>(nameof(GetAvailableQty), ItemData); }
        public void FillContainer(ContainerEntityModel Source, int ItemId, int Count, TOMPlayerController Interactor) { Invoke(nameof(FillContainer), Source, ItemId, Count, Interactor); }
        public void EmptyContainer() { Invoke(nameof(EmptyContainer)); }
        public ContainerEntityModel CreateFromVO(Object Outer, ContainerVO InVO) { return Invoke<ContainerEntityModel>(nameof(CreateFromVO), Outer, InVO); }
        public bool Commit() { return Invoke<bool>(nameof(Commit)); }
    }
    public class ContainerSlotEntityModel : EntityModelBase
    {
        public ContainerSlotEntityModel(ulong addr) : base(addr) { }
        public int TemporaryCountDiff { get { return this[nameof(TemporaryCountDiff)].GetValue<int>(); } set { this[nameof(TemporaryCountDiff)].SetValue<int>(value); } }
        public ContainerSlotItemEntityModel Item { get { return this[nameof(Item)].As<ContainerSlotItemEntityModel>(); } set { this["Item"] = value; } }
        public bool UpdateTempFillCount(float TimeSinceHoldStarted, ContainerEntityModel DestinationContainer, bool OutCompleted) { return Invoke<bool>(nameof(UpdateTempFillCount), TimeSinceHoldStarted, DestinationContainer, OutCompleted); }
        public void SortSlotsArray(ESortType sortType, Array<ContainerSlotEntityModel> arrayToSort) { Invoke(nameof(SortSlotsArray), sortType, arrayToSort); }
        public void OnItemChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnItemChanged), Entity, Context); }
        public Object GetOnItemDurabilityChangedContext() { return Invoke<Object>(nameof(GetOnItemDurabilityChangedContext)); }
        public Object GetOnItemBreakContext() { return Invoke<Object>(nameof(GetOnItemBreakContext)); }
        public int GetLoadoutIndex() { return Invoke<int>(nameof(GetLoadoutIndex)); }
        public ContainerSlotItemEntityModel GetItem() { return Invoke<ContainerSlotItemEntityModel>(nameof(GetItem)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public int GetCount() { return Invoke<int>(nameof(GetCount)); }
    }
    public class ContainerSlotItemEntityModel : EntityModelBase
    {
        public ContainerSlotItemEntityModel(ulong addr) : base(addr) { }
        public Object OnDurabilityChanged { get { return this[nameof(OnDurabilityChanged)]; } set { this[nameof(OnDurabilityChanged)] = value; } }
        public int GetRepairSoulCost(TOMCharacter TOMCharacter) { return Invoke<int>(nameof(GetRepairSoulCost), TOMCharacter); }
        public float GetNormalizedDurability() { return Invoke<float>(nameof(GetNormalizedDurability)); }
        public int GetMaxDurability() { return Invoke<int>(nameof(GetMaxDurability)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public ItemDataModel GetItem() { return Invoke<ItemDataModel>(nameof(GetItem)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public int GetDurability() { return Invoke<int>(nameof(GetDurability)); }
        public int GetDismantleValue(TOMCharacter TOMCharacter) { return Invoke<int>(nameof(GetDismantleValue), TOMCharacter); }
        public ContainerSlotItemEntityModel CreateFromVO(Object Outer, ContainerSlotItemVO InVO) { return Invoke<ContainerSlotItemEntityModel>(nameof(CreateFromVO), Outer, InVO); }
        public void ConsumeDurability(int Amount, TOMCharacter CharacterOwner) { Invoke(nameof(ConsumeDurability), Amount, CharacterOwner); }
    }
    public class CornerActor : Actor
    {
        public CornerActor(ulong addr) : base(addr) { }
        public CornerAttributes CornerAttributes { get { return this[nameof(CornerAttributes)].As<CornerAttributes>(); } set { this["CornerAttributes"] = value; } }
    }
    public class CreaturePackEntityModel : EntityModelBase
    {
        public CreaturePackEntityModel(ulong addr) : base(addr) { }
        public Object OnLastCreatureDied { get { return this[nameof(OnLastCreatureDied)]; } set { this[nameof(OnLastCreatureDied)] = value; } }
        public CreaturePackDataModel CreaturePackDataModel { get { return this[nameof(CreaturePackDataModel)].As<CreaturePackDataModel>(); } set { this["CreaturePackDataModel"] = value; } }
        public CreaturePackVO ToVO() { return Invoke<CreaturePackVO>(nameof(ToVO)); }
        public void OnCreatureDied(WorldCreatureEntityModel CreatureEntity) { Invoke(nameof(OnCreatureDied), CreatureEntity); }
        public CreaturePackEntityModel GetOrCreateCreaturePackEntity(Object Outer, Object EntityId, int CreaturePackDataId, Array<Object> Creatures, Object SummonerId) { return Invoke<CreaturePackEntityModel>(nameof(GetOrCreateCreaturePackEntity), Outer, EntityId, CreaturePackDataId, Creatures, SummonerId); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public Array<Object> GetCreatures() { return Invoke<Array<Object>>(nameof(GetCreatures)); }
        public CreaturePackDataModel GetCreaturePackData() { return Invoke<CreaturePackDataModel>(nameof(GetCreaturePackData)); }
        public CreaturePackEntityModel CreateFromVO(Object Outer, CreaturePackVO VO) { return Invoke<CreaturePackEntityModel>(nameof(CreateFromVO), Outer, VO); }
    }
    public class CreaturesChunkObject : Object
    {
        public CreaturesChunkObject(ulong addr) : base(addr) { }
        public IntPoint ChunkCoordinates { get { return this[nameof(ChunkCoordinates)].As<IntPoint>(); } set { this["ChunkCoordinates"] = value; } }
    }
    public class CreatureSpawnPoint : Actor
    {
        public CreatureSpawnPoint(ulong addr) : base(addr) { }
    }
    public class DecoPropsChunkActor : Object
    {
        public DecoPropsChunkActor(ulong addr) : base(addr) { }
        public Array<Actor> DecoProps { get { return new Array<Actor>(this[nameof(DecoProps)].Address); } }
        public Array<ParticleSystemComponent> ParticleSystems { get { return new Array<ParticleSystemComponent>(this[nameof(ParticleSystems)].Address); } }
    }
    public class DefaultBuilder : Object
    {
        public DefaultBuilder(ulong addr) : base(addr) { }
    }
    public class DefaultChunk : Object
    {
        public DefaultChunk(ulong addr) : base(addr) { }
        public Object ActorClass { get { return this[nameof(ActorClass)]; } set { this[nameof(ActorClass)] = value; } }
        public Actor Actor { get { return this[nameof(Actor)].As<Actor>(); } set { this["Actor"] = value; } }
    }
    public class DefaultProvider : Object
    {
        public DefaultProvider(ulong addr) : base(addr) { }
        public Object ActorClass { get { return this[nameof(ActorClass)]; } set { this[nameof(ActorClass)] = value; } }
    }
    public class DefensiveForwardComponent : DefensiveComponent
    {
        public DefensiveForwardComponent(ulong addr) : base(addr) { }
        public DefensiveComponent PrimaryDefensive { get { return this[nameof(PrimaryDefensive)].As<DefensiveComponent>(); } set { this["PrimaryDefensive"] = value; } }
        public void SetPrimaryDefensive(DefensiveComponent InPrimaryDefensive) { Invoke(nameof(SetPrimaryDefensive), InPrimaryDefensive); }
        public DefensiveComponent GetPrimaryDefensive() { return Invoke<DefensiveComponent>(nameof(GetPrimaryDefensive)); }
    }
    public class DefensiveShieldComponent : DefensiveComponent
    {
        public DefensiveShieldComponent(ulong addr) : base(addr) { }
        public Object OnShieldBlockReceive { get { return this[nameof(OnShieldBlockReceive)]; } set { this[nameof(OnShieldBlockReceive)] = value; } }
        public Object OnAttackGoThroughShield { get { return this[nameof(OnAttackGoThroughShield)]; } set { this[nameof(OnAttackGoThroughShield)] = value; } }
        public Object OnDamageTypeReceived { get { return this[nameof(OnDamageTypeReceived)]; } set { this[nameof(OnDamageTypeReceived)] = value; } }
        public float ShieldConeAngle { get { return this[nameof(ShieldConeAngle)].GetValue<float>(); } set { this[nameof(ShieldConeAngle)].SetValue<float>(value); } }
        public Rotator ShieldRotation { get { return this[nameof(ShieldRotation)].As<Rotator>(); } set { this["ShieldRotation"] = value; } }
        public bool IsShielding { get { return this[nameof(IsShielding)].Flag; } set { this[nameof(IsShielding)].Flag = value; } }
        public ShieldDataModel CurrentShield { get { return this[nameof(CurrentShield)].As<ShieldDataModel>(); } set { this["CurrentShield"] = value; } }
        public bool UseArmor { get { return this[nameof(UseArmor)].Flag; } set { this[nameof(UseArmor)].Flag = value; } }
        public bool UseResistance { get { return this[nameof(UseResistance)].Flag; } set { this[nameof(UseResistance)].Flag = value; } }
        public bool ByPassParry { get { return this[nameof(ByPassParry)].Flag; } set { this[nameof(ByPassParry)].Flag = value; } }
        public bool bBlockAnyProjectile { get { return this[nameof(bBlockAnyProjectile)].Flag; } set { this[nameof(bBlockAnyProjectile)].Flag = value; } }
        public bool bPreventDamage { get { return this[nameof(bPreventDamage)].Flag; } set { this[nameof(bPreventDamage)].Flag = value; } }
        public Array<int> CurrentAmorPerks { get { return new Array<int>(this[nameof(CurrentAmorPerks)].Address); } }
        public Object CurrentArmorStats { get { return this[nameof(CurrentArmorStats)]; } set { this[nameof(CurrentArmorStats)] = value; } }
        public Object CurrentResistances { get { return this[nameof(CurrentResistances)]; } set { this[nameof(CurrentResistances)] = value; } }
        public Object ReceivedNonStackableAttacks { get { return this[nameof(ReceivedNonStackableAttacks)]; } set { this[nameof(ReceivedNonStackableAttacks)] = value; } }
        public void ShieldBlockReceive__DelegateSignature(TOMOffensiveComponent OffensiveComponent, Vector Location, float Damage) { Invoke(nameof(ShieldBlockReceive__DelegateSignature), OffensiveComponent, Location, Damage); }
        public void SetPreventDamage(bool InPreventDamage) { Invoke(nameof(SetPreventDamage), InPreventDamage); }
        public void SetMaxAmount(float InMaxAmount) { Invoke(nameof(SetMaxAmount), InMaxAmount); }
        public void ResolvePerks(Array<PerkDataModel> Perks, TOMOffensiveComponent Source, float TotalAmount) { Invoke(nameof(ResolvePerks), Perks, Source, TotalAmount); }
        public void Reset() { Invoke(nameof(Reset)); }
        public void RefreshArmor(Array<ContainerSlotEntityModel> EquipmentSlots) { Invoke(nameof(RefreshArmor), EquipmentSlots); }
        public void ReceiveDamageType(int DamageTypeId, float InAmount, EmitterComponent Source) { Invoke(nameof(ReceiveDamageType), DamageTypeId, InAmount, Source); }
        public void ReceiveAbsolute(EmitterComponent Source, float InAmount, HitResult HitResult, bool bForceReceive) { Invoke(nameof(ReceiveAbsolute), Source, InAmount, HitResult, bForceReceive); }
        public bool GetPreventDamage() { return Invoke<bool>(nameof(GetPreventDamage)); }
        public bool GetIsInvincible() { return Invoke<bool>(nameof(GetIsInvincible)); }
        public float GetCurrentResistance() { return Invoke<float>(nameof(GetCurrentResistance)); }
        public int GetCurrentArmorMultiplier() { return Invoke<int>(nameof(GetCurrentArmorMultiplier)); }
        public int GetCurrentArmorBonus() { return Invoke<int>(nameof(GetCurrentArmorBonus)); }
        public Object GetArmorStats() { return Invoke<Object>(nameof(GetArmorStats)); }
        public void Cleanse() { Invoke(nameof(Cleanse)); }
        public void AttackGoThroughShield__DelegateSignature(TOMOffensiveComponent OffensiveComponent) { Invoke(nameof(AttackGoThroughShield__DelegateSignature), OffensiveComponent); }
        public void AddResistance(float Value) { Invoke(nameof(AddResistance), Value); }
        public void AddArmorMultiplier(float Value) { Invoke(nameof(AddArmorMultiplier), Value); }
        public void AddArmorBonus(int Value) { Invoke(nameof(AddArmorBonus), Value); }
    }
    public class DestructibleLandmarkBase : DestructibleHazardBase
    {
        public DestructibleLandmarkBase(ulong addr) : base(addr) { }
        public Object RelativeTransforms { get { return this[nameof(RelativeTransforms)]; } set { this[nameof(RelativeTransforms)] = value; } }
        public Object CollisionProfiles { get { return this[nameof(CollisionProfiles)]; } set { this[nameof(CollisionProfiles)] = value; } }
    }
    public class DonateMaterialsQuestBehavior : QuestBehaviorBase
    {
        public DonateMaterialsQuestBehavior(ulong addr) : base(addr) { }
        public ContainerEntityModel ContainerEntityModel { get { return this[nameof(ContainerEntityModel)].As<ContainerEntityModel>(); } set { this["ContainerEntityModel"] = value; } }
        public void OnContainerChanged(ContainerDifference ContainerDifference) { Invoke(nameof(OnContainerChanged), ContainerDifference); }
    }
    public class DroppedLoot : TOMActor
    {
        public DroppedLoot(ulong addr) : base(addr) { }
        public ECgSDKEventType CgSDKEventType { get { return (ECgSDKEventType)this[nameof(CgSDKEventType)].GetValue<int>(); } set { this[nameof(CgSDKEventType)].SetValue<int>((int)value); } }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public DroppedLootData Data { get { return this[nameof(Data)].As<DroppedLootData>(); } set { this["Data"] = value; } }
        public void SpawnLootActor() { Invoke(nameof(SpawnLootActor)); }
        public void SetLoot(ContainerEntityModel InContainer, Array<Object> ExcludedUserIds) { Invoke(nameof(SetLoot), InContainer, ExcludedUserIds); }
        public void PrepareSpawnLootActor(int InItemId, int InDurability, bool InIsInstanced, Array<Object> UserIds) { Invoke(nameof(PrepareSpawnLootActor), InItemId, InDurability, InIsInstanced, UserIds); }
        public void OnTimerElapsed() { Invoke(nameof(OnTimerElapsed)); }
        public void OnRep_Data() { Invoke(nameof(OnRep_Data)); }
        public bool GetIsInstanced() { return Invoke<bool>(nameof(GetIsInstanced)); }
        public ContainerEntityModel GetContainer() { return Invoke<ContainerEntityModel>(nameof(GetContainer)); }
        public void DestroyInstancedLootActor() { Invoke(nameof(DestroyInstancedLootActor)); }
        public void CollectLoot(Object UserId) { Invoke(nameof(CollectLoot), UserId); }
        public void CheckDestroyInstancedLootActor(Object UserId) { Invoke(nameof(CheckDestroyInstancedLootActor), UserId); }
    }
    public class DynamicMapIconBaseWidget : UserWidget
    {
        public DynamicMapIconBaseWidget(ulong addr) : base(addr) { }
        public Vector2D IconSize { get { return this[nameof(IconSize)].As<Vector2D>(); } set { this["IconSize"] = value; } }
        public Image IconWidget { get { return this[nameof(IconWidget)].As<Image>(); } set { this["IconWidget"] = value; } }
        public void RefreshIcon(AppearOnWorldMapComponent IconInfo) { Invoke(nameof(RefreshIcon), IconInfo); }
        public void InitWithMarker(PlayerMarkerInfo IconInfo, WorldmapWidget Parent) { Invoke(nameof(InitWithMarker), IconInfo, Parent); }
        public void InitWithGameEvent(GameEventMapInfo GameEventInfo) { Invoke(nameof(InitWithGameEvent), GameEventInfo); }
        public void InitWithActor(AppearOnWorldMapComponent IconInfo) { Invoke(nameof(InitWithActor), IconInfo); }
        public void Init(MovingNPCMapInfo IconInfo) { Invoke(nameof(Init), IconInfo); }
    }
    public class EnterCaveQuestBehavior : QuestBehaviorBase
    {
        public EnterCaveQuestBehavior(ulong addr) : base(addr) { }
        public void OnEnterExitCave(TOMCharacter Character) { Invoke(nameof(OnEnterExitCave), Character); }
    }
    public class EntitiesManager : Object
    {
        public EntitiesManager(ulong addr) : base(addr) { }
        public Object Entities { get { return this[nameof(Entities)]; } set { this[nameof(Entities)] = value; } }
        public Object Listeners { get { return this[nameof(Listeners)]; } set { this[nameof(Listeners)] = value; } }
        public Object OnEntityRegistrationListeners { get { return this[nameof(OnEntityRegistrationListeners)]; } set { this[nameof(OnEntityRegistrationListeners)] = value; } }
        public void Unregister(Object EntityId) { Invoke(nameof(Unregister), EntityId); }
        public void UnbindOnEntityRegisteredListener(Object EntityId, Object Callback) { Invoke(nameof(UnbindOnEntityRegisteredListener), EntityId, Callback); }
        public void UnbindActionListener(Object EntityId, Object Callback) { Invoke(nameof(UnbindActionListener), EntityId, Callback); }
        public void Register(Object Entity) { Invoke(nameof(Register), Entity); }
        public bool IsRegistered(Object EntityId) { return Invoke<bool>(nameof(IsRegistered), EntityId); }
        public EntityModelBase Get(Object Class, Object EntityId) { return Invoke<EntityModelBase>(nameof(Get), Class, EntityId); }
        public void Clear() { Invoke(nameof(Clear)); }
        public void BindOnEntityRegisteredListener(Object EntityId, Object Callback) { Invoke(nameof(BindOnEntityRegisteredListener), EntityId, Callback); }
        public void BindActionListener(Object EntityId, Object Callback) { Invoke(nameof(BindActionListener), EntityId, Callback); }
    }
    public class EntityModelInterface : Interface
    {
        public EntityModelInterface(ulong addr) : base(addr) { }
    }
    public class EquipmentInterface : Interface
    {
        public EquipmentInterface(ulong addr) : base(addr) { }
        public void SetItem(ContainerSlotItemEntityModel Item) { Invoke(nameof(SetItem), Item); }
        public void EquipItem(SceneComponent Parent) { Invoke(nameof(EquipItem), Parent); }
    }
    public class ExtractorHazardBase : BuildableHazardBase
    {
        public ExtractorHazardBase(ulong addr) : base(addr) { }
        public Object AlertChestFull { get { return this[nameof(AlertChestFull)]; } set { this[nameof(AlertChestFull)] = value; } }
        public WorldMaterialSourceEntityModel MaterialSourceEntity { get { return this[nameof(MaterialSourceEntity)].As<WorldMaterialSourceEntityModel>(); } set { this["MaterialSourceEntity"] = value; } }
        public SceneComponent LootSpawnPoint { get { return this[nameof(LootSpawnPoint)].As<SceneComponent>(); } set { this["LootSpawnPoint"] = value; } }
    }
    public class ExtractorManager : Object
    {
        public ExtractorManager(ulong addr) : base(addr) { }
        public Object AlertChestFull { get { return this[nameof(AlertChestFull)]; } set { this[nameof(AlertChestFull)] = value; } }
        public Object AlertExtract { get { return this[nameof(AlertExtract)]; } set { this[nameof(AlertExtract)] = value; } }
        public Object ExtractorSources { get { return this[nameof(ExtractorSources)]; } set { this[nameof(ExtractorSources)] = value; } }
        public void RespawnSource(bool bRespawned, Object EntityId) { Invoke(nameof(RespawnSource), bRespawned, EntityId); }
    }
    public class FeedYggdrasilQuestBehavior : QuestBehaviorBase
    {
        public FeedYggdrasilQuestBehavior(ulong addr) : base(addr) { }
        public void OnYggdrasilHealthChanged(HealthComponent healthComp, float Health, float NormalizedHealth, float HealthDelta) { Invoke(nameof(OnYggdrasilHealthChanged), healthComp, Health, NormalizedHealth, HealthDelta); }
    }
    public class FireAttackImpactAnimNotify : AnimNotify
    {
        public FireAttackImpactAnimNotify(ulong addr) : base(addr) { }
        public Vector ImpactPosition { get { return this[nameof(ImpactPosition)].As<Vector>(); } set { this["ImpactPosition"] = value; } }
    }
    public class FlammableSurface : HazardBase
    {
        public FlammableSurface(ulong addr) : base(addr) { }
        public float MinLightTimer { get { return this[nameof(MinLightTimer)].GetValue<float>(); } set { this[nameof(MinLightTimer)].SetValue<float>(value); } }
        public float MaxLightTimer { get { return this[nameof(MaxLightTimer)].GetValue<float>(); } set { this[nameof(MaxLightTimer)].SetValue<float>(value); } }
        public float ExtinctTimer { get { return this[nameof(ExtinctTimer)].GetValue<float>(); } set { this[nameof(ExtinctTimer)].SetValue<float>(value); } }
        public float BurningValue { get { return this[nameof(BurningValue)].GetValue<float>(); } set { this[nameof(BurningValue)].SetValue<float>(value); } }
        public float BurnedValue { get { return this[nameof(BurnedValue)].GetValue<float>(); } set { this[nameof(BurnedValue)].SetValue<float>(value); } }
        public int AOESpacing { get { return this[nameof(AOESpacing)].GetValue<int>(); } set { this[nameof(AOESpacing)].SetValue<int>(value); } }
        public int AOEOffset { get { return this[nameof(AOEOffset)].GetValue<int>(); } set { this[nameof(AOEOffset)].SetValue<int>(value); } }
        public int AOESubdivision { get { return this[nameof(AOESubdivision)].GetValue<int>(); } set { this[nameof(AOESubdivision)].SetValue<int>(value); } }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<LinearColor> Colors { get { return new Array<LinearColor>(this[nameof(Colors)].Address); } }
        public AttackStatsDataModel AttackStatModel { get { return this[nameof(AttackStatModel)].As<AttackStatsDataModel>(); } set { this["AttackStatModel"] = value; } }
        public FlammableSurfaceState FlammableSurfaceState { get { return this[nameof(FlammableSurfaceState)].As<FlammableSurfaceState>(); } set { this["FlammableSurfaceState"] = value; } }
        public Array<FlammableSurfaceVertex> Layout { get { return new Array<FlammableSurfaceVertex>(this[nameof(Layout)].Address); } }
        public Object AOETimers { get { return this[nameof(AOETimers)]; } set { this[nameof(AOETimers)] = value; } }
        public RandomStream RNG { get { return this[nameof(RNG)].As<RandomStream>(); } set { this["RNG"] = value; } }
        public void UpdateMesh() { Invoke(nameof(UpdateMesh)); }
        public void SpawnSmoke(Vector WorldPos, int Index) { Invoke(nameof(SpawnSmoke), WorldPos, Index); }
        public void SpawnDelayedAOE(Vector WorldPos, float Delay) { Invoke(nameof(SpawnDelayedAOE), WorldPos, Delay); }
        public void SpawnAOE(Vector WorldPos) { Invoke(nameof(SpawnAOE), WorldPos); }
        public void SetIsInteractable(bool Value) { Invoke(nameof(SetIsInteractable), Value); }
        public void Process(float DeltaTime) { Invoke(nameof(Process), DeltaTime); }
        public void OnRep_FlammableSurfaceState() { Invoke(nameof(OnRep_FlammableSurfaceState)); }
        public void OnEndBurning() { Invoke(nameof(OnEndBurning)); }
        public void InitFlammable(IntPoint InCoords, HazardEntityModel InEntityModel) { Invoke(nameof(InitFlammable), InCoords, InEntityModel); }
        public void CreateMesh(SurfaceData SurfaceData) { Invoke(nameof(CreateMesh), SurfaceData); }
    }
    public class FloatingDamage : BifrostUserWidget
    {
        public FloatingDamage(ulong addr) : base(addr) { }
        public void ShowDamage(int Damage, int Effectivness, EEquipmentElement Element) { Invoke(nameof(ShowDamage), Damage, Effectivness, Element); }
    }
    public class FloatingPingCommand : BifrostUserWidget
    {
        public FloatingPingCommand(ulong addr) : base(addr) { }
        public void Init(TOMCharacter Character) { Invoke(nameof(Init), Character); }
    }
    public class GameEventBase : TOMActor
    {
        public GameEventBase(ulong addr) : base(addr) { }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
        public Object OnEventFinished { get { return this[nameof(OnEventFinished)]; } set { this[nameof(OnEventFinished)] = value; } }
        public bool bDestroyCreatureOnStepCleanUp { get { return this[nameof(bDestroyCreatureOnStepCleanUp)].Flag; } set { this[nameof(bDestroyCreatureOnStepCleanUp)].Flag = value; } }
        public bool bDestroyHazardOnStepCleanUp { get { return this[nameof(bDestroyHazardOnStepCleanUp)].Flag; } set { this[nameof(bDestroyHazardOnStepCleanUp)].Flag = value; } }
        public int CornerCheckRange { get { return this[nameof(CornerCheckRange)].GetValue<int>(); } set { this[nameof(CornerCheckRange)].SetValue<int>(value); } }
        public int RadiusOnMapOffset { get { return this[nameof(RadiusOnMapOffset)].GetValue<int>(); } set { this[nameof(RadiusOnMapOffset)].SetValue<int>(value); } }
        public GameEventEntityModel GameEvent { get { return this[nameof(GameEvent)].As<GameEventEntityModel>(); } set { this["GameEvent"] = value; } }
        public GenerationRNG RNG { get { return this[nameof(RNG)].As<GenerationRNG>(); } set { this["RNG"] = value; } }
        public Array<GameEventZone> GameEventZones { get { return new Array<GameEventZone>(this[nameof(GameEventZones)].Address); } }
        public void NotifyStepCompletionMulticast() { Invoke(nameof(NotifyStepCompletionMulticast)); }
        public void NotifyEventStartMulticast() { Invoke(nameof(NotifyEventStartMulticast)); }
        public void NotifyEventFailedMulticast() { Invoke(nameof(NotifyEventFailedMulticast)); }
        public void NotifyEventCompletionMulticast() { Invoke(nameof(NotifyEventCompletionMulticast)); }
        public bool Init(GameEventEntityModel InGameEvent) { return Invoke<bool>(nameof(Init), InGameEvent); }
        public Array<GameEventZone> GetGameEventZones() { return Invoke<Array<GameEventZone>>(nameof(GetGameEventZones)); }
        public bool GetGameEventZoneByRegionId(int RegionId, GameEventZone OutZone) { return Invoke<bool>(nameof(GetGameEventZoneByRegionId), RegionId, OutZone); }
        public GameEventEntityModel GetGameEventEntity() { return Invoke<GameEventEntityModel>(nameof(GetGameEventEntity)); }
        public float GetEndDate() { return Invoke<float>(nameof(GetEndDate)); }
        public void FinishEvent(bool bSuccess) { Invoke(nameof(FinishEvent), bSuccess); }
        public bool CreateZones(Array<DataObject> Zones) { return Invoke<bool>(nameof(CreateZones), Zones); }
    }
    public class GameEventEntityModel : EntityModelBase
    {
        public GameEventEntityModel(ulong addr) : base(addr) { }
        public GameEventVO VO { get { return this[nameof(VO)].As<GameEventVO>(); } set { this["VO"] = value; } }
        public TimerHandle EventTimerHandle { get { return this[nameof(EventTimerHandle)].As<TimerHandle>(); } set { this["EventTimerHandle"] = value; } }
        public GameEventBase GameEventActor { get { return this[nameof(GameEventActor)].As<GameEventBase>(); } set { this["GameEventActor"] = value; } }
        public float GetStartTime() { return Invoke<float>(nameof(GetStartTime)); }
        public GameEventEntityModel GetOrCreateEntity(Object Outer, Object EntityId, int GameEventId, float StartTime, DataObject Save) { return Invoke<GameEventEntityModel>(nameof(GetOrCreateEntity), Outer, EntityId, GameEventId, StartTime, Save); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public GameEventDataModel GetGameEventData() { return Invoke<GameEventDataModel>(nameof(GetGameEventData)); }
        public GameEventBase GetGameEventActor() { return Invoke<GameEventBase>(nameof(GetGameEventActor)); }
    }
    public class GameEventManager : Object
    {
        public GameEventManager(ulong addr) : base(addr) { }
        public Object OnEventStepTrigger { get { return this[nameof(OnEventStepTrigger)]; } set { this[nameof(OnEventStepTrigger)] = value; } }
        public Object OnSpawnLootForEventStep { get { return this[nameof(OnSpawnLootForEventStep)]; } set { this[nameof(OnSpawnLootForEventStep)] = value; } }
        public Array<GameEventEntityModel> OnGoingEvents { get { return new Array<GameEventEntityModel>(this[nameof(OnGoingEvents)].Address); } }
        public void TriggerEventStep(Object EntityId, Actor LootSpawner) { Invoke(nameof(TriggerEventStep), EntityId, LootSpawner); }
        public void SpawnLootForEventStep(Object EntityId, Actor LootSpawner) { Invoke(nameof(SpawnLootForEventStep), EntityId, LootSpawner); }
        public void OnTodayEventTrigger(ScheduledGameEvent ScheduledGameEvent) { Invoke(nameof(OnTodayEventTrigger), ScheduledGameEvent); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public void OnEventFinished(GameEventEntityModel GameEvent, bool Success) { Invoke(nameof(OnEventFinished), GameEvent, Success); }
        public void OnEventEnd(GameEventEntityModel GameEvent) { Invoke(nameof(OnEventEnd), GameEvent); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public void Init() { Invoke(nameof(Init)); }
        public Array<GameEventEntityModel> GetOnGoingEvents() { return Invoke<Array<GameEventEntityModel>>(nameof(GetOnGoingEvents)); }
        public GameEventEntityModel GetOnGoingEventById(Object EntityId) { return Invoke<GameEventEntityModel>(nameof(GetOnGoingEventById), EntityId); }
    }
    public class TOMLevelScriptActor : BifrostLevelScriptActor
    {
        public TOMLevelScriptActor(ulong addr) : base(addr) { }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void ReceiveLocalPlayerReady(TOMPlayerState InPlayerState) { Invoke(nameof(ReceiveLocalPlayerReady), InPlayerState); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
        public void OnLocalPlayerReady(OnPlayerReadyEventArgs Args) { Invoke(nameof(OnLocalPlayerReady), Args); }
    }
    public class GameLevelScriptActor : TOMLevelScriptActor
    {
        public GameLevelScriptActor(ulong addr) : base(addr) { }
        public Object MaterialManagerBPClass { get { return this[nameof(MaterialManagerBPClass)]; } set { this[nameof(MaterialManagerBPClass)] = value; } }
        public Object TickManagerBPClass { get { return this[nameof(TickManagerBPClass)]; } set { this[nameof(TickManagerBPClass)] = value; } }
        public Object ConstructionManagerBPClass { get { return this[nameof(ConstructionManagerBPClass)]; } set { this[nameof(ConstructionManagerBPClass)] = value; } }
        public Object BushMovementManagerBPClass { get { return this[nameof(BushMovementManagerBPClass)]; } set { this[nameof(BushMovementManagerBPClass)] = value; } }
        public Object PostProcessManagerBPClass { get { return this[nameof(PostProcessManagerBPClass)]; } set { this[nameof(PostProcessManagerBPClass)] = value; } }
        public Object CharacterFloatingUIManagerClass { get { return this[nameof(CharacterFloatingUIManagerClass)]; } set { this[nameof(CharacterFloatingUIManagerClass)] = value; } }
        public void InitializeGameManagers() { Invoke(nameof(InitializeGameManagers)); }
    }
    public class GameLoadingLevelScriptActor : BifrostLevelScriptActor
    {
        public GameLoadingLevelScriptActor(ulong addr) : base(addr) { }
    }
    public class GameOverLevelScriptActor : TOMLevelScriptActor
    {
        public GameOverLevelScriptActor(ulong addr) : base(addr) { }
    }
    public class GameSessionData : Object
    {
        public GameSessionData(ulong addr) : base(addr) { }
        public bool bIsHost { get { return this[nameof(bIsHost)].Flag; } set { this[nameof(bIsHost)].Flag = value; } }
        public bool bIsLocal { get { return this[nameof(bIsLocal)].Flag; } set { this[nameof(bIsLocal)].Flag = value; } }
        public bool bIsTutorial { get { return this[nameof(bIsTutorial)].Flag; } set { this[nameof(bIsTutorial)].Flag = value; } }
        public Object WorldID { get { return this[nameof(WorldID)]; } set { this[nameof(WorldID)] = value; } }
        public int WorldSeed { get { return this[nameof(WorldSeed)].GetValue<int>(); } set { this[nameof(WorldSeed)].SetValue<int>(value); } }
        public int MapSizeIndex { get { return this[nameof(MapSizeIndex)].GetValue<int>(); } set { this[nameof(MapSizeIndex)].SetValue<int>(value); } }
        public DataObject SaveGame { get { return this[nameof(SaveGame)].As<DataObject>(); } set { this["SaveGame"] = value; } }
        public void SetWorldSeed(int InWorldSeed) { Invoke(nameof(SetWorldSeed), InWorldSeed); }
        public void SetWorldId(Object InWorldId) { Invoke(nameof(SetWorldId), InWorldId); }
        public void SetMapSizeIndex(int Index) { Invoke(nameof(SetMapSizeIndex), Index); }
        public int GetWorldSeed() { return Invoke<int>(nameof(GetWorldSeed)); }
        public Object GetWorldId() { return Invoke<Object>(nameof(GetWorldId)); }
        public int GetMapSizeIndex() { return Invoke<int>(nameof(GetMapSizeIndex)); }
    }
    public class GameUtility : Object
    {
        public GameUtility(ulong addr) : base(addr) { }
        public void FilterWeaponMunitionSlots(WeaponDataModel WeaponDataModel, Array<ContainerSlotEntityModel> Slots) { Invoke(nameof(FilterWeaponMunitionSlots), WeaponDataModel, Slots); }
        public bool CraftingRecipeIsUnlocked(Object WorldContextObject, CraftingRecipeDataModel CraftingRecipeModel) { return Invoke<bool>(nameof(CraftingRecipeIsUnlocked), WorldContextObject, CraftingRecipeModel); }
    }
    public class GenerationAndStreamingHelper : Object
    {
        public GenerationAndStreamingHelper(ulong addr) : base(addr) { }
        public void InitManagers(int Seed, GenerationManager GenerationManager, StreamingManager StreamingManager, EGameMode CurrentGameMode, int MapSizeIndex) { Invoke(nameof(InitManagers), Seed, GenerationManager, StreamingManager, CurrentGameMode, MapSizeIndex); }
    }
    public class GenerationChunkActor : TOMActor
    {
        public GenerationChunkActor(ulong addr) : base(addr) { }
    }
    public class GenerationChunkBuilder : Object
    {
        public GenerationChunkBuilder(ulong addr) : base(addr) { }
        public GenerationManager GenerationManager { get { return this[nameof(GenerationManager)].As<GenerationManager>(); } set { this["GenerationManager"] = value; } }
    }
    public class GenerationChunkInterface : Interface
    {
        public GenerationChunkInterface(ulong addr) : base(addr) { }
    }
    public class GenerationManager : Object
    {
        public GenerationManager(ulong addr) : base(addr) { }
        public TOMWorldData World { get { return this[nameof(World)].As<TOMWorldData>(); } set { this["World"] = value; } }
        public DataTable BiomeConfigTable { get { return this[nameof(BiomeConfigTable)].As<DataTable>(); } set { this["BiomeConfigTable"] = value; } }
        public Object BiomeConfigs { get { return this[nameof(BiomeConfigs)]; } set { this[nameof(BiomeConfigs)] = value; } }
        public GenerationConfig GenerationConfig { get { return this[nameof(GenerationConfig)].As<GenerationConfig>(); } set { this["GenerationConfig"] = value; } }
        public Object Chunks { get { return this[nameof(Chunks)]; } set { this[nameof(Chunks)] = value; } }
        public Array<POIData> POIsData { get { return new Array<POIData>(this[nameof(POIsData)].Address); } }
        public Array<Object> WorldSteps { get { return new Array<Object>(this[nameof(WorldSteps)].Address); } }
        public Array<Object> ChunkSteps { get { return new Array<Object>(this[nameof(ChunkSteps)].Address); } }
        public ChunkGenData ChunkGen { get { return this[nameof(ChunkGen)].As<ChunkGenData>(); } set { this["ChunkGen"] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public Object GeoPropFactoryClass { get { return this[nameof(GeoPropFactoryClass)]; } set { this[nameof(GeoPropFactoryClass)] = value; } }
        public ChunkManager ChunksManager { get { return this[nameof(ChunksManager)].As<ChunkManager>(); } set { this["ChunksManager"] = value; } }
        public ModuleManager ModuleManager { get { return this[nameof(ModuleManager)].As<ModuleManager>(); } set { this["ModuleManager"] = value; } }
        public GeoPropFactory GeoPropFactory { get { return this[nameof(GeoPropFactory)].As<GeoPropFactory>(); } set { this["GeoPropFactory"] = value; } }
        public IntPoint WorldPositionToChunkPosition(Vector2D WorldPosition) { return Invoke<IntPoint>(nameof(WorldPositionToChunkPosition), WorldPosition); }
        public int GetWorldSizeInUnit() { return Invoke<int>(nameof(GetWorldSizeInUnit)); }
        public Vector GetVillageShrinePos() { return Invoke<Vector>(nameof(GetVillageShrinePos)); }
        public Vector2D GetVillagePos() { return Invoke<Vector2D>(nameof(GetVillagePos)); }
        public int GetVillageHeight() { return Invoke<int>(nameof(GetVillageHeight)); }
        public IntPoint GetVillageChunkPosition() { return Invoke<IntPoint>(nameof(GetVillageChunkPosition)); }
        public Vector GetSpawnPos() { return Invoke<Vector>(nameof(GetSpawnPos)); }
        public int GetSeed() { return Invoke<int>(nameof(GetSeed)); }
        public Vector GetRespawnPos() { return Invoke<Vector>(nameof(GetRespawnPos)); }
        public Array<POIData> GetPOIsData() { return Invoke<Array<POIData>>(nameof(GetPOIsData)); }
        public Vector GetNextShrineOffset(Vector DestinationShrinePosition) { return Invoke<Vector>(nameof(GetNextShrineOffset), DestinationShrinePosition); }
        public ModuleData GetModuleData(int ModuleInstanceId) { return Invoke<ModuleData>(nameof(GetModuleData), ModuleInstanceId); }
        public int GetChunkSize() { return Invoke<int>(nameof(GetChunkSize)); }
        public int GetChunkLineLength() { return Invoke<int>(nameof(GetChunkLineLength)); }
        public Object GetChunkIdFromWorldPosition(Vector WorldPosition) { return Invoke<Object>(nameof(GetChunkIdFromWorldPosition), WorldPosition); }
        public BiomeConfig GetBiomeConfig(int InBiomeId) { return Invoke<BiomeConfig>(nameof(GetBiomeConfig), InBiomeId); }
    }
    public class GenerationProvider : Object
    {
        public GenerationProvider(ulong addr) : base(addr) { }
    }
    public class GenerationRNG : Object
    {
        public GenerationRNG(ulong addr) : base(addr) { }
        public RandomStream RNG { get { return this[nameof(RNG)].As<RandomStream>(); } set { this["RNG"] = value; } }
    }
    public class GenericSettingsSave : SaveGame
    {
        public GenericSettingsSave(ulong addr) : base(addr) { }
        public Object OnKeyMappingChanged { get { return this[nameof(OnKeyMappingChanged)]; } set { this[nameof(OnKeyMappingChanged)] = value; } }
        public Object OnIsDisplayingNameChanged { get { return this[nameof(OnIsDisplayingNameChanged)]; } set { this[nameof(OnIsDisplayingNameChanged)] = value; } }
        public Object OnDisplayYggdrasilHPChanged { get { return this[nameof(OnDisplayYggdrasilHPChanged)]; } set { this[nameof(OnDisplayYggdrasilHPChanged)] = value; } }
        public Object OnDisplayHUDChanged { get { return this[nameof(OnDisplayHUDChanged)]; } set { this[nameof(OnDisplayHUDChanged)] = value; } }
        public Object OnAimAssistChanged { get { return this[nameof(OnAimAssistChanged)]; } set { this[nameof(OnAimAssistChanged)] = value; } }
        public Object OnPointerArrowChanged { get { return this[nameof(OnPointerArrowChanged)]; } set { this[nameof(OnPointerArrowChanged)] = value; } }
        public Object OnDisplayHPCountChanged { get { return this[nameof(OnDisplayHPCountChanged)]; } set { this[nameof(OnDisplayHPCountChanged)] = value; } }
        public Object SaveSlotName { get { return this[nameof(SaveSlotName)]; } set { this[nameof(SaveSlotName)] = value; } }
        public uint UserIndex { get { return this[nameof(UserIndex)].GetValue<uint>(); } set { this[nameof(UserIndex)].SetValue<uint>(value); } }
        public bool bIsVibrationOn { get { return this[nameof(bIsVibrationOn)].Flag; } set { this[nameof(bIsVibrationOn)].Flag = value; } }
        public bool bIsDisplayingName { get { return this[nameof(bIsDisplayingName)].Flag; } set { this[nameof(bIsDisplayingName)].Flag = value; } }
        public bool bDisplayYggdrasilHP { get { return this[nameof(bDisplayYggdrasilHP)].Flag; } set { this[nameof(bDisplayYggdrasilHP)].Flag = value; } }
        public bool bDisplayHPCount { get { return this[nameof(bDisplayHPCount)].Flag; } set { this[nameof(bDisplayHPCount)].Flag = value; } }
        public bool bAimAssist { get { return this[nameof(bAimAssist)].Flag; } set { this[nameof(bAimAssist)].Flag = value; } }
        public bool bPointerArrow { get { return this[nameof(bPointerArrow)].Flag; } set { this[nameof(bPointerArrow)].Flag = value; } }
        public int MusicVolume { get { return this[nameof(MusicVolume)].GetValue<int>(); } set { this[nameof(MusicVolume)].SetValue<int>(value); } }
        public int SFXVolume { get { return this[nameof(SFXVolume)].GetValue<int>(); } set { this[nameof(SFXVolume)].SetValue<int>(value); } }
        public Object Language { get { return this[nameof(Language)]; } set { this[nameof(Language)] = value; } }
        public bool bDisplayHUD { get { return this[nameof(bDisplayHUD)].Flag; } set { this[nameof(bDisplayHUD)].Flag = value; } }
        public Object KeyboardActionMappings { get { return this[nameof(KeyboardActionMappings)]; } set { this[nameof(KeyboardActionMappings)] = value; } }
        public Object GamepadActionMappings { get { return this[nameof(GamepadActionMappings)]; } set { this[nameof(GamepadActionMappings)] = value; } }
        public Array<InputAxisKeyMapping> KeyboardAxisMappings { get { return new Array<InputAxisKeyMapping>(this[nameof(KeyboardAxisMappings)].Address); } }
        public Object EngineKeyboardActionMappings { get { return this[nameof(EngineKeyboardActionMappings)]; } set { this[nameof(EngineKeyboardActionMappings)] = value; } }
        public Object EngineGamepadActionMappings { get { return this[nameof(EngineGamepadActionMappings)]; } set { this[nameof(EngineGamepadActionMappings)] = value; } }
        public Array<InputAxisKeyMapping> EngineKeyboardAxisMappings { get { return new Array<InputAxisKeyMapping>(this[nameof(EngineKeyboardAxisMappings)].Address); } }
        public Object WorldsItemsSeen { get { return this[nameof(WorldsItemsSeen)]; } set { this[nameof(WorldsItemsSeen)] = value; } }
        public void SaveSettings(GenericSettingsSave Settings) { Invoke(nameof(SaveSettings), Settings); }
        public void ResetUserActionMappings() { Invoke(nameof(ResetUserActionMappings)); }
        public void RemoveSeenItem(Object WorldID, Object ItemId, bool bSave) { Invoke(nameof(RemoveSeenItem), WorldID, ItemId, bSave); }
        public void RefreshValueFromConfig() { Invoke(nameof(RefreshValueFromConfig)); }
        public void MuteAudio() { Invoke(nameof(MuteAudio)); }
        public void LoadUserActionMappings() { Invoke(nameof(LoadUserActionMappings)); }
        public GenericSettingsSave LoadSettings() { return Invoke<GenericSettingsSave>(nameof(LoadSettings)); }
        public Array<Object> GetSeenItemsForWorld(Object WorldID) { return Invoke<Array<Object>>(nameof(GetSeenItemsForWorld), WorldID); }
        public void ClearWorldData(Object WorldID) { Invoke(nameof(ClearWorldData), WorldID); }
        public void ApplySettings() { Invoke(nameof(ApplySettings)); }
        public void ApplyAudioSettings() { Invoke(nameof(ApplyAudioSettings)); }
        public void AddSeenItem(Object WorldID, Object ItemId, bool bSave) { Invoke(nameof(AddSeenItem), WorldID, ItemId, bSave); }
        public void AddOrReplaceUserAxisMappings(InputAxisKeyMapping Mapping) { Invoke(nameof(AddOrReplaceUserAxisMappings), Mapping); }
        public void AddOrReplaceUserActionMappings(InputActionKeyMapping Mapping) { Invoke(nameof(AddOrReplaceUserActionMappings), Mapping); }
    }
    public class GeometryChunkActor : GenerationChunkActor
    {
        public GeometryChunkActor(ulong addr) : base(addr) { }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public ProceduralMeshComponent GlobalCollisionMesh { get { return this[nameof(GlobalCollisionMesh)].As<ProceduralMeshComponent>(); } set { this["GlobalCollisionMesh"] = value; } }
        public ProceduralMeshComponent WaterCollisionMesh { get { return this[nameof(WaterCollisionMesh)].As<ProceduralMeshComponent>(); } set { this["WaterCollisionMesh"] = value; } }
        public ProceduralMeshComponent NoConstructionCollisionMesh { get { return this[nameof(NoConstructionCollisionMesh)].As<ProceduralMeshComponent>(); } set { this["NoConstructionCollisionMesh"] = value; } }
        public ProceduralMeshComponent RiverCollisionMesh { get { return this[nameof(RiverCollisionMesh)].As<ProceduralMeshComponent>(); } set { this["RiverCollisionMesh"] = value; } }
        public OnWaterHitComponent OnWaterHitComponent { get { return this[nameof(OnWaterHitComponent)].As<OnWaterHitComponent>(); } set { this["OnWaterHitComponent"] = value; } }
        public Array<Actor> TerrainProps { get { return new Array<Actor>(this[nameof(TerrainProps)].Address); } }
        public IntPoint Coordinates { get { return this[nameof(Coordinates)].As<IntPoint>(); } set { this["Coordinates"] = value; } }
        public void OnRep_Coordinates() { Invoke(nameof(OnRep_Coordinates)); }
    }
    public class GeoPropFactory : Object
    {
        public GeoPropFactory(ulong addr) : base(addr) { }
        public int WaterfallStencilValue { get { return this[nameof(WaterfallStencilValue)].GetValue<int>(); } set { this[nameof(WaterfallStencilValue)].SetValue<int>(value); } }
        public int WaterfallMaxHeight { get { return this[nameof(WaterfallMaxHeight)].GetValue<int>(); } set { this[nameof(WaterfallMaxHeight)].SetValue<int>(value); } }
        public Object WaterfallsInner { get { return this[nameof(WaterfallsInner)]; } set { this[nameof(WaterfallsInner)] = value; } }
        public Object SplashesInner { get { return this[nameof(SplashesInner)]; } set { this[nameof(SplashesInner)] = value; } }
        public Object WaterfallsInnerLeft { get { return this[nameof(WaterfallsInnerLeft)]; } set { this[nameof(WaterfallsInnerLeft)] = value; } }
        public Object SplashesInnerLeft { get { return this[nameof(SplashesInnerLeft)]; } set { this[nameof(SplashesInnerLeft)] = value; } }
        public Object WaterfallsInnerRight { get { return this[nameof(WaterfallsInnerRight)]; } set { this[nameof(WaterfallsInnerRight)] = value; } }
        public Object SplashesInnerRight { get { return this[nameof(SplashesInnerRight)]; } set { this[nameof(SplashesInnerRight)] = value; } }
        public Object WaterfallsInnerLeftRight { get { return this[nameof(WaterfallsInnerLeftRight)]; } set { this[nameof(WaterfallsInnerLeftRight)] = value; } }
        public Object SplashesInnerLeftRight { get { return this[nameof(SplashesInnerLeftRight)]; } set { this[nameof(SplashesInnerLeftRight)] = value; } }
        public Object WaterfallsOuter { get { return this[nameof(WaterfallsOuter)]; } set { this[nameof(WaterfallsOuter)] = value; } }
        public Object SplashesOuter { get { return this[nameof(SplashesOuter)]; } set { this[nameof(SplashesOuter)] = value; } }
        public Object WaterfallsStraight { get { return this[nameof(WaterfallsStraight)]; } set { this[nameof(WaterfallsStraight)] = value; } }
        public Object SplashesStraight { get { return this[nameof(SplashesStraight)]; } set { this[nameof(SplashesStraight)] = value; } }
        public Object WaterfallsStraightLeft { get { return this[nameof(WaterfallsStraightLeft)]; } set { this[nameof(WaterfallsStraightLeft)] = value; } }
        public Object SplashesStraightLeft { get { return this[nameof(SplashesStraightLeft)]; } set { this[nameof(SplashesStraightLeft)] = value; } }
        public Object WaterfallsStraightRight { get { return this[nameof(WaterfallsStraightRight)]; } set { this[nameof(WaterfallsStraightRight)] = value; } }
        public Object SplashesStraightRight { get { return this[nameof(SplashesStraightRight)]; } set { this[nameof(SplashesStraightRight)] = value; } }
        public Object Shallows { get { return this[nameof(Shallows)]; } set { this[nameof(Shallows)] = value; } }
    }
    public class GiantAIControllerBase : AIController
    {
        public GiantAIControllerBase(ulong addr) : base(addr) { }
        public Vector TargetLocation { get { return this[nameof(TargetLocation)].As<Vector>(); } set { this["TargetLocation"] = value; } }
        public GiantCharacterBase ControlledCharacter { get { return this[nameof(ControlledCharacter)].As<GiantCharacterBase>(); } set { this["ControlledCharacter"] = value; } }
        public void StopIdle() { Invoke(nameof(StopIdle)); }
        public void StopAttack() { Invoke(nameof(StopAttack)); }
        public void StartIdle() { Invoke(nameof(StartIdle)); }
        public void StartAttack(int attackId, Vector AttackTargetLocation) { Invoke(nameof(StartAttack), attackId, AttackTargetLocation); }
    }
    public class GiantCharacterBase : Character
    {
        public GiantCharacterBase(ulong addr) : base(addr) { }
        public float CurrentAngle { get { return this[nameof(CurrentAngle)].GetValue<float>(); } set { this[nameof(CurrentAngle)].SetValue<float>(value); } }
        public float SegmentAngle { get { return this[nameof(SegmentAngle)].GetValue<float>(); } set { this[nameof(SegmentAngle)].SetValue<float>(value); } }
        public float WalkSpeed { get { return this[nameof(WalkSpeed)].GetValue<float>(); } set { this[nameof(WalkSpeed)].SetValue<float>(value); } }
        public bool IsInRagdoll { get { return this[nameof(IsInRagdoll)].Flag; } set { this[nameof(IsInRagdoll)].Flag = value; } }
        public bool IsOnTheGround { get { return this[nameof(IsOnTheGround)].Flag; } set { this[nameof(IsOnTheGround)].Flag = value; } }
        public int IsGettingUp { get { return this[nameof(IsGettingUp)].GetValue<int>(); } set { this[nameof(IsGettingUp)].SetValue<int>(value); } }
        public int GiantModelId { get { return this[nameof(GiantModelId)].GetValue<int>(); } set { this[nameof(GiantModelId)].SetValue<int>(value); } }
        public GiantDataModel GiantModel { get { return this[nameof(GiantModel)].As<GiantDataModel>(); } set { this["GiantModel"] = value; } }
        public Object OnGiantDeath { get { return this[nameof(OnGiantDeath)]; } set { this[nameof(OnGiantDeath)] = value; } }
        public void SetMobility(SceneComponent SceneComponent, byte Mobility) { Invoke(nameof(SetMobility), SceneComponent, Mobility); }
        public void ExecuteAttackReplicated(int attackId, Vector TargetLocation) { Invoke(nameof(ExecuteAttackReplicated), attackId, TargetLocation); }
        public void ExecuteAttack(int attackId, Vector AttackTargetLocation) { Invoke(nameof(ExecuteAttack), attackId, AttackTargetLocation); }
    }
    public class GiantManager : TOMActor
    {
        public GiantManager(ulong addr) : base(addr) { }
        public TOMCharacter CurrentGiantActor { get { return this[nameof(CurrentGiantActor)].As<TOMCharacter>(); } set { this["CurrentGiantActor"] = value; } }
        public int NoPlayerRange { get { return this[nameof(NoPlayerRange)].GetValue<int>(); } set { this[nameof(NoPlayerRange)].SetValue<int>(value); } }
        public bool bHasBeenDiscovered { get { return this[nameof(bHasBeenDiscovered)].Flag; } set { this[nameof(bHasBeenDiscovered)].Flag = value; } }
        public Vector LastKnownPosition { get { return this[nameof(LastKnownPosition)].As<Vector>(); } set { this["LastKnownPosition"] = value; } }
        public bool bIsGiantSpotted { get { return this[nameof(bIsGiantSpotted)].Flag; } set { this[nameof(bIsGiantSpotted)].Flag = value; } }
        public Vector GiantLocation { get { return this[nameof(GiantLocation)].As<Vector>(); } set { this["GiantLocation"] = value; } }
        public EGiantIconStatus GiantIconStatus { get { return (EGiantIconStatus)this[nameof(GiantIconStatus)].GetValue<int>(); } set { this[nameof(GiantIconStatus)].SetValue<int>((int)value); } }
        public bool bEnterVillage { get { return this[nameof(bEnterVillage)].Flag; } set { this[nameof(bEnterVillage)].Flag = value; } }
        public bool bCloseToVillage { get { return this[nameof(bCloseToVillage)].Flag; } set { this[nameof(bCloseToVillage)].Flag = value; } }
        public bool bIsGiantSpawned { get { return this[nameof(bIsGiantSpawned)].Flag; } set { this[nameof(bIsGiantSpawned)].Flag = value; } }
        public bool bIsGiantDead { get { return this[nameof(bIsGiantDead)].Flag; } set { this[nameof(bIsGiantDead)].Flag = value; } }
        public int CurrentGiantDataId { get { return this[nameof(CurrentGiantDataId)].GetValue<int>(); } set { this[nameof(CurrentGiantDataId)].SetValue<int>(value); } }
        public Object OnGiantHiddenOnMap { get { return this[nameof(OnGiantHiddenOnMap)]; } set { this[nameof(OnGiantHiddenOnMap)] = value; } }
        public Object OnGiantShownOnMap { get { return this[nameof(OnGiantShownOnMap)]; } set { this[nameof(OnGiantShownOnMap)] = value; } }
        public Object OnGiantGreyedOnMap { get { return this[nameof(OnGiantGreyedOnMap)]; } set { this[nameof(OnGiantGreyedOnMap)] = value; } }
        public Object OnGiantCloseToVillage { get { return this[nameof(OnGiantCloseToVillage)]; } set { this[nameof(OnGiantCloseToVillage)] = value; } }
        public Object OnGiantEnterVillage { get { return this[nameof(OnGiantEnterVillage)]; } set { this[nameof(OnGiantEnterVillage)] = value; } }
        public Object OnGiantSpawn { get { return this[nameof(OnGiantSpawn)]; } set { this[nameof(OnGiantSpawn)] = value; } }
        public Object OnGiantDeath { get { return this[nameof(OnGiantDeath)]; } set { this[nameof(OnGiantDeath)] = value; } }
        public float DistanceToShowOnMapSquared { get { return this[nameof(DistanceToShowOnMapSquared)].GetValue<float>(); } set { this[nameof(DistanceToShowOnMapSquared)].SetValue<float>(value); } }
        public Object LastAttackerUserId { get { return this[nameof(LastAttackerUserId)]; } set { this[nameof(LastAttackerUserId)] = value; } }
        public WorldGiantEntityModel CurrentWorldGiant { get { return this[nameof(CurrentWorldGiant)].As<WorldGiantEntityModel>(); } set { this["CurrentWorldGiant"] = value; } }
        public GenerationManager GenerationManager { get { return this[nameof(GenerationManager)].As<GenerationManager>(); } set { this["GenerationManager"] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
        public Array<Vector> CurrentPath { get { return new Array<Vector>(this[nameof(CurrentPath)].Address); } }
        public Array<IntPoint> CurrentZonePath { get { return new Array<IntPoint>(this[nameof(CurrentZonePath)].Address); } }
        public void UpdateGiantStatus() { Invoke(nameof(UpdateGiantStatus)); }
        public void SpawnCurrentGiant(bool bFromSave) { Invoke(nameof(SpawnCurrentGiant), bFromSave); }
        public void SetCurrentGiantDataId(int ID) { Invoke(nameof(SetCurrentGiantDataId), ID); }
        public int RewardXPForKill() { return Invoke<int>(nameof(RewardXPForKill)); }
        public void OnRep_IsGiantSpawned() { Invoke(nameof(OnRep_IsGiantSpawned)); }
        public void OnRep_IsGiantDead() { Invoke(nameof(OnRep_IsGiantDead)); }
        public void OnRep_GiantIconStatus() { Invoke(nameof(OnRep_GiantIconStatus)); }
        public void OnRep_EnterVillage() { Invoke(nameof(OnRep_EnterVillage)); }
        public void OnRep_CloseToVillage() { Invoke(nameof(OnRep_CloseToVillage)); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public void OnGiantDeathUpdateAchievement(Object LastAttackerId, EEquipmentElement GiantElement, int GiantKillCount) { Invoke(nameof(OnGiantDeathUpdateAchievement), LastAttackerId, GiantElement, GiantKillCount); }
        public void OnEnterVillage(TOMCharacter Character) { Invoke(nameof(OnEnterVillage), Character); }
        public void OnCurrentGiantDeathMulticast(TOMCharacter DeadGiantActor) { Invoke(nameof(OnCurrentGiantDeathMulticast), DeadGiantActor); }
        public void OnCurrentGiantDeath(int NextGiantId) { Invoke(nameof(OnCurrentGiantDeath), NextGiantId); }
        public bool LoadNextPath() { return Invoke<bool>(nameof(LoadNextPath)); }
        public void LoadNextGiant(int GiantId) { Invoke(nameof(LoadNextGiant), GiantId); }
        public void LoadGiant() { Invoke(nameof(LoadGiant)); }
        public bool IsInLastArea() { return Invoke<bool>(nameof(IsInLastArea)); }
        public bool IsAtEndOfPath() { return Invoke<bool>(nameof(IsAtEndOfPath)); }
        public Vector GetSpawnLocation() { return Invoke<Vector>(nameof(GetSpawnLocation)); }
        public float GetNoPlayerRange() { return Invoke<float>(nameof(GetNoPlayerRange)); }
        public Vector GetNextTargetLocation() { return Invoke<Vector>(nameof(GetNextTargetLocation)); }
        public float GetDefaultSpawnZ() { return Invoke<float>(nameof(GetDefaultSpawnZ)); }
        public Vector GetCurrentTargetLocation() { return Invoke<Vector>(nameof(GetCurrentTargetLocation)); }
    }
    public class GiantMapIconWidget : UserWidget
    {
        public GiantMapIconWidget(ulong addr) : base(addr) { }
        public Texture2D ShownIcon { get { return this[nameof(ShownIcon)].As<Texture2D>(); } set { this["ShownIcon"] = value; } }
        public Texture2D GreyedIcon { get { return this[nameof(GreyedIcon)].As<Texture2D>(); } set { this["GreyedIcon"] = value; } }
        public Vector2D IconSize { get { return this[nameof(IconSize)].As<Vector2D>(); } set { this["IconSize"] = value; } }
        public GiantManager GiantManager { get { return this[nameof(GiantManager)].As<GiantManager>(); } set { this["GiantManager"] = value; } }
        public Image IconWidget { get { return this[nameof(IconWidget)].As<Image>(); } set { this["IconWidget"] = value; } }
    }
    public class GiantSpawnQuestBehavior : QuestBehaviorBase
    {
        public GiantSpawnQuestBehavior(ulong addr) : base(addr) { }
        public void OnGiantSpawn() { Invoke(nameof(OnGiantSpawn)); }
    }
    public class GoldenHornAltar : ReplicatedPropBase
    {
        public GoldenHornAltar(ulong addr) : base(addr) { }
        public float LootDropPositionRadius { get { return this[nameof(LootDropPositionRadius)].GetValue<float>(); } set { this[nameof(LootDropPositionRadius)].SetValue<float>(value); } }
        public Object UnavailableAlert { get { return this[nameof(UnavailableAlert)]; } set { this[nameof(UnavailableAlert)] = value; } }
        public Object CurrencyAlert { get { return this[nameof(CurrencyAlert)]; } set { this[nameof(CurrencyAlert)] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public SceneComponent LootDropPoint { get { return this[nameof(LootDropPoint)].As<SceneComponent>(); } set { this["LootDropPoint"] = value; } }
        public SceneComponent ParticleSystemRoot { get { return this[nameof(ParticleSystemRoot)].As<SceneComponent>(); } set { this["ParticleSystemRoot"] = value; } }
        public NiagaraSystem NiagaraParticleSystem { get { return this[nameof(NiagaraParticleSystem)].As<NiagaraSystem>(); } set { this["NiagaraParticleSystem"] = value; } }
        public EventRequest Request { get { return this[nameof(Request)].As<EventRequest>(); } set { this["Request"] = value; } }
        public bool HasPendingRequest { get { return this[nameof(HasPendingRequest)].Flag; } set { this[nameof(HasPendingRequest)].Flag = value; } }
        public NiagaraComponent NiagaraComponent { get { return this[nameof(NiagaraComponent)].As<NiagaraComponent>(); } set { this["NiagaraComponent"] = value; } }
        public TimerHandle RequestTimeoutTimer { get { return this[nameof(RequestTimeoutTimer)].As<TimerHandle>(); } set { this["RequestTimeoutTimer"] = value; } }
        public void UseAltar(TOMCharacter CharacterInstigator) { Invoke(nameof(UseAltar), CharacterInstigator); }
        public void OnSuccess(ServerResponse Response) { Invoke(nameof(OnSuccess), Response); }
        public void OnRequestTimeout() { Invoke(nameof(OnRequestTimeout)); }
        public void OnRep_PendingRequestCount() { Invoke(nameof(OnRep_PendingRequestCount)); }
        public void OnError(ServerResponse Response) { Invoke(nameof(OnError), Response); }
        public int GetCurrentAltarCostForLocalUser(Object WorldContext) { return Invoke<int>(nameof(GetCurrentAltarCostForLocalUser), WorldContext); }
        public bool CanUserLocalUseAltarForLocalUser(Object WorldContext) { return Invoke<bool>(nameof(CanUserLocalUseAltarForLocalUser), WorldContext); }
    }
    public class HazardBarrelBase : HazardBase
    {
        public HazardBarrelBase(ulong addr) : base(addr) { }
        public Vector ParticleSystemOffset { get { return this[nameof(ParticleSystemOffset)].As<Vector>(); } set { this["ParticleSystemOffset"] = value; } }
        public float OnTriggerImpactForce { get { return this[nameof(OnTriggerImpactForce)].GetValue<float>(); } set { this[nameof(OnTriggerImpactForce)].SetValue<float>(value); } }
        public Vector OnTriggerImpactRelativeLocation { get { return this[nameof(OnTriggerImpactRelativeLocation)].As<Vector>(); } set { this["OnTriggerImpactRelativeLocation"] = value; } }
        public CapsuleComponent CapsuleComponent { get { return this[nameof(CapsuleComponent)].As<CapsuleComponent>(); } set { this["CapsuleComponent"] = value; } }
        public SkeletalMeshComponent SkeletonMeshComponent { get { return this[nameof(SkeletonMeshComponent)].As<SkeletalMeshComponent>(); } set { this["SkeletonMeshComponent"] = value; } }
        public ParticleSystem TriggeredStateParticle { get { return this[nameof(TriggeredStateParticle)].As<ParticleSystem>(); } set { this["TriggeredStateParticle"] = value; } }
        public ParticleSystem NormalStateParticle { get { return this[nameof(NormalStateParticle)].As<ParticleSystem>(); } set { this["NormalStateParticle"] = value; } }
        public Object MaterialParameterName { get { return this[nameof(MaterialParameterName)]; } set { this[nameof(MaterialParameterName)] = value; } }
        public LinearColor MaterialColorWhileTriggered { get { return this[nameof(MaterialColorWhileTriggered)].As<LinearColor>(); } set { this["MaterialColorWhileTriggered"] = value; } }
        public LinearColor MaterialNormalColor { get { return this[nameof(MaterialNormalColor)].As<LinearColor>(); } set { this["MaterialNormalColor"] = value; } }
        public Object SFXTriggerName { get { return this[nameof(SFXTriggerName)]; } set { this[nameof(SFXTriggerName)] = value; } }
        public AnimationAsset TriggeredAnim { get { return this[nameof(TriggeredAnim)].As<AnimationAsset>(); } set { this["TriggeredAnim"] = value; } }
        public Vector CapsuleRelativePosition { get { return this[nameof(CapsuleRelativePosition)].As<Vector>(); } set { this["CapsuleRelativePosition"] = value; } }
        public bool bVisible { get { return this[nameof(bVisible)].Flag; } set { this[nameof(bVisible)].Flag = value; } }
        public bool bReplicatedTriggered { get { return this[nameof(bReplicatedTriggered)].Flag; } set { this[nameof(bReplicatedTriggered)].Flag = value; } }
        public MaterialInstanceDynamic DynamicMaterial { get { return this[nameof(DynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["DynamicMaterial"] = value; } }
        public ParticleSystemComponent CurrentParticles { get { return this[nameof(CurrentParticles)].As<ParticleSystemComponent>(); } set { this["CurrentParticles"] = value; } }
        public void OnRep_bVisible() { Invoke(nameof(OnRep_bVisible)); }
        public void OnRep_bReplicatedTriggered() { Invoke(nameof(OnRep_bReplicatedTriggered)); }
        public void InitMulticast() { Invoke(nameof(InitMulticast)); }
        public void ApplyImpulse(Vector Direction) { Invoke(nameof(ApplyImpulse), Direction); }
    }
    public class HazardEntityModel : EntityModelBase
    {
        public HazardEntityModel(ulong addr) : base(addr) { }
        public ERespawnMode RespawnMode { get { return (ERespawnMode)this[nameof(RespawnMode)].GetValue<int>(); } set { this[nameof(RespawnMode)].SetValue<int>((int)value); } }
        public EPOIType POIType { get { return (EPOIType)this[nameof(POIType)].GetValue<int>(); } set { this[nameof(POIType)].SetValue<int>((int)value); } }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public HazardBase HazardActor { get { return this[nameof(HazardActor)].As<HazardBase>(); } set { this["HazardActor"] = value; } }
        public HazardVO ToVO() { return Invoke<HazardVO>(nameof(ToVO)); }
        public void OnContainerChanged(EEntityActionType ActionType, Object EntityId, Object Context) { Invoke(nameof(OnContainerChanged), ActionType, EntityId, Context); }
        public float GetScale() { return Invoke<float>(nameof(GetScale)); }
        public float GetRotationYaw() { return Invoke<float>(nameof(GetRotationYaw)); }
        public ERespawnMode GetRespawnMode() { return Invoke<ERespawnMode>(nameof(GetRespawnMode)); }
        public HazardEntityModel GetOrCreateHazardEntityModel(Object Outer, Object EntityId, int HazardDataId, Vector Scale, Vector Location, Rotator Rotation, ERespawnMode RespawnMode, EPOIType POIType, EAdjustmentMethod AdjustmentMethod, Object PreExistingWorldContainerInstanceId) { return Invoke<HazardEntityModel>(nameof(GetOrCreateHazardEntityModel), Outer, EntityId, HazardDataId, Scale, Location, Rotation, RespawnMode, POIType, AdjustmentMethod, PreExistingWorldContainerInstanceId); }
        public Vector GetLocation() { return Invoke<Vector>(nameof(GetLocation)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public HazardDataModel GetHazardData() { return Invoke<HazardDataModel>(nameof(GetHazardData)); }
        public HazardBase GetHazardActor() { return Invoke<HazardBase>(nameof(GetHazardActor)); }
        public ContainerEntityModel GetContainer() { return Invoke<ContainerEntityModel>(nameof(GetContainer)); }
        public EAdjustmentMethod GetAdjustmentMethod() { return Invoke<EAdjustmentMethod>(nameof(GetAdjustmentMethod)); }
    }
    public class HazardLayout : Object
    {
        public HazardLayout(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Array<HazardLayoutElement> Elements { get { return new Array<HazardLayoutElement>(this[nameof(Elements)].Address); } }
        public Array<CreatureLayoutElement> Creatures { get { return new Array<CreatureLayoutElement>(this[nameof(Creatures)].Address); } }
    }
    public class HazardPlatformBase : DestructibleHazardBase
    {
        public HazardPlatformBase(ulong addr) : base(addr) { }
        public BoxComponent ScaffoldingCollision { get { return this[nameof(ScaffoldingCollision)].As<BoxComponent>(); } set { this["ScaffoldingCollision"] = value; } }
        public Array<Object> ScaffoldingBlueprint { get { return new Array<Object>(this[nameof(ScaffoldingBlueprint)].Address); } }
        public SceneComponent RaycastStart { get { return this[nameof(RaycastStart)].As<SceneComponent>(); } set { this["RaycastStart"] = value; } }
        public int ScaffoldSize { get { return this[nameof(ScaffoldSize)].GetValue<int>(); } set { this[nameof(ScaffoldSize)].SetValue<int>(value); } }
        public Actor ScaffoldingActor { get { return this[nameof(ScaffoldingActor)].As<Actor>(); } set { this["ScaffoldingActor"] = value; } }
        public void OnRep_ScaffoldSize() { Invoke(nameof(OnRep_ScaffoldSize)); }
        public int GetStepCountToGround() { return Invoke<int>(nameof(GetStepCountToGround)); }
        public void BuildScaffolding() { Invoke(nameof(BuildScaffolding)); }
    }
    public class HealthComponent : ActorComponent
    {
        public HealthComponent(ulong addr) : base(addr) { }
        public Object OnHealthChanged { get { return this[nameof(OnHealthChanged)]; } set { this[nameof(OnHealthChanged)] = value; } }
        public Object OnHealthRep { get { return this[nameof(OnHealthRep)]; } set { this[nameof(OnHealthRep)] = value; } }
        public Object OnEnterDownState { get { return this[nameof(OnEnterDownState)]; } set { this[nameof(OnEnterDownState)] = value; } }
        public Object OnLeaveDownState { get { return this[nameof(OnLeaveDownState)]; } set { this[nameof(OnLeaveDownState)] = value; } }
        public Object OnHealthReset { get { return this[nameof(OnHealthReset)]; } set { this[nameof(OnHealthReset)] = value; } }
        public Object OnDeath { get { return this[nameof(OnDeath)]; } set { this[nameof(OnDeath)] = value; } }
        public Object OnDelayedDeath { get { return this[nameof(OnDelayedDeath)]; } set { this[nameof(OnDelayedDeath)] = value; } }
        public bool UseDownState { get { return this[nameof(UseDownState)].Flag; } set { this[nameof(UseDownState)].Flag = value; } }
        public bool bInvicibleWhileDowned { get { return this[nameof(bInvicibleWhileDowned)].Flag; } set { this[nameof(bInvicibleWhileDowned)].Flag = value; } }
        public bool bIsMinimumHealthLimited { get { return this[nameof(bIsMinimumHealthLimited)].Flag; } set { this[nameof(bIsMinimumHealthLimited)].Flag = value; } }
        public float OriginalMaxAmount { get { return this[nameof(OriginalMaxAmount)].GetValue<float>(); } set { this[nameof(OriginalMaxAmount)].SetValue<float>(value); } }
        public float DownStateStartingAmount { get { return this[nameof(DownStateStartingAmount)].GetValue<float>(); } set { this[nameof(DownStateStartingAmount)].SetValue<float>(value); } }
        public float DownStateDecayRate { get { return this[nameof(DownStateDecayRate)].GetValue<float>(); } set { this[nameof(DownStateDecayRate)].SetValue<float>(value); } }
        public float DownStateDecayAmount { get { return this[nameof(DownStateDecayAmount)].GetValue<float>(); } set { this[nameof(DownStateDecayAmount)].SetValue<float>(value); } }
        public bool bIsBeingRevive { get { return this[nameof(bIsBeingRevive)].Flag; } set { this[nameof(bIsBeingRevive)].Flag = value; } }
        public float DelayedDeathDelay { get { return this[nameof(DelayedDeathDelay)].GetValue<float>(); } set { this[nameof(DelayedDeathDelay)].SetValue<float>(value); } }
        public bool ScaleWithGiantLevel { get { return this[nameof(ScaleWithGiantLevel)].Flag; } set { this[nameof(ScaleWithGiantLevel)].Flag = value; } }
        public HealthComponent_RepProperties HealthComponentRepProperties { get { return this[nameof(HealthComponentRepProperties)].As<HealthComponent_RepProperties>(); } set { this["HealthComponentRepProperties"] = value; } }
        public void SetDefaultHealth(float NewDefaultHealth) { Invoke(nameof(SetDefaultHealth), NewDefaultHealth); }
        public void SetCurrentHealth(float newHealth) { Invoke(nameof(SetCurrentHealth), newHealth); }
        public void ResetHealth(float Amount) { Invoke(nameof(ResetHealth), Amount); }
        public void OnRep_Properties() { Invoke(nameof(OnRep_Properties)); }
        public bool IsInDownState() { return Invoke<bool>(nameof(IsInDownState)); }
        public bool IsDead() { return Invoke<bool>(nameof(IsDead)); }
        public void HandleOnTakeDamage(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(HandleOnTakeDamage), Source, IssuedAmount, HitResult); }
        public float GetUnalteredHealth() { return Invoke<float>(nameof(GetUnalteredHealth)); }
        public float GetNormalizedHealth() { return Invoke<float>(nameof(GetNormalizedHealth)); }
        public float GetDefaultHealth() { return Invoke<float>(nameof(GetDefaultHealth)); }
        public float GetCurrentHealth() { return Invoke<float>(nameof(GetCurrentHealth)); }
        public float GetAmountAlterRatio() { return Invoke<float>(nameof(GetAmountAlterRatio)); }
        public void DelayedDeath() { Invoke(nameof(DelayedDeath)); }
        public void ChangeHealthOnClient(float newHealth, float IssuedAmount) { Invoke(nameof(ChangeHealthOnClient), newHealth, IssuedAmount); }
        public void AddAmountAlterRatio(float Ratio) { Invoke(nameof(AddAmountAlterRatio), Ratio); }
    }
    public class HealthDecayComponent : ActorComponent
    {
        public HealthDecayComponent(ulong addr) : base(addr) { }
        public float DecayRate { get { return this[nameof(DecayRate)].GetValue<float>(); } set { this[nameof(DecayRate)].SetValue<float>(value); } }
        public float DecayByTick { get { return this[nameof(DecayByTick)].GetValue<float>(); } set { this[nameof(DecayByTick)].SetValue<float>(value); } }
    }
    public class StatusComponent : ActorComponent
    {
        public StatusComponent(ulong addr) : base(addr) { }
        public TOMOffensiveComponent Source { get { return this[nameof(Source)].As<TOMOffensiveComponent>(); } set { this["Source"] = value; } }
        public AttackStatsDataModel SourceAttack { get { return this[nameof(SourceAttack)].As<AttackStatsDataModel>(); } set { this["SourceAttack"] = value; } }
        public bool bIsStatusEnding { get { return this[nameof(bIsStatusEnding)].Flag; } set { this[nameof(bIsStatusEnding)].Flag = value; } }
        public PerkDataModel PerkModel { get { return this[nameof(PerkModel)].As<PerkDataModel>(); } set { this["PerkModel"] = value; } }
        public TOMCharacter CharacterOwner { get { return this[nameof(CharacterOwner)].As<TOMCharacter>(); } set { this["CharacterOwner"] = value; } }
        public float InitialMultiplierBonus { get { return this[nameof(InitialMultiplierBonus)].GetValue<float>(); } set { this[nameof(InitialMultiplierBonus)].SetValue<float>(value); } }
        public int PerkDataId { get { return this[nameof(PerkDataId)].GetValue<int>(); } set { this[nameof(PerkDataId)].SetValue<int>(value); } }
        public bool IsStatusStarted { get { return this[nameof(IsStatusStarted)].Flag; } set { this[nameof(IsStatusStarted)].Flag = value; } }
        public int StackCount { get { return this[nameof(StackCount)].GetValue<int>(); } set { this[nameof(StackCount)].SetValue<int>(value); } }
        public void StatusStartClient() { Invoke(nameof(StatusStartClient)); }
        public void StatusEndClient() { Invoke(nameof(StatusEndClient)); }
        public void SetInitialMultiplierBonus(int InInitialMultiplierBonus) { Invoke(nameof(SetInitialMultiplierBonus), InInitialMultiplierBonus); }
        public void SetDuration(float InDuration) { Invoke(nameof(SetDuration), InDuration); }
        public void OnStatusStart() { Invoke(nameof(OnStatusStart)); }
        public void OnStatusStackChanged() { Invoke(nameof(OnStatusStackChanged)); }
        public void OnStatusEnd() { Invoke(nameof(OnStatusEnd)); }
        public void OnRep_PerkDataId() { Invoke(nameof(OnRep_PerkDataId)); }
        public void OnRep_IsStatusStarted() { Invoke(nameof(OnRep_IsStatusStarted)); }
        public void Init(TOMCharacter InCharacterOwner, PerkDataModel InPerkModel, bool bInIsPlayerSkill, int InStackCount, TOMOffensiveComponent InSource, float InInitialMultiplierBonus) { Invoke(nameof(Init), InCharacterOwner, InPerkModel, bInIsPlayerSkill, InStackCount, InSource, InInitialMultiplierBonus); }
        public int GetStackCount() { return Invoke<int>(nameof(GetStackCount)); }
        public PerkDataModel GetPerkModel() { return Invoke<PerkDataModel>(nameof(GetPerkModel)); }
        public float GetInitialMultiplierBonus() { return Invoke<float>(nameof(GetInitialMultiplierBonus)); }
        public TOMCharacter GetCharacterOwner() { return Invoke<TOMCharacter>(nameof(GetCharacterOwner)); }
    }
    public class HealthOnRunestoneStatusComponent : StatusComponent
    {
        public HealthOnRunestoneStatusComponent(ulong addr) : base(addr) { }
        public void OnUseRunestone() { Invoke(nameof(OnUseRunestone)); }
    }
    public class HoldAttackNotifyState : AnimNotifyState
    {
        public HoldAttackNotifyState(ulong addr) : base(addr) { }
    }
    public class HPBarBase : BifrostUserWidget
    {
        public HPBarBase(ulong addr) : base(addr) { }
        public float AnimSpeed { get { return this[nameof(AnimSpeed)].GetValue<float>(); } set { this[nameof(AnimSpeed)].SetValue<float>(value); } }
        public bool bHideAtMax { get { return this[nameof(bHideAtMax)].Flag; } set { this[nameof(bHideAtMax)].Flag = value; } }
        public bool bNeverHideBar { get { return this[nameof(bNeverHideBar)].Flag; } set { this[nameof(bNeverHideBar)].Flag = value; } }
        public LinearColor NormalColor { get { return this[nameof(NormalColor)].As<LinearColor>(); } set { this["NormalColor"] = value; } }
        public LinearColor DownColor { get { return this[nameof(DownColor)].As<LinearColor>(); } set { this["DownColor"] = value; } }
        public HealthComponent HealthComponent { get { return this[nameof(HealthComponent)].As<HealthComponent>(); } set { this["HealthComponent"] = value; } }
        public TextBlock NameText { get { return this[nameof(NameText)].As<TextBlock>(); } set { this["NameText"] = value; } }
        public ProgressBar ProgressBarFG { get { return this[nameof(ProgressBarFG)].As<ProgressBar>(); } set { this["ProgressBarFG"] = value; } }
        public ProgressBar ProgressBarBG { get { return this[nameof(ProgressBarBG)].As<ProgressBar>(); } set { this["ProgressBarBG"] = value; } }
        public void SetNormalColor(LinearColor InColor) { Invoke(nameof(SetNormalColor), InColor); }
        public void Init(HealthComponent InHealthComponent, Object InName) { Invoke(nameof(Init), InHealthComponent, InName); }
    }
    public class IconManager : Object
    {
        public IconManager(ulong addr) : base(addr) { }
        public Object OnPlatformControllerChanged { get { return this[nameof(OnPlatformControllerChanged)]; } set { this[nameof(OnPlatformControllerChanged)] = value; } }
        public Object InputToActionsMap { get { return this[nameof(InputToActionsMap)]; } set { this[nameof(InputToActionsMap)] = value; } }
        public EPlatformController PlatformController { get { return (EPlatformController)this[nameof(PlatformController)].GetValue<int>(); } set { this[nameof(PlatformController)].SetValue<int>((int)value); } }
        public void SetCurrentPlatformController(EPlatformController NewPlatformController) { Invoke(nameof(SetCurrentPlatformController), NewPlatformController); }
        public bool IsKeyboardController() { return Invoke<bool>(nameof(IsKeyboardController)); }
        public bool IsGamepadController() { return Invoke<bool>(nameof(IsGamepadController)); }
        public Object GetIconObjectPtr(Object InputAction, bool bIsNavigation) { return Invoke<Object>(nameof(GetIconObjectPtr), InputAction, bIsNavigation); }
        public EPlatformController GetCurrentPlatformController() { return Invoke<EPlatformController>(nameof(GetCurrentPlatformController)); }
    }
    public class InGameHud : TOMActorComponent
    {
        public InGameHud(ulong addr) : base(addr) { }
    }
    public class TOMObject : BifrostObject
    {
        public TOMObject(ulong addr) : base(addr) { }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void ReceivePlayerReady(TOMPlayerState PlayerState) { Invoke(nameof(ReceivePlayerReady), PlayerState); }
        public void ReceiveLocalPlayerReady(TOMPlayerState InPlayerState) { Invoke(nameof(ReceiveLocalPlayerReady), InPlayerState); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
        public void OnPlayerReady(OnPlayerReadyEventArgs Args) { Invoke(nameof(OnPlayerReady), Args); }
        public void OnLocalPlayerReady(OnPlayerReadyEventArgs Args) { Invoke(nameof(OnLocalPlayerReady), Args); }
    }
    public class InputEffectsManager : TOMObject
    {
        public InputEffectsManager(ulong addr) : base(addr) { }
        public PlayerController PlayerController { get { return this[nameof(PlayerController)].As<PlayerController>(); } set { this["PlayerController"] = value; } }
        public TimeManager TimeManager { get { return this[nameof(TimeManager)].As<TimeManager>(); } set { this["TimeManager"] = value; } }
        public GiantManager GiantManager { get { return this[nameof(GiantManager)].As<GiantManager>(); } set { this["GiantManager"] = value; } }
        public Object ControllerAudioVibrations { get { return this[nameof(ControllerAudioVibrations)]; } set { this[nameof(ControllerAudioVibrations)] = value; } }
        public Object ControllerAudioSpeakers { get { return this[nameof(ControllerAudioSpeakers)]; } set { this[nameof(ControllerAudioSpeakers)] = value; } }
        public float DelayBeforeBlockEffect { get { return this[nameof(DelayBeforeBlockEffect)].GetValue<float>(); } set { this[nameof(DelayBeforeBlockEffect)].SetValue<float>(value); } }
        public void UpdateControllerLightColor(EDayTimeSegment DayTimeSegment) { Invoke(nameof(UpdateControllerLightColor), DayTimeSegment); }
        public void OnTimeManagerSegmentChanged() { Invoke(nameof(OnTimeManagerSegmentChanged)); }
        public void OnTimeManagerReady(OnTimeManagerReadyEventArgs Args) { Invoke(nameof(OnTimeManagerReady), Args); }
        public void OnPlayerShieldBlockReceived(TOMOffensiveComponent OffensiveComponent, Vector Location, float Damage) { Invoke(nameof(OnPlayerShieldBlockReceived), OffensiveComponent, Location, Damage); }
        public void OnPlayerHoldingAttack(bool bIsHoldingAttack) { Invoke(nameof(OnPlayerHoldingAttack), bIsHoldingAttack); }
        public void OnPlayerEquipItem() { Invoke(nameof(OnPlayerEquipItem)); }
        public void OnGiantEnterVillage() { Invoke(nameof(OnGiantEnterVillage)); }
        public void OnGiantDeath() { Invoke(nameof(OnGiantDeath)); }
        public void OnGiantCloseToVillage() { Invoke(nameof(OnGiantCloseToVillage)); }
        public void OnAudioPostEvent(Object EventName) { Invoke(nameof(OnAudioPostEvent), EventName); }
        public void InitTimeManagerEvents(TimeManager InTimeManager) { Invoke(nameof(InitTimeManagerEvents), InTimeManager); }
        public void InitPlayerEvents() { Invoke(nameof(InitPlayerEvents)); }
        public void InitGiantManagerEvents() { Invoke(nameof(InitGiantManagerEvents)); }
    }
    public class InstancedMeshesChunkActor : Object
    {
        public InstancedMeshesChunkActor(ulong addr) : base(addr) { }
    }
    public class InstancedMeshManager : Actor
    {
        public InstancedMeshManager(ulong addr) : base(addr) { }
    }
    public class InteractableComponent : ActorComponent
    {
        public InteractableComponent(ulong addr) : base(addr) { }
        public Object OnDirty { get { return this[nameof(OnDirty)]; } set { this[nameof(OnDirty)] = value; } }
        public Object OnIsInteractableChanged { get { return this[nameof(OnIsInteractableChanged)]; } set { this[nameof(OnIsInteractableChanged)] = value; } }
        public bool bAvailableIfOnlyOne { get { return this[nameof(bAvailableIfOnlyOne)].Flag; } set { this[nameof(bAvailableIfOnlyOne)].Flag = value; } }
        public bool bIsValidatable { get { return this[nameof(bIsValidatable)].Flag; } set { this[nameof(bIsValidatable)].Flag = value; } }
        public bool bKeepTickEnable { get { return this[nameof(bKeepTickEnable)].Flag; } set { this[nameof(bKeepTickEnable)].Flag = value; } }
        public bool bUseGridContextual { get { return this[nameof(bUseGridContextual)].Flag; } set { this[nameof(bUseGridContextual)].Flag = value; } }
        public Vector2D GridContextualCoordinate { get { return this[nameof(GridContextualCoordinate)].As<Vector2D>(); } set { this["GridContextualCoordinate"] = value; } }
        public float Cooldown { get { return this[nameof(Cooldown)].GetValue<float>(); } set { this[nameof(Cooldown)].SetValue<float>(value); } }
        public bool bInteractWithOwner { get { return this[nameof(bInteractWithOwner)].Flag; } set { this[nameof(bInteractWithOwner)].Flag = value; } }
        public EInputContextualAction InputContextual { get { return (EInputContextualAction)this[nameof(InputContextual)].GetValue<int>(); } set { this[nameof(InputContextual)].SetValue<int>((int)value); } }
        public bool bCooldownOnInteraction { get { return this[nameof(bCooldownOnInteraction)].Flag; } set { this[nameof(bCooldownOnInteraction)].Flag = value; } }
        public float CooldownTimer { get { return this[nameof(CooldownTimer)].GetValue<float>(); } set { this[nameof(CooldownTimer)].SetValue<float>(value); } }
        public EntityModelBase Entity { get { return this[nameof(Entity)].As<EntityModelBase>(); } set { this["Entity"] = value; } }
        public Array<MeshComponent> SelectionMeshes { get { return new Array<MeshComponent>(this[nameof(SelectionMeshes)].Address); } }
        public bool bIsDirty { get { return this[nameof(bIsDirty)].Flag; } set { this[nameof(bIsDirty)].Flag = value; } }
        public bool IsInteractable { get { return this[nameof(IsInteractable)].Flag; } set { this[nameof(IsInteractable)].Flag = value; } }
        public void ValidateInteraction(InteractorComponent Interactor) { Invoke(nameof(ValidateInteraction), Interactor); }
        public void ShowSelection() { Invoke(nameof(ShowSelection)); }
        public void ShowPreValidation(InteractorComponent Interactor) { Invoke(nameof(ShowPreValidation), Interactor); }
        public void SetIsInteractable(bool InIsInteractable) { Invoke(nameof(SetIsInteractable), InIsInteractable); }
        public void SetDirty(bool bInIsDirty) { Invoke(nameof(SetDirty), bInIsDirty); }
        public void OnRep_SetIsInteractable_Internal() { Invoke(nameof(OnRep_SetIsInteractable_Internal)); }
        public void OnRep_SetIsInteractable() { Invoke(nameof(OnRep_SetIsInteractable)); }
        public bool IsInteractableByPlayer(TOMPlayerController PlayerController) { return Invoke<bool>(nameof(IsInteractableByPlayer), PlayerController); }
        public bool IsDirty() { return Invoke<bool>(nameof(IsDirty)); }
        public void InteractorLeftRange(InteractorComponent Interactor) { Invoke(nameof(InteractorLeftRange), Interactor); }
        public void InteractorEnteredRange(InteractorComponent Interactor) { Invoke(nameof(InteractorEnteredRange), Interactor); }
        public void InitWithEntity(Object InEntityId) { Invoke(nameof(InitWithEntity), InEntityId); }
        public void HideSelection() { Invoke(nameof(HideSelection)); }
        public void HidePreValidation(InteractorComponent Interactor) { Invoke(nameof(HidePreValidation), Interactor); }
        public bool GetIsInteractable() { return Invoke<bool>(nameof(GetIsInteractable)); }
        public void ClientInputValidateInteraction(InteractorComponent Interactor) { Invoke(nameof(ClientInputValidateInteraction), Interactor); }
    }
    public class InteractorComponent : SphereComponent
    {
        public InteractorComponent(ulong addr) : base(addr) { }
        public Object OnRefreshInteractables { get { return this[nameof(OnRefreshInteractables)]; } set { this[nameof(OnRefreshInteractables)] = value; } }
        public Array<InteractableComponent> CurrentInteractables { get { return new Array<InteractableComponent>(this[nameof(CurrentInteractables)].Address); } }
        public Array<InteractableComponent> InRangeInteractables { get { return new Array<InteractableComponent>(this[nameof(InRangeInteractables)].Address); } }
        public Array<InteractableComponent> OwnedInteractables { get { return new Array<InteractableComponent>(this[nameof(OwnedInteractables)].Address); } }
        public void SetEnabled(bool bInIsEnabled) { Invoke(nameof(SetEnabled), bInIsEnabled); }
        public void Refresh() { Invoke(nameof(Refresh)); }
        public void OnOverlapEnds(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(OnOverlapEnds), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void OnOverlapBegin(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnOverlapBegin), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
        public void OnInteractionRefusedByCooldown(InteractableComponent Interactable) { Invoke(nameof(OnInteractionRefusedByCooldown), Interactable); }
        public void InteractInputPressed(EInputContextualAction InputContextual) { Invoke(nameof(InteractInputPressed), InputContextual); }
        public InteractableComponent GetMainCurrentInteractable() { return Invoke<InteractableComponent>(nameof(GetMainCurrentInteractable)); }
        public Array<InteractableComponent> GetCurrentInteractables() { return Invoke<Array<InteractableComponent>>(nameof(GetCurrentInteractables)); }
        public void CheckForInteractables() { Invoke(nameof(CheckForInteractables)); }
    }
    public class InventoryContainerBaseComponent : TOMActorComponent
    {
        public InventoryContainerBaseComponent(ulong addr) : base(addr) { }
        public Object OnSlotChanged { get { return this[nameof(OnSlotChanged)]; } set { this[nameof(OnSlotChanged)] = value; } }
        public Object OnSlotRemoved { get { return this[nameof(OnSlotRemoved)]; } set { this[nameof(OnSlotRemoved)] = value; } }
        public Object OnEquipmentSpawned { get { return this[nameof(OnEquipmentSpawned)]; } set { this[nameof(OnEquipmentSpawned)] = value; } }
        public Object OnEquipmentDestroyed { get { return this[nameof(OnEquipmentDestroyed)]; } set { this[nameof(OnEquipmentDestroyed)] = value; } }
        public Object OnEquipItem { get { return this[nameof(OnEquipItem)]; } set { this[nameof(OnEquipItem)] = value; } }
        public Object OnContainerSet { get { return this[nameof(OnContainerSet)]; } set { this[nameof(OnContainerSet)] = value; } }
        public bool bUseMaleEquipment { get { return this[nameof(bUseMaleEquipment)].Flag; } set { this[nameof(bUseMaleEquipment)].Flag = value; } }
        public EContainerType ContainerType { get { return (EContainerType)this[nameof(ContainerType)].GetValue<int>(); } set { this[nameof(ContainerType)].SetValue<int>((int)value); } }
        public bool IsCreature { get { return this[nameof(IsCreature)].Flag; } set { this[nameof(IsCreature)].Flag = value; } }
        public bool bAllowItemDrop { get { return this[nameof(bAllowItemDrop)].Flag; } set { this[nameof(bAllowItemDrop)].Flag = value; } }
        public Object SlotIdToSpawnedActor { get { return this[nameof(SlotIdToSpawnedActor)]; } set { this[nameof(SlotIdToSpawnedActor)] = value; } }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public UserEntityModel UserEntityModel { get { return this[nameof(UserEntityModel)].As<UserEntityModel>(); } set { this["UserEntityModel"] = value; } }
        public void SetContainer(ContainerEntityModel InContainer) { Invoke(nameof(SetContainer), InContainer); }
        public void InitPlayerContainer(TOMPlayerState TOMPlayerState) { Invoke(nameof(InitPlayerContainer), TOMPlayerState); }
        public void HandleOnContainerModelChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(HandleOnContainerModelChanged), Entity, Context); }
        public int GetEquippedPower() { return Invoke<int>(nameof(GetEquippedPower)); }
        public TOMEquipmentBase GetEquipmentActorByItemType(int ItemType) { return Invoke<TOMEquipmentBase>(nameof(GetEquipmentActorByItemType), ItemType); }
        public ContainerEntityModel GetContainer() { return Invoke<ContainerEntityModel>(nameof(GetContainer)); }
        public Object FindActorTemplateForUser(ContainerSlotEntityModel Slot, UserEntityModel InUserEntityModel) { return Invoke<Object>(nameof(FindActorTemplateForUser), Slot, InUserEntityModel); }
        public void ExecuteSlotAction(ContainerSlotEntityModel Slot, int LoadoutIndex) { Invoke(nameof(ExecuteSlotAction), Slot, LoadoutIndex); }
        public void EmptySlot(ContainerSlotEntityModel Slot) { Invoke(nameof(EmptySlot), Slot); }
        public void DropSlot(ContainerSlotEntityModel Slot, int Count) { Invoke(nameof(DropSlot), Slot, Count); }
        public void DismantleSlot(ContainerSlotEntityModel Slot) { Invoke(nameof(DismantleSlot), Slot); }
        public void BreakItemMulticast(Object EntityId) { Invoke(nameof(BreakItemMulticast), EntityId); }
        public void AddSpawnActorToSlot(ContainerSlotEntityModel Slot) { Invoke(nameof(AddSpawnActorToSlot), Slot); }
    }
    public class TOMUserWidget : BifrostUserWidget
    {
        public TOMUserWidget(ulong addr) : base(addr) { }
        public Object NameToInput { get { return this[nameof(NameToInput)]; } set { this[nameof(NameToInput)] = value; } }
        public void UnbindListenForAxis(Object AxisName, Object Callback) { Invoke(nameof(UnbindListenForAxis), AxisName, Callback); }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
        public void ListenForAxisInputAction(Object AxisName, bool bConsume, Object Callback) { Invoke(nameof(ListenForAxisInputAction), AxisName, bConsume, Callback); }
        public PlayerController GetPlayerController(Object WorldContextObject, Object Class) { return Invoke<PlayerController>(nameof(GetPlayerController), WorldContextObject, Class); }
        public Character GetPlayerCharacter(Object WorldContextObject, Object Class) { return Invoke<Character>(nameof(GetPlayerCharacter), WorldContextObject, Class); }
    }
    public class ItemSelectionBase : TOMUserWidget
    {
        public ItemSelectionBase(ulong addr) : base(addr) { }
        public bool bIsAnimated { get { return this[nameof(bIsAnimated)].Flag; } set { this[nameof(bIsAnimated)].Flag = value; } }
        public bool bIsShown { get { return this[nameof(bIsShown)].Flag; } set { this[nameof(bIsShown)].Flag = value; } }
        public EItemCategory ItemSlotsCategory { get { return (EItemCategory)this[nameof(ItemSlotsCategory)].GetValue<int>(); } set { this[nameof(ItemSlotsCategory)].SetValue<int>((int)value); } }
        public float DotsAnimationAlpha { get { return this[nameof(DotsAnimationAlpha)].GetValue<float>(); } set { this[nameof(DotsAnimationAlpha)].SetValue<float>(value); } }
        public WidgetTransform DotsDefaultTransform { get { return this[nameof(DotsDefaultTransform)].As<WidgetTransform>(); } set { this["DotsDefaultTransform"] = value; } }
        public TOMCharacter Character { get { return this[nameof(Character)].As<TOMCharacter>(); } set { this["Character"] = value; } }
        public TOMPlayerController PlayerController { get { return this[nameof(PlayerController)].As<TOMPlayerController>(); } set { this["PlayerController"] = value; } }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public Array<ContainerSlotEntityModel> ItemSlots { get { return new Array<ContainerSlotEntityModel>(this[nameof(ItemSlots)].Address); } }
        public int CurrentSlotIndex { get { return this[nameof(CurrentSlotIndex)].GetValue<int>(); } set { this[nameof(CurrentSlotIndex)].SetValue<int>(value); } }
        public int MaximumDotsDisplayed { get { return this[nameof(MaximumDotsDisplayed)].GetValue<int>(); } set { this[nameof(MaximumDotsDisplayed)].SetValue<int>(value); } }
        public bool bNeedRefreshList { get { return this[nameof(bNeedRefreshList)].Flag; } set { this[nameof(bNeedRefreshList)].Flag = value; } }
        public void Show() { Invoke(nameof(Show)); }
        public void RefreshList() { Invoke(nameof(RefreshList)); }
        public void RefreshIndex() { Invoke(nameof(RefreshIndex)); }
        public void RefreshDots() { Invoke(nameof(RefreshDots)); }
        public void OnContainerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerEntityChanged), Entity, Context); }
        public void NextItem() { Invoke(nameof(NextItem)); }
        public void Hide() { Invoke(nameof(Hide)); }
    }
    public class KillCreaturesQuestBehavior : QuestBehaviorBase
    {
        public KillCreaturesQuestBehavior(ulong addr) : base(addr) { }
        public void OnCreatureKilled(AnimalDataModel AnimalDataModel, TOMCharacter CreatureCharacter) { Invoke(nameof(OnCreatureKilled), AnimalDataModel, CreatureCharacter); }
    }
    public class KillGiantQuestBehavior : QuestBehaviorBase
    {
        public KillGiantQuestBehavior(ulong addr) : base(addr) { }
        public void OnGiantKilled() { Invoke(nameof(OnGiantKilled)); }
    }
    public class Layout : Object
    {
        public Layout(ulong addr) : base(addr) { }
    }
    public class LeverReceiverInterface : Interface
    {
        public LeverReceiverInterface(ulong addr) : base(addr) { }
        public void InitReceiver(Object ReceiverId, CaveEntityModel CaveEntityModel) { Invoke(nameof(InitReceiver), ReceiverId, CaveEntityModel); }
        public Object GetLeverReceiver() { return Invoke<Object>(nameof(GetLeverReceiver)); }
    }
    public class LoadingScreenUserWidget : BifrostUserWidget
    {
        public LoadingScreenUserWidget(ulong addr) : base(addr) { }
        public void StopLogic() { Invoke(nameof(StopLogic)); }
        public void StartLogic() { Invoke(nameof(StartLogic)); }
    }
    public class LobbyAvatarEntityModel : EntityModelBase
    {
        public LobbyAvatarEntityModel(ulong addr) : base(addr) { }
        public EventRequest SetUserCosmeticRequest { get { return this[nameof(SetUserCosmeticRequest)].As<EventRequest>(); } set { this["SetUserCosmeticRequest"] = value; } }
        public EGender Gender { get { return (EGender)this[nameof(Gender)].GetValue<int>(); } set { this[nameof(Gender)].SetValue<int>((int)value); } }
        public AvatarCosmeticDataModel pet { get { return this[nameof(pet)].As<AvatarCosmeticDataModel>(); } set { this["pet"] = value; } }
        public AvatarCosmeticDataModel skinTone { get { return this[nameof(skinTone)].As<AvatarCosmeticDataModel>(); } set { this["skinTone"] = value; } }
        public AvatarCosmeticDataModel hairColor { get { return this[nameof(hairColor)].As<AvatarCosmeticDataModel>(); } set { this["hairColor"] = value; } }
        public AvatarCosmeticDataModel hairCut { get { return this[nameof(hairCut)].As<AvatarCosmeticDataModel>(); } set { this["hairCut"] = value; } }
        public AvatarCosmeticDataModel head { get { return this[nameof(head)].As<AvatarCosmeticDataModel>(); } set { this["head"] = value; } }
        public int IconId { get { return this[nameof(IconId)].GetValue<int>(); } set { this[nameof(IconId)].SetValue<int>(value); } }
        public Object Emotes { get { return this[nameof(Emotes)]; } set { this[nameof(Emotes)] = value; } }
        public Object Commands { get { return this[nameof(Commands)]; } set { this[nameof(Commands)] = value; } }
        public CharacterDataModel StaticCharacterData { get { return this[nameof(StaticCharacterData)].As<CharacterDataModel>(); } set { this["StaticCharacterData"] = value; } }
        public void UpdateFromVO(UserAvatarVO InVO) { Invoke(nameof(UpdateFromVO), InVO); }
        public void UnequipTransmog(int TransmogId) { Invoke(nameof(UnequipTransmog), TransmogId); }
        public void UnequipStarterKit(int StarterKitId) { Invoke(nameof(UnequipStarterKit), StarterKitId); }
        public void SwapGender() { Invoke(nameof(SwapGender)); }
        public void SetSkinTone(AvatarCosmeticDataModel skinTone) { Invoke(nameof(SetSkinTone), skinTone); }
        public void SetPet(AvatarCosmeticDataModel pet) { Invoke(nameof(SetPet), pet); }
        public void SetIconId(int ID) { Invoke(nameof(SetIconId), ID); }
        public void SetHead(AvatarCosmeticDataModel head) { Invoke(nameof(SetHead), head); }
        public void SetHaircut(AvatarCosmeticDataModel hairCut) { Invoke(nameof(SetHaircut), hairCut); }
        public void SetHairColor(AvatarCosmeticDataModel hairColor) { Invoke(nameof(SetHairColor), hairColor); }
        public void SetGender(EGender Gender) { Invoke(nameof(SetGender), Gender); }
        public void SetEmotes(Object InEmotes) { Invoke(nameof(SetEmotes), InEmotes); }
        public void Save() { Invoke(nameof(Save)); }
        public bool IsTransmogEquipped(int TransmogId) { return Invoke<bool>(nameof(IsTransmogEquipped), TransmogId); }
        public bool IsStarterKitEquipped(int StarterKitId) { return Invoke<bool>(nameof(IsStarterKitEquipped), StarterKitId); }
        public bool IsEmoteEquipped(int CosmeticId) { return Invoke<bool>(nameof(IsEmoteEquipped), CosmeticId); }
        public bool IsCommandEquipped(int CosmeticId) { return Invoke<bool>(nameof(IsCommandEquipped), CosmeticId); }
        public UserAvatarVO GetVO() { return Invoke<UserAvatarVO>(nameof(GetVO)); }
        public CharacterDataModel GetStaticData() { return Invoke<CharacterDataModel>(nameof(GetStaticData)); }
        public AvatarCosmeticDataModel GetSkinTone() { return Invoke<AvatarCosmeticDataModel>(nameof(GetSkinTone)); }
        public AvatarCosmeticDataModel GetPet() { return Invoke<AvatarCosmeticDataModel>(nameof(GetPet)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public int GetIconId() { return Invoke<int>(nameof(GetIconId)); }
        public AvatarIconDataModel GetIcon() { return Invoke<AvatarIconDataModel>(nameof(GetIcon)); }
        public AvatarCosmeticDataModel GetHead() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHead)); }
        public AvatarCosmeticDataModel GetHaircut() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHaircut)); }
        public AvatarCosmeticDataModel GetHairColor() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHairColor)); }
        public EGender GetGender() { return Invoke<EGender>(nameof(GetGender)); }
        public TransmogDataModel GetEquippedTransmogByType(int ItemTypeId) { return Invoke<TransmogDataModel>(nameof(GetEquippedTransmogByType), ItemTypeId); }
        public UserAvatarVO GetEquipedAvatar() { return Invoke<UserAvatarVO>(nameof(GetEquipedAvatar)); }
        public Object GetEmotes() { return Invoke<Object>(nameof(GetEmotes)); }
        public StarterKitDataModel GetCurrentStarterKit() { return Invoke<StarterKitDataModel>(nameof(GetCurrentStarterKit)); }
        public Object GetCommands() { return Invoke<Object>(nameof(GetCommands)); }
        public void EquipTransmog(int TransmogId) { Invoke(nameof(EquipTransmog), TransmogId); }
        public void EquipStarterKit(int StarterKitId) { Invoke(nameof(EquipStarterKit), StarterKitId); }
        public LobbyAvatarEntityModel CreateFromVO(Object Outer, UserAvatarVO InVO) { return Invoke<LobbyAvatarEntityModel>(nameof(CreateFromVO), Outer, InVO); }
        public void AutoEquipCosmetic(int CosmeticId) { Invoke(nameof(AutoEquipCosmetic), CosmeticId); }
        public void AssignEmote(int Index, AvatarCosmeticDataModel Emote) { Invoke(nameof(AssignEmote), Index, Emote); }
        public void AssignCommand(int Index, AvatarCosmeticDataModel Command) { Invoke(nameof(AssignCommand), Index, Command); }
    }
    public class TOMGameModeBase : BifrostGameMode
    {
        public TOMGameModeBase(ulong addr) : base(addr) { }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
    }
    public class LobbyGameMode : TOMGameModeBase
    {
        public LobbyGameMode(ulong addr) : base(addr) { }
        public void PreloadingComplete() { Invoke(nameof(PreloadingComplete)); }
    }
    public class LobbyLevelScriptActor : TOMLevelScriptActor
    {
        public LobbyLevelScriptActor(ulong addr) : base(addr) { }
    }
    public class LobbyPlayerController : BifrostPlayerController
    {
        public LobbyPlayerController(ulong addr) : base(addr) { }
        public Object OnMatchAboutToStart { get { return this[nameof(OnMatchAboutToStart)]; } set { this[nameof(OnMatchAboutToStart)] = value; } }
        public Object OnInputControllerChanged { get { return this[nameof(OnInputControllerChanged)]; } set { this[nameof(OnInputControllerChanged)] = value; } }
        public Object OnViewportFocusChanged { get { return this[nameof(OnViewportFocusChanged)]; } set { this[nameof(OnViewportFocusChanged)] = value; } }
        public TOMGameViewportClient GameViewportClient { get { return this[nameof(GameViewportClient)].As<TOMGameViewportClient>(); } set { this["GameViewportClient"] = value; } }
        public EventRequest MatchmakingRequest { get { return this[nameof(MatchmakingRequest)].As<EventRequest>(); } set { this["MatchmakingRequest"] = value; } }
        public TOMLobbyCharacterData CharacterData { get { return this[nameof(CharacterData)].As<TOMLobbyCharacterData>(); } set { this["CharacterData"] = value; } }
        public bool bInputSuspended { get { return this[nameof(bInputSuspended)].Flag; } set { this[nameof(bInputSuspended)].Flag = value; } }
        public void SuspendInputChanged() { Invoke(nameof(SuspendInputChanged)); }
        public void StartSeasonMatchmaking(Array<Object> UserIds, int MaxPlayers, bool GroupOnly) { Invoke(nameof(StartSeasonMatchmaking), UserIds, MaxPlayers, GroupOnly); }
        public bool ShowStoreUI() { return Invoke<bool>(nameof(ShowStoreUI)); }
        public void SetInputSuspended(bool InbSuspendInput) { Invoke(nameof(SetInputSuspended), InbSuspendInput); }
        public void SetCharacterData(TOMLobbyCharacterData InCharacterData) { Invoke(nameof(SetCharacterData), InCharacterData); }
        public void OnStartSeasonMatchmakingResult(ServerResponse Response) { Invoke(nameof(OnStartSeasonMatchmakingResult), Response); }
        public void OnExternalUIClosed(bool bIsOpening) { Invoke(nameof(OnExternalUIClosed), bIsOpening); }
        public void OnBroadcastViewportFocusChanged(bool bHasFocus) { Invoke(nameof(OnBroadcastViewportFocusChanged), bHasFocus); }
        public void OnBroadcastInputControllerChanged() { Invoke(nameof(OnBroadcastInputControllerChanged)); }
        public bool IsUsingKeyboard() { return Invoke<bool>(nameof(IsUsingKeyboard)); }
        public bool IsInputSuspended() { return Invoke<bool>(nameof(IsInputSuspended)); }
        public TOMGameViewportClient GetGameViewportClient() { return Invoke<TOMGameViewportClient>(nameof(GetGameViewportClient)); }
        public TOMLobbyCharacterData GetCharacterData() { return Invoke<TOMLobbyCharacterData>(nameof(GetCharacterData)); }
        public void ExecuteOnMatchAboutToStart(bool bOpen) { Invoke(nameof(ExecuteOnMatchAboutToStart), bOpen); }
    }
    public class LogUtility : Object
    {
        public LogUtility(ulong addr) : base(addr) { }
        public void LogError(Object String) { Invoke(nameof(LogError), String); }
    }
    public class LoopWhileAOENotifyState : AnimNotifyState
    {
        public LoopWhileAOENotifyState(ulong addr) : base(addr) { }
        public Object RecoveryName { get { return this[nameof(RecoveryName)]; } set { this[nameof(RecoveryName)] = value; } }
    }
    public class MainMenuLevelScriptActor : TOMLevelScriptActor
    {
        public MainMenuLevelScriptActor(ulong addr) : base(addr) { }
    }
    public class ManaOnRunestoneStatusComponent : StatusComponent
    {
        public ManaOnRunestoneStatusComponent(ulong addr) : base(addr) { }
        public void OnUseRunestone() { Invoke(nameof(OnUseRunestone)); }
    }
    public class MapTextureGenerator : BifrostObject
    {
        public MapTextureGenerator(ulong addr) : base(addr) { }
        public bool UseDebugMap { get { return this[nameof(UseDebugMap)].Flag; } set { this[nameof(UseDebugMap)].Flag = value; } }
        public bool ShowGrid { get { return this[nameof(ShowGrid)].Flag; } set { this[nameof(ShowGrid)].Flag = value; } }
        public bool ShowVoroNoise { get { return this[nameof(ShowVoroNoise)].Flag; } set { this[nameof(ShowVoroNoise)].Flag = value; } }
        public bool ShowTextures { get { return this[nameof(ShowTextures)].Flag; } set { this[nameof(ShowTextures)].Flag = value; } }
        public bool ShowOutline { get { return this[nameof(ShowOutline)].Flag; } set { this[nameof(ShowOutline)].Flag = value; } }
        public bool bShowRegionBorders { get { return this[nameof(bShowRegionBorders)].Flag; } set { this[nameof(bShowRegionBorders)].Flag = value; } }
        public int GridDivisionCount { get { return this[nameof(GridDivisionCount)].GetValue<int>(); } set { this[nameof(GridDivisionCount)].SetValue<int>(value); } }
        public float GridNoiseFactor { get { return this[nameof(GridNoiseFactor)].GetValue<float>(); } set { this[nameof(GridNoiseFactor)].SetValue<float>(value); } }
        public Object BiomeTexture { get { return this[nameof(BiomeTexture)]; } set { this[nameof(BiomeTexture)] = value; } }
        public float MaxHeight { get { return this[nameof(MaxHeight)].GetValue<float>(); } set { this[nameof(MaxHeight)].SetValue<float>(value); } }
        public float OutlineMultiplier { get { return this[nameof(OutlineMultiplier)].GetValue<float>(); } set { this[nameof(OutlineMultiplier)].SetValue<float>(value); } }
        public float WaterOutlineMultiplier { get { return this[nameof(WaterOutlineMultiplier)].GetValue<float>(); } set { this[nameof(WaterOutlineMultiplier)].SetValue<float>(value); } }
        public float CliffBlendRatio { get { return this[nameof(CliffBlendRatio)].GetValue<float>(); } set { this[nameof(CliffBlendRatio)].SetValue<float>(value); } }
        public Texture2DDynamic WorldMapTexture { get { return this[nameof(WorldMapTexture)].As<Texture2DDynamic>(); } set { this["WorldMapTexture"] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public Object BiomeColors { get { return this[nameof(BiomeColors)]; } set { this[nameof(BiomeColors)] = value; } }
        public Object BiomeTexturesPixels { get { return this[nameof(BiomeTexturesPixels)]; } set { this[nameof(BiomeTexturesPixels)] = value; } }
    }
    public class MaterialManager : TOMActor
    {
        public MaterialManager(ulong addr) : base(addr) { }
        public MaterialInstance WaterMaterial { get { return this[nameof(WaterMaterial)].As<MaterialInstance>(); } set { this["WaterMaterial"] = value; } }
        public MaterialInstance SeaMaterial { get { return this[nameof(SeaMaterial)].As<MaterialInstance>(); } set { this["SeaMaterial"] = value; } }
        public MaterialInstance RiverMaterial { get { return this[nameof(RiverMaterial)].As<MaterialInstance>(); } set { this["RiverMaterial"] = value; } }
        public MaterialInstance PuddleMaterial { get { return this[nameof(PuddleMaterial)].As<MaterialInstance>(); } set { this["PuddleMaterial"] = value; } }
        public MaterialInstance BorderMaterial { get { return this[nameof(BorderMaterial)].As<MaterialInstance>(); } set { this["BorderMaterial"] = value; } }
        public float WinterChangeStep { get { return this[nameof(WinterChangeStep)].GetValue<float>(); } set { this[nameof(WinterChangeStep)].SetValue<float>(value); } }
        public Array<BorderMaterialData> BorderMaterials { get { return new Array<BorderMaterialData>(this[nameof(BorderMaterials)].Address); } }
        public Object InstancedMeshesInterface { get { return this[nameof(InstancedMeshesInterface)]; } set { this[nameof(InstancedMeshesInterface)] = value; } }
        public Object TerrainMaterials { get { return this[nameof(TerrainMaterials)]; } set { this[nameof(TerrainMaterials)] = value; } }
        public Object RockMaterials { get { return this[nameof(RockMaterials)]; } set { this[nameof(RockMaterials)] = value; } }
    }
    public class MaterialSourceBase : TOMActor
    {
        public MaterialSourceBase(ulong addr) : base(addr) { }
        public bool bReplicateTimer { get { return this[nameof(bReplicateTimer)].Flag; } set { this[nameof(bReplicateTimer)].Flag = value; } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
        public Vector ParticlesOffset { get { return this[nameof(ParticlesOffset)].As<Vector>(); } set { this["ParticlesOffset"] = value; } }
        public ParticleSystem OnHarvestParticles { get { return this[nameof(OnHarvestParticles)].As<ParticleSystem>(); } set { this["OnHarvestParticles"] = value; } }
        public ParticleSystem OnSpawnParticles { get { return this[nameof(OnSpawnParticles)].As<ParticleSystem>(); } set { this["OnSpawnParticles"] = value; } }
        public ParticleSystem NightShiftParticlesTemplate { get { return this[nameof(NightShiftParticlesTemplate)].As<ParticleSystem>(); } set { this["NightShiftParticlesTemplate"] = value; } }
        public CurveFloat NightShiftCurve { get { return this[nameof(NightShiftCurve)].As<CurveFloat>(); } set { this["NightShiftCurve"] = value; } }
        public Object NightShiftParameterName { get { return this[nameof(NightShiftParameterName)]; } set { this[nameof(NightShiftParameterName)] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public StaticMeshComponent HarvestedMesh { get { return this[nameof(HarvestedMesh)].As<StaticMeshComponent>(); } set { this["HarvestedMesh"] = value; } }
        public StaticMeshComponent NotHarvestedMesh { get { return this[nameof(NotHarvestedMesh)].As<StaticMeshComponent>(); } set { this["NotHarvestedMesh"] = value; } }
        public ShaderVisibilityComponentBase ShaderVisibility { get { return this[nameof(ShaderVisibility)].As<ShaderVisibilityComponentBase>(); } set { this["ShaderVisibility"] = value; } }
        public DefensiveShieldComponent DefensiveComponent { get { return this[nameof(DefensiveComponent)].As<DefensiveShieldComponent>(); } set { this["DefensiveComponent"] = value; } }
        public MaterialSource_RepProperties MaterialRepProperties { get { return this[nameof(MaterialRepProperties)].As<MaterialSource_RepProperties>(); } set { this["MaterialRepProperties"] = value; } }
        public InteractableComponent InteractableActorComponent { get { return this[nameof(InteractableActorComponent)].As<InteractableComponent>(); } set { this["InteractableActorComponent"] = value; } }
        public WorldMaterialSourceEntityModel MaterialSourceEntity { get { return this[nameof(MaterialSourceEntity)].As<WorldMaterialSourceEntityModel>(); } set { this["MaterialSourceEntity"] = value; } }
        public bool bIsBoundToDefensiveComponent { get { return this[nameof(bIsBoundToDefensiveComponent)].Flag; } set { this[nameof(bIsBoundToDefensiveComponent)].Flag = value; } }
        public ParticleSystemComponent NightShiftParticlesEmitter { get { return this[nameof(NightShiftParticlesEmitter)].As<ParticleSystemComponent>(); } set { this["NightShiftParticlesEmitter"] = value; } }
        public void SetForceNightShift(bool InForceNightShift) { Invoke(nameof(SetForceNightShift), InForceNightShift); }
        public void RefreshHarvestState() { Invoke(nameof(RefreshHarvestState)); }
        public void RefreshAlternativeState() { Invoke(nameof(RefreshAlternativeState)); }
        public void OnRep_Properties() { Invoke(nameof(OnRep_Properties)); }
        public void OnNightStart() { Invoke(nameof(OnNightStart)); }
        public void OnEveningStart() { Invoke(nameof(OnEveningStart)); }
        public void OnDefensiveDamageReceived(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnDefensiveDamageReceived), Source, IssuedAmount, HitResult); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public void Init(WorldMaterialSourceEntityModel InMaterialSourceEntity, Vector InLocation, Quat InRotation) { Invoke(nameof(Init), InMaterialSourceEntity, InLocation, InRotation); }
        public void HarvestSource(TOMCharacter Harvester, bool ForceDrop) { Invoke(nameof(HarvestSource), Harvester, ForceDrop); }
        public float GetRespawnRate() { return Invoke<float>(nameof(GetRespawnRate)); }
        public WorldMaterialSourceEntityModel GetMaterialSourceEntity() { return Invoke<WorldMaterialSourceEntityModel>(nameof(GetMaterialSourceEntity)); }
        public bool GetIsHarvested() { return Invoke<bool>(nameof(GetIsHarvested)); }
    }
    public class MaterialSourceTreeBase : MaterialSourceBase
    {
        public MaterialSourceTreeBase(ulong addr) : base(addr) { }
        public float ImpulseMagnitude { get { return this[nameof(ImpulseMagnitude)].GetValue<float>(); } set { this[nameof(ImpulseMagnitude)].SetValue<float>(value); } }
        public Vector ImpulseOffset { get { return this[nameof(ImpulseOffset)].As<Vector>(); } set { this["ImpulseOffset"] = value; } }
        public CurveVector ScaleDownCurve { get { return this[nameof(ScaleDownCurve)].As<CurveVector>(); } set { this["ScaleDownCurve"] = value; } }
        public Vector HarvesterPositionCache { get { return this[nameof(HarvesterPositionCache)].As<Vector>(); } set { this["HarvesterPositionCache"] = value; } }
        public void FallTree(Vector HarvesterPosition) { Invoke(nameof(FallTree), HarvesterPosition); }
    }
    public class MathUtility : Object
    {
        public MathUtility(ulong addr) : base(addr) { }
        public int GetMaxInt() { return Invoke<int>(nameof(GetMaxInt)); }
        public float GetMaxFloat() { return Invoke<float>(nameof(GetMaxFloat)); }
        public float GetMagnitude2D(Vector Vector1, Vector Vector2) { return Invoke<float>(nameof(GetMagnitude2D), Vector1, Vector2); }
        public Rotator FindLookAtRotator(Actor Source, Actor Target) { return Invoke<Rotator>(nameof(FindLookAtRotator), Source, Target); }
    }
    public class MenuRadialBase : TOMUserWidget
    {
        public MenuRadialBase(ulong addr) : base(addr) { }
        public Object AxisInputNameUpDown { get { return this[nameof(AxisInputNameUpDown)]; } set { this[nameof(AxisInputNameUpDown)] = value; } }
        public Object AxisInputNameRightLeft { get { return this[nameof(AxisInputNameRightLeft)]; } set { this[nameof(AxisInputNameRightLeft)] = value; } }
        public int CurrentSegment { get { return this[nameof(CurrentSegment)].GetValue<int>(); } set { this[nameof(CurrentSegment)].SetValue<int>(value); } }
        public float ScaleUpDown { get { return this[nameof(ScaleUpDown)].GetValue<float>(); } set { this[nameof(ScaleUpDown)].SetValue<float>(value); } }
        public float ScaleRightLeft { get { return this[nameof(ScaleRightLeft)].GetValue<float>(); } set { this[nameof(ScaleRightLeft)].SetValue<float>(value); } }
        public Object RightLeftCallback { get { return this[nameof(RightLeftCallback)]; } set { this[nameof(RightLeftCallback)] = value; } }
        public Object UpDownCallback { get { return this[nameof(UpDownCallback)]; } set { this[nameof(UpDownCallback)] = value; } }
        public void StopListeningForInput() { Invoke(nameof(StopListeningForInput)); }
        public void StartListeningForInput() { Invoke(nameof(StartListeningForInput)); }
        public void RefreshSelectedSegment(int Segment) { Invoke(nameof(RefreshSelectedSegment), Segment); }
        public void Refresh() { Invoke(nameof(Refresh)); }
        public void OnAxisUpDown(float Value) { Invoke(nameof(OnAxisUpDown), Value); }
        public void OnAxisRightLeft(float Value) { Invoke(nameof(OnAxisRightLeft), Value); }
    }
    public class MetaMovementManager : Actor
    {
        public MetaMovementManager(ulong addr) : base(addr) { }
        public float SquareDistanceTolerance { get { return this[nameof(SquareDistanceTolerance)].GetValue<float>(); } set { this[nameof(SquareDistanceTolerance)].SetValue<float>(value); } }
        public Array<WorldCreatureEntityModel> MovingCreatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(MovingCreatures)].Address); } }
        public void StopCreatureMetaMovement(WorldCreatureEntityModel CreatureEntityModel) { Invoke(nameof(StopCreatureMetaMovement), CreatureEntityModel); }
        public void StartCreatureMetaMovement(WorldCreatureEntityModel CreatureEntityModel, Array<Vector> Path) { Invoke(nameof(StartCreatureMetaMovement), CreatureEntityModel, Path); }
        public Array<Vector> GetDirectPathToLocation(Vector Origin, Vector Destination) { return Invoke<Array<Vector>>(nameof(GetDirectPathToLocation), Origin, Destination); }
    }
    public class MinionWaveManager : TOMActor
    {
        public MinionWaveManager(ulong addr) : base(addr) { }
        public Object SpawnPointClass { get { return this[nameof(SpawnPointClass)]; } set { this[nameof(SpawnPointClass)] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public Array<Actor> SpawnPoints { get { return new Array<Actor>(this[nameof(SpawnPoints)].Address); } }
        public Array<Actor> SpawnedMinions { get { return new Array<Actor>(this[nameof(SpawnedMinions)].Address); } }
        public Array<MinionWaveDataModel> MinionWaves { get { return new Array<MinionWaveDataModel>(this[nameof(MinionWaves)].Address); } }
        public Array<TimerHandle> CreatureTimers { get { return new Array<TimerHandle>(this[nameof(CreatureTimers)].Address); } }
        public Object SpawnCreaturePerNight { get { return this[nameof(SpawnCreaturePerNight)]; } set { this[nameof(SpawnCreaturePerNight)] = value; } }
        public void StartTimerForCreature(MinionWaveCreatureEntryDataVO MinionWaveCreatureEntry) { Invoke(nameof(StartTimerForCreature), MinionWaveCreatureEntry); }
        public void SpawnRandomMinion() { Invoke(nameof(SpawnRandomMinion)); }
        public void SpawnCreature(MinionWaveCreatureEntryDataVO MinionWaveCreatureEntry) { Invoke(nameof(SpawnCreature), MinionWaveCreatureEntry); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public void OnNightStart() { Invoke(nameof(OnNightStart)); }
        public void OnMinionDestroyed(Actor DestroyedActor) { Invoke(nameof(OnMinionDestroyed), DestroyedActor); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public bool CurrentDayHasMinions() { return Invoke<bool>(nameof(CurrentDayHasMinions)); }
    }
    public class ModuleChunkActor : BifrostObject
    {
        public ModuleChunkActor(ulong addr) : base(addr) { }
        public Array<int> ModuleInstanceIds { get { return new Array<int>(this[nameof(ModuleInstanceIds)].Address); } }
    }
    public class ModuleData : Object
    {
        public ModuleData(ulong addr) : base(addr) { }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public EPOIType Type { get { return (EPOIType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public RegionData Region { get { return this[nameof(Region)].As<RegionData>(); } set { this["Region"] = value; } }
        public IntVector WorldPos { get { return this[nameof(WorldPos)].As<IntVector>(); } set { this["WorldPos"] = value; } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
        public int CaveId { get { return this[nameof(CaveId)].GetValue<int>(); } set { this[nameof(CaveId)].SetValue<int>(value); } }
        public bool bIsPopulated { get { return this[nameof(bIsPopulated)].Flag; } set { this[nameof(bIsPopulated)].Flag = value; } }
        public Object ServerActorClass { get { return this[nameof(ServerActorClass)]; } set { this[nameof(ServerActorClass)] = value; } }
        public Object ClientActorClass { get { return this[nameof(ClientActorClass)]; } set { this[nameof(ClientActorClass)] = value; } }
        public ModuleSave ModuleSave { get { return this[nameof(ModuleSave)].As<ModuleSave>(); } set { this["ModuleSave"] = value; } }
        public ModuleDataModel ModuleModel { get { return this[nameof(ModuleModel)].As<ModuleDataModel>(); } set { this["ModuleModel"] = value; } }
    }
    public class ModuleManager : Actor
    {
        public ModuleManager(ulong addr) : base(addr) { }
        public void UnregisterModuleChunk(int moduleId, bool bIsServer, bool bIsClient) { Invoke(nameof(UnregisterModuleChunk), moduleId, bIsServer, bIsClient); }
        public void RegisterModuleChunk(ModuleData ModuleData, bool bIsServer, bool bIsClient, int Margin) { Invoke(nameof(RegisterModuleChunk), ModuleData, bIsServer, bIsClient, Margin); }
    }
    public class ModuleSave : Actor
    {
        public ModuleSave(ulong addr) : base(addr) { }
        public IntPoint Dimensions { get { return this[nameof(Dimensions)].As<IntPoint>(); } set { this["Dimensions"] = value; } }
        public Vector ModuleOffset { get { return this[nameof(ModuleOffset)].As<Vector>(); } set { this["ModuleOffset"] = value; } }
        public Object Transforms { get { return this[nameof(Transforms)]; } set { this[nameof(Transforms)] = value; } }
        public Object ServerSubClasses { get { return this[nameof(ServerSubClasses)]; } set { this[nameof(ServerSubClasses)] = value; } }
        public Object ClientSubClasses { get { return this[nameof(ClientSubClasses)]; } set { this[nameof(ClientSubClasses)] = value; } }
        public Object CreatureSpawnPoints { get { return this[nameof(CreatureSpawnPoints)]; } set { this[nameof(CreatureSpawnPoints)] = value; } }
        public Object ChestSpawnPoints { get { return this[nameof(ChestSpawnPoints)]; } set { this[nameof(ChestSpawnPoints)] = value; } }
        public Array<float> Weights { get { return new Array<float>(this[nameof(Weights)].Address); } }
        public Array<bool> Handmade { get { return new Array<bool>(this[nameof(Handmade)].Address); } }
        public Array<ModuleCreature> ModuleCreatures { get { return new Array<ModuleCreature>(this[nameof(ModuleCreatures)].Address); } }
        public Array<ModuleHazard> ModuleHazards { get { return new Array<ModuleHazard>(this[nameof(ModuleHazards)].Address); } }
        public Array<ModuleMaterialSource> ModuleMaterialSources { get { return new Array<ModuleMaterialSource>(this[nameof(ModuleMaterialSources)].Address); } }
        public Array<ModuleParticleSystem> ModuleParticleSystems { get { return new Array<ModuleParticleSystem>(this[nameof(ModuleParticleSystems)].Address); } }
        public Array<ModuleLever> ModuleLevers { get { return new Array<ModuleLever>(this[nameof(ModuleLevers)].Address); } }
        public Array<ModuleLeverReceiver> ModuleLeverReceivers { get { return new Array<ModuleLeverReceiver>(this[nameof(ModuleLeverReceivers)].Address); } }
        public Object ServerModule { get { return this[nameof(ServerModule)]; } set { this[nameof(ServerModule)] = value; } }
        public Object ClientModule { get { return this[nameof(ClientModule)]; } set { this[nameof(ClientModule)] = value; } }
    }
    public class ModuleSpawnPoint : Actor
    {
        public ModuleSpawnPoint(ulong addr) : base(addr) { }
        public bool bIsBoss { get { return this[nameof(bIsBoss)].Flag; } set { this[nameof(bIsBoss)].Flag = value; } }
        public bool bIsElite { get { return this[nameof(bIsElite)].Flag; } set { this[nameof(bIsElite)].Flag = value; } }
        public bool bIsRange { get { return this[nameof(bIsRange)].Flag; } set { this[nameof(bIsRange)].Flag = value; } }
    }
    public class MultiplayerSandboxGameMode : TOMGameModeBase
    {
        public MultiplayerSandboxGameMode(ulong addr) : base(addr) { }
        public bool TriggerSave { get { return this[nameof(TriggerSave)].Flag; } set { this[nameof(TriggerSave)].Flag = value; } }
        public DataObject PendingSaveGame { get { return this[nameof(PendingSaveGame)].As<DataObject>(); } set { this["PendingSaveGame"] = value; } }
        public EventRequest SaveEventRequest { get { return this[nameof(SaveEventRequest)].As<EventRequest>(); } set { this["SaveEventRequest"] = value; } }
        public Object PlayersSessionIdByUserId { get { return this[nameof(PlayersSessionIdByUserId)]; } set { this[nameof(PlayersSessionIdByUserId)] = value; } }
        public void Save() { Invoke(nameof(Save)); }
        public void OnYggdrasilDeath() { Invoke(nameof(OnYggdrasilDeath)); }
    }
    public class MultiplayerSandboxGameState : BifrostGameState
    {
        public MultiplayerSandboxGameState(ulong addr) : base(addr) { }
        public Object OnWorldEntityUpdated { get { return this[nameof(OnWorldEntityUpdated)]; } set { this[nameof(OnWorldEntityUpdated)] = value; } }
        public Object GiantManagerBPClass { get { return this[nameof(GiantManagerBPClass)]; } set { this[nameof(GiantManagerBPClass)] = value; } }
        public Object PlayerLootManagerBPClass { get { return this[nameof(PlayerLootManagerBPClass)]; } set { this[nameof(PlayerLootManagerBPClass)] = value; } }
        public Object WorldMapManagerClass { get { return this[nameof(WorldMapManagerClass)]; } set { this[nameof(WorldMapManagerClass)] = value; } }
        public Object MinionWaveManagerBPClass { get { return this[nameof(MinionWaveManagerBPClass)]; } set { this[nameof(MinionWaveManagerBPClass)] = value; } }
        public Object TimeManagerBPClass { get { return this[nameof(TimeManagerBPClass)]; } set { this[nameof(TimeManagerBPClass)] = value; } }
        public GameSessionData GameSessionData { get { return this[nameof(GameSessionData)].As<GameSessionData>(); } set { this["GameSessionData"] = value; } }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
        public GiantManager GiantManager { get { return this[nameof(GiantManager)].As<GiantManager>(); } set { this["GiantManager"] = value; } }
        public PlayerLootManager PlayerLootManager { get { return this[nameof(PlayerLootManager)].As<PlayerLootManager>(); } set { this["PlayerLootManager"] = value; } }
        public MinionWaveManager MinionWaveManager { get { return this[nameof(MinionWaveManager)].As<MinionWaveManager>(); } set { this["MinionWaveManager"] = value; } }
        public WorldMapManager WorldMapManager { get { return this[nameof(WorldMapManager)].As<WorldMapManager>(); } set { this["WorldMapManager"] = value; } }
        public TimeManager TimeManager { get { return this[nameof(TimeManager)].As<TimeManager>(); } set { this["TimeManager"] = value; } }
        public WorldVO WorldVO { get { return this[nameof(WorldVO)].As<WorldVO>(); } set { this["WorldVO"] = value; } }
        public void OnWorldEntityUpdated__DelegateSignature() { Invoke(nameof(OnWorldEntityUpdated__DelegateSignature)); }
        public void OnWorldEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnWorldEntityChanged), Entity, Context); }
        public void OnRep_WorldVO() { Invoke(nameof(OnRep_WorldVO)); }
        public void OnGameStateDestroyed(Actor Actor) { Invoke(nameof(OnGameStateDestroyed), Actor); }
        public void InitManagers() { Invoke(nameof(InitManagers)); }
        public WorldMapManager GetWorldMapManager() { return Invoke<WorldMapManager>(nameof(GetWorldMapManager)); }
        public WorldEntityModel GetWorldEntityModel() { return Invoke<WorldEntityModel>(nameof(GetWorldEntityModel)); }
        public float GetWorldElapsedTime() { return Invoke<float>(nameof(GetWorldElapsedTime)); }
        public TOMPlayerState GetPlayerStateById(Object UserId) { return Invoke<TOMPlayerState>(nameof(GetPlayerStateById), UserId); }
        public PlayerLootManager GetPlayerLootManager() { return Invoke<PlayerLootManager>(nameof(GetPlayerLootManager)); }
        public MinionWaveManager GetMinionWaveManager() { return Invoke<MinionWaveManager>(nameof(GetMinionWaveManager)); }
        public GiantManager GetGiantManager() { return Invoke<GiantManager>(nameof(GetGiantManager)); }
        public GameSessionData GetGameSessionData() { return Invoke<GameSessionData>(nameof(GetGameSessionData)); }
    }
    public class MultiplayerSandboxLevelScriptActor : TOMLevelScriptActor
    {
        public MultiplayerSandboxLevelScriptActor(ulong addr) : base(addr) { }
        public void InitializeGameManagers() { Invoke(nameof(InitializeGameManagers)); }
    }
    public class MultiplayerSandboxLoadingLevelScriptActor : BifrostLevelScriptActor
    {
        public MultiplayerSandboxLoadingLevelScriptActor(ulong addr) : base(addr) { }
        public Object WorldID { get { return this[nameof(WorldID)]; } set { this[nameof(WorldID)] = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public bool bResetWorldMap { get { return this[nameof(bResetWorldMap)].Flag; } set { this[nameof(bResetWorldMap)].Flag = value; } }
        public bool bUseSaveGame { get { return this[nameof(bUseSaveGame)].Flag; } set { this[nameof(bUseSaveGame)].Flag = value; } }
        public bool bIsHost { get { return this[nameof(bIsHost)].Flag; } set { this[nameof(bIsHost)].Flag = value; } }
        public Object GenerationManagerBPClass { get { return this[nameof(GenerationManagerBPClass)]; } set { this[nameof(GenerationManagerBPClass)] = value; } }
        public EventRequest Event { get { return this[nameof(Event)].As<EventRequest>(); } set { this["Event"] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public void Start() { Invoke(nameof(Start)); }
        public void OnPreloadingComplete() { Invoke(nameof(OnPreloadingComplete)); }
        public void OnGetWorldDataResponse(ServerResponse Response) { Invoke(nameof(OnGetWorldDataResponse), Response); }
        public void OnGetGameData(ServerResponse Response) { Invoke(nameof(OnGetGameData), Response); }
    }
    public class NeverendingQuestBehavior : QuestBehaviorBase
    {
        public NeverendingQuestBehavior(ulong addr) : base(addr) { }
    }
    public class OnEntityChangedEventArgs : EventArgs
    {
        public OnEntityChangedEventArgs(ulong addr) : base(addr) { }
        public Object GetEntity() { return Invoke<Object>(nameof(GetEntity)); }
        public Object GetContext() { return Invoke<Object>(nameof(GetContext)); }
        public EEntityActionType GetActionType() { return Invoke<EEntityActionType>(nameof(GetActionType)); }
    }
    public class OnHitRagdollComponent : ActorComponent
    {
        public OnHitRagdollComponent(ulong addr) : base(addr) { }
        public Object RootBoneName { get { return this[nameof(RootBoneName)]; } set { this[nameof(RootBoneName)] = value; } }
        public float CapsuleHalfHeight { get { return this[nameof(CapsuleHalfHeight)].GetValue<float>(); } set { this[nameof(CapsuleHalfHeight)].SetValue<float>(value); } }
        public float MinDelayBeforeGetUp { get { return this[nameof(MinDelayBeforeGetUp)].GetValue<float>(); } set { this[nameof(MinDelayBeforeGetUp)].SetValue<float>(value); } }
        public float MaxDelayBeforeGetUp { get { return this[nameof(MaxDelayBeforeGetUp)].GetValue<float>(); } set { this[nameof(MaxDelayBeforeGetUp)].SetValue<float>(value); } }
        public float GetUpVelocityThreshold { get { return this[nameof(GetUpVelocityThreshold)].GetValue<float>(); } set { this[nameof(GetUpVelocityThreshold)].SetValue<float>(value); } }
        public bool ShouldUpateCapsulePosition { get { return this[nameof(ShouldUpateCapsulePosition)].Flag; } set { this[nameof(ShouldUpateCapsulePosition)].Flag = value; } }
        public bool StopCapsuleCorrection { get { return this[nameof(StopCapsuleCorrection)].Flag; } set { this[nameof(StopCapsuleCorrection)].Flag = value; } }
        public Object BoneBlendName { get { return this[nameof(BoneBlendName)]; } set { this[nameof(BoneBlendName)] = value; } }
        public float PhysicBlendWeight { get { return this[nameof(PhysicBlendWeight)].GetValue<float>(); } set { this[nameof(PhysicBlendWeight)].SetValue<float>(value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public bool IsImmuneToCancel { get { return this[nameof(IsImmuneToCancel)].Flag; } set { this[nameof(IsImmuneToCancel)].Flag = value; } }
        public bool IsPlayer { get { return this[nameof(IsPlayer)].Flag; } set { this[nameof(IsPlayer)].Flag = value; } }
        public Object OnStartRagdoll { get { return this[nameof(OnStartRagdoll)]; } set { this[nameof(OnStartRagdoll)] = value; } }
        public Object OnStopRagdoll { get { return this[nameof(OnStopRagdoll)]; } set { this[nameof(OnStopRagdoll)] = value; } }
        public Object OnCancelAttack { get { return this[nameof(OnCancelAttack)]; } set { this[nameof(OnCancelAttack)] = value; } }
        public Object OnPlayHurtAnim { get { return this[nameof(OnPlayHurtAnim)]; } set { this[nameof(OnPlayHurtAnim)] = value; } }
        public AnimMontage HitReactionRight { get { return this[nameof(HitReactionRight)].As<AnimMontage>(); } set { this["HitReactionRight"] = value; } }
        public AnimMontage HitReactionLeft { get { return this[nameof(HitReactionLeft)].As<AnimMontage>(); } set { this["HitReactionLeft"] = value; } }
        public bool bUseRagdoll { get { return this[nameof(bUseRagdoll)].Flag; } set { this[nameof(bUseRagdoll)].Flag = value; } }
        public PhysicsAsset PhysicsAsset { get { return this[nameof(PhysicsAsset)].As<PhysicsAsset>(); } set { this["PhysicsAsset"] = value; } }
        public bool bIgnoreImpulse { get { return this[nameof(bIgnoreImpulse)].Flag; } set { this[nameof(bIgnoreImpulse)].Flag = value; } }
        public SkeletalMeshComponent meshToRagdoll { get { return this[nameof(meshToRagdoll)].As<SkeletalMeshComponent>(); } set { this["meshToRagdoll"] = value; } }
        public DefensiveComponent DefensiveComponent { get { return this[nameof(DefensiveComponent)].As<DefensiveComponent>(); } set { this["DefensiveComponent"] = value; } }
        public HealthComponent HealthComponent { get { return this[nameof(HealthComponent)].As<HealthComponent>(); } set { this["HealthComponent"] = value; } }
        public TOMCharacter Character { get { return this[nameof(Character)].As<TOMCharacter>(); } set { this["Character"] = value; } }
        public void StopRagdollClient() { Invoke(nameof(StopRagdollClient)); }
        public void StopRagdoll() { Invoke(nameof(StopRagdoll)); }
        public void PlayHurtAnimClient(Actor Source) { Invoke(nameof(PlayHurtAnimClient), Source); }
        public void OnDamageReceivedServer(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnDamageReceivedServer), Source, IssuedAmount, HitResult); }
        public void GoToRagdoll(Vector impulseVelocity, Object BoneName) { Invoke(nameof(GoToRagdoll), impulseVelocity, BoneName); }
        public bool GetIsInRagdoll() { return Invoke<bool>(nameof(GetIsInRagdoll)); }
        public void ApplyRagdollClient(Vector impulseVelocity, Object BoneName) { Invoke(nameof(ApplyRagdollClient), impulseVelocity, BoneName); }
    }
    public class OnPlayerReadyEventArgs : EventArgs
    {
        public OnPlayerReadyEventArgs(ulong addr) : base(addr) { }
        public TOMPlayerState GetPlayerState() { return Invoke<TOMPlayerState>(nameof(GetPlayerState)); }
    }
    public class OnTimeManagerReadyEventArgs : EventArgs
    {
        public OnTimeManagerReadyEventArgs(ulong addr) : base(addr) { }
        public TimeManager GetTimeManager() { return Invoke<TimeManager>(nameof(GetTimeManager)); }
    }
    public class OnWaterHitComponent : ActorComponent
    {
        public OnWaterHitComponent(ulong addr) : base(addr) { }
        public bool bPlayWaterVFX { get { return this[nameof(bPlayWaterVFX)].Flag; } set { this[nameof(bPlayWaterVFX)].Flag = value; } }
        public void StartListeningToCollider(PrimitiveComponent Collider) { Invoke(nameof(StartListeningToCollider), Collider); }
        public void OnCollide(PrimitiveComponent HitComponent, Actor OtherActor, PrimitiveComponent OtherComp, Vector NormalImpulse, HitResult Hit) { Invoke(nameof(OnCollide), HitComponent, OtherActor, OtherComp, NormalImpulse, Hit); }
    }
    public class PhysicHitComponent : ActorComponent
    {
        public PhysicHitComponent(ulong addr) : base(addr) { }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public float ImpactMultiplier { get { return this[nameof(ImpactMultiplier)].GetValue<float>(); } set { this[nameof(ImpactMultiplier)].SetValue<float>(value); } }
        public float DamageOnHit { get { return this[nameof(DamageOnHit)].GetValue<float>(); } set { this[nameof(DamageOnHit)].SetValue<float>(value); } }
        public Object DamageType { get { return this[nameof(DamageType)]; } set { this[nameof(DamageType)] = value; } }
        public void OnHitTriggeredClient(Actor hitActor, HitResult Hit, Vector Direction) { Invoke(nameof(OnHitTriggeredClient), hitActor, Hit, Direction); }
        public void OnHitTriggered(Actor hitActor, Vector Location, Vector Direction) { Invoke(nameof(OnHitTriggered), hitActor, Location, Direction); }
        public void DeactivateHit() { Invoke(nameof(DeactivateHit)); }
    }
    public class PlatformAuthenticationService : Object
    {
        public PlatformAuthenticationService(ulong addr) : base(addr) { }
    }
    public class PlayerLootManager : TOMActor
    {
        public PlayerLootManager(ulong addr) : base(addr) { }
        public Vector DeadLootForcedPosition { get { return this[nameof(DeadLootForcedPosition)].As<Vector>(); } set { this["DeadLootForcedPosition"] = value; } }
        public bool bUseDeadLootForcedPosition { get { return this[nameof(bUseDeadLootForcedPosition)].Flag; } set { this[nameof(bUseDeadLootForcedPosition)].Flag = value; } }
        public Object PlayerLootInstances { get { return this[nameof(PlayerLootInstances)]; } set { this[nameof(PlayerLootInstances)] = value; } }
        public Object TimerCallbacks { get { return this[nameof(TimerCallbacks)]; } set { this[nameof(TimerCallbacks)] = value; } }
        public Array<PlayerLootChestInfo> PlayerLootChestInfos { get { return new Array<PlayerLootChestInfo>(this[nameof(PlayerLootChestInfos)].Address); } }
        public void SpawnPlayerLootActor(Vector Location, Object UserId, Object PlayerChestContainerId) { Invoke(nameof(SpawnPlayerLootActor), Location, UserId, PlayerChestContainerId); }
        public void SpawnDroppedLootActor(LootInfoData LootInfoData) { Invoke(nameof(SpawnDroppedLootActor), LootInfoData); }
        public void SpawnDroppedLoot(LootInfoData LootInfoData) { Invoke(nameof(SpawnDroppedLoot), LootInfoData); }
        public void RemoveLootChest(Object UserId) { Invoke(nameof(RemoveLootChest), UserId); }
        public void ProcessPlayerDeath(Vector Location, UserEntityModel UserEntityModel, TOMCharacter PlayerCharacter) { Invoke(nameof(ProcessPlayerDeath), Location, UserEntityModel, PlayerCharacter); }
        public void PlayDeathVFX(Vector Location) { Invoke(nameof(PlayDeathVFX), Location); }
        public void OnChestTimerExpires(bool HasRespawned, Object EntityId) { Invoke(nameof(OnChestTimerExpires), HasRespawned, EntityId); }
        public bool LootSlotsByCategoryForUser(bool DropMaterialsOnly, Vector Location, UserEntityModel UserEntityModel, float KeepMaterialPercent, Object OutContainerId) { return Invoke<bool>(nameof(LootSlotsByCategoryForUser), DropMaterialsOnly, Location, UserEntityModel, KeepMaterialPercent, OutContainerId); }
        public Array<Vector> GetLootChestPositions(Object UserId) { return Invoke<Array<Vector>>(nameof(GetLootChestPositions), UserId); }
        public void CollectPlayerLoot(TOMPlayerController PlayerController, Object PlayerChestContainerId) { Invoke(nameof(CollectPlayerLoot), PlayerController, PlayerChestContainerId); }
        public void AddLootChest(Object UserId, Actor ChestActor, Object PlayerChestContainerId) { Invoke(nameof(AddLootChest), UserId, ChestActor, PlayerChestContainerId); }
    }
    public class PlayerMapIconBaseWidget : UserWidget
    {
        public PlayerMapIconBaseWidget(ulong addr) : base(addr) { }
        public Vector2D IconSize { get { return this[nameof(IconSize)].As<Vector2D>(); } set { this["IconSize"] = value; } }
        public void Update(PlayerMapInfo PlayerMapInfo) { Invoke(nameof(Update), PlayerMapInfo); }
        public void Init(PlayerMapInfo PlayerMapInfo) { Invoke(nameof(Init), PlayerMapInfo); }
    }
    public class TemperatureMonitorComponent : TOMActorComponent
    {
        public TemperatureMonitorComponent(ulong addr) : base(addr) { }
        public int CurrentTemperature { get { return this[nameof(CurrentTemperature)].GetValue<int>(); } set { this[nameof(CurrentTemperature)].SetValue<int>(value); } }
        public int ExternalModifiers { get { return this[nameof(ExternalModifiers)].GetValue<int>(); } set { this[nameof(ExternalModifiers)].SetValue<int>(value); } }
        public bool bIsPaused { get { return this[nameof(bIsPaused)].Flag; } set { this[nameof(bIsPaused)].Flag = value; } }
        public void UpdateTemperature() { Invoke(nameof(UpdateTemperature)); }
        public void SetPause(bool InIsPaused) { Invoke(nameof(SetPause), InIsPaused); }
        public void PostUpdateTemperature() { Invoke(nameof(PostUpdateTemperature)); }
        public void OnRep_CurrentTemperature() { Invoke(nameof(OnRep_CurrentTemperature)); }
        public void OnEntityChangeBiome(int BiomeId, int Level) { Invoke(nameof(OnEntityChangeBiome), BiomeId, Level); }
        public int GetCurrentTemperature() { return Invoke<int>(nameof(GetCurrentTemperature)); }
        public void ApplyExternalModifier(int Value) { Invoke(nameof(ApplyExternalModifier), Value); }
    }
    public class PlayerTemperatureMonitorComponent : TemperatureMonitorComponent
    {
        public PlayerTemperatureMonitorComponent(ulong addr) : base(addr) { }
        public Object OnResistanceChanged { get { return this[nameof(OnResistanceChanged)]; } set { this[nameof(OnResistanceChanged)] = value; } }
        public Object OnTemperatureChanged { get { return this[nameof(OnTemperatureChanged)]; } set { this[nameof(OnTemperatureChanged)] = value; } }
        public Object OnHotStart { get { return this[nameof(OnHotStart)]; } set { this[nameof(OnHotStart)] = value; } }
        public Object OnHotEnd { get { return this[nameof(OnHotEnd)]; } set { this[nameof(OnHotEnd)] = value; } }
        public Object OnColdStart { get { return this[nameof(OnColdStart)]; } set { this[nameof(OnColdStart)] = value; } }
        public Object OnColdEnd { get { return this[nameof(OnColdEnd)]; } set { this[nameof(OnColdEnd)] = value; } }
        public int DefaultColdResistance { get { return this[nameof(DefaultColdResistance)].GetValue<int>(); } set { this[nameof(DefaultColdResistance)].SetValue<int>(value); } }
        public int DefaultHotResistance { get { return this[nameof(DefaultHotResistance)].GetValue<int>(); } set { this[nameof(DefaultHotResistance)].SetValue<int>(value); } }
        public int TemperatureGaugeSize { get { return this[nameof(TemperatureGaugeSize)].GetValue<int>(); } set { this[nameof(TemperatureGaugeSize)].SetValue<int>(value); } }
        public float TemperatureAlter { get { return this[nameof(TemperatureAlter)].GetValue<float>(); } set { this[nameof(TemperatureAlter)].SetValue<float>(value); } }
        public float CurrentTemperatureGaugeValue { get { return this[nameof(CurrentTemperatureGaugeValue)].GetValue<float>(); } set { this[nameof(CurrentTemperatureGaugeValue)].SetValue<float>(value); } }
        public float TempratureGaugeDecayRate { get { return this[nameof(TempratureGaugeDecayRate)].GetValue<float>(); } set { this[nameof(TempratureGaugeDecayRate)].SetValue<float>(value); } }
        public int MinTemperature { get { return this[nameof(MinTemperature)].GetValue<int>(); } set { this[nameof(MinTemperature)].SetValue<int>(value); } }
        public int MaxTemperature { get { return this[nameof(MaxTemperature)].GetValue<int>(); } set { this[nameof(MaxTemperature)].SetValue<int>(value); } }
        public int ColdResistance { get { return this[nameof(ColdResistance)].GetValue<int>(); } set { this[nameof(ColdResistance)].SetValue<int>(value); } }
        public int HotResistance { get { return this[nameof(HotResistance)].GetValue<int>(); } set { this[nameof(HotResistance)].SetValue<int>(value); } }
        public int ColdResistanceExternalModifier { get { return this[nameof(ColdResistanceExternalModifier)].GetValue<int>(); } set { this[nameof(ColdResistanceExternalModifier)].SetValue<int>(value); } }
        public int HotResistanceExternalModifier { get { return this[nameof(HotResistanceExternalModifier)].GetValue<int>(); } set { this[nameof(HotResistanceExternalModifier)].SetValue<int>(value); } }
        public void UpdateStatus() { Invoke(nameof(UpdateStatus)); }
        public void UpdateResistance() { Invoke(nameof(UpdateResistance)); }
        public void ResetStatus() { Invoke(nameof(ResetStatus)); }
        public void OnRep_Resistance() { Invoke(nameof(OnRep_Resistance)); }
        public float GetStatusCooldownProgress() { return Invoke<float>(nameof(GetStatusCooldownProgress)); }
        public int GetMinTemperature() { return Invoke<int>(nameof(GetMinTemperature)); }
        public int GetMaxTemperature() { return Invoke<int>(nameof(GetMaxTemperature)); }
        public int GetHotResistance() { return Invoke<int>(nameof(GetHotResistance)); }
        public float GetHotRatioPreview(ArmorDataModel ArmorDataModel) { return Invoke<float>(nameof(GetHotRatioPreview), ArmorDataModel); }
        public float GetHotRatio() { return Invoke<float>(nameof(GetHotRatio)); }
        public ETemperatureType GetCurrentStatus() { return Invoke<ETemperatureType>(nameof(GetCurrentStatus)); }
        public int GetColdResistance() { return Invoke<int>(nameof(GetColdResistance)); }
        public float GetColdRatioPreview(ArmorDataModel ArmorDataModel) { return Invoke<float>(nameof(GetColdRatioPreview), ArmorDataModel); }
        public float GetColdRatio() { return Invoke<float>(nameof(GetColdRatio)); }
        public void ApplyHotResistanceModifier(int Value) { Invoke(nameof(ApplyHotResistanceModifier), Value); }
        public void ApplyColdResistanceModifier(int Value) { Invoke(nameof(ApplyColdResistanceModifier), Value); }
    }
    public class POIMapIconBaseWidget : UserWidget
    {
        public POIMapIconBaseWidget(ulong addr) : base(addr) { }
        public Vector2D IconSize { get { return this[nameof(IconSize)].As<Vector2D>(); } set { this["IconSize"] = value; } }
        public float RenderAngle { get { return this[nameof(RenderAngle)].GetValue<float>(); } set { this[nameof(RenderAngle)].SetValue<float>(value); } }
        public WorldmapWidget ParentWidget { get { return this[nameof(ParentWidget)].As<WorldmapWidget>(); } set { this["ParentWidget"] = value; } }
        public Image IconWidget { get { return this[nameof(IconWidget)].As<Image>(); } set { this["IconWidget"] = value; } }
        public Object TextureCooldown { get { return this[nameof(TextureCooldown)]; } set { this[nameof(TextureCooldown)] = value; } }
        public Object TextureNormal { get { return this[nameof(TextureNormal)]; } set { this[nameof(TextureNormal)] = value; } }
        public void SetIconSize(Vector2D InIconSize) { Invoke(nameof(SetIconSize), InIconSize); }
        public void Refresh(bool bHasRespawned) { Invoke(nameof(Refresh), bHasRespawned); }
        public void Init(POIIcon POIIcon, bool bUseDecal, WorldmapWidget Parent) { Invoke(nameof(Init), POIIcon, bUseDecal, Parent); }
    }
    public class PopupManagerGameInstanceSubsystem : GameInstanceSubsystem
    {
        public PopupManagerGameInstanceSubsystem(ulong addr) : base(addr) { }
        public Object OnShowMessageOverlay { get { return this[nameof(OnShowMessageOverlay)]; } set { this[nameof(OnShowMessageOverlay)] = value; } }
        public Object OnOpenPopup { get { return this[nameof(OnOpenPopup)]; } set { this[nameof(OnOpenPopup)] = value; } }
        public Object OnOpenInfoPopup { get { return this[nameof(OnOpenInfoPopup)]; } set { this[nameof(OnOpenInfoPopup)] = value; } }
        public Object OnClosePopup { get { return this[nameof(OnClosePopup)]; } set { this[nameof(OnClosePopup)] = value; } }
        public Object OnCloseAllPopup { get { return this[nameof(OnCloseAllPopup)]; } set { this[nameof(OnCloseAllPopup)] = value; } }
        public Object OnShowProcessingUI { get { return this[nameof(OnShowProcessingUI)]; } set { this[nameof(OnShowProcessingUI)] = value; } }
        public void ShowProcessingUI(bool Show, Object Message) { Invoke(nameof(ShowProcessingUI), Show, Message); }
        public void ShowMessageOverlay(Object Title, Object Message) { Invoke(nameof(ShowMessageOverlay), Title, Message); }
        public void OpenPopup(EPopupType Type) { Invoke(nameof(OpenPopup), Type); }
        public void OpenInfoPopup(Object Title, Object Message) { Invoke(nameof(OpenInfoPopup), Title, Message); }
        public void ClosePopup(EPopupType Type) { Invoke(nameof(ClosePopup), Type); }
        public void CloseAllPopup() { Invoke(nameof(CloseAllPopup)); }
    }
    public class PostProcessActor : Actor
    {
        public PostProcessActor(ulong addr) : base(addr) { }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public BoxComponent BoxComponent { get { return this[nameof(BoxComponent)].As<BoxComponent>(); } set { this["BoxComponent"] = value; } }
        public PostProcessComponent PostProcessComponent { get { return this[nameof(PostProcessComponent)].As<PostProcessComponent>(); } set { this["PostProcessComponent"] = value; } }
        public void SetEnabled(bool bValue) { Invoke(nameof(SetEnabled), bValue); }
    }
    public class PostProcessManager : TOMActor
    {
        public PostProcessManager(ulong addr) : base(addr) { }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public PostProcessComponent PostProcessComponent { get { return this[nameof(PostProcessComponent)].As<PostProcessComponent>(); } set { this["PostProcessComponent"] = value; } }
        public MaterialInterface TOMPostProcessMaterial { get { return this[nameof(TOMPostProcessMaterial)].As<MaterialInterface>(); } set { this["TOMPostProcessMaterial"] = value; } }
        public float TOMPostProcessWeight { get { return this[nameof(TOMPostProcessWeight)].GetValue<float>(); } set { this[nameof(TOMPostProcessWeight)].SetValue<float>(value); } }
        public MaterialInterface TOMFOGPostProcessMaterial { get { return this[nameof(TOMFOGPostProcessMaterial)].As<MaterialInterface>(); } set { this["TOMFOGPostProcessMaterial"] = value; } }
        public float TOMFOGPostProcessWeight { get { return this[nameof(TOMFOGPostProcessWeight)].GetValue<float>(); } set { this[nameof(TOMFOGPostProcessWeight)].SetValue<float>(value); } }
        public Object DeathDesaturationParamName { get { return this[nameof(DeathDesaturationParamName)]; } set { this[nameof(DeathDesaturationParamName)] = value; } }
        public float DeathDesaturationSpeed { get { return this[nameof(DeathDesaturationSpeed)].GetValue<float>(); } set { this[nameof(DeathDesaturationSpeed)].SetValue<float>(value); } }
        public Object BloodMoonParamName { get { return this[nameof(BloodMoonParamName)]; } set { this[nameof(BloodMoonParamName)] = value; } }
        public Object DaytimeParamName { get { return this[nameof(DaytimeParamName)]; } set { this[nameof(DaytimeParamName)] = value; } }
        public Object DaytimeGradients { get { return this[nameof(DaytimeGradients)]; } set { this[nameof(DaytimeGradients)] = value; } }
        public Object ColdParamName { get { return this[nameof(ColdParamName)]; } set { this[nameof(ColdParamName)] = value; } }
        public Object HotParamName { get { return this[nameof(HotParamName)]; } set { this[nameof(HotParamName)] = value; } }
        public MaterialInstanceDynamic FOGMaterialInstanceDynamic { get { return this[nameof(FOGMaterialInstanceDynamic)].As<MaterialInstanceDynamic>(); } set { this["FOGMaterialInstanceDynamic"] = value; } }
        public MaterialInstanceDynamic TOMDynamicMaterial { get { return this[nameof(TOMDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["TOMDynamicMaterial"] = value; } }
        public MaterialInstanceDynamic CaveDynamicMaterial { get { return this[nameof(CaveDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["CaveDynamicMaterial"] = value; } }
        public PlayerTemperatureMonitorComponent TemperatureMonitorComponent { get { return this[nameof(TemperatureMonitorComponent)].As<PlayerTemperatureMonitorComponent>(); } set { this["TemperatureMonitorComponent"] = value; } }
        public HealthComponent CharacterHealth { get { return this[nameof(CharacterHealth)].As<HealthComponent>(); } set { this["CharacterHealth"] = value; } }
        public Object PendingFloatValues { get { return this[nameof(PendingFloatValues)]; } set { this[nameof(PendingFloatValues)] = value; } }
        public Object PendingVectorValues { get { return this[nameof(PendingVectorValues)]; } set { this[nameof(PendingVectorValues)] = value; } }
        public void SetVectorParameter(Object Name, Vector Value) { Invoke(nameof(SetVectorParameter), Name, Value); }
        public void SetTempEffectEnabled(bool bEnabled) { Invoke(nameof(SetTempEffectEnabled), bEnabled); }
        public void SetScalarParameter(Object Name, float Value) { Invoke(nameof(SetScalarParameter), Name, Value); }
        public void SetEnabled(bool bEnabled) { Invoke(nameof(SetEnabled), bEnabled); }
        public void OnTemperatureChange() { Invoke(nameof(OnTemperatureChange)); }
        public void OnEnterExitCave(TOMCharacter TOMCharacter) { Invoke(nameof(OnEnterExitCave), TOMCharacter); }
        public void OnCharacterLeaveDownState(HealthComponent healthComp) { Invoke(nameof(OnCharacterLeaveDownState), healthComp); }
        public void OnCharacterEnterDownState(HealthComponent healthComp) { Invoke(nameof(OnCharacterEnterDownState), healthComp); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public MaterialInstanceDynamic GetFOGMaterialInstanceDynamic() { return Invoke<MaterialInstanceDynamic>(nameof(GetFOGMaterialInstanceDynamic)); }
    }
    public class PostProcessVolumeChunkActor : Object
    {
        public PostProcessVolumeChunkActor(ulong addr) : base(addr) { }
        public PostProcessActor FogPPV { get { return this[nameof(FogPPV)].As<PostProcessActor>(); } set { this["FogPPV"] = value; } }
    }
    public class PrisonerGameEvent : GameEventBase
    {
        public PrisonerGameEvent(ulong addr) : base(addr) { }
        public Array<Object> HazardLayouts { get { return new Array<Object>(this[nameof(HazardLayouts)].Address); } }
        public float DelayBeforeLootSpawn { get { return this[nameof(DelayBeforeLootSpawn)].GetValue<float>(); } set { this[nameof(DelayBeforeLootSpawn)].SetValue<float>(value); } }
        public Array<int> PrisonerHazardIds { get { return new Array<int>(this[nameof(PrisonerHazardIds)].Address); } }
        public Array<int> PrisonerCreatureIds { get { return new Array<int>(this[nameof(PrisonerCreatureIds)].Address); } }
        public float DelayBeforeDestroyStep { get { return this[nameof(DelayBeforeDestroyStep)].GetValue<float>(); } set { this[nameof(DelayBeforeDestroyStep)].SetValue<float>(value); } }
        public bool KillSecondaryHazardOnStepCompletion { get { return this[nameof(KillSecondaryHazardOnStepCompletion)].Flag; } set { this[nameof(KillSecondaryHazardOnStepCompletion)].Flag = value; } }
        public float DelayBeforeSecondaryHazardDestruction { get { return this[nameof(DelayBeforeSecondaryHazardDestruction)].GetValue<float>(); } set { this[nameof(DelayBeforeSecondaryHazardDestruction)].SetValue<float>(value); } }
        public bool KillMainHazardOnStepCompletion { get { return this[nameof(KillMainHazardOnStepCompletion)].Flag; } set { this[nameof(KillMainHazardOnStepCompletion)].Flag = value; } }
        public Object PrisonerRegions { get { return this[nameof(PrisonerRegions)]; } set { this[nameof(PrisonerRegions)] = value; } }
        public Array<ContainerEntityModel> PendingLoot { get { return new Array<ContainerEntityModel>(this[nameof(PendingLoot)].Address); } }
        public void SpawnEventLoot(Actor LootSpawner) { Invoke(nameof(SpawnEventLoot), LootSpawner); }
        public void OnSpawnLootForEventStep(Object EntityId, Actor LootSpawner) { Invoke(nameof(OnSpawnLootForEventStep), EntityId, LootSpawner); }
        public bool IsStepTriggered(Object EntityId) { return Invoke<bool>(nameof(IsStepTriggered), EntityId); }
        public void EventStepTrigger(Object EntityId, Actor LootSpawner) { Invoke(nameof(EventStepTrigger), EntityId, LootSpawner); }
        public void DestroySecondaryHazards(int RegionId) { Invoke(nameof(DestroySecondaryHazards), RegionId); }
        public void DelayedStepCompletion(int RegionId, Actor LootSpawner) { Invoke(nameof(DelayedStepCompletion), RegionId, LootSpawner); }
    }
    public class ProfilingUtility : Object
    {
        public ProfilingUtility(ulong addr) : base(addr) { }
        public ProfilingTimer StartTimer(Object Name) { return Invoke<ProfilingTimer>(nameof(StartTimer), Name); }
        public ProfilingTimer EndTimer(bool bLogProfilingTime) { return Invoke<ProfilingTimer>(nameof(EndTimer), bLogProfilingTime); }
    }
    public class PropsChunkActor : Object
    {
        public PropsChunkActor(ulong addr) : base(addr) { }
        public Array<Actor> Hazards { get { return new Array<Actor>(this[nameof(Hazards)].Address); } }
        public Array<Actor> Surfaces { get { return new Array<Actor>(this[nameof(Surfaces)].Address); } }
        public Array<ServerModule> ServerModules { get { return new Array<ServerModule>(this[nameof(ServerModules)].Address); } }
        public Array<Actor> Props { get { return new Array<Actor>(this[nameof(Props)].Address); } }
    }
    public class PurchaseShopOfferAsyncAction : BlueprintAsyncActionBase
    {
        public PurchaseShopOfferAsyncAction(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public EventRequest PurchaseShopOfferEventRequest { get { return this[nameof(PurchaseShopOfferEventRequest)].As<EventRequest>(); } set { this["PurchaseShopOfferEventRequest"] = value; } }
        public PurchaseShopOfferAsyncAction PurchaseShopOffer(ShopItemDataModel Item) { return Invoke<PurchaseShopOfferAsyncAction>(nameof(PurchaseShopOffer), Item); }
        public void OnPurchaseCosmeticsSuccess(ServerResponse Success) { Invoke(nameof(OnPurchaseCosmeticsSuccess), Success); }
        public void OnPurchaseCosmeticsError(ServerResponse Error) { Invoke(nameof(OnPurchaseCosmeticsError), Error); }
    }
    public class QuestEntityModel : EntityModelBase
    {
        public QuestEntityModel(ulong addr) : base(addr) { }
        public Array<Object> ProgressParams { get { return new Array<Object>(this[nameof(ProgressParams)].Address); } }
        public QuestVO VO { get { return this[nameof(VO)].As<QuestVO>(); } set { this["VO"] = value; } }
        public EQuestStatus GetStatus() { return Invoke<EQuestStatus>(nameof(GetStatus)); }
        public Object GetQuestGiverId() { return Invoke<Object>(nameof(GetQuestGiverId)); }
        public QuestEntityModel GetQuestEntityModel(Object PlayerId, Object QuestGiverId, int QuestDataId) { return Invoke<QuestEntityModel>(nameof(GetQuestEntityModel), PlayerId, QuestGiverId, QuestDataId); }
        public QuestDataModel GetQuestData() { return Invoke<QuestDataModel>(nameof(GetQuestData)); }
        public Object GetPlayerId() { return Invoke<Object>(nameof(GetPlayerId)); }
        public QuestEntityModel GetOrCreateEntity(Object Outer, Object EntityId, Object PlayerId, Object QuestGiverId, int QuestDataId, float ActivationTime, bool bIsSaga, Object NPCEntityId) { return Invoke<QuestEntityModel>(nameof(GetOrCreateEntity), Outer, EntityId, PlayerId, QuestGiverId, QuestDataId, ActivationTime, bIsSaga, NPCEntityId); }
        public Object GetNPCEntityId() { return Invoke<Object>(nameof(GetNPCEntityId)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public Object GetDescriptionWithParams() { return Invoke<Object>(nameof(GetDescriptionWithParams)); }
        public Object GetContainerEntityId() { return Invoke<Object>(nameof(GetContainerEntityId)); }
    }
    public class QuestManager : TOMActor
    {
        public QuestManager(ulong addr) : base(addr) { }
        public Object OnQuestStart { get { return this[nameof(OnQuestStart)]; } set { this[nameof(OnQuestStart)] = value; } }
        public Object OnQuestComplete { get { return this[nameof(OnQuestComplete)]; } set { this[nameof(OnQuestComplete)] = value; } }
        public Object OnQuestEntitiesChanged { get { return this[nameof(OnQuestEntitiesChanged)]; } set { this[nameof(OnQuestEntitiesChanged)] = value; } }
        public Array<QuestEntityModel> QuestEntities { get { return new Array<QuestEntityModel>(this[nameof(QuestEntities)].Address); } }
        public Object LiveQuests { get { return this[nameof(LiveQuests)]; } set { this[nameof(LiveQuests)] = value; } }
        public QuestEntityModel SagaQuestEntity { get { return this[nameof(SagaQuestEntity)].As<QuestEntityModel>(); } set { this["SagaQuestEntity"] = value; } }
        public QuestBehaviorBase SagaQuestBehavior { get { return this[nameof(SagaQuestBehavior)].As<QuestBehaviorBase>(); } set { this["SagaQuestBehavior"] = value; } }
        public Object RespawnCallbacks { get { return this[nameof(RespawnCallbacks)]; } set { this[nameof(RespawnCallbacks)] = value; } }
        public void StartPersonalQuest(Object PlayerId, TOMPlayerController PlayerController, Object QuestGiverId, int QuestDataId) { Invoke(nameof(StartPersonalQuest), PlayerId, PlayerController, QuestGiverId, QuestDataId); }
        public void OnQuestRespawn(bool bRespawned, Object EntityId) { Invoke(nameof(OnQuestRespawn), bRespawned, EntityId); }
        public void OnQuestEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnQuestEntityChanged), Entity, Context); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public QuestEntityModel GetPlayerQuest(Object PlayerId, Object QuestGiverId) { return Invoke<QuestEntityModel>(nameof(GetPlayerQuest), PlayerId, QuestGiverId); }
        public Array<Object> GetInteractablePlayerEntityIds(Object QuestGiverId) { return Invoke<Array<Object>>(nameof(GetInteractablePlayerEntityIds), QuestGiverId); }
        public void FinishPersonalQuest(QuestEntityModel QuestEntity, Vector Location) { Invoke(nameof(FinishPersonalQuest), QuestEntity, Location); }
        public void ClearPlayerQuests(Object PlayerId, TOMPlayerController PlayerController) { Invoke(nameof(ClearPlayerQuests), PlayerId, PlayerController); }
    }
    public class RaycastUtility : Object
    {
        public RaycastUtility(ulong addr) : base(addr) { }
        public bool FindGroundLocationInDonut(Vector OutLocation, Object WorldContextObject, Vector OriginLocation, float MinDispersion, float MaxDispersion, float MinAngle, float MaxAngle, float MinHeight, float MaxHeight, float MaxHeightDifference, int MaxAttemptCount, bool ProjectToNavMesh, bool bReadjustZOnHitLocation) { return Invoke<bool>(nameof(FindGroundLocationInDonut), OutLocation, WorldContextObject, OriginLocation, MinDispersion, MaxDispersion, MinAngle, MaxAngle, MinHeight, MaxHeight, MaxHeightDifference, MaxAttemptCount, ProjectToNavMesh, bReadjustZOnHitLocation); }
        public Actor FindClosestNearbyActorInCone(float RadiusSqr, float Angle, Actor Source, Vector Direction, Array<Actor> NearbyActors, Actor FavoredTarget, float AutoIncludeRadiusSqr) { return Invoke<Actor>(nameof(FindClosestNearbyActorInCone), RadiusSqr, Angle, Source, Direction, NearbyActors, FavoredTarget, AutoIncludeRadiusSqr); }
        public Actor FindClosestActorInChannels(Object WorldContextObject, float Radius, Vector Origin, Array<Actor> ActorsToIgnore, Array<int> Channels) { return Invoke<Actor>(nameof(FindClosestActorInChannels), WorldContextObject, Radius, Origin, ActorsToIgnore, Channels); }
        public bool CheckForCollisionAndTryToAdjust(Object WorldContextObject, Vector Origin, Vector Extents, Quat Rotation, EAdjustmentMethod AdjustmentMethod, Vector OutLocation) { return Invoke<bool>(nameof(CheckForCollisionAndTryToAdjust), WorldContextObject, Origin, Extents, Rotation, AdjustmentMethod, OutLocation); }
    }
    public class RecoveryState : AnimNotifyState
    {
        public RecoveryState(ulong addr) : base(addr) { }
    }
    public class RegionData : Object
    {
        public RegionData(ulong addr) : base(addr) { }
        public Array<NeighborData> Neighbors { get { return new Array<NeighborData>(this[nameof(Neighbors)].Address); } }
        public Array<IntPoint> RampCoordinates { get { return new Array<IntPoint>(this[nameof(RampCoordinates)].Address); } }
    }
    public class ResourcesProvider : BifrostObject
    {
        public ResourcesProvider(ulong addr) : base(addr) { }
        public GenerationManager GenerationManager { get { return this[nameof(GenerationManager)].As<GenerationManager>(); } set { this["GenerationManager"] = value; } }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
    }
    public class RespawnableInterface : Interface
    {
        public RespawnableInterface(ulong addr) : base(addr) { }
    }
    public class RespawnableManager : TOMActor
    {
        public RespawnableManager(ulong addr) : base(addr) { }
        public Array<RespawnTimerVO> ReplicatedRespawnTimers { get { return new Array<RespawnTimerVO>(this[nameof(ReplicatedRespawnTimers)].Address); } }
        public Array<RespawnTimerVO> RespawnTimers { get { return new Array<RespawnTimerVO>(this[nameof(RespawnTimers)].Address); } }
        public Object EntityToCallbacks { get { return this[nameof(EntityToCallbacks)]; } set { this[nameof(EntityToCallbacks)] = value; } }
        public void UnregisterRespawnableStatusChangeCallback(Object Callback, Object EntityId) { Invoke(nameof(UnregisterRespawnableStatusChangeCallback), Callback, EntityId); }
        public void UnRegisterRespawnable(Object Respawnable) { Invoke(nameof(UnRegisterRespawnable), Respawnable); }
        public void StartRespawnTimerForId(Object ID, float InTimer, bool bIsReplicatedTimer) { Invoke(nameof(StartRespawnTimerForId), ID, InTimer, bIsReplicatedTimer); }
        public void StartRespawnTimer(Object Respawnable) { Invoke(nameof(StartRespawnTimer), Respawnable); }
        public void RespawnCallbackMulticast(Object ID, bool bRespawned) { Invoke(nameof(RespawnCallbackMulticast), ID, bRespawned); }
        public void RegisterRespawnableStatusChangeCallback(Object Callback, Object EntityId) { Invoke(nameof(RegisterRespawnableStatusChangeCallback), Callback, EntityId); }
        public void RegisterRespawnable(Object Respawnable) { Invoke(nameof(RegisterRespawnable), Respawnable); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public bool IsRespawning(Object ID) { return Invoke<bool>(nameof(IsRespawning), ID); }
        public float GetRespawnTime(Object ID) { return Invoke<float>(nameof(GetRespawnTime), ID); }
        public void ForceRespawn(Object ID) { Invoke(nameof(ForceRespawn), ID); }
        public void CreatureDied(WorldCreatureEntityModel WorldCreatureEntity) { Invoke(nameof(CreatureDied), WorldCreatureEntity); }
        public bool CancelTimerForId(Object ID, bool bIsReplicatedTimer) { return Invoke<bool>(nameof(CancelTimerForId), ID, bIsReplicatedTimer); }
    }
    public class RichTextBlockInlineDecorator : RichTextBlockDecorator
    {
        public RichTextBlockInlineDecorator(ulong addr) : base(addr) { }
    }
    public class RootMotionMovementAnimInstance : AnimInstance
    {
        public RootMotionMovementAnimInstance(ulong addr) : base(addr) { }
        public float WalkSpeed { get { return this[nameof(WalkSpeed)].GetValue<float>(); } set { this[nameof(WalkSpeed)].SetValue<float>(value); } }
        public float Angle { get { return this[nameof(Angle)].GetValue<float>(); } set { this[nameof(Angle)].SetValue<float>(value); } }
        public float CurrentAngle { get { return this[nameof(CurrentAngle)].GetValue<float>(); } set { this[nameof(CurrentAngle)].SetValue<float>(value); } }
        public bool TriggerSegmentReached { get { return this[nameof(TriggerSegmentReached)].Flag; } set { this[nameof(TriggerSegmentReached)].Flag = value; } }
        public bool Attack { get { return this[nameof(Attack)].Flag; } set { this[nameof(Attack)].Flag = value; } }
        public bool StopAnimations { get { return this[nameof(StopAnimations)].Flag; } set { this[nameof(StopAnimations)].Flag = value; } }
    }
    public class RootMotionPathFollowingComponent : PathFollowingComponent
    {
        public RootMotionPathFollowingComponent(ulong addr) : base(addr) { }
        public float ForceAcceptanceRadius { get { return this[nameof(ForceAcceptanceRadius)].GetValue<float>(); } set { this[nameof(ForceAcceptanceRadius)].SetValue<float>(value); } }
        public float timeToFindAngle { get { return this[nameof(timeToFindAngle)].GetValue<float>(); } set { this[nameof(timeToFindAngle)].SetValue<float>(value); } }
    }
    public class SandboxGameMode : TOMGameModeBase
    {
        public SandboxGameMode(ulong addr) : base(addr) { }
    }
    public class SandboxLevelScriptActor : TOMLevelScriptActor
    {
        public SandboxLevelScriptActor(ulong addr) : base(addr) { }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
        public EventRequest Event { get { return this[nameof(Event)].As<EventRequest>(); } set { this["Event"] = value; } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public Object GenerationManagerBPClass { get { return this[nameof(GenerationManagerBPClass)]; } set { this[nameof(GenerationManagerBPClass)] = value; } }
        public Object IconManagerBPClass { get { return this[nameof(IconManagerBPClass)]; } set { this[nameof(IconManagerBPClass)] = value; } }
        public Object ConstructionManagerBPClass { get { return this[nameof(ConstructionManagerBPClass)]; } set { this[nameof(ConstructionManagerBPClass)] = value; } }
        public void OnGetWorldListDataResponse(ServerResponse Response) { Invoke(nameof(OnGetWorldListDataResponse), Response); }
        public void OnGetWorldDataResponse(ServerResponse Response) { Invoke(nameof(OnGetWorldDataResponse), Response); }
        public void OnGetUserData(ServerResponse Response) { Invoke(nameof(OnGetUserData), Response); }
        public void OnGetGameData(ServerResponse Response) { Invoke(nameof(OnGetGameData), Response); }
        public void OnCreateWorldDataResponse(ServerResponse Response) { Invoke(nameof(OnCreateWorldDataResponse), Response); }
        public void InitializePool() { Invoke(nameof(InitializePool)); }
    }
    public class ServerModule : TOMActor
    {
        public ServerModule(ulong addr) : base(addr) { }
        public IntVector WorldPos { get { return this[nameof(WorldPos)].As<IntVector>(); } set { this["WorldPos"] = value; } }
        public CaveEntityModel CaveEntityModel { get { return this[nameof(CaveEntityModel)].As<CaveEntityModel>(); } set { this["CaveEntityModel"] = value; } }
        public void OnRep_WorldPos() { Invoke(nameof(OnRep_WorldPos)); }
    }
    public class SettingsSave : SaveGame
    {
        public SettingsSave(ulong addr) : base(addr) { }
        public Object OnKeyMappingChanged { get { return this[nameof(OnKeyMappingChanged)]; } set { this[nameof(OnKeyMappingChanged)] = value; } }
        public Object OnIsDisplayingNameChanged { get { return this[nameof(OnIsDisplayingNameChanged)]; } set { this[nameof(OnIsDisplayingNameChanged)] = value; } }
        public Object OnDisplayYggdrasilHPChanged { get { return this[nameof(OnDisplayYggdrasilHPChanged)]; } set { this[nameof(OnDisplayYggdrasilHPChanged)] = value; } }
        public Object OnDisplayHUDChanged { get { return this[nameof(OnDisplayHUDChanged)]; } set { this[nameof(OnDisplayHUDChanged)] = value; } }
        public Object OnAimAssistChanged { get { return this[nameof(OnAimAssistChanged)]; } set { this[nameof(OnAimAssistChanged)] = value; } }
        public Object OnPointerArrowChanged { get { return this[nameof(OnPointerArrowChanged)]; } set { this[nameof(OnPointerArrowChanged)] = value; } }
        public Object OnDisplayHPCountChanged { get { return this[nameof(OnDisplayHPCountChanged)]; } set { this[nameof(OnDisplayHPCountChanged)] = value; } }
        public Object OnIsPushToTalkChanged { get { return this[nameof(OnIsPushToTalkChanged)]; } set { this[nameof(OnIsPushToTalkChanged)] = value; } }
        public Object OnVoiceChatEnabledChanged { get { return this[nameof(OnVoiceChatEnabledChanged)]; } set { this[nameof(OnVoiceChatEnabledChanged)] = value; } }
        public Object SaveSlotName { get { return this[nameof(SaveSlotName)]; } set { this[nameof(SaveSlotName)] = value; } }
        public uint UserIndex { get { return this[nameof(UserIndex)].GetValue<uint>(); } set { this[nameof(UserIndex)].SetValue<uint>(value); } }
        public int QualityLevel { get { return this[nameof(QualityLevel)].GetValue<int>(); } set { this[nameof(QualityLevel)].SetValue<int>(value); } }
        public IntPoint Resolution { get { return this[nameof(Resolution)].As<IntPoint>(); } set { this["Resolution"] = value; } }
        public bool VSync { get { return this[nameof(VSync)].Flag; } set { this[nameof(VSync)].Flag = value; } }
        public bool bIsVibrationOn { get { return this[nameof(bIsVibrationOn)].Flag; } set { this[nameof(bIsVibrationOn)].Flag = value; } }
        public bool bIsDisplayingName { get { return this[nameof(bIsDisplayingName)].Flag; } set { this[nameof(bIsDisplayingName)].Flag = value; } }
        public bool bDisplayYggdrasilHP { get { return this[nameof(bDisplayYggdrasilHP)].Flag; } set { this[nameof(bDisplayYggdrasilHP)].Flag = value; } }
        public bool bDisplayHPCount { get { return this[nameof(bDisplayHPCount)].Flag; } set { this[nameof(bDisplayHPCount)].Flag = value; } }
        public bool bAimAssist { get { return this[nameof(bAimAssist)].Flag; } set { this[nameof(bAimAssist)].Flag = value; } }
        public bool bPointerArrow { get { return this[nameof(bPointerArrow)].Flag; } set { this[nameof(bPointerArrow)].Flag = value; } }
        public int WindowMode { get { return this[nameof(WindowMode)].GetValue<int>(); } set { this[nameof(WindowMode)].SetValue<int>(value); } }
        public float FrameRate { get { return this[nameof(FrameRate)].GetValue<float>(); } set { this[nameof(FrameRate)].SetValue<float>(value); } }
        public int ShadowQuality { get { return this[nameof(ShadowQuality)].GetValue<int>(); } set { this[nameof(ShadowQuality)].SetValue<int>(value); } }
        public int AntiAliasingQuality { get { return this[nameof(AntiAliasingQuality)].GetValue<int>(); } set { this[nameof(AntiAliasingQuality)].SetValue<int>(value); } }
        public int TextureQuality { get { return this[nameof(TextureQuality)].GetValue<int>(); } set { this[nameof(TextureQuality)].SetValue<int>(value); } }
        public int EffectQuality { get { return this[nameof(EffectQuality)].GetValue<int>(); } set { this[nameof(EffectQuality)].SetValue<int>(value); } }
        public Array<float> SupportedFramerates { get { return new Array<float>(this[nameof(SupportedFramerates)].Address); } }
        public Array<IntPoint> SupportedResolution { get { return new Array<IntPoint>(this[nameof(SupportedResolution)].Address); } }
        public int MusicVolume { get { return this[nameof(MusicVolume)].GetValue<int>(); } set { this[nameof(MusicVolume)].SetValue<int>(value); } }
        public int SFXVolume { get { return this[nameof(SFXVolume)].GetValue<int>(); } set { this[nameof(SFXVolume)].SetValue<int>(value); } }
        public int VoiceChatVolume { get { return this[nameof(VoiceChatVolume)].GetValue<int>(); } set { this[nameof(VoiceChatVolume)].SetValue<int>(value); } }
        public bool bVoiceChatEnabled { get { return this[nameof(bVoiceChatEnabled)].Flag; } set { this[nameof(bVoiceChatEnabled)].Flag = value; } }
        public bool bIsPushToTalk { get { return this[nameof(bIsPushToTalk)].Flag; } set { this[nameof(bIsPushToTalk)].Flag = value; } }
        public bool bTextChatEnabled { get { return this[nameof(bTextChatEnabled)].Flag; } set { this[nameof(bTextChatEnabled)].Flag = value; } }
        public Object PreferredAudioInputDevice { get { return this[nameof(PreferredAudioInputDevice)]; } set { this[nameof(PreferredAudioInputDevice)] = value; } }
        public Object PreferredAudioOutputDevice { get { return this[nameof(PreferredAudioOutputDevice)]; } set { this[nameof(PreferredAudioOutputDevice)] = value; } }
        public Object Language { get { return this[nameof(Language)]; } set { this[nameof(Language)] = value; } }
        public bool bDisplayHUD { get { return this[nameof(bDisplayHUD)].Flag; } set { this[nameof(bDisplayHUD)].Flag = value; } }
        public Object KeyboardActionMappings { get { return this[nameof(KeyboardActionMappings)]; } set { this[nameof(KeyboardActionMappings)] = value; } }
        public Object GamepadActionMappings { get { return this[nameof(GamepadActionMappings)]; } set { this[nameof(GamepadActionMappings)] = value; } }
        public Array<InputAxisKeyMapping> KeyboardAxisMappings { get { return new Array<InputAxisKeyMapping>(this[nameof(KeyboardAxisMappings)].Address); } }
        public Object EngineKeyboardActionMappings { get { return this[nameof(EngineKeyboardActionMappings)]; } set { this[nameof(EngineKeyboardActionMappings)] = value; } }
        public Object EngineGamepadActionMappings { get { return this[nameof(EngineGamepadActionMappings)]; } set { this[nameof(EngineGamepadActionMappings)] = value; } }
        public Array<InputAxisKeyMapping> EngineKeyboardAxisMappings { get { return new Array<InputAxisKeyMapping>(this[nameof(EngineKeyboardAxisMappings)].Address); } }
        public bool bHideHelmet { get { return this[nameof(bHideHelmet)].Flag; } set { this[nameof(bHideHelmet)].Flag = value; } }
        public Object WorldsItemsSeen { get { return this[nameof(WorldsItemsSeen)]; } set { this[nameof(WorldsItemsSeen)] = value; } }
        public Array<TOMMenuNotificationPath> Notifications { get { return new Array<TOMMenuNotificationPath>(this[nameof(Notifications)].Address); } }
        public void ToggleHelmetVisibilty() { Invoke(nameof(ToggleHelmetVisibilty)); }
        public void SetDisplayHUD(bool bInValue) { Invoke(nameof(SetDisplayHUD), bInValue); }
        public void SaveSettings(SettingsSave Settings) { Invoke(nameof(SaveSettings), Settings); }
        public void ResetUserActionMappings() { Invoke(nameof(ResetUserActionMappings)); }
        public void RemoveSeenItem(Object WorldID, Object ItemId, bool bSave) { Invoke(nameof(RemoveSeenItem), WorldID, ItemId, bSave); }
        public void RefreshValueFromConfig() { Invoke(nameof(RefreshValueFromConfig)); }
        public void MuteAudio() { Invoke(nameof(MuteAudio)); }
        public void LoadUserActionMappings() { Invoke(nameof(LoadUserActionMappings)); }
        public SettingsSave LoadSettings() { return Invoke<SettingsSave>(nameof(LoadSettings)); }
        public Array<Object> GetSeenItemsForWorld(Object WorldID) { return Invoke<Array<Object>>(nameof(GetSeenItemsForWorld), WorldID); }
        public void ClearWorldData(Object WorldID) { Invoke(nameof(ClearWorldData), WorldID); }
        public void ApplySettings() { Invoke(nameof(ApplySettings)); }
        public void ApplyAudioSettings() { Invoke(nameof(ApplyAudioSettings)); }
        public void AddSeenItem(Object WorldID, Object ItemId, bool bSave) { Invoke(nameof(AddSeenItem), WorldID, ItemId, bSave); }
        public void AddOrReplaceUserAxisMappings(InputAxisKeyMapping Mapping) { Invoke(nameof(AddOrReplaceUserAxisMappings), Mapping); }
        public void AddOrReplaceUserActionMappings(InputActionKeyMapping Mapping) { Invoke(nameof(AddOrReplaceUserActionMappings), Mapping); }
    }
    public class ShaderVisibilityComponentBase : ActorComponent
    {
        public ShaderVisibilityComponentBase(ulong addr) : base(addr) { }
        public bool bUseFade { get { return this[nameof(bUseFade)].Flag; } set { this[nameof(bUseFade)].Flag = value; } }
        public float FadeSpeed { get { return this[nameof(FadeSpeed)].GetValue<float>(); } set { this[nameof(FadeSpeed)].SetValue<float>(value); } }
        public float FadeMinValue { get { return this[nameof(FadeMinValue)].GetValue<float>(); } set { this[nameof(FadeMinValue)].SetValue<float>(value); } }
        public Object OpacityParameterName { get { return this[nameof(OpacityParameterName)]; } set { this[nameof(OpacityParameterName)] = value; } }
        public bool bUseStencil { get { return this[nameof(bUseStencil)].Flag; } set { this[nameof(bUseStencil)].Flag = value; } }
        public int StencilHidden { get { return this[nameof(StencilHidden)].GetValue<int>(); } set { this[nameof(StencilHidden)].SetValue<int>(value); } }
        public int StencilShown { get { return this[nameof(StencilShown)].GetValue<int>(); } set { this[nameof(StencilShown)].SetValue<int>(value); } }
        public float SelectedSpeed { get { return this[nameof(SelectedSpeed)].GetValue<float>(); } set { this[nameof(SelectedSpeed)].SetValue<float>(value); } }
        public Object SelectedParameterName { get { return this[nameof(SelectedParameterName)]; } set { this[nameof(SelectedParameterName)] = value; } }
        public Array<MaterialInstanceDynamic> Materials { get { return new Array<MaterialInstanceDynamic>(this[nameof(Materials)].Address); } }
        public Array<MeshComponent> Meshes { get { return new Array<MeshComponent>(this[nameof(Meshes)].Address); } }
        public void Unselect() { Invoke(nameof(Unselect)); }
        public void StopTransparency() { Invoke(nameof(StopTransparency)); }
        public void Show() { Invoke(nameof(Show)); }
        public void Select() { Invoke(nameof(Select)); }
        public void Hide() { Invoke(nameof(Hide)); }
        public void CheckMaterials() { Invoke(nameof(CheckMaterials)); }
    }
    public class ShaderVisibilitySourceComponent : ActorComponent
    {
        public ShaderVisibilitySourceComponent(ulong addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
        public bool bDrawDebugLine { get { return this[nameof(bDrawDebugLine)].Flag; } set { this[nameof(bDrawDebugLine)].Flag = value; } }
        public bool bDrawDebugCylinder { get { return this[nameof(bDrawDebugCylinder)].Flag; } set { this[nameof(bDrawDebugCylinder)].Flag = value; } }
        public bool bDrawDebugCollisions { get { return this[nameof(bDrawDebugCollisions)].Flag; } set { this[nameof(bDrawDebugCollisions)].Flag = value; } }
        public Array<ShaderVisibilityComponentBase> HiddenTargets { get { return new Array<ShaderVisibilityComponentBase>(this[nameof(HiddenTargets)].Address); } }
    }
    public class ShieldBase : TOMEquipmentBase
    {
        public ShieldBase(ulong addr) : base(addr) { }
        public void RefreshShieldPosition() { Invoke(nameof(RefreshShieldPosition)); }
    }
    public class ShrineReplicatedProp : ReplicatedPropBase
    {
        public ShrineReplicatedProp(ulong addr) : base(addr) { }
        public EntitiesManager EntitiesManager { get { return this[nameof(EntitiesManager)].As<EntitiesManager>(); } set { this["EntitiesManager"] = value; } }
        public WorldShrineEntityModel ShrineEntityModel { get { return this[nameof(ShrineEntityModel)].As<WorldShrineEntityModel>(); } set { this["ShrineEntityModel"] = value; } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public void UpdateShrine() { Invoke(nameof(UpdateShrine)); }
        public void OnShrineEntityRegistered(Object InEntityId) { Invoke(nameof(OnShrineEntityRegistered), InEntityId); }
        public void OnShrineEntityChanged(EEntityActionType ActionType, Object InEntityId, Object Context) { Invoke(nameof(OnShrineEntityChanged), ActionType, InEntityId, Context); }
        public void OnRep_EntityId() { Invoke(nameof(OnRep_EntityId)); }
        public bool IsActive() { return Invoke<bool>(nameof(IsActive)); }
        public void Init(Object InEntityId) { Invoke(nameof(Init), InEntityId); }
        public void ActivateShrine() { Invoke(nameof(ActivateShrine)); }
    }
    public class SlashNotifyState : AnimNotifyState
    {
        public SlashNotifyState(ulong addr) : base(addr) { }
        public bool bIsSecondaryAttack { get { return this[nameof(bIsSecondaryAttack)].Flag; } set { this[nameof(bIsSecondaryAttack)].Flag = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Object SocketName { get { return this[nameof(SocketName)]; } set { this[nameof(SocketName)] = value; } }
        public bool bAttached { get { return this[nameof(bAttached)].Flag; } set { this[nameof(bAttached)].Flag = value; } }
    }
    public class SpawnAOE : AnimNotify
    {
        public SpawnAOE(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public int attackId { get { return this[nameof(attackId)].GetValue<int>(); } set { this[nameof(attackId)].SetValue<int>(value); } }
    }
    public class SpawningManager : TOMActor
    {
        public SpawningManager(ulong addr) : base(addr) { }
        public Object SummonedPacks { get { return this[nameof(SummonedPacks)]; } set { this[nameof(SummonedPacks)] = value; } }
        public void TransferCreature(ChunkEntityModel NewChunk, WorldCreatureEntityModel Creature, Vector Location, bool NoSpawning) { Invoke(nameof(TransferCreature), NewChunk, Creature, Location, NoSpawning); }
        public CreaturePackEntityModel SummonCreaturePack(int CreaturePackDataId, Object SummonerId, Vector Position, int MaxPack, float MinDispersion, float MaxDispersion, float MinAngle, float MaxAngle) { return Invoke<CreaturePackEntityModel>(nameof(SummonCreaturePack), CreaturePackDataId, SummonerId, Position, MaxPack, MinDispersion, MaxDispersion, MinAngle, MaxAngle); }
        public HazardEntityModel SpawnHazard(HazardDataModel HazardModel, Vector Location, Rotator Rotation, Vector Scale, EAdjustmentMethod AdjustmentMethod, Object EntityId) { return Invoke<HazardEntityModel>(nameof(SpawnHazard), HazardModel, Location, Rotation, Scale, AdjustmentMethod, EntityId); }
        public CreaturePackEntityModel SpawnCreaturePack(int CreaturePackDataId, Vector Position, ESpawnType SpawnType, float MinDispersion, float MaxDispersion, float MinAngle, float MaxAngle) { return Invoke<CreaturePackEntityModel>(nameof(SpawnCreaturePack), CreaturePackDataId, Position, SpawnType, MinDispersion, MaxDispersion, MinAngle, MaxAngle); }
        public void SpawnChunkDynamicEntities(IntPoint ChunkCoordinates) { Invoke(nameof(SpawnChunkDynamicEntities), ChunkCoordinates); }
        public void OnLastPackCreatureDied(CreaturePackEntityModel PackEntity) { Invoke(nameof(OnLastPackCreatureDied), PackEntity); }
        public void OnCreatureChangeChunk(IntPoint OldChunkCoord, IntPoint NewChunkCoord, Actor OwnerActor) { Invoke(nameof(OnCreatureChangeChunk), OldChunkCoord, NewChunkCoord, OwnerActor); }
        public void OnChunkCreatureStatusChanged(bool bRespawned, WorldCreatureEntityModel CreatureEntity, Object ChunkEntityId) { Invoke(nameof(OnChunkCreatureStatusChanged), bRespawned, CreatureEntity, ChunkEntityId); }
        public int GetPackCountForSummoner(Object SummonerId) { return Invoke<int>(nameof(GetPackCountForSummoner), SummonerId); }
        public void ClearCreaturesInChunk(Object ChunkId) { Invoke(nameof(ClearCreaturesInChunk), ChunkId); }
        public void ClearChunkDynamicEntities(IntPoint ChunkCoordinates) { Invoke(nameof(ClearChunkDynamicEntities), ChunkCoordinates); }
        public void AddCreatureEntityInChunk(CreatureData CreatureData, Object ChunkId) { Invoke(nameof(AddCreatureEntityInChunk), CreatureData, ChunkId); }
    }
    public class SpecialPointComponent : ActorComponent
    {
        public SpecialPointComponent(ulong addr) : base(addr) { }
        public bool IsUnlimited { get { return this[nameof(IsUnlimited)].Flag; } set { this[nameof(IsUnlimited)].Flag = value; } }
        public Object OnSpChanged { get { return this[nameof(OnSpChanged)]; } set { this[nameof(OnSpChanged)] = value; } }
        public int MaxSp { get { return this[nameof(MaxSp)].GetValue<int>(); } set { this[nameof(MaxSp)].SetValue<int>(value); } }
        public int SpPerBlock { get { return this[nameof(SpPerBlock)].GetValue<int>(); } set { this[nameof(SpPerBlock)].SetValue<int>(value); } }
        public float SPGainRatio { get { return this[nameof(SPGainRatio)].GetValue<float>(); } set { this[nameof(SPGainRatio)].SetValue<float>(value); } }
        public int CurrentSp { get { return this[nameof(CurrentSp)].GetValue<int>(); } set { this[nameof(CurrentSp)].SetValue<int>(value); } }
        public void SetMaxSPModifier(float AmountToAdd) { Invoke(nameof(SetMaxSPModifier), AmountToAdd); }
        public void SetCurrentSp(int InCurrentSp) { Invoke(nameof(SetCurrentSp), InCurrentSp); }
        public void ResetSp() { Invoke(nameof(ResetSp)); }
        public void OnRep_MaxSp() { Invoke(nameof(OnRep_MaxSp)); }
        public void OnRep_CurrentSp() { Invoke(nameof(OnRep_CurrentSp)); }
        public int GetCurrentSp() { return Invoke<int>(nameof(GetCurrentSp)); }
        public bool ConsumeSp(int AmountToConsume) { return Invoke<bool>(nameof(ConsumeSp), AmountToConsume); }
        public bool AddSp(int AmountToAdd) { return Invoke<bool>(nameof(AddSp), AmountToAdd); }
    }
    public class StaminaComponent : ActorComponent
    {
        public StaminaComponent(ulong addr) : base(addr) { }
        public float DefaultStamina { get { return this[nameof(DefaultStamina)].GetValue<float>(); } set { this[nameof(DefaultStamina)].SetValue<float>(value); } }
        public float NormalRegenerationRate { get { return this[nameof(NormalRegenerationRate)].GetValue<float>(); } set { this[nameof(NormalRegenerationRate)].SetValue<float>(value); } }
        public float FatigueRegenerationRate { get { return this[nameof(FatigueRegenerationRate)].GetValue<float>(); } set { this[nameof(FatigueRegenerationRate)].SetValue<float>(value); } }
        public float RegenerationDelay { get { return this[nameof(RegenerationDelay)].GetValue<float>(); } set { this[nameof(RegenerationDelay)].SetValue<float>(value); } }
        public float FatiguedRegenerationDelay { get { return this[nameof(FatiguedRegenerationDelay)].GetValue<float>(); } set { this[nameof(FatiguedRegenerationDelay)].SetValue<float>(value); } }
        public float CurrentStamina { get { return this[nameof(CurrentStamina)].GetValue<float>(); } set { this[nameof(CurrentStamina)].SetValue<float>(value); } }
        public bool IsFatigued { get { return this[nameof(IsFatigued)].Flag; } set { this[nameof(IsFatigued)].Flag = value; } }
        public Object OnStaminaDepleted { get { return this[nameof(OnStaminaDepleted)]; } set { this[nameof(OnStaminaDepleted)] = value; } }
        public Object OnStaminaRegenerated { get { return this[nameof(OnStaminaRegenerated)]; } set { this[nameof(OnStaminaRegenerated)] = value; } }
        public void TriggerFatigueChangeOnClient(bool NewIsFatigued) { Invoke(nameof(TriggerFatigueChangeOnClient), NewIsFatigued); }
        public void SetDefaultStamina(float NewDefaultStamina) { Invoke(nameof(SetDefaultStamina), NewDefaultStamina); }
        public float GetCurrentStaminaFraction() { return Invoke<float>(nameof(GetCurrentStaminaFraction)); }
        public void ConsumeStamina(float Amount) { Invoke(nameof(ConsumeStamina), Amount); }
    }
    public class StaticMeshUtility : Object
    {
        public StaticMeshUtility(ulong addr) : base(addr) { }
        public int UpdateGrassPosition(Object SMHISMC, StaticMesh Mesh, Vector Position, int Index, Actor Chunk, Array<int> AddOnTop) { return Invoke<int>(nameof(UpdateGrassPosition), SMHISMC, Mesh, Position, Index, Chunk, AddOnTop); }
        public void RemoveInstanceOfGrass(HierarchicalInstancedStaticMeshComponent HISMC, Object SMIndex, int FirstAddOnTop) { Invoke(nameof(RemoveInstanceOfGrass), HISMC, SMIndex, FirstAddOnTop); }
    }
    public class StatusAddItemsComponent : StatusComponent
    {
        public StatusAddItemsComponent(ulong addr) : base(addr) { }
    }
    public class StatusAggroedBase : StatusComponent
    {
        public StatusAggroedBase(ulong addr) : base(addr) { }
        public TOMCharacter AggroTarget { get { return this[nameof(AggroTarget)].As<TOMCharacter>(); } set { this["AggroTarget"] = value; } }
    }
    public class StatusAOEHealOnRevivingComponent : StatusComponent
    {
        public StatusAOEHealOnRevivingComponent(ulong addr) : base(addr) { }
        public void OnReviveCharacter(TOMCharacter TOMCharacter) { Invoke(nameof(OnReviveCharacter), TOMCharacter); }
    }
    public class StatusApplyStatusOnIdleComponent : StatusComponent
    {
        public StatusApplyStatusOnIdleComponent(ulong addr) : base(addr) { }
        public void OnIdleChanged(bool bIsIdle) { Invoke(nameof(OnIdleChanged), bIsIdle); }
    }
    public class StatusApplyStatusOnLightAttackComponent : StatusComponent
    {
        public StatusApplyStatusOnLightAttackComponent(ulong addr) : base(addr) { }
        public void OnLightAttack() { Invoke(nameof(OnLightAttack)); }
        public void OnAttackHit(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnAttackHit), Target, bIsLightAttack, AttackStats); }
    }
    public class StatusApplyStatusWhileInAuraComponent : StatusComponent
    {
        public StatusApplyStatusWhileInAuraComponent(ulong addr) : base(addr) { }
        public SphereComponent CollisionSphere { get { return this[nameof(CollisionSphere)].As<SphereComponent>(); } set { this["CollisionSphere"] = value; } }
        public void OnEndOverlap(PrimitiveComponent OverlappedComp, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(OnEndOverlap), OverlappedComp, OtherActor, OtherComp, OtherBodyIndex); }
        public void OnBeginOverlap(PrimitiveComponent OverlappedComp, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnBeginOverlap), OverlappedComp, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class StatusApplyStatusWhileInAndOnLeaveAuraComponent : StatusApplyStatusWhileInAuraComponent
    {
        public StatusApplyStatusWhileInAndOnLeaveAuraComponent(ulong addr) : base(addr) { }
    }
    public class StatusApplyStatusWhileShieldUpComponent : StatusComponent
    {
        public StatusApplyStatusWhileShieldUpComponent(ulong addr) : base(addr) { }
        public void OnShieldUp() { Invoke(nameof(OnShieldUp)); }
        public void OnShieldDown() { Invoke(nameof(OnShieldDown)); }
    }
    public class StatusArmorMultiplierBonusComponent : StatusComponent
    {
        public StatusArmorMultiplierBonusComponent(ulong addr) : base(addr) { }
    }
    public class StatusAttackOnBaseComponent : StatusComponent
    {
        public StatusAttackOnBaseComponent(ulong addr) : base(addr) { }
        public void ExecuteAttack(TOMCharacter CharacterSource, TOMCharacter CharacterTarget, Vector Location) { Invoke(nameof(ExecuteAttack), CharacterSource, CharacterTarget, Location); }
    }
    public class StatusAttackOnBlockComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnBlockComponent(ulong addr) : base(addr) { }
        public void OnShieldBlock(TOMOffensiveComponent OffensiveComponent, Vector Location, float Damage) { Invoke(nameof(OnShieldBlock), OffensiveComponent, Location, Damage); }
    }
    public class StatusAttackOnComboFillComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnComboFillComponent(ulong addr) : base(addr) { }
        public StatusBrawlerComboBase StatusBrawlerComboBase { get { return this[nameof(StatusBrawlerComboBase)].As<StatusBrawlerComboBase>(); } set { this["StatusBrawlerComboBase"] = value; } }
        public TimerHandle ExplosionTimerHandle { get { return this[nameof(ExplosionTimerHandle)].As<TimerHandle>(); } set { this["ExplosionTimerHandle"] = value; } }
        public void OnComboUpdate() { Invoke(nameof(OnComboUpdate)); }
        public void OnComboTimer() { Invoke(nameof(OnComboTimer)); }
        public void DelayedInit() { Invoke(nameof(DelayedInit)); }
    }
    public class StatusAttackOnDeathComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnDeathComponent(ulong addr) : base(addr) { }
        public void OnDelayedDeath() { Invoke(nameof(OnDelayedDeath)); }
        public void OnCharacterDeath(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterDeath), TOMCharacter); }
    }
    public class StatusAttackOnDeconstructComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnDeconstructComponent(ulong addr) : base(addr) { }
        public void OnDeconstruct(Vector Location) { Invoke(nameof(OnDeconstruct), Location); }
    }
    public class StatusAttackOnEvadeComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnEvadeComponent(ulong addr) : base(addr) { }
        public void OnEvadeStart(TOMCharacter TOMCharacter) { Invoke(nameof(OnEvadeStart), TOMCharacter); }
    }
    public class StatusAttackOnHitComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnHitComponent(ulong addr) : base(addr) { }
        public void OnHit(EmitterComponent AttackSource, float InAmount, HitResult HitResult) { Invoke(nameof(OnHit), AttackSource, InAmount, HitResult); }
    }
    public class StatusAttackOnKillComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnKillComponent(ulong addr) : base(addr) { }
        public void OnKill(AnimalDataModel AnimalDataModel, TOMCharacter CreatureCharacter) { Invoke(nameof(OnKill), AnimalDataModel, CreatureCharacter); }
    }
    public class StatusAttackOnLightAttackComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnLightAttackComponent(ulong addr) : base(addr) { }
        public void OnLightAttack() { Invoke(nameof(OnLightAttack)); }
    }
    public class StatusAttackOnLightAttackHitComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOnLightAttackHitComponent(ulong addr) : base(addr) { }
        public void OnLightAttackHit(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnLightAttackHit), Target, bIsLightAttack, AttackStats); }
    }
    public class StatusAttackOverTimeComponent : StatusAttackOnBaseComponent
    {
        public StatusAttackOverTimeComponent(ulong addr) : base(addr) { }
        public void AttackTick() { Invoke(nameof(AttackTick)); }
    }
    public class StatusBrawlerComboBase : StatusComponent
    {
        public StatusBrawlerComboBase(ulong addr) : base(addr) { }
        public int CurrentComboCount { get { return this[nameof(CurrentComboCount)].GetValue<int>(); } set { this[nameof(CurrentComboCount)].SetValue<int>(value); } }
        public int MaxComboCount { get { return this[nameof(MaxComboCount)].GetValue<int>(); } set { this[nameof(MaxComboCount)].SetValue<int>(value); } }
        public float GaugeCount { get { return this[nameof(GaugeCount)].GetValue<float>(); } set { this[nameof(GaugeCount)].SetValue<float>(value); } }
        public Object OnBrawlerComboUpdate { get { return this[nameof(OnBrawlerComboUpdate)]; } set { this[nameof(OnBrawlerComboUpdate)] = value; } }
        public TimerHandle DecayHandle { get { return this[nameof(DecayHandle)].As<TimerHandle>(); } set { this["DecayHandle"] = value; } }
        public TOMOffensiveComponent OffensiveComponent { get { return this[nameof(OffensiveComponent)].As<TOMOffensiveComponent>(); } set { this["OffensiveComponent"] = value; } }
        public void RefreshCurrentComboPoint() { Invoke(nameof(RefreshCurrentComboPoint)); }
        public void OnRep_CurrentComboCount() { Invoke(nameof(OnRep_CurrentComboCount)); }
        public void OnDecayTimerExpire() { Invoke(nameof(OnDecayTimerExpire)); }
        public void OnDealDamage(AttackStatsDataModel AttackStatsDataModel) { Invoke(nameof(OnDealDamage), AttackStatsDataModel); }
        public void OnCharacterDeath(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterDeath), TOMCharacter); }
        public int GetComboIntensityCount() { return Invoke<int>(nameof(GetComboIntensityCount)); }
    }
    public class StatusChargedShotBase : StatusComponent
    {
        public StatusChargedShotBase(ulong addr) : base(addr) { }
        public ParticleSystem ChargeVFX { get { return this[nameof(ChargeVFX)].As<ParticleSystem>(); } set { this["ChargeVFX"] = value; } }
        public ParticleSystem ShootVFX { get { return this[nameof(ShootVFX)].As<ParticleSystem>(); } set { this["ShootVFX"] = value; } }
        public Object AttachPoint { get { return this[nameof(AttachPoint)]; } set { this[nameof(AttachPoint)] = value; } }
        public bool bIsCharged { get { return this[nameof(bIsCharged)].Flag; } set { this[nameof(bIsCharged)].Flag = value; } }
        public ParticleSystemComponent ChargedPS { get { return this[nameof(ChargedPS)].As<ParticleSystemComponent>(); } set { this["ChargedPS"] = value; } }
        public void PlayFireVFXMulticast() { Invoke(nameof(PlayFireVFXMulticast)); }
        public void OnRep_IsCharged() { Invoke(nameof(OnRep_IsCharged)); }
    }
    public class StatusColdHealthRegenComponent : StatusComponent
    {
        public StatusColdHealthRegenComponent(ulong addr) : base(addr) { }
        public void OnColdStart() { Invoke(nameof(OnColdStart)); }
        public void OnColdEnd() { Invoke(nameof(OnColdEnd)); }
        public void HealTick() { Invoke(nameof(HealTick)); }
    }
    public class StatusColdTemperatureResistanceComponent : StatusComponent
    {
        public StatusColdTemperatureResistanceComponent(ulong addr) : base(addr) { }
    }
    public class StatusCooldownBaseComponent : StatusComponent
    {
        public StatusCooldownBaseComponent(ulong addr) : base(addr) { }
        public float Timer { get { return this[nameof(Timer)].GetValue<float>(); } set { this[nameof(Timer)].SetValue<float>(value); } }
        public float MaxTimer { get { return this[nameof(MaxTimer)].GetValue<float>(); } set { this[nameof(MaxTimer)].SetValue<float>(value); } }
        public bool bIsInit { get { return this[nameof(bIsInit)].Flag; } set { this[nameof(bIsInit)].Flag = value; } }
        public void OnStatusInit() { Invoke(nameof(OnStatusInit)); }
        public void OnRep_IsInit() { Invoke(nameof(OnRep_IsInit)); }
        public float GetProgress() { return Invoke<float>(nameof(GetProgress)); }
        public bool Execute() { return Invoke<bool>(nameof(Execute)); }
    }
    public class StatusDecayingSlowComponent : StatusComponent
    {
        public StatusDecayingSlowComponent(ulong addr) : base(addr) { }
        public void DecayTick() { Invoke(nameof(DecayTick)); }
    }
    public class StatusDecoyEvadeComponent : StatusComponent
    {
        public StatusDecoyEvadeComponent(ulong addr) : base(addr) { }
        public Object AppearSFX { get { return this[nameof(AppearSFX)]; } set { this[nameof(AppearSFX)] = value; } }
        public Object DisappearSFX { get { return this[nameof(DisappearSFX)]; } set { this[nameof(DisappearSFX)] = value; } }
        public TOMCharacter DecoyCharacter { get { return this[nameof(DecoyCharacter)].As<TOMCharacter>(); } set { this["DecoyCharacter"] = value; } }
        public void OnEvadeStart(TOMCharacter TOMCharacter) { Invoke(nameof(OnEvadeStart), TOMCharacter); }
        public void DestroyDecoy() { Invoke(nameof(DestroyDecoy)); }
    }
    public class StatusDoubleMeleeLightAttackHitComponent : StatusComponent
    {
        public StatusDoubleMeleeLightAttackHitComponent(ulong addr) : base(addr) { }
    }
    public class StatusGainSoulsOnAttackComponent : StatusComponent
    {
        public StatusGainSoulsOnAttackComponent(ulong addr) : base(addr) { }
        public void OnAttackHit(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnAttackHit), Target, bIsLightAttack, AttackStats); }
    }
    public class StatusGuardianMeterComponent : StatusComponent
    {
        public StatusGuardianMeterComponent(ulong addr) : base(addr) { }
        public bool bIsInit { get { return this[nameof(bIsInit)].Flag; } set { this[nameof(bIsInit)].Flag = value; } }
        public int CurrentComboCount { get { return this[nameof(CurrentComboCount)].GetValue<int>(); } set { this[nameof(CurrentComboCount)].SetValue<int>(value); } }
        public int MaxComboCount { get { return this[nameof(MaxComboCount)].GetValue<int>(); } set { this[nameof(MaxComboCount)].SetValue<int>(value); } }
        public float GaugeCount { get { return this[nameof(GaugeCount)].GetValue<float>(); } set { this[nameof(GaugeCount)].SetValue<float>(value); } }
        public Object OnComboPointChange { get { return this[nameof(OnComboPointChange)]; } set { this[nameof(OnComboPointChange)] = value; } }
        public void OnShieldingChanged(bool bIsShielding) { Invoke(nameof(OnShieldingChanged), bIsShielding); }
        public void OnShieldBlock(TOMOffensiveComponent OffensiveComponent, Vector Location, float Damage) { Invoke(nameof(OnShieldBlock), OffensiveComponent, Location, Damage); }
        public void OnRep_IsInit() { Invoke(nameof(OnRep_IsInit)); }
        public void OnRep_CurrentComboCount() { Invoke(nameof(OnRep_CurrentComboCount)); }
        public void OnCharacterDeath(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterDeath), TOMCharacter); }
    }
    public class StatusHighestDamageChanceAlterComponent : StatusComponent
    {
        public StatusHighestDamageChanceAlterComponent(ulong addr) : base(addr) { }
    }
    public class StatusHotSpeedBonusComponent : StatusComponent
    {
        public StatusHotSpeedBonusComponent(ulong addr) : base(addr) { }
        public void OnHotStart() { Invoke(nameof(OnHotStart)); }
        public void OnHotEnd() { Invoke(nameof(OnHotEnd)); }
        public void OnCharacterDeath(TOMCharacter Character) { Invoke(nameof(OnCharacterDeath), Character); }
    }
    public class StatusHotTemperatureResistanceComponent : StatusComponent
    {
        public StatusHotTemperatureResistanceComponent(ulong addr) : base(addr) { }
    }
    public class StatusInventorySettingsAlterBase : StatusComponent
    {
        public StatusInventorySettingsAlterBase(ulong addr) : base(addr) { }
        public int OriginalContainerDataId { get { return this[nameof(OriginalContainerDataId)].GetValue<int>(); } set { this[nameof(OriginalContainerDataId)].SetValue<int>(value); } }
        public ContainerEntityModel ContainerEntityModel { get { return this[nameof(ContainerEntityModel)].As<ContainerEntityModel>(); } set { this["ContainerEntityModel"] = value; } }
    }
    public class StatusJumpBackComponent : StatusCooldownBaseComponent
    {
        public StatusJumpBackComponent(ulong addr) : base(addr) { }
        public void JumpBack() { Invoke(nameof(JumpBack)); }
    }
    public class StatusKeepSoulOnDeathComponent : StatusComponent
    {
        public StatusKeepSoulOnDeathComponent(ulong addr) : base(addr) { }
    }
    public class StatusLoseSoulsOnHitComponent : StatusComponent
    {
        public StatusLoseSoulsOnHitComponent(ulong addr) : base(addr) { }
        public void OnHit(EmitterComponent AttackSource, float InAmount, HitResult HitResult) { Invoke(nameof(OnHit), AttackSource, InAmount, HitResult); }
    }
    public class StatusManaOnAttackHitComponent : StatusComponent
    {
        public StatusManaOnAttackHitComponent(ulong addr) : base(addr) { }
        public void OnAttackHit(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnAttackHit), Target, bIsLightAttack, AttackStats); }
    }
    public class StatusManaOverTimeComponent : StatusComponent
    {
        public StatusManaOverTimeComponent(ulong addr) : base(addr) { }
    }
    public class StatusNakedDamageBonusComponent : StatusComponent
    {
        public StatusNakedDamageBonusComponent(ulong addr) : base(addr) { }
        public void OnEquipItem() { Invoke(nameof(OnEquipItem)); }
    }
    public class StatusNightSpeedBonusComponent : StatusComponent
    {
        public StatusNightSpeedBonusComponent(ulong addr) : base(addr) { }
        public void OnNightStart() { Invoke(nameof(OnNightStart)); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public void OnCharacterDeath(TOMCharacter Character) { Invoke(nameof(OnCharacterDeath), Character); }
    }
    public class StatusRepairEquipedItemsComponent : StatusComponent
    {
        public StatusRepairEquipedItemsComponent(ulong addr) : base(addr) { }
    }
    public class StatusResetRunestoneCooldownComponent : StatusComponent
    {
        public StatusResetRunestoneCooldownComponent(ulong addr) : base(addr) { }
    }
    public class StatusResistPerkByTagsComponent : StatusComponent
    {
        public StatusResistPerkByTagsComponent(ulong addr) : base(addr) { }
    }
    public class StatusRespawnTotemComponent : StatusComponent
    {
        public StatusRespawnTotemComponent(ulong addr) : base(addr) { }
        public NiagaraSystem RecallVFX { get { return this[nameof(RecallVFX)].As<NiagaraSystem>(); } set { this["RecallVFX"] = value; } }
        public Object RecallVFXAttachBoneName { get { return this[nameof(RecallVFXAttachBoneName)]; } set { this[nameof(RecallVFXAttachBoneName)] = value; } }
        public Object RecallVFXAttachBoneName2 { get { return this[nameof(RecallVFXAttachBoneName2)]; } set { this[nameof(RecallVFXAttachBoneName2)] = value; } }
        public Object RecallSFX { get { return this[nameof(RecallSFX)]; } set { this[nameof(RecallSFX)] = value; } }
        public Object SpawnSFX { get { return this[nameof(SpawnSFX)]; } set { this[nameof(SpawnSFX)] = value; } }
        public void UseTotem() { Invoke(nameof(UseTotem)); }
        public void OnSpawnMulticast() { Invoke(nameof(OnSpawnMulticast)); }
        public void OnRespawnMulticast() { Invoke(nameof(OnRespawnMulticast)); }
        public void OnRespawn() { Invoke(nameof(OnRespawn)); }
        public Vector GetRespawnLocation() { return Invoke<Vector>(nameof(GetRespawnLocation)); }
        public bool GetIsTotemPlaced() { return Invoke<bool>(nameof(GetIsTotemPlaced)); }
    }
    public class StatusSelfReviveComponent : StatusComponent
    {
        public StatusSelfReviveComponent(ulong addr) : base(addr) { }
    }
    public class StatusSentinelShieldTotalDefenseComponent : StatusComponent
    {
        public StatusSentinelShieldTotalDefenseComponent(ulong addr) : base(addr) { }
        public NiagaraSystem GlowNS { get { return this[nameof(GlowNS)].As<NiagaraSystem>(); } set { this["GlowNS"] = value; } }
        public NiagaraSystem TotalDefenseNS { get { return this[nameof(TotalDefenseNS)].As<NiagaraSystem>(); } set { this["TotalDefenseNS"] = value; } }
        public NiagaraSystem EndNS { get { return this[nameof(EndNS)].As<NiagaraSystem>(); } set { this["EndNS"] = value; } }
        public Object SFXSuffix { get { return this[nameof(SFXSuffix)]; } set { this[nameof(SFXSuffix)] = value; } }
        public TimerHandle ParryReadyCountdownTimerHandle { get { return this[nameof(ParryReadyCountdownTimerHandle)].As<TimerHandle>(); } set { this["ParryReadyCountdownTimerHandle"] = value; } }
        public TimerHandle ReflectiveTimerHandle { get { return this[nameof(ReflectiveTimerHandle)].As<TimerHandle>(); } set { this["ReflectiveTimerHandle"] = value; } }
        public NiagaraComponent GlowNPS { get { return this[nameof(GlowNPS)].As<NiagaraComponent>(); } set { this["GlowNPS"] = value; } }
        public NiagaraComponent TotalDefenseNPS { get { return this[nameof(TotalDefenseNPS)].As<NiagaraComponent>(); } set { this["TotalDefenseNPS"] = value; } }
        public bool bIsParryReady { get { return this[nameof(bIsParryReady)].Flag; } set { this[nameof(bIsParryReady)].Flag = value; } }
        public bool bFullBlockMeleeLightAttacks { get { return this[nameof(bFullBlockMeleeLightAttacks)].Flag; } set { this[nameof(bFullBlockMeleeLightAttacks)].Flag = value; } }
        public void OnTotalBlock(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnTotalBlock), Target, bIsLightAttack, AttackStats); }
        public void OnShieldUsableChanged(bool bIsShieldUsable) { Invoke(nameof(OnShieldUsableChanged), bIsShieldUsable); }
        public void OnShieldUp() { Invoke(nameof(OnShieldUp)); }
        public void OnShieldDown() { Invoke(nameof(OnShieldDown)); }
        public void OnRep_IsParryReady() { Invoke(nameof(OnRep_IsParryReady)); }
        public void OnRep_FullBlockMeleeLightAttacks() { Invoke(nameof(OnRep_FullBlockMeleeLightAttacks)); }
        public void OnParryReady() { Invoke(nameof(OnParryReady)); }
        public void OnEndTotalDefense() { Invoke(nameof(OnEndTotalDefense)); }
    }
    public class StatusShield360Component : StatusComponent
    {
        public StatusShield360Component(ulong addr) : base(addr) { }
    }
    public class StatusShieldAggroComponent : StatusComponent
    {
        public StatusShieldAggroComponent(ulong addr) : base(addr) { }
        public ParticleSystem ParticleTemplate { get { return this[nameof(ParticleTemplate)].As<ParticleSystem>(); } set { this["ParticleTemplate"] = value; } }
        public Array<int> Channels { get { return new Array<int>(this[nameof(Channels)].Address); } }
        public void LaunchAggro() { Invoke(nameof(LaunchAggro)); }
    }
    public class StatusSoulDamageBonusComponent : StatusComponent
    {
        public StatusSoulDamageBonusComponent(ulong addr) : base(addr) { }
        public void OnAddItem(int ItemId, int Count) { Invoke(nameof(OnAddItem), ItemId, Count); }
    }
    public class StatusSoulDrainForSpOnHitComponent : StatusComponent
    {
        public StatusSoulDrainForSpOnHitComponent(ulong addr) : base(addr) { }
        public void SoulDrainTick() { Invoke(nameof(SoulDrainTick)); }
    }
    public class StatusSpawnOnDeathComponent : StatusComponent
    {
        public StatusSpawnOnDeathComponent(ulong addr) : base(addr) { }
        public void OnCharacterDeath(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterDeath), TOMCharacter); }
    }
    public class StatusTwoWayRuneStoneBase : StatusComponent
    {
        public StatusTwoWayRuneStoneBase(ulong addr) : base(addr) { }
        public bool bIsGoingBack { get { return this[nameof(bIsGoingBack)].Flag; } set { this[nameof(bIsGoingBack)].Flag = value; } }
        public Vector GoBackPosition { get { return this[nameof(GoBackPosition)].As<Vector>(); } set { this["GoBackPosition"] = value; } }
        public void UseRuneStone() { Invoke(nameof(UseRuneStone)); }
        public void RefreshRuneStone() { Invoke(nameof(RefreshRuneStone)); }
        public void OnRep_IsGoingBack() { Invoke(nameof(OnRep_IsGoingBack)); }
        public void OnLeaveVillage(TOMCharacter Character) { Invoke(nameof(OnLeaveVillage), Character); }
        public Vector GetRuneStoneDestination() { return Invoke<Vector>(nameof(GetRuneStoneDestination)); }
    }
    public class StatusUndergroundArmorBonusComponent : StatusComponent
    {
        public StatusUndergroundArmorBonusComponent(ulong addr) : base(addr) { }
        public void OnEnterOrExitCave(TOMCharacter TOMCharacter) { Invoke(nameof(OnEnterOrExitCave), TOMCharacter); }
    }
    public class StatusVFXComponentBase : ActorComponent
    {
        public StatusVFXComponentBase(ulong addr) : base(addr) { }
        public Object OnVFXStatusStop { get { return this[nameof(OnVFXStatusStop)]; } set { this[nameof(OnVFXStatusStop)] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
    }
    public class StatusYggdrasilSeedlingComponent : StatusComponent
    {
        public StatusYggdrasilSeedlingComponent(ulong addr) : base(addr) { }
        public TOMCharacter SeedlingCharacter { get { return this[nameof(SeedlingCharacter)].As<TOMCharacter>(); } set { this["SeedlingCharacter"] = value; } }
        public void OnAttackHit(Actor Target, bool bIsLightAttack, AttackStatsDataModel AttackStats) { Invoke(nameof(OnAttackHit), Target, bIsLightAttack, AttackStats); }
        public void DestroySeedling() { Invoke(nameof(DestroySeedling)); }
    }
    public class StreamingManager : Object
    {
        public StreamingManager(ulong addr) : base(addr) { }
        public Object OnTargetWorkerCompleted { get { return this[nameof(OnTargetWorkerCompleted)]; } set { this[nameof(OnTargetWorkerCompleted)] = value; } }
        public int ChunkSize { get { return this[nameof(ChunkSize)].GetValue<int>(); } set { this[nameof(ChunkSize)].SetValue<int>(value); } }
        public int HalfWorldSize { get { return this[nameof(HalfWorldSize)].GetValue<int>(); } set { this[nameof(HalfWorldSize)].SetValue<int>(value); } }
        public float RefreshDelay { get { return this[nameof(RefreshDelay)].GetValue<float>(); } set { this[nameof(RefreshDelay)].SetValue<float>(value); } }
        public Object Layers { get { return this[nameof(Layers)]; } set { this[nameof(Layers)] = value; } }
        public Array<Object> LayerIds { get { return new Array<Object>(this[nameof(LayerIds)].Address); } }
        public Array<StreamingTargetComponent> Targets { get { return new Array<StreamingTargetComponent>(this[nameof(Targets)].Address); } }
        public Object TargetWorkers { get { return this[nameof(TargetWorkers)]; } set { this[nameof(TargetWorkers)] = value; } }
        public void Start() { Invoke(nameof(Start)); }
        public void RemoveStreamingTarget(StreamingTargetComponent Target) { Invoke(nameof(RemoveStreamingTarget), Target); }
        public void RemoveLayer(Object ID) { Invoke(nameof(RemoveLayer), ID); }
        public void OnProcessTargetCompleted(StreamingTargetComponent Target) { Invoke(nameof(OnProcessTargetCompleted), Target); }
        public Array<Object> GetSortedLayerIds() { return Invoke<Array<Object>>(nameof(GetSortedLayerIds)); }
        public bool GetLayer(Object ID, StreamingLayer StreamingLayer) { return Invoke<bool>(nameof(GetLayer), ID, StreamingLayer); }
        public void AddStreamingTarget(StreamingTargetComponent Target) { Invoke(nameof(AddStreamingTarget), Target); }
        public void AddLayer(Object ID, StreamingLayer StreamingLayer) { Invoke(nameof(AddLayer), ID, StreamingLayer); }
    }
    public class StreamingTargetComponent : BifrostActorComponent
    {
        public StreamingTargetComponent(ulong addr) : base(addr) { }
        public int Margin { get { return this[nameof(Margin)].GetValue<int>(); } set { this[nameof(Margin)].SetValue<int>(value); } }
        public bool bStreamUncontrolledTargets { get { return this[nameof(bStreamUncontrolledTargets)].Flag; } set { this[nameof(bStreamUncontrolledTargets)].Flag = value; } }
        public Array<Object> LayersFilter { get { return new Array<Object>(this[nameof(LayersFilter)].Address); } }
        public Object OnSetCoords { get { return this[nameof(OnSetCoords)]; } set { this[nameof(OnSetCoords)] = value; } }
        public bool bIsInit { get { return this[nameof(bIsInit)].Flag; } set { this[nameof(bIsInit)].Flag = value; } }
        public StreamingManager StreamingManager { get { return this[nameof(StreamingManager)].As<StreamingManager>(); } set { this["StreamingManager"] = value; } }
        public Object OnStreamingReady { get { return this[nameof(OnStreamingReady)]; } set { this[nameof(OnStreamingReady)] = value; } }
        public bool bIsPaused { get { return this[nameof(bIsPaused)].Flag; } set { this[nameof(bIsPaused)].Flag = value; } }
        public bool ShouldBuildLayer(Object LayerName) { return Invoke<bool>(nameof(ShouldBuildLayer), LayerName); }
        public void SetPause(bool InIsPaused) { Invoke(nameof(SetPause), InIsPaused); }
        public void SetCoords(IntPoint InCoords) { Invoke(nameof(SetCoords), InCoords); }
        public void OnTargetWorkerCompleted(StreamingTargetComponent Target) { Invoke(nameof(OnTargetWorkerCompleted), Target); }
        public bool IsBuilt() { return Invoke<bool>(nameof(IsBuilt)); }
        public void InitAsIgnored() { Invoke(nameof(InitAsIgnored)); }
        public void Init() { Invoke(nameof(Init)); }
        public void DelayedRemoveStreamingTarget() { Invoke(nameof(DelayedRemoveStreamingTarget)); }
        public bool AddLayerFilter(Object InLayerId) { return Invoke<bool>(nameof(AddLayerFilter), InLayerId); }
    }
    public class StreamingTargetWorker : BifrostObject
    {
        public StreamingTargetWorker(ulong addr) : base(addr) { }
        public Array<Object> ChunksToBuild { get { return new Array<Object>(this[nameof(ChunksToBuild)].Address); } }
    }
    public class SurviveNightQuestBehavior : QuestBehaviorBase
    {
        public SurviveNightQuestBehavior(ulong addr) : base(addr) { }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
    }
    public class TalkToNPCQuestBehavior : QuestBehaviorBase
    {
        public TalkToNPCQuestBehavior(ulong addr) : base(addr) { }
        public void OnTalkToNPC(int AnimalId) { Invoke(nameof(OnTalkToNPC), AnimalId); }
    }
    public class TemperatureSphereComponent : SphereComponent
    {
        public TemperatureSphereComponent(ulong addr) : base(addr) { }
        public int WorldTemperatureModifierValue { get { return this[nameof(WorldTemperatureModifierValue)].GetValue<int>(); } set { this[nameof(WorldTemperatureModifierValue)].SetValue<int>(value); } }
        public int PlayerHotResistanceModifierValue { get { return this[nameof(PlayerHotResistanceModifierValue)].GetValue<int>(); } set { this[nameof(PlayerHotResistanceModifierValue)].SetValue<int>(value); } }
        public int PlayerColdResistanceModifierValue { get { return this[nameof(PlayerColdResistanceModifierValue)].GetValue<int>(); } set { this[nameof(PlayerColdResistanceModifierValue)].SetValue<int>(value); } }
        public void OnOverlapEnd(PrimitiveComponent OverlappedComp, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(OnOverlapEnd), OverlappedComp, OtherActor, OtherComp, OtherBodyIndex); }
        public void OnOverlapBegin(PrimitiveComponent OverlappedComp, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnOverlapBegin), OverlappedComp, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class TerrainChunkActor : GenerationChunkActor
    {
        public TerrainChunkActor(ulong addr) : base(addr) { }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public ProceduralMeshComponent LandMesh { get { return this[nameof(LandMesh)].As<ProceduralMeshComponent>(); } set { this["LandMesh"] = value; } }
        public ProceduralMeshComponent BorderMesh { get { return this[nameof(BorderMesh)].As<ProceduralMeshComponent>(); } set { this["BorderMesh"] = value; } }
        public ProceduralMeshComponent WaterMesh { get { return this[nameof(WaterMesh)].As<ProceduralMeshComponent>(); } set { this["WaterMesh"] = value; } }
        public ProceduralMeshComponent SeaMesh { get { return this[nameof(SeaMesh)].As<ProceduralMeshComponent>(); } set { this["SeaMesh"] = value; } }
        public ProceduralMeshComponent PuddleMesh { get { return this[nameof(PuddleMesh)].As<ProceduralMeshComponent>(); } set { this["PuddleMesh"] = value; } }
    }
    public class TickManager : TOMActor
    {
        public TickManager(ulong addr) : base(addr) { }
        public int CharacterMoveMaxCallPerTickPS4 { get { return this[nameof(CharacterMoveMaxCallPerTickPS4)].GetValue<int>(); } set { this[nameof(CharacterMoveMaxCallPerTickPS4)].SetValue<int>(value); } }
        public int CharacterMoveMaxCallPerTickPC { get { return this[nameof(CharacterMoveMaxCallPerTickPC)].GetValue<int>(); } set { this[nameof(CharacterMoveMaxCallPerTickPC)].SetValue<int>(value); } }
        public int AIControllerCallPerTick { get { return this[nameof(AIControllerCallPerTick)].GetValue<int>(); } set { this[nameof(AIControllerCallPerTick)].SetValue<int>(value); } }
        public Array<TOMCharacterMovementComponent> CharacterMovementComponents { get { return new Array<TOMCharacterMovementComponent>(this[nameof(CharacterMovementComponents)].Address); } }
        public Array<TOMCharacterMovementComponent> CharacterMovementPendingRemoves { get { return new Array<TOMCharacterMovementComponent>(this[nameof(CharacterMovementPendingRemoves)].Address); } }
        public Array<AnimalAIController> AnimalAIControllers { get { return new Array<AnimalAIController>(this[nameof(AnimalAIControllers)].Address); } }
    }
    public class TimeManager : TOMActor
    {
        public TimeManager(ulong addr) : base(addr) { }
        public Object OnSegmentChanged { get { return this[nameof(OnSegmentChanged)]; } set { this[nameof(OnSegmentChanged)] = value; } }
        public Object OnDayStart { get { return this[nameof(OnDayStart)]; } set { this[nameof(OnDayStart)] = value; } }
        public Object OnEveningStart { get { return this[nameof(OnEveningStart)]; } set { this[nameof(OnEveningStart)] = value; } }
        public Object OnNightStart { get { return this[nameof(OnNightStart)]; } set { this[nameof(OnNightStart)] = value; } }
        public Object OnTimeLerpFinished { get { return this[nameof(OnTimeLerpFinished)]; } set { this[nameof(OnTimeLerpFinished)] = value; } }
        public Object OnTimeManagerReady { get { return this[nameof(OnTimeManagerReady)]; } set { this[nameof(OnTimeManagerReady)] = value; } }
        public Object DaysCycle { get { return this[nameof(DaysCycle)]; } set { this[nameof(DaysCycle)] = value; } }
        public int DaysCycleCount { get { return this[nameof(DaysCycleCount)].GetValue<int>(); } set { this[nameof(DaysCycleCount)].SetValue<int>(value); } }
        public Array<DailyAnnouncementVO> DailyAnnouncements { get { return new Array<DailyAnnouncementVO>(this[nameof(DailyAnnouncements)].Address); } }
        public Array<TimeManager_ScheduledEvent> TodayEvents { get { return new Array<TimeManager_ScheduledEvent>(this[nameof(TodayEvents)].Address); } }
        public bool UseFimbul() { return Invoke<bool>(nameof(UseFimbul)); }
        public void ShowAnnouncement(DailyAnnouncementVO AnnouncementText) { Invoke(nameof(ShowAnnouncement), AnnouncementText); }
        public void PauseElapsedTime(bool bIsPaused) { Invoke(nameof(PauseElapsedTime), bIsPaused); }
        public void LerpElapsedTimeTo(int TargetTimeSecondOffset, float Duration) { Invoke(nameof(LerpElapsedTimeTo), TargetTimeSecondOffset, Duration); }
        public bool IsWinter() { return Invoke<bool>(nameof(IsWinter)); }
        public bool IsStarted() { return Invoke<bool>(nameof(IsStarted)); }
        public bool IsSnowing() { return Invoke<bool>(nameof(IsSnowing)); }
        public bool IsBloodMoon() { return Invoke<bool>(nameof(IsBloodMoon)); }
        public void InitBloodMoonVariables() { Invoke(nameof(InitBloodMoonVariables)); }
        public void GoToNextDayTimeSegment(EDayTimeSegment newSegment, bool bUseLerp, float LerpDuration) { Invoke(nameof(GoToNextDayTimeSegment), newSegment, bUseLerp, LerpDuration); }
        public float GetWinterIntensityProgression() { return Invoke<float>(nameof(GetWinterIntensityProgression)); }
        public int GetTemperatureModifier() { return Invoke<int>(nameof(GetTemperatureModifier)); }
        public float GetSnowflakeIntensityProgression() { return Invoke<float>(nameof(GetSnowflakeIntensityProgression)); }
        public float GetSegmentProgression() { return Invoke<float>(nameof(GetSegmentProgression)); }
        public ESeason GetSeason() { return Invoke<ESeason>(nameof(GetSeason)); }
        public int GetNightTime() { return Invoke<int>(nameof(GetNightTime)); }
        public int GetNightDuration() { return Invoke<int>(nameof(GetNightDuration)); }
        public float GetFimbulRatio() { return Invoke<float>(nameof(GetFimbulRatio)); }
        public int GetEveningTime() { return Invoke<int>(nameof(GetEveningTime)); }
        public int GetEveningDuration() { return Invoke<int>(nameof(GetEveningDuration)); }
        public EDayTimeSegment GetDayTimeSegment() { return Invoke<EDayTimeSegment>(nameof(GetDayTimeSegment)); }
        public int GetDayTime() { return Invoke<int>(nameof(GetDayTime)); }
        public int GetDaysUntilSeason(ESeason TargetSeason) { return Invoke<int>(nameof(GetDaysUntilSeason), TargetSeason); }
        public int GetDaysUntilGameOver() { return Invoke<int>(nameof(GetDaysUntilGameOver)); }
        public Object GetDaysCycle() { return Invoke<Object>(nameof(GetDaysCycle)); }
        public int GetDayDuration() { return Invoke<int>(nameof(GetDayDuration)); }
        public DayCycleDataModel GetDayCycle(int Day) { return Invoke<DayCycleDataModel>(nameof(GetDayCycle), Day); }
        public int GetCurrentYearCount() { return Invoke<int>(nameof(GetCurrentYearCount)); }
        public float GetCurrentHour() { return Invoke<float>(nameof(GetCurrentHour)); }
        public DayCycleDataModel GetCurrentDayCycle() { return Invoke<DayCycleDataModel>(nameof(GetCurrentDayCycle)); }
        public int GetCurrentDayCount() { return Invoke<int>(nameof(GetCurrentDayCount)); }
        public float GetBloodMoonRatio() { return Invoke<float>(nameof(GetBloodMoonRatio)); }
        public float GetBloodMoonIntensityProgression() { return Invoke<float>(nameof(GetBloodMoonIntensityProgression)); }
    }
    public class TOMAnimInstance : AnimInstance
    {
        public TOMAnimInstance(ulong addr) : base(addr) { }
        public TOMCharacter TOMCharacter { get { return this[nameof(TOMCharacter)].As<TOMCharacter>(); } set { this["TOMCharacter"] = value; } }
        public float AnimScaleSpeed { get { return this[nameof(AnimScaleSpeed)].GetValue<float>(); } set { this[nameof(AnimScaleSpeed)].SetValue<float>(value); } }
        public float MinSpeedToStop { get { return this[nameof(MinSpeedToStop)].GetValue<float>(); } set { this[nameof(MinSpeedToStop)].SetValue<float>(value); } }
        public float WalkingSpeed { get { return this[nameof(WalkingSpeed)].GetValue<float>(); } set { this[nameof(WalkingSpeed)].SetValue<float>(value); } }
        public float RunningSpeed { get { return this[nameof(RunningSpeed)].GetValue<float>(); } set { this[nameof(RunningSpeed)].SetValue<float>(value); } }
        public float SprintingSpeed { get { return this[nameof(SprintingSpeed)].GetValue<float>(); } set { this[nameof(SprintingSpeed)].SetValue<float>(value); } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Rotator CharacterRotation { get { return this[nameof(CharacterRotation)].As<Rotator>(); } set { this["CharacterRotation"] = value; } }
        public Rotator LookingRotation { get { return this[nameof(LookingRotation)].As<Rotator>(); } set { this["LookingRotation"] = value; } }
        public float CharacterDirection { get { return this[nameof(CharacterDirection)].GetValue<float>(); } set { this[nameof(CharacterDirection)].SetValue<float>(value); } }
        public float TargetToCharacterRotationDifference { get { return this[nameof(TargetToCharacterRotationDifference)].GetValue<float>(); } set { this[nameof(TargetToCharacterRotationDifference)].SetValue<float>(value); } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public bool bIsShielding { get { return this[nameof(bIsShielding)].Flag; } set { this[nameof(bIsShielding)].Flag = value; } }
        public bool bIsBuilding { get { return this[nameof(bIsBuilding)].Flag; } set { this[nameof(bIsBuilding)].Flag = value; } }
        public bool bIsDown { get { return this[nameof(bIsDown)].Flag; } set { this[nameof(bIsDown)].Flag = value; } }
        public float Pitch { get { return this[nameof(Pitch)].GetValue<float>(); } set { this[nameof(Pitch)].SetValue<float>(value); } }
        public bool bUseAimOffset { get { return this[nameof(bUseAimOffset)].Flag; } set { this[nameof(bUseAimOffset)].Flag = value; } }
        public bool bIsHoldingAttack { get { return this[nameof(bIsHoldingAttack)].Flag; } set { this[nameof(bIsHoldingAttack)].Flag = value; } }
        public bool bIsInRagdoll { get { return this[nameof(bIsInRagdoll)].Flag; } set { this[nameof(bIsInRagdoll)].Flag = value; } }
        public float ShieldAngle { get { return this[nameof(ShieldAngle)].GetValue<float>(); } set { this[nameof(ShieldAngle)].SetValue<float>(value); } }
        public float Speed { get { return this[nameof(Speed)].GetValue<float>(); } set { this[nameof(Speed)].SetValue<float>(value); } }
        public bool bInitStanceOnce { get { return this[nameof(bInitStanceOnce)].Flag; } set { this[nameof(bInitStanceOnce)].Flag = value; } }
        public float GaitValue { get { return this[nameof(GaitValue)].GetValue<float>(); } set { this[nameof(GaitValue)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
    }
    public class TOMAssetManager : AssetManager
    {
        public TOMAssetManager(ulong addr) : base(addr) { }
    }
    public class TOMAttack : OffensiveEmissionResolver
    {
        public TOMAttack(ulong addr) : base(addr) { }
        public int ItemTypeId { get { return this[nameof(ItemTypeId)].GetValue<int>(); } set { this[nameof(ItemTypeId)].SetValue<int>(value); } }
        public bool bIsLightAttack { get { return this[nameof(bIsLightAttack)].Flag; } set { this[nameof(bIsLightAttack)].Flag = value; } }
        public bool bSuccess { get { return this[nameof(bSuccess)].Flag; } set { this[nameof(bSuccess)].Flag = value; } }
        public float StatusStackBaseMultiplier { get { return this[nameof(StatusStackBaseMultiplier)].GetValue<float>(); } set { this[nameof(StatusStackBaseMultiplier)].SetValue<float>(value); } }
        public int StatusStackBaseBonus { get { return this[nameof(StatusStackBaseBonus)].GetValue<int>(); } set { this[nameof(StatusStackBaseBonus)].SetValue<int>(value); } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public AttackStatsDataModel AttackStats { get { return this[nameof(AttackStats)].As<AttackStatsDataModel>(); } set { this["AttackStats"] = value; } }
        public ProjectileDataModel Projectile { get { return this[nameof(Projectile)].As<ProjectileDataModel>(); } set { this["Projectile"] = value; } }
        public AmmunitionDataModel AmmunitionDataModel { get { return this[nameof(AmmunitionDataModel)].As<AmmunitionDataModel>(); } set { this["AmmunitionDataModel"] = value; } }
        public void SetAttackModel(AttackStatsDataModel InAttackStats, ProjectileDataModel InProjectile) { Invoke(nameof(SetAttackModel), InAttackStats, InProjectile); }
        public float GetIssuedAmount() { return Invoke<float>(nameof(GetIssuedAmount)); }
        public float GetCameraShakeValue() { return Invoke<float>(nameof(GetCameraShakeValue)); }
        public AttackStatsDataModel GetAttackModel() { return Invoke<AttackStatsDataModel>(nameof(GetAttackModel)); }
    }
    public class TOMAttackMetaData : AnimMetaData
    {
        public TOMAttackMetaData(ulong addr) : base(addr) { }
        public float AutoRotationLength { get { return this[nameof(AutoRotationLength)].GetValue<float>(); } set { this[nameof(AutoRotationLength)].SetValue<float>(value); } }
        public float GetAutoRotationLengthFromAnim(AnimMontage Montage) { return Invoke<float>(nameof(GetAutoRotationLengthFromAnim), Montage); }
    }
    public class TOMButton : BifrostUserWidget
    {
        public TOMButton(ulong addr) : base(addr) { }
        public Button CoreButton { get { return this[nameof(CoreButton)].As<Button>(); } set { this["CoreButton"] = value; } }
        public TextBlock CoreLabel { get { return this[nameof(CoreLabel)].As<TextBlock>(); } set { this["CoreLabel"] = value; } }
        public SlateBrush NormalBrush { get { return this[nameof(NormalBrush)].As<SlateBrush>(); } set { this["NormalBrush"] = value; } }
        public SlateBrush HoveredBrush { get { return this[nameof(HoveredBrush)].As<SlateBrush>(); } set { this["HoveredBrush"] = value; } }
        public SlateBrush PressedBrush { get { return this[nameof(PressedBrush)].As<SlateBrush>(); } set { this["PressedBrush"] = value; } }
        public SlateBrush DisabledBrush { get { return this[nameof(DisabledBrush)].As<SlateBrush>(); } set { this["DisabledBrush"] = value; } }
        public Margin NormalPadding { get { return this[nameof(NormalPadding)].As<Margin>(); } set { this["NormalPadding"] = value; } }
        public Margin PressedPadding { get { return this[nameof(PressedPadding)].As<Margin>(); } set { this["PressedPadding"] = value; } }
        public void NativePreConstruct() { Invoke(nameof(NativePreConstruct)); }
    }
    public class TOMCharacter : BifrostCharacter
    {
        public TOMCharacter(ulong addr) : base(addr) { }
        public Array<StaticMeshComponent> ConstructionTools { get { return new Array<StaticMeshComponent>(this[nameof(ConstructionTools)].Address); } }
        public Object OnPossessCharacter { get { return this[nameof(OnPossessCharacter)]; } set { this[nameof(OnPossessCharacter)] = value; } }
        public Object OnCharacterMovementModeChanged { get { return this[nameof(OnCharacterMovementModeChanged)]; } set { this[nameof(OnCharacterMovementModeChanged)] = value; } }
        public Object OnCharacterDeath { get { return this[nameof(OnCharacterDeath)]; } set { this[nameof(OnCharacterDeath)] = value; } }
        public Object OnReviveCharacter { get { return this[nameof(OnReviveCharacter)]; } set { this[nameof(OnReviveCharacter)] = value; } }
        public Object OnTeleportCompleted { get { return this[nameof(OnTeleportCompleted)]; } set { this[nameof(OnTeleportCompleted)] = value; } }
        public Object OnTeleportStart { get { return this[nameof(OnTeleportStart)]; } set { this[nameof(OnTeleportStart)] = value; } }
        public Object OnEvadeStart { get { return this[nameof(OnEvadeStart)]; } set { this[nameof(OnEvadeStart)] = value; } }
        public Object OnStopRagdoll { get { return this[nameof(OnStopRagdoll)]; } set { this[nameof(OnStopRagdoll)] = value; } }
        public Object OnLightAttack { get { return this[nameof(OnLightAttack)]; } set { this[nameof(OnLightAttack)] = value; } }
        public Object OnAttackHit { get { return this[nameof(OnAttackHit)]; } set { this[nameof(OnAttackHit)] = value; } }
        public Object OnTotalBlock { get { return this[nameof(OnTotalBlock)]; } set { this[nameof(OnTotalBlock)] = value; } }
        public Object OnShieldUp { get { return this[nameof(OnShieldUp)]; } set { this[nameof(OnShieldUp)] = value; } }
        public Object OnShieldDown { get { return this[nameof(OnShieldDown)]; } set { this[nameof(OnShieldDown)] = value; } }
        public Object OnCharacterAttackStateChanged { get { return this[nameof(OnCharacterAttackStateChanged)]; } set { this[nameof(OnCharacterAttackStateChanged)] = value; } }
        public Object OnEnterOrExitCave { get { return this[nameof(OnEnterOrExitCave)]; } set { this[nameof(OnEnterOrExitCave)] = value; } }
        public Object OnShieldTargetChanged { get { return this[nameof(OnShieldTargetChanged)]; } set { this[nameof(OnShieldTargetChanged)] = value; } }
        public Object OnHoldingAttack { get { return this[nameof(OnHoldingAttack)]; } set { this[nameof(OnHoldingAttack)] = value; } }
        public Object OnCharacterEnterVillage { get { return this[nameof(OnCharacterEnterVillage)]; } set { this[nameof(OnCharacterEnterVillage)] = value; } }
        public Object OnCharacterLeaveVillage { get { return this[nameof(OnCharacterLeaveVillage)]; } set { this[nameof(OnCharacterLeaveVillage)] = value; } }
        public Object OnForceMoveEnd { get { return this[nameof(OnForceMoveEnd)]; } set { this[nameof(OnForceMoveEnd)] = value; } }
        public Object OnCurrentWeaponChanged { get { return this[nameof(OnCurrentWeaponChanged)]; } set { this[nameof(OnCurrentWeaponChanged)] = value; } }
        public Object OnRefreshIdle { get { return this[nameof(OnRefreshIdle)]; } set { this[nameof(OnRefreshIdle)] = value; } }
        public Object OnShieldUsableChanged { get { return this[nameof(OnShieldUsableChanged)]; } set { this[nameof(OnShieldUsableChanged)] = value; } }
        public float IdleTimerDelay { get { return this[nameof(IdleTimerDelay)].GetValue<float>(); } set { this[nameof(IdleTimerDelay)].SetValue<float>(value); } }
        public bool bCustomFellOutOfWorld { get { return this[nameof(bCustomFellOutOfWorld)].Flag; } set { this[nameof(bCustomFellOutOfWorld)].Flag = value; } }
        public float ALS_RotationRate { get { return this[nameof(ALS_RotationRate)].GetValue<float>(); } set { this[nameof(ALS_RotationRate)].SetValue<float>(value); } }
        public float ALS_BeamRotationRate { get { return this[nameof(ALS_BeamRotationRate)].GetValue<float>(); } set { this[nameof(ALS_BeamRotationRate)].SetValue<float>(value); } }
        public float NormalRotationRate { get { return this[nameof(NormalRotationRate)].GetValue<float>(); } set { this[nameof(NormalRotationRate)].SetValue<float>(value); } }
        public float BuildingRotationRate { get { return this[nameof(BuildingRotationRate)].GetValue<float>(); } set { this[nameof(BuildingRotationRate)].SetValue<float>(value); } }
        public float BuildingWalkSpeedRatio { get { return this[nameof(BuildingWalkSpeedRatio)].GetValue<float>(); } set { this[nameof(BuildingWalkSpeedRatio)].SetValue<float>(value); } }
        public float FootstepTraceLength { get { return this[nameof(FootstepTraceLength)].GetValue<float>(); } set { this[nameof(FootstepTraceLength)].SetValue<float>(value); } }
        public bool bUseAutoRotation { get { return this[nameof(bUseAutoRotation)].Flag; } set { this[nameof(bUseAutoRotation)].Flag = value; } }
        public bool bAutoRotationIgnoreVelocity { get { return this[nameof(bAutoRotationIgnoreVelocity)].Flag; } set { this[nameof(bAutoRotationIgnoreVelocity)].Flag = value; } }
        public bool bCanEverUseAimOffset { get { return this[nameof(bCanEverUseAimOffset)].Flag; } set { this[nameof(bCanEverUseAimOffset)].Flag = value; } }
        public Object CameraSettings { get { return this[nameof(CameraSettings)]; } set { this[nameof(CameraSettings)] = value; } }
        public Object CharacterAudioName { get { return this[nameof(CharacterAudioName)]; } set { this[nameof(CharacterAudioName)] = value; } }
        public bool bIsImmuneToFallDamage { get { return this[nameof(bIsImmuneToFallDamage)].Flag; } set { this[nameof(bIsImmuneToFallDamage)].Flag = value; } }
        public CurveFloat CameraLerpCurve { get { return this[nameof(CameraLerpCurve)].As<CurveFloat>(); } set { this["CameraLerpCurve"] = value; } }
        public Object PelvisBoneName { get { return this[nameof(PelvisBoneName)]; } set { this[nameof(PelvisBoneName)] = value; } }
        public AnimMontage GetUpFromFront { get { return this[nameof(GetUpFromFront)].As<AnimMontage>(); } set { this["GetUpFromFront"] = value; } }
        public AnimMontage GetUpFromBack { get { return this[nameof(GetUpFromBack)].As<AnimMontage>(); } set { this["GetUpFromBack"] = value; } }
        public Object ProjectileOriginSocket { get { return this[nameof(ProjectileOriginSocket)]; } set { this[nameof(ProjectileOriginSocket)] = value; } }
        public bool bDoPlayCriticalHit { get { return this[nameof(bDoPlayCriticalHit)].Flag; } set { this[nameof(bDoPlayCriticalHit)].Flag = value; } }
        public ParticleSystem CriticalHitEyesVFX { get { return this[nameof(CriticalHitEyesVFX)].As<ParticleSystem>(); } set { this["CriticalHitEyesVFX"] = value; } }
        public Object CriticalHitEyesVFXSocketName { get { return this[nameof(CriticalHitEyesVFXSocketName)]; } set { this[nameof(CriticalHitEyesVFXSocketName)] = value; } }
        public Vector CriticalHitEyesVFXScale { get { return this[nameof(CriticalHitEyesVFXScale)].As<Vector>(); } set { this["CriticalHitEyesVFXScale"] = value; } }
        public Object CriticalHitSFXSuffix { get { return this[nameof(CriticalHitSFXSuffix)]; } set { this[nameof(CriticalHitSFXSuffix)] = value; } }
        public AnimMontage RollForwardMontage { get { return this[nameof(RollForwardMontage)].As<AnimMontage>(); } set { this["RollForwardMontage"] = value; } }
        public CurveFloat RollSpeedCurve { get { return this[nameof(RollSpeedCurve)].As<CurveFloat>(); } set { this["RollSpeedCurve"] = value; } }
        public float RollRecoveryTime { get { return this[nameof(RollRecoveryTime)].GetValue<float>(); } set { this[nameof(RollRecoveryTime)].SetValue<float>(value); } }
        public bool bIsInvicibleDuringRoll { get { return this[nameof(bIsInvicibleDuringRoll)].Flag; } set { this[nameof(bIsInvicibleDuringRoll)].Flag = value; } }
        public CurveFloat JumpCurve { get { return this[nameof(JumpCurve)].As<CurveFloat>(); } set { this["JumpCurve"] = value; } }
        public AnimMontage CollectMontage { get { return this[nameof(CollectMontage)].As<AnimMontage>(); } set { this["CollectMontage"] = value; } }
        public AnimMontage TwoHandCollectMontage { get { return this[nameof(TwoHandCollectMontage)].As<AnimMontage>(); } set { this["TwoHandCollectMontage"] = value; } }
        public AnimMontage MiningMontage { get { return this[nameof(MiningMontage)].As<AnimMontage>(); } set { this["MiningMontage"] = value; } }
        public AnimMontage TwoHandMiningMontage { get { return this[nameof(TwoHandMiningMontage)].As<AnimMontage>(); } set { this["TwoHandMiningMontage"] = value; } }
        public AnimMontage CuttingMontage { get { return this[nameof(CuttingMontage)].As<AnimMontage>(); } set { this["CuttingMontage"] = value; } }
        public AnimMontage TwoHandCuttingMontage { get { return this[nameof(TwoHandCuttingMontage)].As<AnimMontage>(); } set { this["TwoHandCuttingMontage"] = value; } }
        public AnimMontage OpenChestMontage { get { return this[nameof(OpenChestMontage)].As<AnimMontage>(); } set { this["OpenChestMontage"] = value; } }
        public AnimMontage TwoHandOpenChestMontage { get { return this[nameof(TwoHandOpenChestMontage)].As<AnimMontage>(); } set { this["TwoHandOpenChestMontage"] = value; } }
        public AnimMontage BuildingMontage { get { return this[nameof(BuildingMontage)].As<AnimMontage>(); } set { this["BuildingMontage"] = value; } }
        public Object HPBarClass { get { return this[nameof(HPBarClass)]; } set { this[nameof(HPBarClass)] = value; } }
        public Object GeneralAlertImpossibleAction { get { return this[nameof(GeneralAlertImpossibleAction)]; } set { this[nameof(GeneralAlertImpossibleAction)] = value; } }
        public ParticleSystem ManaGainEffect { get { return this[nameof(ManaGainEffect)].As<ParticleSystem>(); } set { this["ManaGainEffect"] = value; } }
        public float ForceMoveTraceMaxHeight { get { return this[nameof(ForceMoveTraceMaxHeight)].GetValue<float>(); } set { this[nameof(ForceMoveTraceMaxHeight)].SetValue<float>(value); } }
        public bool bAudioPlayFootsteps { get { return this[nameof(bAudioPlayFootsteps)].Flag; } set { this[nameof(bAudioPlayFootsteps)].Flag = value; } }
        public bool bAudioUseStaticFootsteps { get { return this[nameof(bAudioUseStaticFootsteps)].Flag; } set { this[nameof(bAudioUseStaticFootsteps)].Flag = value; } }
        public Object StaticFootstepWalk { get { return this[nameof(StaticFootstepWalk)]; } set { this[nameof(StaticFootstepWalk)] = value; } }
        public Object StaticFootstepRun { get { return this[nameof(StaticFootstepRun)]; } set { this[nameof(StaticFootstepRun)] = value; } }
        public bool bAudioPlayHurt { get { return this[nameof(bAudioPlayHurt)].Flag; } set { this[nameof(bAudioPlayHurt)].Flag = value; } }
        public Object ShieldUpSFX { get { return this[nameof(ShieldUpSFX)]; } set { this[nameof(ShieldUpSFX)] = value; } }
        public Object ShieldDownSFX { get { return this[nameof(ShieldDownSFX)]; } set { this[nameof(ShieldDownSFX)] = value; } }
        public Object ProjectileSocketName { get { return this[nameof(ProjectileSocketName)]; } set { this[nameof(ProjectileSocketName)] = value; } }
        public bool bAllowMoveWhileHit { get { return this[nameof(bAllowMoveWhileHit)].Flag; } set { this[nameof(bAllowMoveWhileHit)].Flag = value; } }
        public bool bIgnoreWaterCollision { get { return this[nameof(bIgnoreWaterCollision)].Flag; } set { this[nameof(bIgnoreWaterCollision)].Flag = value; } }
        public int DefaultAnimalId { get { return this[nameof(DefaultAnimalId)].GetValue<int>(); } set { this[nameof(DefaultAnimalId)].SetValue<int>(value); } }
        public int DefaultBehaviorId { get { return this[nameof(DefaultBehaviorId)].GetValue<int>(); } set { this[nameof(DefaultBehaviorId)].SetValue<int>(value); } }
        public ECharacterType CharacterType { get { return (ECharacterType)this[nameof(CharacterType)].GetValue<int>(); } set { this[nameof(CharacterType)].SetValue<int>((int)value); } }
        public int FogVisionRange { get { return this[nameof(FogVisionRange)].GetValue<int>(); } set { this[nameof(FogVisionRange)].SetValue<int>(value); } }
        public Array<int> RepStatusIds { get { return new Array<int>(this[nameof(RepStatusIds)].Address); } }
        public float ForwardAxis { get { return this[nameof(ForwardAxis)].GetValue<float>(); } set { this[nameof(ForwardAxis)].SetValue<float>(value); } }
        public float RightAxis { get { return this[nameof(RightAxis)].GetValue<float>(); } set { this[nameof(RightAxis)].SetValue<float>(value); } }
        public bool ALS_bIgnoreVelocity { get { return this[nameof(ALS_bIgnoreVelocity)].Flag; } set { this[nameof(ALS_bIgnoreVelocity)].Flag = value; } }
        public bool bIgnoreVelocityByAnimState { get { return this[nameof(bIgnoreVelocityByAnimState)].Flag; } set { this[nameof(bIgnoreVelocityByAnimState)].Flag = value; } }
        public float ALS_Direction { get { return this[nameof(ALS_Direction)].GetValue<float>(); } set { this[nameof(ALS_Direction)].SetValue<float>(value); } }
        public Rotator ALS_CharacterRotation { get { return this[nameof(ALS_CharacterRotation)].As<Rotator>(); } set { this["ALS_CharacterRotation"] = value; } }
        public Rotator ALS_TargetRotation { get { return this[nameof(ALS_TargetRotation)].As<Rotator>(); } set { this["ALS_TargetRotation"] = value; } }
        public Rotator ALS_LastMovementInputRotation { get { return this[nameof(ALS_LastMovementInputRotation)].As<Rotator>(); } set { this["ALS_LastMovementInputRotation"] = value; } }
        public float YawVelocity { get { return this[nameof(YawVelocity)].GetValue<float>(); } set { this[nameof(YawVelocity)].SetValue<float>(value); } }
        public float VelocitySize { get { return this[nameof(VelocitySize)].GetValue<float>(); } set { this[nameof(VelocitySize)].SetValue<float>(value); } }
        public Rotator ALS_LookingRotation { get { return this[nameof(ALS_LookingRotation)].As<Rotator>(); } set { this["ALS_LookingRotation"] = value; } }
        public Rotator ALS_LookDirection { get { return this[nameof(ALS_LookDirection)].As<Rotator>(); } set { this["ALS_LookDirection"] = value; } }
        public Rotator ALS_InitRotation { get { return this[nameof(ALS_InitRotation)].As<Rotator>(); } set { this["ALS_InitRotation"] = value; } }
        public Actor ALS_LookingTarget { get { return this[nameof(ALS_LookingTarget)].As<Actor>(); } set { this["ALS_LookingTarget"] = value; } }
        public float ALS_MovementInputToVelocityDifference { get { return this[nameof(ALS_MovementInputToVelocityDifference)].GetValue<float>(); } set { this[nameof(ALS_MovementInputToVelocityDifference)].SetValue<float>(value); } }
        public float ALS_TargetToCharacterRotationDifference { get { return this[nameof(ALS_TargetToCharacterRotationDifference)].GetValue<float>(); } set { this[nameof(ALS_TargetToCharacterRotationDifference)].SetValue<float>(value); } }
        public bool bFreezeMovement { get { return this[nameof(bFreezeMovement)].Flag; } set { this[nameof(bFreezeMovement)].Flag = value; } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public bool bIsInteracting { get { return this[nameof(bIsInteracting)].Flag; } set { this[nameof(bIsInteracting)].Flag = value; } }
        public bool bIsTeleporting { get { return this[nameof(bIsTeleporting)].Flag; } set { this[nameof(bIsTeleporting)].Flag = value; } }
        public bool bIsShielding { get { return this[nameof(bIsShielding)].Flag; } set { this[nameof(bIsShielding)].Flag = value; } }
        public bool bIsBuilding { get { return this[nameof(bIsBuilding)].Flag; } set { this[nameof(bIsBuilding)].Flag = value; } }
        public bool bIsDestructionMode { get { return this[nameof(bIsDestructionMode)].Flag; } set { this[nameof(bIsDestructionMode)].Flag = value; } }
        public bool bIsWalking { get { return this[nameof(bIsWalking)].Flag; } set { this[nameof(bIsWalking)].Flag = value; } }
        public bool bIsUsingBeamAttack { get { return this[nameof(bIsUsingBeamAttack)].Flag; } set { this[nameof(bIsUsingBeamAttack)].Flag = value; } }
        public float SpeedRatio { get { return this[nameof(SpeedRatio)].GetValue<float>(); } set { this[nameof(SpeedRatio)].SetValue<float>(value); } }
        public float AttackSpeedRatio { get { return this[nameof(AttackSpeedRatio)].GetValue<float>(); } set { this[nameof(AttackSpeedRatio)].SetValue<float>(value); } }
        public float MoveSpeedRatio { get { return this[nameof(MoveSpeedRatio)].GetValue<float>(); } set { this[nameof(MoveSpeedRatio)].SetValue<float>(value); } }
        public int StunEffectCount { get { return this[nameof(StunEffectCount)].GetValue<int>(); } set { this[nameof(StunEffectCount)].SetValue<int>(value); } }
        public bool bIsHoldingAttack { get { return this[nameof(bIsHoldingAttack)].Flag; } set { this[nameof(bIsHoldingAttack)].Flag = value; } }
        public bool bIsInForceLookDirection { get { return this[nameof(bIsInForceLookDirection)].Flag; } set { this[nameof(bIsInForceLookDirection)].Flag = value; } }
        public bool bIsHarvesting { get { return this[nameof(bIsHarvesting)].Flag; } set { this[nameof(bIsHarvesting)].Flag = value; } }
        public EALSRotationMode ALS_RotationMode { get { return (EALSRotationMode)this[nameof(ALS_RotationMode)].GetValue<int>(); } set { this[nameof(ALS_RotationMode)].SetValue<int>((int)value); } }
        public ECharacterMovementMode CharacterMovementMode { get { return (ECharacterMovementMode)this[nameof(CharacterMovementMode)].GetValue<int>(); } set { this[nameof(CharacterMovementMode)].SetValue<int>((int)value); } }
        public int CurrentWeaponDataId { get { return this[nameof(CurrentWeaponDataId)].GetValue<int>(); } set { this[nameof(CurrentWeaponDataId)].SetValue<int>(value); } }
        public int CurrentShieldDataId { get { return this[nameof(CurrentShieldDataId)].GetValue<int>(); } set { this[nameof(CurrentShieldDataId)].SetValue<int>(value); } }
        public CreatureProperties CreatureProperties { get { return this[nameof(CreatureProperties)].As<CreatureProperties>(); } set { this["CreatureProperties"] = value; } }
        public TOMEquipmentBase CurrentWeaponActor { get { return this[nameof(CurrentWeaponActor)].As<TOMEquipmentBase>(); } set { this["CurrentWeaponActor"] = value; } }
        public TOMEquipmentBase CurrentShieldActor { get { return this[nameof(CurrentShieldActor)].As<TOMEquipmentBase>(); } set { this["CurrentShieldActor"] = value; } }
        public bool bIsIdle { get { return this[nameof(bIsIdle)].Flag; } set { this[nameof(bIsIdle)].Flag = value; } }
        public bool bIsForcedToMove { get { return this[nameof(bIsForcedToMove)].Flag; } set { this[nameof(bIsForcedToMove)].Flag = value; } }
        public bool bIsKnockBack { get { return this[nameof(bIsKnockBack)].Flag; } set { this[nameof(bIsKnockBack)].Flag = value; } }
        public bool bIsHit { get { return this[nameof(bIsHit)].Flag; } set { this[nameof(bIsHit)].Flag = value; } }
        public Actor ProjectileTargetActor { get { return this[nameof(ProjectileTargetActor)].As<Actor>(); } set { this["ProjectileTargetActor"] = value; } }
        public AttackStatsDataModel CurrentAttack { get { return this[nameof(CurrentAttack)].As<AttackStatsDataModel>(); } set { this["CurrentAttack"] = value; } }
        public Object AttackCooldowns { get { return this[nameof(AttackCooldowns)]; } set { this[nameof(AttackCooldowns)] = value; } }
        public bool bIsRolling { get { return this[nameof(bIsRolling)].Flag; } set { this[nameof(bIsRolling)].Flag = value; } }
        public bool bRollRecovery { get { return this[nameof(bRollRecovery)].Flag; } set { this[nameof(bRollRecovery)].Flag = value; } }
        public MaterialSourceDataModel CurrentlyHarvestedMaterialSourceData { get { return this[nameof(CurrentlyHarvestedMaterialSourceData)].As<MaterialSourceDataModel>(); } set { this["CurrentlyHarvestedMaterialSourceData"] = value; } }
        public MaterialSourceBase CurrentlyHarvestedMaterialSource { get { return this[nameof(CurrentlyHarvestedMaterialSource)].As<MaterialSourceBase>(); } set { this["CurrentlyHarvestedMaterialSource"] = value; } }
        public ParticleSystem WaterVfx { get { return this[nameof(WaterVfx)].As<ParticleSystem>(); } set { this["WaterVfx"] = value; } }
        public ParticleSystem BushMovementVFXTrail { get { return this[nameof(BushMovementVFXTrail)].As<ParticleSystem>(); } set { this["BushMovementVFXTrail"] = value; } }
        public Object OnCharacterSwap { get { return this[nameof(OnCharacterSwap)]; } set { this[nameof(OnCharacterSwap)] = value; } }
        public Array<Object> ProjectileSockets { get { return new Array<Object>(this[nameof(ProjectileSockets)].Address); } }
        public bool bIsUsingConstructionTool { get { return this[nameof(bIsUsingConstructionTool)].Flag; } set { this[nameof(bIsUsingConstructionTool)].Flag = value; } }
        public ParticleSystemComponent BushMovementVFXComponent { get { return this[nameof(BushMovementVFXComponent)].As<ParticleSystemComponent>(); } set { this["BushMovementVFXComponent"] = value; } }
        public SceneComponent ProjectileOriginPoint { get { return this[nameof(ProjectileOriginPoint)].As<SceneComponent>(); } set { this["ProjectileOriginPoint"] = value; } }
        public SceneComponent FloatingUIAnchor { get { return this[nameof(FloatingUIAnchor)].As<SceneComponent>(); } set { this["FloatingUIAnchor"] = value; } }
        public bool bCanMoveWhileDowned { get { return this[nameof(bCanMoveWhileDowned)].Flag; } set { this[nameof(bCanMoveWhileDowned)].Flag = value; } }
        public bool bIsMinion { get { return this[nameof(bIsMinion)].Flag; } set { this[nameof(bIsMinion)].Flag = value; } }
        public int CurrentCaveDataId { get { return this[nameof(CurrentCaveDataId)].GetValue<int>(); } set { this[nameof(CurrentCaveDataId)].SetValue<int>(value); } }
        public CaveProperties CaveProperties { get { return this[nameof(CaveProperties)].As<CaveProperties>(); } set { this["CaveProperties"] = value; } }
        public CaveBase PreviousCaveActor { get { return this[nameof(PreviousCaveActor)].As<CaveBase>(); } set { this["PreviousCaveActor"] = value; } }
        public Vector CaveEntryPosition { get { return this[nameof(CaveEntryPosition)].As<Vector>(); } set { this["CaveEntryPosition"] = value; } }
        public Array<Actor> NearbyCreatures { get { return new Array<Actor>(this[nameof(NearbyCreatures)].Address); } }
        public float AimPitch { get { return this[nameof(AimPitch)].GetValue<float>(); } set { this[nameof(AimPitch)].SetValue<float>(value); } }
        public ForceMoveParam ForceMoveParam { get { return this[nameof(ForceMoveParam)].As<ForceMoveParam>(); } set { this["ForceMoveParam"] = value; } }
        public WorldCreatureEntityModel CreatureEntity { get { return this[nameof(CreatureEntity)].As<WorldCreatureEntityModel>(); } set { this["CreatureEntity"] = value; } }
        public ContainerSlotItemEntityModel CurrentWeaponItemEntity { get { return this[nameof(CurrentWeaponItemEntity)].As<ContainerSlotItemEntityModel>(); } set { this["CurrentWeaponItemEntity"] = value; } }
        public float TimeOfLastActivity { get { return this[nameof(TimeOfLastActivity)].GetValue<float>(); } set { this[nameof(TimeOfLastActivity)].SetValue<float>(value); } }
        public bool bIsSelected { get { return this[nameof(bIsSelected)].Flag; } set { this[nameof(bIsSelected)].Flag = value; } }
        public bool bSelectionUseStencil { get { return this[nameof(bSelectionUseStencil)].Flag; } set { this[nameof(bSelectionUseStencil)].Flag = value; } }
        public bool bAutoTargetForcedByCharacter { get { return this[nameof(bAutoTargetForcedByCharacter)].Flag; } set { this[nameof(bAutoTargetForcedByCharacter)].Flag = value; } }
        public bool bIsMenuOpen { get { return this[nameof(bIsMenuOpen)].Flag; } set { this[nameof(bIsMenuOpen)].Flag = value; } }
        public Array<MeshComponent> AllAttachedMeshes { get { return new Array<MeshComponent>(this[nameof(AllAttachedMeshes)].Address); } }
        public ProjectileBase HoldArrow { get { return this[nameof(HoldArrow)].As<ProjectileBase>(); } set { this["HoldArrow"] = value; } }
        public float CharacterOffset { get { return this[nameof(CharacterOffset)].GetValue<float>(); } set { this[nameof(CharacterOffset)].SetValue<float>(value); } }
        public Object AlertTreasureMap { get { return this[nameof(AlertTreasureMap)]; } set { this[nameof(AlertTreasureMap)] = value; } }
        public float AnimScaleSpeed { get { return this[nameof(AnimScaleSpeed)].GetValue<float>(); } set { this[nameof(AnimScaleSpeed)].SetValue<float>(value); } }
        public float MinSpeedToStop { get { return this[nameof(MinSpeedToStop)].GetValue<float>(); } set { this[nameof(MinSpeedToStop)].SetValue<float>(value); } }
        public bool bInitStanceOnce { get { return this[nameof(bInitStanceOnce)].Flag; } set { this[nameof(bInitStanceOnce)].Flag = value; } }
        public bool bWasInvinciblePreTeleportation { get { return this[nameof(bWasInvinciblePreTeleportation)].Flag; } set { this[nameof(bWasInvinciblePreTeleportation)].Flag = value; } }
        public Array<PlayerSkillDataModel> CurrentPlayerSkills { get { return new Array<PlayerSkillDataModel>(this[nameof(CurrentPlayerSkills)].Address); } }
        public Object VFXStatus { get { return this[nameof(VFXStatus)]; } set { this[nameof(VFXStatus)] = value; } }
        public Object CurrentStatus { get { return this[nameof(CurrentStatus)]; } set { this[nameof(CurrentStatus)] = value; } }
        public bool bIsActivated { get { return this[nameof(bIsActivated)].Flag; } set { this[nameof(bIsActivated)].Flag = value; } }
        public ECharacterAttackState CharacterAttackState { get { return (ECharacterAttackState)this[nameof(CharacterAttackState)].GetValue<int>(); } set { this[nameof(CharacterAttackState)].SetValue<int>((int)value); } }
        public int CurrentMunition { get { return this[nameof(CurrentMunition)].GetValue<int>(); } set { this[nameof(CurrentMunition)].SetValue<int>(value); } }
        public TOMOffensiveComponent OffensiveComponent { get { return this[nameof(OffensiveComponent)].As<TOMOffensiveComponent>(); } set { this["OffensiveComponent"] = value; } }
        public DefensiveShieldComponent DefensiveComponent { get { return this[nameof(DefensiveComponent)].As<DefensiveShieldComponent>(); } set { this["DefensiveComponent"] = value; } }
        public TrackedEntityComponent TrackedEntityComponent { get { return this[nameof(TrackedEntityComponent)].As<TrackedEntityComponent>(); } set { this["TrackedEntityComponent"] = value; } }
        public TOMOffensiveComponent TOMOffensive { get { return this[nameof(TOMOffensive)].As<TOMOffensiveComponent>(); } set { this["TOMOffensive"] = value; } }
        public HealthComponent HealthComponent { get { return this[nameof(HealthComponent)].As<HealthComponent>(); } set { this["HealthComponent"] = value; } }
        public InteractorComponent InteractorComponent { get { return this[nameof(InteractorComponent)].As<InteractorComponent>(); } set { this["InteractorComponent"] = value; } }
        public SpecialPointComponent SpecialPointComponent { get { return this[nameof(SpecialPointComponent)].As<SpecialPointComponent>(); } set { this["SpecialPointComponent"] = value; } }
        public OnHitRagdollComponent OnHitRagdollComponent { get { return this[nameof(OnHitRagdollComponent)].As<OnHitRagdollComponent>(); } set { this["OnHitRagdollComponent"] = value; } }
        public InventoryContainerBaseComponent InventoryComponent { get { return this[nameof(InventoryComponent)].As<InventoryContainerBaseComponent>(); } set { this["InventoryComponent"] = value; } }
        public PlayerTemperatureMonitorComponent PlayerTemperatureMonitorComponent { get { return this[nameof(PlayerTemperatureMonitorComponent)].As<PlayerTemperatureMonitorComponent>(); } set { this["PlayerTemperatureMonitorComponent"] = value; } }
        public CharacterDataModel CharacterDataModel { get { return this[nameof(CharacterDataModel)].As<CharacterDataModel>(); } set { this["CharacterDataModel"] = value; } }
        public ECameraZoomLevel TargetCameraZoomLevel { get { return (ECameraZoomLevel)this[nameof(TargetCameraZoomLevel)].GetValue<int>(); } set { this[nameof(TargetCameraZoomLevel)].SetValue<int>((int)value); } }
        public CameraSettings CurrentCameraSettings { get { return this[nameof(CurrentCameraSettings)].As<CameraSettings>(); } set { this["CurrentCameraSettings"] = value; } }
        public SpringArmComponent CameraArm { get { return this[nameof(CameraArm)].As<SpringArmComponent>(); } set { this["CameraArm"] = value; } }
        public float CameraZoomAlphaLerp { get { return this[nameof(CameraZoomAlphaLerp)].GetValue<float>(); } set { this[nameof(CameraZoomAlphaLerp)].SetValue<float>(value); } }
        public bool bIsZoomInProgress { get { return this[nameof(bIsZoomInProgress)].Flag; } set { this[nameof(bIsZoomInProgress)].Flag = value; } }
        public EStackableAction NextAction { get { return (EStackableAction)this[nameof(NextAction)].GetValue<int>(); } set { this[nameof(NextAction)].SetValue<int>((int)value); } }
        public AttackStatsDataModel NextAttack { get { return this[nameof(NextAttack)].As<AttackStatsDataModel>(); } set { this["NextAttack"] = value; } }
        public Rotator NextAttackAutoRotation { get { return this[nameof(NextAttackAutoRotation)].As<Rotator>(); } set { this["NextAttackAutoRotation"] = value; } }
        public bool bNextAttackIsLight { get { return this[nameof(bNextAttackIsLight)].Flag; } set { this[nameof(bNextAttackIsLight)].Flag = value; } }
        public int LightAttackComboCount { get { return this[nameof(LightAttackComboCount)].GetValue<int>(); } set { this[nameof(LightAttackComboCount)].SetValue<int>(value); } }
        public WeaponDataModel CurrentWeaponData { get { return this[nameof(CurrentWeaponData)].As<WeaponDataModel>(); } set { this["CurrentWeaponData"] = value; } }
        public ShieldDataModel CurrentShieldData { get { return this[nameof(CurrentShieldData)].As<ShieldDataModel>(); } set { this["CurrentShieldData"] = value; } }
        public ContainerSlotItemEntityModel CurrentShieldItemEntity { get { return this[nameof(CurrentShieldItemEntity)].As<ContainerSlotItemEntityModel>(); } set { this["CurrentShieldItemEntity"] = value; } }
        public TOMEquipmentBase CurrentTool { get { return this[nameof(CurrentTool)].As<TOMEquipmentBase>(); } set { this["CurrentTool"] = value; } }
        public CaveEntityModel CurrentCave { get { return this[nameof(CurrentCave)].As<CaveEntityModel>(); } set { this["CurrentCave"] = value; } }
        public TOMCharacter TargetLockedCharacter { get { return this[nameof(TargetLockedCharacter)].As<TOMCharacter>(); } set { this["TargetLockedCharacter"] = value; } }
        public Actor ShieldLockedCharacter { get { return this[nameof(ShieldLockedCharacter)].As<Actor>(); } set { this["ShieldLockedCharacter"] = value; } }
        public Object LoadingPerks { get { return this[nameof(LoadingPerks)]; } set { this[nameof(LoadingPerks)] = value; } }
        public Array<ContainerSlotEntityModel> AppliedModifierSlots { get { return new Array<ContainerSlotEntityModel>(this[nameof(AppliedModifierSlots)].Address); } }
        public bool UseTrap(ContainerSlotEntityModel Slot) { return Invoke<bool>(nameof(UseTrap), Slot); }
        public bool UsesAimOffset() { return Invoke<bool>(nameof(UsesAimOffset)); }
        public void UseConsumable(ContainerSlotEntityModel Slot) { Invoke(nameof(UseConsumable), Slot); }
        public void TeleportAtLocation(Vector Location, bool PlayVFX) { Invoke(nameof(TeleportAtLocation), Location, PlayVFX); }
        public void SwapActor(int AnimalId, Object Callback, bool bDestroyActor) { Invoke(nameof(SwapActor), AnimalId, Callback, bDestroyActor); }
        public void StopWalking() { Invoke(nameof(StopWalking)); }
        public void StopUsingTool() { Invoke(nameof(StopUsingTool)); }
        public void StopUsingConstructionTool() { Invoke(nameof(StopUsingConstructionTool)); }
        public void StopUsingBeamAttack() { Invoke(nameof(StopUsingBeamAttack)); }
        public void StopShielding() { Invoke(nameof(StopShielding)); }
        public void StopMontageReplicatedMulticast(AnimMontage Montage) { Invoke(nameof(StopMontageReplicatedMulticast), Montage); }
        public void StopLookRotation() { Invoke(nameof(StopLookRotation)); }
        public void StopLookingAtTarget() { Invoke(nameof(StopLookingAtTarget)); }
        public void StopHoldingShieldInput() { Invoke(nameof(StopHoldingShieldInput)); }
        public void StopDestructionMode() { Invoke(nameof(StopDestructionMode)); }
        public void StopBuilding() { Invoke(nameof(StopBuilding)); }
        public void StartWalking() { Invoke(nameof(StartWalking)); }
        public void StartUsingTool() { Invoke(nameof(StartUsingTool)); }
        public void StartUsingConstructionTool() { Invoke(nameof(StartUsingConstructionTool)); }
        public void StartUsingBeamAttack() { Invoke(nameof(StartUsingBeamAttack)); }
        public void StartTeleport() { Invoke(nameof(StartTeleport)); }
        public void StartShielding(Actor ShieldLockTarget) { Invoke(nameof(StartShielding), ShieldLockTarget); }
        public void StartLookRotationTo(Rotator InLookRotation) { Invoke(nameof(StartLookRotationTo), InLookRotation); }
        public void StartLookingAtTarget(Actor LookTarget) { Invoke(nameof(StartLookingAtTarget), LookTarget); }
        public void StartHoldingShieldInput(Actor ShieldLockTarget) { Invoke(nameof(StartHoldingShieldInput), ShieldLockTarget); }
        public void StartHoldingAttack() { Invoke(nameof(StartHoldingAttack)); }
        public void StartDestructionMode() { Invoke(nameof(StartDestructionMode)); }
        public void StartBuilding() { Invoke(nameof(StartBuilding)); }
        public void StackTauntAttack(Rotator AutoRotation) { Invoke(nameof(StackTauntAttack), AutoRotation); }
        public void StackSpecificAttackById(int attackId, Rotator AutoRotation) { Invoke(nameof(StackSpecificAttackById), attackId, AutoRotation); }
        public void StackSpecificAttack(int attackId, Rotator AutoRotation, int MunitionItemId) { Invoke(nameof(StackSpecificAttack), attackId, AutoRotation, MunitionItemId); }
        public void StackSpecialAttack(int SpecialAttackIndex, Rotator AutoRotation) { Invoke(nameof(StackSpecialAttack), SpecialAttackIndex, AutoRotation); }
        public void StackShieldSkill(Rotator AutoRotation, EPerkType StatusSkillType) { Invoke(nameof(StackShieldSkill), AutoRotation, StatusSkillType); }
        public void StackLightAttack(Rotator AutoRotation, int MunitionItemId) { Invoke(nameof(StackLightAttack), AutoRotation, MunitionItemId); }
        public void StackEvade(Rotator EvadeRotation) { Invoke(nameof(StackEvade), EvadeRotation); }
        public void SpawnInstantAOE(AttackStatsDataModel AttackModel, DefensiveShieldComponent Target, Vector ImpactLocation, StatusComponent Status) { Invoke(nameof(SpawnInstantAOE), AttackModel, Target, ImpactLocation, Status); }
        public void SpawnEmitterAttachedToCharacterMulticast(ParticleSystem ParticleSystem, Object SocketName, Vector Scale) { Invoke(nameof(SpawnEmitterAttachedToCharacterMulticast), ParticleSystem, SocketName, Scale); }
        public void SpawnEmitterAttachedToCharacter(ParticleSystem ParticleSystem, Object SocketName, Vector Scale) { Invoke(nameof(SpawnEmitterAttachedToCharacter), ParticleSystem, SocketName, Scale); }
        public Vector SpawnAttackImpact(Transform ImpactOrigin, AttackStatsDataModel Attack, bool IsLastImpact, DefensiveShieldComponent Target, StatusComponent Status) { return Invoke<Vector>(nameof(SpawnAttackImpact), ImpactOrigin, Attack, IsLastImpact, Target, Status); }
        public void Spawn() { Invoke(nameof(Spawn)); }
        public void SimpleTeleport(Vector Location) { Invoke(nameof(SimpleTeleport), Location); }
        public void ShowSelection() { Invoke(nameof(ShowSelection)); }
        public void ShowProjectilePreview(bool bShow) { Invoke(nameof(ShowProjectilePreview), bShow); }
        public void SetupBushVFXComponent() { Invoke(nameof(SetupBushVFXComponent)); }
        public void SetTeleportInvincibility(bool bSetInvincible) { Invoke(nameof(SetTeleportInvincibility), bSetInvincible); }
        public void SetShieldLockTarget(Actor ShieldLockTarget) { Invoke(nameof(SetShieldLockTarget), ShieldLockTarget); }
        public void SetMoveInputRight(float InRightAxis) { Invoke(nameof(SetMoveInputRight), InRightAxis); }
        public void SetMoveInputForward(float InForwardAxis) { Invoke(nameof(SetMoveInputForward), InForwardAxis); }
        public void SetCharacterDataModel(CharacterDataModel InCharacterDataModel) { Invoke(nameof(SetCharacterDataModel), InCharacterDataModel); }
        public void SetCharacterAttackState(ECharacterAttackState InCharacterAttackState) { Invoke(nameof(SetCharacterAttackState), InCharacterAttackState); }
        public void SetCameraZoomLevel(ECameraZoomLevel InCurrentCameraZoomLevel) { Invoke(nameof(SetCameraZoomLevel), InCurrentCameraZoomLevel); }
        public void SetCameraZoomLevel(int InCurrentCameraZoomLevel) { Invoke(nameof(SetCameraZoomLevel), InCurrentCameraZoomLevel); }
        public void SetBowMoveLock(bool BowHoldMoveLock) { Invoke(nameof(SetBowMoveLock), BowHoldMoveLock); }
        public void SetAnimalEntityModel(WorldCreatureEntityModel InEntityModel) { Invoke(nameof(SetAnimalEntityModel), InEntityModel); }
        public void ResumeVelocityTracking() { Invoke(nameof(ResumeVelocityTracking)); }
        public void RemoveVFXStatusFromPerkMutlicast(int PerkId) { Invoke(nameof(RemoveVFXStatusFromPerkMutlicast), PerkId); }
        public void RemoveStatusByType(EPerkType PerkType) { Invoke(nameof(RemoveStatusByType), PerkType); }
        public void RemoveStatus(int PerkId, bool RemovePlayerSkill) { Invoke(nameof(RemoveStatus), PerkId, RemovePlayerSkill); }
        public void RefreshZoomLevel() { Invoke(nameof(RefreshZoomLevel)); }
        public void RefreshWeapon(WeaponDataModel NewWeaponData) { Invoke(nameof(RefreshWeapon), NewWeaponData); }
        public void RefreshShield(ShieldDataModel NewShieldData) { Invoke(nameof(RefreshShield), NewShieldData); }
        public void RefreshSelectedArrow(int SelectedArrow) { Invoke(nameof(RefreshSelectedArrow), SelectedArrow); }
        public void RefreshRotationMode() { Invoke(nameof(RefreshRotationMode)); }
        public void RefreshPlayerSkills(Array<PlayerSkillDataModel> InPlayerSkills) { Invoke(nameof(RefreshPlayerSkills), InPlayerSkills); }
        public void RefreshPlayerDynamicBodyMaterials() { Invoke(nameof(RefreshPlayerDynamicBodyMaterials)); }
        public void RefreshMovementSettings() { Invoke(nameof(RefreshMovementSettings)); }
        public void RefreshMeshesVisibility() { Invoke(nameof(RefreshMeshesVisibility)); }
        public void RefreshMeshes() { Invoke(nameof(RefreshMeshes)); }
        public void Recycle() { Invoke(nameof(Recycle)); }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void ReceiveSpawn() { Invoke(nameof(ReceiveSpawn)); }
        public void ReceiveRecycle() { Invoke(nameof(ReceiveRecycle)); }
        public void ReceivePlayerReady(TOMPlayerState InPlayerState) { Invoke(nameof(ReceivePlayerReady), InPlayerState); }
        public void ReceiveCustomFellOutOfWorld() { Invoke(nameof(ReceiveCustomFellOutOfWorld)); }
        public void PreTeleport() { Invoke(nameof(PreTeleport)); }
        public void PostTeleport() { Invoke(nameof(PostTeleport)); }
        public void PossessedBy(Controller NewController) { Invoke(nameof(PossessedBy), NewController); }
        public void PlayWeaponMontageMulticast(int AttackMoveId) { Invoke(nameof(PlayWeaponMontageMulticast), AttackMoveId); }
        public void PlaySpawnSequence(ESpawnType SpawnType) { Invoke(nameof(PlaySpawnSequence), SpawnType); }
        public void PlayMontageReplicatedServer(AnimMontage Montage, bool CheckIfIsPlaying, Object SectionName, float StartingPosition, float PlayRate) { Invoke(nameof(PlayMontageReplicatedServer), Montage, CheckIfIsPlaying, SectionName, StartingPosition, PlayRate); }
        public void PlayMontageReplicatedMulticastWithAutoRotation(AnimMontage Montage, Rotator AutoRotation, Object SectionName, float StartingPosition, float PlayRate) { Invoke(nameof(PlayMontageReplicatedMulticastWithAutoRotation), Montage, AutoRotation, SectionName, StartingPosition, PlayRate); }
        public void PlayMontageReplicatedMulticast(AnimMontage Montage, Object SectionName, float StartingPosition, float PlayRate) { Invoke(nameof(PlayMontageReplicatedMulticast), Montage, SectionName, StartingPosition, PlayRate); }
        public void PlayMontage(AnimMontage Montage, Object SectionName, float StartingPosition, float PlayRate) { Invoke(nameof(PlayMontage), Montage, SectionName, StartingPosition, PlayRate); }
        public void PlayAttackMontage(Rotator AutoRotation, AnimMontage AnimMontage, float PlayRate, int attackId) { Invoke(nameof(PlayAttackMontage), AutoRotation, AnimMontage, PlayRate, attackId); }
        public void OnWorldReady(EventArgs Args) { Invoke(nameof(OnWorldReady), Args); }
        public void OnSlotChanged() { Invoke(nameof(OnSlotChanged)); }
        public void OnRep_SpeedRatio() { Invoke(nameof(OnRep_SpeedRatio)); }
        public void OnRep_SpeedMoveRatio() { Invoke(nameof(OnRep_SpeedMoveRatio)); }
        public void OnRep_LookAtTarget() { Invoke(nameof(OnRep_LookAtTarget)); }
        public void OnRep_IsWalking() { Invoke(nameof(OnRep_IsWalking)); }
        public void OnRep_IsUsingBeamAttack() { Invoke(nameof(OnRep_IsUsingBeamAttack)); }
        public void OnRep_IsTeleporting() { Invoke(nameof(OnRep_IsTeleporting)); }
        public void OnRep_IsShielding() { Invoke(nameof(OnRep_IsShielding)); }
        public void OnRep_IsHoldingAttack() { Invoke(nameof(OnRep_IsHoldingAttack)); }
        public void OnRep_IsBuildingDestruction() { Invoke(nameof(OnRep_IsBuildingDestruction)); }
        public void OnRep_IsBuilding() { Invoke(nameof(OnRep_IsBuilding)); }
        public void OnRep_InitRotation() { Invoke(nameof(OnRep_InitRotation)); }
        public void OnRep_InForceLookDirection() { Invoke(nameof(OnRep_InForceLookDirection)); }
        public void OnRep_ECharacterMovementMode() { Invoke(nameof(OnRep_ECharacterMovementMode)); }
        public void OnRep_CreatureProperties() { Invoke(nameof(OnRep_CreatureProperties)); }
        public void OnRep_CharacterState() { Invoke(nameof(OnRep_CharacterState)); }
        public void OnRep_CaveActor() { Invoke(nameof(OnRep_CaveActor)); }
        public void OnRep_bIsActivated() { Invoke(nameof(OnRep_bIsActivated)); }
        public void OnRep_ALS_RotationMode() { Invoke(nameof(OnRep_ALS_RotationMode)); }
        public void OnReceiveDamage(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(OnReceiveDamage), Source, IssuedAmount, HitResult); }
        public void OnPlayerReady(OnPlayerReadyEventArgs Args) { Invoke(nameof(OnPlayerReady), Args); }
        public void OnPlayerListChanged() { Invoke(nameof(OnPlayerListChanged)); }
        public void OnLeaveRagdoll() { Invoke(nameof(OnLeaveRagdoll)); }
        public void OnLeaveDownState(HealthComponent InHealthComponent) { Invoke(nameof(OnLeaveDownState), InHealthComponent); }
        public void OnHealthReset() { Invoke(nameof(OnHealthReset)); }
        public void OnEquipmentSpawned(TOMEquipmentBase Equipment) { Invoke(nameof(OnEquipmentSpawned), Equipment); }
        public void OnEquipItem() { Invoke(nameof(OnEquipItem)); }
        public void OnEntityModelReady() { Invoke(nameof(OnEntityModelReady)); }
        public void OnEnterRagdoll() { Invoke(nameof(OnEnterRagdoll)); }
        public void OnEnterDownState(HealthComponent InHealthComponent) { Invoke(nameof(OnEnterDownState), InHealthComponent); }
        public void OnDeath() { Invoke(nameof(OnDeath)); }
        public void OnCreatureEndOfMetaMovement() { Invoke(nameof(OnCreatureEndOfMetaMovement)); }
        public void OnChangeBiome(int BiomeId, int Level) { Invoke(nameof(OnChangeBiome), BiomeId, Level); }
        public void OnChangeBeingOnRoad(bool bValue) { Invoke(nameof(OnChangeBeingOnRoad), bValue); }
        public bool MoveBackToOrigin() { return Invoke<bool>(nameof(MoveBackToOrigin)); }
        public void LaunchShieldAggro() { Invoke(nameof(LaunchShieldAggro)); }
        public bool IsRolling() { return Invoke<bool>(nameof(IsRolling)); }
        public bool IsReadyToStackAction() { return Invoke<bool>(nameof(IsReadyToStackAction)); }
        public bool IsReadyToExecuteEvade() { return Invoke<bool>(nameof(IsReadyToExecuteEvade)); }
        public bool IsReadyToExecuteAction(EStackableAction ActionToCheck) { return Invoke<bool>(nameof(IsReadyToExecuteAction), ActionToCheck); }
        public bool IsMovementAllowed() { return Invoke<bool>(nameof(IsMovementAllowed)); }
        public bool IsInCave() { return Invoke<bool>(nameof(IsInCave)); }
        public bool IsHoldingAttack() { return Invoke<bool>(nameof(IsHoldingAttack)); }
        public bool IsAttackReady(int attackId) { return Invoke<bool>(nameof(IsAttackReady), attackId); }
        public bool IsAttacking() { return Invoke<bool>(nameof(IsAttacking)); }
        public void InitPlayerDynamicBodyMaterials() { Invoke(nameof(InitPlayerDynamicBodyMaterials)); }
        public void InitCharacterRotationServer(Rotator NewRotation) { Invoke(nameof(InitCharacterRotationServer), NewRotation); }
        public void HideSelection() { Invoke(nameof(HideSelection)); }
        public void HideCharacter(int Activate) { Invoke(nameof(HideCharacter), Activate); }
        public bool HaveStatusById(int PerkId) { return Invoke<bool>(nameof(HaveStatusById), PerkId); }
        public bool HaveStatus(EPerkType PerkType, bool bIgnorePermanentPerks) { return Invoke<bool>(nameof(HaveStatus), PerkType, bIgnorePermanentPerks); }
        public bool HasShield() { return Invoke<bool>(nameof(HasShield)); }
        public TrackedEntityComponent GetTrackedEntityComponent() { return Invoke<TrackedEntityComponent>(nameof(GetTrackedEntityComponent)); }
        public float GetTotalSpeedModifier() { return Invoke<float>(nameof(GetTotalSpeedModifier)); }
        public float GetTotalAttackSpeedModifier() { return Invoke<float>(nameof(GetTotalAttackSpeedModifier)); }
        public PerkDataModel GetStatusModelByType(EPerkType PerkType) { return Invoke<PerkDataModel>(nameof(GetStatusModelByType), PerkType); }
        public StatusComponent GetStatusByTypeClient(EPerkType PerkType) { return Invoke<StatusComponent>(nameof(GetStatusByTypeClient), PerkType); }
        public StatusComponent GetStatusByType(EPerkType PerkType, bool bIgnorePermanentPerks) { return Invoke<StatusComponent>(nameof(GetStatusByType), PerkType, bIgnorePermanentPerks); }
        public SpecialPointComponent GetSpecialPointComponent() { return Invoke<SpecialPointComponent>(nameof(GetSpecialPointComponent)); }
        public float GetRollTimer() { return Invoke<float>(nameof(GetRollTimer)); }
        public float GetRollRecoveryTime() { return Invoke<float>(nameof(GetRollRecoveryTime)); }
        public PlayerTemperatureMonitorComponent GetPlayerTemperatureMonitorComponent() { return Invoke<PlayerTemperatureMonitorComponent>(nameof(GetPlayerTemperatureMonitorComponent)); }
        public OnHitRagdollComponent GetOnHitRagdollComponent() { return Invoke<OnHitRagdollComponent>(nameof(GetOnHitRagdollComponent)); }
        public TOMOffensiveComponent GetOffensiveComponent() { return Invoke<TOMOffensiveComponent>(nameof(GetOffensiveComponent)); }
        public AttackStatsDataModel GetNextAttack() { return Invoke<AttackStatsDataModel>(nameof(GetNextAttack)); }
        public bool GetIsInVillage() { return Invoke<bool>(nameof(GetIsInVillage)); }
        public InventoryContainerBaseComponent GetInventoryComponent() { return Invoke<InventoryContainerBaseComponent>(nameof(GetInventoryComponent)); }
        public InteractorComponent GetInteractorComponent() { return Invoke<InteractorComponent>(nameof(GetInteractorComponent)); }
        public HealthComponent GetHealthComponent() { return Invoke<HealthComponent>(nameof(GetHealthComponent)); }
        public EGender GetGender() { return Invoke<EGender>(nameof(GetGender)); }
        public DefensiveShieldComponent GetDefensiveComponent() { return Invoke<DefensiveShieldComponent>(nameof(GetDefensiveComponent)); }
        public WeaponDataModel GetCurrentWeaponData() { return Invoke<WeaponDataModel>(nameof(GetCurrentWeaponData)); }
        public TOMEquipmentBase GetCurrentWeaponActor() { return Invoke<TOMEquipmentBase>(nameof(GetCurrentWeaponActor)); }
        public Object GetCurrentStatus() { return Invoke<Object>(nameof(GetCurrentStatus)); }
        public ContainerSlotItemEntityModel GetCurrentShieldEntity() { return Invoke<ContainerSlotItemEntityModel>(nameof(GetCurrentShieldEntity)); }
        public ShieldDataModel GetCurrentShieldData() { return Invoke<ShieldDataModel>(nameof(GetCurrentShieldData)); }
        public TOMEquipmentBase GetCurrentShieldActor() { return Invoke<TOMEquipmentBase>(nameof(GetCurrentShieldActor)); }
        public CaveBase GetCurrentCaveActor() { return Invoke<CaveBase>(nameof(GetCurrentCaveActor)); }
        public CaveEntityModel GetCurrentCave() { return Invoke<CaveEntityModel>(nameof(GetCurrentCave)); }
        public Object GetControllerEntityId() { return Invoke<Object>(nameof(GetControllerEntityId)); }
        public Object GetCharacterDisplayName() { return Invoke<Object>(nameof(GetCharacterDisplayName)); }
        public CharacterDataModel GetCharacterDataModel() { return Invoke<CharacterDataModel>(nameof(GetCharacterDataModel)); }
        public Object GetCharacterAudioName() { return Invoke<Object>(nameof(GetCharacterAudioName)); }
        public ECharacterAttackState GetCharacterAttackState() { return Invoke<ECharacterAttackState>(nameof(GetCharacterAttackState)); }
        public WorldCreatureEntityModel GetAnimalEntityModel() { return Invoke<WorldCreatureEntityModel>(nameof(GetAnimalEntityModel)); }
        public void ForceCharacterMoveToPointServer(Vector DestinationPoint, float Duration, bool bCanFallOff, bool bMoveThroughCharacter, bool bSweep) { Invoke(nameof(ForceCharacterMoveToPointServer), DestinationPoint, Duration, bCanFallOff, bMoveThroughCharacter, bSweep); }
        public void ForceCharacterMoveServer(float Distance, Vector NormalizedDirection, float Duration, bool bCanFallOff, bool bMoveThroughCharacter, bool bSweep, bool bUseGravity) { Invoke(nameof(ForceCharacterMoveServer), Distance, NormalizedDirection, Duration, bCanFallOff, bMoveThroughCharacter, bSweep, bUseGravity); }
        public void ForceCharacterMoveMulticast(float Distance, Vector NormalizedDirection, float Duration, bool bCanFallOff, bool bMoveThroughCharacter, bool bSweep, bool bUseGravity) { Invoke(nameof(ForceCharacterMoveMulticast), Distance, NormalizedDirection, Duration, bCanFallOff, bMoveThroughCharacter, bSweep, bUseGravity); }
        public void FootStepTrace(EFootstepType FootstepType) { Invoke(nameof(FootStepTrace), FootstepType); }
        public void FireProjectile(Rotator RotationOffset, Vector LocationOffset, AttackStatsDataModel AttackStatsDataModel, StatusComponent Status, Vector WorldStartPosition) { Invoke(nameof(FireProjectile), RotationOffset, LocationOffset, AttackStatsDataModel, Status, WorldStartPosition); }
        public void FireBuff() { Invoke(nameof(FireBuff)); }
        public void FireAttackImpact(Vector ImpactLocation) { Invoke(nameof(FireAttackImpact), ImpactLocation); }
        public void FellInWater() { Invoke(nameof(FellInWater)); }
        public void ExitCaveBP() { Invoke(nameof(ExitCaveBP)); }
        public void ExitCave() { Invoke(nameof(ExitCave)); }
        public void ExecuteStartHarvestMulticast(Rotator CollectRotation, int MaterialSourceDataId) { Invoke(nameof(ExecuteStartHarvestMulticast), CollectRotation, MaterialSourceDataId); }
        public void ExecuteStartHarvest(MaterialSourceBase MaterialSource) { Invoke(nameof(ExecuteStartHarvest), MaterialSource); }
        public void ExecuteHarvest() { Invoke(nameof(ExecuteHarvest)); }
        public void ExecuteEvadeMulticast(Rotator EvadeDirection) { Invoke(nameof(ExecuteEvadeMulticast), EvadeDirection); }
        public void ExecuteEvade() { Invoke(nameof(ExecuteEvade)); }
        public void ExecuteCollectLoot(DroppedLoot LootActor, bool bWithAnimation) { Invoke(nameof(ExecuteCollectLoot), LootActor, bWithAnimation); }
        public void EnterCave(CaveEntityModel Cave, bool bUpdateEntryPosition) { Invoke(nameof(EnterCave), Cave, bUpdateEntryPosition); }
        public void Die() { Invoke(nameof(Die)); }
        public void DelaySpawnAttackImpact(Transform ImpactOrigin, AttackStatsDataModel Attack, int Index, float Delay) { Invoke(nameof(DelaySpawnAttackImpact), ImpactOrigin, Attack, Index, Delay); }
        public void DelayedProjectile(Vector CurrentTarget, AttackStatsDataModel Attack, ProjectileBase Projectile, Vector WorldStartPosition) { Invoke(nameof(DelayedProjectile), CurrentTarget, Attack, Projectile, WorldStartPosition); }
        public void ClearStatus(bool bOnDeath) { Invoke(nameof(ClearStatus), bOnDeath); }
        public void CaveTeleportOut() { Invoke(nameof(CaveTeleportOut)); }
        public void CaveTeleportIn() { Invoke(nameof(CaveTeleportIn)); }
        public bool CanShield() { return Invoke<bool>(nameof(CanShield)); }
        public void CancelRollMulticast() { Invoke(nameof(CancelRollMulticast)); }
        public void CancelRoll() { Invoke(nameof(CancelRoll)); }
        public void CancelHoldAttack() { Invoke(nameof(CancelHoldAttack)); }
        public void CancelAttackMulticast() { Invoke(nameof(CancelAttackMulticast)); }
        public void CancelAttack() { Invoke(nameof(CancelAttack)); }
        public void BroadcastCharacterSwapMulticast(TOMCharacter NewCharacter) { Invoke(nameof(BroadcastCharacterSwapMulticast), NewCharacter); }
        public void AudioPlayCharacterSFXMulticast(Object Suffix) { Invoke(nameof(AudioPlayCharacterSFXMulticast), Suffix); }
        public void AudioPlayCharacterSFXClient(Object Suffix) { Invoke(nameof(AudioPlayCharacterSFXClient), Suffix); }
        public void AudioPlayCharacterSFX(Object Suffix) { Invoke(nameof(AudioPlayCharacterSFX), Suffix); }
        public bool AttachProjectileToCharacter(ProjectileBase Projectile) { return Invoke<bool>(nameof(AttachProjectileToCharacter), Projectile); }
        public void ApplyPerk(PerkDataModel Perk, bool bIsPlayerSkill, TOMOffensiveComponent Source) { Invoke(nameof(ApplyPerk), Perk, bIsPlayerSkill, Source); }
        public void ApplyAutoRotation(Rotator AutoRotation, bool bForce) { Invoke(nameof(ApplyAutoRotation), AutoRotation, bForce); }
        public void ALS_SetCharacterRotation(Rotator InTargetRotation, bool bShouldInterpolate, float InterpolationSpeed, ETeleportType TeleportPhysic) { Invoke(nameof(ALS_SetCharacterRotation), InTargetRotation, bShouldInterpolate, InterpolationSpeed, TeleportPhysic); }
        public void ALS_AddCharacterRotation(Rotator AddAmount) { Invoke(nameof(ALS_AddCharacterRotation), AddAmount); }
        public void AddStunEffect(int InAmount) { Invoke(nameof(AddStunEffect), InAmount); }
        public void AddStatusFromPerkMulticast(int PerkId) { Invoke(nameof(AddStatusFromPerkMulticast), PerkId); }
        public void AddSpeedRatio(float Value) { Invoke(nameof(AddSpeedRatio), Value); }
        public void AddMoveSpeedRatio(float Value) { Invoke(nameof(AddMoveSpeedRatio), Value); }
        public void AddAttackSpeedRatio(float Value) { Invoke(nameof(AddAttackSpeedRatio), Value); }
    }
    public class TOMCharacterMovementComponent : CharacterMovementComponent
    {
        public TOMCharacterMovementComponent(ulong addr) : base(addr) { }
        public bool DoNotAggregate { get { return this[nameof(DoNotAggregate)].Flag; } set { this[nameof(DoNotAggregate)].Flag = value; } }
    }
    public class TOMCheatManager : CheatManager
    {
        public TOMCheatManager(ulong addr) : base(addr) { }
        public bool UnlimitedStamina { get { return this[nameof(UnlimitedStamina)].Flag; } set { this[nameof(UnlimitedStamina)].Flag = value; } }
        public bool Invicible { get { return this[nameof(Invicible)].Flag; } set { this[nameof(Invicible)].Flag = value; } }
        public bool ShowAOEDebug { get { return this[nameof(ShowAOEDebug)].Flag; } set { this[nameof(ShowAOEDebug)].Flag = value; } }
        public bool ShowAttackDebug { get { return this[nameof(ShowAttackDebug)].Flag; } set { this[nameof(ShowAttackDebug)].Flag = value; } }
        public bool IgnorePlayers { get { return this[nameof(IgnorePlayers)].Flag; } set { this[nameof(IgnorePlayers)].Flag = value; } }
        public Object DummyPlayerAIClass { get { return this[nameof(DummyPlayerAIClass)]; } set { this[nameof(DummyPlayerAIClass)] = value; } }
        public TOMDebugCameraController TOMDebugCameraControllerRef { get { return this[nameof(TOMDebugCameraControllerRef)].As<TOMDebugCameraController>(); } set { this["TOMDebugCameraControllerRef"] = value; } }
        public Pawn TOMDebugCameraPawnRef { get { return this[nameof(TOMDebugCameraPawnRef)].As<Pawn>(); } set { this["TOMDebugCameraPawnRef"] = value; } }
        public Object TOMDebugCameraControllerClass { get { return this[nameof(TOMDebugCameraControllerClass)]; } set { this[nameof(TOMDebugCameraControllerClass)] = value; } }
        public Object TOMDebugCameraPawnClass { get { return this[nameof(TOMDebugCameraPawnClass)]; } set { this[nameof(TOMDebugCameraPawnClass)] = value; } }
        public Pawn PawnRef { get { return this[nameof(PawnRef)].As<Pawn>(); } set { this["PawnRef"] = value; } }
        public TOMPlayerController PossessedPlayerController { get { return this[nameof(PossessedPlayerController)].As<TOMPlayerController>(); } set { this["PossessedPlayerController"] = value; } }
        public TOMCharacter PossessedCharacter { get { return this[nameof(PossessedCharacter)].As<TOMCharacter>(); } set { this["PossessedCharacter"] = value; } }
        public void TOMUpdateUserData(Object DataName, int DataValue) { Invoke(nameof(TOMUpdateUserData), DataName, DataValue); }
        public void TOMUnpossessPlayerByAI() { Invoke(nameof(TOMUnpossessPlayerByAI)); }
        public void TOMUnlockAllAchievements() { Invoke(nameof(TOMUnlockAllAchievements)); }
        public void TOMUnlockAchievement(int ID) { Invoke(nameof(TOMUnlockAchievement), ID); }
        public void TOMTrailerClient(int Activate) { Invoke(nameof(TOMTrailerClient), Activate); }
        public void TOMTrailer(int Activate) { Invoke(nameof(TOMTrailer), Activate); }
        public void TOMToggleSpectatingClient() { Invoke(nameof(TOMToggleSpectatingClient)); }
        public void TOMToggleDebugCameraClient() { Invoke(nameof(TOMToggleDebugCameraClient)); }
        public void TOMToggleDebugCamera() { Invoke(nameof(TOMToggleDebugCamera)); }
        public void TOMTestSpawnCreature(Object EntityId, int ID, float X, float Y, float Z) { Invoke(nameof(TOMTestSpawnCreature), EntityId, ID, X, Y, Z); }
        public void TOMTestMoveToYggdrasil() { Invoke(nameof(TOMTestMoveToYggdrasil)); }
        public void TOMTestMoveToNPC(int NPCAnimalId) { Invoke(nameof(TOMTestMoveToNPC), NPCAnimalId); }
        public void TOMTestKillCreature(Object EntityId) { Invoke(nameof(TOMTestKillCreature), EntityId); }
        public void TOMTestCreatureStackAttack(Object EntityId, int attackId) { Invoke(nameof(TOMTestCreatureStackAttack), EntityId, attackId); }
        public void TOMTestCraftItem(int CraftingRecipeId, int Amount) { Invoke(nameof(TOMTestCraftItem), CraftingRecipeId, Amount); }
        public void TOMTeleportToVillageClient() { Invoke(nameof(TOMTeleportToVillageClient)); }
        public void TOMTeleportToVillage() { Invoke(nameof(TOMTeleportToVillage)); }
        public void TOMTeleportToPOIClient(int ID) { Invoke(nameof(TOMTeleportToPOIClient), ID); }
        public void TOMTeleportToPOI(int ID) { Invoke(nameof(TOMTeleportToPOI), ID); }
        public void TOMTeleportToGiantClient() { Invoke(nameof(TOMTeleportToGiantClient)); }
        public void TOMTeleportToGiant() { Invoke(nameof(TOMTeleportToGiant)); }
        public void TOMTeleportToEvent(int EventId, int ZoneIndex) { Invoke(nameof(TOMTeleportToEvent), EventId, ZoneIndex); }
        public void TOMTeleportToCoordinatesClient(Vector Coordinates) { Invoke(nameof(TOMTeleportToCoordinatesClient), Coordinates); }
        public void TOMTeleportToCoordinates(Vector Coordinates) { Invoke(nameof(TOMTeleportToCoordinates), Coordinates); }
        public void TOMStopGiant() { Invoke(nameof(TOMStopGiant)); }
        public void TOMStartActivity(Object ActivityId) { Invoke(nameof(TOMStartActivity), ActivityId); }
        public void TOMSpawnProbe() { Invoke(nameof(TOMSpawnProbe)); }
        public void TOMSpawnPack(int PackId) { Invoke(nameof(TOMSpawnPack), PackId); }
        public void TOMSpawnHazardsClient(int ID, int quantity) { Invoke(nameof(TOMSpawnHazardsClient), ID, quantity); }
        public void TOMSpawnHazards(int ID, int quantity) { Invoke(nameof(TOMSpawnHazards), ID, quantity); }
        public void TOMSpawnGiantClient(int GiantAnimalId) { Invoke(nameof(TOMSpawnGiantClient), GiantAnimalId); }
        public void TOMSpawnEnnemiesClient(int ID, int quantity, int AIBehaviour) { Invoke(nameof(TOMSpawnEnnemiesClient), ID, quantity, AIBehaviour); }
        public void TOMSpawnEnnemies(int ID, int quantity, int AIBehaviour) { Invoke(nameof(TOMSpawnEnnemies), ID, quantity, AIBehaviour); }
        public void TOMSpawnCave(int CaveId) { Invoke(nameof(TOMSpawnCave), CaveId); }
        public void TOMSlomo(float NewTimeDilation) { Invoke(nameof(TOMSlomo), NewTimeDilation); }
        public void TOMShowSeed() { Invoke(nameof(TOMShowSeed)); }
        public void TOMSetYggdrasilInvincibleClient(int Activate) { Invoke(nameof(TOMSetYggdrasilInvincibleClient), Activate); }
        public void TOMSetYggdrasilInvincible(int Activate) { Invoke(nameof(TOMSetYggdrasilInvincible), Activate); }
        public void TOMSetTimeOfDaySegmentClient(int DayTimeSegment) { Invoke(nameof(TOMSetTimeOfDaySegmentClient), DayTimeSegment); }
        public void TOMSetSFXVolume(int Value) { Invoke(nameof(TOMSetSFXVolume), Value); }
        public void TOMSetMusicVolume(int Value) { Invoke(nameof(TOMSetMusicVolume), Value); }
        public void TOMSetInvincibleClient(int Activate) { Invoke(nameof(TOMSetInvincibleClient), Activate); }
        public void TOMSetInfiniteStamina(int Activate) { Invoke(nameof(TOMSetInfiniteStamina), Activate); }
        public void TOMSetImmuneToStunClient(int Value) { Invoke(nameof(TOMSetImmuneToStunClient), Value); }
        public void TOMSetIdleKickAEnabledClient(int InEnabled) { Invoke(nameof(TOMSetIdleKickAEnabledClient), InEnabled); }
        public void TOMSetGlobalMessagesEnabled(int Value) { Invoke(nameof(TOMSetGlobalMessagesEnabled), Value); }
        public void TOMSetGamepadPlatform(int Platform) { Invoke(nameof(TOMSetGamepadPlatform), Platform); }
        public void TOMSetFreeAbilitiesClient(int Activate) { Invoke(nameof(TOMSetFreeAbilitiesClient), Activate); }
        public void TOMSetAttackDebugClient(int Activate) { Invoke(nameof(TOMSetAttackDebugClient), Activate); }
        public void TOMSetAttackDebug(int Activate) { Invoke(nameof(TOMSetAttackDebug), Activate); }
        public void TOMSetAOEDebugClient(int Activate) { Invoke(nameof(TOMSetAOEDebugClient), Activate); }
        public void TOMSetAOEDebug(int Activate) { Invoke(nameof(TOMSetAOEDebug), Activate); }
        public void TOMSaveClient() { Invoke(nameof(TOMSaveClient)); }
        public void TOMSave() { Invoke(nameof(TOMSave)); }
        public void TOMRevealMapExec() { Invoke(nameof(TOMRevealMapExec)); }
        public void TOMRevealMapClient() { Invoke(nameof(TOMRevealMapClient)); }
        public void TOMRevealMap() { Invoke(nameof(TOMRevealMap)); }
        public void TOMResetXPClient() { Invoke(nameof(TOMResetXPClient)); }
        public void TOMResetUser() { Invoke(nameof(TOMResetUser)); }
        public void TOMResetSkillsClient() { Invoke(nameof(TOMResetSkillsClient)); }
        public void TOMResetRunestonesCooldownClient() { Invoke(nameof(TOMResetRunestonesCooldownClient)); }
        public void TOMResetAchievements() { Invoke(nameof(TOMResetAchievements)); }
        public void TOMRemoveFakePlayersClient() { Invoke(nameof(TOMRemoveFakePlayersClient)); }
        public void TOMRemoveFakePlayers() { Invoke(nameof(TOMRemoveFakePlayers)); }
        public void TOMPauseTimeOfDayClient() { Invoke(nameof(TOMPauseTimeOfDayClient)); }
        public void TOMLootOffering() { Invoke(nameof(TOMLootOffering)); }
        public void TOMLootEveryItem(int IncludeNotCraftableItem) { Invoke(nameof(TOMLootEveryItem), IncludeNotCraftableItem); }
        public void TOMLogCreatureAutoScale(Object EnityId) { Invoke(nameof(TOMLogCreatureAutoScale), EnityId); }
        public void TOMKillClient() { Invoke(nameof(TOMKillClient)); }
        public void TOMKill(TOMPlayerController PlayerController) { Invoke(nameof(TOMKill), PlayerController); }
        public void TOMJoinLobbyDebug() { Invoke(nameof(TOMJoinLobbyDebug)); }
        public void TOMInputTriggerWeaponEffect(int TriggerMask, int StartPosition, int EndPosition, int Strength, float Duration) { Invoke(nameof(TOMInputTriggerWeaponEffect), TriggerMask, StartPosition, EndPosition, Strength, Duration); }
        public void TOMInputTriggerVibrationEffect(int TriggerMask, int Position, int Frequency, int Amplitude, float Duration) { Invoke(nameof(TOMInputTriggerVibrationEffect), TriggerMask, Position, Frequency, Amplitude, Duration); }
        public void TOMInputTriggerFeedbackEffect(int TriggerMask, int Position, int Strength, float Duration) { Invoke(nameof(TOMInputTriggerFeedbackEffect), TriggerMask, Position, Strength, Duration); }
        public void TOMIgnorePlayersClient(int Activate) { Invoke(nameof(TOMIgnorePlayersClient), Activate); }
        public void TOMHideCharacter(int Activate) { Invoke(nameof(TOMHideCharacter), Activate); }
        public void TOMHealPlayersClient(int Amount) { Invoke(nameof(TOMHealPlayersClient), Amount); }
        public void TOMExplorePOI() { Invoke(nameof(TOMExplorePOI)); }
        public void TOMExecuteCommandExec(Object Command) { Invoke(nameof(TOMExecuteCommandExec), Command); }
        public void TOMExecuteCommandClient(Object Command) { Invoke(nameof(TOMExecuteCommandClient), Command); }
        public void TOMEnablePostProcess(int Activate) { Invoke(nameof(TOMEnablePostProcess), Activate); }
        public void TOMEnableHUD(int Activate) { Invoke(nameof(TOMEnableHUD), Activate); }
        public void TOMEmptyMaterials() { Invoke(nameof(TOMEmptyMaterials)); }
        public void TOMDropItemServer(int ID, int quantity, Vector Location) { Invoke(nameof(TOMDropItemServer), ID, quantity, Location); }
        public void TOMDropItem(int ID, int quantity) { Invoke(nameof(TOMDropItem), ID, quantity); }
        public void TOMDealDamageToYggdrasilClient(int Damage) { Invoke(nameof(TOMDealDamageToYggdrasilClient), Damage); }
        public void TOMDealDamageToYggdrasil(int Damage) { Invoke(nameof(TOMDealDamageToYggdrasil), Damage); }
        public void TOMCrash() { Invoke(nameof(TOMCrash)); }
        public void TOMClearAllDroppedLootClient() { Invoke(nameof(TOMClearAllDroppedLootClient)); }
        public void TOMChangeFogSettings(float Intensity, float Radius) { Invoke(nameof(TOMChangeFogSettings), Intensity, Radius); }
        public void TOMAutoModeClient() { Invoke(nameof(TOMAutoModeClient)); }
        public void TOMAutoMode() { Invoke(nameof(TOMAutoMode)); }
        public void TOMAddXPClient(int XP) { Invoke(nameof(TOMAddXPClient), XP); }
        public void TOMAddTime(float HoursToAdd) { Invoke(nameof(TOMAddTime), HoursToAdd); }
        public void TOMAddFakePlayerClient() { Invoke(nameof(TOMAddFakePlayerClient)); }
        public void TOMAddFakePlayer() { Invoke(nameof(TOMAddFakePlayer)); }
        public void TOMAddCollaborativeXP(int XP) { Invoke(nameof(TOMAddCollaborativeXP), XP); }
        public void TOMActivateShrinesExec() { Invoke(nameof(TOMActivateShrinesExec)); }
        public void TOMActivateShrinesClient() { Invoke(nameof(TOMActivateShrinesClient)); }
        public void TOMActivateShrines() { Invoke(nameof(TOMActivateShrines)); }
        public void RevealChunks(Array<IntPoint> Chunks) { Invoke(nameof(RevealChunks), Chunks); }
        public TOMGameInstance GetTOMGameInstance() { return Invoke<TOMGameInstance>(nameof(GetTOMGameInstance)); }
    }
    public class TOMConstants : Object
    {
        public TOMConstants(ulong addr) : base(addr) { }
        public Object GetNPCEntityIdBySellerType(ESellerType SellerType) { return Invoke<Object>(nameof(GetNPCEntityIdBySellerType), SellerType); }
        public Object GetModuleNPCEntityId(Object ModuleEntityId) { return Invoke<Object>(nameof(GetModuleNPCEntityId), ModuleEntityId); }
    }
    public class TOMDebugCameraController : PlayerController
    {
        public TOMDebugCameraController(ulong addr) : base(addr) { }
        public bool bIsFrozenRendering { get { return this[nameof(bIsFrozenRendering)].Flag; } set { this[nameof(bIsFrozenRendering)].Flag = value; } }
        public DrawFrustumComponent DrawFrustum { get { return this[nameof(DrawFrustum)].As<DrawFrustumComponent>(); } set { this["DrawFrustum"] = value; } }
        public Actor SelectedActor { get { return this[nameof(SelectedActor)].As<Actor>(); } set { this["SelectedActor"] = value; } }
        public PrimitiveComponent SelectedComponent { get { return this[nameof(SelectedComponent)].As<PrimitiveComponent>(); } set { this["SelectedComponent"] = value; } }
        public PlayerController OriginalControllerRef { get { return this[nameof(OriginalControllerRef)].As<PlayerController>(); } set { this["OriginalControllerRef"] = value; } }
        public Player OriginalPlayer { get { return this[nameof(OriginalPlayer)].As<Player>(); } set { this["OriginalPlayer"] = value; } }
        public float SpeedScale { get { return this[nameof(SpeedScale)].GetValue<float>(); } set { this[nameof(SpeedScale)].SetValue<float>(value); } }
        public float InitialMaxSpeed { get { return this[nameof(InitialMaxSpeed)].GetValue<float>(); } set { this[nameof(InitialMaxSpeed)].SetValue<float>(value); } }
        public float InitialAccel { get { return this[nameof(InitialAccel)].GetValue<float>(); } set { this[nameof(InitialAccel)].SetValue<float>(value); } }
        public float InitialDecel { get { return this[nameof(InitialDecel)].GetValue<float>(); } set { this[nameof(InitialDecel)].SetValue<float>(value); } }
        public void ToggleDisplay() { Invoke(nameof(ToggleDisplay)); }
        public void SetPawnMovementSpeedScale(float NewSpeedScale) { Invoke(nameof(SetPawnMovementSpeedScale), NewSpeedScale); }
        public void ReceiveOnDeactivate(PlayerController RestoredPC) { Invoke(nameof(ReceiveOnDeactivate), RestoredPC); }
        public void ReceiveOnActorSelected(Actor NewSelectedActor, Vector SelectHitLocation, Vector SelectHitNormal, HitResult Hit) { Invoke(nameof(ReceiveOnActorSelected), NewSelectedActor, SelectHitLocation, SelectHitNormal, Hit); }
        public void ReceiveOnActivate(PlayerController OriginalPC) { Invoke(nameof(ReceiveOnActivate), OriginalPC); }
        public Actor GetSelectedActor() { return Invoke<Actor>(nameof(GetSelectedActor)); }
    }
    public class TOMEngine : GameEngine
    {
        public TOMEngine(ulong addr) : base(addr) { }
    }
    public class TOMEventRequest : Object
    {
        public TOMEventRequest(ulong addr) : base(addr) { }
    }
    public class TOMForceFeedbackAttenuation : ForceFeedbackAttenuation
    {
        public TOMForceFeedbackAttenuation(ulong addr) : base(addr) { }
    }
    public class TOMGameDataModel : GameDataModel
    {
        public TOMGameDataModel(ulong addr) : base(addr) { }
        public int CurrentDataVersion { get { return this[nameof(CurrentDataVersion)].GetValue<int>(); } set { this[nameof(CurrentDataVersion)].SetValue<int>(value); } }
        public bool bForceClearCache { get { return this[nameof(bForceClearCache)].Flag; } set { this[nameof(bForceClearCache)].Flag = value; } }
        public bool bCanUseCache { get { return this[nameof(bCanUseCache)].Flag; } set { this[nameof(bCanUseCache)].Flag = value; } }
        public EventRequest Request { get { return this[nameof(Request)].As<EventRequest>(); } set { this["Request"] = value; } }
        public void OnGetGameData(ServerResponse Response) { Invoke(nameof(OnGetGameData), Response); }
    }
    public class TOMGameInstance : AdvancedFriendsGameInstance
    {
        public TOMGameInstance(ulong addr) : base(addr) { }
        public Object OnNotifyMaintenance { get { return this[nameof(OnNotifyMaintenance)]; } set { this[nameof(OnNotifyMaintenance)] = value; } }
        public Object OnSaveSlotsReceived { get { return this[nameof(OnSaveSlotsReceived)]; } set { this[nameof(OnSaveSlotsReceived)] = value; } }
        public Object OnLeaveWorldComplete { get { return this[nameof(OnLeaveWorldComplete)]; } set { this[nameof(OnLeaveWorldComplete)] = value; } }
        public bool bHasSeenMainMenu { get { return this[nameof(bHasSeenMainMenu)].Flag; } set { this[nameof(bHasSeenMainMenu)].Flag = value; } }
        public Object LoadingScreenClass { get { return this[nameof(LoadingScreenClass)]; } set { this[nameof(LoadingScreenClass)] = value; } }
        public Object IconManagerBPClass { get { return this[nameof(IconManagerBPClass)]; } set { this[nameof(IconManagerBPClass)] = value; } }
        public Object LocalRequestClass { get { return this[nameof(LocalRequestClass)]; } set { this[nameof(LocalRequestClass)] = value; } }
        public Object BackendServerRequestClass { get { return this[nameof(BackendServerRequestClass)]; } set { this[nameof(BackendServerRequestClass)] = value; } }
        public Object GenerationManagerClass { get { return this[nameof(GenerationManagerClass)]; } set { this[nameof(GenerationManagerClass)] = value; } }
        public Object MapTextureGeneratorClass { get { return this[nameof(MapTextureGeneratorClass)]; } set { this[nameof(MapTextureGeneratorClass)] = value; } }
        public bool bIsSandbox { get { return this[nameof(bIsSandbox)].Flag; } set { this[nameof(bIsSandbox)].Flag = value; } }
        public Object CurrentWorldId { get { return this[nameof(CurrentWorldId)]; } set { this[nameof(CurrentWorldId)] = value; } }
        public EGameMode CurrentGameMode { get { return (EGameMode)this[nameof(CurrentGameMode)].GetValue<int>(); } set { this[nameof(CurrentGameMode)].SetValue<int>((int)value); } }
        public bool bUseBifrost { get { return this[nameof(bUseBifrost)].Flag; } set { this[nameof(bUseBifrost)].Flag = value; } }
        public int GoldenHornBonus { get { return this[nameof(GoldenHornBonus)].GetValue<int>(); } set { this[nameof(GoldenHornBonus)].SetValue<int>(value); } }
        public EGameInstanceState CurrentState { get { return (EGameInstanceState)this[nameof(CurrentState)].GetValue<int>(); } set { this[nameof(CurrentState)].SetValue<int>((int)value); } }
        public LoadingScreenUserWidget WidgetLoadingScreen { get { return this[nameof(WidgetLoadingScreen)].As<LoadingScreenUserWidget>(); } set { this["WidgetLoadingScreen"] = value; } }
        public Container GlobalContainer { get { return this[nameof(GlobalContainer)].As<Container>(); } set { this["GlobalContainer"] = value; } }
        public Container GameContainer { get { return this[nameof(GameContainer)].As<Container>(); } set { this["GameContainer"] = value; } }
        public TOMPlayerState LocalPlayerState { get { return this[nameof(LocalPlayerState)].As<TOMPlayerState>(); } set { this["LocalPlayerState"] = value; } }
        public EventRequest Event { get { return this[nameof(Event)].As<EventRequest>(); } set { this["Event"] = value; } }
        public Bifrost Root { get { return this[nameof(Root)].As<Bifrost>(); } set { this["Root"] = value; } }
        public ERuntimePlatform CurrentRuntimePlatform { get { return (ERuntimePlatform)this[nameof(CurrentRuntimePlatform)].GetValue<int>(); } set { this[nameof(CurrentRuntimePlatform)].SetValue<int>((int)value); } }
        public Object PendingActivityId { get { return this[nameof(PendingActivityId)]; } set { this[nameof(PendingActivityId)] = value; } }
        public int DebugSeed { get { return this[nameof(DebugSeed)].GetValue<int>(); } set { this[nameof(DebugSeed)].SetValue<int>(value); } }
        public void UpdateUsingMultiplayerFeatures(bool bIsUsingMultiplayerFeatures) { Invoke(nameof(UpdateUsingMultiplayerFeatures), bIsUsingMultiplayerFeatures); }
        public void UpdateSoloActivity(bool bIsAvailable, bool bIsEnded, bool bIsResume, bool bIsStarted) { Invoke(nameof(UpdateSoloActivity), bIsAvailable, bIsEnded, bIsResume, bIsStarted); }
        public void ShowWidgetLoadingScreen() { Invoke(nameof(ShowWidgetLoadingScreen)); }
        public void SetState(EGameInstanceState NewState) { Invoke(nameof(SetState), NewState); }
        public void SetPlayerWasKicked(bool Status) { Invoke(nameof(SetPlayerWasKicked), Status); }
        public void SetPlayerWasBanned(bool Status) { Invoke(nameof(SetPlayerWasBanned), Status); }
        public void SetPlayerConnectivityIssue(bool Status) { Invoke(nameof(SetPlayerConnectivityIssue), Status); }
        public void SetLocalPlayerState(TOMPlayerState PlayerState) { Invoke(nameof(SetLocalPlayerState), PlayerState); }
        public void SetAsyncLoadingScreen(Object LoadingScreenName) { Invoke(nameof(SetAsyncLoadingScreen), LoadingScreenName); }
        public void PreloadGameLevel() { Invoke(nameof(PreloadGameLevel)); }
        public void PostInit() { Invoke(nameof(PostInit)); }
        public void OnWorldCreated(ServerResponse Response) { Invoke(nameof(OnWorldCreated), Response); }
        public void OnUserWorldsReceived(ServerResponse Response) { Invoke(nameof(OnUserWorldsReceived), Response); }
        public void OnTriggerMaintenance() { Invoke(nameof(OnTriggerMaintenance)); }
        public void OnTriggerClientUpdateRequired() { Invoke(nameof(OnTriggerClientUpdateRequired)); }
        public void OnPreLoadMap(Object MapName) { Invoke(nameof(OnPreLoadMap), MapName); }
        public void OnPostLoadMap(World LoadedWorld) { Invoke(nameof(OnPostLoadMap), LoadedWorld); }
        public void OnLeaveWorldSuccess(ServerResponse Response) { Invoke(nameof(OnLeaveWorldSuccess), Response); }
        public void OnInternetStatusChanged(bool InIsConnected) { Invoke(nameof(OnInternetStatusChanged), InIsConnected); }
        public void OnInitializationSuccess() { Invoke(nameof(OnInitializationSuccess)); }
        public void OnInitializationFailed() { Invoke(nameof(OnInitializationFailed)); }
        public void OnGetWorldDataResponse(ServerResponse Response) { Invoke(nameof(OnGetWorldDataResponse), Response); }
        public void OnGetGameDataServer() { Invoke(nameof(OnGetGameDataServer)); }
        public void LoadTutorialLevel() { Invoke(nameof(LoadTutorialLevel)); }
        public void LoadGameLevel() { Invoke(nameof(LoadGameLevel)); }
        public void LeaveWorld(Object WorldID) { Invoke(nameof(LeaveWorld), WorldID); }
        public void LeaveGame() { Invoke(nameof(LeaveGame)); }
        public void JoinWorld(Object WorldID, bool bIsHost, bool bIsLocal, Object Password, int MapSizeIndex) { Invoke(nameof(JoinWorld), WorldID, bIsHost, bIsLocal, Password, MapSizeIndex); }
        public bool IsWorldReady() { return Invoke<bool>(nameof(IsWorldReady)); }
        public bool IsReady() { return Invoke<bool>(nameof(IsReady)); }
        public bool IsPlayingLoadingScreen() { return Invoke<bool>(nameof(IsPlayingLoadingScreen)); }
        public bool IsLocalPlayerReady() { return Invoke<bool>(nameof(IsLocalPlayerReady)); }
        public bool IsInitialized() { return Invoke<bool>(nameof(IsInitialized)); }
        public void InitTutorialWorld() { Invoke(nameof(InitTutorialWorld)); }
        public void HideWidgetLoadingScreen() { Invoke(nameof(HideWidgetLoadingScreen)); }
        public void HandleEventMessages(Object EventId, Object RequestId, Array<ServerRequestMessage> Messages) { Invoke(nameof(HandleEventMessages), EventId, RequestId, Messages); }
        public void HandleEventErrors(Object EventId, Object RequestId, Array<ServerRequestError> Errors) { Invoke(nameof(HandleEventErrors), EventId, RequestId, Errors); }
        public Key GetVirtualBackKey() { return Invoke<Key>(nameof(GetVirtualBackKey)); }
        public Key GetVirtualAcceptKey() { return Invoke<Key>(nameof(GetVirtualAcceptKey)); }
        public EGameInstanceState GetState() { return Invoke<EGameInstanceState>(nameof(GetState)); }
        public ERuntimePlatform GetRuntimePlatform() { return Invoke<ERuntimePlatform>(nameof(GetRuntimePlatform)); }
        public Object GetProjectVersion() { return Invoke<Object>(nameof(GetProjectVersion)); }
        public bool GetPlayerWasKicked() { return Invoke<bool>(nameof(GetPlayerWasKicked)); }
        public bool GetPlayerWasBanned() { return Invoke<bool>(nameof(GetPlayerWasBanned)); }
        public bool GetPlayerConnectivityIssue() { return Invoke<bool>(nameof(GetPlayerConnectivityIssue)); }
        public TOMPlayerState GetLocalPlayerState() { return Invoke<TOMPlayerState>(nameof(GetLocalPlayerState)); }
        public UserWidget GetLoadingScreenWidget() { return Invoke<UserWidget>(nameof(GetLoadingScreenWidget)); }
        public Object GetEnvironmentId() { return Invoke<Object>(nameof(GetEnvironmentId)); }
        public int GetDebugSeed() { return Invoke<int>(nameof(GetDebugSeed)); }
        public Bifrost GetBifrost() { return Invoke<Bifrost>(nameof(GetBifrost)); }
        public void CreateWorld(Object WorldName, bool IsPrivate, Object Password, int MaxPlayerCount, bool bIsHost, WorldConfigVO VO) { Invoke(nameof(CreateWorld), WorldName, IsPrivate, Password, MaxPlayerCount, bIsHost, VO); }
        public void CreateTutorial() { Invoke(nameof(CreateTutorial)); }
        public void ConsumePendingEntitlements() { Invoke(nameof(ConsumePendingEntitlements)); }
        public bool CheckPendingActivities() { return Invoke<bool>(nameof(CheckPendingActivities)); }
        public void ApplicationWillDeactivate() { Invoke(nameof(ApplicationWillDeactivate)); }
        public void ActivateActivity(Object ActivityId) { Invoke(nameof(ActivateActivity), ActivityId); }
    }
    public class TOMGameMode : TOMGameModeBase
    {
        public TOMGameMode(ulong addr) : base(addr) { }
        public bool TriggerSave { get { return this[nameof(TriggerSave)].Flag; } set { this[nameof(TriggerSave)].Flag = value; } }
        public DataObject PendingSaveGame { get { return this[nameof(PendingSaveGame)].As<DataObject>(); } set { this["PendingSaveGame"] = value; } }
        public EventRequest SaveEventRequest { get { return this[nameof(SaveEventRequest)].As<EventRequest>(); } set { this["SaveEventRequest"] = value; } }
        public EventRequest BanEventRequest { get { return this[nameof(BanEventRequest)].As<EventRequest>(); } set { this["BanEventRequest"] = value; } }
        public EventRequest SetWorldStatusEventRequest { get { return this[nameof(SetWorldStatusEventRequest)].As<EventRequest>(); } set { this["SetWorldStatusEventRequest"] = value; } }
        public Object PlayersSessionIdByUserId { get { return this[nameof(PlayersSessionIdByUserId)]; } set { this[nameof(PlayersSessionIdByUserId)] = value; } }
        public void SendGlobalAlert(Object AlertLocalizedMessage, EAlertColor Color) { Invoke(nameof(SendGlobalAlert), AlertLocalizedMessage, Color); }
        public void Save() { Invoke(nameof(Save)); }
        public void RemoveFakePlayers() { Invoke(nameof(RemoveFakePlayers)); }
        public void PostLogin(PlayerController NewPlayer) { Invoke(nameof(PostLogin), NewPlayer); }
        public void OnSetWorldStatusSuccess(ServerResponse Response) { Invoke(nameof(OnSetWorldStatusSuccess), Response); }
        public void OnSetWorldStatusError(ServerResponse Response) { Invoke(nameof(OnSetWorldStatusError), Response); }
        public void OnSaveSuccess(ServerResponse Response) { Invoke(nameof(OnSaveSuccess), Response); }
        public void OnSaveError(ServerResponse Response) { Invoke(nameof(OnSaveError), Response); }
        public void OnGameOver(bool IsYggdrasilDead, float Delay) { Invoke(nameof(OnGameOver), IsYggdrasilDead, Delay); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public void OnBanSuccess(ServerResponse Response) { Invoke(nameof(OnBanSuccess), Response); }
        public void DelayedOnGameOver(bool IsYggdrasilDead) { Invoke(nameof(DelayedOnGameOver), IsYggdrasilDead); }
        public void CallSetWorldStatus(bool bIsReady) { Invoke(nameof(CallSetWorldStatus), bIsReady); }
        public void BanPlayer(Object PlayerId, Object BanReason) { Invoke(nameof(BanPlayer), PlayerId, BanReason); }
        public void AddFakePlayer() { Invoke(nameof(AddFakePlayer)); }
        public void AddCollaborativeXP(int XpToAdd, Object AlertLocalizedMessage) { Invoke(nameof(AddCollaborativeXP), XpToAdd, AlertLocalizedMessage); }
    }
    public class TOMGameState : BifrostGameState
    {
        public TOMGameState(ulong addr) : base(addr) { }
        public Object GiantManagerBPClass { get { return this[nameof(GiantManagerBPClass)]; } set { this[nameof(GiantManagerBPClass)] = value; } }
        public Object VFXManagerBPClass { get { return this[nameof(VFXManagerBPClass)]; } set { this[nameof(VFXManagerBPClass)] = value; } }
        public Object PlayerLootManagerBPClass { get { return this[nameof(PlayerLootManagerBPClass)]; } set { this[nameof(PlayerLootManagerBPClass)] = value; } }
        public Object WorldMapManagerClass { get { return this[nameof(WorldMapManagerClass)]; } set { this[nameof(WorldMapManagerClass)] = value; } }
        public Object MinionWaveManagerBPClass { get { return this[nameof(MinionWaveManagerBPClass)]; } set { this[nameof(MinionWaveManagerBPClass)] = value; } }
        public Object TimeManagerBPClass { get { return this[nameof(TimeManagerBPClass)]; } set { this[nameof(TimeManagerBPClass)] = value; } }
        public Object ExtractorManagerBPClass { get { return this[nameof(ExtractorManagerBPClass)]; } set { this[nameof(ExtractorManagerBPClass)] = value; } }
        public Object BifrostManagerBPClass { get { return this[nameof(BifrostManagerBPClass)]; } set { this[nameof(BifrostManagerBPClass)] = value; } }
        public GameSessionData GameSessionData { get { return this[nameof(GameSessionData)].As<GameSessionData>(); } set { this["GameSessionData"] = value; } }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
        public GiantManager GiantManager { get { return this[nameof(GiantManager)].As<GiantManager>(); } set { this["GiantManager"] = value; } }
        public PlayerLootManager PlayerLootManager { get { return this[nameof(PlayerLootManager)].As<PlayerLootManager>(); } set { this["PlayerLootManager"] = value; } }
        public MinionWaveManager MinionWaveManager { get { return this[nameof(MinionWaveManager)].As<MinionWaveManager>(); } set { this["MinionWaveManager"] = value; } }
        public WorldMapManager WorldMapManager { get { return this[nameof(WorldMapManager)].As<WorldMapManager>(); } set { this["WorldMapManager"] = value; } }
        public RespawnableManager RespawnableManager { get { return this[nameof(RespawnableManager)].As<RespawnableManager>(); } set { this["RespawnableManager"] = value; } }
        public TimeManager TimeManager { get { return this[nameof(TimeManager)].As<TimeManager>(); } set { this["TimeManager"] = value; } }
        public VFXSpawnManager VFXManager { get { return this[nameof(VFXManager)].As<VFXSpawnManager>(); } set { this["VFXManager"] = value; } }
        public UpgradeManager UpgradeManager { get { return this[nameof(UpgradeManager)].As<UpgradeManager>(); } set { this["UpgradeManager"] = value; } }
        public BifrostManager BifrostManager { get { return this[nameof(BifrostManager)].As<BifrostManager>(); } set { this["BifrostManager"] = value; } }
        public SpawningManager SpawningManager { get { return this[nameof(SpawningManager)].As<SpawningManager>(); } set { this["SpawningManager"] = value; } }
        public MetaMovementManager MetaMovementManager { get { return this[nameof(MetaMovementManager)].As<MetaMovementManager>(); } set { this["MetaMovementManager"] = value; } }
        public GameEventManager GameEventManager { get { return this[nameof(GameEventManager)].As<GameEventManager>(); } set { this["GameEventManager"] = value; } }
        public QuestManager QuestManager { get { return this[nameof(QuestManager)].As<QuestManager>(); } set { this["QuestManager"] = value; } }
        public CaveManager CaveManager { get { return this[nameof(CaveManager)].As<CaveManager>(); } set { this["CaveManager"] = value; } }
        public ExtractorManager ExtractorManager { get { return this[nameof(ExtractorManager)].As<ExtractorManager>(); } set { this["ExtractorManager"] = value; } }
        public WorldVO WorldVO { get { return this[nameof(WorldVO)].As<WorldVO>(); } set { this["WorldVO"] = value; } }
        public void SendFenrirDefeatedMulticast(Object LastAttackerId) { Invoke(nameof(SendFenrirDefeatedMulticast), LastAttackerId); }
        public void ReceiveWorldReady() { Invoke(nameof(ReceiveWorldReady)); }
        public void OnWorldEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnWorldEntityChanged), Entity, Context); }
        public void OnRep_WorldVO(WorldVO WorldVO) { Invoke(nameof(OnRep_WorldVO), WorldVO); }
        public void OnGameStateDestroyed(Actor Actor) { Invoke(nameof(OnGameStateDestroyed), Actor); }
        public void InitManagers() { Invoke(nameof(InitManagers)); }
        public WorldMapManager GetWorldMapManager() { return Invoke<WorldMapManager>(nameof(GetWorldMapManager)); }
        public WorldEntityModel GetWorldEntityModel() { return Invoke<WorldEntityModel>(nameof(GetWorldEntityModel)); }
        public float GetWorldElapsedTime() { return Invoke<float>(nameof(GetWorldElapsedTime)); }
        public VFXSpawnManager GetVFXManager() { return Invoke<VFXSpawnManager>(nameof(GetVFXManager)); }
        public UpgradeManager GetUpgradeManager() { return Invoke<UpgradeManager>(nameof(GetUpgradeManager)); }
        public TimeManager GetTimeManager() { return Invoke<TimeManager>(nameof(GetTimeManager)); }
        public SpawningManager GetSpawningManager() { return Invoke<SpawningManager>(nameof(GetSpawningManager)); }
        public RespawnableManager GetRespawnableManager() { return Invoke<RespawnableManager>(nameof(GetRespawnableManager)); }
        public TOMPlayerState GetPlayerStateById(Object UserId) { return Invoke<TOMPlayerState>(nameof(GetPlayerStateById), UserId); }
        public PlayerLootManager GetPlayerLootManager() { return Invoke<PlayerLootManager>(nameof(GetPlayerLootManager)); }
        public MinionWaveManager GetMinionWaveManager() { return Invoke<MinionWaveManager>(nameof(GetMinionWaveManager)); }
        public MetaMovementManager GetMetaMovementManager() { return Invoke<MetaMovementManager>(nameof(GetMetaMovementManager)); }
        public GiantManager GetGiantManager() { return Invoke<GiantManager>(nameof(GetGiantManager)); }
        public GameSessionData GetGameSessionData() { return Invoke<GameSessionData>(nameof(GetGameSessionData)); }
        public ExtractorManager GetExtractorManager() { return Invoke<ExtractorManager>(nameof(GetExtractorManager)); }
        public float GetCleanWorldElapsedTime() { return Invoke<float>(nameof(GetCleanWorldElapsedTime)); }
        public BifrostManager GetBifrostManager() { return Invoke<BifrostManager>(nameof(GetBifrostManager)); }
    }
    public class TOMGameViewportClient : GameViewportClient
    {
        public TOMGameViewportClient(ulong addr) : base(addr) { }
        public Object OnInputControllerChanged { get { return this[nameof(OnInputControllerChanged)]; } set { this[nameof(OnInputControllerChanged)] = value; } }
        public Object OnViewportFocusChanged { get { return this[nameof(OnViewportFocusChanged)]; } set { this[nameof(OnViewportFocusChanged)] = value; } }
        public bool IsKeyboardController() { return Invoke<bool>(nameof(IsKeyboardController)); }
        public bool IsGamepadController() { return Invoke<bool>(nameof(IsGamepadController)); }
        public EPlatformController GetCurrentPlatformController() { return Invoke<EPlatformController>(nameof(GetCurrentPlatformController)); }
    }
    public class TOMGlobalEvents : BifrostObject
    {
        public TOMGlobalEvents(ulong addr) : base(addr) { }
        public void UnbindOnWorldReadyEventDelegate(Object Callback) { Invoke(nameof(UnbindOnWorldReadyEventDelegate), Callback); }
        public void UnbindOnTimeManagerReadyDelegate(Object Callback) { Invoke(nameof(UnbindOnTimeManagerReadyDelegate), Callback); }
        public void UnbindOnPreWorldSaveDelegate(Object Callback) { Invoke(nameof(UnbindOnPreWorldSaveDelegate), Callback); }
        public void UnbindOnPreloadingCompleteEventDelegate(Object Callback) { Invoke(nameof(UnbindOnPreloadingCompleteEventDelegate), Callback); }
        public void UnbindOnPostWorldSaveDelegate(Object Callback) { Invoke(nameof(UnbindOnPostWorldSaveDelegate), Callback); }
        public void UnbindOnPlayerReadyEventDelegate(Object Callback) { Invoke(nameof(UnbindOnPlayerReadyEventDelegate), Callback); }
        public void UnbindOnLocalPlayerReadyEventDelegate(Object Callback) { Invoke(nameof(UnbindOnLocalPlayerReadyEventDelegate), Callback); }
        public void UnbindOnHazardSpawnedDelegate(Object Callback) { Invoke(nameof(UnbindOnHazardSpawnedDelegate), Callback); }
        public void UnbindOnGiantManagerReadyDelegate(Object Callback) { Invoke(nameof(UnbindOnGiantManagerReadyDelegate), Callback); }
        public void BroadcastOnWorldReadyEvent() { Invoke(nameof(BroadcastOnWorldReadyEvent)); }
        public void BroadcastOnWorldEntityUpdatedEvent() { Invoke(nameof(BroadcastOnWorldEntityUpdatedEvent)); }
        public void BroadcastOnPreloadingCompleteEvent() { Invoke(nameof(BroadcastOnPreloadingCompleteEvent)); }
        public void BroadcastOnPlayerReadyEvent(TOMPlayerState TOMPlayerState) { Invoke(nameof(BroadcastOnPlayerReadyEvent), TOMPlayerState); }
        public void BroadcastOnLocalPlayerReadyEvent(TOMPlayerState TOMPlayerState) { Invoke(nameof(BroadcastOnLocalPlayerReadyEvent), TOMPlayerState); }
        public void BindOnWorldReadyEventDelegate(Object Callback) { Invoke(nameof(BindOnWorldReadyEventDelegate), Callback); }
        public void BindOnTimeManagerReadyDelegate(Object Callback) { Invoke(nameof(BindOnTimeManagerReadyDelegate), Callback); }
        public void BindOnPreWorldSaveDelegate(Object Callback) { Invoke(nameof(BindOnPreWorldSaveDelegate), Callback); }
        public void BindOnPreloadingCompleteEventDelegate(Object Callback) { Invoke(nameof(BindOnPreloadingCompleteEventDelegate), Callback); }
        public void BindOnPostWorldSaveDelegate(Object Callback) { Invoke(nameof(BindOnPostWorldSaveDelegate), Callback); }
        public void BindOnPlayerReadyEventDelegate(Object Callback) { Invoke(nameof(BindOnPlayerReadyEventDelegate), Callback); }
        public void BindOnLocalPlayerReadyEventDelegate(Object Callback) { Invoke(nameof(BindOnLocalPlayerReadyEventDelegate), Callback); }
        public void BindOnHazardSpawnedDelegate(Object Callback) { Invoke(nameof(BindOnHazardSpawnedDelegate), Callback); }
        public void BindOnGiantManagerReadyDelegate(Object Callback) { Invoke(nameof(BindOnGiantManagerReadyDelegate), Callback); }
    }
    public class TOMLobbyBeaconPlayerState : BifrostPartyPlayerState
    {
        public TOMLobbyBeaconPlayerState(ulong addr) : base(addr) { }
        public Object OnLobbyBeaconPlayerStateChanged { get { return this[nameof(OnLobbyBeaconPlayerStateChanged)]; } set { this[nameof(OnLobbyBeaconPlayerStateChanged)] = value; } }
        public TOMLobbyCharacterData Profile { get { return this[nameof(Profile)].As<TOMLobbyCharacterData>(); } set { this["Profile"] = value; } }
        public Object SelectedWorldId { get { return this[nameof(SelectedWorldId)]; } set { this[nameof(SelectedWorldId)] = value; } }
        public int SelectedMapSize { get { return this[nameof(SelectedMapSize)].GetValue<int>(); } set { this[nameof(SelectedMapSize)].SetValue<int>(value); } }
        public void UpdateProfile(TOMLobbyCharacterData InProfile) { Invoke(nameof(UpdateProfile), InProfile); }
        public void OpenMatchAboutToStart() { Invoke(nameof(OpenMatchAboutToStart)); }
        public void OnRep_Profile() { Invoke(nameof(OnRep_Profile)); }
        public void JoinWorld(Object WorldID, int MapSize) { Invoke(nameof(JoinWorld), WorldID, MapSize); }
        public TOMLobbyCharacterData GetProfile() { return Invoke<TOMLobbyCharacterData>(nameof(GetProfile)); }
        public void CloseMatchAboutToStart() { Invoke(nameof(CloseMatchAboutToStart)); }
    }
    public class TOMLobbyCharacter : BifrostCharacter
    {
        public TOMLobbyCharacter(ulong addr) : base(addr) { }
        public TOMLobbyCharacterData TOMLobbyCharacterData { get { return this[nameof(TOMLobbyCharacterData)].As<TOMLobbyCharacterData>(); } set { this["TOMLobbyCharacterData"] = value; } }
        public TransmogDataModel GetRandomTransmogWeapon(TOMLobbyCharacterData Data, int ItemTypeId) { return Invoke<TransmogDataModel>(nameof(GetRandomTransmogWeapon), Data, ItemTypeId); }
    }
    public class TOMLobbyCheatManager : CheatManager
    {
        public TOMLobbyCheatManager(ulong addr) : base(addr) { }
        public void TOMUpdateUserData(Object DataName, int DataValue) { Invoke(nameof(TOMUpdateUserData), DataName, DataValue); }
        public void TOMUnlockEntitlement(int Value) { Invoke(nameof(TOMUnlockEntitlement), Value); }
        public void TOMUnlockAllEntitlements() { Invoke(nameof(TOMUnlockAllEntitlements)); }
        public void TOMUnlockAllAchievements() { Invoke(nameof(TOMUnlockAllAchievements)); }
        public void TOMUnlockAchievement(int ID) { Invoke(nameof(TOMUnlockAchievement), ID); }
        public void TOMStartActivity(Object ActivityId) { Invoke(nameof(TOMStartActivity), ActivityId); }
        public void TOMSetSeed(int Seed) { Invoke(nameof(TOMSetSeed), Seed); }
        public void TOMSetPlatformUI(int Platform) { Invoke(nameof(TOMSetPlatformUI), Platform); }
        public void TOMResetUser() { Invoke(nameof(TOMResetUser)); }
        public void TOMResetAchievements() { Invoke(nameof(TOMResetAchievements)); }
        public void TOMRefreshShop(Object Date) { Invoke(nameof(TOMRefreshShop), Date); }
        public void TOMPlayIntroVideo() { Invoke(nameof(TOMPlayIntroVideo)); }
        public void TOMOpenShiftUI() { Invoke(nameof(TOMOpenShiftUI)); }
        public void TOMLeaveVivox() { Invoke(nameof(TOMLeaveVivox)); }
        public void TOMJoinVivox(Object ChannelName) { Invoke(nameof(TOMJoinVivox), ChannelName); }
        public void TOMJoinLobbyDebug() { Invoke(nameof(TOMJoinLobbyDebug)); }
        public void TOMGetAuthCode() { Invoke(nameof(TOMGetAuthCode)); }
        public void TOMFillFakeLobby() { Invoke(nameof(TOMFillFakeLobby)); }
        public void TOMAddVictoryCurrency(int Value) { Invoke(nameof(TOMAddVictoryCurrency), Value); }
        public void TOMAddSeasonXP(int Value) { Invoke(nameof(TOMAddSeasonXP), Value); }
        public void TOMAddExternalEntitlement(Object EntitlementName) { Invoke(nameof(TOMAddExternalEntitlement), EntitlementName); }
        public void TOMAddBasicCurrency(int Value) { Invoke(nameof(TOMAddBasicCurrency), Value); }
        public void TestNotifyMaintenance() { Invoke(nameof(TestNotifyMaintenance)); }
    }
    public class TOMLobbyDataModel : LobbyDataModel
    {
        public TOMLobbyDataModel(ulong addr) : base(addr) { }
        public LobbyAvatarEntityModel Avatar { get { return this[nameof(Avatar)].As<LobbyAvatarEntityModel>(); } set { this["Avatar"] = value; } }
        public LobbyAvatarEntityModel GetAvatar() { return Invoke<LobbyAvatarEntityModel>(nameof(GetAvatar)); }
    }
    public class TOMMenuNotification : Object
    {
        public TOMMenuNotification(ulong addr) : base(addr) { }
        public TOMMenuNotificationPath PathStruct { get { return this[nameof(PathStruct)].As<TOMMenuNotificationPath>(); } set { this["PathStruct"] = value; } }
        public bool ContainPath(Array<Object> PathToCheck) { return Invoke<bool>(nameof(ContainPath), PathToCheck); }
    }
    public class TOMNotificationManager : Object
    {
        public TOMNotificationManager(ulong addr) : base(addr) { }
        public Object OnMenuNotificationRefresh { get { return this[nameof(OnMenuNotificationRefresh)]; } set { this[nameof(OnMenuNotificationRefresh)] = value; } }
        public Array<TOMMenuNotification> ActiveNotifications { get { return new Array<TOMMenuNotification>(this[nameof(ActiveNotifications)].Address); } }
        public void RemoveNotification(Array<Object> Path) { Invoke(nameof(RemoveNotification), Path); }
        public void RegisterNotification(Array<Object> Path, bool bDoNotBroadcast) { Invoke(nameof(RegisterNotification), Path, bDoNotBroadcast); }
        public bool IsPathNotificationActive(Array<Object> Path) { return Invoke<bool>(nameof(IsPathNotificationActive), Path); }
        public Array<Object> GeneratePathForEntitlement(int EntitlementID) { return Invoke<Array<Object>>(nameof(GeneratePathForEntitlement), EntitlementID); }
        public Array<Object> GeneratePathForCosmetic(int CosmeticId) { return Invoke<Array<Object>>(nameof(GeneratePathForCosmetic), CosmeticId); }
        public Array<Object> GenerateNotificationPathForChallenge(ChallengeDataModel ChallengeDataModel) { return Invoke<Array<Object>>(nameof(GenerateNotificationPathForChallenge), ChallengeDataModel); }
        public TOMMenuNotification FindNotificationByPath(Array<Object> Path) { return Invoke<TOMMenuNotification>(nameof(FindNotificationByPath), Path); }
        public void ClearAllNotifications() { Invoke(nameof(ClearAllNotifications)); }
    }
    public class TOMOffensiveComponent : OffensiveComponent
    {
        public TOMOffensiveComponent(ulong addr) : base(addr) { }
        public Object OnEmissionBlocked { get { return this[nameof(OnEmissionBlocked)]; } set { this[nameof(OnEmissionBlocked)] = value; } }
        public TOMOffensiveComponent PrimaryOffensiveComponent { get { return this[nameof(PrimaryOffensiveComponent)].As<TOMOffensiveComponent>(); } set { this["PrimaryOffensiveComponent"] = value; } }
        public Object DetectionShapeComponent { get { return this[nameof(DetectionShapeComponent)]; } set { this[nameof(DetectionShapeComponent)] = value; } }
        public AttackStatsDataModel CurrentAttack { get { return this[nameof(CurrentAttack)].As<AttackStatsDataModel>(); } set { this["CurrentAttack"] = value; } }
        public bool bCurrentAttackIsLight { get { return this[nameof(bCurrentAttackIsLight)].Flag; } set { this[nameof(bCurrentAttackIsLight)].Flag = value; } }
        public bool bTempIgnoreHitReaction { get { return this[nameof(bTempIgnoreHitReaction)].Flag; } set { this[nameof(bTempIgnoreHitReaction)].Flag = value; } }
        public int ShieldAttackId { get { return this[nameof(ShieldAttackId)].GetValue<int>(); } set { this[nameof(ShieldAttackId)].SetValue<int>(value); } }
        public ReceiverComponent LastHitTarget { get { return this[nameof(LastHitTarget)].As<ReceiverComponent>(); } set { this["LastHitTarget"] = value; } }
        public void SpawnAOE(AttackStatsDataModel AttackModel, Vector Location, Rotator Rotation) { Invoke(nameof(SpawnAOE), AttackModel, Location, Rotation); }
        public void SetDamageMultiplier(float Value) { Invoke(nameof(SetDamageMultiplier), Value); }
        public void SetCurrentAttackData(int AttackModelId, int ItemTypeId, int MunitionItemId, StatusComponent Status, bool bIsLightAttack) { Invoke(nameof(SetCurrentAttackData), AttackModelId, ItemTypeId, MunitionItemId, Status, bIsLightAttack); }
        public float GetRagdollProjectionForce() { return Invoke<float>(nameof(GetRagdollProjectionForce)); }
        public float GetPushBackDuration() { return Invoke<float>(nameof(GetPushBackDuration)); }
        public float GetPushBackDistance() { return Invoke<float>(nameof(GetPushBackDistance)); }
        public TOMCharacter GetOwnerCharacter() { return Invoke<TOMCharacter>(nameof(GetOwnerCharacter)); }
        public float GetCurrentDamageMultiplier() { return Invoke<float>(nameof(GetCurrentDamageMultiplier)); }
        public float GetCurrentDamageBonus() { return Invoke<float>(nameof(GetCurrentDamageBonus)); }
        public Object GetAmountByChannel() { return Invoke<Object>(nameof(GetAmountByChannel)); }
        public void EmissionBlockedDelegate__DelegateSignature(ReceiverComponent Blocker) { Invoke(nameof(EmissionBlockedDelegate__DelegateSignature), Blocker); }
        public void CopyData(TOMOffensiveComponent Source) { Invoke(nameof(CopyData), Source); }
        public void AddDamageMultiplier(float Value) { Invoke(nameof(AddDamageMultiplier), Value); }
        public void AddDamageBonus(float Value) { Invoke(nameof(AddDamageBonus), Value); }
    }
    public class TOMOverlays : Object
    {
        public TOMOverlays(ulong addr) : base(addr) { }
        public Array<OverlayItem> GetOverlaysForTime(BasicOverlays OverlaysRef, Timespan Time) { return Invoke<Array<OverlayItem>>(nameof(GetOverlaysForTime), OverlaysRef, Time); }
    }
    public class TOMPathFollowingComponent : PathFollowingComponent
    {
        public TOMPathFollowingComponent(ulong addr) : base(addr) { }
        public bool HasDetectedBlock { get { return this[nameof(HasDetectedBlock)].Flag; } set { this[nameof(HasDetectedBlock)].Flag = value; } }
        public Actor ActorBlockingPath { get { return this[nameof(ActorBlockingPath)].As<Actor>(); } set { this["ActorBlockingPath"] = value; } }
        public Actor PrevActorBlockingPath { get { return this[nameof(PrevActorBlockingPath)].As<Actor>(); } set { this["PrevActorBlockingPath"] = value; } }
        public Object OnPathBlockedByActors { get { return this[nameof(OnPathBlockedByActors)]; } set { this[nameof(OnPathBlockedByActors)] = value; } }
        public void LookForBlockers() { Invoke(nameof(LookForBlockers)); }
    }
    public struct Vec
    {
        public float x;
        public float y;
        public float z;
    }
    public class TOMPlayerController : BifrostPlayerController
    {
        public TOMPlayerController(ulong addr) : base(addr) { }
        public bool bIsUsingMouseAndKeyboard { get { return this[nameof(bIsUsingMouseAndKeyboard)].Flag; } set { this[nameof(bIsUsingMouseAndKeyboard)].Flag = value; } }
        public Object OnInputControllerChanged { get { return this[nameof(OnInputControllerChanged)]; } set { this[nameof(OnInputControllerChanged)] = value; } }
        public Object OnCraftItemFailed { get { return this[nameof(OnCraftItemFailed)]; } set { this[nameof(OnCraftItemFailed)] = value; } }
        public Object OnTooManyConstructions { get { return this[nameof(OnTooManyConstructions)]; } set { this[nameof(OnTooManyConstructions)] = value; } }
        public Object OnDialogClosedServerEvent { get { return this[nameof(OnDialogClosedServerEvent)]; } set { this[nameof(OnDialogClosedServerEvent)] = value; } }
        public Object OnWorldContainerClosedServerEvent { get { return this[nameof(OnWorldContainerClosedServerEvent)]; } set { this[nameof(OnWorldContainerClosedServerEvent)] = value; } }
        public Object OnUseRunestone { get { return this[nameof(OnUseRunestone)]; } set { this[nameof(OnUseRunestone)] = value; } }
        public Object OnUpdateRuneStone { get { return this[nameof(OnUpdateRuneStone)]; } set { this[nameof(OnUpdateRuneStone)] = value; } }
        public Object OnStartIdleCheck { get { return this[nameof(OnStartIdleCheck)]; } set { this[nameof(OnStartIdleCheck)] = value; } }
        public Object OnDeconstruct { get { return this[nameof(OnDeconstruct)]; } set { this[nameof(OnDeconstruct)] = value; } }
        public Object OnReceiveVictoryCurrency { get { return this[nameof(OnReceiveVictoryCurrency)]; } set { this[nameof(OnReceiveVictoryCurrency)] = value; } }
        public Object OnCreatureKilledEvent { get { return this[nameof(OnCreatureKilledEvent)]; } set { this[nameof(OnCreatureKilledEvent)] = value; } }
        public Object OnHazardBuiltEvent { get { return this[nameof(OnHazardBuiltEvent)]; } set { this[nameof(OnHazardBuiltEvent)] = value; } }
        public Object OnFakeItemCollectionFeedback { get { return this[nameof(OnFakeItemCollectionFeedback)]; } set { this[nameof(OnFakeItemCollectionFeedback)] = value; } }
        public Object OnTalkToNPC { get { return this[nameof(OnTalkToNPC)]; } set { this[nameof(OnTalkToNPC)] = value; } }
        public TOMCharacter ShieldLockTarget { get { return this[nameof(ShieldLockTarget)].As<TOMCharacter>(); } set { this["ShieldLockTarget"] = value; } }
        public bool bIsHoldingShield { get { return this[nameof(bIsHoldingShield)].Flag; } set { this[nameof(bIsHoldingShield)].Flag = value; } }
        public float InputForwardValue { get { return this[nameof(InputForwardValue)].GetValue<float>(); } set { this[nameof(InputForwardValue)].SetValue<float>(value); } }
        public float InputRightValue { get { return this[nameof(InputRightValue)].GetValue<float>(); } set { this[nameof(InputRightValue)].SetValue<float>(value); } }
        public bool bGlobalMessagesEnabled { get { return this[nameof(bGlobalMessagesEnabled)].Flag; } set { this[nameof(bGlobalMessagesEnabled)].Flag = value; } }
        public bool bIsSanctuaryRuneInfiniteCooldown { get { return this[nameof(bIsSanctuaryRuneInfiniteCooldown)].Flag; } set { this[nameof(bIsSanctuaryRuneInfiniteCooldown)].Flag = value; } }
        public float SanctuaryRuneRemainingCooldown { get { return this[nameof(SanctuaryRuneRemainingCooldown)].GetValue<float>(); } set { this[nameof(SanctuaryRuneRemainingCooldown)].SetValue<float>(value); } }
        public float ConsumableBaseCooldown { get { return this[nameof(ConsumableBaseCooldown)].GetValue<float>(); } set { this[nameof(ConsumableBaseCooldown)].SetValue<float>(value); } }
        public float ConsumableRemainingCooldown { get { return this[nameof(ConsumableRemainingCooldown)].GetValue<float>(); } set { this[nameof(ConsumableRemainingCooldown)].SetValue<float>(value); } }
        public Object PlayerShiftId { get { return this[nameof(PlayerShiftId)]; } set { this[nameof(PlayerShiftId)] = value; } }
        public EventRequest EventRequest { get { return this[nameof(EventRequest)].As<EventRequest>(); } set { this["EventRequest"] = value; } }
        public EventRequest CollectHornRequest { get { return this[nameof(CollectHornRequest)].As<EventRequest>(); } set { this["CollectHornRequest"] = value; } }
        public EventRequest ReportUserRequest { get { return this[nameof(ReportUserRequest)].As<EventRequest>(); } set { this["ReportUserRequest"] = value; } }
        public Object RightStickActionUpName { get { return this[nameof(RightStickActionUpName)]; } set { this[nameof(RightStickActionUpName)] = value; } }
        public Object RightStickActionRightName { get { return this[nameof(RightStickActionRightName)]; } set { this[nameof(RightStickActionRightName)] = value; } }
        public Object LeftStickActionUpName { get { return this[nameof(LeftStickActionUpName)]; } set { this[nameof(LeftStickActionUpName)] = value; } }
        public Object LeftStickActionRightName { get { return this[nameof(LeftStickActionRightName)]; } set { this[nameof(LeftStickActionRightName)] = value; } }
        public TOMGameViewportClient GameViewportClient { get { return this[nameof(GameViewportClient)].As<TOMGameViewportClient>(); } set { this["GameViewportClient"] = value; } }
        public WorldCreatureEntityModel pet { get { return this[nameof(pet)].As<WorldCreatureEntityModel>(); } set { this["pet"] = value; } }
        public Array<Object> ReportedPlayerIds { get { return new Array<Object>(this[nameof(ReportedPlayerIds)].Address); } }
        public Array<Object> MutedPlayerIds { get { return new Array<Object>(this[nameof(MutedPlayerIds)].Address); } }
        public TimerHandle IdleCheckTimerHandler { get { return this[nameof(IdleCheckTimerHandler)].As<TimerHandle>(); } set { this["IdleCheckTimerHandler"] = value; } }
        public TimerHandle VivoxReconnectTimerHandler { get { return this[nameof(VivoxReconnectTimerHandler)].As<TimerHandle>(); } set { this["VivoxReconnectTimerHandler"] = value; } }
        public TOMSpectatorPawn TOMSpectator { get { return this[nameof(TOMSpectator)].As<TOMSpectatorPawn>(); } set { this["TOMSpectator"] = value; } }
        public Object CurrentRoomId { get { return this[nameof(CurrentRoomId)]; } set { this[nameof(CurrentRoomId)] = value; } }
        public void ValidateConstructionCountClient() { Invoke(nameof(ValidateConstructionCountClient)); }
        public void UseSanctuaryRune() { Invoke(nameof(UseSanctuaryRune)); }
        public void UpdateCurrencyBalanceClient(int Count, int Diff, int TypeId) { Invoke(nameof(UpdateCurrencyBalanceClient), Count, Diff, TypeId); }
        public void UpdateCharacterLookDirection(Rotator LookPoint) { Invoke(nameof(UpdateCharacterLookDirection), LookPoint); }
        public void UnlockSkillServer(int SkillId) { Invoke(nameof(UnlockSkillServer), SkillId); }
        public void UnequipItem(Object SlotId) { Invoke(nameof(UnequipItem), SlotId); }
        public void UnequipAllItems() { Invoke(nameof(UnequipAllItems)); }
        public void TryEquipItem(Object SlotId, int LoadoutIndex) { Invoke(nameof(TryEquipItem), SlotId, LoadoutIndex); }
        public void TOMSlomo(float NewTimeDilation) { Invoke(nameof(TOMSlomo), NewTimeDilation); }
        public void TOMSave() { Invoke(nameof(TOMSave)); }
        public void TOMRemoveFakePlayers() { Invoke(nameof(TOMRemoveFakePlayers)); }
        public void TOMKill() { Invoke(nameof(TOMKill)); }
        public void TOMExecuteCommand(Object Command) { Invoke(nameof(TOMExecuteCommand), Command); }
        public void TOMDropItem(int ID, int quantity, Vector Location) { Invoke(nameof(TOMDropItem), ID, quantity, Location); }
        public void TOMDealDamageToYggdrasil(int Damage) { Invoke(nameof(TOMDealDamageToYggdrasil), Damage); }
        public void TOMAddXP(int XP) { Invoke(nameof(TOMAddXP), XP); }
        public void TOMAddFakePlayer() { Invoke(nameof(TOMAddFakePlayer)); }
        public void TOMAddCollaborativeXP(int XP) { Invoke(nameof(TOMAddCollaborativeXP), XP); }
        public void ToggleSpectating() { Invoke(nameof(ToggleSpectating)); }
        public void TeleportToVillage() { Invoke(nameof(TeleportToVillage)); }
        public void TeleportToPOI(int ID) { Invoke(nameof(TeleportToPOI), ID); }
        public void TeleportToGiant() { Invoke(nameof(TeleportToGiant)); }
        public void TeleportToCoordinates(Vec pos) { Invoke(nameof(TeleportToCoordinates), pos); }
        public void SwitchWeaponsServer() { Invoke(nameof(SwitchWeaponsServer)); }
        public void SwitchWeapons() { Invoke(nameof(SwitchWeapons)); }
        public void StopDestructionMode() { Invoke(nameof(StopDestructionMode)); }
        public void StopBuilding() { Invoke(nameof(StopBuilding)); }
        public void StartPersonalQuestFromBoardServer(int QuestId) { Invoke(nameof(StartPersonalQuestFromBoardServer), QuestId); }
        public void StartIdleCheckTimerHandle() { Invoke(nameof(StartIdleCheckTimerHandle)); }
        public void StartDestructionMode() { Invoke(nameof(StartDestructionMode)); }
        public void StartBuilding() { Invoke(nameof(StartBuilding)); }
        public void StartAutoMode() { Invoke(nameof(StartAutoMode)); }
        public void SpawnVFX(Vector Location, ParticleSystem Template) { Invoke(nameof(SpawnVFX), Location, Template); }
        public void SpawnHazards(int ID, int quantity) { Invoke(nameof(SpawnHazards), ID, quantity); }
        public void SpawnGiant(int GiantAnimalId) { Invoke(nameof(SpawnGiant), GiantAnimalId); }
        public void SpawnEnnemies(int ID, int quantity, int AIBehaviour) { Invoke(nameof(SpawnEnnemies), ID, quantity, AIBehaviour); }
        public void SkipFTUE() { Invoke(nameof(SkipFTUE)); }
        public void ShowWorldMapZoomedOut() { Invoke(nameof(ShowWorldMapZoomedOut)); }
        public void ShowPingCommandServer(Object PlayerId, int CommandId) { Invoke(nameof(ShowPingCommandServer), PlayerId, CommandId); }
        public void ShowFakeItemCollectionFeedback(int ItemId, int Count) { Invoke(nameof(ShowFakeItemCollectionFeedback), ItemId, Count); }
        public void ShowAlert(Object Message, Object SFX, Vector SFXLocation, EAlertColor AlertColor) { Invoke(nameof(ShowAlert), Message, SFX, SFXLocation, AlertColor); }
        public void SetYggdrasilInvincible(int Activate) { Invoke(nameof(SetYggdrasilInvincible), Activate); }
        public void SetTimeOfDaySegment(int DayTimeSegment) { Invoke(nameof(SetTimeOfDaySegment), DayTimeSegment); }
        public void SetSanctuaryRuneRemainingCooldown(float InSanctuaryRuneRemainingCooldown) { Invoke(nameof(SetSanctuaryRuneRemainingCooldown), InSanctuaryRuneRemainingCooldown); }
        public void SetIsSanctuaryRuneInfiniteCooldown(bool bIsinfiniteCooldown) { Invoke(nameof(SetIsSanctuaryRuneInfiniteCooldown), bIsinfiniteCooldown); }
        public void SetInvincible(int Activate) { Invoke(nameof(SetInvincible), Activate); }
        public void SetImmuneToStun(bool bValue) { Invoke(nameof(SetImmuneToStun), bValue); }
        public void SetIdleKickEnabled(int InEnabled) { Invoke(nameof(SetIdleKickEnabled), InEnabled); }
        public void SetFreeAbilities(int Activate) { Invoke(nameof(SetFreeAbilities), Activate); }
        public void SetConsumableRemainingCooldown(float InConsumableRemainingCooldown) { Invoke(nameof(SetConsumableRemainingCooldown), InConsumableRemainingCooldown); }
        public void SetAttackDebug(int Activate) { Invoke(nameof(SetAttackDebug), Activate); }
        public void SetAOEDebug(int Activate) { Invoke(nameof(SetAOEDebug), Activate); }
        public void SendCgSDKEventClient(ECgSDKEventType EventType) { Invoke(nameof(SendCgSDKEventClient), EventType); }
        public void SendCgSDKEventClient(int EventType) { Invoke(nameof(SendCgSDKEventClient), EventType); }
        public void SelectClassServer(ESkillClass Class) { Invoke(nameof(SelectClassServer), Class); }
        public void RevealMap() { Invoke(nameof(RevealMap)); }
        public void ResponseWorldMapInit(Array<byte> CompressedChunks) { Invoke(nameof(ResponseWorldMapInit), CompressedChunks); }
        public void ResetXP() { Invoke(nameof(ResetXP)); }
        public void ResetSkills() { Invoke(nameof(ResetSkills)); }
        public void ResetRunestonesCooldown() { Invoke(nameof(ResetRunestonesCooldown)); }
        public void RequestWorldMapInit() { Invoke(nameof(RequestWorldMapInit)); }
        public void RequestUnlockSkill(int SkillId) { Invoke(nameof(RequestUnlockSkill), SkillId); }
        public void RequestSelectClass(ESkillClass Class) { Invoke(nameof(RequestSelectClass), Class); }
        public void RequestRemoveRecipeFromWishlist(int RecipeId) { Invoke(nameof(RequestRemoveRecipeFromWishlist), RecipeId); }
        public void RequestAddRecipeToWishlist(int RecipeId) { Invoke(nameof(RequestAddRecipeToWishlist), RecipeId); }
        public void ReportPlayer(Object PlayerId, EReportReason Reason) { Invoke(nameof(ReportPlayer), PlayerId, Reason); }
        public void RepairSlot(Object SlotId) { Invoke(nameof(RepairSlot), SlotId); }
        public void RemoveRecipeFromWishlist(int RecipeId) { Invoke(nameof(RemoveRecipeFromWishlist), RecipeId); }
        public void RemoveMakerOnMap(int IconId) { Invoke(nameof(RemoveMakerOnMap), IconId); }
        public void RefreshPet() { Invoke(nameof(RefreshPet)); }
        public void ReceiveVictoryCurrencyFeedbackClient(int Diff, int NewCount) { Invoke(nameof(ReceiveVictoryCurrencyFeedbackClient), Diff, NewCount); }
        public void PauseTimeOfDay() { Invoke(nameof(PauseTimeOfDay)); }
        public void OnWorldContainerClosedServer() { Invoke(nameof(OnWorldContainerClosedServer)); }
        public void OnVivoxReconnectTimerElapsed() { Invoke(nameof(OnVivoxReconnectTimerElapsed)); }
        public void OnVivoxOnUnexpectedLoggout() { Invoke(nameof(OnVivoxOnUnexpectedLoggout)); }
        public void OnReviveSuccess(TOMCharacter RevivedTarget) { Invoke(nameof(OnReviveSuccess), RevivedTarget); }
        public void OnReportPlayerSuccess(ServerResponse Response) { Invoke(nameof(OnReportPlayerSuccess), Response); }
        public void OnIdleTimerElapsed() { Invoke(nameof(OnIdleTimerElapsed)); }
        public void OnGetUserDataSuccess(ServerResponse Response) { Invoke(nameof(OnGetUserDataSuccess), Response); }
        public void OnGetUserDataError(ServerResponse Response) { Invoke(nameof(OnGetUserDataError), Response); }
        public void OnGameOver(bool IsYggdrasilDead) { Invoke(nameof(OnGameOver), IsYggdrasilDead); }
        public void OnDialogClosedServer() { Invoke(nameof(OnDialogClosedServer)); }
        public void OnCreatureKilledClient() { Invoke(nameof(OnCreatureKilledClient)); }
        public void OnCollectCurrencySuccess(ServerResponse Response) { Invoke(nameof(OnCollectCurrencySuccess), Response); }
        public void OnCharacterShieldBlock(TOMOffensiveComponent OffensiveComponent, Vector Location, float Damage) { Invoke(nameof(OnCharacterShieldBlock), OffensiveComponent, Location, Damage); }
        public void OnCharacterPawnEnterCave(TOMCharacter TOMCharacter) { Invoke(nameof(OnCharacterPawnEnterCave), TOMCharacter); }
        public void OnCharacterInventorySlotChanged() { Invoke(nameof(OnCharacterInventorySlotChanged)); }
        public void OnBroadcastInputControllerChanged() { Invoke(nameof(OnBroadcastInputControllerChanged)); }
        public void MutePlayer(Object PlayerId) { Invoke(nameof(MutePlayer), PlayerId); }
        public void MoveSlotWithWorldContainer(EMoveMode MoveMode, EContainerType TargetContainerType, Object SlotId, int Count) { Invoke(nameof(MoveSlotWithWorldContainer), MoveMode, TargetContainerType, SlotId, Count); }
        public void MoveSlotToWorldContainerById(EMoveMode MoveMode, Object DestinationContainerId, Object SlotId, int Count) { Invoke(nameof(MoveSlotToWorldContainerById), MoveMode, DestinationContainerId, SlotId, Count); }
        public void MoveItemCategoryWithWorldContainer(EItemCategory ItemCategory, Array<int> ItemTypes, EMoveMode MoveMode, Object TargetContainerId) { Invoke(nameof(MoveItemCategoryWithWorldContainer), ItemCategory, ItemTypes, MoveMode, TargetContainerId); }
        public void LockPlayerPawn() { Invoke(nameof(LockPlayerPawn)); }
        public void KillAvatar() { Invoke(nameof(KillAvatar)); }
        public bool IsTOMPlayerMuted(Object UserId) { return Invoke<bool>(nameof(IsTOMPlayerMuted), UserId); }
        public bool IsRecipeWishlisted(int RecipeId) { return Invoke<bool>(nameof(IsRecipeWishlisted), RecipeId); }
        public bool IsPlayerReported(Object UserId) { return Invoke<bool>(nameof(IsPlayerReported), UserId); }
        public bool IsMainMenuOpen() { return Invoke<bool>(nameof(IsMainMenuOpen)); }
        public void IgnorePlayers(int Activate) { Invoke(nameof(IgnorePlayers), Activate); }
        public void HideCharacter(int Activate) { Invoke(nameof(HideCharacter), Activate); }
        public void HealAllPlayers(int Amount) { Invoke(nameof(HealAllPlayers), Amount); }
        public bool HasEnoughSpaceForCrafting(CraftingRecipeDataModel Recipe, int Amount) { return Invoke<bool>(nameof(HasEnoughSpaceForCrafting), Recipe, Amount); }
        public void HasAPetClient() { Invoke(nameof(HasAPetClient)); }
        public Array<int> GetWishlistedRecipes() { return Invoke<Array<int>>(nameof(GetWishlistedRecipes)); }
        public TOMSpectatorPawn GetTOMSpectator() { return Invoke<TOMSpectatorPawn>(nameof(GetTOMSpectator)); }
        public float GetSanctuaryRuneRemainingCooldown() { return Invoke<float>(nameof(GetSanctuaryRuneRemainingCooldown)); }
        public float GetSanctuaryRuneConfigCooldown() { return Invoke<float>(nameof(GetSanctuaryRuneConfigCooldown)); }
        public float GetSanctuaryRuneActivationTime() { return Invoke<float>(nameof(GetSanctuaryRuneActivationTime)); }
        public Array<Object> GetReportedPlayers() { return Invoke<Array<Object>>(nameof(GetReportedPlayers)); }
        public Object GetPlayerShiftId() { return Invoke<Object>(nameof(GetPlayerShiftId)); }
        public Object GetPlayerName() { return Invoke<Object>(nameof(GetPlayerName)); }
        public Array<Object> GetMutedPlayers() { return Invoke<Array<Object>>(nameof(GetMutedPlayers)); }
        public Vec GetMouseWorldProjectedPosition() { return Invoke<Vec>(nameof(GetMouseWorldProjectedPosition)); }
        public Vector GetMouseOrientation() { return Invoke<Vector>(nameof(GetMouseOrientation)); }
        public int GetMaxCraftableConstruction(ConstructionRecipeDataModel ConstructionRecipe) { return Invoke<int>(nameof(GetMaxCraftableConstruction), ConstructionRecipe); }
        public int GetMaxCraftable(CraftingRecipeDataModel Recipe) { return Invoke<int>(nameof(GetMaxCraftable), Recipe); }
        public float GetLocalPlayerPing(Object WorldContext) { return Invoke<float>(nameof(GetLocalPlayerPing), WorldContext); }
        public Vector GetLeftStickOrientation() { return Invoke<Vector>(nameof(GetLeftStickOrientation)); }
        public Vector GetLastRightStickOrientation() { return Invoke<Vector>(nameof(GetLastRightStickOrientation)); }
        public int GetElementCount(CraftingRecipeElementDataModel Element) { return Invoke<int>(nameof(GetElementCount), Element); }
        public float GetConsumableRemainingCooldown() { return Invoke<float>(nameof(GetConsumableRemainingCooldown)); }
        public float GetConsumableBaseCooldown() { return Invoke<float>(nameof(GetConsumableBaseCooldown)); }
        public int GetAvailableItemCount(int ItemDataId) { return Invoke<int>(nameof(GetAvailableItemCount), ItemDataId); }
        public Actor FindAutoTarget(Rotator OutAutoRotation, Rotator OutLookRotation, float Range, float Angle) { return Invoke<Actor>(nameof(FindAutoTarget), OutAutoRotation, OutLookRotation, Range, Angle); }
        public void FillContainerServer(Object DestinationContainerId, int ItemId, int Amount, bool bUseWarChest) { Invoke(nameof(FillContainerServer), DestinationContainerId, ItemId, Amount, bUseWarChest); }
        public void EmptyMaterials() { Invoke(nameof(EmptyMaterials)); }
        public void EmptyInventoryContainer() { Invoke(nameof(EmptyInventoryContainer)); }
        public void DropSlot(Object SlotId, int Count, Vector WorldPosition) { Invoke(nameof(DropSlot), SlotId, Count, WorldPosition); }
        public void DropRemainingLoot(ContainerEntityModel Containers) { Invoke(nameof(DropRemainingLoot), Containers); }
        public void DropMakerOnMap(int X, int Y, int IconId) { Invoke(nameof(DropMakerOnMap), X, Y, IconId); }
        public void DismantleSlotV2(Object SlotId, int Count) { Invoke(nameof(DismantleSlotV2), SlotId, Count); }
        public void DismantleSlot(Object SlotId, Vector WorldPosition) { Invoke(nameof(DismantleSlot), SlotId, WorldPosition); }
        public void DiscardSlot(Object SlotId) { Invoke(nameof(DiscardSlot), SlotId); }
        public void DiscardItem(int ItemId, int Count, EContainerType ContainerType, bool bForced) { Invoke(nameof(DiscardItem), ItemId, Count, ContainerType, bForced); }
        public void CraftSuccessClient(int RecipeId) { Invoke(nameof(CraftSuccessClient), RecipeId); }
        public void CraftRecipeAmount(int RecipeId, int Amount) { Invoke(nameof(CraftRecipeAmount), RecipeId, Amount); }
        public void CollectItem(int ItemId, int Count) { Invoke(nameof(CollectItem), ItemId, Count); }
        public void CollectContainer(ContainerEntityModel Container) { Invoke(nameof(CollectContainer), Container); }
        public void CloseUI() { Invoke(nameof(CloseUI)); }
        public void CloseFillContainerUI(Object ContainerId) { Invoke(nameof(CloseFillContainerUI), ContainerId); }
        public void ClientWasBanned() { Invoke(nameof(ClientWasBanned)); }
        public void ClientJoinVoice(Object RoomId) { Invoke(nameof(ClientJoinVoice), RoomId); }
        public void ClearAllDroppedLoot() { Invoke(nameof(ClearAllDroppedLoot)); }
        public void CheatActivateShrines() { Invoke(nameof(CheatActivateShrines)); }
        public void CharacterShieldBlockClient() { Invoke(nameof(CharacterShieldBlockClient)); }
        public bool CanCraftRecipe(CraftingRecipeDataModel Recipe, int Amount) { return Invoke<bool>(nameof(CanCraftRecipe), Recipe, Amount); }
        public bool CanConstruct(ConstructionRecipeDataModel ConstructionRecipe) { return Invoke<bool>(nameof(CanConstruct), ConstructionRecipe); }
        public void BuildConstruction(int ConstructionRecipeId, Vector Location, Rotator Rotation, Vector Scale, bool BuildCorner, bool AlternativeElevation) { Invoke(nameof(BuildConstruction), ConstructionRecipeId, Location, Rotation, Scale, BuildCorner, AlternativeElevation); }
        public void BanPlayer(Object PlayerId, Object BanReason) { Invoke(nameof(BanPlayer), PlayerId, BanReason); }
        public void AllShrineActivatedClient() { Invoke(nameof(AllShrineActivatedClient)); }
        public void AlertNotEnoughSkillPoint() { Invoke(nameof(AlertNotEnoughSkillPoint)); }
        public void AlertInventoryFull() { Invoke(nameof(AlertInventoryFull)); }
        public void AddXPServer(int XpToAdd) { Invoke(nameof(AddXPServer), XpToAdd); }
        public void AddRecipeToWishlist(int RecipeId) { Invoke(nameof(AddRecipeToWishlist), RecipeId); }
    }
    public class TOMPlayerState : BifrostPlayerState
    {
        public TOMPlayerState(ulong addr) : base(addr) { }
        public Object OnSendPingCommand { get { return this[nameof(OnSendPingCommand)]; } set { this[nameof(OnSendPingCommand)] = value; } }
        public Object OnQuestChange { get { return this[nameof(OnQuestChange)]; } set { this[nameof(OnQuestChange)] = value; } }
        public Object OnQuestListChange { get { return this[nameof(OnQuestListChange)]; } set { this[nameof(OnQuestListChange)] = value; } }
        public Object PlatformInputEffectsManagerClass { get { return this[nameof(PlatformInputEffectsManagerClass)]; } set { this[nameof(PlatformInputEffectsManagerClass)] = value; } }
        public UserEntityModel UserEntityModel { get { return this[nameof(UserEntityModel)].As<UserEntityModel>(); } set { this["UserEntityModel"] = value; } }
        public WorldPlayerEntityModel WorldPlayerEntityModel { get { return this[nameof(WorldPlayerEntityModel)].As<WorldPlayerEntityModel>(); } set { this["WorldPlayerEntityModel"] = value; } }
        public InputEffectsManager InputEffectsManager { get { return this[nameof(InputEffectsManager)].As<InputEffectsManager>(); } set { this["InputEffectsManager"] = value; } }
        public TOMPlayerState_RepProperties PlayerStateRepProperties { get { return this[nameof(PlayerStateRepProperties)].As<TOMPlayerState_RepProperties>(); } set { this["PlayerStateRepProperties"] = value; } }
        public Array<QuestVO> PlayerQuestVOs { get { return new Array<QuestVO>(this[nameof(PlayerQuestVOs)].Address); } }
        public QuestVO CurrentSagaQuest { get { return this[nameof(CurrentSagaQuest)].As<QuestVO>(); } set { this["CurrentSagaQuest"] = value; } }
        public void UpdatePlayerQuests(Array<QuestVO> InPlayerQuestVOs) { Invoke(nameof(UpdatePlayerQuests), InPlayerQuestVOs); }
        public void UpdatePlayerQuest(QuestVO InPlayerQuestVO) { Invoke(nameof(UpdatePlayerQuest), InPlayerQuestVO); }
        public void RemovePlayerQuest(Object QuestId) { Invoke(nameof(RemovePlayerQuest), QuestId); }
        public void OnWorldPlayerEntityModelChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnWorldPlayerEntityModelChanged), Entity, Context); }
        public void OnUserEntityModelChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnUserEntityModelChanged), Entity, Context); }
        public void OnSkillChanged() { Invoke(nameof(OnSkillChanged)); }
        public void OnRep_Properties() { Invoke(nameof(OnRep_Properties)); }
        public void OnRep_PlayerQuest() { Invoke(nameof(OnRep_PlayerQuest)); }
        public void NotifySoulsSpent(int quantity) { Invoke(nameof(NotifySoulsSpent), quantity); }
        public void NotifySagaQuestChanged(QuestVO Quest) { Invoke(nameof(NotifySagaQuestChanged), Quest); }
        public void NotifyQuestChanged(QuestVO Quest) { Invoke(nameof(NotifyQuestChanged), Quest); }
        public void NotifyPingCommand(Object UserId, int CommandId) { Invoke(nameof(NotifyPingCommand), UserId, CommandId); }
        public WorldPlayerEntityModel GetWorldPlayerEntityModel() { return Invoke<WorldPlayerEntityModel>(nameof(GetWorldPlayerEntityModel)); }
        public UserEntityModel GetUserEntityModel() { return Invoke<UserEntityModel>(nameof(GetUserEntityModel)); }
        public QuestVO GetQuest(int QuestId) { return Invoke<QuestVO>(nameof(GetQuest), QuestId); }
        public Array<QuestVO> GetLocalQuests() { return Invoke<Array<QuestVO>>(nameof(GetLocalQuests)); }
        public bool GetIsReady() { return Invoke<bool>(nameof(GetIsReady)); }
        public ContainerSlotItemEntityModel GetCurrentWeapon() { return Invoke<ContainerSlotItemEntityModel>(nameof(GetCurrentWeapon)); }
        public ContainerSlotItemEntityModel GetCurrentShield() { return Invoke<ContainerSlotItemEntityModel>(nameof(GetCurrentShield)); }
        public QuestVO GetCurrentSagaQuest() { return Invoke<QuestVO>(nameof(GetCurrentSagaQuest)); }
        public Array<int> GetAvailableQuests() { return Invoke<Array<int>>(nameof(GetAvailableQuests)); }
    }
    public class TOMPooledObjectInterface : Interface
    {
        public TOMPooledObjectInterface(ulong addr) : base(addr) { }
    }
    public class TOMServiceLocator : Object
    {
        public TOMServiceLocator(ulong addr) : base(addr) { }
        public Actor GetYggdrasilActor(Object WorldContextObject) { return Invoke<Actor>(nameof(GetYggdrasilActor), WorldContextObject); }
        public WorldMapManager GetWorldMapManager(Object WorldContextObject) { return Invoke<WorldMapManager>(nameof(GetWorldMapManager), WorldContextObject); }
        public WorldEntityModel GetWorldEntityModel() { return Invoke<WorldEntityModel>(nameof(GetWorldEntityModel)); }
        public VFXSpawnManager GetVFXManager(Object WorldContextObject) { return Invoke<VFXSpawnManager>(nameof(GetVFXManager), WorldContextObject); }
        public UserWidgetNavigation GetUserWidgetNavigation() { return Invoke<UserWidgetNavigation>(nameof(GetUserWidgetNavigation)); }
        public UserEntityModel GetUserEntityModel() { return Invoke<UserEntityModel>(nameof(GetUserEntityModel)); }
        public UpgradeManager GetUpgradeManager(Object WorldContextObject) { return Invoke<UpgradeManager>(nameof(GetUpgradeManager), WorldContextObject); }
        public TimeManager GetTimeManager(Object WorldContextObject) { return Invoke<TimeManager>(nameof(GetTimeManager), WorldContextObject); }
        public TickManager GetTickManager() { return Invoke<TickManager>(nameof(GetTickManager)); }
        public StreamingManager GetStreamingManager() { return Invoke<StreamingManager>(nameof(GetStreamingManager)); }
        public SpawningManager GetSpawningManager(Object WorldContextObject) { return Invoke<SpawningManager>(nameof(GetSpawningManager), WorldContextObject); }
        public SettingsSave GetSettings() { return Invoke<SettingsSave>(nameof(GetSettings)); }
        public RespawnableManager GetRespawnableManager(Object WorldContextObject) { return Invoke<RespawnableManager>(nameof(GetRespawnableManager), WorldContextObject); }
        public QuestManager GetQuestManager() { return Invoke<QuestManager>(nameof(GetQuestManager)); }
        public PostProcessManager GetPostProcessManager() { return Invoke<PostProcessManager>(nameof(GetPostProcessManager)); }
        public PlayerLootManager GetPlayerLootManager(Object WorldContextObject) { return Invoke<PlayerLootManager>(nameof(GetPlayerLootManager), WorldContextObject); }
        public TOMNotificationManager GetNotificationManager() { return Invoke<TOMNotificationManager>(nameof(GetNotificationManager)); }
        public MinionWaveManager GetMinionWaveManager(Object WorldContextObject) { return Invoke<MinionWaveManager>(nameof(GetMinionWaveManager), WorldContextObject); }
        public MetaMovementManager GetMetaMovementManager(Object WorldContextObject) { return Invoke<MetaMovementManager>(nameof(GetMetaMovementManager), WorldContextObject); }
        public MaterialManager GetMaterialManager() { return Invoke<MaterialManager>(nameof(GetMaterialManager)); }
        public TOMLobbyDataModel GetLobbyDataModel() { return Invoke<TOMLobbyDataModel>(nameof(GetLobbyDataModel)); }
        public InstancedMeshManager GetInstancedMeshManager() { return Invoke<InstancedMeshManager>(nameof(GetInstancedMeshManager)); }
        public InputEffectsManager GetInputEffectsManager() { return Invoke<InputEffectsManager>(nameof(GetInputEffectsManager)); }
        public IconManager GetIconManager() { return Invoke<IconManager>(nameof(GetIconManager)); }
        public GiantManager GetGiantManager(Object WorldContextObject) { return Invoke<GiantManager>(nameof(GetGiantManager), WorldContextObject); }
        public GenerationManager GetGenerationManager() { return Invoke<GenerationManager>(nameof(GetGenerationManager)); }
        public GameSessionData GetGameSessionData() { return Invoke<GameSessionData>(nameof(GetGameSessionData)); }
        public GameEventManager GetGameEventManager() { return Invoke<GameEventManager>(nameof(GetGameEventManager)); }
        public GameDataModel GetGameDataModel() { return Invoke<GameDataModel>(nameof(GetGameDataModel)); }
        public ExtractorManager GetExtractorManager(Object WorldContextObject) { return Invoke<ExtractorManager>(nameof(GetExtractorManager), WorldContextObject); }
        public EntitiesManager GetEntitiesManager() { return Invoke<EntitiesManager>(nameof(GetEntitiesManager)); }
        public ConstructionManager GetConstructionManager() { return Invoke<ConstructionManager>(nameof(GetConstructionManager)); }
        public CharacterFloatingUIManager GetCharacterFloatingUIManager() { return Invoke<CharacterFloatingUIManager>(nameof(GetCharacterFloatingUIManager)); }
        public ChallengeManager GetChallengeManager() { return Invoke<ChallengeManager>(nameof(GetChallengeManager)); }
        public CaveManager GetCaveManager() { return Invoke<CaveManager>(nameof(GetCaveManager)); }
        public BushMovementManager GetBushMovementManager() { return Invoke<BushMovementManager>(nameof(GetBushMovementManager)); }
        public BifrostManager GetBifrostManager(Object WorldContextObject) { return Invoke<BifrostManager>(nameof(GetBifrostManager), WorldContextObject); }
        public AudioManager GetAudioManager() { return Invoke<AudioManager>(nameof(GetAudioManager)); }
        public AnalyticsManager GetAnalyticsManager() { return Invoke<AnalyticsManager>(nameof(GetAnalyticsManager)); }
        public AchievementsManager GetAchievementsManager() { return Invoke<AchievementsManager>(nameof(GetAchievementsManager)); }
    }
    public class TOMSpectatorPawn : SpectatorPawn
    {
        public TOMSpectatorPawn(ulong addr) : base(addr) { }
        public void SendPositionToServer(Vector Position, Rotator Rotation) { Invoke(nameof(SendPositionToServer), Position, Rotation); }
    }
    public class TOMWorldData : Object
    {
        public TOMWorldData(ulong addr) : base(addr) { }
        public Layout Layout { get { return this[nameof(Layout)].As<Layout>(); } set { this["Layout"] = value; } }
        public Array<RegionData> Regions { get { return new Array<RegionData>(this[nameof(Regions)].Address); } }
        public Array<ModuleData> Modules { get { return new Array<ModuleData>(this[nameof(Modules)].Address); } }
        public Object Ramps { get { return this[nameof(Ramps)]; } set { this[nameof(Ramps)] = value; } }
        public Object Traps { get { return this[nameof(Traps)]; } set { this[nameof(Traps)] = value; } }
        public Object Bridges { get { return this[nameof(Bridges)]; } set { this[nameof(Bridges)] = value; } }
    }
    public class ToolBase : TOMEquipmentBase
    {
        public ToolBase(ulong addr) : base(addr) { }
    }
    public class TrackedEntityComponent : TOMActorComponent
    {
        public TrackedEntityComponent(ulong addr) : base(addr) { }
        public Object OnChangeChunk { get { return this[nameof(OnChangeChunk)]; } set { this[nameof(OnChangeChunk)] = value; } }
        public Object OnChangeBiome { get { return this[nameof(OnChangeBiome)]; } set { this[nameof(OnChangeBiome)] = value; } }
        public Object OnChangeBeingOnRoad { get { return this[nameof(OnChangeBeingOnRoad)]; } set { this[nameof(OnChangeBeingOnRoad)] = value; } }
        public Object OnChangeBiomeLevel { get { return this[nameof(OnChangeBiomeLevel)]; } set { this[nameof(OnChangeBiomeLevel)] = value; } }
        public IntPoint CurrentChunkCoord { get { return this[nameof(CurrentChunkCoord)].As<IntPoint>(); } set { this["CurrentChunkCoord"] = value; } }
        public bool bIsPaused { get { return this[nameof(bIsPaused)].Flag; } set { this[nameof(bIsPaused)].Flag = value; } }
        public float TickInterval { get { return this[nameof(TickInterval)].GetValue<float>(); } set { this[nameof(TickInterval)].SetValue<float>(value); } }
        public bool bIsBiomeTracking { get { return this[nameof(bIsBiomeTracking)].Flag; } set { this[nameof(bIsBiomeTracking)].Flag = value; } }
        public bool bIsRoadTracking { get { return this[nameof(bIsRoadTracking)].Flag; } set { this[nameof(bIsRoadTracking)].Flag = value; } }
        public int CurrentBiomeId { get { return this[nameof(CurrentBiomeId)].GetValue<int>(); } set { this[nameof(CurrentBiomeId)].SetValue<int>(value); } }
        public int CurrentBiomeLevel { get { return this[nameof(CurrentBiomeLevel)].GetValue<int>(); } set { this[nameof(CurrentBiomeLevel)].SetValue<int>(value); } }
        public bool bIsOnRoad { get { return this[nameof(bIsOnRoad)].Flag; } set { this[nameof(bIsOnRoad)].Flag = value; } }
        public GenerationManager GenerationManager { get { return this[nameof(GenerationManager)].As<GenerationManager>(); } set { this["GenerationManager"] = value; } }
        public Array<Vector> Path { get { return new Array<Vector>(this[nameof(Path)].Address); } }
        public void StopPathTracking() { Invoke(nameof(StopPathTracking)); }
        public void StartPathTracking() { Invoke(nameof(StartPathTracking)); }
        public void SetPause(bool InPaused) { Invoke(nameof(SetPause), InPaused); }
        public void ResetPath() { Invoke(nameof(ResetPath)); }
        public void RemovePathLastPoint() { Invoke(nameof(RemovePathLastPoint)); }
        public Array<Vector> GetReturnPath() { return Invoke<Array<Vector>>(nameof(GetReturnPath)); }
        public Vector GetPathLastPoint() { return Invoke<Vector>(nameof(GetPathLastPoint)); }
        public int GetCurrentBiomeLevel() { return Invoke<int>(nameof(GetCurrentBiomeLevel)); }
        public int GetCurrentBiomeId() { return Invoke<int>(nameof(GetCurrentBiomeId)); }
        public bool CheckPosition() { return Invoke<bool>(nameof(CheckPosition)); }
    }
    public class TriggerWaypoint : Actor
    {
        public TriggerWaypoint(ulong addr) : base(addr) { }
        public SphereComponent TriggerCollision { get { return this[nameof(TriggerCollision)].As<SphereComponent>(); } set { this["TriggerCollision"] = value; } }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public int Target { get { return this[nameof(Target)].GetValue<int>(); } set { this[nameof(Target)].SetValue<int>(value); } }
    }
    public class TutorialLevelScriptActor : GameLevelScriptActor
    {
        public TutorialLevelScriptActor(ulong addr) : base(addr) { }
        public TOMCharacter NPCHelper1 { get { return this[nameof(NPCHelper1)].As<TOMCharacter>(); } set { this["NPCHelper1"] = value; } }
        public TOMCharacter NPCHelper2 { get { return this[nameof(NPCHelper2)].As<TOMCharacter>(); } set { this["NPCHelper2"] = value; } }
        public Array<TriggerWaypoint> NPCHelper1Waypoints { get { return new Array<TriggerWaypoint>(this[nameof(NPCHelper1Waypoints)].Address); } }
        public Array<TriggerWaypoint> NPCHelper2Waypoints { get { return new Array<TriggerWaypoint>(this[nameof(NPCHelper2Waypoints)].Address); } }
        public TriggerWaypoint CharacterGiantWaypoints { get { return this[nameof(CharacterGiantWaypoints)].As<TriggerWaypoint>(); } set { this["CharacterGiantWaypoints"] = value; } }
        public TriggerWaypoint GiantSpawnPoint { get { return this[nameof(GiantSpawnPoint)].As<TriggerWaypoint>(); } set { this["GiantSpawnPoint"] = value; } }
        public Array<TriggerWaypoint> GiantWaypoints { get { return new Array<TriggerWaypoint>(this[nameof(GiantWaypoints)].Address); } }
        public Array<int> QuestIds { get { return new Array<int>(this[nameof(QuestIds)].Address); } }
        public Array<UpgradableHazardContainer> Gates { get { return new Array<UpgradableHazardContainer>(this[nameof(Gates)].Address); } }
        public YggdrasilBase Yggdrasil { get { return this[nameof(Yggdrasil)].As<YggdrasilBase>(); } set { this["Yggdrasil"] = value; } }
        public TOMCharacter Blacksmith { get { return this[nameof(Blacksmith)].As<TOMCharacter>(); } set { this["Blacksmith"] = value; } }
        public TOMCharacter Tinker { get { return this[nameof(Tinker)].As<TOMCharacter>(); } set { this["Tinker"] = value; } }
        public Array<WorldCreatureEntityModel> Creatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(Creatures)].Address); } }
        public Array<HazardEntityModel> Hazards { get { return new Array<HazardEntityModel>(this[nameof(Hazards)].Address); } }
        public void UpdateEnemyDetectionRadius(float Radius) { Invoke(nameof(UpdateEnemyDetectionRadius), Radius); }
        public void TutorialCompleteAnnouncement() { Invoke(nameof(TutorialCompleteAnnouncement)); }
        public void TriggerHelperQuestInteraction() { Invoke(nameof(TriggerHelperQuestInteraction)); }
        public void TeleportCharacter(Actor Waypoint) { Invoke(nameof(TeleportCharacter), Waypoint); }
        public void SpawnGiant(Actor SpawnPoint, int GiantId) { Invoke(nameof(SpawnGiant), SpawnPoint, GiantId); }
        public void ShowInfoSlideReader(int InfoSlideId) { Invoke(nameof(ShowInfoSlideReader), InfoSlideId); }
        public void SetYggdrasilInvincible(bool IsInvincible) { Invoke(nameof(SetYggdrasilInvincible), IsInvincible); }
        public void SetPlayerInvincible(bool IsInvincible) { Invoke(nameof(SetPlayerInvincible), IsInvincible); }
        public void PlayTeleportVFX() { Invoke(nameof(PlayTeleportVFX)); }
        public void OpenCloseGate(HazardBase GateHazard, bool bOpen) { Invoke(nameof(OpenCloseGate), GateHazard, bOpen); }
        public void OnTimeLerpFinished() { Invoke(nameof(OnTimeLerpFinished)); }
        public void OnQuestStart(QuestEntityModel QuestEntityModel) { Invoke(nameof(OnQuestStart), QuestEntityModel); }
        public void OnQuestComplete(QuestEntityModel QuestEntityModel) { Invoke(nameof(OnQuestComplete), QuestEntityModel); }
        public void OnGiantDeath() { Invoke(nameof(OnGiantDeath)); }
        public void OnDayStart() { Invoke(nameof(OnDayStart)); }
        public void OnCloseInfoSlideReader() { Invoke(nameof(OnCloseInfoSlideReader)); }
        public void OnBifrostConfirm() { Invoke(nameof(OnBifrostConfirm)); }
        public void LeaveTutorial() { Invoke(nameof(LeaveTutorial)); }
        public void InitializeTinker() { Invoke(nameof(InitializeTinker)); }
        public void InitializeHelpers() { Invoke(nameof(InitializeHelpers)); }
        public void InitializeBlacksmith() { Invoke(nameof(InitializeBlacksmith)); }
        public void HelpersMoveToIndexWaypoint(int Index, bool bIsTeleported) { Invoke(nameof(HelpersMoveToIndexWaypoint), Index, bIsTeleported); }
        public void FadeToBlack(bool bFadeIn) { Invoke(nameof(FadeToBlack), bFadeIn); }
        public void FadeOutOfBlack() { Invoke(nameof(FadeOutOfBlack)); }
        public void EnableYggdrasilSoulInteractible(YggdrasilBase YggdrasilBase, bool bEnable) { Invoke(nameof(EnableYggdrasilSoulInteractible), YggdrasilBase, bEnable); }
        public void EnableTinkerCrafting(bool bEnable) { Invoke(nameof(EnableTinkerCrafting), bEnable); }
        public void EnableIronNodesInteraction(bool bEnable) { Invoke(nameof(EnableIronNodesInteraction), bEnable); }
        public void EnableHelperQuestsInteractible(bool bEnable) { Invoke(nameof(EnableHelperQuestsInteractible), bEnable); }
        public void EnableBlacksmithCrafting(bool bEnable) { Invoke(nameof(EnableBlacksmithCrafting), bEnable); }
        public void EnableBifrostUse(bool bEnable) { Invoke(nameof(EnableBifrostUse), bEnable); }
        public void DisplayPersonalQuest(bool bIsDisplay) { Invoke(nameof(DisplayPersonalQuest), bIsDisplay); }
        public void DisableWatchtowerInteractible(HazardBase WatchtowerHazard) { Invoke(nameof(DisableWatchtowerInteractible), WatchtowerHazard); }
        public void DisableVillageUpgradeInteractible(TOMCharacter TOMCharacter) { Invoke(nameof(DisableVillageUpgradeInteractible), TOMCharacter); }
        public void DisableShrineInteractible() { Invoke(nameof(DisableShrineInteractible)); }
        public void DisableMapIconsAndInteractionForUnusedInteractables() { Invoke(nameof(DisableMapIconsAndInteractionForUnusedInteractables)); }
        public void DisableGateInteractible(HazardBase GateHazard) { Invoke(nameof(DisableGateInteractible), GateHazard); }
        public void ClearSundialSeasonAndBloodmoonUI() { Invoke(nameof(ClearSundialSeasonAndBloodmoonUI)); }
        public void BindOnConfirmBifrost(bool bBind) { Invoke(nameof(BindOnConfirmBifrost), bBind); }
        public void AssignHelpersQuest(int NewQuestDataId) { Invoke(nameof(AssignHelpersQuest), NewQuestDataId); }
    }
    public class TutorialsManager : TOMActor
    {
        public TutorialsManager(ulong addr) : base(addr) { }
        public bool IsHandlingMouse { get { return this[nameof(IsHandlingMouse)].Flag; } set { this[nameof(IsHandlingMouse)].Flag = value; } }
    }
    public class UpgradableBuildingBase : TOMActor
    {
        public UpgradableBuildingBase(ulong addr) : base(addr) { }
        public ESellerType SellerType { get { return (ESellerType)this[nameof(SellerType)].GetValue<int>(); } set { this[nameof(SellerType)].SetValue<int>((int)value); } }
        public int FirstUpgradeId { get { return this[nameof(FirstUpgradeId)].GetValue<int>(); } set { this[nameof(FirstUpgradeId)].SetValue<int>(value); } }
        public UpgradeEntityModel UpgradeEntityModel { get { return this[nameof(UpgradeEntityModel)].As<UpgradeEntityModel>(); } set { this["UpgradeEntityModel"] = value; } }
        public int CurrentLevel { get { return this[nameof(CurrentLevel)].GetValue<int>(); } set { this[nameof(CurrentLevel)].SetValue<int>(value); } }
        public void Refresh() { Invoke(nameof(Refresh)); }
        public void OnUpgradeLevelUp(Object UpgradeId, Object OldContainerId) { Invoke(nameof(OnUpgradeLevelUp), UpgradeId, OldContainerId); }
        public void OnRep_CurrentLevel() { Invoke(nameof(OnRep_CurrentLevel)); }
    }
    public class UpgradableBuildingVillage : UpgradableBuildingBase
    {
        public UpgradableBuildingVillage(ulong addr) : base(addr) { }
        public Object BuildingClassPerLevel { get { return this[nameof(BuildingClassPerLevel)]; } set { this[nameof(BuildingClassPerLevel)] = value; } }
        public SceneComponent Root { get { return this[nameof(Root)].As<SceneComponent>(); } set { this["Root"] = value; } }
        public SceneComponent BuildingAnchor { get { return this[nameof(BuildingAnchor)].As<SceneComponent>(); } set { this["BuildingAnchor"] = value; } }
        public SceneComponent NPCAnchor { get { return this[nameof(NPCAnchor)].As<SceneComponent>(); } set { this["NPCAnchor"] = value; } }
        public Object AudioOnLevelUp { get { return this[nameof(AudioOnLevelUp)]; } set { this[nameof(AudioOnLevelUp)] = value; } }
        public Actor CurrentBuilding { get { return this[nameof(CurrentBuilding)].As<Actor>(); } set { this["CurrentBuilding"] = value; } }
        public WorldCreatureEntityModel NPCEntity { get { return this[nameof(NPCEntity)].As<WorldCreatureEntityModel>(); } set { this["NPCEntity"] = value; } }
        public void OnUgradeLevelUpMulticast(Object UpgradeContainerId) { Invoke(nameof(OnUgradeLevelUpMulticast), UpgradeContainerId); }
    }
    public class UpgradableHazardContainer : HazardBase
    {
        public UpgradableHazardContainer(ulong addr) : base(addr) { }
        public SceneComponent Root { get { return this[nameof(Root)].As<SceneComponent>(); } set { this["Root"] = value; } }
        public int FirstUpgradeId { get { return this[nameof(FirstUpgradeId)].GetValue<int>(); } set { this[nameof(FirstUpgradeId)].SetValue<int>(value); } }
        public UpgradeEntityModel UpgradeEntityModel { get { return this[nameof(UpgradeEntityModel)].As<UpgradeEntityModel>(); } set { this["UpgradeEntityModel"] = value; } }
        public Vector RepositionLocation { get { return this[nameof(RepositionLocation)].As<Vector>(); } set { this["RepositionLocation"] = value; } }
        public int CurrentLevel { get { return this[nameof(CurrentLevel)].GetValue<int>(); } set { this[nameof(CurrentLevel)].SetValue<int>(value); } }
        public HazardEntityModel CurrentHazardEntityModel { get { return this[nameof(CurrentHazardEntityModel)].As<HazardEntityModel>(); } set { this["CurrentHazardEntityModel"] = value; } }
        public HazardBase CurrentHazard { get { return this[nameof(CurrentHazard)].As<HazardBase>(); } set { this["CurrentHazard"] = value; } }
        public void Refresh() { Invoke(nameof(Refresh)); }
        public void OnUpgradeLevelUp(Object UpgradeId, Object OldContainerId) { Invoke(nameof(OnUpgradeLevelUp), UpgradeId, OldContainerId); }
        public void OnUgradeLevelUpMulticast(Object UpgradeContainerId) { Invoke(nameof(OnUgradeLevelUpMulticast), UpgradeContainerId); }
        public void OnRepChildHazardHealthComponentRepProperties(HealthComponent healtComp, float Health, float NormalizedHealth) { Invoke(nameof(OnRepChildHazardHealthComponentRepProperties), healtComp, Health, NormalizedHealth); }
        public void OnRep_CurrentLevel() { Invoke(nameof(OnRep_CurrentLevel)); }
        public UpgradeEntityModel GetUpgradeEntityModel() { return Invoke<UpgradeEntityModel>(nameof(GetUpgradeEntityModel)); }
        public int GetCurrentLevel() { return Invoke<int>(nameof(GetCurrentLevel)); }
        public HazardBase GetCurrentHazard() { return Invoke<HazardBase>(nameof(GetCurrentHazard)); }
    }
    public class UpgradeEntityModel : EntityModelBase
    {
        public UpgradeEntityModel(ulong addr) : base(addr) { }
        public Object OnUpgradeLevelUp { get { return this[nameof(OnUpgradeLevelUp)]; } set { this[nameof(OnUpgradeLevelUp)] = value; } }
        public UpgradeVO VO { get { return this[nameof(VO)].As<UpgradeVO>(); } set { this["VO"] = value; } }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public void OnContainerChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerChanged), Entity, Context); }
        public bool IsMaxLevel() { return Invoke<bool>(nameof(IsMaxLevel)); }
        public UpgradeDataModel GetUpgradeData() { return Invoke<UpgradeDataModel>(nameof(GetUpgradeData)); }
        public UpgradeDataModel GetPreviousUpgradeDataOfLevel(int Level, int LevelZeroUpgradeDataId) { return Invoke<UpgradeDataModel>(nameof(GetPreviousUpgradeDataOfLevel), Level, LevelZeroUpgradeDataId); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public UpgradeDataModel GetHighestCompletedUpgradeData() { return Invoke<UpgradeDataModel>(nameof(GetHighestCompletedUpgradeData)); }
        public ContainerEntityModel GetContainer() { return Invoke<ContainerEntityModel>(nameof(GetContainer)); }
        public void ChangeUpgradeId(int NewUpgradeDataId) { Invoke(nameof(ChangeUpgradeId), NewUpgradeDataId); }
        public void ChangeHighestCompletedUpgradeId(int NewHighestCompletedUpgradeDataId, bool IsUpgrading) { Invoke(nameof(ChangeHighestCompletedUpgradeId), NewHighestCompletedUpgradeDataId, IsUpgrading); }
    }
    public class UpgradeManager : TOMActor
    {
        public UpgradeManager(ulong addr) : base(addr) { }
        public Array<UpgradeVO> Upgrades { get { return new Array<UpgradeVO>(this[nameof(Upgrades)].Address); } }
        public UpgradeEntityModel RegisterUpgrade(Object EntityId, int UpgradeDataId) { return Invoke<UpgradeEntityModel>(nameof(RegisterUpgrade), EntityId, UpgradeDataId); }
        public void OnUpgradeChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnUpgradeChanged), Entity, Context); }
        public void OnRep_Upgrades() { Invoke(nameof(OnRep_Upgrades)); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public int GetUpgradeLevelBySellerType(ESellerType SellerType) { return Invoke<int>(nameof(GetUpgradeLevelBySellerType), SellerType); }
        public UpgradeEntityModel GetUpgradeById(Object UpgradeId) { return Invoke<UpgradeEntityModel>(nameof(GetUpgradeById), UpgradeId); }
    }
    public class UserAvatarEntityModel : EntityModelBase
    {
        public UserAvatarEntityModel(ulong addr) : base(addr) { }
        public void UpdateFromVO(UserAvatarVO InVO) { Invoke(nameof(UpdateFromVO), InVO); }
        public void SetTransmogs(Array<int> InTransmogs) { Invoke(nameof(SetTransmogs), InTransmogs); }
        public void SetStarterKit(int InStarterKit) { Invoke(nameof(SetStarterKit), InStarterKit); }
        public void SetIconId(int IconId) { Invoke(nameof(SetIconId), IconId); }
        public void SetEmotes(Array<int> emoteIds) { Invoke(nameof(SetEmotes), emoteIds); }
        public void SetCommands(Array<int> commandsIds) { Invoke(nameof(SetCommands), commandsIds); }
        public bool IsTransmogEquipped(int TransmogId) { return Invoke<bool>(nameof(IsTransmogEquipped), TransmogId); }
        public CharacterDataModel GetStaticData() { return Invoke<CharacterDataModel>(nameof(GetStaticData)); }
        public AvatarCosmeticDataModel GetSkinTone() { return Invoke<AvatarCosmeticDataModel>(nameof(GetSkinTone)); }
        public AvatarPetDataModel GetPet() { return Invoke<AvatarPetDataModel>(nameof(GetPet)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public AvatarIconDataModel GetIcon() { return Invoke<AvatarIconDataModel>(nameof(GetIcon)); }
        public AvatarCosmeticDataModel GetHead() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHead)); }
        public AvatarCosmeticDataModel GetHaircut() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHaircut)); }
        public AvatarCosmeticDataModel GetHairColor() { return Invoke<AvatarCosmeticDataModel>(nameof(GetHairColor)); }
        public EGender GetGender() { return Invoke<EGender>(nameof(GetGender)); }
        public TransmogDataModel GetEquippedTransmogForItemType(int ItemTypeId) { return Invoke<TransmogDataModel>(nameof(GetEquippedTransmogForItemType), ItemTypeId); }
        public Object GetEmotes() { return Invoke<Object>(nameof(GetEmotes)); }
        public StarterKitDataModel GetCurrentStarterKit() { return Invoke<StarterKitDataModel>(nameof(GetCurrentStarterKit)); }
        public Object GetCommands() { return Invoke<Object>(nameof(GetCommands)); }
        public int GetAvatarCosmeticIconId() { return Invoke<int>(nameof(GetAvatarCosmeticIconId)); }
        public UserAvatarEntityModel CreateFromVO(Object Outer, UserAvatarVO InVO) { return Invoke<UserAvatarEntityModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class UserEntityModel : EntityModelBase
    {
        public UserEntityModel(ulong addr) : base(addr) { }
        public Object OnUserDataChanged { get { return this[nameof(OnUserDataChanged)]; } set { this[nameof(OnUserDataChanged)] = value; } }
        public Object OnUserWorldsRefreshed { get { return this[nameof(OnUserWorldsRefreshed)]; } set { this[nameof(OnUserWorldsRefreshed)] = value; } }
        public Object OnUserBlueprintsChanged { get { return this[nameof(OnUserBlueprintsChanged)]; } set { this[nameof(OnUserBlueprintsChanged)] = value; } }
        public Object OnUserCurrencyChanged { get { return this[nameof(OnUserCurrencyChanged)]; } set { this[nameof(OnUserCurrencyChanged)] = value; } }
        public Object OnChallengeClaimed { get { return this[nameof(OnChallengeClaimed)]; } set { this[nameof(OnChallengeClaimed)] = value; } }
        public EventRequest ClaimChallengeRequest { get { return this[nameof(ClaimChallengeRequest)].As<EventRequest>(); } set { this["ClaimChallengeRequest"] = value; } }
        public UserAvatarEntityModel Avatar { get { return this[nameof(Avatar)].As<UserAvatarEntityModel>(); } set { this["Avatar"] = value; } }
        public EventRequest RefreshUserWorldsEventRequest { get { return this[nameof(RefreshUserWorldsEventRequest)].As<EventRequest>(); } set { this["RefreshUserWorldsEventRequest"] = value; } }
        public EventRequest SaveUserDataEventRequest { get { return this[nameof(SaveUserDataEventRequest)].As<EventRequest>(); } set { this["SaveUserDataEventRequest"] = value; } }
        public void UserDataChanged() { Invoke(nameof(UserDataChanged)); }
        public void UpdateFromVO(UserVO InVO, Object Context) { Invoke(nameof(UpdateFromVO), InVO, Context); }
        public void UpdateContentBundles(Array<int> ContentBundles) { Invoke(nameof(UpdateContentBundles), ContentBundles); }
        public UserVO ToVO() { return Invoke<UserVO>(nameof(ToVO)); }
        public void SetUserDataProp(Object TargetField, int TargetValue, bool FlagDirty) { Invoke(nameof(SetUserDataProp), TargetField, TargetValue, FlagDirty); }
        public void SetSurvivedDaysInSeason(int DayCount) { Invoke(nameof(SetSurvivedDaysInSeason), DayCount); }
        public void SetSurvivedDaysInEndless(int DayCount) { Invoke(nameof(SetSurvivedDaysInEndless), DayCount); }
        public void SetSkillClassMaxed(ESkillClass SkillClass) { Invoke(nameof(SetSkillClassMaxed), SkillClass); }
        public void SetMaxSoulCount(int NewCount) { Invoke(nameof(SetMaxSoulCount), NewCount); }
        public void SetHasSeenTutorial(bool Value) { Invoke(nameof(SetHasSeenTutorial), Value); }
        public void SetHasCompletedTutorial() { Invoke(nameof(SetHasCompletedTutorial)); }
        public void SetGiantKilled(EEquipmentElement GiantElement) { Invoke(nameof(SetGiantKilled), GiantElement); }
        public void SetCurrency(int Value, ECurrencyType Type) { Invoke(nameof(SetCurrency), Value, Type); }
        public void SetCraftItem(EItemRarity Rarity) { Invoke(nameof(SetCraftItem), Rarity); }
        public void SaveUserData() { Invoke(nameof(SaveUserData)); }
        public void ResetUserData() { Invoke(nameof(ResetUserData)); }
        public void RegisterGiantDeathInSession(int GiantKillCount) { Invoke(nameof(RegisterGiantDeathInSession), GiantKillCount); }
        public void RegisterCreatureKill() { Invoke(nameof(RegisterCreatureKill)); }
        public void RegisterBlock() { Invoke(nameof(RegisterBlock)); }
        public void RefreshUserWorlds() { Invoke(nameof(RefreshUserWorlds)); }
        public void OnUserWorldsReceived(ServerResponse Response) { Invoke(nameof(OnUserWorldsReceived), Response); }
        public void OnSaveUserDataSuccess(ServerResponse Response) { Invoke(nameof(OnSaveUserDataSuccess), Response); }
        public void OnSaveUserDataError(ServerResponse Response) { Invoke(nameof(OnSaveUserDataError), Response); }
        public void OnClaimChallengeSucess(ServerResponse Response) { Invoke(nameof(OnClaimChallengeSucess), Response); }
        public void OnClaimChallengeError(ServerResponse Response) { Invoke(nameof(OnClaimChallengeError), Response); }
        public bool IsCosmeticsPurchased(int cosmeticsId) { return Invoke<bool>(nameof(IsCosmeticsPurchased), cosmeticsId); }
        public bool IsBlueprintUnlocked(int BlueprintId) { return Invoke<bool>(nameof(IsBlueprintUnlocked), BlueprintId); }
        public void IncrementRevealedAllShrineCount() { Invoke(nameof(IncrementRevealedAllShrineCount)); }
        public void IncrementConstructionCount() { Invoke(nameof(IncrementConstructionCount)); }
        public void IncrementBifrostUseCount() { Invoke(nameof(IncrementBifrostUseCount)); }
        public void IncreaseSoulsSpent(int Increment) { Invoke(nameof(IncreaseSoulsSpent), Increment); }
        public bool HasEnoughCurrency(int Value, ECurrencyType Type) { return Invoke<bool>(nameof(HasEnoughCurrency), Value, Type); }
        public bool HasCompletedChallenge(int ChallengeId) { return Invoke<bool>(nameof(HasCompletedChallenge), ChallengeId); }
        public bool HasClaimedChallenge(int ChallengeId) { return Invoke<bool>(nameof(HasClaimedChallenge), ChallengeId); }
        public int GetXP() { return Invoke<int>(nameof(GetXP)); }
        public int GetVictoryPoints() { return Invoke<int>(nameof(GetVictoryPoints)); }
        public UserDataVO GetUserData() { return Invoke<UserDataVO>(nameof(GetUserData)); }
        public Array<int> GetUnlockedBlueprints() { return Invoke<Array<int>>(nameof(GetUnlockedBlueprints)); }
        public UserSaveSlots GetSaveSlots() { return Invoke<UserSaveSlots>(nameof(GetSaveSlots)); }
        public Array<int> GetPurchasedCosmetics() { return Invoke<Array<int>>(nameof(GetPurchasedCosmetics)); }
        public Array<int> GetOwnedEntitlements() { return Invoke<Array<int>>(nameof(GetOwnedEntitlements)); }
        public Object GetName() { return Invoke<Object>(nameof(GetName)); }
        public bool GetIsTutorialMode() { return Invoke<bool>(nameof(GetIsTutorialMode)); }
        public bool GetIsRecipeBlueprintComplete(int RecipeId, EBlueprintTypes BlueprintType) { return Invoke<bool>(nameof(GetIsRecipeBlueprintComplete), RecipeId, BlueprintType); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public bool GetHasCompletedTutorial() { return Invoke<bool>(nameof(GetHasCompletedTutorial)); }
        public int GetCurrentLevel() { return Invoke<int>(nameof(GetCurrentLevel)); }
        public Object GetCurrencyCode() { return Invoke<Object>(nameof(GetCurrencyCode)); }
        public int GetCurrencyByType(ECurrencyType Type) { return Invoke<int>(nameof(GetCurrencyByType), Type); }
        public int GetCurrency() { return Invoke<int>(nameof(GetCurrency)); }
        public UserAvatarEntityModel GetAvatar() { return Invoke<UserAvatarEntityModel>(nameof(GetAvatar)); }
        public bool DoesOwnEntitlement(int EntitlementID) { return Invoke<bool>(nameof(DoesOwnEntitlement), EntitlementID); }
        public void ClaimChallenge(int ChallengeId) { Invoke(nameof(ClaimChallenge), ChallengeId); }
        public void AddXP(int EarnedXP, int TotalXP) { Invoke(nameof(AddXP), EarnedXP, TotalXP); }
        public void AddUnlockedEntitlement(int EntitlementID) { Invoke(nameof(AddUnlockedEntitlement), EntitlementID); }
        public void AddUnlockedBlueprint(int BlueprintId) { Invoke(nameof(AddUnlockedBlueprint), BlueprintId); }
        public void AddPurchasedCosmetics(int newCosmetic) { Invoke(nameof(AddPurchasedCosmetics), newCosmetic); }
        public void AddCurrency(int Value, ECurrencyType Type) { Invoke(nameof(AddCurrency), Value, Type); }
        public void AddCurrency(int Value, int Type) { Invoke(nameof(AddCurrency), Value, Type); }
        public void AddContentBundle(int newBundle) { Invoke(nameof(AddContentBundle), newBundle); }
    }
    public class VFXSpawnManager : TOMActor
    {
        public VFXSpawnManager(ulong addr) : base(addr) { }
        public ParticleSystem FellInWaterParticleSystem { get { return this[nameof(FellInWaterParticleSystem)].As<ParticleSystem>(); } set { this["FellInWaterParticleSystem"] = value; } }
        public int KilledByWaterParticleSystemDepth { get { return this[nameof(KilledByWaterParticleSystemDepth)].GetValue<int>(); } set { this[nameof(KilledByWaterParticleSystemDepth)].SetValue<int>(value); } }
        public void SpawnVFXMulticast(Vector Location, Rotator Rotation, ParticleSystem Template) { Invoke(nameof(SpawnVFXMulticast), Location, Rotation, Template); }
        public void ShowPingCommand(Object PlayerId, int CommandId) { Invoke(nameof(ShowPingCommand), PlayerId, CommandId); }
        public void ShowGeneralAnnouncementMulticast(Object Message, EAnnouncementColor AnnouncementColor) { Invoke(nameof(ShowGeneralAnnouncementMulticast), Message, AnnouncementColor); }
        public void ShowGeneralAnnouncementByKeyMulticast(Object Key, EAnnouncementColor AnnouncementColor) { Invoke(nameof(ShowGeneralAnnouncementByKeyMulticast), Key, AnnouncementColor); }
        public void ShowGeneralAnnouncementByKey(Object Key, EAnnouncementColor AnnouncementColor) { Invoke(nameof(ShowGeneralAnnouncementByKey), Key, AnnouncementColor); }
        public void ShowGeneralAnnouncement(Object Message, EAnnouncementColor AnnouncementColor) { Invoke(nameof(ShowGeneralAnnouncement), Message, AnnouncementColor); }
        public void ShowGeneralAlertMulticast(Object Message, EAlertColor AlertColor) { Invoke(nameof(ShowGeneralAlertMulticast), Message, AlertColor); }
        public void PlaySFXMulticastAtLocation(Object AudioName, Vector Location) { Invoke(nameof(PlaySFXMulticastAtLocation), AudioName, Location); }
        public void PlaySFXMulticast(Object AudioName) { Invoke(nameof(PlaySFXMulticast), AudioName); }
        public void OnFellInWaterVFXMulticast(Vector Location) { Invoke(nameof(OnFellInWaterVFXMulticast), Location); }
    }
    public class VivoxGameInstanceSubsystem : GameInstanceSubsystem
    {
        public VivoxGameInstanceSubsystem(ulong addr) : base(addr) { }
        public Object OnVivoxTextMessageReceived { get { return this[nameof(OnVivoxTextMessageReceived)]; } set { this[nameof(OnVivoxTextMessageReceived)] = value; } }
        public Object OnVivoxParticipantChanged { get { return this[nameof(OnVivoxParticipantChanged)]; } set { this[nameof(OnVivoxParticipantChanged)] = value; } }
        public Object OnVivoxOnUnexpectedLoggout { get { return this[nameof(OnVivoxOnUnexpectedLoggout)]; } set { this[nameof(OnVivoxOnUnexpectedLoggout)] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
        public void Start(Object PlayerName, Object ChannelName) { Invoke(nameof(Start), PlayerName, ChannelName); }
        public void SetIsPushToTalk(bool Value) { Invoke(nameof(SetIsPushToTalk), Value); }
        public void SetAudioDevice(Object InputDeviceId, Object OutputDeviceId) { Invoke(nameof(SetAudioDevice), InputDeviceId, OutputDeviceId); }
        public void SendMessage(Object Message) { Invoke(nameof(SendMessage), Message); }
        public void PushToTalk(bool PTTKeyPressed) { Invoke(nameof(PushToTalk), PTTKeyPressed); }
        public void MutePlayerToggle(Object UserId) { Invoke(nameof(MutePlayerToggle), UserId); }
        public Array<VoiceDevice> ListAvailableAudioOutputDevices() { return Invoke<Array<VoiceDevice>>(nameof(ListAvailableAudioOutputDevices)); }
        public Array<VoiceDevice> ListAvailableAudioInputDevices() { return Invoke<Array<VoiceDevice>>(nameof(ListAvailableAudioInputDevices)); }
        public void Join(Object ChannelName) { Invoke(nameof(Join), ChannelName); }
        public bool IsLoggedIn() { return Invoke<bool>(nameof(IsLoggedIn)); }
        public void EnableVoiceChat(bool bIsEnabled) { Invoke(nameof(EnableVoiceChat), bIsEnabled); }
        public void ChangeOutputVolume(int VolumeIndex) { Invoke(nameof(ChangeOutputVolume), VolumeIndex); }
    }
    public class WeaponBase : TOMEquipmentBase
    {
        public WeaponBase(ulong addr) : base(addr) { }
        public void InitializeBlueprint(EEquipmentElement Element) { Invoke(nameof(InitializeBlueprint), Element); }
    }
    public class WindowsPlatformAuthenticationService : PlatformAuthenticationService
    {
        public WindowsPlatformAuthenticationService(ulong addr) : base(addr) { }
    }
    public class WorldAutomatonStep : Object
    {
        public WorldAutomatonStep(ulong addr) : base(addr) { }
    }
    public class WorldBeachesStep : Object
    {
        public WorldBeachesStep(ulong addr) : base(addr) { }
    }
    public class WorldBiomesStep : Object
    {
        public WorldBiomesStep(ulong addr) : base(addr) { }
    }
    public class WorldCharacterEntityModel : EntityModelBase
    {
        public WorldCharacterEntityModel(ulong addr) : base(addr) { }
        public void PreSaveUpdate(float InCooldown) { Invoke(nameof(PreSaveUpdate), InCooldown); }
        public ESellerType GetType() { return Invoke<ESellerType>(nameof(GetType)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public float GetCooldown() { return Invoke<float>(nameof(GetCooldown)); }
    }
    public class WorldContainerEntityModel : EntityModelBase
    {
        public WorldContainerEntityModel(ulong addr) : base(addr) { }
        public ContainerEntityModel Container { get { return this[nameof(Container)].As<ContainerEntityModel>(); } set { this["Container"] = value; } }
        public void OnContainerUpdate(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerUpdate), Entity, Context); }
        public int GetToolItemTypeId() { return Invoke<int>(nameof(GetToolItemTypeId)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public float GetHoldToOpenTimer() { return Invoke<float>(nameof(GetHoldToOpenTimer)); }
        public ContainerEntityModel GetContainer() { return Invoke<ContainerEntityModel>(nameof(GetContainer)); }
        public Object GetActionDisplayName() { return Invoke<Object>(nameof(GetActionDisplayName)); }
    }
    public class WorldCornerStatusStep : Object
    {
        public WorldCornerStatusStep(ulong addr) : base(addr) { }
    }
    public class WorldCreatureEntityModel : EntityModelBase
    {
        public WorldCreatureEntityModel(ulong addr) : base(addr) { }
        public Object OnCreatureRespawn { get { return this[nameof(OnCreatureRespawn)]; } set { this[nameof(OnCreatureRespawn)] = value; } }
        public Object OnNewMetaMovementWayPoint { get { return this[nameof(OnNewMetaMovementWayPoint)]; } set { this[nameof(OnNewMetaMovementWayPoint)] = value; } }
        public Object OnEndOfMetaMovement { get { return this[nameof(OnEndOfMetaMovement)]; } set { this[nameof(OnEndOfMetaMovement)] = value; } }
        public Object OnCreatureDied { get { return this[nameof(OnCreatureDied)]; } set { this[nameof(OnCreatureDied)] = value; } }
        public Array<Vector> MovementPath { get { return new Array<Vector>(this[nameof(MovementPath)].Address); } }
        public Vector CurrentMetaMovementWaypoint { get { return this[nameof(CurrentMetaMovementWaypoint)].As<Vector>(); } set { this["CurrentMetaMovementWaypoint"] = value; } }
        public Vector LastMetaMovementWaypoint { get { return this[nameof(LastMetaMovementWaypoint)].As<Vector>(); } set { this["LastMetaMovementWaypoint"] = value; } }
        public float MetaMovementLerpAlpha { get { return this[nameof(MetaMovementLerpAlpha)].GetValue<float>(); } set { this[nameof(MetaMovementLerpAlpha)].SetValue<float>(value); } }
        public float MetaMovementSpeed { get { return this[nameof(MetaMovementSpeed)].GetValue<float>(); } set { this[nameof(MetaMovementSpeed)].SetValue<float>(value); } }
        public bool IsControlledByMetaMovement { get { return this[nameof(IsControlledByMetaMovement)].Flag; } set { this[nameof(IsControlledByMetaMovement)].Flag = value; } }
        public bool bHasReceivedDamage { get { return this[nameof(bHasReceivedDamage)].Flag; } set { this[nameof(bHasReceivedDamage)].Flag = value; } }
        public TOMCharacter FollowTarget { get { return this[nameof(FollowTarget)].As<TOMCharacter>(); } set { this["FollowTarget"] = value; } }
        public TOMCharacter CharacterActor { get { return this[nameof(CharacterActor)].As<TOMCharacter>(); } set { this["CharacterActor"] = value; } }
        public Array<ContainerEntityModel> Containers { get { return new Array<ContainerEntityModel>(this[nameof(Containers)].Address); } }
        public ERespawnMode RespawnMode { get { return (ERespawnMode)this[nameof(RespawnMode)].GetValue<int>(); } set { this[nameof(RespawnMode)].SetValue<int>((int)value); } }
        public WorldCreatureVO ToVO() { return Invoke<WorldCreatureVO>(nameof(ToVO)); }
        public void SetHasReceivedDamage(bool InHasReceivedDamage) { Invoke(nameof(SetHasReceivedDamage), InHasReceivedDamage); }
        public void SetCharacterActor(TOMCharacter InCharacterActor) { Invoke(nameof(SetCharacterActor), InCharacterActor); }
        public void OnCreatureRespawnStatusChanged(bool bRespawned) { Invoke(nameof(OnCreatureRespawnStatusChanged), bRespawned); }
        public void OnContainerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerEntityChanged), Entity, Context); }
        public void OnCharacterActorDeath(TOMCharacter CharacterActor) { Invoke(nameof(OnCharacterActorDeath), CharacterActor); }
        public bool IsInPatrolRadius() { return Invoke<bool>(nameof(IsInPatrolRadius)); }
        public Vector GetSavedLocation() { return Invoke<Vector>(nameof(GetSavedLocation)); }
        public ERespawnMode GetRespawnMode() { return Invoke<ERespawnMode>(nameof(GetRespawnMode)); }
        public Vector GetOriginRotation() { return Invoke<Vector>(nameof(GetOriginRotation)); }
        public Vector GetOriginLocation() { return Invoke<Vector>(nameof(GetOriginLocation)); }
        public Object GetOriginChunkId() { return Invoke<Object>(nameof(GetOriginChunkId)); }
        public WorldCreatureEntityModel GetOrCreateCreatureEntity(Object Outer, WorldCreatureVO VO, ERespawnMode RespawnMode) { return Invoke<WorldCreatureEntityModel>(nameof(GetOrCreateCreatureEntity), Outer, VO, RespawnMode); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public Object GetCurrentChunkId() { return Invoke<Object>(nameof(GetCurrentChunkId)); }
        public Array<ContainerEntityModel> GetContainers() { return Invoke<Array<ContainerEntityModel>>(nameof(GetContainers)); }
        public ContainerEntityModel GetContainerByType(EContainerType ContainerType) { return Invoke<ContainerEntityModel>(nameof(GetContainerByType), ContainerType); }
        public CharacterDataModel GetCharacterData() { return Invoke<CharacterDataModel>(nameof(GetCharacterData)); }
        public TOMCharacter GetCharacterActor() { return Invoke<TOMCharacter>(nameof(GetCharacterActor)); }
        public AnimalDataModel GetAnimalData() { return Invoke<AnimalDataModel>(nameof(GetAnimalData)); }
        public AIBehaviourDataModel GetAIBehaviourData() { return Invoke<AIBehaviourDataModel>(nameof(GetAIBehaviourData)); }
        public WorldCreatureEntityModel CreateFromVO(Object Outer, WorldCreatureVO InVO) { return Invoke<WorldCreatureEntityModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class WorldDistributionStep : Object
    {
        public WorldDistributionStep(ulong addr) : base(addr) { }
    }
    public class WorldEntityModel : EntityModelBase
    {
        public WorldEntityModel(ulong addr) : base(addr) { }
        public Object OnOnlinePlayerListChanged { get { return this[nameof(OnOnlinePlayerListChanged)]; } set { this[nameof(OnOnlinePlayerListChanged)] = value; } }
        public Object OnSagaBossKilled { get { return this[nameof(OnSagaBossKilled)]; } set { this[nameof(OnSagaBossKilled)] = value; } }
        public WorldVO VO { get { return this[nameof(VO)].As<WorldVO>(); } set { this["VO"] = value; } }
        public WorldDifficultySettings DifficultySettings { get { return this[nameof(DifficultySettings)].As<WorldDifficultySettings>(); } set { this["DifficultySettings"] = value; } }
        public Array<WorldCharacterEntityModel> WorldCharacters { get { return new Array<WorldCharacterEntityModel>(this[nameof(WorldCharacters)].Address); } }
        public Array<WorldGiantEntityModel> SpawnedGiants { get { return new Array<WorldGiantEntityModel>(this[nameof(SpawnedGiants)].Address); } }
        public Array<ContainerEntityModel> Containers { get { return new Array<ContainerEntityModel>(this[nameof(Containers)].Address); } }
        public Array<WorldPlayerEntityModel> Players { get { return new Array<WorldPlayerEntityModel>(this[nameof(Players)].Address); } }
        public Array<WorldContainerEntityModel> WorldContainers { get { return new Array<WorldContainerEntityModel>(this[nameof(WorldContainers)].Address); } }
        public Object Shrines { get { return this[nameof(Shrines)]; } set { this[nameof(Shrines)] = value; } }
        public Object Chunks { get { return this[nameof(Chunks)]; } set { this[nameof(Chunks)] = value; } }
        public Object TimerHandles { get { return this[nameof(TimerHandles)]; } set { this[nameof(TimerHandles)] = value; } }
        public EventRequest ConsumeVictoryPointsRequest { get { return this[nameof(ConsumeVictoryPointsRequest)].As<EventRequest>(); } set { this["ConsumeVictoryPointsRequest"] = value; } }
        public void UpdateUsersInfos(Object UserId, Object Name, int Level, int IconId) { Invoke(nameof(UpdateUsersInfos), UserId, Name, Level, IconId); }
        public void UpdateFromVO(WorldVO InVO, Object Context) { Invoke(nameof(UpdateFromVO), InVO, Context); }
        public void UpdateDifficultySettings() { Invoke(nameof(UpdateDifficultySettings)); }
        public WorldVO ToVO() { return Invoke<WorldVO>(nameof(ToVO)); }
        public void SetYggdrasilRemainingHealth(float Health) { Invoke(nameof(SetYggdrasilRemainingHealth), Health); }
        public void SetUserExternalId(Object UserId, Object ExternalUserId) { Invoke(nameof(SetUserExternalId), UserId, ExternalUserId); }
        public void SetIsOnline(Object UserId, bool bIsOnline) { Invoke(nameof(SetIsOnline), UserId, bIsOnline); }
        public void SetCurrentlySpawnMinionCount(int MinionCount) { Invoke(nameof(SetCurrentlySpawnMinionCount), MinionCount); }
        public void SetConstructionCount(int InCount) { Invoke(nameof(SetConstructionCount), InCount); }
        public void OnWorldContainerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnWorldContainerEntityChanged), Entity, Context); }
        public void OnWorldCharacterEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnWorldCharacterEntityChanged), Entity, Context); }
        public void OnShrineEntityChanged(EEntityActionType ActionType, Object EntityId, Object Context) { Invoke(nameof(OnShrineEntityChanged), ActionType, EntityId, Context); }
        public void OnPlayerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnPlayerEntityChanged), Entity, Context); }
        public void OnGiantEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnGiantEntityChanged), Entity, Context); }
        public void OnContainerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerEntityChanged), Entity, Context); }
        public void OnChunkEntityChanged(EEntityActionType ActionType, Object EntityId, Object Context) { Invoke(nameof(OnChunkEntityChanged), ActionType, EntityId, Context); }
        public Array<ContainerEntityModel> LootWorldContainer(WorldContainerEntityModel EntityModel, Object UserId, bool bIsAutoLoot) { return Invoke<Array<ContainerEntityModel>>(nameof(LootWorldContainer), EntityModel, UserId, bIsAutoLoot); }
        public void LogoutUser(Object UserId) { Invoke(nameof(LogoutUser), UserId); }
        public void KillSagaBoss() { Invoke(nameof(KillSagaBoss)); }
        public void KillCreature(WorldCreatureEntityModel EntityModel, Vector LootDropLocation, float LootDropMinDistance, bool PreventLootFromSpawning, EmitterComponent Source) { Invoke(nameof(KillCreature), EntityModel, LootDropLocation, LootDropMinDistance, PreventLootFromSpawning, Source); }
        public bool IsOnline(Object UserId) { return Invoke<bool>(nameof(IsOnline), UserId); }
        public bool IsFTUE() { return Invoke<bool>(nameof(IsFTUE)); }
        public Array<ContainerEntityModel> HarvestMaterialSource(WorldMaterialSourceEntityModel EntityModel, Object UserId, bool bIsAutoLoot, TOMCharacter TOMCharacter, bool bForceNightShift) { return Invoke<Array<ContainerEntityModel>>(nameof(HarvestMaterialSource), EntityModel, UserId, bIsAutoLoot, TOMCharacter, bForceNightShift); }
        public float GetYggdrasilRemainingHealth() { return Invoke<float>(nameof(GetYggdrasilRemainingHealth)); }
        public DataObject GetYggdrasilDecay() { return Invoke<DataObject>(nameof(GetYggdrasilDecay)); }
        public DataObject GetXPDifficulty() { return Invoke<DataObject>(nameof(GetXPDifficulty)); }
        public int GetWorldPlayerCount() { return Invoke<int>(nameof(GetWorldPlayerCount)); }
        public WorldDifficultySettings GetWorldDifficultySettings() { return Invoke<WorldDifficultySettings>(nameof(GetWorldDifficultySettings)); }
        public Array<WorldContainerEntityModel> GetWorldContainers() { return Invoke<Array<WorldContainerEntityModel>>(nameof(GetWorldContainers)); }
        public WorldContainerEntityModel GetWorldContainerById(Object EntityId) { return Invoke<WorldContainerEntityModel>(nameof(GetWorldContainerById), EntityId); }
        public WorldCharacterEntityModel GetWorldCharacterBySellerType(ESellerType SellerType) { return Invoke<WorldCharacterEntityModel>(nameof(GetWorldCharacterBySellerType), SellerType); }
        public Array<UserInfosVO> GetUsersInfos() { return Invoke<Array<UserInfosVO>>(nameof(GetUsersInfos)); }
        public WorldPlayerEntityModel GetUserById(Object UserId) { return Invoke<WorldPlayerEntityModel>(nameof(GetUserById), UserId); }
        public int GetStartingDayTime() { return Invoke<int>(nameof(GetStartingDayTime)); }
        public bool GetSpawnMinions() { return Invoke<bool>(nameof(GetSpawnMinions)); }
        public bool GetSpawnGiants() { return Invoke<bool>(nameof(GetSpawnGiants)); }
        public Array<WorldGiantEntityModel> GetSpawnedGiants() { return Invoke<Array<WorldGiantEntityModel>>(nameof(GetSpawnedGiants)); }
        public int GetSeed() { return Invoke<int>(nameof(GetSeed)); }
        public int GetSagaBossKillCount() { return Invoke<int>(nameof(GetSagaBossKillCount)); }
        public DataObject GetQuestsDifficulty() { return Invoke<DataObject>(nameof(GetQuestsDifficulty)); }
        public Array<WorldPlayerEntityModel> GetPlayers() { return Invoke<Array<WorldPlayerEntityModel>>(nameof(GetPlayers)); }
        public WorldContainerEntityModel GetPlayerLootByUserId(Object UserId) { return Invoke<WorldContainerEntityModel>(nameof(GetPlayerLootByUserId), UserId); }
        public WorldContainerEntityModel GetPlayerLootByContainerId(Object ContainerId) { return Invoke<WorldContainerEntityModel>(nameof(GetPlayerLootByContainerId), ContainerId); }
        public DataObject GetNPCDifficulty() { return Invoke<DataObject>(nameof(GetNPCDifficulty)); }
        public Object GetName() { return Invoke<Object>(nameof(GetName)); }
        public DataObject GetMythBossDifficulty() { return Invoke<DataObject>(nameof(GetMythBossDifficulty)); }
        public DataObject GetMinionWavesDifficulty() { return Invoke<DataObject>(nameof(GetMinionWavesDifficulty)); }
        public DataObject GetMinionsDifficulty() { return Invoke<DataObject>(nameof(GetMinionsDifficulty)); }
        public int GetMaxPlayers() { return Invoke<int>(nameof(GetMaxPlayers)); }
        public int GetMapSize() { return Invoke<int>(nameof(GetMapSize)); }
        public DataObject GetLootDifficultySettings() { return Invoke<DataObject>(nameof(GetLootDifficultySettings)); }
        public bool GetIsPrivate() { return Invoke<bool>(nameof(GetIsPrivate)); }
        public bool GetIsDestroyed() { return Invoke<bool>(nameof(GetIsDestroyed)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public DataObject GetGiantsDifficulty() { return Invoke<DataObject>(nameof(GetGiantsDifficulty)); }
        public bool GetGiantsArrow() { return Invoke<bool>(nameof(GetGiantsArrow)); }
        public int GetGiantLevel() { return Invoke<int>(nameof(GetGiantLevel)); }
        public WorldGiantEntityModel GetGiant() { return Invoke<WorldGiantEntityModel>(nameof(GetGiant)); }
        public EGameMode GetGameMode() { return Invoke<EGameMode>(nameof(GetGameMode)); }
        public Array<byte> GetExploredChunks() { return Invoke<Array<byte>>(nameof(GetExploredChunks)); }
        public DataObject GetEventsDifficulty() { return Invoke<DataObject>(nameof(GetEventsDifficulty)); }
        public float GetElapsedTime() { return Invoke<float>(nameof(GetElapsedTime)); }
        public int GetDropMaterialOnDeath() { return Invoke<int>(nameof(GetDropMaterialOnDeath)); }
        public int GetDayDuration() { return Invoke<int>(nameof(GetDayDuration)); }
        public int GetCurrentlySpawnMinionCount() { return Invoke<int>(nameof(GetCurrentlySpawnMinionCount)); }
        public DataObject GetCreaturesDifficulty() { return Invoke<DataObject>(nameof(GetCreaturesDifficulty)); }
        public DataObject GetCreaturePackDifficulty() { return Invoke<DataObject>(nameof(GetCreaturePackDifficulty)); }
        public Array<ContainerEntityModel> GetContainers() { return Invoke<Array<ContainerEntityModel>>(nameof(GetContainers)); }
        public ContainerEntityModel GetContainerByType(EContainerType ContainerType) { return Invoke<ContainerEntityModel>(nameof(GetContainerByType), ContainerType); }
        public ContainerEntityModel GetContainerById(Object ID) { return Invoke<ContainerEntityModel>(nameof(GetContainerById), ID); }
        public int GetConstructionCount() { return Invoke<int>(nameof(GetConstructionCount)); }
        public float GetCleanElapsedTime() { return Invoke<float>(nameof(GetCleanElapsedTime)); }
        public Object GetChunks() { return Invoke<Object>(nameof(GetChunks)); }
        public int GetAutoScaleConfigIndex(int ValuesArrayLength) { return Invoke<int>(nameof(GetAutoScaleConfigIndex), ValuesArrayLength); }
        public ContainerSlotItemEntityModel FindUserItemById(Object ItemEntityId, Object UserId) { return Invoke<ContainerSlotItemEntityModel>(nameof(FindUserItemById), ItemEntityId, UserId); }
        public Array<ContainerEntityModel> FindUserContainers(Object UserId) { return Invoke<Array<ContainerEntityModel>>(nameof(FindUserContainers), UserId); }
        public ContainerEntityModel FindUserContainer(Object UserId, EContainerType ContainerType) { return Invoke<ContainerEntityModel>(nameof(FindUserContainer), UserId, ContainerType); }
        public void DiscardSlotsByCategoryForUser(EItemCategory ItemCategory, Object UserId) { Invoke(nameof(DiscardSlotsByCategoryForUser), ItemCategory, UserId); }
        public void ClearGiants() { Invoke(nameof(ClearGiants)); }
        public void CleanUpChunks() { Invoke(nameof(CleanUpChunks)); }
        public void AddUserIfNotExist(Object UserId, Object Name, int XP, int IconId) { Invoke(nameof(AddUserIfNotExist), UserId, Name, XP, IconId); }
        public void AddGiant(int GiantId) { Invoke(nameof(AddGiant), GiantId); }
    }
    public class WorldFinalStep : Object
    {
        public WorldFinalStep(ulong addr) : base(addr) { }
    }
    public class WorldGenData : Object
    {
        public WorldGenData(ulong addr) : base(addr) { }
    }
    public class WorldGiantEntityModel : EntityModelBase
    {
        public WorldGiantEntityModel(ulong addr) : base(addr) { }
        public void PreSaveUpdate(float InHealth, float InDelay, int InCurrentPathIndex, int InCurrentZoneIndex, int InCurrentTargetIndex, bool bInHasBeenDiscovered, Vector InWorldPosition, Vector InLastKnownPosition) { Invoke(nameof(PreSaveUpdate), InHealth, InDelay, InCurrentPathIndex, InCurrentZoneIndex, InCurrentTargetIndex, bInHasBeenDiscovered, InWorldPosition, InLastKnownPosition); }
        public void OnGiantDeath() { Invoke(nameof(OnGiantDeath)); }
        public void Init(float InDelay, int InCurrentPathIndex, int InCurrentZoneIndex, int InCurrentTargetIndex, Vector InWorldPosition) { Invoke(nameof(Init), InDelay, InCurrentPathIndex, InCurrentZoneIndex, InCurrentTargetIndex, InWorldPosition); }
        public bool HasBeenDiscovered() { return Invoke<bool>(nameof(HasBeenDiscovered)); }
        public int GetZoneIndex() { return Invoke<int>(nameof(GetZoneIndex)); }
        public Vector GetWorldPosition() { return Invoke<Vector>(nameof(GetWorldPosition)); }
        public int GetTargetIndex() { return Invoke<int>(nameof(GetTargetIndex)); }
        public int GetPathIndex() { return Invoke<int>(nameof(GetPathIndex)); }
        public Vector GetLastKnownPosition() { return Invoke<Vector>(nameof(GetLastKnownPosition)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public GiantDataModel GetGiantData() { return Invoke<GiantDataModel>(nameof(GetGiantData)); }
        public float GetDelay() { return Invoke<float>(nameof(GetDelay)); }
    }
    public class WorldGiantPathsStep : Object
    {
        public WorldGiantPathsStep(ulong addr) : base(addr) { }
    }
    public class WorldHeightsStep : Object
    {
        public WorldHeightsStep(ulong addr) : base(addr) { }
    }
    public class WorldInitStep : Object
    {
        public WorldInitStep(ulong addr) : base(addr) { }
    }
    public class WorldIsolationStep : Object
    {
        public WorldIsolationStep(ulong addr) : base(addr) { }
    }
    public class WorldLakesStep : Object
    {
        public WorldLakesStep(ulong addr) : base(addr) { }
    }
    public class WorldLevelsStep : Object
    {
        public WorldLevelsStep(ulong addr) : base(addr) { }
    }
    public class WorldMapManager : TOMActor
    {
        public WorldMapManager(ulong addr) : base(addr) { }
        public Object OnPlayerListChanged { get { return this[nameof(OnPlayerListChanged)]; } set { this[nameof(OnPlayerListChanged)] = value; } }
        public Object OnRefreshMarkers { get { return this[nameof(OnRefreshMarkers)]; } set { this[nameof(OnRefreshMarkers)] = value; } }
        public Object OnRefreshConstruction { get { return this[nameof(OnRefreshConstruction)]; } set { this[nameof(OnRefreshConstruction)] = value; } }
        public Object OnRefreshMovingNPC { get { return this[nameof(OnRefreshMovingNPC)]; } set { this[nameof(OnRefreshMovingNPC)] = value; } }
        public Object OnRefreshGameEvents { get { return this[nameof(OnRefreshGameEvents)]; } set { this[nameof(OnRefreshGameEvents)] = value; } }
        public Object OnRefreshPings { get { return this[nameof(OnRefreshPings)]; } set { this[nameof(OnRefreshPings)] = value; } }
        public Object OnRegisterNewActorToTrack { get { return this[nameof(OnRegisterNewActorToTrack)]; } set { this[nameof(OnRegisterNewActorToTrack)] = value; } }
        public Object OnUnregisterNewActorToTrack { get { return this[nameof(OnUnregisterNewActorToTrack)]; } set { this[nameof(OnUnregisterNewActorToTrack)] = value; } }
        public Object OnRefreshDynamicActor { get { return this[nameof(OnRefreshDynamicActor)]; } set { this[nameof(OnRefreshDynamicActor)] = value; } }
        public Texture2D TrapIcon { get { return this[nameof(TrapIcon)].As<Texture2D>(); } set { this["TrapIcon"] = value; } }
        public Texture2D TrapIconCooldown { get { return this[nameof(TrapIconCooldown)].As<Texture2D>(); } set { this["TrapIconCooldown"] = value; } }
        public Texture2D RampNorthDecal { get { return this[nameof(RampNorthDecal)].As<Texture2D>(); } set { this["RampNorthDecal"] = value; } }
        public Texture2D RampSouthDecal { get { return this[nameof(RampSouthDecal)].As<Texture2D>(); } set { this["RampSouthDecal"] = value; } }
        public Texture2D RampEastDecal { get { return this[nameof(RampEastDecal)].As<Texture2D>(); } set { this["RampEastDecal"] = value; } }
        public Texture2D RampWestDecal { get { return this[nameof(RampWestDecal)].As<Texture2D>(); } set { this["RampWestDecal"] = value; } }
        public Texture2D CaveEntranceIcon { get { return this[nameof(CaveEntranceIcon)].As<Texture2D>(); } set { this["CaveEntranceIcon"] = value; } }
        public float visionDistance { get { return this[nameof(visionDistance)].GetValue<float>(); } set { this[nameof(visionDistance)].SetValue<float>(value); } }
        public Object StreamingCharacterClass { get { return this[nameof(StreamingCharacterClass)]; } set { this[nameof(StreamingCharacterClass)] = value; } }
        public Array<IntPoint> NewlyExploredChunk { get { return new Array<IntPoint>(this[nameof(NewlyExploredChunk)].Address); } }
        public Texture2D FogOfWarTexture { get { return this[nameof(FogOfWarTexture)].As<Texture2D>(); } set { this["FogOfWarTexture"] = value; } }
        public Array<AppearOnWorldMapComponent> DynamicTrackedActors { get { return new Array<AppearOnWorldMapComponent>(this[nameof(DynamicTrackedActors)].Address); } }
        public Array<AppearOnWorldMapComponent> StaticTrackedActors { get { return new Array<AppearOnWorldMapComponent>(this[nameof(StaticTrackedActors)].Address); } }
        public Array<MovingNPCMapInfo> MovingNPCsPositions { get { return new Array<MovingNPCMapInfo>(this[nameof(MovingNPCsPositions)].Address); } }
        public Array<PlayerMapInfo> PlayerPositions { get { return new Array<PlayerMapInfo>(this[nameof(PlayerPositions)].Address); } }
        public Array<PlayerMarkerInfo> PlayerMarkers { get { return new Array<PlayerMarkerInfo>(this[nameof(PlayerMarkers)].Address); } }
        public Array<ConstructionMapInfo> ConstructionMapPositions { get { return new Array<ConstructionMapInfo>(this[nameof(ConstructionMapPositions)].Address); } }
        public Array<GameEventMapInfo> GameEvents { get { return new Array<GameEventMapInfo>(this[nameof(GameEvents)].Address); } }
        public Array<PingMapInfo> Pings { get { return new Array<PingMapInfo>(this[nameof(Pings)].Address); } }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public GenerationManager GenerationManager { get { return this[nameof(GenerationManager)].As<GenerationManager>(); } set { this["GenerationManager"] = value; } }
        public WorldEntityModel WorldEntityModel { get { return this[nameof(WorldEntityModel)].As<WorldEntityModel>(); } set { this["WorldEntityModel"] = value; } }
        public Texture2DDynamic WorldMap { get { return this[nameof(WorldMap)].As<Texture2DDynamic>(); } set { this["WorldMap"] = value; } }
        public Array<POIIcon> POIIcons { get { return new Array<POIIcon>(this[nameof(POIIcons)].Address); } }
        public Array<byte> ExploredChunksBytes { get { return new Array<byte>(this[nameof(ExploredChunksBytes)].Address); } }
        public Array<byte> ExploredChunksCompressedBytes { get { return new Array<byte>(this[nameof(ExploredChunksCompressedBytes)].Address); } }
        public void UpdateMovingNPCs() { Invoke(nameof(UpdateMovingNPCs)); }
        public void UpdateMovingNPCIcon(AppearOnWorldMapComponent AppearOnWorldMapComponent, int ForcedZOrder) { Invoke(nameof(UpdateMovingNPCIcon), AppearOnWorldMapComponent, ForcedZOrder); }
        public void UpdateLocalActorIcon(AppearOnWorldMapComponent ActorToTrack) { Invoke(nameof(UpdateLocalActorIcon), ActorToTrack); }
        public void UpdateActivePlayers(Array<PlayerState> PlayerStates) { Invoke(nameof(UpdateActivePlayers), PlayerStates); }
        public void UnRegisterStreamingTarget(StreamingTargetComponent Target) { Invoke(nameof(UnRegisterStreamingTarget), Target); }
        public void UnregisterPing(int ID) { Invoke(nameof(UnregisterPing), ID); }
        public void UnregisterMovingNPC(AppearOnWorldMapComponent AppearOnWorldMapComponent) { Invoke(nameof(UnregisterMovingNPC), AppearOnWorldMapComponent); }
        public void UnregisterActorToTrack(AppearOnWorldMapComponent ActorToUntrack) { Invoke(nameof(UnregisterActorToTrack), ActorToUntrack); }
        public void Tick(float DeltaSeconds) { Invoke(nameof(Tick), DeltaSeconds); }
        public void SaveWorldMapToPNG(Object FilePath, Texture2DDynamic WorldMapTexture) { Invoke(nameof(SaveWorldMapToPNG), FilePath, WorldMapTexture); }
        public void RevealChunksInRange(IntPoint ChunkCoords, int Range) { Invoke(nameof(RevealChunksInRange), ChunkCoords, Range); }
        public void ResetMap() { Invoke(nameof(ResetMap)); }
        public void RemoveMarker(Object UserId, int IconId) { Invoke(nameof(RemoveMarker), UserId, IconId); }
        public void RegisterStreamingTarget(StreamingTargetComponent Target) { Invoke(nameof(RegisterStreamingTarget), Target); }
        public void RegisterPing(Vector WorldPos, int Duration, EMapPingType MapPingType) { Invoke(nameof(RegisterPing), WorldPos, Duration, MapPingType); }
        public void RegisterMovingNPC(AppearOnWorldMapComponent AppearOnWorldMapComponent) { Invoke(nameof(RegisterMovingNPC), AppearOnWorldMapComponent); }
        public void RegisterActorToTrack(AppearOnWorldMapComponent NewActorToTrack) { Invoke(nameof(RegisterActorToTrack), NewActorToTrack); }
        public void OnRep_Pings() { Invoke(nameof(OnRep_Pings)); }
        public void OnRep_MarkerPositions() { Invoke(nameof(OnRep_MarkerPositions)); }
        public void OnRep_GameEvents() { Invoke(nameof(OnRep_GameEvents)); }
        public void OnRep_ExploredChunksBytes() { Invoke(nameof(OnRep_ExploredChunksBytes)); }
        public void OnRep_ConstructionPositions() { Invoke(nameof(OnRep_ConstructionPositions)); }
        public void OnPreWorldSave() { Invoke(nameof(OnPreWorldSave)); }
        public void NotifyPlayerListChanged() { Invoke(nameof(NotifyPlayerListChanged)); }
        public void NotifyMovingNPCListChanged() { Invoke(nameof(NotifyMovingNPCListChanged)); }
        public void MulticastRPC_SetCompressedExploredChunksBytesArray(Array<byte> Chunks) { Invoke(nameof(MulticastRPC_SetCompressedExploredChunksBytesArray), Chunks); }
        public void MulticastRPC_AddExploredChunks(Array<IntPoint> Chunks) { Invoke(nameof(MulticastRPC_AddExploredChunks), Chunks); }
        public bool IsChunkExplored(IntPoint ChunkCoord) { return Invoke<bool>(nameof(IsChunkExplored), ChunkCoord); }
        public bool IsChunkAndNearbyExplored(IntPoint ChunkCoord, int Radius) { return Invoke<bool>(nameof(IsChunkAndNearbyExplored), ChunkCoord, Radius); }
        public void HandleOnTargetSetCoords(StreamingTargetComponent Target, IntPoint InCoords) { Invoke(nameof(HandleOnTargetSetCoords), Target, InCoords); }
        public int GetWorldMapSize() { return Invoke<int>(nameof(GetWorldMapSize)); }
        public Texture2DDynamic GetWorldMap(Array<POIIcon> OutIcons) { return Invoke<Texture2DDynamic>(nameof(GetWorldMap), OutIcons); }
        public Array<AppearOnWorldMapComponent> GetStaticTrackedActors() { return Invoke<Array<AppearOnWorldMapComponent>>(nameof(GetStaticTrackedActors)); }
        public Array<POIIcon> GetPOIS() { return Invoke<Array<POIIcon>>(nameof(GetPOIS)); }
        public Array<PlayerMapInfo> GetPlayerPositions() { return Invoke<Array<PlayerMapInfo>>(nameof(GetPlayerPositions)); }
        public Array<PlayerMarkerInfo> GetPlayerMarkers() { return Invoke<Array<PlayerMarkerInfo>>(nameof(GetPlayerMarkers)); }
        public Array<PingMapInfo> GetPings() { return Invoke<Array<PingMapInfo>>(nameof(GetPings)); }
        public Array<MovingNPCMapInfo> GetMovingNPCsPositions() { return Invoke<Array<MovingNPCMapInfo>>(nameof(GetMovingNPCsPositions)); }
        public Array<GameEventMapInfo> GetGameEvents() { return Invoke<Array<GameEventMapInfo>>(nameof(GetGameEvents)); }
        public Texture2D GetFogOfWarTexture() { return Invoke<Texture2D>(nameof(GetFogOfWarTexture)); }
        public Array<AppearOnWorldMapComponent> GetDynamicTrackedActors() { return Invoke<Array<AppearOnWorldMapComponent>>(nameof(GetDynamicTrackedActors)); }
        public Array<ConstructionMapInfo> GetConstructionPositions() { return Invoke<Array<ConstructionMapInfo>>(nameof(GetConstructionPositions)); }
        public IntPoint FindClosestChunk(Vector POIposition) { return Invoke<IntPoint>(nameof(FindClosestChunk), POIposition); }
        public void EnqueueRefreshOfFOVTexture() { Invoke(nameof(EnqueueRefreshOfFOVTexture)); }
        public void DropMarker(Object UserId, int X, int Y, int IconId) { Invoke(nameof(DropMarker), UserId, X, Y, IconId); }
        public int ComputeChunkIndexFromChunkCoord(IntPoint ChunkCoord) { return Invoke<int>(nameof(ComputeChunkIndexFromChunkCoord), ChunkCoord); }
        public IntPoint ComputeChunkCoordFromChunkIndex(int ChunkIndex) { return Invoke<IntPoint>(nameof(ComputeChunkCoordFromChunkIndex), ChunkIndex); }
        public void CleanWorldmap(Object WorldID, TOMGameInstance InGameInstance) { Invoke(nameof(CleanWorldmap), WorldID, InGameInstance); }
        public void AddPOI(POIIcon POIIcon) { Invoke(nameof(AddPOI), POIIcon); }
    }
    public class WorldmapWidget : TOMUserWidget
    {
        public WorldmapWidget(ulong addr) : base(addr) { }
        public bool bIsCompass { get { return this[nameof(bIsCompass)].Flag; } set { this[nameof(bIsCompass)].Flag = value; } }
        public MaterialInterface FOWMaterialAsset { get { return this[nameof(FOWMaterialAsset)].As<MaterialInterface>(); } set { this["FOWMaterialAsset"] = value; } }
        public Object POIIconPerType { get { return this[nameof(POIIconPerType)]; } set { this[nameof(POIIconPerType)] = value; } }
        public Object DefaultPOIIcon { get { return this[nameof(DefaultPOIIcon)]; } set { this[nameof(DefaultPOIIcon)] = value; } }
        public Object POIDecalPerType { get { return this[nameof(POIDecalPerType)]; } set { this[nameof(POIDecalPerType)] = value; } }
        public Object DefaultDecalClass { get { return this[nameof(DefaultDecalClass)]; } set { this[nameof(DefaultDecalClass)] = value; } }
        public Object PlayerIconClass { get { return this[nameof(PlayerIconClass)]; } set { this[nameof(PlayerIconClass)] = value; } }
        public Object NPCDynamicIconPerType { get { return this[nameof(NPCDynamicIconPerType)]; } set { this[nameof(NPCDynamicIconPerType)] = value; } }
        public Object DynamicIconClass { get { return this[nameof(DynamicIconClass)]; } set { this[nameof(DynamicIconClass)] = value; } }
        public Object GameEventZoneClass { get { return this[nameof(GameEventZoneClass)]; } set { this[nameof(GameEventZoneClass)] = value; } }
        public Object GameEventIconClass { get { return this[nameof(GameEventIconClass)]; } set { this[nameof(GameEventIconClass)] = value; } }
        public Object PingClass { get { return this[nameof(PingClass)]; } set { this[nameof(PingClass)] = value; } }
        public Object GiantIconClass { get { return this[nameof(GiantIconClass)]; } set { this[nameof(GiantIconClass)] = value; } }
        public Object MarkerIconClass { get { return this[nameof(MarkerIconClass)]; } set { this[nameof(MarkerIconClass)] = value; } }
        public Object RunestoneClass { get { return this[nameof(RunestoneClass)]; } set { this[nameof(RunestoneClass)] = value; } }
        public Object ZOrderPerType { get { return this[nameof(ZOrderPerType)]; } set { this[nameof(ZOrderPerType)] = value; } }
        public int GiantIconZOrder { get { return this[nameof(GiantIconZOrder)].GetValue<int>(); } set { this[nameof(GiantIconZOrder)].SetValue<int>(value); } }
        public int PlayerIconZOrder { get { return this[nameof(PlayerIconZOrder)].GetValue<int>(); } set { this[nameof(PlayerIconZOrder)].SetValue<int>(value); } }
        public int MovingNPCIconZOrder { get { return this[nameof(MovingNPCIconZOrder)].GetValue<int>(); } set { this[nameof(MovingNPCIconZOrder)].SetValue<int>(value); } }
        public float PlayerInterpSpeed { get { return this[nameof(PlayerInterpSpeed)].GetValue<float>(); } set { this[nameof(PlayerInterpSpeed)].SetValue<float>(value); } }
        public Object VillageShrineIconPtr { get { return this[nameof(VillageShrineIconPtr)]; } set { this[nameof(VillageShrineIconPtr)] = value; } }
        public float ZoomStep { get { return this[nameof(ZoomStep)].GetValue<float>(); } set { this[nameof(ZoomStep)].SetValue<float>(value); } }
        public float ZoomMin { get { return this[nameof(ZoomMin)].GetValue<float>(); } set { this[nameof(ZoomMin)].SetValue<float>(value); } }
        public float ZoomMax { get { return this[nameof(ZoomMax)].GetValue<float>(); } set { this[nameof(ZoomMax)].SetValue<float>(value); } }
        public float ZoomSpeed { get { return this[nameof(ZoomSpeed)].GetValue<float>(); } set { this[nameof(ZoomSpeed)].SetValue<float>(value); } }
        public float GamepadSpeed { get { return this[nameof(GamepadSpeed)].GetValue<float>(); } set { this[nameof(GamepadSpeed)].SetValue<float>(value); } }
        public float ClickMoveSensitivity { get { return this[nameof(ClickMoveSensitivity)].GetValue<float>(); } set { this[nameof(ClickMoveSensitivity)].SetValue<float>(value); } }
        public int DynamicIconPoolSize { get { return this[nameof(DynamicIconPoolSize)].GetValue<int>(); } set { this[nameof(DynamicIconPoolSize)].SetValue<int>(value); } }
        public Object OnGamepadClick { get { return this[nameof(OnGamepadClick)]; } set { this[nameof(OnGamepadClick)] = value; } }
        public Object OnMapClick { get { return this[nameof(OnMapClick)]; } set { this[nameof(OnMapClick)] = value; } }
        public bool bSuspendGamepadMovement { get { return this[nameof(bSuspendGamepadMovement)].Flag; } set { this[nameof(bSuspendGamepadMovement)].Flag = value; } }
        public Vector2D CenterScreen { get { return this[nameof(CenterScreen)].As<Vector2D>(); } set { this["CenterScreen"] = value; } }
        public Image MapImageWidget { get { return this[nameof(MapImageWidget)].As<Image>(); } set { this["MapImageWidget"] = value; } }
        public Image FOWWidget { get { return this[nameof(FOWWidget)].As<Image>(); } set { this["FOWWidget"] = value; } }
        public CanvasPanel IconLayerCanvas { get { return this[nameof(IconLayerCanvas)].As<CanvasPanel>(); } set { this["IconLayerCanvas"] = value; } }
        public CanvasPanel DecalLayerCanvas { get { return this[nameof(DecalLayerCanvas)].As<CanvasPanel>(); } set { this["DecalLayerCanvas"] = value; } }
        public CanvasPanel AboveFogDecalLayerCanvas { get { return this[nameof(AboveFogDecalLayerCanvas)].As<CanvasPanel>(); } set { this["AboveFogDecalLayerCanvas"] = value; } }
        public CanvasPanel AboveFogIconLayerCanvas { get { return this[nameof(AboveFogIconLayerCanvas)].As<CanvasPanel>(); } set { this["AboveFogIconLayerCanvas"] = value; } }
        public ScaleBox ScaleBoxWidget { get { return this[nameof(ScaleBoxWidget)].As<ScaleBox>(); } set { this["ScaleBoxWidget"] = value; } }
        public CanvasPanelSlot MoveRootSlot { get { return this[nameof(MoveRootSlot)].As<CanvasPanelSlot>(); } set { this["MoveRootSlot"] = value; } }
        public Array<POIIcon> POIIcons { get { return new Array<POIIcon>(this[nameof(POIIcons)].Address); } }
        public Array<POIMapIconBaseWidget> POIWidgets { get { return new Array<POIMapIconBaseWidget>(this[nameof(POIWidgets)].Address); } }
        public TOMPlayerController LocalPlayerController { get { return this[nameof(LocalPlayerController)].As<TOMPlayerController>(); } set { this["LocalPlayerController"] = value; } }
        public WorldMapManager WorldMapManager { get { return this[nameof(WorldMapManager)].As<WorldMapManager>(); } set { this["WorldMapManager"] = value; } }
        public Object PlayerIcons { get { return this[nameof(PlayerIcons)]; } set { this[nameof(PlayerIcons)] = value; } }
        public PlayerMapIconBaseWidget LocalPlayerIcon { get { return this[nameof(LocalPlayerIcon)].As<PlayerMapIconBaseWidget>(); } set { this["LocalPlayerIcon"] = value; } }
        public Object DynamicIcons { get { return this[nameof(DynamicIcons)]; } set { this[nameof(DynamicIcons)] = value; } }
        public Array<DynamicMapIconBaseWidget> DynamicIconPool { get { return new Array<DynamicMapIconBaseWidget>(this[nameof(DynamicIconPool)].Address); } }
        public Object DynamicActorIcons { get { return this[nameof(DynamicActorIcons)]; } set { this[nameof(DynamicActorIcons)] = value; } }
        public Object StaticActorIcons { get { return this[nameof(StaticActorIcons)]; } set { this[nameof(StaticActorIcons)] = value; } }
        public Array<GameEventWidget> GameEventWidgets { get { return new Array<GameEventWidget>(this[nameof(GameEventWidgets)].Address); } }
        public Array<PingWidget> PingWidgets { get { return new Array<PingWidget>(this[nameof(PingWidgets)].Address); } }
        public GiantMapIconWidget GiantIconWidget { get { return this[nameof(GiantIconWidget)].As<GiantMapIconWidget>(); } set { this["GiantIconWidget"] = value; } }
        public Array<DynamicMapIconBaseWidget> MarkerIcons { get { return new Array<DynamicMapIconBaseWidget>(this[nameof(MarkerIcons)].Address); } }
        public POIMapIconBaseWidget VillageShrine { get { return this[nameof(VillageShrine)].As<POIMapIconBaseWidget>(); } set { this["VillageShrine"] = value; } }
        public DynamicMapIconBaseWidget Runestone { get { return this[nameof(Runestone)].As<DynamicMapIconBaseWidget>(); } set { this["Runestone"] = value; } }
        public Vector2D WorldLocationToMapPosition(Vector WorldLocation) { return Invoke<Vector2D>(nameof(WorldLocationToMapPosition), WorldLocation); }
        public void SetTargetZoom(float Target) { Invoke(nameof(SetTargetZoom), Target); }
        public Vector2D ScreenToMapPosition(Vector2D ScreenLocation) { return Invoke<Vector2D>(nameof(ScreenToMapPosition), ScreenLocation); }
        public void RefreshRuneStone() { Invoke(nameof(RefreshRuneStone)); }
        public void RefreshPlayerList() { Invoke(nameof(RefreshPlayerList)); }
        public void RefreshPings() { Invoke(nameof(RefreshPings)); }
        public void RefreshMovingNPC(bool bForceUpdate) { Invoke(nameof(RefreshMovingNPC), bForceUpdate); }
        public void RefreshMarkers() { Invoke(nameof(RefreshMarkers)); }
        public void RefreshGameEvents() { Invoke(nameof(RefreshGameEvents)); }
        public void RefreshDynamicActor() { Invoke(nameof(RefreshDynamicActor)); }
        public Vector MapToWorldPosition(Vector2D MapPosition) { return Invoke<Vector>(nameof(MapToWorldPosition), MapPosition); }
        public bool IsOpenFromShrine() { return Invoke<bool>(nameof(IsOpenFromShrine)); }
        public void Init(bool InOpenedFromShrine, Texture2D ManualMap) { Invoke(nameof(Init), InOpenedFromShrine, ManualMap); }
        public void HideFogOfWar() { Invoke(nameof(HideFogOfWar)); }
        public void CenterOnVillage() { Invoke(nameof(CenterOnVillage)); }
        public void CenterOnLocalPlayer() { Invoke(nameof(CenterOnLocalPlayer)); }
    }
    public class WorldMaterialSourceEntityModel : EntityModelBase
    {
        public WorldMaterialSourceEntityModel(ulong addr) : base(addr) { }
        public ERespawnMode RespawnMode { get { return (ERespawnMode)this[nameof(RespawnMode)].GetValue<int>(); } set { this[nameof(RespawnMode)].SetValue<int>((int)value); } }
        public void SetRespawnMode(ERespawnMode newRespawnMode) { Invoke(nameof(SetRespawnMode), newRespawnMode); }
        public ERespawnMode GetRespawnMode() { return Invoke<ERespawnMode>(nameof(GetRespawnMode)); }
        public WorldMaterialSourceEntityModel GetOrCreateMaterialSourceEntity(Object Outer, Object EntityId, IntPoint ChunkCoords, int MaterialSourceId, ERespawnMode RespawnMode) { return Invoke<WorldMaterialSourceEntityModel>(nameof(GetOrCreateMaterialSourceEntity), Outer, EntityId, ChunkCoords, MaterialSourceId, RespawnMode); }
        public MaterialSourceDataModel GetMaterialSourceData() { return Invoke<MaterialSourceDataModel>(nameof(GetMaterialSourceData)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
    }
    public class WorldModulesStep : Object
    {
        public WorldModulesStep(ulong addr) : base(addr) { }
    }
    public class WorldNetworkStep : Object
    {
        public WorldNetworkStep(ulong addr) : base(addr) { }
    }
    public class WorldNoiseStep : Object
    {
        public WorldNoiseStep(ulong addr) : base(addr) { }
    }
    public class WorldPassagesStep : Object
    {
        public WorldPassagesStep(ulong addr) : base(addr) { }
    }
    public class WorldPlayerEntityModel : EntityModelBase
    {
        public WorldPlayerEntityModel(ulong addr) : base(addr) { }
        public Object OnXPGained { get { return this[nameof(OnXPGained)]; } set { this[nameof(OnXPGained)] = value; } }
        public Object OnLevelUp { get { return this[nameof(OnLevelUp)]; } set { this[nameof(OnLevelUp)] = value; } }
        public Object OnSkillChanged { get { return this[nameof(OnSkillChanged)]; } set { this[nameof(OnSkillChanged)] = value; } }
        public Array<ContainerEntityModel> Containers { get { return new Array<ContainerEntityModel>(this[nameof(Containers)].Address); } }
        public void SetFTUE() { Invoke(nameof(SetFTUE)); }
        public bool SawFTUE() { return Invoke<bool>(nameof(SawFTUE)); }
        public void RemoveSeenItem(Object ItemId) { Invoke(nameof(RemoveSeenItem), ItemId); }
        public void RemoveRecipeFromWishlist(int RecipeId) { Invoke(nameof(RemoveRecipeFromWishlist), RecipeId); }
        public void PreSaveUpdate(float InHealth, Vector InWorldPosition, int InSpecialPoint, StatusTwoWayRuneStoneBase StatusTwoWayRuneStoneBase) { Invoke(nameof(PreSaveUpdate), InHealth, InWorldPosition, InSpecialPoint, StatusTwoWayRuneStoneBase); }
        public void OnContainerEntityChanged(EntityModelBase Entity, Object Context) { Invoke(nameof(OnContainerEntityChanged), Entity, Context); }
        public bool IsSlotItemNew(ContainerSlotEntityModel Slot) { return Invoke<bool>(nameof(IsSlotItemNew), Slot); }
        public bool IsRecipeWishlisted(int RecipeId) { return Invoke<bool>(nameof(IsRecipeWishlisted), RecipeId); }
        public bool IsAdmin() { return Invoke<bool>(nameof(IsAdmin)); }
        public bool HasSkill(int ID) { return Invoke<bool>(nameof(HasSkill), ID); }
        public int GetXP() { return Invoke<int>(nameof(GetXP)); }
        public Vector GetWorldPosition() { return Invoke<Vector>(nameof(GetWorldPosition)); }
        public Array<int> GetWishlistedRecipes() { return Invoke<Array<int>>(nameof(GetWishlistedRecipes)); }
        public Array<PlayerSkillDataModel> GetUnlockedSkills() { return Invoke<Array<PlayerSkillDataModel>>(nameof(GetUnlockedSkills)); }
        public int GetSpecialPoints() { return Invoke<int>(nameof(GetSpecialPoints)); }
        public int GetSkillPoints() { return Invoke<int>(nameof(GetSkillPoints)); }
        public ESkillClass GetSelectedClass() { return Invoke<ESkillClass>(nameof(GetSelectedClass)); }
        public Array<Object> GetSeenItems() { return Invoke<Array<Object>>(nameof(GetSeenItems)); }
        public Vector GetRuneStoneGoBackPosition() { return Invoke<Vector>(nameof(GetRuneStoneGoBackPosition)); }
        public Array<int> GetPersonalQuests() { return Invoke<Array<int>>(nameof(GetPersonalQuests)); }
        public int GetMaxLevel() { return Invoke<int>(nameof(GetMaxLevel)); }
        public bool GetIsRuneStoneInGoBackMode() { return Invoke<bool>(nameof(GetIsRuneStoneInGoBackMode)); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public int GetCurrentLevel() { return Invoke<int>(nameof(GetCurrentLevel)); }
        public ContainerEntityModel GetContainerByType(EContainerType ContainerType) { return Invoke<ContainerEntityModel>(nameof(GetContainerByType), ContainerType); }
        public int GetConstrictionCount() { return Invoke<int>(nameof(GetConstrictionCount)); }
        public int GetAltarUseCount() { return Invoke<int>(nameof(GetAltarUseCount)); }
        public void AddSeenItem(Object Value, bool bSave) { Invoke(nameof(AddSeenItem), Value, bSave); }
        public void AddRecipeToWishlist(int RecipeId) { Invoke(nameof(AddRecipeToWishlist), RecipeId); }
    }
    public class WorldRegionsStep : Object
    {
        public WorldRegionsStep(ulong addr) : base(addr) { }
    }
    public class WorldRiversStep : Object
    {
        public WorldRiversStep(ulong addr) : base(addr) { }
    }
    public class WorldRoadsStep : Object
    {
        public WorldRoadsStep(ulong addr) : base(addr) { }
    }
    public class WorldShrineEntityModel : EntityModelBase
    {
        public WorldShrineEntityModel(ulong addr) : base(addr) { }
        public void UpdateFromVO(WorldShrineVO InVO, Object Context) { Invoke(nameof(UpdateFromVO), InVO, Context); }
        public WorldShrineVO ToVO() { return Invoke<WorldShrineVO>(nameof(ToVO)); }
        public bool IsActive() { return Invoke<bool>(nameof(IsActive)); }
        public WorldShrineEntityModel GetOrCreateEntity(Object Outer, Object EntityId) { return Invoke<WorldShrineEntityModel>(nameof(GetOrCreateEntity), Outer, EntityId); }
        public Object GetId() { return Invoke<Object>(nameof(GetId)); }
        public WorldShrineEntityModel CreateFromVO(Object Outer, WorldShrineVO InVO) { return Invoke<WorldShrineEntityModel>(nameof(CreateFromVO), Outer, InVO); }
        public bool ComputeReplication(WorldShrine_RepProperties OutRepProperties, EEntityActionType ActionType, Object InEntityId, WorldShrineEntityModel Entity, Object Context) { return Invoke<bool>(nameof(ComputeReplication), OutRepProperties, ActionType, InEntityId, Entity, Context); }
        public bool ApplyReplication(WorldShrine_RepProperties RepProperties) { return Invoke<bool>(nameof(ApplyReplication), RepProperties); }
        public void Activate() { Invoke(nameof(Activate)); }
    }
    public class WorldStepInterface : Interface
    {
        public WorldStepInterface(ulong addr) : base(addr) { }
    }
    public class WorldTrapsStep : Object
    {
        public WorldTrapsStep(ulong addr) : base(addr) { }
    }
    public class WorldVillageStep : Object
    {
        public WorldVillageStep(ulong addr) : base(addr) { }
    }
    public class YggdrasilBase : TOMActor
    {
        public YggdrasilBase(ulong addr) : base(addr) { }
        public HealthComponent YggdrasilHealthComponent { get { return this[nameof(YggdrasilHealthComponent)].As<HealthComponent>(); } set { this["YggdrasilHealthComponent"] = value; } }
        public TOMOffensiveComponent TOMOffensiveComponent { get { return this[nameof(TOMOffensiveComponent)].As<TOMOffensiveComponent>(); } set { this["TOMOffensiveComponent"] = value; } }
        public SceneComponent AttackOriginPoint { get { return this[nameof(AttackOriginPoint)].As<SceneComponent>(); } set { this["AttackOriginPoint"] = value; } }
        public Object MUS_Yggdrasil_Death { get { return this[nameof(MUS_Yggdrasil_Death)]; } set { this[nameof(MUS_Yggdrasil_Death)] = value; } }
        public int CurrentTier { get { return this[nameof(CurrentTier)].GetValue<int>(); } set { this[nameof(CurrentTier)].SetValue<int>(value); } }
        public TimerHandle TickAttackHandle { get { return this[nameof(TickAttackHandle)].As<TimerHandle>(); } set { this["TickAttackHandle"] = value; } }
        public Array<DataObject> TiersConfig { get { return new Array<DataObject>(this[nameof(TiersConfig)].Address); } }
        public void StartGameOverSequence(TOMPlayerController PlayerController) { Invoke(nameof(StartGameOverSequence), PlayerController); }
        public void RefreshTier(float Health) { Invoke(nameof(RefreshTier), Health); }
        public void PlayGameOverSequence(TOMPlayerController PlayerController) { Invoke(nameof(PlayGameOverSequence), PlayerController); }
        public void OnHealthChanged(HealthComponent healthComp, float Health, float NormalizedHealth, float HealthDelta) { Invoke(nameof(OnHealthChanged), healthComp, Health, NormalizedHealth, HealthDelta); }
        public DataObject GetCurrentTier() { return Invoke<DataObject>(nameof(GetCurrentTier)); }
        public void ExecuteAttack() { Invoke(nameof(ExecuteAttack)); }
    }
    public class ServerStatus : Object
    {
        public ServerStatus(ulong addr) : base(addr) { }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public Object DataVersion { get { return this[nameof(DataVersion)]; } set { this[nameof(DataVersion)] = value; } }
        public bool IsActive { get { return this[nameof(IsActive)].Flag; } set { this[nameof(IsActive)].Flag = value; } }
        public bool IsMaintenance { get { return this[nameof(IsMaintenance)].Flag; } set { this[nameof(IsMaintenance)].Flag = value; } }
        public bool IsShopMaintenance { get { return this[nameof(IsShopMaintenance)].Flag; } set { this[nameof(IsShopMaintenance)].Flag = value; } }
    }
    public class ContainerDifference : Object
    {
        public ContainerDifference(ulong addr) : base(addr) { }
        public Object AddedItems { get { return this[nameof(AddedItems)]; } set { this[nameof(AddedItems)] = value; } }
    }
    public enum EPopupType : int
    {
        Info = 0,
        NoInternet = 1,
        Maintenance = 2,
        AgeRestricted = 3,
        PremiumNeeded = 4,
        UpdateRequired = 5,
        EPopupType_MAX = 6,
    }
    public enum EAppearOnWorldMapIconWidgetType : int
    {
        Regular = 0,
        VillageHealer = 1,
        EAppearOnWorldMapIconWidgetType_MAX = 2,
    }
    public enum EAppearOnWorldMapSpawnType : int
    {
        Local = 0,
        Remote = 1,
        EAppearOnWorldMapSpawnType_MAX = 2,
    }
    public enum AppearOnWorldMapSpawnCondition : int
    {
        Always = 0,
        Never = 1,
        OnPlayerDetection = 2,
        AppearOnWorldMapSpawnCondition_MAX = 3,
    }
    public enum EMoveDirection : int
    {
        Forward = 0,
        Backward = 1,
        Right = 2,
        Left = 3,
        EMoveDirection_MAX = 4,
    }
    public enum ECaveExitType : int
    {
        ToWorld = 0,
        PreviousFloor = 1,
        NextFloor = 2,
        BossExit = 3,
        ECaveExitType_MAX = 4,
    }
    public enum ECgSDKEventType : int
    {
        None = 0,
        LootRunes = 1,
        LootGoldenHorn = 2,
        LootTreasureChest = 3,
        PickUpDeadLoot = 4,
        ECgSDKEventType_MAX = 5,
    }
    public enum EChunkLayerType : int
    {
        None = 0,
        Geometry = 1,
        Modules = 2,
        Props = 3,
        Creatures = 4,
        Terrain = 5,
        DecoProps = 6,
        InstancedMeshes = 7,
        PostProcessVolume = 8,
        EChunkLayerType_MAX = 9,
    }
    public enum EFlammableStatus : int
    {
        None = 0,
        Flammable = 1,
        Ignited = 2,
        Burning = 3,
        Burned = 4,
        Extinguished = 5,
        EFlammableStatus_MAX = 6,
    }
    public enum EBiomeType : int
    {
        None = 0,
        Regular = 1,
        Beach = 2,
        CliffIsolated = 3,
        RiftIsolated = 4,
        BridgeIsolated = 5,
        EBiomeType_MAX = 6,
    }
    public enum EGroundDetailType : int
    {
        None = 0,
        Regular = 1,
        OnRoad = 2,
        EGroundDetailType_MAX = 3,
    }
    public enum ELandmarkType : int
    {
        Regular = 0,
        OnRoad = 1,
        OnRamp = 2,
        InWater = 3,
        InWaterAndLand = 4,
        ELandmarkType_MAX = 5,
    }
    public enum EGeoPropType : int
    {
        InnerCap = 0,
        OuterCap = 1,
        StraightCap = 2,
        InnerPart = 3,
        OuterPart = 4,
        StraightPart = 5,
        InnerBottom = 6,
        OuterBottom = 7,
        StraightBottom = 8,
        InnerShore = 9,
        OuterShore = 10,
        StraightShore = 11,
        WaterfallLeftShore = 12,
        WaterfallRightShore = 13,
        EGeoPropType_MAX = 14,
    }
    public enum EFoliageType : int
    {
        Base = 0,
        Specific = 1,
        River = 2,
        Cliff = 3,
        Road = 4,
        Water = 5,
        WaterNearShore = 6,
        EFoliageType_MAX = 7,
    }
    public enum EGiantIconStatus : int
    {
        Hidden = 0,
        Shown = 1,
        Greyed = 2,
        EGiantIconStatus_MAX = 3,
    }
    public enum EInputEffectsTriggerMask : int
    {
        LeftTrigger = 1,
        RightTrigger = 2,
        EInputEffectsTriggerMask_MAX = 3,
    }
    public enum ECanPlayOnlineResult : int
    {
        NoFailures = 0,
        AgeRestrictionFailure = 1,
        AccountTypeFailure = 2,
        UnknownFailure = 3,
        ECanPlayOnlineResult_MAX = 4,
    }
    public enum EServerRequestError : int
    {
        UnknownError = 0,
        TimeoutError = -10000,
        EventKeyError = -10001,
        EServerRequestError_MAX = 1,
    }
    public enum ESpawnType : int
    {
        Default = 0,
        Respawn = 1,
        Summon = 2,
        ESpawnType_MAX = 3,
    }
    public enum EGameInstanceState : int
    {
        MainMenu = 0,
        TransitioningOrPlaying = 1,
        EGameInstanceState_MAX = 2,
    }
    public enum ESaveGameAction : int
    {
        Add = 0,
        Update = 1,
        Remove = 2,
        ESaveGameAction_MAX = 3,
    }
    public enum ETutorialState : int
    {
        InitialState = 0,
        CatTipInfoSlide = 1,
        GatherPickaxeMaterialsQuest = 2,
        HelpersMoveToTinker = 3,
        HelpersWaitingAfterMoveToTinker = 4,
        CraftPickaxeQuest = 5,
        EquipmentTipInfoSlide = 6,
        TimeLerpToEvening = 7,
        HelpersMoveToSwordMaterial = 8,
        HelpersWaitingAfterMoveToSwordMaterial = 9,
        GatherSwordMaterialsQuest = 10,
        HelpersMoveToBlacksmith1 = 11,
        HelpersMoveToBlacksmith2 = 12,
        HelpersWaitingAfterMoveToBlacksmith = 13,
        CraftSwordQuest = 14,
        HelpersMoveToYggdrasil = 15,
        HelpersWaitingAfterMoveToYggdrasil = 16,
        SoulTipInfoSlide = 17,
        FeedYggdrasilQuest = 18,
        FadeToEvening = 19,
        HelpersWaitingAfterYggdrasilQuest = 20,
        FightingTipInfoSlide = 21,
        FadeToNight = 22,
        MinionWaveNightQuest = 23,
        MinionWaveNightQuestComplete = 24,
        FadeToGiant = 25,
        WaitingForDefeatGiantQuest = 26,
        LegendaryTipInfoSlide = 27,
        DefeatGiantQuest = 28,
        DefeatGiantQuestCompletionDialog = 29,
        HelpersMoveToBifrost = 30,
        HelpersWaitingAfterMoveToBifrost = 31,
        EnterBifrostQuest = 32,
        TutorialEnd = 33,
        ETutorialState_MAX = 34,
    }
    public class GroundDetailsCollection : Object
    {
        public GroundDetailsCollection(ulong addr) : base(addr) { }
    }
    public class CameraSettings : Object
    {
        public CameraSettings(ulong addr) : base(addr) { }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public float TargetArmLength { get { return this[nameof(TargetArmLength)].GetValue<float>(); } set { this[nameof(TargetArmLength)].SetValue<float>(value); } }
        public float CameraLagSpeed { get { return this[nameof(CameraLagSpeed)].GetValue<float>(); } set { this[nameof(CameraLagSpeed)].SetValue<float>(value); } }
        public Vector SocketOffset { get { return this[nameof(SocketOffset)].As<Vector>(); } set { this["SocketOffset"] = value; } }
    }
    public class CaveEntrance : Object
    {
        public CaveEntrance(ulong addr) : base(addr) { }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
        public ECardinal Cardinal { get { return (ECardinal)this[nameof(Cardinal)].GetValue<int>(); } set { this[nameof(Cardinal)].SetValue<int>((int)value); } }
    }
    public class CreaturePackData : Object
    {
        public CreaturePackData(ulong addr) : base(addr) { }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public Array<CreatureData> Creatures { get { return new Array<CreatureData>(this[nameof(Creatures)].Address); } }
        public int MinValue { get { return this[nameof(MinValue)].GetValue<int>(); } set { this[nameof(MinValue)].SetValue<int>(value); } }
    }
    public class CreatureData : Object
    {
        public CreatureData(ulong addr) : base(addr) { }
        public int AnimalId { get { return this[nameof(AnimalId)].GetValue<int>(); } set { this[nameof(AnimalId)].SetValue<int>(value); } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public Object PackEntityId { get { return this[nameof(PackEntityId)]; } set { this[nameof(PackEntityId)] = value; } }
        public int PackDataId { get { return this[nameof(PackDataId)].GetValue<int>(); } set { this[nameof(PackDataId)].SetValue<int>(value); } }
        public WorldCreatureEntityModel EntityModel { get { return this[nameof(EntityModel)].As<WorldCreatureEntityModel>(); } set { this["EntityModel"] = value; } }
    }
    public class ChunkAction : Object
    {
        public ChunkAction(ulong addr) : base(addr) { }
    }
    public class Container_RepProperties : Object
    {
        public Container_RepProperties(ulong addr) : base(addr) { }
        public EEntityActionType ActionType { get { return (EEntityActionType)this[nameof(ActionType)].GetValue<int>(); } set { this[nameof(ActionType)].SetValue<int>((int)value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public ContainerVO Entity { get { return this[nameof(Entity)].As<ContainerVO>(); } set { this["Entity"] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
    }
    public class CornerAttributes : Object
    {
        public CornerAttributes(ulong addr) : base(addr) { }
        public IntPoint WorldCoordinates { get { return this[nameof(WorldCoordinates)].As<IntPoint>(); } set { this["WorldCoordinates"] = value; } }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
        public ushort WorldExternalId { get { return this[nameof(WorldExternalId)].GetValue<ushort>(); } set { this[nameof(WorldExternalId)].SetValue<ushort>(value); } }
        public ushort WorldProcessValue { get { return this[nameof(WorldProcessValue)].GetValue<ushort>(); } set { this[nameof(WorldProcessValue)].SetValue<ushort>(value); } }
        public ushort WorldHeight { get { return this[nameof(WorldHeight)].GetValue<ushort>(); } set { this[nameof(WorldHeight)].SetValue<ushort>(value); } }
        public Object WorldExternalCardinal { get { return this[nameof(WorldExternalCardinal)]; } set { this[nameof(WorldExternalCardinal)] = value; } }
        public Array<Object> WorldStatus { get { return new Array<Object>(this[nameof(WorldStatus)].Address); } }
        public ushort RegionId { get { return this[nameof(RegionId)].GetValue<ushort>(); } set { this[nameof(RegionId)].SetValue<ushort>(value); } }
        public ushort RegionBiomeId { get { return this[nameof(RegionBiomeId)].GetValue<ushort>(); } set { this[nameof(RegionBiomeId)].SetValue<ushort>(value); } }
        public byte RegionBiomeLevel { get { return this[nameof(RegionBiomeLevel)].GetValue<byte>(); } set { this[nameof(RegionBiomeLevel)].SetValue<byte>(value); } }
        public ushort RegionHeight { get { return this[nameof(RegionHeight)].GetValue<ushort>(); } set { this[nameof(RegionHeight)].SetValue<ushort>(value); } }
        public int DistFromVillage { get { return this[nameof(DistFromVillage)].GetValue<int>(); } set { this[nameof(DistFromVillage)].SetValue<int>(value); } }
        public Array<Object> RegionStatus { get { return new Array<Object>(this[nameof(RegionStatus)].Address); } }
        public ushort ChunkBiomeId { get { return this[nameof(ChunkBiomeId)].GetValue<ushort>(); } set { this[nameof(ChunkBiomeId)].SetValue<ushort>(value); } }
        public ushort ChunkEffectiveHeight { get { return this[nameof(ChunkEffectiveHeight)].GetValue<ushort>(); } set { this[nameof(ChunkEffectiveHeight)].SetValue<ushort>(value); } }
        public Vector2D ChunkLocalPos { get { return this[nameof(ChunkLocalPos)].As<Vector2D>(); } set { this["ChunkLocalPos"] = value; } }
        public float ChunkGroundWeight { get { return this[nameof(ChunkGroundWeight)].GetValue<float>(); } set { this[nameof(ChunkGroundWeight)].SetValue<float>(value); } }
        public float ChunkPuddleWeight { get { return this[nameof(ChunkPuddleWeight)].GetValue<float>(); } set { this[nameof(ChunkPuddleWeight)].SetValue<float>(value); } }
        public bool bChunkIsPopulated { get { return this[nameof(bChunkIsPopulated)].Flag; } set { this[nameof(bChunkIsPopulated)].Flag = value; } }
        public bool bChunkIsMuddy { get { return this[nameof(bChunkIsMuddy)].Flag; } set { this[nameof(bChunkIsMuddy)].Flag = value; } }
    }
    public class DroppedLootData : Object
    {
        public DroppedLootData(ulong addr) : base(addr) { }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int Durability { get { return this[nameof(Durability)].GetValue<int>(); } set { this[nameof(Durability)].SetValue<int>(value); } }
        public bool bIsInstanced { get { return this[nameof(bIsInstanced)].Flag; } set { this[nameof(bIsInstanced)].Flag = value; } }
        public Array<Object> UserIds { get { return new Array<Object>(this[nameof(UserIds)].Address); } }
    }
    public class OnEntityRegisteredDelegates : Object
    {
        public OnEntityRegisteredDelegates(ulong addr) : base(addr) { }
        public Array<Object> Delegates { get { return new Array<Object>(this[nameof(Delegates)].Address); } }
    }
    public class EntityActionDelegates : Object
    {
        public EntityActionDelegates(ulong addr) : base(addr) { }
        public Array<Object> Delegates { get { return new Array<Object>(this[nameof(Delegates)].Address); } }
    }
    public class FlammableSurfaceState : Object
    {
        public FlammableSurfaceState(ulong addr) : base(addr) { }
        public IntPoint Coords { get { return this[nameof(Coords)].As<IntPoint>(); } set { this["Coords"] = value; } }
        public int LitIndex { get { return this[nameof(LitIndex)].GetValue<int>(); } set { this[nameof(LitIndex)].SetValue<int>(value); } }
        public float RegrowthValue { get { return this[nameof(RegrowthValue)].GetValue<float>(); } set { this[nameof(RegrowthValue)].SetValue<float>(value); } }
    }
    public class FlammableSurfaceVertex : Object
    {
        public FlammableSurfaceVertex(ulong addr) : base(addr) { }
    }
    public class GameEventZone : Object
    {
        public GameEventZone(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector2D MapOffset { get { return this[nameof(MapOffset)].As<Vector2D>(); } set { this["MapOffset"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int RegionId { get { return this[nameof(RegionId)].GetValue<int>(); } set { this[nameof(RegionId)].SetValue<int>(value); } }
        public Array<HazardEntityModel> SpawnedHazards { get { return new Array<HazardEntityModel>(this[nameof(SpawnedHazards)].Address); } }
        public Array<WorldCreatureEntityModel> SpawnedCreatures { get { return new Array<WorldCreatureEntityModel>(this[nameof(SpawnedCreatures)].Address); } }
    }
    public class ScheduledGameEvent : Object
    {
        public ScheduledGameEvent(ulong addr) : base(addr) { }
        public int Day { get { return this[nameof(Day)].GetValue<int>(); } set { this[nameof(Day)].SetValue<int>(value); } }
        public int GameEventDataId { get { return this[nameof(GameEventDataId)].GetValue<int>(); } set { this[nameof(GameEventDataId)].SetValue<int>(value); } }
        public Object GameEventEntityId { get { return this[nameof(GameEventEntityId)]; } set { this[nameof(GameEventEntityId)] = value; } }
    }
    public class GenerationConfig : Object
    {
        public GenerationConfig(ulong addr) : base(addr) { }
        public int WorldSize { get { return this[nameof(WorldSize)].GetValue<int>(); } set { this[nameof(WorldSize)].SetValue<int>(value); } }
        public int LayoutSpraySpacing { get { return this[nameof(LayoutSpraySpacing)].GetValue<int>(); } set { this[nameof(LayoutSpraySpacing)].SetValue<int>(value); } }
        public int NoiseStepCount { get { return this[nameof(NoiseStepCount)].GetValue<int>(); } set { this[nameof(NoiseStepCount)].SetValue<int>(value); } }
        public int NeighborCornerCount { get { return this[nameof(NeighborCornerCount)].GetValue<int>(); } set { this[nameof(NeighborCornerCount)].SetValue<int>(value); } }
        public int WorldBoundsRange { get { return this[nameof(WorldBoundsRange)].GetValue<int>(); } set { this[nameof(WorldBoundsRange)].SetValue<int>(value); } }
        public int LowPassageCornerCount { get { return this[nameof(LowPassageCornerCount)].GetValue<int>(); } set { this[nameof(LowPassageCornerCount)].SetValue<int>(value); } }
        public int MinNetworkSpacing { get { return this[nameof(MinNetworkSpacing)].GetValue<int>(); } set { this[nameof(MinNetworkSpacing)].SetValue<int>(value); } }
        public int MaxNetworkSpacing { get { return this[nameof(MaxNetworkSpacing)].GetValue<int>(); } set { this[nameof(MaxNetworkSpacing)].SetValue<int>(value); } }
        public float LandRatio { get { return this[nameof(LandRatio)].GetValue<float>(); } set { this[nameof(LandRatio)].SetValue<float>(value); } }
        public int MinSuperRegionSize { get { return this[nameof(MinSuperRegionSize)].GetValue<int>(); } set { this[nameof(MinSuperRegionSize)].SetValue<int>(value); } }
        public int MaxSuperRegionSize { get { return this[nameof(MaxSuperRegionSize)].GetValue<int>(); } set { this[nameof(MaxSuperRegionSize)].SetValue<int>(value); } }
        public int MinBeachSuperRegionSize { get { return this[nameof(MinBeachSuperRegionSize)].GetValue<int>(); } set { this[nameof(MinBeachSuperRegionSize)].SetValue<int>(value); } }
        public int MaxBeachSuperRegionSize { get { return this[nameof(MaxBeachSuperRegionSize)].GetValue<int>(); } set { this[nameof(MaxBeachSuperRegionSize)].SetValue<int>(value); } }
        public int MinRiftIsolatedSuperRegionSize { get { return this[nameof(MinRiftIsolatedSuperRegionSize)].GetValue<int>(); } set { this[nameof(MinRiftIsolatedSuperRegionSize)].SetValue<int>(value); } }
        public int MaxRiftIsolatedSuperRegionSize { get { return this[nameof(MaxRiftIsolatedSuperRegionSize)].GetValue<int>(); } set { this[nameof(MaxRiftIsolatedSuperRegionSize)].SetValue<int>(value); } }
        public int MinRegularSuperRegionWidth { get { return this[nameof(MinRegularSuperRegionWidth)].GetValue<int>(); } set { this[nameof(MinRegularSuperRegionWidth)].SetValue<int>(value); } }
        public int MaxRegularSuperRegionWidth { get { return this[nameof(MaxRegularSuperRegionWidth)].GetValue<int>(); } set { this[nameof(MaxRegularSuperRegionWidth)].SetValue<int>(value); } }
        public int MaxRemainingSuperRegionWidth { get { return this[nameof(MaxRemainingSuperRegionWidth)].GetValue<int>(); } set { this[nameof(MaxRemainingSuperRegionWidth)].SetValue<int>(value); } }
        public int GatedMinDistFromVillage { get { return this[nameof(GatedMinDistFromVillage)].GetValue<int>(); } set { this[nameof(GatedMinDistFromVillage)].SetValue<int>(value); } }
        public int MinDistFromVillageScaleTarget { get { return this[nameof(MinDistFromVillageScaleTarget)].GetValue<int>(); } set { this[nameof(MinDistFromVillageScaleTarget)].SetValue<int>(value); } }
        public int MonoRegionMaxSize { get { return this[nameof(MonoRegionMaxSize)].GetValue<int>(); } set { this[nameof(MonoRegionMaxSize)].SetValue<int>(value); } }
        public int RiftIsolationRadius { get { return this[nameof(RiftIsolationRadius)].GetValue<int>(); } set { this[nameof(RiftIsolationRadius)].SetValue<int>(value); } }
        public int BridgeIsolationRadius { get { return this[nameof(BridgeIsolationRadius)].GetValue<int>(); } set { this[nameof(BridgeIsolationRadius)].SetValue<int>(value); } }
        public int MinBridgeLength { get { return this[nameof(MinBridgeLength)].GetValue<int>(); } set { this[nameof(MinBridgeLength)].SetValue<int>(value); } }
        public int MaxBridgeLength { get { return this[nameof(MaxBridgeLength)].GetValue<int>(); } set { this[nameof(MaxBridgeLength)].SetValue<int>(value); } }
        public int BridgeStep { get { return this[nameof(BridgeStep)].GetValue<int>(); } set { this[nameof(BridgeStep)].SetValue<int>(value); } }
        public int BridgeHazardId { get { return this[nameof(BridgeHazardId)].GetValue<int>(); } set { this[nameof(BridgeHazardId)].SetValue<int>(value); } }
        public int MinElevationSize { get { return this[nameof(MinElevationSize)].GetValue<int>(); } set { this[nameof(MinElevationSize)].SetValue<int>(value); } }
        public int MaxElevationSize { get { return this[nameof(MaxElevationSize)].GetValue<int>(); } set { this[nameof(MaxElevationSize)].SetValue<int>(value); } }
        public int LakeMinDistanceFromCoast { get { return this[nameof(LakeMinDistanceFromCoast)].GetValue<int>(); } set { this[nameof(LakeMinDistanceFromCoast)].SetValue<int>(value); } }
        public int LakeRadius { get { return this[nameof(LakeRadius)].GetValue<int>(); } set { this[nameof(LakeRadius)].SetValue<int>(value); } }
        public int LakeNoiseTreshold { get { return this[nameof(LakeNoiseTreshold)].GetValue<int>(); } set { this[nameof(LakeNoiseTreshold)].SetValue<int>(value); } }
        public float LakeFallOff { get { return this[nameof(LakeFallOff)].GetValue<float>(); } set { this[nameof(LakeFallOff)].SetValue<float>(value); } }
        public int RiverProgressionDivider { get { return this[nameof(RiverProgressionDivider)].GetValue<int>(); } set { this[nameof(RiverProgressionDivider)].SetValue<int>(value); } }
        public int MinRiverRadius { get { return this[nameof(MinRiverRadius)].GetValue<int>(); } set { this[nameof(MinRiverRadius)].SetValue<int>(value); } }
        public int MaxRiverRadius { get { return this[nameof(MaxRiverRadius)].GetValue<int>(); } set { this[nameof(MaxRiverRadius)].SetValue<int>(value); } }
        public bool bIsDedicatedServer { get { return this[nameof(bIsDedicatedServer)].Flag; } set { this[nameof(bIsDedicatedServer)].Flag = value; } }
        public float HeightsNoiseRatio { get { return this[nameof(HeightsNoiseRatio)].GetValue<float>(); } set { this[nameof(HeightsNoiseRatio)].SetValue<float>(value); } }
        public ushort MinNoiseHeightLockRadius { get { return this[nameof(MinNoiseHeightLockRadius)].GetValue<ushort>(); } set { this[nameof(MinNoiseHeightLockRadius)].SetValue<ushort>(value); } }
        public ushort MaxNoiseHeightLockRadius { get { return this[nameof(MaxNoiseHeightLockRadius)].GetValue<ushort>(); } set { this[nameof(MaxNoiseHeightLockRadius)].SetValue<ushort>(value); } }
        public Array<Vector> RespawnPosOffset { get { return new Array<Vector>(this[nameof(RespawnPosOffset)].Address); } }
        public Array<Vector> ShrineTeleportOffset { get { return new Array<Vector>(this[nameof(ShrineTeleportOffset)].Address); } }
        public Array<Vector> VillageShrineTeleportOffset { get { return new Array<Vector>(this[nameof(VillageShrineTeleportOffset)].Address); } }
        public Vector VillageShrineOffset { get { return this[nameof(VillageShrineOffset)].As<Vector>(); } set { this["VillageShrineOffset"] = value; } }
        public float MinGiantDistance { get { return this[nameof(MinGiantDistance)].GetValue<float>(); } set { this[nameof(MinGiantDistance)].SetValue<float>(value); } }
        public float MaxGiantDistance { get { return this[nameof(MaxGiantDistance)].GetValue<float>(); } set { this[nameof(MaxGiantDistance)].SetValue<float>(value); } }
        public int GiantPathStep { get { return this[nameof(GiantPathStep)].GetValue<int>(); } set { this[nameof(GiantPathStep)].SetValue<int>(value); } }
        public float GiantPathsSpacing { get { return this[nameof(GiantPathsSpacing)].GetValue<float>(); } set { this[nameof(GiantPathsSpacing)].SetValue<float>(value); } }
        public ushort RampSafeRadius { get { return this[nameof(RampSafeRadius)].GetValue<ushort>(); } set { this[nameof(RampSafeRadius)].SetValue<ushort>(value); } }
        public Object BarricadeRatios { get { return this[nameof(BarricadeRatios)]; } set { this[nameof(BarricadeRatios)] = value; } }
        public ushort CaveEntranceSafeRange { get { return this[nameof(CaveEntranceSafeRange)].GetValue<ushort>(); } set { this[nameof(CaveEntranceSafeRange)].SetValue<ushort>(value); } }
        public float MinRoadWeight { get { return this[nameof(MinRoadWeight)].GetValue<float>(); } set { this[nameof(MinRoadWeight)].SetValue<float>(value); } }
        public float MaxRoadWeight { get { return this[nameof(MaxRoadWeight)].GetValue<float>(); } set { this[nameof(MaxRoadWeight)].SetValue<float>(value); } }
        public float MinRoadAdjWeight { get { return this[nameof(MinRoadAdjWeight)].GetValue<float>(); } set { this[nameof(MinRoadAdjWeight)].SetValue<float>(value); } }
        public float MaxRoadAdjWeight { get { return this[nameof(MaxRoadAdjWeight)].GetValue<float>(); } set { this[nameof(MaxRoadAdjWeight)].SetValue<float>(value); } }
        public int LocalHeightsRadius { get { return this[nameof(LocalHeightsRadius)].GetValue<int>(); } set { this[nameof(LocalHeightsRadius)].SetValue<int>(value); } }
        public int LocalHeightsNoiseTreshold { get { return this[nameof(LocalHeightsNoiseTreshold)].GetValue<int>(); } set { this[nameof(LocalHeightsNoiseTreshold)].SetValue<int>(value); } }
        public float LocalHeightsFallOff { get { return this[nameof(LocalHeightsFallOff)].GetValue<float>(); } set { this[nameof(LocalHeightsFallOff)].SetValue<float>(value); } }
        public int MinEntranceCliffSize { get { return this[nameof(MinEntranceCliffSize)].GetValue<int>(); } set { this[nameof(MinEntranceCliffSize)].SetValue<int>(value); } }
        public int MaxEntranceCliffSize { get { return this[nameof(MaxEntranceCliffSize)].GetValue<int>(); } set { this[nameof(MaxEntranceCliffSize)].SetValue<int>(value); } }
        public float EntranceCliffFalloff { get { return this[nameof(EntranceCliffFalloff)].GetValue<float>(); } set { this[nameof(EntranceCliffFalloff)].SetValue<float>(value); } }
        public float ShallowsFrequency { get { return this[nameof(ShallowsFrequency)].GetValue<float>(); } set { this[nameof(ShallowsFrequency)].SetValue<float>(value); } }
        public int ShallowsOctaves { get { return this[nameof(ShallowsOctaves)].GetValue<int>(); } set { this[nameof(ShallowsOctaves)].SetValue<int>(value); } }
        public float ShallowsLacunarity { get { return this[nameof(ShallowsLacunarity)].GetValue<float>(); } set { this[nameof(ShallowsLacunarity)].SetValue<float>(value); } }
        public float ShallowsPersistence { get { return this[nameof(ShallowsPersistence)].GetValue<float>(); } set { this[nameof(ShallowsPersistence)].SetValue<float>(value); } }
        public float AddedShallowsTreshold { get { return this[nameof(AddedShallowsTreshold)].GetValue<float>(); } set { this[nameof(AddedShallowsTreshold)].SetValue<float>(value); } }
        public int PuddlesRadius { get { return this[nameof(PuddlesRadius)].GetValue<int>(); } set { this[nameof(PuddlesRadius)].SetValue<int>(value); } }
        public int PuddlesNoiseTreshold { get { return this[nameof(PuddlesNoiseTreshold)].GetValue<int>(); } set { this[nameof(PuddlesNoiseTreshold)].SetValue<int>(value); } }
        public float PuddlesFallOff { get { return this[nameof(PuddlesFallOff)].GetValue<float>(); } set { this[nameof(PuddlesFallOff)].SetValue<float>(value); } }
        public float PuddleNoise { get { return this[nameof(PuddleNoise)].GetValue<float>(); } set { this[nameof(PuddleNoise)].SetValue<float>(value); } }
        public ushort DefaultBiomeId { get { return this[nameof(DefaultBiomeId)].GetValue<ushort>(); } set { this[nameof(DefaultBiomeId)].SetValue<ushort>(value); } }
        public float GroundDetailRatio { get { return this[nameof(GroundDetailRatio)].GetValue<float>(); } set { this[nameof(GroundDetailRatio)].SetValue<float>(value); } }
        public int MaxBeachWidth { get { return this[nameof(MaxBeachWidth)].GetValue<int>(); } set { this[nameof(MaxBeachWidth)].SetValue<int>(value); } }
        public int BeachSmoothingRatio { get { return this[nameof(BeachSmoothingRatio)].GetValue<int>(); } set { this[nameof(BeachSmoothingRatio)].SetValue<int>(value); } }
        public int BeachSlopeLength { get { return this[nameof(BeachSlopeLength)].GetValue<int>(); } set { this[nameof(BeachSlopeLength)].SetValue<int>(value); } }
        public bool bDoSpawnMythBossModule { get { return this[nameof(bDoSpawnMythBossModule)].Flag; } set { this[nameof(bDoSpawnMythBossModule)].Flag = value; } }
        public bool bDoSpawnBifrostModule { get { return this[nameof(bDoSpawnBifrostModule)].Flag; } set { this[nameof(bDoSpawnBifrostModule)].Flag = value; } }
        public float QuestGiverSpawnRatio { get { return this[nameof(QuestGiverSpawnRatio)].GetValue<float>(); } set { this[nameof(QuestGiverSpawnRatio)].SetValue<float>(value); } }
        public int MaxModulesSpawnTries { get { return this[nameof(MaxModulesSpawnTries)].GetValue<int>(); } set { this[nameof(MaxModulesSpawnTries)].SetValue<int>(value); } }
        public int ModulesSpacingCheck { get { return this[nameof(ModulesSpacingCheck)].GetValue<int>(); } set { this[nameof(ModulesSpacingCheck)].SetValue<int>(value); } }
        public Object ModuleStreamerClass { get { return this[nameof(ModuleStreamerClass)]; } set { this[nameof(ModuleStreamerClass)] = value; } }
        public Vector2D YggdrasilOffset { get { return this[nameof(YggdrasilOffset)].As<Vector2D>(); } set { this["YggdrasilOffset"] = value; } }
        public Vector2D VillageSecondRadiusOffset { get { return this[nameof(VillageSecondRadiusOffset)].As<Vector2D>(); } set { this["VillageSecondRadiusOffset"] = value; } }
        public int VillageFirstRadius { get { return this[nameof(VillageFirstRadius)].GetValue<int>(); } set { this[nameof(VillageFirstRadius)].SetValue<int>(value); } }
        public int VillageSecondRadius { get { return this[nameof(VillageSecondRadius)].GetValue<int>(); } set { this[nameof(VillageSecondRadius)].SetValue<int>(value); } }
        public int GenericCaveEntranceId { get { return this[nameof(GenericCaveEntranceId)].GetValue<int>(); } set { this[nameof(GenericCaveEntranceId)].SetValue<int>(value); } }
        public float TrapsSpacing { get { return this[nameof(TrapsSpacing)].GetValue<float>(); } set { this[nameof(TrapsSpacing)].SetValue<float>(value); } }
        public int TrapCheckRadius { get { return this[nameof(TrapCheckRadius)].GetValue<int>(); } set { this[nameof(TrapCheckRadius)].SetValue<int>(value); } }
        public int TrapHazardId { get { return this[nameof(TrapHazardId)].GetValue<int>(); } set { this[nameof(TrapHazardId)].SetValue<int>(value); } }
        public int TrapRadius { get { return this[nameof(TrapRadius)].GetValue<int>(); } set { this[nameof(TrapRadius)].SetValue<int>(value); } }
        public int TrapNoiseTreshold { get { return this[nameof(TrapNoiseTreshold)].GetValue<int>(); } set { this[nameof(TrapNoiseTreshold)].SetValue<int>(value); } }
        public float TrapFallOff { get { return this[nameof(TrapFallOff)].GetValue<float>(); } set { this[nameof(TrapFallOff)].SetValue<float>(value); } }
        public int SpawnPointCheckedRadius { get { return this[nameof(SpawnPointCheckedRadius)].GetValue<int>(); } set { this[nameof(SpawnPointCheckedRadius)].SetValue<int>(value); } }
        public int CreaturesSpacing { get { return this[nameof(CreaturesSpacing)].GetValue<int>(); } set { this[nameof(CreaturesSpacing)].SetValue<int>(value); } }
        public float MinPacksSpacing { get { return this[nameof(MinPacksSpacing)].GetValue<float>(); } set { this[nameof(MinPacksSpacing)].SetValue<float>(value); } }
        public float VillagePacksSafe { get { return this[nameof(VillagePacksSafe)].GetValue<float>(); } set { this[nameof(VillagePacksSafe)].SetValue<float>(value); } }
        public float GroupedSlotTreshold { get { return this[nameof(GroupedSlotTreshold)].GetValue<float>(); } set { this[nameof(GroupedSlotTreshold)].SetValue<float>(value); } }
        public int OnRoadLandmarkRotationOffset { get { return this[nameof(OnRoadLandmarkRotationOffset)].GetValue<int>(); } set { this[nameof(OnRoadLandmarkRotationOffset)].SetValue<int>(value); } }
        public float GroupedFrequency { get { return this[nameof(GroupedFrequency)].GetValue<float>(); } set { this[nameof(GroupedFrequency)].SetValue<float>(value); } }
        public int GroupedOctaves { get { return this[nameof(GroupedOctaves)].GetValue<int>(); } set { this[nameof(GroupedOctaves)].SetValue<int>(value); } }
        public float GroupedLacunarity { get { return this[nameof(GroupedLacunarity)].GetValue<float>(); } set { this[nameof(GroupedLacunarity)].SetValue<float>(value); } }
        public float GroupedPersistence { get { return this[nameof(GroupedPersistence)].GetValue<float>(); } set { this[nameof(GroupedPersistence)].SetValue<float>(value); } }
        public float DefaultWeight { get { return this[nameof(DefaultWeight)].GetValue<float>(); } set { this[nameof(DefaultWeight)].SetValue<float>(value); } }
        public float BeachShoreMaxWeight { get { return this[nameof(BeachShoreMaxWeight)].GetValue<float>(); } set { this[nameof(BeachShoreMaxWeight)].SetValue<float>(value); } }
        public float GroundFrequency { get { return this[nameof(GroundFrequency)].GetValue<float>(); } set { this[nameof(GroundFrequency)].SetValue<float>(value); } }
        public int GroundOctaves { get { return this[nameof(GroundOctaves)].GetValue<int>(); } set { this[nameof(GroundOctaves)].SetValue<int>(value); } }
        public float GroundLacunarity { get { return this[nameof(GroundLacunarity)].GetValue<float>(); } set { this[nameof(GroundLacunarity)].SetValue<float>(value); } }
        public float GroundPersistence { get { return this[nameof(GroundPersistence)].GetValue<float>(); } set { this[nameof(GroundPersistence)].SetValue<float>(value); } }
        public float MinFoliageScale { get { return this[nameof(MinFoliageScale)].GetValue<float>(); } set { this[nameof(MinFoliageScale)].SetValue<float>(value); } }
        public int TerrainCliffOffset { get { return this[nameof(TerrainCliffOffset)].GetValue<int>(); } set { this[nameof(TerrainCliffOffset)].SetValue<int>(value); } }
        public int GeometryCliffPlatformOffset { get { return this[nameof(GeometryCliffPlatformOffset)].GetValue<int>(); } set { this[nameof(GeometryCliffPlatformOffset)].SetValue<int>(value); } }
        public int GeometryCliffWallOffset { get { return this[nameof(GeometryCliffWallOffset)].GetValue<int>(); } set { this[nameof(GeometryCliffWallOffset)].SetValue<int>(value); } }
        public int GeometryShorePlatformOffset { get { return this[nameof(GeometryShorePlatformOffset)].GetValue<int>(); } set { this[nameof(GeometryShorePlatformOffset)].SetValue<int>(value); } }
        public int WaterHeight { get { return this[nameof(WaterHeight)].GetValue<int>(); } set { this[nameof(WaterHeight)].SetValue<int>(value); } }
        public float ShallowsOffset { get { return this[nameof(ShallowsOffset)].GetValue<float>(); } set { this[nameof(ShallowsOffset)].SetValue<float>(value); } }
        public float EdgeInnerRatio { get { return this[nameof(EdgeInnerRatio)].GetValue<float>(); } set { this[nameof(EdgeInnerRatio)].SetValue<float>(value); } }
        public float EdgeOuterRatio { get { return this[nameof(EdgeOuterRatio)].GetValue<float>(); } set { this[nameof(EdgeOuterRatio)].SetValue<float>(value); } }
        public int BeachShoreHeight { get { return this[nameof(BeachShoreHeight)].GetValue<int>(); } set { this[nameof(BeachShoreHeight)].SetValue<int>(value); } }
        public int BeachShoreTreshold { get { return this[nameof(BeachShoreTreshold)].GetValue<int>(); } set { this[nameof(BeachShoreTreshold)].SetValue<int>(value); } }
        public Object OceanAudioSourceClass { get { return this[nameof(OceanAudioSourceClass)]; } set { this[nameof(OceanAudioSourceClass)] = value; } }
        public Object FogPPVClass { get { return this[nameof(FogPPVClass)]; } set { this[nameof(FogPPVClass)] = value; } }
        public Object GenericBridgeEdgeClass { get { return this[nameof(GenericBridgeEdgeClass)]; } set { this[nameof(GenericBridgeEdgeClass)] = value; } }
        public Object GenericBridgeMiddleClass { get { return this[nameof(GenericBridgeMiddleClass)]; } set { this[nameof(GenericBridgeMiddleClass)] = value; } }
        public StaticMesh DebugMesh { get { return this[nameof(DebugMesh)].As<StaticMesh>(); } set { this["DebugMesh"] = value; } }
        public Object CornerDebugActor { get { return this[nameof(CornerDebugActor)]; } set { this[nameof(CornerDebugActor)] = value; } }
        public int DebugSeed { get { return this[nameof(DebugSeed)].GetValue<int>(); } set { this[nameof(DebugSeed)].SetValue<int>(value); } }
        public bool bDebugCorners { get { return this[nameof(bDebugCorners)].Flag; } set { this[nameof(bDebugCorners)].Flag = value; } }
    }
    public class GeoPropConfigRow : TableRowBase
    {
        public GeoPropConfigRow(ulong addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public StaticMesh SecondaryStaticMesh { get { return this[nameof(SecondaryStaticMesh)].As<StaticMesh>(); } set { this["SecondaryStaticMesh"] = value; } }
        public EGeoPropType Type { get { return (EGeoPropType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ushort Height { get { return this[nameof(Height)].GetValue<ushort>(); } set { this[nameof(Height)].SetValue<ushort>(value); } }
        public int StencilValue { get { return this[nameof(StencilValue)].GetValue<int>(); } set { this[nameof(StencilValue)].SetValue<int>(value); } }
        public int SecondaryStencilValue { get { return this[nameof(SecondaryStencilValue)].GetValue<int>(); } set { this[nameof(SecondaryStencilValue)].SetValue<int>(value); } }
    }
    public class GroundDetailConfigRow : TableRowBase
    {
        public GroundDetailConfigRow(ulong addr) : base(addr) { }
        public Array<StaticMesh> StaticMeshes { get { return new Array<StaticMesh>(this[nameof(StaticMeshes)].Address); } }
        public EGroundDetailType Type { get { return (EGroundDetailType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
        public int XYOffset { get { return this[nameof(XYOffset)].GetValue<int>(); } set { this[nameof(XYOffset)].SetValue<int>(value); } }
        public float ZOffset { get { return this[nameof(ZOffset)].GetValue<float>(); } set { this[nameof(ZOffset)].SetValue<float>(value); } }
        public int StencilValue { get { return this[nameof(StencilValue)].GetValue<int>(); } set { this[nameof(StencilValue)].SetValue<int>(value); } }
        public Array<int> Levels { get { return new Array<int>(this[nameof(Levels)].Address); } }
    }
    public class LandmarkConfigRow : TableRowBase
    {
        public LandmarkConfigRow(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Array<Object> Variants { get { return new Array<Object>(this[nameof(Variants)].Address); } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
        public int XYOffset { get { return this[nameof(XYOffset)].GetValue<int>(); } set { this[nameof(XYOffset)].SetValue<int>(value); } }
        public int MinYaw { get { return this[nameof(MinYaw)].GetValue<int>(); } set { this[nameof(MinYaw)].SetValue<int>(value); } }
        public int MaxYaw { get { return this[nameof(MaxYaw)].GetValue<int>(); } set { this[nameof(MaxYaw)].SetValue<int>(value); } }
        public int HazardId { get { return this[nameof(HazardId)].GetValue<int>(); } set { this[nameof(HazardId)].SetValue<int>(value); } }
        public ELandmarkType Type { get { return (ELandmarkType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bIsReplicated { get { return this[nameof(bIsReplicated)].Flag; } set { this[nameof(bIsReplicated)].Flag = value; } }
    }
    public class FoliageConfigRow : TableRowBase
    {
        public FoliageConfigRow(ulong addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
        public EFoliageType Type { get { return (EFoliageType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bCanBeScaled { get { return this[nameof(bCanBeScaled)].Flag; } set { this[nameof(bCanBeScaled)].Flag = value; } }
        public int StencilValue { get { return this[nameof(StencilValue)].GetValue<int>(); } set { this[nameof(StencilValue)].SetValue<int>(value); } }
        public bool bUseDynamicMaterial { get { return this[nameof(bUseDynamicMaterial)].Flag; } set { this[nameof(bUseDynamicMaterial)].Flag = value; } }
    }
    public class BiomeConfigRow : TableRowBase
    {
        public BiomeConfigRow(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public MaterialInstance TitleMaterial { get { return this[nameof(TitleMaterial)].As<MaterialInstance>(); } set { this["TitleMaterial"] = value; } }
        public bool bIsFoggy { get { return this[nameof(bIsFoggy)].Flag; } set { this[nameof(bIsFoggy)].Flag = value; } }
        public float HeightsRatio { get { return this[nameof(HeightsRatio)].GetValue<float>(); } set { this[nameof(HeightsRatio)].SetValue<float>(value); } }
        public float PuddlesRatio { get { return this[nameof(PuddlesRatio)].GetValue<float>(); } set { this[nameof(PuddlesRatio)].SetValue<float>(value); } }
        public float BaseFoliageFrequency { get { return this[nameof(BaseFoliageFrequency)].GetValue<float>(); } set { this[nameof(BaseFoliageFrequency)].SetValue<float>(value); } }
        public float SpecificFoliageFrequency { get { return this[nameof(SpecificFoliageFrequency)].GetValue<float>(); } set { this[nameof(SpecificFoliageFrequency)].SetValue<float>(value); } }
        public DataTable FoliageConfig { get { return this[nameof(FoliageConfig)].As<DataTable>(); } set { this["FoliageConfig"] = value; } }
        public float LandmarkRatio { get { return this[nameof(LandmarkRatio)].GetValue<float>(); } set { this[nameof(LandmarkRatio)].SetValue<float>(value); } }
        public DataTable LandmarksConfig { get { return this[nameof(LandmarksConfig)].As<DataTable>(); } set { this["LandmarksConfig"] = value; } }
        public int MinOnRoadStep { get { return this[nameof(MinOnRoadStep)].GetValue<int>(); } set { this[nameof(MinOnRoadStep)].SetValue<int>(value); } }
        public int MaxOnRoadStep { get { return this[nameof(MaxOnRoadStep)].GetValue<int>(); } set { this[nameof(MaxOnRoadStep)].SetValue<int>(value); } }
        public DataTable GroundDetailsConfig { get { return this[nameof(GroundDetailsConfig)].As<DataTable>(); } set { this["GroundDetailsConfig"] = value; } }
        public DataTable GeoPropsConfig { get { return this[nameof(GeoPropsConfig)].As<DataTable>(); } set { this["GeoPropsConfig"] = value; } }
        public LinearColor BlendColor { get { return this[nameof(BlendColor)].As<LinearColor>(); } set { this["BlendColor"] = value; } }
        public MaterialInstance TerrainMaterial { get { return this[nameof(TerrainMaterial)].As<MaterialInstance>(); } set { this["TerrainMaterial"] = value; } }
        public Texture2D TerrainTexture { get { return this[nameof(TerrainTexture)].As<Texture2D>(); } set { this["TerrainTexture"] = value; } }
        public Texture2D WorldMapTexture { get { return this[nameof(WorldMapTexture)].As<Texture2D>(); } set { this["WorldMapTexture"] = value; } }
        public Texture2D WorldMapPathTexture { get { return this[nameof(WorldMapPathTexture)].As<Texture2D>(); } set { this["WorldMapPathTexture"] = value; } }
        public Object SFXName { get { return this[nameof(SFXName)]; } set { this[nameof(SFXName)] = value; } }
    }
    public class CaveEntranceData : Object
    {
        public CaveEntranceData(ulong addr) : base(addr) { }
        public HazardData HazardData { get { return this[nameof(HazardData)].As<HazardData>(); } set { this["HazardData"] = value; } }
        public ECardinal EntranceDirection { get { return (ECardinal)this[nameof(EntranceDirection)].GetValue<int>(); } set { this[nameof(EntranceDirection)].SetValue<int>((int)value); } }
        public int WorldCaveId { get { return this[nameof(WorldCaveId)].GetValue<int>(); } set { this[nameof(WorldCaveId)].SetValue<int>(value); } }
        public CaveEntityModel CaveEntityModel { get { return this[nameof(CaveEntityModel)].As<CaveEntityModel>(); } set { this["CaveEntityModel"] = value; } }
    }
    public class HazardData : Object
    {
        public HazardData(ulong addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public int HazardId { get { return this[nameof(HazardId)].GetValue<int>(); } set { this[nameof(HazardId)].SetValue<int>(value); } }
        public EPOIType POIType { get { return (EPOIType)this[nameof(POIType)].GetValue<int>(); } set { this[nameof(POIType)].SetValue<int>((int)value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public HazardEntityModel HazardEntityModel { get { return this[nameof(HazardEntityModel)].As<HazardEntityModel>(); } set { this["HazardEntityModel"] = value; } }
    }
    public class POIData : Object
    {
        public POIData(ulong addr) : base(addr) { }
        public int POIId { get { return this[nameof(POIId)].GetValue<int>(); } set { this[nameof(POIId)].SetValue<int>(value); } }
        public EPOIType POIType { get { return (EPOIType)this[nameof(POIType)].GetValue<int>(); } set { this[nameof(POIType)].SetValue<int>((int)value); } }
        public Vector WorldPos { get { return this[nameof(WorldPos)].As<Vector>(); } set { this["WorldPos"] = value; } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
    }
    public class InstancedMeshData : Object
    {
        public InstancedMeshData(ulong addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public bool bCollisionDetection { get { return this[nameof(bCollisionDetection)].Flag; } set { this[nameof(bCollisionDetection)].Flag = value; } }
        public bool bInstanceMaterialDynamic { get { return this[nameof(bInstanceMaterialDynamic)].Flag; } set { this[nameof(bInstanceMaterialDynamic)].Flag = value; } }
        public int StencilValue { get { return this[nameof(StencilValue)].GetValue<int>(); } set { this[nameof(StencilValue)].SetValue<int>(value); } }
    }
    public class ParticleSystemData : Object
    {
        public ParticleSystemData(ulong addr) : base(addr) { }
        public ParticleSystem ParticleSystem { get { return this[nameof(ParticleSystem)].As<ParticleSystem>(); } set { this["ParticleSystem"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public bool bRenderCustomDepth { get { return this[nameof(bRenderCustomDepth)].Flag; } set { this[nameof(bRenderCustomDepth)].Flag = value; } }
        public int CustomDepthStencilValue { get { return this[nameof(CustomDepthStencilValue)].GetValue<int>(); } set { this[nameof(CustomDepthStencilValue)].SetValue<int>(value); } }
    }
    public class DecoPropData : Object
    {
        public DecoPropData(ulong addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
    }
    public class ModuleCreatureSpawnPoint : Object
    {
        public ModuleCreatureSpawnPoint(ulong addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public bool bIsBoss { get { return this[nameof(bIsBoss)].Flag; } set { this[nameof(bIsBoss)].Flag = value; } }
        public bool bIsElite { get { return this[nameof(bIsElite)].Flag; } set { this[nameof(bIsElite)].Flag = value; } }
        public bool bIsRange { get { return this[nameof(bIsRange)].Flag; } set { this[nameof(bIsRange)].Flag = value; } }
    }
    public class SurfaceData : Object
    {
        public SurfaceData(ulong addr) : base(addr) { }
        public Object SurfaceActor { get { return this[nameof(SurfaceActor)]; } set { this[nameof(SurfaceActor)] = value; } }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<int> Triangles { get { return new Array<int>(this[nameof(Triangles)].Address); } }
        public Array<bool> Status { get { return new Array<bool>(this[nameof(Status)].Address); } }
        public IntPoint Dimensions { get { return this[nameof(Dimensions)].As<IntPoint>(); } set { this["Dimensions"] = value; } }
        public IntPoint ChunkCoords { get { return this[nameof(ChunkCoords)].As<IntPoint>(); } set { this["ChunkCoords"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public int AttackStatId { get { return this[nameof(AttackStatId)].GetValue<int>(); } set { this[nameof(AttackStatId)].SetValue<int>(value); } }
        public int HazardSourceId { get { return this[nameof(HazardSourceId)].GetValue<int>(); } set { this[nameof(HazardSourceId)].SetValue<int>(value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public HazardEntityModel EntityModel { get { return this[nameof(EntityModel)].As<HazardEntityModel>(); } set { this["EntityModel"] = value; } }
    }
    public class ResourceData : Object
    {
        public ResourceData(ulong addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public WorldMaterialSourceEntityModel MaterialSourceEntityModel { get { return this[nameof(MaterialSourceEntityModel)].As<WorldMaterialSourceEntityModel>(); } set { this["MaterialSourceEntityModel"] = value; } }
    }
    public class PropData : Object
    {
        public PropData(ulong addr) : base(addr) { }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public int BiomeId { get { return this[nameof(BiomeId)].GetValue<int>(); } set { this[nameof(BiomeId)].SetValue<int>(value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
    }
    public class GeometrySectionData : Object
    {
        public GeometrySectionData(ulong addr) : base(addr) { }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<int> Triangles { get { return new Array<int>(this[nameof(Triangles)].Address); } }
    }
    public class TerrainSectionData : Object
    {
        public TerrainSectionData(ulong addr) : base(addr) { }
        public int SectionId { get { return this[nameof(SectionId)].GetValue<int>(); } set { this[nameof(SectionId)].SetValue<int>(value); } }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<int> Triangles { get { return new Array<int>(this[nameof(Triangles)].Address); } }
        public Array<Color> Colors { get { return new Array<Color>(this[nameof(Colors)].Address); } }
    }
    public class BiomeBorderData : Object
    {
        public BiomeBorderData(ulong addr) : base(addr) { }
        public int RedBiome { get { return this[nameof(RedBiome)].GetValue<int>(); } set { this[nameof(RedBiome)].SetValue<int>(value); } }
        public int GreenBiome { get { return this[nameof(GreenBiome)].GetValue<int>(); } set { this[nameof(GreenBiome)].SetValue<int>(value); } }
        public int BlueBiome { get { return this[nameof(BlueBiome)].GetValue<int>(); } set { this[nameof(BlueBiome)].SetValue<int>(value); } }
        public int BlackBiome { get { return this[nameof(BlackBiome)].GetValue<int>(); } set { this[nameof(BlackBiome)].SetValue<int>(value); } }
    }
    public class CreatureLayoutElement : Object
    {
        public CreatureLayoutElement(ulong addr) : base(addr) { }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public int BehaviourId { get { return this[nameof(BehaviourId)].GetValue<int>(); } set { this[nameof(BehaviourId)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public ERespawnMode RespawnMode { get { return (ERespawnMode)this[nameof(RespawnMode)].GetValue<int>(); } set { this[nameof(RespawnMode)].SetValue<int>((int)value); } }
    }
    public class HazardLayoutElement : Object
    {
        public HazardLayoutElement(ulong addr) : base(addr) { }
        public int HazardId { get { return this[nameof(HazardId)].GetValue<int>(); } set { this[nameof(HazardId)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public EAdjustmentMethod AdjustmentMethod { get { return (EAdjustmentMethod)this[nameof(AdjustmentMethod)].GetValue<int>(); } set { this[nameof(AdjustmentMethod)].SetValue<int>((int)value); } }
    }
    public class HealthComponent_RepProperties : Object
    {
        public HealthComponent_RepProperties(ulong addr) : base(addr) { }
        public bool InDownState { get { return this[nameof(InDownState)].Flag; } set { this[nameof(InDownState)].Flag = value; } }
        public float currentHealth { get { return this[nameof(currentHealth)].GetValue<float>(); } set { this[nameof(currentHealth)].SetValue<float>(value); } }
        public float DefaultHealth { get { return this[nameof(DefaultHealth)].GetValue<float>(); } set { this[nameof(DefaultHealth)].SetValue<float>(value); } }
        public bool IsDead { get { return this[nameof(IsDead)].Flag; } set { this[nameof(IsDead)].Flag = value; } }
    }
    public class ControllerAudioVibration : Object
    {
        public ControllerAudioVibration(ulong addr) : base(addr) { }
        public Object Sound { get { return this[nameof(Sound)]; } set { this[nameof(Sound)] = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
    }
    public class InputEffectsColorParams : Object
    {
        public InputEffectsColorParams(ulong addr) : base(addr) { }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public float PulsesPerSecond { get { return this[nameof(PulsesPerSecond)].GetValue<float>(); } set { this[nameof(PulsesPerSecond)].SetValue<float>(value); } }
    }
    public class InputEffectsTriggerParams : Object
    {
        public InputEffectsTriggerParams(ulong addr) : base(addr) { }
        public Object TriggerMode { get { return this[nameof(TriggerMode)]; } set { this[nameof(TriggerMode)] = value; } }
        public EInputEffectsTriggerMask TriggerMask { get { return (EInputEffectsTriggerMask)this[nameof(TriggerMask)].GetValue<int>(); } set { this[nameof(TriggerMask)].SetValue<int>((int)value); } }
        public Array<int> Values { get { return new Array<int>(this[nameof(Values)].Address); } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
    }
    public class GridPoint : Object
    {
        public GridPoint(ulong addr) : base(addr) { }
    }
    public class TextureDescription : Object
    {
        public TextureDescription(ulong addr) : base(addr) { }
    }
    public class BorderMaterialData : Object
    {
        public BorderMaterialData(ulong addr) : base(addr) { }
        public BiomeBorderData AreaBiomeData { get { return this[nameof(AreaBiomeData)].As<BiomeBorderData>(); } set { this["AreaBiomeData"] = value; } }
        public MaterialInstanceDynamic Material { get { return this[nameof(Material)].As<MaterialInstanceDynamic>(); } set { this["Material"] = value; } }
    }
    public class MaterialSource_RepProperties : Object
    {
        public MaterialSource_RepProperties(ulong addr) : base(addr) { }
        public bool bIsHarvested { get { return this[nameof(bIsHarvested)].Flag; } set { this[nameof(bIsHarvested)].Flag = value; } }
        public int AlternativeState { get { return this[nameof(AlternativeState)].GetValue<int>(); } set { this[nameof(AlternativeState)].SetValue<int>(value); } }
        public bool bIsFirstRefresh { get { return this[nameof(bIsFirstRefresh)].Flag; } set { this[nameof(bIsFirstRefresh)].Flag = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class ModuleParticleSystem : Object
    {
        public ModuleParticleSystem(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public ParticleSystem ParticleSystem { get { return this[nameof(ParticleSystem)].As<ParticleSystem>(); } set { this["ParticleSystem"] = value; } }
        public bool bRenderCustomDepth { get { return this[nameof(bRenderCustomDepth)].Flag; } set { this[nameof(bRenderCustomDepth)].Flag = value; } }
        public int CustomDepthStencilValue { get { return this[nameof(CustomDepthStencilValue)].GetValue<int>(); } set { this[nameof(CustomDepthStencilValue)].SetValue<int>(value); } }
    }
    public class ModuleMaterialSource : Object
    {
        public ModuleMaterialSource(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
        public Object Class { get { return this[nameof(Class)]; } set { this[nameof(Class)] = value; } }
    }
    public class ModuleLeverReceiver : Object
    {
        public ModuleLeverReceiver(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public Object LeverReceiverId { get { return this[nameof(LeverReceiverId)]; } set { this[nameof(LeverReceiverId)] = value; } }
        public Object Class { get { return this[nameof(Class)]; } set { this[nameof(Class)] = value; } }
    }
    public class ModuleLever : Object
    {
        public ModuleLever(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public Object LeverId { get { return this[nameof(LeverId)]; } set { this[nameof(LeverId)] = value; } }
        public Object LeverReceiverId { get { return this[nameof(LeverReceiverId)]; } set { this[nameof(LeverReceiverId)] = value; } }
        public Object Class { get { return this[nameof(Class)]; } set { this[nameof(Class)] = value; } }
    }
    public class ModuleHazard : Object
    {
        public ModuleHazard(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public int HazardDataId { get { return this[nameof(HazardDataId)].GetValue<int>(); } set { this[nameof(HazardDataId)].SetValue<int>(value); } }
    }
    public class ModuleCreature : Object
    {
        public ModuleCreature(ulong addr) : base(addr) { }
        public int TransformId { get { return this[nameof(TransformId)].GetValue<int>(); } set { this[nameof(TransformId)].SetValue<int>(value); } }
        public int CreatureDataId { get { return this[nameof(CreatureDataId)].GetValue<int>(); } set { this[nameof(CreatureDataId)].SetValue<int>(value); } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
    }
    public class PlayerLootChestInfo : Object
    {
        public PlayerLootChestInfo(ulong addr) : base(addr) { }
        public Object UserId { get { return this[nameof(UserId)]; } set { this[nameof(UserId)] = value; } }
        public Object ContainerId { get { return this[nameof(ContainerId)]; } set { this[nameof(ContainerId)] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
    }
    public class LootInfoData : Object
    {
        public LootInfoData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Array<ContainerEntityModel> Containers { get { return new Array<ContainerEntityModel>(this[nameof(Containers)].Address); } }
        public float MinDistance { get { return this[nameof(MinDistance)].GetValue<float>(); } set { this[nameof(MinDistance)].SetValue<float>(value); } }
        public Array<Object> ExcludedUserIds { get { return new Array<Object>(this[nameof(ExcludedUserIds)].Address); } }
    }
    public class ProfilingTimer : Object
    {
        public ProfilingTimer(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public long StartTime { get { return this[nameof(StartTime)].GetValue<long>(); } set { this[nameof(StartTime)].SetValue<long>(value); } }
        public long EndTime { get { return this[nameof(EndTime)].GetValue<long>(); } set { this[nameof(EndTime)].SetValue<long>(value); } }
        public long ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<long>(); } set { this[nameof(ElapsedTime)].SetValue<long>(value); } }
    }
    public class QuestCollection : Object
    {
        public QuestCollection(ulong addr) : base(addr) { }
        public Array<QuestBehaviorBase> Collection { get { return new Array<QuestBehaviorBase>(this[nameof(Collection)].Address); } }
    }
    public class NeighborData : Object
    {
        public NeighborData(ulong addr) : base(addr) { }
    }
    public class ReplicatedPropBase_RepProperties : Object
    {
        public ReplicatedPropBase_RepProperties(ulong addr) : base(addr) { }
        public int BiomeId { get { return this[nameof(BiomeId)].GetValue<int>(); } set { this[nameof(BiomeId)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
    }
    public class RespawnableCallbacks : Object
    {
        public RespawnableCallbacks(ulong addr) : base(addr) { }
        public Array<Object> Callbacks { get { return new Array<Object>(this[nameof(Callbacks)].Address); } }
    }
    public class WorldSeenItems : Object
    {
        public WorldSeenItems(ulong addr) : base(addr) { }
        public Array<Object> SeenItems { get { return new Array<Object>(this[nameof(SeenItems)].Address); } }
    }
    public class PendingCreatures : Object
    {
        public PendingCreatures(ulong addr) : base(addr) { }
        public WorldCreatureEntityModel CreatureEntity { get { return this[nameof(CreatureEntity)].As<WorldCreatureEntityModel>(); } set { this["CreatureEntity"] = value; } }
        public Object ChunkEntityId { get { return this[nameof(ChunkEntityId)]; } set { this[nameof(ChunkEntityId)] = value; } }
        public int AttemptCount { get { return this[nameof(AttemptCount)].GetValue<int>(); } set { this[nameof(AttemptCount)].SetValue<int>(value); } }
        public bool bIsWaitingToSpawn { get { return this[nameof(bIsWaitingToSpawn)].Flag; } set { this[nameof(bIsWaitingToSpawn)].Flag = value; } }
    }
    public class SummonedPack : Object
    {
        public SummonedPack(ulong addr) : base(addr) { }
    }
    public class StreamingLayer : Object
    {
        public StreamingLayer(ulong addr) : base(addr) { }
        public Object Provider { get { return this[nameof(Provider)]; } set { this[nameof(Provider)] = value; } }
        public Object Builder { get { return this[nameof(Builder)]; } set { this[nameof(Builder)] = value; } }
        public int Priority { get { return this[nameof(Priority)].GetValue<int>(); } set { this[nameof(Priority)].SetValue<int>(value); } }
        public float ZIndex { get { return this[nameof(ZIndex)].GetValue<float>(); } set { this[nameof(ZIndex)].SetValue<float>(value); } }
        public bool bOnServerOnly { get { return this[nameof(bOnServerOnly)].Flag; } set { this[nameof(bOnServerOnly)].Flag = value; } }
        public bool bOnControlledTargetOnly { get { return this[nameof(bOnControlledTargetOnly)].Flag; } set { this[nameof(bOnControlledTargetOnly)].Flag = value; } }
        public bool bActive { get { return this[nameof(bActive)].Flag; } set { this[nameof(bActive)].Flag = value; } }
    }
    public class TimeManager_ScheduledEvent : Object
    {
        public TimeManager_ScheduledEvent(ulong addr) : base(addr) { }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
    }
    public class TOMArticle : Object
    {
        public TOMArticle(ulong addr) : base(addr) { }
        public Object Header { get { return this[nameof(Header)]; } set { this[nameof(Header)] = value; } }
        public Object Body { get { return this[nameof(Body)]; } set { this[nameof(Body)] = value; } }
        public Object Summary { get { return this[nameof(Summary)]; } set { this[nameof(Summary)] = value; } }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
    }
    public class CaveProperties : Object
    {
        public CaveProperties(ulong addr) : base(addr) { }
        public CaveBase CurrentCaveActor { get { return this[nameof(CurrentCaveActor)].As<CaveBase>(); } set { this["CurrentCaveActor"] = value; } }
        public bool bIsInCave { get { return this[nameof(bIsInCave)].Flag; } set { this[nameof(bIsInCave)].Flag = value; } }
    }
    public class CreatureProperties : Object
    {
        public CreatureProperties(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
    }
    public class ForceMoveParam : Object
    {
        public ForceMoveParam(ulong addr) : base(addr) { }
        public Vector ForceMoveStartingPoint { get { return this[nameof(ForceMoveStartingPoint)].As<Vector>(); } set { this["ForceMoveStartingPoint"] = value; } }
        public Vector ForceMoveEndPoint { get { return this[nameof(ForceMoveEndPoint)].As<Vector>(); } set { this["ForceMoveEndPoint"] = value; } }
        public float ForceMoveAlpha { get { return this[nameof(ForceMoveAlpha)].GetValue<float>(); } set { this[nameof(ForceMoveAlpha)].SetValue<float>(value); } }
        public bool bCanFallOff { get { return this[nameof(bCanFallOff)].Flag; } set { this[nameof(bCanFallOff)].Flag = value; } }
        public bool bMoveThroughCharacter { get { return this[nameof(bMoveThroughCharacter)].Flag; } set { this[nameof(bMoveThroughCharacter)].Flag = value; } }
        public bool bUseGravity { get { return this[nameof(bUseGravity)].Flag; } set { this[nameof(bUseGravity)].Flag = value; } }
        public bool bSweep { get { return this[nameof(bSweep)].Flag; } set { this[nameof(bSweep)].Flag = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float ForceMoveStartTime { get { return this[nameof(ForceMoveStartTime)].GetValue<float>(); } set { this[nameof(ForceMoveStartTime)].SetValue<float>(value); } }
    }
    public class TOMLobbyCharacterData : Object
    {
        public TOMLobbyCharacterData(ulong addr) : base(addr) { }
        public UserAvatarVO Avatar { get { return this[nameof(Avatar)].As<UserAvatarVO>(); } set { this["Avatar"] = value; } }
        public Object UserId { get { return this[nameof(UserId)]; } set { this[nameof(UserId)] = value; } }
        public int SeasonLevel { get { return this[nameof(SeasonLevel)].GetValue<int>(); } set { this[nameof(SeasonLevel)].SetValue<int>(value); } }
        public Array<int> EquipementIds { get { return new Array<int>(this[nameof(EquipementIds)].Address); } }
    }
    public class TOMLobbyChacterData : Object
    {
        public TOMLobbyChacterData(ulong addr) : base(addr) { }
        public UserAvatarVO Avatar { get { return this[nameof(Avatar)].As<UserAvatarVO>(); } set { this["Avatar"] = value; } }
        public Array<int> EquipementIds { get { return new Array<int>(this[nameof(EquipementIds)].Address); } }
    }
    public class TOMMenuNotificationPath : Object
    {
        public TOMMenuNotificationPath(ulong addr) : base(addr) { }
        public Array<Object> Path { get { return new Array<Object>(this[nameof(Path)].Address); } }
    }
    public class TOMPlayerState_RepProperties : Object
    {
        public TOMPlayerState_RepProperties(ulong addr) : base(addr) { }
        public UserVO UserVO { get { return this[nameof(UserVO)].As<UserVO>(); } set { this["UserVO"] = value; } }
        public Object UserContext { get { return this[nameof(UserContext)]; } set { this[nameof(UserContext)] = value; } }
        public WorldPlayerVO WorldPlayerVO { get { return this[nameof(WorldPlayerVO)].As<WorldPlayerVO>(); } set { this["WorldPlayerVO"] = value; } }
        public Object WorldPlayerContext { get { return this[nameof(WorldPlayerContext)]; } set { this[nameof(WorldPlayerContext)] = value; } }
    }
    public class WorldCaveData : Object
    {
        public WorldCaveData(ulong addr) : base(addr) { }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public int CaveDataId { get { return this[nameof(CaveDataId)].GetValue<int>(); } set { this[nameof(CaveDataId)].SetValue<int>(value); } }
        public Array<CaveEntrance> CaveEntrances { get { return new Array<CaveEntrance>(this[nameof(CaveEntrances)].Address); } }
    }
    public class UserBlueprint : Object
    {
        public UserBlueprint(ulong addr) : base(addr) { }
        public int FragmentAmount { get { return this[nameof(FragmentAmount)].GetValue<int>(); } set { this[nameof(FragmentAmount)].SetValue<int>(value); } }
        public bool IsUnlocked { get { return this[nameof(IsUnlocked)].Flag; } set { this[nameof(IsUnlocked)].Flag = value; } }
        public bool IsComplete { get { return this[nameof(IsComplete)].Flag; } set { this[nameof(IsComplete)].Flag = value; } }
    }
    public class UserSaveSlots : Object
    {
        public UserSaveSlots(ulong addr) : base(addr) { }
        public WorldVO SeasonSoloWorld { get { return this[nameof(SeasonSoloWorld)].As<WorldVO>(); } set { this["SeasonSoloWorld"] = value; } }
        public WorldVO SeasonMultiWorld { get { return this[nameof(SeasonMultiWorld)].As<WorldVO>(); } set { this["SeasonMultiWorld"] = value; } }
        public Array<WorldVO> CustomWorlds { get { return new Array<WorldVO>(this[nameof(CustomWorlds)].Address); } }
        public Array<WorldVO> CreativeWorlds { get { return new Array<WorldVO>(this[nameof(CreativeWorlds)].Address); } }
    }
    public class VoiceDevice : Object
    {
        public VoiceDevice(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class BiomeDistributionRule : Object
    {
        public BiomeDistributionRule(ulong addr) : base(addr) { }
    }
    public class WorldDifficultySettings : Object
    {
        public WorldDifficultySettings(ulong addr) : base(addr) { }
        public float YggdrasilDecayAmount { get { return this[nameof(YggdrasilDecayAmount)].GetValue<float>(); } set { this[nameof(YggdrasilDecayAmount)].SetValue<float>(value); } }
        public float YggdrasilDecayRate { get { return this[nameof(YggdrasilDecayRate)].GetValue<float>(); } set { this[nameof(YggdrasilDecayRate)].SetValue<float>(value); } }
        public float QuestsCooldownModifier { get { return this[nameof(QuestsCooldownModifier)].GetValue<float>(); } set { this[nameof(QuestsCooldownModifier)].SetValue<float>(value); } }
        public float MaterialMultiplier { get { return this[nameof(MaterialMultiplier)].GetValue<float>(); } set { this[nameof(MaterialMultiplier)].SetValue<float>(value); } }
        public float OfferingLootMultiplier { get { return this[nameof(OfferingLootMultiplier)].GetValue<float>(); } set { this[nameof(OfferingLootMultiplier)].SetValue<float>(value); } }
        public int MaterialRespawnModifier { get { return this[nameof(MaterialRespawnModifier)].GetValue<int>(); } set { this[nameof(MaterialRespawnModifier)].SetValue<int>(value); } }
        public float MinionAttackMultiplier { get { return this[nameof(MinionAttackMultiplier)].GetValue<float>(); } set { this[nameof(MinionAttackMultiplier)].SetValue<float>(value); } }
        public float MinionArmorMultiplier { get { return this[nameof(MinionArmorMultiplier)].GetValue<float>(); } set { this[nameof(MinionArmorMultiplier)].SetValue<float>(value); } }
        public float MinionHPMultiplier { get { return this[nameof(MinionHPMultiplier)].GetValue<float>(); } set { this[nameof(MinionHPMultiplier)].SetValue<float>(value); } }
        public float MythBossAttackMultiplier { get { return this[nameof(MythBossAttackMultiplier)].GetValue<float>(); } set { this[nameof(MythBossAttackMultiplier)].SetValue<float>(value); } }
        public float MythBossArmorMultiplier { get { return this[nameof(MythBossArmorMultiplier)].GetValue<float>(); } set { this[nameof(MythBossArmorMultiplier)].SetValue<float>(value); } }
        public float MythBossHPMultiplier { get { return this[nameof(MythBossHPMultiplier)].GetValue<float>(); } set { this[nameof(MythBossHPMultiplier)].SetValue<float>(value); } }
        public float CreatureAttackMultiplier { get { return this[nameof(CreatureAttackMultiplier)].GetValue<float>(); } set { this[nameof(CreatureAttackMultiplier)].SetValue<float>(value); } }
        public float CreatureArmorMultiplier { get { return this[nameof(CreatureArmorMultiplier)].GetValue<float>(); } set { this[nameof(CreatureArmorMultiplier)].SetValue<float>(value); } }
        public float CreatureHPMultiplier { get { return this[nameof(CreatureHPMultiplier)].GetValue<float>(); } set { this[nameof(CreatureHPMultiplier)].SetValue<float>(value); } }
        public float GiantAttackMultiplier { get { return this[nameof(GiantAttackMultiplier)].GetValue<float>(); } set { this[nameof(GiantAttackMultiplier)].SetValue<float>(value); } }
        public float GiantArmorMultiplier { get { return this[nameof(GiantArmorMultiplier)].GetValue<float>(); } set { this[nameof(GiantArmorMultiplier)].SetValue<float>(value); } }
        public float GiantHPMultiplier { get { return this[nameof(GiantHPMultiplier)].GetValue<float>(); } set { this[nameof(GiantHPMultiplier)].SetValue<float>(value); } }
        public float GiantXPOnKill { get { return this[nameof(GiantXPOnKill)].GetValue<float>(); } set { this[nameof(GiantXPOnKill)].SetValue<float>(value); } }
        public float GiantSpawnDelay { get { return this[nameof(GiantSpawnDelay)].GetValue<float>(); } set { this[nameof(GiantSpawnDelay)].SetValue<float>(value); } }
        public float GiantLevelMultiplier { get { return this[nameof(GiantLevelMultiplier)].GetValue<float>(); } set { this[nameof(GiantLevelMultiplier)].SetValue<float>(value); } }
        public float MinionMinIntervalMultiplier { get { return this[nameof(MinionMinIntervalMultiplier)].GetValue<float>(); } set { this[nameof(MinionMinIntervalMultiplier)].SetValue<float>(value); } }
        public float MinionMaxIntervalMultiplier { get { return this[nameof(MinionMaxIntervalMultiplier)].GetValue<float>(); } set { this[nameof(MinionMaxIntervalMultiplier)].SetValue<float>(value); } }
        public float MinionMaxPerNightMultiplier { get { return this[nameof(MinionMaxPerNightMultiplier)].GetValue<float>(); } set { this[nameof(MinionMaxPerNightMultiplier)].SetValue<float>(value); } }
        public int EventsDurationModifier { get { return this[nameof(EventsDurationModifier)].GetValue<int>(); } set { this[nameof(EventsDurationModifier)].SetValue<int>(value); } }
        public int EventsDayModifier { get { return this[nameof(EventsDayModifier)].GetValue<int>(); } set { this[nameof(EventsDayModifier)].SetValue<int>(value); } }
        public int CreaturePackCountModifier { get { return this[nameof(CreaturePackCountModifier)].GetValue<int>(); } set { this[nameof(CreaturePackCountModifier)].SetValue<int>(value); } }
        public float ArtifactLootMultiplier { get { return this[nameof(ArtifactLootMultiplier)].GetValue<float>(); } set { this[nameof(ArtifactLootMultiplier)].SetValue<float>(value); } }
        public float MaterialSourcesRespawnModifier { get { return this[nameof(MaterialSourcesRespawnModifier)].GetValue<float>(); } set { this[nameof(MaterialSourcesRespawnModifier)].SetValue<float>(value); } }
        public float AnimalRespawnModifier { get { return this[nameof(AnimalRespawnModifier)].GetValue<float>(); } set { this[nameof(AnimalRespawnModifier)].SetValue<float>(value); } }
        public float NPCAttackMultiplier { get { return this[nameof(NPCAttackMultiplier)].GetValue<float>(); } set { this[nameof(NPCAttackMultiplier)].SetValue<float>(value); } }
        public float NPCArmorMultiplier { get { return this[nameof(NPCArmorMultiplier)].GetValue<float>(); } set { this[nameof(NPCArmorMultiplier)].SetValue<float>(value); } }
        public float NPCHPMultiplier { get { return this[nameof(NPCHPMultiplier)].GetValue<float>(); } set { this[nameof(NPCHPMultiplier)].SetValue<float>(value); } }
        public float XPMultiplier { get { return this[nameof(XPMultiplier)].GetValue<float>(); } set { this[nameof(XPMultiplier)].SetValue<float>(value); } }
        public bool SpawnGiants { get { return this[nameof(SpawnGiants)].Flag; } set { this[nameof(SpawnGiants)].Flag = value; } }
        public bool SpawnMinions { get { return this[nameof(SpawnMinions)].Flag; } set { this[nameof(SpawnMinions)].Flag = value; } }
        public int DeadLootChest { get { return this[nameof(DeadLootChest)].GetValue<int>(); } set { this[nameof(DeadLootChest)].SetValue<int>(value); } }
    }
    public class SuperRegion : Object
    {
        public SuperRegion(ulong addr) : base(addr) { }
    }
    public class PingMapInfo : Object
    {
        public PingMapInfo(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Vector WorldPos { get { return this[nameof(WorldPos)].As<Vector>(); } set { this["WorldPos"] = value; } }
        public EMapPingType MapPingType { get { return (EMapPingType)this[nameof(MapPingType)].GetValue<int>(); } set { this[nameof(MapPingType)].SetValue<int>((int)value); } }
    }
    public class MovingNPCMapInfo : Object
    {
        public MovingNPCMapInfo(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public bool IsDead { get { return this[nameof(IsDead)].Flag; } set { this[nameof(IsDead)].Flag = value; } }
        public Actor ActorRef { get { return this[nameof(ActorRef)].As<Actor>(); } set { this["ActorRef"] = value; } }
        public bool bIsCharacter { get { return this[nameof(bIsCharacter)].Flag; } set { this[nameof(bIsCharacter)].Flag = value; } }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public int ForcedZOrder { get { return this[nameof(ForcedZOrder)].GetValue<int>(); } set { this[nameof(ForcedZOrder)].SetValue<int>(value); } }
        public EAppearOnWorldMapIconWidgetType IconWidgetType { get { return (EAppearOnWorldMapIconWidgetType)this[nameof(IconWidgetType)].GetValue<int>(); } set { this[nameof(IconWidgetType)].SetValue<int>((int)value); } }
    }
    public class ConstructionMapInfo : Object
    {
        public ConstructionMapInfo(ulong addr) : base(addr) { }
        public Object ConstructionEntityId { get { return this[nameof(ConstructionEntityId)]; } set { this[nameof(ConstructionEntityId)] = value; } }
        public int GiantDetectionRange { get { return this[nameof(GiantDetectionRange)].GetValue<int>(); } set { this[nameof(GiantDetectionRange)].SetValue<int>(value); } }
        public int ConstructionId { get { return this[nameof(ConstructionId)].GetValue<int>(); } set { this[nameof(ConstructionId)].SetValue<int>(value); } }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class PlayerMarkerInfo : Object
    {
        public PlayerMarkerInfo(ulong addr) : base(addr) { }
        public Object UserId { get { return this[nameof(UserId)]; } set { this[nameof(UserId)] = value; } }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int IconId { get { return this[nameof(IconId)].GetValue<int>(); } set { this[nameof(IconId)].SetValue<int>(value); } }
    }
    public class GameEventMapInfo : Object
    {
        public GameEventMapInfo(ulong addr) : base(addr) { }
        public Object GameEventId { get { return this[nameof(GameEventId)]; } set { this[nameof(GameEventId)] = value; } }
        public int GameEventDataId { get { return this[nameof(GameEventDataId)].GetValue<int>(); } set { this[nameof(GameEventDataId)].SetValue<int>(value); } }
        public float EventEndDate { get { return this[nameof(EventEndDate)].GetValue<float>(); } set { this[nameof(EventEndDate)].SetValue<float>(value); } }
        public Array<GameEventZone> GameEventZones { get { return new Array<GameEventZone>(this[nameof(GameEventZones)].Address); } }
    }
    public class PlayerMapInfo : Object
    {
        public PlayerMapInfo(ulong addr) : base(addr) { }
        public Object UserId { get { return this[nameof(UserId)]; } set { this[nameof(UserId)] = value; } }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public float YawAngle { get { return this[nameof(YawAngle)].GetValue<float>(); } set { this[nameof(YawAngle)].SetValue<float>(value); } }
        public int IconId { get { return this[nameof(IconId)].GetValue<int>(); } set { this[nameof(IconId)].SetValue<int>(value); } }
        public bool IsDown { get { return this[nameof(IsDown)].Flag; } set { this[nameof(IsDown)].Flag = value; } }
        public bool IsDead { get { return this[nameof(IsDead)].Flag; } set { this[nameof(IsDead)].Flag = value; } }
    }
    public class POIIcon : Object
    {
        public POIIcon(ulong addr) : base(addr) { }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object CooldownIcon { get { return this[nameof(CooldownIcon)]; } set { this[nameof(CooldownIcon)] = value; } }
        public Object Decal { get { return this[nameof(Decal)]; } set { this[nameof(Decal)] = value; } }
        public POIData POIData { get { return this[nameof(POIData)].As<POIData>(); } set { this["POIData"] = value; } }
        public int ZOrder { get { return this[nameof(ZOrder)].GetValue<int>(); } set { this[nameof(ZOrder)].SetValue<int>(value); } }
    }
    public class PingWidget : Object
    {
        public PingWidget(ulong addr) : base(addr) { }
        public UserWidget PingWidget_value { get { return this[nameof(PingWidget)].As<UserWidget>(); } set { this["PingWidget"] = value; } }
    }
    public class GameEventWidget : Object
    {
        public GameEventWidget(ulong addr) : base(addr) { }
        public UserWidget GameEventWidget_value { get { return this[nameof(GameEventWidget)].As<UserWidget>(); } set { this["GameEventWidget"] = value; } }
        public DynamicMapIconBaseWidget GameEventIcon { get { return this[nameof(GameEventIcon)].As<DynamicMapIconBaseWidget>(); } set { this["GameEventIcon"] = value; } }
    }
    public class ModuleDistributionData : Object
    {
        public ModuleDistributionData(ulong addr) : base(addr) { }
    }
    public class WorldShrine_RepProperties : Object
    {
        public WorldShrine_RepProperties(ulong addr) : base(addr) { }
        public EEntityActionType ActionType { get { return (EEntityActionType)this[nameof(ActionType)].GetValue<int>(); } set { this[nameof(ActionType)].SetValue<int>((int)value); } }
        public Object EntityId { get { return this[nameof(EntityId)]; } set { this[nameof(EntityId)] = value; } }
        public WorldShrineVO Entity { get { return this[nameof(Entity)].As<WorldShrineVO>(); } set { this["Entity"] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
    }
}
