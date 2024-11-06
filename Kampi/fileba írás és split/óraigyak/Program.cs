using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace óraigyak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            // 2020 óta
            // List<int> number2 = new();


            string nevek = "Joó András, Galadriel, Sauron, Morgoth, Frodó, Bilbó";

            // szeretnénk szétválasztani a ,-vel tagolt elemeket
            string[] names = nevek.Split(',');

            //írjuk ki a neveket egy szövegfileba
            StreamWriter fp = new StreamWriter("nevek.txt", false, Encoding.UTF8); //false jelenti, hogy nem hozzáfüzés (append) van hanem törlődik a file tartalma
            foreach (var item in names) // a names tömb minden elemét végigolvasom, az lista elemi egymás után az item változóba kerülnek
            {
                fp.WriteLine(item); //Új sort ír ki a fileba
            }

            fp.Close();


            Console.ReadKey();
        }
    }
}
