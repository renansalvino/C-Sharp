﻿using System;

namespace calculadora3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 5;
            float num2 = 10;

            string oper;

            Console.WriteLine("Digite o 1° número:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();


            switch (oper) {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
                   
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

                  case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

                  case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;

                  case "%":
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;

                default:
                    Console.WriteLine("Deu merda amigão");
                    break;
            }
        }
    }
}
