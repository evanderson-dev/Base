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

        private void FormParaTeste_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dirs = Directory.GetFiles(Constante.DiretorioDoEnderecoBanco, "BD*");
                MessageBox.Show($"O NUMERO DE ARQUIVOS COMEÇANDO COM D É: {dirs.Length}.");
                /*foreach (string dir in dirs)
                {
                    MessageBox.Show(dir);
                }*/
                //comboBoxEnderecoDoBanco.DataSource = dirs;
                for (int i = 0; i < dirs.Length; i++)
                {
                    string caminho = dirs[i];
                    //MessageBox.Show(caminho);
                    string conteudo = File.ReadAllText(caminho);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"O PROCESSO FALHOU: {ex.Message}");
            }
        }
    }
}
