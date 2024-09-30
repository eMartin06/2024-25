using System;

namespace feladatswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot 1-7 között!");
            int szám = int.Parse(Console.ReadLine());
            switch (szám)
            {
                case 1:
                    Console.WriteLine("Hétő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;
                default:
                    Console.WriteLine("nem 1-7 közötti számot adott meg.");
                    break;
            }
        }
    }
}
