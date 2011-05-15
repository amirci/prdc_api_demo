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
    /// Specification when calling index method
    /// </summary>
    [Specification]
    public class When_speakers_controller_calls_index 
        : SpeakersControllerSpecification<IEnumerable<ISpeaker>>
    {
        /// <summary>
        /// Checks that all the speakers are returned
        /// </summary>
        [It]
        public void Should_return_all_the_speakers()
        {
            this.Model.Should().Have.SameValuesAs(this.Expected);
        }

        /// <summary>
        /// Checks that the expected view is reneder
        /// </summary>
        [It]
        public void Should_render_the_index_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Setup the expected sessions
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this.Expected = 10.Times(() => Mock<ISpeaker>());

            Dep<IConference>().Stub(conf => conf.Speakers).Return(this.Expected);
        }

        /// <summary>
        /// Call the index method
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Index();
        }
    }
}