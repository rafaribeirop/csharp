namespace gorjeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restaurante");

            Console.WriteLine("O valor da gorjeta é 10% do valor dos pedidos.");
            Console.WriteLine("Digite o valores: ");
            double valor = double.Parse(Console.ReadLine());

            double valorGorjeta = valor * 10 / 100;

            double valorTotal = valor + valorGorjeta;

            Console.WriteLine("Total: " + valorTotal.ToString("C"));

        }
    }
}
