using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Drawing.Drawing2D;

namespace Player_Media
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer tocar = new WMPLib.WindowsMediaPlayer();
        string localArquivo;
        botoes btn = new botoes();
        ListaPlaylist lista = new ListaPlaylist();
        List<Musica> listaPlaylist = new List<Musica>();
        public Form1(string usuario)
        {
            InitializeComponent();
            tocar.settings.volume = 50;
            tbVolume.Value = 5;
            labelVolume.Text = "50%";
            nomeUsuario.Text = usuario;
            tocar = new WindowsMediaPlayer();
            listBoxPlaylist.Font = new System.Drawing.Font("Bookshelf Symbol", 10, System.Drawing.FontStyle.Bold);
            listBoxPlaylist.ItemHeight = 20;
            listBoxPlaylist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }
        string[] paths, files;
        private void tocaMusica(string localArquivo)
        {
            tocar.URL = localArquivo;
            tocar.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivos = new OpenFileDialog();
            if (abrirArquivos.ShowDialog() == DialogResult.OK)
            {
                localArquivo = abrirArquivos.FileName;
                
                files = abrirArquivos.FileNames;
                paths = abrirArquivos.FileNames;
                tocaMusica(localArquivo);
                btnPLAY.ImageIndex = 1;
                label2.Text = Path.GetFileName(localArquivo);
            }
            
            try
            {
                TagLib.File file = TagLib.File.Create(localArquivo);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                capa_Musica_img.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch { }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tocar.close();
            Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (tocar.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2ProgressBar1.Maximum = (int)tocar.controls.currentItem.duration;
                guna2ProgressBar1.Value = (int)tocar.controls.currentPosition;
                if (guna2ProgressBar1.Maximum == guna2ProgressBar1.Value)
                {
                    if (listBoxPlaylist.SelectedIndex < listBoxPlaylist.Items.Count - 1)
                    {
                        listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
                    }
                }
            }
            try
            {
                labelTempoMusica.Text = tocar.controls.currentPositionString;
                labelTempoTotalMusica.Text = tocar.controls.currentItem.durationString.ToString();
            }
            catch {}
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
                capa_Musica_img.Image = Player_Media.Properties.Resources.TREND_MUSIC;
            if (listaPlaylist.Count == 0)
            {
               
                StreamReader sr = new StreamReader("./playlist.txt");
                string linha = sr.ReadLine();
                while (linha != null)
                {
                    listaPlaylist.Add(new Musica("./Músicas/" + linha));
                    listBoxPlaylist.Items.Add(linha);
                    linha = sr.ReadLine();
                }
                iconPictureBox6.Visible = true;
                botaoRemover.Visible = true;
                botaoRemover.Enabled = true;
                sr.Close();
            }
            iconPictureBox7.Visible = true;
            buttonBusca.Enabled = true;
            buttonBusca.Visible = true;

            iconPictureBox4.Visible = true;
            btnAdcMusicaPlayList.Enabled = true;
            btnAdcMusicaPlayList.Visible = true;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tocar.settings.volume = tbVolume.Value * 10;
            labelVolume.Text = tbVolume.Value.ToString() + "0%";
        }

        private void btnAdcMusicaPlayList_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivos = new OpenFileDialog();
            abrirArquivos.Filter = "arquivos mp3|*.mp3";
            abrirArquivos.Multiselect= true;
            if (abrirArquivos.ShowDialog() == DialogResult.OK)
            {

                localArquivo = abrirArquivos.FileName;
                StreamWriter escrever = new StreamWriter("./playlist.txt", true);
                foreach (var arquivo in abrirArquivos.FileNames)
                    escrever.WriteLine(Path.GetFileName(arquivo));
                escrever.Close();
            }
            foreach (var arquivo in abrirArquivos.FileNames)
                listaPlaylist.Add(new Musica(arquivo));

            listBoxPlaylist.Items.Clear();
            foreach (var item in listaPlaylist)
                listBoxPlaylist.Items.Add(Path.GetFileName(item.Arquivo));
        }


        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                localArquivo = listaPlaylist[listBoxPlaylist.SelectedIndex].Arquivo;
                label2.Text = Path.GetFileName(listaPlaylist[listBoxPlaylist.SelectedIndex].Arquivo);
                if (Path.GetFileName(listaPlaylist[listBoxPlaylist.SelectedIndex].Arquivo) != null)
                {
                    iconPictureBox6.Visible = true;
                    botaoRemover.Enabled = true;
                    botaoRemover.Visible = true;

                    tocaMusica(localArquivo);
                }
            }
            catch {}
            btnPLAY.ImageIndex = 1;
            try
            {
                TagLib.File file = TagLib.File.Create(localArquivo);
                var bin = (byte [ ])(file.Tag.Pictures[0].Data.Data);
                capa_Musica_img.Image = Image.FromStream(new MemoryStream (bin) );
            }
            catch {}
            if (tocar.playState == WMPPlayState.wmppsMediaEnded)
            {
                listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
            }
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {   
            string linha;
            StreamReader sr = new StreamReader("./playlist.txt"); // leitura da playlist
            StreamWriter wr = new StreamWriter("./playlistTemp.txt");
            linha = sr.ReadLine();
            while(linha != null){ // enquanto houver músicas
                if(linha != Path.GetFileName(listaPlaylist[listBoxPlaylist.SelectedIndex].Arquivo)) // se "linha" for diferente ao nome da música selecionada
                    wr.WriteLine(linha);
                linha = sr.ReadLine(); // lê a próxima linha
            }
            listaPlaylist.Remove(listaPlaylist[listBoxPlaylist.SelectedIndex]);
            listBoxPlaylist.Items.RemoveAt(listBoxPlaylist.SelectedIndex); // remove a música selecionada da playlist
            sr.Close();
            wr.Close();
            File.Delete("./playlist.txt");
            File.Move("./playlistTemp.txt", "./playlist.txt");
            tocar.close();
            label2.Text = "";
            capa_Musica_img.Image = Player_Media.Properties.Resources.TREND_MUSIC;
            botaoRemover.Enabled = false;
            botaoRemover.Visible = false;
            iconPictureBox6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex < listBoxPlaylist.Items.Count - 1)
            {
                listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex + 1;
            }
        }

        private void btnPLAY_Click(object sender, EventArgs e)
        {
            Play(localArquivo);
        }
        private void Play (string localArquivo)
        {
            if (tocar.playState == WMPPlayState.wmppsUndefined || tocar.playState == WMPPlayState.wmppsStopped)
            {
                tocar.URL = localArquivo;
                tocar.controls.play();
                btnPLAY.ImageIndex = 1;
            }
            else if (tocar.playState == WMPPlayState.wmppsPlaying)
            {
                tocar.controls.pause();
                btnPLAY.ImageIndex = 0;
            }
            else if (tocar.playState == WMPPlayState.wmppsPaused)
            {
                tocar.controls.play();
                btnPLAY.ImageIndex = 1;
            }

        }

        private void btnVOLTAR_Click(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex > 0)
            {
                listBoxPlaylist.SelectedIndex = listBoxPlaylist.SelectedIndex - 1;
            }
        }

        Color back_color;
        Color hei_color = Color.Purple;
        private void listBoxPlaylist_DrawItem(object sender, DrawItemEventArgs e)
        {
            back_color = e.BackColor;
            Color clr = Color.FromArgb(0, back_color);
            Brush bb = new LinearGradientBrush(e.Bounds, back_color, clr, 120);

            if (e.Index >= 0)
            {
                SolidBrush sb = new SolidBrush(((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                 ? hei_color : back_color);

                e.Graphics.FillRectangle(sb, e.Bounds);
                e.Graphics.FillRectangle(bb, e.Bounds);

                string txt = listBoxPlaylist.Items[e.Index].ToString();
                SolidBrush tb = new SolidBrush(e.ForeColor );
                e.Graphics.DrawString(txt, e.Font, tb, listBoxPlaylist.GetItemRectangle(e.Index).Location);
            }
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            Arvore arvore = new Arvore();
            StreamReader reader = new StreamReader("./playlist.txt");
            string linha = reader.ReadLine();
            while (linha != null)
            {
                arvore.Inserir(linha);
                linha = reader.ReadLine();
            }
            reader.Close();

            StreamWriter wr = new StreamWriter("./playlistOrg.txt");
            arvore.InOrdem(arvore.Raiz, wr);
            wr.Close();

            File.Delete("./playlist.txt");
            File.Move("./playlistOrg.txt", "./playlist.txt");

            listaPlaylist.Clear();
            listBoxPlaylist.Items.Clear();

            StreamReader sr = new StreamReader("./playlist.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                listaPlaylist.Add(new Musica("./Músicas/" + line));
                listBoxPlaylist.Items.Add(line);
                line = sr.ReadLine();
            }
            iconPictureBox6.Visible = true;
            botaoRemover.Visible = true;
            botaoRemover.Enabled = true;
            sr.Close();

        }

        private void guna2ProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            tocar.controls.currentPosition=tocar.currentMedia.duration*e.X/guna2ProgressBar1.Width;
        }
    }

    public class Musica
    {
        public string Arquivo { get; set; }

        public Musica() { }

        public Musica(string arquivo)
        {
            Arquivo = arquivo;
        }

    }
}
