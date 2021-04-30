using System;

namespace Backend_Execício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário atual?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine(salario.ToString("C"));

            double sal_reajustado = salario + (salario * 30/100);            

            if (salario<= 500)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Párabéns! " + "Seu salário foi aumentado em 30%. " + "A partir de agora você receberá: " + sal_reajustado.ToString("C") + " reais");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Você não se enquadra no requisito do aumento salarial em 30%. Seu salário permanecerá o mesmo.");
            }
        }
    }
}
