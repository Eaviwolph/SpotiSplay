namespace SpotiSplay
{
    partial class SpotiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusicNameLabel = new System.Windows.Forms.Label();
            this.MusicArtistLabel = new System.Windows.Forms.Label();
            this.splitBigL = new System.Windows.Forms.SplitContainer();
            this.splitMusicTime = new System.Windows.Forms.SplitContainer();
            this.MusicTimeLabel = new System.Windows.Forms.Label();
            this.splitBig = new System.Windows.Forms.SplitContainer();
            this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitBigL)).BeginInit();
            this.splitBigL.Panel1.SuspendLayout();
            this.splitBigL.Panel2.SuspendLayout();
            this.splitBigL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMusicTime)).BeginInit();
            this.splitMusicTime.Panel1.SuspendLayout();
            this.splitMusicTime.Panel2.SuspendLayout();
            this.splitMusicTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBig)).BeginInit();
            this.splitBig.Panel1.SuspendLayout();
            this.splitBig.Panel2.SuspendLayout();
            this.splitBig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicNameLabel
            // 
            this.MusicNameLabel.AutoSize = true;
            this.MusicNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MusicNameLabel.Name = "MusicNameLabel";
            this.MusicNameLabel.Size = new System.Drawing.Size(39, 15);
            this.MusicNameLabel.TabIndex = 0;
            this.MusicNameLabel.Text = "Music";
            this.MusicNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusicNameLabel.TextChanged += new System.EventHandler(this.MusicNameLabel_TextChanged);
            // 
            // MusicArtistLabel
            // 
            this.MusicArtistLabel.AutoSize = true;
            this.MusicArtistLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MusicArtistLabel.Location = new System.Drawing.Point(0, 0);
            this.MusicArtistLabel.Name = "MusicArtistLabel";
            this.MusicArtistLabel.Size = new System.Drawing.Size(35, 15);
            this.MusicArtistLabel.TabIndex = 1;
            this.MusicArtistLabel.Text = "Artist";
            this.MusicArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitBigL
            // 
            this.splitBigL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBigL.Location = new System.Drawing.Point(0, 0);
            this.splitBigL.Name = "splitBigL";
            this.splitBigL.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBigL.Panel1
            // 
            this.splitBigL.Panel1.Controls.Add(this.splitMusicTime);
            // 
            // splitBigL.Panel2
            // 
            this.splitBigL.Panel2.Controls.Add(this.MusicArtistLabel);
            this.splitBigL.Size = new System.Drawing.Size(194, 118);
            this.splitBigL.SplitterDistance = 60;
            this.splitBigL.TabIndex = 2;
            // 
            // splitMusicTime
            // 
            this.splitMusicTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMusicTime.Location = new System.Drawing.Point(0, 0);
            this.splitMusicTime.Name = "splitMusicTime";
            // 
            // splitMusicTime.Panel1
            // 
            this.splitMusicTime.Panel1.Controls.Add(this.MusicNameLabel);
            this.splitMusicTime.Panel1MinSize = 1;
            // 
            // splitMusicTime.Panel2
            // 
            this.splitMusicTime.Panel2.Controls.Add(this.MusicTimeLabel);
            this.splitMusicTime.Panel2MinSize = 1;
            this.splitMusicTime.Size = new System.Drawing.Size(194, 60);
            this.splitMusicTime.SplitterDistance = 122;
            this.splitMusicTime.TabIndex = 1;
            this.splitMusicTime.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitMusicTime_SplitterMoved);
            // 
            // MusicTimeLabel
            // 
            this.MusicTimeLabel.AutoSize = true;
            this.MusicTimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicTimeLabel.Location = new System.Drawing.Point(2, 0);
            this.MusicTimeLabel.Name = "MusicTimeLabel";
            this.MusicTimeLabel.Size = new System.Drawing.Size(66, 15);
            this.MusicTimeLabel.TabIndex = 1;
            this.MusicTimeLabel.Text = "00:00/00:00";
            this.MusicTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitBig
            // 
            this.splitBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBig.Location = new System.Drawing.Point(0, 0);
            this.splitBig.Name = "splitBig";
            // 
            // splitBig.Panel1
            // 
            this.splitBig.Panel1.Controls.Add(this.splitBigL);
            // 
            // splitBig.Panel2
            // 
            this.splitBig.Panel2.Controls.Add(this.AlbumPictureBox);
            this.splitBig.Size = new System.Drawing.Size(318, 118);
            this.splitBig.SplitterDistance = 194;
            this.splitBig.TabIndex = 3;
            this.splitBig.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitBig_SplitterMoved);
            // 
            // AlbumPictureBox
            // 
            this.AlbumPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlbumPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AlbumPictureBox.Name = "AlbumPictureBox";
            this.AlbumPictureBox.Size = new System.Drawing.Size(120, 118);
            this.AlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumPictureBox.TabIndex = 0;
            this.AlbumPictureBox.TabStop = false;
            // 
            // SpotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 118);
            this.Controls.Add(this.splitBig);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(30, 30);
            this.Name = "SpotiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpotiForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SpotiForm_Load);
            this.splitBigL.Panel1.ResumeLayout(false);
            this.splitBigL.Panel2.ResumeLayout(false);
            this.splitBigL.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBigL)).EndInit();
            this.splitBigL.ResumeLayout(false);
            this.splitMusicTime.Panel1.ResumeLayout(false);
            this.splitMusicTime.Panel1.PerformLayout();
            this.splitMusicTime.Panel2.ResumeLayout(false);
            this.splitMusicTime.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMusicTime)).EndInit();
            this.splitMusicTime.ResumeLayout(false);
            this.splitBig.Panel1.ResumeLayout(false);
            this.splitBig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBig)).EndInit();
            this.splitBig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label MusicNameLabel;
        public Label MusicArtistLabel;
        public SplitContainer splitBigL;
        public SplitContainer splitBig;
        public SplitContainer splitMusicTime;
        public Label MusicTimeLabel;
        public PictureBox AlbumPictureBox;
    }
}