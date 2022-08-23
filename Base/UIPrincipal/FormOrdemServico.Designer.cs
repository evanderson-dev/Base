namespace UIPrincipal
{
    partial class FormOrdemServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelDescricao;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label labelCodigo;
            System.Windows.Forms.Label labelUf;
            System.Windows.Forms.Label labelCidade;
            System.Windows.Forms.Label labelCelularDois;
            System.Windows.Forms.Label labelCelularUm;
            System.Windows.Forms.Label labelNascimento;
            System.Windows.Forms.Label labelTelefone;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelNumCasa;
            System.Windows.Forms.Label labelRua;
            System.Windows.Forms.Label labelBairro;
            System.Windows.Forms.Label label1CpfCNPJ;
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.textBoxProtocolo = new System.Windows.Forms.TextBox();
            this.textBoxAtendente = new System.Windows.Forms.TextBox();
            this.labelProtocolo = new System.Windows.Forms.Label();
            this.labelTipoChamado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTecnicoResponsavel = new System.Windows.Forms.ComboBox();
            this.labelLigarAntes = new System.Windows.Forms.Label();
            this.comboBoxlLigarAntes = new System.Windows.Forms.ComboBox();
            this.labelPrazo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrazo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxStatusOS = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoChamado = new System.Windows.Forms.ComboBox();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelIdPessoa = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelularDois = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCelularUm = new System.Windows.Forms.MaskedTextBox();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPlano = new System.Windows.Forms.TextBox();
            this.textBoxNumCasa = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.tipoChamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            labelDescricao = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            labelCodigo = new System.Windows.Forms.Label();
            labelUf = new System.Windows.Forms.Label();
            labelCidade = new System.Windows.Forms.Label();
            labelCelularDois = new System.Windows.Forms.Label();
            labelCelularUm = new System.Windows.Forms.Label();
            labelNascimento = new System.Windows.Forms.Label();
            labelTelefone = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelNumCasa = new System.Windows.Forms.Label();
            labelRua = new System.Windows.Forms.Label();
            labelBairro = new System.Windows.Forms.Label();
            label1CpfCNPJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            labelDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelDescricao.AutoSize = true;
            labelDescricao.ForeColor = System.Drawing.Color.White;
            labelDescricao.Location = new System.Drawing.Point(13, 226);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new System.Drawing.Size(72, 13);
            labelDescricao.TabIndex = 38;
            labelDescricao.Text = "DESCRIÇÃO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(4, 63);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(31, 13);
            label8.TabIndex = 33;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(67, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 13);
            label9.TabIndex = 5;
            label9.Text = "NOME COMPLETO:";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.ForeColor = System.Drawing.Color.White;
            labelCodigo.Location = new System.Drawing.Point(3, 23);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new System.Drawing.Size(52, 13);
            labelCodigo.TabIndex = 3;
            labelCodigo.Text = "CODIGO:";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.ForeColor = System.Drawing.Color.White;
            labelUf.Location = new System.Drawing.Point(505, 63);
            labelUf.Name = "labelUf";
            labelUf.Size = new System.Drawing.Size(24, 13);
            labelUf.TabIndex = 17;
            labelUf.Text = "UF:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.ForeColor = System.Drawing.Color.White;
            labelCidade.Location = new System.Drawing.Point(387, 63);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new System.Drawing.Size(50, 13);
            labelCidade.TabIndex = 24;
            labelCidade.Text = "CIDADE:";
            // 
            // labelCelularDois
            // 
            labelCelularDois.AutoSize = true;
            labelCelularDois.ForeColor = System.Drawing.Color.White;
            labelCelularDois.Location = new System.Drawing.Point(447, 102);
            labelCelularDois.Name = "labelCelularDois";
            labelCelularDois.Size = new System.Drawing.Size(68, 13);
            labelCelularDois.TabIndex = 19;
            labelCelularDois.Text = "CELULAR 2:";
            // 
            // labelCelularUm
            // 
            labelCelularUm.AutoSize = true;
            labelCelularUm.ForeColor = System.Drawing.Color.White;
            labelCelularUm.Location = new System.Drawing.Point(346, 102);
            labelCelularUm.Name = "labelCelularUm";
            labelCelularUm.Size = new System.Drawing.Size(68, 13);
            labelCelularUm.TabIndex = 22;
            labelCelularUm.Text = "CELULAR 1:";
            // 
            // labelNascimento
            // 
            labelNascimento.AutoSize = true;
            labelNascimento.ForeColor = System.Drawing.Color.White;
            labelNascimento.Location = new System.Drawing.Point(460, 23);
            labelNascimento.Name = "labelNascimento";
            labelNascimento.Size = new System.Drawing.Size(81, 13);
            labelNascimento.TabIndex = 1;
            labelNascimento.Text = "NASCIMENTO:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.ForeColor = System.Drawing.Color.White;
            labelTelefone.Location = new System.Drawing.Point(245, 102);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new System.Drawing.Size(66, 13);
            labelTelefone.TabIndex = 27;
            labelTelefone.Text = "TELEFONE:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = System.Drawing.Color.White;
            labelEmail.Location = new System.Drawing.Point(3, 102);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(45, 13);
            labelEmail.TabIndex = 30;
            labelEmail.Text = "E-MAIL:";
            // 
            // labelNumCasa
            // 
            labelNumCasa.AutoSize = true;
            labelNumCasa.ForeColor = System.Drawing.Color.White;
            labelNumCasa.Location = new System.Drawing.Point(245, 63);
            labelNumCasa.Name = "labelNumCasa";
            labelNumCasa.Size = new System.Drawing.Size(22, 13);
            labelNumCasa.TabIndex = 25;
            labelNumCasa.Text = "N°:";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.ForeColor = System.Drawing.Color.White;
            labelRua.Location = new System.Drawing.Point(67, 63);
            labelRua.Name = "labelRua";
            labelRua.Size = new System.Drawing.Size(33, 13);
            labelRua.TabIndex = 32;
            labelRua.Text = "RUA:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.ForeColor = System.Drawing.Color.White;
            labelBairro.Location = new System.Drawing.Point(286, 63);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new System.Drawing.Size(51, 13);
            labelBairro.TabIndex = 41;
            labelBairro.Text = "BAIRRO:";
            // 
            // label1CpfCNPJ
            // 
            label1CpfCNPJ.AutoSize = true;
            label1CpfCNPJ.ForeColor = System.Drawing.Color.White;
            label1CpfCNPJ.Location = new System.Drawing.Point(544, 23);
            label1CpfCNPJ.Name = "label1CpfCNPJ";
            label1CpfCNPJ.Size = new System.Drawing.Size(68, 13);
            label1CpfCNPJ.TabIndex = 43;
            label1CpfCNPJ.Text = "CPF / CNPJ:";
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(14, 390);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.RowHeadersVisible = false;
            this.usuarioDataGridView.Size = new System.Drawing.Size(836, 194);
            this.usuarioDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeCompleto";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Image = global::UIPrincipal.Properties.Resources.magnifier;
            this.buttonBuscar.Location = new System.Drawing.Point(235, 362);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(29, 24);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuscar.Location = new System.Drawing.Point(15, 364);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(219, 20);
            this.textBoxBuscar.TabIndex = 0;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // textBoxProtocolo
            // 
            this.textBoxProtocolo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxProtocolo.BackColor = System.Drawing.Color.Black;
            this.textBoxProtocolo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProtocolo.ForeColor = System.Drawing.Color.White;
            this.textBoxProtocolo.Location = new System.Drawing.Point(398, 7);
            this.textBoxProtocolo.Name = "textBoxProtocolo";
            this.textBoxProtocolo.ReadOnly = true;
            this.textBoxProtocolo.Size = new System.Drawing.Size(136, 16);
            this.textBoxProtocolo.TabIndex = 1;
            // 
            // textBoxAtendente
            // 
            this.textBoxAtendente.BackColor = System.Drawing.Color.White;
            this.textBoxAtendente.Enabled = false;
            this.textBoxAtendente.Location = new System.Drawing.Point(547, 118);
            this.textBoxAtendente.Name = "textBoxAtendente";
            this.textBoxAtendente.ReadOnly = true;
            this.textBoxAtendente.Size = new System.Drawing.Size(293, 20);
            this.textBoxAtendente.TabIndex = 13;
            // 
            // labelProtocolo
            // 
            this.labelProtocolo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProtocolo.AutoSize = true;
            this.labelProtocolo.ForeColor = System.Drawing.Color.White;
            this.labelProtocolo.Location = new System.Drawing.Point(319, 9);
            this.labelProtocolo.Name = "labelProtocolo";
            this.labelProtocolo.Size = new System.Drawing.Size(77, 13);
            this.labelProtocolo.TabIndex = 17;
            this.labelProtocolo.Text = "PROTOCOLO:";
            // 
            // labelTipoChamado
            // 
            this.labelTipoChamado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTipoChamado.AutoSize = true;
            this.labelTipoChamado.BackColor = System.Drawing.Color.Black;
            this.labelTipoChamado.ForeColor = System.Drawing.Color.White;
            this.labelTipoChamado.Location = new System.Drawing.Point(12, 183);
            this.labelTipoChamado.Name = "labelTipoChamado";
            this.labelTipoChamado.Size = new System.Drawing.Size(110, 13);
            this.labelTipoChamado.TabIndex = 18;
            this.labelTipoChamado.Text = "TIPO DE CHAMADO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(584, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "TÉCNICO RESPONSÁVEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(544, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ATENDENTE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(544, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "PLANO:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(177, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "STATUS:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(435, 598);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 51;
            this.buttonCancelar.Text = "&CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(346, 598);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 50;
            this.buttonSalvar.Text = "&SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSair.Location = new System.Drawing.Point(521, 598);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 49;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(257, 598);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 47;
            this.buttonNovo.Text = "&NOVO";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.comboBoxTecnicoResponsavel);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.labelLigarAntes);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Controls.Add(this.comboBoxlLigarAntes);
            this.panel1.Controls.Add(this.labelPrazo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskedTextBoxPrazo);
            this.panel1.Controls.Add(this.maskedTextBoxDataAbertura);
            this.panel1.Controls.Add(this.comboBoxStatusOS);
            this.panel1.Controls.Add(this.comboBoxTipoChamado);
            this.panel1.Controls.Add(this.groupBoxDadosPessoais);
            this.panel1.Controls.Add(labelDescricao);
            this.panel1.Controls.Add(this.usuarioDataGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxProtocolo);
            this.panel1.Controls.Add(this.labelTipoChamado);
            this.panel1.Controls.Add(this.labelProtocolo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(870, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 639);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxTecnicoResponsavel
            // 
            this.comboBoxTecnicoResponsavel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTecnicoResponsavel.BackColor = System.Drawing.Color.White;
            this.comboBoxTecnicoResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecnicoResponsavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTecnicoResponsavel.FormattingEnabled = true;
            this.comboBoxTecnicoResponsavel.Location = new System.Drawing.Point(587, 199);
            this.comboBoxTecnicoResponsavel.Name = "comboBoxTecnicoResponsavel";
            this.comboBoxTecnicoResponsavel.Size = new System.Drawing.Size(263, 21);
            this.comboBoxTecnicoResponsavel.TabIndex = 46;
            this.comboBoxTecnicoResponsavel.Click += new System.EventHandler(this.comboBoxTecnicoResponsavel_Click);
            // 
            // labelLigarAntes
            // 
            this.labelLigarAntes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLigarAntes.AutoSize = true;
            this.labelLigarAntes.ForeColor = System.Drawing.Color.White;
            this.labelLigarAntes.Location = new System.Drawing.Point(298, 183);
            this.labelLigarAntes.Name = "labelLigarAntes";
            this.labelLigarAntes.Size = new System.Drawing.Size(81, 13);
            this.labelLigarAntes.TabIndex = 45;
            this.labelLigarAntes.Text = "LIGAR ANTES:";
            // 
            // comboBoxlLigarAntes
            // 
            this.comboBoxlLigarAntes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxlLigarAntes.BackColor = System.Drawing.Color.White;
            this.comboBoxlLigarAntes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxlLigarAntes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxlLigarAntes.FormattingEnabled = true;
            this.comboBoxlLigarAntes.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.comboBoxlLigarAntes.Location = new System.Drawing.Point(301, 199);
            this.comboBoxlLigarAntes.Name = "comboBoxlLigarAntes";
            this.comboBoxlLigarAntes.Size = new System.Drawing.Size(78, 21);
            this.comboBoxlLigarAntes.TabIndex = 44;
            // 
            // labelPrazo
            // 
            this.labelPrazo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrazo.AutoSize = true;
            this.labelPrazo.ForeColor = System.Drawing.Color.White;
            this.labelPrazo.Location = new System.Drawing.Point(482, 184);
            this.labelPrazo.Name = "labelPrazo";
            this.labelPrazo.Size = new System.Drawing.Size(47, 13);
            this.labelPrazo.TabIndex = 43;
            this.labelPrazo.Text = "PRAZO:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(380, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "ABERTURA:";
            // 
            // maskedTextBoxPrazo
            // 
            this.maskedTextBoxPrazo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBoxPrazo.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxPrazo.Location = new System.Drawing.Point(485, 200);
            this.maskedTextBoxPrazo.Mask = "00/00/0000 90:00";
            this.maskedTextBoxPrazo.Name = "maskedTextBoxPrazo";
            this.maskedTextBoxPrazo.ReadOnly = true;
            this.maskedTextBoxPrazo.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxPrazo.TabIndex = 41;
            this.maskedTextBoxPrazo.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataAbertura
            // 
            this.maskedTextBoxDataAbertura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBoxDataAbertura.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxDataAbertura.Enabled = false;
            this.maskedTextBoxDataAbertura.Location = new System.Drawing.Point(383, 200);
            this.maskedTextBoxDataAbertura.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDataAbertura.Name = "maskedTextBoxDataAbertura";
            this.maskedTextBoxDataAbertura.ReadOnly = true;
            this.maskedTextBoxDataAbertura.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxDataAbertura.TabIndex = 40;
            this.maskedTextBoxDataAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxStatusOS
            // 
            this.comboBoxStatusOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxStatusOS.BackColor = System.Drawing.Color.White;
            this.comboBoxStatusOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatusOS.FormattingEnabled = true;
            this.comboBoxStatusOS.Location = new System.Drawing.Point(180, 199);
            this.comboBoxStatusOS.Name = "comboBoxStatusOS";
            this.comboBoxStatusOS.Size = new System.Drawing.Size(117, 21);
            this.comboBoxStatusOS.TabIndex = 39;
            // 
            // comboBoxTipoChamado
            // 
            this.comboBoxTipoChamado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTipoChamado.BackColor = System.Drawing.Color.White;
            this.comboBoxTipoChamado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoChamado.Location = new System.Drawing.Point(16, 199);
            this.comboBoxTipoChamado.Name = "comboBoxTipoChamado";
            this.comboBoxTipoChamado.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoChamado.TabIndex = 0;
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDadosPessoais.Controls.Add(label1CpfCNPJ);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxBairro);
            this.groupBoxDadosPessoais.Controls.Add(labelBairro);
            this.groupBoxDadosPessoais.Controls.Add(this.labelIdPessoa);
            this.groupBoxDadosPessoais.Controls.Add(label8);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCep);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxEmail);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBoxDadosPessoais.Controls.Add(label9);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCelularDois);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNomeCompleto);
            this.groupBoxDadosPessoais.Controls.Add(this.label6);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(labelCodigo);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxUf);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxAtendente);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelUf);
            this.groupBoxDadosPessoais.Controls.Add(labelCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularDois);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxDataNascimento);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxPlano);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(labelNascimento);
            this.groupBoxDadosPessoais.Controls.Add(labelTelefone);
            this.groupBoxDadosPessoais.Controls.Add(labelEmail);
            this.groupBoxDadosPessoais.Controls.Add(labelNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(labelRua);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxRua);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(10, 29);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(846, 147);
            this.groupBoxDadosPessoais.TabIndex = 0;
            this.groupBoxDadosPessoais.TabStop = false;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.BackColor = System.Drawing.Color.White;
            this.textBoxCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cpf", true));
            this.textBoxCpf.Enabled = false;
            this.textBoxCpf.Location = new System.Drawing.Point(547, 39);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.ReadOnly = true;
            this.textBoxCpf.Size = new System.Drawing.Size(293, 20);
            this.textBoxCpf.TabIndex = 42;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.BackColor = System.Drawing.Color.White;
            this.textBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Bairro", true));
            this.textBoxBairro.Enabled = false;
            this.textBoxBairro.Location = new System.Drawing.Point(290, 79);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.ReadOnly = true;
            this.textBoxBairro.Size = new System.Drawing.Size(94, 20);
            this.textBoxBairro.TabIndex = 40;
            // 
            // labelIdPessoa
            // 
            this.labelIdPessoa.BackColor = System.Drawing.Color.White;
            this.labelIdPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIdPessoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id", true));
            this.labelIdPessoa.Location = new System.Drawing.Point(6, 39);
            this.labelIdPessoa.Name = "labelIdPessoa";
            this.labelIdPessoa.Size = new System.Drawing.Size(58, 20);
            this.labelIdPessoa.TabIndex = 39;
            this.labelIdPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cep", true));
            this.maskedTextBoxCep.Enabled = false;
            this.maskedTextBoxCep.Location = new System.Drawing.Point(6, 79);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.ReadOnly = true;
            this.maskedTextBoxCep.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBoxCep.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(6, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(236, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefone", true));
            this.maskedTextBoxTelefone.Enabled = false;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(248, 118);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.ReadOnly = true;
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxTelefone.TabIndex = 13;
            // 
            // maskedTextBoxCelularDois
            // 
            this.maskedTextBoxCelularDois.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxCelularDois.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CelularDois", true));
            this.maskedTextBoxCelularDois.Enabled = false;
            this.maskedTextBoxCelularDois.Location = new System.Drawing.Point(450, 118);
            this.maskedTextBoxCelularDois.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularDois.Name = "maskedTextBoxCelularDois";
            this.maskedTextBoxCelularDois.ReadOnly = true;
            this.maskedTextBoxCelularDois.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularDois.TabIndex = 15;
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.BackColor = System.Drawing.Color.White;
            this.textBoxNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeCompleto", true));
            this.textBoxNomeCompleto.Enabled = false;
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(70, 39);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.ReadOnly = true;
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(387, 20);
            this.textBoxNomeCompleto.TabIndex = 13;
            // 
            // maskedTextBoxCelularUm
            // 
            this.maskedTextBoxCelularUm.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxCelularUm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CelularUm", true));
            this.maskedTextBoxCelularUm.Enabled = false;
            this.maskedTextBoxCelularUm.Location = new System.Drawing.Point(349, 118);
            this.maskedTextBoxCelularUm.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularUm.Name = "maskedTextBoxCelularUm";
            this.maskedTextBoxCelularUm.ReadOnly = true;
            this.maskedTextBoxCelularUm.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularUm.TabIndex = 14;
            // 
            // textBoxUf
            // 
            this.textBoxUf.BackColor = System.Drawing.Color.White;
            this.textBoxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Uf", true));
            this.textBoxUf.Enabled = false;
            this.textBoxUf.Location = new System.Drawing.Point(508, 79);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.ReadOnly = true;
            this.textBoxUf.Size = new System.Drawing.Size(33, 20);
            this.textBoxUf.TabIndex = 11;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.BackColor = System.Drawing.Color.White;
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cidade", true));
            this.textBoxCidade.Enabled = false;
            this.textBoxCidade.Location = new System.Drawing.Point(390, 79);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.ReadOnly = true;
            this.textBoxCidade.Size = new System.Drawing.Size(112, 20);
            this.textBoxCidade.TabIndex = 10;
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "DataNascimento", true));
            this.maskedTextBoxDataNascimento.Enabled = false;
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(463, 39);
            this.maskedTextBoxDataNascimento.Mask = "00/00/0000";
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.ReadOnly = true;
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxDataNascimento.TabIndex = 8;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPlano
            // 
            this.textBoxPlano.BackColor = System.Drawing.Color.White;
            this.textBoxPlano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Plano", true));
            this.textBoxPlano.Enabled = false;
            this.textBoxPlano.Location = new System.Drawing.Point(547, 79);
            this.textBoxPlano.Name = "textBoxPlano";
            this.textBoxPlano.ReadOnly = true;
            this.textBoxPlano.Size = new System.Drawing.Size(293, 20);
            this.textBoxPlano.TabIndex = 9;
            // 
            // textBoxNumCasa
            // 
            this.textBoxNumCasa.BackColor = System.Drawing.Color.White;
            this.textBoxNumCasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NumCasa", true));
            this.textBoxNumCasa.Enabled = false;
            this.textBoxNumCasa.Location = new System.Drawing.Point(248, 79);
            this.textBoxNumCasa.Name = "textBoxNumCasa";
            this.textBoxNumCasa.ReadOnly = true;
            this.textBoxNumCasa.Size = new System.Drawing.Size(36, 20);
            this.textBoxNumCasa.TabIndex = 9;
            // 
            // textBoxRua
            // 
            this.textBoxRua.BackColor = System.Drawing.Color.White;
            this.textBoxRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Rua", true));
            this.textBoxRua.Enabled = false;
            this.textBoxRua.Location = new System.Drawing.Point(70, 79);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.ReadOnly = true;
            this.textBoxRua.Size = new System.Drawing.Size(172, 20);
            this.textBoxRua.TabIndex = 8;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDescricao.Location = new System.Drawing.Point(15, 242);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(835, 100);
            this.textBoxDescricao.TabIndex = 37;
            // 
            // tipoChamadoBindingSource
            // 
            this.tipoChamadoBindingSource.DataSource = typeof(Model.TipoChamado);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // ordemServicoBindingSource
            // 
            this.ordemServicoBindingSource.DataSource = typeof(Model.OrdemServico);
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormOrdemServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox textBoxProtocolo;
        private System.Windows.Forms.TextBox textBoxAtendente;
        private System.Windows.Forms.Label labelProtocolo;
        private System.Windows.Forms.Label labelTipoChamado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.Label labelIdPessoa;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularDois;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularUm;
        private System.Windows.Forms.TextBox textBoxUf;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNascimento;
        private System.Windows.Forms.TextBox textBoxNumCasa;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.TextBox textBoxPlano;
        private System.Windows.Forms.ComboBox comboBoxTipoChamado;
        private System.Windows.Forms.BindingSource tipoChamadoBindingSource;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.ComboBox comboBoxStatusOS;
        private System.Windows.Forms.Label labelPrazo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrazo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataAbertura;
        private System.Windows.Forms.Label labelLigarAntes;
        private System.Windows.Forms.ComboBox comboBoxlLigarAntes;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTecnicoResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.BindingSource ordemServicoBindingSource;
    }
}