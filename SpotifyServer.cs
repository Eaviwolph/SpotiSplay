using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;

namespace SpotiSplay
{
    public class SpotifyServer
    {
        private static SpotifyClient spotify;
        private static EmbedIOAuthServer _server;

        public static SpotifyServer Instance { get; } = new SpotifyServer();

        public SpotifyServer()
        {
            if (File.Exists("token.txt"))
            {
                spotify = new SpotifyClient(File.ReadAllText("token.txt"));
            }
            else
            {
                ConnectServ();
            }
        }

        private async Task OnAuthorizationAppCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
              new AuthorizationCodeTokenRequest(
                "a5671eaed5c04450a0859cec6a0b7db8", File.ReadAllText("tokenSecret.txt"), response.Code, new Uri("http://localhost:5000/callback")
              )
            );
            spotify = new SpotifyClient(tokenResponse.AccessToken);
            File.WriteAllText("token.txt", tokenResponse.AccessToken);
        }

        private async Task OnErrorReceived(object sender, string error, string state)
        {
            MessageBox.Show($"Aborting authorization, error received: {error}");
            await _server.Stop();
        }
        public async void ConnectServ()
        {
            try
            {
                _server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
                await _server.Start();

                _server.AuthorizationCodeReceived += OnAuthorizationAppCodeReceived;
                _server.ErrorReceived += OnErrorReceived;

                var request = new LoginRequest(_server.BaseUri, "a5671eaed5c04450a0859cec6a0b7db8", LoginRequest.ResponseType.Code)
                {
                    Scope = new List<string> { Scopes.UserReadPlaybackState, Scopes.UserModifyPlaybackState, Scopes.UserReadCurrentlyPlaying, Scopes.Streaming, Scopes.UgcImageUpload, Scopes.AppRemoteControl, Scopes.UserReadEmail, Scopes.UserReadPrivate, Scopes.PlaylistReadCollaborative, Scopes.PlaylistModifyPublic, Scopes.PlaylistReadPrivate, Scopes.PlaylistModifyPrivate, Scopes.UserLibraryModify, Scopes.UserLibraryRead, Scopes.UserTopRead, Scopes.UserReadPlaybackPosition, Scopes.UserReadRecentlyPlayed, Scopes.UserFollowRead, Scopes.UserFollowModify }
                };
                BrowserUtil.Open(request.ToUri());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                Application.Exit();
            }
        }

        public async Task<CurrentlyPlaying> GetCurrentTrackAsync()
        {
            PlayerCurrentlyPlayingRequest c = new PlayerCurrentlyPlayingRequest();
            var music = await spotify.Player.GetCurrentlyPlaying(c);
            return music;
        }

        public async Task<string> GetImage(string albumId)
        {
            FullAlbum al = await spotify.Albums.Get(albumId);
            return al.Images[0].Url;
        }
    }
}
