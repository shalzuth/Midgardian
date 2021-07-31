using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.UMGSDK;
namespace SDK.Script.ShiftUISDK
{
    public class ShiftUI : Object
    {
        public ShiftUI(ulong addr) : base(addr) { }
        public Object ShiftSession { get { return this[nameof(ShiftSession)]; } set { this[nameof(ShiftSession)] = value; } }
    }
    public class ShiftUICoherentRenderingSettings : Object
    {
        public ShiftUICoherentRenderingSettings(ulong addr) : base(addr) { }
        public EShiftUICoherentRenderingSettingsSeverity RenderingLogSeverity { get { return (EShiftUICoherentRenderingSettingsSeverity)this[nameof(RenderingLogSeverity)].GetValue<int>(); } set { this[nameof(RenderingLogSeverity)].SetValue<int>((int)value); } }
        public bool ShowWarningsOnScreen { get { return this[nameof(ShowWarningsOnScreen)].Flag; } set { this[nameof(ShowWarningsOnScreen)].Flag = value; } }
        public Object DeveloperOptions { get { return this[nameof(DeveloperOptions)]; } set { this[nameof(DeveloperOptions)] = value; } }
    }
    public class ShiftUICohTextureUserWrapData : Object
    {
        public ShiftUICohTextureUserWrapData(ulong addr) : base(addr) { }
        public Texture Texture { get { return this[nameof(Texture)].As<Texture>(); } set { this["Texture"] = value; } }
    }
    public class ShiftUICohtmlAssetReferencer : Object
    {
        public ShiftUICohtmlAssetReferencer(ulong addr) : base(addr) { }
    }
    public class ShiftUICohtmlAtlasContainedTextures : Object
    {
        public ShiftUICohtmlAtlasContainedTextures(ulong addr) : base(addr) { }
        public Object Textures { get { return this[nameof(Textures)]; } set { this[nameof(Textures)] = value; } }
    }
    public class ShiftUICohtmlTextureAtlasDetails : Object
    {
        public ShiftUICohtmlTextureAtlasDetails(ulong addr) : base(addr) { }
        public Object AtlasPath { get { return this[nameof(AtlasPath)]; } set { this[nameof(AtlasPath)] = value; } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public Object PixelFormat { get { return this[nameof(PixelFormat)]; } set { this[nameof(PixelFormat)] = value; } }
        public int MaxAtlasWidth { get { return this[nameof(MaxAtlasWidth)].GetValue<int>(); } set { this[nameof(MaxAtlasWidth)].SetValue<int>(value); } }
        public int MaxAtlasHeight { get { return this[nameof(MaxAtlasHeight)].GetValue<int>(); } set { this[nameof(MaxAtlasHeight)].SetValue<int>(value); } }
        public int MaxTextureWidth { get { return this[nameof(MaxTextureWidth)].GetValue<int>(); } set { this[nameof(MaxTextureWidth)].SetValue<int>(value); } }
        public int MaxTextureHeight { get { return this[nameof(MaxTextureHeight)].GetValue<int>(); } set { this[nameof(MaxTextureHeight)].SetValue<int>(value); } }
    }
    public class ShiftUICohtmlAudioWrapper : Object
    {
        public ShiftUICohtmlAudioWrapper(ulong addr) : base(addr) { }
        public Object Owner { get { return this[nameof(Owner)].As<Object>(); } set { this["Owner"] = value; } }
        public Object Sounds { get { return this[nameof(Sounds)]; } set { this[nameof(Sounds)] = value; } }
    }
    public class ShiftUICohtmlBaseComponent : ActorComponent
    {
        public ShiftUICohtmlBaseComponent(ulong addr) : base(addr) { }
        public Object ReadyForBindings { get { return this[nameof(ReadyForBindings)]; } set { this[nameof(ReadyForBindings)] = value; } }
        public Object BindingsReleased { get { return this[nameof(BindingsReleased)]; } set { this[nameof(BindingsReleased)] = value; } }
        public Object ScriptingReady { get { return this[nameof(ScriptingReady)]; } set { this[nameof(ScriptingReady)] = value; } }
        public Array<Texture2D> PreloadedTextures { get { return new Array<Texture2D>(this[nameof(PreloadedTextures)].Address); } }
        public bool bEnableComplexCSSSupport { get { return this[nameof(bEnableComplexCSSSupport)].Flag; } set { this[nameof(bEnableComplexCSSSupport)].Flag = value; } }
        public TextureRenderTarget2D Texture { get { return this[nameof(Texture)].As<TextureRenderTarget2D>(); } set { this["Texture"] = value; } }
        public byte Filter { get { return this[nameof(Filter)].GetValue<byte>(); } set { this[nameof(Filter)].SetValue<byte>(value); } }
        public bool bReceiveInput { get { return this[nameof(bReceiveInput)].Flag; } set { this[nameof(bReceiveInput)].Flag = value; } }
        public bool bDelayedUpdate { get { return this[nameof(bDelayedUpdate)].Flag; } set { this[nameof(bDelayedUpdate)].Flag = value; } }
        public bool bUseWideColorTextures { get { return this[nameof(bUseWideColorTextures)].Flag; } set { this[nameof(bUseWideColorTextures)].Flag = value; } }
        public ShiftUICohtmlAudioWrapper AudioWrapper { get { return this[nameof(AudioWrapper)].As<ShiftUICohtmlAudioWrapper>(); } set { this["AudioWrapper"] = value; } }
        public void UpdateWholeDataModelFromStruct(Object Struct) { Invoke(nameof(UpdateWholeDataModelFromStruct), Struct); }
        public void UpdateWholeDataModelFromObject(Object Model) { Invoke(nameof(UpdateWholeDataModelFromObject), Model); }
        public void TriggerJSEvent(Object Name, ShiftUICohtmlJSEvent EventData) { Invoke(nameof(TriggerJSEvent), Name, EventData); }
        public void SynchronizeModels() { Invoke(nameof(SynchronizeModels)); }
        public void ShowPaintRects(bool Show) { Invoke(nameof(ShowPaintRects), Show); }
        public void SetSoundAttenuation(SoundAttenuationSettings Settings) { Invoke(nameof(SetSoundAttenuation), Settings); }
        public void Resize(int Width, int Height) { Invoke(nameof(Resize), Width, Height); }
        public bool RemovePreloadedTextureFromPath(Object AssetPath) { return Invoke<bool>(nameof(RemovePreloadedTextureFromPath), AssetPath); }
        public bool RemovePreloadedTexture(Texture2D Texture) { return Invoke<bool>(nameof(RemovePreloadedTexture), Texture); }
        public void RemoveDataModelFromStruct(Object Struct) { Invoke(nameof(RemoveDataModelFromStruct), Struct); }
        public void RemoveDataModelFromObject(Object Model) { Invoke(nameof(RemoveDataModelFromObject), Model); }
        public void RemoveAllPreloadedTextures() { Invoke(nameof(RemoveAllPreloadedTextures)); }
        public void Reload() { Invoke(nameof(Reload)); }
        public void PreloadTextureSync(Object AssetPath) { Invoke(nameof(PreloadTextureSync), AssetPath); }
        public void PreloadTextureAsync(Object AssetPath) { Invoke(nameof(PreloadTextureAsync), AssetPath); }
        public void Load(Object Path) { Invoke(nameof(Load), Path); }
        public bool IsReadyToCreateView() { return Invoke<bool>(nameof(IsReadyToCreateView)); }
        public bool IsReadyForBindings() { return Invoke<bool>(nameof(IsReadyForBindings)); }
        public bool HasRequestedView() { return Invoke<bool>(nameof(HasRequestedView)); }
        public void EndDebugFrameSave() { Invoke(nameof(EndDebugFrameSave)); }
        public void EnableRendering(bool bEnabled) { Invoke(nameof(EnableRendering), bEnabled); }
        public void EnableDelayedUpdate(bool bEnabled) { Invoke(nameof(EnableDelayedUpdate), bEnabled); }
        public void DebugSaveNextFrame() { Invoke(nameof(DebugSaveNextFrame)); }
        public ShiftUICohtmlJSEvent CreateJSEvent() { return Invoke<ShiftUICohtmlJSEvent>(nameof(CreateJSEvent)); }
        public void CreateDataModelFromStruct(Object Name, Object Arg) { Invoke(nameof(CreateDataModelFromStruct), Name, Arg); }
        public void CreateDataModelFromObject(Object Name, Object Model) { Invoke(nameof(CreateDataModelFromObject), Name, Model); }
        public void BeginDebugFrameSave() { Invoke(nameof(BeginDebugFrameSave)); }
        public void AddPreloadedTexture(Texture2D Texture) { Invoke(nameof(AddPreloadedTexture), Texture); }
    }
    public class ShiftUICohtmlBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public ShiftUICohtmlBlueprintFunctionLibrary(ulong addr) : base(addr) { }
        public void TriggerJSEvent(ShiftUICohtmlBaseComponent Component, Object EventName, ShiftUICohtmlJSEvent JSEvent) { Invoke(nameof(TriggerJSEvent), Component, EventName, JSEvent); }
        public ShiftUICohtmlJSEvent CreateJSEvent(Object WorldContextObject) { return Invoke<ShiftUICohtmlJSEvent>(nameof(CreateJSEvent), WorldContextObject); }
        public void AddStructArg(ShiftUICohtmlJSEvent JSEvent, Object Arg) { Invoke(nameof(AddStructArg), JSEvent, Arg); }
        public void AddString(ShiftUICohtmlJSEvent JSEvent, Object Arg) { Invoke(nameof(AddString), JSEvent, Arg); }
        public void AddObject(ShiftUICohtmlJSEvent JSEvent, Object Arg) { Invoke(nameof(AddObject), JSEvent, Arg); }
        public void AddInt32(ShiftUICohtmlJSEvent JSEvent, int Arg) { Invoke(nameof(AddInt32), JSEvent, Arg); }
        public void AddFloat(ShiftUICohtmlJSEvent JSEvent, float Arg) { Invoke(nameof(AddFloat), JSEvent, Arg); }
        public void AddByte(ShiftUICohtmlJSEvent JSEvent, byte Arg) { Invoke(nameof(AddByte), JSEvent, Arg); }
        public void AddBool(ShiftUICohtmlJSEvent JSEvent, bool Arg) { Invoke(nameof(AddBool), JSEvent, Arg); }
        public void AddArrayOfStructs(ShiftUICohtmlJSEvent JSEvent, Array<int> Arg) { Invoke(nameof(AddArrayOfStructs), JSEvent, Arg); }
        public void AddArray(ShiftUICohtmlJSEvent JSEvent, Array<int> Arg, int ArrayType) { Invoke(nameof(AddArray), JSEvent, Arg, ArrayType); }
    }
    public class ShiftUICohtmlComponent : ShiftUICohtmlBaseComponent
    {
        public ShiftUICohtmlComponent(ulong addr) : base(addr) { }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public bool ManualTexture { get { return this[nameof(ManualTexture)].Flag; } set { this[nameof(ManualTexture)].Flag = value; } }
        public Object PrimitiveName { get { return this[nameof(PrimitiveName)]; } set { this[nameof(PrimitiveName)] = value; } }
    }
    public class ShiftUICohtmlEventHelpers : Object
    {
        public ShiftUICohtmlEventHelpers(ulong addr) : base(addr) { }
    }
    public class ShiftUICohtmlGameHUD : HUD
    {
        public ShiftUICohtmlGameHUD(ulong addr) : base(addr) { }
        public ShiftUICohtmlHUD CohtmlHUD { get { return this[nameof(CohtmlHUD)].As<ShiftUICohtmlHUD>(); } set { this["CohtmlHUD"] = value; } }
        public ShiftUICohtmlHUD CohtmlHUDInternal { get { return this[nameof(CohtmlHUDInternal)].As<ShiftUICohtmlHUD>(); } set { this["CohtmlHUDInternal"] = value; } }
        public void SetupView(Object PageUrl, bool bEnableComplexCSSSupport, bool bDelayedUpdate, bool bUseWideColorTextures) { Invoke(nameof(SetupView), PageUrl, bEnableComplexCSSSupport, bDelayedUpdate, bUseWideColorTextures); }
    }
    public class ShiftUICohtmlHUD : ShiftUICohtmlBaseComponent
    {
        public ShiftUICohtmlHUD(ulong addr) : base(addr) { }
        public SoftObjectPath HUDMaterialName { get { return this[nameof(HUDMaterialName)].As<SoftObjectPath>(); } set { this["HUDMaterialName"] = value; } }
        public Material HUDMaterial { get { return this[nameof(HUDMaterial)].As<Material>(); } set { this["HUDMaterial"] = value; } }
        public MaterialInstanceDynamic HUDMaterialInstance { get { return this[nameof(HUDMaterialInstance)].As<MaterialInstanceDynamic>(); } set { this["HUDMaterialInstance"] = value; } }
    }
    public class ShiftUICohtmlInputActor : Actor
    {
        public ShiftUICohtmlInputActor(ulong addr) : base(addr) { }
        public Object OnCohtmlInputActorMouseButtonDown { get { return this[nameof(OnCohtmlInputActorMouseButtonDown)]; } set { this[nameof(OnCohtmlInputActorMouseButtonDown)] = value; } }
        public Object OnCohtmlInputActorMouseButtonUp { get { return this[nameof(OnCohtmlInputActorMouseButtonUp)]; } set { this[nameof(OnCohtmlInputActorMouseButtonUp)] = value; } }
        public Object OnCohtmlInputActorKeyDown { get { return this[nameof(OnCohtmlInputActorKeyDown)]; } set { this[nameof(OnCohtmlInputActorKeyDown)] = value; } }
        public Object OnCohtmlInputActorKeyUp { get { return this[nameof(OnCohtmlInputActorKeyUp)]; } set { this[nameof(OnCohtmlInputActorKeyUp)] = value; } }
        public void ToggleCohtmlInputFocus() { Invoke(nameof(ToggleCohtmlInputFocus)); }
        public void SetLineTraceMode(byte Mode) { Invoke(nameof(SetLineTraceMode), Mode); }
        public void SetInputPropagationBehaviour(byte Propagation) { Invoke(nameof(SetInputPropagationBehaviour), Propagation); }
        public void SetCohtmlViewFocus(ShiftUICohtmlBaseComponent NewFocusedView) { Invoke(nameof(SetCohtmlViewFocus), NewFocusedView); }
        public void SetCohtmlInputFocus(bool FocusUI) { Invoke(nameof(SetCohtmlInputFocus), FocusUI); }
        public bool IsCohtmlFocused() { return Invoke<bool>(nameof(IsCohtmlFocused)); }
        public void Initialize(byte CollisionChannel, byte AddressMode, byte RaycastQuality, int UVChannel) { Invoke(nameof(Initialize), CollisionChannel, AddressMode, RaycastQuality, UVChannel); }
        public byte GetInputPropagationBehaviour() { return Invoke<byte>(nameof(GetInputPropagationBehaviour)); }
        public void AlwaysAcceptMouseInput(bool bAccept) { Invoke(nameof(AlwaysAcceptMouseInput), bAccept); }
    }
    public class ShiftUICohtmlJSEvent : Object
    {
        public ShiftUICohtmlJSEvent(ulong addr) : base(addr) { }
        public Array<Struct> StructTypes { get { return new Array<Struct>(this[nameof(StructTypes)].Address); } }
        public void AddText(Object Text) { Invoke(nameof(AddText), Text); }
        public void AddStructArg(Object Arg) { Invoke(nameof(AddStructArg), Arg); }
        public void AddString(Object str) { Invoke(nameof(AddString), str); }
        public void AddObject(Object Object) { Invoke(nameof(AddObject), Object); }
        public void AddName(Object Name) { Invoke(nameof(AddName), Name); }
        public void AddInt32(int integer) { Invoke(nameof(AddInt32), integer); }
        public void AddFloat(float fl) { Invoke(nameof(AddFloat), fl); }
        public void AddByte(byte b) { Invoke(nameof(AddByte), b); }
        public void AddBool(bool B) { Invoke(nameof(AddBool), B); }
        public void AddArray(Array<int> Array) { Invoke(nameof(AddArray), Array); }
    }
    public class ShiftUICohtmlSettings : Object
    {
        public ShiftUICohtmlSettings(ulong addr) : base(addr) { }
        public bool EnableLiveReload { get { return this[nameof(EnableLiveReload)].Flag; } set { this[nameof(EnableLiveReload)].Flag = value; } }
        public int DevToolsPort { get { return this[nameof(DevToolsPort)].GetValue<int>(); } set { this[nameof(DevToolsPort)].SetValue<int>(value); } }
        public bool EnableLocalization { get { return this[nameof(EnableLocalization)].Flag; } set { this[nameof(EnableLocalization)].Flag = value; } }
        public bool EnableBreakIterator { get { return this[nameof(EnableBreakIterator)].Flag; } set { this[nameof(EnableBreakIterator)].Flag = value; } }
        public bool HandleInputOnHTMLBody { get { return this[nameof(HandleInputOnHTMLBody)].Flag; } set { this[nameof(HandleInputOnHTMLBody)].Flag = value; } }
        public Array<Object> InputTransparentCssClasses { get { return new Array<Object>(this[nameof(InputTransparentCssClasses)].Address); } }
        public Array<Object> InputTransparentCssClassesWithChildren { get { return new Array<Object>(this[nameof(InputTransparentCssClassesWithChildren)].Address); } }
        public float ScrollDelta { get { return this[nameof(ScrollDelta)].GetValue<float>(); } set { this[nameof(ScrollDelta)].SetValue<float>(value); } }
        public bool ShowWarningsOnScreen { get { return this[nameof(ShowWarningsOnScreen)].Flag; } set { this[nameof(ShowWarningsOnScreen)].Flag = value; } }
        public EShiftUICohtmlSettingsSeverity LogSeverity { get { return (EShiftUICohtmlSettingsSeverity)this[nameof(LogSeverity)].GetValue<int>(); } set { this[nameof(LogSeverity)].SetValue<int>((int)value); } }
        public bool bRespectTitleSafeZone { get { return this[nameof(bRespectTitleSafeZone)].Flag; } set { this[nameof(bRespectTitleSafeZone)].Flag = value; } }
        public bool bRespectLetterboxing { get { return this[nameof(bRespectLetterboxing)].Flag; } set { this[nameof(bRespectLetterboxing)].Flag = value; } }
        public bool TickWhileGameIsPaused { get { return this[nameof(TickWhileGameIsPaused)].Flag; } set { this[nameof(TickWhileGameIsPaused)].Flag = value; } }
        public bool bUseLowerCaseNamesForAutoExposedProperties { get { return this[nameof(bUseLowerCaseNamesForAutoExposedProperties)].Flag; } set { this[nameof(bUseLowerCaseNamesForAutoExposedProperties)].Flag = value; } }
        public EShiftUICohtmlMSAA MSAA { get { return (EShiftUICohtmlMSAA)this[nameof(MSAA)].GetValue<int>(); } set { this[nameof(MSAA)].SetValue<int>((int)value); } }
        public Array<ShiftUISingleFormatFallbacks> FallbacksForAllFormats { get { return new Array<ShiftUISingleFormatFallbacks>(this[nameof(FallbacksForAllFormats)].Address); } }
        public Object DefaultStyleFontFamily { get { return this[nameof(DefaultStyleFontFamily)]; } set { this[nameof(DefaultStyleFontFamily)] = value; } }
        public bool AsynchronousResourceRequestCalls { get { return this[nameof(AsynchronousResourceRequestCalls)].Flag; } set { this[nameof(AsynchronousResourceRequestCalls)].Flag = value; } }
        public bool bUseInputPreprocessor { get { return this[nameof(bUseInputPreprocessor)].Flag; } set { this[nameof(bUseInputPreprocessor)].Flag = value; } }
    }
    public class ShiftUICohtmlSystem : Actor
    {
        public ShiftUICohtmlSystem(ulong addr) : base(addr) { }
    }
    public class ShiftUICohtmlWidget : Widget
    {
        public ShiftUICohtmlWidget(ulong addr) : base(addr) { }
        public Actor Owner { get { return this[nameof(Owner)].As<Actor>(); } set { this["Owner"] = value; } }
        public Object ReadyForBindings { get { return this[nameof(ReadyForBindings)]; } set { this[nameof(ReadyForBindings)] = value; } }
        public Object BindingsReleased { get { return this[nameof(BindingsReleased)]; } set { this[nameof(BindingsReleased)] = value; } }
        public Object ScriptingReady { get { return this[nameof(ScriptingReady)]; } set { this[nameof(ScriptingReady)] = value; } }
        public bool bEnableComplexCSSSupport { get { return this[nameof(bEnableComplexCSSSupport)].Flag; } set { this[nameof(bEnableComplexCSSSupport)].Flag = value; } }
        public byte Filter { get { return this[nameof(Filter)].GetValue<byte>(); } set { this[nameof(Filter)].SetValue<byte>(value); } }
        public bool bReceiveInput { get { return this[nameof(bReceiveInput)].Flag; } set { this[nameof(bReceiveInput)].Flag = value; } }
        public byte InputPropagationBehaviour { get { return this[nameof(InputPropagationBehaviour)].GetValue<byte>(); } set { this[nameof(InputPropagationBehaviour)].SetValue<byte>(value); } }
        public bool bGammaCorrectedMaterial { get { return this[nameof(bGammaCorrectedMaterial)].Flag; } set { this[nameof(bGammaCorrectedMaterial)].Flag = value; } }
        public bool bUseWideColorTextures { get { return this[nameof(bUseWideColorTextures)].Flag; } set { this[nameof(bUseWideColorTextures)].Flag = value; } }
        public float TickPeriodInMinimizedGame { get { return this[nameof(TickPeriodInMinimizedGame)].GetValue<float>(); } set { this[nameof(TickPeriodInMinimizedGame)].SetValue<float>(value); } }
        public Array<Texture2D> PreloadedTextures { get { return new Array<Texture2D>(this[nameof(PreloadedTextures)].Address); } }
        public ShiftUICohtmlAudioWrapper AudioWrapper { get { return this[nameof(AudioWrapper)].As<ShiftUICohtmlAudioWrapper>(); } set { this["AudioWrapper"] = value; } }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
        public void UpdateWholeDataModelFromStruct(Object Struct) { Invoke(nameof(UpdateWholeDataModelFromStruct), Struct); }
        public void UpdateWholeDataModelFromObject(Object Model) { Invoke(nameof(UpdateWholeDataModelFromObject), Model); }
        public void TriggerJSEvent(Object Name, ShiftUICohtmlJSEvent EventData) { Invoke(nameof(TriggerJSEvent), Name, EventData); }
        public void SynchronizeModels() { Invoke(nameof(SynchronizeModels)); }
        public void ShowPaintRects(bool Show) { Invoke(nameof(ShowPaintRects), Show); }
        public void SetSoundAttenuation(SoundAttenuationSettings Settings) { Invoke(nameof(SetSoundAttenuation), Settings); }
        public void SetInputPropagationBehaviour(byte Propagation) { Invoke(nameof(SetInputPropagationBehaviour), Propagation); }
        public bool RemovePreloadedTextureFromPath(Object AssetPath) { return Invoke<bool>(nameof(RemovePreloadedTextureFromPath), AssetPath); }
        public bool RemovePreloadedTexture(Texture2D Texture) { return Invoke<bool>(nameof(RemovePreloadedTexture), Texture); }
        public void RemoveDataModelFromStruct(Object Struct) { Invoke(nameof(RemoveDataModelFromStruct), Struct); }
        public void RemoveDataModelFromObject(Object Model) { Invoke(nameof(RemoveDataModelFromObject), Model); }
        public void RemoveAllPreloadedTextures() { Invoke(nameof(RemoveAllPreloadedTextures)); }
        public void Reload() { Invoke(nameof(Reload)); }
        public void PreloadTextureSync(Object AssetPath) { Invoke(nameof(PreloadTextureSync), AssetPath); }
        public void PreloadTextureAsync(Object AssetPath) { Invoke(nameof(PreloadTextureAsync), AssetPath); }
        public void Load(Object Path) { Invoke(nameof(Load), Path); }
        public bool IsReadyToCreateView() { return Invoke<bool>(nameof(IsReadyToCreateView)); }
        public bool IsReadyForBindings() { return Invoke<bool>(nameof(IsReadyForBindings)); }
        public bool HasRequestedView() { return Invoke<bool>(nameof(HasRequestedView)); }
        public TextureRenderTarget2D GetRenderTexture() { return Invoke<TextureRenderTarget2D>(nameof(GetRenderTexture)); }
        public byte GetInputPropagationBehaviour() { return Invoke<byte>(nameof(GetInputPropagationBehaviour)); }
        public ShiftUICohtmlJSEvent CreateJSEvent() { return Invoke<ShiftUICohtmlJSEvent>(nameof(CreateJSEvent)); }
        public void CreateDataModelFromStruct(Object Name, Object Struct) { Invoke(nameof(CreateDataModelFromStruct), Name, Struct); }
        public void CreateDataModelFromObject(Object Name, Object Model) { Invoke(nameof(CreateDataModelFromObject), Name, Model); }
        public void AddPreloadedTexture(Texture2D Texture) { Invoke(nameof(AddPreloadedTexture), Texture); }
    }
    public class ShiftUIFunctionLibrary : BlueprintFunctionLibrary
    {
        public ShiftUIFunctionLibrary(ulong addr) : base(addr) { }
        public void Unblock(Object Reason) { Invoke(nameof(Unblock), Reason); }
        public void SetBlockingEnabled(bool Enabled) { Invoke(nameof(SetBlockingEnabled), Enabled); }
        public void RemoveShowDelegate(Object Delegate) { Invoke(nameof(RemoveShowDelegate), Delegate); }
        public void RemoveHideDelegate(Object Delegate) { Invoke(nameof(RemoveHideDelegate), Delegate); }
        public void Open() { Invoke(nameof(Open)); }
        public bool IsVisible() { return Invoke<bool>(nameof(IsVisible)); }
        public bool IsInitialized() { return Invoke<bool>(nameof(IsInitialized)); }
        public bool IsBlockingEnabled() { return Invoke<bool>(nameof(IsBlockingEnabled)); }
        public void Close() { Invoke(nameof(Close)); }
        public void Block(Object Reason) { Invoke(nameof(Block), Reason); }
        public void AddShowDelegate(Object Delegate) { Invoke(nameof(AddShowDelegate), Delegate); }
        public void AddHideDelegate(Object Delegate) { Invoke(nameof(AddHideDelegate), Delegate); }
    }
    public class ShiftUIHummingbirdBaseComponent : ShiftUICohtmlBaseComponent
    {
        public ShiftUIHummingbirdBaseComponent(ulong addr) : base(addr) { }
    }
    public class ShiftUIHummingbirdComponent : ShiftUICohtmlComponent
    {
        public ShiftUIHummingbirdComponent(ulong addr) : base(addr) { }
    }
    public class ShiftUIHummingbirdGameHUD : ShiftUICohtmlGameHUD
    {
        public ShiftUIHummingbirdGameHUD(ulong addr) : base(addr) { }
    }
    public class ShiftUIHummingbirdHUD : ShiftUICohtmlHUD
    {
        public ShiftUIHummingbirdHUD(ulong addr) : base(addr) { }
    }
    public class ShiftUIHummingbirdInputActor : ShiftUICohtmlInputActor
    {
        public ShiftUIHummingbirdInputActor(ulong addr) : base(addr) { }
    }
    public class ShiftUIHummingbirdSystem : ShiftUICohtmlSystem
    {
        public ShiftUIHummingbirdSystem(ulong addr) : base(addr) { }
    }
    public class ShiftUISettings : Object
    {
        public ShiftUISettings(ulong addr) : base(addr) { }
        public int ZOrder { get { return this[nameof(ZOrder)].GetValue<int>(); } set { this[nameof(ZOrder)].SetValue<int>(value); } }
        public int VirtualResX { get { return this[nameof(VirtualResX)].GetValue<int>(); } set { this[nameof(VirtualResX)].SetValue<int>(value); } }
        public int VirtualResY { get { return this[nameof(VirtualResY)].GetValue<int>(); } set { this[nameof(VirtualResY)].SetValue<int>(value); } }
        public float InputModeThreshold_Cursor { get { return this[nameof(InputModeThreshold_Cursor)].GetValue<float>(); } set { this[nameof(InputModeThreshold_Cursor)].SetValue<float>(value); } }
        public float InputModeThreshold_Analog { get { return this[nameof(InputModeThreshold_Analog)].GetValue<float>(); } set { this[nameof(InputModeThreshold_Analog)].SetValue<float>(value); } }
        public bool bAutoBlockOnMapLoad { get { return this[nameof(bAutoBlockOnMapLoad)].Flag; } set { this[nameof(bAutoBlockOnMapLoad)].Flag = value; } }
        public bool bAutoBlockOnMovie { get { return this[nameof(bAutoBlockOnMovie)].Flag; } set { this[nameof(bAutoBlockOnMovie)].Flag = value; } }
        public bool bAutoBlockOnCinematic { get { return this[nameof(bAutoBlockOnCinematic)].Flag; } set { this[nameof(bAutoBlockOnCinematic)].Flag = value; } }
        public bool bAutoBlockOnAppFocus { get { return this[nameof(bAutoBlockOnAppFocus)].Flag; } set { this[nameof(bAutoBlockOnAppFocus)].Flag = value; } }
    }
    public enum EShiftUICohtmlKeys : int
    {
        LeftMouseButton = 0,
        RightMouseButton = 1,
        MiddleMouseButton = 2,
        ThumbMouseButton = 3,
        ThumbMouseButton2 = 4,
        BackSpace = 5,
        Tab = 6,
        Enter = 7,
        Pause = 8,
        CapsLock = 9,
        Escape = 10,
        SpaceBar = 11,
        PageUp = 12,
        PageDown = 13,
        End = 14,
        Home = 15,
        Left = 16,
        Up = 17,
        Right = 18,
        Down = 19,
        Insert = 20,
        Delete = 21,
        Zero = 22,
        One = 23,
        Two = 24,
        Three = 25,
        Four = 26,
        Five = 27,
        Six = 28,
        Seven = 29,
        Eight = 30,
        Nine = 31,
        A = 32,
        B = 33,
        C = 34,
        D = 35,
        E = 36,
        F = 37,
        G = 38,
        H = 39,
        I = 40,
        J = 41,
        K = 42,
        L = 43,
        M = 44,
        N = 45,
        O = 46,
        P = 47,
        Q = 48,
        R = 49,
        S = 50,
        T = 51,
        U = 52,
        V = 53,
        W = 54,
        X = 55,
        Y = 56,
        Z = 57,
        NumPadZero = 58,
        NumPadOne = 59,
        NumPadTwo = 60,
        NumPadThree = 61,
        NumPadFour = 62,
        NumPadFive = 63,
        NumPadSix = 64,
        NumPadSeven = 65,
        NumPadEight = 66,
        NumPadNine = 67,
        Multiply = 68,
        Add = 69,
        Subtract = 70,
        Decimal = 71,
        Divide = 72,
        F1 = 73,
        F2 = 74,
        F3 = 75,
        F4 = 76,
        F5 = 77,
        F6 = 78,
        F7 = 79,
        F8 = 80,
        F9 = 81,
        F10 = 82,
        F11 = 83,
        F12 = 84,
        NumLock = 85,
        ScrollLock = 86,
        LeftShift = 87,
        RightShift = 88,
        LeftControl = 89,
        RightControl = 90,
        LeftAlt = 91,
        RightAlt = 92,
        LeftCommand = 93,
        RightCommand = 94,
        Semicolon = 95,
        Equals = 96,
        Comma = 97,
        Underscore = 98,
        Period = 99,
        Slash = 100,
        Tilde = 101,
        LeftBracket = 102,
        Backslash = 103,
        RightBracket = 104,
        Quote = 105,
        Unknown = 106,
        EShiftUICohtmlKeys_MAX = 107,
    }
    public enum EShiftUICoherentRenderingSettingsSeverity : int
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        AssertFailure = 4,
        Error = 5,
        EShiftUICoherentRenderingSettingsSeverity_MAX = 6,
    }
    public enum EShiftUICohtmlInputWidgetRaycastQuality : int
    {
        ShiftUICohtmlRaycastQuality_Fast = 0,
        ShiftUICohtmlRaycastQuality_Balanced = 1,
        ShiftUICohtmlRaycastQuality_Accurate = 2,
        ShiftUICohtmlRaycastQuality_MAX = 3,
    }
    public enum EShiftUICohtmlInputWidgetLineTraceMode : int
    {
        ShiftUICohtmlInputLineTrace_Single = 0,
        ShiftUICohtmlInputLineTrace_Multi = 1,
        ShiftUICohtmlInputLineTrace_MAX = 2,
    }
    public enum EShiftUICohtmlImageFormat : int
    {
        PNG = 0,
        TGA = 1,
        JPEG = 2,
        PSD = 3,
        SVG = 4,
        DDS = 5,
        BMP = 6,
        ASTC = 7,
        PKM = 8,
        KTX = 9,
        EShiftUICohtmlImageFormat_MAX = 10,
    }
    public enum EShiftUICohtmlMSAA : int
    {
        MSAA_1x = 0,
        MSAA_2x = 1,
        MSAA_4x = 2,
        MSAA_MAX = 3,
    }
    public enum EShiftUICohtmlSettingsSeverity : int
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        AssertFailure = 4,
        Error = 5,
        EShiftUICohtmlSettingsSeverity_MAX = 6,
    }
    public enum EShiftUICohtmlInputPropagationBehaviour : int
    {
        None = 0,
        Keyboard = 1,
        Joystick = 2,
        KeyboardAndJoystick = 3,
        EShiftUICohtmlInputPropagationBehaviour_MAX = 4,
    }
    public enum EShiftUICohtmlGamepadBehaviourOnFocusLost : int
    {
        ShiftUICohtmlResetState = 0,
        ShiftUICohtmlUseCurrentState = 1,
        ShiftUICohtmlUseStateBeforeReset = 2,
        EShiftUICohtmlGamepadBehaviourOnFocusLost_MAX = 3,
    }
    public class ShiftUITextureAtlasMetaData : Object
    {
        public ShiftUITextureAtlasMetaData(ulong addr) : base(addr) { }
        public Object AtlasContainedTextures { get { return this[nameof(AtlasContainedTextures)]; } set { this[nameof(AtlasContainedTextures)] = value; } }
        public Object AtlasDetails { get { return this[nameof(AtlasDetails)]; } set { this[nameof(AtlasDetails)] = value; } }
    }
    public class ShiftUITextureAtlasMappingInfo : Object
    {
        public ShiftUITextureAtlasMappingInfo(ulong addr) : base(addr) { }
        public Object AtlasPath { get { return this[nameof(AtlasPath)]; } set { this[nameof(AtlasPath)] = value; } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public int ContentRectWidth { get { return this[nameof(ContentRectWidth)].GetValue<int>(); } set { this[nameof(ContentRectWidth)].SetValue<int>(value); } }
        public int ContentRectHeight { get { return this[nameof(ContentRectHeight)].GetValue<int>(); } set { this[nameof(ContentRectHeight)].SetValue<int>(value); } }
        public int OriginX { get { return this[nameof(OriginX)].GetValue<int>(); } set { this[nameof(OriginX)].SetValue<int>(value); } }
        public int OriginY { get { return this[nameof(OriginY)].GetValue<int>(); } set { this[nameof(OriginY)].SetValue<int>(value); } }
    }
    public class ShiftUICohtmlSound : Object
    {
        public ShiftUICohtmlSound(ulong addr) : base(addr) { }
        public AudioComponent Component { get { return this[nameof(Component)].As<AudioComponent>(); } set { this["Component"] = value; } }
        public SoundWaveProcedural Stream { get { return this[nameof(Stream)].As<SoundWaveProcedural>(); } set { this["Stream"] = value; } }
    }
    public class ShiftUISingleFormatFallbacks : Object
    {
        public ShiftUISingleFormatFallbacks(ulong addr) : base(addr) { }
        public EShiftUICohtmlImageFormat BaseFormat { get { return (EShiftUICohtmlImageFormat)this[nameof(BaseFormat)].GetValue<int>(); } set { this[nameof(BaseFormat)].SetValue<int>((int)value); } }
        public Array<EShiftUICohtmlImageFormat> PossibleFallbacks { get { return new Array<EShiftUICohtmlImageFormat>(this[nameof(PossibleFallbacks)].Address); } }
    }
    public class ShiftUICohtmlViewSettings : Object
    {
        public ShiftUICohtmlViewSettings(ulong addr) : base(addr) { }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public bool IsTransparent { get { return this[nameof(IsTransparent)].Flag; } set { this[nameof(IsTransparent)].Flag = value; } }
        public float AnimationFrameDefer { get { return this[nameof(AnimationFrameDefer)].GetValue<float>(); } set { this[nameof(AnimationFrameDefer)].SetValue<float>(value); } }
    }
}
