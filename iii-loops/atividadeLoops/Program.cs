namespace atividadeLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.WriteLine("============= MENU ============");
                Console.WriteLine("| [1] Tabuada                 |");
                Console.WriteLine("| [2] Avaliar programa        |");
                Console.WriteLine("| [3] Joguinho de adivinhação |");
                Console.WriteLine("| [4] Sair                    |");
                Console.WriteLine("===============================");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Digite um número para ver sua tabuada: ");
                        int numeroTabuada = int.Parse(Console.ReadLine());

                        if (numeroTabuada > 0)
                        {
                            for (int i = 0; i <= 10; i++)
                            {
                                Console.WriteLine(numeroTabuada + " x " + i + " = " + numeroTabuada * i);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Apenas números entre positivos");
                        }
                        break;

                    case 2:

                        double nota;
                        do
                        {
                            Console.WriteLine("Avalie o programinha com uma nota entre 0 e 10 :3");
                            nota = double.Parse(Console.ReadLine());

                            if (nota < 0 || nota > 10)
                            {
                                Console.WriteLine("Apenas números entre 0 e 10");
                            }
                            else
                            {
                                Console.WriteLine("Sua nota " + nota + " foi registrada com sucesso");
                            }
                        } while (nota < 0 || nota > 10);

                        break;

                    case 3:
                        Random random = new Random();
                        int numeroAleatorio = random.Next(1, 6);

                        Console.WriteLine("Tente adivinhar o número que o computador escolheu");
                        Console.WriteLine("Digite um número [1-5]");
                        int numeroEscolhido = int.Parse(Console.ReadLine());

                        if (numeroEscolhido == numeroAleatorio)
                        {
                            Console.WriteLine("Parábens você ganhou!!");
                        }
                        else
                        {
                            Console.WriteLine("ERROU");
                        }

                        break;
                    case 4:
                        Console.WriteLine("..Saindo..");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (menu != 4);
        }
    }
}
