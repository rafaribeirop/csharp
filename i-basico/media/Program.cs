namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Nome do aluno
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            //Notas do aluno
            Console.WriteLine("Digite a 1a nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2a nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3a nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            //Calcular média
            double media = (nota1 + nota2 + nota3) / 3;

            //Situação do aluno
            string situacao;
            if (media >= 7)
            {
                situacao = "Aprovado!";   
            } else if (media >= 5){
                situacao = "em Recuperação!";
            } else
            {
                situacao = "Reprovado!";
            }

            Console.WriteLine("Aluno(a) " + nome + ": " + situacao);

        }
    }
}
