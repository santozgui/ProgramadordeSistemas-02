namespace calcularIdade
{
    partial class frmCalcularIdade
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
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAnoNasc.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasc.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAnoNasc.Location = new System.Drawing.Point(42, 34);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(255, 42);
            this.lblAnoNasc.TabIndex = 0;
            this.lblAnoNasc.Text = "Ano de Nascimento";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoNasc.Location = new System.Drawing.Point(49, 101);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(174, 29);
            this.txtAnoNasc.TabIndex = 1;
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.BackColor = System.Drawing.Color.SeaGreen;
            this.lblAnoAtual.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoAtual.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAnoAtual.Location = new System.Drawing.Point(49, 167);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(149, 42);
            this.lblAnoAtual.TabIndex = 2;
            this.lblAnoAtual.Text = "Ano Atual";
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoAtual.Location = new System.Drawing.Point(49, 249);
            this.txtAnoAtual.Multiline = true;
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(174, 28);
            this.txtAnoAtual.TabIndex = 3;
            this.txtAnoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoAtual_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(52, 339);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(20, 24);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // frmCalcularIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.lblAnoAtual);
            this.Controls.Add(this.txtAnoNasc);
            this.Controls.Add(this.lblAnoNasc);
            this.Name = "frmCalcularIdade";
            this.Text = "Calcular Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblIdade;
    }
}

