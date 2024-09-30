using System;

namespace órai__helyetesítés_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Add meg a pontodat!");
            float pont = float.Parse(Console.ReadLine());
            
            if (pont <= 50)
            {
                Console.WriteLine("1-es a dolgozatod");
            }
            else if ( pont <=65)
            {
                Console.WriteLine("2-es a dolgozatod");
            }
            else if  (pont <= 75)
            {
                Console.WriteLine("3-as a dolgozatod");
            }
            else if ( pont <= 85)
            {
                Console.WriteLine("4-es a dolgozatod");
            }
            else
            {
                Console.WriteLine("5-es a dolgozatod");
            }
        */

            Random r = new Random();
            int random = r.Next(100);
            Console.WriteLine(random);
            int random2 = r.Next(20,50);
            Console.WriteLine(random2);

            int random3 = r.Next(20, 50);
            float szam = 0;
            while (szam != random3)
            {
                Console.Write("Találd ki a számot amire gondoltam! ");
                 szam = float.Parse(Console.ReadLine());
                if (szam > random3)
                {
                    Console.WriteLine("Kisebb számot!!");
                }
                else if (szam < random3)
                {
                    Console.WriteLine("Nagyobb számot!");
                }
            }
            Console.WriteLine("Nyertél");
            Console.ReadLine();
        }

    }
}
