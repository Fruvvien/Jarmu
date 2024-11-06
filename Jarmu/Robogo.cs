using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu
{
    internal class Robogo : Jarmu
    {

        private int maximalis_sebesseg;
        public Robogo(string rendszam, int sebesseg, int maximalis_sebesseg) :base( rendszam, sebesseg)
        {
            this.maximalis_sebesseg = maximalis_sebesseg;
        }

        public override bool GyorshajtottE(int sebessegKorlat)
        {
            return this.sebesseg >= sebessegKorlat;
        }

        public bool HaladahatItt(int sebessegkorlat) => this.maximalis_sebesseg > sebessegkorlat;

        public override string ToString()
        {
            return "Robogo: " +  base.ToString();
        }
    }
}
