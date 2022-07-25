using BLL;
using System;
using System.Data;
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

        private void FormConsultaPlano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null, null);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroPlano frm  = new FormCadastroPlano())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PlanoBLL planoBLL = new PlanoBLL();
            planoBindingSource.DataSource = planoBLL.BuscarPlano(textBoxBuscar.Text);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            PlanoBLL planoBLL = new PlanoBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)planoBindingSource.Current).Row["Id"]);

            planoBLL.Excluir(id);
            planoBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroPlano frm = new FormCadastroPlano(planoBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
