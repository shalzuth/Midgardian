using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.NiagaraSDK;
namespace SDK.Script.HoudiniNiagaraSDK
{
    public class HoudiniPointCache : Object
    {
        public HoudiniPointCache(ulong addr) : base(addr) { }
        public Object Filename { get { return this[nameof(Filename)]; } set { this[nameof(Filename)] = value; } }
        public int NumberOfSamples { get { return this[nameof(NumberOfSamples)].GetValue<int>(); } set { this[nameof(NumberOfSamples)].SetValue<int>(value); } }
        public int NumberOfAttributes { get { return this[nameof(NumberOfAttributes)].GetValue<int>(); } set { this[nameof(NumberOfAttributes)].SetValue<int>(value); } }
        public int NumberOfPoints { get { return this[nameof(NumberOfPoints)].GetValue<int>(); } set { this[nameof(NumberOfPoints)].SetValue<int>(value); } }
        public int NumberOfFrames { get { return this[nameof(NumberOfFrames)].GetValue<int>(); } set { this[nameof(NumberOfFrames)].SetValue<int>(value); } }
        public float FirstFrame { get { return this[nameof(FirstFrame)].GetValue<float>(); } set { this[nameof(FirstFrame)].SetValue<float>(value); } }
        public float LastFrame { get { return this[nameof(LastFrame)].GetValue<float>(); } set { this[nameof(LastFrame)].SetValue<float>(value); } }
        public float MinSampleTime { get { return this[nameof(MinSampleTime)].GetValue<float>(); } set { this[nameof(MinSampleTime)].SetValue<float>(value); } }
        public float MaxSampleTime { get { return this[nameof(MaxSampleTime)].GetValue<float>(); } set { this[nameof(MaxSampleTime)].SetValue<float>(value); } }
        public Object SourceCSVTitleRow { get { return this[nameof(SourceCSVTitleRow)]; } set { this[nameof(SourceCSVTitleRow)] = value; } }
        public Array<Object> AttributeArray { get { return new Array<Object>(this[nameof(AttributeArray)].Address); } }
        public Array<float> FloatSampleData { get { return new Array<float>(this[nameof(FloatSampleData)].Address); } }
        public Array<float> SpawnTimes { get { return new Array<float>(this[nameof(SpawnTimes)].Address); } }
        public Array<float> LifeValues { get { return new Array<float>(this[nameof(LifeValues)].Address); } }
        public Array<int> PointTypes { get { return new Array<int>(this[nameof(PointTypes)].Address); } }
        public Array<int> SpecialAttributeIndexes { get { return new Array<int>(this[nameof(SpecialAttributeIndexes)].Address); } }
        public Array<PointIndexes> PointValueIndexes { get { return new Array<PointIndexes>(this[nameof(PointValueIndexes)].Address); } }
        public bool UseCustomCSVTitleRow { get { return this[nameof(UseCustomCSVTitleRow)].Flag; } set { this[nameof(UseCustomCSVTitleRow)].Flag = value; } }
        public EHoudiniPointCacheFileType FileType { get { return (EHoudiniPointCacheFileType)this[nameof(FileType)].GetValue<int>(); } set { this[nameof(FileType)].SetValue<int>((int)value); } }
        public void SetUseCustomCSVTitleRow(bool bInUseCustomCSVTitleRow) { Invoke(nameof(SetUseCustomCSVTitleRow), bInUseCustomCSVTitleRow); }
        public bool GetVelocityValue(int SampleIndex, Vector Value) { return Invoke<bool>(nameof(GetVelocityValue), SampleIndex, Value); }
        public bool GetVectorValueForString(int SampleIndex, Object Attribute, Vector Value, bool DoSwap, bool DoScale) { return Invoke<bool>(nameof(GetVectorValueForString), SampleIndex, Attribute, Value, DoSwap, DoScale); }
        public bool GetVectorValue(int SampleIndex, int attrIndex, Vector Value, bool DoSwap, bool DoScale) { return Invoke<bool>(nameof(GetVectorValue), SampleIndex, attrIndex, Value, DoSwap, DoScale); }
        public bool GetVector4ValueForString(int SampleIndex, Object Attribute, Vector4 Value) { return Invoke<bool>(nameof(GetVector4ValueForString), SampleIndex, Attribute, Value); }
        public bool GetVector4Value(int SampleIndex, int attrIndex, Vector4 Value) { return Invoke<bool>(nameof(GetVector4Value), SampleIndex, attrIndex, Value); }
        public bool GetUseCustomCSVTitleRow() { return Invoke<bool>(nameof(GetUseCustomCSVTitleRow)); }
        public bool GetTimeValue(int SampleIndex, float Value) { return Invoke<bool>(nameof(GetTimeValue), SampleIndex, Value); }
        public Array<int> GetSpecialAttributeIndexes() { return Invoke<Array<int>>(nameof(GetSpecialAttributeIndexes)); }
        public Array<float> GetSpawnTimes() { return Invoke<Array<float>>(nameof(GetSpawnTimes)); }
        public bool GetSampleIndexesForPointAtTime(int POINTID, float desiredTime, int PrevSampleIndex, int NextSampleIndex, float PrevWeight) { return Invoke<bool>(nameof(GetSampleIndexesForPointAtTime), POINTID, desiredTime, PrevSampleIndex, NextSampleIndex, PrevWeight); }
        public bool GetQuatValueForString(int SampleIndex, Object Attribute, Quat Value, bool DoHoudiniToUnrealConversion) { return Invoke<bool>(nameof(GetQuatValueForString), SampleIndex, Attribute, Value, DoHoudiniToUnrealConversion); }
        public bool GetQuatValue(int SampleIndex, int attrIndex, Quat Value, bool DoHoudiniToUnrealConversion) { return Invoke<bool>(nameof(GetQuatValue), SampleIndex, attrIndex, Value, DoHoudiniToUnrealConversion); }
        public bool GetPositionValue(int SampleIndex, Vector Value) { return Invoke<bool>(nameof(GetPositionValue), SampleIndex, Value); }
        public bool GetPointVectorValueAtTimeForString(int POINTID, Object Attribute, float desiredTime, Vector Vector, bool DoSwap, bool DoScale) { return Invoke<bool>(nameof(GetPointVectorValueAtTimeForString), POINTID, Attribute, desiredTime, Vector, DoSwap, DoScale); }
        public bool GetPointVectorValueAtTime(int POINTID, int AttributeIndex, float desiredTime, Vector Vector, bool DoSwap, bool DoScale) { return Invoke<bool>(nameof(GetPointVectorValueAtTime), POINTID, AttributeIndex, desiredTime, Vector, DoSwap, DoScale); }
        public bool GetPointVector4ValueAtTimeForString(int POINTID, Object Attribute, float desiredTime, Vector4 Vector) { return Invoke<bool>(nameof(GetPointVector4ValueAtTimeForString), POINTID, Attribute, desiredTime, Vector); }
        public bool GetPointVector4ValueAtTime(int POINTID, int AttributeIndex, float desiredTime, Vector4 Vector) { return Invoke<bool>(nameof(GetPointVector4ValueAtTime), POINTID, AttributeIndex, desiredTime, Vector); }
        public Array<PointIndexes> GetPointValueIndexes() { return Invoke<Array<PointIndexes>>(nameof(GetPointValueIndexes)); }
        public bool GetPointValueAtTimeForString(int POINTID, Object Attribute, float desiredTime, float Value) { return Invoke<bool>(nameof(GetPointValueAtTimeForString), POINTID, Attribute, desiredTime, Value); }
        public bool GetPointValueAtTime(int POINTID, int AttributeIndex, float desiredTime, float Value) { return Invoke<bool>(nameof(GetPointValueAtTime), POINTID, AttributeIndex, desiredTime, Value); }
        public Array<int> GetPointTypes() { return Invoke<Array<int>>(nameof(GetPointTypes)); }
        public bool GetPointType(int POINTID, int Value) { return Invoke<bool>(nameof(GetPointType), POINTID, Value); }
        public bool GetPointQuatValueAtTimeForString(int POINTID, Object Attribute, float desiredTime, Quat Quat, bool DoHoudiniToUnrealConversion) { return Invoke<bool>(nameof(GetPointQuatValueAtTimeForString), POINTID, Attribute, desiredTime, Quat, DoHoudiniToUnrealConversion); }
        public bool GetPointQuatValueAtTime(int POINTID, int AttributeIndex, float desiredTime, Quat Quat, bool DoHoudiniToUnrealConversion) { return Invoke<bool>(nameof(GetPointQuatValueAtTime), POINTID, AttributeIndex, desiredTime, Quat, DoHoudiniToUnrealConversion); }
        public bool GetPointPositionAtTime(int POINTID, float desiredTime, Vector Vector) { return Invoke<bool>(nameof(GetPointPositionAtTime), POINTID, desiredTime, Vector); }
        public bool GetPointLifeAtTime(int POINTID, float desiredTime, float Value) { return Invoke<bool>(nameof(GetPointLifeAtTime), POINTID, desiredTime, Value); }
        public bool GetPointLife(int POINTID, float Value) { return Invoke<bool>(nameof(GetPointLife), POINTID, Value); }
        public bool GetPointInt32ValueAtTime(int POINTID, int AttributeIndex, float desiredTime, int Value) { return Invoke<bool>(nameof(GetPointInt32ValueAtTime), POINTID, AttributeIndex, desiredTime, Value); }
        public bool GetPointIDsToSpawnAtTime(float desiredTime, int MinID, int MaxID, int Count, int LastSpawnedPointID, float LastSpawnTime, float LastSpawnTimeRequest) { return Invoke<bool>(nameof(GetPointIDsToSpawnAtTime), desiredTime, MinID, MaxID, Count, LastSpawnedPointID, LastSpawnTime, LastSpawnTimeRequest); }
        public bool GetPointFloatValueAtTime(int POINTID, int AttributeIndex, float desiredTime, float Value) { return Invoke<bool>(nameof(GetPointFloatValueAtTime), POINTID, AttributeIndex, desiredTime, Value); }
        public int GetNumberOfSamples() { return Invoke<int>(nameof(GetNumberOfSamples)); }
        public int GetNumberOfPoints() { return Invoke<int>(nameof(GetNumberOfPoints)); }
        public int GetNumberOfAttributes() { return Invoke<int>(nameof(GetNumberOfAttributes)); }
        public bool GetNormalValue(int SampleIndex, Vector Value) { return Invoke<bool>(nameof(GetNormalValue), SampleIndex, Value); }
        public Array<float> GetLifeValues() { return Invoke<Array<float>>(nameof(GetLifeValues)); }
        public bool GetLastSampleIndexAtTime(float desiredTime, int lastSampleIndex) { return Invoke<bool>(nameof(GetLastSampleIndexAtTime), desiredTime, lastSampleIndex); }
        public bool GetLastPointIDToSpawnAtTime(float Time, int lastID) { return Invoke<bool>(nameof(GetLastPointIDToSpawnAtTime), Time, lastID); }
        public bool GetImpulseValue(int SampleIndex, float Value) { return Invoke<bool>(nameof(GetImpulseValue), SampleIndex, Value); }
        public bool GetFloatValueForString(int SampleIndex, Object Attribute, float Value) { return Invoke<bool>(nameof(GetFloatValueForString), SampleIndex, Attribute, Value); }
        public bool GetFloatValue(int SampleIndex, int attrIndex, float Value) { return Invoke<bool>(nameof(GetFloatValue), SampleIndex, attrIndex, Value); }
        public Array<float> GetFloatSampleData() { return Invoke<Array<float>>(nameof(GetFloatSampleData)); }
        public bool GetColorValue(int SampleIndex, LinearColor Value) { return Invoke<bool>(nameof(GetColorValue), SampleIndex, Value); }
        public bool GetAttributeIndexInArrayFromString(Object InAttribute, Array<Object> InAttributeArray, int OutAttributeIndex) { return Invoke<bool>(nameof(GetAttributeIndexInArrayFromString), InAttribute, InAttributeArray, OutAttributeIndex); }
        public bool GetAttributeIndexFromString(Object Attribute, int AttributeIndex) { return Invoke<bool>(nameof(GetAttributeIndexFromString), Attribute, AttributeIndex); }
    }
    public class NiagaraDataInterfaceHoudini : NiagaraDataInterface
    {
        public NiagaraDataInterfaceHoudini(ulong addr) : base(addr) { }
        public HoudiniPointCache HoudiniPointCacheAsset { get { return this[nameof(HoudiniPointCacheAsset)].As<HoudiniPointCache>(); } set { this["HoudiniPointCacheAsset"] = value; } }
    }
    public enum EHoudiniPointCacheFileType : int
    {
        Invalid = 0,
        CSV = 1,
        JSON = 2,
        BJSON = 3,
        EHoudiniPointCacheFileType_MAX = 4,
    }
    public enum EHoudiniAttributes : int
    {
        HOUDINI_ATTR_BEGIN = 0,
        Position = 0,
        Normal = 1,
        Time = 2,
        POINTID = 3,
        LIFE = 4,
        Color = 5,
        ALPHA = 6,
        Velocity = 7,
        Type = 8,
        Impulse = 9,
        AGE = 10,
        HOUDINI_ATTR_SIZE = 11,
        HOUDINI_ATTR_END = 10,
        EHoudiniAttributes_MAX = 12,
    }
    public class PointIndexes : Object
    {
        public PointIndexes(ulong addr) : base(addr) { }
        public Array<int> SampleIndexes { get { return new Array<int>(this[nameof(SampleIndexes)].Address); } }
    }
    public class HoudiniEvent : Object
    {
        public HoudiniEvent(ulong addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Impulse { get { return this[nameof(Impulse)].GetValue<float>(); } set { this[nameof(Impulse)].SetValue<float>(value); } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public int POINTID { get { return this[nameof(POINTID)].GetValue<int>(); } set { this[nameof(POINTID)].SetValue<int>(value); } }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
        public float LIFE { get { return this[nameof(LIFE)].GetValue<float>(); } set { this[nameof(LIFE)].SetValue<float>(value); } }
        public LinearColor Color { get { return this[nameof(Color)].As<LinearColor>(); } set { this["Color"] = value; } }
        public int Type { get { return this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>(value); } }
    }
}
