namespace Tuote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuote banaani = new Tuote("banaani", 1.1, 13);
            banaani.TulostaTuote();
        }
    }
}