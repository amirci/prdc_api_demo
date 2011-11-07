using System.Collections.Generic;

namespace MavenThought.PrDC.Api
{
    public class Session : IPresenterSession
    {
        public virtual string Title { get; set; }

        public virtual string Abstract { get; set; }

        public IEnumerable<ISpeaker> Speakers { get; set; }
        
        public IEnumerable<string> Tags { get; set; }

        public virtual int Id { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Session;

            return other != null && this.Title == other.Title;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}