﻿using SpotifyAPI.Web;

namespace SpotiSplay
{
    public partial class SpotiForm : Form
    {
        private SpotifyServer spot;
        private MainForm parent;
        public SpotiForm(SpotifyServer spot, MainForm parent)
        {
            InitializeComponent();
            this.spot = spot;
            this.parent = parent;
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            ActAllStatus();
        }

        public void SetErrors()
        {
            this.MusicNameLabel.Text = "Music Error";
            this.MusicArtistLabel.Text = "Artist Error";
            this.MusicTimeLabel.Text = "00:00/00:00";
        }

        string TimeToString(int time)
        {
            int min = time / 60;
            int sec = time % 60;
            return min.ToString("00") + ":" + sec.ToString("00");
        }
        public async void ActAllStatus()
        {
            CurrentlyPlaying? t = null;
            try
            {
                t = await spot.GetCurrentTrackAsync();
            }
            catch (Exception)
            {
                ForceReloadToken();
            }
            try
            {
                FullTrack? f = new FullTrack();
                f.Name = "Error Getting Current Track";
                if (t != null && t.Item != null && t.Item is FullTrack)
                {
                    f = t.Item as FullTrack;
                }
                if (t != null && f != null)
                {
                    this.MusicNameLabel.Text = f.Name;
                    if (f.Artists != null && f.Artists.Count > 0)
                    {
                        this.MusicArtistLabel.Text = f.Artists[0].Name;
                    }
                    else
                    {
                        this.MusicArtistLabel.Text = "Artist Error";
                    }

                    if (t.ProgressMs != null)
                    {
                        int progress = (int)t.ProgressMs;
                        this.MusicTimeLabel.Text = TimeToString(progress / 1000) + "/" + TimeToString(f.DurationMs / 1000);
                    }
                    else
                    {
                        this.MusicTimeLabel.Text = "00:00/00:00";
                    }
                }
            }
            catch (Exception)
            {
                SetErrors();
            }
        }

        int connectResult = 1;
        public async void ForceReloadToken()
        {
            if (connectResult == 1)
            {
                connectResult = 0;
                connectResult = await spot.ConnectServ();
            }
        }
        private void SpotiForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
        }
        public void splitMusicTime_SplitterMoved(object? sender, SplitterEventArgs? e)
        {
            this.MusicNameLabel.MaximumSize = new Size(this.splitMusicTime.Panel1.Width - this.splitMusicTime.Panel1.Padding.Left, 3000);
            this.MusicTimeLabel.MaximumSize = new Size(this.splitMusicTime.Panel2.Width - this.splitMusicTime.Panel2.Padding.Left, 3000);
        }

        public void splitBig_SplitterMoved(object? sender, SplitterEventArgs? e)
        {
            this.MusicArtistLabel.MaximumSize = new Size(this.splitBig.Panel1.Width, 3000);
        }

        private async void MusicNameLabel_TextChanged(object sender, EventArgs e)
        {
            CurrentlyPlaying? t = null;
            try
            {
                t = await spot.GetCurrentTrackAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Spotify Server Error. Reload the token please", "Error");
            }
            try
            {
                FullTrack? f = new FullTrack();
                f.Name = "Error Getting Current Track";
                if (t != null && t.Item != null && t.Item is FullTrack)
                {
                    f = t.Item as FullTrack;
                }
                if (t != null && f != null)
                {
                    string url = await spot.GetImage(f.Album.Id);
                    HttpClient client = new HttpClient();
                    Stream stream = await client.GetStreamAsync(url);
                    Bitmap bitmap;
                    bitmap = new Bitmap(stream);
                    if (bitmap != null)
                    {
                        this.AlbumPictureBox.Image = bitmap;
                    }
                }
            }
            catch
            {
            }
        }
        private void SpotiForm_Resize(object sender, EventArgs e)
        {
            splitBig_SplitterMoved(null, null);
            splitMusicTime_SplitterMoved(null, null);
        }
        public void SpotiForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (parent.forceQuit)
            {
                return;
            }
            e.Cancel = true;
            this.Hide();
        }

        public void UpdateFont(Font f)
        {
            this.MusicNameLabel.Font = f;
            this.MusicArtistLabel.Font = f;
            this.MusicTimeLabel.Font = f;
        }
    }
}
