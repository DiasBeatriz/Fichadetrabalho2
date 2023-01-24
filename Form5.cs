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
    public partial class Form5 : Form
    {
        //declarar um vetor para armazenar os registos
        //declarar um contador de registo
        private const int MaxCategorias = 100;
        private readonly Categorias[] categoriasVetor;

        //declarar um contador de registos
        private int num_categorias;



        public Form5()
        {
            //criar e inicializar o vetor
            categoriasVetor = new Categorias[MaxCategorias];
            num_categorias = 0;

            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //configurar o datagridview
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Name = "Categoria";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[2].Name = "Zona";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[3].Name = "Fila";
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Name = "Prateleira";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Rows.Clear();

            Limpar();
        }

        private void Limpar()
        {
            txb_codigo.ResetText();
            txb_categoria.ResetText();
            txb_fila.ResetText();
            txb_prateleira.ResetText();
            txb_zona.ResetText();
            txb_codigo.Focus();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {
                dataGridView1.Rows.RemoveAt(posLista);
                posLista = -1;
                Limpar();
            }
            else
            {
                MessageBox.Show("Não existe nenhuma categoria selecionada", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //verificar se os dados são válidos
            try
            {
                //verificar se o código é inteiro
                int x;

                if (!int.TryParse(txb_codigo.Text, out x))
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código inteiro.");
                }
                else if (Convert.ToInt32(txb_codigo.Text) < 1)
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um código maior que 0");
                }

                //verificar se é uma descrisão da categoria é válida
                if (txb_categoria.Text.Equals("") ||
                    txb_categoria.Text.Length < 3 ||
                    txb_categoria.Text.Length > 50)
                {
                    txb_categoria.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                }

                //verificar se é uma zona válida
                if (txb_zona.Text.Equals("") ||
                    !System.Text.RegularExpressions.Regex.IsMatch(txb_zona.Text, "^[a-zA-Z]"))

                {
                    txb_zona.Focus();
                    throw new Exception("Insira uma zona (letra A a Z).");
                }

                //verificar se a fila é inteira
                if (!int.TryParse(txb_fila.Text, out x))
                {
                    txb_fila.Focus();
                    throw new Exception("Insira na fila um valor inteiro.");
                }
                else if (Convert.ToInt32(txb_fila.Text) < 1 || Convert.ToInt32(txb_fila.Text) > 100)
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um valor para a fila entre 1 e 100.");
                }

                //verificar se a prateleria é inteira
                if (!int.TryParse(txb_prateleira.Text, out x))
                {
                    txb_prateleira.Focus();
                    throw new Exception("Insira uma prateleria com valor inteiro.");
                }
                else if (Convert.ToInt32(txb_fila.Text) < 1 || Convert.ToInt32(txb_fila.Text) < 10)
                {
                    txb_codigo.Focus();
                    throw new Exception("Insira um valor para a prateleira entre 1 e 10");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Add(txb_codigo.Text, txb_categoria.Text, txb_zona.Text, txb_fila.Text, txb_prateleira.Text);

            Limpar();
        }

        //saber qual é o index da categoria selecionado na listbox
        private int posLista = -1;

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            posLista = dataGridView1.CurrentCell.RowIndex;
            if (posLista != -1)
            {
                txb_codigo.Text = dataGridView1.Rows[posLista].Cells[0].Value.ToString();
                txb_categoria.Text = dataGridView1.Rows[posLista].Cells[1].Value.ToString();
                txb_zona.Text = dataGridView1.Rows[posLista].Cells[2].Value.ToString();
                txb_fila.Text = dataGridView1.Rows[posLista].Cells[3].Value.ToString();
                txb_prateleira.Text = dataGridView1.Rows[posLista].Cells[4].Value.ToString();
                txb_codigo.Focus();
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {
                //verificar se os dados são válidos
                try
                {
                    //verificar se o código é inteiro
                    int x;

                    if (!int.TryParse(txb_codigo.Text, out x))
                    {
                        txb_codigo.Focus();
                        throw new Exception("Insira um código inteiro.");
                    }
                    else if (Convert.ToInt32(txb_codigo.Text) < 1)
                    {
                        txb_codigo.Focus();
                        throw new Exception("Insira um código maior que 0");
                    }

                    //verificar se é uma descrisão da categoria é válida
                    if (txb_categoria.Text.Equals("") ||
                        txb_categoria.Text.Length < 3 ||
                        txb_categoria.Text.Length > 50)
                    {
                        txb_categoria.Focus();
                        throw new Exception("Insira a descrição do produto (3 a 50 chars).");
                    }

                    //verificar se é uma zona válida
                    if (txb_zona.Text.Equals("") ||
                        !System.Text.RegularExpressions.Regex.IsMatch(txb_zona.Text, "^[a-zA-Z]"))

                    {
                        txb_zona.Focus();
                        throw new Exception("Insira uma zona (letra A a Z).");
                    }

                    //verificar se a fila é inteira
                    if (!int.TryParse(txb_fila.Text, out x))
                    {
                        txb_fila.Focus();
                        throw new Exception("Insira na fila um valor inteiro.");
                    }
                    else if (Convert.ToInt32(txb_fila.Text) < 1 || Convert.ToInt32(txb_fila.Text) > 100)
                    {
                        txb_codigo.Focus();
                        throw new Exception("Insira um valor para a fila entre 1 e 100.");
                    }

                    //verificar se a prateleria é inteira
                    if (!int.TryParse(txb_prateleira.Text, out x))
                    {
                        txb_prateleira.Focus();
                        throw new Exception("Insira uma prateleria com valor inteiro.");
                    }
                    else if (Convert.ToInt32(txb_fila.Text) < 1 || Convert.ToInt32(txb_fila.Text) < 10)
                    {
                        txb_codigo.Focus();
                        throw new Exception("Insira um valor para a prateleira entre 1 e 10");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                //remover e inserir na mesma posição no dataGridView
                dataGridView1.Rows.RemoveAt(posLista);
                dataGridView1.Rows.Insert(posLista, txb_codigo.Text, txb_categoria.Text, txb_zona.Text, txb_fila.Text, txb_prateleira.Text);


                posLista = -1;
                Limpar();
            }
        }

        private void AdicionarCategoria(Categorias c)
        {
            if(num_categorias < MaxCategorias)
            {
                categoriasVetor[num_categorias++] = c;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //colocar os itens da datagridview fazendo uma seleção linha a linha
            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                string categoria = Convert.ToString(linha.Cells[1].Value.ToString());
                string zona = Convert.ToString(linha.Cells[2].Value.ToString());
                int fila = Convert.ToInt32(linha.Cells[3].Value.ToString());
                int prateleria = Convert.ToInt32(linha.Cells[4].Value.ToString());

                AdicionarCategoria(new Categorias(codigo, categoria, zona, fila, prateleria));
               
                MessageBox.Show("Resgito guardados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
