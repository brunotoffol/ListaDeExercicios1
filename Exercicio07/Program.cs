namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

            Console.WriteLine("----------------------------");
            Console.WriteLine("Informe a quantidade de notas que deseja fazer a média: ");
            int numeroDeNotas = int.Parse(Console.ReadLine());

            double somaDosPesos = 0;
            double somaNotas = 0;

            for (int i = 0; i < numeroDeNotas; i++)
            {
                Console.WriteLine($"Digite sua nota: ");
                double valorNota = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o peso para a nota informada: ");
                double pesoNota = int.Parse(Console.ReadLine());

                somaNotas += valorNota * pesoNota;
                somaDosPesos += pesoNota;
            }

            double mediaNotas = somaNotas / somaDosPesos;
            Console.WriteLine($"A média ponderada para as suas notas é: {mediaNotas}");

            Console.ReadLine();
        }
    }
}
