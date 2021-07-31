using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.NiagaraCoreSDK
{
    public class NiagaraMergeable : Object
    {
        public NiagaraMergeable(ulong addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceBase : NiagaraMergeable
    {
        public NiagaraDataInterfaceBase(ulong addr) : base(addr) { }
    }
    public class NiagaraCompileHash : Object
    {
        public NiagaraCompileHash(ulong addr) : base(addr) { }
        public Array<byte> DataHash { get { return new Array<byte>(this[nameof(DataHash)].Address); } }
    }
}
