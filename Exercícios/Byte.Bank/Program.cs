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
            Console.WriteLine();



            System.Console.WriteLine("ByteBank - Cadastro da conta");
            System.Console.Write("Entre com a agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com a conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();


            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, conta, cliente1);
                double saldo;
            
            do{
                Console.Write("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0){
                    contaCorrente1.Saldo = saldo;
                }else{
                    System.Console.WriteLine("Valor do saldo deve ser positivo!");
                }
            }while(saldo < 0);
            System.Console.WriteLine();
            

            Cliente cliente2 = new Cliente ("Cesar", "123.123.123-12", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente("123","321", cliente2);

            #region Depósito.
            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do saque: ");
            valor = double.Parse(Console.ReadLine());
        }
    }
}