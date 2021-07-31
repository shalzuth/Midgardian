using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.ActorLayerUtilitiesSDK
{
    public class LayersBlueprintLibrary : BlueprintFunctionLibrary
    {
        public LayersBlueprintLibrary(ulong addr) : base(addr) { }
        public void RemoveActorFromLayer(Actor InActor, ActorLayer Layer) { Invoke(nameof(RemoveActorFromLayer), InActor, Layer); }
        public Array<Actor> GetActors(Object WorldContextObject, ActorLayer ActorLayer) { return Invoke<Array<Actor>>(nameof(GetActors), WorldContextObject, ActorLayer); }
        public void AddActorToLayer(Actor InActor, ActorLayer Layer) { Invoke(nameof(AddActorToLayer), InActor, Layer); }
    }
    public class ActorLayer : Object
    {
        public ActorLayer(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
    }
}
