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
            MessageBox.Show((string)((DataRowView)usuarioBindingSource.Current).Row["Foto"]);
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
            else if (nivelFuncionario == "3")
            {
                radioButtonNivelTres.Checked = true;
            }
        }
    }
}
