using System;

namespace _6for
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int total = 0;
            Console.WriteLine("Program oblicza sumę pięciu liczb.");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Wprowadź liczbę: ");
                number = int.Parse(Console.ReadLine());
                total = total + number;
            }
            Console.WriteLine($"Suma jest równa {total}");
        }
    }
}
