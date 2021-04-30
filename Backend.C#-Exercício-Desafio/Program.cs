using System;

namespace Backend_Exercío_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E aí, nadador! Qual a sua idade? :D");
            int idade = int.Parse(Console.ReadLine());

            if (idade >=5 && idade <=7)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A sua categoria é:" + "Infantil A");
            }
            if (idade >=8 && idade <=10)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("A sua categoria é: " + "Infantil B");
            }
            if (idade >=11 && idade <=13)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A sua categoria é: " + "Juvenil A");  
            }
            if (idade >=14 && idade <=17)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("A sua categoria é: " + "Juvenil B");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("A sua categoria é: " + "Sênior");
            }
        }
    }
}
