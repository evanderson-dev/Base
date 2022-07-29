using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormConsultaOS : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        OrdemServicoBLL ordemServicoBLL = new OrdemServicoBLL();
        TipoChamadoBLL tipoChamadoBLL = new TipoChamadoBLL();
        StatusOSBLL statusOSBLL = new StatusOSBLL();
        PlanoBLL planoBLL = new PlanoBLL();
        public FormConsultaOS()
        {
            InitializeComponent();
        }
        private void FormConsultaOS_Load(object sender, EventArgs e)
        {
            textBoxBuscarOS.Focus();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ordemServicoBindingSource.DataSource = ordemServicoBLL.BuscarOS(textBoxBuscarOS.Text);
            
            textBoxProtocolo.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Protocolo"];
            labelIdPessoa.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["Id_Cliente"]);
            textBoxNomeCompleto.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["NomeCompleto"];
            textBoxCpf.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cpf"];
            maskedTextBoxCep.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cep"];
            textBoxRua.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Rua"];
            textBoxNumCasa.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["NumCasa"];
            textBoxBairro.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Bairro"];
            textBoxEmail.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Email"];
            maskedTextBoxTelefone.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Telefone"];
            maskedTextBoxCelularUm.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["CelularUm"];
            maskedTextBoxCelularDois.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["CelularDois"];
            textBoxCidade.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Cidade"];
            textBoxUf.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Uf"];

            textBoxDescricao.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Descricao"];
            textBoxAtendente.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["Atendente"];
            maskedTextBoxDataAbertura.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["DataAbertura"]);
            maskedTextBoxPrazo.Text = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["DataPrazo"]);

            comboBoxTipoChamado.DataSource = tipoChamadoBLL.BuscarTipoChamado("");
            comboBoxTipoChamado.DisplayMember = "Descricao";
            comboBoxTipoChamado.ValueMember = "Id";
            comboBoxTipoChamado.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["TipoChamado"];

            comboBoxEstatusOS.DataSource = statusOSBLL.BuscarStatusOS("");
            comboBoxEstatusOS.DisplayMember = "Descricao";
            comboBoxEstatusOS.ValueMember = "Id";
            comboBoxEstatusOS.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["EstatusOS"];

            comboBoxLigarAntes.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["LigarAntes"];

            comboBoxTecnicoResponsavel.DataSource = usuarioBLL.BuscarFuncionario("1");
            comboBoxTecnicoResponsavel.DisplayMember = "NomeCompleto";
            comboBoxTecnicoResponsavel.ValueMember = "Id";
            comboBoxTecnicoResponsavel.Text = (string)((DataRowView)ordemServicoBindingSource.Current).Row["TecnicoResponsavel"];

            string id_Plano = Convert.ToString(((DataRowView)ordemServicoBindingSource.Current).Row["Id_Plano"]);
            planoBindingSource.DataSource = planoBLL.BuscarPlano(id_Plano);
            textBoxPlano.Text = (string)(((DataRowView)planoBindingSource.Current).Row["Descricao"]);
        }

        private void textBoxBuscarOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(null,null);
                //ordemServicoBindingSource.DataSource = ordemServicoBLL.BuscarOS("");
            }
        }
    }
}
