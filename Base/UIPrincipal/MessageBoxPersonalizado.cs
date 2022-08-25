using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class MessageBoxPersonalizado : Form
    {
        public MessageBoxPersonalizado(string _mensagem, string _titulo = "", bool _Ok = true, bool _SimNao = false, string _icon = "")
        {
            InitializeComponent();

            buttonOk.Visible = _Ok;
            buttonYes.Visible = _SimNao;
            buttonNo.Visible = _SimNao;

            if (_icon == "?")
                pictureBoxQuestion.Visible = true;
            if (_icon == "!")
                pictureBoxExclamacao.Visible = true;

            labelMessagem.Text = _mensagem;
            labelTitulo.Text = _titulo;
        }
    }
}