namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma caixa retangular   
            
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Insira o valor do comprimento: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());            
            Console.WriteLine("Insira o valor da largura: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            decimal volume = altura * largura * comprimento;
            Console.WriteLine($"O volume da caixa é de {volume}cm³.");
            Console.ReadLine();
        }
    }
}
