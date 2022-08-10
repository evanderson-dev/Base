using BLL;
using Infra;
using System;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormParaTeste : Form
    {
        public FormParaTeste()
        {
            InitializeComponent();
        }

        private void buttonGravarBanco_Click(object sender, EventArgs e)
        {
            ArquivoBanco.GravarBanco(textBoxGravarBanco.Text);
            MessageBox.Show("ENDEREÇO DO BANCO SALVO COM SUCESSO!");
            textBoxGravarBanco.Text = "";
            textBoxGravarBanco.Focus();

            comboBoxServidores.Items.Clear();
            string[] lineOfContents = File.ReadAllLines(Constante.DiretorioDoEnderecoBanco + Constante.NomeArquivoBanco);
            foreach (var item in lineOfContents)
            {
                string[] bancos = item.Split(',');
                comboBoxServidores.Items.Add(bancos[0]);
            }
        }

        private void comboBoxServidores_Click(object sender, EventArgs e)
        {

        }

        private void FormParaTeste_Load(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines(Constante.DiretorioDoEnderecoBanco + Constante.NomeArquivoBanco);
            foreach (var item in lineOfContents)
            {
                string[] bancos = item.Split(',');
                comboBoxServidores.Items.Add(bancos[0]);
            }

            EnderecoServidorBLL enderecoServidorBLL = new EnderecoServidorBLL();
            comboBoxEnderecoDoBanco.DataSource = enderecoServidorBLL.Buscar("");
            comboBoxEnderecoDoBanco.DisplayMember = "Descricao";
            comboBoxEnderecoDoBanco.ValueMember = "StringDeConexao";
        }

        private void buttonGerenciarServidor_Click(object sender, EventArgs e)
        {
            FormGerenciamentoServidor frm = new FormGerenciamentoServidor();
            frm.ShowDialog();
        }
    }
}
