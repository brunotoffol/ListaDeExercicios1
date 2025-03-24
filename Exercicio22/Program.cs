namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número. 0, 1, 1 , 2 , 3 , 5, 8 , 13 , 21 , 34


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite um valor pra realizarmos a demonstração da sequência Fibonacci: ");
            int sequencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            int proximoNumero = 0;
            int numeroAnterior = 0;

            for (int i = 0; i <= sequencia; i++)
            {
                Console.WriteLine(proximoNumero);
                if (proximoNumero == 0)
                {
                    proximoNumero = 1;
                }
                else
                {                   
                    int numeroTemporario = proximoNumero;
                    proximoNumero = proximoNumero + numeroAnterior;
                    numeroAnterior = numeroTemporario;
                }
            }

            Console.ReadLine();


        }
    }
}
