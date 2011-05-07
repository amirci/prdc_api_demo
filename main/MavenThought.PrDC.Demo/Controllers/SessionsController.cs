using System.Web.Mvc;
using MavenThought.PrDC.Api;

namespace MavenThought.PrDC.Demo.Controllers
{
    /// <summary>
    /// Controller for sessions (i.e. speaker presentations)
    /// </summary>
    public class SessionsController : Controller
    {
        /// <summary>
        /// Repository to find the sessions
        /// </summary>
        private readonly IConference repository;

        /// <summary>
        /// Initializes a new instance of the SessionsController class.
        /// </summary>
        /// <param name="conferenceRepo"></param>
        public SessionsController(IConference conferenceRepo)
        {
            this.repository = conferenceRepo;
        }

        //
        // GET: /Sessions/
        public ActionResult Index(string track)
        {
            return View();
        }
    }
}
