using BLL;
using Infra;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        private bool Logado = true;
        private string protocoloOculto = "";
        private string cpfPessoa = "";
        OrdemServicoBLL ordemServicoBLL = new OrdemServicoBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuario frm = new FormConsultaUsuario())
            {
                frm.ShowDialog();
            }
        }
        
        private void pLANOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaPlano frm = new FormConsultaPlano())
            {
                frm.ShowDialog();
            }
        }
        private void tIPODECHAMADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormTipoChamado frm = new FormTipoChamado())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAbrirOS_Click(object sender, EventArgs e)
        {
            using (FormOrdemServico frm = new FormOrdemServico())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUsuario.Text = UsuarioLogado.NomeUsuario;
            dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSPendente();
        }
                
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Logou = false;
            if (!frmLogin.Logou)
            {
                this.Hide();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            /*DialogResult resposta = MessageBox.Show("DESEJA ENCERRAR O SISTEMA?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }*/
        }
        private void dataGridViewOSAbertas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewOSAbertas.CurrentRow.Selected = true;
                string protocolo = dataGridViewOSAbertas.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormConsultaOS frm = new FormConsultaOS(protocolo);
                frm.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private void dataGridViewOSAbertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewOSAbertas.CurrentRow.Selected = true;
                protocoloOculto = dataGridViewOSAbertas.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaOS frm = new FormConsultaOS(protocoloOculto);
            frm.Show();
        }

        private void toolStripMenuItemNovo_Click(object sender, EventArgs e)
        {
            using (FormOrdemServico frm = new FormOrdemServico())
            {
                frm.ShowDialog();
            }
        }

        private void deligarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            psi.Arguments = "-s -f -t 0";
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlConsulta.SelectTab(1);
            //usuarioBindingSource.DataSource = usuarioBLL.BuscarFuncionario("1");
        }

        private void buttonBuscarCadastro_Click(object sender, EventArgs e)
        {
            if (tabControlConsulta.SelectedIndex == 0)
            {
                //labelFilto.Visible = false;
                if (textBoxBuscarCadastro.Text == "")
                {
                    dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSPendente();
                }
                else
                {
                    dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOS(textBoxBuscarCadastro.Text);
                }
            }
            else if (tabControlConsulta.SelectedIndex == 1)
            {
                if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == true && checkBoxCliente.Checked == false && checkBoxAtivo.Checked == false)
                {   // FUNCIONARIO INATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarFuncionarioInativo();
                }
                else if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == true && checkBoxCliente.Checked == false && checkBoxAtivo.Checked == true)
                {   // FUNCIONARIO ATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarFuncionario("1");
                }
                else if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == false && checkBoxCliente.Checked == true && checkBoxAtivo.Checked == false)
                {   // CLIENTE INATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarClienteInativo();
                }
                else if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == false && checkBoxCliente.Checked == true && checkBoxAtivo.Checked == true)
                {   // CLIENTE ATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarClienteAtivo();
                }
                else if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == true && checkBoxCliente.Checked == true && checkBoxAtivo.Checked == false)
                {   // CLIENTE E FUNCIONARIO INATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarClienteFuncionarioInativo();
                }
                else if (textBoxBuscarCadastro.Text == "" && checkBoxFuncionario.Checked == true && checkBoxCliente.Checked == true && checkBoxAtivo.Checked == true)
                {   // CLIENTE E FUNCIONARIO ATIVO
                    usuarioBindingSource.DataSource = usuarioBLL.BuscarClienteFuncionarioAtivo();
                }
                else
                {
                    usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscarCadastro.Text);
                }
            }
        }
        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = null;
            usuarioDataGridView.DataSource = usuarioBindingSource;
            textBoxBuscarCadastro.Text = "";
            checkBoxFuncionario.Checked = false;
            checkBoxCliente.Checked = false;
            checkBoxAtivo.Checked = false;
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuarioDataGridView.CurrentRow.Selected = true;
                cpfPessoa = usuarioDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void usuarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource bindingSourceConsultaCadastro = new BindingSource();
            bindingSourceConsultaCadastro.DataSource = usuarioBLL.Buscar(cpfPessoa);
            using (FormDetalhesPessoa frm = new FormDetalhesPessoa(bindingSourceConsultaCadastro))
            {
                frm.ShowDialog();
            }
        }

        private void fORMPARATESTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalhesPessoa frm = new FormDetalhesPessoa();
            frm.ShowDialog();
        }

        private void abrirOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSourceConsultaCadastro = new BindingSource();
            bindingSourceConsultaCadastro.DataSource = usuarioBLL.Buscar(cpfPessoa);
            using (FormOrdemServico frm = new FormOrdemServico(bindingSourceConsultaCadastro))
            {
                frm.ShowDialog();
            }
        }
    }
}
