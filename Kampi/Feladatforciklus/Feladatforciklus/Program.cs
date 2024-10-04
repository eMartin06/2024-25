using System;

namespace Feladatforciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            float összeg = 0;
            float min = float.MaxValue;

            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("Add meg egy számot!");
                float szám = float.Parse(Console.ReadLine());
                összeg += szám;
           
                if (min > szám)
                {
                    min = szám;
                }
            }
            Console.WriteLine($"A számok összege: {összeg}, és az átlaga: {összeg/5}");
            Console.WriteLine($"A legkisebb szám a listánól: {min}");
        }
    }
}
