using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.EngineMessagesSDK
{
    public class EngineServiceNotification : Object
    {
        public EngineServiceNotification(ulong addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public double TimeSeconds { get { return this[nameof(TimeSeconds)].GetValue<double>(); } set { this[nameof(TimeSeconds)].SetValue<double>(value); } }
    }
    public class EngineServiceTerminate : Object
    {
        public EngineServiceTerminate(ulong addr) : base(addr) { }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
    }
    public class EngineServiceExecuteCommand : Object
    {
        public EngineServiceExecuteCommand(ulong addr) : base(addr) { }
        public Object Command { get { return this[nameof(Command)]; } set { this[nameof(Command)] = value; } }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
    }
    public class EngineServiceAuthGrant : Object
    {
        public EngineServiceAuthGrant(ulong addr) : base(addr) { }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
        public Object UserToGrant { get { return this[nameof(UserToGrant)]; } set { this[nameof(UserToGrant)] = value; } }
    }
    public class EngineServiceAuthDeny : Object
    {
        public EngineServiceAuthDeny(ulong addr) : base(addr) { }
        public Object UserName { get { return this[nameof(UserName)]; } set { this[nameof(UserName)] = value; } }
        public Object UserToDeny { get { return this[nameof(UserToDeny)]; } set { this[nameof(UserToDeny)] = value; } }
    }
    public class EngineServicePong : Object
    {
        public EngineServicePong(ulong addr) : base(addr) { }
        public Object CurrentLevel { get { return this[nameof(CurrentLevel)]; } set { this[nameof(CurrentLevel)] = value; } }
        public int EngineVersion { get { return this[nameof(EngineVersion)].GetValue<int>(); } set { this[nameof(EngineVersion)].SetValue<int>(value); } }
        public bool HasBegunPlay { get { return this[nameof(HasBegunPlay)].Flag; } set { this[nameof(HasBegunPlay)].Flag = value; } }
        public Guid InstanceId { get { return this[nameof(InstanceId)].As<Guid>(); } set { this["InstanceId"] = value; } }
        public Object InstanceType { get { return this[nameof(InstanceType)]; } set { this[nameof(InstanceType)] = value; } }
        public Guid SessionId { get { return this[nameof(SessionId)].As<Guid>(); } set { this["SessionId"] = value; } }
        public float WorldTimeSeconds { get { return this[nameof(WorldTimeSeconds)].GetValue<float>(); } set { this[nameof(WorldTimeSeconds)].SetValue<float>(value); } }
    }
    public class EngineServicePing : Object
    {
        public EngineServicePing(ulong addr) : base(addr) { }
    }
}
