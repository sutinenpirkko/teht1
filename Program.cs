using System;

namespace tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä sinun nimesi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Minkä ikäinen olet?");
            string ika = Console.ReadLine();
            bool tulos;
            int iika;         
            string date = DateTime.Now.ToString("yyyy");
            int vuosi = Int32.Parse(date);
            tulos = int.TryParse(ika, out iika);
            if (tulos)
            {
                Console.WriteLine($"Ajattele {nimi.ToUpper()}, vuonna {vuosi + 10} olet jo {iika + 10} vuotta vanha.");
            }
            else
            {
                Console.WriteLine("Anna ikä numerona");
            }
        }
    }
}
