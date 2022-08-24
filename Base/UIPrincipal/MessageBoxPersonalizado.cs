using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class MessageBoxPersonalizado : Form
    {
        public MessageBoxPersonalizado(string _mensagem, string _titulo = "", bool _Ok = true, bool _SimNao = false)
        {
            InitializeComponent();

            buttonOk.Visible = _Ok;
            buttonYes.Visible = _SimNao;
            buttonNo.Visible = _SimNao;

            labelMessagem.Text = _mensagem;
            labelTitulo.Text = _titulo;
        }
    }
}