namespace pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Coletaveis -");

            Console.WriteLine("Digite quantas moedas de ouro você coletou:  ");
            int moedas = int.Parse(Console.ReadLine());
            //Cada moeda de ouro vale 10 pontos
            int pontuacaoMoedas = moedas * 10;

            Console.WriteLine("Digite quantas gemas azuis você coletou: ");
            int gemas = int.Parse(Console.ReadLine());
            //Cada gema azul vale 50 pontos
            int pontuacaoGemas = gemas * 50;

            int pontuacaoTotal = pontuacaoMoedas + pontuacaoGemas;

            Console.WriteLine("Pontuação das moedas: " + pontuacaoMoedas);
            Console.WriteLine("Pontuação das gemas: " + pontuacaoGemas);
            Console.WriteLine("Pontuação total: " + pontuacaoTotal);

        }
    }
}
