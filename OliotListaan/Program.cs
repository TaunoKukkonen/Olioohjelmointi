using ElainLuokat;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace OliotListaan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Kuinka monta eläintä luodaan? ");
            int Elainmaara = Convert.ToInt32(Console.ReadLine());
            int Nummuuttuja = 3;
            Random random = new Random();
            List<Elain> list = new List<Elain>();
            for (int i = 0; i < Elainmaara; i++)
            {
                x++;
                if (x % 4 == 0)
                {
                    Hevonen hevonen = new Hevonen();

                    hevonen.AsetaElaimenNimi("Hevonen "+hevonen.GenerateName());
                    hevonen.AsetaElaimenIka(random.Next(30));
                    hevonen.AsetaOnLihanSyoja(false);
                    hevonen.AsetaHikoilu(true);
                    Nummuuttuja++;
                    list.Add(hevonen);
                } else if (Nummuuttuja == 3)
                {
                    Kissa kissa = new Kissa();
                    kissa.AsetaElaimenNimi("Kissa "+kissa.GenerateName());
                    kissa.AsetaElaimenIka(random.Next(15));
                    kissa.AsetaOnLihanSyoja(true);
                    kissa.AsetaHikoilu(true);
                    list.Add(kissa);
                    Nummuuttuja = 1;
                } else if (Nummuuttuja == 1 || Nummuuttuja==4)
                {
                    Koira koira = new Koira();
                    koira.AsetaElaimenNimi("Koira " + koira.GenerateName());
                    koira.AsetaElaimenIka(random.Next(10));
                    koira.AsetaOnLihanSyoja(true);
                    koira.AsetaHikoilu(true);
                    list.Add(koira);
                    Nummuuttuja = 2;
                } else if (Nummuuttuja == 2)
                {
                    Papukaija papukaija = new Papukaija();
                    papukaija.AsetaElaimenNimi("Papukaija "+papukaija.GenerateName());
                    papukaija.AsetaElaimenIka(random.Next(100));
                    papukaija.AsetaOnLihanSyoja(false);
                    if (i % 2 == 0)
                    {
                        papukaija.AsetaMuniminen(true);
                    } else
                    {
                        papukaija.AsetaMuniminen(false);
                    }
                    list.Add(papukaija);
                    Nummuuttuja = 3;
                }

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
          
        } 
    }
}