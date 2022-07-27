namespace UIPrincipal
{
    partial class FormTipoChamado
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
            this.tipoChamadoDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoChamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCadastroTipoChamado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoChamadoDataGridView
            // 
            this.tipoChamadoDataGridView.AutoGenerateColumns = false;
            this.tipoChamadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoChamadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricaoDataGridViewTextBoxColumn});
            this.tipoChamadoDataGridView.DataSource = this.tipoChamadoBindingSource;
            this.tipoChamadoDataGridView.Location = new System.Drawing.Point(12, 95);
            this.tipoChamadoDataGridView.Name = "tipoChamadoDataGridView";
            this.tipoChamadoDataGridView.ReadOnly = true;
            this.tipoChamadoDataGridView.RowHeadersVisible = false;
            this.tipoChamadoDataGridView.Size = new System.Drawing.Size(264, 298);
            this.tipoChamadoDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "TIPO DE CHAMADO";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoChamadoBindingSource
            // 
            this.tipoChamadoBindingSource.DataSource = typeof(Model.TipoChamado);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 45);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(279, 4);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 37);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "&CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(190, 4);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 37);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "&SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSair.Location = new System.Drawing.Point(457, 4);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(84, 37);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(368, 4);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(85, 37);
            this.buttonExcluir.TabIndex = 6;
            this.buttonExcluir.Text = "&EXCLUIR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(101, 4);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(85, 37);
            this.buttonAlterar.TabIndex = 1;
            this.buttonAlterar.Text = "ALTERAR";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 4);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(85, 37);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "&NOVO";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(212, 70);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(65, 19);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 70);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(196, 20);
            this.textBoxBuscar.TabIndex = 0;
            this.textBoxBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyDown);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoChamadoBindingSource, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(352, 95);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.ReadOnly = true;
            this.textBoxDescricao.Size = new System.Drawing.Size(189, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TIPO DE CHAMADO:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(293, 79);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoChamadoBindingSource, "Id", true));
            this.textBoxId.Location = new System.Drawing.Point(296, 95);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(50, 20);
            this.textBoxId.TabIndex = 4;
            this.textBoxId.Text = "0";
            // 
            // labelCadastroTipoChamado
            // 
            this.labelCadastroTipoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroTipoChamado.Location = new System.Drawing.Point(12, 9);
            this.labelCadastroTipoChamado.Name = "labelCadastroTipoChamado";
            this.labelCadastroTipoChamado.Size = new System.Drawing.Size(529, 49);
            this.labelCadastroTipoChamado.TabIndex = 6;
            this.labelCadastroTipoChamado.Text = "CADASTRO DE TIPO DE CHAMADO";
            this.labelCadastroTipoChamado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTipoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 442);
            this.Controls.Add(this.labelCadastroTipoChamado);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tipoChamadoDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTipoChamado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTipoChamado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoChamadoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tipoChamadoDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource tipoChamadoBindingSource;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelCadastroTipoChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}