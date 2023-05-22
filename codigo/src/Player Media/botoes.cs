
using System.Drawing;
using System.Windows.Forms;

namespace Player_Media
{
    internal class botoes
    {
        public Button gerarBotao(string text)
        {
            Button btnAutomatico = new Button();
            btnAutomatico.Text = text;
            btnAutomatico.Dock = DockStyle.Right;
            btnAutomatico.BackColor = Color.White;
            btnAutomatico.Size = new Size(100, 20);
            return btnAutomatico;
        }

    }
}
