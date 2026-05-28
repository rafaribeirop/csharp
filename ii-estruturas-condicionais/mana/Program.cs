namespace mana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Recuperar mana -");
            Console.Write("Digite sua mana atual: [Max: 250]: ");
            int mana = int.Parse(Console.ReadLine());

            if (mana > 250)
            // Caso o usuário digite um valor maior que o máximo permitido, exibe uma mensagem de erro.
            {
                Console.WriteLine("Digito inválido");
            } else if (mana == 250)
            // Caso a mana do usuário já esteja cheia, exibe uma mensagem informando que não é necessário tomar poções.
            {
                Console.WriteLine("Sua mana já está cheia!");
            }
            else
            {
                Console.Write("Digite quantas poções deseja tomar: ");
                int pocoes = int.Parse(Console.ReadLine());

                mana += (pocoes * 25);

                if (mana > 250)
                // Caso a mana do usuário ultrapasse o máximo permitido após tomar as poções, ajusta a mana para o valor máximo.
                {
                    mana = 250;
                }

                Console.WriteLine("Mana atual: " + mana);
            }

        }
    }
}
