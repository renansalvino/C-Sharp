using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
   int[] vetor = new int[6];
            int impar = 0;
            int par = 0;

            for(int cont = 0; cont < 6; cont++){
                Console.Write($"Digite o {cont+1} número:");//+1 serve para modificar a variavel para somar para sair do 0
                vetor[cont] = int.Parse(Console.ReadLine());

                //como descobrir quais que são pares e quais que são ímpares em uma matriz

                foreach(int num in vetor){//vai olhar vetor por vetor e fazer um calculo (no caso desse exercicio)
                    if(num % 2 == 0){
                        par++;//isso aqui vai somando os números porque na linha 18 acima ele começa com 0 e então se eu somar mais um vai ir para outro número ate chegar a um valor menor que 6 como diz na linha acima (observação na linha 13 que tem o +1 que serve para sair do 0)

                    } else {// se não for par será impar então....
                        
                        impar++;
                        
                    }

                }
            //     Console.WriteLine($"Você tem {par} números pares e {impar} números impares");//($) serve para colocar as váriaveis em forma de texto
            // }




            // int[] vetor = new int[6];//criar  uma matriz vetorial
            // Console.WriteLine("Digite uma quantidade de 6 números e saiba qual deles são pares e impares ")
            //  Console.WriteLine("Digite o primeiro número");
            //  vetor[0] = int.Parse(Console.ReadLine());

            //  Console.WriteLine("Digite o segundo número");
            //  vetor[1] = int.Parse(Console.ReadLine());

            //  Console.WriteLine("Digite o terceiro número");
            //  vetor[2] = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Digite o quarto número");
            //  vetor[3] = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Digite o quinto número");
            //  vetor[4] = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Digite o sexto número");
            //  vetor[5] = int.Parse(Console.ReadLine());
            //CÓDIGO QUE EU FIZ MAS ACHO QUE NAO VOU USAR PORQUE TA ERRADO KKKKKKKK        }
    }
}
