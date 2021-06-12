using System;

namespace Aula_30_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for ( int i=0; i<N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.Write("Nomes lidos: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }


            Console.ReadLine();
        }
    }
}
