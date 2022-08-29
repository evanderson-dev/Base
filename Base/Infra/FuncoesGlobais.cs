using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (controle is TextBox || controle is MaskedTextBox || controle is ComboBox || controle is DataGridView)
            {
                controle.BackColor = Color.White;
                controle.ForeColor = Color.Black;
            }
            
            if (controle.HasChildren)// CONTROLE FILHO UM
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaModoNorturno(controleFilho);
                    if (controleFilho.HasChildren)// CONTROLE FILHO DOIS
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            temaModoNorturno(controleFilhoDois);
                            if (controleFilhoDois.HasChildren)// CONTROLE FILHO TRES
                            {
                                foreach (Control controleFilhoTres in controleFilhoDois.Controls)
                                {
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
            controle.BackColor = Color.LightGray;
            controle.ForeColor = Color.Black;
            if (controle is TextBox || controle is MaskedTextBox || controle is ComboBox || controle is DataGridView)
            {
                controle.BackColor = Color.White;
                controle.ForeColor = Color.Black;
            }
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaModoClaro(controleFilho);
                    if (controleFilho.HasChildren)
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            temaModoClaro(controleFilhoDois);
                            if (controleFilhoDois.HasChildren)
                            {
                                foreach (Control controleFilhoTres in controleFilhoDois.Controls)
                                {
                                    temaModoClaro(controleFilhoTres);                                    
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void temaPersonalizado
            (
            Control controle,
            Color _fundo,
            Color _texto,
            Color _texBoxFundo,
            Color _texBoxTexto,
            Color _maskedTextBoxFundo,
            Color _maskedTextBoxTexto,
            Color _comboBoxFundo,
            Color _comboBoxTexto,
            Color _dataGridViewFundo,
            Color _dataGridViewTexto
            )
        {
            controle.BackColor = _fundo;
            controle.ForeColor = _texto;

            if (controle is TextBox)
            {
                controle.BackColor = _texBoxFundo;
                controle.ForeColor = _texBoxTexto;
            }
            if (controle is MaskedTextBox)
            {
                controle.BackColor = _maskedTextBoxFundo;
                controle.ForeColor = _maskedTextBoxTexto;
            }
            if (controle is ComboBox)
            {
                controle.BackColor = _comboBoxFundo;
                controle.ForeColor = _comboBoxTexto;
            }
            if (controle is DataGridView)
            {
                controle.BackColor = _dataGridViewFundo;
                controle.ForeColor = _dataGridViewTexto;
            }
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaPersonalizado(controleFilho, _fundo, _texto, _texBoxFundo, _texBoxTexto, _maskedTextBoxFundo, _maskedTextBoxTexto, _comboBoxFundo, _comboBoxTexto, _dataGridViewFundo, _dataGridViewTexto);
                    if (controleFilho.HasChildren)
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            temaPersonalizado(controleFilhoDois, _fundo, _texto, _texBoxFundo, _texBoxTexto, _maskedTextBoxFundo, _maskedTextBoxTexto, _comboBoxFundo, _comboBoxTexto, _dataGridViewFundo, _dataGridViewTexto);
                        }
                    }
                }
            }
        }
        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            var result = (Color)cc.ConvertFromString(colorStr);
            return result;
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
