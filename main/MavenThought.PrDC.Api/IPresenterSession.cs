using System.Collections.Generic;

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
        IEnumerable<ISpeaker> Speakers { get; set; }
        IEnumerable<string> Tags { get; set; }
    }
}