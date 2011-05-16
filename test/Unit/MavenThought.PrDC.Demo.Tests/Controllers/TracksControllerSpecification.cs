using MavenThought.PrDC.Demo.Controllers;

namespace MavenThought.PrDC.Demo.Tests.Controllers
{
    /// <summary>
    /// Base specification for TracksController
    /// </summary>
    public abstract class TracksControllerSpecification<TModel>
        : BaseControllerSpecification<TracksController, TModel>
    {
    }
}