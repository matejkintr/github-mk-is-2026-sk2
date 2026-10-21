using System;

namespace VypisRadyPokrocily
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opakovat = true;

            while (opakovat)
            {
                Console.Clear();
                Console.WriteLine("=== PROGRAM 001: Pokročilý výpis řady ===");
                Console.WriteLine();

                // Bezpečné načtení vstupních parametrů pomocí pomocné metody
                int first = NactiCeleCislo("Zadejte první hodnotu (first): ");
                int last = NactiCeleCislo("Zadejte poslední hodnotu (last): ");
                int step = NactiCeleCislo("Zadejte krok (step): ");

                Console.WriteLine();
                Console.WriteLine("--- Generovaná řada ---");

                // Validace logického rozporu nebo nulového kroku
                if (step == 0)
                {
                    Console.WriteLine("Chyba: Krok nemůže být 0.");
                }
                else if ((first < last && step < 0) || (first > last && step > 0))
                {
                    Console.WriteLine("Chyba: Zadaný krok směřuje opačným směrem než je cílová hodnota.");
                }
                else
                {
                    int pocetPrvku = 0;
                    long soucet = 0;

                    // Logika generování řady
                    if (first <= last)
                    {
                        for (int i = first; i <= last; i += step)
                        {
                            Console.Write($"{i} ");
                            pocetPrvku++;
                            soucet += i;
                        }
                    }
                    else
                    {
                        for (int i = first; i >= last; i += step)
                        {
                            Console.Write($"{i} ");
                            pocetPrvku++;
                            soucet += i;
                        }
                    }

                    // Statistická nadstavba
                    Console.WriteLine();
                    Console.WriteLine("\n--- Statistiky řady ---");
                    Console.WriteLine($"Celkový počet prvků: {pocetPrvku}");
                    Console.WriteLine($"Součet všech prvků:  {soucet}");
                }

                Console.WriteLine();
                Console.Write("Chcete zadat další řadu? (a/n): ");
                string odpoved = Console.ReadLine().Trim().ToLower();
                opakovat = (odpoved == "a" || odpoved == "ano");
            }

            Console.WriteLine("Děkuji za použití programu.");
        }

        /// <summary>
        /// Pomocná metoda pro bezpečné načtení celého čísla z konzole.
        /// Ošetřuje neplatné vstupy (písmena, prázdné řetězce).
        /// </summary>
        static int NactiCeleCislo("Zpráva pro uživatele")
        {
            int cislo;
            Console.Write(vyzva);
            while (!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Neplatný vstup! Zadejte prosím platné celé číslo.");
                Console.ResetColor();
                Console.Write(vyzva);
            }
            return cislo;
        }
    }
}