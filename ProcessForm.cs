using AlbumSplitter.Classes;
using System.Diagnostics;
using System.Text;
using TagLib;

namespace AlbumSplitter {
    public partial class ProcessForm : Form {
        readonly string FFMpeg;
        readonly string Input;
        readonly Album MyAlbum;

        bool InProgress = false;
        bool CancelPending = false;

        public ProcessForm(Album A, string Input, string FFMpeg) {
            InitializeComponent();
            this.Input = Input;
            this.FFMpeg = FFMpeg;
            MyAlbum = A;
        }

        private void TheButton_Click(object sender, EventArgs e) {

            if (!InProgress) { Close(); }
            if (!CancelPending) { 
                CancelPending = true;
                TheButton.Enabled = false;
            }
        }

        private async void ProcessForm_Shown(object sender, EventArgs e) {

            try {
                int Result = await Split();
                InProgress = false;

                pictureBox1.Image = Result == 0 ? Properties.Resources.Checkmark : Properties.Resources.X;
                TheButton.Enabled = true;
                TheButton.Text = "OK";

            } catch (Exception) {
                InProgress = false;
                pictureBox1.Image = Properties.Resources.X;
                return;
            } finally {
                TheButton.Enabled = true;
                TheButton.Text = "OK";
            }
        }

        private async Task<int> Split() {

            InProgress = true;

            //Now we do the do:
            TitleLabel.Text =$"Splitting {MyAlbum.Title}";
            OverallProgressBar.Value = 0;
            TaskProgressBar.Value = 0;
            OverallStatusLabel.Text = "Splitting tracks";

            TaskStatusLabel.Text = "Getting Tracklist";
            List<Track> Tracklist = await Task.Run(() => MyAlbum.Tracklist);

            double PerTrackIncrement = 100.0 / (Tracklist.Count+0.0);

            double OverallProgress = 0.0;
            double TaskProgress = 0.0;

            string indir = Path.GetDirectoryName(Input) ?? "";
            string OutputDir = Path.Combine(indir, $"{MyAlbum.Artist} - {MyAlbum.Title}");
            if (!Directory.Exists(OutputDir)) { Directory.CreateDirectory(OutputDir); }

            //Do the thing
            foreach (Track T in Tracklist) {

                TaskStatusLabel.Text = $"Splitting {T.Title}";
                DetailsTextBox.AppendText($"Splitting {T.Title}" + Environment.NewLine);

                string Args = $"-ss {T.Timing.Start.TotalMiliseconds}ms -i \"{Input}\" -t {T.Timing.Duration().TotalMiliseconds}ms \"{OutputDir}\\{T.Number} {T.Title}.mp3\"";

                ProcessStartInfo PSI = new() {
                    CreateNoWindow = true,
                    FileName = FFMpeg,
                    Arguments = Args,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    StandardOutputEncoding = Encoding.ASCII,
                };

                DetailsTextBox.AppendText($"Running {FFMpeg} {Args}");

                Process P = new();

                P.StartInfo = PSI;
                P.OutputDataReceived += P_OutputDataReceived;
                P.ErrorDataReceived += P_OutputDataReceived;

                P.Start();
                
                P.BeginOutputReadLine();
                P.BeginErrorReadLine();
                await P.WaitForExitAsync();

                if (CancelPending) {
                    TitleLabel.Text = "Cancelled!";

                    return -1;
                }

                if (P.ExitCode != 0) {
                    TitleLabel.Text = "Split failed";

                    return P.ExitCode;
                }

                TaskProgressBar.Value = Convert.ToInt32(TaskProgress += PerTrackIncrement);
                OverallProgressBar.Value = Convert.ToInt32(OverallProgress += PerTrackIncrement / 2);

            }

            OverallProgressBar.Value = Convert.ToInt32(OverallProgress = 50);
            TaskProgressBar.Value = Convert.ToInt32(TaskProgress = 0);

            OverallStatusLabel.Text = "Ensuring Cover is Jpeg";
            DetailsTextBox.AppendText($"Converting Image to JPEG (if it exists)" + Environment.NewLine);
            byte[]? imageBytes = await Task.Run(()=> ImageBytesToJpegImageBytes(MyAlbum.CoverArt));

            TagLib.Id3v2.AttachmentFrame cover = new() {
                Type = PictureType.FrontCover,
                Description = "Cover",
                MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
                Data = imageBytes,
                TextEncoding = StringType.UTF16
            };

            OverallStatusLabel.Text = "Writing Metadata";            

            //Now let's go ahead and set the data
            foreach (Track T in Tracklist) {

                TaskStatusLabel.Text = $"Setting Metadata for {T.Title}";
                DetailsTextBox.AppendText($"Setting Metadata for {T.Title}" + Environment.NewLine);

                TagLib.File TF = TagLib.File.Create($"{OutputDir}\\{T.Number} {T.Title}.mp3");
                TF.Tag.Title= T.Title;
                TF.Tag.Album = MyAlbum.Title;
                TF.Tag.Performers = new List<string>(){ T.Artist }.ToArray();
                TF.Tag.AlbumArtists= new List<string>() { MyAlbum.Artist }.ToArray();
                TF.Tag.Genres = new List<string>() { MyAlbum.Genre }.ToArray();
                TF.Tag.Track = Convert.ToUInt32(T.Number);
                TF.Tag.Year = Convert.ToUInt32(MyAlbum.Year);

                //Load the image
                if (imageBytes is not null) { TF.Tag.Pictures = new IPicture[] { cover }; }

                if (CancelPending) {
                    TitleLabel.Text = "Cancelled!";

                    return -1;
                }

                await Task.Run(() => TF.Save());

                TaskProgressBar.Value = Convert.ToInt32(TaskProgress += PerTrackIncrement);
                OverallProgressBar.Value = Convert.ToInt32(OverallProgress += PerTrackIncrement / 2);

            }

            OverallStatusLabel.Text = "Wrapping up";
            TaskStatusLabel.Text = "";

            if (imageBytes is not null) {
                DetailsTextBox.AppendText($"Writing Cover Jpeg" + Environment.NewLine);
                await System.IO.File.WriteAllBytesAsync($"{OutputDir}\\Cover.jpg",imageBytes); 
            }

            OverallStatusLabel.Text = "";
            TitleLabel.Text = "Finished!";

            return 0;
        
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e) => AppendDetailsText(e.Data + Environment.NewLine ?? "");

        private void AppendDetailsText(string Text) => _ = Invoke(new MethodInvoker(delegate () { DetailsTextBox.AppendText(Text); }));

        private static byte[]? ImageBytesToJpegImageBytes(byte[]? Bytes) {
            if (Bytes is null) { return null; }

            using MemoryStream ReadMS = new(Bytes);
            using MemoryStream WriteMS = new();
            Image E = Image.FromStream(ReadMS);
            E.Save(WriteMS, System.Drawing.Imaging.ImageFormat.Jpeg);
            return WriteMS.ToArray();
        }

        private void ProcessForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = InProgress;

    }
}
