using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.PacketHandlerSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
namespace SDK.Script.OnlineSubsystemSteamSDK
{
    public class SteamAuthComponentModuleInterface : HandlerComponentFactory
    {
        public SteamAuthComponentModuleInterface(ulong addr) : base(addr) { }
    }
    public class SteamNetConnection : IpConnection
    {
        public SteamNetConnection(ulong addr) : base(addr) { }
        public bool bIsPassthrough { get { return this[nameof(bIsPassthrough)].Flag; } set { this[nameof(bIsPassthrough)].Flag = value; } }
    }
    public class SteamNetDriver : IpNetDriver
    {
        public SteamNetDriver(ulong addr) : base(addr) { }
    }
}
