using System.Collections.Generic;

namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Base implementation for a presenter session
    /// </summary>
    public class PresenterSession : IPresenterSession
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public IEnumerable<ISpeaker> Speakers
        {
            get; set; 
        }

        public IEnumerable<string> Tags
        {
            get;
            set;
        }
    }
}