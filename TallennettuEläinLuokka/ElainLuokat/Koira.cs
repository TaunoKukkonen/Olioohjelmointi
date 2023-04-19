using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira
    {
        private int ika = 0;
        public String nimi="Haukkuli";
        private bool oikeaika;
        private bool oikeanimi;
        public Koira()
        {

        }
        public Koira(int ika, String nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKoiranNimi(String uusi_Nimi)
        {
            if (uusi_Nimi.ContainsCaseInsensitive ( "Musti" ) == true)
            {
                oikeanimi = false;
            }
            else
            {
                oikeanimi = true;
                this.nimi = uusi_Nimi;
            }




        }
        public void AsetaKoiranIka(int ika)
        {
            if (ika >= 0)
            {
                this.ika = ika;
                oikeaika = true;
            }
            else
            {
                oikeaika = false;
            }
        }

        public String PalautaKoiranNimi()
        { return this.nimi; }

        public int PalautaKoiranIka()
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
            return "Koira: "+ this.nimi + ", ikä "+ this.ika;
        }
    }
}
