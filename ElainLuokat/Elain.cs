using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int ika = 0;
        public String nimi = "a";
        private bool OnLihanSyoja;

        public Elain() { }

        public Elain(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        public void AsetaElaimenIka(int uusiika)
        {
            if (uusiika >= 0)
            {
                this.ika = uusiika;
            }
        }
        public void AsetaElaimenNimi(string uusinimi)
        {
            this.nimi = uusinimi;
        }
        public string PalautaElaimenNimi()
        {
            return this.nimi;
        }
        public int PalautaElaimenIka()
        {
            return this.ika;
        }
        public void AsetaOnLihanSyoja(bool LihanSyoja)
        {
            this.OnLihanSyoja = LihanSyoja;
        }
        public bool palautaOnLihanSyoja()
        {
            return this.OnLihanSyoja;
        }
        public virtual void Aantele()
        {
            Console.WriteLine("Uuph");
        }

        public string GenerateName()
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < 6)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;//https://stackoverflow.com/questions/14687658/random-name-generator-in-c-sharp
        }
        public override string ToString()
        {
            return nimi + " " + ika + " onko lihansyöjä " + OnLihanSyoja;
        }
    }
}
