namespace parOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            Console.WriteLine("Digite 10 números: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine((i + 1) + "o número:");
                numeros[i] = int.Parse(Console.ReadLine());

                // Verificar se o número é par ou ímpar e adicionar à lista correspondente
                int verificador = numeros[i] % 2;

                if (verificador == 0)
                {
                    par.Add(numeros[i]);

                }
                else
                {
                    impar.Add(numeros[i]);
                }
            }

            Console.WriteLine();

            Console.Write("Números digitados: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " - ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Números pares: ");
            for (int i = 0; i < par.Count; i++)
            {
                Console.Write(par[i] + " - ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Números impares: ");
            for (int i = 0; i < impar.Count; i++)
            {
                Console.Write(impar[i] + " - ");
            }

        }
    }
}

