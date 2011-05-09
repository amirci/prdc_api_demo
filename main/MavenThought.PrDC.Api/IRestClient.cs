using System.Collections.Generic;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Abstraction for the REST client
    /// </summary>
    public interface IRestClient
    {
        /// <summary>
        /// Gets all the resources of the type (by using type name)
        /// </summary>
        /// <typeparam name="T">Type of the resource</typeparam>
        /// <param name="url">Url to use</param>
        /// <returns>All the resources matching the type name</returns>
        IEnumerable<T> GetAll<T>(string url);
    }
}