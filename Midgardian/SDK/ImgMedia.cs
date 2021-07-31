using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImgMediaSDK
{
    public class ImgMediaSource : BaseMediaSource
    {
        public ImgMediaSource(ulong addr) : base(addr) { }
        public FrameRate FrameRateOverride { get { return this[nameof(FrameRateOverride)].As<FrameRate>(); } set { this["FrameRateOverride"] = value; } }
        public Object ProxyOverride { get { return this[nameof(ProxyOverride)]; } set { this[nameof(ProxyOverride)] = value; } }
        public DirectoryPath SequencePath { get { return this[nameof(SequencePath)].As<DirectoryPath>(); } set { this["SequencePath"] = value; } }
        public void SetSequencePath(Object Path) { Invoke(nameof(SetSequencePath), Path); }
        public Object GetSequencePath() { return Invoke<Object>(nameof(GetSequencePath)); }
        public void GetProxies(Array<Object> OutProxies) { Invoke(nameof(GetProxies), OutProxies); }
    }
}
