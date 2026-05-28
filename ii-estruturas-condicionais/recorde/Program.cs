namespace recorde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu recorde: ");
            int recorde = int.Parse(Console.ReadLine());

            Console.Write("Digite a sua pontuação atual: ");
            int pontuacaoAtual = int.Parse(Console.ReadLine());

            if (pontuacaoAtual > recorde)
            {
                recorde = pontuacaoAtual;
                Console.WriteLine("Novo recorde alcançado!!");
            }

            Console.WriteLine("Recorde: " + recorde);
            Console.WriteLine("Pontuação atual: " + pontuacaoAtual);

        }
    }
}
