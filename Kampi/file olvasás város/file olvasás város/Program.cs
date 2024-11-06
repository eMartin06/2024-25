using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_olvasás_város
{
    class Program
    {
        static void Main(string[] args)
        {
            int összeg = 0;
            StreamReader lista = new StreamReader("adatok.txt", Encoding.UTF8);
            Console.Write("Add meg a cél várost (Szeged,Pest,Dóc). ");
            string város = Console.ReadLine();
            while (!lista.EndOfStream)
            {
                string[] tartalom = lista.ReadLine().Split();
                if (tartalom[1]== város)
                {
                    összeg += int.Parse(tartalom[2]);
                }
                
            }
            Console.Write($"Annak a városnak tartozó emberek fizetésének összege: {összeg}");
            lista.Close();
            Console.ReadKey();

        }

    }
}
