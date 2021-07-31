using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.PropertyPathSDK
{
    public class CachedPropertyPath : Object
    {
        public CachedPropertyPath(ulong addr) : base(addr) { }
        public Array<PropertyPathSegment> Segments { get { return new Array<PropertyPathSegment>(this[nameof(Segments)].Address); } }
        public Function CachedFunction { get { return this[nameof(CachedFunction)].As<Function>(); } set { this["CachedFunction"] = value; } }
    }
    public class PropertyPathSegment : Object
    {
        public PropertyPathSegment(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int ArrayIndex { get { return this[nameof(ArrayIndex)].GetValue<int>(); } set { this[nameof(ArrayIndex)].SetValue<int>(value); } }
        public Struct Struct { get { return this[nameof(Struct)].As<Struct>(); } set { this["Struct"] = value; } }
    }
}
