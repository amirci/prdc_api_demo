using System.Collections.Generic;
using MavenThought.PrDC.Demo.Controllers;
using MavenThought.PrDC.Demo.Models;

namespace MavenThought.PrDC.Demo.Tests.Controllers
{
    /// <summary>
    /// Base specification for TracksController
    /// </summary>
    public abstract class TracksControllerSpecification
        : BaseControllerSpecification<TracksController, IEnumerable<TrackViewModel>>
    {
    }
}