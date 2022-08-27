using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infra
{
    public static class FuncoesGlobais
    {
        public static void temaModoNorturno(Control controle)
        {
            controle.BackColor = Color.Black;//SystemColors.Control;
            controle.ForeColor = Color.White;//SystemColors.ControlText;
            if (controle is MaskedTextBox)
            {
                controle.BackColor = Color.White;
                controle.ForeColor = Color.Black;
            }
            // CONTROLE FILHO UM
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    if (controleFilho is TextBox || controleFilho is ComboBox || controleFilho is DataGridView || controleFilho is MaskedTextBox)
                        temaModoClaro(controleFilho);
                    else
                        temaModoNorturno(controleFilho);
                    // CONTROLE FILHO DOIS
                    if (controleFilho.HasChildren)
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            if (controleFilhoDois is TextBox || controleFilhoDois is ComboBox || controleFilhoDois is DataGridView || controleFilho is MaskedTextBox)
                                temaModoClaro(controleFilhoDois);
                            else
                                temaModoNorturno(controleFilhoDois);
                            // CONTROLE FILHO TRES
                            if (controleFilhoDois.HasChildren)
                            {
                                foreach (Control controleFilhoTres in controleFilhoDois.Controls)
                                {
                                    if (controleFilhoTres is TextBox || controleFilhoTres is ComboBox || controleFilhoTres is DataGridView || controleFilho is MaskedTextBox)
                                        temaModoClaro(controleFilhoTres);
                                    else
                                        temaModoNorturno(controleFilhoTres);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void temaModoClaro(Control controle)
        {
            controle.BackColor = Color.White;
            controle.ForeColor = Color.Black;
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    if (controleFilho is MenuStrip || controleFilho is StatusStrip)
                        controleFilho.BackColor = Color.Gray;
                    else
                        temaPadraoSistema(controleFilho);
                    if (controleFilho.HasChildren)
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            if (controleFilhoDois is MenuStrip || controleFilhoDois is StatusStrip)
                                controleFilhoDois.BackColor = Color.LightGray;
                            else
                                temaPadraoSistema(controleFilhoDois);
                            if (controleFilhoDois.HasChildren)
                            {
                                foreach (Control controleFilhoTres in controleFilhoDois.Controls)
                                {
                                    if (controleFilhoTres is MenuStrip || controleFilhoTres is StatusStrip)
                                        controleFilhoTres.BackColor = Color.LightGray;
                                    else
                                        temaPadraoSistema(controleFilhoTres);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void temaPadraoSistema(Control controle)
        {
            controle.BackColor = SystemColors.Control;
            controle.ForeColor = SystemColors.ControlText;
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaPadraoSistema(controleFilho);
                }
            }
        }
        public static void temaPersonalizado(Control controle, Color _corUm, Color _corDois)
        {
            controle.BackColor = _corUm;
            controle.ForeColor = _corDois;
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaPersonalizado(controleFilho, _corUm, _corDois);
                }
            }
        }
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
