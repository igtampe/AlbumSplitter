namespace AlbumSplitter {
    partial class SilenceDetectForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.FoundTracksGroupbox = new System.Windows.Forms.GroupBox();
            this.TracksListView = new System.Windows.Forms.ListView();
            this.TrackNumberColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackStartColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackEndColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackDurationColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SilencedBUpDown = new System.Windows.Forms.NumericUpDown();
            this.SilenceTimeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExecuteSearchButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel.SuspendLayout();
            this.FoundTracksGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OptionsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilencedBUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilenceTimeNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 3;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.Controls.Add(this.OKButton, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.CancelBTN, 2, 2);
            this.MainTableLayoutPanel.Controls.Add(this.FoundTracksGroupbox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.groupBox1, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainTableLayoutPanel.RowCount = 3;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(500, 619);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(321, 573);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(402, 573);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // FoundTracksGroupbox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.FoundTracksGroupbox, 3);
            this.FoundTracksGroupbox.Controls.Add(this.TracksListView);
            this.FoundTracksGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoundTracksGroupbox.Location = new System.Drawing.Point(23, 23);
            this.FoundTracksGroupbox.Name = "FoundTracksGroupbox";
            this.FoundTracksGroupbox.Size = new System.Drawing.Size(454, 424);
            this.FoundTracksGroupbox.TabIndex = 2;
            this.FoundTracksGroupbox.TabStop = false;
            this.FoundTracksGroupbox.Text = "Found Tracks";
            // 
            // TracksListView
            // 
            this.TracksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackNumberColumnHeader,
            this.TrackStartColumnHeader,
            this.TrackEndColumnHeader,
            this.TrackDurationColumnHeader});
            this.TracksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TracksListView.FullRowSelect = true;
            this.TracksListView.Location = new System.Drawing.Point(3, 19);
            this.TracksListView.Name = "TracksListView";
            this.TracksListView.Size = new System.Drawing.Size(448, 402);
            this.TracksListView.TabIndex = 0;
            this.TracksListView.UseCompatibleStateImageBehavior = false;
            this.TracksListView.View = System.Windows.Forms.View.Details;
            this.TracksListView.DoubleClick += new System.EventHandler(this.TracksListView_DoubleClick);
            // 
            // TrackNumberColumnHeader
            // 
            this.TrackNumberColumnHeader.Text = "#";
            this.TrackNumberColumnHeader.Width = 40;
            // 
            // TrackStartColumnHeader
            // 
            this.TrackStartColumnHeader.Text = "Start";
            this.TrackStartColumnHeader.Width = 75;
            // 
            // TrackEndColumnHeader
            // 
            this.TrackEndColumnHeader.Text = "End";
            this.TrackEndColumnHeader.Width = 75;
            // 
            // TrackDurationColumnHeader
            // 
            this.TrackDurationColumnHeader.Text = "Duration";
            this.TrackDurationColumnHeader.Width = 75;
            // 
            // groupBox1
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.OptionsTableLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(23, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SilenceDetect Options";
            // 
            // OptionsTableLayoutPanel
            // 
            this.OptionsTableLayoutPanel.ColumnCount = 2;
            this.OptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OptionsTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.OptionsTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.OptionsTableLayoutPanel.Controls.Add(this.SilencedBUpDown, 1, 0);
            this.OptionsTableLayoutPanel.Controls.Add(this.SilenceTimeNumUpDown, 1, 1);
            this.OptionsTableLayoutPanel.Controls.Add(this.ExecuteSearchButton, 1, 2);
            this.OptionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.OptionsTableLayoutPanel.Name = "OptionsTableLayoutPanel";
            this.OptionsTableLayoutPanel.RowCount = 3;
            this.OptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OptionsTableLayoutPanel.Size = new System.Drawing.Size(448, 92);
            this.OptionsTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silence Noise Level (dB)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum Silence Time (s)";
            // 
            // SilencedBUpDown
            // 
            this.SilencedBUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.SilencedBUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SilencedBUpDown.Location = new System.Drawing.Point(154, 3);
            this.SilencedBUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SilencedBUpDown.Name = "SilencedBUpDown";
            this.SilencedBUpDown.Size = new System.Drawing.Size(291, 23);
            this.SilencedBUpDown.TabIndex = 2;
            this.SilencedBUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // SilenceTimeNumUpDown
            // 
            this.SilenceTimeNumUpDown.DecimalPlaces = 3;
            this.SilenceTimeNumUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SilenceTimeNumUpDown.Location = new System.Drawing.Point(154, 32);
            this.SilenceTimeNumUpDown.Name = "SilenceTimeNumUpDown";
            this.SilenceTimeNumUpDown.Size = new System.Drawing.Size(291, 23);
            this.SilenceTimeNumUpDown.TabIndex = 3;
            this.SilenceTimeNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // ExecuteSearchButton
            // 
            this.ExecuteSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteSearchButton.Location = new System.Drawing.Point(370, 61);
            this.ExecuteSearchButton.Name = "ExecuteSearchButton";
            this.ExecuteSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteSearchButton.TabIndex = 4;
            this.ExecuteSearchButton.Text = "Search";
            this.ExecuteSearchButton.UseVisualStyleBackColor = true;
            this.ExecuteSearchButton.Click += new System.EventHandler(this.ExecuteSearchButton_Click);
            // 
            // SilenceDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 619);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SilenceDetectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Silence Detective";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.FoundTracksGroupbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.OptionsTableLayoutPanel.ResumeLayout(false);
            this.OptionsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilencedBUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilenceTimeNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Button OKButton;
        private Button CancelBTN;
        private GroupBox FoundTracksGroupbox;
        private GroupBox groupBox1;
        private TableLayoutPanel OptionsTableLayoutPanel;
        private Label label1;
        private Label label2;
        private NumericUpDown SilencedBUpDown;
        private NumericUpDown SilenceTimeNumUpDown;
        private ListView TracksListView;
        private Button ExecuteSearchButton;
        private ColumnHeader TrackNumberColumnHeader;
        private ColumnHeader TrackStartColumnHeader;
        private ColumnHeader TrackEndColumnHeader;
        private ColumnHeader TrackDurationColumnHeader;
    }
}