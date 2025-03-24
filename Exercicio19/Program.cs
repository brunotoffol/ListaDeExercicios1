namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.

            int soma = 0;
            int numero;

            for (numero = 1; numero <= 500; numero++)
            {
                if (numero % 2 != 0 && numero % 3 == 0)
                {
                    soma += numero;
                }
            }
            Console.WriteLine($"A soma de todos os números ímpares que são múltiplos de três entre 1 a 500 é: {soma}");
            Console.ReadLine();
        }
    }
}
