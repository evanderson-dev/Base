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
                if (MessageBox.Show("DESEJA CADASTRAR SEM FOTO?","ERRO!",MessageBoxButtons.YesNo) == DialogResult.No)
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
                    if (MessageBox.Show("ERRO SO LOCALIZAR A FOTO, DESEJA CONTINUAR?", "ERRO!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            try
            {
                //usuarioBindingSource.EndEdit();
                Inserir();
                MessageBox.Show("OPERAÇÃO REALIZADO COM SUCESSO!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO! " + ex.Message);
            }
        }

        private void Inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(labelIdPessoa.Text);
            usuario.Ativo = ativoCheckBox.Checked;
            usuario.NomeUsuario = textBoxNomeUsuario.Text;
            usuario.Senha = textBoxSenha.Text;
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

        private void somenteLetras(object sender, KeyPressEventArgs e)
        {// ESTE METODO PERMITE QUE APENAS LETRAS E ESPAÇO SEJAM INSERIDOS NO TEXTBOX
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxRg_KeyPress(object sender, KeyPressEventArgs e)
        {// ESTE EVENTO PERMITE QUE APENAS NUMEROS SEJAM INSERIDOS E APAGADOS NO TEXTBOX
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            somenteLetras(sender, e);
        }

        private void textBoxNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            somenteLetras(sender, e);
        }

        private void textBoxEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            somenteLetras(sender, e);
        }

        private void textBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            somenteLetras(sender, e);
        }

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            somenteLetras(sender, e);
        }
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
                maskedTextBoxInicioContrato.Text = DateTime.Now.ToString();
            }
            // O CODIGO ABAIXO É TEMPORARIO
            if (checkBoxCliente.Checked && checkBoxFuncionario.Checked)
            {
                PlanoBLL planoBLL = new PlanoBLL();
                comboBoxPlanos.DataSource = planoBLL.BuscarPlano("");
                comboBoxPlanos.DisplayMember = "Descricao";
                comboBoxPlanos.ValueMember = "Id";
                maskedTextBoxInicioContrato.Text = DateTime.Now.ToString();
                maskedTextBoxDataAdmissao.Text = DateTime.Now.ToString();
            }
        }
        public void checkBoxFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFuncionario.Checked)
                maskedTextBoxDataAdmissao.Text = null;
            else
                maskedTextBoxDataAdmissao.Text = DateTime.Now.ToString();
            // O CODIGO ABAIXO É TEMPORARIO
            if (checkBoxCliente.Checked && checkBoxFuncionario.Checked)
            {
                PlanoBLL planoBLL = new PlanoBLL();
                comboBoxPlanos.DataSource = planoBLL.BuscarPlano("");
                comboBoxPlanos.DisplayMember = "Descricao";
                comboBoxPlanos.ValueMember = "Id";
                maskedTextBoxInicioContrato.Text = DateTime.Now.ToString();
                maskedTextBoxDataAdmissao.Text = DateTime.Now.ToString();
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (inserindoNovo)
            {// SE FOR UM NOVO CADASTRO, O CHECKBOX CLIENTE INICIARÁ DESMARCADO
                checkBoxCliente.Checked = false;
            }
            else
            {
                pictureBoxFoto.ImageLocation = (string)((DataRowView)usuarioBindingSource.Current).Row["Foto"];
            }
                        
            comboBoxPlanos.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Plano", true));
            
            // CARREGAMENTO DO NIVEL DE ACESSO DO CLIENTE
            if (labelId_Permissao.Text == "1")
            {
                radioButtonNivelUm.Checked = true;
            } else if (labelId_Permissao.Text == "2")
            {
                radioButtonNivelDois.Checked = true;
            } else
            {
                radioButtonNivelTres.Checked = true;
            }
            
            //pictureBoxFoto.ImageLocation = (string)((DataRowView)usuarioBindingSource.Current).Row["Foto"];
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
                    Console.WriteLine(Constante.DiretorioDeImagem);
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
                if (MessageBox.Show("O ARQUIVO JÁ EXISTE, DESEJA SUBSTITUIR?","",MessageBoxButtons.YesNo)==DialogResult.No)
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
                MessageBox.Show("ARQUIVO NÃO COPIADO");
            }
        }
    }
}
