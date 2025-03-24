using System;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. 
             * Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela. */

                      
            Console.WriteLine("-------------------------------");
            Console.Write("Informe o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.Write("Informe o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            int valorC;

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Os valores A e B são iguais, logo foram somados e o resultado é: {valorC}.");
            }
            else
            {
                valorC = valorA * valorB;
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Os valores A e B são diferentes, logo foram multiplicados e o resultado é: {valorC}.");
            }

            Console.ReadLine();
        }
    }
}
