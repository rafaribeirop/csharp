namespace inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inventario = new string[6];

            //Adicionar itens ao inventário
            for (int i = 0; i < inventario.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "o item do inventário: [6 itens]");
                inventario[i] = Console.ReadLine();
            }

            Console.WriteLine();

            //Listar os itens na forma oposta
            for(int i = inventario.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(inventario[i]);   
            }
            
        }
    }
}
