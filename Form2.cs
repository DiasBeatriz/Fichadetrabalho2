using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichadetrabalho2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            label_mensagem.Visible = false;
            
            Txt_nome.Text = user;
            Txt_nome.Text = password;
        }

        public string user;
        public string password;
        private void Txt_utilizador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = false;

            label_mensagem.Visible = false;
            label_mensagem.Text = "";

            if (string.IsNullOrEmpty(Txt_nome.Text))
            {
                label_mensagem.Visible = true;
                label_mensagem.Text = "Insira o seu nome.";
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_utilizador.Text))
                {
                    label_mensagem.Visible = true;
                    label_mensagem.Text = "Insira o utilizador.";
                }
                else
                {
                    if (string.IsNullOrEmpty(Txt_password.Text))
                    {
                        label_mensagem.Visible = true;
                        label_mensagem.Text = "Insira a senha";
                    }
                    else
                    {
                        //verificar a senha
                        if (Txt_password.Text.Equals("psi2022"))
                        {
                            pictureBox1.Visible = true;

                            MessageBox.Show("Login realizado com sucesso.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Form1.utilizador = Txt_nome.Text;
                            Form1 Parent = (Form1)this.MdiParent;
                            Parent.MostrarLogin(Txt_nome.Text);


                            
                            this.Close();
                        }
                        else
                        {
                            Txt_password.Clear();
                            Txt_utilizador.Clear();
                            Txt_nome.Clear();
                            Txt_nome.Focus();
                        }
                    }
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            string _msg = "Tem a certeza que pretende sair?";
            string _titulo = "Sair";
            var _botoes = MessageBoxButtons.YesNo;
            var _icone = MessageBoxIcon.Question;

            resposta = MessageBox.Show(_msg, _titulo, _botoes, _icone);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_mensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
