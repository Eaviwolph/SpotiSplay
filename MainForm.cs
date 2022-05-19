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
<<<<<<< HEAD
            spot = SpotifyServer.Instance;
=======
            spot = new SpotifyServer();
>>>>>>> e674c804ee96b1bcf510b3168576251d39939747
            spotiForm = new SpotiForm();
            spotiForm.TopMost = true;
        }

        private async void StartDisplay(object sender, EventArgs e)
        {
<<<<<<< HEAD
            spotiForm.Show();
=======
                var t = await spot.GetCurrentTrackAsync();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {

>>>>>>> e674c804ee96b1bcf510b3168576251d39939747
        }
    }
}