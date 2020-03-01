using System;

namespace Multiplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            System.Console.WriteLine("Saiba se o número é multiplo de 3");
            System.Console.WriteLine("Entre com um número:");
            num = int.Parse(Console.ReadLine());

            if(num %3 ==0){

            System.Console.WriteLine("O número é multiplo de 3!!");


            }else{
                System.Console.WriteLine("O número não é multiplo de 3");
            }
        }
    }
}
