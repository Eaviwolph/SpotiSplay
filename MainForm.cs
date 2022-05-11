using System.Runtime.InteropServices;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;

namespace SpotiSplay
{
    public partial class MainForm : Form
    {
        SpotiForm spotiForm;
        private static SpotifyClient spotify;
        private static EmbedIOAuthServer _server;

        public MainForm()
        {
            InitializeComponent();
            spotiForm = new SpotiForm();
        }

        private static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
              new AuthorizationCodeTokenRequest(
                "a5671eaed5c04450a0859cec6a0b7db8", "a26b2dd7e6cb4369aa096ef0dd5108b0", response.Code, new Uri("http://localhost:5000/callback")
              )
            );

            spotify = new SpotifyClient(tokenResponse.AccessToken);
            await spotify.Player.PausePlayback();
        }

        private static async Task OnErrorReceived(object sender, string error, string state)
        {
            Console.WriteLine($"Aborting authorization, error received: {error}");
            await _server.Stop();
        }

        private async void StartDisplay(object sender, EventArgs e)
        {
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            var request = new LoginRequest(_server.BaseUri, "a5671eaed5c04450a0859cec6a0b7db8", LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> { Scopes.UserReadEmail }
            };
            BrowserUtil.Open(request.ToUri());
            //spotiForm.Show();
        }
    }
}