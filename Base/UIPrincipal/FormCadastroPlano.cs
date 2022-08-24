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
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                planoBindingSource.EndEdit();
                Inserir();
                MessageBoxCustomizada.Show("PLANO CADASTRADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBoxCustomizada.Show("OCORREU UM ERRO: " + ex.Message);
            }
        }
        private void Inserir()
        {
            PlanoBLL planoBLL = new PlanoBLL();
            Plano plano = new Plano();

            plano.Id = 0;//Convert.ToInt32(textBoxId.Text);
            plano.Descricao = textBoxDescricao.Text;
            plano.Valor = textBoxValor.Text;

            if (inserindoNovo)
                planoBLL.Inserir(plano);
            else
                planoBLL.Alterar(plano);
        }
    }
}