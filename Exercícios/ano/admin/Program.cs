using System;

namespace admin
{
    class Program
    {
        static void Main(string[] args)
        {
            String admLogin = "admin";
            String admPasswd = "admin";

            Console.WriteLine("Insira o nome de usuário:");
            String login =  Console.ReadLine();
            Console.WriteLine("Entre comj a senha:")
            String passwd = Console.ReadLine = Console.ReadLine();

            if ((login == admLogin) && passwd == admPasswd ){
                Console.WriteLine("Bem vindo Admin.");
            } else{
                Console.WriteLine("Olá Usuário.";)
            }


        }
    }
}
