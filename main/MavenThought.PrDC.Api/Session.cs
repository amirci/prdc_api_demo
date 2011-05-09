namespace MavenThought.PrDC.Api
{
    public class Session
    {
        public virtual string Title { get; set; }

        public virtual string Abstract { get; set; }

        public virtual string Style { get; set; }

        public virtual string Presenter { get; set; }

        public virtual string Track { get; set; }

        public virtual int Year { get; set; }

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