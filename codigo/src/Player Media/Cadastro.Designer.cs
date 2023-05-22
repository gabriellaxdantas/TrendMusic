
namespace Player_Media
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textConfirSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookshelf Symbol 7", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre-se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.White;
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.textUsuario.Location = new System.Drawing.Point(36, 140);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(216, 28);
            this.textUsuario.TabIndex = 2;
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.White;
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.textSenha.Location = new System.Drawing.Point(36, 205);
            this.textSenha.Multiline = true;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '•';
            this.textSenha.Size = new System.Drawing.Size(216, 28);
            this.textSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // textConfirSenha
            // 
            this.textConfirSenha.BackColor = System.Drawing.Color.White;
            this.textConfirSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textConfirSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.textConfirSenha.Location = new System.Drawing.Point(36, 273);
            this.textConfirSenha.Multiline = true;
            this.textConfirSenha.Name = "textConfirSenha";
            this.textConfirSenha.PasswordChar = '•';
            this.textConfirSenha.Size = new System.Drawing.Size(216, 28);
            this.textConfirSenha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar Senha";
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSenha.Location = new System.Drawing.Point(130, 321);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(116, 21);
            this.checkBoxSenha.TabIndex = 7;
            this.checkBoxSenha.Text = "Mostrar Senha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            this.checkBoxSenha.CheckedChanged += new System.EventHandler(this.checkBoxSenha_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Criar Conta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookshelf Symbol 7", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Já Possui Uma Conta?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Bookshelf Symbol 7", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Faça Login";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(285, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.textConfirSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textConfirSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}