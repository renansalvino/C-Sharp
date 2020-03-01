using System;

namespace salário
{
    class Program
    {
        static void Main(string[] args)
        {

            double salário;

            Console.WriteLine("Insira aqui o valor do seu salário");
            salário = double.Parse(Console.ReadLine());
            if (salário<500) Console.WriteLine($"Parabéns, Você acaba de receber um aumento de 30% {salário * 1.3}");
            else Console.WriteLine("Você não pode receber o aumento de salário, seu salário ja ultrapassa de R$500");

            

        }
    }
}
