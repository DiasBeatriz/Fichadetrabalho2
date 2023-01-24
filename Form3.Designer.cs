namespace Fichadetrabalho2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.txb_designacao = new System.Windows.Forms.TextBox();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.lstb_produtos = new System.Windows.Forms.ListBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preço:";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_codigo.Location = new System.Drawing.Point(216, 111);
            this.txb_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.Size = new System.Drawing.Size(106, 26);
            this.txb_codigo.TabIndex = 1;
            // 
            // txb_designacao
            // 
            this.txb_designacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_designacao.Location = new System.Drawing.Point(216, 148);
            this.txb_designacao.Margin = new System.Windows.Forms.Padding(4);
            this.txb_designacao.Name = "txb_designacao";
            this.txb_designacao.Size = new System.Drawing.Size(173, 26);
            this.txb_designacao.TabIndex = 2;
            // 
            // txb_preco
            // 
            this.txb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_preco.Location = new System.Drawing.Point(216, 243);
            this.txb_preco.Margin = new System.Windows.Forms.Padding(4);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(106, 26);
            this.txb_preco.TabIndex = 4;
            // 
            // lstb_produtos
            // 
            this.lstb_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstb_produtos.FormattingEnabled = true;
            this.lstb_produtos.ItemHeight = 20;
            this.lstb_produtos.Location = new System.Drawing.Point(639, 39);
            this.lstb_produtos.Margin = new System.Windows.Forms.Padding(4);
            this.lstb_produtos.Name = "lstb_produtos";
            this.lstb_produtos.Size = new System.Drawing.Size(369, 284);
            this.lstb_produtos.TabIndex = 2;
            this.lstb_produtos.SelectedIndexChanged += new System.EventHandler(this.lstb_produtos_SelectedIndexChanged);
            this.lstb_produtos.DoubleClick += new System.EventHandler(this.lstb_produtos_DoubleClick);
            // 
            // cb_categoria
            // 
            this.cb_categoria.Enabled = false;
            this.cb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(216, 193);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(173, 28);
            this.cb_categoria.TabIndex = 3;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cb_categoria.Leave += new System.EventHandler(this.cb_categoria_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(417, -8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "PRODUTOS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_msg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_msg
            // 
            this.status_msg.Name = "status_msg";
            this.status_msg.Size = new System.Drawing.Size(66, 17);
            this.status_msg.Text = "mensagem";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_guardar.Image = global::Fichadetrabalho2.Properties.Resources.save;
            this.btn_guardar.Location = new System.Drawing.Point(812, 354);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(153, 128);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_eliminar.Image = global::Fichadetrabalho2.Properties.Resources.red_cross_icon;
            this.btn_eliminar.Location = new System.Drawing.Point(587, 354);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(153, 128);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancelar.Image = global::Fichadetrabalho2.Properties.Resources.icons8_vassoura_48;
            this.btn_cancelar.Location = new System.Drawing.Point(408, 354);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(153, 128);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_atualizar.Image = global::Fichadetrabalho2.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_atualizar.Location = new System.Drawing.Point(236, 354);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(153, 128);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Image = global::Fichadetrabalho2.Properties.Resources.blue_plus_icon;
            this.btn_novo.Location = new System.Drawing.Point(60, 354);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(153, 128);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.lstb_produtos);
            this.Controls.Add(this.txb_preco);
            this.Controls.Add(this.txb_designacao);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.TextBox txb_designacao;
        private System.Windows.Forms.TextBox txb_preco;
        private System.Windows.Forms.ListBox lstb_produtos;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_msg;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
    }
}