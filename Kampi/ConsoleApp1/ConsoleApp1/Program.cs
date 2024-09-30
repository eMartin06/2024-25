using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long nagyobb;
            long kisebb;
            Console.Write("Kérem adjon meg egy parancsot (kisebb, nagyobb): ");
            string parancs = Console.ReadLine();
            if (parancs == "kisebb" || parancs == "nagyobb") {
                Console.Write("Kérem az első számot: ");
                long szám1 = long.Parse(Console.ReadLine());
                Console.Write("Kérem a második számot: ");
                long szám2 = long.Parse(Console.ReadLine());

                if (szám1 > szám2)
                {
                    nagyobb = szám1;
                    kisebb = szám2;
                }
                else
                {
                    kisebb = szám1;
                    nagyobb = szám2;
                }

                if (parancs == "nagyobb")
                {
                    Console.WriteLine($"A(z) {nagyobb} a nagyobb szám");

                }
                else if (parancs == "kisebb")
                {
                    Console.WriteLine($"A(z) {kisebb} a nagyobb szám");
                }





            else
            {
                    Console.WriteLine("Értelmezhetetlen parancs!");
            }


            }

            Console.ReadLine();
        }
    }
}
