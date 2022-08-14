using BLL;
using Infra;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        private bool Logado = true;
        private bool modificarProtcolo = false;
        private string protocoloOculto = "";
        public string cpfPessoa = "";
        public string textoCopiado = "";
        private string protocoloOcultoPropriedade
        {
            get { return protocoloOculto; }
            set
            {
                protocoloOculto = value;
                if (tabControlConsulta.SelectedIndex == 0)
                {
                    contextMenuStripAbaUm.Show(MousePosition.X, MousePosition.Y);
                }
                if (tabControlConsulta.SelectedIndex == 1)
                {
                    contextMenuStripAbaDois.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

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
            textBoxBuscarCadastro.Focus();
            tabControlConsulta.TabPages.Remove(tabPageCadastrados);
            buttonFecharAba.Visible = false;
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
            /*try
            {
                dataGridViewOSAbertas.CurrentRow.Selected = true;
                string protocolo = dataGridViewOSAbertas.Rows[e.RowIndex].Cells[1].Value.ToString();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ordemServicoBLL.BuscarOrdemServico(protocoloOculto);
                using (FormConsultaOS frm = new FormConsultaOS(bindingSource))
                {
                    frm.ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }*/
        }
        private void dataGridViewOSAbertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textoCopiado = dataGridViewOSAbertas.CurrentCell.Value.ToString();
            try
            {
                dataGridViewOSAbertas.CurrentRow.Selected = true;
                if (modificarProtcolo)
                {
                    protocoloOcultoPropriedade = dataGridViewOSAbertas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    modificarProtcolo = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlConsulta.SelectedIndex == 0)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ordemServicoBLL.BuscarOrdemServico(protocoloOculto);
                using (FormConsultaOS frm = new FormConsultaOS(bindingSource))
                {
                    frm.ShowDialog();
                }
            }
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
            buttonFecharAba.Visible = true;
            if (!tabControlConsulta.Controls.Contains(tabPageCadastrados))
            {
                tabControlConsulta.Controls.Add(tabPageCadastrados);
                //tabControlConsulta.TabPages.Insert(index, tabPageCadastrados);
            }
            tabControlConsulta.SelectTab(1);
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
            if (tabControlConsulta.SelectedIndex == 0)
            {
                textBoxBuscarCadastro.Text = "";
                dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSPendente();
            }
            else
            {
                usuarioBindingSource.DataSource = null;
                usuarioDataGridView.DataSource = usuarioBindingSource;
                textBoxBuscarCadastro.Text = "";
                checkBoxFuncionario.Checked = false;
                checkBoxCliente.Checked = false;
                checkBoxAtivo.Checked = false;
            }
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textoCopiado = usuarioDataGridView.CurrentCell.Value.ToString();
            try
            {
                if (usuarioDataGridView.Rows.Count > 1)
                {
                    usuarioDataGridView.CurrentRow.Selected = true;
                    cpfPessoa = usuarioDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            try
            {
                usuarioDataGridView.CurrentRow.Selected = true;
                if (modificarProtcolo)
                {
                    protocoloOcultoPropriedade = usuarioDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    modificarProtcolo = false;
                }
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
            FormParaTeste frm = new FormParaTeste();
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

        private void textBoxBuscarCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscarCadastro_Click(sender, e);
            }
        }

        private void buttonFecharAba_Click(object sender, EventArgs e)
        {
            tabControlConsulta.Controls.Remove(tabPageCadastrados);
            buttonFecharAba.Visible = false;
        }

        private void tabControlConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlConsulta.SelectedIndex == 0 && buttonFecharAba.Visible == true)
            {
                buttonFecharAba.Size = new Size(11,11);
                buttonFecharAba.Location = new Point(181,37);
            }
            if (tabControlConsulta.SelectedIndex == 1 && buttonFecharAba.Visible == true)
            {
                buttonFecharAba.Size = new Size(13,13);
                buttonFecharAba.Location = new Point(181,35);
            }
        }

        private void dataGridViewOSAbertas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, e.X, e.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, e.X, e.Y, 0, 0);
                modificarProtcolo = true;
            }
        }
        private void usuarioDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, e.X, e.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, e.X, e.Y, 0, 0);
                modificarProtcolo = true;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        private void visualizarDetalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ordemServicoBLL.BuscarOrdemServico(protocoloOculto);
            using (FormConsultaOS frm = new FormConsultaOS(bindingSource))
            {
                frm.ShowDialog();
            }
        }

        private void impressãoDiretaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ordemServicoBLL.BuscarOrdemServico(protocoloOculto);
            Impressao.ImprimirOS(bindingSource);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Clipboard.SetText(textoCopiado);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void copiarAbaDoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textoCopiado);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
            {
                frm.ShowDialog();
            }
        }
    }
}
