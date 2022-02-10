using AlbumSplitter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumSplitter {
    public partial class SilenceDetectForm : Form {

        readonly string Input, FFMpeg;
        readonly List<string> Output = new();
        public List<Track> Tracklist { get; private set; } = new();
        readonly List<Timing> Silences = new();
        
        string OutputString = "";

        public SilenceDetectForm(string Input, string FFMpeg) {
            InitializeComponent();
            this.FFMpeg = FFMpeg;
            this.Input = Input;
        }

        private void OKButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBTN_Click(object sender, EventArgs e) => Close();

        private async void ExecuteSearchButton_Click(object sender, EventArgs e) {
            Enabled = false;
            try { await SilenceDetect(); } catch (Exception E) { 
                Error($"Could not detect silence: {E.Message}");
                
            }
            Enabled = true;
        }

        private async Task<int> SilenceDetect() {
            //Do the thing with the thing
            string Args = $"-i \"{Input}\" -af silencedetect=n={SilencedBUpDown.Value}dB:d={SilenceTimeNumUpDown.Value} -f null -";

            Enabled = false;
            Output.Clear();
            Silences.Clear();
            Tracklist.Clear();
            TracksListView.Items.Clear();
            OutputString = "";
            
            ProcessStartInfo PSI = new() {
                CreateNoWindow = true,
                FileName = FFMpeg,
                Arguments = Args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                StandardOutputEncoding = Encoding.ASCII,
            };

            Process P = new();

            P.StartInfo = PSI;
            P.OutputDataReceived += P_OutputDataReceived;
            P.ErrorDataReceived += P_OutputDataReceived;

            P.Start();

            P.BeginOutputReadLine();
            P.BeginErrorReadLine();
            await P.WaitForExitAsync();

            if (P.ExitCode != 0) {
                Error("An error occurred while SilenceDetect-ing");
                Error($">{FFMpeg} {Args}{Environment.NewLine}{Environment.NewLine}{OutputString}");
                return P.ExitCode;
            }

            if (Output.Count == 0) {
                Error("There is no (detectable) silence in this track.");
                Error($">{FFMpeg} {Args}{Environment.NewLine}{Environment.NewLine}{OutputString}");
                return -2;
            }

            double? Start = null;
            double? End = null;

            //Parse the silences
            for (int i = 0; i < Output.Count; i++) {

                int CutIndex = Output[i].IndexOf(']');
                if (CutIndex == -1) { continue; }
                string TempOutput = Output[i][(CutIndex + 2)..];
                if (TempOutput.StartsWith("silence_start")) {

                    TempOutput = TempOutput.Replace("silence_start:", "").TrimStart().TrimEnd();
                    Start = TempOutput.Contains('x') ? 0 : double.Parse(TempOutput) * 1000;

                } else if (TempOutput.StartsWith("silence_end")) {
                    TempOutput = TempOutput.Split('|')[0];
                    TempOutput = TempOutput.Replace("silence_end:", "").TrimStart().TrimEnd();
                    End = TempOutput.Contains('x') ? 0 : double.Parse(TempOutput) * 1000;
                }

                if (Start is not null && End is not null) {
                    //We have a pair
                    Silences.Add(new(new(Convert.ToInt32(Start)), new(Convert.ToInt32(End))));
                    End = null;
                    Start = null;
                }
            }

            if (Silences.Count == 0) {
                Error("No silence timings were generated from the output");
                Error($">{FFMpeg} {Args}{Environment.NewLine}{Environment.NewLine}{OutputString}");
                return -2;
            }

            int CurrentTrack = 1;

            //Add the first track (if one exists before silenec
            if (Silences[0].Start.TotalMiliseconds != 0) {

                Tracklist.Add(new() {
                    Number = CurrentTrack,
                    Timing = new(new(0), new(Silences[0].Start.TotalMiliseconds))
                });

                CurrentTrack++;

            }

            //Parse the tracks
            for (int i = 1; i < Silences.Count; i++) {
                Tracklist.Add(new() {
                    Number = CurrentTrack,
                    Timing = new(new(Silences[i - 1].End.TotalMiliseconds), new(Silences[i].Start.TotalMiliseconds))
                });
                CurrentTrack++;
            }

            //Add the last track
            Tracklist.Add(new() {
                Number = CurrentTrack,
                Timing = new(new(Silences[^1].End.TotalMiliseconds), new(23, 59, 59, 999))
            });

            //Lastly populate the listview
            foreach (Track T in Tracklist) {

                ListViewItem LVI = new(T.Number.ToString());
                LVI.SubItems.Add(T.Timing.Start.ToString());
                LVI.SubItems.Add(T.Timing.End.ToString());
                LVI.SubItems.Add(T.Timing.Duration().ToString());

                TracksListView.Items.Add(LVI);

            }

            return 0;

        }

        private async void TracksListView_DoubleClick(object sender, EventArgs e) {
            
            int Index = SelectedIndex();
            if (Index == -1) { return; }
            Track T = Tracklist[Index];

            Enabled = false;

            //Generate a small preview of 30 seconds.
            if (File.Exists("Temp.mp3")) { File.Delete("Temp.mp3"); }
            string Args = $"-ss {T.Timing.Start.TotalMiliseconds}ms -i \"{Input}\" -t 0:0:10 \"Temp.mp3\"";

            ProcessStartInfo PSI = new() {
                CreateNoWindow = true,
                FileName = FFMpeg,
                Arguments = Args,
                UseShellExecute = false,
            };

            Process P = new();
            P.StartInfo = PSI;
            P.Start();

            await P.WaitForExitAsync();
            Enabled = true;

            if (P.ExitCode != 0) {
                Error("An error occurred while generating a preview");
                return;
            }

            if (!File.Exists("Temp.mp3")) {
                Error("Wait... where's the preview?");
                return;
            }

            try {
                Process.Start("explorer","temp.mp3");
            } catch (Exception) { }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            OutputString += e.Data + Environment.NewLine;
            if (e.Data is not null && e.Data.Contains("silencedetect")) { Output.Add(e.Data); }
        }

        private static void Error(string Error)
            => MessageBox.Show($"{Error}", "Nope", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private int SelectedIndex() => TracksListView.SelectedIndices.Count > 0 ? TracksListView.SelectedIndices[0] : -1;

    }
}
