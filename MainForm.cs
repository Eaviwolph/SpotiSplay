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
            spot = SpotifyServer.Instance;
            spotiForm = new SpotiForm();
            spotiForm.TopMost = true;
        }

        private async void StartDisplay(object sender, EventArgs e)
        {
            spotiForm.Show();
        }
    }
}