using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ClothingSystemRuntimeInterfaceSDK
{
    public class ClothConfigBase : Object
    {
        public ClothConfigBase(ulong addr) : base(addr) { }
    }
    public class ClothingSimulationFactory : Object
    {
        public ClothingSimulationFactory(ulong addr) : base(addr) { }
    }
    public class ClothingSimulationInteractor : Object
    {
        public ClothingSimulationInteractor(ulong addr) : base(addr) { }
        public void SetAnimDriveSpringStiffness(float InStiffness) { Invoke(nameof(SetAnimDriveSpringStiffness), InStiffness); }
        public void PhysicsAssetUpdated() { Invoke(nameof(PhysicsAssetUpdated)); }
        public float GetSimulationTime() { return Invoke<float>(nameof(GetSimulationTime)); }
        public int GetNumSubsteps() { return Invoke<int>(nameof(GetNumSubsteps)); }
        public int GetNumKinematicParticles() { return Invoke<int>(nameof(GetNumKinematicParticles)); }
        public int GetNumIterations() { return Invoke<int>(nameof(GetNumIterations)); }
        public int GetNumDynamicParticles() { return Invoke<int>(nameof(GetNumDynamicParticles)); }
        public int GetNumCloths() { return Invoke<int>(nameof(GetNumCloths)); }
        public void EnableGravityOverride(Vector InVector) { Invoke(nameof(EnableGravityOverride), InVector); }
        public void DisableGravityOverride() { Invoke(nameof(DisableGravityOverride)); }
        public void ClothConfigUpdated() { Invoke(nameof(ClothConfigUpdated)); }
    }
    public class ClothSharedSimConfigBase : Object
    {
        public ClothSharedSimConfigBase(ulong addr) : base(addr) { }
    }
    public class ClothingAssetBase : Object
    {
        public ClothingAssetBase(ulong addr) : base(addr) { }
        public Object ImportedFilePath { get { return this[nameof(ImportedFilePath)]; } set { this[nameof(ImportedFilePath)] = value; } }
        public Guid AssetGuid { get { return this[nameof(AssetGuid)].As<Guid>(); } set { this["AssetGuid"] = value; } }
    }
    public class ClothPhysicalMeshDataBase_Legacy : Object
    {
        public ClothPhysicalMeshDataBase_Legacy(ulong addr) : base(addr) { }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<Vector> Normals { get { return new Array<Vector>(this[nameof(Normals)].Address); } }
        public Array<uint> Indices { get { return new Array<uint>(this[nameof(Indices)].Address); } }
        public Array<float> InverseMasses { get { return new Array<float>(this[nameof(InverseMasses)].Address); } }
        public Array<ClothVertBoneData> BoneData { get { return new Array<ClothVertBoneData>(this[nameof(BoneData)].Address); } }
        public int NumFixedVerts { get { return this[nameof(NumFixedVerts)].GetValue<int>(); } set { this[nameof(NumFixedVerts)].SetValue<int>(value); } }
        public int MaxBoneWeights { get { return this[nameof(MaxBoneWeights)].GetValue<int>(); } set { this[nameof(MaxBoneWeights)].SetValue<int>(value); } }
        public Array<uint> SelfCollisionIndices { get { return new Array<uint>(this[nameof(SelfCollisionIndices)].Address); } }
    }
    public class ClothCollisionData : Object
    {
        public ClothCollisionData(ulong addr) : base(addr) { }
        public Array<ClothCollisionPrim_Sphere> Spheres { get { return new Array<ClothCollisionPrim_Sphere>(this[nameof(Spheres)].Address); } }
        public Array<ClothCollisionPrim_SphereConnection> SphereConnections { get { return new Array<ClothCollisionPrim_SphereConnection>(this[nameof(SphereConnections)].Address); } }
        public Array<ClothCollisionPrim_Convex> Convexes { get { return new Array<ClothCollisionPrim_Convex>(this[nameof(Convexes)].Address); } }
        public Array<ClothCollisionPrim_Box> Boxes { get { return new Array<ClothCollisionPrim_Box>(this[nameof(Boxes)].Address); } }
    }
    public class ClothCollisionPrim_Box : Object
    {
        public ClothCollisionPrim_Box(ulong addr) : base(addr) { }
        public Vector LocalPosition { get { return this[nameof(LocalPosition)].As<Vector>(); } set { this["LocalPosition"] = value; } }
        public Quat LocalRotation { get { return this[nameof(LocalRotation)].As<Quat>(); } set { this["LocalRotation"] = value; } }
        public Vector HalfExtents { get { return this[nameof(HalfExtents)].As<Vector>(); } set { this["HalfExtents"] = value; } }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
    }
    public class ClothCollisionPrim_Convex : Object
    {
        public ClothCollisionPrim_Convex(ulong addr) : base(addr) { }
        public Array<Plane> Planes { get { return new Array<Plane>(this[nameof(Planes)].Address); } }
        public Array<Vector> SurfacePoints { get { return new Array<Vector>(this[nameof(SurfacePoints)].Address); } }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
    }
    public class ClothCollisionPrim_SphereConnection : Object
    {
        public ClothCollisionPrim_SphereConnection(ulong addr) : base(addr) { }
        public int SphereIndices { get { return this[nameof(SphereIndices)].GetValue<int>(); } set { this[nameof(SphereIndices)].SetValue<int>(value); } }
    }
    public class ClothCollisionPrim_Sphere : Object
    {
        public ClothCollisionPrim_Sphere(ulong addr) : base(addr) { }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Vector LocalPosition { get { return this[nameof(LocalPosition)].As<Vector>(); } set { this["LocalPosition"] = value; } }
    }
    public class ClothVertBoneData : Object
    {
        public ClothVertBoneData(ulong addr) : base(addr) { }
        public int NumInfluences { get { return this[nameof(NumInfluences)].GetValue<int>(); } set { this[nameof(NumInfluences)].SetValue<int>(value); } }
        public ushort BoneIndices { get { return this[nameof(BoneIndices)].GetValue<ushort>(); } set { this[nameof(BoneIndices)].SetValue<ushort>(value); } }
        public float BoneWeights { get { return this[nameof(BoneWeights)].GetValue<float>(); } set { this[nameof(BoneWeights)].SetValue<float>(value); } }
    }
}
