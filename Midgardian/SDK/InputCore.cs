using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.InputCoreSDK
{
    public class InputCoreTypes : Object
    {
        public InputCoreTypes(ulong addr) : base(addr) { }
    }
    public class Key : Object
    {
        public Key(ulong addr) : base(addr) { }
        public Object KeyName { get { return this[nameof(KeyName)]; } set { this[nameof(KeyName)] = value; } }
    }
    public enum ETouchIndex : int
    {
        Touch1 = 0,
        Touch2 = 1,
        Touch3 = 2,
        Touch4 = 3,
        Touch5 = 4,
        Touch6 = 5,
        Touch7 = 6,
        Touch8 = 7,
        Touch9 = 8,
        Touch10 = 9,
        CursorPointerIndex = 10,
        MAX_TOUCHES = 11,
        ETouchIndex_MAX = 12,
    }
    public enum ETouchType : int
    {
        Began = 0,
        Moved = 1,
        Stationary = 2,
        ForceChanged = 3,
        FirstMove = 4,
        Ended = 5,
        NumTypes = 6,
        ETouchType_MAX = 7,
    }
    public enum EConsoleForGamepadLabels : int
    {
        None = 0,
        XBoxOne = 1,
        PS4 = 2,
        EConsoleForGamepadLabels_MAX = 3,
    }
    public enum EControllerHand : int
    {
        Left = 0,
        Right = 1,
        AnyHand = 2,
        Pad = 3,
        ExternalCamera = 4,
        Gun = 5,
        Special_2 = 6,
        Special_3 = 7,
        Special_4 = 8,
        Special_5 = 9,
        Special_6 = 10,
        Special_7 = 11,
        Special_8 = 12,
        Special_9 = 13,
        Special_10 = 14,
        Special_11 = 15,
        Special_12 = 16,
        ControllerHand_Count = 17,
        EControllerHand_MAX = 18,
    }
}
