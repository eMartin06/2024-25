using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a testsúlyód (kg)");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a testmagasságodat (m)");
            float h = float.Parse(Console.ReadLine());

            float BMI = m / (h * h);
            Console.WriteLine($"{BMI}");

            if ( BMI< 18.5 )
            {
                Console.WriteLine("Alulsúlyos");
            }
            else if (BMI >= 18.5 && BMI < 24.99 )
            {
                Console.WriteLine("Optimális testsúly");
            }
            else if (BMI >= 25 && BMI < 29.99)
            {
                Console.WriteLine("Túlsúlyos");
            }
            else if (BMI >= 30 && BMI < 34.99)
            {
                Console.WriteLine("Elsőfokú elhízás");
            }
            else if (BMI >= 35 && BMI < 39.99)
            {
                Console.WriteLine("Másodfokú elhízás");
            }
            else
            {
                Console.WriteLine("Harmadfokú elhízás");
            }

            Console.ReadLine();
        }

    }
}
