using System;
using System.Windows.Forms;

namespace MatrizApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal do aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
