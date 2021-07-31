using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ActorSequenceSDK
{
    public class ActorSequence : MovieSceneSequence
    {
        public ActorSequence(ulong addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public ActorSequenceObjectReferenceMap ObjectReferences { get { return this[nameof(ObjectReferences)].As<ActorSequenceObjectReferenceMap>(); } set { this["ObjectReferences"] = value; } }
    }
    public class ActorSequenceComponent : ActorComponent
    {
        public ActorSequenceComponent(ulong addr) : base(addr) { }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public ActorSequence Sequence { get { return this[nameof(Sequence)].As<ActorSequence>(); } set { this["Sequence"] = value; } }
        public ActorSequencePlayer SequencePlayer { get { return this[nameof(SequencePlayer)].As<ActorSequencePlayer>(); } set { this["SequencePlayer"] = value; } }
    }
    public class ActorSequencePlayer : MovieSceneSequencePlayer
    {
        public ActorSequencePlayer(ulong addr) : base(addr) { }
    }
    public enum EActorSequenceObjectReferenceType : int
    {
        ContextActor = 0,
        ExternalActor = 1,
        Component = 2,
        EActorSequenceObjectReferenceType_MAX = 3,
    }
    public class ActorSequenceObjectReferenceMap : Object
    {
        public ActorSequenceObjectReferenceMap(ulong addr) : base(addr) { }
        public Array<Guid> BindingIds { get { return new Array<Guid>(this[nameof(BindingIds)].Address); } }
        public Array<ActorSequenceObjectReferences> References { get { return new Array<ActorSequenceObjectReferences>(this[nameof(References)].Address); } }
    }
    public class ActorSequenceObjectReferences : Object
    {
        public ActorSequenceObjectReferences(ulong addr) : base(addr) { }
        public Array<ActorSequenceObjectReference> Array { get { return new Array<ActorSequenceObjectReference>(this[nameof(Array)].Address); } }
    }
    public class ActorSequenceObjectReference : Object
    {
        public ActorSequenceObjectReference(ulong addr) : base(addr) { }
        public EActorSequenceObjectReferenceType Type { get { return (EActorSequenceObjectReferenceType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Guid ActorId { get { return this[nameof(ActorId)].As<Guid>(); } set { this["ActorId"] = value; } }
        public Object PathToComponent { get { return this[nameof(PathToComponent)]; } set { this[nameof(PathToComponent)] = value; } }
    }
}
