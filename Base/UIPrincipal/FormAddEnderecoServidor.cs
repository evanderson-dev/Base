using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormAddEnderecoServidor : Form
    {
        public FormAddEnderecoServidor()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddEnderecoServidor_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string dadosLogin = $"User ID = {textBoxUsuario.Text}; Password = {textBoxSenha.Text}";
            if (checkBoxAutenticacaoWindows.Checked)
                dadosLogin = "Integrated Security = True";

            if (checkBoxDiretorioLocal.Checked)
                textBoxNomeMaquinaLocalOuIP.Text = ".";

            if (checkBoxAutenticacaoWindows.Checked)
            {
                textBoxUsuario.Text = "Integrated Security = True";
                textBoxSenha.Text = "";
            }

            string stringDeConexao = $"{textBoxNomeServidor.Text}|Initial Catalog = {textBoxNomeBanco.Text}; Data Source = {textBoxNomeMaquinaLocalOuIP.Text}/{textBoxVersaoSQL.Text}; {dadosLogin}";
            MessageBox.Show(stringDeConexao);
            Close();
        }
    }
}