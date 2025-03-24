namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
             * a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
             * b. Pesquise sobre “fatorial” */

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Insira um valor: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;

            Console.Write($"{valorA}! = ");
            for (int i = valorA; i > 1; i--)
            {
                fatorial *= i;
                Console.Write(i + " x ");
            }

            fatorial *= 1;
            Console.WriteLine("1 = " + fatorial);

            Console.ReadLine();   


        }
    }
}
