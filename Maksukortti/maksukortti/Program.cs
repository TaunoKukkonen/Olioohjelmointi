using System;

namespace paaohjelma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maksukortti Pekka =new Maksukortti(20);
            Maksukortti Matti = new Maksukortti(30);
            Pekka.syoMaukkaasti();
            Matti.syoEdullisesti();
            Console.WriteLine("Pekkan "+ Pekka);
            Console.WriteLine("Mattin " + Matti);
            Pekka.LataaRahaa(20);
            Matti.syoMaukkaasti();
            Console.WriteLine("Pekkan " + Pekka);
            Console.WriteLine("Mattin " + Matti);
            Pekka.syoEdullisesti();
            Pekka.syoEdullisesti();
            Matti.LataaRahaa(50);
            Console.WriteLine("Pekkan " + Pekka);
            Console.WriteLine("Mattin " + Matti);

        }
    }
}