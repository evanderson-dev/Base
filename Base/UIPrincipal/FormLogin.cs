using BLL;
using System;
using System.Windows.Forms;
using System.Data;

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
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["NomeUsuario"].ToString();//PARA CORRIGIR
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();//PARA CORRIGIR
                //string nome = "admin";//"SELET NomeUsuario FROM Pessoa WHERE NomeUsuario='" + textBoxUsuario.Text + "'";
                //string senha = "admin";//"SELET Senha FROM Pessoa WHERE Senha='"+textBoxSenha.Text+"'";

                //NAO ALTERAR ABAIXO
                if ((nome == textBoxUsuario.Text) && (senha == textBoxSenha.Text))
                {
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
