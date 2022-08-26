using Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConfiguracoes : Form
    {
        string origemCompleto="", foto="", destinoCompleto="", pastaDestino = Constante.DiretorioDeImagem;

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FormConfiguracoes()
        {
            InitializeComponent();
            pictureBoxLogoOS.ImageLocation = Constante.DiretorioDeImagem + "\\logo.png";
        }
        private void buttonDeleteLogo_Click(object sender, EventArgs e)
        {
            if (pictureBoxLogoOS.ImageLocation != "" || pictureBoxLogoOS.ImageLocation != null)
            {
                File.Delete(pictureBoxLogoOS.ImageLocation);
                pictureBoxLogoOS.ImageLocation = "";
            }
        }

        private void buttonAddLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogAddLogo = new OpenFileDialog();
            if (openFileDialogAddLogo.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Constante.DiretorioDeImagem))//VERIFICA SE A PASTA JA EXISTE
                    Directory.CreateDirectory(Constante.DiretorioDeImagem);//CRIA A PASTA CASO ELA NAO EXISTA

                if (File.Exists(Constante.DiretorioDeImagem + "\\logo.png"))//VERIFICA SE O ARQUIVO PASTA JA EXISTE
                    File.Delete(Constante.DiretorioDeImagem + "\\logo.png");//DELETA O ARQUIVO CASO ELE JÁ EXISTA

                origemCompleto = openFileDialogAddLogo.FileName;//RETORNA O CAMINHO COMPLETO E NOME DO ARQUIVO
                foto = openFileDialogAddLogo.SafeFileName;//RETORNA O NOME DO ARQUIVO
                destinoCompleto = pastaDestino + foto;
                
                try
                {
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true);//COPIA O ARQUIVO DA PASTA DE ORIGEM PARA A PASTA DE DESTINO
                    File.Move(destinoCompleto, pastaDestino + "\\logo.png");//ESTE COMANDO RENOMEIA O ARQUIVO
                }
                catch (Exception ex)
                {
                    MessageBoxCustomizada.Show(ex.Message);
                }
                
                pictureBoxLogoOS.ImageLocation = Constante.DiretorioDeImagem + @"\logo.png";
            }
            else
            {
                return;
            }
        }
    }
}
