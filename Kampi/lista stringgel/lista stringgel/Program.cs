using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_stringgel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Adj meg a {i+1}. nevet! ");
                nevek.Add(Console.ReadLine());
            }

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }
            Console.ReadLine();
        }
    }
}
