using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_GerePessoas
{
    class Pessoa
    {
        private string nome;
        private string morada;
        private int pontuacao;
        private DateTime DataNascimento;

        //Ficha 3.1
        private string tipoDePessoa;


        public Pessoa(string nomePessoa, DateTime dataNascimento, string moradaPessoa)
        {
            this.nome = nomePessoa;
            this.DataNascimento = dataNascimento;
            this.morada = moradaPessoa;
            this.pontuacao = 0;

            //Ficha 3.1
            this.tipoDePessoa = this.GetType().Name;
        }

        public void Pontuar()
        {
            pontuacao = pontuacao + 1;
        }


        public int idade()
        {

            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade--;
                //MessageBox.Show("Idade invalida");

            }

            return idade;
        }

        public override string ToString()
        {
            return nome + " " + this.idade() + " - " + this.pontuacao;
        }

        public virtual string Mostrar()
        {
            return nome + "\n" +
                      "\tData de Nascimento: " + DataNascimento.ToShortDateString() + "\n" +
                      "\tMorada: " + morada + "\n" +
                      "\tTipo: " + tipoDePessoa;
        }

     

        //Ficha 3.1

        public class Aluno : Pessoa
        {
            public string numeroAluno { get; }
            public string curso { get; }

            public Aluno(string nome, DateTime dataNascimento, string morada, string numeroAluno, string curso)
                : base(nome, dataNascimento, morada)
            {
                this.numeroAluno = numeroAluno;
                this.curso = curso;
            }

            public override string ToString()
            {
                return nome + " " + numeroAluno + ": " + curso + " - " + this.pontuacao;
            }

            public override string Mostrar()
            {

                return nome + "\n" +
                        "\tData de Nascimento: " + DataNascimento.ToShortDateString() + "\n" +
                        "\tMorada: " + morada + "\n" +
                        "\tNúmero do Aluno: " + numeroAluno + "\n" +
                        "\tCurso: " + curso + "\n" +
                        "\tPontuação: " + pontuacao + "\n" +
                        "\tTipo: " + tipoDePessoa;
            }
        }


        public class Professor : Pessoa
        {
            private string disciplina;

            public Professor(string nome, DateTime dataNascimento, string morada, string disciplina)
                : base(nome, dataNascimento, morada)
            {
                this.disciplina = disciplina;
            }

            public override string ToString()
            {
                return nome + ": " + this.disciplina + " - " + this.pontuacao;
            }

            public override string Mostrar()
            {
                return nome + "\n" + 
                              "\tData de Nascimento: " + DataNascimento.ToShortDateString() + "\n" +
                              "\tMorada: " + morada + "\n" +
                              "\tTipo: " + tipoDePessoa + "\n" +
                              "\tDisciplina: " + disciplina + "\n" +
                              "\tPontuação: " + pontuacao;

            }
        
        }


        public class AlunoEspecial : Aluno
        {
            private string tipo_dificuldade;
            public AlunoEspecial(string nome, DateTime dataNascimento, string morada, string numeroAluno, string curso, string tipoDificuldade)
                : base(nome, dataNascimento, morada, numeroAluno, curso)
            {
                this.tipo_dificuldade = tipoDificuldade;
            }

            public override string ToString()
            {
                return nome + ": " + this.tipo_dificuldade + " - " + this.pontuacao;
            }

            public override string Mostrar()
            {
                return nome + "\n" +
                       "\tNúmero do Aluno:" + numeroAluno + "\n" +
                       "\tCurso: " + curso + "\n" +
                       "\tData de Nascimento: " + DataNascimento.ToShortDateString() + "\n" +
                       "\tPontuação: " + pontuacao + "\n" +
                       "\tDificuldade: " + tipo_dificuldade;
            }
        }
    }
}
