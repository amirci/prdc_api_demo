using System;
using System.Collections.Generic;
using System.Net;
using EasyHttp.Http;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Repository to obtain data
    /// </summary>
    public class PrairieDevConConference : IConference
    {
        /// <summary>
        /// Backing field for api client
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Url to use
        /// </summary>
        public const string ConferenceURL = @"http://www.prairiedevcon.com";

        /// <summary>
        /// Initializes the <see cref="PrairieDevConConference"/> class.
        /// </summary>
        public PrairieDevConConference()
        {
            _httpClient = new HttpClient();

            _httpClient.Request.Accept = HttpContentTypes.ApplicationJson;
        }

        /// <summary>
        /// Gets the presenters at the conference
        /// </summary>
        public IEnumerable<ISpeaker> Speakers
        {
            get { return Get<Speaker>(); }
        }

        /// <summary>
        /// Gets all the sessions in the conference
        /// </summary>
        public IEnumerable<IPresenterSession> Sessions
        {
            get { return Get<PresenterSession>(); }
        }

        /// <summary>
        /// Gets all the tracks in the conference
        /// </summary>
        public IEnumerable<ITrack> Tracks
        {
            get { return Get<Track>(); }
        }

        /// <summary>
        /// Gets all the sessions in that track
        /// </summary>
        /// <param name="track">Track to use</param>
        /// <returns>All the sessions in the track</returns>
        public IEnumerable<IPresenterSession> SessionsForTrack(ITrack track)
        {
            var formatted = string.Format("{0}/{1}s/{2}", ConferenceURL, "Session", track.Name);

            return GetUrl<PresenterSession>(formatted);
        }

        /// <summary>
        /// Gets the a collection of resources by type
        /// </summary>
        /// <typeparam name="T">Type of the resource</typeparam>
        /// <returns>A collection of instances of the resource</returns>
        private IEnumerable<T> Get<T>()
        {
            var nameMap = new Dictionary<Type, string>
                              {
                                  {typeof (PresenterSession), "Session"}
                              };


            var typeName = nameMap.ContainsKey(typeof(T)) ? nameMap[typeof(T)] : typeof(T).Name;

            var formatted = string.Format("{0}/{1}s", ConferenceURL, typeName);

            return GetUrl<T>(formatted);
        }

        /// <summary>
        /// Gets the resources associated to the URL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="formatted"></param>
        /// <returns></returns>
        private IEnumerable<T> GetUrl<T>(string formatted)
        {
            var response = this._httpClient.Get(formatted);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("Can't retrieve the resource {0}", formatted));
            }

            return response.StaticBody<IEnumerable<T>>();
        }
    }
}