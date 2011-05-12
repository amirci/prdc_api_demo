namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Model for presenters sessions
    /// </summary>
    public interface IPresenterSession
    {
        int Id { get; set; }
        string Title { get; set; }
        string Abstract { get; set; }
        string Style { get; set; }
        string Presenter { get; set; }
        string Track { get; set; }
        int Year { get; set; }
    }
}