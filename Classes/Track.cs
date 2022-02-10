namespace AlbumSplitter.Classes {
    public class Track {

        public string Title { get; set; } = "";

        /// <summary>individual track aritst</summary>
        private string artist = "";

        /// <summary>Artist of this track. If none is set, defaults to the album's artist</summary>
        public string Artist { 
            get => artist == "" ? Album?.Artist ?? "" : artist; 
            set => artist = value; 
        }

        /// <summary>Number of this track</summary>
        public int Number { get; set; } = 0;

        /// <summary>Album this track belongs to</summary>
        public Album? Album { get; set; }

        /// <summary>Timing of this track</summary>
        public Timing Timing { get; set; } = new(new(0), new(0));

    }
}
