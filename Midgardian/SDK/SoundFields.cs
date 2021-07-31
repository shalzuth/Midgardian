using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.AudioExtensionsSDK;
namespace SDK.Script.SoundFieldsSDK
{
    public class AmbisonicsEncodingSettings : SoundfieldEncodingSettingsBase
    {
        public AmbisonicsEncodingSettings(ulong addr) : base(addr) { }
        public int AmbisonicsOrder { get { return this[nameof(AmbisonicsOrder)].GetValue<int>(); } set { this[nameof(AmbisonicsOrder)].SetValue<int>(value); } }
    }
}
