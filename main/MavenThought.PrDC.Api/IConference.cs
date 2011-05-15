using System.Collections.Generic;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Repository for the conference
    /// </summary>
    public interface IConference
    {
        /// <summary>
        /// Gets the presenters at the conference
        /// </summary>
        IEnumerable<ISpeaker> Speakers { get; }
        
        /// <summary>
        /// Gets all the sessions in the conference
        /// </summary>
        IEnumerable<IPresenterSession> Sessions { get; }

        /// <summary>
        /// Gets all the tracks in the conference
        /// </summary>
        IEnumerable<ITrack> Tracks { get; }

        /// <summary>
        /// Gets all the sessions in that track
        /// </summary>
        /// <param name="track">Track to use</param>
        /// <returns>All the sessions in the track</returns>
        IEnumerable<IPresenterSession> SessionsForTrack(ITrack track);
    }
}
