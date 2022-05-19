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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MusicNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MusicNameLabel
            // 
            this.MusicNameLabel.AutoSize = true;
            this.MusicNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MusicNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MusicNameLabel.Name = "MusicNameLabel";
            this.MusicNameLabel.Size = new System.Drawing.Size(71, 15);
            this.MusicNameLabel.TabIndex = 1;
            this.MusicNameLabel.Text = "MusicName";
            // 
            // SpotiForm
            // 
            this.ClientSize = new System.Drawing.Size(479, 109);
            this.Controls.Add(this.MusicNameLabel);
            this.Name = "SpotiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Label MusicNameLabel;
    }
}