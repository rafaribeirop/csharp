namespace lojinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesPocoes = {"Cura", "Mana", "Força", "Velocidade", "Visão noturna" };
            int[] precosPocoes = { 50, 30, 70, 40, 60 };

            //Menu da loja de poções
            Console.WriteLine("==== Lojinha =====");
            for (int i = 0; i < nomesPocoes.Length; i++)
            {
                Console.Write("[" + (i + 1) + "]" + nomesPocoes[i] + " - ");
                Console.Write("$"+ precosPocoes[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Qual poção deseja comprar? [Digite seu índice]");
            int comprarPocao = int.Parse(Console.ReadLine());
            int indice = comprarPocao - 1;

            //Verificar se o índice é válido
            if (comprarPocao > precosPocoes.Length || comprarPocao < 1)
            {
                Console.WriteLine("Indice inválido");
            } else
            {
                Console.WriteLine("$" + precosPocoes[indice]);
                Console.WriteLine("Digite seu dinheiro: ");
                int dinheiro = int.Parse(Console.ReadLine());

                // Verificar se o jogador tem dinheiro suficiente para comprar a poção
                if (dinheiro < precosPocoes[indice])
                {
                    Console.WriteLine("Você não tem dinheiro suficiente");
                }
                else
                {
                    Console.WriteLine("Você comprou uma Poção de " + nomesPocoes[indice]);

                    int troco = dinheiro - precosPocoes[indice];

                    //Verificar troco
                    if (troco > 0)
                    {
                        Console.WriteLine("Seu troco foi de:  $" + troco);
                    }
                }
            }
        }
    }
}
