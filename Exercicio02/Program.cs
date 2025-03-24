namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para calcular o volume de um Cilindro

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Insira o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine($"O volume do cilindro é {volume}");

            Console.ReadLine();
        }
    }
}
