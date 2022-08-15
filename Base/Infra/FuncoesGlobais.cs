using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infra
{
    public static class FuncoesGlobais
    {
        public static void somenteLetras(object sender, KeyPressEventArgs e)
        {// ESTE METODO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        public static void somenteNumeros(object sender, KeyPressEventArgs e)
        {// ESTE METODO PERMITE QUE APENAS NUMEROS SEJAM INSERIDOS E APAGADOS NO TEXTBOX
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        public static string Base64Encode(string plainText)
        {// METODO PARA CRIPTOGRAFAR TEXTO
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {// METODO PARA DECRIPTOGRAFAR TEXTO
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        // O CODIGO ABAIXO ATIVA O CLIQUE ESQUERDO DO MOUSE
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
    }
}
