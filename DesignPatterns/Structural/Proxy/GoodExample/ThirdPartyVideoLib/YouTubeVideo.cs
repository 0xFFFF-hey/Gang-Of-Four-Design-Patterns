using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib
{
    internal class YouTubeVideo
    {
        private string _videoId;

        public YouTubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }

        private void Download()
        {
            System.Console.WriteLine("Downloading video with id " + _videoId + " from YouTube API");
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering video " + _videoId);
        }

        public string GetVideoId()
        {
            return _videoId;
        }
    }
}
