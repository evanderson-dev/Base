using BLL;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormTipoChamado : Form
    {
        private bool inserindoNovo;
        private bool permitirSalvar = false;
        TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
        public FormTipoChamado()
        {
            InitializeComponent();
            tipoChamadoBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormTipoChamado(object _current)
        {
            InitializeComponent();
            tipoChamadoBindingSource.DataSource = _current;
            inserindoNovo = false;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormTipoChamado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                buttonSair_Click(null, null);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            tipoChamadoBindingSource.DataSource = tipoChamadoBLL.BuscarTipoChamado(textBoxBuscar.Text);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA EXCLUIR O TIPO DE CHAMADO?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id;
            id = Convert.ToInt32(((DataRowView)tipoChamadoBindingSource.Current).Row["Id"]);
            
            tipoChamadoBLL.Excluir(id);
            tipoChamadoBindingSource.RemoveCurrent();
            MessageBox.Show("TIPO DE CHAMADO EXCLUIDO COM SUCESSO!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            permitirSalvar = true;
            inserindoNovo = false;
            textBoxDescricao.ReadOnly = false;
            textBoxDescricao.Text = (string)((DataRowView)tipoChamadoBindingSource.Current).Row["Descricao"];
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            permitirSalvar = true;
            inserindoNovo = true;
            textBoxId.Text = "0";
            textBoxDescricao.Text = null;
            textBoxDescricao.ReadOnly = false;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            permitirSalvar = false;
            inserindoNovo = false;
            textBoxId.Text = "0";
            textBoxDescricao.Text = null;
            textBoxDescricao.ReadOnly = true;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (permitirSalvar)
            {
                try
                {
                    tipoChamadoBindingSource.EndEdit();
                    TipoChamado tipoChamado = new TipoChamado();

                    tipoChamado.Id = Convert.ToInt32(textBoxId.Text);
                    tipoChamado.Descricao = textBoxDescricao.Text;

                    if (inserindoNovo)
                    {
                        tipoChamadoBLL.Inserir(tipoChamado);
                    }
                    else
                    {
                        tipoChamadoBLL.Alterar(tipoChamado);
                    }
                    textBoxDescricao.ReadOnly = true;
                    tipoChamadoBindingSource.DataSource = tipoChamadoBLL.BuscarTipoChamado(textBoxBuscar.Text);
                    permitirSalvar = false;
                    
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OCORREU UM ERRO" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SELECIONE A OPÇÃO NOVO OU ALTERAR ANTES DE SALVAR!");
            }
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tipoChamadoBindingSource.DataSource = tipoChamadoBLL.BuscarTipoChamado("");
            }
        }
    }
}
