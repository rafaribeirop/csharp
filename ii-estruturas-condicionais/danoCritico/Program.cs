namespace danoCritico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu dano: ");
            int danoBase = int.Parse(Console.ReadLine());


            Console.WriteLine("Jogue o dado e escreva o número: [1 a 20]");
            int dado = int.Parse(Console.ReadLine());
            
            int danoTotal = 0;

            if (dado > 20 || dado < 1)
            // Se o número do dado não estiver entre 1 e 20, exibe a mensagem de erro
            {
                Console.WriteLine("Apenas números entre 1 e 20");

            } else if (dado == 20)
            // Ataque crítico ocorre quando o número do dado é 20, multiplicando o dano base por 3
            {
                Console.WriteLine("ATAQUE CRÍTICO");
                danoTotal = danoBase * 3;
            }
            else
            // Dano base se mantém para qualquer outro número do dado
            {
                danoTotal = danoBase;
            }

            Console.WriteLine("Seu dano foi: " + danoTotal);
        }
    }
}
