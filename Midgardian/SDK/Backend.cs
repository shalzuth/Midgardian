using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.BifrostSDK;
using SDK.Script.SharedSDK;
namespace SDK.Script.BackendSDK
{
    public class BackendServerRequest : ServerRequestBase
    {
        public BackendServerRequest(ulong addr) : base(addr) { }
    }
    public class GetGameDataRequestInputVO : Object
    {
        public GetGameDataRequestInputVO(ulong addr) : base(addr) { }
    }
    public class GetGameDataRequestOutputVO : Object
    {
        public GetGameDataRequestOutputVO(ulong addr) : base(addr) { }
        public GameDataVO GameData { get { return this[nameof(GameData)].As<GameDataVO>(); } set { this["GameData"] = value; } }
    }
    public class GetLobbyDataRequestOutputVO : Object
    {
        public GetLobbyDataRequestOutputVO(ulong addr) : base(addr) { }
        public LobbyDataVO LobbyData { get { return this[nameof(LobbyData)].As<LobbyDataVO>(); } set { this["LobbyData"] = value; } }
    }
}
