using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu
{
    internal abstract class Jarmu : KisGepJarmu
    {
        protected int sebesseg;
        private string rendszam;

        public Jarmu(string rendszam,int sebesseg)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebessegKorlat);

        public bool HaladahatItt(int sebessegkorlat) => false;

    

        public override string ToString()
        {
            return $"{rendszam} {sebesseg} km/h ";
        }
    }
}
