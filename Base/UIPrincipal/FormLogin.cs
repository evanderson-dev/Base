using BLL;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;//ADICIONADO PARA TESTE
using System.Data;//ADICIONADO PARA TESTE

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
        ///////////////////////////////////////////////////////////////////////////////
        SqlConnection cn = new SqlConnection(@"Initial Catalog=ORDEMSERVICO; Data Source = EVANDERSON\SQLEXPRESS; Integrated Security=True");
        string nome, senha;
        ///////////////////////////////////////////////////////////////////////////////
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();//FORÇA O FECHAMENTO DE TODO O SISTEMA
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);

            /*/////////////////////////////////////////////////////////////////////////
            string login = "SELECT NomeUsuario, Senha FROM Pessoa WHERE NomeUsuario='" + textBoxUsuario.Text + "'AND Senha'" + textBoxSenha.Text + "'";
            SqlCommand cmd = new SqlCommand(login, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nome = reader[0].ToString();
                    senha = reader[1].ToString();
                    cn.Close();
                    
                    if ((nome == textBoxUsuario.Text) && (senha == textBoxSenha.Text))
                    {
                        Logou = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO OU SENHA INCORRETO - TESTE!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!");
            }
            /////////////////////////////////////////////////////////////////////////*/

            if (usuarioBindingSource.Count != 0)
            {
                //string nome = ((DataRowView)usuarioBindingSource.Current).Row["NomeCompleto"].ToString();//PARA CORRIGIR
                //string senha = ((DataRowView)usuarioBindingSource.Current).Row["Cpf"].ToString();//PARA CORRIGIR
                string nome = "admin";//"SELET NomeUsuario FROM Pessoa WHERE NomeUsuario='" + textBoxUsuario.Text + "'";
                string senha = "admin";//"SELET Senha FROM Pessoa WHERE Senha='"+textBoxSenha.Text+"'";

                //string login = "SELECT NomeUsuario, Senha FROM Pessoa WHERE NomeUsuario='"+textBoxUsuario.Text+"'AND Senha'"+textBoxSenha.Text+"'";


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
    }
}
