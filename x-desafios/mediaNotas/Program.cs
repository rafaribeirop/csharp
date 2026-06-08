namespace mediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double[] notas = new double[5];
           double soma = 0;
           double media;

            for (int i = 0; i < notas.Length; i++) 
            {
                Console.WriteLine("Digite a " + (i + 1) + "a nota: ");
                notas[i] = double.Parse(Console.ReadLine());

                soma += notas[i];
            }

            Console.WriteLine();
            Console.WriteLine("Notas: ");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + " - ");
            }

            media = soma / notas.Length;

            Console.WriteLine();
            Console.WriteLine("A média das notas foi: " + media);


        }
    }
}
