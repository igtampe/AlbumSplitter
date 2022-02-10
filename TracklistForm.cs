using AlbumSplitter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumSplitter {
    public partial class TracklistForm : Form {

        public List<string> Names { get; } = new List<string>();
        readonly int Tracks;

        public TracklistForm(List<Track> Tracks) {
            InitializeComponent();
            this.Tracks = Tracks.Count;
            
            foreach (Track T in Tracks) { TracklistBox.AppendText($"{T.Timing.Start} {T.Number} - {T.Title}{Environment.NewLine}"); }
        }

        private void TracklistBox_Leave(object sender, EventArgs e) {
            Names.Clear();

            foreach (string Line in TracklistBox.Lines) {

                var X = Line.SkipWhile(A=>!char.IsLetter(A)).TakeWhile(A => char.IsLetter(A) || A == ' ');
                var TrackName = new string( X.ToArray()).TrimStart().TrimEnd();
                Names.Add(TrackName);
            }

            PopulateListview();

        }

        private void PopulateListview() { 
        
            listView1.Items.Clear();
            for (int i = 0; i < Tracks; i++) {
                ListViewItem LVI = new(i+1 + "");
                LVI.SubItems.Add(Names.ElementAtOrDefault(i) ?? "");
                listView1.Items.Add(LVI);
            }
        }

        private void OKBTN_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e) => Close();
    }
}
