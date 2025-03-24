namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie um programa para calcular a média harmônica das notas de um Aluno
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite suas notas: ");
            string[] notasInformadas = Console.ReadLine().Split(' ');
            double[] notasConvertida = new double[notasInformadas.Length];

            
            for (int i = 0; i < notasInformadas.Length; i++)
            {
                notasConvertida[i] = double.Parse(notasInformadas[i]);
            }

            
            double somaNotas = 0;
            for (int i = 0; i < notasInformadas.Length; i++)
            {
                somaNotas += 1.0 / notasConvertida[i];
            }

            double mediaNotas = notasConvertida.Length / somaNotas;
            Console.WriteLine($"A média harmônica é: {mediaNotas}");
            Console.ReadLine();
        }
    }
}

