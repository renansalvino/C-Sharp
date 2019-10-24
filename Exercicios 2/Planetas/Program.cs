using System;

namespace Planetas {
    class Program {
        static void Main (string[] args) {
            int opcao;
            double Mercurio;
            double Venus;
            double Marte;
            double Jupiter;
            double Saturno;
            double Urano;
            double Pterra;

            Console.Clear ();
            System.Console.WriteLine ("");
            System.Console.WriteLine ("1 - Mercurio");
            System.Console.WriteLine ("2 - Vênus");
            System.Console.WriteLine ("3 - Marte");
            System.Console.WriteLine ("4 - Júpiter");
            System.Console.WriteLine ("5 - Saturno");
            System.Console.WriteLine ("6 - Urano");
            System.Console.WriteLine ("");
            opcao = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("");
            System.Console.WriteLine ("Digite aqui o peso em Kg:");
            Pterra = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("");

            switch (opcao) {
                case 1:
                    Mercurio = (Pterra / 10) * 0.37;
                    System.Console.WriteLine (" O peso da massa em Mercúrio é:" + Mercurio);
                    break;

                case 2:
                    Venus = (Pterra / 10) * 0.88;
                    System.Console.WriteLine (" O peso da massa em Vênus é:" + Venus);
                    break;

                case 3:
                    Marte = (Pterra / 10) * 0.38;
                    System.Console.WriteLine (" O peso da massa em Marte é:" + Marte);
                    break;

                case 4:
                    Jupiter = (Pterra / 10) * 2.64;
                    System.Console.WriteLine (" O peso da massa em Júpiter é:" + Jupiter);
                    break;

                case 5:
                    Saturno = (Pterra / 10) * 1.15;
                    System.Console.WriteLine (" O peso da massa em Saturno é:" + Saturno);
                    break;

                case 6:
                    Urano = (Pterra / 10) * 1.17;
                    System.Console.WriteLine (" O peso da massa em Urano é:" + Urano);
                    break;
            }
        }
    }
}