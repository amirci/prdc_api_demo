using MavenThought.Commons.Extensions;
using SharpTestsEx;
using TechTalk.SpecFlow;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class PresentersSteps : BaseSteps
    {
        [Then(@"I should see the following presenters:")]
        public void ShouldBeInThePage(Table table)
        {
            table.Rows.ForEach(row => this.PageContains(row[0].ToString()).Should().Be.True());
        }
    }
}
