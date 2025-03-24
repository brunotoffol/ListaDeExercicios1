namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para verificar se um número é primo.
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o número para ser verificado: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (checkNumeroPrimo(numero))
                    Console.WriteLine($"O número {numero} é um número primo.");
                else
                    Console.WriteLine($"O número {numero} não é um número primo.");
            }
            
            Console.ReadLine();

            static bool checkNumeroPrimo(int numero)
            {
                if (numero == 2)
                    return true;
                else if (numero < 2 || numero % 2 == 0)
                {
                    return false;
                }
                else
                {
                    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
                    {
                        if (numero % i == 0)
                            return false;
                    }
                    return true;
                }

            }
        }
    }
}
