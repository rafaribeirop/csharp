namespace estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Estoque -");

            int notebooks = 30;
            int mouses = 50;

            Console.WriteLine("Notebooks: " + notebooks);
            Console.WriteLine("Mouses: " + mouses); 

            int soma = notebooks + mouses;

            Console.WriteLine("Diponível no estoque " + soma + " itens no total");
        }
    }
}
