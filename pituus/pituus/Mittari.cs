using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pituus
{
    internal class Mittari
    {
        private int _mitta;

        public Mittari() 
        {
            _mitta = 0;
        }

        public void Lisaa()
        {
            _mitta++;
        }
        public void Vahenna()
        {
            _mitta--;
        }
        public int Mitta()
        { return _mitta; }
        public Boolean Taynna()
        { return _mitta == 5; }


    }
}
