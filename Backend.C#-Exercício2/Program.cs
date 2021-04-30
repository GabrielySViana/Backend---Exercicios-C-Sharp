using System;

namespace Backend.csproj_Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            int ano = DateTime.Now.Year;

            int idade = (ano - nascimento);
            int idade_semanas = (idade * 52);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A sua idade no ano de " + ano + " será: " + idade + " anos");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A sua idade em semanas é: " + idade_semanas);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estes são seus anos e semanas vividos, felicitações! :)");

        
        }
    }
}
