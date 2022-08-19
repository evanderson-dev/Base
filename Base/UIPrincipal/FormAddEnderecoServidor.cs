using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (checkBoxDiretorioLocal.Checked)
            {
                textBoxNomeMaquinaLocalOuIP.Text = ".";
            }
            if (checkBoxAutenticacaoWindows.Checked)
            {
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
            }
            string stringDeConexao = $"{textBoxNomeServidor.Text}|Initial Catalog={textBoxNomeBanco.Text}; Data Source={textBoxNomeMaquinaLocalOuIP.Text}/{textBoxVersaoSQL.Text}; User ID={textBoxUsuario.Text}; Password={textBoxSenha.Text}";
            MessageBox.Show(stringDeConexao);
            Close();
        }
    }
}
//TOLEDO SERVER|Initial Catalog=ORDEMSERVICO; Data Source=.\SQLEXPRESS; User ID=SA; Password=Senailab05