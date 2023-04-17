using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuote
{
    internal class Tuote
    {
        private string nimiAlussa;
        private double hintaAlussa;
        private int maaraAlussa;


        public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)
        {
            this.nimiAlussa = nimiAlussa;
            this.hintaAlussa = hintaAlussa;
            this.maaraAlussa = maaraAlussa;
        }

        public void TulostaTuote()
        {
            Console.WriteLine(nimiAlussa+"hinta " + hintaAlussa+" "+ maaraAlussa+ " kpl" );
        }


    }
}
