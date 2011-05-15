using System.Linq;
using System.Web.Mvc;
using MavenThought.PrDC.Api;
using MavenThought.PrDC.Demo.Models;

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
        /// <param name="conferenceRepo">Conference repository to use</param>
        public TracksController(IConference conferenceRepo)
        {
            this._conference = conferenceRepo;
        }
        
        //
        // GET: /Tracks/
        public ActionResult Index()
        {
            var tracks = this._conference.Tracks
                .Select(t => new TrackViewModel
                                 {
                                     Track = t,
                                     Sessions = this._conference.SessionsForTrack(t)
                                 })
                .ToList();

            return View(tracks);
        }
    }
}
