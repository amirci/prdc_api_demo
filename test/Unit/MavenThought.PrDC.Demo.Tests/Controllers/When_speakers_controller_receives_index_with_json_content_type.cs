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
    /// Specification when calling Index with json content type
    /// </summary>
    [Specification]
    public class When_speakers_controller_receives_index_with_json_content_type
        : SpeakersControllerSpecification
    {
        private IEnumerable<Presenter> _expected;

        /// <summary>
        /// Checks that the result is json
        /// </summary>
        [It]
        public void Should_return_json_result()
        {
            this.Result.Should().Be.InstanceOf<JsonResult>();
        }

        /// <summary>
        /// Checks that the result includes the expected speakers
        /// </summary>
        [It]
        public void Should_return_the_expected_speakers()
        {
            var json = (JsonResult) this.Result;

            var actual = (IEnumerable<Presenter>) json.Data;

            actual.Should().Have.SameSequenceAs(this._expected);
        }

        /// <summary>
        /// Setup presenters
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this._expected = RandomGenerator.CollectionOf<Presenter>(10);

            Dep<IConferenceRepository>().Stub(repo => repo.Presenters).Return(_expected);
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