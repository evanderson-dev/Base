
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSalvarECadastrarNovo = new System.Windows.Forms.Button();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.buttonCancelarCadastro = new System.Windows.Forms.Button();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.ForeColor = System.Drawing.Color.Black;
            nomeUsuarioLabel.Location = new System.Drawing.Point(19, 441);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(43, 13);
            nomeUsuarioLabel.TabIndex = 8;
            nomeUsuarioLabel.Text = "LOGIN:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.ForeColor = System.Drawing.Color.Black;
            cpfLabel.Location = new System.Drawing.Point(525, 7);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(30, 13);
            cpfLabel.TabIndex = 10;
            cpfLabel.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(19, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 13);
            label1.TabIndex = 11;
            label1.Text = "NOME COMPLETO:";
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
            this.ativoCheckBox.Location = new System.Drawing.Point(711, 21);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(52, 24);
            this.ativoCheckBox.TabIndex = 2;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Model.Usuario);
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.textBoxNomeUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(22, 457);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(429, 20);
            this.textBoxNomeUsuario.TabIndex = 3;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.textBoxCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCpf.Location = new System.Drawing.Point(528, 23);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(177, 20);
            this.textBoxCpf.TabIndex = 1;
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
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(23, 23);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(499, 20);
            this.textBoxNomeCompleto.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(457, 457);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(295, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.ForeColor = System.Drawing.Color.Black;
            labelSenha.Location = new System.Drawing.Point(454, 441);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new System.Drawing.Size(47, 13);
            labelSenha.TabIndex = 14;
            labelSenha.Text = "SENHA:";
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 561);
            this.Controls.Add(labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonCancelarCadastro);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.ativoCheckBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSalvarECadastrarNovo;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Button buttonCancelarCadastro;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.TextBox textBoxSenha;
    }
}

