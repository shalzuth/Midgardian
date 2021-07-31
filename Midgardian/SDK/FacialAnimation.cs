using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.FacialAnimationSDK
{
    public class AudioCurveSourceComponent : AudioComponent
    {
        public AudioCurveSourceComponent(ulong addr) : base(addr) { }
        public Object CurveSourceBindingName { get { return this[nameof(CurveSourceBindingName)]; } set { this[nameof(CurveSourceBindingName)] = value; } }
        public float CurveSyncOffset { get { return this[nameof(CurveSyncOffset)].GetValue<float>(); } set { this[nameof(CurveSyncOffset)].SetValue<float>(value); } }
    }
}
