namespace Ficha3_GerePessoas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxDificuldade = new System.Windows.Forms.TextBox();
            this.adicionarAluno = new System.Windows.Forms.Button();
            this.AdicionarAlunoEspecial = new System.Windows.Forms.Button();
            this.AdicionarProfessor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.buttonTipoPessoa = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(272, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 94);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adiconar Pessoa >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pontuar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(387, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 196);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "NºAluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Disciplina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dificulade";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(84, 365);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(200, 22);
            this.textBoxNumero.TabIndex = 14;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(84, 403);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(200, 22);
            this.textBoxCurso.TabIndex = 15;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(92, 440);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(192, 22);
            this.textBoxDisciplina.TabIndex = 16;
            // 
            // textBoxDificuldade
            // 
            this.textBoxDificuldade.Location = new System.Drawing.Point(95, 487);
            this.textBoxDificuldade.Name = "textBoxDificuldade";
            this.textBoxDificuldade.Size = new System.Drawing.Size(189, 22);
            this.textBoxDificuldade.TabIndex = 17;
            // 
            // adicionarAluno
            // 
            this.adicionarAluno.Location = new System.Drawing.Point(12, 574);
            this.adicionarAluno.Name = "adicionarAluno";
            this.adicionarAluno.Size = new System.Drawing.Size(85, 64);
            this.adicionarAluno.TabIndex = 18;
            this.adicionarAluno.Text = "Adicionar Aluno";
            this.adicionarAluno.UseVisualStyleBackColor = true;
            this.adicionarAluno.Click += new System.EventHandler(this.adicionarAluno_Click);
            // 
            // AdicionarAlunoEspecial
            // 
            this.AdicionarAlunoEspecial.Location = new System.Drawing.Point(106, 574);
            this.AdicionarAlunoEspecial.Name = "AdicionarAlunoEspecial";
            this.AdicionarAlunoEspecial.Size = new System.Drawing.Size(85, 64);
            this.AdicionarAlunoEspecial.TabIndex = 19;
            this.AdicionarAlunoEspecial.Text = "Adicionar aluno especial";
            this.AdicionarAlunoEspecial.UseVisualStyleBackColor = true;
            this.AdicionarAlunoEspecial.Click += new System.EventHandler(this.AdicionarAlunoEspecial_Click);
            // 
            // AdicionarProfessor
            // 
            this.AdicionarProfessor.Location = new System.Drawing.Point(199, 574);
            this.AdicionarProfessor.Name = "AdicionarProfessor";
            this.AdicionarProfessor.Size = new System.Drawing.Size(85, 64);
            this.AdicionarProfessor.TabIndex = 20;
            this.AdicionarProfessor.Text = "Adicionar professor";
            this.AdicionarProfessor.UseVisualStyleBackColor = true;
            this.AdicionarProfessor.Click += new System.EventHandler(this.AdicionarProfessor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dados do Individuo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Morada";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(84, 327);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(200, 22);
            this.textBoxMorada.TabIndex = 26;
            // 
            // buttonTipoPessoa
            // 
            this.buttonTipoPessoa.Location = new System.Drawing.Point(387, 470);
            this.buttonTipoPessoa.Name = "buttonTipoPessoa";
            this.buttonTipoPessoa.Size = new System.Drawing.Size(355, 74);
            this.buttonTipoPessoa.TabIndex = 27;
            this.buttonTipoPessoa.Text = "Que tipo de Pessoa sou?";
            this.buttonTipoPessoa.UseVisualStyleBackColor = true;
            this.buttonTipoPessoa.Click += new System.EventHandler(this.buttonTipoPessoa_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(387, 297);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(355, 164);
            this.listBox2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 645);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonTipoPessoa);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AdicionarProfessor);
            this.Controls.Add(this.AdicionarAlunoEspecial);
            this.Controls.Add(this.adicionarAluno);
            this.Controls.Add(this.textBoxDificuldade);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxDificuldade;
        private System.Windows.Forms.Button adicionarAluno;
        private System.Windows.Forms.Button AdicionarAlunoEspecial;
        private System.Windows.Forms.Button AdicionarProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Button buttonTipoPessoa;
        private System.Windows.Forms.ListBox listBox2;
    }
}

