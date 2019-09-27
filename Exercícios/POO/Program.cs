using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
        Aluno aluno1 = new Aluno("Renan", "Senai", "123-456-789-00");

        Aluno aluno2 = new Aluno("Mateus", "Senai", "987-654-321-00" );

        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("Curso: " + aluno1.Curso);
        Console.WriteLine("Cpf:  " + aluno1.Cpf);

        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("Curso: " + aluno2.Curso);
        Console.WriteLine("Cpf:  " + aluno2.Cpf);

        Console.Write("Entre com o Nome:");
        string nome = Console.ReadLine();
        Console.Write("Entre com o CPF:");
        string cpf = Console.ReadLine();
        Console.Write("Entre com o Curso:");
        string curso = Console.ReadLine();
        Console.Write("Entre com a Nota:");
        int nota = int.Parse(Console.ReadLine());
        Console.Write("Entre com o Bimestre:");
        int Bimestre = int.Parse(Console.ReadLine());
        
        }
    }
}
