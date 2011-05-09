using System.Collections.Generic;
using Rhino.Mocks;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MavenThought.PrDC.Api.Tests
{
    /// <summary>
    /// Specification when listing all the presenters
    /// </summary>
    [Specification]
    public class When_conference_lists_presenters : PrairieDevConConferenceSpecification
    {
        private IEnumerable<Presenter> _actual;

        private IEnumerable<Presenter> _expected;

        /// <summary>
        /// Checks that all the presenters are returned
        /// </summary>
        [It]
        public void Should_return_all_the_presenters()
        {
            this._actual.Should().Have.SameValuesAs(this._expected);
        }

        /// <summary>
        /// Setup the presenters
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this._expected = RandomEntities.CollectionOf<Presenter>(10);

            Dep<IRestClient>().Stub(api => api.GetAll<Presenter>(site)).Return(this._expected);
        }

        /// <summary>
        /// Get the presenters
        /// </summary>
        protected override void WhenIRun()
        {
            this._actual = this.Sut.Presenters;
        }
    }
}