using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormDetalhesPessoa : Form
    {
        public FormDetalhesPessoa()
        {
            InitializeComponent();
        }
        public FormDetalhesPessoa(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
        }

        private void FormDetalhesPessoa_Load(object sender, EventArgs e)
        {
            pictureBoxFoto.ImageLocation = (string)((DataRowView)usuarioBindingSource.Current).Row["Foto"];
            string nivelFuncionario = Convert.ToString(((DataRowView)usuarioBindingSource.Current).Row["Id_Permissao"]);

            if (Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Ativo"]) == 1)
            {
                checkBoxAtivo.Checked = true;
            }

            if (Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Cliente"]) == 1)
            {
                checkBoxCliente.Checked = true;
            }

            if (Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Funcionario"]) == 1)
            {
                checkBoxFuncionario.Checked = true;
            }

            if (nivelFuncionario == "1")
            {
                radioButtonNivelUm.Checked = true;
            }
            else if (nivelFuncionario == "2")
            {
                radioButtonNivelDois.Checked = true;
            }
            else
            {
                radioButtonNivelTres.Checked = true;
            }
        }
    }
}
