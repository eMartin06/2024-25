using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szöveg beolvasása billentyűzetről és eltárolása egy változóban

            Console.Write("Kérem adja meg a nevét. ");
            string name = Console.ReadLine(); //A ReadLine olvassa be a szöveget
            Console.WriteLine($"Szia {name}!");
            Console.ReadKey();

            //int tipusú érték beolvasása
            Console.Write("kérem adja meg a fizetését: ");
            int fizu = int.Parse(Console.ReadLine()); //int.parse(szöveg) a szöveget int tipusúvá alakítja
            //Console.Write($"{fizu}");
            //van long.parse, byte.Parse stb. is
            if (fizu < 350000)
                Console.WriteLine("Keress uúj munkahelyet!");

            else
                Console.WriteLine("Nem rossz, de azért még lehet fejlődni");


            Console.ReadKey(); //vár egy billentyű leütésre
        
        }
    }
}
