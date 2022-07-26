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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label labelUf;
            System.Windows.Forms.Label labelCidade;
            System.Windows.Forms.Label labelCelularDois;
            System.Windows.Forms.Label labelCelularUm;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label labelTelefone;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelNumCasa;
            System.Windows.Forms.Label labelRua;
            System.Windows.Forms.Label labelBairro;
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.textBoxProtocolo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxAtendente = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTipoChamado = new System.Windows.Forms.ComboBox();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
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
            labelDescricao = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            labelUf = new System.Windows.Forms.Label();
            labelCidade = new System.Windows.Forms.Label();
            labelCelularDois = new System.Windows.Forms.Label();
            labelCelularUm = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            labelTelefone = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelNumCasa = new System.Windows.Forms.Label();
            labelRua = new System.Windows.Forms.Label();
            labelBairro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.ForeColor = System.Drawing.Color.Black;
            labelDescricao.Location = new System.Drawing.Point(326, 305);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new System.Drawing.Size(72, 13);
            labelDescricao.TabIndex = 38;
            labelDescricao.Text = "DESCRIÇÃO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(4, 63);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(31, 13);
            label8.TabIndex = 33;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(74, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 13);
            label9.TabIndex = 5;
            label9.Text = "NOME COMPLETO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.Black;
            label11.Location = new System.Drawing.Point(3, 23);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(52, 13);
            label11.TabIndex = 3;
            label11.Text = "CODIGO:";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.ForeColor = System.Drawing.Color.Black;
            labelUf.Location = new System.Drawing.Point(505, 63);
            labelUf.Name = "labelUf";
            labelUf.Size = new System.Drawing.Size(24, 13);
            labelUf.TabIndex = 17;
            labelUf.Text = "UF:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.ForeColor = System.Drawing.Color.Black;
            labelCidade.Location = new System.Drawing.Point(387, 63);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new System.Drawing.Size(50, 13);
            labelCidade.TabIndex = 24;
            labelCidade.Text = "CIDADE:";
            // 
            // labelCelularDois
            // 
            labelCelularDois.AutoSize = true;
            labelCelularDois.ForeColor = System.Drawing.Color.Black;
            labelCelularDois.Location = new System.Drawing.Point(447, 102);
            labelCelularDois.Name = "labelCelularDois";
            labelCelularDois.Size = new System.Drawing.Size(68, 13);
            labelCelularDois.TabIndex = 19;
            labelCelularDois.Text = "CELULAR 2:";
            // 
            // labelCelularUm
            // 
            labelCelularUm.AutoSize = true;
            labelCelularUm.ForeColor = System.Drawing.Color.Black;
            labelCelularUm.Location = new System.Drawing.Point(346, 102);
            labelCelularUm.Name = "labelCelularUm";
            labelCelularUm.Size = new System.Drawing.Size(68, 13);
            labelCelularUm.TabIndex = 22;
            labelCelularUm.Text = "CELULAR 1:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(460, 23);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(81, 13);
            label12.TabIndex = 1;
            label12.Text = "NASCIMENTO:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.ForeColor = System.Drawing.Color.Black;
            labelTelefone.Location = new System.Drawing.Point(245, 102);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new System.Drawing.Size(66, 13);
            labelTelefone.TabIndex = 27;
            labelTelefone.Text = "TELEFONE:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = System.Drawing.Color.Black;
            labelEmail.Location = new System.Drawing.Point(3, 102);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(45, 13);
            labelEmail.TabIndex = 30;
            labelEmail.Text = "E-MAIL:";
            // 
            // labelNumCasa
            // 
            labelNumCasa.AutoSize = true;
            labelNumCasa.ForeColor = System.Drawing.Color.Black;
            labelNumCasa.Location = new System.Drawing.Point(245, 63);
            labelNumCasa.Name = "labelNumCasa";
            labelNumCasa.Size = new System.Drawing.Size(22, 13);
            labelNumCasa.TabIndex = 25;
            labelNumCasa.Text = "N°:";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.ForeColor = System.Drawing.Color.Black;
            labelRua.Location = new System.Drawing.Point(74, 63);
            labelRua.Name = "labelRua";
            labelRua.Size = new System.Drawing.Size(33, 13);
            labelRua.TabIndex = 32;
            labelRua.Text = "RUA:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.ForeColor = System.Drawing.Color.Black;
            labelBairro.Location = new System.Drawing.Point(286, 63);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new System.Drawing.Size(51, 13);
            labelBairro.TabIndex = 41;
            labelBairro.Text = "BAIRRO:";
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(15, 35);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.Size = new System.Drawing.Size(300, 500);
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
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(240, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 24);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "&BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(15, 7);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(219, 20);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // textBoxProtocolo
            // 
            this.textBoxProtocolo.Location = new System.Drawing.Point(607, 9);
            this.textBoxProtocolo.Name = "textBoxProtocolo";
            this.textBoxProtocolo.ReadOnly = true;
            this.textBoxProtocolo.Size = new System.Drawing.Size(136, 20);
            this.textBoxProtocolo.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(547, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBoxAtendente
            // 
            this.textBoxAtendente.Location = new System.Drawing.Point(547, 79);
            this.textBoxAtendente.Name = "textBoxAtendente";
            this.textBoxAtendente.Size = new System.Drawing.Size(209, 20);
            this.textBoxAtendente.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(384, 507);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(136, 20);
            this.textBox8.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "PROTOCOLO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIPO DE CHAMADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "TÉCNICO RESPONSÁVEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ATENDENTE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "PLANO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "STATUS:";
            // 
            // panelBotoes
            // 
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 538);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(1090, 41);
            this.panelBotoes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxTipoChamado);
            this.panel1.Controls.Add(this.groupBoxDadosPessoais);
            this.panel1.Controls.Add(labelDescricao);
            this.panel1.Controls.Add(this.usuarioDataGridView);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxProtocolo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 538);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxTipoChamado
            // 
            this.comboBoxTipoChamado.Location = new System.Drawing.Point(327, 204);
            this.comboBoxTipoChamado.Name = "comboBoxTipoChamado";
            this.comboBoxTipoChamado.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTipoChamado.TabIndex = 0;
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBoxDadosPessoais.Controls.Add(this.textBox4);
            this.groupBoxDadosPessoais.Controls.Add(this.label3);
            this.groupBoxDadosPessoais.Controls.Add(this.label4);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(label11);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxUf);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxAtendente);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelUf);
            this.groupBoxDadosPessoais.Controls.Add(labelCidade);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularDois);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxDataNascimento);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxPlano);
            this.groupBoxDadosPessoais.Controls.Add(labelCelularUm);
            this.groupBoxDadosPessoais.Controls.Add(label12);
            this.groupBoxDadosPessoais.Controls.Add(labelTelefone);
            this.groupBoxDadosPessoais.Controls.Add(labelEmail);
            this.groupBoxDadosPessoais.Controls.Add(labelNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNumCasa);
            this.groupBoxDadosPessoais.Controls.Add(labelRua);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxRua);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(321, 35);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(763, 147);
            this.groupBoxDadosPessoais.TabIndex = 0;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "DADOS DO CLIENTE";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cidade", true));
            this.textBoxBairro.Location = new System.Drawing.Point(290, 79);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(94, 20);
            this.textBoxBairro.TabIndex = 40;
            // 
            // labelIdPessoa
            // 
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
            this.maskedTextBoxCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cep", true));
            this.maskedTextBoxCep.Location = new System.Drawing.Point(6, 79);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBoxCep.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(6, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(236, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefone", true));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(248, 118);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxTelefone.TabIndex = 13;
            // 
            // maskedTextBoxCelularDois
            // 
            this.maskedTextBoxCelularDois.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CelularDois", true));
            this.maskedTextBoxCelularDois.Location = new System.Drawing.Point(450, 118);
            this.maskedTextBoxCelularDois.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularDois.Name = "maskedTextBoxCelularDois";
            this.maskedTextBoxCelularDois.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularDois.TabIndex = 15;
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeCompleto", true));
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(70, 39);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(387, 20);
            this.textBoxNomeCompleto.TabIndex = 13;
            // 
            // maskedTextBoxCelularUm
            // 
            this.maskedTextBoxCelularUm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CelularUm", true));
            this.maskedTextBoxCelularUm.Location = new System.Drawing.Point(349, 118);
            this.maskedTextBoxCelularUm.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularUm.Name = "maskedTextBoxCelularUm";
            this.maskedTextBoxCelularUm.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularUm.TabIndex = 14;
            // 
            // textBoxUf
            // 
            this.textBoxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Uf", true));
            this.textBoxUf.Location = new System.Drawing.Point(508, 79);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.Size = new System.Drawing.Size(33, 20);
            this.textBoxUf.TabIndex = 11;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cidade", true));
            this.textBoxCidade.Location = new System.Drawing.Point(390, 79);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(112, 20);
            this.textBoxCidade.TabIndex = 10;
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "DataNascimento", true));
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(463, 39);
            this.maskedTextBoxDataNascimento.Mask = "00-00-0000";
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxDataNascimento.TabIndex = 8;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPlano
            // 
            this.textBoxPlano.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Plano", true));
            this.textBoxPlano.Location = new System.Drawing.Point(547, 39);
            this.textBoxPlano.Name = "textBoxPlano";
            this.textBoxPlano.Size = new System.Drawing.Size(209, 20);
            this.textBoxPlano.TabIndex = 9;
            // 
            // textBoxNumCasa
            // 
            this.textBoxNumCasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NumCasa", true));
            this.textBoxNumCasa.Location = new System.Drawing.Point(248, 79);
            this.textBoxNumCasa.Name = "textBoxNumCasa";
            this.textBoxNumCasa.Size = new System.Drawing.Size(36, 20);
            this.textBoxNumCasa.TabIndex = 9;
            // 
            // textBoxRua
            // 
            this.textBoxRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Rua", true));
            this.textBoxRua.Location = new System.Drawing.Point(70, 79);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(172, 20);
            this.textBoxRua.TabIndex = 8;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricao.Location = new System.Drawing.Point(327, 321);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(750, 52);
            this.textBoxDescricao.TabIndex = 37;
            // 
            // tipoChamadoBindingSource
            // 
            this.tipoChamadoBindingSource.DataSource = typeof(Model.TipoChamado);
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBotoes);
            this.MinimizeBox = false;
            this.Name = "FormOrdemServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox textBoxProtocolo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxAtendente;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}