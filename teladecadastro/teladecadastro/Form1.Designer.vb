<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        lblNomeCompleto = New Label()
        lblNomeSocial = New Label()
        lblEmail = New Label()
        txtCPF = New MaskedTextBox()
        Label5 = New Label()
        txtNomeCompleto = New TextBox()
        txtNomeSocial = New TextBox()
        txtEmail = New TextBox()
        TabControl1 = New TabControl()
        tpConsulta = New TabPage()
        tbDadosdeCliente = New TabPage()
        btnSalvar = New Button()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(861, 81)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(42, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 32)
        Label1.TabIndex = 0
        Label1.Text = "Cadastro de Clientes"
        ' 
        ' lblNomeCompleto
        ' 
        lblNomeCompleto.AutoSize = True
        lblNomeCompleto.BackColor = Color.Transparent
        lblNomeCompleto.Font = New Font("Segoe UI", 10F)
        lblNomeCompleto.Location = New Point(60, 164)
        lblNomeCompleto.Name = "lblNomeCompleto"
        lblNomeCompleto.Size = New Size(110, 19)
        lblNomeCompleto.TabIndex = 1
        lblNomeCompleto.Text = "Nome Completo"
        ' 
        ' lblNomeSocial
        ' 
        lblNomeSocial.AutoSize = True
        lblNomeSocial.Font = New Font("Segoe UI", 10F)
        lblNomeSocial.Location = New Point(60, 214)
        lblNomeSocial.Name = "lblNomeSocial"
        lblNomeSocial.Size = New Size(84, 19)
        lblNomeSocial.TabIndex = 2
        lblNomeSocial.Text = "Nome Social"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F)
        lblEmail.Location = New Point(60, 268)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(47, 19)
        lblEmail.TabIndex = 3
        lblEmail.Text = "E-mail"
        ' 
        ' txtCPF
        ' 
        txtCPF.Location = New Point(181, 316)
        txtCPF.Mask = "###,###,###-##"
        txtCPF.Name = "txtCPF"
        txtCPF.Size = New Size(111, 23)
        txtCPF.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(60, 319)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 19)
        Label5.TabIndex = 5
        Label5.Text = "CPF"
        ' 
        ' txtNomeCompleto
        ' 
        txtNomeCompleto.Location = New Point(181, 161)
        txtNomeCompleto.Name = "txtNomeCompleto"
        txtNomeCompleto.Size = New Size(329, 23)
        txtNomeCompleto.TabIndex = 6
        ' 
        ' txtNomeSocial
        ' 
        txtNomeSocial.Location = New Point(181, 214)
        txtNomeSocial.Name = "txtNomeSocial"
        txtNomeSocial.Size = New Size(329, 23)
        txtNomeSocial.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(181, 268)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(329, 23)
        txtEmail.TabIndex = 8
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpConsulta)
        TabControl1.Controls.Add(tbDadosdeCliente)
        TabControl1.Location = New Point(42, 128)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(545, 246)
        TabControl1.TabIndex = 10
        ' 
        ' tpConsulta
        ' 
        tpConsulta.Location = New Point(4, 24)
        tpConsulta.Name = "tpConsulta"
        tpConsulta.Padding = New Padding(3)
        tpConsulta.Size = New Size(537, 218)
        tpConsulta.TabIndex = 1
        tpConsulta.Text = "Consulta"
        tpConsulta.UseVisualStyleBackColor = True
        ' 
        ' tbDadosdeCliente
        ' 
        tbDadosdeCliente.BackColor = Color.Transparent
        tbDadosdeCliente.Location = New Point(4, 24)
        tbDadosdeCliente.Name = "tbDadosdeCliente"
        tbDadosdeCliente.Padding = New Padding(3)
        tbDadosdeCliente.Size = New Size(537, 218)
        tbDadosdeCliente.TabIndex = 0
        tbDadosdeCliente.Text = "Dados de Clientes"
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackColor = Color.SteelBlue
        btnSalvar.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalvar.ForeColor = SystemColors.ButtonFace
        btnSalvar.Location = New Point(71, 398)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(151, 43)
        btnSalvar.TabIndex = 11
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(747, 450)
        Controls.Add(btnSalvar)
        Controls.Add(txtEmail)
        Controls.Add(txtNomeSocial)
        Controls.Add(txtNomeCompleto)
        Controls.Add(Label5)
        Controls.Add(txtCPF)
        Controls.Add(lblEmail)
        Controls.Add(lblNomeSocial)
        Controls.Add(lblNomeCompleto)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomeCompleto As Label
    Friend WithEvents lblNomeSocial As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomeCompleto As TextBox
    Friend WithEvents txtNomeSocial As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpConsulta As TabPage
    Friend WithEvents tbDadosdeCliente As TabPage
    Friend WithEvents btnSalvar As Button

End Class
