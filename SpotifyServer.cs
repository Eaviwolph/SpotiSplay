using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;

namespace SpotiSplay
{
    internal class SpotifyServer
    {
        private static SpotifyClient spotify;
        private static EmbedIOAuthServer _server;
        
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
                File.ReadAllText("tokenSecret.txt"), "a26b2dd7e6cb4369aa096ef0dd5108b0", response.Code, new Uri("http://localhost:5000/callback")
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
            _server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationAppCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            var request = new LoginRequest(_server.BaseUri, File.ReadAllText("tokenSecret.txt"), LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> { Scopes.UserReadPlaybackState, Scopes.UserModifyPlaybackState, Scopes.UserReadCurrentlyPlaying, Scopes.Streaming, Scopes.UgcImageUpload, Scopes.AppRemoteControl, Scopes.UserReadEmail, Scopes.UserReadPrivate, Scopes.PlaylistReadCollaborative, Scopes.PlaylistModifyPublic, Scopes.PlaylistReadPrivate, Scopes.PlaylistModifyPrivate, Scopes.UserLibraryModify, Scopes.UserLibraryRead, Scopes.UserTopRead, Scopes.UserReadPlaybackPosition, Scopes.UserReadRecentlyPlayed, Scopes.UserFollowRead, Scopes.UserFollowModify }
            };
            BrowserUtil.Open(request.ToUri());
        }

        public async Task<FullTrack> GetCurrentTrackAsync()
        {
            PlayerCurrentlyPlayingRequest c = new PlayerCurrentlyPlayingRequest();
            var music = await spotify.Player.GetCurrentlyPlaying(c);
            FullTrack f = new FullTrack();
            f.Name = "Error Getting Current Track";
            if (music != null && music.Item != null && music.Item is FullTrack)
            {
                f = music.Item as FullTrack;
            }
            
            return f;
        }
    }
}
