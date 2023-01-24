using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fichadetrabalho2
{
    public partial class Form4 : Form
    {
        //declarar um vetor para armazenar as avarias
        //e um contador da posição atual no vetor 
        private const int MaxAvarias = 200;
        private readonly Avarias[] avarias;
        private int num_avarias;
        public Form4()
        {
           //criar o vetor e inicializar o contador
           avarias = new Avarias[MaxAvarias];
           num_avarias = 0;
            InitializeComponent();
        }

        private void Limpar()
        {
            txtCodigo.ResetText();
            dtData.Value = DateTime.Now;
            txtNome.ResetText();
            txtTelefone.ResetText();
            chkGarantia.ResetText();
            cbAvaria.SelectedIndex = -1;
            chkGarantia.Checked = false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            //definir as propriedades e os itens da combobox
            cbAvaria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvaria.Items.Clear();
            cbAvaria.Items.Add("Não Liga");
            cbAvaria.Items.Add("Bloqueia");
            cbAvaria.Items.Add("Ecrã com defeito");
            cbAvaria.Items.Add("Teclado com defeito");
            cbAvaria.Items.Add("Software com erros");
            cbAvaria.Items.Add("Não lê cartão SIM");
            cbAvaria.Items.Add("Não lê cartão de memória");
            cbAvaria.Items.Add("Desliga-se");
            cbAvaria.Items.Add("Não carrega");
            cbAvaria.SelectedIndex = -1;

            //definir as propriedades do datagridview
            grelha.EditMode = DataGridViewEditMode.EditProgrammatically;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.RowHeadersVisible = false;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.AllowUserToResizeColumns = false;
            grelha.ColumnCount = 6;
            grelha.Columns[0].Name = "Código";
            grelha.Columns[1].Name = "Data";
            grelha.Columns[2].Name = "Cliente";
            grelha.Columns[3].Name = "Contacto";
            grelha.Columns[4].Name = "Descrição";
            grelha.Columns[5].Name = "Garantia";
            grelha.Columns[0].Width = 100;
            grelha.Columns[1].Width = 100;
            grelha.Columns[2].Width = 300;
            grelha.Columns[3].Width = 150;
            grelha.Columns[4].Width = 350;
            grelha.Columns[5].Width = 50;
            grelha.Rows.Clear();
            Limpar();
            statusMsg.Text = String.Empty;
        }

        private void ptb_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //obter a pasta atual onde corre o aplicativo e criar uma subpasta
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\data";
                if (!Directory.Exists(target))
                {
                    DirectoryInfo di = Directory.CreateDirectory(target);
                }

                //caminho e nome de ficheiro de texto
                string caminho = target + "\\avarias1";
                Stream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
                StreamWriter registo = new StreamWriter(ficheiro);


                for (int i = 0; i < num_avarias; i++)
                {
                    int codigo = avarias[i].getCodigo();
                    DateTime data = avarias[i].getData();
                    string nome = avarias[i].getNomeCliente();
                    long telefone = avarias[i].getTelefone();
                    string email = avarias[i].getEmail();
                    string avaria = avarias[i].getAvaria();
                    bool garantia = avarias[i].getGarantia();

                    registo.Write(codigo + ";");
                    registo.Write(data + ";");
                    registo.Write(nome + ";");
                    registo.Write(telefone + ";");
                    registo.Write(email + ";");
                    registo.Write(avaria + ";");
                    registo.Write(Environment.NewLine);
                }

                registo.Close();
                ficheiro.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();

        }


        private void tsAdicionar_Click(object sender, EventArgs e)
        {
            Limpar();
            statusMsg.Text = "Preparado para novo registro de avaria!";
        }


        private void tsAnular_Click(object sender, EventArgs e)
        {
            Limpar();
            statusMsg.Text = "Eliminado registo temporário de avaria!";
        }

        private void tsValidar_Click(object sender, EventArgs e)
        {

            int x;
            try
            {
                //verificar se o código da avaria é um inteiro e positivo
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código válido!");
                }
                else if (Convert.ToInt32(txtCodigo.Text) < 0)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código com valor positivo!");
                }

                //verificar se o nome do cliente é válido
                if (txtNome.Text.Equals("") ||
                    txtNome.Text.Length < 3 || txtNome.Text.Length > 50)
                {
                    txtNome.Focus();
                    throw new Exception("Insira o Nome do cliente (3 a 50 caracteres)!");
                }

                //verificar se o telefone é um inteiro e positivo
                if (!int.TryParse(txtTelefone.Text, out x))
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um número de Telefone válido!");
                }
                else if (Convert.ToInt32(txtTelefone.Text) < 210000000)
                {
                    txtTelefone.Focus();
                    throw new Exception("Insira um número de Telefone válido!");
                }

                //verificar se escolheu o tipo de avaria
                if (cbAvaria.SelectedIndex == -1)
                {
                    throw new Exception("Escolha da lista uma topologia de avaria!");
                }

            }
            catch (Exception ex)
            {
                statusMsg.Text = ex.Message;
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //depois de tudo verificado vamos enviar para a datagridview
            grelha.Rows.Add(txtCodigo.Text.ToString(), dtData.Value.ToString(),
                txtNome.Text.ToString(), txtTelefone.Text, cbAvaria.SelectedItem,
                chkGarantia.Checked ? "Sim" : "Não");

            //adiciona os objetos da classe Avarias para o array usando um método
            int codigo = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtData.Value;
            string nome = txtNome.Text;
            long telefone = Convert.ToInt64(txtTelefone.Text);
            string email = txtEmail.Text;
            string avaria = cbAvaria.SelectedItem.ToString();
            bool garantia = chkGarantia.Checked;
            AdicionarAvaria(new Avarias(codigo, data, nome, telefone, email, avaria, garantia));

            //enviar mensagem para o status e limpar os campos do formulário
            statusMsg.Text = "Adicionado um novo registo";
            Limpar();
        }

        private void AdicionarAvaria(Avarias av)
        {
            if (num_avarias < MaxAvarias)
                avarias[num_avarias++] = av;
        }

        private void grelha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
