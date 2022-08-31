using System.Configuration;
using System.Collections.Specialized;
using BLL;
using System;
using System.Windows.Forms;
using System.Data;
using Infra;
using System.IO;
using System.Drawing;

namespace UIPrincipal
{
    public partial class FormLogin : Form
    {
        public bool Logou;
        ToolTip toolTipServidor = new ToolTip();
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
            labelInformacaoErro.Text = "";
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            try
            {
                usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);
            }
            catch (Exception ex)
            {
                MessageBoxCustomizada.Show(ex.Message);
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
                else if ((nome == textBoxUsuario.Text) && (senha == senhaCriptografada) && ativo == "False")
                {
                    labelInformacaoErro.Text = "USUARIO DESATIVADO!";
                    textBoxSenha.Text = "";
                    textBoxUsuario.Focus();
                }                
                else if((nome == textBoxUsuario.Text) && (senha != senhaCriptografada))
                {
                    labelInformacaoErro.Text = "SENHA INCORRETA!";
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }
                else if ((nome != textBoxUsuario.Text))
                {
                    labelInformacaoErro.Text = "O USUARIO NÃO EXISTE";
                    textBoxSenha.Text = "";
                    textBoxUsuario.Focus();
                }
            }
        }
        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin_Click(null, null);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            toolTipServidor.SetToolTip(buttonConfirmarServidor, "Confirmar Servidor");
            toolTipServidor.SetToolTip(buttonAddServidor, "Adicionar Servidor");
            toolTipServidor.SetToolTip(buttonAtualizar, "Atualizar Lista");
            if (UsuarioLogado.luzLigada)
            {
                Temas.temaPersonalizado
                (
                this,
                Temas.corDeFundoPrimeiroPlano,
                Temas.corTextoPrimeiroPlano,
                Temas.corTextBoxFundo,
                Temas.corTextBoxTexto,
                Temas.corMaskedTextBoxFundo,
                Temas.corMaskedTextBoxTexto,
                Temas.corComboBoxFundo,
                Temas.corComboBoxTexto,
                Temas.corGridViewTexto,
                Temas.corBotao,
                Temas.corBotaoTexto
                );
                toolTipServidor.SetToolTip(buttonBlackWhite, "Ativar Modo Noturno");
                buttonBlackWhite.Image = Properties.Resources.lightbulb;
                buttonBlackWhite.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonAddServidor.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonAtualizar.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonConfirmarServidor.BackColor = Temas.corDeFundoPrimeiroPlano;
            }
            else
            {
                Temas.temaModoNorturno(this);
                toolTipServidor.SetToolTip(buttonBlackWhite, "Desativar Modo Noturno");
            }

            try
            {
                if (File.Exists(Convert.ToString(Constante.DiretorioDoEnderecoBanco + Constante.NomeArquivoBanco)))
                {
                    string[] texto = File.ReadAllLines(Convert.ToString(Constante.DiretorioDoEnderecoBanco + Constante.NomeArquivoBanco));
                    string servidorDecriptografado = texto[0];
                    UsuarioLogado.conexaoAtual = FuncoesGlobais.Base64Decode(servidorDecriptografado);
                }
            }
            catch (Exception ex)
            {
                MessageBoxCustomizada.Show(ex.Message);
            }
            //string test = ConfigurationManager.AppSettings.Get("luz");
            //MessageBoxCustomizada.Show(test);
            //ConfigurationManager.AppSettings.Set("luz", "0");
            //test = ConfigurationManager.AppSettings.Get("luz");
            //MessageBoxCustomizada.Show(test);
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

        private void buttonAddServidor_Click(object sender, EventArgs e)
        {
            FormAddEnderecoServidor frm = new FormAddEnderecoServidor();
            frm.ShowDialog();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
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

        private void buttonBlackWhite_Click(object sender, EventArgs e)
        {
            if (!UsuarioLogado.luzLigada)
            {
                UsuarioLogado.luzLigada = true;
                toolTipServidor.SetToolTip(buttonBlackWhite, "Ativar Modo Noturno");
                Temas.temaPersonalizado
                (
                this,
                Temas.corDeFundoPrimeiroPlano,
                Temas.corTextoPrimeiroPlano,
                Temas.corTextBoxFundo,
                Temas.corTextBoxTexto,
                Temas.corMaskedTextBoxFundo,
                Temas.corMaskedTextBoxTexto,
                Temas.corComboBoxFundo,
                Temas.corMaskedTextBoxTexto,
                Temas.corGridViewTexto,
                Temas.corBotao,
                Temas.corBotaoTexto
                );
                buttonBlackWhite.Image = Properties.Resources.lightbulb;
                buttonBlackWhite.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonAddServidor.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonAtualizar.BackColor = Temas.corDeFundoPrimeiroPlano;
                buttonConfirmarServidor.BackColor = Temas.corDeFundoPrimeiroPlano;
            }
            else
            {
                UsuarioLogado.luzLigada = false;
                buttonBlackWhite.Image = Properties.Resources.lightbulb_off;
                toolTipServidor.SetToolTip(buttonBlackWhite, "Ativar Modo Claro");
                Temas.temaModoNorturno(this);
            }
        }
    }
}
