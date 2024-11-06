using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktura
{
    class Program
    {
         struct Adat
        {
            public string név;
            public string város;
            public int fizetés;

        }
        static void Main(string[] args)
        {
            Adat pista,feri;
            pista.név = "Savany István";
            pista.város = "Ruzsa";
            pista.fizetés = 500000;
            feri.név = "Csipás Ferenc";
            pista.város = "Dóc";
            pista.fizetés = 400000;

            Console.WriteLine(pista.név);

            // olyan lista, ami adat struktúrákat tartalmaz

            List<Adat> adatok = new List<Adat>();
            Adat temp;
            temp.név = "Joó András";
            temp.város = "Szeged";
            temp.fizetés = 520000;
            adatok.Add(temp);

            temp.név = "Harsányi Gábor";
            temp.város = "Budapest";
            temp.fizetés = 12000000;
            adatok.Add(temp);
                       

            // Jelenítsük meg az adatok lista tartalmát a képernyőn

            foreach (Adat item in adatok)
            {
                Console.WriteLine($" Név: {item.név}, Város: {item.város}, fizetés: {item.fizetés}");
            }

            Console.ReadKey();
        }
    }
}
