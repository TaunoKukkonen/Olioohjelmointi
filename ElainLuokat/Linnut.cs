using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Linnut: Elain
    {
        private bool Munii;

        public void AsetaMuniminen( bool Munii)
        {
            this.Munii = Munii;
        }

        public void PalautaMuniminen()
        {
            if (this.Munii==true) 
            {
                Console.WriteLine("Tämä lintu munii");
            }
            else
            {
                Console.WriteLine("Tämä lintu ei muni");
            }
        }

    }
}
