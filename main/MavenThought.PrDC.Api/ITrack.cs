namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Model for tracks in the conference
    /// </summary>
    public interface ITrack
    {
        string Name { get; set; }
        int Id { get; set; }
        string Key { get; set; }
        int NumberOfSessions { get; set; }
        bool Category { get; set; }
    }
}