using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.NiagaraShaderSDK
{
    public class NiagaraScriptBase : Object
    {
        public NiagaraScriptBase(ulong addr) : base(addr) { }
    }
    public enum FNiagaraCompileEventSeverity : int
    {
        Log = 0,
        Warning = 1,
        Error = 2,
        FNiagaraCompileEventSeverity_MAX = 3,
    }
    public class SimulationStageMetaData : Object
    {
        public SimulationStageMetaData(ulong addr) : base(addr) { }
        public Object SimulationStageName { get { return this[nameof(SimulationStageName)]; } set { this[nameof(SimulationStageName)] = value; } }
        public Object IterationSource { get { return this[nameof(IterationSource)]; } set { this[nameof(IterationSource)] = value; } }
        public bool bSpawnOnly { get { return this[nameof(bSpawnOnly)].Flag; } set { this[nameof(bSpawnOnly)].Flag = value; } }
        public bool bWritesParticles { get { return this[nameof(bWritesParticles)].Flag; } set { this[nameof(bWritesParticles)].Flag = value; } }
        public bool bPartialParticleUpdate { get { return this[nameof(bPartialParticleUpdate)].Flag; } set { this[nameof(bPartialParticleUpdate)].Flag = value; } }
        public Array<Object> OutputDestinations { get { return new Array<Object>(this[nameof(OutputDestinations)].Address); } }
        public int MinStage { get { return this[nameof(MinStage)].GetValue<int>(); } set { this[nameof(MinStage)].SetValue<int>(value); } }
        public int MaxStage { get { return this[nameof(MaxStage)].GetValue<int>(); } set { this[nameof(MaxStage)].SetValue<int>(value); } }
    }
    public class NiagaraDataInterfaceGPUParamInfo : Object
    {
        public NiagaraDataInterfaceGPUParamInfo(ulong addr) : base(addr) { }
        public Object DataInterfaceHLSLSymbol { get { return this[nameof(DataInterfaceHLSLSymbol)]; } set { this[nameof(DataInterfaceHLSLSymbol)] = value; } }
        public Object DIClassName { get { return this[nameof(DIClassName)]; } set { this[nameof(DIClassName)] = value; } }
        public Array<NiagaraDataInterfaceGeneratedFunction> GeneratedFunctions { get { return new Array<NiagaraDataInterfaceGeneratedFunction>(this[nameof(GeneratedFunctions)].Address); } }
    }
    public class NiagaraDataInterfaceGeneratedFunction : Object
    {
        public NiagaraDataInterfaceGeneratedFunction(ulong addr) : base(addr) { }
    }
    public class NiagaraCompileEvent : Object
    {
        public NiagaraCompileEvent(ulong addr) : base(addr) { }
        public FNiagaraCompileEventSeverity Severity { get { return (FNiagaraCompileEventSeverity)this[nameof(Severity)].GetValue<int>(); } set { this[nameof(Severity)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
        public Guid NodeGuid { get { return this[nameof(NodeGuid)].As<Guid>(); } set { this["NodeGuid"] = value; } }
        public Guid PinGuid { get { return this[nameof(PinGuid)].As<Guid>(); } set { this["PinGuid"] = value; } }
        public Array<Guid> StackGuids { get { return new Array<Guid>(this[nameof(StackGuids)].Address); } }
    }
}
