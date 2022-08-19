using BLL;
using System;
using System.Windows.Forms;
using System.Data;
using Infra;
using System.IO;
using System.Collections;

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
            Close();
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
            try
            {
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (usuarioBindingSource.Count != 0)
            {
                string ativo = ((DataRowView)usuarioBindingSource.Current).Row["Ativo"].ToString();
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["NomeUsuario"].ToString();
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();
                string senhaCriptografada = FuncoesGlobais.Base64Encode(textBoxSenha.Text);
                if ((nome == textBoxUsuario.Text) && (senha == senhaCriptografada) && ativo == "True")
                {
                    UsuarioLogado.Id = ((DataRowView)usuarioBindingSource.Current).Row["Id"].ToString();
                    UsuarioLogado.NomeCompleto = ((DataRowView)usuarioBindingSource.Current).Row["NomeCompleto"].ToString();
                    UsuarioLogado.NomeUsuario = nome;
                    Logou = true;
                    this.Hide();
                    TelaInicial();
                    this.Close();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip toolTip1 = new ToolTip();
                //toolTip1.ReshowDelay = 500;
                //toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(this.buttonConfirmarServidor, "My button1");
                toolTip1.SetToolTip(this.comboBoxEnderecoDoBanco, "My checkBox1");

                string[] lineOfContents = File.ReadAllLines(FuncoesGlobais.Base64Decode(Constante.DiretorioDoEnderecoBanco + Constante.NomeArquivoBanco));
                UsuarioLogado.conexaoAtual = lineOfContents[0];

            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttonConfirmarServidor_Click(object sender, EventArgs e)
        {
            UsuarioLogado.conexaoAtual = comboBoxEnderecoDoBanco.Text;
            ArquivoBanco.GravarBanco(FuncoesGlobais.Base64Encode(Convert.ToString(comboBoxEnderecoDoBanco.Text)));
        }

        private void comboBoxEnderecoDoBanco_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxEnderecoDoBanco.DataSource == null)
            {
                try
                {
                    EnderecoServidorBLL enderecoServidorBLL = new EnderecoServidorBLL();
                    comboBoxEnderecoDoBanco.DataSource = enderecoServidorBLL.Buscar();
                    comboBoxEnderecoDoBanco.DisplayMember = "Descricao";
                    comboBoxEnderecoDoBanco.ValueMember = "StringDeConexao";
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void comboBoxEnderecoDoBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuarioLogado.conexaoAtual = Convert.ToString(comboBoxEnderecoDoBanco.SelectedValue);
            ArquivoBanco.GravarBanco(FuncoesGlobais.Base64Encode(Convert.ToString(comboBoxEnderecoDoBanco.SelectedValue)));
        }
    }
}
