namespace dadosnecessarios
{
    partial class frm_Simples
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeCompleto = new TextBox();
            lblDataNasc = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblCidade = new Label();
            comboBoxCidade = new ComboBox();
            generoSelecionado = new GroupBox();
            rbNaoBi = new RadioButton();
            rbMasculino = new RadioButton();
            rbFeminino = new RadioButton();
            btn_Cadastro = new Button();
            txtNumeroCadastrado = new TextBox();
            generoSelecionado.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(31, 85);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(214, 23);
            txtNomeCompleto.TabIndex = 0;
            txtNomeCompleto.Text = "Insira seu nome completo";
            txtNomeCompleto.Click += txtNomeCompleto_Click;
            txtNomeCompleto.Leave += txtNomeCompleto_Leave;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(31, 133);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 1;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(178, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(31, 170);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 3;
            lblCidade.Text = "Cidade";
            // 
            // comboBoxCidade
            // 
            comboBoxCidade.FormattingEnabled = true;
            comboBoxCidade.Items.AddRange(new object[] { "São Paulo", "Vitoria", "Curitiba", "Salvador", "Natal", "Fortaleza" });
            comboBoxCidade.Location = new Point(104, 167);
            comboBoxCidade.Name = "comboBoxCidade";
            comboBoxCidade.Size = new Size(121, 23);
            comboBoxCidade.TabIndex = 4;
            comboBoxCidade.SelectedIndexChanged += comboBoxCidade_SelectedIndexChanged;
            comboBoxCidade.Click += comboBoxCidade_Click;
            // 
            // generoSelecionado
            // 
            generoSelecionado.Controls.Add(rbNaoBi);
            generoSelecionado.Controls.Add(rbMasculino);
            generoSelecionado.Controls.Add(rbFeminino);
            generoSelecionado.Location = new Point(31, 191);
            generoSelecionado.Name = "generoSelecionado";
            generoSelecionado.Size = new Size(285, 84);
            generoSelecionado.TabIndex = 5;
            generoSelecionado.TabStop = false;
            generoSelecionado.Text = "Genero";
            generoSelecionado.Enter += groupBox1_Enter;
            generoSelecionado.MouseCaptureChanged += generoSelecionado_MouseCaptureChanged;
            // 
            // rbNaoBi
            // 
            rbNaoBi.AutoSize = true;
            rbNaoBi.Location = new Point(173, 33);
            rbNaoBi.Name = "rbNaoBi";
            rbNaoBi.Size = new Size(89, 19);
            rbNaoBi.TabIndex = 2;
            rbNaoBi.TabStop = true;
            rbNaoBi.Text = "Não-Binario";
            rbNaoBi.UseVisualStyleBackColor = true;
            rbNaoBi.Click += rbNaoBi_Click;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(87, 33);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 1;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            rbMasculino.CheckedChanged += radioButton2_CheckedChanged;
            rbMasculino.Click += rbMasculino_Click;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(6, 33);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 0;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            rbFeminino.CheckedChanged += rbFeminino_CheckedChanged;
            rbFeminino.Click += rbFeminino_Click;
            rbFeminino.HelpRequested += rbFeminino_HelpRequested;
            // 
            // btn_Cadastro
            // 
            btn_Cadastro.Location = new Point(31, 292);
            btn_Cadastro.Name = "btn_Cadastro";
            btn_Cadastro.Size = new Size(278, 39);
            btn_Cadastro.TabIndex = 6;
            btn_Cadastro.Text = "Cadastrar";
            btn_Cadastro.UseVisualStyleBackColor = true;
            btn_Cadastro.Click += btnCadastro_Click;
            btn_Cadastro.Leave += btn_Cadastro_Leave;
            // 
            // txtNumeroCadastrado
            // 
            txtNumeroCadastrado.Location = new Point(31, 44);
            txtNumeroCadastrado.Name = "txtNumeroCadastrado";
            txtNumeroCadastrado.Size = new Size(214, 23);
            txtNumeroCadastrado.TabIndex = 7;
            txtNumeroCadastrado.Text = "Insira seu numero de cadastro";
            txtNumeroCadastrado.Click += txtNumeroCadastrado_Click;
            txtNumeroCadastrado.Leave += txtNumeroCadastrado_Leave;
            // 
            // frm_Simples
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeroCadastrado);
            Controls.Add(btn_Cadastro);
            Controls.Add(generoSelecionado);
            Controls.Add(comboBoxCidade);
            Controls.Add(lblCidade);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDataNasc);
            Controls.Add(txtNomeCompleto);
            Name = "frm_Simples";
            Text = "Formulario Simples";
            generoSelecionado.ResumeLayout(false);
            generoSelecionado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCompleto;
        private Label lblDataNasc;
        private DateTimePicker dateTimePicker1;
        private Label lblCidade;
        private ComboBox comboBoxCidade;
        private GroupBox generoSelecionado;
        private RadioButton rbNaoBi;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private Button btn_Cadastro;
        private TextBox txtNumeroCadastrado;
    }
}
