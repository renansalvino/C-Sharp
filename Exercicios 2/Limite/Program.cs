using System;

namespace Limite
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Insira aqui um numero para ser contado como limite:");
            num = double.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 1) Console.WriteLine(i);
            }
        }
    }
}
