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
            Console.Read(); 
             
            Cat aCat = new Cat();
            aCat.name = "Pasi";
            Console.WriteLine(aCat.name);
            Console.ReadLine();

            aCat.setKissaname("Simo");
            Console.Write(aCat.name);
            Console.ReadLine();
            aCat.setKissaage(1);
            Console.Write(aCat.returnage());
            Console.ReadLine();

            Cat bCat = new Cat(6,"Stinky");
            Console.Write(bCat.returnKissaname() +" "+bCat.returnage());
            



            Console.ReadLine();
        }
        

          
    }
}
