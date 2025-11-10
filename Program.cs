namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número");

            int numUser = Convert.ToInt32(Console.ReadLine());

            if (numUser % 2 == 0)
            {
                System.Console.WriteLine("Par!");
            }
            else
            {
                System.Console.WriteLine("Impar!");
            }

            System.Console.WriteLine("Digite a hora atual:");
            int horaAtual = Convert.ToInt32(Console.ReadLine());

            if (horaAtual < 12)
            {
                System.Console.WriteLine("Bom dia!");
            } else if ((horaAtual == 12) || (horaAtual <= 18))
            {
                System.Console.WriteLine("Boa tarde!");
            } else if (horaAtual > 18)
            {
                System.Console.WriteLine("Boa noite!");
            }

        }
    }
}