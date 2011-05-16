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
    /// Specification when calling index on tracks controller
    /// </summary>
    [Specification]
    public class When_tracks_controller_calls_index
        : TracksControllerSpecification<IEnumerable<ITrack>>
    {
        /// <summary>
        /// Checks that the view is rendered
        /// </summary>
        [It]
        public void Should_render_the_expected_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Checks that the view model collection is returned
        /// </summary>
        [It]
        public void Should_return_a_collection_of_tracks()
        {
            this.Model.Should().Have.SameValuesAs(this.Expected);
        }

        protected override void GivenThat()
        {
            base.GivenThat();

            this.Expected = 10.Times(() => Mock<ITrack>());

            Dep<IConference>().Stub(conf => conf.Tracks).Return(this.Expected);
        }

        /// <summary>
        /// Call index method
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Index();
        }
    }
}