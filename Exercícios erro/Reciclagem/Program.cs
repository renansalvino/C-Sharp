using System;
using Reciclagem.Interface.cs;
using Reciclagem.Models.cs;

namespace Reciclagem {
    class Program {
        static void Main (string[] args) {
            int opcao;
do{


            Console.Clear ();
            System.Console.WriteLine ("//////////Bem vindo a Reciclagem//////////");
            System.Console.WriteLine ("");
            System.Console.WriteLine ("Escolha qual tipo de lixo Você deseja descartar:");
            System.Console.WriteLine ("1 - Garrafa ");
            System.Console.WriteLine ("2 - Garrafa PET");
            System.Console.WriteLine ("3 - Guarda Chuva");
            System.Console.WriteLine ("4 - Latinha");
            System.Console.WriteLine ("5 - Papelão");
            System.Console.WriteLine ("6 - Banana");
            System.Console.WriteLine("");
            opcao = int.Parse (Console.ReadLine ());

            Ilixo Garrafa = new Verde ();
            Ilixo GarrafaPet = new Vermelho ();
            Ilixo GuardaChuva = new Cinza ();
            Ilixo Latinha = new Amarelo ();
            Ilixo Papelão = new Azul ();
            Ilixo Banana = new Preto ();

            

            switch (opcao) {
                case 1:
                    System.Console.WriteLine (Garrafa.OrganizarLixo ());
                    break;

                case 2:
                    System.Console.WriteLine (GarrafaPet.OrganizarLixo ());
                    break;

                case 3:
                    System.Console.WriteLine (GuardaChuva.OrganizarLixo ());
                    break;
                case 4:
                    System.Console.WriteLine (Latinha.OrganizarLixo ());
                    break;

                case 5:
                    System.Console.WriteLine (Papelão.OrganizarLixo ());
                    break;

                case 6:
                    System.Console.WriteLine (Banana.OrganizarLixo ());
                    break;
                    
                    
            

            }
            
            Console.ReadLine();
            
}while(opcao!= 0);




        
    }

    }
}