using System;

namespace LadoTriangulo {
    class Program {
        static void Main (string[] args) {
            double num1;
            double num2;
            double num3;

            System.Console.WriteLine ("Insira o primeiro numero: ");
            num1 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Insira o segundo numero: ");
            num2 = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Insira o terceiro numero: ");
            num3 = double.Parse (Console.ReadLine ());

            if (num1 + num2 < num3) {
                System.Console.WriteLine ("Os lados fazem parte de um triângulo: ");

            } else if (num1 + num3 < num2) {
                System.Console.WriteLine ("Os lados fazem parte de um triângulo: ");
            } else if (num2 + num3 < num1) {
                System.Console.WriteLine ("Os lados fazem parte de um triângulo: ");

            } else {
                System.Console.WriteLine ("Os lados não fazem parte de um triângulo: ");
            }

        }

    }
}