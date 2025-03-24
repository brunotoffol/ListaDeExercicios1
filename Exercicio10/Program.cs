namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
                pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
                venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
                Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
                quantidades de pães e de broas, e depois calcular os dados solicitados. */

            double paozinho = 0.12;
            double broa = 1.5;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Informe a quantidade de pães vendidos: ");
            double qtdPaozinhos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de broas vendidas: ");
            double qtdBroas = Convert.ToDouble(Console.ReadLine());

            double totalPaozinho = paozinho * qtdPaozinhos;
            double totalBroa = broa * qtdBroas;
            double totalVendas = totalPaozinho + totalBroa;

            double poupanca = 0.1 * totalVendas;

            Console.WriteLine($"O total de vendas do dia foi R${totalVendas}, o valor a ser depositado na poupança é R$ {poupanca:f3}");
            Console.ReadLine();
        }
    }
}
