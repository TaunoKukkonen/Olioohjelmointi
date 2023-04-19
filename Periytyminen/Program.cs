using ElainLuokat;

namespace Periytyminen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kissa newkissa = new Kissa();
            newkissa.AsetaElaimenNimi("Mauno");
            newkissa.AsetaElaimenIka(8);
            newkissa.AsetaOnLihanSyoja(true);
            newkissa.kehrata();
            Console.WriteLine(newkissa.PalautaElaimenNimi() + " " + newkissa.PalautaElaimenIka() + " " + newkissa.palautaOnLihanSyoja());

            Koira newKoira = new Koira();
            newKoira.AsetaElaimenNimi("Danny");
            newKoira.AsetaElaimenIka(15);
            newKoira.AsetaOnLihanSyoja(true);
            Console.WriteLine(newKoira.PalautaElaimenNimi()+ " "+ newKoira.PalautaElaimenIka()+" "+ newKoira.palautaOnLihanSyoja());
            newKoira.Aantele();

            

            
            newkissa.Aantele();
            newKoira.Aantele();
        }
    }
}