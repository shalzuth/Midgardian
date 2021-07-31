using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapARPinSDK
{
    public class MagicLeapARPinComponent : SceneComponent
    {
        public MagicLeapARPinComponent(ulong addr) : base(addr) { }
        public Object ObjectUID { get { return this[nameof(ObjectUID)]; } set { this[nameof(ObjectUID)] = value; } }
        public int UserIndex { get { return this[nameof(UserIndex)].GetValue<int>(); } set { this[nameof(UserIndex)].SetValue<int>(value); } }
        public EMagicLeapAutoPinType AutoPinType { get { return (EMagicLeapAutoPinType)this[nameof(AutoPinType)].GetValue<int>(); } set { this[nameof(AutoPinType)].SetValue<int>((int)value); } }
        public bool bShouldPinActor { get { return this[nameof(bShouldPinActor)].Flag; } set { this[nameof(bShouldPinActor)].Flag = value; } }
        public Object PinDataClass { get { return this[nameof(PinDataClass)]; } set { this[nameof(PinDataClass)] = value; } }
        public Object SearchPinTypes { get { return this[nameof(SearchPinTypes)]; } set { this[nameof(SearchPinTypes)] = value; } }
        public SphereComponent SearchVolume { get { return this[nameof(SearchVolume)].As<SphereComponent>(); } set { this["SearchVolume"] = value; } }
        public Object OnPersistentEntityPinned { get { return this[nameof(OnPersistentEntityPinned)]; } set { this[nameof(OnPersistentEntityPinned)] = value; } }
        public Object OnPersistentEntityPinLost { get { return this[nameof(OnPersistentEntityPinLost)]; } set { this[nameof(OnPersistentEntityPinLost)] = value; } }
        public Object OnPinDataLoadAttemptCompleted { get { return this[nameof(OnPinDataLoadAttemptCompleted)]; } set { this[nameof(OnPinDataLoadAttemptCompleted)] = value; } }
        public Guid PinnedCFUID { get { return this[nameof(PinnedCFUID)].As<Guid>(); } set { this["PinnedCFUID"] = value; } }
        public SceneComponent PinnedSceneComponent { get { return this[nameof(PinnedSceneComponent)].As<SceneComponent>(); } set { this["PinnedSceneComponent"] = value; } }
        public MagicLeapARPinSaveGame PinData { get { return this[nameof(PinData)].As<MagicLeapARPinSaveGame>(); } set { this["PinData"] = value; } }
        public void UnPin() { Invoke(nameof(UnPin)); }
        public MagicLeapARPinSaveGame TryGetPinData(Object InPinDataClass, bool OutPinDataValid) { return Invoke<MagicLeapARPinSaveGame>(nameof(TryGetPinData), InPinDataClass, OutPinDataValid); }
        public bool PinToRestoredOrSyncedID() { return Invoke<bool>(nameof(PinToRestoredOrSyncedID)); }
        public bool PinToID(Guid PinId) { return Invoke<bool>(nameof(PinToID), PinId); }
        public void PinToBestFit() { Invoke(nameof(PinToBestFit)); }
        public bool PinSceneComponent(SceneComponent ComponentToPin) { return Invoke<bool>(nameof(PinSceneComponent), ComponentToPin); }
        public bool PinRestoredOrSynced() { return Invoke<bool>(nameof(PinRestoredOrSynced)); }
        public bool PinActor(Actor ActorToPin) { return Invoke<bool>(nameof(PinActor), ActorToPin); }
        public void PersistentEntityPinned__DelegateSignature(bool bRestoredOrSynced) { Invoke(nameof(PersistentEntityPinned__DelegateSignature), bRestoredOrSynced); }
        public void PersistentEntityPinLost__DelegateSignature() { Invoke(nameof(PersistentEntityPinLost__DelegateSignature)); }
        public void MagicLeapARPinDataLoadAttemptCompleted__DelegateSignature(bool bDataRestored) { Invoke(nameof(MagicLeapARPinDataLoadAttemptCompleted__DelegateSignature), bDataRestored); }
        public bool IsPinned() { return Invoke<bool>(nameof(IsPinned)); }
        public bool GetPinState(MagicLeapARPinState State) { return Invoke<bool>(nameof(GetPinState), State); }
        public bool GetPinnedPinID(Guid PinId) { return Invoke<bool>(nameof(GetPinnedPinID), PinId); }
        public MagicLeapARPinSaveGame GetPinData(Object PinDataClass) { return Invoke<MagicLeapARPinSaveGame>(nameof(GetPinData), PinDataClass); }
        public void AttemptPinDataRestorationAsync() { Invoke(nameof(AttemptPinDataRestorationAsync)); }
        public bool AttemptPinDataRestoration() { return Invoke<bool>(nameof(AttemptPinDataRestoration)); }
    }
    public class MagicLeapARPinFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapARPinFunctionLibrary(ulong addr) : base(addr) { }
        public void UnBindToOnMagicLeapContentBindingFoundDelegate(Object Delegate) { Invoke(nameof(UnBindToOnMagicLeapContentBindingFoundDelegate), Delegate); }
        public void UnBindToOnMagicLeapARPinUpdatedDelegate(Object Delegate) { Invoke(nameof(UnBindToOnMagicLeapARPinUpdatedDelegate), Delegate); }
        public EMagicLeapPassableWorldError SetGlobalQueryFilter(MagicLeapARPinQuery InGlobalFilter) { return Invoke<EMagicLeapPassableWorldError>(nameof(SetGlobalQueryFilter), InGlobalFilter); }
        public void SetContentBindingSaveGameUserIndex(int UserIndex) { Invoke(nameof(SetContentBindingSaveGameUserIndex), UserIndex); }
        public EMagicLeapPassableWorldError QueryARPins(MagicLeapARPinQuery Query, Array<Guid> Pins) { return Invoke<EMagicLeapPassableWorldError>(nameof(QueryARPins), Query, Pins); }
        public bool ParseStringToARPinId(Object PinIdString, Guid ARPinId) { return Invoke<bool>(nameof(ParseStringToARPinId), PinIdString, ARPinId); }
        public bool IsTrackerValid() { return Invoke<bool>(nameof(IsTrackerValid)); }
        public EMagicLeapPassableWorldError GetNumAvailableARPins(int Count) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetNumAvailableARPins), Count); }
        public EMagicLeapPassableWorldError GetGlobalQueryFilter(MagicLeapARPinQuery CurrentGlobalFilter) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetGlobalQueryFilter), CurrentGlobalFilter); }
        public int GetContentBindingSaveGameUserIndex() { return Invoke<int>(nameof(GetContentBindingSaveGameUserIndex)); }
        public EMagicLeapPassableWorldError GetClosestARPin(Vector SearchPoint, Guid PinId) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetClosestARPin), SearchPoint, PinId); }
        public EMagicLeapPassableWorldError GetAvailableARPins(int NumRequested, Array<Guid> Pins) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetAvailableARPins), NumRequested, Pins); }
        public Object GetARPinStateToString(MagicLeapARPinState State) { return Invoke<Object>(nameof(GetARPinStateToString), State); }
        public EMagicLeapPassableWorldError GetARPinState(Guid PinId, MagicLeapARPinState State) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetARPinState), PinId, State); }
        public bool GetARPinPositionAndOrientation_TrackingSpace(Guid PinId, Vector Position, Rotator Orientation, bool PinFoundInEnvironment) { return Invoke<bool>(nameof(GetARPinPositionAndOrientation_TrackingSpace), PinId, Position, Orientation, PinFoundInEnvironment); }
        public bool GetARPinPositionAndOrientation(Guid PinId, Vector Position, Rotator Orientation, bool PinFoundInEnvironment) { return Invoke<bool>(nameof(GetARPinPositionAndOrientation), PinId, Position, Orientation, PinFoundInEnvironment); }
        public EMagicLeapPassableWorldError DestroyTracker() { return Invoke<EMagicLeapPassableWorldError>(nameof(DestroyTracker)); }
        public EMagicLeapPassableWorldError CreateTracker() { return Invoke<EMagicLeapPassableWorldError>(nameof(CreateTracker)); }
        public void BindToOnMagicLeapContentBindingFoundDelegate(Object Delegate) { Invoke(nameof(BindToOnMagicLeapContentBindingFoundDelegate), Delegate); }
        public void BindToOnMagicLeapARPinUpdatedDelegate(Object Delegate) { Invoke(nameof(BindToOnMagicLeapARPinUpdatedDelegate), Delegate); }
        public Object ARPinIdToString(Guid ARPinId) { return Invoke<Object>(nameof(ARPinIdToString), ARPinId); }
    }
    public class MagicLeapARPinInfoActorBase : Actor
    {
        public MagicLeapARPinInfoActorBase(ulong addr) : base(addr) { }
        public Guid PinId { get { return this[nameof(PinId)].As<Guid>(); } set { this["PinId"] = value; } }
        public bool bVisibilityOverride { get { return this[nameof(bVisibilityOverride)].Flag; } set { this[nameof(bVisibilityOverride)].Flag = value; } }
        public void OnUpdateARPinState() { Invoke(nameof(OnUpdateARPinState)); }
    }
    public class MagicLeapARPinRenderer : Actor
    {
        public MagicLeapARPinRenderer(ulong addr) : base(addr) { }
        public bool bInfoActorsVisibilityOverride { get { return this[nameof(bInfoActorsVisibilityOverride)].Flag; } set { this[nameof(bInfoActorsVisibilityOverride)].Flag = value; } }
        public Object AllInfoActors { get { return this[nameof(AllInfoActors)]; } set { this[nameof(AllInfoActors)] = value; } }
        public Object ClassToSpawn { get { return this[nameof(ClassToSpawn)]; } set { this[nameof(ClassToSpawn)] = value; } }
        public void SetVisibilityOverride(bool InVisibilityOverride) { Invoke(nameof(SetVisibilityOverride), InVisibilityOverride); }
    }
    public class MagicLeapARPinSettings : Object
    {
        public MagicLeapARPinSettings(ulong addr) : base(addr) { }
        public float UpdateCheckFrequency { get { return this[nameof(UpdateCheckFrequency)].GetValue<float>(); } set { this[nameof(UpdateCheckFrequency)].SetValue<float>(value); } }
        public MagicLeapARPinState OnUpdatedEventTriggerDelta { get { return this[nameof(OnUpdatedEventTriggerDelta)].As<MagicLeapARPinState>(); } set { this["OnUpdatedEventTriggerDelta"] = value; } }
    }
    public class MagicLeapARPinSaveGame : SaveGame
    {
        public MagicLeapARPinSaveGame(ulong addr) : base(addr) { }
        public Guid PinnedID { get { return this[nameof(PinnedID)].As<Guid>(); } set { this["PinnedID"] = value; } }
        public Transform ComponentWorldTransform { get { return this[nameof(ComponentWorldTransform)].As<Transform>(); } set { this["ComponentWorldTransform"] = value; } }
        public Transform PinTransform { get { return this[nameof(PinTransform)].As<Transform>(); } set { this["PinTransform"] = value; } }
        public bool bShouldPinActor { get { return this[nameof(bShouldPinActor)].Flag; } set { this[nameof(bShouldPinActor)].Flag = value; } }
    }
    public class MagicLeapARPinContentBindings : SaveGame
    {
        public MagicLeapARPinContentBindings(ulong addr) : base(addr) { }
        public Object AllContentBindings { get { return this[nameof(AllContentBindings)]; } set { this[nameof(AllContentBindings)] = value; } }
    }
    public class MagicLeapARPinState : Object
    {
        public MagicLeapARPinState(ulong addr) : base(addr) { }
        public float Confidence { get { return this[nameof(Confidence)].GetValue<float>(); } set { this[nameof(Confidence)].SetValue<float>(value); } }
        public float ValidRadius { get { return this[nameof(ValidRadius)].GetValue<float>(); } set { this[nameof(ValidRadius)].SetValue<float>(value); } }
        public float RotationError { get { return this[nameof(RotationError)].GetValue<float>(); } set { this[nameof(RotationError)].SetValue<float>(value); } }
        public float TranslationError { get { return this[nameof(TranslationError)].GetValue<float>(); } set { this[nameof(TranslationError)].SetValue<float>(value); } }
        public EMagicLeapARPinType PinType { get { return (EMagicLeapARPinType)this[nameof(PinType)].GetValue<int>(); } set { this[nameof(PinType)].SetValue<int>((int)value); } }
    }
    public enum EMagicLeapARPinType : int
    {
        SingleUserSingleSession = 0,
        SingleUserMultiSession = 1,
        MultiUserMultiSession = 2,
        EMagicLeapARPinType_MAX = 3,
    }
    public enum EMagicLeapAutoPinType : int
    {
        OnlyOnDataRestoration = 0,
        Always = 1,
        Never = 2,
        EMagicLeapAutoPinType_MAX = 3,
    }
    public enum EMagicLeapPassableWorldError : int
    {
        None = 0,
        LowMapQuality = 1,
        UnableToLocalize = 2,
        Unavailable = 3,
        PrivilegeDenied = 4,
        InvalidParam = 5,
        UnspecifiedFailure = 6,
        PrivilegeRequestPending = 7,
        StartupPending = 8,
        SharedWorldNotEnabled = 9,
        NotImplemented = 10,
        PinNotFound = 11,
        EMagicLeapPassableWorldError_MAX = 12,
    }
    public class MagicLeapARPinQuery : Object
    {
        public MagicLeapARPinQuery(ulong addr) : base(addr) { }
        public Object Types { get { return this[nameof(Types)]; } set { this[nameof(Types)] = value; } }
        public int MaxResults { get { return this[nameof(MaxResults)].GetValue<int>(); } set { this[nameof(MaxResults)].SetValue<int>(value); } }
        public Vector TargetPoint { get { return this[nameof(TargetPoint)].As<Vector>(); } set { this["TargetPoint"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public bool bSorted { get { return this[nameof(bSorted)].Flag; } set { this[nameof(bSorted)].Flag = value; } }
    }
    public class MagicLeapARPinObjectIdList : Object
    {
        public MagicLeapARPinObjectIdList(ulong addr) : base(addr) { }
        public Object ObjectIdList { get { return this[nameof(ObjectIdList)]; } set { this[nameof(ObjectIdList)] = value; } }
    }
}
