namespace Fichadetrabalho2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grelha = new System.Windows.Forms.DataGridView();
            this.cbAvaria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkGarantia = new System.Windows.Forms.CheckBox();
            this.tsAdicionar = new System.Windows.Forms.PictureBox();
            this.tsAnular = new System.Windows.Forms.PictureBox();
            this.tsGuardarSair = new System.Windows.Forms.PictureBox();
            this.tsEliminar = new System.Windows.Forms.PictureBox();
            this.tsValidar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsGuardarSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1100, 423);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 24);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Garantia";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(438, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 45);
            this.label5.TabIndex = 23;
            this.label5.Text = "REPARAÇÕES";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 495);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 26);
            this.textBox5.TabIndex = 26;
            // 
            // grelha
            // 
            this.grelha.AllowUserToAddRows = false;
            this.grelha.AllowUserToDeleteRows = false;
            this.grelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha.Location = new System.Drawing.Point(127, 350);
            this.grelha.Margin = new System.Windows.Forms.Padding(2);
            this.grelha.Name = "grelha";
            this.grelha.ReadOnly = true;
            this.grelha.RowHeadersWidth = 51;
            this.grelha.RowTemplate.Height = 24;
            this.grelha.Size = new System.Drawing.Size(741, 154);
            this.grelha.TabIndex = 37;
            this.grelha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_CellContentClick);
            // 
            // cbAvaria
            // 
            this.cbAvaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvaria.FormattingEnabled = true;
            this.cbAvaria.Location = new System.Drawing.Point(238, 300);
            this.cbAvaria.Margin = new System.Windows.Forms.Padding(2);
            this.cbAvaria.Name = "cbAvaria";
            this.cbAvaria.Size = new System.Drawing.Size(210, 28);
            this.cbAvaria.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(910, 127);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(587, 79);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(118, 82);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(152, 26);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(118, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(688, 26);
            this.txtNome.TabIndex = 3;
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(760, 103);
            this.dtData.Margin = new System.Windows.Forms.Padding(2);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(108, 26);
            this.dtData.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Descrição da avaria:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(135, 109);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Código:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMsg});
            this.statusBar.Location = new System.Drawing.Point(0, 532);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1050, 22);
            this.statusBar.TabIndex = 39;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusMsg
            // 
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(66, 17);
            this.statusMsg.Text = "mensagem";
            // 
            // chkGarantia
            // 
            this.chkGarantia.AutoSize = true;
            this.chkGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGarantia.Location = new System.Drawing.Point(764, 300);
            this.chkGarantia.Margin = new System.Windows.Forms.Padding(2);
            this.chkGarantia.Name = "chkGarantia";
            this.chkGarantia.Size = new System.Drawing.Size(90, 24);
            this.chkGarantia.TabIndex = 41;
            this.chkGarantia.Text = "Garantia";
            this.chkGarantia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGarantia.UseVisualStyleBackColor = true;
            // 
            // tsAdicionar
            // 
            this.tsAdicionar.Image = global::Fichadetrabalho2.Properties.Resources.blue_plus_icon;
            this.tsAdicionar.InitialImage = global::Fichadetrabalho2.Properties.Resources.blue_plus_icon;
            this.tsAdicionar.Location = new System.Drawing.Point(12, 14);
            this.tsAdicionar.Name = "tsAdicionar";
            this.tsAdicionar.Size = new System.Drawing.Size(50, 50);
            this.tsAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsAdicionar.TabIndex = 40;
            this.tsAdicionar.TabStop = false;
            this.tsAdicionar.Click += new System.EventHandler(this.tsAdicionar_Click);
            // 
            // tsAnular
            // 
            this.tsAnular.Image = global::Fichadetrabalho2.Properties.Resources.icons8_vassoura_48;
            this.tsAnular.Location = new System.Drawing.Point(70, 14);
            this.tsAnular.Name = "tsAnular";
            this.tsAnular.Size = new System.Drawing.Size(50, 50);
            this.tsAnular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsAnular.TabIndex = 38;
            this.tsAnular.TabStop = false;
            this.tsAnular.Click += new System.EventHandler(this.tsAnular_Click);
            // 
            // tsGuardarSair
            // 
            this.tsGuardarSair.Image = global::Fichadetrabalho2.Properties.Resources.Floppy_Disk_icon;
            this.tsGuardarSair.Location = new System.Drawing.Point(291, 14);
            this.tsGuardarSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tsGuardarSair.Name = "tsGuardarSair";
            this.tsGuardarSair.Size = new System.Drawing.Size(50, 50);
            this.tsGuardarSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsGuardarSair.TabIndex = 12;
            this.tsGuardarSair.TabStop = false;
            this.tsGuardarSair.Click += new System.EventHandler(this.ptb_salvar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.Image = global::Fichadetrabalho2.Properties.Resources.red_cross_icon;
            this.tsEliminar.Location = new System.Drawing.Point(209, 14);
            this.tsEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(50, 50);
            this.tsEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsEliminar.TabIndex = 13;
            this.tsEliminar.TabStop = false;
            // 
            // tsValidar
            // 
            this.tsValidar.Image = global::Fichadetrabalho2.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.tsValidar.Location = new System.Drawing.Point(127, 14);
            this.tsValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tsValidar.Name = "tsValidar";
            this.tsValidar.Size = new System.Drawing.Size(50, 50);
            this.tsValidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tsValidar.TabIndex = 14;
            this.tsValidar.TabStop = false;
            this.tsValidar.Click += new System.EventHandler(this.tsValidar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 554);
            this.Controls.Add(this.chkGarantia);
            this.Controls.Add(this.tsAdicionar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tsAnular);
            this.Controls.Add(this.grelha);
            this.Controls.Add(this.cbAvaria);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tsGuardarSair);
            this.Controls.Add(this.tsEliminar);
            this.Controls.Add(this.tsValidar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparações";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsGuardarSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsValidar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tsGuardarSair;
        private System.Windows.Forms.PictureBox tsEliminar;
        private System.Windows.Forms.PictureBox tsValidar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView grelha;
        private System.Windows.Forms.ComboBox cbAvaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox tsAnular;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusMsg;
        private System.Windows.Forms.PictureBox tsAdicionar;
        private System.Windows.Forms.CheckBox chkGarantia;
    }
}