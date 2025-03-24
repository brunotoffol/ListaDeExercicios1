namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Informe o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double somaAB = valorA + valorB;

            if (somaAB < valorC)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("A soma de A+B é menor que C");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("A soma de A+B é maior que C");
                Console.ReadLine();
            }


            
        }
    }
}
