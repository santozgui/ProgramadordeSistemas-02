using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Essa é uma mensagem simples");
        }

        private void lalulu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("receba aqui é o luva de pedreiro");
        }

        private void BtnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?", "Titulo aqui", MessageBoxButtons.YesNo,

              MessageBoxIcon.Question);
        }
    }
}
