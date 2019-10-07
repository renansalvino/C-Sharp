﻿using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList {
    class Program {
        static void Main (string[] args) {
            List<TodoItem> todoList = new List<TodoItem> ();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try {
                string[] todoFile = File.ReadAllLines (filePath);

                foreach (string line in todoFile) {
                    string[] itens = line.Split (",");
                    string titulo = itens[0].Replace ("\"", "");
                    string nota = itens[1].Replace ("\"", "");

                    TodoItem todoItem = new TodoItem (titulo, nota);
                    todoList.Add (todoItem);

                }
            } catch (IOException ioe) {
                System.Console.WriteLine ("Erro ao acessar arquivo");
                System.Console.WriteLine (ioe.Message);

            }

            int opcao = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("TODO LIST");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ("Digite uma opção: ");
                System.Console.WriteLine ("1 - Adicionar Item ");
                System.Console.WriteLine ("2 - Remover Item ");
                System.Console.WriteLine ("3 - Sair do Programa");
                System.Console.Write ("opção: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        AddItem(todoList);
                        /**
                         * TODO: Método de  adicionar itens a lista 
                         */
                        break;
                    case 2:
                        RemoveItem(todoList);
                        /**
                         * TODO: Método de  adicionar itens a lista 
                         */
                        break;
                    case 3:
                        System.Console.WriteLine ("Tchau!");
                        break;
                    default:
                        System.Console.WriteLine ("Opção inválida");
                        Console.ReadLine ();
                        break;

                }

            } while (opcao != 3);

        }
        public static void ListaItens (List<TodoItem> TodoList) {
            Console.Clear ();
            int count = 1;
            System.Console.WriteLine ("Todo List");
            System.Console.WriteLine ();
            System.Console.WriteLine ($"ID{"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in TodoList)

                System.Console.WriteLine ($"{count, 3}: {item.Titulo, 15} - {item.Nota}");
            foreach (TodoItem item in TodoList) {
                System.Console.WriteLine ($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }

        public static void AddItem (List<TodoItem> todoList) {
            Console.Clear ();
            System.Console.WriteLine ("Novo Item:");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Título: ");
            string titulo = Console.ReadLine ();
            System.Console.WriteLine ("Nota: ");
            string nota = Console.ReadLine ();
            TodoItem item = new TodoItem (titulo, nota);

            todoList.Add (item);
        }

        public static void RemoveItem (List<TodoItem> todoList) {
            int index = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("Remove item");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite o ID ou x para terminar");
                System.Console.WriteLine ("ID:");
                string id = Console.ReadLine ();

                if (id.ToLower () == "x") {
                    break;
                } else {
                     index = int.Parse (id) - 1;
                }

                if((index < 0) || (index > todoList.Count - 1))
                {
                    System.Console.WriteLine("ID inválido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    Console.ReadLine();
                    
                } else {
                    todoList.RemoveAt(index);
                }

            } while (true);
        }
    }
}