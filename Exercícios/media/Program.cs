using System;

namespace media2
{
    class Program
    {
        static void Main(string[] args)
        {
           double n1, n2, n3, n4, media;

           Console.Write("Entre com a primeira nota:");
           n1 = double.Parse(Console.ReadLine());
           Console.Write("Entre com a segunda nota:");
           n2 = double.Parse(Console.ReadLine());
           Console.Write("Entre com a terceira nota:");
           n3 = double.Parse(Console.ReadLine());
           Console.Write("Entre com a quarta nota");
           n4 = double.Parse(Console.ReadLine());

           media = (n1 + n2 + n3 + n4) / 4;

           Console.WriteLine("Sua média é " + media);

             if (media>7) {
                Console.WriteLine("Aprovado, boa jovem");
            } else {
                Console.WriteLine("Reprovado, nimguém é perfeito");
            }
        }
    }
}
