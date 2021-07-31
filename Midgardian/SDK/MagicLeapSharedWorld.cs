using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MagicLeapARPinSDK;
namespace SDK.Script.MagicLeapSharedWorldSDK
{
    public class MagicLeapSharedWorldGameMode : GameMode
    {
        public MagicLeapSharedWorldGameMode(ulong addr) : base(addr) { }
        public MagicLeapSharedWorldSharedData SharedWorldData { get { return this[nameof(SharedWorldData)].As<MagicLeapSharedWorldSharedData>(); } set { this["SharedWorldData"] = value; } }
        public Object OnNewLocalDataFromClients { get { return this[nameof(OnNewLocalDataFromClients)]; } set { this[nameof(OnNewLocalDataFromClients)] = value; } }
        public float PinSelectionConfidenceThreshold { get { return this[nameof(PinSelectionConfidenceThreshold)].GetValue<float>(); } set { this[nameof(PinSelectionConfidenceThreshold)].SetValue<float>(value); } }
        public MagicLeapSharedWorldPlayerController ChosenOne { get { return this[nameof(ChosenOne)].As<MagicLeapSharedWorldPlayerController>(); } set { this["ChosenOne"] = value; } }
        public bool SendSharedWorldDataToClients() { return Invoke<bool>(nameof(SendSharedWorldDataToClients)); }
        public void SelectChosenOne() { Invoke(nameof(SelectChosenOne)); }
        public void MagicLeapOnNewLocalDataFromClients__DelegateSignature() { Invoke(nameof(MagicLeapOnNewLocalDataFromClients__DelegateSignature)); }
        public void DetermineSharedWorldData(MagicLeapSharedWorldSharedData NewSharedWorldData) { Invoke(nameof(DetermineSharedWorldData), NewSharedWorldData); }
    }
    public class MagicLeapSharedWorldGameState : GameState
    {
        public MagicLeapSharedWorldGameState(ulong addr) : base(addr) { }
        public MagicLeapSharedWorldSharedData SharedWorldData { get { return this[nameof(SharedWorldData)].As<MagicLeapSharedWorldSharedData>(); } set { this["SharedWorldData"] = value; } }
        public MagicLeapSharedWorldAlignmentTransforms AlignmentTransforms { get { return this[nameof(AlignmentTransforms)].As<MagicLeapSharedWorldAlignmentTransforms>(); } set { this["AlignmentTransforms"] = value; } }
        public Object OnSharedWorldDataUpdated { get { return this[nameof(OnSharedWorldDataUpdated)]; } set { this[nameof(OnSharedWorldDataUpdated)] = value; } }
        public Object OnAlignmentTransformsUpdated { get { return this[nameof(OnAlignmentTransformsUpdated)]; } set { this[nameof(OnAlignmentTransformsUpdated)] = value; } }
        public void OnReplicate_SharedWorldData() { Invoke(nameof(OnReplicate_SharedWorldData)); }
        public void OnReplicate_AlignmentTransforms() { Invoke(nameof(OnReplicate_AlignmentTransforms)); }
        public void MagicLeapSharedWorldEvent__DelegateSignature() { Invoke(nameof(MagicLeapSharedWorldEvent__DelegateSignature)); }
        public Transform CalculateXRCameraRootTransform() { return Invoke<Transform>(nameof(CalculateXRCameraRootTransform)); }
    }
    public class MagicLeapSharedWorldPlayerController : PlayerController
    {
        public MagicLeapSharedWorldPlayerController(ulong addr) : base(addr) { }
        public void ServerSetLocalWorldData(MagicLeapSharedWorldLocalData LocalWorldReplicationData) { Invoke(nameof(ServerSetLocalWorldData), LocalWorldReplicationData); }
        public void ServerSetAlignmentTransforms(MagicLeapSharedWorldAlignmentTransforms InAlignmentTransforms) { Invoke(nameof(ServerSetAlignmentTransforms), InAlignmentTransforms); }
        public bool IsChosenOne() { return Invoke<bool>(nameof(IsChosenOne)); }
        public void ClientSetChosenOne(bool bChosenOne) { Invoke(nameof(ClientSetChosenOne), bChosenOne); }
        public void ClientMarkReadyForSendingLocalData() { Invoke(nameof(ClientMarkReadyForSendingLocalData)); }
        public bool CanSendLocalDataToServer() { return Invoke<bool>(nameof(CanSendLocalDataToServer)); }
    }
    public class MagicLeapSharedWorldSharedData : Object
    {
        public MagicLeapSharedWorldSharedData(ulong addr) : base(addr) { }
        public Array<Guid> PinIDs { get { return new Array<Guid>(this[nameof(PinIDs)].Address); } }
    }
    public class MagicLeapSharedWorldAlignmentTransforms : Object
    {
        public MagicLeapSharedWorldAlignmentTransforms(ulong addr) : base(addr) { }
        public Array<Transform> AlignmentTransforms { get { return new Array<Transform>(this[nameof(AlignmentTransforms)].Address); } }
    }
    public class MagicLeapSharedWorldLocalData : Object
    {
        public MagicLeapSharedWorldLocalData(ulong addr) : base(addr) { }
        public Array<MagicLeapSharedWorldPinData> LocalPins { get { return new Array<MagicLeapSharedWorldPinData>(this[nameof(LocalPins)].Address); } }
    }
    public class MagicLeapSharedWorldPinData : Object
    {
        public MagicLeapSharedWorldPinData(ulong addr) : base(addr) { }
        public Guid PinId { get { return this[nameof(PinId)].As<Guid>(); } set { this["PinId"] = value; } }
        public MagicLeapARPinState PinState { get { return this[nameof(PinState)].As<MagicLeapARPinState>(); } set { this["PinState"] = value; } }
    }
}
