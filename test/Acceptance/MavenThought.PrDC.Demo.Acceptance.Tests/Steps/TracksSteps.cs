using System.Collections.Generic;
using System.Linq;
using MavenThought.Commons.Extensions;
using NUnit.Framework;
using SharpTestsEx;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;
using TableRow = TechTalk.SpecFlow.TableRow;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class TracksSteps : BaseSteps
    {
        [Then(@"I should see the following tracks with sessions")]
        public void ShouldSeeTheTracks(Table table)
        {
            var tracks = this.Browser
                .Instance
                .Elements
                .Filter(Find.BySelector(".track"))
                .Select(e => e.Text.Trim());

            table.Rows.ForEach(row => HasMatchingTrack(row, tracks));
        }

        private static void HasMatchingTrack(TableRow row, IEnumerable<string> tracks)
        {
            var expected = string.Format("{0}: {1}",row["track"], row["count"]);

            tracks.Should().Contain(expected);
        }
    }
}
