namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** 3. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
            programa deve solicitar ao usuário:
            ● A quilometragem inicial do veículo no início da viagem.
            ● A quilometragem final ao término da viagem.
            ● A quantidade de combustível consumida durante a viagem(em litros).
            */

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Insira a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de combustível, em litros, consumida na viagem: ");            
            double qtdCombustivel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            double distanciaPercorrida = kmFinal - kmInicial;
            
            double consumoPorKm = distanciaPercorrida / qtdCombustivel;
            Console.WriteLine($"O consumo de combustível foi de aproximadamente {consumoPorKm} litros por kilometro");

            Console.ReadLine();
        }
    }
}
