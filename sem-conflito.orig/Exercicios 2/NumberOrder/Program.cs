using System;
using System.Collections.Generic;
namespace NumberOrder {
    class Program {
        public static void Main (string[] args) {
            double num;

            List<double> lista = new List<double> ();
            System.Console.WriteLine ("Insira aqui o seu primeiro numero: ");
            lista.Add (num = double.Parse (Console.ReadLine ()));
            System.Console.WriteLine ("Insira aqui o seu segundo numero: ");
            lista.Add (num = double.Parse (Console.ReadLine ()));
            System.Console.WriteLine ("Insira aqui o terceiro numero: ");
            lista.Add (num = double.Parse (Console.ReadLine ()));

            // Ordena toda a lista de forma ascendente
            lista.Sort ();

            // output dos números de forma ascendente
            foreach (double item in lista)
                Console.WriteLine ("A ordem é: " + item);
        }
    }
}