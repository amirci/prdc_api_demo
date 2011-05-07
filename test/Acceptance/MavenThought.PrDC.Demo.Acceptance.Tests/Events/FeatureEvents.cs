using MavenThought.PrDC.Demo.Acceptance.Tests.Infrastructure;
using TechTalk.SpecFlow;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Events
{
    /// <summary>
    /// Events for scenarios and steps
    /// Events to start and stop databse, webserver, etc....
    /// </summary>
    [Binding]
    public class FeatureEvents
    {
        /// <summary>
        /// Setup the browser
        /// </summary>
        [BeforeScenario]
        public static void BeforeScenario()
        {
            var server = new WebServer();

            server.Start();

            var context = ScenarioContext.Current;

            context.Set(server);

            context.Set(new Browser());
        }

        /// <summary>
        /// Close the browser
        /// </summary>
        [AfterScenario]
        public static void AfterScenario()
        {
            var context = ScenarioContext.Current;

            context.Get<WebServer>().Shutdown();

            context.Get<Browser>().Shutdown();
        }
    }
}
