using System;

namespace Retângulo
{
    class Program
    {
        static void Main(string[] args)
        {
         double altura;
            double baba;
            double result;
           

            System.Console.WriteLine ("**** Calculadora de rentângulo  ****");
            System.Console.WriteLine ("Aqui você vai saber o valor da sua área, do seu perímetro e da diagonal do triangulo");
            System.Console.WriteLine ("Digite a altura:");
            altura = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Digite a base:");
            baba = int.Parse (Console.ReadLine ());
            
            
            // TODO: Valor da área
            result = baba * altura;
            System.Console.WriteLine ("A Sua área é:" + result);

            // Todo: Valor do perímetro
            result = (baba + baba) + (altura + altura);
            System.Console.WriteLine ("O seu perímetro é:" + result);

            //Todo: Valor da diagonal
            result = Math.Sqrt ((baba * baba) + (altura * altura));
            System.Console.WriteLine ("A diagonal é: " + result);
        }
    }
}
