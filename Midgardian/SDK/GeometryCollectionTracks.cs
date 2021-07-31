using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryCollectionTracksSDK
{
    public class MovieSceneGeometryCollectionSection : MovieSceneSection
    {
        public MovieSceneGeometryCollectionSection(ulong addr) : base(addr) { }
        public MovieSceneGeometryCollectionParams Params { get { return this[nameof(Params)].As<MovieSceneGeometryCollectionParams>(); } set { this["Params"] = value; } }
    }
    public class MovieSceneGeometryCollectionTrack : MovieSceneNameableTrack
    {
        public MovieSceneGeometryCollectionTrack(ulong addr) : base(addr) { }
        public Array<MovieSceneSection> AnimationSections { get { return new Array<MovieSceneSection>(this[nameof(AnimationSections)].Address); } }
    }
    public class MovieSceneGeometryCollectionParams : Object
    {
        public MovieSceneGeometryCollectionParams(ulong addr) : base(addr) { }
        public SoftObjectPath GeometryCollectionCache { get { return this[nameof(GeometryCollectionCache)].As<SoftObjectPath>(); } set { this["GeometryCollectionCache"] = value; } }
        public FrameNumber StartFrameOffset { get { return this[nameof(StartFrameOffset)].As<FrameNumber>(); } set { this["StartFrameOffset"] = value; } }
        public FrameNumber EndFrameOffset { get { return this[nameof(EndFrameOffset)].As<FrameNumber>(); } set { this["EndFrameOffset"] = value; } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
    }
    public class MovieSceneGeometryCollectionSectionTemplate : MovieSceneEvalTemplate
    {
        public MovieSceneGeometryCollectionSectionTemplate(ulong addr) : base(addr) { }
        public MovieSceneGeometryCollectionSectionTemplateParameters Params { get { return this[nameof(Params)].As<MovieSceneGeometryCollectionSectionTemplateParameters>(); } set { this["Params"] = value; } }
    }
    public class MovieSceneGeometryCollectionSectionTemplateParameters : MovieSceneGeometryCollectionParams
    {
        public MovieSceneGeometryCollectionSectionTemplateParameters(ulong addr) : base(addr) { }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
        public FrameNumber SectionEndTime { get { return this[nameof(SectionEndTime)].As<FrameNumber>(); } set { this["SectionEndTime"] = value; } }
    }
}
