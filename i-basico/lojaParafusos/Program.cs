namespace lojaParafusos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Loja de parafusos -");

            Console.WriteLine("Valor unitário: R$0,10");
            Console.Write("Quantos parafusos deseja comprar: ");
            int parafusos = int.Parse(Console.ReadLine());

            double parafusosTotal = parafusos * 0.10;

            Console.WriteLine("Valor total: " + parafusosTotal.ToString("C"));

        }
    }
}
