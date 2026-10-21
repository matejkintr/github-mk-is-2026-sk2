using System;

namespace VypisRady
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM 001: Výpis řady čísel ===");
            Console.WriteLine();

            Console.Write("Zadejte první hodnotu (first): ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Zadejte poslední hodnotu (last): ");
            int last = int.Parse(Console.ReadLine());

            Console.Write("Zadejte krok (step): ");
            int step = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--- Výstup ---");

            if (step == 0)
            {
                Console.WriteLine("Krok nemůže být 0 (způsobil by nekonečný cyklus).");
            }
            else if (first <= last && step > 0)
            {
                for (int i = first; i <= last; i += step)
                {
                    Console.WriteLine(i);
                }
            }
            else if (first >= last && step < 0)
            {
                for (int i = first; i >= last; i += step)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Směr kroku neodpovídá relaci mezi první a poslední hodnotou.");
            }
        }
    }
}
