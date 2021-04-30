using System;

namespace Backend_Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            
            int meses = (idade * 12);
            int dias = (idade * 365);
            int horas = (idade * 8760);
            int minutos = (idade * 525600);

            int somados = (meses + dias + horas + minutos);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine ("Sua idade em meses é: " + meses);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine ("Sua idade em dias é: " + dias);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine ("Sua idade em horas é: " + horas);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine ("Sua idade em minutos é: " + minutos);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("Somando a sua idade em meses, dias, horas e minutos fica: " + somados);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("Parabéns pelo seu tempo de vida!!! ;)");
        }
    }
}
