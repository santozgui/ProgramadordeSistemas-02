using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace menuSideBar
{
    public partial class frmWhatsapp : Form
    {
        private SoundPlayer Som = new SoundPlayer();
        private SoundPlayer Som2 = new SoundPlayer();
        private Image gifAnimado;
        private Image gifAnimado2;

        public frmWhatsapp()
        {
            InitializeComponent();
        }

        private void frmWhatsapp_Load(object sender, EventArgs e)
        {
            gifAnimado = Image.FromFile("C:/Users/guilherme.srocha18/Downloads/frutigerAero/old-future-frutiger-aero.gif");
            gifAnimado2 = Image.FromFile("C:/Users/guilherme.srocha18/Downloads/frutigerAero/frutiger-aero (1).gif");

            pictureBox2.Image = gifAnimado;
            ImageAnimator.Animate(gifAnimado, OnFrameChanged);

            pictureBox3.Image = gifAnimado2;
            pictureBox3.BackColor = Color.Transparent; // 👈 adicionado
            ImageAnimator.Animate(gifAnimado2, OnFrameChanged2);
        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            pictureBox2.Invalidate();
        }

        private void OnFrameChanged2(object sender, EventArgs e)
        {
            pictureBox3.Invalidate();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(gifAnimado);
            e.Graphics.DrawImage(gifAnimado, pictureBox2.ClientRectangle);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(gifAnimado2);
            e.Graphics.DrawImage(gifAnimado2, pictureBox3.ClientRectangle);
        }

        private void btnReproduzir_Click(object sender, EventArgs e)
        {
            Som.SoundLocation = "C:/Users/guilherme.srocha18/Downloads/whatsapp_audio/Testing - Nohluhn (128k).wav";
            Som.Play();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Som.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void frmWhatsapp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImageAnimator.StopAnimate(gifAnimado, OnFrameChanged);
            ImageAnimator.StopAnimate(gifAnimado2, OnFrameChanged2);
        }

        private void panelOpacidade_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReproduzir2_Click(object sender, EventArgs e)
        {
            Som2.SoundLocation = "C:/Users/guilherme.srocha18/Downloads/whatsapp_audio/frutiger aero - amirthetrash (128k).wav";
            Som2.Play();
        }

        private void btnParar2_Click(object sender, EventArgs e)
        {
            Som.Stop();
        }
    }
}