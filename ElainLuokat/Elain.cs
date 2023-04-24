using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int ika;
        public String nimi;
        private bool OnLihanSyoja;

        public Elain(){}

        public Elain(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void AsetaElaimenIka(int uusiika)
        {   if (uusiika >= 0) 
            {
                this.ika = uusiika; 
            }
        }
        public void AsetaElaimenNimi(string uusinimi)
        {
            this .nimi = uusinimi;
        }
        public string PalautaElaimenNimi()
        {
            return this.nimi;
        }
        public int PalautaElaimenIka()
        {
            return this.ika;
        }
        public void AsetaOnLihanSyoja(bool LihanSyoja)
        {
            this.OnLihanSyoja = LihanSyoja;
        }
        public bool palautaOnLihanSyoja()
        {
            return this .OnLihanSyoja;
        }
        public virtual void Aantele()
        {
            Console.WriteLine("Uuph");
        }

    }
}
