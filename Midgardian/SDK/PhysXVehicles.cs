using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AnimGraphRuntimeSDK;
using SDK.Script.PhysicsCoreSDK;
namespace SDK.Script.PhysXVehiclesSDK
{
    public class WheeledVehicleMovementComponent : PawnMovementComponent
    {
        public WheeledVehicleMovementComponent(ulong addr) : base(addr) { }
        public bool bDeprecatedSpringOffsetMode { get { return this[nameof(bDeprecatedSpringOffsetMode)].Flag; } set { this[nameof(bDeprecatedSpringOffsetMode)].Flag = value; } }
        public bool bReverseAsBrake { get { return this[nameof(bReverseAsBrake)].Flag; } set { this[nameof(bReverseAsBrake)].Flag = value; } }
        public bool bUseRVOAvoidance { get { return this[nameof(bUseRVOAvoidance)].Flag; } set { this[nameof(bUseRVOAvoidance)].Flag = value; } }
        public bool bRawHandbrakeInput { get { return this[nameof(bRawHandbrakeInput)].Flag; } set { this[nameof(bRawHandbrakeInput)].Flag = value; } }
        public bool bRawGearUpInput { get { return this[nameof(bRawGearUpInput)].Flag; } set { this[nameof(bRawGearUpInput)].Flag = value; } }
        public bool bRawGearDownInput { get { return this[nameof(bRawGearDownInput)].Flag; } set { this[nameof(bRawGearDownInput)].Flag = value; } }
        public bool bWasAvoidanceUpdated { get { return this[nameof(bWasAvoidanceUpdated)].Flag; } set { this[nameof(bWasAvoidanceUpdated)].Flag = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public Array<WheelSetup> WheelSetups { get { return new Array<WheelSetup>(this[nameof(WheelSetups)].Address); } }
        public float DragCoefficient { get { return this[nameof(DragCoefficient)].GetValue<float>(); } set { this[nameof(DragCoefficient)].SetValue<float>(value); } }
        public float ChassisWidth { get { return this[nameof(ChassisWidth)].GetValue<float>(); } set { this[nameof(ChassisWidth)].SetValue<float>(value); } }
        public float ChassisHeight { get { return this[nameof(ChassisHeight)].GetValue<float>(); } set { this[nameof(ChassisHeight)].SetValue<float>(value); } }
        public float DragArea { get { return this[nameof(DragArea)].GetValue<float>(); } set { this[nameof(DragArea)].SetValue<float>(value); } }
        public float EstimatedMaxEngineSpeed { get { return this[nameof(EstimatedMaxEngineSpeed)].GetValue<float>(); } set { this[nameof(EstimatedMaxEngineSpeed)].SetValue<float>(value); } }
        public float MaxEngineRPM { get { return this[nameof(MaxEngineRPM)].GetValue<float>(); } set { this[nameof(MaxEngineRPM)].SetValue<float>(value); } }
        public float DebugDragMagnitude { get { return this[nameof(DebugDragMagnitude)].GetValue<float>(); } set { this[nameof(DebugDragMagnitude)].SetValue<float>(value); } }
        public Vector InertiaTensorScale { get { return this[nameof(InertiaTensorScale)].As<Vector>(); } set { this["InertiaTensorScale"] = value; } }
        public float MinNormalizedTireLoad { get { return this[nameof(MinNormalizedTireLoad)].GetValue<float>(); } set { this[nameof(MinNormalizedTireLoad)].SetValue<float>(value); } }
        public float MinNormalizedTireLoadFiltered { get { return this[nameof(MinNormalizedTireLoadFiltered)].GetValue<float>(); } set { this[nameof(MinNormalizedTireLoadFiltered)].SetValue<float>(value); } }
        public float MaxNormalizedTireLoad { get { return this[nameof(MaxNormalizedTireLoad)].GetValue<float>(); } set { this[nameof(MaxNormalizedTireLoad)].SetValue<float>(value); } }
        public float MaxNormalizedTireLoadFiltered { get { return this[nameof(MaxNormalizedTireLoadFiltered)].GetValue<float>(); } set { this[nameof(MaxNormalizedTireLoadFiltered)].SetValue<float>(value); } }
        public float ThresholdLongitudinalSpeed { get { return this[nameof(ThresholdLongitudinalSpeed)].GetValue<float>(); } set { this[nameof(ThresholdLongitudinalSpeed)].SetValue<float>(value); } }
        public int LowForwardSpeedSubStepCount { get { return this[nameof(LowForwardSpeedSubStepCount)].GetValue<int>(); } set { this[nameof(LowForwardSpeedSubStepCount)].SetValue<int>(value); } }
        public int HighForwardSpeedSubStepCount { get { return this[nameof(HighForwardSpeedSubStepCount)].GetValue<int>(); } set { this[nameof(HighForwardSpeedSubStepCount)].SetValue<int>(value); } }
        public Array<VehicleWheel> Wheels { get { return new Array<VehicleWheel>(this[nameof(Wheels)].Address); } }
        public float RVOAvoidanceRadius { get { return this[nameof(RVOAvoidanceRadius)].GetValue<float>(); } set { this[nameof(RVOAvoidanceRadius)].SetValue<float>(value); } }
        public float RVOAvoidanceHeight { get { return this[nameof(RVOAvoidanceHeight)].GetValue<float>(); } set { this[nameof(RVOAvoidanceHeight)].SetValue<float>(value); } }
        public float AvoidanceConsiderationRadius { get { return this[nameof(AvoidanceConsiderationRadius)].GetValue<float>(); } set { this[nameof(AvoidanceConsiderationRadius)].SetValue<float>(value); } }
        public float RVOSteeringStep { get { return this[nameof(RVOSteeringStep)].GetValue<float>(); } set { this[nameof(RVOSteeringStep)].SetValue<float>(value); } }
        public float RVOThrottleStep { get { return this[nameof(RVOThrottleStep)].GetValue<float>(); } set { this[nameof(RVOThrottleStep)].SetValue<float>(value); } }
        public int AvoidanceUID { get { return this[nameof(AvoidanceUID)].GetValue<int>(); } set { this[nameof(AvoidanceUID)].SetValue<int>(value); } }
        public NavAvoidanceMask AvoidanceGroup { get { return this[nameof(AvoidanceGroup)].As<NavAvoidanceMask>(); } set { this["AvoidanceGroup"] = value; } }
        public NavAvoidanceMask GroupsToAvoid { get { return this[nameof(GroupsToAvoid)].As<NavAvoidanceMask>(); } set { this["GroupsToAvoid"] = value; } }
        public NavAvoidanceMask GroupsToIgnore { get { return this[nameof(GroupsToIgnore)].As<NavAvoidanceMask>(); } set { this["GroupsToIgnore"] = value; } }
        public float AvoidanceWeight { get { return this[nameof(AvoidanceWeight)].GetValue<float>(); } set { this[nameof(AvoidanceWeight)].SetValue<float>(value); } }
        public Vector PendingLaunchVelocity { get { return this[nameof(PendingLaunchVelocity)].As<Vector>(); } set { this["PendingLaunchVelocity"] = value; } }
        public ReplicatedVehicleState ReplicatedState { get { return this[nameof(ReplicatedState)].As<ReplicatedVehicleState>(); } set { this["ReplicatedState"] = value; } }
        public float RawSteeringInput { get { return this[nameof(RawSteeringInput)].GetValue<float>(); } set { this[nameof(RawSteeringInput)].SetValue<float>(value); } }
        public float RawThrottleInput { get { return this[nameof(RawThrottleInput)].GetValue<float>(); } set { this[nameof(RawThrottleInput)].SetValue<float>(value); } }
        public float RawBrakeInput { get { return this[nameof(RawBrakeInput)].GetValue<float>(); } set { this[nameof(RawBrakeInput)].SetValue<float>(value); } }
        public float SteeringInput { get { return this[nameof(SteeringInput)].GetValue<float>(); } set { this[nameof(SteeringInput)].SetValue<float>(value); } }
        public float ThrottleInput { get { return this[nameof(ThrottleInput)].GetValue<float>(); } set { this[nameof(ThrottleInput)].SetValue<float>(value); } }
        public float BrakeInput { get { return this[nameof(BrakeInput)].GetValue<float>(); } set { this[nameof(BrakeInput)].SetValue<float>(value); } }
        public float HandbrakeInput { get { return this[nameof(HandbrakeInput)].GetValue<float>(); } set { this[nameof(HandbrakeInput)].SetValue<float>(value); } }
        public float IdleBrakeInput { get { return this[nameof(IdleBrakeInput)].GetValue<float>(); } set { this[nameof(IdleBrakeInput)].SetValue<float>(value); } }
        public float StopThreshold { get { return this[nameof(StopThreshold)].GetValue<float>(); } set { this[nameof(StopThreshold)].SetValue<float>(value); } }
        public float WrongDirectionThreshold { get { return this[nameof(WrongDirectionThreshold)].GetValue<float>(); } set { this[nameof(WrongDirectionThreshold)].SetValue<float>(value); } }
        public VehicleInputRate ThrottleInputRate { get { return this[nameof(ThrottleInputRate)].As<VehicleInputRate>(); } set { this["ThrottleInputRate"] = value; } }
        public VehicleInputRate BrakeInputRate { get { return this[nameof(BrakeInputRate)].As<VehicleInputRate>(); } set { this["BrakeInputRate"] = value; } }
        public VehicleInputRate HandbrakeInputRate { get { return this[nameof(HandbrakeInputRate)].As<VehicleInputRate>(); } set { this["HandbrakeInputRate"] = value; } }
        public VehicleInputRate SteeringInputRate { get { return this[nameof(SteeringInputRate)].As<VehicleInputRate>(); } set { this["SteeringInputRate"] = value; } }
        public Controller OverrideController { get { return this[nameof(OverrideController)].As<Controller>(); } set { this["OverrideController"] = value; } }
        public void SetUseAutoGears(bool bUseAuto) { Invoke(nameof(SetUseAutoGears), bUseAuto); }
        public void SetThrottleInput(float Throttle) { Invoke(nameof(SetThrottleInput), Throttle); }
        public void SetTargetGear(int GearNum, bool bImmediate) { Invoke(nameof(SetTargetGear), GearNum, bImmediate); }
        public void SetSteeringInput(float Steering) { Invoke(nameof(SetSteeringInput), Steering); }
        public void SetHandbrakeInput(bool bNewHandbrake) { Invoke(nameof(SetHandbrakeInput), bNewHandbrake); }
        public void SetGroupsToIgnoreMask(NavAvoidanceMask GroupMask) { Invoke(nameof(SetGroupsToIgnoreMask), GroupMask); }
        public void SetGroupsToIgnore(int GroupFlags) { Invoke(nameof(SetGroupsToIgnore), GroupFlags); }
        public void SetGroupsToAvoidMask(NavAvoidanceMask GroupMask) { Invoke(nameof(SetGroupsToAvoidMask), GroupMask); }
        public void SetGroupsToAvoid(int GroupFlags) { Invoke(nameof(SetGroupsToAvoid), GroupFlags); }
        public void SetGearUp(bool bNewGearUp) { Invoke(nameof(SetGearUp), bNewGearUp); }
        public void SetGearDown(bool bNewGearDown) { Invoke(nameof(SetGearDown), bNewGearDown); }
        public void SetBrakeInput(float Brake) { Invoke(nameof(SetBrakeInput), Brake); }
        public void SetAvoidanceGroupMask(NavAvoidanceMask GroupMask) { Invoke(nameof(SetAvoidanceGroupMask), GroupMask); }
        public void SetAvoidanceGroup(int GroupFlags) { Invoke(nameof(SetAvoidanceGroup), GroupFlags); }
        public void SetAvoidanceEnabled(bool bEnable) { Invoke(nameof(SetAvoidanceEnabled), bEnable); }
        public void ServerUpdateState(float InSteeringInput, float InThrottleInput, float InBrakeInput, float InHandbrakeInput, int CurrentGear) { Invoke(nameof(ServerUpdateState), InSteeringInput, InThrottleInput, InBrakeInput, InHandbrakeInput, CurrentGear); }
        public bool GetUseAutoGears() { return Invoke<bool>(nameof(GetUseAutoGears)); }
        public int GetTargetGear() { return Invoke<int>(nameof(GetTargetGear)); }
        public float GetForwardSpeed() { return Invoke<float>(nameof(GetForwardSpeed)); }
        public float GetEngineRotationSpeed() { return Invoke<float>(nameof(GetEngineRotationSpeed)); }
        public float GetEngineMaxRotationSpeed() { return Invoke<float>(nameof(GetEngineMaxRotationSpeed)); }
        public int GetCurrentGear() { return Invoke<int>(nameof(GetCurrentGear)); }
    }
    public class SimpleWheeledVehicleMovementComponent : WheeledVehicleMovementComponent
    {
        public SimpleWheeledVehicleMovementComponent(ulong addr) : base(addr) { }
        public void SetSteerAngle(float SteerAngle, int WheelIndex) { Invoke(nameof(SetSteerAngle), SteerAngle, WheelIndex); }
        public void SetDriveTorque(float DriveTorque, int WheelIndex) { Invoke(nameof(SetDriveTorque), DriveTorque, WheelIndex); }
        public void SetBrakeTorque(float BrakeTorque, int WheelIndex) { Invoke(nameof(SetBrakeTorque), BrakeTorque, WheelIndex); }
    }
    public class TireConfig : DataAsset
    {
        public TireConfig(ulong addr) : base(addr) { }
        public float FrictionScale { get { return this[nameof(FrictionScale)].GetValue<float>(); } set { this[nameof(FrictionScale)].SetValue<float>(value); } }
        public Array<TireConfigMaterialFriction> TireFrictionScales { get { return new Array<TireConfigMaterialFriction>(this[nameof(TireFrictionScales)].Address); } }
    }
    public class VehicleAnimInstance : AnimInstance
    {
        public VehicleAnimInstance(ulong addr) : base(addr) { }
        public WheeledVehicleMovementComponent WheeledVehicleMovementComponent { get { return this[nameof(WheeledVehicleMovementComponent)].As<WheeledVehicleMovementComponent>(); } set { this["WheeledVehicleMovementComponent"] = value; } }
        public WheeledVehicle GetVehicle() { return Invoke<WheeledVehicle>(nameof(GetVehicle)); }
    }
    public class VehicleWheel : Object
    {
        public VehicleWheel(ulong addr) : base(addr) { }
        public StaticMesh CollisionMesh { get { return this[nameof(CollisionMesh)].As<StaticMesh>(); } set { this["CollisionMesh"] = value; } }
        public bool bDontCreateShape { get { return this[nameof(bDontCreateShape)].Flag; } set { this[nameof(bDontCreateShape)].Flag = value; } }
        public bool bAutoAdjustCollisionSize { get { return this[nameof(bAutoAdjustCollisionSize)].Flag; } set { this[nameof(bAutoAdjustCollisionSize)].Flag = value; } }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
        public float ShapeRadius { get { return this[nameof(ShapeRadius)].GetValue<float>(); } set { this[nameof(ShapeRadius)].SetValue<float>(value); } }
        public float ShapeWidth { get { return this[nameof(ShapeWidth)].GetValue<float>(); } set { this[nameof(ShapeWidth)].SetValue<float>(value); } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public float DampingRate { get { return this[nameof(DampingRate)].GetValue<float>(); } set { this[nameof(DampingRate)].SetValue<float>(value); } }
        public float SteerAngle { get { return this[nameof(SteerAngle)].GetValue<float>(); } set { this[nameof(SteerAngle)].SetValue<float>(value); } }
        public bool bAffectedByHandbrake { get { return this[nameof(bAffectedByHandbrake)].Flag; } set { this[nameof(bAffectedByHandbrake)].Flag = value; } }
        public TireType TireType { get { return this[nameof(TireType)].As<TireType>(); } set { this["TireType"] = value; } }
        public TireConfig TireConfig { get { return this[nameof(TireConfig)].As<TireConfig>(); } set { this["TireConfig"] = value; } }
        public float LatStiffMaxLoad { get { return this[nameof(LatStiffMaxLoad)].GetValue<float>(); } set { this[nameof(LatStiffMaxLoad)].SetValue<float>(value); } }
        public float LatStiffValue { get { return this[nameof(LatStiffValue)].GetValue<float>(); } set { this[nameof(LatStiffValue)].SetValue<float>(value); } }
        public float LongStiffValue { get { return this[nameof(LongStiffValue)].GetValue<float>(); } set { this[nameof(LongStiffValue)].SetValue<float>(value); } }
        public float SuspensionForceOffset { get { return this[nameof(SuspensionForceOffset)].GetValue<float>(); } set { this[nameof(SuspensionForceOffset)].SetValue<float>(value); } }
        public float SuspensionMaxRaise { get { return this[nameof(SuspensionMaxRaise)].GetValue<float>(); } set { this[nameof(SuspensionMaxRaise)].SetValue<float>(value); } }
        public float SuspensionMaxDrop { get { return this[nameof(SuspensionMaxDrop)].GetValue<float>(); } set { this[nameof(SuspensionMaxDrop)].SetValue<float>(value); } }
        public float SuspensionNaturalFrequency { get { return this[nameof(SuspensionNaturalFrequency)].GetValue<float>(); } set { this[nameof(SuspensionNaturalFrequency)].SetValue<float>(value); } }
        public float SuspensionDampingRatio { get { return this[nameof(SuspensionDampingRatio)].GetValue<float>(); } set { this[nameof(SuspensionDampingRatio)].SetValue<float>(value); } }
        public byte SweepType { get { return this[nameof(SweepType)].GetValue<byte>(); } set { this[nameof(SweepType)].SetValue<byte>(value); } }
        public float MaxBrakeTorque { get { return this[nameof(MaxBrakeTorque)].GetValue<float>(); } set { this[nameof(MaxBrakeTorque)].SetValue<float>(value); } }
        public float MaxHandBrakeTorque { get { return this[nameof(MaxHandBrakeTorque)].GetValue<float>(); } set { this[nameof(MaxHandBrakeTorque)].SetValue<float>(value); } }
        public WheeledVehicleMovementComponent VehicleSim { get { return this[nameof(VehicleSim)].As<WheeledVehicleMovementComponent>(); } set { this["VehicleSim"] = value; } }
        public int WheelIndex { get { return this[nameof(WheelIndex)].GetValue<int>(); } set { this[nameof(WheelIndex)].SetValue<int>(value); } }
        public float DebugLongSlip { get { return this[nameof(DebugLongSlip)].GetValue<float>(); } set { this[nameof(DebugLongSlip)].SetValue<float>(value); } }
        public float DebugLatSlip { get { return this[nameof(DebugLatSlip)].GetValue<float>(); } set { this[nameof(DebugLatSlip)].SetValue<float>(value); } }
        public float DebugNormalizedTireLoad { get { return this[nameof(DebugNormalizedTireLoad)].GetValue<float>(); } set { this[nameof(DebugNormalizedTireLoad)].SetValue<float>(value); } }
        public float DebugWheelTorque { get { return this[nameof(DebugWheelTorque)].GetValue<float>(); } set { this[nameof(DebugWheelTorque)].SetValue<float>(value); } }
        public float DebugLongForce { get { return this[nameof(DebugLongForce)].GetValue<float>(); } set { this[nameof(DebugLongForce)].SetValue<float>(value); } }
        public float DebugLatForce { get { return this[nameof(DebugLatForce)].GetValue<float>(); } set { this[nameof(DebugLatForce)].SetValue<float>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector OldLocation { get { return this[nameof(OldLocation)].As<Vector>(); } set { this["OldLocation"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public bool IsInAir() { return Invoke<bool>(nameof(IsInAir)); }
        public float GetSuspensionOffset() { return Invoke<float>(nameof(GetSuspensionOffset)); }
        public float GetSteerAngle() { return Invoke<float>(nameof(GetSteerAngle)); }
        public float GetRotationAngle() { return Invoke<float>(nameof(GetRotationAngle)); }
    }
    public class WheeledVehicle : Pawn
    {
        public WheeledVehicle(ulong addr) : base(addr) { }
        public SkeletalMeshComponent Mesh { get { return this[nameof(Mesh)].As<SkeletalMeshComponent>(); } set { this["Mesh"] = value; } }
        public WheeledVehicleMovementComponent VehicleMovement { get { return this[nameof(VehicleMovement)].As<WheeledVehicleMovementComponent>(); } set { this["VehicleMovement"] = value; } }
    }
    public class WheeledVehicleMovementComponent4W : WheeledVehicleMovementComponent
    {
        public WheeledVehicleMovementComponent4W(ulong addr) : base(addr) { }
        public VehicleEngineData EngineSetup { get { return this[nameof(EngineSetup)].As<VehicleEngineData>(); } set { this["EngineSetup"] = value; } }
        public VehicleDifferential4WData DifferentialSetup { get { return this[nameof(DifferentialSetup)].As<VehicleDifferential4WData>(); } set { this["DifferentialSetup"] = value; } }
        public float AckermannAccuracy { get { return this[nameof(AckermannAccuracy)].GetValue<float>(); } set { this[nameof(AckermannAccuracy)].SetValue<float>(value); } }
        public VehicleTransmissionData TransmissionSetup { get { return this[nameof(TransmissionSetup)].As<VehicleTransmissionData>(); } set { this["TransmissionSetup"] = value; } }
        public RuntimeFloatCurve SteeringCurve { get { return this[nameof(SteeringCurve)].As<RuntimeFloatCurve>(); } set { this["SteeringCurve"] = value; } }
    }
    public enum EWheelSweepType : int
    {
        SimpleAndComplex = 0,
        Simple = 1,
        Complex = 2,
        EWheelSweepType_MAX = 3,
    }
    public enum EVehicleDifferential4W : int
    {
        LimitedSlip_4W = 0,
        LimitedSlip_FrontDrive = 1,
        LimitedSlip_RearDrive = 2,
        Open_4W = 3,
        Open_FrontDrive = 4,
        Open_RearDrive = 5,
        EVehicleDifferential4W_MAX = 6,
    }
    public class AnimNode_WheelHandler : AnimNode_SkeletalControlBase
    {
        public AnimNode_WheelHandler(ulong addr) : base(addr) { }
    }
    public class TireConfigMaterialFriction : Object
    {
        public TireConfigMaterialFriction(ulong addr) : base(addr) { }
        public PhysicalMaterial PhysicalMaterial { get { return this[nameof(PhysicalMaterial)].As<PhysicalMaterial>(); } set { this["PhysicalMaterial"] = value; } }
        public float FrictionScale { get { return this[nameof(FrictionScale)].GetValue<float>(); } set { this[nameof(FrictionScale)].SetValue<float>(value); } }
    }
    public class VehicleAnimInstanceProxy : AnimInstanceProxy
    {
        public VehicleAnimInstanceProxy(ulong addr) : base(addr) { }
    }
    public class VehicleInputRate : Object
    {
        public VehicleInputRate(ulong addr) : base(addr) { }
        public float RiseRate { get { return this[nameof(RiseRate)].GetValue<float>(); } set { this[nameof(RiseRate)].SetValue<float>(value); } }
        public float FallRate { get { return this[nameof(FallRate)].GetValue<float>(); } set { this[nameof(FallRate)].SetValue<float>(value); } }
    }
    public class ReplicatedVehicleState : Object
    {
        public ReplicatedVehicleState(ulong addr) : base(addr) { }
        public float SteeringInput { get { return this[nameof(SteeringInput)].GetValue<float>(); } set { this[nameof(SteeringInput)].SetValue<float>(value); } }
        public float ThrottleInput { get { return this[nameof(ThrottleInput)].GetValue<float>(); } set { this[nameof(ThrottleInput)].SetValue<float>(value); } }
        public float BrakeInput { get { return this[nameof(BrakeInput)].GetValue<float>(); } set { this[nameof(BrakeInput)].SetValue<float>(value); } }
        public float HandbrakeInput { get { return this[nameof(HandbrakeInput)].GetValue<float>(); } set { this[nameof(HandbrakeInput)].SetValue<float>(value); } }
        public int CurrentGear { get { return this[nameof(CurrentGear)].GetValue<int>(); } set { this[nameof(CurrentGear)].SetValue<int>(value); } }
    }
    public class WheelSetup : Object
    {
        public WheelSetup(ulong addr) : base(addr) { }
        public Object WheelClass { get { return this[nameof(WheelClass)]; } set { this[nameof(WheelClass)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public Vector AdditionalOffset { get { return this[nameof(AdditionalOffset)].As<Vector>(); } set { this["AdditionalOffset"] = value; } }
        public bool bDisableSteering { get { return this[nameof(bDisableSteering)].Flag; } set { this[nameof(bDisableSteering)].Flag = value; } }
    }
    public class VehicleTransmissionData : Object
    {
        public VehicleTransmissionData(ulong addr) : base(addr) { }
        public bool bUseGearAutoBox { get { return this[nameof(bUseGearAutoBox)].Flag; } set { this[nameof(bUseGearAutoBox)].Flag = value; } }
        public float GearSwitchTime { get { return this[nameof(GearSwitchTime)].GetValue<float>(); } set { this[nameof(GearSwitchTime)].SetValue<float>(value); } }
        public float GearAutoBoxLatency { get { return this[nameof(GearAutoBoxLatency)].GetValue<float>(); } set { this[nameof(GearAutoBoxLatency)].SetValue<float>(value); } }
        public float FinalRatio { get { return this[nameof(FinalRatio)].GetValue<float>(); } set { this[nameof(FinalRatio)].SetValue<float>(value); } }
        public Array<VehicleGearData> ForwardGears { get { return new Array<VehicleGearData>(this[nameof(ForwardGears)].Address); } }
        public float ReverseGearRatio { get { return this[nameof(ReverseGearRatio)].GetValue<float>(); } set { this[nameof(ReverseGearRatio)].SetValue<float>(value); } }
        public float NeutralGearUpRatio { get { return this[nameof(NeutralGearUpRatio)].GetValue<float>(); } set { this[nameof(NeutralGearUpRatio)].SetValue<float>(value); } }
        public float ClutchStrength { get { return this[nameof(ClutchStrength)].GetValue<float>(); } set { this[nameof(ClutchStrength)].SetValue<float>(value); } }
    }
    public class VehicleGearData : Object
    {
        public VehicleGearData(ulong addr) : base(addr) { }
        public float Ratio { get { return this[nameof(Ratio)].GetValue<float>(); } set { this[nameof(Ratio)].SetValue<float>(value); } }
        public float DownRatio { get { return this[nameof(DownRatio)].GetValue<float>(); } set { this[nameof(DownRatio)].SetValue<float>(value); } }
        public float UpRatio { get { return this[nameof(UpRatio)].GetValue<float>(); } set { this[nameof(UpRatio)].SetValue<float>(value); } }
    }
    public class VehicleEngineData : Object
    {
        public VehicleEngineData(ulong addr) : base(addr) { }
        public RuntimeFloatCurve TorqueCurve { get { return this[nameof(TorqueCurve)].As<RuntimeFloatCurve>(); } set { this["TorqueCurve"] = value; } }
        public float MaxRPM { get { return this[nameof(MaxRPM)].GetValue<float>(); } set { this[nameof(MaxRPM)].SetValue<float>(value); } }
        public float MOI { get { return this[nameof(MOI)].GetValue<float>(); } set { this[nameof(MOI)].SetValue<float>(value); } }
        public float DampingRateFullThrottle { get { return this[nameof(DampingRateFullThrottle)].GetValue<float>(); } set { this[nameof(DampingRateFullThrottle)].SetValue<float>(value); } }
        public float DampingRateZeroThrottleClutchEngaged { get { return this[nameof(DampingRateZeroThrottleClutchEngaged)].GetValue<float>(); } set { this[nameof(DampingRateZeroThrottleClutchEngaged)].SetValue<float>(value); } }
        public float DampingRateZeroThrottleClutchDisengaged { get { return this[nameof(DampingRateZeroThrottleClutchDisengaged)].GetValue<float>(); } set { this[nameof(DampingRateZeroThrottleClutchDisengaged)].SetValue<float>(value); } }
    }
    public class VehicleDifferential4WData : Object
    {
        public VehicleDifferential4WData(ulong addr) : base(addr) { }
        public byte DifferentialType { get { return this[nameof(DifferentialType)].GetValue<byte>(); } set { this[nameof(DifferentialType)].SetValue<byte>(value); } }
        public float FrontRearSplit { get { return this[nameof(FrontRearSplit)].GetValue<float>(); } set { this[nameof(FrontRearSplit)].SetValue<float>(value); } }
        public float FrontLeftRightSplit { get { return this[nameof(FrontLeftRightSplit)].GetValue<float>(); } set { this[nameof(FrontLeftRightSplit)].SetValue<float>(value); } }
        public float RearLeftRightSplit { get { return this[nameof(RearLeftRightSplit)].GetValue<float>(); } set { this[nameof(RearLeftRightSplit)].SetValue<float>(value); } }
        public float CentreBias { get { return this[nameof(CentreBias)].GetValue<float>(); } set { this[nameof(CentreBias)].SetValue<float>(value); } }
        public float FrontBias { get { return this[nameof(FrontBias)].GetValue<float>(); } set { this[nameof(FrontBias)].SetValue<float>(value); } }
        public float RearBias { get { return this[nameof(RearBias)].GetValue<float>(); } set { this[nameof(RearBias)].SetValue<float>(value); } }
    }
}
