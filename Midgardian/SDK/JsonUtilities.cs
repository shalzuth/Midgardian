using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.JsonUtilitiesSDK
{
    public class JsonUtilitiesDummyObject : Object
    {
        public JsonUtilitiesDummyObject(ulong addr) : base(addr) { }
    }
    public class JsonObjectWrapper : Object
    {
        public JsonObjectWrapper(ulong addr) : base(addr) { }
        public Object JsonString { get { return this[nameof(JsonString)]; } set { this[nameof(JsonString)] = value; } }
    }
}
