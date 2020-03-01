using System;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
              int numero = 0;
        while(numero !=0)
            Console.Write("Digiite um número para saber se ele é par ou impar:");
            numero = int.Parse(Console.ReadLine());


          if ((numero%2) != 0){

            Console.WriteLine("impar");

           } else {

            Console.WriteLine("par");
    }

    } 
}
