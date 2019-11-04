using System;
using System.Linq;
using Zoologico.Interface;
using Zoologico.Models.Animais;
namespace Zoológico 
{
    class Program 
    
        
    
    {
        static void Main(string[] args)
        {
            var codigo = 0;

            Console.Clear();
            System.Console.WriteLine("/////////////////////////////////////////");
            System.Console.WriteLine();
            System.Console.WriteLine("|      Bem vindo ao Zoológico           |");
            System.Console.WriteLine();
            System.Console.WriteLine("/////////////////////////////////////////");

            foreach (var item in Arca.Animais.Values )
            {
                System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
            }

            
        }
    }
}
