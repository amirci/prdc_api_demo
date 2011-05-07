using System.Web.Mvc;
using EasyHttp.Http;
using MavenThought.Commons.Testing;
using MvcContrib.TestHelper;

namespace PrairieDevCon.Website.Tests.Controllers
{
    public abstract class ControllerSpecification<T> : 
        AutoMockSpecificationWithNoContract<T> where T : Controller
    {
        /// <summary>
        /// Builder to use
        /// </summary>
        protected TestControllerBuilder Builder { get; set; }

        /// <summary>
        /// Actual result obtained from calling the method
        /// </summary>
        protected ActionResult Result { get; set; }

        /// <summary>
        /// Create the builder
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this.Builder = new TestControllerBuilder();
        }

        /// <summary>
        /// Setup the builder
        /// </summary>
        protected override void AndGivenThatAfterCreated()
        {
            base.AndGivenThatAfterCreated();

            this.Builder.InitializeController(this.Sut);

            this.Builder.AcceptTypes = new[] { HttpContentTypes.ApplicationJson };
        }
    }
}