using BLL;
using Infra;
using Model;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormOrdemServico : Form
    {
        private bool permitirSalvar = false;
        private bool inserindoNovo;

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
        StatusOSBLL statusOSBLL = new StatusOSBLL();
        OrdemServicoBLL ordemServicoBLL = new OrdemServicoBLL();
        public FormOrdemServico()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }
        public FormOrdemServico(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxBuscar.Text);
        }
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(null, null);
            }
        }
        private void comboBoxTecnicoResponsavel_Click(object sender, EventArgs e)
        {
            comboBoxTecnicoResponsavel.DataSource = usuarioBLL.BuscarFuncionario("1");
            comboBoxTecnicoResponsavel.DisplayMember = "NomeCompleto";
            comboBoxTecnicoResponsavel.ValueMember = "Id";
        }
        private void FormOrdemServico_Load(object sender, EventArgs e)
        {
            //textBoxProtocolo.Text = DateTime.Now.ToShortDateString().Replace("/","");
            textBoxProtocolo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");//("ano/MES/dia/HORA/minuto/segundo")

            maskedTextBoxDataAbertura.Text = DateTime.Now.ToString();

            textBoxBuscar.Focus();

            comboBoxTipoChamado.DataSource = tipoChamadoBLL.BuscarTipoChamado("");
            comboBoxTipoChamado.DisplayMember = "Descricao";
            comboBoxTipoChamado.ValueMember = "Id";

            comboBoxStatusOS.DataSource = statusOSBLL.BuscarStatusOS("");
            comboBoxStatusOS.DisplayMember = "Descricao";
            comboBoxStatusOS.ValueMember = "Id";

            textBoxAtendente.Text = UsuarioLogado.NomeCompleto;

            comboBoxTipoChamado.Enabled = false;
            comboBoxlLigarAntes.Enabled = false;
            comboBoxStatusOS.Enabled = false;
            comboBoxTecnicoResponsavel.Enabled = false;
            textBoxDescricao.Enabled = false;
        }
                
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            inserindoNovo = true;
            permitirSalvar = true;
            comboBoxTipoChamado.Enabled = true;
            comboBoxlLigarAntes.Enabled = true;
            comboBoxStatusOS.Enabled = true;
            comboBoxTecnicoResponsavel.Enabled = true;
            textBoxDescricao.Enabled = true;
            maskedTextBoxPrazo.ReadOnly = false;
            DateTime dateTime = DateTime.Now;
            maskedTextBoxPrazo.Text = Convert.ToString(dateTime.AddDays(2));
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            inserindoNovo = false;
            permitirSalvar = false;

            comboBoxTipoChamado.Enabled = false;
            comboBoxlLigarAntes.Enabled = false;
            comboBoxStatusOS.Enabled = false;
            comboBoxTecnicoResponsavel.Enabled = false;
            textBoxDescricao.Enabled = false;

            comboBoxTipoChamado.Text = null;
            comboBoxlLigarAntes.Text = null;
            comboBoxStatusOS.Text = null;
            comboBoxTecnicoResponsavel.Text = null;
            textBoxDescricao.Text = null;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (permitirSalvar)
            {
                try
                {
                    usuarioBindingSource.EndEdit();
                    OrdemServico ordemServico = new OrdemServico();

                    ordemServico.Id = Convert.ToInt32(labelIdPessoa.Text);
                    ordemServico.Protocolo = textBoxProtocolo.Text;
                    ordemServico.Id_Cliente = Convert.ToInt32(labelIdPessoa.Text);
                    ordemServico.TipoChamado = comboBoxTipoChamado.Text;
                    ordemServico.Descricao = textBoxDescricao.Text;
                    ordemServico.DataAbertura = maskedTextBoxDataAbertura.Text;
                    ordemServico.DataPrazo = maskedTextBoxPrazo.Text;
                    ordemServico.TecnicoResponsavel = comboBoxTecnicoResponsavel.Text;
                    ordemServico.Atendente = textBoxAtendente.Text;
                    ordemServico.EstatusOS = comboBoxStatusOS.Text;
                    ordemServico.LigarAntes = comboBoxlLigarAntes.Text;
                                        
                    if (inserindoNovo)
                    {
                        ordemServicoBLL.AbrirOS(ordemServico);
                    }
                    else
                    {
                        ordemServicoBLL.AlterarOS(ordemServico);
                    }

                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OCORREU UM ERRO" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DADOS INSUFICIENTES!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
