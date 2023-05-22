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

namespace Player_Media
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valid = 0;
            StreamReader ler = new StreamReader("./db_users.txt");
            string linha = ler.ReadLine();
            while (linha != null)
            {
                if (linha == textUsuario.Text)
                {
                    MessageBox.Show("Este Usuário já Existe!", "Registro não pode ser concluido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = 1;
                    break;
                }
                linha = ler.ReadLine();
                linha = ler.ReadLine();
            }
            ler.Close();

            if (textUsuario.Text == "" || textSenha.Text == "" || textConfirSenha.Text == "")
            {
                MessageBox.Show("Campos vazios!", "Registro não pode ser concluido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textSenha.Text == textConfirSenha.Text && valid != 1)
            {
                StreamWriter escrever = new StreamWriter("./db_users.txt", true);

                escrever.WriteLine(textUsuario.Text);
                escrever.WriteLine(textSenha.Text);

                escrever.Close();

                new Carregar(textUsuario.Text).Show();
                this.Hide();

            }
            else if (valid != 1)
            {
                MessageBox.Show("As senhas não são iguais, Por Favor Reescreva", "Registro não pode ser concluido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSenha.Focus();
            }
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked)
            {
                textSenha.PasswordChar = '\0';
                textConfirSenha.PasswordChar = '\0';
            }
            else
            {
                textSenha.PasswordChar = '•';
                textConfirSenha.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
