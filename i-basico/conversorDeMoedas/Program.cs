namespace conversorDeMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Dolares para Reais -");

            Console.WriteLine("Digite o valor em Dolares: ");
            double valorDolar = double.Parse(Console.ReadLine());

            double real = valorDolar * 5.25;

            Console.WriteLine("US$ " + valorDolar + " = " + real.ToString("C"));
        }
    }
}
