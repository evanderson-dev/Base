using BLL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class TipoChamado : Form
    {
        public TipoChamado()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
            tipoChamadoBindingSource.DataSource = tipoChamadoBLL.BuscarTipoChamado(textBoxBuscar.Text);
        }

    }
}
