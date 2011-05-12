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
        private readonly IConference _conference;

        /// <summary>
        /// Initializes a new instance of the SessionsController class.
        /// </summary>
        /// <param name="conferenceRepo"></param>
        public SessionsController(IConference conferenceRepo)
        {
            this._conference = conferenceRepo;
        }

        //
        // GET: /Sessions/
        public ActionResult Index()
        {
            return View(this._conference.Sessions);
        }
    }
}
