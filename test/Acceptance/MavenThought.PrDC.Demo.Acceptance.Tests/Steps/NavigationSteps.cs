using TechTalk.SpecFlow;

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
    }
}
