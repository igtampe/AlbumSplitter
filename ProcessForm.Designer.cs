namespace AlbumSplitter {
    partial class ProcessForm {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OverallProgressBar = new System.Windows.Forms.ProgressBar();
            this.OverallStatusLabel = new System.Windows.Forms.Label();
            this.TaskProgressBar = new System.Windows.Forms.ProgressBar();
            this.TaskStatusLabel = new System.Windows.Forms.Label();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.TheButton = new System.Windows.Forms.Button();
            this.SplitBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.MainTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.TitleLabel, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.OverallProgressBar, 1, 2);
            this.MainTableLayoutPanel.Controls.Add(this.OverallStatusLabel, 1, 1);
            this.MainTableLayoutPanel.Controls.Add(this.TaskProgressBar, 1, 4);
            this.MainTableLayoutPanel.Controls.Add(this.TaskStatusLabel, 1, 3);
            this.MainTableLayoutPanel.Controls.Add(this.DetailsGroupBox, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.TheButton, 1, 6);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(15);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MainTableLayoutPanel.RowCount = 7;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(513, 353);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AlbumSplitter.Properties.Resources.Hourglass;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.MainTableLayoutPanel.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(125, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(151, 20);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(242, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Splitting {Album}";
            // 
            // OverallProgressBar
            // 
            this.OverallProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverallProgressBar.Location = new System.Drawing.Point(151, 87);
            this.OverallProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.OverallProgressBar.Name = "OverallProgressBar";
            this.OverallProgressBar.Size = new System.Drawing.Size(342, 23);
            this.OverallProgressBar.TabIndex = 3;
            // 
            // OverallStatusLabel
            // 
            this.OverallStatusLabel.AutoSize = true;
            this.OverallStatusLabel.Location = new System.Drawing.Point(151, 62);
            this.OverallStatusLabel.Margin = new System.Windows.Forms.Padding(5);
            this.OverallStatusLabel.Name = "OverallStatusLabel";
            this.OverallStatusLabel.Size = new System.Drawing.Size(86, 15);
            this.OverallStatusLabel.TabIndex = 2;
            this.OverallStatusLabel.Text = "Splitting Songs";
            // 
            // TaskProgressBar
            // 
            this.TaskProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskProgressBar.Location = new System.Drawing.Point(151, 145);
            this.TaskProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.TaskProgressBar.Name = "TaskProgressBar";
            this.TaskProgressBar.Size = new System.Drawing.Size(342, 23);
            this.TaskProgressBar.TabIndex = 4;
            // 
            // TaskStatusLabel
            // 
            this.TaskStatusLabel.AutoSize = true;
            this.TaskStatusLabel.Location = new System.Drawing.Point(151, 120);
            this.TaskStatusLabel.Margin = new System.Windows.Forms.Padding(5);
            this.TaskStatusLabel.Name = "TaskStatusLabel";
            this.TaskStatusLabel.Size = new System.Drawing.Size(89, 15);
            this.TaskStatusLabel.TabIndex = 5;
            this.TaskStatusLabel.Text = "Splitting {Track}";
            // 
            // DetailsGroupBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.DetailsGroupBox, 2);
            this.DetailsGroupBox.Controls.Add(this.DetailsTextBox);
            this.DetailsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroupBox.Location = new System.Drawing.Point(18, 176);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Size = new System.Drawing.Size(477, 130);
            this.DetailsGroupBox.TabIndex = 6;
            this.DetailsGroupBox.TabStop = false;
            this.DetailsGroupBox.Text = "Details";
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsTextBox.Location = new System.Drawing.Point(3, 19);
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.ReadOnly = true;
            this.DetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsTextBox.Size = new System.Drawing.Size(471, 108);
            this.DetailsTextBox.TabIndex = 0;
            // 
            // TheButton
            // 
            this.TheButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TheButton.Location = new System.Drawing.Point(420, 312);
            this.TheButton.Name = "TheButton";
            this.TheButton.Size = new System.Drawing.Size(75, 23);
            this.TheButton.TabIndex = 7;
            this.TheButton.Text = "Cancel";
            this.TheButton.UseVisualStyleBackColor = true;
            this.TheButton.Click += new System.EventHandler(this.TheButton_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 353);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Splitting Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessForm_FormClosing);
            this.Shown += new System.EventHandler(this.ProcessForm_Shown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private System.ComponentModel.BackgroundWorker SplitBackgroundWorker;
        private PictureBox pictureBox1;
        private Label TitleLabel;
        private ProgressBar OverallProgressBar;
        private Label OverallStatusLabel;
        private ProgressBar TaskProgressBar;
        private Label TaskStatusLabel;
        private GroupBox DetailsGroupBox;
        private TextBox DetailsTextBox;
        private Button TheButton;
    }
}