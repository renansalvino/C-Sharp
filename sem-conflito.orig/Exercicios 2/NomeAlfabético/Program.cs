using System;

namespace NomeAlfabético
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 4;


            string[] Nomes = new string[num];
            System.Console.WriteLine("Escreva os 4 nomes");

            for(int i = 0; i < num; i++ ){
                System.Console.WriteLine("Insira o nome:");
               Nomes[i] = Console.ReadLine();
            
            }

            Array.Sort(Nomes);

            foreach (string Item in Nomes )
            {
                System.Console.WriteLine("A ordem é: " + Item);
            }


            
        }
    }
}
