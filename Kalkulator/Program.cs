using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wykonanie działanie na 2 liczbach

            Console.WriteLine("Podaj 1. liczbę: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak działania: ");
            string z = Console.ReadLine();
            Console.WriteLine("Podaj 2. liczbę: ");
            double b = double.Parse(Console.ReadLine());

            if (z == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (z == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (z == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (z == "/")
            {
                Console.WriteLine(a / b);
            }
            else
                Console.WriteLine("Nie ma takiego działania.");
            Console.ReadKey();
        }
    }
}
