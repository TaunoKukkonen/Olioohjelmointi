using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pankki
{
    internal class Velka
    {
        private double _saldo;
        private double _korkoProsentti;

        public Velka(double saldoAlussa, double _korkoProsentti) 
        {
            this._saldo = saldoAlussa;
            this._korkoProsentti = 0.01*_korkoProsentti;
        }


        public void OdotaVuosi()
        {
            _saldo = _saldo * (1 + _korkoProsentti);
        }
        public void TulostaSaldo()
        {
            Console.WriteLine(_saldo);
        }

    }
}
