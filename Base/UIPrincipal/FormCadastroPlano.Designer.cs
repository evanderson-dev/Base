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
            this.planoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelarCadastroPlano = new System.Windows.Forms.Button();
            this.buttonSalvarPlano = new System.Windows.Forms.Button();
            this.textBoxIdPlano = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoPlano = new System.Windows.Forms.TextBox();
            this.textBoxValorPlano = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.panelCadstroPlanos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).BeginInit();
            this.panelCadstroPlanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // planoBindingSource
            // 
            this.planoBindingSource.DataSource = typeof(Model.Plano);
            // 
            // buttonCancelarCadastroPlano
            // 
            this.buttonCancelarCadastroPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarCadastroPlano.BackColor = System.Drawing.Color.White;
            this.buttonCancelarCadastroPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelarCadastroPlano.FlatAppearance.BorderSize = 0;
            this.buttonCancelarCadastroPlano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonCancelarCadastroPlano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCadastroPlano.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancelarCadastroPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCadastroPlano.Location = new System.Drawing.Point(387, 203);
            this.buttonCancelarCadastroPlano.Name = "buttonCancelarCadastroPlano";
            this.buttonCancelarCadastroPlano.Size = new System.Drawing.Size(80, 22);
            this.buttonCancelarCadastroPlano.TabIndex = 7;
            this.buttonCancelarCadastroPlano.Text = "CANCELAR";
            this.buttonCancelarCadastroPlano.UseVisualStyleBackColor = false;
            this.buttonCancelarCadastroPlano.Click += new System.EventHandler(this.buttonCancelarCadastroPlano_Click);
            // 
            // buttonSalvarPlano
            // 
            this.buttonSalvarPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalvarPlano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvarPlano.FlatAppearance.BorderSize = 0;
            this.buttonSalvarPlano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSalvarPlano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSalvarPlano.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSalvarPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarPlano.Location = new System.Drawing.Point(301, 203);
            this.buttonSalvarPlano.Name = "buttonSalvarPlano";
            this.buttonSalvarPlano.Size = new System.Drawing.Size(80, 22);
            this.buttonSalvarPlano.TabIndex = 6;
            this.buttonSalvarPlano.Text = "SALVAR";
            this.buttonSalvarPlano.UseVisualStyleBackColor = true;
            this.buttonSalvarPlano.Click += new System.EventHandler(this.buttonSalvarPlano_Click);
            // 
            // textBoxIdPlano
            // 
            this.textBoxIdPlano.Location = new System.Drawing.Point(103, 98);
            this.textBoxIdPlano.Name = "textBoxIdPlano";
            this.textBoxIdPlano.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdPlano.TabIndex = 8;
            // 
            // textBoxDescricaoPlano
            // 
            this.textBoxDescricaoPlano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricaoPlano.Location = new System.Drawing.Point(209, 98);
            this.textBoxDescricaoPlano.Name = "textBoxDescricaoPlano";
            this.textBoxDescricaoPlano.Size = new System.Drawing.Size(361, 20);
            this.textBoxDescricaoPlano.TabIndex = 9;
            // 
            // textBoxValorPlano
            // 
            this.textBoxValorPlano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValorPlano.Location = new System.Drawing.Point(576, 98);
            this.textBoxValorPlano.Name = "textBoxValorPlano";
            this.textBoxValorPlano.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPlano.TabIndex = 10;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(100, 82);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(52, 13);
            this.labelCodigo.TabIndex = 11;
            this.labelCodigo.Text = "CODIGO:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(206, 82);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(164, 13);
            this.labelDescricao.TabIndex = 12;
            this.labelDescricao.Text = "DESCRIÇÃO DO NOVO PLANO:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(573, 82);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(46, 13);
            this.labelValor.TabIndex = 13;
            this.labelValor.Text = "VALOR:";
            // 
            // panelCadstroPlanos
            // 
            this.panelCadstroPlanos.Controls.Add(this.textBoxDescricaoPlano);
            this.panelCadstroPlanos.Controls.Add(this.buttonCancelarCadastroPlano);
            this.panelCadstroPlanos.Controls.Add(this.buttonSalvarPlano);
            this.panelCadstroPlanos.Controls.Add(this.labelValor);
            this.panelCadstroPlanos.Controls.Add(this.textBoxIdPlano);
            this.panelCadstroPlanos.Controls.Add(this.labelDescricao);
            this.panelCadstroPlanos.Controls.Add(this.textBoxValorPlano);
            this.panelCadstroPlanos.Controls.Add(this.labelCodigo);
            this.panelCadstroPlanos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadstroPlanos.Location = new System.Drawing.Point(0, 0);
            this.panelCadstroPlanos.Name = "panelCadstroPlanos";
            this.panelCadstroPlanos.Size = new System.Drawing.Size(784, 238);
            this.panelCadstroPlanos.TabIndex = 14;
            // 
            // FormCadastroPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 238);
            this.Controls.Add(this.panelCadstroPlanos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroPlano";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.planoBindingSource)).EndInit();
            this.panelCadstroPlanos.ResumeLayout(false);
            this.panelCadstroPlanos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource planoBindingSource;
        private System.Windows.Forms.Button buttonCancelarCadastroPlano;
        private System.Windows.Forms.Button buttonSalvarPlano;
        private System.Windows.Forms.TextBox textBoxIdPlano;
        private System.Windows.Forms.TextBox textBoxDescricaoPlano;
        private System.Windows.Forms.TextBox textBoxValorPlano;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Panel panelCadstroPlanos;
    }
}