using System.ComponentModel;

namespace SpotiSplay
{
    public partial class MainForm : Form
    {
        private SpotiForm spotiForm;
        private SpotifyServer spot;
        public Color backColor;
        public Color foreColor;
        public MainForm()
        {
            InitializeComponent();
            spot = new SpotifyServer();
            spotiForm = new SpotiForm(spot, this);
            GetParams();
            Icon = new Icon("Logo_Spotinaz.ico");
        }

        public void SaveParams()
        {
            string s = spotiForm.Location.X + "," + spotiForm.Location.Y + "," + spotiForm.Width + "," + spotiForm.Height + "\n";
            s += backColor.R.ToString() + "," + backColor.G.ToString() + "," + backColor.B.ToString() + "\n";
            s += foreColor.R.ToString() + "," + foreColor.G.ToString() + "," + foreColor.B.ToString() + "\n";
            s += this.OpacityUpDown.Value.ToString() + "\n";
            s += spotiForm.splitBig.SplitterDistance + "," + spotiForm.splitBigL.SplitterDistance + "," + spotiForm.splitMusicTime.SplitterDistance;
            File.WriteAllText("params.txt", s);
        }

        public void GetParams()
        {
            if (File.Exists("params.txt"))
            {
                string[] s = File.ReadAllText("params.txt").Split('\n');
                string[] s1 = s[0].Split(',');
                string[] s2 = s[1].Split(',');
                string[] s3 = s[2].Split(',');
                string[] s4 = s[3].Split(',');
                string[] s5 = s[4].Split(',');
                spotiForm.Location = new Point(int.Parse(s1[0]), int.Parse(s1[1]));
                spotiForm.Size = new Size(int.Parse(s1[2]), int.Parse(s1[3]));
                backColor = Color.FromArgb(int.Parse(s2[0]), int.Parse(s2[1]), int.Parse(s2[2]));
                foreColor = Color.FromArgb(int.Parse(s3[0]), int.Parse(s3[1]), int.Parse(s3[2]));
                this.OpacityUpDown.Value = int.Parse(s4[0]);

                int tmp = int.Parse(s5[0]);
                if (tmp < spotiForm.splitBig.Panel1MinSize)
                    tmp = spotiForm.splitBig.Panel1MinSize;
                if (tmp > spotiForm.splitBig.Width - spotiForm.splitBig.Panel2MinSize)
                    tmp = spotiForm.splitBig.Width - spotiForm.splitBig.Panel2MinSize;
                spotiForm.splitBig.SplitterDistance = tmp;
                tmp = int.Parse(s5[1]);
                if (tmp < spotiForm.splitBigL.Panel1MinSize)
                    tmp = spotiForm.splitBigL.Panel1MinSize;
                if (tmp > spotiForm.splitBigL.Width - spotiForm.splitBigL.Panel2MinSize)
                    tmp = spotiForm.splitBigL.Width - spotiForm.splitBigL.Panel2MinSize;
                //spotiForm.splitBigL.SplitterDistance = tmp;
                tmp = int.Parse(s5[2]);
                if (tmp < spotiForm.splitMusicTime.Panel1MinSize)
                    tmp = spotiForm.splitMusicTime.Panel1MinSize;
                if (tmp > spotiForm.splitMusicTime.Width - spotiForm.splitMusicTime.Panel2MinSize)
                    tmp = spotiForm.splitMusicTime.Width - spotiForm.splitMusicTime.Panel2MinSize;
                spotiForm.splitMusicTime.SplitterDistance = tmp;

                spotiForm.Opacity = ((double)OpacityUpDown.Value) / 100;
                this.backColorPanel.BackColor = backColor;
                this.foreColorPanel.BackColor = foreColor;
                spotiForm.BackColor = backColor;
                spotiForm.MusicArtistLabel.ForeColor = foreColor;
                spotiForm.MusicNameLabel.ForeColor = foreColor;
                spotiForm.MusicTimeLabel.ForeColor = foreColor;

                spotiForm.splitBig_SplitterMoved(null, null);
                spotiForm.splitMusicTime_SplitterMoved(null, null);
            }
        }

