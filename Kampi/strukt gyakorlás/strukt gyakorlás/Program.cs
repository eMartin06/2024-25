using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strukt_gyakorlás
{
    class Program
    {
        struct auto
        {
            public string rendszám;
            public string tipus;
            public string szin;

        }
        static void Main(string[] args)
        {
            List<auto> adatok = new List<auto>();
            auto temp;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Add meg a(z) {i+1}. autó rendszámát ");
                temp.rendszám = Console.ReadLine();
                Console.Write($"Add meg a(z) {i + 1}. autó tipusát ");
                temp.tipus = Console.ReadLine();
                Console.Write($"Add meg a(z) {i + 1}. autó szinét ");
                temp.szin = Console.ReadLine();

                adatok.Add(temp);
            }

            foreach (auto adat in adatok)
            {
                Console.WriteLine($"A(z) {adat.rendszám} rendszámú, {adat.tipus} tipusú és {adat.szin} színű autó");
                Console.ReadLine();
            }
        }
    }
}
