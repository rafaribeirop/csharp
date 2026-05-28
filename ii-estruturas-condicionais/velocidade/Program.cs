namespace velocidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a velocidade do seu personagem: ");
            int velocidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso de sua mochila [KG]: ");
            int pesoMochila = int.Parse(Console.ReadLine());

            if (pesoMochila >= 50)
            // Velocidade do personagem é reduzida pela metade se o peso da mochila for igual ou superior a 50 kg.
            {
                velocidade /= 2;
               
            }

            Console.WriteLine("Sua velocidade final: " + velocidade);
        }
    }
}
