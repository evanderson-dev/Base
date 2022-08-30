using Infra;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConfiguracoes : Form
    {
        private string origemCompleto = "";
        private string foto = "";
        private string destinoCompleto = "";
        private readonly string pastaDestino = Constante.DiretorioDeImagem;
        ToolTip toolTipConfiguracoes = new ToolTip();
        

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FormConfiguracoes()
        {
            InitializeComponent();
            toolTipConfiguracoes.SetToolTip(buttonAddLogo, "Adicionar Logo");
            toolTipConfiguracoes.SetToolTip(buttonDeleteLogo, "Deletar Logo");
            toolTipConfiguracoes.SetToolTip(buttonSalvarTema, "Salvar Tema");
            pictureBoxLogoOS.ImageLocation = Constante.DiretorioDeImagem + "\\logo.png";
            textBoxPersonalizado.BackColor = Temas.corTextBoxFundo;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
            corDeFundoPrimeiroPlano.BackColor = Temas.corDeFundoPrimeiroPlano;
            corTextoPrimeiroPlano.BackColor = Temas.corTextoPrimeiroPlano;
            buttonCorTextBox.BackColor = Temas.corTextBoxFundo;
            buttonCorTextoTextBox.BackColor = Temas.corTextBoxTexto;
            buttonCorFundoComboBox.BackColor = Temas.corComboBoxFundo;
            buttonCorTextoComboBox.BackColor = Temas.corComboBoxTexto;
            comboBox.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
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
            MyDialog.Color = Temas.corTemporaria;
            MyDialog.ShowDialog();
            return MyDialog.Color;            
        }
        private void buttonCorTextBox_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = buttonCorTextBox.BackColor;
            Temas.corTextBoxFundo = selecionarCor(sender, e);
            textBoxPersonalizado.BackColor = Temas.corTextBoxFundo;
            buttonCorTextBox.BackColor = Temas.corTextBoxFundo;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
        }
        private void buttonCorTextoTextBox_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = buttonCorTextoTextBox.BackColor;
            Temas.corTextBoxTexto = selecionarCor(sender, e);
            textBoxPersonalizado.ForeColor = Temas.corTextBoxTexto;
            buttonCorTextoTextBox.BackColor = Temas.corTextBoxTexto;
            textBoxPersonalizado.Text = "TEXTO: " + Temas.corTextBoxTexto.ToString() + " FUNDO: " + Temas.corTextBoxFundo.ToString();
        }
        private void corDeFundoPrimeiroPlano_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = corDeFundoPrimeiroPlano.BackColor;
            Temas.corDeFundoPrimeiroPlano = selecionarCor(sender, e);
            corDeFundoPrimeiroPlano.BackColor = Temas.corDeFundoPrimeiroPlano;
        }
        private void corTextoPrimeiroPlano_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = corTextoPrimeiroPlano.BackColor;
            Temas.corTextoPrimeiroPlano = selecionarCor(sender, e);
            corTextoPrimeiroPlano.BackColor = Temas.corTextoPrimeiroPlano;
        }
        private void buttonCorFundoComboBox_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = buttonCorFundoComboBox.BackColor;
            Temas.corComboBoxFundo = selecionarCor(sender, e);
            comboBox.BackColor = Temas.corComboBoxFundo;
            comboBox.Text = "TEXTO: " + Temas.corComboBoxTexto.ToString() + " FUNDO: " + Temas.corComboBoxFundo.ToString();
            buttonCorFundoComboBox.BackColor = Temas.corComboBoxFundo;
        }
        private void buttonCorTextoComboBox_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = buttonCorTextoComboBox.BackColor;
            Temas.corComboBoxTexto = selecionarCor(sender, e);
            comboBox.ForeColor = Temas.corComboBoxTexto;
            comboBox.Text = "TEXTO: " + Temas.corComboBoxTexto.ToString() + " FUNDO: " + Temas.corComboBoxFundo.ToString();
            buttonCorTextoComboBox.BackColor = Temas.corComboBoxTexto;
        }
    }
}
