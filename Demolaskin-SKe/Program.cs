using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolaskin_SKe
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            Console.WriteLine("Tämä on yhteenlaskuohjelma");
            Console.Write("Anna luku 1: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku 2: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Antamiesi lukujen summa on: " + (luku1 + luku2));
            Console.WriteLine("");
            Console.WriteLine("Kiitos, paina Enter lopettaaksesi");
            Console.ReadLine();
        }
    }
}
