using System;
using EscolaDeRock.Models;
using System.Collections.Generic;
namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentoEnum : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum : int
    {
        HARMONIA,
        MELODIA,
        PERCUSSÃO
    };

    class Program
    {
        

        static void Main(string[] args)
        {
            //TODO: Verificar com o professor o inicio do menu de opções
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "   - 0                     ",
                "   - 1                 "   
            };

            opcoesFormacao = 0;

            int opcaoFormacaoSelecionada; 
            string menuBar = "=============================================";

            do{
                do
            {
                bool formacaoEscolhida = false;
                Console.Clear();
                System.Console.WriteLine(menuBar);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("     Seja bem-vind@!    ");
                System.Console.WriteLine("     Escolha uma formação:    ");
                Console.ResetColor();
                Console.WriteLine(menuBar);
,,
                for(int i = 0; i< opcoesFormacao.Count; i++)
                {
                    string titulo = itensMenuPrincipal[i];
                    if(opcaoFormacaoSelecionada == i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(),titulo));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                    }
                }
                
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;
                    break;
                    case ConsoleKey.DownArrow:
                    opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada: ++opcaoFormacaoSelecionada;
                    break;
                    case ConsoleKey.Enter:
                    formacaoEscolhida = true;
                    break;
                }
                //TODO: Terminar menu de opções
            }

                }
            }       
        }
    }

