using System;

namespace Byte.Bank {
    class Program {
        static void Main (string[] args) {

            
            System.Console.WriteLine("ByteBank - Cadastro do cliente");
            System.Console.WriteLine ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.WriteLine ("CPF: ");
            string CPF = Console.ReadLine ();
            System.Console.WriteLine ("E-mail: ");
            string email = Console.ReadLine ();
        

            Cliente cliente1 = new Cliente (nome, CPF, email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if(trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                }else{
                    System.Console.WriteLine("senha inválida");
                }
            }while(!trocouSenha);
            Console.Clear();
            
        }
    }
}