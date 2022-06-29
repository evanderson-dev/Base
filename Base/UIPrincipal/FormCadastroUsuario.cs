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

            //usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.NomeCompleto = textBoxNomeCompleto.Text;
            usuario.Cpf = maskedTextBoxCpf.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.Rg = textBoxRg.Text;
            usuario.OrgaoExpeditor = textBoxOrgExpeditor.Text;
            usuario.DataNascimento = maskedTextBoxDataNascimento.Text;
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
            usuario.Funcionario = checkBoxFuncionario.Checked;
            usuario.Cliente = checkBoxCliente.Checked;
            usuario.Cep = maskedTextBoxCep.Text;
            usuario.Banco = textBoxBanco.Text;
            usuario.NumeroAgenciaBanco = textBoxAgencia.Text;
            usuario.NumeroContaBanco = textBoxNumConta.Text;
            usuario.Observacao = textBoxObservacao.Text;


            ////////////////////////////////////////////////////////////////////
            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }

        private void buttonSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            Inserir();
            MessageBox.Show("CADASTRO REALIZADO COM SUCESSO - INSERINDO NOVO!");
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            textBoxNomeUsuario.Focus();
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxRg_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS NUMEROS SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
        }

        private void textBoxNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
