using System;
using System.Collections.Generic;
using System.Text;

namespace joguinho
{
    internal class Personagem
    {
        private int vidaJogador;
        private int manaJogador;
        private int focousJogador;
        private int danoBaseJogador;

        private int vidaBoss;
        private int manaBoss;
        private int danoBaseBoss;

       

        //Método construtor
        public Personagem(int vida, int mana, int focous, int danoBase, int vidaBoss, int manaBoss, int danoBaseBoss)
        {
            this.vidaJogador = vida;
            this.manaJogador = mana;
            this.focousJogador = focous; 
            this.danoBaseJogador = danoBase;
            this.vidaBoss = vidaBoss;
            this.manaBoss = manaBoss;
            this.danoBaseBoss = danoBaseBoss;

        }

        //Calcular o dano do personagem
        static int calcularDanoJogador(int danoBase, int numeroHabilidade)
        {
            int danoTotal;
            //Se usuário escolher a habilidade 1, o dano será igual ao dano base
            if (numeroHabilidade == 1)
            {
                danoTotal = danoBase;
            }
            else
            {
                //Se usuário escolher a habilidade 2, o dano será dobrado
                 if (numeroHabilidade == 2)
                {
                    danoTotal = danoBase * 2;
                } else
                {
                    //Se o usuário escolher um valor inválido, ele perde a oportunidade de atacar
                    danoTotal = 0;
                }
            }
            return danoTotal;
        }

        static int calcularDanoBoss(int danoBase)
        {
            Random random = new Random();
            int habilidadeBoss = random.Next(1, 3); //Gera um número aleatório entre 1 e 2 para a habilidade do boss
            int danoTotal;

            if (habilidadeBoss == 1)
            {
                danoTotal = danoBase;
            }
            else
            {
                danoTotal = danoBase * 2;
            }

            return danoTotal;
        }

        //Métodos Getters e Setters
        public int hpJogador
        {
            get { return vidaJogador; }
            set { vidaJogador = value; }
        }

        public int mpJogador
        {
            get { return manaJogador; }
            set { manaJogador = value; }
        }

        public int focoJogador
        {
            get { return focousJogador; }
            set { focousJogador = value; }
        }

        public int dmgBaseJogador
        {
            get { return danoBaseJogador; }
            set { danoBaseJogador = value; }
        }

        public int hpBoss
        {
            get { return vidaBoss; }
            set { vidaBoss = value; }
        }

        public int mpBoss
        {
            get { return manaBoss; }
            set { manaBoss = value; }
        }

        public int dmgBaseBoss
        {
            get { return danoBaseBoss; }
            set { danoBaseBoss = value; }
        }
        

    }
}
