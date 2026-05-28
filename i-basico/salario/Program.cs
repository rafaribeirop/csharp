namespace salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine("Salário líquido: " + salarioLiquido.ToString("C"));
        }
    }
}
