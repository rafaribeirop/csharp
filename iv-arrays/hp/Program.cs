namespace hp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 50, 50, 50, 50, 50 };

            while (true)
            {
                Console.WriteLine("\nHP dos monstros:");

                for (int i = 0; i < hp.Length; i++)
                    Console.Write(hp[i] + " ");

                Console.WriteLine();

                bool todosMortos = true;

                foreach (int vida in hp)
                {
                    if (vida > 0)
                    {
                        todosMortos = false;
                        break;
                    }
                }

                if (todosMortos)
                {
                    Console.WriteLine("Todos os monstros foram derrotados!");
                    break;
                }

                Console.Write("Escolha um alvo (0 a 4): ");
                int alvo = int.Parse(Console.ReadLine());

                hp[alvo] = Math.Max(0, hp[alvo] - 20);

                if (alvo > 0)
                    hp[alvo - 1] = Math.Max(0, hp[alvo - 1] - 5);

                if (alvo < 4)
                    hp[alvo + 1] = Math.Max(0, hp[alvo + 1] - 5);
            }
        }
    }
}
    

