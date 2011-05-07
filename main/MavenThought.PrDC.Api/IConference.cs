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
        IEnumerable<Presenter> Presenters { get; }
        
        /// <summary>
        /// Gets all the sessions in the conference
        /// </summary>
        IEnumerable<PresenterSession> Sessions { get; }

        /// <summary>
        /// Gets all the tracks in the conference
        /// </summary>
        IEnumerable<Track> Tracks { get; }
    }
}
