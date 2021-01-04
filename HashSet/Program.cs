using System;
using System.Collections.Generic;

namespace HashSett
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>() {"Beograd", "Nis", "Kragujevac"};
            
            Console.WriteLine(gradovi.Add("Nis"));
            Console.WriteLine(gradovi.Add("Novi Sad"));
            
            Console.WriteLine("========================================");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            
            Console.WriteLine(gradovi.Add("BEOGRAD"));
            Console.WriteLine(gradovi.Add("NOVI SAD"));

            Console.WriteLine("========================================");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            
            HashSet<string> gradovii = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) {"Beograd", "Nis", "Kragujevac"};
            
            Console.WriteLine(gradovii.Add("NIS"));
            Console.WriteLine(gradovii.Add("BEOGRAD"));

            Console.WriteLine("========================================");
            foreach (var grad in gradovii)
            {
                Console.WriteLine(grad);
            }
            
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
        }
    }
}