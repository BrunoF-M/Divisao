using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double numerador;
            double denominador;

            Console.Write("Digite um numerador!: ");
            numerador = double.Parse(Console.ReadLine());


            Console.Write("\nDigite um Denominador!: ");
            denominador = double.Parse(Console.ReadLine());

            if (denominador ==0)
            {
                Console.WriteLine("\nnão é possivel dividir por 0");
                Console.WriteLine();
                Console.Write("\nPress enter to finish...");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }

            double resu1 = numerador/denominador;

            Console.WriteLine($"\n{numerador} dividido por {denominador} é {resu1}");
 
            Console.WriteLine();
            Console.Write("\nPress enter to finish...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
