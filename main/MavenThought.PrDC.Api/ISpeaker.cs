namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Model for speakers
    /// </summary>
    public interface ISpeaker
    {
        int Id { get; set; }
        string Email { get; set; }
        string Bio { get; set; }
        string Twitter { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string WebSite { get; set; }
        string Blog { get; set; }
        string Location { get; set; }
        string Picture { get; set; }
        int Year { get; set; }
        string Company { get; set; }
    }
}