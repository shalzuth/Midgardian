using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.UObjectPluginSDK
{
    public class MyPluginObject : Object
    {
        public MyPluginObject(ulong addr) : base(addr) { }
        public MyPluginStruct MyStruct { get { return this[nameof(MyStruct)].As<MyPluginStruct>(); } set { this["MyStruct"] = value; } }
    }
    public class MyPluginStruct : Object
    {
        public MyPluginStruct(ulong addr) : base(addr) { }
        public Object TestString { get { return this[nameof(TestString)]; } set { this[nameof(TestString)] = value; } }
    }
}
