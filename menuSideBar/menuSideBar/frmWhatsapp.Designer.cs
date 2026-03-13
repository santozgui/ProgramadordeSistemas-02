namespace menuSideBar
{
    partial class frmWhatsapp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhatsapp));
            this.btnReproduzir = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnReproduzir2 = new System.Windows.Forms.Button();
            this.btnParar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReproduzir
            // 
            this.btnReproduzir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReproduzir.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproduzir.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnReproduzir.Location = new System.Drawing.Point(58, 482);
            this.btnReproduzir.Name = "btnReproduzir";
            this.btnReproduzir.Size = new System.Drawing.Size(166, 69);
            this.btnReproduzir.TabIndex = 0;
            this.btnReproduzir.Text = "Iniciar";
            this.btnReproduzir.UseVisualStyleBackColor = false;
            this.btnReproduzir.Click += new System.EventHandler(this.btnReproduzir_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnParar.Font = new System.Drawing.Font("MV Boli", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnParar.Location = new System.Drawing.Point(337, 483);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(166, 68);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 384);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(633, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(475, 384);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // btnReproduzir2
            // 
            this.btnReproduzir2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReproduzir2.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproduzir2.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnReproduzir2.Location = new System.Drawing.Point(660, 483);
            this.btnReproduzir2.Name = "btnReproduzir2";
            this.btnReproduzir2.Size = new System.Drawing.Size(166, 69);
            this.btnReproduzir2.TabIndex = 4;
            this.btnReproduzir2.Text = "Iniciar";
            this.btnReproduzir2.UseVisualStyleBackColor = false;
            this.btnReproduzir2.Click += new System.EventHandler(this.btnReproduzir2_Click);
            // 
            // btnParar2
            // 
            this.btnParar2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnParar2.Font = new System.Drawing.Font("MV Boli", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar2.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnParar2.Location = new System.Drawing.Point(921, 481);
            this.btnParar2.Name = "btnParar2";
            this.btnParar2.Size = new System.Drawing.Size(166, 68);
            this.btnParar2.TabIndex = 5;
            this.btnParar2.Text = "Parar";
            this.btnParar2.UseVisualStyleBackColor = false;
            this.btnParar2.Click += new System.EventHandler(this.btnParar2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnParar2);
            this.panel1.Controls.Add(this.btnReproduzir2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnParar);
            this.panel1.Controls.Add(this.btnReproduzir);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(44, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 585);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Testing - Nohluhn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(717, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "frutiger aero - amirthetrash (128k)";
            // 
            // frmWhatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1226, 642);
            this.Controls.Add(this.panel1);
            this.Name = "frmWhatsapp";
            this.Text = "frmWhatsapp";
            this.Load += new System.EventHandler(this.frmWhatsapp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReproduzir;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnReproduzir2;
        private System.Windows.Forms.Button btnParar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}