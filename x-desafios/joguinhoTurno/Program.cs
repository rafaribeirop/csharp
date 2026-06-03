namespace joguinhoTurno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atributos do personagem
            int vidaPersonagem = 120;
            int focousPersonagem = 1;
            int danoBasePersonagem = 30;

            //Atributos do boss
            int vidaBoss = 300;
            int danoBaseBoss = 20;


            //Inicio do combate
            int turno = 1;
            int danoPersonagem;
            do
            {
                Console.WriteLine("Turno " + turno);
                bool vivoP = personagemVivo(vidaPersonagem);
                if (vivoP)
                {
                    Console.WriteLine("Escolha a habilidade");
                    Console.WriteLine("| [1] Ataque básico | [2] Ataque Carregado | [3] Curar |");

                    //Dano causado com base na habilidade escolhida
                    int habilidadeEscolhida = int.Parse(Console.ReadLine());

                    switch (habilidadeEscolhida)
                    {
                        case 1:
                            //Ataque básico: Causa dano igual ao dano base do personagem
                            danoPersonagem = ataqueBasico(danoBasePersonagem);
                            break;

                        case 2:
                            //Ataque carregado: Causa dano igual ao dobro do dano base do personagem
                            danoPersonagem = ataqueCarregado(danoBasePersonagem);
                            break;

                        case 3:
                            //Curar: Restaura 40 vida do personagem, mas não causa dano ao boss
                            vidaPersonagem = pocaoCura(vidaPersonagem);
                            danoPersonagem = 0;
                            break;

                        default:
                            //Se o usuário escolher um valor inválido, ele perde a oportunidade de atacar
                            danoPersonagem = 0;
                            break;
                    }

                    vidaBoss -= danoPersonagem;

                    hud(vidaPersonagem, vidaBoss);
                    Console.WriteLine();
                }
               
                bool vivoB = bossVivo(vidaBoss);
                if (vivoB)
                {
                    Console.WriteLine("Ataque do boss");
                    Console.WriteLine();
                    //Calcula o dano causado pelo boss e aplica ao personagem
                    int danoBoss = calcularDanoBoss(danoBaseBoss);
                    vidaPersonagem -= danoBoss;

                    if (vidaBoss < 0)
                    {
                        vidaBoss = 0;
                    }

                    if (vidaPersonagem < 0)
                    {
                        vidaPersonagem = 0;
                    }

                    hud(vidaPersonagem, vidaBoss);
                    Console.WriteLine();
                }
             
                turno++;

            } while (vidaPersonagem > 0 && vidaBoss > 0);

            if (vidaPersonagem <= 0)
            {
                Console.WriteLine("Você foi derrotado pelo boss!");
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("Parabéns! Você derrotou o boss!");

            }

            static void hud(int vidaP, int vidaB)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("| Vida: " + vidaP + " | Boss: " + vidaB + " |");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            }

            static int calcularDanoBoss(int danoBase)
            {
                Random random = new Random();
                int habilidadeBoss = random.Next(1, 3); //Gera um número aleatório entre 1 e 2 para a habilidade do boss
                int danoTotal;

                if (habilidadeBoss == 1)
                {
                    Console.WriteLine("O boss deu um ataque básico");
                    danoTotal = danoBase;
                }
                else
                {
                    Console.WriteLine("O boss deu um ataque carregado");
                    danoTotal = danoBase * 2;
                }

                return danoTotal;
            }

            static int ataqueBasico(int danoBase)
            {
                int danoTotal = danoBase;
                return danoTotal;
            }

            static int ataqueCarregado(int danoBase)
            {
                int danoTotal = danoBase * 2;
                return danoTotal;
            }

            static int pocaoCura(int vida)
            {
                int vidaRestaurada = vida + 40;
                if (vidaRestaurada > 120)
                {
                    vidaRestaurada = 120;
                }
                return vidaRestaurada;
            }

            static bool bossVivo(int vidaBoss)
            {
                bool vivo;
                if (vidaBoss > 0)
                {
                    vivo = true;
                }
                else
                {
                    vivo = false;
                }
                return vivo;
            }

            static bool personagemVivo(int vidaPersonagem)
            {
                bool vivo;
                if (vidaPersonagem > 0)
                {
                    vivo = true;
                }
                else
                {
                    vivo = false;
                }
                return vivo;


            }
        }
    }
}
