using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SerializationSDK
{
    public class StructSerializerTestStruct : Object
    {
        public StructSerializerTestStruct(ulong addr) : base(addr) { }
        public StructSerializerNumericTestStruct Numerics { get { return this[nameof(Numerics)].As<StructSerializerNumericTestStruct>(); } set { this["Numerics"] = value; } }
        public StructSerializerBooleanTestStruct Booleans { get { return this[nameof(Booleans)].As<StructSerializerBooleanTestStruct>(); } set { this["Booleans"] = value; } }
        public StructSerializerObjectTestStruct Objects { get { return this[nameof(Objects)].As<StructSerializerObjectTestStruct>(); } set { this["Objects"] = value; } }
        public StructSerializerBuiltinTestStruct Builtins { get { return this[nameof(Builtins)].As<StructSerializerBuiltinTestStruct>(); } set { this["Builtins"] = value; } }
        public StructSerializerArrayTestStruct Arrays { get { return this[nameof(Arrays)].As<StructSerializerArrayTestStruct>(); } set { this["Arrays"] = value; } }
        public StructSerializerMapTestStruct Maps { get { return this[nameof(Maps)].As<StructSerializerMapTestStruct>(); } set { this["Maps"] = value; } }
        public StructSerializerSetTestStruct Sets { get { return this[nameof(Sets)].As<StructSerializerSetTestStruct>(); } set { this["Sets"] = value; } }
    }
    public class StructSerializerSetTestStruct : Object
    {
        public StructSerializerSetTestStruct(ulong addr) : base(addr) { }
        public Object StrSet { get { return this[nameof(StrSet)]; } set { this[nameof(StrSet)] = value; } }
        public Object IntSet { get { return this[nameof(IntSet)]; } set { this[nameof(IntSet)] = value; } }
        public Object NameSet { get { return this[nameof(NameSet)]; } set { this[nameof(NameSet)] = value; } }
        public Object StructSet { get { return this[nameof(StructSet)]; } set { this[nameof(StructSet)] = value; } }
    }
    public class StructSerializerBuiltinTestStruct : Object
    {
        public StructSerializerBuiltinTestStruct(ulong addr) : base(addr) { }
        public Guid Guid { get { return this[nameof(Guid)].As<Guid>(); } set { this["Guid"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public Vector4 Vector4 { get { return this[nameof(Vector4)].As<Vector4>(); } set { this["Vector4"] = value; } }
        public Rotator Rotator { get { return this[nameof(Rotator)].As<Rotator>(); } set { this["Rotator"] = value; } }
        public Quat Quat { get { return this[nameof(Quat)].As<Quat>(); } set { this["Quat"] = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
    }
    public class StructSerializerMapTestStruct : Object
    {
        public StructSerializerMapTestStruct(ulong addr) : base(addr) { }
        public Object IntToStr { get { return this[nameof(IntToStr)]; } set { this[nameof(IntToStr)] = value; } }
        public Object StrToStr { get { return this[nameof(StrToStr)]; } set { this[nameof(StrToStr)] = value; } }
        public Object StrToVec { get { return this[nameof(StrToVec)]; } set { this[nameof(StrToVec)] = value; } }
        public Object StrToStruct { get { return this[nameof(StrToStruct)]; } set { this[nameof(StrToStruct)] = value; } }
    }
    public class StructSerializerArrayTestStruct : Object
    {
        public StructSerializerArrayTestStruct(ulong addr) : base(addr) { }
        public Array<int> Int32Array { get { return new Array<int>(this[nameof(Int32Array)].Address); } }
        public Array<byte> ByteArray { get { return new Array<byte>(this[nameof(ByteArray)].Address); } }
        public int StaticSingleElement { get { return this[nameof(StaticSingleElement)].GetValue<int>(); } set { this[nameof(StaticSingleElement)].SetValue<int>(value); } }
        public int StaticInt32Array { get { return this[nameof(StaticInt32Array)].GetValue<int>(); } set { this[nameof(StaticInt32Array)].SetValue<int>(value); } }
        public float StaticFloatArray { get { return this[nameof(StaticFloatArray)].GetValue<float>(); } set { this[nameof(StaticFloatArray)].SetValue<float>(value); } }
        public Array<Vector> VectorArray { get { return new Array<Vector>(this[nameof(VectorArray)].Address); } }
        public Array<StructSerializerBuiltinTestStruct> StructArray { get { return new Array<StructSerializerBuiltinTestStruct>(this[nameof(StructArray)].Address); } }
    }
    public class StructSerializerObjectTestStruct : Object
    {
        public StructSerializerObjectTestStruct(ulong addr) : base(addr) { }
        public Object Class { get { return this[nameof(Class)]; } set { this[nameof(Class)] = value; } }
        public Object SubClass { get { return this[nameof(SubClass)]; } set { this[nameof(SubClass)] = value; } }
        public Object SoftClass { get { return this[nameof(SoftClass)]; } set { this[nameof(SoftClass)] = value; } }
        public Object Object { get { return this[nameof(Object)].As<Object>(); } set { this["Object"] = value; } }
        public Object WeakObject { get { return this[nameof(WeakObject)]; } set { this[nameof(WeakObject)] = value; } }
        public Object SoftObject { get { return this[nameof(SoftObject)]; } set { this[nameof(SoftObject)] = value; } }
        public SoftClassPath ClassPath { get { return this[nameof(ClassPath)].As<SoftClassPath>(); } set { this["ClassPath"] = value; } }
        public SoftObjectPath ObjectPath { get { return this[nameof(ObjectPath)].As<SoftObjectPath>(); } set { this["ObjectPath"] = value; } }
    }
    public class StructSerializerBooleanTestStruct : Object
    {
        public StructSerializerBooleanTestStruct(ulong addr) : base(addr) { }
        public bool BoolFalse { get { return this[nameof(BoolFalse)].Flag; } set { this[nameof(BoolFalse)].Flag = value; } }
        public bool BoolTrue { get { return this[nameof(BoolTrue)].Flag; } set { this[nameof(BoolTrue)].Flag = value; } }
        public bool Bitfield0 { get { return this[nameof(Bitfield0)].Flag; } set { this[nameof(Bitfield0)].Flag = value; } }
        public bool Bitfield1 { get { return this[nameof(Bitfield1)].Flag; } set { this[nameof(Bitfield1)].Flag = value; } }
        public bool Bitfield2Set { get { return this[nameof(Bitfield2Set)].Flag; } set { this[nameof(Bitfield2Set)].Flag = value; } }
        public bool Bitfield3 { get { return this[nameof(Bitfield3)].Flag; } set { this[nameof(Bitfield3)].Flag = value; } }
        public bool Bitfield4Set { get { return this[nameof(Bitfield4Set)].Flag; } set { this[nameof(Bitfield4Set)].Flag = value; } }
        public bool Bitfield5Set { get { return this[nameof(Bitfield5Set)].Flag; } set { this[nameof(Bitfield5Set)].Flag = value; } }
        public bool Bitfield6 { get { return this[nameof(Bitfield6)].Flag; } set { this[nameof(Bitfield6)].Flag = value; } }
        public bool Bitfield7Set { get { return this[nameof(Bitfield7Set)].Flag; } set { this[nameof(Bitfield7Set)].Flag = value; } }
    }
    public class StructSerializerNumericTestStruct : Object
    {
        public StructSerializerNumericTestStruct(ulong addr) : base(addr) { }
        public byte Int8 { get { return this[nameof(Int8)].GetValue<byte>(); } set { this[nameof(Int8)].SetValue<byte>(value); } }
        public short Int16 { get { return this[nameof(Int16)].GetValue<short>(); } set { this[nameof(Int16)].SetValue<short>(value); } }
        public int Int32 { get { return this[nameof(Int32)].GetValue<int>(); } set { this[nameof(Int32)].SetValue<int>(value); } }
        public long Int64 { get { return this[nameof(Int64)].GetValue<long>(); } set { this[nameof(Int64)].SetValue<long>(value); } }
        public byte UInt8 { get { return this[nameof(UInt8)].GetValue<byte>(); } set { this[nameof(UInt8)].SetValue<byte>(value); } }
        public ushort UInt16 { get { return this[nameof(UInt16)].GetValue<ushort>(); } set { this[nameof(UInt16)].SetValue<ushort>(value); } }
        public uint UInt32 { get { return this[nameof(UInt32)].GetValue<uint>(); } set { this[nameof(UInt32)].SetValue<uint>(value); } }
        public ulong UInt64 { get { return this[nameof(UInt64)].GetValue<ulong>(); } set { this[nameof(UInt64)].SetValue<ulong>(value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public double Double { get { return this[nameof(Double)].GetValue<double>(); } set { this[nameof(Double)].SetValue<double>(value); } }
    }
    public class StructSerializerByteArray : Object
    {
        public StructSerializerByteArray(ulong addr) : base(addr) { }
        public int Dummy1 { get { return this[nameof(Dummy1)].GetValue<int>(); } set { this[nameof(Dummy1)].SetValue<int>(value); } }
        public Array<byte> ByteArray { get { return new Array<byte>(this[nameof(ByteArray)].Address); } }
        public int Dummy2 { get { return this[nameof(Dummy2)].GetValue<int>(); } set { this[nameof(Dummy2)].SetValue<int>(value); } }
        public Array<byte> Int8Array { get { return new Array<byte>(this[nameof(Int8Array)].Address); } }
        public int Dummy3 { get { return this[nameof(Dummy3)].GetValue<int>(); } set { this[nameof(Dummy3)].SetValue<int>(value); } }
    }
}
