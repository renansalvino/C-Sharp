using System;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            int alt ;
            
        
            Console.Clear();
            

            System.Console.WriteLine("Entre com a altura do triângulo: ");
            alt = int.Parse(Console.ReadLine());
            System.Console.WriteLine("");


            for(int i = 0;i <= alt; i++){
            System.Console.WriteLine(new string ('*', alt-i));
            
            }

            

        }
    }
}
