using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    internal class Kissa
    {
        private int ika = 0;
        public String nimi="miuku";
        private bool oikeaika;
        private bool oikeanimi;
        public Kissa()
        {

        }
        public Kissa(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKissaNimi(String uusi_Nimi)
        {
            if (uusi_Nimi.ContainsCaseInsensitive ( "hilda" ) == true)
            {
                oikeanimi = false;
            }
            else
            {
                oikeanimi = true;
                this.nimi = uusi_Nimi;
            }




        }
        public void AsetaKissanIka(int ika)
        {
            if (this.ika > 0)
            {
                this.ika = ika;
                oikeaika = true;
            }
            else
            {
                oikeaika = false;
            }
        }

        public String PalautaKissanNimi()
        { return this.nimi; }

        public int PalautaKissanIka()
        {
            return this.ika;
        }
        public void ikätotta()
        {
            if (oikeaika==true)
            {
                Console.WriteLine("Ikä muutettiin");
                    }else
            {
                Console.WriteLine("ikä on negatiivinen ja ei käy");
            }
        }
        public void nimitotta()
        {
            if (oikeanimi == true)
            {
                Console.WriteLine("nimi on hyväksyttävä");
            }else { Console.WriteLine("nimeä Hilda ei voida hyväksyä"); }
        }
        public override string ToString()
        {
            return "Miuku, ikä 0.";
        }
    }
}
