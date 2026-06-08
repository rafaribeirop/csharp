namespace bauTesouro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] moedasOuro = new int[10];

            Console.WriteLine("Você encontrou 10 baús do tesouro !");

            int maiorMoedas = 0;
            int menorMoedas = int.MaxValue;
            int bauMaior = 0;
            int bauMenor = 0;

            for (int i = 0; i < moedasOuro.Length; i++)
            {
                Console.WriteLine("Digite a quantidade de moedas de ouro no " + (i + 1) + "o baú: ");
                moedasOuro[i] = int.Parse(Console.ReadLine());

               
                if (moedasOuro[i] > maiorMoedas)
                {
                    maiorMoedas = moedasOuro[i];
                    bauMaior = i + 1;
                }

                if (moedasOuro[i] < menorMoedas)
                {
                    menorMoedas = moedasOuro[i];
                    bauMenor = i + 1;
                }
            }

            Console.WriteLine("Maior quantidade de moedas: " + maiorMoedas + " Encontrada no bau " + bauMaior);
            Console.WriteLine("Encontrada no bau " + bauMaior);

            Console.WriteLine("Menor quantidade de moedas: " + menorMoedas + " Encontrada no bau " + bauMenor);
            Console.WriteLine("Encontrada no bau " + bauMenor);


        }
    }
}
