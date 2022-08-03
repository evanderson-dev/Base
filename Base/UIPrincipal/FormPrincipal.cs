﻿using BLL;
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
        OrdemServicoBLL ordemServicoBLL = new OrdemServicoBLL();
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
            toolStripTextBoxPesquisar.Focus();

            /*try
            {
            // TODO: esta linha de código carrega dados na tabela 'oRDEMSERVICODataSetOsPendente.SP_BuscarOSPendente'. Você pode movê-la ou removê-la conforme necessário.
            this.sP_BuscarOSPendenteTableAdapter.Fill(this.oRDEMSERVICODataSetOsPendente.SP_BuscarOSPendente);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
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
        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxPesquisar.Text != null)
            {
                dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOS(toolStripTextBoxPesquisar.Text);
            }
            else
            {
                dataGridViewOSAbertas.DataSource = ordemServicoBLL.BuscarOSPendente();
                //this.sP_BuscarOSPendenteTableAdapter.Fill(this.oRDEMSERVICODataSetOsPendente.SP_BuscarOSPendente);
            }
        }

        private void buttonTeste_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            psi.Arguments = "-s -f -t 0";
            psi.CreateNoWindow = true;
            Process p = Process.Start(psi);
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
    }
}
