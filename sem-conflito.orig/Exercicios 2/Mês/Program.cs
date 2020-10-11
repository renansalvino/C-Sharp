using System;

namespace Mês {
    class Program {
        static void Main (string[] args) {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int intervalo = meses.Length;

            System.Console.WriteLine ("Meses do ano");
            System.Console.Write ("Insira um número do mês: ");
            int index = int.Parse (Console.ReadLine ()) - 1;

            if (index < intervalo) {
                System.Console.WriteLine ($"Mês: {meses [index]}");
            } else {
                System.Console.WriteLine ("Insira um número do mês valido!");
            }
        }
    }
}