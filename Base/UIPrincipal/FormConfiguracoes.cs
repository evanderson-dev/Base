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
            CarregarTema();
        }

        private void CarregarTema()
        {
            textBoxPersonalizado.BackColor = Temas.corTextBoxFundo;
            textBoxPersonalizado.Text = $"TEXTO: {Temas.corTextBoxTexto} FUNDO: {Temas.corTextBoxFundo}";
            corDeFundoPrimeiroPlano.BackColor = Temas.corDeFundoPrimeiroPlano;
            corTextoPrimeiroPlano.BackColor = Temas.corTextoPrimeiroPlano;
            buttonCorTextBox.BackColor = Temas.corTextBoxFundo;
            buttonCorTextoTextBox.BackColor = Temas.corTextBoxTexto;
            buttonCorFundoComboBox.BackColor = Temas.corComboBoxFundo;
            buttonCorTextoComboBox.BackColor = Temas.corComboBoxTexto;
            comboBox.Text = $"TEXTO: {Temas.corTextBoxTexto} FUNDO:{Temas.corTextBoxFundo}";
            for (int i = 0; i < 3; i++)
                dataGridView.Rows.Add($"0{i}", "NOME EXEMPLO", "123.456.789-12");
            for (int r = 0; r < dataGridView.RowCount; r++)
            {
                for (int c = 0; c < dataGridView.ColumnCount; c++)
                    dataGridView.Rows[r].Cells[c].Style.BackColor = Temas.corGridViewFundo;
            }
            dataGridView.BackgroundColor = Temas.corGridViewFundo;
            dataGridView.ForeColor = Temas.corGridViewTexto;
            dataGridView.GridColor = Temas.corGridViewLinhas;
            buttonCorFundoGridView.BackColor = Temas.corGridViewFundo;
            buttonCorTextoGridView.BackColor = Temas.corGridViewTexto;
            buttonCorLinhaGridView.BackColor = Temas.corGridViewLinhas;
            panelJanelaCustomizada.BackColor = Temas.corDeFundoPrimeiroPlano;
            labelBarraSuperior.BackColor = Temas.corLabelSuperior;
            labelBarraSuperior.ForeColor = Temas.corLabelSuperiorTexto;
            labelTextBox.ForeColor = Temas.corTextoPrimeiroPlano;
            labelComboBox.ForeColor = Temas.corTextoPrimeiroPlano;
            labelTabela.ForeColor = Temas.corTextoPrimeiroPlano;
            labelSuperior.BackColor = Temas.corLabelSuperior;
            buttonFechar.BackColor = Temas.corLabelSuperior;
            buttonCorCustomizado.BackColor = Temas.corBotao;
            buttonCorCustomizado.ForeColor = Temas.corBotaoTexto;
            buttonCorTextoBotao.BackColor = Temas.corBotaoTexto;
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
            ColorDialog MyDialog = new ColorDialog
            {
                // Permite que o usuário selecione ou edite uma cor personalizada.
                AllowFullOpen = true,
                // Atribui uma matriz de cores personalizadas à propriedade CustomColors
                CustomColors = new int[]{6916092, 15195440, 16107657, 1836924,
                3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294,
                3102017, 7324121, 14993507, 11730944,},
                ShowHelp = true,
                Color = Temas.corTemporaria
            };
            MyDialog.ShowDialog();
            return MyDialog.Color;            
        }

        private void corDeFundoPrimeiroPlano_Click(object sender, EventArgs e)
        {// COR DE FUNDO GERAL
            Temas.corTemporaria = corDeFundoPrimeiroPlano.BackColor;
            corDeFundoPrimeiroPlano.BackColor = selecionarCor(sender, e);
            panelJanelaCustomizada.BackColor = corDeFundoPrimeiroPlano.BackColor;
        }

        private void corTextoPrimeiroPlano_Click(object sender, EventArgs e)
        {// COR DO TEXTO GERAL
            Temas.corTemporaria = corTextoPrimeiroPlano.BackColor;
            corTextoPrimeiroPlano.BackColor = selecionarCor(sender, e);
            labelTextBox.ForeColor = corTextoPrimeiroPlano.BackColor;
            labelComboBox.ForeColor = corTextoPrimeiroPlano.BackColor;
            labelTabela.ForeColor = corTextoPrimeiroPlano.BackColor;
        }

        private void buttonCorTextBox_Click(object sender, EventArgs e)
        {// COR DO FUNDO DA TEXT BOX
            Temas.corTemporaria = buttonCorTextBox.BackColor;
            buttonCorTextBox.BackColor = selecionarCor(sender, e);
            textBoxPersonalizado.BackColor = buttonCorTextBox.BackColor;
            textBoxPersonalizado.Text = $"TEXTO: {buttonCorTextoTextBox.BackColor} FUNDO: {buttonCorTextBox.BackColor}";
        }

        private void buttonCorTextoTextBox_Click(object sender, EventArgs e)
        {// COR DO TEXTO DA TEXT BOX
            Temas.corTemporaria = buttonCorTextoTextBox.BackColor;
            buttonCorTextoTextBox.BackColor = selecionarCor(sender, e);
            textBoxPersonalizado.ForeColor = buttonCorTextoTextBox.BackColor;
            textBoxPersonalizado.Text = $"TEXTO: {buttonCorTextoTextBox.BackColor} FUNDO: {buttonCorTextBox.BackColor}";
        }

        private void buttonCorFundoComboBox_Click(object sender, EventArgs e)
        {// COR DE FUNDO DO COMBO BOX
            Temas.corTemporaria = buttonCorFundoComboBox.BackColor;
            buttonCorFundoComboBox.BackColor = selecionarCor(sender, e);
            comboBox.BackColor = buttonCorFundoComboBox.BackColor;
            comboBox.Text = $"TEXTO: {buttonCorTextoComboBox.BackColor} FUNDO: {buttonCorFundoComboBox.BackColor}";
        }

        private void buttonCorTextoComboBox_Click(object sender, EventArgs e)
        {// COR DO TEXTO DO COMBO BOX
            Temas.corTemporaria = buttonCorTextoComboBox.BackColor;
            buttonCorTextoComboBox.BackColor = selecionarCor(sender, e);
            comboBox.ForeColor = buttonCorTextoComboBox.BackColor;
            comboBox.Text = $"TEXTO: { buttonCorTextoComboBox.BackColor} FUNDO: {buttonCorFundoComboBox.BackColor}";
        }

        private void buttonCorFundoGridView_Click(object sender, EventArgs e)
        {// COR DO FUNDO DAS CELULAS DA GRIDVIEW
            Temas.corTemporaria = buttonCorFundoGridView.BackColor;
            buttonCorFundoGridView.BackColor = selecionarCor(sender, e);
            for (int r = 0; r < dataGridView.RowCount; r++)
            {
                for (int c = 0; c < dataGridView.ColumnCount; c++)
                    dataGridView.Rows[r].Cells[c].Style.BackColor = buttonCorFundoGridView.BackColor;
            }
            dataGridView.BackgroundColor = buttonCorFundoGridView.BackColor;
        }

        private void buttonCorTextoGridView_Click(object sender, EventArgs e)
        {// COR DO TEXTO DA GRIDVIEW
            Temas.corTemporaria = buttonCorTextoGridView.BackColor;
            buttonCorTextoGridView.BackColor = selecionarCor(sender, e);
            dataGridView.ForeColor = buttonCorTextoGridView.BackColor;
        }

        private void buttonCorLinhaGridView_Click(object sender, EventArgs e)
        {// COR DA LINHA DA GRIDVIEW
            Temas.corTemporaria = buttonCorLinhaGridView.BackColor;
            buttonCorLinhaGridView.BackColor = selecionarCor(sender, e);
            dataGridView.GridColor = buttonCorLinhaGridView.BackColor;
        }

        private void buttonCorBarraSuperior_Click(object sender, EventArgs e)
        {// COR DA BARRA SUPERIOR
            Temas.corTemporaria = buttonCorBarraSuperior.BackColor;
            buttonCorBarraSuperior.BackColor = selecionarCor(sender, e);
            labelBarraSuperior.BackColor = buttonCorBarraSuperior.BackColor;
            buttonFechar.BackColor = buttonCorBarraSuperior.BackColor;
        }

        private void buttonCorTextoBarraSuperior_Click(object sender, EventArgs e)
        {// COR DO TEXTO DA BARRA SUPERIOR
            Temas.corTemporaria = buttonCorTextoBarraSuperior.BackColor;
            buttonCorTextoBarraSuperior.BackColor = selecionarCor(sender, e);
            labelBarraSuperior.ForeColor = buttonCorTextoBarraSuperior.BackColor;
        }

        private void buttonCorBotao_Click(object sender, EventArgs e)
        {// COR DOS BOTOES
            Temas.corTemporaria = buttonCorBotao.BackColor;
            buttonCorBotao.BackColor = selecionarCor(sender, e);
            buttonCorCustomizado.BackColor = buttonCorBotao.BackColor;            
        }

        private void buttonCorTextoBotao_Click(object sender, EventArgs e)
        {
            Temas.corTemporaria = buttonCorTextoBotao.BackColor;
            buttonCorTextoBotao.BackColor = selecionarCor(sender, e);
            buttonCorCustomizado.ForeColor = buttonCorTextoBotao.BackColor;
            
        }
        private void buttonSalvarTema_Click(object sender, EventArgs e)
        {
            if (MessageBoxCustomizada.Show("DESEJA SALVAR ESTE TEMA? ","",MessageBoxButtons.YesNo,"?") == DialogResult.Yes)
            {
                Temas.corDeFundoPrimeiroPlano = corDeFundoPrimeiroPlano.BackColor;
                Temas.corTextoPrimeiroPlano = corTextoPrimeiroPlano.BackColor;
                Temas.corTextBoxFundo = buttonCorTextBox.BackColor;
                Temas.corTextBoxTexto = buttonCorTextoTextBox.BackColor;
                Temas.corComboBoxFundo = buttonCorFundoComboBox.BackColor;
                Temas.corComboBoxTexto = buttonCorTextoComboBox.BackColor;
                Temas.corGridViewFundo = buttonCorFundoGridView.BackColor;
                Temas.corGridViewTexto = buttonCorTextoGridView.BackColor;
                Temas.corGridViewLinhas = buttonCorLinhaGridView.BackColor;
                Temas.corLabelSuperior = buttonCorBarraSuperior.BackColor;
                Temas.corLabelSuperiorTexto = buttonCorTextoBarraSuperior.BackColor;
                Temas.corBotao = buttonCorBotao.BackColor;
                Temas.corBotaoTexto = buttonCorTextoBotao.BackColor;
                MessageBoxCustomizada.Show("TEMA SALVO COM SUCESSO!");
            }
            else
            {
                return;
            }
        }
    }
}
