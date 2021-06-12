using System;
using System.Globalization;

namespace Aula_25_Estrutura_Repetitiva_Faça_Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;
            char nrepetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InstalledUICulture));
                Console.Write("Desja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
                
            }
            while (repetir == 's');   

            Console.ReadLine();
        }
    }
}
