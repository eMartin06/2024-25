using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A változókat deklarálni kell (meg kell mondani, hogy a változónak mi a tipusa)
            string duma = "Szeretem a ... :3"; //string változó
            string lala; //a lala változó string tipusú, de az értéket még nem adtam meg
           // Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(duma);
            byte magasság = 255;
            magasság += 10;
            Console.WriteLine(magasság);
            // 0 lesz a magasság, mert a byte típus 255 ig tárolhat. 255 +1 ebben az esetben 0 lesz.mert túlcsordul a változó

            int number = 100;
            Console.WriteLine(++ number); //előbb növel, aztán értékül adja az eredményt
            Console.WriteLine(number);
            Console.WriteLine("--------------------------------------");
            int number2 = 100;
            Console.WriteLine(number2++); //előbb az eredeti értéket adja eredményül aztán növel
            Console.WriteLine(number2);


            Console.ReadKey();
        }
    }
}
