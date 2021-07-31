using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.AudioExtensionsSDK
{
    public class SoundfieldEncodingSettingsBase : Object
    {
        public SoundfieldEncodingSettingsBase(ulong addr) : base(addr) { }
    }
    public class AudioEndpointSettingsBase : Object
    {
        public AudioEndpointSettingsBase(ulong addr) : base(addr) { }
    }
    public class SpatializationPluginSourceSettingsBase : Object
    {
        public SpatializationPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class OcclusionPluginSourceSettingsBase : Object
    {
        public OcclusionPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class ReverbPluginSourceSettingsBase : Object
    {
        public ReverbPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundModulatorBase : Object
    {
        public SoundModulatorBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEndpointSettingsBase : Object
    {
        public SoundfieldEndpointSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEffectSettingsBase : Object
    {
        public SoundfieldEffectSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEffectBase : Object
    {
        public SoundfieldEffectBase(ulong addr) : base(addr) { }
        public SoundfieldEffectSettingsBase Settings { get { return this[nameof(Settings)].As<SoundfieldEffectSettingsBase>(); } set { this["Settings"] = value; } }
    }
}
