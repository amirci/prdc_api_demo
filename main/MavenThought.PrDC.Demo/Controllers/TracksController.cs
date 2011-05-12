using System.Web.Mvc;
using MavenThought.PrDC.Api;

namespace MavenThought.PrDC.Demo.Controllers
{
    public class TracksController : Controller
    {
        /// <summary>
        /// Repository to find the sessions
        /// </summary>
        private readonly IConference _conference;

        /// <summary>
        /// Initializes a new instance of the SessionsController class.
        /// </summary>
        /// <param name="conferenceRepo"></param>
        public TracksController(IConference conferenceRepo)
        {
            this._conference = conferenceRepo;
        }
        
        //
        // GET: /Tracks/
        public ActionResult Index()
        {
            return View(this._conference.Tracks);
        }

    }
}
