using System;
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
                .Select(e => e.Text);

            table.Rows.ForEach(row => HasMatchingTrack(row, tracks));
        }

        private static void HasMatchingTrack(TableRow row, IEnumerable<string> tracks)
        {
            var found = tracks.Find(e => e.Contains(row["track"]));

            Assert.IsNotNull(found, "Can't find track {0} with count {1}", row["track"], row["count"]);

            found.Should().Contain(string.Format("Number of Sessions: {0}",row["count"]));
        }
    }
}
