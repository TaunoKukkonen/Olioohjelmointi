using ElainLuokat;
using System.Security.Cryptography.X509Certificates;

namespace Ika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            
            Random rnd = new Random();
           

            while (x < 10)
            {
                
                Koira Uusikoira = new Koira();
                Uusikoira.AsetaKoiranIka(rnd.Next(15));
                Kissa UusiKissa = new Kissa();
                UusiKissa.AsetaKissanIka(rnd.Next(10));
                Console.WriteLine("Koira on "+ Uusikoira.PalautaKoiranIka()+" vuotta, Kissa on "+ UusiKissa.PalautaKissanIka()+" vuotta");
                if (Uusikoira.PalautaKoiranIka() == UusiKissa.PalautaKissanIka())
                {
                    Console.WriteLine("Koira ja Kissa ovat saman ikäisiä");
                }
                else if (Uusikoira.PalautaKoiranIka() > UusiKissa.PalautaKissanIka())
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
                
                x++;

            }
           
        }
    }
}