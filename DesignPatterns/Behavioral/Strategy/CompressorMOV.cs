using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MOV");
        }
    }
}
