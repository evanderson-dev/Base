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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PlanoBLL planoBLL = new PlanoBLL();
            planoBindingSource.DataSource = planoBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroPlano frm = new FormCadastroPlano())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA EXCLUIR O PLANO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            PlanoBLL planoBLL = new PlanoBLL();
            int id = Convert.ToInt32(((DataRowView)planoBindingSource.Current).Row["Id"]);

            planoBLL.Excluir(id);
            planoBindingSource.RemoveCurrent();
            MessageBox.Show("PLANO EXCLUIDO COM SUCESSO!");
        }
    }
}
