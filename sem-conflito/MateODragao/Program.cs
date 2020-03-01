using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        private static int geradorNumeroAleatorioDragao;
        private static int geradorNumeroAleatorioJogador;
        private static int geradornumeroAleatorioJogador;
        private static int geradornumeroAleatorioDragao;

        static void Main (string[] args) { // ! O MAIN FAZ TUDO NO CÓDIGO, LEMBRE-SE!!!
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("         Mate o Dragão        ");
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine (" 1 - Iniciar Jogo");
                System.Console.WriteLine (" 0 - Sair do Jogo");

                string opcaoBatalhaJogador = Console.ReadLine ();

                switch (opcaoBatalhaJogador) {
                    case "1":
                        Console.Clear ();


                       Guerreiro guerreiro = CriarGuerreiro ();


                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Pica fio";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        // INICIO - Primeiro Diálogo
                        /*
                         *Quanto menos eu escrever melhor, se não eu  faço cagada
                         *Toda string tem um metodo
                         *Não preciso colocar ToUpper porque no metodo de baixo "CriarDialogo" ja vai ser colocado automaticamente
                         */
                         CriarGuerreiro ();
                        CriarDialogo (guerreiro.Nome, $"{dragao.Nome},  Seu vagabundo Xerador! Vim -lhe derrotar-lhe, seu baderneiro!!!!");
                        CriarDialogo (dragao.Nome, $"Humano tolinho.");

                        FinalizarDialogo (); //!Colocar verbo no nome dos metodos!!!
                        // FIM - Primeiro Diálogo
                        //INICIO - Segundo diálogo
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! da casa {guerreiro.Sobrenome}. ó criatura Morfética.");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... fritar-te-ei, primata insolente!");

                        System.Console.WriteLine ("BAMBAM: Tá na hora do show Mísera!!!");

                        FinalizarDialogo();
                        // FIM -Segundo Diálogo 
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro) {
                            System.Console.WriteLine ("***Turno do jogador***");
                            System.Console.WriteLine ("Escolha uma ação: ");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir ");

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int geradorNumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int geradorNumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDesrtrezaTotal = guerreiro.Destreza + geradorNumeroAleatorioJogador;
                                    int dragaoDesrtrezaTotal = dragao.Destreza + geradorNumeroAleatorioDragao;

                                    if (guerreiroDesrtrezaTotal > dragaoDesrtrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: TOMA ESSA PICA FIO MALDIIITOOOOOOO!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine ($"HP Dragão {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro {guerreiro.Vida}");

                                    } else {

                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou, Humanóide tosco");
                                    }
                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLW");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)

                        {
                            Console.Clear ();
                            System.Console.WriteLine ("Turno do Dragão");

                            Random geradorNumeroAleatorio = new Random ();
                            int geradorNumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int guerreiroDesrtrezaTotal = guerreiro.Destreza + geradorNumeroAleatorioJogador;
                            int dragaoDesrtrezaTotal = dragao.Destreza + geradorNumeroAleatorioDragao;

                            if (dragaoDesrtrezaTotal > guerreiroDesrtrezaTotal) {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: ta com fogo no rabo agora é!?");
                                guerreiro.Vida = guerreiro.Vida - (dragao.Forca);
                                System.Console.WriteLine ($"HP Dragão {dragao.Vida}");
                                System.Console.WriteLine ($"HP Guerreiro {guerreiro.Vida}");

                            } else {

                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Errou, seu vagabundo xerador, baderneiro!!!!");
                            }

                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            Console.Clear ();

                            if (jogadorAtacaPrimeiro) {
                                System.Console.WriteLine ("***Turno do jogador***");
                                System.Console.WriteLine ("Escolha uma ação: ");
                                System.Console.WriteLine (" 1 - Atacar");
                                System.Console.WriteLine (" 2 - Fugir ");

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        geradornumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        geradornumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                        guerreiroDesrtrezaTotal = guerreiro.Destreza + geradorNumeroAleatorioJogador;
                                        dragaoDesrtrezaTotal = dragao.Destreza + geradorNumeroAleatorioDragao;

                                        if (guerreiroDesrtrezaTotal > dragaoDesrtrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: TOMA ESSA PICA FIO MALDIIITOOOOOOO!");
                                            dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                            System.Console.WriteLine ($"HP Dragão {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro {guerreiro.Vida}");

                                        } else if(guerreiroDesrtrezaTotal < dragaoDesrtrezaTotal) 
                                        {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou, Humanóide tosco");
                                            FinalizarDialogo();
                                            
                                        }
                                        break;
                                    case "2":
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW VLW");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                                        jogadorNaoCorreu = false;
                                        break;
                                }

                            }
                            if (guerreiro.Vida <= 0) {
                                System.Console.WriteLine ("Você perdeeu seu vagabundo xerador!!!"); // Caso ele perca
                            }
                            if (dragao.Vida <= 0) {
                                System.Console.WriteLine ("Você venceu!");
                            }
                            FinalizarDialogo ();
                            /**
                             *! Não deu tempo de terminar o pojeto 
                             *TODO: Transformar diálogtos em métodos 
                             */

                        }
                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine ("GAME OVER SEU VAGABUNDO XERADOR!!!");
                        break;
                    default:
                        System.Console.WriteLine ("Comando inválido!!!"); //alt+shift+f = formatar o código.
                        break;
                }
            } while (jogadorNaoDesistiu);

        }

        public static void CriarDialogo (string nome, string frase) //*Nome de metodo começa com letra maisúcula, e é importante começar com ( uma frase) métoddo infinitivo  */
        {

            System.Console.WriteLine ($"{nome.ToUpper()}: \n-{frase}");
        }
        public static void FinalizarDialogo () {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();

        }

        public static  Guerreiro CriarGuerreiro () { //!void é quando nao ha retorno de qualquer coisa
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Bomb Man";
            guerreiro.Sobrenome = "The Nike Warriors";
            guerreiro.CidadeNatal = "Nikelândia";
            guerreiro.Datadenascimento = DateTime.Parse ("25/05/500");
            guerreiro.FerramentaAtaque = "Espada";
            guerreiro.FerramentaProtecao = "Escudo da Nike";
            guerreiro.Forca = 2;
            guerreiro.Destreza = 0;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 200;

            return guerreiro;
        }
    }
}