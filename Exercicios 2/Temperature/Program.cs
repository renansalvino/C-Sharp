using System;

namespace Temperature {
    class Program {
        static void Main (string[] args) {
            double celsius;
            double fare;


            System.Console.WriteLine ("*** Bem vindo a central da Maju ***");
            System.Console.WriteLine("Digite a temperatura em Graus Celsius");
            celsius = Double.Parse(Console.ReadLine());

           fare = celsius/5;
           fare = fare*9;
           fare = fare +32;
           System.Console.WriteLine($"A temperatura de Celsius convertida para Fahrenheit é igual a " + fare);
           Console.ReadLine();
           
        }
    }
}