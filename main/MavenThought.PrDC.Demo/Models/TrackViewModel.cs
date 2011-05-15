using System.Collections.Generic;
using MavenThought.PrDC.Api;

namespace MavenThought.PrDC.Demo.Models
{
    public class TrackViewModel
    {
        public ITrack Track { get; set; }

        public IEnumerable<IPresenterSession> Sessions { get; set; }
    }
}