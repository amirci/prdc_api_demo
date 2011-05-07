using System;
using WatiN.Core;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Infrastructure
{
    /// <summary>
    /// Steps related to browser operations
    /// </summary>
    public class Browser
    {
        /// <summary>
        /// Main URL for the application
        /// </summary>
        private static readonly string ApplicationURL = string.Format("http://localhost:{0}", 8091);

        /// <summary>
        /// Initialize instance
        /// </summary>
        public Browser()
        {
            Instance = new IE(ApplicationURL);
        }

        /// <summary>
        /// Browser used or the tests
        /// </summary>
        public IE Instance { get; private set; }

        /// <summary>
        /// Go to a path in the application
        /// </summary>
        /// <param name="path">Path to go</param>
        public void GoTo(string path)
        {
            Instance.GoTo(String.Format("{0}/{1}", ApplicationURL, path));
            Instance.Refresh();
        }

        /// <summary>
        /// Shutdown the browser
        /// </summary>
        public void Shutdown()
        {
            Instance.Close();
        }
    }
}