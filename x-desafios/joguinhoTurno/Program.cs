namespace joguinhoTurno
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            //Atributos do personagem
            int vidaPersonagem = 150;
            int focousPersonagem = 0;
            int danoBasePersonagem = 30;

            //Atributos do boss
            int vidaBoss = 250;
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
                            if (focousPersonagem > 0)
                            {
                                danoPersonagem = ataqueCarregado(danoBasePersonagem);
                                focousPersonagem--;
                            } else
                            {
                                Console.WriteLine("Não há focous suficiente");
                                danoPersonagem = ataqueBasico(danoBasePersonagem);
                            }
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

                    Console.WriteLine("Você deu: " + danoPersonagem + " de dano.");
                    Console.WriteLine();
                    vidaBoss -= danoPersonagem;

                    hud(vidaPersonagem, vidaBoss, focousPersonagem);
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

                    hud(vidaPersonagem, vidaBoss, focousPersonagem);
                    Console.WriteLine();
                }
             
                turno++;
                //A cada turno, o personagem ganha 1 focous
                focousPersonagem++;

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
        }

        //======= MÉTODOS =======

        //Mostrar HUD
        static void hud(int vidaP, int vidaB, int focous)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("| Vida: " + vidaP + " | Focous: " + focous + " | Boss: " + vidaB + " |");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        //Dano do boss: O boss tem uma chance de 50% de causar um ataque básico (dano igual ao dano base do boss) ou um ataque carregado (dano igual ao dobro do dano base do boss) 
        static int calcularDanoBoss(int danoBase)
        {
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

        //Poção de cura: Restaura 40 de vida
        static int pocaoCura(int vida)
        {
            int vidaRestaurada = vida + 40;
            //Não pode ultrapassar a vida máxima do personagem (120)
            if (vidaRestaurada > 150)
            {
                vidaRestaurada = 150;
            }
            return vidaRestaurada;
        }

        //Verificar se o boss está vivo (Boss não pode atacar se tiver sido derrotado)
        static bool bossVivo(int vidaBoss)
        {
            return vidaBoss > 0;
        }

        //Verificar se o personagem está vivo (Personagem não pode atacar se tiver sido derrotado)
        static bool personagemVivo(int vidaPersonagem)
        {
            return vidaPersonagem > 0;
        }
    }
}
