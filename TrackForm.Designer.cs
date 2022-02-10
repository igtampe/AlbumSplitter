namespace AlbumSplitter {
    partial class TrackForm {
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
            this.OKBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.TrackGroupBox = new System.Windows.Forms.GroupBox();
            this.TrackTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.TrackTitleBox = new System.Windows.Forms.TextBox();
            this.TrackArtistBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StartTimecodeBox = new System.Windows.Forms.TextBox();
            this.EndTimeCodeBox = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.TrackNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MainTableLayoutPanel.SuspendLayout();
            this.TrackGroupBox.SuspendLayout();
            this.TrackTableLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 3;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.Controls.Add(this.OKBTN, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.CancelBTN, 2, 1);
            this.MainTableLayoutPanel.Controls.Add(this.TrackGroupBox, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(298, 232);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // OKBTN
            // 
            this.OKBTN.Location = new System.Drawing.Point(127, 194);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(75, 23);
            this.OKBTN.TabIndex = 0;
            this.OKBTN.Text = "OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(208, 194);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // TrackGroupBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.TrackGroupBox, 3);
            this.TrackGroupBox.Controls.Add(this.TrackTableLayoutPanel);
            this.TrackGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackGroupBox.Location = new System.Drawing.Point(3, 3);
            this.TrackGroupBox.Name = "TrackGroupBox";
            this.TrackGroupBox.Size = new System.Drawing.Size(292, 185);
            this.TrackGroupBox.TabIndex = 2;
            this.TrackGroupBox.TabStop = false;
            this.TrackGroupBox.Text = "Track Information";
            // 
            // TrackTableLayoutPanel
            // 
            this.TrackTableLayoutPanel.ColumnCount = 2;
            this.TrackTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TrackTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrackTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.TrackTableLayoutPanel.Controls.Add(this.ArtistLabel, 0, 1);
            this.TrackTableLayoutPanel.Controls.Add(this.TrackTitleBox, 1, 0);
            this.TrackTableLayoutPanel.Controls.Add(this.TrackArtistBox, 1, 1);
            this.TrackTableLayoutPanel.Controls.Add(this.NumberLabel, 0, 2);
            this.TrackTableLayoutPanel.Controls.Add(this.groupBox1, 0, 3);
            this.TrackTableLayoutPanel.Controls.Add(this.TrackNumUpDown, 1, 2);
            this.TrackTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.TrackTableLayoutPanel.Name = "TrackTableLayoutPanel";
            this.TrackTableLayoutPanel.RowCount = 4;
            this.TrackTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrackTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrackTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrackTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrackTableLayoutPanel.Size = new System.Drawing.Size(286, 163);
            this.TrackTableLayoutPanel.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(29, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(3, 29);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(35, 15);
            this.ArtistLabel.TabIndex = 1;
            this.ArtistLabel.Text = "Artist";
            // 
            // TrackTitleBox
            // 
            this.TrackTitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackTitleBox.Location = new System.Drawing.Point(60, 3);
            this.TrackTitleBox.Name = "TrackTitleBox";
            this.TrackTitleBox.Size = new System.Drawing.Size(223, 23);
            this.TrackTitleBox.TabIndex = 2;
            // 
            // TrackArtistBox
            // 
            this.TrackArtistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackArtistBox.Location = new System.Drawing.Point(60, 32);
            this.TrackArtistBox.Name = "TrackArtistBox";
            this.TrackArtistBox.Size = new System.Drawing.Size(223, 23);
            this.TrackArtistBox.TabIndex = 3;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(3, 58);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(51, 15);
            this.NumberLabel.TabIndex = 5;
            this.NumberLabel.Text = "Number";
            // 
            // groupBox1
            // 
            this.TrackTableLayoutPanel.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timing";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StartTimecodeBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EndTimeCodeBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StartTimecodeBox
            // 
            this.StartTimecodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartTimecodeBox.Location = new System.Drawing.Point(3, 18);
            this.StartTimecodeBox.Name = "StartTimecodeBox";
            this.StartTimecodeBox.PlaceholderText = "hh:mm:ss.mmm";
            this.StartTimecodeBox.Size = new System.Drawing.Size(131, 23);
            this.StartTimecodeBox.TabIndex = 0;
            // 
            // EndTimeCodeBox
            // 
            this.EndTimeCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimeCodeBox.Location = new System.Drawing.Point(140, 18);
            this.EndTimeCodeBox.Name = "EndTimeCodeBox";
            this.EndTimeCodeBox.PlaceholderText = "hh:mm:ss.mmm";
            this.EndTimeCodeBox.Size = new System.Drawing.Size(131, 23);
            this.EndTimeCodeBox.TabIndex = 1;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(3, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(31, 15);
            this.StartLabel.TabIndex = 2;
            this.StartLabel.Text = "Start";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(140, 0);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(27, 15);
            this.EndLabel.TabIndex = 3;
            this.EndLabel.Text = "End";
            // 
            // TrackNumUpDown
            // 
            this.TrackNumUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackNumUpDown.Location = new System.Drawing.Point(60, 61);
            this.TrackNumUpDown.Name = "TrackNumUpDown";
            this.TrackNumUpDown.Size = new System.Drawing.Size(223, 23);
            this.TrackNumUpDown.TabIndex = 7;
            // 
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 232);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track Editor";
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.TrackGroupBox.ResumeLayout(false);
            this.TrackTableLayoutPanel.ResumeLayout(false);
            this.TrackTableLayoutPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Button OKBTN;
        private Button CancelBTN;
        private GroupBox TrackGroupBox;
        private TableLayoutPanel TrackTableLayoutPanel;
        private Label TitleLabel;
        private Label ArtistLabel;
        private TextBox TrackTitleBox;
        private TextBox TrackArtistBox;
        private Label NumberLabel;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox StartTimecodeBox;
        private TextBox EndTimeCodeBox;
        private Label StartLabel;
        private Label EndLabel;
        private NumericUpDown TrackNumUpDown;
    }
}