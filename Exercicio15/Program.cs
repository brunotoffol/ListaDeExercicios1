using System;

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobrea condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². 
             * Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
                    ● IMC em adultos Condição
                    ● Abaixo de 18,5
                    ● Abaixo do peso
                    ● Entre 18,5 e 25 Peso normal
                    ● Entre 25 e 30
                    ● Acima do peso
                    ● Acima de 30 obeso
            */

            Console.WriteLine("--------------------------------------");
            Console.Write("Informe seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.Write("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Seu IMC é {imc:F2}.");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Você está com o peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso.");
            }
            else
            {
                Console.WriteLine("Você está obeso");
            }

            Console.ReadLine();

        }
    }
}
