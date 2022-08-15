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
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR ESTE PLANO?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            PlanoBLL planoBLL = new PlanoBLL();
            int id = Convert.ToInt32(((DataRowView)planoBindingSource.Current).Row["Id"]);

            planoBLL.Excluir(id);
            planoBindingSource.RemoveCurrent();
            MessageBox.Show("PLANO EXCLUÍDO COM SUCESSO!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroPlano frm = new FormCadastroPlano(planoBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }
    }
}
