using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ficha3_GerePessoas.Pessoa;


namespace Ficha3_GerePessoas
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;

            if (!validaPessoa(nome, dataNascimento, morada))
            {
                return;
            }
            


            listBox1.Items.Add(new Pessoa(nome, dataNascimento, morada));
        }

        public bool validaPessoa(string nome, DateTime dataNascimento, string morada)
        {
            if (nome == "")
            {
                MessageBox.Show("Nome invalido!");
                return false;
            }

            if (dataNascimento > DateTime.Now)
            {
                MessageBox.Show("idade inv");
                return false;
            }

            if (morada == "")
            {
                MessageBox.Show("morada inv");
                return false;

            }
            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa x = (Pessoa)listBox1.SelectedItem;
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("selecione uma pessoa");
                // return;
            }
            else
            {
                x.Pontuar();
                listBox1.Items[listBox1.SelectedIndex] = x;
            }

        }

        public bool validaAluno(string numeroAluno, string curso)
        {
            if (numeroAluno == "")
            {
                MessageBox.Show("numero de aluno invalido!");
                return false;
            }

            if (curso == "")
            {
                MessageBox.Show("curso inv");
                return false;
            }


            return true;
        }

        private void adicionarAluno_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;

            string numeroAluno = textBoxNumero.Text;
            string curso = textBoxCurso.Text;



            if (!validaPessoa(nome, dataNascimento, morada))
            {
                return;
            }

            if (!validaAluno(numeroAluno, curso))
            {
                return;
            }

            listBox1.Items.Add(new Aluno(nome, dataNascimento, morada, numeroAluno, curso));
        }

        private void AdicionarAlunoEspecial_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;

            string numeroAluno = textBoxNumero.Text;
            string curso = textBoxCurso.Text;

            if (!validaPessoa(nome, dataNascimento, morada))
            {
                return;

            }

            if (!validaAluno(numeroAluno, curso))
            {
                return;
            }

            string dificuldade = textBoxDificuldade.Text;
            if (dificuldade == "")
            {
                MessageBox.Show("Dificuldade inválida!");
                return;
            }

            listBox1.Items.Add(new AlunoEspecial(nome, dataNascimento, morada, numeroAluno, curso, dificuldade));
        }

        private void AdicionarProfessor_Click(object sender, EventArgs e)
        {

            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;

            if (!validaPessoa(nome, dataNascimento, morada))
            {
                return;
            }

            string disciplina = textBoxDisciplina.Text;
            if (disciplina == "")
            {
                MessageBox.Show("Disciplina inválida!");
                return;
            }

            listBox1.Items.Add(new Professor(nome, dataNascimento, morada, disciplina));
        }


        private void buttonTipoPessoa_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma pessoa!");
                return;
            }

            if (listBox1.SelectedItem is Pessoa pessoaSelecionada)
            {
                // Limpa a listBox2 antes de adicionar novos detalhes
                listBox2.Items.Clear();

                foreach (string linha in pessoaSelecionada.Mostrar().Split('\n'))
                {
                    listBox2.Items.Add(linha.Replace("\t", "    ")); // Converte "\t" em espaços
                }
            }
        }

    }
}
