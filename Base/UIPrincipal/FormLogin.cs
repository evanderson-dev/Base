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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);

            if (usuarioBindingSource.Count != 0)
            {
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["NomeUsuario"].ToString();
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();
                //NAO ALTERAR ABAIXO
                if ((nome == textBoxUsuario.Text) && (senha == textBoxSenha.Text))
                {
                    Constante.UsuarioLogado = nome;
                    Logou = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETO!");
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("USUARIO OU SENHA INCORRETO!");
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
