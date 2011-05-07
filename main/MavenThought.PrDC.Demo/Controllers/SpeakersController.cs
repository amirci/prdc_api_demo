using System.Web.Mvc;
using MavenThought.PrDC.Api;

namespace MavenThought.PrDC.Demo.Controllers
{
    public class SpeakersController : Controller
    {
        /// <summary>
        /// Repository to use
        /// </summary>
        private readonly IConference conferenceRepo;

        /// <summary>
        /// Initializes a new instance of the SpeakersController class.
        /// </summary>
        /// <param name="conferenceRepo"></param>
        public SpeakersController(IConference conferenceRepo)
        {
            this.conferenceRepo = conferenceRepo;
        }

        //
        // GET: /Speakers/
        public ActionResult Index()
        {
            var presenters = conferenceRepo.Presenters;

            return View(presenters);
        }
    }
}
