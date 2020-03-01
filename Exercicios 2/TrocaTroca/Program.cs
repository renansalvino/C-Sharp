using System;

namespace TrocaTroca
{
    class Program
    {
        static void Main(string[] args)
        {
           int AB;
           int BA;
           int C;
           

           System.Console.WriteLine("Digite o Número da Váriavel A: ");
           AB = int.Parse(Console.ReadLine());
           System.Console.WriteLine("Digite o número da váriavel B: ");
           BA = int.Parse(Console.ReadLine());

           C = BA;
           BA = AB;
           AB= C;

           System.Console.WriteLine(" Váriavel A :" + AB);
           System.Console.WriteLine("Váriavel B:" + BA);
           
           

        }
    }
}
