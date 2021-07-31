using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.FieldSystemEngineSDK
{
    public class FieldSystemActor : Actor
    {
        public FieldSystemActor(ulong addr) : base(addr) { }
        public FieldSystemComponent FieldSystemComponent { get { return this[nameof(FieldSystemComponent)].As<FieldSystemComponent>(); } set { this["FieldSystemComponent"] = value; } }
    }
    public class FieldSystem : Object
    {
        public FieldSystem(ulong addr) : base(addr) { }
    }
    public class FieldSystemComponent : PrimitiveComponent
    {
        public FieldSystemComponent(ulong addr) : base(addr) { }
        public FieldSystem FieldSystem { get { return this[nameof(FieldSystem)].As<FieldSystem>(); } set { this["FieldSystem"] = value; } }
        public Array<Object> SupportedSolvers { get { return new Array<Object>(this[nameof(SupportedSolvers)].Address); } }
        public void ResetFieldSystem() { Invoke(nameof(ResetFieldSystem)); }
        public void ApplyUniformVectorFalloffForce(bool Enabled, Vector Position, Vector Direction, float Radius, float Magnitude) { Invoke(nameof(ApplyUniformVectorFalloffForce), Enabled, Position, Direction, Radius, Magnitude); }
        public void ApplyStrainField(bool Enabled, Vector Position, float Radius, float Magnitude, int Iterations) { Invoke(nameof(ApplyStrainField), Enabled, Position, Radius, Magnitude, Iterations); }
        public void ApplyStayDynamicField(bool Enabled, Vector Position, float Radius) { Invoke(nameof(ApplyStayDynamicField), Enabled, Position, Radius); }
        public void ApplyRadialVectorFalloffForce(bool Enabled, Vector Position, float Radius, float Magnitude) { Invoke(nameof(ApplyRadialVectorFalloffForce), Enabled, Position, Radius, Magnitude); }
        public void ApplyRadialForce(bool Enabled, Vector Position, float Magnitude) { Invoke(nameof(ApplyRadialForce), Enabled, Position, Magnitude); }
        public void ApplyPhysicsField(bool Enabled, byte Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(ApplyPhysicsField), Enabled, Target, MetaData, Field); }
        public void ApplyLinearForce(bool Enabled, Vector Direction, float Magnitude) { Invoke(nameof(ApplyLinearForce), Enabled, Direction, Magnitude); }
        public void AddFieldCommand(bool Enabled, byte Target, FieldSystemMetaData MetaData, FieldNodeBase Field) { Invoke(nameof(AddFieldCommand), Enabled, Target, MetaData, Field); }
    }
    public class FieldSystemMetaData : ActorComponent
    {
        public FieldSystemMetaData(ulong addr) : base(addr) { }
    }
    public class FieldSystemMetaDataIteration : FieldSystemMetaData
    {
        public FieldSystemMetaDataIteration(ulong addr) : base(addr) { }
        public int Iterations { get { return this[nameof(Iterations)].GetValue<int>(); } set { this[nameof(Iterations)].SetValue<int>(value); } }
        public FieldSystemMetaDataIteration SetMetaDataIteration(int Iterations) { return Invoke<FieldSystemMetaDataIteration>(nameof(SetMetaDataIteration), Iterations); }
    }
    public class FieldSystemMetaDataProcessingResolution : FieldSystemMetaData
    {
        public FieldSystemMetaDataProcessingResolution(ulong addr) : base(addr) { }
        public byte ResolutionType { get { return this[nameof(ResolutionType)].GetValue<byte>(); } set { this[nameof(ResolutionType)].SetValue<byte>(value); } }
        public FieldSystemMetaDataProcessingResolution SetMetaDataaProcessingResolutionType(byte ResolutionType) { return Invoke<FieldSystemMetaDataProcessingResolution>(nameof(SetMetaDataaProcessingResolutionType), ResolutionType); }
    }
    public class FieldNodeBase : ActorComponent
    {
        public FieldNodeBase(ulong addr) : base(addr) { }
    }
    public class FieldNodeInt : FieldNodeBase
    {
        public FieldNodeInt(ulong addr) : base(addr) { }
    }
    public class FieldNodeFloat : FieldNodeBase
    {
        public FieldNodeFloat(ulong addr) : base(addr) { }
    }
    public class FieldNodeVector : FieldNodeBase
    {
        public FieldNodeVector(ulong addr) : base(addr) { }
    }
    public class UniformInteger : FieldNodeInt
    {
        public UniformInteger(ulong addr) : base(addr) { }
        public int Magnitude { get { return this[nameof(Magnitude)].GetValue<int>(); } set { this[nameof(Magnitude)].SetValue<int>(value); } }
        public UniformInteger SetUniformInteger(int Magnitude) { return Invoke<UniformInteger>(nameof(SetUniformInteger), Magnitude); }
    }
    public class RadialIntMask : FieldNodeInt
    {
        public RadialIntMask(ulong addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public int InteriorValue { get { return this[nameof(InteriorValue)].GetValue<int>(); } set { this[nameof(InteriorValue)].SetValue<int>(value); } }
        public int ExteriorValue { get { return this[nameof(ExteriorValue)].GetValue<int>(); } set { this[nameof(ExteriorValue)].SetValue<int>(value); } }
        public byte SetMaskCondition { get { return this[nameof(SetMaskCondition)].GetValue<byte>(); } set { this[nameof(SetMaskCondition)].SetValue<byte>(value); } }
        public RadialIntMask SetRadialIntMask(float Radius, Vector Position, int InteriorValue, int ExteriorValue, byte SetMaskConditionIn) { return Invoke<RadialIntMask>(nameof(SetRadialIntMask), Radius, Position, InteriorValue, ExteriorValue, SetMaskConditionIn); }
    }
    public class UniformScalar : FieldNodeFloat
    {
        public UniformScalar(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public UniformScalar SetUniformScalar(float Magnitude) { return Invoke<UniformScalar>(nameof(SetUniformScalar), Magnitude); }
    }
    public class RadialFalloff : FieldNodeFloat
    {
        public RadialFalloff(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public RadialFalloff SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, Vector Position, byte Falloff) { return Invoke<RadialFalloff>(nameof(SetRadialFalloff), Magnitude, MinRange, MaxRange, Default, Radius, Position, Falloff); }
    }
    public class PlaneFalloff : FieldNodeFloat
    {
        public PlaneFalloff(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public PlaneFalloff SetPlaneFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Distance, Vector Position, Vector Normal, byte Falloff) { return Invoke<PlaneFalloff>(nameof(SetPlaneFalloff), Magnitude, MinRange, MaxRange, Default, Distance, Position, Normal, Falloff); }
    }
    public class BoxFalloff : FieldNodeFloat
    {
        public BoxFalloff(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public byte Falloff { get { return this[nameof(Falloff)].GetValue<byte>(); } set { this[nameof(Falloff)].SetValue<byte>(value); } }
        public BoxFalloff SetBoxFalloff(float Magnitude, float MinRange, float MaxRange, float Default, Transform Transform, byte Falloff) { return Invoke<BoxFalloff>(nameof(SetBoxFalloff), Magnitude, MinRange, MaxRange, Default, Transform, Falloff); }
    }
    public class NoiseField : FieldNodeFloat
    {
        public NoiseField(ulong addr) : base(addr) { }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public NoiseField SetNoiseField(float MinRange, float MaxRange, Transform Transform) { return Invoke<NoiseField>(nameof(SetNoiseField), MinRange, MaxRange, Transform); }
    }
    public class UniformVector : FieldNodeVector
    {
        public UniformVector(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public UniformVector SetUniformVector(float Magnitude, Vector Direction) { return Invoke<UniformVector>(nameof(SetUniformVector), Magnitude, Direction); }
    }
    public class RadialVector : FieldNodeVector
    {
        public RadialVector(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public RadialVector SetRadialVector(float Magnitude, Vector Position) { return Invoke<RadialVector>(nameof(SetRadialVector), Magnitude, Position); }
    }
    public class RandomVector : FieldNodeVector
    {
        public RandomVector(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public RandomVector SetRandomVector(float Magnitude) { return Invoke<RandomVector>(nameof(SetRandomVector), Magnitude); }
    }
    public class OperatorField : FieldNodeBase
    {
        public OperatorField(ulong addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public FieldNodeBase RightField { get { return this[nameof(RightField)].As<FieldNodeBase>(); } set { this["RightField"] = value; } }
        public FieldNodeBase LeftField { get { return this[nameof(LeftField)].As<FieldNodeBase>(); } set { this["LeftField"] = value; } }
        public byte Operation { get { return this[nameof(Operation)].GetValue<byte>(); } set { this[nameof(Operation)].SetValue<byte>(value); } }
        public OperatorField SetOperatorField(float Magnitude, FieldNodeBase RightField, FieldNodeBase LeftField, byte Operation) { return Invoke<OperatorField>(nameof(SetOperatorField), Magnitude, RightField, LeftField, Operation); }
    }
    public class ToIntegerField : FieldNodeInt
    {
        public ToIntegerField(ulong addr) : base(addr) { }
        public FieldNodeFloat FloatField { get { return this[nameof(FloatField)].As<FieldNodeFloat>(); } set { this["FloatField"] = value; } }
        public ToIntegerField SetToIntegerField(FieldNodeFloat FloatField) { return Invoke<ToIntegerField>(nameof(SetToIntegerField), FloatField); }
    }
    public class ToFloatField : FieldNodeFloat
    {
        public ToFloatField(ulong addr) : base(addr) { }
        public FieldNodeInt IntField { get { return this[nameof(IntField)].As<FieldNodeInt>(); } set { this["IntField"] = value; } }
        public ToFloatField SetToFloatField(FieldNodeInt IntegerField) { return Invoke<ToFloatField>(nameof(SetToFloatField), IntegerField); }
    }
    public class CullingField : FieldNodeBase
    {
        public CullingField(ulong addr) : base(addr) { }
        public FieldNodeBase Culling { get { return this[nameof(Culling)].As<FieldNodeBase>(); } set { this["Culling"] = value; } }
        public FieldNodeBase Field { get { return this[nameof(Field)].As<FieldNodeBase>(); } set { this["Field"] = value; } }
        public byte Operation { get { return this[nameof(Operation)].GetValue<byte>(); } set { this[nameof(Operation)].SetValue<byte>(value); } }
        public CullingField SetCullingField(FieldNodeBase Culling, FieldNodeBase Field, byte Operation) { return Invoke<CullingField>(nameof(SetCullingField), Culling, Field, Operation); }
    }
    public class ReturnResultsTerminal : FieldNodeBase
    {
        public ReturnResultsTerminal(ulong addr) : base(addr) { }
        public ReturnResultsTerminal SetReturnResultsTerminal() { return Invoke<ReturnResultsTerminal>(nameof(SetReturnResultsTerminal)); }
    }
}
