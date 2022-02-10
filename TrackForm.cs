using AlbumSplitter.Classes;

namespace AlbumSplitter {
    public partial class TrackForm : Form {

        public Track Track { get; set; }

        public TrackForm(Track T) {
            InitializeComponent();
            TrackTitleBox.Text = T.Title;
            TrackArtistBox.Text = T.Artist;
            Track = T;
            TrackNumUpDown.Value = T.Number;
            StartTimecodeBox.Text = T.Timing.Start.ToString();
            EndTimeCodeBox.Text = T.Timing.End.ToString();
        }

        private void OKBTN_Click(object sender, EventArgs e) {
            Timing.Timecode Start ;
            Timing.Timecode End;

            //Check the timings.
            try {
                Start = Timing.Timecode.FromString(StartTimecodeBox.Text);
                End = Timing.Timecode.FromString(EndTimeCodeBox.Text);

            } catch (Exception E) {
                MessageBox.Show($"Could not parse Timecodes. {E.Message}.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Track.Title = TrackTitleBox.Text;
            Track.Artist = TrackArtistBox.Text;
            Track.Number = Convert.ToInt32(TrackNumUpDown.Value);
            Track.Timing = new(Start, End);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e) => Close();
    }
}
