using System.Linq;
using MavenThought.Commons.Extensions;
using SharpTestsEx;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class PresentersSteps : BaseSteps
    {
        [Then(@"I should see the following presenters:")]
        public void ShouldHavePresenters(Table table)
        {
            var speakers = this.Browser.Instance.Divs.Filter(Find.ByClass("title"));

            var names = speakers.Select(s => s.Text).ToList();

            table.Rows.ForEach(row => names.Should().Contain(row[0].ToString()));
        }
    }
}
