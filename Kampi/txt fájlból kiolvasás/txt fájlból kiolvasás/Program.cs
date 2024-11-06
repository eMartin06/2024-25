using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace txt_fájlból_kiolvasás
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fájl olvasása soronként, amíg nem jutunk el a végére
            int összeg = 0;
            int szám = 0;
            List<int> kicsi = new List<int>();
            StreamReader lista = new StreamReader("lista.txt", Encoding.UTF8);
            while (!lista.EndOfStream)//addig olvasok amíg nem jutok a végére
            {
                string sor = lista.ReadLine(); //Kiolvasom a következő sorts
                összeg += int.Parse(sor);
                Console.WriteLine(sor);
                szám = int.Parse(sor);
                if (szám<3000)
                {
                    kicsi.Add(szám);
                }

            }

            lista.Close();
            StreamWriter fp = new StreamWriter("kicsi.txt", false, Encoding.UTF8);
            foreach (var item in kicsi)
            {
                fp.WriteLine(item);
            }
            fp.Close();
            
            Console.WriteLine($"A számuk összege: {összeg}");
            Console.ReadKey();
        }
    }
}
