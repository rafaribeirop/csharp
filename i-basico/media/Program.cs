namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine("Sua média é: " + media);
        }
    }
}
