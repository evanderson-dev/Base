using BLL;
using System;
using System.Windows.Forms;
using System.Data;
using Infra;

namespace UIPrincipal
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();//FORÇA O FECHAMENTO DE TODO O SISTEMA
        }
        private void TelaInicial()
        {
            using (FormPrincipal frm = new FormPrincipal())
            {
                frm.ShowDialog();
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);

            if (usuarioBindingSource.Count != 0)
            {
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["NomeUsuario"].ToString();
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();
                string ativo = ((DataRowView)usuarioBindingSource.Current).Row["Ativo"].ToString();

                if ((nome == textBoxUsuario.Text) && (senha == textBoxSenha.Text) && ativo == "True")
                {
                    UsuarioLogado.Id = ((DataRowView)usuarioBindingSource.Current).Row["Id"].ToString();
                    UsuarioLogado.NomeCompleto = ((DataRowView)usuarioBindingSource.Current).Row["NomeCompleto"].ToString();
                    UsuarioLogado.NomeUsuario = nome;
                    Logou = true;
                    TelaInicial();
                    Close();
                }
                else if (ativo == "False")
                {
                    labelUsuarioDesativado.Text = "USUARIO DESATIVADO!";
                    textBoxSenha.Text = "";
                    textBoxUsuario.Focus();
                }                
                else if(senha != textBoxSenha.Text)
                {
                    labelUsuarioDesativado.Text = "SENHA INCORRETA!";
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }                
                else
                {
                    labelUsuarioDesativado.Text = "USUARIO OU SENHA INCORRETO!";
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }
            }
            else
            {
                labelUsuarioDesativado.Text = "USUARIO OU SENHA INCORRETO!";
                textBoxSenha.Text = "";
                textBoxSenha.Focus();
            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin_Click(null, null);
        }
    }
}
