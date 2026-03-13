using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuSideBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Paint += label2_Paint;
        }

        private void whatsappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWhatsapp frm = new frmWhatsapp();
            frm.Show();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            e.Graphics.Clear(lbl.BackColor);

            e.Graphics.TranslateTransform(lbl.Width / 2, lbl.Height / 2);
            e.Graphics.RotateTransform(-30);
            e.Graphics.TranslateTransform(-lbl.Width / 2, -lbl.Height / 2);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(lbl.Text, lbl.Font, new SolidBrush(lbl.ForeColor),
                new RectangleF(0, 0, lbl.Width, lbl.Height), sf);
        }
    }
}