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
            spotiForm = new SpotiForm();
        }

        private async void StartDisplay(object sender, EventArgs e)
        {
            var t = await spot.GetCurrentTrackAsync();
            
            MessageBox.Show(t.Name);
            //MessageBox.Show($"{music.ProgressMs / (1000 * 60)}:{music.ProgressMs % (1000 * 60) / 1000}");
        }
    }
}