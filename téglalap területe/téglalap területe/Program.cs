using System;

namespace téglalap_területe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ra = r.Next(0, 100);
            Console.WriteLine(ra);
            /*
            Console.WriteLine("Add meg a téglalap egyik oldalát");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a téglalap másik oldalát");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Ez a téglalap területe {a*b}");
            Console.ReadLine();*/

            /*
            float[] v = { float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()) };
            Console.WriteLine($"tégla területe: {v[1] * v[3]}");
            Console.ReadLine(); */
        }
    }
}
