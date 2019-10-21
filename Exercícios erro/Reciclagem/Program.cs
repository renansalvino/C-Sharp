using System;
using Reciclagem.Interface.cs;
using Reciclagem.Models.cs;

namespace Reciclagem {
    class Program {
        static void Main (string[] args) {

            
            Console.Clear ();
            System.Console.WriteLine ("//////////Bem vindo a Reciclagem//////////");
            System.Console.WriteLine ("");
            System.Console.WriteLine ("Escolha qual tipo de lixo Você deseja descartar:");
            System.Console.WriteLine ("1 - Garrafa ");
            System.Console.WriteLine ("2 - Garrafa PET");
            System.Console.WriteLine ("3 - Guarda Chuva");
            System.Console.WriteLine ("4 - Latinha");
            System.Console.WriteLine ("5 - Papelão");
            System.Console.WriteLine ("6 - Pote de manteiga");
            System.Console.WriteLine ();
            int opcao = int.Parse (Console.ReadLine ());

            Ilixo Garrafa = new Verde ();
            Ilixo GarrafaPet = new Vermelho ();
            Ilixo GuardaChuva = new Cinza ();
            Ilixo Latinha = new Amarelo ();
            Ilixo Papelão = new Azul ();
            Ilixo Banana = new Preto ();

            switch (opcao)
            {
                case 1:
                    System.Console.WriteLine(Reciclagem.Verde);                
                break;
            }

            }

            }
}
    
            