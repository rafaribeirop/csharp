namespace poder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] poderInimigo = new int[8];

            for (int i = 0; i < poderInimigo.Length; i++) 
            {
                Console.WriteLine("Digite o poder do inimigo: ");
                poderInimigo[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Digite o nível de alerta: ");
            int nivelAlerta = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < poderInimigo.Length; i++)
            { 
                if (poderInimigo[i]  >= nivelAlerta)
                {
                    //Mostrar apenas os poderes dos inimigos que são maiores ou iguais ao nível de alerta
                    Console.WriteLine(poderInimigo[i]);
                }
            }

        }
    }
}
