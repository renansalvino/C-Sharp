using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Olá eu sou a sua calculadora, Digite um número para escolher a sua forma geométrica desejada:");
            Console.ReadLine("Digite 1 para o quadrado");
            Console.ReadLine("Digite 2 para o triângulo");
            Console.ReadLine("Digite 3 para o Círculo");
            Console.ReadLine("Digite 4 para o Trapézio");
            Console.ReadLine("Digite 5 para o Retângulo");
            Console.ReadLine("Digite 6 para o Lôsango");
            Oper = int.Parse(Console.ReadLine());

            switch(opcao) {
                case "1":
                    Console.WriteLine("área de triangulo");
                    Console.Write("Entre com a base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Entre com a altura");
                    double alTri = double.Parse(Console.ReadLine());
                    double areaTri = (baseTri * alTri) / 2;
                    Console.WriteLine("A área do triangulo é:" + areaTri);
                    break;

                case "2":
                Console.WriteLine("área do quadrado");
                Console.Write ("Qual o lado do quadrado? ");
                double ladoQuad = double.Parse(Console.ReadLine());
            }
            
        }
    }
}
