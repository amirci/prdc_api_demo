using System;
using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Extensions;
using MavenThought.PrDC.Api;
using MavenThought.PrDC.Demo.Models;
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
        : TracksControllerSpecification<IEnumerable<TrackViewModel>>
    {
        private IDictionary<ITrack, IEnumerable<IPresenterSession>> _tracks;

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
        public void Should_return_a_collection_of_view_models()
        {
            this.Model.Should().Not.Be.Null();
        }

        protected override void GivenThat()
        {
            base.GivenThat();

            Func<IDictionary<ITrack, IEnumerable<IPresenterSession>>, 
                ITrack, 
                IDictionary<ITrack, IEnumerable<IPresenterSession>>> func = (map, t) =>
                            {
                                map[t] = 10.Times(() => Mock<IPresenterSession>());
                                return map;
                            };

            this._tracks = 10
                .Times(() => Mock<ITrack>())
                .Aggregate(new Dictionary<ITrack, IEnumerable<IPresenterSession>>(), func);

            Dep<IConference>().Stub(conf => conf.Tracks).Return(this._tracks.Keys);

            Dep<IConference>()
                .Stub(conf => conf.SessionsForTrack(Arg<string>.Is.Anything))
                .WhenCalled(mi => mi.ReturnValue = this._tracks[(ITrack) mi.Arguments[0]])
                .Return(null);
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