using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.RendererSDK;
namespace SDK.Script.LightPropagationVolumeRuntimeSDK
{
    public class LightPropagationVolumeBlendable : Object
    {
        public LightPropagationVolumeBlendable(ulong addr) : base(addr) { }
        public LightPropagationVolumeSettings Settings { get { return this[nameof(Settings)].As<LightPropagationVolumeSettings>(); } set { this["Settings"] = value; } }
        public float BlendWeight { get { return this[nameof(BlendWeight)].GetValue<float>(); } set { this[nameof(BlendWeight)].SetValue<float>(value); } }
    }
}
