using BLL;
using Infra;
using System;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormGerenciamentoServidor : Form
    {
        string valorCelulaSelecionada;
        EnderecoServidorBLL enderecoServidorBLL = new EnderecoServidorBLL();
        public FormGerenciamentoServidor()
        {
            InitializeComponent();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormGerenciamentoServidor_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewGerenciamentoServidor.DataSource = enderecoServidorBLL.Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormAddEnderecoServidor frm = new FormAddEnderecoServidor();
            frm.ShowDialog();
        }
        private void dataGridViewGerenciamentoServidor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valorCelulaSelecionada = dataGridViewGerenciamentoServidor.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }        
        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            string caminhoCriptografado, caminhoDescriptografado;
            string[] caminho = Directory.GetFiles(Constante.DiretorioDoEnderecoBanco, "BD*");
            if (MessageBox.Show("CONFIRMA A EXCLUSÃO DESTE ENDEREÇO DE SERVIDOR?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < caminho.Length; i++)
                    {
                        caminhoCriptografado = File.ReadAllText(caminho[i]);
                        caminhoDescriptografado = FuncoesGlobais.Base64Decode(caminhoCriptografado);
                        if (caminhoDescriptografado.Contains(valorCelulaSelecionada))
                        {
                            File.Delete(caminho[i]);
                            buttonAtualizar_Click(sender, e);
                            MessageBox.Show($"O ARQUIVO {caminho[i]} FOI EXCLUÍDO!");
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewGerenciamentoServidor.DataSource = enderecoServidorBLL.Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
