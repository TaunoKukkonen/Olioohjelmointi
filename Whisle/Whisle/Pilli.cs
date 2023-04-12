using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whisle
{
    internal class Pilli
    {
        private String _aani;

        public Pilli(String pillinAani)
            {
                this._aani = pillinAani;

            }

        public void soi()
        {
            Console.WriteLine(_aani);  
        }


    }

}
