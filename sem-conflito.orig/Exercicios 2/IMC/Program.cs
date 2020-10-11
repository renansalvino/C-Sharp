using System;

namespace IMC {
    class Program {
        static void Main (string[] args) {
            double peso;
            double altura;
            double imc;

            Console.Clear();
            
            System.Console.WriteLine ("Insira aqui seus dados para saber qual a sua faixa de risco!");
            System.Console.WriteLine("");
            System.Console.WriteLine ("Insira seu peso em Kg: ");
            peso = double.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Insira aqui sua altura em metros: ");
            altura = double.Parse (Console.ReadLine ());

            imc = peso / (altura*2);

            if (imc < 20) {
                System.Console.WriteLine ("Você está abaixo do peso!");
            }

            else if((imc > 20) && (imc < 25)){

            System.Console.WriteLine("Seu peso está normal");
            }

            else if((imc >= 25.1) && (imc < 30)){
                System.Console.WriteLine("Você está com excesso de peso");
            }

            else if((imc > 30.1) && (imc < 35))
            {
                System.Console.WriteLine("Você está classificado como obeso");

            }
            else if(imc > 35.1)
            {
                System.Console.WriteLine("Você está classificado como obeso Mórbido");

            }

            System.Console.WriteLine("Seu IMC é:" + imc);

        }
    }
}