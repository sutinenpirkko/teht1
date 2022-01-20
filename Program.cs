// Esimerkkiratkaisu tehtävää 1
// Pirkko Sutinen 13.4.2021
// pirkko.sutinen@sasky.fi

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
            { // Joko VSC tai jotain muuta pelleilee mut en saa mitään error codes tästä
            // koodista, ja se ei vaan koskaan siirry seuraavaan kysymykseen enkä tiedä miks
            //mutta olen nyt editoinut tämän kommentin tähän koodiin jonka forkkasin ja kloonasin
            // omalle koneelleni.
                Console.WriteLine($"Ajattele {nimi.ToUpper()}, vuonna 2031 olet jo {ika + 10} vuotta vanha");
            }
            else
            {
                Console.WriteLine("Anna ikä numerona");
            }
        }
    }
}
