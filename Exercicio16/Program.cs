namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

            Console.WriteLine("---------------------------");
            Console.WriteLine("Informe um valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor % 2 == 0)

            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"O valor informado é par.");
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("O valor informado é impar.");
            }

            Console.ReadLine();
        }        
    }
}
