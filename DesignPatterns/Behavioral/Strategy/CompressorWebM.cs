using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressorWebM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using WebM");
        }
    }
}
