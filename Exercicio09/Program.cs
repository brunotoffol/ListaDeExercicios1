namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informe o comprimento do terreno: ");
            int comprimentoTerreno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a largura do terreno: ");
            int larguraTerreno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            int areaTerreno = comprimentoTerreno * larguraTerreno;
            Console.WriteLine($"A área do terreno é {areaTerreno} m².");
            Console.ReadLine();
        }
    }
}
