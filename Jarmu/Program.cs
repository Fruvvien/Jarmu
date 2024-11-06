using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orszagut orszagut = new Orszagut();
            orszagut.jarmuvekJonne("jarmuvek.txt");

            orszagut.kiketMerunkBe();
        }
    }
}
