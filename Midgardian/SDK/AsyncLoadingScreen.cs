using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AsyncLoadingScreenSDK
{
    public class AsyncLoadingScreenLibrary : BlueprintFunctionLibrary
    {
        public AsyncLoadingScreenLibrary(ulong addr) : base(addr) { }
        public void StopLoadingScreen() { Invoke(nameof(StopLoadingScreen)); }
        public void StartLoadingScreen() { Invoke(nameof(StartLoadingScreen)); }
        public void SetDisplayTipTextIndex(int TipTextIndex) { Invoke(nameof(SetDisplayTipTextIndex), TipTextIndex); }
        public void SetDisplayMovieIndex(int MovieIndex) { Invoke(nameof(SetDisplayMovieIndex), MovieIndex); }
        public void SetDisplayLoadingScreen(Object LoadingScreenName) { Invoke(nameof(SetDisplayLoadingScreen), LoadingScreenName); }
        public void SetDisplayBackgroundIndex(int BackgroundIndex) { Invoke(nameof(SetDisplayBackgroundIndex), BackgroundIndex); }
        public bool IsCurrentlyPlaying() { return Invoke<bool>(nameof(IsCurrentlyPlaying)); }
    }
    public enum ELoadingWidgetType : int
    {
        LWT_Horizontal = 0,
        LWT_Vertical = 1,
        LWT_MAX = 2,
    }
    public enum ELoadingIconType : int
    {
        LIT_Throbber = 0,
        LIT_CircularThrobber = 1,
        LIT_ImageSequence = 2,
        LIT_MAX = 3,
    }
    public enum EAsyncLoadingScreenLayout : int
    {
        ALSL_Classic = 0,
        ALSL_Center = 1,
        ALSL_Letterbox = 2,
        ALSL_Sidebar = 3,
        ALSL_DualSidebar = 4,
        ALSL_MAX = 5,
    }
    public class DualSidebarLayoutSettings : Object
    {
        public DualSidebarLayoutSettings(ulong addr) : base(addr) { }
        public bool bIsLoadingWidgetAtRight { get { return this[nameof(bIsLoadingWidgetAtRight)].Flag; } set { this[nameof(bIsLoadingWidgetAtRight)].Flag = value; } }
        public byte LeftVerticalAlignment { get { return this[nameof(LeftVerticalAlignment)].GetValue<byte>(); } set { this[nameof(LeftVerticalAlignment)].SetValue<byte>(value); } }
        public byte RightVerticalAlignment { get { return this[nameof(RightVerticalAlignment)].GetValue<byte>(); } set { this[nameof(RightVerticalAlignment)].SetValue<byte>(value); } }
        public byte LeftBorderVerticalAlignment { get { return this[nameof(LeftBorderVerticalAlignment)].GetValue<byte>(); } set { this[nameof(LeftBorderVerticalAlignment)].SetValue<byte>(value); } }
        public byte RightBorderVerticalAlignment { get { return this[nameof(RightBorderVerticalAlignment)].GetValue<byte>(); } set { this[nameof(RightBorderVerticalAlignment)].SetValue<byte>(value); } }
        public Margin LeftBorderPadding { get { return this[nameof(LeftBorderPadding)].As<Margin>(); } set { this["LeftBorderPadding"] = value; } }
        public Margin RightBorderPadding { get { return this[nameof(RightBorderPadding)].As<Margin>(); } set { this["RightBorderPadding"] = value; } }
        public SlateBrush LeftBorderBackground { get { return this[nameof(LeftBorderBackground)].As<SlateBrush>(); } set { this["LeftBorderBackground"] = value; } }
        public SlateBrush RightBorderBackground { get { return this[nameof(RightBorderBackground)].As<SlateBrush>(); } set { this["RightBorderBackground"] = value; } }
    }
    public class SidebarLayoutSettings : Object
    {
        public SidebarLayoutSettings(ulong addr) : base(addr) { }
        public bool bIsWidgetAtRight { get { return this[nameof(bIsWidgetAtRight)].Flag; } set { this[nameof(bIsWidgetAtRight)].Flag = value; } }
        public bool bIsLoadingWidgetAtTop { get { return this[nameof(bIsLoadingWidgetAtTop)].Flag; } set { this[nameof(bIsLoadingWidgetAtTop)].Flag = value; } }
        public float Space { get { return this[nameof(Space)].GetValue<float>(); } set { this[nameof(Space)].SetValue<float>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
        public WidgetAlignment LoadingWidgetAlignment { get { return this[nameof(LoadingWidgetAlignment)].As<WidgetAlignment>(); } set { this["LoadingWidgetAlignment"] = value; } }
        public WidgetAlignment TipAlignment { get { return this[nameof(TipAlignment)].As<WidgetAlignment>(); } set { this["TipAlignment"] = value; } }
        public byte BorderVerticalAlignment { get { return this[nameof(BorderVerticalAlignment)].GetValue<byte>(); } set { this[nameof(BorderVerticalAlignment)].SetValue<byte>(value); } }
        public float BorderHorizontalOffset { get { return this[nameof(BorderHorizontalOffset)].GetValue<float>(); } set { this[nameof(BorderHorizontalOffset)].SetValue<float>(value); } }
        public Margin BorderPadding { get { return this[nameof(BorderPadding)].As<Margin>(); } set { this["BorderPadding"] = value; } }
        public SlateBrush BorderBackground { get { return this[nameof(BorderBackground)].As<SlateBrush>(); } set { this["BorderBackground"] = value; } }
    }
    public class WidgetAlignment : Object
    {
        public WidgetAlignment(ulong addr) : base(addr) { }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public byte VerticalAlignment { get { return this[nameof(VerticalAlignment)].GetValue<byte>(); } set { this[nameof(VerticalAlignment)].SetValue<byte>(value); } }
    }
    public class LetterboxLayoutSettings : Object
    {
        public LetterboxLayoutSettings(ulong addr) : base(addr) { }
        public bool bIsLoadingWidgetAtTop { get { return this[nameof(bIsLoadingWidgetAtTop)].Flag; } set { this[nameof(bIsLoadingWidgetAtTop)].Flag = value; } }
        public WidgetAlignment TipAlignment { get { return this[nameof(TipAlignment)].As<WidgetAlignment>(); } set { this["TipAlignment"] = value; } }
        public WidgetAlignment LoadingWidgetAlignment { get { return this[nameof(LoadingWidgetAlignment)].As<WidgetAlignment>(); } set { this["LoadingWidgetAlignment"] = value; } }
        public byte TopBorderHorizontalAlignment { get { return this[nameof(TopBorderHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(TopBorderHorizontalAlignment)].SetValue<byte>(value); } }
        public byte BottomBorderHorizontalAlignment { get { return this[nameof(BottomBorderHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(BottomBorderHorizontalAlignment)].SetValue<byte>(value); } }
        public Margin TopBorderPadding { get { return this[nameof(TopBorderPadding)].As<Margin>(); } set { this["TopBorderPadding"] = value; } }
        public Margin BottomBorderPadding { get { return this[nameof(BottomBorderPadding)].As<Margin>(); } set { this["BottomBorderPadding"] = value; } }
        public SlateBrush TopBorderBackground { get { return this[nameof(TopBorderBackground)].As<SlateBrush>(); } set { this["TopBorderBackground"] = value; } }
        public SlateBrush BottomBorderBackground { get { return this[nameof(BottomBorderBackground)].As<SlateBrush>(); } set { this["BottomBorderBackground"] = value; } }
    }
    public class CenterLayoutSettings : Object
    {
        public CenterLayoutSettings(ulong addr) : base(addr) { }
        public bool bIsTipAtBottom { get { return this[nameof(bIsTipAtBottom)].Flag; } set { this[nameof(bIsTipAtBottom)].Flag = value; } }
        public WidgetAlignment TipAlignment { get { return this[nameof(TipAlignment)].As<WidgetAlignment>(); } set { this["TipAlignment"] = value; } }
        public byte BorderHorizontalAlignment { get { return this[nameof(BorderHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(BorderHorizontalAlignment)].SetValue<byte>(value); } }
        public float BorderVerticalOffset { get { return this[nameof(BorderVerticalOffset)].GetValue<float>(); } set { this[nameof(BorderVerticalOffset)].SetValue<float>(value); } }
        public Margin BorderPadding { get { return this[nameof(BorderPadding)].As<Margin>(); } set { this["BorderPadding"] = value; } }
        public SlateBrush BorderBackground { get { return this[nameof(BorderBackground)].As<SlateBrush>(); } set { this["BorderBackground"] = value; } }
    }
    public class ClassicLayoutSettings : Object
    {
        public ClassicLayoutSettings(ulong addr) : base(addr) { }
        public bool bIsWidgetAtBottom { get { return this[nameof(bIsWidgetAtBottom)].Flag; } set { this[nameof(bIsWidgetAtBottom)].Flag = value; } }
        public bool bIsLoadingWidgetAtLeft { get { return this[nameof(bIsLoadingWidgetAtLeft)].Flag; } set { this[nameof(bIsLoadingWidgetAtLeft)].Flag = value; } }
        public float Space { get { return this[nameof(Space)].GetValue<float>(); } set { this[nameof(Space)].SetValue<float>(value); } }
        public WidgetAlignment TipAlignment { get { return this[nameof(TipAlignment)].As<WidgetAlignment>(); } set { this["TipAlignment"] = value; } }
        public byte BorderHorizontalAlignment { get { return this[nameof(BorderHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(BorderHorizontalAlignment)].SetValue<byte>(value); } }
        public Margin BorderPadding { get { return this[nameof(BorderPadding)].As<Margin>(); } set { this["BorderPadding"] = value; } }
        public SlateBrush BorderBackground { get { return this[nameof(BorderBackground)].As<SlateBrush>(); } set { this["BorderBackground"] = value; } }
    }
    public class ALoadingScreenSettings : Object
    {
        public ALoadingScreenSettings(ulong addr) : base(addr) { }
        public float MinimumLoadingScreenDisplayTime { get { return this[nameof(MinimumLoadingScreenDisplayTime)].GetValue<float>(); } set { this[nameof(MinimumLoadingScreenDisplayTime)].SetValue<float>(value); } }
        public bool bAutoCompleteWhenLoadingCompletes { get { return this[nameof(bAutoCompleteWhenLoadingCompletes)].Flag; } set { this[nameof(bAutoCompleteWhenLoadingCompletes)].Flag = value; } }
        public bool bMoviesAreSkippable { get { return this[nameof(bMoviesAreSkippable)].Flag; } set { this[nameof(bMoviesAreSkippable)].Flag = value; } }
        public bool bWaitForManualStop { get { return this[nameof(bWaitForManualStop)].Flag; } set { this[nameof(bWaitForManualStop)].Flag = value; } }
        public bool bAllowInEarlyStartup { get { return this[nameof(bAllowInEarlyStartup)].Flag; } set { this[nameof(bAllowInEarlyStartup)].Flag = value; } }
        public bool bAllowEngineTick { get { return this[nameof(bAllowEngineTick)].Flag; } set { this[nameof(bAllowEngineTick)].Flag = value; } }
        public byte PlaybackType { get { return this[nameof(PlaybackType)].GetValue<byte>(); } set { this[nameof(PlaybackType)].SetValue<byte>(value); } }
        public Array<Object> MoviePaths { get { return new Array<Object>(this[nameof(MoviePaths)].Address); } }
        public bool bShuffle { get { return this[nameof(bShuffle)].Flag; } set { this[nameof(bShuffle)].Flag = value; } }
        public bool bSetDisplayMovieIndexManually { get { return this[nameof(bSetDisplayMovieIndexManually)].Flag; } set { this[nameof(bSetDisplayMovieIndexManually)].Flag = value; } }
        public bool bShowWidgetOverlay { get { return this[nameof(bShowWidgetOverlay)].Flag; } set { this[nameof(bShowWidgetOverlay)].Flag = value; } }
        public bool bShowLoadingCompleteText { get { return this[nameof(bShowLoadingCompleteText)].Flag; } set { this[nameof(bShowLoadingCompleteText)].Flag = value; } }
        public LoadingCompleteTextSettings LoadingCompleteTextSettings { get { return this[nameof(LoadingCompleteTextSettings)].As<LoadingCompleteTextSettings>(); } set { this["LoadingCompleteTextSettings"] = value; } }
        public BackgroundSettings Background { get { return this[nameof(Background)].As<BackgroundSettings>(); } set { this["Background"] = value; } }
        public TipSettings TipWidget { get { return this[nameof(TipWidget)].As<TipSettings>(); } set { this["TipWidget"] = value; } }
        public LoadingWidgetSettings LoadingWidget { get { return this[nameof(LoadingWidget)].As<LoadingWidgetSettings>(); } set { this["LoadingWidget"] = value; } }
        public EAsyncLoadingScreenLayout Layout { get { return (EAsyncLoadingScreenLayout)this[nameof(Layout)].GetValue<int>(); } set { this[nameof(Layout)].SetValue<int>((int)value); } }
    }
    public class LoadingWidgetSettings : Object
    {
        public LoadingWidgetSettings(ulong addr) : base(addr) { }
        public ELoadingIconType LoadingIconType { get { return (ELoadingIconType)this[nameof(LoadingIconType)].GetValue<int>(); } set { this[nameof(LoadingIconType)].SetValue<int>((int)value); } }
        public ELoadingWidgetType LoadingWidgetType { get { return (ELoadingWidgetType)this[nameof(LoadingWidgetType)].GetValue<int>(); } set { this[nameof(LoadingWidgetType)].SetValue<int>((int)value); } }
        public Vector2D TransformTranslation { get { return this[nameof(TransformTranslation)].As<Vector2D>(); } set { this["TransformTranslation"] = value; } }
        public Vector2D TransformScale { get { return this[nameof(TransformScale)].As<Vector2D>(); } set { this["TransformScale"] = value; } }
        public Vector2D TransformPivot { get { return this[nameof(TransformPivot)].As<Vector2D>(); } set { this["TransformPivot"] = value; } }
        public Object LoadingText { get { return this[nameof(LoadingText)]; } set { this[nameof(LoadingText)] = value; } }
        public bool bLoadingTextRightPosition { get { return this[nameof(bLoadingTextRightPosition)].Flag; } set { this[nameof(bLoadingTextRightPosition)].Flag = value; } }
        public bool bLoadingTextTopPosition { get { return this[nameof(bLoadingTextTopPosition)].Flag; } set { this[nameof(bLoadingTextTopPosition)].Flag = value; } }
        public TextAppearance Appearance { get { return this[nameof(Appearance)].As<TextAppearance>(); } set { this["Appearance"] = value; } }
        public ThrobberSettings ThrobberSettings { get { return this[nameof(ThrobberSettings)].As<ThrobberSettings>(); } set { this["ThrobberSettings"] = value; } }
        public CircularThrobberSettings CircularThrobberSettings { get { return this[nameof(CircularThrobberSettings)].As<CircularThrobberSettings>(); } set { this["CircularThrobberSettings"] = value; } }
        public ImageSequenceSettings ImageSequenceSettings { get { return this[nameof(ImageSequenceSettings)].As<ImageSequenceSettings>(); } set { this["ImageSequenceSettings"] = value; } }
        public WidgetAlignment TextAlignment { get { return this[nameof(TextAlignment)].As<WidgetAlignment>(); } set { this["TextAlignment"] = value; } }
        public WidgetAlignment LoadingIconAlignment { get { return this[nameof(LoadingIconAlignment)].As<WidgetAlignment>(); } set { this["LoadingIconAlignment"] = value; } }
        public float Space { get { return this[nameof(Space)].GetValue<float>(); } set { this[nameof(Space)].SetValue<float>(value); } }
    }
    public class ImageSequenceSettings : Object
    {
        public ImageSequenceSettings(ulong addr) : base(addr) { }
        public Array<Texture2D> Images { get { return new Array<Texture2D>(this[nameof(Images)].Address); } }
        public Vector2D Scale { get { return this[nameof(Scale)].As<Vector2D>(); } set { this["Scale"] = value; } }
        public float Interval { get { return this[nameof(Interval)].GetValue<float>(); } set { this[nameof(Interval)].SetValue<float>(value); } }
        public bool bPlayReverse { get { return this[nameof(bPlayReverse)].Flag; } set { this[nameof(bPlayReverse)].Flag = value; } }
    }
    public class CircularThrobberSettings : Object
    {
        public CircularThrobberSettings(ulong addr) : base(addr) { }
        public int NumberOfPieces { get { return this[nameof(NumberOfPieces)].GetValue<int>(); } set { this[nameof(NumberOfPieces)].SetValue<int>(value); } }
        public float Period { get { return this[nameof(Period)].GetValue<float>(); } set { this[nameof(Period)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public SlateBrush Image { get { return this[nameof(Image)].As<SlateBrush>(); } set { this["Image"] = value; } }
    }
    public class ThrobberSettings : Object
    {
        public ThrobberSettings(ulong addr) : base(addr) { }
        public int NumberOfPieces { get { return this[nameof(NumberOfPieces)].GetValue<int>(); } set { this[nameof(NumberOfPieces)].SetValue<int>(value); } }
        public bool bAnimateHorizontally { get { return this[nameof(bAnimateHorizontally)].Flag; } set { this[nameof(bAnimateHorizontally)].Flag = value; } }
        public bool bAnimateVertically { get { return this[nameof(bAnimateVertically)].Flag; } set { this[nameof(bAnimateVertically)].Flag = value; } }
        public bool bAnimateOpacity { get { return this[nameof(bAnimateOpacity)].Flag; } set { this[nameof(bAnimateOpacity)].Flag = value; } }
        public SlateBrush Image { get { return this[nameof(Image)].As<SlateBrush>(); } set { this["Image"] = value; } }
    }
    public class TextAppearance : Object
    {
        public TextAppearance(ulong addr) : base(addr) { }
        public SlateColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<SlateColor>(); } set { this["ColorAndOpacity"] = value; } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public Vector2D ShadowOffset { get { return this[nameof(ShadowOffset)].As<Vector2D>(); } set { this["ShadowOffset"] = value; } }
        public LinearColor ShadowColorAndOpacity { get { return this[nameof(ShadowColorAndOpacity)].As<LinearColor>(); } set { this["ShadowColorAndOpacity"] = value; } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
    }
    public class TipSettings : Object
    {
        public TipSettings(ulong addr) : base(addr) { }
        public float DefaultTipDelay { get { return this[nameof(DefaultTipDelay)].GetValue<float>(); } set { this[nameof(DefaultTipDelay)].SetValue<float>(value); } }
        public Object TimedTips { get { return this[nameof(TimedTips)]; } set { this[nameof(TimedTips)] = value; } }
        public Array<Object> TipText { get { return new Array<Object>(this[nameof(TipText)].Address); } }
        public TextAppearance Appearance { get { return this[nameof(Appearance)].As<TextAppearance>(); } set { this["Appearance"] = value; } }
        public float TipWrapAt { get { return this[nameof(TipWrapAt)].GetValue<float>(); } set { this[nameof(TipWrapAt)].SetValue<float>(value); } }
        public bool bSetDisplayTipTextManually { get { return this[nameof(bSetDisplayTipTextManually)].Flag; } set { this[nameof(bSetDisplayTipTextManually)].Flag = value; } }
    }
    public class BackgroundSettings : Object
    {
        public BackgroundSettings(ulong addr) : base(addr) { }
        public Array<SoftObjectPath> Images { get { return new Array<SoftObjectPath>(this[nameof(Images)].Address); } }
        public byte ImageStretch { get { return this[nameof(ImageStretch)].GetValue<byte>(); } set { this[nameof(ImageStretch)].SetValue<byte>(value); } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public LinearColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<LinearColor>(); } set { this["BackgroundColor"] = value; } }
        public bool bSetDisplayBackgroundManually { get { return this[nameof(bSetDisplayBackgroundManually)].Flag; } set { this[nameof(bSetDisplayBackgroundManually)].Flag = value; } }
    }
    public class LoadingCompleteTextSettings : Object
    {
        public LoadingCompleteTextSettings(ulong addr) : base(addr) { }
        public Object LoadingCompleteText { get { return this[nameof(LoadingCompleteText)]; } set { this[nameof(LoadingCompleteText)] = value; } }
        public TextAppearance Appearance { get { return this[nameof(Appearance)].As<TextAppearance>(); } set { this["Appearance"] = value; } }
        public WidgetAlignment Alignment { get { return this[nameof(Alignment)].As<WidgetAlignment>(); } set { this["Alignment"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public bool bFadeInOutAnim { get { return this[nameof(bFadeInOutAnim)].Flag; } set { this[nameof(bFadeInOutAnim)].Flag = value; } }
        public float AnimationSpeed { get { return this[nameof(AnimationSpeed)].GetValue<float>(); } set { this[nameof(AnimationSpeed)].SetValue<float>(value); } }
    }
}
