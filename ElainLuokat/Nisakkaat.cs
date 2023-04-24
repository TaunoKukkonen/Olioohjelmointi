using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Nisakkaat : Elain
    {
        private bool VoiHikoilla = true;

        public void AsetaHikoilu(bool Hiki)
        {
            this.VoiHikoilla = Hiki;
        }
        public void palautaHikoilu()
        {
            if (this.VoiHikoilla == true) 
            {
                Console.WriteLine("Tämä eläin voi hikoilla");
            } else
            {
                Console.WriteLine("Tämä eläin ei hikoile");
            }
        }
    }
}
