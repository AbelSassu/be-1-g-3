using System;

namespace es_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Quanti nomi desideri inserire? Inserisci il numero");
            int xNames = int.Parse(Console.ReadLine());
            string[] names = new string[xNames];

            for (int i = 0; i < xNames; i++)
            {
                Console.WriteLine($"Inserisci nome {i}:");
                string nome = Console.ReadLine();
                names[i] = nome;
            }

            Console.WriteLine("Inserisci nome da cercare");
            string searchQuery = Console.ReadLine();
            bool found = false;

            foreach (var name in names)
            {
                if (searchQuery == name)
                {
                    Console.WriteLine($"Il nome {name} è presente nel database ");
                    found = true;
                    break; 
                }
            }

            if (!found)
            {
                Console.WriteLine($"Il nome {searchQuery} non è presente nel database ");
            }

            Console.WriteLine("Quanti numeri vuoi calcolare?");
            int number = int.Parse(Console.ReadLine());
            int[] values = new int[number];

            int tot = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Inserisci il valore del numero {i +1 }");
                int value = int.Parse(Console.ReadLine());
                values[i] = value;
                tot += value;
            }

            double media = (double)tot / number;
            Console.WriteLine($"Il totale degli numeri è: {tot}");
            Console.WriteLine($"La media tra di loro è: {media}");
        }
    }
}
