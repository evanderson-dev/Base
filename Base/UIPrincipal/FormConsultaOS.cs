using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp; // BIBLIOTECA PARA TRABALHAR COM ARQUIVOS PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.html.simpleparser;
using Infra;

namespace UIPrincipal
{
    public partial class FormConsultaOS : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        OrdemServicoBLL ordemServicoBLL = new OrdemServicoBLL();
        TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
        StatusOSBLL statusOSBLL = new StatusOSBLL();
        PlanoBLL planoBLL = new PlanoBLL();
        public FormConsultaOS()
        {
            InitializeComponent();
        }
        private void FormConsultaOS_Load(object sender, EventArgs e)
        {
            textBoxBuscarOS.Focus();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ordemServicoBindingSource.DataSource = ordemServicoBLL.BuscarOS(textBoxBuscarOS.Text);
            
            textBoxProtocolo.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Protocolo"];
            labelIdPessoa.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["Id_Cliente"]);
            textBoxNomeCompleto.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["NomeCompleto"];
            textBoxCpf.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cpf"];
            maskedTextBoxCep.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cep"];
            textBoxRua.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Rua"];
            textBoxNumCasa.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["NumCasa"];
            textBoxBairro.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Bairro"];
            textBoxEmail.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Email"];
            maskedTextBoxTelefone.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Telefone"];
            maskedTextBoxCelularUm.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["CelularUm"];
            maskedTextBoxCelularDois.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["CelularDois"];
            textBoxCidade.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cidade"];
            textBoxUf.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Uf"];

            textBoxDescricao.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Descricao"];
            textBoxAtendente.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Atendente"];
            maskedTextBoxDataAbertura.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["DataAbertura"]);
            maskedTextBoxPrazo.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["DataPrazo"]);

            comboBoxTipoChamado.DataSource = tipoChamadoBLL.BuscarTipoChamado("");
            comboBoxTipoChamado.DisplayMember = "Descricao";
            comboBoxTipoChamado.ValueMember = "Id";
            comboBoxTipoChamado.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["TipoChamado"];

            comboBoxEstatusOS.DataSource = statusOSBLL.BuscarStatusOS("");
            comboBoxEstatusOS.DisplayMember = "Descricao";
            comboBoxEstatusOS.ValueMember = "Id";
            comboBoxEstatusOS.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["EstatusOS"];

            comboBoxLigarAntes.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["LigarAntes"];

            comboBoxTecnicoResponsavel.DataSource = usuarioBLL.BuscarFuncionario("1");
            comboBoxTecnicoResponsavel.DisplayMember = "NomeCompleto";
            comboBoxTecnicoResponsavel.ValueMember = "Id";
            comboBoxTecnicoResponsavel.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["TecnicoResponsavel"];

            string id_Plano = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["Id_Plano"]);
            planoBindingSource.DataSource = planoBLL.BuscarPlano(id_Plano);
            textBoxPlano.Text = (string)(((DataRowView)planoBindingSource.Current).Row["Descricao"]);
        }

        private void textBoxBuscarOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(null,null);
                //ordemServicoBindingSource.DataSource = ordemServicoBLL.BuscarOS("");
            }
        }

        [Obsolete]
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            string filepath = Infra.Constante.DiretorioDePDF + @"\testePDF.pdf";

            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes
            string caminho = filepath;//OBS: o nome sempre deve ser terminado com .pdf
            //criando o arquivo pdf em branco, passando como parametro a variavel doc criada
            //acima e a variavel caminho tambem criada acima.
            if (!Directory.Exists(Constante.DiretorioDePDF))//CRIA A PASTA CASO ELA NAO EXISTA
                Directory.CreateDirectory(Constante.DiretorioDePDF);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            
            doc.Open();

            //criando a variavel para paragrafo
            Paragraph paragrafoUm = new Paragraph("", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafoUm.Alignment = Element.ALIGN_CENTER;//etipulando o alinhamneto
            //AQUI ONDE VAMOS ADICIONAR A VARIAVEL DO TIPO "Font"
            paragrafoUm.Font = new Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold);
            string texto = "PROTOCOLO: " + textBoxProtocolo.Text + "\n\n";
            paragrafoUm.Add(texto);//adicionando texto

            /*Paragraph paragrafoDois = new Paragraph("", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Regular));
            paragrafoDois.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafoDois.Font = new Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            texto = "ID: " + labelIdPessoa.Text + "  NOME: " + textBoxNomeCompleto.Text + "  CPF/CNPJ: " + textBoxCpf.Text;
            paragrafoDois.Add(texto);*/

            PdfPTable table = new PdfPTable(6);
            table.TotalWidth = 520f;
            table.LockedWidth = true;

            //PdfPCell header = new PdfPCell(new Phrase("PROTOCOLO: " + textBoxProtocolo.Text, new Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Regular)));
            //header.Colspan = 6;
            //table.AddCell(header);*/

            //LINHA UM
            PdfPCell cell_Nome = new PdfPCell(new Phrase("CLIENTE: "+ labelIdPessoa.Text + " - " + textBoxNomeCompleto.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            cell_Nome.Colspan = 4;
            table.AddCell(cell_Nome);

            PdfPCell cell_CPF_CNPJ = new PdfPCell(new Phrase("CPF/CNPJ: " + textBoxCpf.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            cell_CPF_CNPJ.Colspan = 2;
            table.AddCell(cell_CPF_CNPJ);

            //LINHA DOIS
            PdfPCell cell_Cep = new PdfPCell(new Phrase("CEP: " + maskedTextBoxCep.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            table.AddCell(cell_Cep);

            PdfPCell cell_Endereco = new PdfPCell(new Phrase("ENDEREÇO: " + textBoxRua.Text +", "+ textBoxNumCasa.Text + ", " + textBoxCidade.Text + " - " + textBoxUf.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            cell_Endereco.Colspan = 4;
            table.AddCell(cell_Endereco);

            PdfPCell cell_Plano = new PdfPCell(new Phrase("PLANO: " + textBoxPlano.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            table.AddCell(cell_Plano);

            //LINHA TRES
            PdfPCell cell_Email = new PdfPCell(new Phrase("E-MAIL: " + textBoxEmail.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            table.AddCell(cell_Email);

            PdfPCell cell_Telefone = new PdfPCell(new Phrase("TELEFONES: " + maskedTextBoxTelefone.Text + " | " + maskedTextBoxCelularUm.Text + " | " +maskedTextBoxCelularDois.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            cell_Telefone.Colspan = 3;
            table.AddCell(cell_Telefone);

            PdfPCell cell_Atendente = new PdfPCell(new Phrase("ATENDENTE: " + textBoxAtendente.Text, new Font(iTextSharp.text.Font.NORMAL, 9, (int)System.Drawing.FontStyle.Regular)));
            cell_Atendente.Colspan = 2;
            table.AddCell(cell_Atendente);

            //LINHA QUATRO


            //## PROPRIEDADES UTEIS ############################################################
            // cell.Border = 0;
            // cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            // table.AddCell("TEXTO PARA SER EXIBIDO");

            doc.Add(paragrafoUm);//adicionando escrita no arquivo.
            doc.Add(table);//adicionando escrita no arquivo.
            doc.Close();//fechando documento para que seja salva as alteraçoes.
            System.Diagnostics.Process.Start(caminho);//Abrindo o arquivo após cria-lo.

            //PdfPCell bottom = new PdfPCell(new Phrase("bottom"));
            //bottom.Colspan = 4;
            //table.AddCell(bottom);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
