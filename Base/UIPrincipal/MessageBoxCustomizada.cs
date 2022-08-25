using System.Windows.Forms;

namespace UIPrincipal
{
    public static class MessageBoxCustomizada
    {
        public static DialogResult Show(string _mensagem, string _titulo = "", MessageBoxButtons _botao = MessageBoxButtons.OK, string _icon = "")
        {             
            using (MessageBoxPersonalizado frm = new MessageBoxPersonalizado(_mensagem, _titulo, _botao == MessageBoxButtons.OK, _botao == MessageBoxButtons.YesNo, _icon))
            {
                frm.ShowDialog();
                return frm.DialogResult;
            }
        }
    }
}
