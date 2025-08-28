using DesafioAsenjo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAsenjo
{
    public partial class Form1 : Form
    {

        private PessoaBLL pessoaBLL = new PessoaBLL();

        public Form1()
        {
            InitializeComponent();
            textBox5.ReadOnly = true; // Estado
            textBox7.ReadOnly = true; // Cidade
            textBox6.ReadOnly = true; // Bairro
            textBox9.ReadOnly = true; // Rua
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(120, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 29);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(120, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(334, 29);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(120, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(325, 223);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 29);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(325, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 29);
            this.textBox6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bairro:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(120, 267);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 29);
            this.textBox7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cidade:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(120, 358);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 29);
            this.textBox8.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(120, 314);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(334, 29);
            this.textBox9.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rua:";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(167, 402);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(287, 29);
            this.textBox10.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Complemento:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 22;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(257, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 43);
            this.button4.TabIndex = 23;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(485, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Desafio Asenjo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa
                {
                    Nome = textBox1.Text,
                    Telefone = textBox2.Text,
                    Email = textBox3.Text,
                    CEP = textBox4.Text,
                    Estado = textBox5.Text,
                    Cidade = textBox7.Text,
                    Bairro = textBox6.Text,
                    Rua = textBox9.Text,
                    Numero = textBox8.Text,
                    Complemento = textBox10.Text
                };

                pessoaBLL.Inserir(p);
                MessageBox.Show("Pessoa cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    Text = "Deletar Pessoa",
                    StartPosition = FormStartPosition.CenterParent
                };

                Label textLabel = new Label() { Left = 10, Top = 20, Text = "Informe o ID para deletar:", AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 80, Top = 80, DialogResult = DialogResult.OK };

                confirmation.Click += (s, eArgs) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    int id = int.Parse(inputBox.Text);
                    pessoaBLL.Deletar(id);
                    MessageBox.Show("Pessoa deletada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    Text = "Atualizar Pessoa",
                    StartPosition = FormStartPosition.CenterParent
                };

                Label textLabel = new Label() { Left = 10, Top = 20, Text = "Informe o ID para atualizar:", AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 80, Top = 80, DialogResult = DialogResult.OK };

                confirmation.Click += (s, eArgs) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                if (prompt.ShowDialog() == DialogResult.OK)
                {
                    Pessoa p = new Pessoa
                    {
                        Id = int.Parse(inputBox.Text),
                        Nome = textBox1.Text,
                        Telefone = textBox2.Text,
                        Email = textBox3.Text,
                        CEP = textBox4.Text,
                        Estado = textBox5.Text,
                        Cidade = textBox7.Text,
                        Bairro = textBox6.Text,
                        Rua = textBox9.Text,
                        Numero = textBox8.Text,
                        Complemento = textBox10.Text
                    };

                    pessoaBLL.Atualizar(p);
                    MessageBox.Show("Pessoa atualizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pessoas = pessoaBLL.Listar();
            string lista = "";
            foreach (var p in pessoas)
            {
                lista += $"{p.Id} - {p.Nome} ({p.Cidade}/{p.Estado})\n";
            }
            MessageBox.Show(lista, "Lista de Pessoas");
        }

        async private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string cep = textBox4.Text;

            string cepNumeros = new string(cep.Where(char.IsDigit).ToArray());

            if (cepNumeros.Length != 8)
            {
                textBox5.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox9.Text = "";
                return;
            }

            try
            {
                var endereco = await CepService.BuscarEndereco(cepNumeros);
                textBox5.Text = endereco.Estado;
                textBox7.Text = endereco.Cidade;
                textBox6.Text = endereco.Bairro;
                textBox9.Text = endereco.Rua;
            }
            catch
            {
                textBox5.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox9.Text = "";
                MessageBox.Show("CEP inválido ou serviço indisponível.");
            }
        }
    }
}
