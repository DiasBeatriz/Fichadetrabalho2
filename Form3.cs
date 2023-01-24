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
    public partial class Form3 : Form
    {
        //declarar um vetor para armazenar os registos
        //declarar um contador de registo
        private const int MaxProdutos = 100;
        private readonly Produtos[] produtos;

        //declarar um contador de registos
        private int num_produtos;

        public Form3()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            //criar e inicializar o vetor
            produtos = new Produtos[MaxProdutos];
            num_produtos = 0;

            InitializeComponent();


            cb_categoria.Items.Clear();
            cb_categoria.Items.Add("Hardware");
            cb_categoria.Items.Add("Software");
        }
        private void Limpar()
        {
            txb_codigo.ResetText();
            txb_designacao.ResetText();
            txb_preco.ResetText();
            cb_categoria.SelectedIndex = -1;
            txb_codigo.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cb_categoria.Enabled = true;
            Limpar();
            status_msg.Text = "";
        }

        private void AdicionaProduto(Produtos p)
        {
            if (num_produtos < MaxProdutos)
            {
                produtos[num_produtos++] = p;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValidarDados()
        {

        }

        //saber qual é o index do produto selecionado na listbox
        private int posLista = -1;

        private void lstb_produtos_DoubleClick(object sender, EventArgs e)
        {
            //ajustar
            posLista = lstb_produtos.SelectedIndex;

            //fazer o parse para um array
            string[] campos = lstb_produtos.SelectedItem.ToString().Split('|');

            txb_codigo.Text = campos[0].Trim();
            txb_designacao.Text = campos[1].Trim();

            switch (campos[2].Trim())
            {
                case "Hardware": cb_categoria.SelectedIndex = 0; break;
                case "Software": cb_categoria.SelectedIndex = 1; break;
                default: cb_categoria.SelectedIndex = -1; break;
            }

            txb_preco.Text = campos[3].Trim();
            txb_codigo.Focus();
        }


        private void cb_categoria_Leave(object sender, EventArgs e)
        {
            status_msg.Text = "";
        }

        private void lstb_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {

            //verificar se os dados são válidos
            try
            {
                //verificar se o código é inteiro
                int x;
                double y;

                if (!int.TryParse(txb_codigo.Text, out x))
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(txb_codigo.Text) < 100)
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código com 3 ou mais digitos");
                }

                //verificar se é uma descrisão válida
                if (txb_designacao.Text.Equals("") ||
                    txb_designacao.Text.Length < 3 ||
                    txb_designacao.Text.Length > 50)
                {
                    txb_designacao.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                }

                //verificar categoria
                if (cb_categoria.SelectedIndex == -1)
                {
                    throw new Exception("Escolhe uma categoria!");
                }

                //verificar se o preço é double
                if (!double.TryParse(txb_preco.Text, out y))
                {
                    txb_preco.Focus();
                    throw new Exception("Insira um preço numérico.");
                }
                else if (Convert.ToInt32(txb_preco.Text) <= 0)
                {
                    txb_preco.Focus();
                    throw new Exception("Insira um preço um valor superior a 0.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string linha = txb_codigo.Text + " | " + txb_designacao.Text + " | " +
                cb_categoria.SelectedItem + " | " + txb_preco.Text + "";

            lstb_produtos.Items.RemoveAt(posLista);
            lstb_produtos.Items.Insert(posLista, linha);
            posLista = -1;

            status_msg.Text = "Atualizado com sucesso.";
            Limpar();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //verificar se os dados são válidos
            try
            {
                //verificar se o código é inteiro
                int x;
                double y;

                if (!int.TryParse(txb_codigo.Text, out x))
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(txb_codigo.Text) < 100)
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código com 3 ou mais digitos");
                }

                //verificar se é uma descrisão válida
                if (txb_designacao.Text.Equals("") ||
                    txb_designacao.Text.Length < 3 ||
                    txb_designacao.Text.Length > 50)
                {
                    txb_designacao.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                }

                //verificar categoria
                if (cb_categoria.SelectedIndex == -1)
                {
                    throw new Exception("Escolhe uma categoria!");
                }

                //verificar se o preço é double
                if (!double.TryParse(txb_preco.Text, out y))
                {
                    txb_preco.Focus();
                    throw new Exception("Insira um preço numérico.");
                }
                else if (Convert.ToInt32(txb_preco.Text) <= 0)
                {
                    txb_preco.Focus();
                    throw new Exception("Insira um preço um valor superior a 0.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string linha = txb_codigo.Text + " | " + txb_designacao.Text + " | " +
                cb_categoria.SelectedItem + " | " + txb_preco.Text + "";

            lstb_produtos.Items.Add(linha);

            status_msg.Text = "Adicionado um novo produto!";
            Limpar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {
                //remover da listbox
                lstb_produtos.Items.RemoveAt(posLista);
                posLista = -1;
                status_msg.Text = "Eliminado um produto.";
                Limpar();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
