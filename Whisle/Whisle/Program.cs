namespace Whisle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilli sorsapilli = new Pilli("Kvaak");
            Pilli kukkopilli = new Pilli("Peef");
            sorsapilli.soi();
            kukkopilli.soi();
            sorsapilli.soi();
        }
    }
}