        private void StartDisplay(object sender, EventArgs e)
        {
            try
            {
                if (spotiForm.FormBorderStyle == FormBorderStyle.Sizable)
                    MoveButton_Click(null, null);
                spotiForm.Show();
            }
            catch (Exception)
            {
                spotiForm = new SpotiForm(spot, this);
                GetParams();
                MoveButton_Click(null, null);
                spotiForm.Show();
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            spot.ConnectServ();
        }

        private void OpacityUpDown_ValueChanged(object sender, EventArgs e)
        {
            spotiForm.Opacity = ((double)OpacityUpDown.Value) / 100;
            SaveParams();
        }

        public void MoveButton_Click(object sender, EventArgs e)
        {
            int width = spotiForm.Width;
            int height = spotiForm.Height;

            if (spotiForm.FormBorderStyle == FormBorderStyle.None)
            {
                spotiForm.FormBorderStyle = FormBorderStyle.Sizable;
                spotiForm.splitBig.IsSplitterFixed = false;
                spotiForm.splitBigL.IsSplitterFixed = false;
                spotiForm.splitMusicTime.IsSplitterFixed = false;
            }
            else
            {
                spotiForm.FormBorderStyle = FormBorderStyle.None;
                spotiForm.splitBig.IsSplitterFixed = true;
                spotiForm.splitBigL.IsSplitterFixed = true;
                spotiForm.splitMusicTime.IsSplitterFixed = true;
                SaveParams();
            }
            int xd = (width - spotiForm.Width) / 2;
            int yd = height - spotiForm.Height - xd;
            spotiForm.Location = new Point(spotiForm.Location.X + xd, spotiForm.Location.Y + yd);
        }

        private void backgroungColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = backColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backColor = colorDialog.Color;
            }
            spotiForm.BackColor = backColor;
            this.backColorPanel.BackColor = backColor;
            SaveParams();
        }

        private void FontGroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = foreColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreColor = colorDialog.Color;
            }
            spotiForm.MusicArtistLabel.ForeColor = foreColor;
            spotiForm.MusicNameLabel.ForeColor = foreColor;
            spotiForm.MusicTimeLabel.ForeColor = foreColor;
            this.foreColorPanel.BackColor = foreColor;
            SaveParams();
        }
        public void MainForm_Closing(object? sender, System.ComponentModel.CancelEventArgs? e)
        {
            if (e.Cancel == true)
            {
                e.Cancel = false;
                return;
            }
            this.WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SpotiNotif.BalloonTipText = "SpotiSplay";
            SpotiNotif.BalloonTipTitle = "SpotiSplay";
            SpotiNotif.ContextMenuStrip = contextMenuStripNotif;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                SpotiNotif.Visible = true;
                SpotiNotif.ShowBalloonTip(1000);
            }
        }

        private void SpotiNotif_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowInTaskbar = true;
                SpotiNotif.Visible = false;
                WindowState = FormWindowState.Normal;
            }
            else if (e.Button == MouseButtons.Right)
            {
                SpotiNotif.ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void StripTextBoxQuit_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            SpotiNotif.Visible = false;
            if (spotiForm.FormBorderStyle == FormBorderStyle.None)
            {
                MoveButton_Click(null, null);
            }
            SaveParams();
            CancelEventArgs c = new CancelEventArgs();
            c.Cancel = true;
            Application.Exit(c);
        }

        private void LPadUpDown_ValueChanged(object sender, EventArgs e)
        {
            spotiForm.splitMusicTime.Panel1.Padding = new Padding((int)LPadUpDown.Value, spotiForm.splitMusicTime.Panel1.Padding.Top, 0, 0);
            spotiForm.splitBigL.Panel2.Padding = new Padding((int)LPadUpDown.Value, 0, 0, 0);
            spotiForm.splitMusicTime_SplitterMoved(null, null);
        }

        private void TPadUpDown_ValueChanged(object sender, EventArgs e)
        {
            spotiForm.splitMusicTime.Panel1.Padding = new Padding(spotiForm.splitMusicTime.Panel1.Padding.Left, (int)TPadUpDown.Value, 0, 0);
            spotiForm.splitMusicTime.Panel2.Padding = new Padding(0, (int)TPadUpDown.Value, 0, 0);

        }
    }
}