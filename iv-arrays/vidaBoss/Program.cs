using System.Reflection.PortableExecutable;

namespace vidaBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vidaBoss = { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', };

            Console.WriteLine("Digite o dano causado: [0 a 10]");
            int dano = int.Parse(Console.ReadLine());

            if(dano > 10 || dano < 0)
            {
                Console.WriteLine("Apenas valores entre 0 e 10!");
            }
            else
            {
                for (int i = vidaBoss.Length - 1; i >= vidaBoss.Length - dano; i--)
                {
                    vidaBoss[i] = '_';
                }

                Console.Write("Vida do boss: ");
                for (int i = 0; i < vidaBoss.Length; i++)
                {
                    Console.Write(vidaBoss[i] + " ");
                }
            }
        }
    }
}
