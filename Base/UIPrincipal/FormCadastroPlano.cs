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
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO: " + ex.Message);
            }
        }

        private void Inserir()
        {
            PlanoBLL usuarioBLL = new PlanoBLL();
            Plano usuario = new Plano();

            usuario.Id = Convert.ToInt32(textBoxId.Text);
            usuario.Descricao = textBoxDescricao.Text;
            usuario.Valor = textBoxValor.Text;

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }
    }
}