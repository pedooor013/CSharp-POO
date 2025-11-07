namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número");

            int numUser = Convert.ToInt32(Console.ReadLine());

            if(numUser % 2 == 0)
            {
                System.Console.WriteLine("Par!");
            }
            else
            {
                System.Console.WriteLine("Impar!");
            }
        }
    }
}