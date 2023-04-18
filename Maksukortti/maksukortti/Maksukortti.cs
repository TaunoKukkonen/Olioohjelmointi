using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paaohjelma
{
    public class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkusaldo)
        {
            this.saldo = alkusaldo;
        }
        public override string ToString()
        {
            return "Kortilla on rahaa "+this.saldo+ " Euroa";

        }
        public void syoEdullisesti()
        {   if (this.saldo > 2.60) 
            { this.saldo = saldo - 2.60; }
        }
        public void syoMaukkaasti()
        {
            if (this.saldo > 4.60)
            { this.saldo = saldo - 4.60; }
        }
        public void LataaRahaa(int talletus)
        { if (talletus > 0)
            { this.saldo += talletus; }
        }
    }
}
