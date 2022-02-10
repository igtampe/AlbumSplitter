namespace AlbumSplitter {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Chopo\'s Last Yelll",
            "00:00:00",
            "00:10:00"}, -1);
            this.AlbumGroupbox = new System.Windows.Forms.GroupBox();
            this.AlbumTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AlbumYearBox = new System.Windows.Forms.TextBox();
            this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumTitleBox = new System.Windows.Forms.TextBox();
            this.AlbumArtistBox = new System.Windows.Forms.TextBox();
            this.AlbumGenreBox = new System.Windows.Forms.TextBox();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TracksGroupbox = new System.Windows.Forms.GroupBox();
            this.TracksListview = new System.Windows.Forms.ListView();
            this.TrackNumberColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackTitleColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TimingStartColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TimingEndColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TimingDuritionColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DetectTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewEditTextTracklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BrowseMp3spltButton = new System.Windows.Forms.Button();
            this.Mp3SpltLabel = new System.Windows.Forms.Label();
            this.InputFileBox = new System.Windows.Forms.TextBox();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.BrowseInputButton = new System.Windows.Forms.Button();
            this.MP3SpltBox = new System.Windows.Forms.TextBox();
            this.ActionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.AlbumFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Mp3SpltFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AlbumGroupbox.SuspendLayout();
            this.AlbumTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            this.MainTableLayoutPanel.SuspendLayout();
            this.TracksGroupbox.SuspendLayout();
            this.TrackContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FileTableLayoutPanel.SuspendLayout();
            this.ActionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlbumGroupbox
            // 
            this.AlbumGroupbox.Controls.Add(this.AlbumTableLayoutPanel);
            this.AlbumGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumGroupbox.Location = new System.Drawing.Point(3, 3);
            this.AlbumGroupbox.Name = "AlbumGroupbox";
            this.AlbumGroupbox.Size = new System.Drawing.Size(445, 158);
            this.AlbumGroupbox.TabIndex = 0;
            this.AlbumGroupbox.TabStop = false;
            this.AlbumGroupbox.Text = "Album Data";
            // 
            // AlbumTableLayoutPanel
            // 
            this.AlbumTableLayoutPanel.ColumnCount = 3;
            this.AlbumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.AlbumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AlbumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AlbumTableLayoutPanel.Controls.Add(this.AlbumYearBox, 0, 2);
            this.AlbumTableLayoutPanel.Controls.Add(this.AlbumPictureBox, 0, 0);
            this.AlbumTableLayoutPanel.Controls.Add(this.AlbumTitleBox, 1, 0);
            this.AlbumTableLayoutPanel.Controls.Add(this.AlbumArtistBox, 1, 1);
            this.AlbumTableLayoutPanel.Controls.Add(this.AlbumGenreBox, 1, 2);
            this.AlbumTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.AlbumTableLayoutPanel.Name = "AlbumTableLayoutPanel";
            this.AlbumTableLayoutPanel.RowCount = 3;
            this.AlbumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AlbumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AlbumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlbumTableLayoutPanel.Size = new System.Drawing.Size(439, 136);
            this.AlbumTableLayoutPanel.TabIndex = 2;
            // 
            // AlbumYearBox
            // 
            this.AlbumYearBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumYearBox.Location = new System.Drawing.Point(134, 73);
            this.AlbumYearBox.Name = "AlbumYearBox";
            this.AlbumYearBox.PlaceholderText = "Album Year";
            this.AlbumYearBox.Size = new System.Drawing.Size(147, 23);
            this.AlbumYearBox.TabIndex = 3;
            this.AlbumYearBox.TextChanged += new System.EventHandler(this.AlbumYearBox_TextChanged);
            // 
            // AlbumPictureBox
            // 
            this.AlbumPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumPictureBox.Image = global::AlbumSplitter.Properties.Resources.AS;
            this.AlbumPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AlbumPictureBox.Name = "AlbumPictureBox";
            this.AlbumTableLayoutPanel.SetRowSpan(this.AlbumPictureBox, 3);
            this.AlbumPictureBox.Size = new System.Drawing.Size(125, 130);
            this.AlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumPictureBox.TabIndex = 0;
            this.AlbumPictureBox.TabStop = false;
            this.AlbumPictureBox.Click += new System.EventHandler(this.AlbumPictureBox_Click);
            // 
            // AlbumTitleBox
            // 
            this.AlbumTableLayoutPanel.SetColumnSpan(this.AlbumTitleBox, 2);
            this.AlbumTitleBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlbumTitleBox.Location = new System.Drawing.Point(134, 3);
            this.AlbumTitleBox.Name = "AlbumTitleBox";
            this.AlbumTitleBox.PlaceholderText = "Album Title";
            this.AlbumTitleBox.Size = new System.Drawing.Size(302, 35);
            this.AlbumTitleBox.TabIndex = 1;
            this.AlbumTitleBox.TextChanged += new System.EventHandler(this.AlbumTitleBox_TextChanged);
            // 
            // AlbumArtistBox
            // 
            this.AlbumTableLayoutPanel.SetColumnSpan(this.AlbumArtistBox, 2);
            this.AlbumArtistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumArtistBox.Location = new System.Drawing.Point(134, 44);
            this.AlbumArtistBox.Name = "AlbumArtistBox";
            this.AlbumArtistBox.PlaceholderText = "Album Artist";
            this.AlbumArtistBox.Size = new System.Drawing.Size(302, 23);
            this.AlbumArtistBox.TabIndex = 2;
            this.AlbumArtistBox.TextChanged += new System.EventHandler(this.AlbumArtistBox_TextChanged);
            // 
            // AlbumGenreBox
            // 
            this.AlbumGenreBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumGenreBox.Location = new System.Drawing.Point(287, 73);
            this.AlbumGenreBox.Name = "AlbumGenreBox";
            this.AlbumGenreBox.PlaceholderText = "Album Genre";
            this.AlbumGenreBox.Size = new System.Drawing.Size(149, 23);
            this.AlbumGenreBox.TabIndex = 4;
            this.AlbumGenreBox.TextChanged += new System.EventHandler(this.AlbumGenreBox_TextChanged);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.AlbumGroupbox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.TracksGroupbox, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.groupBox1, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.ActionsTableLayoutPanel, 0, 3);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 4;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(451, 587);
            this.MainTableLayoutPanel.TabIndex = 1;
            // 
            // TracksGroupbox
            // 
            this.TracksGroupbox.Controls.Add(this.TracksListview);
            this.TracksGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TracksGroupbox.Location = new System.Drawing.Point(3, 167);
            this.TracksGroupbox.Name = "TracksGroupbox";
            this.TracksGroupbox.Size = new System.Drawing.Size(445, 290);
            this.TracksGroupbox.TabIndex = 1;
            this.TracksGroupbox.TabStop = false;
            this.TracksGroupbox.Text = "Track Data";
            // 
            // TracksListview
            // 
            this.TracksListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackNumberColumnHeader,
            this.TrackTitleColumnHeader,
            this.TimingStartColumnHeader,
            this.TimingEndColumnHeader,
            this.TimingDuritionColumnHeader});
            this.TracksListview.ContextMenuStrip = this.TrackContextMenuStrip;
            this.TracksListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TracksListview.FullRowSelect = true;
            this.TracksListview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TracksListview.Location = new System.Drawing.Point(3, 19);
            this.TracksListview.Name = "TracksListview";
            this.TracksListview.Size = new System.Drawing.Size(439, 268);
            this.TracksListview.TabIndex = 0;
            this.TracksListview.UseCompatibleStateImageBehavior = false;
            this.TracksListview.View = System.Windows.Forms.View.Details;
            this.TracksListview.DoubleClick += new System.EventHandler(this.TracksListview_DoubleClick);
            // 
            // TrackNumberColumnHeader
            // 
            this.TrackNumberColumnHeader.Text = "#";
            this.TrackNumberColumnHeader.Width = 40;
            // 
            // TrackTitleColumnHeader
            // 
            this.TrackTitleColumnHeader.Text = "Title";
            this.TrackTitleColumnHeader.Width = 150;
            // 
            // TimingStartColumnHeader
            // 
            this.TimingStartColumnHeader.Text = "Start";
            this.TimingStartColumnHeader.Width = 75;
            // 
            // TimingEndColumnHeader
            // 
            this.TimingEndColumnHeader.Text = "End";
            this.TimingEndColumnHeader.Width = 75;
            // 
            // TimingDuritionColumnHeader
            // 
            this.TimingDuritionColumnHeader.Text = "Duration";
            this.TimingDuritionColumnHeader.Width = 75;
            // 
            // TrackContextMenuStrip
            // 
            this.TrackContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrackToolStripMenuItem,
            this.modifyTrackToolStripMenuItem,
            this.removeTrackToolStripMenuItem,
            this.toolStripSeparator1,
            this.DetectTracksToolStripMenuItem,
            this.ViewEditTextTracklistToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearTracksToolStripMenuItem});
            this.TrackContextMenuStrip.Name = "TrackContextMenuStrip";
            this.TrackContextMenuStrip.Size = new System.Drawing.Size(194, 148);
            this.TrackContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.TrackContextMenuStrip_Opening);
            // 
            // addTrackToolStripMenuItem
            // 
            this.addTrackToolStripMenuItem.Name = "addTrackToolStripMenuItem";
            this.addTrackToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addTrackToolStripMenuItem.Text = "Add Track";
            this.addTrackToolStripMenuItem.Click += new System.EventHandler(this.AddTrackToolStripMenuItem_Click);
            // 
            // modifyTrackToolStripMenuItem
            // 
            this.modifyTrackToolStripMenuItem.Name = "modifyTrackToolStripMenuItem";
            this.modifyTrackToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.modifyTrackToolStripMenuItem.Text = "Modify Track";
            this.modifyTrackToolStripMenuItem.Click += new System.EventHandler(this.ModifyTrackToolStripMenuItem_Click);
            // 
            // removeTrackToolStripMenuItem
            // 
            this.removeTrackToolStripMenuItem.Name = "removeTrackToolStripMenuItem";
            this.removeTrackToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeTrackToolStripMenuItem.Text = "Remove Track";
            this.removeTrackToolStripMenuItem.Click += new System.EventHandler(this.RemoveTrackToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // DetectTracksToolStripMenuItem
            // 
            this.DetectTracksToolStripMenuItem.Name = "DetectTracksToolStripMenuItem";
            this.DetectTracksToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.DetectTracksToolStripMenuItem.Text = "Detect Tracks";
            this.DetectTracksToolStripMenuItem.Click += new System.EventHandler(this.DetectTracksToolStripMenuItem_Click);
            // 
            // ViewEditTextTracklistToolStripMenuItem
            // 
            this.ViewEditTextTracklistToolStripMenuItem.Name = "ViewEditTextTracklistToolStripMenuItem";
            this.ViewEditTextTracklistToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ViewEditTextTracklistToolStripMenuItem.Text = "View/Edit Text Tracklist";
            this.ViewEditTextTracklistToolStripMenuItem.Click += new System.EventHandler(this.ViewEditTextTracklistToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // clearTracksToolStripMenuItem
            // 
            this.clearTracksToolStripMenuItem.Name = "clearTracksToolStripMenuItem";
            this.clearTracksToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clearTracksToolStripMenuItem.Text = "Clear Tracks";
            this.clearTracksToolStripMenuItem.Click += new System.EventHandler(this.ClearTracksToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileTableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // FileTableLayoutPanel
            // 
            this.FileTableLayoutPanel.ColumnCount = 3;
            this.FileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FileTableLayoutPanel.Controls.Add(this.BrowseMp3spltButton, 2, 2);
            this.FileTableLayoutPanel.Controls.Add(this.Mp3SpltLabel, 0, 2);
            this.FileTableLayoutPanel.Controls.Add(this.InputFileBox, 1, 0);
            this.FileTableLayoutPanel.Controls.Add(this.InputFileLabel, 0, 0);
            this.FileTableLayoutPanel.Controls.Add(this.BrowseInputButton, 2, 0);
            this.FileTableLayoutPanel.Controls.Add(this.MP3SpltBox, 1, 2);
            this.FileTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.FileTableLayoutPanel.Name = "FileTableLayoutPanel";
            this.FileTableLayoutPanel.RowCount = 3;
            this.FileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FileTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FileTableLayoutPanel.Size = new System.Drawing.Size(439, 59);
            this.FileTableLayoutPanel.TabIndex = 0;
            // 
            // BrowseMp3spltButton
            // 
            this.BrowseMp3spltButton.Location = new System.Drawing.Point(361, 32);
            this.BrowseMp3spltButton.Name = "BrowseMp3spltButton";
            this.BrowseMp3spltButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseMp3spltButton.TabIndex = 9;
            this.BrowseMp3spltButton.Text = "Browse";
            this.BrowseMp3spltButton.UseVisualStyleBackColor = true;
            this.BrowseMp3spltButton.Click += new System.EventHandler(this.BrowseMp3spltButton_Click);
            // 
            // Mp3SpltLabel
            // 
            this.Mp3SpltLabel.AutoSize = true;
            this.Mp3SpltLabel.Location = new System.Drawing.Point(3, 29);
            this.Mp3SpltLabel.Name = "Mp3SpltLabel";
            this.Mp3SpltLabel.Size = new System.Drawing.Size(50, 15);
            this.Mp3SpltLabel.TabIndex = 7;
            this.Mp3SpltLabel.Text = "FFMpeg";
            // 
            // InputFileBox
            // 
            this.InputFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFileBox.Location = new System.Drawing.Point(92, 3);
            this.InputFileBox.Name = "InputFileBox";
            this.InputFileBox.Size = new System.Drawing.Size(263, 23);
            this.InputFileBox.TabIndex = 0;
            this.InputFileBox.TextChanged += new System.EventHandler(this.InputFileBox_TextChanged);
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(3, 0);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(83, 15);
            this.InputFileLabel.TabIndex = 1;
            this.InputFileLabel.Text = "Input MP3 File";
            // 
            // BrowseInputButton
            // 
            this.BrowseInputButton.Location = new System.Drawing.Point(361, 3);
            this.BrowseInputButton.Name = "BrowseInputButton";
            this.BrowseInputButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseInputButton.TabIndex = 5;
            this.BrowseInputButton.Text = "Browse";
            this.BrowseInputButton.UseVisualStyleBackColor = true;
            this.BrowseInputButton.Click += new System.EventHandler(this.BrowseInputButton_Click);
            // 
            // MP3SpltBox
            // 
            this.MP3SpltBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MP3SpltBox.Location = new System.Drawing.Point(92, 32);
            this.MP3SpltBox.Name = "MP3SpltBox";
            this.MP3SpltBox.Size = new System.Drawing.Size(263, 23);
            this.MP3SpltBox.TabIndex = 8;
            this.MP3SpltBox.Text = "Ffmpeg";
            this.MP3SpltBox.TextChanged += new System.EventHandler(this.MP3SpltBox_TextChanged);
            // 
            // ActionsTableLayoutPanel
            // 
            this.ActionsTableLayoutPanel.ColumnCount = 2;
            this.ActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ActionsTableLayoutPanel.Controls.Add(this.StartButton, 1, 0);
            this.ActionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsTableLayoutPanel.Location = new System.Drawing.Point(3, 550);
            this.ActionsTableLayoutPanel.Name = "ActionsTableLayoutPanel";
            this.ActionsTableLayoutPanel.RowCount = 1;
            this.ActionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionsTableLayoutPanel.Size = new System.Drawing.Size(445, 34);
            this.ActionsTableLayoutPanel.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(363, 3);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 3, 7, 7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AlbumFileDialog
            // 
            this.AlbumFileDialog.DefaultExt = "mp3";
            this.AlbumFileDialog.FileName = "Album.mp3";
            this.AlbumFileDialog.Filter = "MPEG Files|*.mp3;*.m4a|All Files|*.*";
            this.AlbumFileDialog.Title = "Choose an album file";
            // 
            // OutputFolderDialog
            // 
            this.OutputFolderDialog.Description = "Select a folder to output the music files to";
            this.OutputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // PictureFileDialog
            // 
            this.PictureFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            this.PictureFileDialog.Title = "Pick an Album Cover picture ";
            // 
            // Mp3SpltFileDialog
            // 
            this.Mp3SpltFileDialog.DefaultExt = "exe";
            this.Mp3SpltFileDialog.Filter = "FFMpeg Executable |ffmpeg.exe";
            this.Mp3SpltFileDialog.Title = "Find ffmpeg Executable";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 587);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumSplitter";
            this.AlbumGroupbox.ResumeLayout(false);
            this.AlbumTableLayoutPanel.ResumeLayout(false);
            this.AlbumTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.TracksGroupbox.ResumeLayout(false);
            this.TrackContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.FileTableLayoutPanel.ResumeLayout(false);
            this.FileTableLayoutPanel.PerformLayout();
            this.ActionsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox AlbumGroupbox;
        private TextBox AlbumTitleBox;
        private PictureBox AlbumPictureBox;
        private TableLayoutPanel MainTableLayoutPanel;
        private TableLayoutPanel AlbumTableLayoutPanel;
        private TextBox AlbumArtistBox;
        private TextBox AlbumYearBox;
        private TextBox AlbumGenreBox;
        private GroupBox TracksGroupbox;
        private ListView TracksListview;
        private ColumnHeader TrackNumberColumnHeader;
        private ColumnHeader TrackTitleColumnHeader;
        private ColumnHeader TimingStartColumnHeader;
        private ColumnHeader TimingEndColumnHeader;
        private GroupBox groupBox1;
        private TableLayoutPanel FileTableLayoutPanel;
        private TextBox InputFileBox;
        private Label InputFileLabel;
        private Button BrowseInputButton;
        private TableLayoutPanel ActionsTableLayoutPanel;
        private Button StartButton;
        private OpenFileDialog AlbumFileDialog;
        private FolderBrowserDialog OutputFolderDialog;
        private ContextMenuStrip TrackContextMenuStrip;
        private ToolStripMenuItem addTrackToolStripMenuItem;
        private ToolStripMenuItem removeTrackToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem clearTracksToolStripMenuItem;
        private OpenFileDialog PictureFileDialog;
        private ToolStripMenuItem modifyTrackToolStripMenuItem;
        private Label Mp3SpltLabel;
        private Button BrowseMp3spltButton;
        private TextBox MP3SpltBox;
        private OpenFileDialog Mp3SpltFileDialog;
        private ColumnHeader TimingDuritionColumnHeader;
        private ToolStripMenuItem DetectTracksToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ViewEditTextTracklistToolStripMenuItem;
    }
}