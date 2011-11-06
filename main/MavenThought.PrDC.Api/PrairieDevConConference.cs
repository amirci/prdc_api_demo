using System.Collections.Generic;
using RestSharp;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Repository to obtain data
    /// </summary>
    public class PrairieDevConConference : IConference
    {
        /// <summary>
        /// Url to use
        /// </summary>
        public const string ConferenceURL = @"http://www.prairiedevcon.com";

        /// <summary>
        /// Gets the presenters at the conference
        /// </summary>
        public IEnumerable<ISpeaker> Speakers
        {
            get
            {
                var client = new RestClient {BaseUrl = ConferenceURL};

                var request = new RestRequest {Resource = "speakers", RootElement = "speakers"};

                return client.Execute<List<Speaker>>(request).Data; 
            }
        }

        /// <summary>
        /// Gets all the sessions in the conference
        /// </summary>
        public IEnumerable<IPresenterSession> Sessions
        {
            get
            {
                var client = new RestClient { BaseUrl = ConferenceURL };

                var request = new RestRequest { Resource = "sessions", RootElement = "sessions" };

                return client.Execute<List<PresenterSession>>(request).Data;
            }
        }
    }
}