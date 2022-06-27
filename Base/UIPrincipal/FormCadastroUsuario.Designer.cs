
namespace UIPrincipal
{
    partial class FormCadastroUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label labelSenha;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label RgLabel;
            System.Windows.Forms.Label labelOrgExpeditor;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label labelNacionalidade;
            System.Windows.Forms.Label labelEstadoCivil;
            System.Windows.Forms.Label labelRua;
            System.Windows.Forms.Label labelNumCasa;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelTelefone;
            System.Windows.Forms.Label labelCelularUm;
            System.Windows.Forms.Label labelCelularDois;
            System.Windows.Forms.Label labelCidade;
            System.Windows.Forms.Label labelUf;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSalvarECadastrarNovo = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxRg = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.textBoxOrgExpeditor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNacionalidade = new System.Windows.Forms.TextBox();
            this.textBoxEstadoCivil = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.textBoxNumCasa = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCelularUm = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelularDois = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelSenha = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            RgLabel = new System.Windows.Forms.Label();
            labelOrgExpeditor = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelNacionalidade = new System.Windows.Forms.Label();
            labelEstadoCivil = new System.Windows.Forms.Label();
            labelRua = new System.Windows.Forms.Label();
            labelNumCasa = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelTelefone = new System.Windows.Forms.Label();
            labelCelularUm = new System.Windows.Forms.Label();
            labelCelularDois = new System.Windows.Forms.Label();
            labelCidade = new System.Windows.Forms.Label();
            labelUf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBoxFuncionario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.ForeColor = System.Drawing.Color.Black;
            nomeUsuarioLabel.Location = new System.Drawing.Point(6, 16);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(43, 13);
            nomeUsuarioLabel.TabIndex = 8;
            nomeUsuarioLabel.Text = "LOGIN:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.ForeColor = System.Drawing.Color.Black;
            cpfLabel.Location = new System.Drawing.Point(3, 62);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(30, 13);
            cpfLabel.TabIndex = 10;
            cpfLabel.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(74, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 13);
            label1.TabIndex = 11;
            label1.Text = "NOME COMPLETO:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.ForeColor = System.Drawing.Color.Black;
            labelSenha.Location = new System.Drawing.Point(389, 16);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new System.Drawing.Size(47, 13);
            labelSenha.TabIndex = 14;
            labelSenha.Text = "SENHA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(3, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 16;
            label2.Text = "CODIGO:";
            // 
            // RgLabel
            // 
            RgLabel.AutoSize = true;
            RgLabel.ForeColor = System.Drawing.Color.Black;
            RgLabel.Location = new System.Drawing.Point(100, 62);
            RgLabel.Name = "RgLabel";
            RgLabel.Size = new System.Drawing.Size(26, 13);
            RgLabel.TabIndex = 18;
            RgLabel.Text = "RG:";
            // 
            // labelOrgExpeditor
            // 
            labelOrgExpeditor.AutoSize = true;
            labelOrgExpeditor.ForeColor = System.Drawing.Color.Black;
            labelOrgExpeditor.Location = new System.Drawing.Point(191, 62);
            labelOrgExpeditor.Name = "labelOrgExpeditor";
            labelOrgExpeditor.Size = new System.Drawing.Size(102, 13);
            labelOrgExpeditor.TabIndex = 20;
            labelOrgExpeditor.Text = "ORG. EXPEDITOR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(509, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 13);
            label3.TabIndex = 22;
            label3.Text = "NASCIMENTO:";
            // 
            // labelNacionalidade
            // 
            labelNacionalidade.AutoSize = true;
            labelNacionalidade.ForeColor = System.Drawing.Color.Black;
            labelNacionalidade.Location = new System.Drawing.Point(299, 62);
            labelNacionalidade.Name = "labelNacionalidade";
            labelNacionalidade.Size = new System.Drawing.Size(97, 13);
            labelNacionalidade.TabIndex = 24;
            labelNacionalidade.Text = "NACIONALIDADE:";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.ForeColor = System.Drawing.Color.Black;
            labelEstadoCivil.Location = new System.Drawing.Point(403, 62);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new System.Drawing.Size(83, 13);
            labelEstadoCivil.TabIndex = 26;
            labelEstadoCivil.Text = "ESTADO CICIL:";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.ForeColor = System.Drawing.Color.Black;
            labelRua.Location = new System.Drawing.Point(3, 101);
            labelRua.Name = "labelRua";
            labelRua.Size = new System.Drawing.Size(33, 13);
            labelRua.TabIndex = 28;
            labelRua.Text = "RUA:";
            // 
            // labelNumCasa
            // 
            labelNumCasa.AutoSize = true;
            labelNumCasa.ForeColor = System.Drawing.Color.Black;
            labelNumCasa.Location = new System.Drawing.Point(254, 101);
            labelNumCasa.Name = "labelNumCasa";
            labelNumCasa.Size = new System.Drawing.Size(58, 13);
            labelNumCasa.TabIndex = 30;
            labelNumCasa.Text = "NUMERO:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = System.Drawing.Color.Black;
            labelEmail.Location = new System.Drawing.Point(3, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(45, 13);
            labelEmail.TabIndex = 31;
            labelEmail.Text = "E-MAIL:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.ForeColor = System.Drawing.Color.Black;
            labelTelefone.Location = new System.Drawing.Point(218, 140);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new System.Drawing.Size(66, 13);
            labelTelefone.TabIndex = 32;
            labelTelefone.Text = "TELEFONE:";
            // 
            // labelCelularUm
            // 
            labelCelularUm.AutoSize = true;
            labelCelularUm.ForeColor = System.Drawing.Color.Black;
            labelCelularUm.Location = new System.Drawing.Point(315, 140);
            labelCelularUm.Name = "labelCelularUm";
            labelCelularUm.Size = new System.Drawing.Size(68, 13);
            labelCelularUm.TabIndex = 33;
            labelCelularUm.Text = "CELULAR 1:";
            // 
            // labelCelularDois
            // 
            labelCelularDois.AutoSize = true;
            labelCelularDois.ForeColor = System.Drawing.Color.Black;
            labelCelularDois.Location = new System.Drawing.Point(412, 140);
            labelCelularDois.Name = "labelCelularDois";
            labelCelularDois.Size = new System.Drawing.Size(68, 13);
            labelCelularDois.TabIndex = 34;
            labelCelularDois.Text = "CELULAR 2:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.ForeColor = System.Drawing.Color.Black;
            labelCidade.Location = new System.Drawing.Point(315, 101);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new System.Drawing.Size(50, 13);
            labelCidade.TabIndex = 35;
            labelCidade.Text = "CIDADE:";
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.ForeColor = System.Drawing.Color.Black;
            labelUf.Location = new System.Drawing.Point(458, 101);
            labelUf.Name = "labelUf";
            labelUf.Size = new System.Drawing.Size(24, 13);
            labelUf.TabIndex = 36;
            labelUf.Text = "UF:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(22, 526);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(65, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSalvarECadastrarNovo
            // 
            this.buttonSalvarECadastrarNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarECadastrarNovo.Location = new System.Drawing.Point(93, 526);
            this.buttonSalvarECadastrarNovo.Name = "buttonSalvarECadastrarNovo";
            this.buttonSalvarECadastrarNovo.Size = new System.Drawing.Size(226, 23);
            this.buttonSalvarECadastrarNovo.TabIndex = 6;
            this.buttonSalvarECadastrarNovo.Text = "SALVAR E CADASTRAR UM NOVO";
            this.buttonSalvarECadastrarNovo.UseVisualStyleBackColor = true;
            this.buttonSalvarECadastrarNovo.Click += new System.EventHandler(this.buttonSalvarECadastrarNovo_Click);
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ativoCheckBox.Location = new System.Drawing.Point(596, 37);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(52, 24);
            this.ativoCheckBox.TabIndex = 2;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.textBoxNomeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(9, 32);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(377, 20);
            this.textBoxNomeUsuario.TabIndex = 3;
            // 
            // textBoxRg
            // 
            this.textBoxRg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.textBoxRg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRg.Location = new System.Drawing.Point(103, 78);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(85, 20);
            this.textBoxRg.TabIndex = 1;
            // 
            // buttonCancelarCadastro
            // 
            this.buttonCancelarCadastro.BackColor = System.Drawing.Color.White;
            this.buttonCancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCancelarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastro.Location = new System.Drawing.Point(325, 526);
            this.buttonCancelarCadastro.Name = "buttonCancelarCadastro";
            this.buttonCancelarCadastro.Size = new System.Drawing.Size(82, 23);
            this.buttonCancelarCadastro.TabIndex = 7;
            this.buttonCancelarCadastro.Text = "CANCELAR";
            this.buttonCancelarCadastro.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastro.Click += new System.EventHandler(this.buttonCancelarCadastro_Click);
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(77, 39);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(429, 20);
            this.textBoxNomeCompleto.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(392, 32);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(267, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(6, 39);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(65, 20);
            this.textBoxCodigo.TabIndex = 15;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(6, 78);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCpf.TabIndex = 17;
            // 
            // textBoxOrgExpeditor
            // 
            this.textBoxOrgExpeditor.Location = new System.Drawing.Point(194, 78);
            this.textBoxOrgExpeditor.Name = "textBoxOrgExpeditor";
            this.textBoxOrgExpeditor.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrgExpeditor.TabIndex = 19;
            // 
            // maskedTextBoxDataNascimento
            // 
            this.maskedTextBoxDataNascimento.Location = new System.Drawing.Point(512, 39);
            this.maskedTextBoxDataNascimento.Mask = "00-00-0000";
            this.maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            this.maskedTextBoxDataNascimento.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxDataNascimento.TabIndex = 21;
            this.maskedTextBoxDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxNacionalidade
            // 
            this.textBoxNacionalidade.Location = new System.Drawing.Point(300, 78);
            this.textBoxNacionalidade.Name = "textBoxNacionalidade";
            this.textBoxNacionalidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacionalidade.TabIndex = 23;
            // 
            // textBoxEstadoCivil
            // 
            this.textBoxEstadoCivil.Location = new System.Drawing.Point(406, 78);
            this.textBoxEstadoCivil.Name = "textBoxEstadoCivil";
            this.textBoxEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoCivil.TabIndex = 25;
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(6, 117);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(245, 20);
            this.textBoxRua.TabIndex = 27;
            // 
            // textBoxNumCasa
            // 
            this.textBoxNumCasa.Location = new System.Drawing.Point(257, 117);
            this.textBoxNumCasa.Name = "textBoxNumCasa";
            this.textBoxNumCasa.Size = new System.Drawing.Size(55, 20);
            this.textBoxNumCasa.TabIndex = 29;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(318, 117);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(137, 20);
            this.textBoxCidade.TabIndex = 37;
            // 
            // textBoxUf
            // 
            this.textBoxUf.Location = new System.Drawing.Point(461, 117);
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.Size = new System.Drawing.Size(45, 20);
            this.textBoxUf.TabIndex = 38;
            // 
            // maskedTextBoxCelularUm
            // 
            this.maskedTextBoxCelularUm.Location = new System.Drawing.Point(318, 156);
            this.maskedTextBoxCelularUm.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularUm.Name = "maskedTextBoxCelularUm";
            this.maskedTextBoxCelularUm.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularUm.TabIndex = 39;
            // 
            // maskedTextBoxCelularDois
            // 
            this.maskedTextBoxCelularDois.Location = new System.Drawing.Point(415, 156);
            this.maskedTextBoxCelularDois.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxCelularDois.Name = "maskedTextBoxCelularDois";
            this.maskedTextBoxCelularDois.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelularDois.TabIndex = 40;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(221, 156);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxTelefone.TabIndex = 41;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(6, 156);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(209, 20);
            this.textBoxEmail.TabIndex = 42;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // groupBoxFuncionario
            // 
            this.groupBoxFuncionario.Controls.Add(this.textBoxNomeUsuario);
            this.groupBoxFuncionario.Controls.Add(nomeUsuarioLabel);
            this.groupBoxFuncionario.Controls.Add(this.textBoxSenha);
            this.groupBoxFuncionario.Controls.Add(labelSenha);
            this.groupBoxFuncionario.Location = new System.Drawing.Point(22, 409);
            this.groupBoxFuncionario.Name = "groupBoxFuncionario";
            this.groupBoxFuncionario.Size = new System.Drawing.Size(730, 65);
            this.groupBoxFuncionario.TabIndex = 43;
            this.groupBoxFuncionario.TabStop = false;
            this.groupBoxFuncionario.Text = "DADOS DO FUNCIONARIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 40);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DO CLIENTE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCodigo);
            this.groupBox2.Controls.Add(this.ativoCheckBox);
            this.groupBox2.Controls.Add(this.textBoxRg);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(cpfLabel);
            this.groupBox2.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.maskedTextBoxCelularDois);
            this.groupBox2.Controls.Add(this.textBoxNomeCompleto);
            this.groupBox2.Controls.Add(this.maskedTextBoxCelularUm);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.textBoxUf);
            this.groupBox2.Controls.Add(this.maskedTextBoxCpf);
            this.groupBox2.Controls.Add(this.textBoxCidade);
            this.groupBox2.Controls.Add(RgLabel);
            this.groupBox2.Controls.Add(labelUf);
            this.groupBox2.Controls.Add(this.textBoxOrgExpeditor);
            this.groupBox2.Controls.Add(labelCidade);
            this.groupBox2.Controls.Add(labelOrgExpeditor);
            this.groupBox2.Controls.Add(labelCelularDois);
            this.groupBox2.Controls.Add(this.maskedTextBoxDataNascimento);
            this.groupBox2.Controls.Add(labelCelularUm);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(labelTelefone);
            this.groupBox2.Controls.Add(this.textBoxNacionalidade);
            this.groupBox2.Controls.Add(labelEmail);
            this.groupBox2.Controls.Add(labelNacionalidade);
            this.groupBox2.Controls.Add(labelNumCasa);
            this.groupBox2.Controls.Add(this.textBoxEstadoCivil);
            this.groupBox2.Controls.Add(this.textBoxNumCasa);
            this.groupBox2.Controls.Add(labelEstadoCivil);
            this.groupBox2.Controls.Add(labelRua);
            this.groupBox2.Controls.Add(this.textBoxRua);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 214);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFuncionario);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(this.buttonSalvarECadastrarNovo);
            this.Controls.Add(this.buttonSalvar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBoxFuncionario.ResumeLayout(false);
            this.groupBoxFuncionario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSalvarECadastrarNovo;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.TextBox textBoxRg;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.TextBox textBoxOrgExpeditor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNascimento;
        private System.Windows.Forms.TextBox textBoxNacionalidade;
        private System.Windows.Forms.TextBox textBoxEstadoCivil;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.TextBox textBoxNumCasa;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxUf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularUm;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularDois;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

