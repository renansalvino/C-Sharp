using System;

namespace Litros {
    class Program {
        static void Main (string[] args) {
            double tempo;
            double velocidade;
            double distancia;
            double litrosus ;

            System.Console.WriteLine ("Digite quanto tempo você gastou na viagem em horas");
            tempo = double.Parse(Console.ReadLine ());
            System.Console.WriteLine("Digite a velocidade média em KM por hora");
            velocidade = double.Parse(Console.ReadLine());

            distancia = (tempo * velocidade);
            litrosus = distancia / 12;

            System.Console.WriteLine("Quantidade de litros que você usou de gasolina: " + litrosus + "L");
            System.Console.WriteLine("Distancia da viagem: " + distancia + "KM");
            System.Console.WriteLine("Sua velocidade média é:" + velocidade + "KM" );
            
        }
    }
}