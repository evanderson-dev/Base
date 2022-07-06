
namespace UIPrincipal
{
    partial class FormCadastroPlano
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.planoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 48);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(106, 48);
            nomeUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(55, 13);
            nomeUsuarioLabel.TabIndex = 0;
            nomeUsuarioLabel.Text = "Descrição";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(423, 48);
            senhaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(31, 13);
            senhaLabel.TabIndex = 2;
            senhaLabel.Text = "Valor";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(9, 330);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(56, 26);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Sal&var";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(535, 330);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(56, 26);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoBindingSource, "Id", true));
            this.textBoxId.Location = new System.Drawing.Point(29, 64);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(76, 20);
            this.textBoxId.TabIndex = 9;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(109, 64);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(313, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planoBindingSource, "Valor", true));
            this.textBoxValor.Location = new System.Drawing.Point(425, 64);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.PasswordChar = '*';
            this.textBoxValor.Size = new System.Drawing.Size(122, 20);
            this.textBoxValor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "CADASTRO DE PLANOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planoBindingSource
            // 
            this.planoBindingSource.DataSource = typeof(Model.Plano);
            // 
            // FormCadastroPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroPlano";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource planoBindingSource;
    }
}

