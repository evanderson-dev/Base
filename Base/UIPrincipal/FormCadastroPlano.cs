using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroPlano : Form
    {
        private bool inserindoNovo;
        public FormCadastroPlano()
        {
            InitializeComponent();
            planoBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroPlano(object _current)
        {
            InitializeComponent();
            planoBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonSalvarPlano_Click(object sender, EventArgs e)
        {
            try
            {
                planoBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("OPERAÇÃO REALIZADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO! " + ex.Message);
            }
        }
        private void Inserir()
        {
            PlanoBLL planoBLL = new PlanoBLL();
            Plano plano = new Plano();

            plano.Descricao = textBoxDescricaoPlano.Text;
            plano.Valor = textBoxValorPlano.Text;

            if (inserindoNovo)
                planoBLL.Inserir(plano);
            else
                planoBLL.Alterar(plano);
        }
        private void buttonCancelarCadastroPlano_Click(object sender, EventArgs e)
        {
            Close();
        }
               
    }
}
