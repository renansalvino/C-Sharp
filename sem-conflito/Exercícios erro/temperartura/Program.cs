using System;

namespace temperartura {
    class Program {
        static void Main (string[] args) {
            double[] temperartura = new double[12];
            double maior = 0;
            double menor = 0;

            for (int i = 0; i < 12; i++) {
                Console.WriteLine ($"Digite a temperatura do mês {i + 1}:");
                temperartura[i] = double.Parse (Console.ReadLine ());
            }

            foreach (double temp in temperartura) {
                if (temp > maior) {
                    maior = temp;
                } else if (temp < menor) {
                    menor = temp;
                }
            }
            Console.WriteLine($"A maior temperatura é {maior}.");
            Console.WriteLine($"A menor temperatura é {menor}");
        }

    }
} 
