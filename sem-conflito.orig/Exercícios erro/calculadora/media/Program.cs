using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;
            float soma = 0;
            float média = 0;
            

            Console.WriteLine("Digite o 1° número:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número:");
            n2 = float.Parse(Console.ReadLine());
             Console.WriteLine("Digite o 3° número:");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4° número:");
            n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            soma = n1 + n2 + n3 + n4;
            Console.WriteLine($"A Média dos Números é: {média}");
            

        }
    }
}
