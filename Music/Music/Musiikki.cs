using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    internal class Musiikkikappale
    {
        private string nimi;
        private int pituus;


        public Musiikkikappale(string nimi, int pituus)
        {
            this.nimi = nimi;
            this.pituus = pituus;
        }
        public string Nimi()
        {
            return nimi;
        }
        public int Pituus()
        {
            return pituus;
        }
    }
}
