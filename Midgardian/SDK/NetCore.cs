using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.NetCoreSDK
{
    public class NetAnalyticsAggregatorConfig : Object
    {
        public NetAnalyticsAggregatorConfig(ulong addr) : base(addr) { }
        public Array<NetAnalyticsDataConfig> NetAnalyticsData { get { return new Array<NetAnalyticsDataConfig>(this[nameof(NetAnalyticsData)].Address); } }
    }
    public class NetAnalyticsDataConfig : Object
    {
        public NetAnalyticsDataConfig(ulong addr) : base(addr) { }
        public Object DataName { get { return this[nameof(DataName)]; } set { this[nameof(DataName)] = value; } }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
    }
}
