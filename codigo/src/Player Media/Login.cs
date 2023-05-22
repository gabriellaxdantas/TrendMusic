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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader ler = new StreamReader("./db_users.txt");
            string usuario = ler.ReadLine();
            string senha = ler.ReadLine();
            int valid = 0;

            while (senha != null || usuario != null)
            {
                if (textUsuario.Text == usuario && textSenha.Text == senha)
                {
                    valid = 1;
                    break;
                }
                usuario = ler.ReadLine();
                senha = ler.ReadLine();
            }

            if (valid == 1)
            {
                new Carregar(textUsuario.Text).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos, Por favor Tente Novamente", "Login não pode ser concluido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Text = "";
                textSenha.Text = "";
                textUsuario.Focus();
            }

            ler.Close();
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked)
            {
                textSenha.PasswordChar = '\0';
            }
            else
            {
                textSenha.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmCadastro().Show();
            this.Hide();
        }
    }
}
