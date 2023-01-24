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
    public partial class Form1 : Form
    {
        public static string utilizador = null;
        public static string pass = null;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;

            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            
            ficheiroToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            vendasToolStripMenuItem.Enabled = false;
            reparaçõesToolStripMenuItem.Enabled = false;


            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.Hour.ToString("00");
            lbl_minutos.Text = DateTime.Now.Minute.ToString("00");
            lbl_segundos.Text = DateTime.Now.Second.ToString("00");
            timer_segundos.Start();
        }


        private void timer_segundos_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.Hour.ToString("00");
            lbl_minutos.Text = DateTime.Now.Minute.ToString("00");
            lbl_segundos.Text = DateTime.Now.Second.ToString("00");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form f2 = new Form2();
            f2.MdiParent = this;
            f2.Show(); 
            
            toolStripLabel1.Text = "Login";
            ficheiroToolStripMenuItem.Enabled = false;
            produtosToolStripMenuItem.Enabled = false;
            vendasToolStripMenuItem.Enabled = false;
            reparaçõesToolStripMenuItem.Enabled = false;

            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void MostrarLogin(string u)
        {
            if (u != null)
            {
                toolStripLabel1.Text = utilizador;
                ficheiroToolStripMenuItem.Enabled = true;
                produtosToolStripMenuItem.Enabled = true;
                vendasToolStripMenuItem.Enabled = true;
                reparaçõesToolStripMenuItem.Enabled = true;

                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = true;
                toolStripButton5.Enabled = true;
            }
            else
            {
                toolStripLabel1.Text = "Login";
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reparaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void lbl_segundos_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }

        private void consultaGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

        private void registosDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Form f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }
    }
}
