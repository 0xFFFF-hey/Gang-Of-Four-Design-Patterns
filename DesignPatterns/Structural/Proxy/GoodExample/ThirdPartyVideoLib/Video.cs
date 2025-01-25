using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.GoodExample.ThirdPartyVideoLib
{
    internal interface Video
    {
        void Render();
        string GetVideoId();
    }
}
