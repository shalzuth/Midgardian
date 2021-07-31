using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.MoviePlayerSDK
{
    public class MoviePlayerSettings : Object
    {
        public MoviePlayerSettings(ulong addr) : base(addr) { }
        public bool bWaitForMoviesToComplete { get { return this[nameof(bWaitForMoviesToComplete)].Flag; } set { this[nameof(bWaitForMoviesToComplete)].Flag = value; } }
        public bool bMoviesAreSkippable { get { return this[nameof(bMoviesAreSkippable)].Flag; } set { this[nameof(bMoviesAreSkippable)].Flag = value; } }
        public Array<Object> StartupMovies { get { return new Array<Object>(this[nameof(StartupMovies)].Address); } }
    }
    public enum EMoviePlaybackType : int
    {
        MT_Normal = 0,
        MT_Looped = 1,
        MT_LoadingLoop = 2,
        MT_MAX = 3,
    }
}
