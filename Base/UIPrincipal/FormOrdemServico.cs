using BLL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormOrdemServico : Form
    {
        private bool inserindoNovo;
        public FormOrdemServico()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormOrdemServico(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }
    }
}
