using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.PropertyAccessSDK
{
    public class PropertyAccess : Interface
    {
        public PropertyAccess(ulong addr) : base(addr) { }
    }
    public class PropertyEventBroadcaster : Interface
    {
        public PropertyEventBroadcaster(ulong addr) : base(addr) { }
    }
    public class PropertyEventSubscriber : Interface
    {
        public PropertyEventSubscriber(ulong addr) : base(addr) { }
    }
    public enum EPropertyAccessCopyBatch : int
    {
        InternalUnbatched = 0,
        ExternalUnbatched = 1,
        InternalBatched = 2,
        ExternalBatched = 3,
        Count = 4,
        EPropertyAccessCopyBatch_MAX = 5,
    }
    public enum EPropertyAccessCopyType : int
    {
        None = 0,
        Plain = 1,
        Complex = 2,
        Bool = 3,
        Struct = 4,
        Object = 5,
        Name = 6,
        Array = 7,
        PromoteBoolToByte = 8,
        PromoteBoolToInt32 = 9,
        PromoteBoolToInt64 = 10,
        PromoteBoolToFloat = 11,
        PromoteByteToInt32 = 12,
        PromoteByteToInt64 = 13,
        PromoteByteToFloat = 14,
        PromoteInt32ToInt64 = 15,
        PromoteInt32ToFloat = 16,
        EPropertyAccessCopyType_MAX = 17,
    }
    public enum EPropertyAccessObjectType : int
    {
        None = 0,
        Object = 1,
        WeakObject = 2,
        SoftObject = 3,
        EPropertyAccessObjectType_MAX = 4,
    }
    public enum EPropertyAccessIndirectionType : int
    {
        Offset = 0,
        Object = 1,
        Array = 2,
        ScriptFunction = 3,
        NativeFunction = 4,
        EPropertyAccessIndirectionType_MAX = 5,
    }
    public class PropertyAccessLibrary : Object
    {
        public PropertyAccessLibrary(ulong addr) : base(addr) { }
        public Array<PropertyAccessSegment> PathSegments { get { return new Array<PropertyAccessSegment>(this[nameof(PathSegments)].Address); } }
        public Array<PropertyAccessPath> SrcPaths { get { return new Array<PropertyAccessPath>(this[nameof(SrcPaths)].Address); } }
        public Array<PropertyAccessPath> DestPaths { get { return new Array<PropertyAccessPath>(this[nameof(DestPaths)].Address); } }
        public PropertyAccessCopyBatch CopyBatches { get { return this[nameof(CopyBatches)].As<PropertyAccessCopyBatch>(); } set { this["CopyBatches"] = value; } }
        public Array<PropertyAccessIndirectionChain> SrcAccesses { get { return new Array<PropertyAccessIndirectionChain>(this[nameof(SrcAccesses)].Address); } }
        public Array<PropertyAccessIndirectionChain> DestAccesses { get { return new Array<PropertyAccessIndirectionChain>(this[nameof(DestAccesses)].Address); } }
        public Array<PropertyAccessIndirection> Indirections { get { return new Array<PropertyAccessIndirection>(this[nameof(Indirections)].Address); } }
        public Array<int> EventAccessIndices { get { return new Array<int>(this[nameof(EventAccessIndices)].Address); } }
    }
    public class PropertyAccessIndirection : Object
    {
        public PropertyAccessIndirection(ulong addr) : base(addr) { }
        public Object ArrayProperty { get { return this[nameof(ArrayProperty)]; } set { this[nameof(ArrayProperty)] = value; } }
        public Function Function { get { return this[nameof(Function)].As<Function>(); } set { this["Function"] = value; } }
        public int ReturnBufferSize { get { return this[nameof(ReturnBufferSize)].GetValue<int>(); } set { this[nameof(ReturnBufferSize)].SetValue<int>(value); } }
        public int ReturnBufferAlignment { get { return this[nameof(ReturnBufferAlignment)].GetValue<int>(); } set { this[nameof(ReturnBufferAlignment)].SetValue<int>(value); } }
        public int ArrayIndex { get { return this[nameof(ArrayIndex)].GetValue<int>(); } set { this[nameof(ArrayIndex)].SetValue<int>(value); } }
        public uint Offset { get { return this[nameof(Offset)].GetValue<uint>(); } set { this[nameof(Offset)].SetValue<uint>(value); } }
        public EPropertyAccessObjectType ObjectType { get { return (EPropertyAccessObjectType)this[nameof(ObjectType)].GetValue<int>(); } set { this[nameof(ObjectType)].SetValue<int>((int)value); } }
        public EPropertyAccessIndirectionType Type { get { return (EPropertyAccessIndirectionType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class PropertyAccessIndirectionChain : Object
    {
        public PropertyAccessIndirectionChain(ulong addr) : base(addr) { }
        public Object Property { get { return this[nameof(Property)]; } set { this[nameof(Property)] = value; } }
        public int IndirectionStartIndex { get { return this[nameof(IndirectionStartIndex)].GetValue<int>(); } set { this[nameof(IndirectionStartIndex)].SetValue<int>(value); } }
        public int IndirectionEndIndex { get { return this[nameof(IndirectionEndIndex)].GetValue<int>(); } set { this[nameof(IndirectionEndIndex)].SetValue<int>(value); } }
        public int EventId { get { return this[nameof(EventId)].GetValue<int>(); } set { this[nameof(EventId)].SetValue<int>(value); } }
    }
    public class PropertyAccessCopyBatch : Object
    {
        public PropertyAccessCopyBatch(ulong addr) : base(addr) { }
        public Array<PropertyAccessCopy> Copies { get { return new Array<PropertyAccessCopy>(this[nameof(Copies)].Address); } }
    }
    public class PropertyAccessCopy : Object
    {
        public PropertyAccessCopy(ulong addr) : base(addr) { }
        public int AccessIndex { get { return this[nameof(AccessIndex)].GetValue<int>(); } set { this[nameof(AccessIndex)].SetValue<int>(value); } }
        public int DestAccessStartIndex { get { return this[nameof(DestAccessStartIndex)].GetValue<int>(); } set { this[nameof(DestAccessStartIndex)].SetValue<int>(value); } }
        public int DestAccessEndIndex { get { return this[nameof(DestAccessEndIndex)].GetValue<int>(); } set { this[nameof(DestAccessEndIndex)].SetValue<int>(value); } }
        public EPropertyAccessCopyType Type { get { return (EPropertyAccessCopyType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class PropertyAccessPath : Object
    {
        public PropertyAccessPath(ulong addr) : base(addr) { }
        public int PathSegmentStartIndex { get { return this[nameof(PathSegmentStartIndex)].GetValue<int>(); } set { this[nameof(PathSegmentStartIndex)].SetValue<int>(value); } }
        public int PathSegmentCount { get { return this[nameof(PathSegmentCount)].GetValue<int>(); } set { this[nameof(PathSegmentCount)].SetValue<int>(value); } }
        public bool bHasEvents { get { return this[nameof(bHasEvents)].Flag; } set { this[nameof(bHasEvents)].Flag = value; } }
    }
    public class PropertyAccessSegment : Object
    {
        public PropertyAccessSegment(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Struct Struct { get { return this[nameof(Struct)].As<Struct>(); } set { this["Struct"] = value; } }
        public Object Property { get { return this[nameof(Property)]; } set { this[nameof(Property)] = value; } }
        public Function Function { get { return this[nameof(Function)].As<Function>(); } set { this["Function"] = value; } }
        public int ArrayIndex { get { return this[nameof(ArrayIndex)].GetValue<int>(); } set { this[nameof(ArrayIndex)].SetValue<int>(value); } }
        public ushort Flags { get { return this[nameof(Flags)].GetValue<ushort>(); } set { this[nameof(Flags)].SetValue<ushort>(value); } }
    }
}
