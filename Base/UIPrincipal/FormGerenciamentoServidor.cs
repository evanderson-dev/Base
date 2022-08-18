using BLL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormGerenciamentoServidor : Form
    {
        EnderecoServidorBLL enderecoServidorBLL = new EnderecoServidorBLL();
        public FormGerenciamentoServidor()
        {
            InitializeComponent();
        }

        private void FormGerenciamentoServidor_Load(object sender, EventArgs e)
        {
            dataGridViewGerenciamentoServidor.DataSource = enderecoServidorBLL.Buscar("");
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este endereço?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id;
            //dataGridViewGerenciamentoServidor.CurrentRow.Selected = true;
            //id = (int)dataGridViewGerenciamentoServidor.Rows[e.RowIndex].Cells[1].Value;
            //id = Convert.ToInt32(((DataRowView)planoBindingSource.Current).Row["Id"]);

            //enderecoServidorBLL.Excluir(id);
            //planoBindingSource.RemoveCurrent();
            MessageBox.Show("TESTE");
        }
    }
}
