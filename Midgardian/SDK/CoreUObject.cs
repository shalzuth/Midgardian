using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.CoreUObjectSDK
{
    public class Interface : Object
    {
        public Interface(ulong addr) : base(addr) { }
    }
    public class GCObjectReferencer : Object
    {
        public GCObjectReferencer(ulong addr) : base(addr) { }
    }
    public class TextBuffer : Object
    {
        public TextBuffer(ulong addr) : base(addr) { }
    }
    public class Field : Object
    {
        public Field(ulong addr) : base(addr) { }
    }
    public class Struct : Field
    {
        public Struct(ulong addr) : base(addr) { }
    }
    public class ScriptStruct : Struct
    {
        public ScriptStruct(ulong addr) : base(addr) { }
    }
    public class Package : Object
    {
        public Package(ulong addr) : base(addr) { }
    }
    public class Class : Struct
    {
        public Class(ulong addr) : base(addr) { }
    }
    public class Function : Struct
    {
        public Function(ulong addr) : base(addr) { }
    }
    public class DelegateFunction : Function
    {
        public DelegateFunction(ulong addr) : base(addr) { }
    }
    public class SparseDelegateFunction : DelegateFunction
    {
        public SparseDelegateFunction(ulong addr) : base(addr) { }
    }
    public class DynamicClass : Class
    {
        public DynamicClass(ulong addr) : base(addr) { }
    }
    public class PackageMap : Object
    {
        public PackageMap(ulong addr) : base(addr) { }
    }
    public class Enum : Field
    {
        public Enum(ulong addr) : base(addr) { }
    }
    public class LinkerPlaceholderClass : Class
    {
        public LinkerPlaceholderClass(ulong addr) : base(addr) { }
    }
    public class LinkerPlaceholderExportObject : Object
    {
        public LinkerPlaceholderExportObject(ulong addr) : base(addr) { }
    }
    public class LinkerPlaceholderFunction : Function
    {
        public LinkerPlaceholderFunction(ulong addr) : base(addr) { }
    }
    public class MetaData : Object
    {
        public MetaData(ulong addr) : base(addr) { }
    }
    public class ObjectRedirector : Object
    {
        public ObjectRedirector(ulong addr) : base(addr) { }
    }
    public class Property : Field
    {
        public Property(ulong addr) : base(addr) { }
    }
    public class EnumProperty : Property
    {
        public EnumProperty(ulong addr) : base(addr) { }
    }
    public class ArrayProperty : Property
    {
        public ArrayProperty(ulong addr) : base(addr) { }
    }
    public class ObjectPropertyBase : Property
    {
        public ObjectPropertyBase(ulong addr) : base(addr) { }
    }
    public class BoolProperty : Property
    {
        public BoolProperty(ulong addr) : base(addr) { }
    }
    public class NumericProperty : Property
    {
        public NumericProperty(ulong addr) : base(addr) { }
    }
    public class ByteProperty : NumericProperty
    {
        public ByteProperty(ulong addr) : base(addr) { }
    }
    public class ObjectProperty : ObjectPropertyBase
    {
        public ObjectProperty(ulong addr) : base(addr) { }
    }
    public class ClassProperty : ObjectProperty
    {
        public ClassProperty(ulong addr) : base(addr) { }
    }
    public class DelegateProperty : Property
    {
        public DelegateProperty(ulong addr) : base(addr) { }
    }
    public class DoubleProperty : NumericProperty
    {
        public DoubleProperty(ulong addr) : base(addr) { }
    }
    public class FloatProperty : NumericProperty
    {
        public FloatProperty(ulong addr) : base(addr) { }
    }
    public class IntProperty : NumericProperty
    {
        public IntProperty(ulong addr) : base(addr) { }
    }
    public class Int8Property : NumericProperty
    {
        public Int8Property(ulong addr) : base(addr) { }
    }
    public class Int16Property : NumericProperty
    {
        public Int16Property(ulong addr) : base(addr) { }
    }
    public class Int64Property : NumericProperty
    {
        public Int64Property(ulong addr) : base(addr) { }
    }
    public class InterfaceProperty : Property
    {
        public InterfaceProperty(ulong addr) : base(addr) { }
    }
    public class LazyObjectProperty : ObjectPropertyBase
    {
        public LazyObjectProperty(ulong addr) : base(addr) { }
    }
    public class MapProperty : Property
    {
        public MapProperty(ulong addr) : base(addr) { }
    }
    public class MulticastDelegateProperty : Property
    {
        public MulticastDelegateProperty(ulong addr) : base(addr) { }
    }
    public class MulticastInlineDelegateProperty : MulticastDelegateProperty
    {
        public MulticastInlineDelegateProperty(ulong addr) : base(addr) { }
    }
    public class MulticastSparseDelegateProperty : MulticastDelegateProperty
    {
        public MulticastSparseDelegateProperty(ulong addr) : base(addr) { }
    }
    public class NameProperty : Property
    {
        public NameProperty(ulong addr) : base(addr) { }
    }
    public class SetProperty : Property
    {
        public SetProperty(ulong addr) : base(addr) { }
    }
    public class SoftObjectProperty : ObjectPropertyBase
    {
        public SoftObjectProperty(ulong addr) : base(addr) { }
    }
    public class SoftClassProperty : SoftObjectProperty
    {
        public SoftClassProperty(ulong addr) : base(addr) { }
    }
    public class StrProperty : Property
    {
        public StrProperty(ulong addr) : base(addr) { }
    }
    public class StructProperty : Property
    {
        public StructProperty(ulong addr) : base(addr) { }
    }
    public class UInt16Property : NumericProperty
    {
        public UInt16Property(ulong addr) : base(addr) { }
    }
    public class UInt32Property : NumericProperty
    {
        public UInt32Property(ulong addr) : base(addr) { }
    }
    public class UInt64Property : NumericProperty
    {
        public UInt64Property(ulong addr) : base(addr) { }
    }
    public class WeakObjectProperty : ObjectPropertyBase
    {
        public WeakObjectProperty(ulong addr) : base(addr) { }
    }
    public class TextProperty : Property
    {
        public TextProperty(ulong addr) : base(addr) { }
    }
    public class PropertyWrapper : Object
    {
        public PropertyWrapper(ulong addr) : base(addr) { }
    }
    public class MulticastDelegatePropertyWrapper : PropertyWrapper
    {
        public MulticastDelegatePropertyWrapper(ulong addr) : base(addr) { }
    }
    public class MulticastInlineDelegatePropertyWrapper : MulticastDelegatePropertyWrapper
    {
        public MulticastInlineDelegatePropertyWrapper(ulong addr) : base(addr) { }
    }
    public class Default__ScriptStruct : Object
    {
        public Default__ScriptStruct(ulong addr) : base(addr) { }
    }
    public enum Default__Enum : int
    {
    }
    public class JoinabilitySettings : Object
    {
        public JoinabilitySettings(ulong addr) : base(addr) { }
        public Object SessionName { get { return this[nameof(SessionName)]; } set { this[nameof(SessionName)] = value; } }
        public bool bPublicSearchable { get { return this[nameof(bPublicSearchable)].Flag; } set { this[nameof(bPublicSearchable)].Flag = value; } }
        public bool bAllowInvites { get { return this[nameof(bAllowInvites)].Flag; } set { this[nameof(bAllowInvites)].Flag = value; } }
        public bool bJoinViaPresence { get { return this[nameof(bJoinViaPresence)].Flag; } set { this[nameof(bJoinViaPresence)].Flag = value; } }
        public bool bJoinViaPresenceFriendsOnly { get { return this[nameof(bJoinViaPresenceFriendsOnly)].Flag; } set { this[nameof(bJoinViaPresenceFriendsOnly)].Flag = value; } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public int MaxPartySize { get { return this[nameof(MaxPartySize)].GetValue<int>(); } set { this[nameof(MaxPartySize)].SetValue<int>(value); } }
    }
    public class UniqueNetIdWrapper : Object
    {
        public UniqueNetIdWrapper(ulong addr) : base(addr) { }
    }
    public class Guid : Object
    {
        public Guid(ulong addr) : base(addr) { }
        public int A { get { return this[nameof(A)].GetValue<int>(); } set { this[nameof(A)].SetValue<int>(value); } }
        public int B { get { return this[nameof(B)].GetValue<int>(); } set { this[nameof(B)].SetValue<int>(value); } }
        public int C { get { return this[nameof(C)].GetValue<int>(); } set { this[nameof(C)].SetValue<int>(value); } }
        public int D { get { return this[nameof(D)].GetValue<int>(); } set { this[nameof(D)].SetValue<int>(value); } }
    }
    public class Vector : Object
    {
        public Vector(ulong addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
    }
    public class Vector4 : Object
    {
        public Vector4(ulong addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public class Vector2D : Object
    {
        public Vector2D(ulong addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
    }
    public class TwoVectors : Object
    {
        public TwoVectors(ulong addr) : base(addr) { }
        public Vector v1 { get { return this[nameof(v1)].As<Vector>(); } set { this["v1"] = value; } }
        public Vector v2 { get { return this[nameof(v2)].As<Vector>(); } set { this["v2"] = value; } }
    }
    public class Plane : Vector
    {
        public Plane(ulong addr) : base(addr) { }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public class Rotator : Object
    {
        public Rotator(ulong addr) : base(addr) { }
        public float Pitch { get { return this[nameof(Pitch)].GetValue<float>(); } set { this[nameof(Pitch)].SetValue<float>(value); } }
        public float Yaw { get { return this[nameof(Yaw)].GetValue<float>(); } set { this[nameof(Yaw)].SetValue<float>(value); } }
        public float Roll { get { return this[nameof(Roll)].GetValue<float>(); } set { this[nameof(Roll)].SetValue<float>(value); } }
    }
    public class Quat : Object
    {
        public Quat(ulong addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
    }
    public class PackedNormal : Object
    {
        public PackedNormal(ulong addr) : base(addr) { }
        public byte X { get { return this[nameof(X)].GetValue<byte>(); } set { this[nameof(X)].SetValue<byte>(value); } }
        public byte Y { get { return this[nameof(Y)].GetValue<byte>(); } set { this[nameof(Y)].SetValue<byte>(value); } }
        public byte Z { get { return this[nameof(Z)].GetValue<byte>(); } set { this[nameof(Z)].SetValue<byte>(value); } }
        public byte W { get { return this[nameof(W)].GetValue<byte>(); } set { this[nameof(W)].SetValue<byte>(value); } }
    }
    public class PackedRGB10A2N : Object
    {
        public PackedRGB10A2N(ulong addr) : base(addr) { }
        public int Packed { get { return this[nameof(Packed)].GetValue<int>(); } set { this[nameof(Packed)].SetValue<int>(value); } }
    }
    public class PackedRGBA16N : Object
    {
        public PackedRGBA16N(ulong addr) : base(addr) { }
        public int XY { get { return this[nameof(XY)].GetValue<int>(); } set { this[nameof(XY)].SetValue<int>(value); } }
        public int ZW { get { return this[nameof(ZW)].GetValue<int>(); } set { this[nameof(ZW)].SetValue<int>(value); } }
    }
    public class IntPoint : Object
    {
        public IntPoint(ulong addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
    }
    public class IntVector : Object
    {
        public IntVector(ulong addr) : base(addr) { }
        public int X { get { return this[nameof(X)].GetValue<int>(); } set { this[nameof(X)].SetValue<int>(value); } }
        public int Y { get { return this[nameof(Y)].GetValue<int>(); } set { this[nameof(Y)].SetValue<int>(value); } }
        public int Z { get { return this[nameof(Z)].GetValue<int>(); } set { this[nameof(Z)].SetValue<int>(value); } }
    }
    public class Color : Object
    {
        public Color(ulong addr) : base(addr) { }
        public byte B { get { return this[nameof(B)].GetValue<byte>(); } set { this[nameof(B)].SetValue<byte>(value); } }
        public byte G { get { return this[nameof(G)].GetValue<byte>(); } set { this[nameof(G)].SetValue<byte>(value); } }
        public byte R { get { return this[nameof(R)].GetValue<byte>(); } set { this[nameof(R)].SetValue<byte>(value); } }
        public byte A { get { return this[nameof(A)].GetValue<byte>(); } set { this[nameof(A)].SetValue<byte>(value); } }
    }
    public class LinearColor : Object
    {
        public LinearColor(ulong addr) : base(addr) { }
        public float R { get { return this[nameof(R)].GetValue<float>(); } set { this[nameof(R)].SetValue<float>(value); } }
        public float G { get { return this[nameof(G)].GetValue<float>(); } set { this[nameof(G)].SetValue<float>(value); } }
        public float B { get { return this[nameof(B)].GetValue<float>(); } set { this[nameof(B)].SetValue<float>(value); } }
        public float A { get { return this[nameof(A)].GetValue<float>(); } set { this[nameof(A)].SetValue<float>(value); } }
    }
    public class Box : Object
    {
        public Box(ulong addr) : base(addr) { }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public byte IsValid { get { return this[nameof(IsValid)].GetValue<byte>(); } set { this[nameof(IsValid)].SetValue<byte>(value); } }
    }
    public class Box2D : Object
    {
        public Box2D(ulong addr) : base(addr) { }
        public Vector2D Min { get { return this[nameof(Min)].As<Vector2D>(); } set { this["Min"] = value; } }
        public Vector2D Max { get { return this[nameof(Max)].As<Vector2D>(); } set { this["Max"] = value; } }
        public byte bIsValid { get { return this[nameof(bIsValid)].GetValue<byte>(); } set { this[nameof(bIsValid)].SetValue<byte>(value); } }
    }
    public class BoxSphereBounds : Object
    {
        public BoxSphereBounds(ulong addr) : base(addr) { }
        public Vector Origin { get { return this[nameof(Origin)].As<Vector>(); } set { this["Origin"] = value; } }
        public Vector BoxExtent { get { return this[nameof(BoxExtent)].As<Vector>(); } set { this["BoxExtent"] = value; } }
        public float SphereRadius { get { return this[nameof(SphereRadius)].GetValue<float>(); } set { this[nameof(SphereRadius)].SetValue<float>(value); } }
    }
    public class OrientedBox : Object
    {
        public OrientedBox(ulong addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector AxisX { get { return this[nameof(AxisX)].As<Vector>(); } set { this["AxisX"] = value; } }
        public Vector AxisY { get { return this[nameof(AxisY)].As<Vector>(); } set { this["AxisY"] = value; } }
        public Vector AxisZ { get { return this[nameof(AxisZ)].As<Vector>(); } set { this["AxisZ"] = value; } }
        public float ExtentX { get { return this[nameof(ExtentX)].GetValue<float>(); } set { this[nameof(ExtentX)].SetValue<float>(value); } }
        public float ExtentY { get { return this[nameof(ExtentY)].GetValue<float>(); } set { this[nameof(ExtentY)].SetValue<float>(value); } }
        public float ExtentZ { get { return this[nameof(ExtentZ)].GetValue<float>(); } set { this[nameof(ExtentZ)].SetValue<float>(value); } }
    }
    public class Matrix : Object
    {
        public Matrix(ulong addr) : base(addr) { }
        public Plane XPlane { get { return this[nameof(XPlane)].As<Plane>(); } set { this["XPlane"] = value; } }
        public Plane YPlane { get { return this[nameof(YPlane)].As<Plane>(); } set { this["YPlane"] = value; } }
        public Plane ZPlane { get { return this[nameof(ZPlane)].As<Plane>(); } set { this["ZPlane"] = value; } }
        public Plane WPlane { get { return this[nameof(WPlane)].As<Plane>(); } set { this["WPlane"] = value; } }
    }
    public class InterpCurvePointFloat : Object
    {
        public InterpCurvePointFloat(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public float OutVal { get { return this[nameof(OutVal)].GetValue<float>(); } set { this[nameof(OutVal)].SetValue<float>(value); } }
        public float ArriveTangent { get { return this[nameof(ArriveTangent)].GetValue<float>(); } set { this[nameof(ArriveTangent)].SetValue<float>(value); } }
        public float LeaveTangent { get { return this[nameof(LeaveTangent)].GetValue<float>(); } set { this[nameof(LeaveTangent)].SetValue<float>(value); } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public enum EInterpCurveMode : int
    {
        CIM_Linear = 0,
        CIM_CurveAuto = 1,
        CIM_Constant = 2,
        CIM_CurveUser = 3,
        CIM_CurveBreak = 4,
        CIM_CurveAutoClamped = 5,
        CIM_MAX = 6,
    }
    public class InterpCurveFloat : Object
    {
        public InterpCurveFloat(ulong addr) : base(addr) { }
        public Array<InterpCurvePointFloat> Points { get { return new Array<InterpCurvePointFloat>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointVector2D : Object
    {
        public InterpCurvePointVector2D(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Vector2D OutVal { get { return this[nameof(OutVal)].As<Vector2D>(); } set { this["OutVal"] = value; } }
        public Vector2D ArriveTangent { get { return this[nameof(ArriveTangent)].As<Vector2D>(); } set { this["ArriveTangent"] = value; } }
        public Vector2D LeaveTangent { get { return this[nameof(LeaveTangent)].As<Vector2D>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveVector2D : Object
    {
        public InterpCurveVector2D(ulong addr) : base(addr) { }
        public Array<InterpCurvePointVector2D> Points { get { return new Array<InterpCurvePointVector2D>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointVector : Object
    {
        public InterpCurvePointVector(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Vector OutVal { get { return this[nameof(OutVal)].As<Vector>(); } set { this["OutVal"] = value; } }
        public Vector ArriveTangent { get { return this[nameof(ArriveTangent)].As<Vector>(); } set { this["ArriveTangent"] = value; } }
        public Vector LeaveTangent { get { return this[nameof(LeaveTangent)].As<Vector>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveVector : Object
    {
        public InterpCurveVector(ulong addr) : base(addr) { }
        public Array<InterpCurvePointVector> Points { get { return new Array<InterpCurvePointVector>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointQuat : Object
    {
        public InterpCurvePointQuat(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public Quat OutVal { get { return this[nameof(OutVal)].As<Quat>(); } set { this["OutVal"] = value; } }
        public Quat ArriveTangent { get { return this[nameof(ArriveTangent)].As<Quat>(); } set { this["ArriveTangent"] = value; } }
        public Quat LeaveTangent { get { return this[nameof(LeaveTangent)].As<Quat>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveQuat : Object
    {
        public InterpCurveQuat(ulong addr) : base(addr) { }
        public Array<InterpCurvePointQuat> Points { get { return new Array<InterpCurvePointQuat>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointTwoVectors : Object
    {
        public InterpCurvePointTwoVectors(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public TwoVectors OutVal { get { return this[nameof(OutVal)].As<TwoVectors>(); } set { this["OutVal"] = value; } }
        public TwoVectors ArriveTangent { get { return this[nameof(ArriveTangent)].As<TwoVectors>(); } set { this["ArriveTangent"] = value; } }
        public TwoVectors LeaveTangent { get { return this[nameof(LeaveTangent)].As<TwoVectors>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveTwoVectors : Object
    {
        public InterpCurveTwoVectors(ulong addr) : base(addr) { }
        public Array<InterpCurvePointTwoVectors> Points { get { return new Array<InterpCurvePointTwoVectors>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class InterpCurvePointLinearColor : Object
    {
        public InterpCurvePointLinearColor(ulong addr) : base(addr) { }
        public float InVal { get { return this[nameof(InVal)].GetValue<float>(); } set { this[nameof(InVal)].SetValue<float>(value); } }
        public LinearColor OutVal { get { return this[nameof(OutVal)].As<LinearColor>(); } set { this["OutVal"] = value; } }
        public LinearColor ArriveTangent { get { return this[nameof(ArriveTangent)].As<LinearColor>(); } set { this["ArriveTangent"] = value; } }
        public LinearColor LeaveTangent { get { return this[nameof(LeaveTangent)].As<LinearColor>(); } set { this["LeaveTangent"] = value; } }
        public byte InterpMode { get { return this[nameof(InterpMode)].GetValue<byte>(); } set { this[nameof(InterpMode)].SetValue<byte>(value); } }
    }
    public class InterpCurveLinearColor : Object
    {
        public InterpCurveLinearColor(ulong addr) : base(addr) { }
        public Array<InterpCurvePointLinearColor> Points { get { return new Array<InterpCurvePointLinearColor>(this[nameof(Points)].Address); } }
        public bool bIsLooped { get { return this[nameof(bIsLooped)].Flag; } set { this[nameof(bIsLooped)].Flag = value; } }
        public float LoopKeyOffset { get { return this[nameof(LoopKeyOffset)].GetValue<float>(); } set { this[nameof(LoopKeyOffset)].SetValue<float>(value); } }
    }
    public class Transform : Object
    {
        public Transform(ulong addr) : base(addr) { }
        public Quat Rotation { get { return this[nameof(Rotation)].As<Quat>(); } set { this["Rotation"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public Vector Scale3D { get { return this[nameof(Scale3D)].As<Vector>(); } set { this["Scale3D"] = value; } }
    }
    public class RandomStream : Object
    {
        public RandomStream(ulong addr) : base(addr) { }
        public int InitialSeed { get { return this[nameof(InitialSeed)].GetValue<int>(); } set { this[nameof(InitialSeed)].SetValue<int>(value); } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
    }
    public class DateTime : Object
    {
        public DateTime(ulong addr) : base(addr) { }
    }
    public class FrameNumber : Object
    {
        public FrameNumber(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class FrameRate : Object
    {
        public FrameRate(ulong addr) : base(addr) { }
        public int Numerator { get { return this[nameof(Numerator)].GetValue<int>(); } set { this[nameof(Numerator)].SetValue<int>(value); } }
        public int Denominator { get { return this[nameof(Denominator)].GetValue<int>(); } set { this[nameof(Denominator)].SetValue<int>(value); } }
    }
    public class FrameTime : Object
    {
        public FrameTime(ulong addr) : base(addr) { }
        public FrameNumber FrameNumber { get { return this[nameof(FrameNumber)].As<FrameNumber>(); } set { this["FrameNumber"] = value; } }
        public float SubFrame { get { return this[nameof(SubFrame)].GetValue<float>(); } set { this[nameof(SubFrame)].SetValue<float>(value); } }
    }
    public class QualifiedFrameTime : Object
    {
        public QualifiedFrameTime(ulong addr) : base(addr) { }
        public FrameTime Time { get { return this[nameof(Time)].As<FrameTime>(); } set { this["Time"] = value; } }
        public FrameRate Rate { get { return this[nameof(Rate)].As<FrameRate>(); } set { this["Rate"] = value; } }
    }
    public class Timecode : Object
    {
        public Timecode(ulong addr) : base(addr) { }
        public int Hours { get { return this[nameof(Hours)].GetValue<int>(); } set { this[nameof(Hours)].SetValue<int>(value); } }
        public int Minutes { get { return this[nameof(Minutes)].GetValue<int>(); } set { this[nameof(Minutes)].SetValue<int>(value); } }
        public int Seconds { get { return this[nameof(Seconds)].GetValue<int>(); } set { this[nameof(Seconds)].SetValue<int>(value); } }
        public int Frames { get { return this[nameof(Frames)].GetValue<int>(); } set { this[nameof(Frames)].SetValue<int>(value); } }
        public bool bDropFrameFormat { get { return this[nameof(bDropFrameFormat)].Flag; } set { this[nameof(bDropFrameFormat)].Flag = value; } }
    }
    public class Timespan : Object
    {
        public Timespan(ulong addr) : base(addr) { }
    }
    public class SoftObjectPath : Object
    {
        public SoftObjectPath(ulong addr) : base(addr) { }
        public Object AssetPathName { get { return this[nameof(AssetPathName)]; } set { this[nameof(AssetPathName)] = value; } }
        public Object SubPathString { get { return this[nameof(SubPathString)]; } set { this[nameof(SubPathString)] = value; } }
    }
    public class SoftClassPath : SoftObjectPath
    {
        public SoftClassPath(ulong addr) : base(addr) { }
    }
    public class PrimaryAssetType : Object
    {
        public PrimaryAssetType(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
    public class PrimaryAssetId : Object
    {
        public PrimaryAssetId(ulong addr) : base(addr) { }
        public PrimaryAssetType PrimaryAssetType { get { return this[nameof(PrimaryAssetType)].As<PrimaryAssetType>(); } set { this["PrimaryAssetType"] = value; } }
        public Object PrimaryAssetName { get { return this[nameof(PrimaryAssetName)]; } set { this[nameof(PrimaryAssetName)] = value; } }
    }
    public class FallbackStruct : Object
    {
        public FallbackStruct(ulong addr) : base(addr) { }
    }
    public class FloatRangeBound : Object
    {
        public FloatRangeBound(ulong addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public enum ERangeBoundTypes : int
    {
        Exclusive = 0,
        Inclusive = 1,
        Open = 2,
        ERangeBoundTypes_MAX = 3,
    }
    public class FloatRange : Object
    {
        public FloatRange(ulong addr) : base(addr) { }
        public FloatRangeBound LowerBound { get { return this[nameof(LowerBound)].As<FloatRangeBound>(); } set { this["LowerBound"] = value; } }
        public FloatRangeBound UpperBound { get { return this[nameof(UpperBound)].As<FloatRangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class Int32RangeBound : Object
    {
        public Int32RangeBound(ulong addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class Int32Range : Object
    {
        public Int32Range(ulong addr) : base(addr) { }
        public Int32RangeBound LowerBound { get { return this[nameof(LowerBound)].As<Int32RangeBound>(); } set { this["LowerBound"] = value; } }
        public Int32RangeBound UpperBound { get { return this[nameof(UpperBound)].As<Int32RangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class FrameNumberRangeBound : Object
    {
        public FrameNumberRangeBound(ulong addr) : base(addr) { }
        public byte Type { get { return this[nameof(Type)].GetValue<byte>(); } set { this[nameof(Type)].SetValue<byte>(value); } }
        public FrameNumber Value { get { return this[nameof(Value)].As<FrameNumber>(); } set { this["Value"] = value; } }
    }
    public class FrameNumberRange : Object
    {
        public FrameNumberRange(ulong addr) : base(addr) { }
        public FrameNumberRangeBound LowerBound { get { return this[nameof(LowerBound)].As<FrameNumberRangeBound>(); } set { this["LowerBound"] = value; } }
        public FrameNumberRangeBound UpperBound { get { return this[nameof(UpperBound)].As<FrameNumberRangeBound>(); } set { this["UpperBound"] = value; } }
    }
    public class FloatInterval : Object
    {
        public FloatInterval(ulong addr) : base(addr) { }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
    }
    public class Int32Interval : Object
    {
        public Int32Interval(ulong addr) : base(addr) { }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
    }
    public class PolyglotTextData : Object
    {
        public PolyglotTextData(ulong addr) : base(addr) { }
        public ELocalizedTextSourceCategory Category { get { return (ELocalizedTextSourceCategory)this[nameof(Category)].GetValue<int>(); } set { this[nameof(Category)].SetValue<int>((int)value); } }
        public Object NativeCulture { get { return this[nameof(NativeCulture)]; } set { this[nameof(NativeCulture)] = value; } }
        public Object Namespace { get { return this[nameof(Namespace)]; } set { this[nameof(Namespace)] = value; } }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object NativeString { get { return this[nameof(NativeString)]; } set { this[nameof(NativeString)] = value; } }
        public Object LocalizedStrings { get { return this[nameof(LocalizedStrings)]; } set { this[nameof(LocalizedStrings)] = value; } }
        public bool bIsMinimalPatch { get { return this[nameof(bIsMinimalPatch)].Flag; } set { this[nameof(bIsMinimalPatch)].Flag = value; } }
        public Object CachedText { get { return this[nameof(CachedText)]; } set { this[nameof(CachedText)] = value; } }
    }
    public enum ELocalizedTextSourceCategory : int
    {
        Game = 0,
        Engine = 1,
        Editor = 2,
        ELocalizedTextSourceCategory_MAX = 3,
    }
    public class AutomationEvent : Object
    {
        public AutomationEvent(ulong addr) : base(addr) { }
        public EAutomationEventType Type { get { return (EAutomationEventType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public Guid Artifact { get { return this[nameof(Artifact)].As<Guid>(); } set { this["Artifact"] = value; } }
    }
    public enum EAutomationEventType : int
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        EAutomationEventType_MAX = 3,
    }
    public class AutomationExecutionEntry : Object
    {
        public AutomationExecutionEntry(ulong addr) : base(addr) { }
        public AutomationEvent Event { get { return this[nameof(Event)].As<AutomationEvent>(); } set { this["Event"] = value; } }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public int LineNumber { get { return this[nameof(LineNumber)].GetValue<int>(); } set { this[nameof(LineNumber)].SetValue<int>(value); } }
        public DateTime Timestamp { get { return this[nameof(Timestamp)].As<DateTime>(); } set { this["Timestamp"] = value; } }
    }
    public class ARFilter : Object
    {
        public ARFilter(ulong addr) : base(addr) { }
        public Array<Object> PackageNames { get { return new Array<Object>(this[nameof(PackageNames)].Address); } }
        public Array<Object> PackagePaths { get { return new Array<Object>(this[nameof(PackagePaths)].Address); } }
        public Array<Object> ObjectPaths { get { return new Array<Object>(this[nameof(ObjectPaths)].Address); } }
        public Array<Object> ClassNames { get { return new Array<Object>(this[nameof(ClassNames)].Address); } }
        public Object RecursiveClassesExclusionSet { get { return this[nameof(RecursiveClassesExclusionSet)]; } set { this[nameof(RecursiveClassesExclusionSet)] = value; } }
        public bool bRecursivePaths { get { return this[nameof(bRecursivePaths)].Flag; } set { this[nameof(bRecursivePaths)].Flag = value; } }
        public bool bRecursiveClasses { get { return this[nameof(bRecursiveClasses)].Flag; } set { this[nameof(bRecursiveClasses)].Flag = value; } }
        public bool bIncludeOnlyOnDiskAssets { get { return this[nameof(bIncludeOnlyOnDiskAssets)].Flag; } set { this[nameof(bIncludeOnlyOnDiskAssets)].Flag = value; } }
    }
    public class AssetBundleEntry : Object
    {
        public AssetBundleEntry(ulong addr) : base(addr) { }
        public PrimaryAssetId BundleScope { get { return this[nameof(BundleScope)].As<PrimaryAssetId>(); } set { this["BundleScope"] = value; } }
        public Object BundleName { get { return this[nameof(BundleName)]; } set { this[nameof(BundleName)] = value; } }
        public Array<SoftObjectPath> BundleAssets { get { return new Array<SoftObjectPath>(this[nameof(BundleAssets)].Address); } }
    }
    public class AssetBundleData : Object
    {
        public AssetBundleData(ulong addr) : base(addr) { }
        public Array<AssetBundleEntry> Bundles { get { return new Array<AssetBundleEntry>(this[nameof(Bundles)].Address); } }
    }
    public class AssetData : Object
    {
        public AssetData(ulong addr) : base(addr) { }
        public Object ObjectPath { get { return this[nameof(ObjectPath)]; } set { this[nameof(ObjectPath)] = value; } }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public Object PackagePath { get { return this[nameof(PackagePath)]; } set { this[nameof(PackagePath)] = value; } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public Object AssetClass { get { return this[nameof(AssetClass)]; } set { this[nameof(AssetClass)] = value; } }
    }
    public enum ELifetimeCondition : int
    {
        COND_None = 0,
        COND_InitialOnly = 1,
        COND_OwnerOnly = 2,
        COND_SkipOwner = 3,
        COND_SimulatedOnly = 4,
        COND_AutonomousOnly = 5,
        COND_SimulatedOrPhysics = 6,
        COND_InitialOrOwner = 7,
        COND_Custom = 8,
        COND_ReplayOrOwner = 9,
        COND_ReplayOnly = 10,
        COND_SimulatedOnlyNoReplay = 11,
        COND_SimulatedOrPhysicsNoReplay = 12,
        COND_SkipReplay = 13,
        COND_Never = 15,
        COND_Max = 16,
    }
    public enum EDataValidationResult : int
    {
        Invalid = 0,
        Valid = 1,
        NotValidated = 2,
        EDataValidationResult_MAX = 3,
    }
    public enum EAppMsgType : int
    {
        Ok = 0,
        YesNo = 1,
        OkCancel = 2,
        YesNoCancel = 3,
        CancelRetryContinue = 4,
        YesNoYesAllNoAll = 5,
        YesNoYesAllNoAllCancel = 6,
        YesNoYesAll = 7,
        EAppMsgType_MAX = 8,
    }
    public enum EAppReturnType : int
    {
        No = 0,
        Yes = 1,
        YesAll = 2,
        NoAll = 3,
        Cancel = 4,
        Ok = 5,
        Retry = 6,
        Continue = 7,
        EAppReturnType_MAX = 8,
    }
    public enum EPropertyAccessChangeNotifyMode : int
    {
        Default = 0,
        Never = 1,
        Always = 2,
        EPropertyAccessChangeNotifyMode_MAX = 3,
    }
    public enum EUnit : int
    {
        Micrometers = 0,
        Millimeters = 1,
        Centimeters = 2,
        Meters = 3,
        Kilometers = 4,
        Inches = 5,
        Feet = 6,
        Yards = 7,
        Miles = 8,
        Lightyears = 9,
        Degrees = 10,
        Radians = 11,
        MetersPerSecond = 12,
        KilometersPerHour = 13,
        MilesPerHour = 14,
        Celsius = 15,
        Farenheit = 16,
        Kelvin = 17,
        Micrograms = 18,
        Milligrams = 19,
        Grams = 20,
        Kilograms = 21,
        MetricTons = 22,
        Ounces = 23,
        Pounds = 24,
        Stones = 25,
        Newtons = 26,
        PoundsForce = 27,
        KilogramsForce = 28,
        Hertz = 29,
        Kilohertz = 30,
        Megahertz = 31,
        Gigahertz = 32,
        RevolutionsPerMinute = 33,
        Bytes = 34,
        Kilobytes = 35,
        Megabytes = 36,
        Gigabytes = 37,
        Terabytes = 38,
        Lumens = 39,
        Milliseconds = 43,
        Seconds = 44,
        Minutes = 45,
        Hours = 46,
        Days = 47,
        Months = 48,
        Years = 49,
        Multiplier = 52,
        Percentage = 51,
        Unspecified = 53,
        EUnit_MAX = 54,
    }
    public enum EMouseCursor : int
    {
        None = 0,
        Default = 1,
        TextEditBeam = 2,
        ResizeLeftRight = 3,
        ResizeUpDown = 4,
        ResizeSouthEast = 5,
        ResizeSouthWest = 6,
        CardinalCross = 7,
        Crosshairs = 8,
        Hand = 9,
        GrabHand = 10,
        GrabHandClosed = 11,
        SlashedCircle = 12,
        EyeDropper = 13,
        EMouseCursor_MAX = 14,
    }
    public enum EPixelFormat : int
    {
        PF_Unknown = 0,
        PF_A32B32G32R32F = 1,
        PF_B8G8R8A8 = 2,
        PF_G8 = 3,
        PF_G16 = 4,
        PF_DXT1 = 5,
        PF_DXT3 = 6,
        PF_DXT5 = 7,
        PF_UYVY = 8,
        PF_FloatRGB = 9,
        PF_FloatRGBA = 10,
        PF_DepthStencil = 11,
        PF_ShadowDepth = 12,
        PF_R32_FLOAT = 13,
        PF_G16R16 = 14,
        PF_G16R16F = 15,
        PF_G16R16F_FILTER = 16,
        PF_G32R32F = 17,
        PF_A2B10G10R10 = 18,
        PF_A16B16G16R16 = 19,
        PF_D24 = 20,
        PF_R16F = 21,
        PF_R16F_FILTER = 22,
        PF_BC5 = 23,
        PF_V8U8 = 24,
        PF_A1 = 25,
        PF_FloatR11G11B10 = 26,
        PF_A8 = 27,
        PF_R32_UINT = 28,
        PF_R32_SINT = 29,
        PF_PVRTC2 = 30,
        PF_PVRTC4 = 31,
        PF_R16_UINT = 32,
        PF_R16_SINT = 33,
        PF_R16G16B16A16_UINT = 34,
        PF_R16G16B16A16_SINT = 35,
        PF_R5G6B5_UNORM = 36,
        PF_R8G8B8A8 = 37,
        PF_A8R8G8B8 = 38,
        PF_BC4 = 39,
        PF_R8G8 = 40,
        PF_ATC_RGB = 41,
        PF_ATC_RGBA_E = 42,
        PF_ATC_RGBA_I = 43,
        PF_X24_G8 = 44,
        PF_ETC1 = 45,
        PF_ETC2_RGB = 46,
        PF_ETC2_RGBA = 47,
        PF_R32G32B32A32_UINT = 48,
        PF_R16G16_UINT = 49,
        PF_ASTC_4x4 = 50,
        PF_ASTC_6x6 = 51,
        PF_ASTC_8x8 = 52,
        PF_ASTC_10x10 = 53,
        PF_ASTC_12x12 = 54,
        PF_BC6H = 55,
        PF_BC7 = 56,
        PF_R8_UINT = 57,
        PF_L8 = 58,
        PF_XGXR8 = 59,
        PF_R8G8B8A8_UINT = 60,
        PF_R8G8B8A8_SNORM = 61,
        PF_R16G16B16A16_UNORM = 62,
        PF_R16G16B16A16_SNORM = 63,
        PF_PLATFORM_HDR_1 = 64,
        PF_PLATFORM_HDR_2 = 65,
        PF_PLATFORM_HDR_3 = 66,
        PF_NV12 = 67,
        PF_R32G32_UINT = 68,
        PF_ETC2_R11_EAC = 69,
        PF_ETC2_RG11_EAC = 70,
        PF_MAX = 72,
    }
    public enum EAxis : int
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
        EAxis_MAX = 4,
    }
    public enum ELogTimes : int
    {
        None = 0,
        UTC = 1,
        SinceGStartTime = 2,
        Local = 3,
        ELogTimes_MAX = 4,
    }
    public enum ESearchDir : int
    {
        FromStart = 0,
        FromEnd = 1,
        ESearchDir_MAX = 2,
    }
    public enum ESearchCase : int
    {
        CaseSensitive = 0,
        IgnoreCase = 1,
        ESearchCase_MAX = 2,
    }
    public class Default__Class : Object
    {
        public Default__Class(ulong addr) : base(addr) { }
    }
    public enum Default__EnumProperty : int
    {
    }
    public class Default__ClassProperty : Object
    {
        public Default__ClassProperty(ulong addr) : base(addr) { }
    }
}
