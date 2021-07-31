using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.PacketHandlerSDK
{
    public class HandlerComponentFactory : Object
    {
        public HandlerComponentFactory(ulong addr) : base(addr) { }
    }
    public class PacketHandlerProfileConfig : Object
    {
        public PacketHandlerProfileConfig(ulong addr) : base(addr) { }
        public Array<Object> Components { get { return new Array<Object>(this[nameof(Components)].Address); } }
    }
}
