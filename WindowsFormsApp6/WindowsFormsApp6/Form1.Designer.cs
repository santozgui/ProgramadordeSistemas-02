namespace WindowsFormsApp6
{
    partial class frmVetor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVetor));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.btnTestar = new System.Windows.Forms.Button();
            this.lblTopo = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Crimson;
            this.panelTopo.Controls.Add(this.lblTopo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(479, 99);
            this.panelTopo.TabIndex = 0;
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Crimson;
            this.panelBase.Controls.Add(this.lblBase);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBase.Location = new System.Drawing.Point(0, 355);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(479, 95);
            this.panelBase.TabIndex = 1;
            // 
            // btnTestar
            // 
            this.btnTestar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnTestar.Font = new System.Drawing.Font("Malgun Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnTestar.Location = new System.Drawing.Point(154, 190);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(188, 74);
            this.btnTestar.TabIndex = 2;
            this.btnTestar.Text = "OK";
            this.btnTestar.UseVisualStyleBackColor = false;
            this.btnTestar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTestar_MouseClick);
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTopo.Location = new System.Drawing.Point(37, 37);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(384, 43);
            this.lblTopo.TabIndex = 3;
            this.lblTopo.Text = "para testar o array uniderecional - vetor";
            this.lblTopo.Click += new System.EventHandler(this.lblTopo_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBase.Location = new System.Drawing.Point(144, 31);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(198, 24);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Clique no botão acima";
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // frmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelTopo);
            this.Name = "frmVetor";
            this.Text = "Vetor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.Label lblBase;
    }
}

