namespace MavenThought.PrDC.Api
{
    /// <summary>
    /// Base implementation for track
    /// </summary>
    public class Track : ITrack
    {
        private string _name;

        public string Name
        {
            get { return _name ?? this.Key; }
        
            set { _name = value; }
        }

        public int Id { get; set; }

        public string Key { get; set; }

        public int NumberOfSessions { get; set; }

        public bool Category { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Track;

            return other != null && other.Key == this.Key;
        }

        public override int GetHashCode()
        {
            return this.Key.GetHashCode();
        }
    }
}