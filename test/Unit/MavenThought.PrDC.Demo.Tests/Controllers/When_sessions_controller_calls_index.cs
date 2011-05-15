using System.Collections.Generic;
using MavenThought.Commons.Extensions;
using MavenThought.PrDC.Api;
using MvcContrib.TestHelper;
using Rhino.Mocks;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MavenThought.PrDC.Demo.Tests.Controllers
{
    /// <summary>
    /// Specification when calling Index method
    /// </summary>
    [Specification]
    public class When_sessions_controller_calls_index 
        : SessionsControllerSpecification<IEnumerable<IPresenterSession>>
    {
        /// <summary>
        /// Checks that the collection of sessions are returned
        /// </summary>
        [It]
        public void Should_return_the_collection_of_sessions()
        {
            this.Model.Should().Have.SameValuesAs(this.Expected) ;
        }

        /// <summary>
        /// Checks that the View is returned
        /// </summary>
        [It]
        public void Should_return_the_index_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Setup the expected sessions
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this.Expected = 10.Times(() => Mock<IPresenterSession>());

            Dep<IConference>().Stub(conf => conf.Sessions).Return(this.Expected);
        }

        /// <summary>
        /// Call the method
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Index();
        }
    }
}