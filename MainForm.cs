using AlbumSplitter.Classes;

namespace AlbumSplitter {
    public partial class MainForm : Form {
        readonly Album MyAlbum = new();
        List<Track> DisplayedTracks = new();

        string Input = "";
        string FFMpeg = "ffmpeg";

        public MainForm() { 
            InitializeComponent();
            PopulateListview();
        }

        private async void AlbumPictureBox_Click(object sender, EventArgs e) {
            if (PictureFileDialog.ShowDialog() != DialogResult.OK) { return; }

            byte[] Image = await File.ReadAllBytesAsync(PictureFileDialog.FileName);

            MyAlbum.CoverArt = Image;
            using MemoryStream MS = new(Image);

            AlbumPictureBox.Image = System.Drawing.Image.FromStream(MS);

        }

        private void AlbumTitleBox_TextChanged(object sender, EventArgs e) => MyAlbum.Title = AlbumTitleBox.Text;

        private void AlbumArtistBox_TextChanged(object sender, EventArgs e) => MyAlbum.Artist = AlbumArtistBox.Text;

        private void AlbumYearBox_TextChanged(object sender, EventArgs e) => MyAlbum.Year = AlbumYearBox.Text;

        private void AlbumGenreBox_TextChanged(object sender, EventArgs e) => MyAlbum.Genre = AlbumGenreBox.Text;

        private void TracksListview_DoubleClick(object sender, EventArgs e) => ModifyTrackToolStripMenuItem_Click(sender, e);

        private void TrackContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {

            int Index = SelectedIndex();
            modifyTrackToolStripMenuItem.Enabled= Index >= 0;
            removeTrackToolStripMenuItem.Enabled= Index >= 0;

        }

        private void AddTrackToolStripMenuItem_Click(object sender, EventArgs e) {

            Track? LT = DisplayedTracks.Count > 0 ? DisplayedTracks.Last() : null;

            Track T = new() {
                Album = MyAlbum,
                Number = LT?.Number + 1 ?? 1,
                Timing = new(LT?.Timing.End ?? new(0),LT?.Timing.End ?? new(0)),
            };

            TrackForm TForm = new(T);
            if (TForm.ShowDialog() == DialogResult.OK) {
                MyAlbum.AddTrack(TForm.Track);
                PopulateListview();
            }
        }

        private void ModifyTrackToolStripMenuItem_Click(object sender, EventArgs e) {
            int Index = SelectedIndex();
            if(Index < 0) { return; }

            Track T = DisplayedTracks[Index];
            
            TrackForm TForm = new(T);
            if (TForm.ShowDialog() == DialogResult.OK) {
                //MyAlbum.UpdateTrack(Index+1,TForm.Track); //for some reason this isn't.... necessary?
                PopulateListview();
            }
        }

        private void RemoveTrackToolStripMenuItem_Click(object sender, EventArgs e) {
            int Index = SelectedIndex();
            if (Index < 0 ||
                !AreYouSure($"Are you sure you want to remove track {Index+1}?")) { return; }

            MyAlbum.RemoveTrack(Index+1);
            PopulateListview();
        }

        private void ClearTracksToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!AreYouSure($"Are you sure you want to remove all tracks from this album?")) { return; }
            MyAlbum.ClearTracks();
            PopulateListview();
        }

        private void InputFileBox_TextChanged(object sender, EventArgs e) => Input = InputFileBox.Text;

        private void MP3SpltBox_TextChanged(object sender, EventArgs e) => FFMpeg = MP3SpltBox.Text;

        private void BrowseInputButton_Click(object sender, EventArgs e) {
            if (AlbumFileDialog.ShowDialog() != DialogResult.OK) { return; }
            InputFileBox.Text=AlbumFileDialog.FileName;
        }

        private void BrowseMp3spltButton_Click(object sender, EventArgs e) {
            if (Mp3SpltFileDialog.ShowDialog() != DialogResult.OK) { return; }
            MP3SpltBox.Text = Mp3SpltFileDialog.FileName;
        }

        private void StartButton_Click(object sender, EventArgs e) {

            if (MyAlbum.TrackCount == 0) {
                Error("Cannot split an empty album. Add some tracks!");
                return;
            };

            if (!File.Exists(Input)) {
                Error($"Input file {Input} doesn't exist!");
                return;
            }

            if (!MyAlbum.VerifyTrackNumberContinuity()
                && !AreYouSure("This album doesn't seem to have Track Number Continuity (Some tracks appear to be missing). Are you sure you want to split?", MessageBoxIcon.Warning)) {
                return;
            }

            if (!MyAlbum.VerifyTimingContinuity()
                && !AreYouSure("This album doesn't seem to have Timing continuity (There's time gaps between some tracks). Are you sure you want to split?", MessageBoxIcon.Warning)) {
                return;
            }

            new ProcessForm(MyAlbum, Input, FFMpeg).ShowDialog();

        }

        private void detectTracksToolStripMenuItem_Click(object sender, EventArgs e) {

            if (!File.Exists(Input)) {
                Error($"Input file {Input} doesn't exist!");
                return;
            }

            SilenceDetectForm SDF = new(Input, FFMpeg);
            if (SDF.ShowDialog() == DialogResult.OK) {

                //Add everything in the tracklist
                foreach (Track T in SDF.Tracklist) {
                    T.Album = MyAlbum;
                    MyAlbum.AddTrack(T);
                }

                PopulateListview();
            }
        }

        private void PopulateListview() {

            //Clear the Displayed Tracks
            DisplayedTracks.Clear();
            TracksListview.Items.Clear();

            //Update
            DisplayedTracks = MyAlbum.Tracklist;

            //Actually display it
            foreach (Track T in DisplayedTracks) {
                ListViewItem LVI = new() {
                    Text = T.Number + ""
                };

                LVI.SubItems.Add(T.Title);
                LVI.SubItems.Add(T.Timing.Start.ToString());
                LVI.SubItems.Add(T.Timing.End.ToString());
                LVI.SubItems.Add(T.Timing.Duration().ToString());
                TracksListview.Items.Add(LVI);
            }
        }

        private int SelectedIndex() => TracksListview.SelectedIndices.Count > 0 ? TracksListview.SelectedIndices[0] : -1;

        private static void Error(string Error) 
            => MessageBox.Show($"{Error}", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private static bool AreYouSure(string Action, MessageBoxIcon Icon = MessageBoxIcon.Question) 
            => MessageBox.Show($"{Action}", "Are you sure?", MessageBoxButtons.YesNo, Icon) == DialogResult.Yes;

    }
}