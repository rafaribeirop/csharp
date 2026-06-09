namespace jogador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jogador = { "Alanzoka", "DuduGameplays", "PedrinMinecraft", "RafaJogadas", "Meowgg" };

            Console.WriteLine("Top 5 jogadoes");
            Console.WriteLine();

            for (int i = 0; i < jogador.Length; i++)
            {
                Console.WriteLine(jogador[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Digite o nome do jogador que deseja substituir ");
            string novoJogador = Console.ReadLine();

            for (int i = 0; i < jogador.Length; i++)
            {
                if (novoJogador.Equals(jogador[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite o novo nome: ");
                    jogador[i] = Console.ReadLine();
                }
            }

            Console.WriteLine();
            for(int i = 0; i < jogador.Length; i++)
            {
                Console.WriteLine(jogador[i]);
            }

        }

    }
    
}
