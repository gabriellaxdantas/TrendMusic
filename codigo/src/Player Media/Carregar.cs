using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Player_Media
{
    public partial class Carregar : Form
    {
        string usuario;
        public Carregar(string valor)
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            gambiarra(valor, 0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value++;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                gambiarra("", 1);
            }
        }
        public void gambiarra(string valor, int valid)
        {
            if (valid == 0)
            {
                usuario = valor;
            }
            else
            {
                new Form1(usuario).Show();
                this.Hide();
            }
        }
    }
}
