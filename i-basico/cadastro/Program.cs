namespace cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- CADASTRO -");

            Console.Write("Nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("- Dados cadastrados -");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Cargo: " + cargo);

        }
    }
}
