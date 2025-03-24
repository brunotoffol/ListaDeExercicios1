namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
               impostos. Imprima o salário inicial, o salário com o aumento e o salário final. */

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Informe o seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double ajusteSalario = salario * 0.15;
            double salarioAjustado = salario + ajusteSalario;


            double imposto = salarioAjustado * 0.08;
            double salarioFinal = salarioAjustado - imposto;

            Console.WriteLine($"Seu salário atual é R${salario:F2}, após o aumento de 15% seu novo salário é R${salarioAjustado:F2}, após a redução de 8% dos impostos seu salário será R${salarioFinal:F2}");
            Console.ReadLine();
        }
    }
}
