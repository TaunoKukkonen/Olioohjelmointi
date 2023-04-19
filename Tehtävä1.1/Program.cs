using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtävä1._1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Hevonen aHevonen = new Hevonen();
            aHevonen.Nimi = "Histamiini";
            aHevonen.Paino = 89;
            Console.WriteLine(aHevonen.Nimi + " " + aHevonen.Paino);

            Kissa aKissa = new Kissa();
            aKissa.nimi = "pasi";
            Console.WriteLine(aKissa.nimi);


            Kissa bKissa = new Kissa(5, "stinky");
            Console.WriteLine(bKissa.nimi + " " + bKissa.PalautaKissanIka());

            Kissa cKissa = new Kissa();
            cKissa.AsetaKissaNimi("bob");
            cKissa.AsetaKissanIka(-2);
            Console.WriteLine(cKissa.PalautaKissanNimi() + " " + cKissa.PalautaKissanIka());
            cKissa.nimitotta();
            cKissa.ikätotta();

            Kissa katti = new Kissa(2, "Anneli");
            Console.WriteLine(katti.nimi);
            katti.AsetaKissaNimi("HiLdA");
            Console.WriteLine(katti.nimi);
            katti.nimitotta();

            Kissa kitty = new Kissa();
            Console.WriteLine(kitty.nimi + " " + kitty.PalautaKissanIka());

            Kissa elgato = new Kissa();
            Console.WriteLine(elgato);

            Koira aKoira = new Koira(0,"Max");
            Console.WriteLine(aKoira.nimi);
            aKoira.AsetaKoiranNimi("Musti");
            Console.WriteLine(aKoira.nimi);



            Console.ReadLine();
        }

    }
}