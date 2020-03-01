using System;

 namespace Aluno
 {

    class Aluno{
        //Propriedades
       public string Nome{get;set;}
	   public string Curso{get;set;}
	   public string Cpf{get;set;}
       public int[] Notas;
	    

        // construtor
        public  Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;// 'this' serve para difereciar o nome da class do que qualquer outro nome
        }

        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
            // this.Notas = Notas;


            //Metodos de acesso
            public int[] getNotas(){return Notas;}

            public void setNotas(int bi, int nota){
                int i = bi - 1;
                if ((i < 0) || (i > 3)){
                    //condição de erro;
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be");
                    else if (nota<0 || nota>10) throw new ArgumentOutOfRangeException($"Nota tem de ser entre 0 a 10");
                    //Condição de erro 
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be");
                }else{
                    this.Notas[indice] = nota;
                }
            }

        }

    }
 }

 