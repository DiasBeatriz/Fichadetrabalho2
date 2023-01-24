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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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
                string caminho = target + "\\avarias.txt";
                Stream ficheiro = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                StreamReader registo = new StreamReader(ficheiro);

                string linha = registo.ReadLine();
                string[] dados = linha.Split(';');

                
                while (linha != null)
                {
                    grelha.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6]);
                    linha = registo.ReadLine();
                    if (linha != null)
                    {
                        dados = linha.Split(';');

                    }
                }
                registo.Close();
                ficheiro.Close();
        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
