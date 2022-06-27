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
            usuario.Cpf = textBoxCpf.Text;
            usuario.Ativo = ativoCheckBox.Checked;


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
    }
}
