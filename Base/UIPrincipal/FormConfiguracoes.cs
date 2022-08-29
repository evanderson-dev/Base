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
        private string origemCompleto = "";
        private string foto = "";
        private string destinoCompleto = "";
        private readonly string pastaDestino = Constante.DiretorioDeImagem;

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FormConfiguracoes()
        {
            InitializeComponent();
            pictureBoxLogoOS.ImageLocation = Constante.DiretorioDeImagem + "\\logo.png";
            textBoxPersonalizado.BackColor = Temas.corTextBoxFundo;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
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
        private Color selecionarCor(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog MyDialog = new ColorDialog();
            // Permite que o usuário selecione ou edite uma cor personalizada.
            MyDialog.AllowFullOpen = true;
            // Atribui uma matriz de cores personalizadas à propriedade CustomColors
            MyDialog.CustomColors = new int[]{6916092, 15195440, 16107657, 1836924,
            3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294,
            3102017, 7324121, 14993507, 11730944,};
            MyDialog.ShowHelp = true;
            MyDialog.Color = this.BackColor;
            MyDialog.ShowDialog();
            return MyDialog.Color;
        }
        private void buttonCorTextBox_Click(object sender, EventArgs e)
        {
            Temas.corTextBoxFundo = selecionarCor(sender, e);
            textBoxPersonalizado.BackColor = Temas.corTextBoxFundo;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
        }
        private void buttonCorTextoTextBox_Click(object sender, EventArgs e)
        {
            Temas.corTextBoxTexto = selecionarCor(sender, e);
            textBoxPersonalizado.ForeColor = Temas.corTextBoxTexto;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
        }
        private void corDeFundoPrimeiroPlano_Click(object sender, EventArgs e)
        {
            Temas.corDeFundoPrimeiroPlano = selecionarCor(sender, e);
            groupBoxCoresSistema.BackColor = Temas.corDeFundoPrimeiroPlano;
        }
        private void corTextoPrimeiroPlano_Click(object sender, EventArgs e)
        {
            Temas.corTextoPrimeiroPlano = selecionarCor(sender, e);
            groupBoxCoresSistema.ForeColor = Temas.corTextoPrimeiroPlano;
        }

        private void buttonCorFundoComboBox_Click(object sender, EventArgs e)
        {
            Temas.corComboBoxFundo = selecionarCor(sender, e);
            comboBox.BackColor = Temas.corComboBoxFundo;
        }

        private void buttonCorTextoComboBox_Click(object sender, EventArgs e)
        {
            Temas.corComboBoxTexto = selecionarCor(sender, e);
            comboBox.ForeColor = Temas.corComboBoxTexto;
        }
    }
}
