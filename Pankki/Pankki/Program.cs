namespace Pankki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Velka laina = new Velka(1000, 5);
            laina.TulostaSaldo();
            laina.OdotaVuosi();
            laina.TulostaSaldo();
        }
    }
}