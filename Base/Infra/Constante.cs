using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Data;
using System.IO;
using System.Runtime;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Infra
{
    public static class Constante
    {
        public static string DiretorioDeImagem = Environment.CurrentDirectory + @"\Imgs\";
        public static string DiretorioDePDF = Environment.CurrentDirectory + @"\PDF\";
        public static string DiretorioDoEnderecoBanco = Environment.CurrentDirectory + @"\Servidores\";
        public static string NomeArquivoBanco = "Endereço do Servidor.txt";
    }
    public static class UsuarioLogado
    {
        public static string Id = null;
        public static string NomeUsuario = null;
        public static string NomeCompleto = null;
        public static string conexaoAtual = "";
        public static bool luzLigada = false;
        public static bool luz = false;
    }

    public static class ArquivoBanco
    {
        public static void GravarEnderecoBancoNoArquivo(string _texto, string _caminho)
        {
            FileStream fileStream = new FileStream(_caminho, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.Write(_texto);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public static void GravarStringDeConexaoNoArquivo(string _texto)
        {
            string nomeArquivo = "BD";

            if (!Directory.Exists(Constante.DiretorioDoEnderecoBanco))
                CriarPasta(Constante.DiretorioDoEnderecoBanco);

            for (int i = 1; i > 0; i++)
            {
                if (!File.Exists(Constante.DiretorioDoEnderecoBanco + nomeArquivo + i + ".txt"))
                {
                    FileStream fileStream = new FileStream(Constante.DiretorioDoEnderecoBanco + nomeArquivo + i + ".txt", FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                    streamWriter.Write(FuncoesGlobais.Base64Encode(_texto));
                    streamWriter.Flush();
                    streamWriter.Close();
                    fileStream.Close();
                    break;
                }
            }
        }

        public static void GravarBanco(string _texto)
        {
            CriarPasta(Constante.DiretorioDoEnderecoBanco);
            GravarEnderecoBancoNoArquivo(_texto, Constante.DiretorioDoEnderecoBanco + "\\" + Constante.NomeArquivoBanco);
        }

        public static void CriarPasta(string _caminho)
        {
            Directory.CreateDirectory(_caminho);
        }
    }
    
    public static class Impressao
    {
        #region Impressao Direta
        public static void ImprimirOS(object _current)//IMPRESSAO DIRETA
        {
            BindingSource bindingSourceImprimirOS = new BindingSource();
            bindingSourceImprimirOS.DataSource = _current;
            string teste = "";
            teste = (string)((DataRowView)bindingSourceImprimirOS.Current).Row["NomeCompleto"];
            string filepath = Constante.DiretorioDePDF + @"\testePDF.pdf";

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

            PdfPTable table = new PdfPTable(6);
            table.TotalWidth = 520f;
            table.LockedWidth = true;

            if (!File.Exists(Constante.DiretorioDeImagem + @"\logo.png"))
            {
                PdfPCell cell_Imagem = new PdfPCell(new Phrase($" "));
                cell_Imagem.Border = 0;
                cell_Imagem.PaddingBottom = 20;
                cell_Imagem.Colspan = 2;
                table.AddCell(cell_Imagem);
            }
            else
            {
                Image logo = Image.GetInstance(Constante.DiretorioDeImagem + @"\logo.png");
                logo.ScaleToFit(100f, 100f);
                PdfPCell cell_Imagem = new PdfPCell(new Phrase($"IMG", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
                cell_Imagem.AddElement(logo);
                cell_Imagem.Border = 0;
                cell_Imagem.PaddingBottom = 20;
                cell_Imagem.Colspan = 2;
                table.AddCell(cell_Imagem);
            }

            PdfPCell cell_Protocolo = new PdfPCell(new Phrase($"PROTOCOLO: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Protocolo"]}", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_Protocolo.Border = 0;
            cell_Protocolo.PaddingBottom = 20;
            cell_Protocolo.HorizontalAlignment = 1;
            cell_Protocolo.Colspan = 2;
            table.AddCell(cell_Protocolo);

            string idOS = Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["Id"]);
            PdfPCell cell_IdOS = new PdfPCell(new Phrase($"O.S N°: {idOS}", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_IdOS.Border = 0;
            cell_IdOS.PaddingBottom = 20;
            cell_IdOS.HorizontalAlignment = 2;
            cell_IdOS.Colspan = 2;
            table.AddCell(cell_IdOS);

            //LINHA UM
            PdfPCell cell_Nome = new PdfPCell(new Phrase($"Cliente: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["NomeCompleto"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Nome.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Nome.BorderWidth = 1f;
            cell_Nome.Padding = 4f;
            cell_Nome.PaddingTop = 1f;
            cell_Nome.Colspan = 4;
            table.AddCell(cell_Nome);

            PdfPCell cell_CPF_CNPJ = new PdfPCell(new Phrase($"CPF/CNPJ: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cpf"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_CPF_CNPJ.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_CPF_CNPJ.BorderWidth = 1f;
            cell_CPF_CNPJ.Padding = 4f;
            cell_CPF_CNPJ.PaddingTop = 1f;
            cell_CPF_CNPJ.Colspan = 2;
            table.AddCell(cell_CPF_CNPJ);

            //LINHA DOIS
            PdfPCell cell_Cep = new PdfPCell(new Phrase($"Cep: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cep"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Cep.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Cep.BorderWidth = 1f;
            cell_Cep.Padding = 4f;
            cell_Cep.PaddingTop = 1f;
            table.AddCell(cell_Cep);

            PdfPCell cell_Endereco = new PdfPCell(new Phrase($"Endereço: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Rua"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["NumCasa"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cidade"]} - {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Uf"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Endereco.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Endereco.BorderWidth = 1f;
            cell_Endereco.Padding = 4f;
            cell_Endereco.PaddingTop = 1f;

            cell_Endereco.Colspan = 4;
            table.AddCell(cell_Endereco);

            PdfPCell cell_Plano = new PdfPCell(new Phrase($"Plano: SEM PLANO", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Plano.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Plano.BorderWidth = 1f;
            cell_Plano.Padding = 4f;
            cell_Plano.PaddingTop = 1f;
            table.AddCell(cell_Plano);

            //LINHA TRES
            PdfPCell cell_Email = new PdfPCell(new Phrase($"E-mail: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Email"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Email.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Email.BorderWidth = 1f;
            cell_Email.Padding = 4f;
            cell_Email.PaddingTop = 1f;
            table.AddCell(cell_Email);

            PdfPCell cell_Telefone = new PdfPCell(new Phrase($"Telefones: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Telefone"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["CelularUm"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["CelularDois"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Telefone.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Telefone.BorderWidth = 1f;
            cell_Telefone.Padding = 4f;
            cell_Telefone.PaddingTop = 1f;
            cell_Telefone.Colspan = 3;
            table.AddCell(cell_Telefone);

            PdfPCell cell_Atendente = new PdfPCell(new Phrase($"Atendente: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Atendente"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Atendente.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Atendente.BorderWidth = 1f;
            cell_Atendente.Padding = 4f;
            cell_Atendente.PaddingTop = 1f;
            cell_Atendente.Colspan = 2;
            table.AddCell(cell_Atendente);

            //LINHA QUATRO
            PdfPCell cell_Tipo = new PdfPCell(new Phrase($"Tipo: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["TipoChamado"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Tipo.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Tipo.BorderWidth = 1f;
            cell_Tipo.Padding = 4f;
            cell_Tipo.PaddingTop = 1f;
            table.AddCell(cell_Tipo);

            PdfPCell cell_Status = new PdfPCell(new Phrase($"Status: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["EstatusOS"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Status.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Status.BorderWidth = 1f;
            cell_Status.Padding = 4f;
            cell_Status.PaddingTop = 1f;
            table.AddCell(cell_Status);

            PdfPCell cell_LigarAntes = new PdfPCell(new Phrase($"Ligar Antes: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["LigarAntes"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_LigarAntes.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_LigarAntes.BorderWidth = 1f;
            cell_LigarAntes.Padding = 4f;
            cell_LigarAntes.PaddingTop = 1f;
            table.AddCell(cell_LigarAntes);

            PdfPCell cell_Abertura = new PdfPCell(new Phrase($"Abertura: {Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["DataAbertura"]).Replace("00:00:00", "")}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Abertura.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Abertura.BorderWidth = 1f;
            cell_Abertura.Padding = 4f;
            cell_Abertura.PaddingTop = 1f;
            table.AddCell(cell_Abertura);

            PdfPCell cell_Prazo = new PdfPCell(new Phrase($"Prazo: {Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["DataPrazo"]).Replace("00:00:00", "")}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Prazo.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Prazo.BorderWidth = 1f;
            cell_Prazo.Padding = 4f;
            cell_Prazo.PaddingTop = 1f;
            table.AddCell(cell_Prazo);

            PdfPCell cell_TecResponsavel = new PdfPCell(new Phrase($"Tec. Responsável: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["TecnicoResponsavel"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_TecResponsavel.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecResponsavel.BorderWidth = 1f;
            cell_TecResponsavel.Padding = 4f;
            cell_TecResponsavel.PaddingTop = 1f;
            table.AddCell(cell_TecResponsavel);

            //LINHA CINCO
            PdfPCell cell_Descricao = new PdfPCell(new Phrase($"Descrição: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Descricao"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Descricao.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Descricao.BorderWidth = 1f;
            cell_Descricao.Padding = 4f;
            cell_Descricao.PaddingTop = 1f;
            cell_Descricao.Colspan = 6;
            table.AddCell(cell_Descricao);

            PdfPCell cell_DescricaoServicoProblema = new PdfPCell(new Phrase($"Descrição do Serviço/Problema:\n", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_DescricaoServicoProblema.Colspan = 6;
            cell_DescricaoServicoProblema.Border = 0;
            table.AddCell(cell_DescricaoServicoProblema);

            PdfPCell cell_Linha = new PdfPCell(new Phrase($"_______________________________________________________________________________________________", new Font(iTextSharp.text.Font.NORMAL, 9/*, (int)System.Drawing.FontStyle.Regular*/)));
            cell_Linha.Colspan = 6;
            cell_Linha.Border = 0;
            for (int i = 0; i < 7; i++)
            {
                table.AddCell(cell_Linha);
            }

            PdfPCell cell_QuebraLinha = new PdfPCell(new Phrase("\n", new Font(iTextSharp.text.Font.NORMAL, 9, 1)));
            cell_QuebraLinha.Colspan = 6;
            cell_QuebraLinha.Border = 0;
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TecAtivacao = new PdfPCell(new Phrase("TÉCNICOS LANÇAMENTO DE DROP/ATIVAÇÃO", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_TecAtivacao.BorderColor = BaseColor.GRAY;
            cell_TecAtivacao.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecAtivacao.BorderWidth = 2f;
            cell_TecAtivacao.PaddingBottom = 10f;
            cell_TecAtivacao.PaddingLeft = 20f;
            cell_TecAtivacao.PaddingTop = 4f;
            cell_TecAtivacao.Colspan = 6;
            cell_TecAtivacao.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell_TecAtivacao);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            //LINHA UM
            PdfPCell cell_HrChegada = new PdfPCell(new Phrase("Hr Chegada:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_HrChegada.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_HrChegada.BorderWidth = 1f;
            cell_HrChegada.Padding = 4f;
            cell_HrChegada.PaddingTop = 1f;
            cell_HrChegada.Colspan = 2;
            table.AddCell(cell_HrChegada);

            PdfPCell cell_HrSaida = new PdfPCell(new Phrase("Hr Saída:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_HrSaida.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_HrSaida.BorderWidth = 1f;
            cell_HrSaida.Padding = 4f;
            cell_HrSaida.PaddingTop = 1f;
            cell_HrSaida.Colspan = 2;
            table.AddCell(cell_HrSaida);

            PdfPCell cell_Data = new PdfPCell(new Phrase("Data:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Data.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Data.BorderWidth = 1f;
            cell_Data.Padding = 4f;
            cell_Data.PaddingTop = 1f;
            cell_Data.Colspan = 2;
            table.AddCell(cell_Data);

            //LINHA DOIS
            PdfPCell cell_SinalCTO = new PdfPCell(new Phrase("Sinal CTO:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalCTO.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalCTO.BorderWidth = 1f;
            cell_SinalCTO.Padding = 4f;
            cell_SinalCTO.PaddingTop = 1f;
            cell_SinalCTO.Colspan = 2;
            table.AddCell(cell_SinalCTO);

            PdfPCell cell_SinalDROP = new PdfPCell(new Phrase("Sinal DROP:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalDROP.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalDROP.BorderWidth = 1f;
            cell_SinalDROP.Padding = 4f;
            cell_SinalDROP.PaddingTop = 1f;
            cell_SinalDROP.Colspan = 2;
            table.AddCell(cell_SinalDROP);

            PdfPCell cell_MetragemFibra = new PdfPCell(new Phrase("Metragem fibra:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_MetragemFibra.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_MetragemFibra.BorderWidth = 1f;
            cell_MetragemFibra.Padding = 4f;
            cell_MetragemFibra.PaddingTop = 1f;
            cell_MetragemFibra.Colspan = 2;
            table.AddCell(cell_MetragemFibra);

            //LINHA TRES
            PdfPCell cell_ConcluidoTecnico = new PdfPCell(new Phrase("Concluido pelos Técnicos:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ConcluidoTecnico.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ConcluidoTecnico.BorderWidth = 1f;
            cell_ConcluidoTecnico.Padding = 4f;
            cell_ConcluidoTecnico.PaddingTop = 1f;
            cell_ConcluidoTecnico.Colspan = 4;
            table.AddCell(cell_ConcluidoTecnico);

            table.AddCell(cell_Data);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TelhasQuebradas = new PdfPCell(new Phrase("Há telhas quebradas na casa do cliente? ( ) Sim ( ) Não Quantidade: __________________________", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_TelhasQuebradas.Colspan = 6;
            cell_TelhasQuebradas.Border = 0;
            table.AddCell(cell_TelhasQuebradas);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TecSuporteFibra = new PdfPCell(new Phrase("TÉCNICOS SUPORTE FIBRA", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_TecSuporteFibra.BorderColor = BaseColor.GRAY;
            cell_TecSuporteFibra.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecSuporteFibra.BorderWidth = 2f;
            cell_TecSuporteFibra.PaddingBottom = 10f;
            cell_TecSuporteFibra.PaddingLeft = 20f;
            cell_TecSuporteFibra.PaddingTop = 4f;
            cell_TecSuporteFibra.Colspan = 6;
            cell_TecSuporteFibra.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell_TecSuporteFibra);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            //LINHA UM
            table.AddCell(cell_HrChegada);
            table.AddCell(cell_HrSaida);
            table.AddCell(cell_Data);

            //LINHA DOIS
            PdfPCell cell_SinalONU = new PdfPCell(new Phrase("Sinal ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalONU.BorderWidth = 1f;
            cell_SinalONU.Padding = 4f;
            cell_SinalONU.PaddingTop = 1f;
            cell_SinalONU.Colspan = 2;
            table.AddCell(cell_SinalONU);

            PdfPCell cell_ModeloONU = new PdfPCell(new Phrase("Modelo ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ModeloONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ModeloONU.BorderWidth = 1f;
            cell_ModeloONU.Padding = 4f;
            cell_ModeloONU.PaddingTop = 1f;
            cell_ModeloONU.Colspan = 2;
            table.AddCell(cell_ModeloONU);

            PdfPCell cell_MecONU = new PdfPCell(new Phrase("MEC ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_MecONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_MecONU.BorderWidth = 1f;
            cell_MecONU.Padding = 4f;
            cell_MecONU.PaddingTop = 1f;
            cell_MecONU.Colspan = 2;
            table.AddCell(cell_MecONU);

            //LINHA TRES
            PdfPCell cell_ModeloRoteador = new PdfPCell(new Phrase("Modelo Roteador:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ModeloRoteador.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ModeloRoteador.BorderWidth = 1f;
            cell_ModeloRoteador.Padding = 4f;
            cell_ModeloRoteador.PaddingTop = 1f;
            cell_ModeloRoteador.Colspan = 2;
            table.AddCell(cell_ModeloRoteador);

            PdfPCell cell_NomeRedeWifi = new PdfPCell(new Phrase("Nome Rede Wifi:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_NomeRedeWifi.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_NomeRedeWifi.BorderWidth = 1f;
            cell_NomeRedeWifi.Padding = 4f;
            cell_NomeRedeWifi.PaddingTop = 1f;
            cell_NomeRedeWifi.Colspan = 2;
            table.AddCell(cell_NomeRedeWifi);

            PdfPCell cell_SenhaWifi = new PdfPCell(new Phrase("Senha Wifi:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SenhaWifi.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SenhaWifi.BorderWidth = 1f;
            cell_SenhaWifi.Padding = 4f;
            cell_SenhaWifi.PaddingTop = 1f;
            cell_SenhaWifi.Colspan = 2;
            table.AddCell(cell_SenhaWifi);

            table.AddCell(cell_ConcluidoTecnico);
            table.AddCell(cell_Data);
            for (int i = 0; i < 7; i++)
            {
                table.AddCell(cell_QuebraLinha);
            }

            PdfPCell cell_Observacao = new PdfPCell(new Phrase("Foi realizado o serviço acima descrito, não tendo nada a reclamar.\nDeclaro estar de acordo com as informações contidas nesta Ordem de Serviço.", new Font(iTextSharp.text.Font.NORMAL, 7, 1)));
            cell_Observacao.Colspan = 6;
            cell_Observacao.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_Observacao.Border = 0;
            table.AddCell(cell_Observacao);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_AssUm = new PdfPCell(new Phrase("_________________________________________\nASSINATURA CLIENTE\nASSINATURA TÉCNICO LANÇAMENTO/ATIVAÇÃO", new Font(iTextSharp.text.Font.NORMAL, 7, 1)));
            cell_AssUm.Colspan = 3;
            cell_AssUm.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_AssUm.Border = 0;
            table.AddCell(cell_AssUm);

            PdfPCell cell_AssDois = new PdfPCell(new Phrase("_________________________________________\nASSINATURA CLIENTE\nASSINATURA TÉCNICO SUPORTE FIBRA", new Font(Font.NORMAL, 7, 1)));
            cell_AssDois.Colspan = 3;
            cell_AssDois.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_AssDois.Border = 0;
            table.AddCell(cell_AssDois);

            doc.Add(table);//adicionando escrita no arquivo.
            doc.Close();//fechando documento para que seja salva as alteraçoes.
            System.Diagnostics.Process.Start(caminho);//Abrindo o arquivo após cria-lo.

            //## PROPRIEDADES UTEIS ############################################################
            // cell.Border = 0;
            // cell.BorderColor = BaseColor.GRAY;
            // cell.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            // cell.BorderWidthBottom = 1f;
            // cell.BorderWidthTop = 1f;
            // cell.BorderWidthLeft = 1f;
            // cell.BorderWidthRight = 1f;
            // cell.Padding = 4f;
            // cell.PaddingBottom = 5f;
            // cell.PaddingLeft = 4f;
            // cell.PaddingTop = 1f;
            // cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            // table.AddCell("TEXTO PARA SER EXIBIDO");
            // (int)System.Drawing.FontStyle.Bold
        }
        #endregion Impressao Direta

        #region Visualizar Impressao
        public static void GerarArquivoPdfOS(object _current)
        {
            BindingSource bindingSourceImprimirOS = new BindingSource();
            bindingSourceImprimirOS.DataSource = _current;
            string filepath = Constante.DiretorioDePDF + @"\visualizarImpressao.pdf";

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

            PdfPTable table = new PdfPTable(6);
            table.TotalWidth = 520f;
            table.LockedWidth = true;

            if (!File.Exists(Constante.DiretorioDeImagem + @"\logo.png"))
            {
                PdfPCell cell_Imagem = new PdfPCell(new Phrase($" "));
                cell_Imagem.Border = 0;
                cell_Imagem.PaddingBottom = 20;
                cell_Imagem.Colspan = 2;
                table.AddCell(cell_Imagem);
            }
            else
            {
                Image logo = Image.GetInstance(Constante.DiretorioDeImagem + @"\logo.png");
                logo.ScaleToFit(100f, 100f);
                PdfPCell cell_Imagem = new PdfPCell(new Phrase($"IMG", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
                cell_Imagem.AddElement(logo);
                cell_Imagem.Border = 0;
                cell_Imagem.PaddingBottom = 20;
                cell_Imagem.Colspan = 2;
                table.AddCell(cell_Imagem);
            }

            PdfPCell cell_Protocolo = new PdfPCell(new Phrase($"PROTOCOLO: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Protocolo"]}", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_Protocolo.Border = 0;
            cell_Protocolo.PaddingBottom = 20;
            cell_Protocolo.HorizontalAlignment = 1;
            cell_Protocolo.Colspan = 2;
            table.AddCell(cell_Protocolo);

            string idOS = Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["Id"]);
            PdfPCell cell_IdOS = new PdfPCell(new Phrase($"O.S N°: {idOS}", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_IdOS.Border = 0;
            cell_IdOS.PaddingBottom = 20;
            cell_IdOS.HorizontalAlignment = 2;
            cell_IdOS.Colspan = 2;
            table.AddCell(cell_IdOS);

            //LINHA UM
            PdfPCell cell_Nome = new PdfPCell(new Phrase($"Cliente: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["NomeCompleto"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Nome.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Nome.BorderWidth = 1f;
            cell_Nome.Padding = 4f;
            cell_Nome.PaddingTop = 1f;
            cell_Nome.Colspan = 4;
            table.AddCell(cell_Nome);

            PdfPCell cell_CPF_CNPJ = new PdfPCell(new Phrase($"CPF/CNPJ: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cpf"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_CPF_CNPJ.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_CPF_CNPJ.BorderWidth = 1f;
            cell_CPF_CNPJ.Padding = 4f;
            cell_CPF_CNPJ.PaddingTop = 1f;
            cell_CPF_CNPJ.Colspan = 2;
            table.AddCell(cell_CPF_CNPJ);

            //LINHA DOIS
            PdfPCell cell_Cep = new PdfPCell(new Phrase($"Cep: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cep"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Cep.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Cep.BorderWidth = 1f;
            cell_Cep.Padding = 4f;
            cell_Cep.PaddingTop = 1f;
            table.AddCell(cell_Cep);

            PdfPCell cell_Endereco = new PdfPCell(new Phrase($"Endereço: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Rua"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["NumCasa"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Cidade"]} - {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Uf"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Endereco.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Endereco.BorderWidth = 1f;
            cell_Endereco.Padding = 4f;
            cell_Endereco.PaddingTop = 1f;

            cell_Endereco.Colspan = 4;
            table.AddCell(cell_Endereco);

            PdfPCell cell_Plano = new PdfPCell(new Phrase($"Plano: SEM PLANO", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Plano.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Plano.BorderWidth = 1f;
            cell_Plano.Padding = 4f;
            cell_Plano.PaddingTop = 1f;
            table.AddCell(cell_Plano);

            //LINHA TRES
            PdfPCell cell_Email = new PdfPCell(new Phrase($"E-mail: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Email"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Email.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Email.BorderWidth = 1f;
            cell_Email.Padding = 4f;
            cell_Email.PaddingTop = 1f;
            table.AddCell(cell_Email);

            PdfPCell cell_Telefone = new PdfPCell(new Phrase($"Telefones: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Telefone"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["CelularUm"]}, {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["CelularDois"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Telefone.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Telefone.BorderWidth = 1f;
            cell_Telefone.Padding = 4f;
            cell_Telefone.PaddingTop = 1f;
            cell_Telefone.Colspan = 3;
            table.AddCell(cell_Telefone);

            PdfPCell cell_Atendente = new PdfPCell(new Phrase($"Atendente: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Atendente"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Atendente.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Atendente.BorderWidth = 1f;
            cell_Atendente.Padding = 4f;
            cell_Atendente.PaddingTop = 1f;
            cell_Atendente.Colspan = 2;
            table.AddCell(cell_Atendente);

            //LINHA QUATRO
            PdfPCell cell_Tipo = new PdfPCell(new Phrase($"Tipo: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["TipoChamado"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Tipo.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Tipo.BorderWidth = 1f;
            cell_Tipo.Padding = 4f;
            cell_Tipo.PaddingTop = 1f;
            table.AddCell(cell_Tipo);

            PdfPCell cell_Status = new PdfPCell(new Phrase($"Status: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["EstatusOS"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Status.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Status.BorderWidth = 1f;
            cell_Status.Padding = 4f;
            cell_Status.PaddingTop = 1f;
            table.AddCell(cell_Status);

            PdfPCell cell_LigarAntes = new PdfPCell(new Phrase($"Ligar Antes: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["LigarAntes"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_LigarAntes.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_LigarAntes.BorderWidth = 1f;
            cell_LigarAntes.Padding = 4f;
            cell_LigarAntes.PaddingTop = 1f;
            table.AddCell(cell_LigarAntes);

            PdfPCell cell_Abertura = new PdfPCell(new Phrase($"Abertura: {Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["DataAbertura"]).Replace("00:00:00", "")}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Abertura.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Abertura.BorderWidth = 1f;
            cell_Abertura.Padding = 4f;
            cell_Abertura.PaddingTop = 1f;
            table.AddCell(cell_Abertura);

            PdfPCell cell_Prazo = new PdfPCell(new Phrase($"Prazo: {Convert.ToString(((DataRowView)bindingSourceImprimirOS.Current).Row["DataPrazo"]).Replace("00:00:00", "")}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Prazo.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Prazo.BorderWidth = 1f;
            cell_Prazo.Padding = 4f;
            cell_Prazo.PaddingTop = 1f;
            table.AddCell(cell_Prazo);

            PdfPCell cell_TecResponsavel = new PdfPCell(new Phrase($"Tec. Responsável: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["TecnicoResponsavel"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_TecResponsavel.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecResponsavel.BorderWidth = 1f;
            cell_TecResponsavel.Padding = 4f;
            cell_TecResponsavel.PaddingTop = 1f;
            table.AddCell(cell_TecResponsavel);

            //LINHA CINCO
            PdfPCell cell_Descricao = new PdfPCell(new Phrase($"Descrição: {(string)((DataRowView)bindingSourceImprimirOS.Current).Row["Descricao"]}", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Descricao.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Descricao.BorderWidth = 1f;
            cell_Descricao.Padding = 4f;
            cell_Descricao.PaddingTop = 1f;
            cell_Descricao.Colspan = 6;
            table.AddCell(cell_Descricao);

            PdfPCell cell_DescricaoServicoProblema = new PdfPCell(new Phrase($"Descrição do Serviço/Problema:\n", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_DescricaoServicoProblema.Colspan = 6;
            cell_DescricaoServicoProblema.Border = 0;
            table.AddCell(cell_DescricaoServicoProblema);

            PdfPCell cell_Linha = new PdfPCell(new Phrase($"_______________________________________________________________________________________________", new Font(iTextSharp.text.Font.NORMAL, 9/*, (int)System.Drawing.FontStyle.Regular*/)));
            cell_Linha.Colspan = 6;
            cell_Linha.Border = 0;
            for (int i = 0; i < 7; i++)
            {
                table.AddCell(cell_Linha);
            }

            PdfPCell cell_QuebraLinha = new PdfPCell(new Phrase("\n", new Font(iTextSharp.text.Font.NORMAL, 9, 1)));
            cell_QuebraLinha.Colspan = 6;
            cell_QuebraLinha.Border = 0;
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TecAtivacao = new PdfPCell(new Phrase("TÉCNICOS LANÇAMENTO DE DROP/ATIVAÇÃO", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_TecAtivacao.BorderColor = BaseColor.GRAY;
            cell_TecAtivacao.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecAtivacao.BorderWidth = 2f;
            cell_TecAtivacao.PaddingBottom = 10f;
            cell_TecAtivacao.PaddingLeft = 20f;
            cell_TecAtivacao.PaddingTop = 4f;
            cell_TecAtivacao.Colspan = 6;
            cell_TecAtivacao.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell_TecAtivacao);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            //LINHA UM
            PdfPCell cell_HrChegada = new PdfPCell(new Phrase("Hr Chegada:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_HrChegada.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_HrChegada.BorderWidth = 1f;
            cell_HrChegada.Padding = 4f;
            cell_HrChegada.PaddingTop = 1f;
            cell_HrChegada.Colspan = 2;
            table.AddCell(cell_HrChegada);

            PdfPCell cell_HrSaida = new PdfPCell(new Phrase("Hr Saída:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_HrSaida.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_HrSaida.BorderWidth = 1f;
            cell_HrSaida.Padding = 4f;
            cell_HrSaida.PaddingTop = 1f;
            cell_HrSaida.Colspan = 2;
            table.AddCell(cell_HrSaida);

            PdfPCell cell_Data = new PdfPCell(new Phrase("Data:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_Data.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_Data.BorderWidth = 1f;
            cell_Data.Padding = 4f;
            cell_Data.PaddingTop = 1f;
            cell_Data.Colspan = 2;
            table.AddCell(cell_Data);

            //LINHA DOIS
            PdfPCell cell_SinalCTO = new PdfPCell(new Phrase("Sinal CTO:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalCTO.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalCTO.BorderWidth = 1f;
            cell_SinalCTO.Padding = 4f;
            cell_SinalCTO.PaddingTop = 1f;
            cell_SinalCTO.Colspan = 2;
            table.AddCell(cell_SinalCTO);

            PdfPCell cell_SinalDROP = new PdfPCell(new Phrase("Sinal DROP:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalDROP.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalDROP.BorderWidth = 1f;
            cell_SinalDROP.Padding = 4f;
            cell_SinalDROP.PaddingTop = 1f;
            cell_SinalDROP.Colspan = 2;
            table.AddCell(cell_SinalDROP);

            PdfPCell cell_MetragemFibra = new PdfPCell(new Phrase("Metragem fibra:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_MetragemFibra.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_MetragemFibra.BorderWidth = 1f;
            cell_MetragemFibra.Padding = 4f;
            cell_MetragemFibra.PaddingTop = 1f;
            cell_MetragemFibra.Colspan = 2;
            table.AddCell(cell_MetragemFibra);

            //LINHA TRES
            PdfPCell cell_ConcluidoTecnico = new PdfPCell(new Phrase("Concluido pelos Técnicos:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ConcluidoTecnico.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ConcluidoTecnico.BorderWidth = 1f;
            cell_ConcluidoTecnico.Padding = 4f;
            cell_ConcluidoTecnico.PaddingTop = 1f;
            cell_ConcluidoTecnico.Colspan = 4;
            table.AddCell(cell_ConcluidoTecnico);

            table.AddCell(cell_Data);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TelhasQuebradas = new PdfPCell(new Phrase("Há telhas quebradas na casa do cliente? ( ) Sim ( ) Não Quantidade: __________________________", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_TelhasQuebradas.Colspan = 6;
            cell_TelhasQuebradas.Border = 0;
            table.AddCell(cell_TelhasQuebradas);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_TecSuporteFibra = new PdfPCell(new Phrase("TÉCNICOS SUPORTE FIBRA", new Font(iTextSharp.text.Font.NORMAL, 10, 1)));
            cell_TecSuporteFibra.BorderColor = BaseColor.GRAY;
            cell_TecSuporteFibra.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_TecSuporteFibra.BorderWidth = 2f;
            cell_TecSuporteFibra.PaddingBottom = 10f;
            cell_TecSuporteFibra.PaddingLeft = 20f;
            cell_TecSuporteFibra.PaddingTop = 4f;
            cell_TecSuporteFibra.Colspan = 6;
            cell_TecSuporteFibra.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell_TecSuporteFibra);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            //LINHA UM
            table.AddCell(cell_HrChegada);
            table.AddCell(cell_HrSaida);
            table.AddCell(cell_Data);

            //LINHA DOIS
            PdfPCell cell_SinalONU = new PdfPCell(new Phrase("Sinal ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SinalONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SinalONU.BorderWidth = 1f;
            cell_SinalONU.Padding = 4f;
            cell_SinalONU.PaddingTop = 1f;
            cell_SinalONU.Colspan = 2;
            table.AddCell(cell_SinalONU);

            PdfPCell cell_ModeloONU = new PdfPCell(new Phrase("Modelo ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ModeloONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ModeloONU.BorderWidth = 1f;
            cell_ModeloONU.Padding = 4f;
            cell_ModeloONU.PaddingTop = 1f;
            cell_ModeloONU.Colspan = 2;
            table.AddCell(cell_ModeloONU);

            PdfPCell cell_MecONU = new PdfPCell(new Phrase("MEC ONU:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_MecONU.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_MecONU.BorderWidth = 1f;
            cell_MecONU.Padding = 4f;
            cell_MecONU.PaddingTop = 1f;
            cell_MecONU.Colspan = 2;
            table.AddCell(cell_MecONU);

            //LINHA TRES
            PdfPCell cell_ModeloRoteador = new PdfPCell(new Phrase("Modelo Roteador:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_ModeloRoteador.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_ModeloRoteador.BorderWidth = 1f;
            cell_ModeloRoteador.Padding = 4f;
            cell_ModeloRoteador.PaddingTop = 1f;
            cell_ModeloRoteador.Colspan = 2;
            table.AddCell(cell_ModeloRoteador);

            PdfPCell cell_NomeRedeWifi = new PdfPCell(new Phrase("Nome Rede Wifi:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_NomeRedeWifi.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_NomeRedeWifi.BorderWidth = 1f;
            cell_NomeRedeWifi.Padding = 4f;
            cell_NomeRedeWifi.PaddingTop = 1f;
            cell_NomeRedeWifi.Colspan = 2;
            table.AddCell(cell_NomeRedeWifi);

            PdfPCell cell_SenhaWifi = new PdfPCell(new Phrase("Senha Wifi:", new Font(iTextSharp.text.Font.NORMAL, 8, 1)));
            cell_SenhaWifi.Border = Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER | Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
            cell_SenhaWifi.BorderWidth = 1f;
            cell_SenhaWifi.Padding = 4f;
            cell_SenhaWifi.PaddingTop = 1f;
            cell_SenhaWifi.Colspan = 2;
            table.AddCell(cell_SenhaWifi);

            table.AddCell(cell_ConcluidoTecnico);
            table.AddCell(cell_Data);
            for (int i = 0; i < 7; i++)
            {
                table.AddCell(cell_QuebraLinha);
            }

            PdfPCell cell_Observacao = new PdfPCell(new Phrase("Foi realizado o serviço acima descrito, não tendo nada a reclamar.\nDeclaro estar de acordo com as informações contidas nesta Ordem de Serviço.", new Font(iTextSharp.text.Font.NORMAL, 7, 1)));
            cell_Observacao.Colspan = 6;
            cell_Observacao.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_Observacao.Border = 0;
            table.AddCell(cell_Observacao);
            table.AddCell(cell_QuebraLinha);
            table.AddCell(cell_QuebraLinha);

            PdfPCell cell_AssUm = new PdfPCell(new Phrase("_________________________________________\nASSINATURA CLIENTE\nASSINATURA TÉCNICO LANÇAMENTO/ATIVAÇÃO", new Font(iTextSharp.text.Font.NORMAL, 7, 1)));
            cell_AssUm.Colspan = 3;
            cell_AssUm.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_AssUm.Border = 0;
            table.AddCell(cell_AssUm);

            PdfPCell cell_AssDois = new PdfPCell(new Phrase("_________________________________________\nASSINATURA CLIENTE\nASSINATURA TÉCNICO SUPORTE FIBRA", new Font(Font.NORMAL, 7, 1)));
            cell_AssDois.Colspan = 3;
            cell_AssDois.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell_AssDois.Border = 0;
            table.AddCell(cell_AssDois);

            doc.Add(table);//adicionando escrita no arquivo.
            doc.Close();//fechando documento para que seja salva as alteraçoes.
        }
        #endregion Visualizar Impressao
    }
}
