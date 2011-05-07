using System.Collections.Generic;
using System.Web.Mvc;
using MavenThought.Commons.Testing;
using PrairieDevCon.Core;
using PrairieDevCon.Testing.Infrastructure;
using Rhino.Mocks;
using SharpTestsEx;

namespace PrairieDevCon.Website.Tests.Controllers
{
    /// <summary>
    /// Specification when calling Index on tracks controller
    /// </summary>
    [Specification]
    public class When_tracks_controller_gets_all_tracks : TracksControllerSpecification
    {
        /// <summary>
        /// Expected tracks
        /// </summary>
        private IEnumerable<Track> _expected;

        /// <summary>
        /// Checks that all the tracks are returned in the result
        /// </summary>
        [It]
        public void Should_return_all_the_tracks_as_json()
        {
            var json = (JsonResult) this.Result;

            var tracks = (IEnumerable<Track>) json.Data;

            tracks.Should().Have.SameSequenceAs(this._expected);
        }

        /// <summary>
        /// Setup the sessions
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this._expected = RandomGenerator.CollectionOf<Track>(10);

            Dep<IConferenceRepository>().Stub(repo => repo.Tracks).Return(this._expected);
        }

        /// <summary>
        /// Call the index
        /// </summary>
        protected override void WhenIRun()
        {
            this.Result = this.Sut.Index();
        }        
    }
}