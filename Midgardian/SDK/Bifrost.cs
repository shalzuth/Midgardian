using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.UMGSDK;
namespace SDK.Script.BifrostSDK
{
    public class Bifrost : Object
    {
        public Bifrost(ulong addr) : base(addr) { }
        public LogManager LogManager { get { return this[nameof(LogManager)].As<LogManager>(); } set { this["LogManager"] = value; } }
        public EventManager EventManager { get { return this[nameof(EventManager)].As<EventManager>(); } set { this["EventManager"] = value; } }
        public EventRequestManager EventRequestManager { get { return this[nameof(EventRequestManager)].As<EventRequestManager>(); } set { this["EventRequestManager"] = value; } }
        public Object Containers { get { return this[nameof(Containers)]; } set { this[nameof(Containers)] = value; } }
        public void UnbindEventDelegate(Object Name, Object Callback) { Invoke(nameof(UnbindEventDelegate), Name, Callback); }
        public bool IsInitialized() { return Invoke<bool>(nameof(IsInitialized)); }
        public LogManager GetLogManager() { return Invoke<LogManager>(nameof(GetLogManager)); }
        public Bifrost GetInstance() { return Invoke<Bifrost>(nameof(GetInstance)); }
        public Container GetContainer(Object Name) { return Invoke<Container>(nameof(GetContainer), Name); }
        public void BroadcastEvent(Object Name, EventArgs EventArgs) { Invoke(nameof(BroadcastEvent), Name, EventArgs); }
        public void BindEventDelegate(Object Name, Object Callback) { Invoke(nameof(BindEventDelegate), Name, Callback); }
        public Container AddContainer(Object Name) { return Invoke<Container>(nameof(AddContainer), Name); }
    }
    public class BifrostActor : Actor
    {
        public BifrostActor(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostActorComponent : ActorComponent
    {
        public BifrostActorComponent(ulong addr) : base(addr) { }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsGameReady() { return Invoke<bool>(nameof(IsGameReady)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostCharacter : Character
    {
        public BifrostCharacter(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostGameInstanceInterface : Interface
    {
        public BifrostGameInstanceInterface(ulong addr) : base(addr) { }
    }
    public class BifrostGameMode : GameMode
    {
        public BifrostGameMode(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostGameModeBase : GameModeBase
    {
        public BifrostGameModeBase(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostGameState : GameState
    {
        public BifrostGameState(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostGameStateBase : GameStateBase
    {
        public BifrostGameStateBase(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostLevelScriptActor : LevelScriptActor
    {
        public BifrostLevelScriptActor(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostObject : Object
    {
        public BifrostObject(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostPlayerController : PlayerController
    {
        public BifrostPlayerController(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostPlayerState : PlayerState
    {
        public BifrostPlayerState(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
        public GameInstance GetGameInstance(Object Class) { return Invoke<GameInstance>(nameof(GetGameInstance), Class); }
    }
    public class BifrostUserWidget : UserWidget
    {
        public BifrostUserWidget(ulong addr) : base(addr) { }
        public Object GameInstance { get { return this[nameof(GameInstance)]; } set { this[nameof(GameInstance)] = value; } }
        public void ReceiveGameReady(bool bIsReady) { Invoke(nameof(ReceiveGameReady), bIsReady); }
        public void OnPopedFromStack() { Invoke(nameof(OnPopedFromStack)); }
        public void OnGameInstanceGameReady(OnGameReadyEventArgs Args) { Invoke(nameof(OnGameInstanceGameReady), Args); }
        public bool IsStandalone() { return Invoke<bool>(nameof(IsStandalone)); }
        public bool IsServer() { return Invoke<bool>(nameof(IsServer)); }
        public bool IsListenServer() { return Invoke<bool>(nameof(IsListenServer)); }
        public bool IsDedicatedServer() { return Invoke<bool>(nameof(IsDedicatedServer)); }
        public bool IsClient() { return Invoke<bool>(nameof(IsClient)); }
    }
    public class Container : Object
    {
        public Container(ulong addr) : base(addr) { }
        public Object Bindings { get { return this[nameof(Bindings)]; } set { this[nameof(Bindings)] = value; } }
        public Object RegisteredActors { get { return this[nameof(RegisteredActors)]; } set { this[nameof(RegisteredActors)] = value; } }
        public Object ObjectsPools { get { return this[nameof(ObjectsPools)]; } set { this[nameof(ObjectsPools)] = value; } }
        public void RegisteredActor(Object ActorTagName, Actor Actor) { Invoke(nameof(RegisteredActor), ActorTagName, Actor); }
        public void RegisterClassInstance(Object Obj) { Invoke(nameof(RegisterClassInstance), Obj); }
        public bool IsRegistered(Object Class) { return Invoke<bool>(nameof(IsRegistered), Class); }
        public Actor GetRegisteredActor(Object ActorTagName) { return Invoke<Actor>(nameof(GetRegisteredActor), ActorTagName); }
        public Object GetClassInstance(Object Class) { return Invoke<Object>(nameof(GetClassInstance), Class); }
        public void Clear() { Invoke(nameof(Clear)); }
    }
    public class DataObject : Object
    {
        public DataObject(ulong addr) : base(addr) { }
        public Object Values { get { return this[nameof(Values)]; } set { this[nameof(Values)] = value; } }
        public DataObject SetVectorArray(Object ID, Array<Vector> Value) { return Invoke<DataObject>(nameof(SetVectorArray), ID, Value); }
        public DataObject SetVector(Object ID, Vector Value) { return Invoke<DataObject>(nameof(SetVector), ID, Value); }
        public DataObject SetValue(Object ID, DataValue Value) { return Invoke<DataObject>(nameof(SetValue), ID, Value); }
        public DataObject SetUInt8Array(Object ID, Array<byte> Value) { return Invoke<DataObject>(nameof(SetUInt8Array), ID, Value); }
        public DataObject SetStringArray(Object ID, Array<Object> Value) { return Invoke<DataObject>(nameof(SetStringArray), ID, Value); }
        public DataObject SetString(Object ID, Object Value) { return Invoke<DataObject>(nameof(SetString), ID, Value); }
        public DataObject SetObjectArray(Object ID, Array<DataObject> Value) { return Invoke<DataObject>(nameof(SetObjectArray), ID, Value); }
        public DataObject SetObject(Object ID, DataObject Value) { return Invoke<DataObject>(nameof(SetObject), ID, Value); }
        public DataObject SetIntPointArray(Object ID, Array<IntPoint> Value) { return Invoke<DataObject>(nameof(SetIntPointArray), ID, Value); }
        public DataObject SetIntPoint(Object ID, IntPoint Value) { return Invoke<DataObject>(nameof(SetIntPoint), ID, Value); }
        public DataObject SetIntArray(Object ID, Array<int> Value) { return Invoke<DataObject>(nameof(SetIntArray), ID, Value); }
        public DataObject SetInt(Object ID, int Value) { return Invoke<DataObject>(nameof(SetInt), ID, Value); }
        public DataObject SetFloatArray(Object ID, Array<float> Value) { return Invoke<DataObject>(nameof(SetFloatArray), ID, Value); }
        public DataObject SetFloat(Object ID, float Value) { return Invoke<DataObject>(nameof(SetFloat), ID, Value); }
        public DataObject SetBoolArray(Object ID, Array<bool> Value) { return Invoke<DataObject>(nameof(SetBoolArray), ID, Value); }
        public DataObject SetBool(Object ID, bool Value) { return Invoke<DataObject>(nameof(SetBool), ID, Value); }
        public DataObject SetArray(Object ID, Array<DataValue> Value) { return Invoke<DataObject>(nameof(SetArray), ID, Value); }
        public bool IsEmpty() { return Invoke<bool>(nameof(IsEmpty)); }
        public bool HasField(Object ID) { return Invoke<bool>(nameof(HasField), ID); }
        public Array<Vector> GetVectorArray(Object ID) { return Invoke<Array<Vector>>(nameof(GetVectorArray), ID); }
        public Vector GetVector(Object ID) { return Invoke<Vector>(nameof(GetVector), ID); }
        public Object GetValues() { return Invoke<Object>(nameof(GetValues)); }
        public DataValue GetValue(Object ID) { return Invoke<DataValue>(nameof(GetValue), ID); }
        public Array<byte> GetUInt8Array(Object ID) { return Invoke<Array<byte>>(nameof(GetUInt8Array), ID); }
        public byte GetUInt8(Object ID) { return Invoke<byte>(nameof(GetUInt8), ID); }
        public Array<Object> GetStringArray(Object ID) { return Invoke<Array<Object>>(nameof(GetStringArray), ID); }
        public Object GetString(Object ID) { return Invoke<Object>(nameof(GetString), ID); }
        public Array<DataObject> GetObjectArray(Object ID) { return Invoke<Array<DataObject>>(nameof(GetObjectArray), ID); }
        public DataObject GetObject(Object ID) { return Invoke<DataObject>(nameof(GetObject), ID); }
        public Array<IntPoint> GetIntPointArray(Object ID) { return Invoke<Array<IntPoint>>(nameof(GetIntPointArray), ID); }
        public IntPoint GetIntPoint(Object ID) { return Invoke<IntPoint>(nameof(GetIntPoint), ID); }
        public Array<int> GetIntArray(Object ID) { return Invoke<Array<int>>(nameof(GetIntArray), ID); }
        public int GetInt(Object ID) { return Invoke<int>(nameof(GetInt), ID); }
        public Array<float> GetFloatArray(Object ID) { return Invoke<Array<float>>(nameof(GetFloatArray), ID); }
        public float GetFloat(Object ID) { return Invoke<float>(nameof(GetFloat), ID); }
        public Array<bool> GetBoolArray(Object ID) { return Invoke<Array<bool>>(nameof(GetBoolArray), ID); }
        public bool GetBool(Object ID) { return Invoke<bool>(nameof(GetBool), ID); }
        public Array<DataValue> GetArray(Object ID) { return Invoke<Array<DataValue>>(nameof(GetArray), ID); }
    }
    public class DataValue : Object
    {
        public DataValue(ulong addr) : base(addr) { }
    }
    public class DataValueArray : DataValue
    {
        public DataValueArray(ulong addr) : base(addr) { }
        public Array<DataValue> Value { get { return new Array<DataValue>(this[nameof(Value)].Address); } }
    }
    public class DataValueBoolean : DataValue
    {
        public DataValueBoolean(ulong addr) : base(addr) { }
    }
    public class DataValueNull : DataValue
    {
        public DataValueNull(ulong addr) : base(addr) { }
    }
    public class DataValueNumber : DataValue
    {
        public DataValueNumber(ulong addr) : base(addr) { }
    }
    public class DataValueObject : DataValue
    {
        public DataValueObject(ulong addr) : base(addr) { }
        public DataObject Value { get { return this[nameof(Value)].As<DataObject>(); } set { this["Value"] = value; } }
    }
    public class DataValueString : DataValue
    {
        public DataValueString(ulong addr) : base(addr) { }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class ReceiverComponent : BifrostActorComponent
    {
        public ReceiverComponent(ulong addr) : base(addr) { }
        public Object OnReceivedDelegate { get { return this[nameof(OnReceivedDelegate)]; } set { this[nameof(OnReceivedDelegate)] = value; } }
        public Object OnAmountChangedDelegate { get { return this[nameof(OnAmountChangedDelegate)]; } set { this[nameof(OnAmountChangedDelegate)] = value; } }
        public Object OnLimitReachedDelegate { get { return this[nameof(OnLimitReachedDelegate)]; } set { this[nameof(OnLimitReachedDelegate)] = value; } }
        public int Channel { get { return this[nameof(Channel)].GetValue<int>(); } set { this[nameof(Channel)].SetValue<int>(value); } }
        public float Amount { get { return this[nameof(Amount)].GetValue<float>(); } set { this[nameof(Amount)].SetValue<float>(value); } }
        public float MinimumAmount { get { return this[nameof(MinimumAmount)].GetValue<float>(); } set { this[nameof(MinimumAmount)].SetValue<float>(value); } }
        public float MaximumAmount { get { return this[nameof(MaximumAmount)].GetValue<float>(); } set { this[nameof(MaximumAmount)].SetValue<float>(value); } }
        public void SetChannel(int InChannel) { Invoke(nameof(SetChannel), InChannel); }
        public void SetAmount(float InAmount) { Invoke(nameof(SetAmount), InAmount); }
        public void ReceivedDelegate__DelegateSignature(EmitterComponent Source, float IssuedAmount, HitResult HitResult) { Invoke(nameof(ReceivedDelegate__DelegateSignature), Source, IssuedAmount, HitResult); }
        public void Receive(EmitterComponent Source, float InAmount, HitResult HitResult, bool bForceReceive) { Invoke(nameof(Receive), Source, InAmount, HitResult, bForceReceive); }
        public void LimitReachedDelegate__DelegateSignature() { Invoke(nameof(LimitReachedDelegate__DelegateSignature)); }
        public bool IsMinimumLimitReached() { return Invoke<bool>(nameof(IsMinimumLimitReached)); }
        public bool IsMaximumLimitReached() { return Invoke<bool>(nameof(IsMaximumLimitReached)); }
        public bool IsLimitReached() { return Invoke<bool>(nameof(IsLimitReached)); }
        public int GetChannel() { return Invoke<int>(nameof(GetChannel)); }
        public int GetAmount() { return Invoke<int>(nameof(GetAmount)); }
        public void AmountChangedDelegate__DelegateSignature() { Invoke(nameof(AmountChangedDelegate__DelegateSignature)); }
    }
    public class DefensiveComponent : ReceiverComponent
    {
        public DefensiveComponent(ulong addr) : base(addr) { }
        public bool bInvincible { get { return this[nameof(bInvincible)].Flag; } set { this[nameof(bInvincible)].Flag = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public void SetInvincible(bool Invincible) { Invoke(nameof(SetInvincible), Invincible); }
        public bool IsInvincible() { return Invoke<bool>(nameof(IsInvincible)); }
        public float GetRadius() { return Invoke<float>(nameof(GetRadius)); }
        public void Destroy() { Invoke(nameof(Destroy)); }
    }
    public class EmissionResolverBase : BifrostObject
    {
        public EmissionResolverBase(ulong addr) : base(addr) { }
        public bool Resolve(ReceiverComponent Target) { return Invoke<bool>(nameof(Resolve), Target); }
    }
    public class EmissionResolverInterface : Interface
    {
        public EmissionResolverInterface(ulong addr) : base(addr) { }
    }
    public class EmitterComponent : BifrostActorComponent
    {
        public EmitterComponent(ulong addr) : base(addr) { }
        public Object OnEmitterStartedDelegate { get { return this[nameof(OnEmitterStartedDelegate)]; } set { this[nameof(OnEmitterStartedDelegate)] = value; } }
        public Object OnEmissionStartedDelegate { get { return this[nameof(OnEmissionStartedDelegate)]; } set { this[nameof(OnEmissionStartedDelegate)] = value; } }
        public Object OnEmissionDelegate { get { return this[nameof(OnEmissionDelegate)]; } set { this[nameof(OnEmissionDelegate)] = value; } }
        public Object OnEmissionResolvedDelegate { get { return this[nameof(OnEmissionResolvedDelegate)]; } set { this[nameof(OnEmissionResolvedDelegate)] = value; } }
        public Object OnEmissionEndedDelegate { get { return this[nameof(OnEmissionEndedDelegate)]; } set { this[nameof(OnEmissionEndedDelegate)] = value; } }
        public Object OnEmitterStoppedDelegate { get { return this[nameof(OnEmitterStoppedDelegate)]; } set { this[nameof(OnEmitterStoppedDelegate)] = value; } }
        public Object OnEmissionRateChangedDelegate { get { return this[nameof(OnEmissionRateChangedDelegate)]; } set { this[nameof(OnEmissionRateChangedDelegate)] = value; } }
        public bool bAuto { get { return this[nameof(bAuto)].Flag; } set { this[nameof(bAuto)].Flag = value; } }
        public float Rate { get { return this[nameof(Rate)].GetValue<float>(); } set { this[nameof(Rate)].SetValue<float>(value); } }
        public float Delay { get { return this[nameof(Delay)].GetValue<float>(); } set { this[nameof(Delay)].SetValue<float>(value); } }
        public Object AmountByChannel { get { return this[nameof(AmountByChannel)]; } set { this[nameof(AmountByChannel)] = value; } }
        public Object EmissionResolver { get { return this[nameof(EmissionResolver)]; } set { this[nameof(EmissionResolver)] = value; } }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetRate(float InRate) { Invoke(nameof(SetRate), InRate); }
        public void SetEmissionResolver(Object InEmissionResolver) { Invoke(nameof(SetEmissionResolver), InEmissionResolver); }
        public void SetDelay(float InDelay) { Invoke(nameof(SetDelay), InDelay); }
        public void SetAuto(bool bInAuto) { Invoke(nameof(SetAuto), bInAuto); }
        public void SetAmount(int Channel, float Amount) { Invoke(nameof(SetAmount), Channel, Amount); }
        public void LaunchEmission(ReceiverComponent Target) { Invoke(nameof(LaunchEmission), Target); }
        public bool IsEmitting() { return Invoke<bool>(nameof(IsEmitting)); }
        public bool IsAuto() { return Invoke<bool>(nameof(IsAuto)); }
        public float GetRate() { return Invoke<float>(nameof(GetRate)); }
        public Object GetEmissionResolver() { return Invoke<Object>(nameof(GetEmissionResolver)); }
        public float GetDelay() { return Invoke<float>(nameof(GetDelay)); }
        public bool GetAmount(int Channel, float OutAmount) { return Invoke<bool>(nameof(GetAmount), Channel, OutAmount); }
        public void End(ReceiverComponent Target) { Invoke(nameof(End), Target); }
        public void EmitToTarget(ReceiverComponent Target) { Invoke(nameof(EmitToTarget), Target); }
        public void EmitterStoppedDelegate__DelegateSignature() { Invoke(nameof(EmitterStoppedDelegate__DelegateSignature)); }
        public void EmitterStartedDelegate__DelegateSignature() { Invoke(nameof(EmitterStartedDelegate__DelegateSignature)); }
        public void Emit(ReceiverComponent Target) { Invoke(nameof(Emit), Target); }
        public void EmissionStartedDelegate__DelegateSignature() { Invoke(nameof(EmissionStartedDelegate__DelegateSignature)); }
        public void EmissionResolvedDelegate__DelegateSignature(Object EmissionResolver, ReceiverComponent MainReceiver, Array<ReceiverComponent> Receivers) { Invoke(nameof(EmissionResolvedDelegate__DelegateSignature), EmissionResolver, MainReceiver, Receivers); }
        public void EmissionRateChangedDelegate__DelegateSignature() { Invoke(nameof(EmissionRateChangedDelegate__DelegateSignature)); }
        public void EmissionEndedDelegate__DelegateSignature() { Invoke(nameof(EmissionEndedDelegate__DelegateSignature)); }
        public void EmissionDelegate__DelegateSignature() { Invoke(nameof(EmissionDelegate__DelegateSignature)); }
        public bool CanEmit() { return Invoke<bool>(nameof(CanEmit)); }
    }
    public class EventArgs : Object
    {
        public EventArgs(ulong addr) : base(addr) { }
    }
    public class EventManager : Object
    {
        public EventManager(ulong addr) : base(addr) { }
        public Object Events { get { return this[nameof(Events)]; } set { this[nameof(Events)] = value; } }
        public void UnbindDelegate(Object Name, Object Callback) { Invoke(nameof(UnbindDelegate), Name, Callback); }
        public void Broadcast(Object Name, EventArgs EventArgs) { Invoke(nameof(Broadcast), Name, EventArgs); }
        public void BindDelegate(Object Name, Object Callback) { Invoke(nameof(BindDelegate), Name, Callback); }
    }
    public class EventRequest : OnlineBlueprintCallProxyBase
    {
        public EventRequest(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnError { get { return this[nameof(OnError)]; } set { this[nameof(OnError)] = value; } }
        public bool bIsDone { get { return this[nameof(bIsDone)].Flag; } set { this[nameof(bIsDone)].Flag = value; } }
        public ServerResponse ServerResponse { get { return this[nameof(ServerResponse)].As<ServerResponse>(); } set { this["ServerResponse"] = value; } }
        public Object EventId { get { return this[nameof(EventId)]; } set { this[nameof(EventId)] = value; } }
        public DataObject Data { get { return this[nameof(Data)].As<DataObject>(); } set { this["Data"] = value; } }
        public ServerRequestBase Request { get { return this[nameof(Request)].As<ServerRequestBase>(); } set { this["Request"] = value; } }
        public EventRequest SendEvent(Object InEventId, DataObject InData) { return Invoke<EventRequest>(nameof(SendEvent), InEventId, InData); }
        public void RegisterMessagesHandler(Object InMessagesHandler) { Invoke(nameof(RegisterMessagesHandler), InMessagesHandler); }
        public void RegisterEventWithSettings(Object InEventId, Object InSettings, Object ServerRequestClass) { Invoke(nameof(RegisterEventWithSettings), InEventId, InSettings, ServerRequestClass); }
        public void RegisterEvent(Object InEventId, Object ServerRequestClass) { Invoke(nameof(RegisterEvent), InEventId, ServerRequestClass); }
        public void RegisterErrorsHandler(Object InErrorsHandler) { Invoke(nameof(RegisterErrorsHandler), InErrorsHandler); }
        public void OnRequestResponse(ServerResponse Response) { Invoke(nameof(OnRequestResponse), Response); }
    }
    public class EventRequestManager : Object
    {
        public EventRequestManager(ulong addr) : base(addr) { }
        public Object Events { get { return this[nameof(Events)]; } set { this[nameof(Events)] = value; } }
        public Object Settings { get { return this[nameof(Settings)]; } set { this[nameof(Settings)] = value; } }
    }
    public class EventSettingsInterface : Interface
    {
        public EventSettingsInterface(ulong addr) : base(addr) { }
    }
    public class LoggerBase : Object
    {
        public LoggerBase(ulong addr) : base(addr) { }
        public Object MachineIdentifier { get { return this[nameof(MachineIdentifier)]; } set { this[nameof(MachineIdentifier)] = value; } }
        public void SetMachineIdentifier(Object InMachineIdentifier) { Invoke(nameof(SetMachineIdentifier), InMachineIdentifier); }
        public void LogWarning(Object Category, Object Message) { Invoke(nameof(LogWarning), Category, Message); }
        public void LogInfo(Object Category, Object Message) { Invoke(nameof(LogInfo), Category, Message); }
        public void LogError(Object Category, Object Message) { Invoke(nameof(LogError), Category, Message); }
        public void Log(Object Category, Object Message) { Invoke(nameof(Log), Category, Message); }
        public Object GetMachineIdentifier() { return Invoke<Object>(nameof(GetMachineIdentifier)); }
    }
    public class FriggLogger : LoggerBase
    {
        public FriggLogger(ulong addr) : base(addr) { }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
        public TimerHandle LogTimerHandle { get { return this[nameof(LogTimerHandle)].As<TimerHandle>(); } set { this["LogTimerHandle"] = value; } }
        public Array<DataObject> Logs { get { return new Array<DataObject>(this[nameof(Logs)].Address); } }
    }
    public class ServerRequestBase : Object
    {
        public ServerRequestBase(ulong addr) : base(addr) { }
        public Object OnResponse { get { return this[nameof(OnResponse)]; } set { this[nameof(OnResponse)] = value; } }
        public void SendInternal(Object EventId, Object RequestId, Object Settings, DataObject Data) { Invoke(nameof(SendInternal), EventId, RequestId, Settings, Data); }
        public void Send(Object EventId, Object Settings, DataObject Data) { Invoke(nameof(Send), EventId, Settings, Data); }
    }
    public class LocalRequest : ServerRequestBase
    {
        public LocalRequest(ulong addr) : base(addr) { }
    }
    public class LoggerInterface : Interface
    {
        public LoggerInterface(ulong addr) : base(addr) { }
        public void LogWarning(Object Category, Object Message) { Invoke(nameof(LogWarning), Category, Message); }
        public void LogInfo(Object Category, Object Message) { Invoke(nameof(LogInfo), Category, Message); }
        public void LogError(Object Category, Object Message) { Invoke(nameof(LogError), Category, Message); }
        public void Log(Object Category, Object Message) { Invoke(nameof(Log), Category, Message); }
    }
    public class LogManager : Object
    {
        public LogManager(ulong addr) : base(addr) { }
        public Object Loggers { get { return this[nameof(Loggers)]; } set { this[nameof(Loggers)] = value; } }
        public Object MachineIdentifier { get { return this[nameof(MachineIdentifier)]; } set { this[nameof(MachineIdentifier)] = value; } }
        public void UnregisterLogger(Object Name) { Invoke(nameof(UnregisterLogger), Name); }
        public void UnregisterAll() { Invoke(nameof(UnregisterAll)); }
        public void SetMachineIdentifier(Object InMachineIdentifier) { Invoke(nameof(SetMachineIdentifier), InMachineIdentifier); }
        public void RegisterLogger(Object Name, Object Logger) { Invoke(nameof(RegisterLogger), Name, Logger); }
        public void LogWarning(Object Category, Object Message) { Invoke(nameof(LogWarning), Category, Message); }
        public void LogInfo(Object Category, Object Message) { Invoke(nameof(LogInfo), Category, Message); }
        public void LogError(Object Category, Object Message) { Invoke(nameof(LogError), Category, Message); }
        public void Log(Object Category, Object Message) { Invoke(nameof(Log), Category, Message); }
        public bool IsRegistered(Object Name) { return Invoke<bool>(nameof(IsRegistered), Name); }
        public Object GetMachineIdentifier() { return Invoke<Object>(nameof(GetMachineIdentifier)); }
        public Object GetLogger(Object Name) { return Invoke<Object>(nameof(GetLogger), Name); }
    }
    public class OffensiveComponent : EmitterComponent
    {
        public OffensiveComponent(ulong addr) : base(addr) { }
        public Object OnWeaponChanged { get { return this[nameof(OnWeaponChanged)]; } set { this[nameof(OnWeaponChanged)] = value; } }
        public Object OnAttackMissed { get { return this[nameof(OnAttackMissed)]; } set { this[nameof(OnAttackMissed)] = value; } }
        public bool bAnimationDriven { get { return this[nameof(bAnimationDriven)].Flag; } set { this[nameof(bAnimationDriven)].Flag = value; } }
        public bool bUseOneTimeCollisionOnServer { get { return this[nameof(bUseOneTimeCollisionOnServer)].Flag; } set { this[nameof(bUseOneTimeCollisionOnServer)].Flag = value; } }
        public bool bAOE { get { return this[nameof(bAOE)].Flag; } set { this[nameof(bAOE)].Flag = value; } }
        public float AOERadius { get { return this[nameof(AOERadius)].GetValue<float>(); } set { this[nameof(AOERadius)].SetValue<float>(value); } }
        public EAOEType AOEType { get { return (EAOEType)this[nameof(AOEType)].GetValue<int>(); } set { this[nameof(AOEType)].SetValue<int>((int)value); } }
        public Vector AOEOrigin { get { return this[nameof(AOEOrigin)].As<Vector>(); } set { this["AOEOrigin"] = value; } }
        public Vector AOEEnd { get { return this[nameof(AOEEnd)].As<Vector>(); } set { this["AOEEnd"] = value; } }
        public float AOEMaxDamage { get { return this[nameof(AOEMaxDamage)].GetValue<float>(); } set { this[nameof(AOEMaxDamage)].SetValue<float>(value); } }
        public float AOEMinDamage { get { return this[nameof(AOEMinDamage)].GetValue<float>(); } set { this[nameof(AOEMinDamage)].SetValue<float>(value); } }
        public bool ShowDebug { get { return this[nameof(ShowDebug)].Flag; } set { this[nameof(ShowDebug)].Flag = value; } }
        public float DebugDuration { get { return this[nameof(DebugDuration)].GetValue<float>(); } set { this[nameof(DebugDuration)].SetValue<float>(value); } }
        public float Range { get { return this[nameof(Range)].GetValue<float>(); } set { this[nameof(Range)].SetValue<float>(value); } }
        public float AttackAngle { get { return this[nameof(AttackAngle)].GetValue<float>(); } set { this[nameof(AttackAngle)].SetValue<float>(value); } }
        public bool bIgnoreMultiHit { get { return this[nameof(bIgnoreMultiHit)].Flag; } set { this[nameof(bIgnoreMultiHit)].Flag = value; } }
        public bool bIsCapsule { get { return this[nameof(bIsCapsule)].Flag; } set { this[nameof(bIsCapsule)].Flag = value; } }
        public bool bAllowSecondaryAttack { get { return this[nameof(bAllowSecondaryAttack)].Flag; } set { this[nameof(bAllowSecondaryAttack)].Flag = value; } }
        public Array<Vector> LastMarkersPositions { get { return new Array<Vector>(this[nameof(LastMarkersPositions)].Address); } }
        public Array<ReceiverComponent> MarkersReceivers { get { return new Array<ReceiverComponent>(this[nameof(MarkersReceivers)].Address); } }
        public Array<ReceiverComponent> AOEIgnoreList { get { return new Array<ReceiverComponent>(this[nameof(AOEIgnoreList)].Address); } }
        public void SetAOEIgnoreList(Array<ReceiverComponent> InAOEIgnoreList) { Invoke(nameof(SetAOEIgnoreList), InAOEIgnoreList); }
        public Array<ReceiverComponent> GetAOEIgnoreList() { return Invoke<Array<ReceiverComponent>>(nameof(GetAOEIgnoreList)); }
        public void ComputeServerCollision(bool IgnoreWeapon) { Invoke(nameof(ComputeServerCollision), IgnoreWeapon); }
        public void ClearAOEIgnorList() { Invoke(nameof(ClearAOEIgnorList)); }
    }
    public class OffensiveComponentAttackState : AnimNotifyState
    {
        public OffensiveComponentAttackState(ulong addr) : base(addr) { }
        public bool bIsSecondaryAttack { get { return this[nameof(bIsSecondaryAttack)].Flag; } set { this[nameof(bIsSecondaryAttack)].Flag = value; } }
    }
    public class OffensiveComponentEndAttack : AnimNotify
    {
        public OffensiveComponentEndAttack(ulong addr) : base(addr) { }
    }
    public class OffensiveComponentStartAttack : AnimNotify
    {
        public OffensiveComponentStartAttack(ulong addr) : base(addr) { }
    }
    public class OffensiveEmissionResolver : EmissionResolverBase
    {
        public OffensiveEmissionResolver(ulong addr) : base(addr) { }
    }
    public class OnGameReadyEventArgs : EventArgs
    {
        public OnGameReadyEventArgs(ulong addr) : base(addr) { }
        public bool IsReady() { return Invoke<bool>(nameof(IsReady)); }
    }
    public class PooledObjectInterface : Interface
    {
        public PooledObjectInterface(ulong addr) : base(addr) { }
    }
    public class RESTfulEventRequestSettings : Object
    {
        public RESTfulEventRequestSettings(ulong addr) : base(addr) { }
    }
    public class UserWidgetNavigation : Object
    {
        public UserWidgetNavigation(ulong addr) : base(addr) { }
        public UserWidget CurrentUserWidget { get { return this[nameof(CurrentUserWidget)].As<UserWidget>(); } set { this["CurrentUserWidget"] = value; } }
        public Array<Object> UserWidgetStack { get { return new Array<Object>(this[nameof(UserWidgetStack)].Address); } }
        public void Push(Object UserWidgetClass) { Invoke(nameof(Push), UserWidgetClass); }
        public void Pop() { Invoke(nameof(Pop)); }
        public void Init(Object UserWidgetClass) { Invoke(nameof(Init), UserWidgetClass); }
        public UserWidget GetCurrentUserWidget() { return Invoke<UserWidget>(nameof(GetCurrentUserWidget)); }
    }
    public class WeaponInterface : Interface
    {
        public WeaponInterface(ulong addr) : base(addr) { }
        public void SetOffensiveOwner(OffensiveComponent InOffensiveOwner) { Invoke(nameof(SetOffensiveOwner), InOffensiveOwner); }
        public OffensiveComponent GetOffensiveOwner() { return Invoke<OffensiveComponent>(nameof(GetOffensiveOwner)); }
        public Array<Vector> GetMarkersPositions() { return Invoke<Array<Vector>>(nameof(GetMarkersPositions)); }
    }
    public class ServerResponse : Object
    {
        public ServerResponse(ulong addr) : base(addr) { }
        public Object EventId { get { return this[nameof(EventId)]; } set { this[nameof(EventId)] = value; } }
        public Object RequestId { get { return this[nameof(RequestId)]; } set { this[nameof(RequestId)] = value; } }
        public DataObject Data { get { return this[nameof(Data)].As<DataObject>(); } set { this["Data"] = value; } }
        public Array<ServerRequestError> Errors { get { return new Array<ServerRequestError>(this[nameof(Errors)].Address); } }
        public Array<ServerRequestMessage> Messages { get { return new Array<ServerRequestMessage>(this[nameof(Messages)].Address); } }
    }
    public class ServerRequestMessage : Object
    {
        public ServerRequestMessage(ulong addr) : base(addr) { }
        public int Code { get { return this[nameof(Code)].GetValue<int>(); } set { this[nameof(Code)].SetValue<int>(value); } }
        public DataObject Data { get { return this[nameof(Data)].As<DataObject>(); } set { this["Data"] = value; } }
    }
    public class ServerRequestError : Object
    {
        public ServerRequestError(ulong addr) : base(addr) { }
        public int Code { get { return this[nameof(Code)].GetValue<int>(); } set { this[nameof(Code)].SetValue<int>(value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
    }
    public enum HttpMethod : int
    {
        HTTP_GET = 0,
        HTTP_POST = 1,
        HTTP_DELETE = 2,
        HTTP_PUT = 3,
        HTTP_HEAD = 4,
        HTTP_PATCH = 5,
        HTTP_MAX = 6,
    }
    public enum EAOEType : int
    {
        None = 0,
        FullDamage = 1,
        DecreaseLinear = 2,
        Buff = 3,
        EAOEType_MAX = 4,
    }
    public enum EDataValueType : int
    {
        None = 0,
        Null = 1,
        String = 2,
        Number = 3,
        Boolean = 4,
        Object = 5,
        Array = 6,
        EDataValueType_MAX = 7,
    }
    public class ObjectPool : Object
    {
        public ObjectPool(ulong addr) : base(addr) { }
        public PoolParameters PoolParameters { get { return this[nameof(PoolParameters)].As<PoolParameters>(); } set { this["PoolParameters"] = value; } }
        public Array<Actor> ObjectsPool { get { return new Array<Actor>(this[nameof(ObjectsPool)].Address); } }
        public Array<Actor> SpawnedObjects { get { return new Array<Actor>(this[nameof(SpawnedObjects)].Address); } }
    }
    public class PoolParameters : Object
    {
        public PoolParameters(ulong addr) : base(addr) { }
        public int InitAmount { get { return this[nameof(InitAmount)].GetValue<int>(); } set { this[nameof(InitAmount)].SetValue<int>(value); } }
        public int AllocationAmount { get { return this[nameof(AllocationAmount)].GetValue<int>(); } set { this[nameof(AllocationAmount)].SetValue<int>(value); } }
        public int LimitAmount { get { return this[nameof(LimitAmount)].GetValue<int>(); } set { this[nameof(LimitAmount)].SetValue<int>(value); } }
    }
}
