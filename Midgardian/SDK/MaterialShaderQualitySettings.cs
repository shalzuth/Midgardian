using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.MaterialShaderQualitySettingsSDK
{
    public class MaterialShaderQualitySettings : Object
    {
        public MaterialShaderQualitySettings(ulong addr) : base(addr) { }
        public Object ForwardSettingMap { get { return this[nameof(ForwardSettingMap)]; } set { this[nameof(ForwardSettingMap)] = value; } }
    }
    public class ShaderPlatformQualitySettings : Object
    {
        public ShaderPlatformQualitySettings(ulong addr) : base(addr) { }
        public MaterialQualityOverrides QualityOverrides { get { return this[nameof(QualityOverrides)].As<MaterialQualityOverrides>(); } set { this["QualityOverrides"] = value; } }
    }
    public enum EMobileShadowQuality : int
    {
        NoFiltering = 0,
        PCF_1x1 = 1,
        PCF_2x2 = 2,
        PCF_3x3 = 3,
        EMobileShadowQuality_MAX = 4,
    }
    public class MaterialQualityOverrides : Object
    {
        public MaterialQualityOverrides(ulong addr) : base(addr) { }
        public bool bDiscardQualityDuringCook { get { return this[nameof(bDiscardQualityDuringCook)].Flag; } set { this[nameof(bDiscardQualityDuringCook)].Flag = value; } }
        public bool bEnableOverride { get { return this[nameof(bEnableOverride)].Flag; } set { this[nameof(bEnableOverride)].Flag = value; } }
        public bool bForceFullyRough { get { return this[nameof(bForceFullyRough)].Flag; } set { this[nameof(bForceFullyRough)].Flag = value; } }
        public bool bForceNonMetal { get { return this[nameof(bForceNonMetal)].Flag; } set { this[nameof(bForceNonMetal)].Flag = value; } }
        public bool bForceDisableLMDirectionality { get { return this[nameof(bForceDisableLMDirectionality)].Flag; } set { this[nameof(bForceDisableLMDirectionality)].Flag = value; } }
        public bool bForceLQReflections { get { return this[nameof(bForceLQReflections)].Flag; } set { this[nameof(bForceLQReflections)].Flag = value; } }
        public bool bForceDisablePreintegratedGF { get { return this[nameof(bForceDisablePreintegratedGF)].Flag; } set { this[nameof(bForceDisablePreintegratedGF)].Flag = value; } }
        public bool bDisableMaterialNormalCalculation { get { return this[nameof(bDisableMaterialNormalCalculation)].Flag; } set { this[nameof(bDisableMaterialNormalCalculation)].Flag = value; } }
        public EMobileShadowQuality MobileShadowQuality { get { return (EMobileShadowQuality)this[nameof(MobileShadowQuality)].GetValue<int>(); } set { this[nameof(MobileShadowQuality)].SetValue<int>((int)value); } }
    }
}
