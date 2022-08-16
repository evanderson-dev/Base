using BLL;
using Infra;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPdfView : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public FormPdfView()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Width = this.Width - 20;
            pdf.Height = this.Height - 80;
            //pdf.Width = this.Width;
            //pdf.Height = this.Height;
            pdf.Anchor = AnchorStyles.Top;
            pdf.AutoSize = true;
            openfile(Constante.DiretorioDePDF + "\\visualizarImpressao.pdf");
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }
    }
}
