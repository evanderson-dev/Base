namespace UIPrincipal
{
    partial class FormAddEnderecoServidor
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNomeServidor = new System.Windows.Forms.TextBox();
            this.textBoxNomeBanco = new System.Windows.Forms.TextBox();
            this.textBoxVersaoSQL = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelNomeServidor = new System.Windows.Forms.Label();
            this.labelNomeBanco = new System.Windows.Forms.Label();
            this.labelVersaoSQL = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNomeMaquinaPC = new System.Windows.Forms.Label();
            this.textBoxNomeMaquinaLocalOuIP = new System.Windows.Forms.TextBox();
            this.checkBoxAutenticacaoWindows = new System.Windows.Forms.CheckBox();
            this.groupBoxDadosLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosServidor = new System.Windows.Forms.GroupBox();
            this.checkBoxDiretorioLocal = new System.Windows.Forms.CheckBox();
            this.groupBoxDadosBancoSQL = new System.Windows.Forms.GroupBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.panelAddServidor = new System.Windows.Forms.Panel();
            this.groupBoxDadosLogin.SuspendLayout();
            this.groupBoxDadosServidor.SuspendLayout();
            this.groupBoxDadosBancoSQL.SuspendLayout();
            this.panelAddServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(749, 312);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNomeServidor
            // 
            this.textBoxNomeServidor.Location = new System.Drawing.Point(16, 91);
            this.textBoxNomeServidor.Name = "textBoxNomeServidor";
            this.textBoxNomeServidor.Size = new System.Drawing.Size(258, 20);
            this.textBoxNomeServidor.TabIndex = 0;
            // 
            // textBoxNomeBanco
            // 
            this.textBoxNomeBanco.Location = new System.Drawing.Point(9, 35);
            this.textBoxNomeBanco.Name = "textBoxNomeBanco";
            this.textBoxNomeBanco.Size = new System.Drawing.Size(130, 20);
            this.textBoxNomeBanco.TabIndex = 0;
            // 
            // textBoxVersaoSQL
            // 
            this.textBoxVersaoSQL.Location = new System.Drawing.Point(145, 35);
            this.textBoxVersaoSQL.Name = "textBoxVersaoSQL";
            this.textBoxVersaoSQL.Size = new System.Drawing.Size(122, 20);
            this.textBoxVersaoSQL.TabIndex = 1;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(9, 35);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(133, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(148, 35);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(190, 20);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelNomeServidor
            // 
            this.labelNomeServidor.AutoSize = true;
            this.labelNomeServidor.ForeColor = System.Drawing.Color.White;
            this.labelNomeServidor.Location = new System.Drawing.Point(16, 75);
            this.labelNomeServidor.Name = "labelNomeServidor";
            this.labelNomeServidor.Size = new System.Drawing.Size(120, 13);
            this.labelNomeServidor.TabIndex = 6;
            this.labelNomeServidor.Text = "NOME DO SERVIDOR:";
            // 
            // labelNomeBanco
            // 
            this.labelNomeBanco.AutoSize = true;
            this.labelNomeBanco.ForeColor = System.Drawing.Color.White;
            this.labelNomeBanco.Location = new System.Drawing.Point(6, 19);
            this.labelNomeBanco.Name = "labelNomeBanco";
            this.labelNomeBanco.Size = new System.Drawing.Size(101, 13);
            this.labelNomeBanco.TabIndex = 7;
            this.labelNomeBanco.Text = "NOME DO BANCO:";
            // 
            // labelVersaoSQL
            // 
            this.labelVersaoSQL.AutoSize = true;
            this.labelVersaoSQL.ForeColor = System.Drawing.Color.White;
            this.labelVersaoSQL.Location = new System.Drawing.Point(142, 19);
            this.labelVersaoSQL.Name = "labelVersaoSQL";
            this.labelVersaoSQL.Size = new System.Drawing.Size(125, 13);
            this.labelVersaoSQL.TabIndex = 8;
            this.labelVersaoSQL.Text = "VERSAO SQL SERVER:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(6, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(59, 13);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "USUARIO:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(145, 19);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(47, 13);
            this.labelSenha.TabIndex = 10;
            this.labelSenha.Text = "SENHA:";
            // 
            // labelNomeMaquinaPC
            // 
            this.labelNomeMaquinaPC.AutoSize = true;
            this.labelNomeMaquinaPC.ForeColor = System.Drawing.Color.White;
            this.labelNomeMaquinaPC.Location = new System.Drawing.Point(6, 19);
            this.labelNomeMaquinaPC.Name = "labelNomeMaquinaPC";
            this.labelNomeMaquinaPC.Size = new System.Drawing.Size(145, 13);
            this.labelNomeMaquinaPC.TabIndex = 12;
            this.labelNomeMaquinaPC.Text = "IP OU NOME DA MAQUINA:";
            // 
            // textBoxNomeMaquinaLocalOuIP
            // 
            this.textBoxNomeMaquinaLocalOuIP.Location = new System.Drawing.Point(9, 35);
            this.textBoxNomeMaquinaLocalOuIP.Name = "textBoxNomeMaquinaLocalOuIP";
            this.textBoxNomeMaquinaLocalOuIP.Size = new System.Drawing.Size(175, 20);
            this.textBoxNomeMaquinaLocalOuIP.TabIndex = 0;
            // 
            // checkBoxAutenticacaoWindows
            // 
            this.checkBoxAutenticacaoWindows.AutoSize = true;
            this.checkBoxAutenticacaoWindows.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutenticacaoWindows.Location = new System.Drawing.Point(9, 61);
            this.checkBoxAutenticacaoWindows.Name = "checkBoxAutenticacaoWindows";
            this.checkBoxAutenticacaoWindows.Size = new System.Drawing.Size(176, 17);
            this.checkBoxAutenticacaoWindows.TabIndex = 2;
            this.checkBoxAutenticacaoWindows.Text = "Usar Autenticação do Windows";
            this.checkBoxAutenticacaoWindows.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosLogin
            // 
            this.groupBoxDadosLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxDadosLogin.Controls.Add(this.checkBoxAutenticacaoWindows);
            this.groupBoxDadosLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxDadosLogin.Controls.Add(this.labelUsuario);
            this.groupBoxDadosLogin.Controls.Add(this.labelSenha);
            this.groupBoxDadosLogin.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosLogin.Location = new System.Drawing.Point(482, 132);
            this.groupBoxDadosLogin.Name = "groupBoxDadosLogin";
            this.groupBoxDadosLogin.Size = new System.Drawing.Size(344, 85);
            this.groupBoxDadosLogin.TabIndex = 3;
            this.groupBoxDadosLogin.TabStop = false;
            this.groupBoxDadosLogin.Text = "DADOS DE LOGIN";
            // 
            // groupBoxDadosServidor
            // 
            this.groupBoxDadosServidor.Controls.Add(this.checkBoxDiretorioLocal);
            this.groupBoxDadosServidor.Controls.Add(this.textBoxNomeMaquinaLocalOuIP);
            this.groupBoxDadosServidor.Controls.Add(this.labelNomeMaquinaPC);
            this.groupBoxDadosServidor.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosServidor.Location = new System.Drawing.Point(286, 132);
            this.groupBoxDadosServidor.Name = "groupBoxDadosServidor";
            this.groupBoxDadosServidor.Size = new System.Drawing.Size(190, 85);
            this.groupBoxDadosServidor.TabIndex = 2;
            this.groupBoxDadosServidor.TabStop = false;
            this.groupBoxDadosServidor.Text = "DADOS DA MAQUINA SERVIDOR";
            // 
            // checkBoxDiretorioLocal
            // 
            this.checkBoxDiretorioLocal.AutoSize = true;
            this.checkBoxDiretorioLocal.ForeColor = System.Drawing.Color.White;
            this.checkBoxDiretorioLocal.Location = new System.Drawing.Point(9, 61);
            this.checkBoxDiretorioLocal.Name = "checkBoxDiretorioLocal";
            this.checkBoxDiretorioLocal.Size = new System.Drawing.Size(119, 17);
            this.checkBoxDiretorioLocal.TabIndex = 1;
            this.checkBoxDiretorioLocal.Text = "Usar Diretorio Local";
            this.checkBoxDiretorioLocal.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosBancoSQL
            // 
            this.groupBoxDadosBancoSQL.Controls.Add(this.textBoxNomeBanco);
            this.groupBoxDadosBancoSQL.Controls.Add(this.labelNomeBanco);
            this.groupBoxDadosBancoSQL.Controls.Add(this.textBoxVersaoSQL);
            this.groupBoxDadosBancoSQL.Controls.Add(this.labelVersaoSQL);
            this.groupBoxDadosBancoSQL.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosBancoSQL.Location = new System.Drawing.Point(7, 132);
            this.groupBoxDadosBancoSQL.Name = "groupBoxDadosBancoSQL";
            this.groupBoxDadosBancoSQL.Size = new System.Drawing.Size(273, 85);
            this.groupBoxDadosBancoSQL.TabIndex = 1;
            this.groupBoxDadosBancoSQL.TabStop = false;
            this.groupBoxDadosBancoSQL.Text = "DADOS DO BANCO SQL";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(668, 312);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // panelAddServidor
            // 
            this.panelAddServidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddServidor.Controls.Add(this.buttonSalvar);
            this.panelAddServidor.Controls.Add(this.buttonCancelar);
            this.panelAddServidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddServidor.Location = new System.Drawing.Point(0, 0);
            this.panelAddServidor.Name = "panelAddServidor";
            this.panelAddServidor.Size = new System.Drawing.Size(834, 349);
            this.panelAddServidor.TabIndex = 18;
            // 
            // FormAddEnderecoServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 349);
            this.Controls.Add(this.groupBoxDadosBancoSQL);
            this.Controls.Add(this.groupBoxDadosServidor);
            this.Controls.Add(this.groupBoxDadosLogin);
            this.Controls.Add(this.labelNomeServidor);
            this.Controls.Add(this.textBoxNomeServidor);
            this.Controls.Add(this.panelAddServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEnderecoServidor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxDadosLogin.ResumeLayout(false);
            this.groupBoxDadosLogin.PerformLayout();
            this.groupBoxDadosServidor.ResumeLayout(false);
            this.groupBoxDadosServidor.PerformLayout();
            this.groupBoxDadosBancoSQL.ResumeLayout(false);
            this.groupBoxDadosBancoSQL.PerformLayout();
            this.panelAddServidor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNomeServidor;
        private System.Windows.Forms.TextBox textBoxNomeBanco;
        private System.Windows.Forms.TextBox textBoxVersaoSQL;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelNomeServidor;
        private System.Windows.Forms.Label labelNomeBanco;
        private System.Windows.Forms.Label labelVersaoSQL;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelNomeMaquinaPC;
        private System.Windows.Forms.TextBox textBoxNomeMaquinaLocalOuIP;
        private System.Windows.Forms.CheckBox checkBoxAutenticacaoWindows;
        private System.Windows.Forms.GroupBox groupBoxDadosLogin;
        private System.Windows.Forms.GroupBox groupBoxDadosServidor;
        private System.Windows.Forms.CheckBox checkBoxDiretorioLocal;
        private System.Windows.Forms.GroupBox groupBoxDadosBancoSQL;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel panelAddServidor;
    }
}