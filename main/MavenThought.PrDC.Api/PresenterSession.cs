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

        public string Style { get; set; }

        public string Presenter { get; set; }

        public string Track { get; set; }

        public int Year { get; set; }
    }
}