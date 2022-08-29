using BLL;
using Infra;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        private bool Logado = true;
        private bool modificarProtcolo = false;
        private string protocolo;
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
            if (UsuarioLogado.luzLigada)
            {
                FuncoesGlobais.temaPersonalizado(this, Temas.corDeFundoPrimeiroPlano, Temas.corTextoPrimeiroPlano, Temas.corTextBoxFundo, Temas.corTextBoxTexto, Color.White, Color.Black, Color.White, Color.Black, Color.White, Color.Black);
                for (int i = 0; i < menuStrip1.Items.Count; i++)
                    menuStrip1.Items[i].ForeColor = Temas.corTextoPrimeiroPlano;
            }
            else
            {
                FuncoesGlobais.temaModoNorturno(this);
                for (int i = 0; i < menuStrip1.Items.Count; i++)
                    menuStrip1.Items[i].ForeColor = Color.White;
                for (int i = 0; i < statusStrip1.Items.Count; i++)
                    statusStrip1.Items[i].ForeColor = Color.White;
            }
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
            ToolTip toolTipOS = new ToolTip();
            ToolTip toolTipCadastro = new ToolTip();
            if (tabControlConsulta.SelectedIndex == 0)
            {
                toolTipOS.SetToolTip(this.buttonBuscarCadastro, "Buscar O.S");
            }
            else if (tabControlConsulta.SelectedIndex == 1)
            {
                toolTipCadastro.SetToolTip(this.buttonBuscarCadastro, "Buscar Cadastro");
            }
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
        private void dataGridViewOSAbertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                protocolo = dataGridViewOSAbertas.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }

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
                bindingSource.DataSource = ordemServicoBLL.BuscarOrdemServico(protocolo);
                Impressao.GerarArquivoPdfOS(bindingSource);

                using (FormPdfView formPdfView = new FormPdfView())
                {
                    formPdfView.ShowDialog();
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
            cadastrarPessoaToolStripMenuItem.Visible = true;
            deletarPessoaToolStripMenuItem.Visible = true;
            editarPessoaToolStripMenuItem.Visible = true;
        }

        private void buttonBuscarCadastro_Click(object sender, EventArgs e)
        {
            if (tabControlConsulta.SelectedIndex == 0)
            {
                if (textBoxBuscarCadastro.Text == "")
                {
                    if (checkBoxFechada.Checked == true)
                    {
                        dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSFechada();
                    }
                    else if (checkBoxAberto.Checked == true)
                    {
                        dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSAberta();
                    }
                    else if (checkBoxEncaminhado.Checked == true)
                    {
                        dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSEncaminhada();
                    }
                    else
                    {
                        dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSPendente();
                    }
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
                checkBoxAberto.Checked = false;
                checkBoxFechada.Checked = false;
                checkBoxEncaminhado.Checked = false;
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
            try
            {
                if (usuarioDataGridView.Rows.Count > 1)
                {
                    textoCopiado = usuarioDataGridView.CurrentCell.Value.ToString();
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
                buttonFecharAba.Location = new Point(180, 66);
                deletarPessoaToolStripMenuItem.Visible = false;
                editarPessoaToolStripMenuItem.Visible = false;
            }
            if (tabControlConsulta.SelectedIndex == 1 && buttonFecharAba.Visible == true)
            {
                buttonFecharAba.Size = new Size(13,13);
                buttonFecharAba.Location = new Point(180,64);
                deletarPessoaToolStripMenuItem.Visible = true;
                editarPessoaToolStripMenuItem.Visible = true;
            }
        }

        private void dataGridViewOSAbertas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FuncoesGlobais.mouse_event(FuncoesGlobais.MOUSEEVENTF_LEFTDOWN, e.X, e.Y, 0, 0);
                FuncoesGlobais.mouse_event(FuncoesGlobais.MOUSEEVENTF_LEFTUP, e.X, e.Y, 0, 0);
                modificarProtcolo = true;
            }
        }
        private void usuarioDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FuncoesGlobais.mouse_event(FuncoesGlobais.MOUSEEVENTF_LEFTDOWN, e.X, e.Y, 0, 0);
                FuncoesGlobais.mouse_event(FuncoesGlobais.MOUSEEVENTF_LEFTUP, e.X, e.Y, 0, 0);
                modificarProtcolo = true;
            }
        }

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

        private void editarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDataGridView.Rows.Count > 1)
            {
                using (FormCadastroUsuario frm = new FormCadastroUsuario(usuarioBindingSource.Current))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                return;
            }
        }

        private void deletarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioDataGridView.Rows.Count > 1)
            {
                if (MessageBoxCustomizada.Show("CONFIRMA A EXCLUSÃO DO CADASTRO?", "", MessageBoxButtons.YesNo,"?") == DialogResult.No)
                {
                    return;
                }
                else
                {
                    int id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
                    if ((string)((DataRowView)usuarioBindingSource.Current).Row["Foto"] != "")
                    {
                        File.Delete((string)((DataRowView)usuarioBindingSource.Current).Row["Foto"]);
                    }
                    usuarioBLL.Excluir(id);// EXCLUSÃO DO CADASTRO NO BANCO
                    usuarioBindingSource.RemoveCurrent();// ATUALIZAÇÃO DA GRID VIEW REMOVENDO O ITEM EXCLUIDO
                    MessageBoxCustomizada.Show("CADASTRO EXCLUIDO COM SUCESSO!","",MessageBoxButtons.OK,"!");
                }
            }
            else
            {
                return;
            }
        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void checkBoxAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAberto.Checked == true)
            {
                checkBoxEncaminhado.Checked = false;
                checkBoxFechada.Checked = false;
            }
        }

        private void checkBoxEncaminhado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEncaminhado.Checked == true)
            {
                checkBoxAberto.Checked = false;
                checkBoxFechada.Checked = false;
            }
        }

        private void checkBoxFechada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFechada.Checked == true)
            {
                checkBoxAberto.Checked = false;
                checkBoxEncaminhado.Checked = false;
            }
        }

        private void exibirDetalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingSource bindingSourceConsultaCadastro = new BindingSource();
            bindingSourceConsultaCadastro.DataSource = usuarioBLL.Buscar(cpfPessoa);
            using (FormDetalhesPessoa frm = new FormDetalhesPessoa(bindingSourceConsultaCadastro))
            {
                frm.ShowDialog();
            }
        }

        private void sERVIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciamentoServidor frm = new FormGerenciamentoServidor();
            frm.ShowDialog();
        }

        private void jANELADETESTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParaTeste formParaTeste = new FormParaTeste();
            formParaTeste.ShowDialog();
        }

        private void cONFIGURAÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes frm = new FormConfiguracoes();
            frm.Show();
        }
    }
}
