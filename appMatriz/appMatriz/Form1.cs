using System;
using System.Drawing;
using System.Windows.Forms;

namespace appMatriz
{
    public partial class Form1 : Form
    {
        private int respostaCorreta = 24;

        public Form1()
        {
            InitializeComponent();
            ConfigurarBotoes();
            ConfigurarCampoResposta();
        }

        private void ConfigurarCampoResposta()
        {
            txtResposta.Text = "";
            txtResposta.ForeColor = Color.Black;
        }

        private void ConfigurarBotoes()
        {
            VincularBotoes(this);
        }

        private void VincularBotoes(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += Btn_Click;
                }

                if (ctrl.HasChildren)
                {
                    VincularBotoes(ctrl);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            if (int.TryParse(btnClicado.Text.Trim(), out int valorClicado))
            {
                if (valorClicado == respostaCorreta)
                {
                    txtResposta.Text = "Acertou resenhudo";
                    txtResposta.ForeColor = Color.Green;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\guilherme.srocha18\Downloads\Nova pasta\receba.jpg");
                }
                else
                {
                    txtResposta.Text = "APODREÇA";
                    txtResposta.ForeColor = Color.Red;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\guilherme.srocha18\Downloads\Nova pasta\feito por minha entidade (1).jpg");
                }
            }
            else
            {
                txtResposta.Text = "Valor inválido no botão.";
                txtResposta.ForeColor = Color.DarkOrange;
            }
        }
    }
}