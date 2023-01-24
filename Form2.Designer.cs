namespace Fichadetrabalho2
{
    partial class Form2
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
            this.button_cancelar = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_utilizador = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_mensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(480, 375);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(129, 50);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Button_Ok
            // 
            this.Button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Ok.Location = new System.Drawing.Point(284, 375);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(100, 50);
            this.Button_Ok.TabIndex = 4;
            this.Button_Ok.Text = "Login";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Txt_password
            // 
            this.Txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_password.Location = new System.Drawing.Point(389, 294);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.PasswordChar = '*';
            this.Txt_password.Size = new System.Drawing.Size(220, 26);
            this.Txt_password.TabIndex = 3;
            // 
            // Txt_nome
            // 
            this.Txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nome.Location = new System.Drawing.Point(389, 207);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(220, 26);
            this.Txt_nome.TabIndex = 1;
            this.Txt_nome.TextChanged += new System.EventHandler(this.Txt_utilizador_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(218, 287);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(159, 31);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Password: ";
            // 
            // label_utilizador
            // 
            this.label_utilizador.AutoSize = true;
            this.label_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_utilizador.Location = new System.Drawing.Point(230, 243);
            this.label_utilizador.Name = "label_utilizador";
            this.label_utilizador.Size = new System.Drawing.Size(147, 31);
            this.label_utilizador.TabIndex = 7;
            this.label_utilizador.Text = "Utilizador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_utilizador
            // 
            this.Txt_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_utilizador.Location = new System.Drawing.Point(389, 250);
            this.Txt_utilizador.Name = "Txt_utilizador";
            this.Txt_utilizador.Size = new System.Drawing.Size(220, 26);
            this.Txt_utilizador.TabIndex = 2;
            this.Txt_utilizador.TextChanged += new System.EventHandler(this.Txt_utilizador_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fichadetrabalho2.Properties.Resources.login_icon;
            this.pictureBox2.Location = new System.Drawing.Point(40, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fichadetrabalho2.Properties.Resources.cadeado_800x600;
            this.pictureBox1.InitialImage = global::Fichadetrabalho2.Properties.Resources.cadeado_800x600;
            this.pictureBox1.Location = new System.Drawing.Point(623, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensagem.Location = new System.Drawing.Point(422, 157);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(117, 25);
            this.label_mensagem.TabIndex = 17;
            this.label_mensagem.Text = "mensagem";
            this.label_mensagem.Visible = false;
            this.label_mensagem.Click += new System.EventHandler(this.label_mensagem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.label_mensagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.Txt_utilizador);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_utilizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_utilizador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label_mensagem;
    }
}