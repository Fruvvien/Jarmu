using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu
{
    internal class AudiS8 : Jarmu
    {
        private bool lezerblokkolo;

        public AudiS8(string rendszam, int sebesseg,  bool lezerblokkolo) : base(rendszam, sebesseg)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public override bool GyorshajtottE(int sebessegKorlat)
        {
            if(lezerblokkolo)
            {
                return false;
            }
            return this.sebesseg > sebessegKorlat;
        }

        public override string ToString()
        {
            return "AuidS8 " +  base.ToString();
        }
    }
}
