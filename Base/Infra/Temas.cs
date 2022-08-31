using System;
using System.Drawing;
using System.Windows.Forms;

namespace Infra
{
    public static class Temas
    {
        public static Color corTemporaria;
        public static Color corDeFundoPrimeiroPlano = Color.LightGray;
        public static Color corTextoPrimeiroPlano = Color.Black;
        public static Color corTextBoxFundo = Color.White;
        public static Color corTextBoxTexto = Color.Black;
        public static Color corMaskedTextBoxFundo = Color.White;
        public static Color corMaskedTextBoxTexto = Color.Black;
        public static Color corComboBoxFundo = Color.White;
        public static Color corComboBoxTexto = Color.Black;
        public static Color corGridViewFundo = Color.White;
        public static Color corGridViewTexto = Color.Black;
        public static Color corGridViewLinhas = Color.Black;
        public static Color corLabelSuperior = Color.Gray;
        public static Color corLabelSuperiorTexto = Color.White;
        public static Color corBotao = Color.White;
        public static Color corBotaoTexto = Color.Black;

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
            Color _dataGridViewTexto,
            Color _botaoFundo,
            Color _botaoTexto
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
                controle.ForeColor = _dataGridViewTexto;
            }
            if (controle is Button)
            {
                controle.BackColor = _botaoFundo;
                controle.ForeColor = _botaoTexto;
            }
            if (controle.HasChildren)
            {
                foreach (Control controleFilho in controle.Controls)
                {
                    temaPersonalizado
                    (
                    controleFilho,
                    _fundo,
                    _texto,
                    _texBoxFundo,
                    _texBoxTexto,
                    _maskedTextBoxFundo,
                    _maskedTextBoxTexto,
                    _comboBoxFundo,
                    _comboBoxTexto,
                    _dataGridViewTexto,
                    _botaoFundo,
                    _botaoTexto
                    );
                    if (controleFilho.HasChildren)
                    {
                        foreach (Control controleFilhoDois in controleFilho.Controls)
                        {
                            temaPersonalizado
                            (
                            controleFilhoDois,
                            _fundo,
                            _texto,
                            _texBoxFundo,
                            _texBoxTexto,
                            _maskedTextBoxFundo,
                            _maskedTextBoxTexto,
                            _comboBoxFundo,
                            _comboBoxTexto,
                            _dataGridViewTexto,
                            _botaoFundo,
                            _botaoTexto
                            );
                        }
                    }
                }
            }
        }
    }
}
