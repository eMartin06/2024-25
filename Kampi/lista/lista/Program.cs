using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tároljunk
            int[] numbers = new int[5];
            numbers[0] = 500;
            numbers[1] = 1500;
            numbers[2] = 50;
            numbers[3] = 15;
            numbers[4] = 3;

            // tömb deklarálása előre megadott értékekkel
            long[] values = { 33, 54545, 4545, 34, 45454, 45, 3434, 34, 4545, 43, 3, 3, 3 };
            /*
             * Így is lehet
             string[] dumák = new string[5] {"csak", "mert", "inkább", "mégse", "naná"};
             */

            // Lista használata. Nem kell előre megmondani a méretét. Bővithető.

            List<string> nevek = new List<string>();
            nevek.Add("Cseppcsányi Ember");
            nevek.Add("Lópici Gáspár");
            nevek.Add("Oriza Triznyák");

            //Lista deklarálása előre megadott értékkel

            List<byte> susmus = new List<byte> {3, 4, 45, 255, 56 };

            //Feladat:
            //Deklaráljon egy 5 elemű int típusú tömbet, majd töltse fel a billentyűzetről beolvasott értékkel.


            int[] számok = new int[5];
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("Adj meg egy teljes számot");
                int szám = int.Parse(Console.ReadLine());
                számok[i]=szám;

            }
            foreach (int dög in számok)
            {
            Console.Write(dög);
            }


    
            Console.ReadKey();
        }
    }
}
