using System;
using System.Diagnostics;
using System.IO;
using SharpTestsEx;

namespace MavenThought.PrDC.Demo.Acceptance.Tests.Infrastructure
{
    public class WebServer
    {
        /// <summary>
        /// Path to find IIS Express
        /// </summary>
        private const string relativeToolPath = @"..\..\..\..\..\tools\IIS Express\iisexpress.exe";

        /// <summary>
        /// Path to find the web application
        /// </summary>
        const string relativeWebPath = @"..\..\..\..\..\main\MavenThought.PrDC.Demo";

        /// <summary>
        /// Root to the website
        /// </summary>
        public static DirectoryInfo WebRoot = new DirectoryInfo(ResolvePath(relativeWebPath));

        /// <summary>
        /// Port to use
        /// </summary>
        private const int Port = 8091;

        /// <summary>
        /// CLR version to pass to IIS Express
        /// </summary>
        private const double ClrVersion = 4.0;

        private Process _process;

        public void Start()
        {
            var actualPath = Path.Combine(Directory.GetCurrentDirectory(), relativeToolPath);

            // configure IIS Express command-line parameters
            var exeFile = new FileInfo(actualPath);

            var args = string.Format(@"/path:""{0}"" /port:{1} /clr:v{2:0.0}", WebRoot.FullName, Port, ClrVersion);

            Log("starting IIS Express:\n--> {0} {1}", exeFile.FullName, args);

            // run IIS Express as requested
            exeFile.Exists.Should().Be.True();

            var iisexpressStartInfo = new ProcessStartInfo
            {
                FileName = exeFile.FullName,
                Arguments = args
            };

            _process = Process.Start(iisexpressStartInfo);
        }

        public void Shutdown()
        {
            Log("shutting down the web server.");

            using (var exe = this._process)
            {
                exe.Kill();
            }
        }

        public static void Log(string text, params object[] args)
        {
            Console.WriteLine();
            Console.WriteLine(text, args);
            Console.WriteLine();
        }

        private static string ResolvePath(string relativePath)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), relativePath);
        }
    }
}