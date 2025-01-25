using DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib;

namespace DesignPatterns.Structural.Proxy.GoodExample
{
    internal class VideoList
    {
        private Dictionary<string, Video> _videoList = new Dictionary<string, Video>();

        public void Add(Video video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }


        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}
