using System.Linq;
using System.Web.Mvc;

namespace MavenThought.PrDC.Demo.Helpers
{
    public static class ControllerHelper
    {
        /// <summary>
        /// Checks if the controller has json as content type
        /// </summary>
        /// <param name="controller"></param>
        /// <returns><c>true</c> if the headers include content type json</returns>
        public static bool ShouldReturnJson(this Controller controller)
        {
            const string ApplicationJson = "application/json";

            return controller.Request.AcceptTypes.Any(type => type == ApplicationJson);
        }
    }
}