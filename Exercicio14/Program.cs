namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

            double[] valoresOrdenados;
            valoresOrdenados = new double[3];

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informe o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                if (valor2 > valor3)
                    valoresOrdenados = new double[] {valor1, valor2, valor3};

                else
                    valoresOrdenados = new double[] {valor1, valor3, valor2};
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                if (valor1 > valor3)
                    valoresOrdenados = new double[] {valor2, valor1, valor3};
                
                else
                    valoresOrdenados = new double[] {valor2, valor3, valor1};
            }
            else
            {
                if (valor1 > valor2)
                    valoresOrdenados = new double[] {valor3, valor1, valor2};
                else
                    valoresOrdenados = new double[] {valor3, valor2, valor1};
            }

            Console.WriteLine("Valores em ordem decrescente: ");
            foreach (var valor in valoresOrdenados)
            {
                Console.WriteLine(valor.ToString());
            }

            Console.ReadLine();
        }
    }
}
