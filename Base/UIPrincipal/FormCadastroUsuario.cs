using BLL;
using Model;
using Infra;
using System;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Constante.DiretorioDeImagem;
        string destinoCompleto = "";
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (pictureBoxFoto.ImageLocation == "")
            {
                if (MessageBoxCustomizada.Show("DESEJA CADASTRAR SEM FOTO?","",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pictureBoxFoto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBoxCustomizada.Show("ERRO SO LOCALIZAR A FOTO, DESEJA CONTINUAR?", "ERRO!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            try
            {
                //usuarioBindingSource.EndEdit();
                Inserir();
                MessageBoxCustomizada.Show("OPERAÇÃO REALIZADA COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBoxCustomizada.Show("OCORREU UM ERRO! " + ex.Message);
            }
        }
        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(labelIdPessoa.Text);
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            string senhaNormal = textBoxSenha.Text;
            usuario.Senha = FuncoesGlobais.Base64Encode(senhaNormal);
            usuario.NomeCompleto = textBoxNomeCompleto.Text;
            usuario.Cpf = maskedTextBoxCpf.Text;
            usuario.Rg = textBoxRg.Text;
            usuario.OrgaoExpeditor = textBoxOrgExpeditor.Text;
            usuario.DataNascimento = maskedTextBoxDataNascimento.Text;
            usuario.Cep = maskedTextBoxCep.Text;
            usuario.Rua = textBoxRua.Text;
            usuario.NumCasa = textBoxNumCasa.Text;
            usuario.Bairro = textBoxBairro.Text;
            usuario.EstadoCivil = textBoxEstadoCivil.Text;
            usuario.Nacionalidade = textBoxNacionalidade.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Telefone = maskedTextBoxTelefone.Text;
            usuario.CelularUm = maskedTextBoxCelularUm.Text;
            usuario.CelularDois = maskedTextBoxCelularDois.Text;
            usuario.Cidade = textBoxCidade.Text;
            usuario.Uf = textBoxUf.Text;
            usuario.Foto = destinoCompleto;
            usuario.Funcionario = checkBoxFuncionario.Checked;
            int idpermissao = 3;
            if (radioButtonNivelUm.Checked)
                idpermissao = 1;
            else if (radioButtonNivelDois.Checked)
                idpermissao = 2;
            usuario.Id_Permissao = idpermissao;
            usuario.Salario = textBoxSalario.Text;
            usuario.Cargo = textBoxCargo.Text;
            usuario.DataAdmissao = maskedTextBoxDataAdmissao.Text;
            usuario.DataDemissao = maskedTextBoxDataDemissao.Text;
            usuario.Banco = textBoxBanco.Text;
            usuario.NumeroAgenciaBanco = textBoxAgencia.Text;
            usuario.NumeroContaBanco = textBoxNumConta.Text;
            usuario.Cliente = checkBoxCliente.Checked;
            usuario.InicioDoContrato = maskedTextBoxInicioContrato.Text;
            usuario.FimDoContrato = maskedTextBoxFimContrato.Text;
            usuario.Observacao = textBoxObservacao.Text;
            usuario.Id_Plano = Convert.ToInt32(comboBoxPlanos.SelectedValue);

            if (inserindoNovo)
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);
        }
        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {Close();}

        private void textBoxRg_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteNumeros(sender, e);}

        private void textBoxNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteLetras(sender, e);}

        private void textBoxNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteLetras(sender, e);}

        private void textBoxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteLetras(sender, e);}

        private void textBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteLetras(sender, e);}

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {FuncoesGlobais.somenteLetras(sender, e);}
        public void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCliente.Checked)
            {
                comboBoxPlanos.DataSource = null;
                maskedTextBoxInicioContrato.Text = null;
            }
            else
            {
                PlanoBLL planoBLL = new PlanoBLL();
                comboBoxPlanos.DataSource = planoBLL.BuscarPlano("");
                comboBoxPlanos.DisplayMember = "Descricao";
                comboBoxPlanos.ValueMember = "Id";
                if (inserindoNovo)
                maskedTextBoxInicioContrato.Text = ((Usuario)usuarioBindingSource.Current).InicioDoContrato = DateTime.Now.ToString();
            }
        }
        public void checkBoxFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFuncionario.Checked)
            {
                if (inserindoNovo)
                {
                    maskedTextBoxDataAdmissao.Text = ((Usuario)usuarioBindingSource.Current).DataAdmissao = DateTime.Now.ToString();
                }
                textBoxNomeUsuario.Enabled = true;
                textBoxSenha.Enabled = true;
            }
            else
            {
                textBoxNomeUsuario.Text = null;
                textBoxSenha.Text = null;
                textBoxNomeUsuario.Enabled = false;
                textBoxSenha.Enabled = false;
                maskedTextBoxDataAdmissao.Text = null;
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (UsuarioLogado.luzLigada)
                Temas.temaPersonalizado(this, Temas.corDeFundoPrimeiroPlano, Temas.corTextoPrimeiroPlano, Temas.corTextBoxFundo, Temas.corTextBoxTexto, Temas.corMaskedTextBoxFundo, Temas.corMaskedTextBoxTexto, Temas.corComboBoxFundo, Temas.corMaskedTextBoxTexto, Temas.corGridViewFundo, Temas.corGridViewTexto);
            else
                Temas.temaModoNorturno(this);

            if (inserindoNovo)
            {// SE FOR UM NOVO CADASTRO, O CHECKBOX CLIENTE INICIARÁ DESMARCADO
                checkBoxCliente.Checked = false;
                textBoxNomeUsuario.Enabled = false;
                textBoxSenha.Enabled = false;
            }
            else
            {
                pictureBoxFoto.ImageLocation = (string)((DataRowView)usuarioBindingSource.Current).Row["Foto"];
                textBoxSenha.Text = FuncoesGlobais.Base64Decode((string)((DataRowView)usuarioBindingSource.Current).Row["Senha"]);

                if (((int)((DataRowView)usuarioBindingSource.Current).Row["Id_Permissao"]) == 1)
                {
                    radioButtonNivelUm.Checked = true;
                }
                else if (((int)((DataRowView)usuarioBindingSource.Current).Row["Id_Permissao"]) == 2)
                {
                    radioButtonNivelDois.Checked = true;
                }
                else if (((int)((DataRowView)usuarioBindingSource.Current).Row["Id_Permissao"]) == 0)
                {
                    radioButtonNivelUm.Checked = false;
                    radioButtonNivelDois.Checked = false;
                    radioButtonNivelTres.Checked = false;
                }
                else
                {
                    radioButtonNivelTres.Checked = true;
                }
            }          
            comboBoxPlanos.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Plano", true));
            buttonVisualizarSenha_Click(sender, e);
        }

        private void buttonAddFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Constante.DiretorioDeImagem;
            destinoCompleto = "";

            if (openFileDialogAddFoto.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Constante.DiretorioDeImagem))//CRIA A PASTA CASO ELA NAO EXISTA
                {
                    Directory.CreateDirectory(Constante.DiretorioDeImagem);
                }
                origemCompleto = openFileDialogAddFoto.FileName;//RETORNA O CAMINHO COMPLETO E NOME DO ARQUIVO
                foto = openFileDialogAddFoto.SafeFileName;//RETORNA O NOME DO ARQUIVO
                destinoCompleto = pastaDestino + foto;
            }
            else
            {
                return;
            }

            if (File.Exists(destinoCompleto))
            {
                if (MessageBoxCustomizada.Show("O ARQUIVO JÁ EXISTE, DESEJA SUBSTITUIR?","",MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pictureBoxFoto.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBoxCustomizada.Show("ARQUIVO NÃO COPIADO!");
            }
        }

        private void checkBoxMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMasculino.Checked)
                checkBoxFeminino.Checked = false;
        }
        private void checkBoxFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFeminino.Checked)
                checkBoxMasculino.Checked = false;
        }

        private void buttonVisualizarSenha_Click(object sender, EventArgs e)
        {
            if (!inserindoNovo)
            {
                if (textBoxSenha.UseSystemPasswordChar)
                {
                    textBoxSenha.UseSystemPasswordChar = false;
                    textBoxSenha.Text = FuncoesGlobais.Base64Decode((string)((DataRowView)usuarioBindingSource.Current).Row["Senha"]);
                }
                else
                {
                    textBoxSenha.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
