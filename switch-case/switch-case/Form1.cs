using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSwitch_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
                var codigo = Convert.ToInt32(txtCodigoInserido.Text);
                lblDescricao.Text = GetTipoCombustivel(codigo);
            
            } catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private string GetTipoCombustivel(int codigo)
        {
            var result = "";

            switch (codigo)
            {
                case 1:
                    result = "mais vc eh chato ein but kk";
                    break;
                case 2:
                    result = "mais vc eh chato ein but kk";
                    break;
                    case 3:
                    result = "mais vc eh chato ein but kk";
                    break;
                    case 4: 
                    result = "mais vc eh chato ein but kk";
                    break;
                    case 5:
                    result = "mais vc eh chato ein but kk";
                    break;
                case 6:
                    result = "mais vc eh chato ein but kk";
                    break;

            }
            return result;
        }
    }
}
