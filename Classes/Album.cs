namespace AlbumSplitter.Classes {

    /// <summary>Holds a musical Album</summary>
    public class Album {

        /// <summary>Title of the Album</summary>
        public string Title { get; set; } = "";

        /// <summary>Artist of the Album</summary>
        public string Artist { get; set; } = "";

        /// <summary>Year the album was produced</summary>
        public string Year { get; set; } = "";

        /// <summary>Genre of the album</summary>
        public string Genre { get; set; } = "";

        /// <summary>Cover art for this album</summary>
        public byte[]? CoverArt { get; set; } = null;

        /// <summary>List of all tracks in this album</summary>
        private readonly HashSet<Track> Tracks = new();

        /// <summary>Number of tracks in the album</summary>
        public int TrackCount => Tracks.Count;

        /// <summary>List of tracks ordered by track number</summary>
        public List<Track> Tracklist => Tracks.OrderBy(A => A.Number).ToList();

        /// <summary></summary>
        /// <param name="Track"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddTrack(Track Track) {

            if (Track.Number <= 0) {
                throw new ArgumentException("Track number has to be at least 0");
            }

            Tracks.Add(Track);
        
        }

        /// <summary>Updates a track in the hashset</summary>
        /// <param name="Number"></param>
        /// <param name="Track"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateTrack(int Number, Track Track) {
            
            if (Track.Number <= 0 || Number <= 0) {
                throw new ArgumentException("Track number has to be at least 0");
            }

            //Remove the current track
            if (!Tracks.Any(T => T.Number == Number)) { throw new ArgumentException("Track with given number does not exist"); }

            Track? ExchangedTrack = null;

            //If the Number does not match, assume there's been an exchange
            if (Number != Track.Number) { 
                ExchangedTrack = Tracks.FirstOrDefault(A=>A.Number==Track.Number);

                //We don't need to check if it actually exists because if it doesn't, removeWhere does nothing, and we act as if we don't need to fix it.

                //Remove the track
                RemoveTrack(Track.Number);

                //All we need to do is check here
                if (ExchangedTrack is not null) { ExchangedTrack.Number = Number; }
            }

            //Now then let's update the track
            RemoveTrack(Number);
            Tracks.Add(Track);
            if (ExchangedTrack is not null) { Tracks.Add(ExchangedTrack); }
        }

        /// <summary>Removes a track from the tracklist with given number</summary>
        /// <param name="Number"></param>
        public void RemoveTrack(int Number) => _ = Tracks.RemoveWhere(A => A.Number == Number);

        /// <summary>Clears all tracks</summary>
        public void ClearTracks() => Tracks.Clear();

        /// <summary>Verifies Track number continutiy (that all tracks from the maximum track number to 1 exist)</summary>
        /// <returns></returns>
        public bool VerifyTrackNumberContinuity() {

            if (Tracks.Count == 0) { return true; }

            //Get the maximum track number
            int MaxTrack = Tracks.Max(A => A.Number);
            for (int i = MaxTrack-1; i > 0; i--) {
                if(!Tracks.Any(A => A.Number == i)) { return false; }
            }

            return true;
        
        }
        
        /// <summary>Verifies Timing Continuity (That all tracks from the maximum track to 1 are continuous in timing</summary>
        /// <returns></returns>
        public bool VerifyTimingContinuity() {

            if (Tracks.Count == 0) { return true; }

            //Do we assume track continuity by number or track continuity with...
            //Let's assume with number.
            int MaxTrack = Tracks.Max(A => A.Number);
            Timing.Timecode LStart = Tracks.First(A => A.Number == MaxTrack).Timing.Start;

            for (int i = MaxTrack - 1; i > 0; i--) {
                Timing T = Tracks.First(A => A.Number == i).Timing;
                if (T.End!=LStart) { return false; }
                LStart = T.Start;
            }

            return true;

        }
    }
}
