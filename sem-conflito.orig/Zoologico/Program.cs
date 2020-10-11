using System;
using System.Linq;
using Zoologico.Interfaces;
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
            System.Console.Write($"\n{"",2}Digite o animal que deseja mover para a jaula: ");

                System.Console.WriteLine();
            int opcao = int.Parse(Console.ReadLine());
            Arca arca = new Arca();//instanciando uma arca
            Animal animal1 = Arca.Animais [opcao];// Busca o valor do animal com a  chave com a opçao que a pessoa colocou
            System.Console.WriteLine(animal1.GetType().Name);// imprimir o que a linha de cima resgatou
            //! gettype converte para um tipo
            //! TypeOf.Equals: é usado para verificar a interface do animaL


            


            
        }
    }
}
