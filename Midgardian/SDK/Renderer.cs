using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.RendererSDK
{
    public class LightPropagationVolumeSettings : Object
    {
        public LightPropagationVolumeSettings(ulong addr) : base(addr) { }
        public bool bOverride_LPVIntensity { get { return this[nameof(bOverride_LPVIntensity)].Flag; } set { this[nameof(bOverride_LPVIntensity)].Flag = value; } }
        public bool bOverride_LPVDirectionalOcclusionIntensity { get { return this[nameof(bOverride_LPVDirectionalOcclusionIntensity)].Flag; } set { this[nameof(bOverride_LPVDirectionalOcclusionIntensity)].Flag = value; } }
        public bool bOverride_LPVDirectionalOcclusionRadius { get { return this[nameof(bOverride_LPVDirectionalOcclusionRadius)].Flag; } set { this[nameof(bOverride_LPVDirectionalOcclusionRadius)].Flag = value; } }
        public bool bOverride_LPVDiffuseOcclusionExponent { get { return this[nameof(bOverride_LPVDiffuseOcclusionExponent)].Flag; } set { this[nameof(bOverride_LPVDiffuseOcclusionExponent)].Flag = value; } }
        public bool bOverride_LPVSpecularOcclusionExponent { get { return this[nameof(bOverride_LPVSpecularOcclusionExponent)].Flag; } set { this[nameof(bOverride_LPVSpecularOcclusionExponent)].Flag = value; } }
        public bool bOverride_LPVDiffuseOcclusionIntensity { get { return this[nameof(bOverride_LPVDiffuseOcclusionIntensity)].Flag; } set { this[nameof(bOverride_LPVDiffuseOcclusionIntensity)].Flag = value; } }
        public bool bOverride_LPVSpecularOcclusionIntensity { get { return this[nameof(bOverride_LPVSpecularOcclusionIntensity)].Flag; } set { this[nameof(bOverride_LPVSpecularOcclusionIntensity)].Flag = value; } }
        public bool bOverride_LPVSize { get { return this[nameof(bOverride_LPVSize)].Flag; } set { this[nameof(bOverride_LPVSize)].Flag = value; } }
        public bool bOverride_LPVSecondaryOcclusionIntensity { get { return this[nameof(bOverride_LPVSecondaryOcclusionIntensity)].Flag; } set { this[nameof(bOverride_LPVSecondaryOcclusionIntensity)].Flag = value; } }
        public bool bOverride_LPVSecondaryBounceIntensity { get { return this[nameof(bOverride_LPVSecondaryBounceIntensity)].Flag; } set { this[nameof(bOverride_LPVSecondaryBounceIntensity)].Flag = value; } }
        public bool bOverride_LPVGeometryVolumeBias { get { return this[nameof(bOverride_LPVGeometryVolumeBias)].Flag; } set { this[nameof(bOverride_LPVGeometryVolumeBias)].Flag = value; } }
        public bool bOverride_LPVVplInjectionBias { get { return this[nameof(bOverride_LPVVplInjectionBias)].Flag; } set { this[nameof(bOverride_LPVVplInjectionBias)].Flag = value; } }
        public bool bOverride_LPVEmissiveInjectionIntensity { get { return this[nameof(bOverride_LPVEmissiveInjectionIntensity)].Flag; } set { this[nameof(bOverride_LPVEmissiveInjectionIntensity)].Flag = value; } }
        public float LPVIntensity { get { return this[nameof(LPVIntensity)].GetValue<float>(); } set { this[nameof(LPVIntensity)].SetValue<float>(value); } }
        public float LPVVplInjectionBias { get { return this[nameof(LPVVplInjectionBias)].GetValue<float>(); } set { this[nameof(LPVVplInjectionBias)].SetValue<float>(value); } }
        public float LPVSize { get { return this[nameof(LPVSize)].GetValue<float>(); } set { this[nameof(LPVSize)].SetValue<float>(value); } }
        public float LPVSecondaryOcclusionIntensity { get { return this[nameof(LPVSecondaryOcclusionIntensity)].GetValue<float>(); } set { this[nameof(LPVSecondaryOcclusionIntensity)].SetValue<float>(value); } }
        public float LPVSecondaryBounceIntensity { get { return this[nameof(LPVSecondaryBounceIntensity)].GetValue<float>(); } set { this[nameof(LPVSecondaryBounceIntensity)].SetValue<float>(value); } }
        public float LPVGeometryVolumeBias { get { return this[nameof(LPVGeometryVolumeBias)].GetValue<float>(); } set { this[nameof(LPVGeometryVolumeBias)].SetValue<float>(value); } }
        public float LPVEmissiveInjectionIntensity { get { return this[nameof(LPVEmissiveInjectionIntensity)].GetValue<float>(); } set { this[nameof(LPVEmissiveInjectionIntensity)].SetValue<float>(value); } }
        public float LPVDirectionalOcclusionIntensity { get { return this[nameof(LPVDirectionalOcclusionIntensity)].GetValue<float>(); } set { this[nameof(LPVDirectionalOcclusionIntensity)].SetValue<float>(value); } }
        public float LPVDirectionalOcclusionRadius { get { return this[nameof(LPVDirectionalOcclusionRadius)].GetValue<float>(); } set { this[nameof(LPVDirectionalOcclusionRadius)].SetValue<float>(value); } }
        public float LPVDiffuseOcclusionExponent { get { return this[nameof(LPVDiffuseOcclusionExponent)].GetValue<float>(); } set { this[nameof(LPVDiffuseOcclusionExponent)].SetValue<float>(value); } }
        public float LPVSpecularOcclusionExponent { get { return this[nameof(LPVSpecularOcclusionExponent)].GetValue<float>(); } set { this[nameof(LPVSpecularOcclusionExponent)].SetValue<float>(value); } }
        public float LPVDiffuseOcclusionIntensity { get { return this[nameof(LPVDiffuseOcclusionIntensity)].GetValue<float>(); } set { this[nameof(LPVDiffuseOcclusionIntensity)].SetValue<float>(value); } }
        public float LPVSpecularOcclusionIntensity { get { return this[nameof(LPVSpecularOcclusionIntensity)].GetValue<float>(); } set { this[nameof(LPVSpecularOcclusionIntensity)].SetValue<float>(value); } }
        public float LPVFadeRange { get { return this[nameof(LPVFadeRange)].GetValue<float>(); } set { this[nameof(LPVFadeRange)].SetValue<float>(value); } }
        public float LPVDirectionalOcclusionFadeRange { get { return this[nameof(LPVDirectionalOcclusionFadeRange)].GetValue<float>(); } set { this[nameof(LPVDirectionalOcclusionFadeRange)].SetValue<float>(value); } }
    }
}
