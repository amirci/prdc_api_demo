using System.Linq;
using MavenThought.Commons.Extensions;
using SharpTestsEx;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class SessionsSteps : BaseSteps
    {
        [Then(@"I should see the following sessions:")]
        public void ShouldHaveSessions(Table table)
        {
            var sessions = this.Browser.Instance.Elements.Filter(Find.ByClass(".sessions.title"));

            var names = sessions.Select(s => s.Text).ToList();

            table.Rows.ForEach(row => names.Should().Contain(row[0].ToString()));
        }
    }
}
