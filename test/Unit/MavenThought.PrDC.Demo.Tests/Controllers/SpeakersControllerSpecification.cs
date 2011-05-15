using MavenThought.PrDC.Demo.Controllers;

namespace MavenThought.PrDC.Demo.Tests.Controllers
{
    /// <summary>
    /// Base specification for SpeakersController
    /// </summary>
    public abstract class SpeakersControllerSpecification<TModel>
        : BaseControllerSpecification<SpeakersController, TModel>
    {
    }
}