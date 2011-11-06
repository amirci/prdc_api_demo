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
    }
}
