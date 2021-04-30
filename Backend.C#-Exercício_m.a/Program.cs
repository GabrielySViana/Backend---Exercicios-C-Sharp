using System;

namespace Backend___Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Qual é a primeira nota? ");
            // var primeiraNota = Qual é a primeira nota?
            double n1 = double.Parse(Console.ReadLine());  

            Console.WriteLine("Qual é a segunda nota? ");
            // var segundaNota = Qual é a segunda nota?
            double n2 = double.Parse(Console.ReadLine());  

            Console.WriteLine("Qual é a terceira nota? ");
            // var terceiraNota = Qual é a terceira nota?
            double n3 = double.Parse(Console.ReadLine());  

            double media = (n1 + n2 + n3) / 3;
           
            Console.WriteLine(nomeAluno + " sua média foi: " + Math.Round(media, 1));

            if (media>=5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ("Você foi aprovado(a)!!!");
            }
            else
            {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Você foi reprovado(a).");
            }




           

        }
    }
}
