using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testandoShowhide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbLogotipo.Visible = false;
        }

        private void btnMostrarLogo_Click(object sender, EventArgs e)
        {
            if (pbLogotipo.Visible)
            {
                pbLogotipo.Hide();
                btnMostrarLogo.Text = "Mostrar Logotipo";
            }
            else
            {
                               pbLogotipo.Show();
                btnMostrarLogo.Text = "Esconder Logotipo";
            }
        }

        private void pbLogotipo_Click(object sender, EventArgs e)
        {
            frmHome Form= new frmHome();
            Form.Show();
            this.Hide();
        }
    }
}
