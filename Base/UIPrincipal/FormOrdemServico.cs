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
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
        StatusOSBLL statusOSBLL = new StatusOSBLL();
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
            //UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void FormOrdemServico_Load(object sender, EventArgs e)
        {
            //textBoxProtocolo.Text = DateTime.Now.ToShortDateString().Replace("/","");
            textBoxProtocolo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");//("ano/MES/dia/HORA/minuto/segundo")

            maskedTextBoxDataAbertura.Text = DateTime.Now.ToString();

            textBoxBuscar.Focus();

            comboBoxTipoChamado.DataSource = tipoChamadoBLL.BuscarTipoChamado("");
            comboBoxTipoChamado.DisplayMember = "Descricao";
            comboBoxTipoChamado.ValueMember = "Id";

            comboBoxStatusOS.DataSource = statusOSBLL.BuscarStatusOS("");
            comboBoxStatusOS.DisplayMember = "Descricao";
            comboBoxStatusOS.ValueMember = "Id";
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(null,null);
            }
        }
    }
}
