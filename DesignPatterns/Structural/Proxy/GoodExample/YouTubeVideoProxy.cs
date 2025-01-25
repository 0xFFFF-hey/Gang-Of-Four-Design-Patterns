using DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib;

namespace DesignPatterns.Structural.Proxy.GoodExample
{
    internal class YouTubeVideoProxy : Video
    {
        private string _videoId;
        private YouTubeVideo _youTubeVideo;

        public YouTubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public void Render()
        {
            if (_youTubeVideo == null)
            {
                _youTubeVideo = new YouTubeVideo(_videoId);
            }

            _youTubeVideo.Render();
        }

        public string GetVideoId()
        {
            return _videoId;
        }
    }
}
