using SharpTestsEx;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    [Binding]
    public class NavigationSteps : BaseSteps
    {
        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page">Path to go</param>
        [Given(@"I'm on the ""(.*)"" page")]
        public void GoToResourcePage(string page)
        {
            this.Browser.GoTo(page);
        }

        /// <summary>
        /// Follow a link
        /// </summary>
        /// <param name="linkName">Link text to be followed</param>
        [When(@"I follow ""(.*)""")]
        public void FollowLink(string linkName)
        {
            this.Browser.Instance.Link(Find.ByText(linkName)).Click();
        }

        [Then(@"I should see ""(.*)""")]
        public void PageShouldContainText(string text)
        {
            this.Browser.Instance.ContainsText(text).Should().Be.True();
        }
    }
}
