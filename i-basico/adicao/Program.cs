using System.Numerics;

namespace adicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1o número: ");
            // Console.ReadLine() lê a entrada do usuário como uma string, e int.Parse() converte essa string em um número inteiro.
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2o número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine(n1 + " + " + n2 + " = " + soma);
        }
    }
}
