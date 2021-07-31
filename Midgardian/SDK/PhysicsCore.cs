using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.ChaosSDK;
namespace SDK.Script.PhysicsCoreSDK
{
    public class BodySetupCore : Object
    {
        public BodySetupCore(ulong addr) : base(addr) { }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public byte PhysicsType { get { return this[nameof(PhysicsType)].GetValue<byte>(); } set { this[nameof(PhysicsType)].SetValue<byte>(value); } }
        public byte CollisionTraceFlag { get { return this[nameof(CollisionTraceFlag)].GetValue<byte>(); } set { this[nameof(CollisionTraceFlag)].SetValue<byte>(value); } }
        public byte CollisionReponse { get { return this[nameof(CollisionReponse)].GetValue<byte>(); } set { this[nameof(CollisionReponse)].SetValue<byte>(value); } }
    }
    public class ChaosPhysicalMaterial : Object
    {
        public ChaosPhysicalMaterial(ulong addr) : base(addr) { }
        public float Friction { get { return this[nameof(Friction)].GetValue<float>(); } set { this[nameof(Friction)].SetValue<float>(value); } }
        public float StaticFriction { get { return this[nameof(StaticFriction)].GetValue<float>(); } set { this[nameof(StaticFriction)].SetValue<float>(value); } }
        public float Restitution { get { return this[nameof(Restitution)].GetValue<float>(); } set { this[nameof(Restitution)].SetValue<float>(value); } }
        public float LinearEtherDrag { get { return this[nameof(LinearEtherDrag)].GetValue<float>(); } set { this[nameof(LinearEtherDrag)].SetValue<float>(value); } }
        public float AngularEtherDrag { get { return this[nameof(AngularEtherDrag)].GetValue<float>(); } set { this[nameof(AngularEtherDrag)].SetValue<float>(value); } }
        public float SleepingLinearVelocityThreshold { get { return this[nameof(SleepingLinearVelocityThreshold)].GetValue<float>(); } set { this[nameof(SleepingLinearVelocityThreshold)].SetValue<float>(value); } }
        public float SleepingAngularVelocityThreshold { get { return this[nameof(SleepingAngularVelocityThreshold)].GetValue<float>(); } set { this[nameof(SleepingAngularVelocityThreshold)].SetValue<float>(value); } }
    }
    public class PhysicalMaterial : Object
    {
        public PhysicalMaterial(ulong addr) : base(addr) { }
        public float Friction { get { return this[nameof(Friction)].GetValue<float>(); } set { this[nameof(Friction)].SetValue<float>(value); } }
        public float StaticFriction { get { return this[nameof(StaticFriction)].GetValue<float>(); } set { this[nameof(StaticFriction)].SetValue<float>(value); } }
        public byte FrictionCombineMode { get { return this[nameof(FrictionCombineMode)].GetValue<byte>(); } set { this[nameof(FrictionCombineMode)].SetValue<byte>(value); } }
        public bool bOverrideFrictionCombineMode { get { return this[nameof(bOverrideFrictionCombineMode)].Flag; } set { this[nameof(bOverrideFrictionCombineMode)].Flag = value; } }
        public float Restitution { get { return this[nameof(Restitution)].GetValue<float>(); } set { this[nameof(Restitution)].SetValue<float>(value); } }
        public byte RestitutionCombineMode { get { return this[nameof(RestitutionCombineMode)].GetValue<byte>(); } set { this[nameof(RestitutionCombineMode)].SetValue<byte>(value); } }
        public bool bOverrideRestitutionCombineMode { get { return this[nameof(bOverrideRestitutionCombineMode)].Flag; } set { this[nameof(bOverrideRestitutionCombineMode)].Flag = value; } }
        public float Density { get { return this[nameof(Density)].GetValue<float>(); } set { this[nameof(Density)].SetValue<float>(value); } }
        public float SleepLinearVelocityThreshold { get { return this[nameof(SleepLinearVelocityThreshold)].GetValue<float>(); } set { this[nameof(SleepLinearVelocityThreshold)].SetValue<float>(value); } }
        public float SleepAngularVelocityThreshold { get { return this[nameof(SleepAngularVelocityThreshold)].GetValue<float>(); } set { this[nameof(SleepAngularVelocityThreshold)].SetValue<float>(value); } }
        public int SleepCounterThreshold { get { return this[nameof(SleepCounterThreshold)].GetValue<int>(); } set { this[nameof(SleepCounterThreshold)].SetValue<int>(value); } }
        public float RaiseMassToPower { get { return this[nameof(RaiseMassToPower)].GetValue<float>(); } set { this[nameof(RaiseMassToPower)].SetValue<float>(value); } }
        public float DestructibleDamageThresholdScale { get { return this[nameof(DestructibleDamageThresholdScale)].GetValue<float>(); } set { this[nameof(DestructibleDamageThresholdScale)].SetValue<float>(value); } }
        public PhysicalMaterialPropertyBase PhysicalMaterialProperty { get { return this[nameof(PhysicalMaterialProperty)].As<PhysicalMaterialPropertyBase>(); } set { this["PhysicalMaterialProperty"] = value; } }
        public byte SurfaceType { get { return this[nameof(SurfaceType)].GetValue<byte>(); } set { this[nameof(SurfaceType)].SetValue<byte>(value); } }
    }
    public class PhysicalMaterialPropertyBase : Object
    {
        public PhysicalMaterialPropertyBase(ulong addr) : base(addr) { }
    }
    public enum EBodyCollisionResponse : int
    {
        BodyCollision_Enabled = 0,
        BodyCollision_Disabled = 1,
        BodyCollision_MAX = 2,
    }
    public enum EPhysicsType : int
    {
        PhysType_Default = 0,
        PhysType_Kinematic = 1,
        PhysType_Simulated = 2,
        PhysType_MAX = 3,
    }
    public enum ECollisionTraceFlag : int
    {
        CTF_UseDefault = 0,
        CTF_UseSimpleAndComplex = 1,
        CTF_UseSimpleAsComplex = 2,
        CTF_UseComplexAsSimple = 3,
        CTF_MAX = 4,
    }
    public enum ELinearConstraintMotion : int
    {
        LCM_Free = 0,
        LCM_Limited = 1,
        LCM_Locked = 2,
        LCM_MAX = 3,
    }
    public enum EConstraintFrame : int
    {
        Frame1 = 0,
        Frame2 = 1,
        EConstraintFrame_MAX = 2,
    }
    public enum EAngularConstraintMotion : int
    {
        ACM_Free = 0,
        ACM_Limited = 1,
        ACM_Locked = 2,
        ACM_MAX = 3,
    }
    public enum ESleepFamily : int
    {
        Normal = 0,
        Sensitive = 1,
        Custom = 2,
        ESleepFamily_MAX = 3,
    }
    public enum ERadialImpulseFalloff : int
    {
        RIF_Constant = 0,
        RIF_Linear = 1,
        RIF_MAX = 2,
    }
    public enum EPhysicalSurface : int
    {
        SurfaceType_Default = 0,
        SurfaceType1 = 1,
        SurfaceType2 = 2,
        SurfaceType3 = 3,
        SurfaceType4 = 4,
        SurfaceType5 = 5,
        SurfaceType6 = 6,
        SurfaceType7 = 7,
        SurfaceType8 = 8,
        SurfaceType9 = 9,
        SurfaceType10 = 10,
        SurfaceType11 = 11,
        SurfaceType12 = 12,
        SurfaceType13 = 13,
        SurfaceType14 = 14,
        SurfaceType15 = 15,
        SurfaceType16 = 16,
        SurfaceType17 = 17,
        SurfaceType18 = 18,
        SurfaceType19 = 19,
        SurfaceType20 = 20,
        SurfaceType21 = 21,
        SurfaceType22 = 22,
        SurfaceType23 = 23,
        SurfaceType24 = 24,
        SurfaceType25 = 25,
        SurfaceType26 = 26,
        SurfaceType27 = 27,
        SurfaceType28 = 28,
        SurfaceType29 = 29,
        SurfaceType30 = 30,
        SurfaceType31 = 31,
        SurfaceType32 = 32,
        SurfaceType33 = 33,
        SurfaceType34 = 34,
        SurfaceType35 = 35,
        SurfaceType36 = 36,
        SurfaceType37 = 37,
        SurfaceType38 = 38,
        SurfaceType39 = 39,
        SurfaceType40 = 40,
        SurfaceType41 = 41,
        SurfaceType42 = 42,
        SurfaceType43 = 43,
        SurfaceType44 = 44,
        SurfaceType45 = 45,
        SurfaceType46 = 46,
        SurfaceType47 = 47,
        SurfaceType48 = 48,
        SurfaceType49 = 49,
        SurfaceType50 = 50,
        SurfaceType51 = 51,
        SurfaceType52 = 52,
        SurfaceType53 = 53,
        SurfaceType54 = 54,
        SurfaceType55 = 55,
        SurfaceType56 = 56,
        SurfaceType57 = 57,
        SurfaceType58 = 58,
        SurfaceType59 = 59,
        SurfaceType60 = 60,
        SurfaceType61 = 61,
        SurfaceType62 = 62,
        SurfaceType_Max = 63,
        EPhysicalSurface_MAX = 64,
    }
    public enum EFrictionCombineMode : int
    {
        Average = 0,
        Min = 1,
        Multiply = 2,
        Max = 3,
    }
    public class BodyInstanceCore : Object
    {
        public BodyInstanceCore(ulong addr) : base(addr) { }
        public bool bSimulatePhysics { get { return this[nameof(bSimulatePhysics)].Flag; } set { this[nameof(bSimulatePhysics)].Flag = value; } }
        public bool bOverrideMass { get { return this[nameof(bOverrideMass)].Flag; } set { this[nameof(bOverrideMass)].Flag = value; } }
        public bool bEnableGravity { get { return this[nameof(bEnableGravity)].Flag; } set { this[nameof(bEnableGravity)].Flag = value; } }
        public bool bAutoWeld { get { return this[nameof(bAutoWeld)].Flag; } set { this[nameof(bAutoWeld)].Flag = value; } }
        public bool bStartAwake { get { return this[nameof(bStartAwake)].Flag; } set { this[nameof(bStartAwake)].Flag = value; } }
        public bool bGenerateWakeEvents { get { return this[nameof(bGenerateWakeEvents)].Flag; } set { this[nameof(bGenerateWakeEvents)].Flag = value; } }
        public bool bUpdateMassWhenScaleChanges { get { return this[nameof(bUpdateMassWhenScaleChanges)].Flag; } set { this[nameof(bUpdateMassWhenScaleChanges)].Flag = value; } }
    }
}
