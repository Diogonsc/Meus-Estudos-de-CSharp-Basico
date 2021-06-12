using System;
using System.Globalization;

namespace Aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 34;
            string z = "Diogo";
            char w = 'M';

            Console.WriteLine("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais.");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais.");

            Console.WriteLine();
            Console.WriteLine("O aluno " + z + " tem " + y + " anos e seu sexo é " + w + ".") ;

            Console.ReadLine();
        }
    }
}
