using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormMessageBoxPersonalizado : Form
    {
        public FormMessageBoxPersonalizado()
        {
            InitializeComponent();
        }
        DialogResult Resultado { get; set; }

        public static DialogResult Show(string txtMsg, string txtTitulo)
        {
            FormMessageBoxPersonalizado newMsgBox = new FormMessageBoxPersonalizado();
            newMsgBox.labelMessagem.Text = txtMsg;
            newMsgBox.labelTitulo.Text = txtTitulo;
            newMsgBox.ShowDialog();
            return newMsgBox.Resultado;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.OK;
            Close();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.Cancel;
            Close();
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.Yes;
            Close();
        }
        private void buttonNo_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.No;
            Close();
        }
    }
}
