namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbpl = new System.Windows.Forms.Label();
            this.lalulu = new System.Windows.Forms.Button();
            this.BtnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpl
            // 
            this.lbpl.AutoSize = true;
            this.lbpl.Location = new System.Drawing.Point(68, 62);
            this.lbpl.Name = "lbpl";
            this.lbpl.Size = new System.Drawing.Size(50, 13);
            this.lbpl.TabIndex = 0;
            this.lbpl.Text = "LABUBU\r\n";
            // 
            // lalulu
            // 
            this.lalulu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lalulu.Location = new System.Drawing.Point(22, 115);
            this.lalulu.Name = "lalulu";
            this.lalulu.Size = new System.Drawing.Size(153, 72);
            this.lalulu.TabIndex = 1;
            this.lalulu.Text = "button1";
            this.lalulu.UseVisualStyleBackColor = false;
            this.lalulu.Click += new System.EventHandler(this.lalulu_Click);
            // 
            // BtnAlertaRobusto
            // 
            this.BtnAlertaRobusto.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAlertaRobusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlertaRobusto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.BtnAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAlertaRobusto.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlertaRobusto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAlertaRobusto.Location = new System.Drawing.Point(249, 115);
            this.BtnAlertaRobusto.Name = "BtnAlertaRobusto";
            this.BtnAlertaRobusto.Size = new System.Drawing.Size(164, 72);
            this.BtnAlertaRobusto.TabIndex = 2;
            this.BtnAlertaRobusto.Text = "Alerta Robusto";
            this.BtnAlertaRobusto.UseVisualStyleBackColor = false;
            this.BtnAlertaRobusto.Click += new System.EventHandler(this.BtnAlertaRobusto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAlertaRobusto);
            this.Controls.Add(this.lalulu);
            this.Controls.Add(this.lbpl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbpl;
        private System.Windows.Forms.Button lalulu;
        private System.Windows.Forms.Button BtnAlertaRobusto;
    }
}

