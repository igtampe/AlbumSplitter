namespace AlbumSplitter {
    partial class TracklistForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OKBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.TracklistGroupbox = new System.Windows.Forms.GroupBox();
            this.TracklistBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TrackNumberColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.TrackNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.TracklistGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.OKBTN, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelBTN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TracklistGroupbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OKBTN
            // 
            this.OKBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBTN.Location = new System.Drawing.Point(326, 331);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(75, 23);
            this.OKBTN.TabIndex = 0;
            this.OKBTN.Text = "OK";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(407, 331);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // TracklistGroupbox
            // 
            this.TracklistGroupbox.Controls.Add(this.TracklistBox);
            this.TracklistGroupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TracklistGroupbox.Location = new System.Drawing.Point(23, 23);
            this.TracklistGroupbox.Name = "TracklistGroupbox";
            this.TracklistGroupbox.Size = new System.Drawing.Size(250, 302);
            this.TracklistGroupbox.TabIndex = 2;
            this.TracklistGroupbox.TabStop = false;
            this.TracklistGroupbox.Text = "Tracklist";
            // 
            // TracklistBox
            // 
            this.TracklistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TracklistBox.Location = new System.Drawing.Point(3, 19);
            this.TracklistBox.Multiline = true;
            this.TracklistBox.Name = "TracklistBox";
            this.TracklistBox.Size = new System.Drawing.Size(244, 280);
            this.TracklistBox.TabIndex = 0;
            this.TracklistBox.Leave += new System.EventHandler(this.TracklistBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(279, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrackNumberColumnHeader,
            this.TrackNameColumnHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 280);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TrackNumberColumnHeader
            // 
            this.TrackNumberColumnHeader.Text = "#";
            this.TrackNumberColumnHeader.Width = 40;
            // 
            // TrackNameColumnHeader
            // 
            this.TrackNameColumnHeader.Text = "Name";
            this.TrackNameColumnHeader.Width = 100;
            // 
            // TracklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TracklistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Track Names";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TracklistGroupbox.ResumeLayout(false);
            this.TracklistGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button OKBTN;
        private Button CancelBTN;
        private GroupBox TracklistGroupbox;
        private TextBox TracklistBox;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader TrackNumberColumnHeader;
        private ColumnHeader TrackNameColumnHeader;
    }
}