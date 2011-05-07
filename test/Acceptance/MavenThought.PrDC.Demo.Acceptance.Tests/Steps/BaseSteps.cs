using MavenThought.PrDC.Demo.Acceptance.Tests.Infrastructure;
using TechTalk.SpecFlow;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Steps
{
    /// <summary>
    /// Base steps shared
    /// </summary>
    public class BaseSteps
    {
        protected Browser Browser
        {
            get { return ScenarioContext.Current.Get<Browser>(); }
        }

        public bool PageContains(string text)
        {
            return this.Browser.Instance.ContainsText(text);
        }
    }
}