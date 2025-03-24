namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Insira a temperatura em Celsius:");
            double tempCelsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            double tempFahrenheit = (tempCelsius * 1.8) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é: {tempFahrenheit}ºF");
            Console.ReadLine(); 
        }
    }
}
