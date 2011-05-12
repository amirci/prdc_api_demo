using System.Linq;
using MavenThought.Commons.Extensions;
using SharpTestsEx;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class TracksSteps : BaseSteps
    {
        [Then(@"I should see the following tracks with sessions")]
        public void ShouldSeeTheTracks(Table table)
        {
            var sessions = this.Browser
                .Instance
                .Elements
                .Filter(Find.BySelector(".title"))
                .Select(s => s.Text);

            table.Rows.ForEach(row => sessions.Should().Contain(row["track"].ToString()));
        }

    }
}
