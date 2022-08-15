using BLL;
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
            pdf.Height = this.Height - 40;
        }
        public FormPdfView(object _current)
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Width = this.Width - 20;
            pdf.Height = this.Height - 40;
        }

        private void buttonAbrirPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                openfile(dialog.FileName);
            }
        }
        public void openfile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }
        //var arq = @"c:\dados\teste.pdf");
        //openfile(arq);
    }
}
