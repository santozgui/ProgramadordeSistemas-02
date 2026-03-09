namespace MatrizApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles do formulário
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMatriz  = new System.Windows.Forms.Panel();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnReset     = new System.Windows.Forms.Button();
            this.btnInfo      = new System.Windows.Forms.Button();
            this.lblTitulo    = new System.Windows.Forms.Label();
            this.lblStatus    = new System.Windows.Forms.Label();
            this.groupBox1    = new System.Windows.Forms.GroupBox();

            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitulo ──────────────────────────────────────
            this.lblTitulo.Text      = "🔢 Visualizador de Matriz";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 100);
            this.lblTitulo.Location  = new System.Drawing.Point(12, 15);
            this.lblTitulo.Size      = new System.Drawing.Size(360, 35);
            this.lblTitulo.AutoSize  = false;

            // ── panelMatriz ────────────────────────────────────
            this.panelMatriz.Location    = new System.Drawing.Point(20, 60);
            this.panelMatriz.Size        = new System.Drawing.Size(320, 310);
            this.panelMatriz.BackColor   = System.Drawing.Color.White;
            this.panelMatriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatriz.Paint      += new System.Windows.Forms.PaintEventHandler(this.panelMatriz_Paint);

            // ── groupBox1 (botões) ─────────────────────────────
            this.groupBox1.Text     = "Ações";
            this.groupBox1.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(355, 60);
            this.groupBox1.Size     = new System.Drawing.Size(190, 200);

            // ── btnAleatorio ───────────────────────────────────
            this.btnAleatorio.Text      = "🎲 Valores Aleatórios";
            this.btnAleatorio.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAleatorio.Location  = new System.Drawing.Point(10, 30);
            this.btnAleatorio.Size      = new System.Drawing.Size(165, 45);
            this.btnAleatorio.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnAleatorio.ForeColor = System.Drawing.Color.White;
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnAleatorio.Click    += new System.EventHandler(this.btnAleatorio_Click);

            // ── btnInfo ────────────────────────────────────────
            this.btnInfo.Text      = "📊 Ver Informações";
            this.btnInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfo.Location  = new System.Drawing.Point(10, 90);
            this.btnInfo.Size      = new System.Drawing.Size(165, 45);
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(60, 179, 113);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Click    += new System.EventHandler(this.btnInfo_Click);

            // ── btnReset ───────────────────────────────────────
            this.btnReset.Text      = "🔄 Resetar";
            this.btnReset.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Location  = new System.Drawing.Point(10, 150);
            this.btnReset.Size      = new System.Drawing.Size(165, 40);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(200, 80, 80);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Click    += new System.EventHandler(this.btnReset_Click);

            // ── lblStatus ──────────────────────────────────────
            this.lblStatus.Text      = "✔ Matriz carregada com valores padrão.";
            this.lblStatus.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 120, 60);
            this.lblStatus.Location  = new System.Drawing.Point(12, 380);
            this.lblStatus.Size      = new System.Drawing.Size(530, 22);
            this.lblStatus.AutoSize  = false;

            // ── Adiciona botões ao GroupBox ────────────────────
            this.groupBox1.Controls.Add(this.btnAleatorio);
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.btnReset);

            // ── Form1 ──────────────────────────────────────────
            this.Text            = "Matriz App - Visualizador";
            this.ClientSize      = new System.Drawing.Size(565, 415);
            this.BackColor       = System.Drawing.Color.FromArgb(245, 247, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);

            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
