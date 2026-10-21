using System;

namespace VypisRady
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vizuální oddělení a uvození programu v konzoli pro přehlednost uživatele
            Console.WriteLine("=== PROGRAM 001: Výpis řady čísel ===");
            Console.WriteLine();

            // Vyzvání uživatele k zadání počáteční hranice intervalu
            Console.Write("Zadejte první hodnotu (first): ");
            // Načtení textového řetězce z klávesnice a jeho přetypování na celé číslo,
            // abychom s ním mohl algoritmus provádět matematické operace a porovnávání
            int first = int.Parse(Console.ReadLine());

            // Načtení koncové hranice intervalu
            Console.Write("Zadejte poslední hodnotu (last): ");
            int last = int.Parse(Console.ReadLine());

            // Načtení velikosti a směru prírůstku mezi jednotlivými čísly řady
            Console.Write("Zadejte krok (step): ");
            int step = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--- Výstup ---");

            // Ochranná podmínka proti kritické chybě: nulový krok by v cyklu 
            // vedl k nekonečnému opakování bez posunu v řadě
            if (step == 0)
            {
                Console.WriteLine("Krok nemůže být 0 (způsobil by nekonečný cyklus).");
            }
            // Vetvení pro vzostupnou řadu (např. od 1 do 10 s krokem +2)
            else if (first <= last && step > 0)
            {
                // Cyklus for s řídicí proměnnou 'i': začíná na počáteční hodnotě 'first',
                // běží, dokud nepřekročí 'last', a v každém kroku se zvýší o 'step'
                for (int i = first; i <= last; i += step)
                {
                    Console.WriteLine(i);
                }
            }
            // Vetvení pro sestupnou řadu (např. od 10 do 1 s krokem -2)
            else if (first >= last && step < 0)
            {
                // Pro sestupnou řadu hlídáme, aby řídicí proměnná 'i' neklesla pod 'last'
                for (int i = first; i >= last; i += step)
                {
                    Console.WriteLine(i);
                }
            }
            // Záchytný blok pro logické rozpory v zadání (např. generování z 1 do 10, ale s záporným krokem)
            else
            {
                Console.WriteLine("Směr kroku neodpovídá relaci mezi první a poslední hodnotou.");
            }
        }
    }
}