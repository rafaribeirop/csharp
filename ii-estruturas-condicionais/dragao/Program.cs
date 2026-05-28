namespace dragao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- O Dragão foi derrotado -");

            Console.WriteLine("10% da recompensa irá para a taxa da guilda, e o restante será dividido entre os três jogadores!");
            Console.WriteLine("Digite quantas moedas foram coletadas: ");
            int moedas = int.Parse(Console.ReadLine());

            double taxaGuilda = moedas * 10 / 100;

            double moedasPorJogador = (moedas - taxaGuilda) / 3;

            Console.WriteLine("Cada jogador ficou com " + moedasPorJogador + " moedas.");
            Console.WriteLine("A guilda ficou com " + taxaGuilda + " moedas.");

        }
    }
}
