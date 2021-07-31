using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.VivoxCoreSDK
{
    public enum DeviceType : int
    {
        NullDevice = 0,
        SpecificDevice = 1,
        DefaultSystemDevice = 2,
        DefaultCommunicationDevice = 3,
        DeviceType_MAX = 4,
    }
    public enum EAudioFadeModel : int
    {
        InverseByDistance = 0,
        LinearByDistance = 1,
        ExponentialByDistance = 2,
        EAudioFadeModel_MAX = 3,
    }
    public enum ChannelType : int
    {
        NonPositional = 0,
        Positional = 1,
        Echo = 2,
        ChannelType_MAX = 3,
    }
    public enum ConnectionState : int
    {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2,
        Disconnecting = 3,
        ConnectionState_MAX = 4,
    }
    public enum ParticipantSpeakingUpdateRate : int
    {
        StateChange = 0,
        Never = 1,
        Update1Hz = 2,
        Update5Hz = 3,
        Update10Hz = 4,
        ParticipantSpeakingUpdateRate_MAX = 5,
    }
    public enum TransmissionMode : int
    {
        None = 0,
        Single = 1,
        All = 2,
        TransmissionMode_MAX = 3,
    }
    public enum SubscriptionReply : int
    {
        Allow = 0,
        Block = 1,
        SubscriptionReply_MAX = 2,
    }
    public enum SubscriptionMode : int
    {
        Accept = 0,
        Block = 1,
        Defer = 2,
        SubscriptionMode_MAX = 3,
    }
    public enum LoginState : int
    {
        LoggedOut = 0,
        LoggingIn = 1,
        LoggedIn = 2,
        LoggingOut = 3,
        LoginState_MAX = 4,
    }
    public enum TTSMessageState : int
    {
        Playing = 0,
        Enqueued = 1,
        TTSMessageState_MAX = 2,
    }
    public enum TTSDestination : int
    {
        Default = 0,
        RemoteTransmission = 0,
        LocalPlayback = 1,
        RemoteTransmissionWithLocalPlayback = 2,
        QueuedRemoteTransmission = 3,
        QueuedLocalPlayback = 4,
        QueuedRemoteTransmissionWithLocalPlayback = 5,
        ScreenReader = 6,
        TTSDestination_MAX = 7,
    }
    public enum PresenceStatus : int
    {
        Unavailable = 0,
        Available = 1,
        Chat = 2,
        DoNotDisturb = 3,
        Away = 4,
        ExtendedAway = 5,
        PresenceStatus_MAX = 6,
    }
}
