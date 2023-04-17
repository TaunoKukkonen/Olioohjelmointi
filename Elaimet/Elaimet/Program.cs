using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hevonen aHevonen = new Hevonen();
            aHevonen.Nimi= "Histamiini";
            aHevonen.Paino=89;
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

            Kissa katti = new Kissa(2,"Anneli");
            Console.WriteLine(katti.nimi);
            katti.AsetaKissaNimi("Hilda");
            Console.WriteLine(katti.nimi);
            katti.nimitotta();

            Kissa kitty = new Kissa();
            Console.WriteLine(kitty.nimi+ " "+ kitty.PalautaKissanIka());
            

            Console.ReadLine();
        }
        

          
    }
}
