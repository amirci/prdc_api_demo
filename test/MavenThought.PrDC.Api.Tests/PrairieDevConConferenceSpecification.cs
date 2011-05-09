using System;
using MavenThought.Commons.Testing;

namespace MavenThought.PrDC.Api.Tests
{
    /// <summary>
    /// Base specification for PrairieDevConference spec 
    /// </summary>
    public abstract class PrairieDevConConferenceSpecification 
        : AutoMockSpecificationWithNoContract<PrairieDevConConference>
    {
        protected const string site = @"http://www.prairiedevcon.com";

        /// <summary>
        /// Calculates the URL for the resource specified by type
        /// </summary>
        /// <typeparam name="T">Type of the resource</typeparam>
        /// <returns>A string with the URL</returns>
        protected string UrlFor<T>()
        {
            return string.Format("{0}/{1}s", site, typeof(T).Name);
        }
    }
}