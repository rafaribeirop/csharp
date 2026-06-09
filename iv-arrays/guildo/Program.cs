namespace guilda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] membros = new int[7];

            int soma = 0;
            for (int i = 0; i < membros.Length;i++)
            {
                Console.WriteLine("Digite o xp do " + (i + 1) + "o membro: ");
                membros[i] = int.Parse(Console.ReadLine());

                soma += membros[i];
            }

            double media = (double)soma / membros.Length;

            List <int> jogadorMaiorMedia = new List<int>();

            //Quais jogadores tem xp maior que a média
            for(int i = 0; i < membros.Length; i++)
            {
                if (membros[i] > media)
                {
                    jogadorMaiorMedia.Add(i + 1);
                }
            }

            Console.WriteLine("Membros acima da média");
            for(int i = 0; i < jogadorMaiorMedia.Count; i++)
            {
                Console.WriteLine("Membro: " + jogadorMaiorMedia[i]);
            }
        }
    }  
}
