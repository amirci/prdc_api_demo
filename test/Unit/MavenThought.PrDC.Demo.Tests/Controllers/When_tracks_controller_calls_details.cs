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
    /// Specification when calling details
    /// </summary>
    [Specification]
    public class When_tracks_controller_calls_details 
        : TracksControllerSpecification<IEnumerable<IPresenterSession>>
    {
        private string _track;

        /// <summary>
        /// Checks that render the view
        /// </summary>
        [It]
        public void Should_render_the_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Checks that the sessions for the track are returned
        /// </summary>
        [It]
        public void Should_return_all_the_sessions_in_the_track()
        {
            this.Model.Should().Have.SameValuesAs(this.Expected);
        }

        /// <summary>
        /// Setup expected sessions
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this._track = "Mobile";

            this.Expected = 10.Times(() => Mock<IPresenterSession>());

            Dep<IConference>().Stub(conf => conf.SessionsForTrack(this._track)).Return(this.Expected);
        }

        /// <summary>
        /// Get the details
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Detail("Mobile");
        }
    }
}