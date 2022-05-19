using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;

namespace SpotiSplay
{
    public partial class MainForm : Form
    {
        SpotiForm spotiForm;
        SpotifyServer spot;
        public MainForm()
        {
            InitializeComponent();
            spot = new SpotifyServer();
            spotiForm = new SpotiForm();
        }

        private async void StartDisplay(object sender, EventArgs e)
        {
                var t = await spot.GetCurrentTrackAsync();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {

        }
    }
}