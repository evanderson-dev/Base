using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("OPERAÇÃO REALIZADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO! " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(labelIdPessoa.Text);
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.NomeCompleto = textBoxNomeCompleto.Text;
            usuario.Cpf = maskedTextBoxCpf.Text;
            usuario.Rg = textBoxRg.Text;
            usuario.OrgaoExpeditor = textBoxOrgExpeditor.Text;
            usuario.DataNascimento = maskedTextBoxDataNascimento.Text;
            usuario.Cep = maskedTextBoxCep.Text;
            usuario.Rua = textBoxRua.Text;
            usuario.NumCasa = textBoxNumCasa.Text;
            usuario.EstadoCivil = textBoxEstadoCivil.Text;
            usuario.Nacionalidade = textBoxNacionalidade.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Telefone = maskedTextBoxTelefone.Text;
            usuario.CelularUm = maskedTextBoxCelularUm.Text;
            usuario.CelularDois = maskedTextBoxCelularDois.Text;
            usuario.Cidade = textBoxCidade.Text;
            usuario.Uf = textBoxUf.Text;
            usuario.Funcionario = checkBoxFuncionario.Checked;
            int idpermissao = 3;
            if (radioButtonNivelUm.Checked)
                idpermissao = 1;
            else if (radioButtonNivelDois.Checked)
                idpermissao = 2;
            usuario.Id_Permissao = idpermissao;
            usuario.Salario = textBoxSalario.Text;
            usuario.Cargo = textBoxCargo.Text;
            usuario.DataAdmissao = maskedTextBoxDataAdmissao.Text;
            usuario.DataDemissao = maskedTextBoxDataDemissao.Text;
            usuario.Banco = textBoxBanco.Text;
            usuario.NumeroAgenciaBanco = textBoxAgencia.Text;
            usuario.NumeroContaBanco = textBoxNumConta.Text;
            usuario.Cliente = checkBoxCliente.Checked;
            usuario.InicioDoContrato = maskedTextBoxInicioContrato.Text;
            usuario.FimDoContrato = maskedTextBoxFimContrato.Text;
            usuario.Observacao = textBoxObservacao.Text;
            usuario.Id_Plano = Convert.ToInt32(comboBoxPlanos.SelectedValue);


            ////////////////////////////////////////////////////////////////////
            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }

        private void somenteLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxRg_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS NUMEROS SEJAM INSERIDOS E APAGADOS NO TEXTBOX
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            somenteLetras(sender, e);
        }

        private void textBoxNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            somenteLetras(sender, e);
        }

        private void textBoxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            somenteLetras(sender, e);
        }

        private void textBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            somenteLetras(sender, e);
        }

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            somenteLetras(sender, e);
        }
        public void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCliente.Checked)
            {
                comboBoxPlanos.DataSource = null;
            }
            else
            {
                PlanoBLL planoBLL = new PlanoBLL();
                comboBoxPlanos.DataSource = planoBLL.BuscarPlano("");
                comboBoxPlanos.DisplayMember = "Descricao";
                comboBoxPlanos.ValueMember = "Id";
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (inserindoNovo)
                checkBoxCliente.Checked = false;

           if (checkBoxCliente.Checked == true)
            {
                comboBoxPlanos.DataSource = usuarioBindingSource;
                comboBoxPlanos.DisplayMember = "Id";
                //ESTA PASSANDO O ID DO PLANO, MAS DEVERÁ PASSAR A DESCRICAO DO PLANO

            }
        }
    }
}
