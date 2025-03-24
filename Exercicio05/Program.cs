namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
            vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.*/

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Informe o salário base: ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Informe o total de vendas realizadas: ");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Informe o porcentual de comissão sobre as vendas: ");
            decimal porcentualVendas = Convert.ToDecimal(Console.ReadLine());

            decimal totalComissão = (porcentualVendas / 100) * totalVendas;
            decimal total = totalComissão + salarioBase;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Seu salário total para este mês é R${total}, sendo R${salarioBase} do seu salário e R${totalComissão} de comissão de vendas.");
            Console.ReadLine();


        }
    }
}
