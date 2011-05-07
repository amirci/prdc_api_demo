using System.Collections.Generic;
using System.Linq;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Repository to obtain data
    /// </summary>
    public class PrarieDevConConference : IConference
    {
        /// <summary>
        /// Gets the presenters at the conference
        /// </summary>
        public IEnumerable<Presenter> Presenters
        {
            get
            {
                return Enumerable.Empty<Presenter>();
            }
        }

        /// <summary>
        /// Gets all the sessions in the conference
        /// </summary>
        public IEnumerable<PresenterSession> Sessions
        {
            get { return Enumerable.Empty<PresenterSession>(); }
        }

        /// <summary>
        /// Gets all the tracks in the conference
        /// </summary>
        public IEnumerable<Track> Tracks
        {
            get
            {
                return  Enumerable.Empty<Track>();
            }
        }
    }
}