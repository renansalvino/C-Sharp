using System;
namespace SENAIzinho 
{
    public class Sala 
    {
        public int capacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; }
        public int numeroSala { get; set; }
        public string[] Alunos { get; set; }

        //Construtor
        public Sala (int numeroSala, int capacidadeTotal) 
        {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = this.capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
        }

        public string AlocarAluno(string NomeAluno)
        { 
            int index = 0;

            if(this.capacidadeAtual > 0)
            {
                foreach(string aluno in this.Alunos)
                {
                    if(aluno == "")
                    {
                        this.Alunos[index] = NomeAluno;
                        break;
                    }
                    index++;
                }
                this.capacidadeAtual--;
                return "OK";
            } else 
            {
                return "LOTADO";
            }
        }
        public string RemoverAluno(string  NomeAluno)
        {
            int index = 0;

            if(this.capacidadeAtual == this.capacidadeTotal)
            {
                return "SALA VAZIA";
            }

            foreach(string aluno in this.Alunos)
            {
                if(NomeAluno == aluno)
                {
                    this.Alunos[index] = "";
                    return "OK";
                }
                index++;
            }
            return "NÃO ENCONTRADO";
        }
        public string MostrarAlunos()
        {
            string listaAlunos = "";
            foreach(string aluno in this.Alunos)
            {
                if(aluno != "")
                {
                    listaAlunos = listaAlunos + aluno + " ";
                }
            }
            listaAlunos.TrimEnd();
            return listaAlunos;
        }
    }
}