// Esimerkkiratkaisu tehtävää 1
// Pirkko Sutinen 13.4.2021
// pirkko.sutinen@sasky.fi
//En saa nyt toimimaan C# mun studio codessa, en saa ajettua ohjelmaa joten tyydyn kirjoittamaan vain kommentin, täytyy korjata tää tänään et voi C# tehdä muutakin kun TMCssä valmista kurssia... T:Ronja
using System;

namespace tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä sinun nimesi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Minä ikäinen olet?");
            string ika = Console.ReadLine();
            bool tulos;
            int iika;
            tulos = int.TryParse(ika, out iika);
            if(tulos)
            {
                Console.WriteLine($"Ajattele {nimi.ToUpper()}, vuonna 2031 olet jo {ika + 10} vuotta vanha");
            }
            else
            {
                Console.WriteLine("Anna ikä numerona");
            }
        }
    }
}
