using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    internal class Kissa
    {
        private int ika;
        public String nimi;

        public Kissa()
        {

        }
        public Kissa(int ika,String nimi) 
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKissaNimi(String nimi)
        {
            this.nimi = nimi;
        }

        public String PalautaKissanNimi()
        { return this.nimi; }

        public int PalautaKissanIkä()
        {
            return this.ika;
        }



    }
}
