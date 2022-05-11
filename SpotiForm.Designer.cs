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
            this.AlbumPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AlbumPicture
            // 
            this.AlbumPicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AlbumPicture.Location = new System.Drawing.Point(317, 208);
            this.AlbumPicture.Name = "AlbumPicture";
            this.AlbumPicture.Size = new System.Drawing.Size(151, 167);
            this.AlbumPicture.TabIndex = 0;
            this.AlbumPicture.TabStop = false;
            // 
            // SpotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlbumPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpotiForm";
            this.Text = "SpotiForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.AlbumPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox AlbumPicture;
    }
}