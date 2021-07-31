using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AppleImageUtilsSDK
{
    public class AppleImageUtilsBaseAsyncTaskBlueprintProxy : Object
    {
        public AppleImageUtilsBaseAsyncTaskBlueprintProxy(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public AppleImageUtilsImageConversionResult ConversionResult { get { return this[nameof(ConversionResult)].As<AppleImageUtilsImageConversionResult>(); } set { this["ConversionResult"] = value; } }
        public AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToTIFF(Texture SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate) { return Invoke<AppleImageUtilsBaseAsyncTaskBlueprintProxy>(nameof(CreateProxyObjectForConvertToTIFF), SourceImage, bWantColor, bUseGpu, Scale, Rotate); }
        public AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToPNG(Texture SourceImage, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate) { return Invoke<AppleImageUtilsBaseAsyncTaskBlueprintProxy>(nameof(CreateProxyObjectForConvertToPNG), SourceImage, bWantColor, bUseGpu, Scale, Rotate); }
        public AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToJPEG(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate) { return Invoke<AppleImageUtilsBaseAsyncTaskBlueprintProxy>(nameof(CreateProxyObjectForConvertToJPEG), SourceImage, Quality, bWantColor, bUseGpu, Scale, Rotate); }
        public AppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToHEIF(Texture SourceImage, int Quality, bool bWantColor, bool bUseGpu, float Scale, ETextureRotationDirection Rotate) { return Invoke<AppleImageUtilsBaseAsyncTaskBlueprintProxy>(nameof(CreateProxyObjectForConvertToHEIF), SourceImage, Quality, bWantColor, bUseGpu, Scale, Rotate); }
    }
    public class AppleImageInterface : Interface
    {
        public AppleImageInterface(ulong addr) : base(addr) { }
    }
    public class AppleImageUtilsImageConversionResult : Object
    {
        public AppleImageUtilsImageConversionResult(ulong addr) : base(addr) { }
        public Object Error { get { return this[nameof(Error)]; } set { this[nameof(Error)] = value; } }
        public Array<byte> ImageData { get { return new Array<byte>(this[nameof(ImageData)].Address); } }
    }
    public enum EAppleTextureType : int
    {
        Unknown = 0,
        Image = 1,
        PixelBuffer = 2,
        Surface = 3,
        MetalTexture = 4,
        EAppleTextureType_MAX = 5,
    }
    public enum ETextureRotationDirection : int
    {
        None = 0,
        Left = 1,
        Right = 2,
        Down = 3,
        LeftMirrored = 4,
        RightMirrored = 5,
        DownMirrored = 6,
        UpMirrored = 7,
        ETextureRotationDirection_MAX = 8,
    }
}
