namespace dadosnecessarios
{
    public partial class frm_Simples : Form
    {
        public frm_Simples()
        {
            InitializeComponent();
        }

        private void comboBoxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            // Validação de campos obrigatorios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))
            {

                MessageBox.Show("Por favor, preencha o número de cadastro. ");
                return; //Interrompe a execução do código caso o campo esteja vazio.
            }
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor preencha o nome completo ");
                return;
            }
            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade");
                return;
            }
            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBi.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return;
            }
            //agora, caso todos os campos estejam preenchidos a validação prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBi.Checked;

            //formatar a data para exibir apenas a data(Sem a hora)
            string dataFormada = dataNascimento.ToString("dd/MM/yyyy");

            //determine o genero selecionado
            string generoSelecionado = "Não informado";

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Gênero não selecionado";

            //exibir informações em messagebox
            MessageBox.Show("Numero cadastrado: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de Nascimento: " + dataFormada);
            MessageBox.Show("Cidade: " + cidade);
            {

            }
        }

        private void txtNumeroCadastrado_Click(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void comboBoxCidade_Click(object sender, EventArgs e)
        {

        }

        private void rbFeminino_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void rbMasculino_Click(object sender, EventArgs e)
        {

        }

        private void rbNaoBi_Click(object sender, EventArgs e)
        {

        }

        private void rbFeminino_Click(object sender, EventArgs e)
        {

        }

        private void generoSelecionado_MouseCaptureChanged(object sender, EventArgs e)
        {

        }







        private void btn_Cadastro_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }
}
