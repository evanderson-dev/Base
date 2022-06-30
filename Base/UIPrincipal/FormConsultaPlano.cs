using BLL;
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
    public partial class FormConsultaPlano : Form
    {
        public FormConsultaPlano()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PlanoBLL planoBLL = new PlanoBLL();
            planoBindingSource.DataSource = planoBLL.Buscar(textBoxBuscar.Text);
            /*
             UsuarioBLL usuarioBLL = new UsuarioBLL();
             usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
             */
        }
    }
}
